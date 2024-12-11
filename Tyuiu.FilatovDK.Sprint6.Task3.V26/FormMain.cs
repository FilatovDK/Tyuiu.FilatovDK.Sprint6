using Tyuiu.FilatovDK.Sprint6.Task3.V26.Lib;
namespace Tyuiu.FilatovDK.Sprint6.Task3.V26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelp_FDK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск3 Выполнил студент Филаитов Денис СМАРТб-24-1");
        }
        private void buttonDone_FDK_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mt);
            int row = res.GetUpperBound(0) + 1;
            int col = res.Length / row;
            dataGridViewMatrix_FDK.ColumnCount = col;
            dataGridViewMatrix_FDK.RowCount = row;
            for (int i = 0; i < col; i++)
            {
                dataGridViewMatrix_FDK.Columns[i].Width = 25;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewMatrix_FDK.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }

        }

        int[,] mt = { { 16, 19, 17, 2, 8 }, { -17, 8, -17, -8, 1 }, { -7, 17, -2, 1, -3 }, { -12, 0, -17, 15, 6 }, { 17, -6, -17, 18, -19 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mt.GetUpperBound(0) + 1;
            int cols = mt.Length / rows;
            dataGridViewMatrix_FDK.ColumnCount = cols;
            dataGridViewMatrix_FDK.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix_FDK.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_FDK.Rows[i].Cells[j].Value = Convert.ToString(mt[i, j]);
                }
            }
        }


    }
}
