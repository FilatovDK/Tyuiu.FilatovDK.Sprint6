using Tyuiu.FilatovDK.Sprint6.Task6.V29.Lib;
namespace Tyuiu.FilatovDK.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {


            DataService ds = new DataService();
            string path;
            public FormMain()
            {
                InitializeComponent();
            }

            private void buttonOpen_GVM_Click(object sender, EventArgs e)
            {
                openFileDialogTask_FDK.ShowDialog();
                path = openFileDialogTask_FDK.FileName;
                textBoxV_FDK.Text = File.ReadAllText(path);
                groupBoxV_FDK.Text = groupBoxV_FDK.Text + " " + path;
                buttonDone_FDK.Enabled = true;
            }

            private void buttonDone_GVM_Click(object sender, EventArgs e)
            {
                textBoxRes_FDK.Text = ds.CollectTextFromFile(path);
            }

            private void buttonSp_GVM_Click(object sender, EventArgs e)
            {
                FormAbout formAbout = new FormAbout();
                formAbout.ShowDialog();
            }

            private void FormMain_Load(object sender, EventArgs e)
            {

            }
        }
    }
