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

namespace FinalProject
{
  public partial class ExperienceForm : Form
  {
    readonly Experience experience = new Experience();
    readonly DataBaseManager baseManager = new DataBaseManager();
    public ExperienceForm()
    {
      InitializeComponent();
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
    private void SaveExperienceButton_Click(object sender, EventArgs e)
    {
      baseManager.AddExperience(experience);
    }

    private void ExperienceForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    
  }
}
