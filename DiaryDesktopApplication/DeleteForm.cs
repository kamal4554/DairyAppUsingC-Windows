using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiaryDesktopApplication
{
  public partial class DeleteForm : Form
  {
    public DeleteForm()
    {
      InitializeComponent();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      var currentDate = txtdate.Value;
      string[] result = currentDate.ToString().Split(' ');
      string getdata = result[0];
      string path = AppDomain.CurrentDomain.BaseDirectory + "Dairy\\" + getdata + ".txt";
      if (File.Exists(path))
      {
        File.Delete(path);
        MessageBox.Show("File Deleted Successfully","Delete");
      }
      else
        MessageBox.Show("File not exists on: "+ getdata);
    }

    private void DeleteForm_Load(object sender, EventArgs e)
    {
      txtdate.Format = DateTimePickerFormat.Short;
      txtdate.Value = DateTime.Today;
    }
  }
}
