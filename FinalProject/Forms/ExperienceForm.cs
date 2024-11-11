using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.DataBase;
using FinalProject.Forms;
using FinalProject.Core;

namespace FinalProject
{
  public partial class ExperienceForm : Form
  {
    readonly private InfoForm infoForm;
    private EducationForm educationForm;
    readonly Experience experience = new Experience();
    readonly DataBaseManager baseManager = new DataBaseManager();

    public ExperienceForm() 
    {
      InitializeComponent();
    }
    public ExperienceForm(Experience experience)
    {
      InitializeComponent();
      this.experience = experience;
      PositionField.Text = experience.Position;
      CompanyField.Text = experience.Company;
      StartDateField.Text = experience.StartDate;
      EndDateField.Text = experience.EndDate;
      ResponsibilitiesField.Text = experience.Responsibilities;
    }
    public ExperienceForm(InfoForm infoForm)
    {
      InitializeComponent();
      this.infoForm = infoForm;
    }

   
    private void PositionField_Click(object sender, EventArgs e)
    {
      if (PositionField.Text == "Должность")
      {
        PositionField.Text = "";
      }
    }

    private void PositionField_TextChanged(object sender, EventArgs e)
    {
      experience.Position = PositionField.Text;
      PositionField.ForeColor = Color.Black;
    }

    private void PositionField_Leave(object sender, EventArgs e)
    {
      if (PositionField.Text == "")
      {
        PositionField.Text = "Должность";

      }
    }

    private void CompanyField_Click(object sender, EventArgs e)
    {
      if (CompanyField.Text == "Компания")
      {
        CompanyField.Text = "";

      }
    }

    private void CompanyField_TextChanged(object sender, EventArgs e)
    {
      experience.Company = CompanyField.Text;
      CompanyField.ForeColor = Color.Black;
    }

    private void CompanyField_Leave(object sender, EventArgs e)
    {
      if (CompanyField.Text == "")
      {
        CompanyField.Text = "Компания";

      }
    }
    private void StartDateField_Click(object sender, EventArgs e)
    {
      if (StartDateField.Text == "С")
        StartDateField.Text = "";
    }

    private void StartDateField_TextChanged(object sender, EventArgs e)
    {
      experience.StartDate = StartDateField.Text;
      StartDateField.ForeColor = Color.Black;
    }

    private void StartDateField_Leave(object sender, EventArgs e)
    {
      if ((StartDateField.Text == "") || (StartDateField.Text == " ") || (StartDateField.Text.Contains("\n")))
      {
        StartDateField.Text = "С";
      }
      if ((!Validator.IsValidMonth(StartDateField.Text) && (StartDateField.Text != "С")))
        MessageBox.Show("Некорректный формат электронной даты. Пожалуйста, введите дату в формате мм.гггг");
    }

    private void EndDateField_Click(object sender, EventArgs e)
    {
      if (EndDateField.Text == "До")
        EndDateField.Text = "";
    }

    private void EndDateField_TextChanged(object sender, EventArgs e)
    {
      experience.EndDate = EndDateField.Text;
    }

    private void EndDateField_Leave(object sender, EventArgs e)
    {
      if ((EndDateField.Text == "") || (EndDateField.Text == " ") || (EndDateField.Text.Contains("\n")))
      {
        EndDateField.Text = "До";
      }
      if ((!Validator.IsValidMonth(EndDateField.Text) && (EndDateField.Text != "До")))
        MessageBox.Show("Некорректный формат электронной даты. Пожалуйста, введите дату в формате мм.гггг");
    }
  

    private void ResponsibilitiesField_Click(object sender, EventArgs e)
    {
      if (ResponsibilitiesField.Text == "Обязанности")
      {
        ResponsibilitiesField.Text = "";
      }
    }
    private void ResponsibilitiesField_TextChanged(object sender, EventArgs e)
    {
      experience.Responsibilities = ResponsibilitiesField.Text;
      ResponsibilitiesField.ForeColor = Color.Black;
    }
    private void ResponsibilitiesField_Leave(object sender, EventArgs e)
    {
      if (ResponsibilitiesField.Text == "")
      {
        ResponsibilitiesField.Text = "Обязанности";

      }
    }
    private void NextButton_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
      {
        if (baseManager.FindExperienceByPosition(PositionField.Text, Experience.ExperienceId) != null)
          baseManager.EditExperience(experience);
         
        else
          baseManager.AddExperience(experience);

          educationForm = new EducationForm(this);
          educationForm.Show();
          this.Hide();
        
      }

      else MessageBox.Show("Необходимо заполнить все поля");

    }
    public bool IsFieldsFilled()
    {
      if (PositionField.Text == "Должность")
      {

        PositionField.ForeColor = Color.Red;
        return false;
      }

      if (CompanyField.Text == "Компания")
      {
        CompanyField.ForeColor = Color.Red;
        return false;
      }

      if (ResponsibilitiesField.Text == "Обязанности")
      {
        ResponsibilitiesField.ForeColor = Color.Red;
        return false;
      }

      if (StartDateField.Text == "С")
      {
        StartDateField.ForeColor = Color.Red;
        return false;
      }

      if (EndDateField.Text == "До")
      {
        EndDateField.ForeColor = Color.Red;
        return false;
      }

      else return true;
    }

    private void ExperienceForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void AddMoreExperience_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
      {
        baseManager.AddExperience(experience);

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

    private void NoExperienceButton_Click(object sender, EventArgs e)
    {
      educationForm = new EducationForm(this);
      educationForm.Show();
      this.Hide();
    }

    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      infoForm.Show();
      this.Hide();
    }

    private void ShowExperienceListButton_Click(object sender, EventArgs e)
    {
      if (baseManager.IsExperienceExist(PersonalInfo.PersonalInfoId))
      {
            EditExperienceForm editExperienceForm = new EditExperienceForm();
            editExperienceForm.Show();
            this.Hide();
       
        }
      else MessageBox.Show("Опыт еще не добавлен. Добавьте его.");
    }
  }
}
