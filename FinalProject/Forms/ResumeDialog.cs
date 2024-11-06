using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Forms
{
  public partial class ResumeDialog : Form
  {
    public ResumeDialog()
    {
      InitializeComponent();
    }

    private void ResumeDialog_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void OpenDraftButton_Click(object sender, EventArgs e)
    {

    }

    private void NewResumeButton_Click(object sender, EventArgs e)
    {
      InfoForm infoForm = new InfoForm();
      infoForm.Show();
      this.Hide();
    }
  }
}
