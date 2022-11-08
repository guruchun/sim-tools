using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Windows.Forms;

namespace SimCogen
{
    public partial class Day1 : Form
    {
        public Day1()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            string path = TxtBoxPath.Text;
            using (StreamReader streamReader = new StreamReader(path, Encoding.Default, true))
            //using (StreamReader streamReader = new StreamReader(path, Encoding.GetEncoding("949")))     // 949(euc-kr)
            {
                TextBoxContent.Text = streamReader.ReadToEnd();
                Console.WriteLine("File Content: " + TextBoxContent.Text);
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    TxtBoxPath.Text = filePath;

                }
            }

            Console.WriteLine("File Content at path: " + filePath);
        }
    }
}