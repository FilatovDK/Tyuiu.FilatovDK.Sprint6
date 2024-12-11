namespace Tyuiu.FilatovDK.Sprint6.Task3.V26
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            dataGridViewMatrix_FDK = new DataGridView();
            buttonDone_FDK = new Button();
            textBox2 = new TextBox();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_FDK).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(0, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 198);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridViewMatrix_FDK
            // 
            dataGridViewMatrix_FDK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_FDK.Location = new Point(253, 36);
            dataGridViewMatrix_FDK.Name = "dataGridViewMatrix_FDK";
            dataGridViewMatrix_FDK.RowHeadersVisible = false;
            dataGridViewMatrix_FDK.Size = new Size(338, 293);
            dataGridViewMatrix_FDK.TabIndex = 0;
            // 
            // buttonDone_FDK
            // 
            buttonDone_FDK.Location = new Point(686, 415);
            buttonDone_FDK.Name = "buttonDone_FDK";
            buttonDone_FDK.Size = new Size(75, 23);
            buttonDone_FDK.TabIndex = 1;
            buttonDone_FDK.Text = "Выполнить";
            buttonDone_FDK.UseVisualStyleBackColor = true;
            buttonDone_FDK.Click += FormMain_Load;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(661, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(661, 415);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(19, 23);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
           /// buttonHelp.Click += buttonHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(textBox2);
            Controls.Add(buttonDone_FDK);
            Controls.Add(dataGridViewMatrix_FDK);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_FDK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewMatrix_FDK;
        private Button buttonDone_FDK;
        private TextBox textBox2;
        private Button buttonHelp;
    }
}
