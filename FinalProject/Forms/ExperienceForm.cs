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

namespace FinalProject
{
  public partial class ExperienceForm : Form
  {
    readonly private InfoForm infoForm;
    private EducationForm educationForm;
    readonly Experience experience = new Experience();
    readonly DataBaseManager baseManager = new DataBaseManager();
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
    }

    private void CompanyField_Leave(object sender, EventArgs e)
    {
      if (CompanyField.Text == "")
      {
        CompanyField.Text = "Компания";

      }
    }

    private void StartDateField_ValueChanged(object sender, EventArgs e)
    {
      experience.StartDate = StartDateField.Text;
    }

    private void EndDateField_ValueChanged(object sender, EventArgs e)
    {
      experience.EndDate = EndDateField.Text;
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
  }
}
