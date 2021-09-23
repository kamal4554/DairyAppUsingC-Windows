using System;
using System.IO;
using System.Windows.Forms;

namespace DiaryDesktopApplication
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtmsg.Text.Length > 0)
            {
                var currentDate = txtdate.Value;
                string[] result = currentDate.ToString().Split(' ');
                string getdata = result[0];
                string path = AppDomain.CurrentDomain.BaseDirectory + "Dairy\\" + getdata + ".txt";
                if (!File.Exists(path))
                {
                    File.CreateText(path).Dispose();
                    MessageBox.Show("File is Created", "File");
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(txtmsg.Text);
                        MessageBox.Show("Added Successfully");
                        txtmsg.Text = "";
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(txtmsg.Text);
                        MessageBox.Show("Added Successfully", "Add");
                        txtmsg.Text = "";
                    }
                }
            }
            else
                MessageBox.Show("Please enter some text");

        }
        private void AddForm_Load(object sender, EventArgs e)
        {
            txtdate.Format = DateTimePickerFormat.Short;
            txtdate.Value = DateTime.Today;
        }
    }
}
