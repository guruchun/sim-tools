namespace SimCogen
{
    partial class Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Final));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FcID = new System.Windows.Forms.ComboBox();
            this.picCogen = new System.Windows.Forms.PictureBox();
            this.CogenVer = new System.Windows.Forms.TextBox();
            this.TxtPit02 = new System.Windows.Forms.TextBox();
            this.TxtTtTh3 = new System.Windows.Forms.TextBox();
            this.TxtPit01 = new System.Windows.Forms.TextBox();
            this.TxtThM = new System.Windows.Forms.TextBox();
            this.TxtThL = new System.Windows.Forms.TextBox();
            this.TxtThH = new System.Windows.Forms.TextBox();
            this.TxtTtTh6 = new System.Windows.Forms.TextBox();
            this.TxtPit03 = new System.Windows.Forms.TextBox();
            this.picTankH = new System.Windows.Forms.PictureBox();
            this.TankLevel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GridFC = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picCogen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cogen 상태";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "연료전지 상태";
            // 
            // FcID
            // 
            this.FcID.FormattingEnabled = true;
            this.FcID.Location = new System.Drawing.Point(835, 22);
            this.FcID.Name = "FcID";
            this.FcID.Size = new System.Drawing.Size(56, 23);
            this.FcID.TabIndex = 3;
            this.FcID.Text = "01";
            // 
            // picCogen
            // 
            this.picCogen.Image = ((System.Drawing.Image)(resources.GetObject("picCogen.Image")));
            this.picCogen.Location = new System.Drawing.Point(25, 50);
            this.picCogen.Name = "picCogen";
            this.picCogen.Size = new System.Drawing.Size(660, 450);
            this.picCogen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCogen.TabIndex = 4;
            this.picCogen.TabStop = false;
            // 
            // CogenVer
            // 
            this.CogenVer.Location = new System.Drawing.Point(45, 72);
            this.CogenVer.Name = "CogenVer";
            this.CogenVer.ReadOnly = true;
            this.CogenVer.Size = new System.Drawing.Size(100, 23);
            this.CogenVer.TabIndex = 6;
            this.CogenVer.Tag = "Version";
            // 
            // TxtPit02
            // 
            this.TxtPit02.Location = new System.Drawing.Point(134, 356);
            this.TxtPit02.Name = "TxtPit02";
            this.TxtPit02.ReadOnly = true;
            this.TxtPit02.Size = new System.Drawing.Size(56, 23);
            this.TxtPit02.TabIndex = 6;
            this.TxtPit02.Tag = "PIT-02";
            // 
            // TxtTtTh3
            // 
            this.TxtTtTh3.Location = new System.Drawing.Point(328, 350);
            this.TxtTtTh3.Name = "TxtTtTh3";
            this.TxtTtTh3.ReadOnly = true;
            this.TxtTtTh3.Size = new System.Drawing.Size(56, 23);
            this.TxtTtTh3.TabIndex = 6;
            this.TxtTtTh3.Tag = "PIT-02";
            // 
            // TxtPit01
            // 
            this.TxtPit01.Location = new System.Drawing.Point(328, 384);
            this.TxtPit01.Name = "TxtPit01";
            this.TxtPit01.ReadOnly = true;
            this.TxtPit01.Size = new System.Drawing.Size(56, 23);
            this.TxtPit01.TabIndex = 7;
            this.TxtPit01.Tag = "PIT-02";
            // 
            // TxtThM
            // 
            this.TxtThM.Location = new System.Drawing.Point(425, 254);
            this.TxtThM.Name = "TxtThM";
            this.TxtThM.ReadOnly = true;
            this.TxtThM.Size = new System.Drawing.Size(56, 23);
            this.TxtThM.TabIndex = 8;
            this.TxtThM.Tag = "PIT-02";
            // 
            // TxtThL
            // 
            this.TxtThL.Location = new System.Drawing.Point(425, 316);
            this.TxtThL.Name = "TxtThL";
            this.TxtThL.ReadOnly = true;
            this.TxtThL.Size = new System.Drawing.Size(56, 23);
            this.TxtThL.TabIndex = 9;
            this.TxtThL.Tag = "PIT-02";
            // 
            // TxtThH
            // 
            this.TxtThH.Location = new System.Drawing.Point(425, 191);
            this.TxtThH.Name = "TxtThH";
            this.TxtThH.ReadOnly = true;
            this.TxtThH.Size = new System.Drawing.Size(56, 23);
            this.TxtThH.TabIndex = 10;
            this.TxtThH.Tag = "PIT-02";
            // 
            // TxtTtTh6
            // 
            this.TxtTtTh6.Location = new System.Drawing.Point(606, 177);
            this.TxtTtTh6.Name = "TxtTtTh6";
            this.TxtTtTh6.Size = new System.Drawing.Size(56, 23);
            this.TxtTtTh6.TabIndex = 11;
            this.TxtTtTh6.Tag = "PIT-02";
            this.TxtTtTh6.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // TxtPit03
            // 
            this.TxtPit03.Location = new System.Drawing.Point(606, 288);
            this.TxtPit03.Name = "TxtPit03";
            this.TxtPit03.ReadOnly = true;
            this.TxtPit03.Size = new System.Drawing.Size(56, 23);
            this.TxtPit03.TabIndex = 12;
            this.TxtPit03.Tag = "PIT-02";
            // 
            // picTankH
            // 
            this.picTankH.BackColor = System.Drawing.SystemColors.Control;
            this.picTankH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picTankH.Image = global::SimCogen.Properties.Resources.dot_green;
            this.picTankH.InitialImage = global::SimCogen.Properties.Resources.dot_gray;
            this.picTankH.Location = new System.Drawing.Point(25, 50);
            this.picTankH.Name = "picTankH";
            this.picTankH.Size = new System.Drawing.Size(17, 16);
            this.picTankH.TabIndex = 13;
            this.picTankH.TabStop = false;
            // 
            // TankLevel
            // 
            this.TankLevel.BackColor = System.Drawing.Color.Blue;
            this.TankLevel.FlatAppearance.BorderSize = 0;
            this.TankLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TankLevel.Font = new System.Drawing.Font("맑은 고딕", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TankLevel.ForeColor = System.Drawing.Color.LightGray;
            this.TankLevel.Location = new System.Drawing.Point(300, 201);
            this.TankLevel.Name = "TankLevel";
            this.TankLevel.Size = new System.Drawing.Size(115, 128);
            this.TankLevel.TabIndex = 14;
            this.TankLevel.Text = "축열조";
            this.TankLevel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TankLevel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cogen 상태 설정";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(810, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID:";
            // 
            // GridFC
            // 
            this.GridFC.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridFC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFC.Location = new System.Drawing.Point(700, 50);
            this.GridFC.Name = "GridFC";
            this.GridFC.RowTemplate.Height = 25;
            this.GridFC.Size = new System.Drawing.Size(191, 243);
            this.GridFC.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(700, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(191, 184);
            this.dataGridView1.TabIndex = 20;
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GridFC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TankLevel);
            this.Controls.Add(this.picTankH);
            this.Controls.Add(this.TxtPit03);
            this.Controls.Add(this.TxtTtTh6);
            this.Controls.Add(this.TxtThH);
            this.Controls.Add(this.TxtThL);
            this.Controls.Add(this.TxtThM);
            this.Controls.Add(this.TxtPit01);
            this.Controls.Add(this.TxtTtTh3);
            this.Controls.Add(this.TxtPit02);
            this.Controls.Add(this.CogenVer);
            this.Controls.Add(this.picCogen);
            this.Controls.Add(this.FcID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Final";
            this.Text = "Final";
            this.Load += new System.EventHandler(this.Final_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCogen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private ComboBox FcID;
        private PictureBox picCogen;
        private TextBox CogenVer;
        private TextBox TxtPit02;
        private TextBox TxtTtTh3;
        private TextBox TxtPit01;
        private TextBox TxtThM;
        private TextBox TxtThL;
        private TextBox TxtThH;
        private TextBox TxtTtTh6;
        private TextBox TxtPit03;
        private PictureBox picTankH;
        private Button TankLevel;
        private Label label2;
        private Label label5;
        private DataGridView GridFC;
        private DataGridView dataGridView1;
    }
}