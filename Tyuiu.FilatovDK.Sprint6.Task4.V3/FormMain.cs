using Tyuiu.FilatovDK.Sprint6.Task5.V3.Lib;
namespace Tyuiu.FilatovDK.Sprint6.Task5.V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = $@"C:\DataSprint6\InPutDataFileTask5V3.txt";

        private void buttonHelp_ATY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void textBoxStartValue_ATY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxStopValue_ATY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_ATY_Click(object sender, EventArgs e)
        {
            dataGridViewResult_ATY.ColumnCount = 2;
            dataGridViewResult_ATY.Columns[0].Width = 20;
            dataGridViewResult_ATY.Columns[1].Width = 50;
            this.chartFunction_ATY.ChartAreas[0].AxisX.Title = " X";
            this.chartFunction_ATY.ChartAreas[0].AxisY.Title = " Y";
            chartFunction_ATY.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_ATY.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_ATY.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonSave_ATY_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}