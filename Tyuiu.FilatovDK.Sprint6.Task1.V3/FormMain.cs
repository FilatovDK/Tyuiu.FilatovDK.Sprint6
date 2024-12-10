using Tyuiu.FilatovDK.Sprint6.Task1.V3.Lib;

namespace Tyuiu.FilatovDK.Sprint6.Task1.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_FDK_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(textBoxstartStep_FDK.Text);
            int end = Convert.ToInt32(textBoxstopStep_FDK.Text);

            double[] valueArray = ds.GetMassFunction(start, end);
            textBoxResult.Text = "";
            textBoxResult.AppendText("+---------+--------------+" + Environment.NewLine);
            textBoxResult.AppendText("|    X    |      f(x)    |" + Environment.NewLine);
            textBoxResult.AppendText("+---------+--------------+" + Environment.NewLine);
            for (int i = 0; i <= valueArray.Length; i++)
            {
                strLine = String.Format("| {0,5:d}     |  {1, 7:f2}  | ", start, valueArray[i]);
                textBoxResult_FDK.AppendText(strLine + Environment.NewLine);
                start++;
            }
            textBoxResult.AppendText("+---------+--------------+" + Environment.NewLine);
        }
        catch
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    

        private void buttonHelp_FDK_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxstartStep_FDK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}