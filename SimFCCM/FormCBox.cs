using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinFormsUI.Docking;
using System.Xml.Serialization;
using System.Collections.Generic;
using log4net;
using System.IO.Ports;
using FcpUtils;
using System.Threading;
using System.Linq;
using System.Text;

namespace CBoxSim {
    public partial class FormCBox : DockContent
    {
        // static members --------------------
        static readonly ILog log = LogManager.GetLogger("Console");
        static readonly ILog sys = LogManager.GetLogger("NetOpen");

        // dic(address, addressInfo))
        static SortedDictionary<int, MemoryMap.AddressInfo> dicTagInfos
            = new SortedDictionary<int, MemoryMap.AddressInfo>();

        // private members --------------------
        SockClientTCP _tcpClient = new SockClientTCP();
        string _savedPath;
        List<byte> _rxBuffer = new List<byte>();
        
        public FormCBox()
        {
            InitializeComponent();

            // delegate의 구현체를 가지고 delegate 함수를 생성해 event handler로 등록한다.
            _tcpClient.Connected += new SockClientTCP.ConnectedEvent(TcpClient_Connected);
            _tcpClient.Disconnected += new SockClientTCP.DisconnectedEvent(TcpClient_Disconnected);
            _tcpClient.DataReceived += new SockClientTCP.DataReceivedEvent(TcpClient_DataRecieved);
        }

        delegate void ConnectHandler(object sender);
        private void TcpClient_Connected(object sender)
        {
            if (this.btnConnect.InvokeRequired)
            {
                ConnectHandler d = new ConnectHandler(TcpClient_Connected);
                this.Invoke(d, this);
                return;
            }
            btnConnect.Text = "연결해제";
            log.Debug("client is connected to " + _tcpClient.IPAddress + ":" + _tcpClient.Port);
            picConnState.Image = Properties.Resources.dot_green;
        }

        delegate void DiconnectHandler(object sender);
        private void TcpClient_Disconnected(object sender)
        {
            if (this.btnConnect.InvokeRequired)
            {
                DiconnectHandler d = new DiconnectHandler(TcpClient_Disconnected);
                this.Invoke(d, this);
                return;
            }

            btnConnect.Text = "연결";
            log.Debug("client is disconnected from " + _tcpClient.IPAddress + ":" + _tcpClient.Port);
            picConnState.Image = Properties.Resources.dot_red;
        }

        // TODO
        private void TcpClient_DataRecieved(object sender, byte[] recvData)
        {
            if (sender == null || !(sender is SockClientTCP) || _tcpClient == null)
            {
                log.Error("tcp client is invalid");
                return;
            }

            try
            {
                sys.InfoFormat("RX: {0:000}, {1}", _rxBuffer.Count, BitConverter.ToString(recvData));
                // 1. find STX, CMD, CMD_DATA
                byte cmd = 0, cmdData = 0;
                for (int i=0; i < recvData.Length; i++)
                {
                    if (recvData[i] != CBoxMessage.GetSTX())
                        continue;

                    if (i+2 <= recvData.Length) {
                        cmd = recvData[i + 1];
                        cmdData = recvData[i + 2];
                        break;
                    }
                }

                // 2. handle request
                if (cmd == CBoxMessage.REQ_CTRL)
                {
                    // start or stop system
                    log.Warn(" --- request of system on/off, ctrl-cmd=" + cmdData + " ---");
                } else
                {
                    // make response message
                    byte[] txData = CBoxMessage.MakeResponse(cmd, cmdData, dicTagInfos);
                    if (txData.Length > 0)
                    {
                        //TODO serialPort.Write(txData, 0, txData.Length);
                        //_tcpClient.Send(txData);
                        ((SockClientTCP)sender).Send(txData);
                        sys.InfoFormat("TX: {0:000}, {1}", txData.Length, BitConverter.ToString(txData));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Info("can't handle request, ex=" + ex.Message);
            }
        }

        // 화면에서 수정한 값이 유효한지 체크한다.
        private void DgvData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!(sender is DataGridView))
                return;

            // Value 필드가 아니면 무시한다.
            if (e.ColumnIndex != 1)
                return;
            
            // empty value는 허용한다.
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                return;
                
            // empty가 아닌 경우 값의 숫자인지 체크한다.
            bool isOk = decimal.TryParse(e.FormattedValue.ToString(), out decimal value);
            if (!isOk)
            {
                //DgvData.Rows[e.RowIndex].ErrorText = "Number is required & not be empty";
                log.Info("cell value is validating. invalid input=" + e.FormattedValue.ToString() + ", number is required");
                e.Cancel = true;
            }
        }

        // 화면에서 수정한 값을 MemMap에 반영한다.
        private void DgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!(sender is DataGridView))
                return;

            DataGridView grid = (DataGridView)sender;
            if (grid.SelectedCells.Count == 0)
                return;

            int colindex = grid.SelectedCells[0].ColumnIndex;
            if (colindex != 1) // selected column: not 'value'
                return;
            int rowindex = grid.SelectedCells[0].RowIndex;

            // get changed value of selected address
            int address = 0;
            try
            {
                address = int.Parse(grid.Rows[rowindex].Cells[0].Value.ToString()); // first column: 'address'
                // TODO dicTagInfos의 data type을 보고 value를 처리하는 방법이 달라야 한다.
                // value가 int type이 아니라 float type일 수도 있다.
                int iValue;
                double fValue;
                switch (dicTagInfos[address].DataType)
                {
                    case "b08":
                    case "b16":
                        iValue = int.Parse(grid.SelectedCells[0].Value.ToString());
                        dicTagInfos[address].Value = iValue.ToString();
                        break;
                    case "f32":
                    case "f64":
                        fValue = double.Parse(grid.SelectedCells[0].Value.ToString());
                        dicTagInfos[address].Value = (fValue * dicTagInfos[address].Scale).ToString();
                        break;
                    default:
                        fValue = double.Parse(grid.SelectedCells[0].Value.ToString());
                        dicTagInfos[address].Value = ((int)(fValue * dicTagInfos[address].Scale)).ToString();
                        break;
                }
                log.Debug("CellValue updated, address=" + address + ", value=" + dicTagInfos[address].Value);
            }
            catch (Exception ex)
            {
                log.Error("CellValue error, address=" + address + ", ex=" + ex.Message);
                //throw new ApplicationException("invalid input data");
            }
            //RefreshMemMapItem(address);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CBoxConfig config = ConfigInfo.GetInstance().config;

            // server info
            ServerIP.Text = config.network.IP;
            ServerPort.Text = config.network.Port;
            // connection state
            picConnState.Image = Properties.Resources.dot_red;

            // protocol info
            cboProtocol.Items.Add(config.network.Protocol);
            cboProtocol.SelectedIndex = 0;
            mapName.Text = config.mapFile;
            CBoxMessage.Protocol = config.network.Protocol;

            // load memory map
            LoadMemoryMap(config.mapFile);
            RefreshMemMapView();
        }

        // map file --> tagInfos
        private void LoadMemoryMap(string mapFile)
        {
            // load register info on dictionary
            dicTagInfos.Clear();
            log.Debug("memmap load, map file=" + mapFile);

            try
            {
                // load modbus map
                XmlSerializer serializer = new XmlSerializer(typeof(MemoryMap));
                TextReader reader = new StreamReader(Application.StartupPath + "/maps/" + mapFile);
                MemoryMap map = (MemoryMap)serializer.Deserialize(reader);
                reader.Close();

                foreach (var g in map.registers)
                {
                    foreach (var r in g.Register)
                    {
                        try
                        {
                            // register의 상대주소를 절대주소로 변환해서 Dictionary에 담는다.
                            r.Address += g.BaseAddress;
                            // default 값은 0으로 설정한다.
                            r.Value = "0";
                            dicTagInfos.Add(r.Address, r);
                            log.Debug("memmap, regType=" + g.RegType + ", addr=" + (g.BaseAddress + r.Address) + " --> " + r.Tag);
                        }
                        catch (System.Exception e)
                        {
                            log.Error("memmap, regType=" + g.RegType + ", addr=" + (g.BaseAddress + r.Address) + ", ex=" + e.Message);
                        }
                    }
                }
            }
            catch (System.Exception e1)
            {
                log.Debug("MemoryMap file loading error, map:" + mapFile + ", " + e1.Message);
            }
        }

        private void Form_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            ((MainForm)this.ParentForm).ShowHelp("ToolModbusClient");
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConnect.Text == "연결")
                {
                    _tcpClient.IPAddress = ServerIP.Text;
                    _tcpClient.Port = UInt16.Parse(ServerPort.Text);
                    _tcpClient.ReadTimeout = 1000; //ms
                    _tcpClient.Connect();
                }
                else
                {
                    _tcpClient.Close();
                }
            }
            catch (Exception e1)
            {
                log.Error("Connection Error, " + _tcpClient.IPAddress + ":" + _tcpClient.Port + ", " + e1.Message);
                return;
            }
        }

        // 값변경 항목들을 일괄처리할 때 사용함
        //private void DgvData_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        //{
        //    DataGridView dgview = (DataGridView)sender;
        //    dgview.CurrentRow.HeaderCell.Value = "*";
        //}

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            // create dialog
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "데이터 파일 선택",
                //ofd.FileName = "";
                Filter = "데이터 파일 (*.prop, *.txt, *.data) | *.prop; *.txt; *.data; | 모든 파일 (*.*) | *.*"
            };
            if (!String.IsNullOrEmpty(_savedPath))
                ofd.InitialDirectory = _savedPath;
            else
                ofd.InitialDirectory = Application.StartupPath;

           // show
            DialogResult dr = ofd.ShowDialog();
            // check button
            if (dr != DialogResult.OK)
                return;

            // get file name with path
            string fileFullName = ofd.FileName;
            // get file name
            string fileName = ofd.SafeFileName;
            // get file path only
            _savedPath = fileFullName.Replace(fileName, "");

            // open property file
            Property prop = new Property(fileFullName);

            // update tagInfos
            foreach (var kv in dicTagInfos)
            {
                // kv.Key: Address
                // kv.Value: AddressInfo
                bool isOk = decimal.TryParse(prop.Get(kv.Value.Tag, "0"), out decimal result);
                if (isOk)
                    kv.Value.Value =  ((int)(result * kv.Value.Scale)).ToString();

            }
            // refresh dgView from tagInfos
            RefreshMemMapView();

            //foreach (DataGridViewRow row in DgvData.Rows)
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
        }

        /// dicTagInfos --> 화면 Update
        void RefreshMemMapView()
        {
            DgvData.Rows.Clear();

            // from dicTagInfos
            MemoryMap.AddressInfo info = new MemoryMap.AddressInfo();
            foreach (int addr in dicTagInfos.Keys.ToList())
            {
                // check map binding
                bool found = dicTagInfos.TryGetValue(addr, out info);
                if (!found)
                {
                    //dgvData.Rows.Add(ai, value, serverResponse[i].ToString("X4"), type, format, scale, tag, desc);
                    continue;
                }

                if (info.DataType == "b08" || info.DataType == "b16")
                {
                    //dgvData.Rows.Add(addrOffset + addrFrom + i, value, serverResponse[i].ToString("X4"), type, format, scale, tag, desc);
                    //int mask = 1;
                    //for (int pos = 0; pos < 16; pos++)
                    //{
                    //    bool flag = (serverResponse[i] & (mask << pos)) > 0 ? true : false;
                    //    dgvData.Rows.Add(i + ":" + pos, flag, "", "", "", "", "", "");
                    //    if (flag)
                    //        dgvData[1, i + pos + 1].Style.BackColor = Color.Yellow;
                    //    else
                    //        dgvData[1, i + pos + 1].Style.BackColor = Color.LightGreen;
                    //}
                    log.Error("not implemented");
                    throw new NotImplementedException();
                }
                else
                {
                    // add data
                    DgvData.Rows.Add(info.Address, (decimal.Parse(info.Value)/info.Scale).ToString(), info.Scale, info.Tag, info.Description);
                }
            }
        }

        /// dicTagInfos(지정된 항목) --> 화면 Update
        private void RefreshMemMapItem(int address)
        {
            // 업데이트하려는 주소의 데이터 존재 여부 확인
            MemoryMap.AddressInfo info = new MemoryMap.AddressInfo();
            bool found = dicTagInfos.TryGetValue(address, out info);
            if (!found)
            {
                return;
            }

            if (info.DataType == "b08" || info.DataType == "b16")
            {
                log.Error("not implemented, dataType=b08, b16");
                throw new NotImplementedException();
            }

            // 해당되는 주소를 화면에서 찾아 업데이트
            foreach (DataGridViewRow row in DgvData.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(address.ToString()))
                {
                    // TODO Data Type에 따라 다르게 처리해야 함
                    row.Cells[1].Value = (int.Parse(info.Value) * info.Scale).ToString();
                }
            }
        }

        private void FormCBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_tcpClient != null)
                    _tcpClient.Close();
            } catch (Exception ex)
            {
                log.Error("FormClosing, " + ex.Message);
            }
        }
    }
}
