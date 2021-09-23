using System;
using System.IO;
using System.Windows.Forms;

namespace DiaryDesktopApplication
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }
        private void btnget_Click(object sender, EventArgs e)
        {
            var currentDate = txtdate.Value;
            string[] result = currentDate.ToString().Split(' ');
            string getdata = result[0];
            string path = AppDomain.CurrentDomain.BaseDirectory + "Dairy\\" + getdata + ".txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("No file created on: " + getdata, "Edit");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var currentDate = txtdate.Value;
            string[] result = currentDate.ToString().Split(' ');
            string getdata = result[0];
            string path = AppDomain.CurrentDomain.BaseDirectory + "Dairy\\" + getdata + ".txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("File not exists on: " + getdata, "File");
                txtmsg.Text = "";
            }
            else
            {
                File.Delete(path);
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(txtmsg.Text);
                    MessageBox.Show("Updated Successfully", "Update");
                    txtmsg.Text = "";
                }
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            txtdate.Format = DateTimePickerFormat.Short;
            txtdate.Value = DateTime.Today;
        }
    }
}
