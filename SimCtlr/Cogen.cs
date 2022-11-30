using SimMesg;
using System.Data;
using System.Diagnostics;
using System.IO.Ports;
using System.Xml.Linq;

namespace SimCtlr
{
    // Cogen이 보내는 메시지에 대해 연료전지가 응답하는 기능
    // 응답 메시지에는 연료전지의 상태 뿐만 아니라 Cogen 제어 명령(FC#1 Only)도 들어간다.
    public partial class Cogen : Form
    {
        private DataTable tblCogen = new DataTable("DtCogen");
        private DataTable tblFCell = new DataTable("DtFCell");

        private SerialPort serialPort = new SerialPort();
        private List<byte> rxData = new List<byte>();

        private CogenMessage cogenMesg = new CogenMessage();
        private string[] cogenTxTags = new string[] { "Pmp01Des" };

        public Cogen()
        {
            InitializeComponent();
        }

        private void SetupDataTable()
        {
            // initialize DataTable
            // set table columns
            string[] colName = { "Name", "Value", "Description" };
            string[] colType = { "System.String", "System.Object", "System.String" };
            // for tblCogen
            for (int i = 0; i < colName.Length; i++)
            {
                DataColumn col = new DataColumn(colName[i], dataType: Type.GetType(colType[i]) ?? typeof(String));
                tblCogen.Columns.Add(col);
            }
            // for searching, filtering
            tblCogen.PrimaryKey = new DataColumn[] { (tblCogen.Columns["Name"] ?? tblCogen.Columns[0]) };
            DgvCogen.DataSource = tblCogen;

            // for tblFCell
            for (int i = 0; i < colName.Length; i++)
            {
                DataColumn col = new DataColumn(colName[i], dataType: Type.GetType(colType[i]) ?? typeof(String));
                tblFCell.Columns.Add(col);
            }
            tblFCell.PrimaryKey = new DataColumn[] { tblFCell.Columns["Name"] ?? tblFCell.Columns[0] };
            DgvFC.DataSource = tblFCell;
        }

        private void Cogen_Load(object sender, EventArgs e)
        {
            // set up DataTable
            SetupDataTable();

            string[] tags = CogenMessage.GetCogenTagList();
            foreach(string tag in tags)
            {
                tblCogen.Rows.Add(new object[] { tag, 0 });
            }

            tags = CogenMessage.GetFCellTagList();
            foreach (string tag in tags)
            {
                tblFCell.Rows.Add(new object[] { tag, 0 });
            }

            // 시리얼포트
            RefreshPorts();
            serialPort.DataReceived += SerialPort_DataReceived;
            try
            {
                serialPort.PortName = "COM1";
                serialPort.BaudRate = 9600;
                serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;
                serialPort.Handshake = Handshake.None;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Port config error, " + ex.Message);
            }
        }

        private void RefreshPorts()
        {
            // show list of valid com ports
            PortList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                PortList.Items.Add(s);
            }

            // find index
            PortList.SelectedIndex = -1;
            for (int i = 0; i < PortList.Items.Count; i++)
            {
                if (PortList.Items[i].ToString() == "COM1")
                {
                    PortList.SelectedIndex = i;
                    break;
                }
            }
            if (PortList.Items.Count > 0 && PortList.SelectedIndex == -1)
                PortList.SelectedIndex = 0;
        }

        private void PortOpen_Click(object sender, EventArgs e)
        {
            //dgvSigValuesFilter();

            if (PortOpen.Text == "Open")
            {
                if (PortList.Items.Count < 1)
                {
                    Debug.WriteLine("serial port is not found");
                    return;
                }
                try
                {
                    serialPort.PortName = (string)PortList.SelectedItem;
                    Serial_Start();
                    PortOpen.Text = "Close";
                    PortList.Enabled = false;
                    Debug.WriteLine(serialPort.PortName + " is opened ... ");

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(serialPort.PortName + " open Error, " + ex.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    Serial_Stop();
                    PortOpen.Text = "Open";
                    PortList.Enabled = true;
                    Debug.WriteLine(serialPort.PortName + " is closed ... ");

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(serialPort.PortName + " close Error, " + ex.Message);
                    return;
                }
            }
        }
        void Serial_Start()
        {
            try
            {
                if (serialPort.IsOpen)
                    serialPort.Close();

                serialPort.Open();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Port open error , : " + ex.Message);
                throw;
            }
        }

        void Serial_Stop()
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        internal void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serialPort.BytesToRead == 0)
                    return;

                // read byte until message completed or timeout
                bool isReceiving = rxData.Count > 0 ? true : false;
                int readByte = serialPort.ReadByte();
                while (!isReceiving && readByte >= 0 && readByte != CogenMessage.STX)
                {
                    // will be dropped
                    rxData.Add((byte)readByte);
                    readByte = serialPort.ReadByte();
                }
                if (readByte != CogenMessage.STX)
                {
                    Debug.WriteLine("invalid request from Cogen, data={0}", BitConverter.ToString(rxData.ToArray()));
                    rxData.Clear();
                    return;
                }

                // read byte until message completed(ETX) or timeout
                rxData.Add((byte)readByte);
                while (readByte >= 0 && readByte != CogenMessage.ETX)
                {
                    rxData.Add((byte)readByte);
                    readByte = (byte)serialPort.ReadByte();
                }
                // ETX까지 수신하지 못했으면 return
                if (readByte != CogenMessage.STX)
                {
                    Debug.WriteLine("receiving from Cogen, data={0}", BitConverter.ToString(rxData.ToArray()));
                    return;
                }

                // ETX까지 수신했는데, validtation error이면 버리고 return
                // Check Length, Checksum
                if (cogenMesg.MakeCheckSum(rxData.ToArray()) != 0)
                {
                    Debug.WriteLine("invalid checksum from FCell, data={0}", BitConverter.ToString(rxData.ToArray()));
                    return;
                }

                // handle received message
                Dictionary<string, ValueType> dicVals =
                    cogenMesg.ParseFCellResponse(rxData.GetRange(4, 4).ToArray());

                // update datasource
                foreach (var kv in dicVals)
                {
                    SetTagValue(ref tblCogen, kv.Key, kv.Value);
                }

                // raise event(optional)

                // make response message

                // TODO 하나는 처리했으니 나머지 밀린 데이터가 있으면 모두 읽어서 버린다.

            }
            catch (Exception ex)
            {
                Debug.WriteLine("can't handle message, rx={0}, ex={1}", rxData, ex.Message);
            }
        }

        private void SetTagValue(ref DataTable tbl, string tag, object value)
        {
            DataRow? row = tbl.Rows.Find(tag);
            if (row is not null)
            {
                if (row[1] is int)
                {
                    row[1] = (int)value;
                }
                else if (row[1] is double)
                {
                    row[1] = (double)value;
                }
                else
                {
                    Debug.Print("invalid value {0} of tag {1}", row[1].ToString(), tag);
                }
            }
        }

        private double GetTagValue(DataTable tbl, string tag)
        {
            double value = 0;
            DataRow? row = tbl.Rows.Find(tag);
            if (row is not null)
            {
                if (row[1] is int)
                {
                    value = (int)row[1];
                }
                else if (row[1] is double)
                {
                    value = (double)row[1];
                }
            }
            return value;
        }
    }
}