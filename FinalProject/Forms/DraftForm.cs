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
    readonly DataBase.DataBaseManager baseManager = new DataBase.DataBaseManager();
    

    private void DraftForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void DraftForm_Load(object sender, EventArgs e)
    {
      List<string> names = baseManager.DraftNames(User.UserId);
      int yPos = 10; 
      foreach (string name in names)
      {
        RadioButton radioButton = new RadioButton
        {
          Text = name,
          Location = new Point(10, yPos),
          AutoSize = true
        };
        radioPanel.Controls.Add(radioButton);
        yPos += radioButton.Height + 5; 
      }
    }
    private void NewResumeButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      InfoForm infoForm = new InfoForm();
      infoForm.Show();
    }

    private void ChoiseDraftButton_Click(object sender, EventArgs e)
    {
      RadioButton selectedRadioButton = null;
      foreach (Control control in radioPanel.Controls)
      {
        if (control is RadioButton radioButton && radioButton.Checked)
        {
          selectedRadioButton = radioButton;
          break;
        }
      }

      if (selectedRadioButton != null)
      {
        string selectedName = selectedRadioButton.Text;
        PersonalInfo person = baseManager.FindInfoByFullName(selectedName);

        this.Hide();
        InfoForm infoForm = new InfoForm(person);
        infoForm.Show();
      }

      else
      {
        MessageBox.Show("Выберите один из вариантов");
      }
    }
    
 
    private void DeleteDraftButton_Click(object sender, EventArgs e)
    {
      RadioButton selectedRadioButton = null;
      foreach (Control control in radioPanel.Controls)
      {
        if (control is RadioButton radioButton && radioButton.Checked)
        {
          selectedRadioButton = radioButton;
          break;
        }
      }
      if (selectedRadioButton != null)
      {

        string selectedName = selectedRadioButton.Text;
        baseManager.DeleteDraft(selectedName, PersonalInfo.PersonalInfoId);

        this.Hide();
        DraftForm draft = new DraftForm();
        draft.Show();
      }
      else
      {
        MessageBox.Show("Выберите один из вариантов");
      }
    }

    public DraftForm()
    {
      InitializeComponent();
    }
  }
}
