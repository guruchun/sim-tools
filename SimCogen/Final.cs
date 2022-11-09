using System.Data;
using System.Diagnostics;
using FcpUtils;
using System.Xml.Linq;

namespace SimCogen
{
    public partial class Final : Form
    {
        private DataTable TblCogen = new DataTable("DtCogen");
        private DataTable[] TblFCell = new DataTable[6];

        public Final()
        {
            InitializeComponent();
        }

        private void SetupDataTable()
        {
            // initialize DataTable
            // set table columns
            string[] colName = { "Name", "Value", "Description" };
            string[] colType = { "System.String", "System.Object", "System.String" };
            // for TblCogen
            for (int i = 0; i < colName.Length; i++)
            {
                DataColumn col = new DataColumn(colName[i], dataType: Type.GetType(colType[i]) ?? typeof(String));
                TblCogen.Columns.Add(col);
            }
            // for searching, filtering
            TblCogen.PrimaryKey = new DataColumn[] { (TblCogen.Columns["Name"] ?? TblCogen.Columns[0]) };
            DgvCogen.DataSource = TblCogen;

            // for TblFCell
            for (int fc = 0; fc < 6; fc++)
            {
                TblFCell[fc] = new DataTable("DtFCell-" + fc);
                for (int i = 0; i < colName.Length; i++)
                {
                    DataColumn col = new DataColumn(colName[i], dataType: Type.GetType(colType[i]) ?? typeof(String));
                    TblFCell[fc].Columns.Add(col);
                }
                TblFCell[fc].PrimaryKey = new DataColumn[] { TblFCell[fc].Columns["Name"] ?? TblFCell[fc].Columns[0] };
            }
            DgvFC.DataSource = TblFCell[0];
        }

        private void LoadDataTable()
        {
            // 임시
            string fileFullName = "config/init-data-cogen.txt";
            // open property file
            Property prop = new(fileFullName);

            // update DataGridView directly
            //foreach (DataGridViewRow row in DgvCogen.Rows)
            //{
            //    // get tag value
            //    string tag = (string)row.Cells[3].Value;
            //    if (String.IsNullOrEmpty(tag))
            //    {
            //        row.Cells[1].Value = "0";
            //    }
            //    else
            //    {
            //        row.Cells[1].Value = prop.Get(tag, "0");
            //    }
            //}

            // update DataTable
        }

        private void Final_Load(object sender, EventArgs e)
        {
            // set up DataTable
            SetupDataTable();

            // set up PictureBox
            List<PictureBox> picList = new();
            picList.AddRange(this.Controls.OfType<PictureBox>());
            foreach (PictureBox pb in picList)
            {
                if (pb.Name.StartsWith("Pic"))
                {
                    Debug.WriteLine($"PicBox Name={pb.Name}");

                    // set transparent of background
                    pb.Parent = CogenBG;    // Form의 Child Controls에 영향을 주므로 직접 접근하지 않고 복사해 놓고 사용한다.
                    pb.Location = new Point(pb.Location.X - CogenBG.Location.X, pb.Location.Y - CogenBG.Location.Y);

                    // add event handler
                    pb.Click += new EventHandler(PictureBox_Click);

                    // add name on TblCogen
                    string name = pb.Name[3..];
                    TblCogen.Rows.Add(new object[] { name, false });
                }
                else
                {
                    Debug.WriteLine($"PicOther Name={pb.Name}");
                }
            }

            // set up TextBox
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Name.StartsWith("Txt"))
                {
                    Debug.WriteLine($"TextBox Name={tb.Name}");

                    // add event handler
                    tb.TextChanged += new EventHandler(TextBox_TextChanged);

                    // add name on dictionary
                    string name = tb.Name[3..];
                    TblCogen.Rows.Add(new object[] { name, "" });
                }
                else
                {
                    Debug.WriteLine($"TxtOther Name={tb.Name}");
                }
            }

            // ComboBox 초기화
            // design time에 입력한 item을 제거한다.
            this.FcID.Items.Clear();
            // configuration에 따라 FC의 개수만큼 설정한다.
            List<string> fcList = new() { "01", "02", "03", "04", "05", "06" };
            this.FcID.Items.AddRange(fcList.ToArray());
            this.FcID.SelectedIndex = 0;

            // Loading된 데이터로 초기화한다.
            LoadDataTable();

            // 화면을 업데이트한다.
            Final_Refresh();
        }

        private void Final_Refresh()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox tb)
                {
                    if (tb.Name.StartsWith("Txt"))
                    {
                        string name = tb.Name[3..];
                        DataRow? row = TblCogen.Rows.Find(name);
                        if (row is not null)
                            tb.Text = (string)row[1];   // value
                    }
                }
                else if (c is PictureBox pb)
                {
                    if (pb.Name.StartsWith("Pic"))
                    {
                        string name = pb.Name[3..];
                        DataRow? row = TblCogen.Rows.Find(name);
                        if (row is not null)
                        {
                            bool state = (bool)row[1];   // value
                            // set image by state
                            if (state)
                            {
                                pb.Image = Properties.Resources.dot_green;
                            }
                            else
                            {
                                pb.Image = Properties.Resources.dot_red;
                            }
                        }
                    }
                } 
                else
                {
                    // ignore the other controls
                }
            } // end of foreach
        }

        private void TextBox_TextChanged(object? sender, EventArgs e)
        {
            if (sender is not TextBox txtBox)
                return;

            string name = txtBox.Name[3..];
            Debug.WriteLine($"TextBox {name} = {txtBox.Text}");

            // update on DataTable
            DataRow? row = TblCogen.Rows.Find(name);
            if (row is not null)
            {
                row[1] = txtBox.Text;
            }
        }

        private void PictureBox_Click(object? sender, EventArgs e)
        {
            if (sender is not PictureBox picBox)
                return;

            string name = picBox.Name[3..];
            Debug.WriteLine($"PictureBox {name} = {picBox.Text}");

            // get current state
            DataRow? row = TblCogen.Rows.Find(name);
            if (row is not null)
            {
                row[1] = !((bool)row[1]);
            }
        }
    }
}
