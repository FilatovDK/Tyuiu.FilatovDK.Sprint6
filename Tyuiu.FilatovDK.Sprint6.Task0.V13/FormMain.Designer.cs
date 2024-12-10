namespace Tyuiu.FilatovDK.Sprint6.Task0.V13
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
            buttonDone_FDK = new Button();
            textBoxResult_FDK = new TextBox();
            textBoxValueX_FDK = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonHelp_FDK = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_FDK
            // 
            buttonDone_FDK.Location = new Point(713, 415);
            buttonDone_FDK.Name = "buttonDone_FDK";
            buttonDone_FDK.Size = new Size(75, 23);
            buttonDone_FDK.TabIndex = 0;
            buttonDone_FDK.Text = "Выполнить";
            buttonDone_FDK.UseVisualStyleBackColor = true;
            buttonDone_FDK.Click += buttonDone_FDK_Click;
            // 
            // textBoxResult_FDK
            // 
            textBoxResult_FDK.Location = new Point(688, 386);
            textBoxResult_FDK.Multiline = true;
            textBoxResult_FDK.Name = "textBoxResult_FDK";
            textBoxResult_FDK.Size = new Size(100, 23);
            textBoxResult_FDK.TabIndex = 2;
            textBoxResult_FDK.TextChanged += textBoxResult_FDK_TextChanged;
            // 
            // textBoxValueX_FDK
            // 
            textBoxValueX_FDK.Location = new Point(43, 386);
            textBoxValueX_FDK.Multiline = true;
            textBoxValueX_FDK.Name = "textBoxValueX_FDK";
            textBoxValueX_FDK.Size = new Size(100, 23);
            textBoxValueX_FDK.TabIndex = 3;
            textBoxValueX_FDK.TextChanged += textBoxValueX_FDK_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 341);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 4;
            label1.Text = "Ввод данных: \r\nПеременная X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 5;
            label2.Text = "Условие";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 34);
            label3.Name = "label3";
            label3.Size = new Size(205, 30);
            label3.TabIndex = 6;
            label3.Text = "Вычислить выражения по формуле\r\n\r\n";
            label3.Click += label3_Click;
            // 
            // buttonHelp_FDK
            // 
            buttonHelp_FDK.Location = new Point(688, 415);
            buttonHelp_FDK.Name = "buttonHelp_FDK";
            buttonHelp_FDK.Size = new Size(19, 23);
            buttonHelp_FDK.TabIndex = 7;
            buttonHelp_FDK.Text = "?";
            buttonHelp_FDK.UseVisualStyleBackColor = true;
            buttonHelp_FDK.Click += buttonHelp_FDK_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.такс0;
            pictureBox1.Location = new Point(667, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 73);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 448);
            Controls.Add(pictureBox1);
            Controls.Add(buttonHelp_FDK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxValueX_FDK);
            Controls.Add(textBoxResult_FDK);
            Controls.Add(buttonDone_FDK);
            Name = "FormMain";
            Text = "Спринт 6| Таск0 | Вариант 13| Филатов Д.К ";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_FDK;
        private TextBox textBoxResult_FDK;
        private TextBox textBoxValueX_FDK;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonHelp_FDK;
        private PictureBox pictureBox1;
    }
}
