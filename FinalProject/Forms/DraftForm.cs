using FinalProject.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Core;

namespace FinalProject.Forms
{
  public partial class DraftForm : Form
  {
    readonly DataBaseManager baseManager = new DataBaseManager();
    public DraftForm()
    {
      InitializeComponent();
    }

    private void DraftForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void DraftForm_Load(object sender, EventArgs e)
    {
      List<string> names = baseManager.DraftNames(User.UserId);
      DraftField.Text = string.Join(Environment.NewLine, names);
    }

    private void NewResumeButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      InfoForm infoForm = new InfoForm();
      infoForm.Show();
    }

    private void ChoiseDraftButton_Click(object sender, EventArgs e) 
    {
      if (DraftChoiseField.Text == "Введите ФИО")
      {
        DraftChoiseField.ForeColor = Color.Red;
        MessageBox.Show("Заполните поле");
        return;
      }

      PersonalInfo person = baseManager.FindInfoByFullName(DraftChoiseField.Text);
      if (person != null && !string.IsNullOrEmpty(person.FullName))
      { 
        this.Hide();
        InfoForm infoForm = new InfoForm(person);
        infoForm.Show();
      }
      else
      {
        MessageBox.Show("Такого черновика не существует, попробуйте еще");
      }

    }
    private void DraftChoiseField_Click(object sender, EventArgs e)
    {
      if (DraftChoiseField.Text == "Введите ФИО")
        DraftChoiseField.Text = "";
    }
    
    private void DraftChoiseField_Leave(object sender, EventArgs e)
    {
      if (DraftChoiseField.Text == "")
        DraftChoiseField.Text = "Введите ФИО";
    }

    private void DraftChoiseField_TextChanged(object sender, EventArgs e)
    {
      DraftChoiseField.ForeColor = Color.Black;
    }
  }
}
