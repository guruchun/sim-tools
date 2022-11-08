
namespace FcpTools
{
    partial class FormMbSvrUtil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMbSvrUtil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtProtocol = new System.Windows.Forms.TextBox();
            this.txtSlave = new System.Windows.Forms.TextBox();
            this.txtSeq = new System.Windows.Forms.TextBox();
            this.txtRawPreview = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtStartAddress = new System.Windows.Forms.TextBox();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRawPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkTxnId = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelUpper.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 655);
            this.panel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panelUpper);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(751, 655);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // panelUpper
            // 
            this.panelUpper.Controls.Add(this.groupBox3);
            this.panelUpper.Location = new System.Drawing.Point(3, 3);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(739, 191);
            this.panelUpper.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.chkTxnId);
            this.groupBox3.Controls.Add(this.txtLength);
            this.groupBox3.Controls.Add(this.txtProtocol);
            this.groupBox3.Controls.Add(this.txtSlave);
            this.groupBox3.Controls.Add(this.txtSeq);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.txtRawPreview);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.txtStartAddress);
            this.groupBox3.Controls.Add(this.cbFunction);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnRawPreview);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(17, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 165);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generate Response Message";
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLength.Location = new System.Drawing.Point(129, 60);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(43, 21);
            this.txtLength.TabIndex = 4;
            this.txtLength.Text = "0";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProtocol
            // 
            this.txtProtocol.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtProtocol.Location = new System.Drawing.Point(68, 60);
            this.txtProtocol.Name = "txtProtocol";
            this.txtProtocol.Size = new System.Drawing.Size(43, 21);
            this.txtProtocol.TabIndex = 4;
            this.txtProtocol.Text = "0";
            this.txtProtocol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSlave
            // 
            this.txtSlave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSlave.Location = new System.Drawing.Point(187, 60);
            this.txtSlave.Name = "txtSlave";
            this.txtSlave.Size = new System.Drawing.Size(82, 21);
            this.txtSlave.TabIndex = 4;
            this.txtSlave.Text = "0";
            this.txtSlave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSeq
            // 
            this.txtSeq.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSeq.Location = new System.Drawing.Point(21, 60);
            this.txtSeq.Name = "txtSeq";
            this.txtSeq.Size = new System.Drawing.Size(37, 21);
            this.txtSeq.TabIndex = 4;
            this.txtSeq.Text = "0";
            this.txtSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRawPreview
            // 
            this.txtRawPreview.Location = new System.Drawing.Point(20, 93);
            this.txtRawPreview.Name = "txtRawPreview";
            this.txtRawPreview.ReadOnly = true;
            this.txtRawPreview.Size = new System.Drawing.Size(560, 21);
            this.txtRawPreview.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 21);
            this.textBox1.TabIndex = 4;
            // 
            // txtStartAddress
            // 
            this.txtStartAddress.Location = new System.Drawing.Point(484, 60);
            this.txtStartAddress.Name = "txtStartAddress";
            this.txtStartAddress.Size = new System.Drawing.Size(221, 21);
            this.txtStartAddress.TabIndex = 4;
            // 
            // cbFunction
            // 
            this.cbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbFunction.Location = new System.Drawing.Point(283, 60);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(111, 20);
            this.cbFunction.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Data";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(389, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "Count/Exception";
            // 
            // btnRawPreview
            // 
            this.btnRawPreview.Location = new System.Drawing.Point(596, 88);
            this.btnRawPreview.Name = "btnRawPreview";
            this.btnRawPreview.Size = new System.Drawing.Size(109, 28);
            this.btnRawPreview.TabIndex = 3;
            this.btnRawPreview.Text = "Preview";
            this.btnRawPreview.UseVisualStyleBackColor = true;
            this.btnRawPreview.Click += new System.EventHandler(this.btnRawPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Function/Error";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(187, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "Unit ID(Slave)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(280, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "| <------------ MODBUS Response -----------> |";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(20, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "| <------------ MBAP Header ---------> |";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Protocol";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(129, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "Length";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(3, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 433);
            this.panel2.TabIndex = 12;
            // 
            // chkTxnId
            // 
            this.chkTxnId.AutoSize = true;
            this.chkTxnId.Location = new System.Drawing.Point(596, 20);
            this.chkTxnId.Name = "chkTxnId";
            this.chkTxnId.Size = new System.Drawing.Size(97, 16);
            this.chkTxnId.TabIndex = 5;
            this.chkTxnId.Text = "Txn# is fixed";
            this.chkTxnId.UseVisualStyleBackColor = true;
            this.chkTxnId.CheckedChanged += new System.EventHandler(this.chkTxnId_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(17, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(705, 184);
            this.listBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rx/Tx Messages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Txn";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(596, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Function is fixed";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.chkTxnId_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox2.Location = new System.Drawing.Point(20, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(685, 21);
            this.textBox2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Message Decoding";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(17, 288);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(705, 128);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 261);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(705, 21);
            this.textBox3.TabIndex = 3;
            // 
            // FormMonitor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(751, 655);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMonitor";
            this.Text = "Modbus Monitor";
            this.Load += new System.EventHandler(this.Form_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form_HelpRequested);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelUpper.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtProtocol;
        private System.Windows.Forms.TextBox txtSlave;
        private System.Windows.Forms.TextBox txtSeq;
        private System.Windows.Forms.TextBox txtRawPreview;
        private System.Windows.Forms.TextBox txtStartAddress;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRawPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkTxnId;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
    }
}