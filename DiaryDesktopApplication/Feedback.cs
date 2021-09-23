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
  public partial class Feedback : Form
  {
    public Feedback()
    {
      InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (txtmsg.Text.Length > 0)
      {
        string path = AppDomain.CurrentDomain.BaseDirectory +"Feedback\\" + System.Environment.MachineName+".txt";
        if (!File.Exists(path))
        {
          File.CreateText(path).Dispose();
          using (StreamWriter sw = new StreamWriter(path))
          {
            sw.WriteLine(txtmsg.Text);
            MessageBox.Show("Feedback Submitted Successfully","Feedback");
            txtmsg.Text = "";
          }
        }
        else
        {
          using (StreamWriter sw = new StreamWriter(path))
          {
            sw.WriteLine(txtmsg.Text);
            MessageBox.Show("Feedback Submitted Successfully", "Feedback");
            txtmsg.Text = "";
          }
        }
      }
      else
        MessageBox.Show("Please enter some text","File");
    }
  }
}
