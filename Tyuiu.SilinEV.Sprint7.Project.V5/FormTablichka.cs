using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SilinEV.Sprint7.Project.V5.Lib;

namespace Tyuiu.SilinEV.Sprint7.Project.V5
{
    public partial class FormTablichka : Form
    {
        string filePath = FormMain.filePath;
        DataService ds = new();

        public FormTablichka()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            ToolTip tt = new();
            tt.SetToolTip(buttonOpenFile, "открывает файл формата csv");
            tt.SetToolTip(buttonSaveFile, "сохраняет изменения в файле формата csv");
            tt.SetToolTip(buttonSearch, "ищет строки по заданым критериям(№ столбца, то что нужно найти)");
            tt.SetToolTip(buttonGraf_SEV, "строит график по выделенным столбцам");
            tt.SetToolTip(buttonInfo, "выводит информацию о программе");

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                int rows = lines.Length;

                int column = lines[0].Split(';').Length;

                Object[,] matrix = new Object[rows, column];

                for (int i = 0; i < rows; i++)
                {
                    String[] values = lines[i].Split(";");
                    for (int j = 0; j < column; j++)
                    {
                        try
                        {
                            matrix[i, j] = int.Parse(values[j]);
                        }
                        catch
                        {
                            matrix[i, j] = values[j];
                        }
                    }
                }

                dataGridView_SEV.Rows.Clear();

                int rowCount = matrix.GetLength(0);
                int columnCount = matrix.GetLength(1);

                for (int i = 0; i < rowCount; i++)
                {
                    var row = new DataGridViewRow();
                    for (int j = 0; j < columnCount; j++)
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = matrix[i, j] });
                    }
                    dataGridView_SEV.Rows.Add(row);
                }

                Chart ch1 = chartKol_SEV;
                Chart ch2 = chartSto_SEV;
                ch1.Titles.Add("Кол-во товаров");
                ch2.Titles.Add("Стоимость товара");
                ch1.Series.Clear();
                ch2.Series.Clear();
                for (int i = 0; i < rows; i++)
                {
                    dataGridView_SEV.CurrentCell = dataGridView_SEV[1, i];
                    ch1.Series.Add(Convert.ToString(dataGridView_SEV.CurrentCell.Value));

                    dataGridView_SEV.CurrentCell = dataGridView_SEV[2, i];
                    ch1.Series[i].Points.AddY(Convert.ToDouble(dataGridView_SEV.CurrentCell.Value));

                    dataGridView_SEV.CurrentCell = dataGridView_SEV[1, i];
                    ch2.Series.Add(Convert.ToString(dataGridView_SEV.CurrentCell.Value));

                    dataGridView_SEV.CurrentCell = dataGridView_SEV[3, i];
                    ch2.Series[i].Points.AddY(Convert.ToDouble(dataGridView_SEV.CurrentCell.Value));
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                string[] lines = File.ReadAllLines(filePath);
                int rows = lines.Length;

                int column = lines[0].Split(';').Length;

                Object[,] matrix = new Object[rows, column];

                for (int i = 0; i < rows; i++)
                {
                    String[] values = lines[i].Split(";");
                    for (int j = 0; j < column; j++)
                    {
                        try
                        {
                            matrix[i, j] = int.Parse(values[j]);
                        }
                        catch
                        {
                            matrix[i, j] = values[j];
                        }
                    }
                }

                dataGridView_SEV.Rows.Clear();

                int rowCount = matrix.GetLength(0);
                int columnCount = matrix.GetLength(1);

                for (int i = 0; i < rowCount; i++)
                {
                    var row = new DataGridViewRow();
                    for (int j = 0; j < columnCount; j++)
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = matrix[i, j] });
                    }
                    dataGridView_SEV.Rows.Add(row);
                }
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    int rowCount = dataGridView_SEV.RowCount;
                    int columnCount = dataGridView_SEV.ColumnCount;

                    for (int i = 0; i < rowCount - 1; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            dataGridView_SEV.CurrentCell = dataGridView_SEV[j, i];
                            writer.Write(dataGridView_SEV.CurrentCell.Value);
                            if (j < columnCount - 1)
                            {
                                writer.Write(";");
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }
            catch
            {

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int NumOfColumn = Convert.ToInt32(textBoxNumColumn_SEV.Text) - 1;
                string Find = textBoxWhstFind_SEV.Text;
                if (Find != "")
                {
                    for (int i = 0; i < dataGridView_SEV.RowCount; i++)
                    {
                        DataGridViewBand band = dataGridView_SEV.Rows[i];
                        band.Visible = true;
                    }
                    for (int i = 0; i < dataGridView_SEV.RowCount - 1; i++)
                    {
                        DataGridViewBand band = dataGridView_SEV.Rows[i];
                        dataGridView_SEV.CurrentCell = dataGridView_SEV[NumOfColumn, i];
                        if (Convert.ToString(dataGridView_SEV.CurrentCell.Value) == Find) band.Visible = true;
                        else band.Visible = false;
                    }
                }
                else
                {
                    for (int i = 0; i < dataGridView_SEV.RowCount; i++)
                    {
                        DataGridViewBand band = dataGridView_SEV.Rows[i];
                        band.Visible = true;
                    }
                }
            }
            catch
            {

            }
        }

        private void buttonGraf_SEV_Click(object sender, EventArgs e)
        {
            Chart ch1 = chartKol_SEV;
            Chart ch2 = chartSto_SEV;
            ch1.Series.Clear();
            ch2.Series.Clear();
            for (int i = 0; i < dataGridView_SEV.Rows.Count - 1; i++)
            {
                dataGridView_SEV.CurrentCell = dataGridView_SEV[1, i];
                ch1.Series.Add(Convert.ToString(dataGridView_SEV.CurrentCell.Value));

                dataGridView_SEV.CurrentCell = dataGridView_SEV[2, i];
                ch1.Series[i].Points.AddY(Convert.ToDouble(dataGridView_SEV.CurrentCell.Value));

                dataGridView_SEV.CurrentCell = dataGridView_SEV[1, i];
                ch2.Series.Add(Convert.ToString(dataGridView_SEV.CurrentCell.Value));

                dataGridView_SEV.CurrentCell = dataGridView_SEV[3, i];
                ch2.Series[i].Points.AddY(Convert.ToDouble(dataGridView_SEV.CurrentCell.Value));
            }
        }

        private void textBoxMInMax_SEV_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInfo inf = new();
            inf.Show();
        }
    }
}
