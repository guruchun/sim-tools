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
    public partial class Day2 : Form
    {
        public Day2()
        {
            InitializeComponent();
        }

        private void Day2_Load(object sender, EventArgs e)
        {
            // ComboBox 초기화
            // design time에 입력한 item을 제거한다.
            this.comboBox1.Items.Clear();
            // configuration에 따라 FC의 개수만큼 설정한다.
            List<string> fcList = new() { "01", "02", "03", "04", "05", "06" };
            this.comboBox1.Items.AddRange(fcList.ToArray());
            this.comboBox1.SelectedIndex = 0;

            // ListView 초기화
            // Design Time에 입력한 컬럼과 Item을 제거한다.

            // Loading된 데이터로 초기화한다.
        }
    }
}
