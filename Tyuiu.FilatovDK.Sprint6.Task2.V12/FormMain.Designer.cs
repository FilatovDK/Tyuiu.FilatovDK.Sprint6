namespace Tyuiu.FilatovDK.Sprint6.Task2.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonResult = new Button();
            button2 = new Button();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            groupBox1 = new GroupBox();
            dataGridViewRows = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartMain).BeginInit();
            SuspendLayout();
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(317, 415);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(84, 23);
            buttonResult.TabIndex = 0;
            buttonResult.Text = "выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // button2
            // 
            button2.Location = new Point(236, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "справка";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(118, 416);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(100, 23);
            textBoxStop.TabIndex = 2;
            textBoxStop.TextChanged += textBoxStop_TextChanged;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(12, 415);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 350);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "произвести табулирование функции на заданном диапазоне (-5; 5) с шагом 1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridViewRows
            // 
            dataGridViewRows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRows.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewRows.Location = new Point(412, 40);
            dataGridViewRows.Name = "dataGridViewRows";
            dataGridViewRows.RowHeadersVisible = false;
            dataGridViewRows.Size = new Size(105, 398);
            dataGridViewRows.TabIndex = 0;
            dataGridViewRows.CellContentClick += dataGridViewRows_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(x)";
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 5;
            label1.Text = "Условие";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 397);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 6;
            label2.Text = "Конец шага";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 382);
            label3.Name = "label3";
            label3.Size = new Size(77, 30);
            label3.TabIndex = 7;
            label3.Text = "Ввод данных\r\nСтарт шага:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 7);
            label4.Name = "label4";
            label4.Size = new Size(86, 30);
            label4.TabIndex = 8;
            label4.Text = "Вывод двнных\r\nРезультат:\r\n";
            // 
            // chartMain
            // 
            chartArea1.Name = "ChartArea1";
            chartMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartMain.Legends.Add(legend1);
            chartMain.Location = new Point(549, 39);
            chartMain.Name = "chartMain";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartMain.Series.Add(series1);
            chartMain.Size = new Size(577, 399);
            chartMain.TabIndex = 9;
            chartMain.Text = "chart1";
            chartMain.Click += chart1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 450);
            Controls.Add(chartMain);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewRows);
            Controls.Add(groupBox1);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxStop);
            Controls.Add(button2);
            Controls.Add(buttonResult);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonResult;
        private Button button2;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private GroupBox groupBox1;
        private DataGridView dataGridViewRows;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
    }
}
