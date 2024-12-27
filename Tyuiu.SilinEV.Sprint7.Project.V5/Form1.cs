using Microsoft.VisualBasic.Logging;
using Tyuiu.SilinEV.Sprint7.Project.V5.Lib;

namespace Tyuiu.SilinEV.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        public static string filePath;

        public FormMain()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            ToolTip tt = new();
            tt.SetToolTip(buttonOpenFile, "открывает файл формата csv");
            tt.SetToolTip(buttonInfo, "выводит информацию о программе");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInfo inf = new();
            inf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                FormTablichka Tab = new();
                Tab.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
