namespace SimCogen
{
    partial class Day1
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
            this.BtnRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxPath = new System.Windows.Forms.TextBox();
            this.TextBoxContent = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(570, 45);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(197, 32);
            this.BtnRead.TabIndex = 0;
            this.BtnRead.Text = "읽기(&R)";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.Read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "파일위치";
            // 
            // TxtBoxPath
            // 
            this.TxtBoxPath.Location = new System.Drawing.Point(135, 47);
            this.TxtBoxPath.Name = "TxtBoxPath";
            this.TxtBoxPath.Size = new System.Drawing.Size(310, 23);
            this.TxtBoxPath.TabIndex = 2;
            // 
            // TextBoxContent
            // 
            this.TextBoxContent.Location = new System.Drawing.Point(135, 83);
            this.TextBoxContent.Multiline = true;
            this.TextBoxContent.Name = "TextBoxContent";
            this.TextBoxContent.Size = new System.Drawing.Size(632, 268);
            this.TextBoxContent.TabIndex = 3;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(451, 47);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(43, 23);
            this.BtnBrowse.TabIndex = 4;
            this.BtnBrowse.Text = "...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "파일내용";
            // 
            // Day1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.TextBoxContent);
            this.Controls.Add(this.TxtBoxPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRead);
            this.Name = "Day1";
            this.Text = "Day1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnRead;
        private Label label1;
        private TextBox TxtBoxPath;
        private TextBox TextBoxContent;
        private Button BtnBrowse;
        private Label label2;
    }
}