namespace Tyuiu.SilinEV.Sprint7.Project.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            buttonOpenFile = new Button();
            buttonInfo = new Button();
            labelMainMenu = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(12, 42);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(74, 61);
            buttonOpenFile.TabIndex = 25;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += button1_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(92, 42);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(74, 61);
            buttonInfo.TabIndex = 26;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += button2_Click;
            // 
            // labelMainMenu
            // 
            labelMainMenu.AutoSize = true;
            labelMainMenu.Font = new Font("Segoe UI", 16F);
            labelMainMenu.Location = new Point(12, 9);
            labelMainMenu.Name = "labelMainMenu";
            labelMainMenu.Size = new Size(165, 30);
            labelMainMenu.TabIndex = 27;
            labelMainMenu.Text = "Главное Меню";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(182, 115);
            Controls.Add(labelMainMenu);
            Controls.Add(buttonInfo);
            Controls.Add(buttonOpenFile);
            Name = "FormMain";
            Text = "Спринт 7 | ТехЗадание | Вариант 5 | Силин Е. В.";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Button buttonOpenFile;
        private Button buttonInfo;
        private Label labelMainMenu;
    }
}
