using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCogen
{
    public partial class Day3 : Form
    {
        private Dictionary<string, object> _DataList = new Dictionary<string, object>();

        public Day3()
        {
            InitializeComponent();
        }

        private void Day3_Load(object sender, EventArgs e)
        {
            _DataList.Add("TxtFwVer", "COGEN_FW_1.1.2");
            _DataList.Add("TxtPit02", "1.234");
            foreach (var c in this.Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    _DataList.Add(pb.Name, false);
                }
            }

            FormRefresh();
        }

        private void FormRefresh()
        {
            TxtFwVer.Text = (string)_DataList[TxtFwVer.Name];
            TxtPit02.Text = (string)_DataList[TxtPit02.Name];


            foreach (var c in this.Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    string name = pb.Name;
                    if (name.StartsWith("Pic"))
                    {
                        bool nowSts = (bool)_DataList[name];
                        if (nowSts)
                            pb.Image = Properties.Resources.dot_green;
                        else
                            pb.Image = Properties.Resources.dot_red;
                    }
                }
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            _DataList["TxtFwVer"] = TxtFwVer.Text;
            FormRefresh();
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox? pb = sender as PictureBox;
            if (pb == null)
                return;

            string name = pb.Name;
            bool nowSts = (bool)_DataList[name];
            _DataList[name] = !nowSts;

            FormRefresh();
        }
    }
}
