using System;
using System.IO;
using System.Windows.Forms;

namespace DiaryDesktopApplication
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var currentDate = txtdate.Value;
            string[] result = currentDate.ToString().Split(' ');
            string getdata = result[0];
            string path = AppDomain.CurrentDomain.BaseDirectory + "Dairy\\" + getdata + ".txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("No file created on: " + getdata);
                txtmsg.Text = "";
            }
            else
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    txtmsg.Text = sw.ReadToEnd();
                }
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            txtdate.Format = DateTimePickerFormat.Short;
            txtdate.Value = DateTime.Today;
        }
    }
}
