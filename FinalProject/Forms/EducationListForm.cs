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
  public partial class EducationListForm : Form
  {
    readonly DataBase.DataBaseManager baseManager = new DataBase.DataBaseManager();
    

    private void EducationListForm_Load(object sender, EventArgs e)
    {
      List<string> list = baseManager.EducationList(PersonalInfo.PersonalInfoId);
      int yPos = 10;
      foreach (string name in list)
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

    private void EducationListForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void DeleteEducationButton_Click(object sender, EventArgs e)
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

        string selectedInstitution = selectedRadioButton.Text;
        baseManager.DeleteEducation(selectedInstitution);

        this.Hide();
        EducationListForm educationListForm = new EducationListForm();
        educationListForm.Show();
      }
      else
      {
        MessageBox.Show("Выберите один из вариантов");
      }
    }

    private void EditEducation_Click(object sender, EventArgs e)
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
        string selectedInstitution = selectedRadioButton.Text;
        Education education = baseManager.FindEducationByInstitution(selectedInstitution);

        this.Hide();
        EducationForm educationForm = new EducationForm(education);
        educationForm.Show();
      }

      else
      {
        MessageBox.Show("Выберите один из вариантов");
      }
    }

    private void NextFormButton_Click(object sender, EventArgs e)
    {
      SkillsForm skillsForm = new SkillsForm();
      skillsForm.Show();
      this.Hide();
    }

    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      EducationForm educationForm = new EducationForm();
      educationForm.Show();
      this.Hide();
    }

    public EducationListForm()
    {
      InitializeComponent();
    }
  }
}
