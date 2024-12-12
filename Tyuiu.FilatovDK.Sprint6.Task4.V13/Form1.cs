using Tyuiu.FilatovDK.Sprint6.Task4.V13.Lib;
namespace Tyuiu.FilatovDK.Sprint6.Task4.V13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void SolveButton_PKK_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(InputTextBoxStart_PKK.Text);
                int stopValue = Convert.ToInt32(InputTextBoxStop_PKK.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] TempArray = new double[len];

                TempArray = ds.GetMassFunction(startValue, stopValue);

                this.ChartFunctionResult_PKK.ChartAreas[0].AxisX.Title = " X";
                this.ChartFunctionResult_PKK.ChartAreas[0].AxisY.Title = " Y";

                ResultTextBox_PKK.Text = "";

                ChartFunctionResult_PKK.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.ChartFunctionResult_PKK.Series[0].Points.AddXY(startValue, TempArray[i]);
                    ResultTextBox_PKK.AppendText(TempArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HelpButton_PKK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveButton_PKK_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine("C:", "DataSprint6", "OutPutDataFileTask4V13.txt");
                File.WriteAllText(path, ResultTextBox_PKK.Text);

                DialogResult dr = MessageBox.Show("\n", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
