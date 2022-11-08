namespace CBoxSim {
    partial class FormCBox {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCBox));
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableOnTop = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.ServerIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picConnState = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.cboProtocol = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mapName = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tableOnBottom = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPreviewValue = new System.Windows.Forms.TextBox();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScaleFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.tableOnTop.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnState)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tableOnBottom.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tableOnTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(690, 80);
            this.panelTop.TabIndex = 9;
            // 
            // tableOnTop
            // 
            this.tableOnTop.ColumnCount = 3;
            this.tableOnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableOnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableOnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableOnTop.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableOnTop.Controls.Add(this.btnConnect, 2, 1);
            this.tableOnTop.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableOnTop.Controls.Add(this.btnLoad, 2, 2);
            this.tableOnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOnTop.Location = new System.Drawing.Point(0, 0);
            this.tableOnTop.Name = "tableOnTop";
            this.tableOnTop.RowCount = 4;
            this.tableOnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableOnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableOnTop.Size = new System.Drawing.Size(690, 80);
            this.tableOnTop.TabIndex = 104;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Controls.Add(this.ServerIP);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.ServerPort);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.picConnState);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 13);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(575, 25);
            this.flowLayoutPanel2.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 12);
            this.label12.TabIndex = 111;
            this.label12.Text = "HMI Server:";
            // 
            // ServerIP
            // 
            this.ServerIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServerIP.Location = new System.Drawing.Point(87, 3);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(128, 21);
            this.ServerIP.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 112;
            this.label2.Text = "Port: ";
            // 
            // ServerPort
            // 
            this.ServerPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServerPort.Location = new System.Drawing.Point(269, 3);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(48, 21);
            this.ServerPort.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 103;
            this.label4.Text = "연결 상태:";
            // 
            // picConnState
            // 
            this.picConnState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picConnState.Image = global::CBoxSim.Properties.Resources.dot_red;
            this.picConnState.Location = new System.Drawing.Point(397, 5);
            this.picConnState.Name = "picConnState";
            this.picConnState.Size = new System.Drawing.Size(18, 16);
            this.picConnState.TabIndex = 104;
            this.picConnState.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(593, 13);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 25);
            this.btnConnect.TabIndex = 99;
            this.btnConnect.Text = "연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label19);
            this.flowLayoutPanel1.Controls.Add(this.cboProtocol);
            this.flowLayoutPanel1.Controls.Add(this.label16);
            this.flowLayoutPanel1.Controls.Add(this.mapName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 44);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(568, 25);
            this.flowLayoutPanel1.TabIndex = 111;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "Protocol:    ";
            // 
            // cboProtocol
            // 
            this.cboProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProtocol.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboProtocol.FormattingEnabled = true;
            this.cboProtocol.Location = new System.Drawing.Point(80, 3);
            this.cboProtocol.Name = "cboProtocol";
            this.cboProtocol.Size = new System.Drawing.Size(128, 20);
            this.cboProtocol.TabIndex = 103;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(221, 7);
            this.label16.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 12);
            this.label16.TabIndex = 88;
            this.label16.Text = "Map:";
            // 
            // mapName
            // 
            this.mapName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mapName.Location = new System.Drawing.Point(261, 3);
            this.mapName.Name = "mapName";
            this.mapName.ReadOnly = true;
            this.mapName.Size = new System.Drawing.Size(177, 21);
            this.mapName.TabIndex = 115;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(593, 44);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(87, 24);
            this.btnLoad.TabIndex = 103;
            this.btnLoad.Text = "Load ...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.tableOnBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 551);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(690, 32);
            this.panelBottom.TabIndex = 10;
            // 
            // tableOnBottom
            // 
            this.tableOnBottom.ColumnCount = 1;
            this.tableOnBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.tableOnBottom.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableOnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOnBottom.Location = new System.Drawing.Point(0, 0);
            this.tableOnBottom.Name = "tableOnBottom";
            this.tableOnBottom.RowCount = 1;
            this.tableOnBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOnBottom.Size = new System.Drawing.Size(690, 32);
            this.tableOnBottom.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label15);
            this.flowLayoutPanel4.Controls.Add(this.txtPreviewValue);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(684, 26);
            this.flowLayoutPanel4.TabIndex = 111;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 7);
            this.label15.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 12);
            this.label15.TabIndex = 92;
            this.label15.Text = "Preview";
            // 
            // txtPreviewValue
            // 
            this.txtPreviewValue.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPreviewValue.Location = new System.Drawing.Point(66, 3);
            this.txtPreviewValue.Name = "txtPreviewValue";
            this.txtPreviewValue.ReadOnly = true;
            this.txtPreviewValue.Size = new System.Drawing.Size(611, 21);
            this.txtPreviewValue.TabIndex = 93;
            this.txtPreviewValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelMiddle
            // 
            this.panelMiddle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMiddle.Controls.Add(this.DgvData);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(0, 80);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Padding = new System.Windows.Forms.Padding(10);
            this.panelMiddle.Size = new System.Drawing.Size(690, 471);
            this.panelMiddle.TabIndex = 11;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.Value,
            this.ScaleFactor,
            this.TagName,
            this.Description});
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvData.EnableHeadersVisualStyles = false;
            this.DgvData.Location = new System.Drawing.Point(10, 10);
            this.DgvData.Name = "DgvData";
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.RowTemplate.Height = 23;
            this.DgvData.Size = new System.Drawing.Size(670, 451);
            this.DgvData.TabIndex = 86;
            this.DgvData.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvData_CellValidating);
            this.DgvData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellValueChanged);
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // ScaleFactor
            // 
            this.ScaleFactor.HeaderText = "Scale";
            this.ScaleFactor.Name = "ScaleFactor";
            this.ScaleFactor.ReadOnly = true;
            // 
            // TagName
            // 
            this.TagName.HeaderText = "Tag";
            this.TagName.Name = "TagName";
            this.TagName.ReadOnly = true;
            this.TagName.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // FormCBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(690, 583);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FCP Open";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCBox_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form_HelpRequested);
            this.panelTop.ResumeLayout(false);
            this.tableOnTop.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnState)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.tableOnBottom.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tableOnTop;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picConnState;
        private System.Windows.Forms.TableLayoutPanel tableOnBottom;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPreviewValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ServerIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServerPort;
        private System.Windows.Forms.ComboBox cboProtocol;
        private System.Windows.Forms.TextBox mapName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScaleFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}