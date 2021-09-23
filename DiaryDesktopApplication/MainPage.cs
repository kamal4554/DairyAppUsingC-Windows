using System;
using System.Windows.Forms;

namespace DiaryDesktopApplication
{
  public partial class MainPage : Form
  {
    public MainPage(string text)
    {
      InitializeComponent();
      lblres.Text = System.Environment.MachineName;
     // lblres.Text = text;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Maximized;
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AddForm newMDIChild = new AddForm();// // Set the Parent Form of the Child window.
      newMDIChild.MdiParent = this;//// Display the new form.
      newMDIChild.Show();
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
      EditForm newMDIChild = new EditForm();
      // Set the Parent Form of the Child window.
      newMDIChild.MdiParent = this;
      // Display the new form.
      newMDIChild.Show();
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DeleteForm newMDIChild = new DeleteForm();
      // Set the Parent Form of the Child window.
      newMDIChild.MdiParent = this;
      // Display the new form.
      newMDIChild.Show();
    }

    private void searchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SearchForm newMDIChild = new SearchForm();
      // Set the Parent Form of the Child window.
      newMDIChild.MdiParent = this;
      // Display the new form.
      newMDIChild.Show();
    }

    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string message = "Do you want to Logout?";
      string title = "Close Window";
      MessageBoxButtons buttons = MessageBoxButtons.YesNo;
      DialogResult result = MessageBox.Show(message, title, buttons);
      if (result == DialogResult.Yes)
      {
        Application.Exit();
      }
      else
      {
        
      }
      
    }

    private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Feedback newMDIChild = new Feedback();
      // Set the Parent Form of the Child window.
      newMDIChild.MdiParent = this;
      // Display the new form.
      newMDIChild.Show();
    }
  }
}
