using System.Data;
using System.Diagnostics;
using FcpUtils;
using System.Xml.Linq;
using Timer = System.Windows.Forms.Timer;
using static System.Windows.Forms.AxHost;

namespace SimCogen
{
    public partial class Day4 : Form
    {
        private DataTable tblCogen = new DataTable("DtCogen");
        private DataTable[] tblFCell = new DataTable[6];
        //private Timer updateTimer = new Timer();

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
            // for tblCogen
            for (int i = 0; i < colName.Length; i++)
            {
                DataColumn col = new DataColumn(colName[i], dataType: Type.GetType(colType[i]) ?? typeof(String));
                tblCogen.Columns.Add(col);
            }
            // for searching, filtering
            tblCogen.PrimaryKey = new DataColumn[] { (tblCogen.Columns["Name"] ?? tblCogen.Columns[0]) };
            DgvCogen.DataSource = tblCogen;

            // for tblFCell
            for (int fc = 0; fc < 6; fc++)
            {
                this.tblFCell[fc] = new DataTable("DtFCell-" + fc);
                for (int i = 0; i < colName.Length; i++)
                {
                    DataColumn col = new DataColumn(colName[i], dataType: Type.GetType(colType[i]) ?? typeof(String));
                    tblFCell[fc].Columns.Add(col);
                }
                tblFCell[fc].PrimaryKey = new DataColumn[] { tblFCell[fc].Columns["Name"] ?? tblFCell[fc].Columns[0] };
            }
            DgvFC.DataSource = tblFCell[0];
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

        private void Day4_Load(object sender, EventArgs e)
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

                    // add name on tblCogen
                    string name = pb.Name[3..];
                    tblCogen.Rows.Add(new object[] { name, 0 });
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
                    tblCogen.Rows.Add(new object[] { name, "" });
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

            // 화면을 업데이트하기 위해 Timer를 활성화한다.
            //updateTimer.Interval = 500;
            //updateTimer.Tick += UpdateTimer_Tick;
            //updateTimer.Enabled = true;
            //updateTimer.Start();
        }

        private void UpdateTimer_Tick(object? sender, EventArgs e)
        {
            Form_Refresh();
        }

        private void UpdatePicBoxes(object picParent)
        {
            if (picParent == null)
                return;

            PictureBox? pa = picParent as PictureBox;
            if (pa == null)
                return;

            foreach (var c in pa.Controls)
            {
                if (c is PictureBox pb)
                {
                    if (pb.Name.StartsWith("Pic"))
                    {
                        string name = pb.Name[3..];
                        DataRow? row = tblCogen.Rows.Find(name);
                        if (row is not null)
                        {
                            Int32 state = 0;
                            if (row[1] is string)
                            {
                                Int32.TryParse((string)row[1], out state);
                            }
                            else if (row[1] is Int32)
                            {
                                state = (Int32)row[1];
                            }
                            else
                            {
                                Debug.Print("invalid value {0}", row[1].ToString());
                                continue;
                            }

                            // set image by state
                            if (state > 0)
                            {
                                pb.BackgroundImage = Properties.Resources.dot_green;
                            }
                            else
                            {
                                pb.BackgroundImage = Properties.Resources.dot_red;
                            }
                        }
                    }
                }
            }
        }

        private void Form_Refresh()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox tb)
                {
                    if (tb.Name.StartsWith("Txt"))
                    {
                        string name = tb.Name[3..];
                        DataRow? row = tblCogen.Rows.Find(name);
                        if (row is not null)
                            tb.Text = (string)row[1];   // value
                    }
                }
                else if (c is PictureBox pb)
                {
                    UpdatePicBoxes(pb);
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

            Double value;
            bool isOk = Double.TryParse((string)txtBox.Text, out value);
            if (!isOk)
            {
                Debug.Print("invalid value {0}", txtBox.Text);
                return;
            }

            // update on DataTable
            DataRow? row = tblCogen.Rows.Find(name);
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

            // get current state
            DataRow? row = tblCogen.Rows.Find(name);
            if (row is not null)
            {
                Int32 state = 0;
                if (row[1] is string)
                {
                    Int32.TryParse((string)row[1], out state);
                }
                else if (row[1] is Int32)
                {
                    state = (Int32)row[1];
                }
                else
                {
                    Debug.Print("invalid value {0}", row[1].ToString());
                }
                row[1] = state > 0 ? 0 : 1;
            }
        }
    }
}
