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

namespace FinalProject.Forms
{
  public partial class EducationForm : Form
  {
    readonly DataBaseManager baseManager = new DataBaseManager();
   readonly private ExperienceForm experienceForm;
    private SkillsForm skillsForm;
   readonly Education education = new Education();
    public EducationForm(ExperienceForm experienceForm)
    {
      InitializeComponent();
      this.experienceForm = experienceForm;
    }
    private void InstitutionField_Click(object sender, EventArgs e)
    {
      if (InstitutionField.Text == "Учебное заведение")
      {
        InstitutionField.Text = "";
      }
    }
    private void InstitutionField_TextChanged(object sender, EventArgs e)
    {
      education.Institution = InstitutionField.Text;
    }
    private void InstitutionField_Leave(object sender, EventArgs e)
    {
      if (InstitutionField.Text == "")
      {
        InstitutionField.Text = "Учебное заведение";

      }
    }
    private void SpecialtyField_Click(object sender, EventArgs e)
    {
      if (SpecialtyField.Text == "Специальность")
      {
        SpecialtyField.Text = "";
      }
    }
    private void SpecialtyField_TextChanged(object sender, EventArgs e)
    {
      education.Specialty = SpecialtyField.Text;
    }
    private void SpecialtyField_Leave(object sender, EventArgs e)
    {
      if (SpecialtyField.Text == "")
      {
        SpecialtyField.Text = "Специальность";

      }
    }
    private void YearOfGraduationField_ValueChanged(object sender, EventArgs e)
    {
      education.YearOfGraduation = Convert.ToInt32(YearOfGraduationField.Text);
    }

    private void AddMoreEducation_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
      {
        baseManager.AddEducation(education);

        foreach (Control control in this.Controls)
        {
          if (control is TextBox textBox)
          {
            textBox.Text = string.Empty;
          }
        }
      }
      else MessageBox.Show("Сначала необходимо заполнить все поля");
    }

    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      experienceForm.Show();
      this.Hide();
    }

    private void NoEducationButton_Click(object sender, EventArgs e)
    {
      skillsForm = new SkillsForm(this);
      skillsForm.Show();
      this.Hide();
    }

    private void SaveAndNextButton_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
      {
        baseManager.AddEducation(education);
        skillsForm = new SkillsForm(this);
        skillsForm.Show();
        this.Hide();
      }

      else MessageBox.Show("Необходимо заполнить все поля");
    }
    public bool IsFieldsFilled()
    {
      if (InstitutionField.Text == "Учебное заведение")
      {

        InstitutionField.ForeColor = Color.Red;
        return false;
      }

      if (SpecialtyField.Text == "Специальность")
      {
        SpecialtyField.ForeColor = Color.Red;
        return false;
      }

      else return true;
    }

    private void EducationForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }
  }
}
