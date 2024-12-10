namespace Tyuiu.FilatovDK.Sprint6.Task1.V3
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
            textBoxResult = new TextBox();
            buttonHelp_FDK = new Button();
            textBoxstartStep_FDK = new TextBox();
            textBoxstopStep_FDK = new TextBox();
            SuspendLayout();
            // 
            // buttonDone_FDK
            // 
            buttonDone_FDK.Location = new Point(480, 400);
            buttonDone_FDK.Name = "buttonDone_FDK";
            buttonDone_FDK.Size = new Size(75, 23);
            buttonDone_FDK.TabIndex = 0;
            buttonDone_FDK.Text = "Выполнить";
            buttonDone_FDK.UseVisualStyleBackColor = true;
            buttonDone_FDK.Click += buttonDone_FDK_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(648, 54);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 1;
            // 
            // buttonHelp_FDK
            // 
            buttonHelp_FDK.Location = new Point(385, 400);
            buttonHelp_FDK.Name = "buttonHelp_FDK";
            buttonHelp_FDK.Size = new Size(75, 23);
            buttonHelp_FDK.TabIndex = 2;
            buttonHelp_FDK.Text = "Справка";
            buttonHelp_FDK.UseVisualStyleBackColor = true;
            // 
            // textBoxstartStep_FDK
            // 
            textBoxstartStep_FDK.Location = new Point(12, 35);
            textBoxstartStep_FDK.Name = "textBoxstartStep_FDK";
            textBoxstartStep_FDK.Size = new Size(100, 23);
            textBoxstartStep_FDK.TabIndex = 3;
            // 
            // textBoxstopStep_FDK
            // 
            textBoxstopStep_FDK.Location = new Point(82, 97);
            textBoxstopStep_FDK.Name = "textBoxstopStep_FDK";
            textBoxstopStep_FDK.Size = new Size(100, 23);
            textBoxstopStep_FDK.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxstopStep_FDK);
            Controls.Add(textBoxstartStep_FDK);
            Controls.Add(buttonHelp_FDK);
            Controls.Add(textBoxResult);
            Controls.Add(buttonDone_FDK);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_FDK;
        private TextBox textBoxResult;
        private Button buttonHelp_FDK;
        private TextBox textBoxstartStep_FDK;
        private TextBox textBoxstopStep_FDK;
    }
}
