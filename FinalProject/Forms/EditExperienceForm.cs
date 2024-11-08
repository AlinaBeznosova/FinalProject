using FinalProject.Core;
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
  public partial class EditExperienceForm : Form
  {
    
    readonly DataBaseManager baseManager = new DataBaseManager();
    readonly Experience experience = new Experience();
    public EditExperienceForm()
    {
      InitializeComponent();
    }

    private void EditExperienceForm_Load(object sender, EventArgs e)
    {
      List<string> exp = baseManager.ExperienceList(PersonalInfo.PersonalInfoId);
      PositionsList.Text = string.Join(Environment.NewLine, exp);
    }

    private void EditExperienceForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void PositionChoiseField_Click(object sender, EventArgs e)
    {
      if (PositionChoiseField.Text == "Введите должность")
        PositionChoiseField.Text = "";
    }

    private void PositionChoiseField_TextChanged(object sender, EventArgs e)
    {
      PositionChoiseField.ForeColor = Color.Black;
    }

    private void PositionChoiseField_Leave(object sender, EventArgs e)
    {
      if (PositionChoiseField.Text == "")
        PositionChoiseField.Text = "Введите должность";
    }

    private void DeleteExperienceButton_Click(object sender, EventArgs e)
    {
      if (PositionChoiseField.Text == "Введите должность")
      {
        PositionChoiseField.ForeColor = Color.Red;
        MessageBox.Show("Заполните поле");
        return;
      }
      else
      {
        baseManager.DeleteExperience(PositionChoiseField.Text);
        this.Hide();
        EditExperienceForm editExperienceForm = new EditExperienceForm();
        editExperienceForm.Show();
      }
    }

    private void EditExperience_Click(object sender, EventArgs e)
    {
      if (PositionChoiseField.Text == "Введите должность")
      {
        PositionChoiseField.ForeColor = Color.Red;
        MessageBox.Show("Заполните поле");
        return;
      }
      else
      {
        Experience experience = baseManager.FindExperienceByPosition(PositionChoiseField.Text);
        if (experience != null && !string.IsNullOrEmpty(experience.Position))
        {
          this.Hide();
          ExperienceForm experienceForm = new ExperienceForm(experience);
          experienceForm.Show();
        }
        else
        {
          MessageBox.Show("Такого черновика не существует, попробуйте еще");
        }
      }
    }

    private void NextFormButton_Click(object sender, EventArgs e)
    {
      EducationForm educationForm = new EducationForm();
      educationForm.Show();
      this.Hide();
    }

    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      ExperienceForm exp = new ExperienceForm();
      exp.Show();
      this.Hide();
    }
  }
}
