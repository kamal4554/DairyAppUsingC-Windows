using System;
using System.Windows.Forms;

namespace DiaryDesktopApplication
{
  public partial class Login : Form
  {
    public Login()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (textBox1.Text=="Kamal" && textBox2.Text=="123")
      {
        MessageBox.Show("Login Success...");
        this.Hide();
        var mainpage = new MainPage(textBox1.Text);
        mainpage.Closed += (s, args) => this.Close();
        mainpage.Show();
        //this.Close();
      }
      else
      {
        MessageBox.Show("Login Failed...");
      }
    }
  }
}
