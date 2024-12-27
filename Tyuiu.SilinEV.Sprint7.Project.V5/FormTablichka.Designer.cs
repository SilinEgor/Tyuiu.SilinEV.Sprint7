namespace Tyuiu.SilinEV.Sprint7.Project.V5
{
    partial class FormTablichka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            labelNum = new Label();
            textBoxWhstFind_SEV = new TextBox();
            textBoxNumColumn_SEV = new TextBox();
            chartKol_SEV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonGraf_SEV = new Button();
            buttonSearch = new Button();
            buttonSaveFile = new Button();
            dataGridView_SEV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            buttonOpenFile = new Button();
            textBoxMInMax_SEV = new TextBox();
            buttonInfo = new Button();
            chartSto_SEV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartKol_SEV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SEV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartSto_SEV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 12);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 21;
            label1.Text = "Что ищем";
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Location = new Point(259, 12);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(68, 15);
            labelNum.TabIndex = 20;
            labelNum.Text = "№ столбца";
            // 
            // textBoxWhstFind_SEV
            // 
            textBoxWhstFind_SEV.Location = new Point(455, 7);
            textBoxWhstFind_SEV.Name = "textBoxWhstFind_SEV";
            textBoxWhstFind_SEV.Size = new Size(162, 23);
            textBoxWhstFind_SEV.TabIndex = 19;
            // 
            // textBoxNumColumn_SEV
            // 
            textBoxNumColumn_SEV.Location = new Point(333, 8);
            textBoxNumColumn_SEV.Name = "textBoxNumColumn_SEV";
            textBoxNumColumn_SEV.Size = new Size(47, 23);
            textBoxNumColumn_SEV.TabIndex = 18;
            // 
            // chartKol_SEV
            // 
            chartArea3.Name = "ChartArea1";
            chartKol_SEV.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartKol_SEV.Legends.Add(legend3);
            chartKol_SEV.Location = new Point(562, 37);
            chartKol_SEV.Name = "chartKol_SEV";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartKol_SEV.Series.Add(series3);
            chartKol_SEV.Size = new Size(383, 197);
            chartKol_SEV.TabIndex = 17;
            chartKol_SEV.Text = "chart1";
            // 
            // buttonGraf_SEV
            // 
            buttonGraf_SEV.Location = new Point(829, 8);
            buttonGraf_SEV.Name = "buttonGraf_SEV";
            buttonGraf_SEV.Size = new Size(84, 23);
            buttonGraf_SEV.TabIndex = 16;
            buttonGraf_SEV.Text = "График";
            buttonGraf_SEV.UseVisualStyleBackColor = true;
            buttonGraf_SEV.Click += buttonGraf_SEV_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(197, 8);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(56, 23);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Location = new Point(116, 8);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(75, 23);
            buttonSaveFile.TabIndex = 14;
            buttonSaveFile.Text = "Сохранить";
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // dataGridView_SEV
            // 
            dataGridView_SEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SEV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView_SEV.Location = new Point(12, 37);
            dataGridView_SEV.Name = "dataGridView_SEV";
            dataGridView_SEV.Size = new Size(544, 397);
            dataGridView_SEV.TabIndex = 13;
            // 
            // Column1
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            Column1.DefaultCellStyle = dataGridViewCellStyle5;
            Column1.HeaderText = "Код товара";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Название товара";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            Column3.DefaultCellStyle = dataGridViewCellStyle6;
            Column3.HeaderText = "Кол-во на складе";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            Column4.DefaultCellStyle = dataGridViewCellStyle7;
            Column4.HeaderText = "Стоимость";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            dataGridViewCellStyle8.NullValue = null;
            Column5.DefaultCellStyle = dataGridViewCellStyle8;
            Column5.HeaderText = "Примечание";
            Column5.Name = "Column5";
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(12, 8);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(98, 23);
            buttonOpenFile.TabIndex = 12;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // textBoxMInMax_SEV
            // 
            textBoxMInMax_SEV.Location = new Point(12, 440);
            textBoxMInMax_SEV.Name = "textBoxMInMax_SEV";
            textBoxMInMax_SEV.Size = new Size(933, 23);
            textBoxMInMax_SEV.TabIndex = 22;
            textBoxMInMax_SEV.TextChanged += textBoxMInMax_SEV_TextChanged;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(919, 8);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(26, 23);
            buttonInfo.TabIndex = 23;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // chartSto_SEV
            // 
            chartArea4.Name = "ChartArea1";
            chartSto_SEV.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartSto_SEV.Legends.Add(legend4);
            chartSto_SEV.Location = new Point(561, 240);
            chartSto_SEV.Name = "chartSto_SEV";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartSto_SEV.Series.Add(series4);
            chartSto_SEV.Size = new Size(383, 194);
            chartSto_SEV.TabIndex = 24;
            chartSto_SEV.Text = "chart1";
            // 
            // FormTablichka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 470);
            Controls.Add(chartSto_SEV);
            Controls.Add(buttonInfo);
            Controls.Add(textBoxMInMax_SEV);
            Controls.Add(label1);
            Controls.Add(labelNum);
            Controls.Add(textBoxWhstFind_SEV);
            Controls.Add(textBoxNumColumn_SEV);
            Controls.Add(chartKol_SEV);
            Controls.Add(buttonGraf_SEV);
            Controls.Add(buttonSearch);
            Controls.Add(buttonSaveFile);
            Controls.Add(dataGridView_SEV);
            Controls.Add(buttonOpenFile);
            Name = "FormTablichka";
            Text = "Спринт 7 | ТехЗадание | Вариант 5 | Силин Е. В.";
            ((System.ComponentModel.ISupportInitialize)chartKol_SEV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SEV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartSto_SEV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNum;
        private TextBox textBoxWhstFind_SEV;
        private TextBox textBoxNumColumn_SEV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKol_SEV;
        private Button buttonGraf_SEV;
        private Button buttonSearch;
        private Button buttonSaveFile;
        private DataGridView dataGridView_SEV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button buttonOpenFile;
        private TextBox textBoxMInMax_SEV;
        private Button buttonInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSto_SEV;
    }
}