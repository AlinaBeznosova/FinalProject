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
  public partial class EducationForm : Form
  {
    readonly DataBase.DataBaseManager baseManager = new DataBase.DataBaseManager();
    readonly private ExperienceForm experienceForm;
    private SkillsForm skillsForm;
   readonly Education education = new Education();
    public EducationForm()
    {
      InitializeComponent();
    }
   
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
    private void YearOfGraduationField_Click(object sender, EventArgs e)
    {
      if (YearOfGraduationField.Text == "Год окончания")
      {
        YearOfGraduationField.Text = "";
      }
    }
    private void YearOfGraduationField_TextChanged(object sender, EventArgs e)
    {
      education.YearOfGraduation = YearOfGraduationField.Text;
    }
    private void YearOfGraduationField_Leave(object sender, EventArgs e)
    {
      if ((YearOfGraduationField.Text == "") || (YearOfGraduationField.Text == " ") || (YearOfGraduationField.Text.Contains("\n")))
      {
        YearOfGraduationField.Text = "Год окончания";
      }
      if ((!Validator.IsValidYear(YearOfGraduationField.Text) && (YearOfGraduationField.Text != "Год окончания")))
        MessageBox.Show("Некорректный формат даты. Пожалуйста, введите дату в формате гггг");
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
      ExperienceForm exp = new ExperienceForm();
      exp.Show();
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
      if (YearOfGraduationField.Text == "Год окончания")
      {
        YearOfGraduationField.ForeColor = Color.Red;
        return false;
      }

      else return true;
    }

    private void EducationForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void EducationListButton_Click(object sender, EventArgs e)
    {
      if (baseManager.IsEducationExist(PersonalInfo.PersonalInfoId))
      {
        EducationListForm educationListForm = new EducationListForm();
        educationListForm.Show();
        this.Hide();

      }
      else MessageBox.Show("Опыт еще не добавлен. Добавьте его.");
    }
  }
}
