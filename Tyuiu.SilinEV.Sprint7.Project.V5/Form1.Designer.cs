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
            button1 = new Button();
            button2 = new Button();
            labelMainMenu = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 42);
            button1.Name = "button1";
            button1.Size = new Size(74, 61);
            button1.TabIndex = 25;
            button1.Text = "Открыть файл";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(92, 42);
            button2.Name = "button2";
            button2.Size = new Size(74, 61);
            button2.TabIndex = 26;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormMain";
            Text = "Спринт 7 | ТехЗадание | Вариант 5 | Силин Е. В.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private Label labelMainMenu;
    }
}
