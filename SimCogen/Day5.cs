using System.Data;
using System.Diagnostics;
using System.IO.Ports;
using Timer = System.Windows.Forms.Timer;
using SimMesg;

namespace SimCogen
{
    public partial class Day5 : Form
    {
        private DataTable tblCogen = new DataTable("DtCogen");
        private DataTable[] tblFCell = new DataTable[6];
        private Timer updateTimer = new Timer();
        private Timer sendTimer = new Timer();
        private SerialPort serialPort = new SerialPort();
        private int TnkLevel = 0;
        private int TnkHeight = 0;
        private Point TnkPosition;

        private List<byte> rxData = new List<byte>();
        private CogenMessage cogenMesg= new CogenMessage();
        private string[] cogenTxTags= new string[] {"Pmp01Des"};

        public Day5()
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
        }

        private void LoadDataTable()
        {
            // 파일에서 읽어오기
            //string fileFullName = "config/init-data-cogen.txt";
            // open property file
            //Property prop = new(fileFullName);

            // update DataGridView directly
            //foreach (DataGridViewRow row in DgvCogen.Rows)
            //{
            //    // get tag value
            //    string tag = (string)row.Cells[3].Value;
            //    if (String.IsNullOrEmpty(tag))
            //    {
            //        row.Cells[1].Value = "0";
            //    }
            //    else
            //    {
            //        row.Cells[1].Value = prop.Get(tag, "0");
            //    }
            //}

            // 기본값 설정하기
            tblCogen.Rows.Add(new object[] { "cogenFwVer", "" });
            tblCogen.Rows.Add(new object[] { "tCogenTnkHigh", (double)45.3 });
            tblCogen.Rows.Add(new object[] { "tCogenTnkMid", (double)40.5 });
            tblCogen.Rows.Add(new object[] { "tCogenTnkLow", (double)35.1 });
            tblCogen.Rows.Add(new object[] { "pCogenRadLoop", (double)0 });
            tblCogen.Rows.Add(new object[] { "tCogenWtrCold", (double)0 });
            tblCogen.Rows.Add(new object[] { "pCogenWtrCold", (double)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenPmpColdMode", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenPmpColdEn", (byte)0 });
            tblCogen.Rows.Add(new object[] { "rCogenPmpColdDes", (double)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenFanMode", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenFan12", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenFan34", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenFan56", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenVlvTnkSupply", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenVlvTnkSplMode", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenVlvDrain", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenLvlHigh", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenLvlMid", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenLvlLow", (byte)0 });
            tblCogen.Rows.Add(new object[] { "pCogenWtrCustIn", (double)0 });
            tblCogen.Rows.Add(new object[] { "tCogenWtrCustOut", (double)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenVlvHotMode", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenVlvHotOut", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenPmpHotMode", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenPmpHotEn", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenSysRun1", (byte)1 });
            tblCogen.Rows.Add(new object[] { "swtCogenSysRun2", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenSysRun3", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenSysRun4", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenSysRun5", (byte)0 });
            tblCogen.Rows.Add(new object[] { "swtCogenSysRun6", (byte)1 });
            tblCogen.Rows.Add(new object[] { "swtCogenSysRun7", (byte)0 });
        }

        private void Day5_Load(object sender, EventArgs e)
        {
            // set up DataTable
            SetupDataTable();

            // set up PictureBox
            List<PictureBox> picList = new();
            picList.AddRange(this.Controls.OfType<PictureBox>());
            foreach (PictureBox pb in picList)
            {
                if (pb.Name.StartsWith("Pic"))
                {
                    Debug.WriteLine($"PicBox Name={pb.Name}");

                    // set transparent of background
                    pb.Parent = CogenBG;    // Form의 Child Controls에 영향을 주므로 직접 접근하지 않고 복사해 놓고 사용한다.
                    pb.Location = new Point(pb.Location.X - CogenBG.Location.X, pb.Location.Y - CogenBG.Location.Y);

                    // add event handler
                    pb.Click += new EventHandler(PictureBox_Click);
                }
                else
                {
                    Debug.WriteLine($"PicOther Name={pb.Name}");
                }
            }

            // set up TextBox
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Name.StartsWith("Txt"))
                {
                    Debug.WriteLine($"TextBox Name={tb.Name}");

                    // add event handler
                    //tb.TextChanged += new EventHandler(TextBox_TextChanged);
                    tb.KeyDown += new KeyEventHandler(TextBox_KeyDown);
                }
                else
                {
                    Debug.WriteLine($"TxtOther Name={tb.Name}");
                }
            }
            this.TnkHeight = TankLevel.Height;
            this.TnkPosition = TankLevel.Location;

            // ComboBox 초기화
            // design time에 입력한 item을 제거한다.
            this.FcID.Items.Clear();
            // configuration에 따라 FC의 개수만큼 설정한다.
            List<string> fcList = new() { "01", "02", "03", "04", "05", "06", "07" };
            this.FcID.Items.AddRange(fcList.ToArray());
            this.FcID.SelectedIndex = 0;

            // Loading된 데이터로 초기화한다.
            LoadDataTable();

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

            // 화면을 업데이트하기 위해 Timer를 활성화한다.
            updateTimer.Interval = 500;
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Enabled = true;
            updateTimer.Start();

            sendTimer.Interval = 1000;
            sendTimer.Tick += SendTimer_Tick;
        }

        private void UpdateTimer_Tick(object? sender, EventArgs e)
        {
            Day5_Refresh();
        }

        private void SendTimer_Tick(object? sender, EventArgs e)
        {
            Dictionary<string, int> values = new Dictionary<string, int>();
            // TODO add key/value from dataTable
            values.Add("Fan1", 0);

            byte[] txData = cogenMesg.MakeReqData(values);
            byte.TryParse(FcID.Text, out byte idFc);
            byte[] txMesg = cogenMesg.MakeReqMessage(idFc, txData);
            serialPort.Write(txData, 0, txData.Length);
        }

        private void UpdatePicBoxes(object picParent)
        {
            if (picParent == null)
                return;

            PictureBox? pa = picParent as PictureBox;
            if (pa == null)
                return;

            foreach (var c in pa.Controls)
            {
                if (c is PictureBox pb)
                {
                    if (!pb.Name.StartsWith("Pic"))
                        continue;
                    
                    // check value -> update control
                    string name = pb.Name[3..];
                    double state = GetTagValue(name);

                    // set image by state
                    if (state > 0)
                    {
                        pb.BackgroundImage = Properties.Resources.dot_green;
                    }
                    else
                    {
                        pb.BackgroundImage = Properties.Resources.dot_red;
                    }
                }
            } // end of foreach
        }

        private void Day5_Refresh()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox tb)
                {
                    // 입력중이면 skip
                    if (tb.Focused)
                        continue;

                    if (tb.Name.StartsWith("Txt"))
                    {
                        string name = tb.Name[3..];
                        if (name == "FwVer")
                        {
                            //tb.Text = (string)row[1];   // value
                        }
                        else
                        {
                            tb.Text = GetTagValue(name).ToString();
                        }
                    }
                }
                else if (c is PictureBox pb)
                {
                    UpdatePicBoxes(pb);
                }
                else if (c is Button btn)
                {
                    if (btn.Name == "TankLevel")
                    {
                        double H = GetTagValue("swtCogenLvlHigh");
                        double M = GetTagValue("swtCogenLvlMid");
                        double L = GetTagValue("swtCogenLvlLow");
                        int resize = 0;
                        if (H > 0)
                        {
                            btn.Location = new Point(TnkPosition.X, TnkPosition.Y);
                            btn.Height = this.TnkHeight;
                        } else if (M > 0)
                        {
                            resize = (int)(this.TnkHeight * 0.25);
                        } else if (L > 0)
                        {
                            resize = (int)(this.TnkHeight * 0.5);
                        } else
                        {
                            resize = (int)(this.TnkHeight * 0.8);
                        }
                        btn.Location = new Point(TnkPosition.X, TnkPosition.Y + resize);
                        btn.Height = this.TnkHeight - resize;
                    }
                }
                else
                {
                    // ignore the other controls
                }
            } // end of foreach
        }

        //private void TextBox_TextChanged(object? sender, EventArgs e)
        //{
        //    if (sender is not TextBox txtBox)
        //        return;

        //    string name = txtBox.Name[3..];
        //    Debug.WriteLine($"TextBox {name} = {txtBox.Text}");

        //    Double value;
        //    bool isOk = Double.TryParse((string)txtBox.Text, out value);
        //    if (!isOk)
        //    {
        //        Debug.Print("invalid value {0}", txtBox.Text);
        //        return;
        //    }

        //    // update on DataTable
        //    DataRow? row = tblCogen.Rows.Find(name);
        //    if (row is not null)
        //    {
        //        row[1] = txtBox.Text;
        //    }
        //}

        private void TextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (sender is not TextBox txtBox)
                return;

            if (e.KeyCode== Keys.Enter)
            {
                string name = txtBox.Name[3..];
                Debug.WriteLine($"TextBox {name} = {txtBox.Text}");

                // update on DataTable
                if (name == "FwVer")
                {
                    SetTagValue(name, txtBox.Text);
                }
                else
                {
                    bool isOk = double.TryParse((string)txtBox.Text, out double value);
                    if (isOk)
                    {
                        SetTagValue(name, value);
                    }
                    else {
                        Debug.Print("invalid value {0}", txtBox.Text);
                        return;
                    }
                }

                // set lost focus
                this.ActiveControl = null;
            }
        }

        private void PictureBox_Click(object? sender, EventArgs e)
        {
            if (sender is not PictureBox picBox)
                return;

            string name = picBox.Name[3..];

            // get current state --> toggle as new state
            double state = GetTagValue(name);
            // toggle
            byte st = (byte)(state > 0 ? 0 : 1);
            SetTagValue(name, st);
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
        private void PortRefresh_Click(object sender, EventArgs e)
        {
            RefreshPorts();
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

                    // start sending timer
                    sendTimer.Enabled = true;
                    sendTimer.Start();
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

                    // stop sending timer
                    sendTimer.Enabled = false;
                    sendTimer.Stop();
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

        internal void SendRequest(string txData)
        {
            if (!serialPort.IsOpen)
            {
                Debug.WriteLine("device port is not open");
                return;
            }

            // create & send request message
            try
            {
                serialPort.WriteLine(txData);
                Debug.WriteLine("TX: {0:000}, {1}", txData.Length, txData);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("fail to send a message. ex={0}", ex.Message);
            }
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
                    Debug.WriteLine("invalid response from FCell, data={0}", BitConverter.ToString(rxData.ToArray()));
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
                    Debug.WriteLine("receiving from FCell, data={0}", BitConverter.ToString(rxData.ToArray()));
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
                    SetTagValue(kv.Key, kv.Value);
                }

                // raise event(optional)

                // TODO 하나는 처리했으니 나머지 밀린 데이터가 있으면 모두 읽어서 버린다.

            }
            catch (Exception ex)
            {
                Debug.WriteLine("can't handle message, rx={0}, ex={1}", rxData, ex.Message);
            }
        }

        private void SetTagValue(string tag, object value)
        {
            DataRow? row = tblCogen.Rows.Find(tag);
            if (row is not null)
            {
                row[1] = value;
            }
        }

        private double GetTagValue(string tag)
        {
            double value = 0;
            DataRow? row = tblCogen.Rows.Find(tag);
            if (row is not null)
            {
                if (row[1] is byte)
                {
                    value = (byte)row[1];
                } else if (row[1] is double)
                {
                    value = (double)row[1];
                } else if (row[1] is string)
                {
                   double.TryParse((string)row[1], out value);
                } else
                {
                    Debug.Print("invalid value {0}", row[1].ToString());
                }
            }
            return value;
        }

        private void TankLevel_Click(object sender, EventArgs e)
        {
            TnkLevel = (TnkLevel + 1) % 4;
            byte L, M, H;
            L = M = H = 0;
            if (TnkLevel > 0)
                L = 1;
            if (TnkLevel > 1)
                M = 1;
            if (TnkLevel > 2)
                H = 1;

            SetTagValue("swtCogenLvlHigh", H);
            SetTagValue("swtCogenLvlMid", M);
            SetTagValue("swtCogenLvlLow", L);
        }

    }
}
