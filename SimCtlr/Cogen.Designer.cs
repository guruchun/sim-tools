namespace SimCtlr
{
    partial class Cogen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortList = new System.Windows.Forms.ComboBox();
            this.PortRefresh = new System.Windows.Forms.Button();
            this.PortOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvCogen = new System.Windows.Forms.DataGridView();
            this.DgvFC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCogen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFC)).BeginInit();
            this.SuspendLayout();
            // 
            // PortList
            // 
            this.PortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortList.Location = new System.Drawing.Point(13, 8);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(121, 23);
            this.PortList.TabIndex = 29;
            // 
            // PortRefresh
            // 
            this.PortRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PortRefresh.Location = new System.Drawing.Point(135, 8);
            this.PortRefresh.Name = "PortRefresh";
            this.PortRefresh.Size = new System.Drawing.Size(23, 23);
            this.PortRefresh.TabIndex = 30;
            // 
            // PortOpen
            // 
            this.PortOpen.Location = new System.Drawing.Point(169, 8);
            this.PortOpen.Name = "PortOpen";
            this.PortOpen.Size = new System.Drawing.Size(98, 23);
            this.PortOpen.TabIndex = 31;
            this.PortOpen.Text = "Open";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cogen 상태(수신 정보)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(438, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cogen 제어(FC#1 Only) && FC 상태 응답";
            // 
            // DgvCogen
            // 
            this.DgvCogen.AllowUserToAddRows = false;
            this.DgvCogen.AllowUserToDeleteRows = false;
            this.DgvCogen.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvCogen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCogen.Location = new System.Drawing.Point(28, 84);
            this.DgvCogen.Name = "DgvCogen";
            this.DgvCogen.RowHeadersVisible = false;
            this.DgvCogen.RowHeadersWidth = 82;
            this.DgvCogen.RowTemplate.Height = 25;
            this.DgvCogen.Size = new System.Drawing.Size(380, 464);
            this.DgvCogen.TabIndex = 35;
            // 
            // DgvFC
            // 
            this.DgvFC.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvFC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFC.Location = new System.Drawing.Point(438, 84);
            this.DgvFC.Name = "DgvFC";
            this.DgvFC.RowHeadersVisible = false;
            this.DgvFC.RowHeadersWidth = 82;
            this.DgvFC.RowTemplate.Height = 25;
            this.DgvFC.Size = new System.Drawing.Size(398, 464);
            this.DgvFC.TabIndex = 34;
            // 
            // Cogen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 571);
            this.Controls.Add(this.DgvCogen);
            this.Controls.Add(this.DgvFC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortList);
            this.Controls.Add(this.PortRefresh);
            this.Controls.Add(this.PortOpen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cogen";
            this.Text = "FCell Cogen Interface";
            this.Load += new System.EventHandler(this.Cogen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCogen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox PortList;
        private Button PortRefresh;
        private Button PortOpen;
        private Label label1;
        private Label label2;
        private DataGridView DgvCogen;
        private DataGridView DgvFC;
    }
}