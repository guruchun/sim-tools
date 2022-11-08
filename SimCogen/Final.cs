using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCogen
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void Final_Load(object sender, EventArgs e)
        {
            picTankH.Parent = picCogen;
            picTankH.BackColor = Color.Transparent;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox? txtBox = sender as TextBox;
            if (txtBox == null)
                return;

            string name = txtBox.Name;
            switch (name) {
                case "TxtTtTh6":
                    Debug.WriteLine("TxtTtTht...");
                    break;

            }
        }
    }
}
