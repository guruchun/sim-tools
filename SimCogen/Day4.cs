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
using System.Xml.Linq;

namespace SimCogen
{
    public partial class Day4 : Form
    {
        private DataTable _DataList = new DataTable();

        public Day4()
        {
            InitializeComponent();
        }

        private void SetupDataTable()
        {
            // initialize DataTable
            // set table columns
            string[] colName = { "Name", "Value", "Description" };
            string[] colType = { "System.String", "System.Object", "System.String" };
            // for _DataList
            for (int i = 0; i < colName.Length; i++)
            {
                DataColumn col = new DataColumn(colName[i], dataType: Type.GetType(colType[i]) ?? typeof(String));
                _DataList.Columns.Add(col);
            }
            // for searching, filtering
            _DataList.PrimaryKey = new DataColumn[] { (_DataList.Columns["Name"] ?? _DataList.Columns[0]) };
            DgvCogen.DataSource = _DataList;
        }

        private void Day4_Load(object sender, EventArgs e)
        {
            SetupDataTable();
            _DataList.Rows.Add(new object[] { "test", "value", "description" });
            _DataList.Rows.Add(new object[] { "test2", "value2", "description2" });

            foreach (var c in this.Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    if (pb.Name.StartsWith("Pic"))
                    {
                        _DataList.Rows.Add(new object[] { pb.Name, "0", "description" });
                        pb.Click += new System.EventHandler(this.Pic_Click);
                    }
                }
            }

            FormRefresh();
        }

        private void FormRefresh()
        {
            //TxtFwVer.Text = (string)_DataList[TxtFwVer.Name];
            //TxtPit02.Text = (string)_DataList[TxtPit02.Name];


            foreach (var c in this.Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    string name = pb.Name;
                    if (name.StartsWith("Pic"))
                    {
                        DataRow? row = _DataList.Rows.Find(name);
                        string value = (string)row[1];
                        if (value == "1")
                            pb.BackgroundImage = Properties.Resources.dot_green;
                        else
                            pb.BackgroundImage = Properties.Resources.dot_red;
                    }
                }
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            //_DataList["TxtFwVer"] = TxtFwVer.Text;
            FormRefresh();
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox? pb = sender as PictureBox;
            if (pb == null)
                return;

            string name = pb.Name;
            var row = _DataList.Rows.Find(name);
            string value = (string)row[1];
            if (value == "1")
                value = "0";
            else
                value = "1";

            row[1] = value;

            FormRefresh();
        }

        private void DgvCogen_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            FormRefresh();
        }
    }
}
