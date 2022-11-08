
namespace FcpTools
{
    partial class FormServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLocalAddress = new System.Windows.Forms.ComboBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.btnNetStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabDisplay = new System.Windows.Forms.TabControl();
            this.pageCoil = new System.Windows.Forms.TabPage();
            this.txtCoilQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchCoil = new System.Windows.Forms.TextBox();
            this.txtCoilStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.coilRead = new System.Windows.Forms.Button();
            this.dataGridCoil = new System.Windows.Forms.DataGridView();
            this.coilAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coilDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coilValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageDisc = new System.Windows.Forms.TabPage();
            this.lblSearchDisc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridDiscrete = new System.Windows.Forms.DataGridView();
            this.discAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiscQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiscStart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.discRead = new System.Windows.Forms.Button();
            this.pageHoldReg = new System.Windows.Forms.TabPage();
            this.txtSearchHold = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtRhrQuantity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRhrStart = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rhrRead = new System.Windows.Forms.Button();
            this.dataGridHolding = new System.Windows.Forms.DataGridView();
            this.holdRegAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdRegDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdRegValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageInReg = new System.Windows.Forms.TabPage();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRegQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRegStart = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.regRead = new System.Windows.Forms.Button();
            this.dataGridInReg = new System.Windows.Forms.DataGridView();
            this.inRegAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inRegDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inRegValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clientCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCommentLoad = new System.Windows.Forms.Button();
            this.btnExportFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelUpper.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            this.pageCoil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCoil)).BeginInit();
            this.pageDisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscrete)).BeginInit();
            this.pageHoldReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHolding)).BeginInit();
            this.pageInReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInReg)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 792);
            this.panel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panelUpper);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(751, 792);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // panelUpper
            // 
            this.panelUpper.Controls.Add(this.groupBox1);
            this.panelUpper.Location = new System.Drawing.Point(3, 3);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(739, 113);
            this.panelUpper.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLocalAddress);
            this.groupBox1.Controls.Add(this.txtServerPort);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnNetStart);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 81);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modbus/TCP";
            // 
            // cbLocalAddress
            // 
            this.cbLocalAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalAddress.FormattingEnabled = true;
            this.cbLocalAddress.Location = new System.Drawing.Point(20, 34);
            this.cbLocalAddress.Name = "cbLocalAddress";
            this.cbLocalAddress.Size = new System.Drawing.Size(161, 20);
            this.cbLocalAddress.TabIndex = 32;
            // 
            // txtServerPort
            // 
            this.txtServerPort.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtServerPort.Location = new System.Drawing.Point(196, 33);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(54, 21);
            this.txtServerPort.TabIndex = 8;
            this.txtServerPort.Text = "502";
            this.txtServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNetStart
            // 
            this.btnNetStart.Location = new System.Drawing.Point(596, 29);
            this.btnNetStart.Name = "btnNetStart";
            this.btnNetStart.Size = new System.Drawing.Size(109, 28);
            this.btnNetStart.TabIndex = 7;
            this.btnNetStart.Text = "Start";
            this.btnNetStart.UseVisualStyleBackColor = true;
            this.btnNetStart.Click += new System.EventHandler(this.btnNetStart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.tabDisplay);
            this.panel2.Location = new System.Drawing.Point(3, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 433);
            this.panel2.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExportFile);
            this.groupBox2.Controls.Add(this.btnCommentLoad);
            this.groupBox2.Location = new System.Drawing.Point(17, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 57);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Binding Map Description";
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.pageCoil);
            this.tabDisplay.Controls.Add(this.pageDisc);
            this.tabDisplay.Controls.Add(this.pageHoldReg);
            this.tabDisplay.Controls.Add(this.pageInReg);
            this.tabDisplay.Location = new System.Drawing.Point(17, 72);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.SelectedIndex = 0;
            this.tabDisplay.Size = new System.Drawing.Size(721, 354);
            this.tabDisplay.TabIndex = 19;
            this.tabDisplay.SelectedIndexChanged += new System.EventHandler(this.tabDisplay_SelectedIndexChanged);
            // 
            // pageCoil
            // 
            this.pageCoil.Controls.Add(this.txtCoilQuantity);
            this.pageCoil.Controls.Add(this.label5);
            this.pageCoil.Controls.Add(this.txtSearchCoil);
            this.pageCoil.Controls.Add(this.txtCoilStart);
            this.pageCoil.Controls.Add(this.label6);
            this.pageCoil.Controls.Add(this.label23);
            this.pageCoil.Controls.Add(this.coilRead);
            this.pageCoil.Controls.Add(this.dataGridCoil);
            this.pageCoil.Location = new System.Drawing.Point(4, 22);
            this.pageCoil.Name = "pageCoil";
            this.pageCoil.Padding = new System.Windows.Forms.Padding(3);
            this.pageCoil.Size = new System.Drawing.Size(713, 328);
            this.pageCoil.TabIndex = 4;
            this.pageCoil.Tag = "8";
            this.pageCoil.Text = "Coils";
            this.pageCoil.UseVisualStyleBackColor = true;
            // 
            // txtCoilQuantity
            // 
            this.txtCoilQuantity.Location = new System.Drawing.Point(536, 24);
            this.txtCoilQuantity.Name = "txtCoilQuantity";
            this.txtCoilQuantity.Size = new System.Drawing.Size(47, 21);
            this.txtCoilQuantity.TabIndex = 64;
            this.txtCoilQuantity.Text = "5";
            this.txtCoilQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 61;
            this.label5.Text = "Quantity:";
            // 
            // txtSearchCoil
            // 
            this.txtSearchCoil.Location = new System.Drawing.Point(77, 24);
            this.txtSearchCoil.Name = "txtSearchCoil";
            this.txtSearchCoil.ReadOnly = true;
            this.txtSearchCoil.Size = new System.Drawing.Size(113, 21);
            this.txtSearchCoil.TabIndex = 65;
            this.txtSearchCoil.Text = "search text...";
            this.txtSearchCoil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCoilStart
            // 
            this.txtCoilStart.Location = new System.Drawing.Point(425, 24);
            this.txtCoilStart.Name = "txtCoilStart";
            this.txtCoilStart.Size = new System.Drawing.Size(51, 21);
            this.txtCoilStart.TabIndex = 66;
            this.txtCoilStart.Text = "0";
            this.txtCoilStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 12);
            this.label6.TabIndex = 62;
            this.label6.Text = "Start Address:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 12);
            this.label23.TabIndex = 63;
            this.label23.Text = "Search:";
            // 
            // coilRead
            // 
            this.coilRead.Location = new System.Drawing.Point(592, 22);
            this.coilRead.Name = "coilRead";
            this.coilRead.Size = new System.Drawing.Size(109, 24);
            this.coilRead.TabIndex = 59;
            this.coilRead.Tag = "coil";
            this.coilRead.Text = "Read";
            this.coilRead.UseVisualStyleBackColor = true;
            this.coilRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dataGridCoil
            // 
            this.dataGridCoil.AllowUserToAddRows = false;
            this.dataGridCoil.AllowUserToDeleteRows = false;
            this.dataGridCoil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCoil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coilAddress,
            this.coilDesc,
            this.coilValue});
            this.dataGridCoil.Location = new System.Drawing.Point(18, 53);
            this.dataGridCoil.Name = "dataGridCoil";
            this.dataGridCoil.RowTemplate.Height = 23;
            this.dataGridCoil.ShowEditingIcon = false;
            this.dataGridCoil.Size = new System.Drawing.Size(683, 259);
            this.dataGridCoil.TabIndex = 58;
            this.dataGridCoil.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // coilAddress
            // 
            this.coilAddress.HeaderText = "Address";
            this.coilAddress.Name = "coilAddress";
            this.coilAddress.ReadOnly = true;
            // 
            // coilDesc
            // 
            this.coilDesc.HeaderText = "Description";
            this.coilDesc.Name = "coilDesc";
            this.coilDesc.ReadOnly = true;
            this.coilDesc.Width = 400;
            // 
            // coilValue
            // 
            this.coilValue.HeaderText = "Value";
            this.coilValue.Name = "coilValue";
            this.coilValue.ReadOnly = true;
            // 
            // pageDisc
            // 
            this.pageDisc.Controls.Add(this.lblSearchDisc);
            this.pageDisc.Controls.Add(this.label4);
            this.pageDisc.Controls.Add(this.dataGridDiscrete);
            this.pageDisc.Controls.Add(this.txtDiscQuantity);
            this.pageDisc.Controls.Add(this.label8);
            this.pageDisc.Controls.Add(this.txtDiscStart);
            this.pageDisc.Controls.Add(this.label7);
            this.pageDisc.Controls.Add(this.discRead);
            this.pageDisc.Location = new System.Drawing.Point(4, 22);
            this.pageDisc.Name = "pageDisc";
            this.pageDisc.Padding = new System.Windows.Forms.Padding(3);
            this.pageDisc.Size = new System.Drawing.Size(713, 328);
            this.pageDisc.TabIndex = 3;
            this.pageDisc.Tag = "7";
            this.pageDisc.Text = "Discrete";
            this.pageDisc.UseVisualStyleBackColor = true;
            // 
            // lblSearchDisc
            // 
            this.lblSearchDisc.Location = new System.Drawing.Point(78, 24);
            this.lblSearchDisc.Name = "lblSearchDisc";
            this.lblSearchDisc.ReadOnly = true;
            this.lblSearchDisc.Size = new System.Drawing.Size(113, 21);
            this.lblSearchDisc.TabIndex = 68;
            this.lblSearchDisc.Text = "search text...";
            this.lblSearchDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 66;
            this.label4.Text = "Search:";
            // 
            // dataGridDiscrete
            // 
            this.dataGridDiscrete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDiscrete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.discAddress,
            this.discDescription,
            this.discValue});
            this.dataGridDiscrete.Location = new System.Drawing.Point(18, 53);
            this.dataGridDiscrete.Name = "dataGridDiscrete";
            this.dataGridDiscrete.RowTemplate.Height = 23;
            this.dataGridDiscrete.Size = new System.Drawing.Size(683, 259);
            this.dataGridDiscrete.TabIndex = 57;
            this.dataGridDiscrete.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // discAddress
            // 
            this.discAddress.HeaderText = "Address";
            this.discAddress.Name = "discAddress";
            this.discAddress.ReadOnly = true;
            // 
            // discDescription
            // 
            this.discDescription.HeaderText = "Description";
            this.discDescription.Name = "discDescription";
            this.discDescription.ReadOnly = true;
            this.discDescription.Width = 400;
            // 
            // discValue
            // 
            this.discValue.HeaderText = "Value";
            this.discValue.Name = "discValue";
            this.discValue.ReadOnly = true;
            // 
            // txtDiscQuantity
            // 
            this.txtDiscQuantity.Location = new System.Drawing.Point(536, 24);
            this.txtDiscQuantity.Name = "txtDiscQuantity";
            this.txtDiscQuantity.Size = new System.Drawing.Size(47, 21);
            this.txtDiscQuantity.TabIndex = 56;
            this.txtDiscQuantity.Text = "10";
            this.txtDiscQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 12);
            this.label8.TabIndex = 54;
            this.label8.Text = "Quantity:";
            // 
            // txtDiscStart
            // 
            this.txtDiscStart.Location = new System.Drawing.Point(425, 24);
            this.txtDiscStart.Name = "txtDiscStart";
            this.txtDiscStart.Size = new System.Drawing.Size(51, 21);
            this.txtDiscStart.TabIndex = 56;
            this.txtDiscStart.Text = "0";
            this.txtDiscStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 54;
            this.label7.Text = "Start Address:";
            // 
            // discRead
            // 
            this.discRead.Location = new System.Drawing.Point(592, 22);
            this.discRead.Name = "discRead";
            this.discRead.Size = new System.Drawing.Size(109, 24);
            this.discRead.TabIndex = 51;
            this.discRead.Tag = "disc";
            this.discRead.Text = "Read";
            this.discRead.UseVisualStyleBackColor = true;
            this.discRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // pageHoldReg
            // 
            this.pageHoldReg.Controls.Add(this.txtSearchHold);
            this.pageHoldReg.Controls.Add(this.label19);
            this.pageHoldReg.Controls.Add(this.txtRhrQuantity);
            this.pageHoldReg.Controls.Add(this.label16);
            this.pageHoldReg.Controls.Add(this.txtRhrStart);
            this.pageHoldReg.Controls.Add(this.label17);
            this.pageHoldReg.Controls.Add(this.rhrRead);
            this.pageHoldReg.Controls.Add(this.dataGridHolding);
            this.pageHoldReg.Location = new System.Drawing.Point(4, 22);
            this.pageHoldReg.Name = "pageHoldReg";
            this.pageHoldReg.Size = new System.Drawing.Size(713, 328);
            this.pageHoldReg.TabIndex = 5;
            this.pageHoldReg.Text = "Holding Register";
            this.pageHoldReg.UseVisualStyleBackColor = true;
            // 
            // txtSearchHold
            // 
            this.txtSearchHold.Location = new System.Drawing.Point(79, 24);
            this.txtSearchHold.Name = "txtSearchHold";
            this.txtSearchHold.ReadOnly = true;
            this.txtSearchHold.Size = new System.Drawing.Size(113, 21);
            this.txtSearchHold.TabIndex = 71;
            this.txtSearchHold.Text = "search text...";
            this.txtSearchHold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 12);
            this.label19.TabIndex = 69;
            this.label19.Text = "Search:";
            // 
            // txtRhrQuantity
            // 
            this.txtRhrQuantity.Location = new System.Drawing.Point(536, 24);
            this.txtRhrQuantity.Name = "txtRhrQuantity";
            this.txtRhrQuantity.Size = new System.Drawing.Size(47, 21);
            this.txtRhrQuantity.TabIndex = 66;
            this.txtRhrQuantity.Text = "20";
            this.txtRhrQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(478, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 12);
            this.label16.TabIndex = 63;
            this.label16.Text = "Quantity:";
            // 
            // txtRhrStart
            // 
            this.txtRhrStart.Location = new System.Drawing.Point(425, 24);
            this.txtRhrStart.Name = "txtRhrStart";
            this.txtRhrStart.Size = new System.Drawing.Size(51, 21);
            this.txtRhrStart.TabIndex = 68;
            this.txtRhrStart.Text = "0";
            this.txtRhrStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(338, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 12);
            this.label17.TabIndex = 64;
            this.label17.Text = "Start Address:";
            // 
            // rhrRead
            // 
            this.rhrRead.Location = new System.Drawing.Point(592, 22);
            this.rhrRead.Name = "rhrRead";
            this.rhrRead.Size = new System.Drawing.Size(109, 24);
            this.rhrRead.TabIndex = 61;
            this.rhrRead.Tag = "holdReg";
            this.rhrRead.Text = "Read";
            this.rhrRead.UseVisualStyleBackColor = true;
            this.rhrRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dataGridHolding
            // 
            this.dataGridHolding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHolding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.holdRegAddress,
            this.holdRegDesc,
            this.holdRegValue});
            this.dataGridHolding.Location = new System.Drawing.Point(18, 53);
            this.dataGridHolding.Name = "dataGridHolding";
            this.dataGridHolding.RowTemplate.Height = 23;
            this.dataGridHolding.Size = new System.Drawing.Size(683, 259);
            this.dataGridHolding.TabIndex = 59;
            this.dataGridHolding.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // holdRegAddress
            // 
            this.holdRegAddress.HeaderText = "Address";
            this.holdRegAddress.Name = "holdRegAddress";
            // 
            // holdRegDesc
            // 
            this.holdRegDesc.HeaderText = "Description";
            this.holdRegDesc.Name = "holdRegDesc";
            this.holdRegDesc.Width = 400;
            // 
            // holdRegValue
            // 
            this.holdRegValue.HeaderText = "Value";
            this.holdRegValue.Name = "holdRegValue";
            // 
            // pageInReg
            // 
            this.pageInReg.Controls.Add(this.txtSearchInput);
            this.pageInReg.Controls.Add(this.label15);
            this.pageInReg.Controls.Add(this.txtRegQuantity);
            this.pageInReg.Controls.Add(this.label12);
            this.pageInReg.Controls.Add(this.txtRegStart);
            this.pageInReg.Controls.Add(this.label13);
            this.pageInReg.Controls.Add(this.regRead);
            this.pageInReg.Controls.Add(this.dataGridInReg);
            this.pageInReg.Location = new System.Drawing.Point(4, 22);
            this.pageInReg.Name = "pageInReg";
            this.pageInReg.Size = new System.Drawing.Size(713, 328);
            this.pageInReg.TabIndex = 6;
            this.pageInReg.Text = "Input Register";
            this.pageInReg.UseVisualStyleBackColor = true;
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Location = new System.Drawing.Point(78, 24);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.ReadOnly = true;
            this.txtSearchInput.Size = new System.Drawing.Size(113, 21);
            this.txtSearchInput.TabIndex = 69;
            this.txtSearchInput.Text = "search text...";
            this.txtSearchInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 12);
            this.label15.TabIndex = 67;
            this.label15.Text = "Search:";
            // 
            // txtRegQuantity
            // 
            this.txtRegQuantity.Location = new System.Drawing.Point(536, 24);
            this.txtRegQuantity.Name = "txtRegQuantity";
            this.txtRegQuantity.Size = new System.Drawing.Size(47, 21);
            this.txtRegQuantity.TabIndex = 64;
            this.txtRegQuantity.Text = "30";
            this.txtRegQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(478, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 12);
            this.label12.TabIndex = 61;
            this.label12.Text = "Quantity:";
            // 
            // txtRegStart
            // 
            this.txtRegStart.Location = new System.Drawing.Point(425, 24);
            this.txtRegStart.Name = "txtRegStart";
            this.txtRegStart.Size = new System.Drawing.Size(51, 21);
            this.txtRegStart.TabIndex = 66;
            this.txtRegStart.Text = "0";
            this.txtRegStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(338, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 12);
            this.label13.TabIndex = 62;
            this.label13.Text = "Start Address:";
            // 
            // regRead
            // 
            this.regRead.Location = new System.Drawing.Point(592, 22);
            this.regRead.Name = "regRead";
            this.regRead.Size = new System.Drawing.Size(109, 24);
            this.regRead.TabIndex = 60;
            this.regRead.Tag = "inReg";
            this.regRead.Text = "Read";
            this.regRead.UseVisualStyleBackColor = true;
            this.regRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dataGridInReg
            // 
            this.dataGridInReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inRegAddress,
            this.inRegDesc,
            this.inRegValue});
            this.dataGridInReg.Location = new System.Drawing.Point(18, 53);
            this.dataGridInReg.Name = "dataGridInReg";
            this.dataGridInReg.RowTemplate.Height = 23;
            this.dataGridInReg.Size = new System.Drawing.Size(683, 259);
            this.dataGridInReg.TabIndex = 59;
            // 
            // inRegAddress
            // 
            this.inRegAddress.HeaderText = "Address";
            this.inRegAddress.Name = "inRegAddress";
            // 
            // inRegDesc
            // 
            this.inRegDesc.HeaderText = "Description";
            this.inRegDesc.Name = "inRegDesc";
            this.inRegDesc.Width = 400;
            // 
            // inRegValue
            // 
            this.inRegValue.HeaderText = "Value";
            this.inRegValue.Name = "inRegValue";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clientCount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 561);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 66);
            this.panel3.TabIndex = 13;
            // 
            // clientCount
            // 
            this.clientCount.AutoSize = true;
            this.clientCount.Location = new System.Drawing.Point(119, 20);
            this.clientCount.Name = "clientCount";
            this.clientCount.Size = new System.Drawing.Size(23, 12);
            this.clientCount.TabIndex = 54;
            this.clientCount.Text = "###";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 12);
            this.label3.TabIndex = 54;
            this.label3.Text = "Modbus Clients:";
            // 
            // btnCommentLoad
            // 
            this.btnCommentLoad.Location = new System.Drawing.Point(596, 19);
            this.btnCommentLoad.Name = "btnCommentLoad";
            this.btnCommentLoad.Size = new System.Drawing.Size(109, 28);
            this.btnCommentLoad.TabIndex = 6;
            this.btnCommentLoad.Text = "Load/Mapping";
            this.btnCommentLoad.UseVisualStyleBackColor = true;
            this.btnCommentLoad.Click += new System.EventHandler(this.btnCommentLoad_Click);
            // 
            // btnExportFile
            // 
            this.btnExportFile.Location = new System.Drawing.Point(481, 19);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(109, 28);
            this.btnExportFile.TabIndex = 5;
            this.btnExportFile.Text = "Export ...";
            this.btnExportFile.UseVisualStyleBackColor = true;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Monitor/Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNetStart_Click);
            // 
            // FormServer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(751, 792);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormServer";
            this.Text = "Modbus Slave (Server)";
            this.Load += new System.EventHandler(this.Form_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form_HelpRequested);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelUpper.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            this.pageCoil.ResumeLayout(false);
            this.pageCoil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCoil)).EndInit();
            this.pageDisc.ResumeLayout(false);
            this.pageDisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscrete)).EndInit();
            this.pageHoldReg.ResumeLayout(false);
            this.pageHoldReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHolding)).EndInit();
            this.pageInReg.ResumeLayout(false);
            this.pageInReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInReg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Button btnNetStart;
        private System.Windows.Forms.TabControl tabDisplay;
        private System.Windows.Forms.TabPage pageDisc;
        private System.Windows.Forms.TextBox txtDiscQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiscStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage pageCoil;
        private System.Windows.Forms.TabPage pageInReg;
        private System.Windows.Forms.TabPage pageHoldReg;
        private System.Windows.Forms.Button discRead;
        private System.Windows.Forms.ComboBox cbLocalAddress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label clientCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button coilRead;
        private System.Windows.Forms.Button regRead;
        private System.Windows.Forms.Button rhrRead;
        private System.Windows.Forms.TextBox txtCoilQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchCoil;
        private System.Windows.Forms.TextBox txtCoilStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRegStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRhrQuantity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRhrStart;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridDiscrete;
        private System.Windows.Forms.DataGridView dataGridCoil;
        private System.Windows.Forms.DataGridView dataGridHolding;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdRegAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdRegDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdRegValue;
        private System.Windows.Forms.DataGridView dataGridInReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn inRegAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn inRegDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn inRegValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn coilAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn coilDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn coilValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn discAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn discDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn discValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox lblSearchDisc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchHold;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnExportFile;
        private System.Windows.Forms.Button btnCommentLoad;
        private System.Windows.Forms.Button button1;
    }
}