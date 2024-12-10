using Tyuiu.FilatovDK.Sprint6.Task2.V12.Lib;
namespace Tyuiu.FilatovDK.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStart.Text);
                int stopstep = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(startstep, stopstep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startstep, stopstep);
                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewRows.Rows.Add(Convert.ToString(startstep), Convert.ToString(valueArray[i]));


                    startstep++;

                }



            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void chartFunction_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRows_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxStop_TextChanged(object sender, EventArgs e)
        {

        }
    }
}