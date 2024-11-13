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
    readonly Education education = new Education();
   
   
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
        foreach (Control control in this.Controls)
        {
          if (control is TextBox textBox)
          {
            textBox.Text = string.Empty;
          }
        }
    }

    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      ExperienceForm experienceForm = new ExperienceForm();
      experienceForm.Show();
      this.Hide();
    }


    private void AddEducationButton_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
      {
        if (baseManager.IsIdenticEducationExist(education))
          MessageBox.Show("Такое образование уже сущестувует.");

        else
          baseManager.AddEducation(education);
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
      else MessageBox.Show("Образование еще не добавлено. Добавьте его.");
    }

    private void UpdateEducationButton_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
        baseManager.UpdateEducation(education);

      else MessageBox.Show("Необходимо заполнить все поля");
    }

    private void NextFormButton_Click_1(object sender, EventArgs e)
    {
      SkillsForm skillsForm = new SkillsForm();
      skillsForm.Show();
      this.Hide();
    }

    public EducationForm()
    {
      InitializeComponent();
    }

    public EducationForm(Education education)
    {
      InitializeComponent();
      this.education = education;
      InstitutionField.Text = education.Institution;
      SpecialtyField.Text = education.Specialty;
      YearOfGraduationField.Text = education.YearOfGraduation;
    }
  }
}
