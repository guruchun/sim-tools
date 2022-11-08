using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using WinFormsUI.Docking;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace CBoxSim {
    public partial class FormBoxControl : DockContent
    {
        private ModbusServer _modbusServer;
        private bool _preventRefresh = false;

        public FormBoxControl()
        {
            InitializeComponent();

            // modbus server
            _modbusServer = ModbusServer.getInstance();
            //_modbusServer.coilsChanged += new ModbusServer.CoilsChanged(CoilsChanged);
            //_modbusServer.holdingRegistersChanged += new ModbusServer.HoldingRegistersChanged(HoldingRegistersChanged);
            //_modbusServer.numberOfConnectedClientsChanged += new ModbusServer.NumberOfConnectedClientsChanged(NumberOfConnectionsChanged);
            //_modbusServer.logDataChanged += new ModbusServer.LogDataChanged(LogDataChanged);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                // get system configuration
                ConfigInfo config = ConfigInfo.getInstance();

                // Network configuration
                cbProtocol.SelectedIndex = config.server.modbusNet.transMode; // 0;
                txtServerPort.Text = config.server.modbusNet.listenPort.ToString();
                IPAddress[] IPS = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress addr in IPS)
                {
                    if (addr.AddressFamily == AddressFamily.InterNetwork) // 
                        cbLocalAddress.Items.Add(addr.ToString());
                }
                if (cbLocalAddress.Items.Count > 0)
                    cbLocalAddress.SelectedIndex = 0;
                
                // modbus server
                txtFilePath.Text = config.server.mapFilePath;
            }
            catch (Exception e1)
            {
                Common.WriteConsole("server form load error, " + e1.Message);
            }
        }

        private void Form_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            ((MainForm)this.ParentForm).ShowHelp("GuideServer");
        }

        delegate void coilsChangedCallback();
        private void CoilsChanged()
        {
            if (_preventRefresh)
                return;

            if (this.tabDisplay.InvokeRequired)
            {

                {
                    coilsChangedCallback d = new coilsChangedCallback(CoilsChanged);
                    this.Invoke(d);
                }
            }
            else
            {
                if (tabDisplay.SelectedIndex == 1)
                    tabDisplay_SelectedIndexChanged(null, null);
            }
        }

        delegate void registersChangedCallback();
        bool registersChanegesLocked;
        private void HoldingRegistersChanged()
        {
            if (_preventRefresh)
                return;

            try
            {
                Common.WriteConsole("Server received message");

                if (this.tabDisplay.InvokeRequired)
                {
                    {
                        if (!registersChanegesLocked)
                            lock (this)
                            {
                                registersChanegesLocked = true;

                                registersChangedCallback d = new registersChangedCallback(HoldingRegistersChanged);
                                this.Invoke(d);
                            }
                    }
                }
                else
                {
                    if (tabDisplay.SelectedIndex == 3)
                        tabDisplay_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception) { }
            registersChanegesLocked = false;
        }


        bool LockNumberOfConnectionsChanged = false;
        delegate void numberOfConnectionsCallback();
        private void NumberOfConnectionsChanged()
        {
            if (this.clientCount.InvokeRequired & !LockNumberOfConnectionsChanged)
            {
                {
                    lock (this)
                    {
                        LockNumberOfConnectionsChanged = true;
                        registersChangedCallback d = new registersChangedCallback(NumberOfConnectionsChanged);
                        try
                        {
                            this.Invoke(d);
                        }
                        catch (Exception) { }
                        finally
                        {
                            LockNumberOfConnectionsChanged = false;
                        }
                    }
                }
            }
            else
            {
                try
                {
                    clientCount.Text = _modbusServer.NumberOfConnections.ToString();
                }
                catch (Exception)
                { }
            }
        }

        private void tabDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDisplay.SelectedIndex == 0)
            {
            }
            if (tabDisplay.SelectedIndex == 1)
            {
            }
            if (tabDisplay.SelectedIndex == 2)
            {
            }
            if (tabDisplay.SelectedIndex == 3)
            {
            }
        }

        delegate void logDataChangedCallback();
        private void LogDataChanged()
        {
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                String tag = ((Control)sender).Tag.ToString();

                DataGridView grid;
                int addrFrom, addrTo;
                Dictionary<int, string> dic;
                if (tag.Equals("disc") || tag.Equals("coil"))
                {
                    bool[] bitValues;
                    if (tag.Equals("disc")) {
                        grid = dataGridDiscrete;
                        addrFrom = int.Parse(txtDiscStart.Text) + _modbusServer.baseAddrDisc;
                        addrTo = addrFrom + int.Parse(txtDiscQuantity.Text);
                        dic = _modbusServer.dicDisc;
                        bitValues = _modbusServer.discs;
                    }
                    else
                    {
                        grid = dataGridCoil;
                        addrFrom = int.Parse(txtCoilStart.Text) + _modbusServer.baseAddrCoil;
                        addrTo = addrFrom + int.Parse(txtCoilQuantity.Text);
                        dic = _modbusServer.dicCoil;
                        bitValues = _modbusServer.coils;
                    }

                    string comment;
                    grid.Rows.Clear();
                    for (int i = addrFrom; i < addrTo; i++)
                    {
                        bool found = dic.TryGetValue(i, out comment);
                        grid.Rows.Add(i, found ? comment : "", bitValues[i]);
                        if (bitValues[i])
                            grid[2, i - addrFrom].Style.BackColor = Color.Green;
                        else
                            grid[2, i - addrFrom].Style.BackColor = Color.Red;
                    }
                    grid.ClearSelection();
                }
                else // "inputReg, holdingReg"
                {
                    UInt16[] regValues;
                    if (tag.Equals("holdReg"))
                    {
                        grid = dataGridHolding;
                        addrFrom = int.Parse(txtRhrStart.Text) + _modbusServer.baseAddrHoReg;
                        addrTo = addrFrom + int.Parse(txtRhrQuantity.Text);
                        dic = _modbusServer.dicHoReg;
                        regValues = _modbusServer.holdRegisters;
                    }
                    else
                    {
                        grid = dataGridInReg;
                        addrFrom = int.Parse(txtRegStart.Text) + _modbusServer.baseAddrInReg;
                        addrTo = addrFrom + int.Parse(txtRegQuantity.Text);
                        dic = _modbusServer.dicInReg;
                        regValues = _modbusServer.inputRegisters;
                    }
                    
                    string comment;
                    grid.Rows.Clear();
                    for (int i = addrFrom; i < addrTo; i++)
                    {
                        UInt16 value = regValues[i];

                        bool found = dic.TryGetValue(i, out comment);
                        grid.Rows.Add(i, found ? comment : "", value);
                    }
                }
            }
            catch (Exception e1)
            {
                Common.WriteConsole("modbus read error, " + e1.Message);
            }
        }

        private void btnNetStart_Click(object sender, EventArgs e)
        {
            if (btnNetStart.Text.Equals("Start"))
            {
                _modbusServer.Port = int.Parse(txtServerPort.Text);
                _modbusServer.Start();
                btnNetStart.Text = "Stop";

                Common.WriteConsole("Modbus/TCP Server is started on port:" + _modbusServer.Port);
            }
            else
            {
                _modbusServer.Stop();
                btnNetStart.Text = "Start";
                Common.WriteConsole("Modbus/TCP Server is stopped");
            }
        }

        private void btnSerialStart_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!(sender is DataGridView))
                    return;

                DataGridView grid = (DataGridView)sender;
                int colindex = grid.SelectedCells[0].ColumnIndex;
                if (colindex != 2) // selected column: not 'value'
                    return;
                int rowindex = grid.SelectedCells[0].RowIndex;
                int address = int.Parse(grid.Rows[rowindex].Cells[0].Value.ToString()); // first column: 'address'

                if (grid == dataGridCoil)
                {
                    // toggle value: true <--> false
                    if (_modbusServer.coils[address] == false)
                        _modbusServer.coils[address] = true;
                    else
                        _modbusServer.coils[address] = false;

                    // reload with color
                    btnRead_Click(coilRead, null);
                }
                else if (grid == dataGridDiscrete)
                {
                    // toggle value: true <--> false
                    _modbusServer.discs[address] = !(_modbusServer.discs[address]);

                    // reload with color
                    btnRead_Click(discRead, null);
                }
            }
            catch (Exception e1)
            {
                Common.WriteConsole("data grid editing error, " + e1.Message);
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!(sender is DataGridView))
                return;

            DataGridView grid = (DataGridView)sender;
            if (grid.SelectedCells.Count == 0)
                return;

            int colindex = grid.SelectedCells[0].ColumnIndex;
            if (colindex != 2) // selected column: not 'value'
                return;
            int rowindex = grid.SelectedCells[0].RowIndex;

            // get changed value of selected address
            int address; UInt16 value;
            try
            {
                address = int.Parse(grid.Rows[rowindex].Cells[0].Value.ToString()); // first column: 'address'
                value = UInt16.Parse(grid.SelectedCells[0].Value.ToString());
            }
            catch (Exception) {
                return;
            }

            // update register
            try
            {
                if (grid == dataGridHolding)
                {
                    _modbusServer.holdRegisters[address] = value;
                }
                else if (grid == dataGridInReg)
                {
                    _modbusServer.inputRegisters[address] = value;
                }
            }
            catch (Exception e1)
            {
                Common.WriteConsole("data grid updating error, " + e1.Message);
            }

            // refresh UI -> not requird
        }

        private void btnCommentLoad_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ModbusMap));
                
                //XmlReader reader = XmlReader.Create(new StreamReader(txtFilePath.Text));
                TextReader reader = new StreamReader(txtFilePath.Text);
                ModbusMap map = (ModbusMap)serializer.Deserialize(reader);
                reader.Close();

                //_modbusServer.LoadValues(map);

                //txtDiscStart.Text = "0";
                //txtCoilStart.Text = "0";
                //txtRegStart.Text = "0";
                //txtRhrStart.Text = "0";
                //lblRangeDisc.Text = map.discretes.start + " ~ " + (map.discretes.start + map.discretes.range);
                //lblRangeCoil.Text = map.coils.start + " ~ " + (map.coils.start + map.coils.range);
                //lblRangeInput.Text = map.inputRegisters.start + " ~ " + (map.inputRegisters.start + map.inputRegisters.range);
                //lblRangeHold.Text = map.holdingRegisters.start + " ~ " + (map.holdingRegisters.start + map.holdingRegisters.range);
            }
            catch (Exception e1)
            {
                Common.WriteConsole("xml serializer error, " + e1.Message);
            }
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            Int32 value = 0x01020304;
            byte[] values = BitConverter.GetBytes(value);
            Console.WriteLine("org: {0:X} -> getBytes: {1}", value, BitConverter.ToString(values));
        }

        private void btnRawPreview_Click(object sender, EventArgs e)
        {

        }
    }
}
