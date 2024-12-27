using Tyuiu.SilinEV.Sprint7.Project.V5.Lib;

namespace Tyuiu.SilinEV.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        public static string filePath;
        FormTablichka Tab = new();

        public FormMain()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInfo inf = new();
            inf.Show();
        }
    }
}
