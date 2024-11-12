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
    readonly Education education = new Education();
    public EducationListForm()
    {
      InitializeComponent();
    }

    private void EducationListForm_Load(object sender, EventArgs e)
    {
      List<string> ed = baseManager.EducationList(PersonalInfo.PersonalInfoId);
      InstitutionList.Text = string.Join(Environment.NewLine, ed);
    }

    private void EducationListForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }
    private void PositionChoiseField_Click(object sender, EventArgs e)
    {
      if (PositionChoiseField.Text == "Введите учебное заведение")
        PositionChoiseField.Text = "";
    }
    private void PositionChoiseField_TextChanged(object sender, EventArgs e)
    {
      PositionChoiseField.ForeColor = Color.Black;
    }

    private void PositionChoiseField_Leave(object sender, EventArgs e)
    {
      if (PositionChoiseField.Text == "")
        PositionChoiseField.Text = "Введите учебное заведение";
    }

    private void DeleteExperienceButton_Click(object sender, EventArgs e)
    {
      if (PositionChoiseField.Text == "Введите учебное заведение")
      {
        PositionChoiseField.ForeColor = Color.Red;
        MessageBox.Show("Заполните поле");
        return;
      }
      else
      {
        baseManager.DeleteEducation(PositionChoiseField.Text);
        this.Hide();
        EducationListForm educationListForm = new EducationListForm();
        educationListForm.Show();
      }
    }

    private void EditExperience_Click(object sender, EventArgs e)
    {
      if (PositionChoiseField.Text == "Введите учебное заведение")
      {
        PositionChoiseField.ForeColor = Color.Red;
        MessageBox.Show("Заполните поле");
        return;
      }
      else
      {
        Education education = baseManager.FindEducationByInstitution(PositionChoiseField.Text);
        if (education != null && !string.IsNullOrEmpty(education.Institution))
        {
          this.Hide();
          EducationForm educationForm = new EducationForm(education);
          educationForm.Show();
        }
        else
        {
          MessageBox.Show("Такого черновика не существует, попробуйте еще");
        }
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
      EducationForm ed = new EducationForm();
      ed.Show();
      this.Hide();
    }
  }
}
