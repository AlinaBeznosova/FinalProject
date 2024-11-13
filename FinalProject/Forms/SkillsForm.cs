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
  public partial class SkillsForm : Form
  {
    readonly DataBase.DataBaseManager baseManager = new DataBase.DataBaseManager();
    readonly Skill skill = new Skill();

    private void HardSkillField_Click(object sender, EventArgs e)
    {
      if (HardSkillField.Text == "Технические навыки")
        HardSkillField.Text = "";
    }
    private void HardSkillField_TextChanged(object sender, EventArgs e)
    {
      skill.Hardskill = HardSkillField.Text;
    }
    private void HardSkillField_Leave(object sender, EventArgs e)
    {
      if (HardSkillField.Text == "")
        HardSkillField.Text = "Технические навыки";
    }
    private void SoftSkillField_Click(object sender, EventArgs e)
    {
      if (SoftSkillField.Text == "Универсальные навыки")
        SoftSkillField.Text = "";
    }

    private void SoftSkillField_TextChanged(object sender, EventArgs e)
    {
      skill.Softskill = SoftSkillField.Text;
    }
    private void SoftSkillField_Leave(object sender, EventArgs e)
    {
      if (SoftSkillField.Text == "")
        SoftSkillField.Text = "Универсальные навыки";
    }
    
    public bool IsFieldsFilled()
    {
      if (HardSkillField.Text == "Технические навыки")
      {

        HardSkillField.ForeColor = Color.Red;
        return false;
      }

      if (SoftSkillField.Text == "Универсальные навыки")
      {
        SoftSkillField.ForeColor = Color.Red;
        return false;
      }
      else return true;
    }

    private void SkillsForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void ClearFieldsButton_Click(object sender, EventArgs e)
    {
      foreach (Control control in this.Controls)
      {
        if (control is TextBox textBox)
        {
          textBox.Text = string.Empty;
        }
      }
    }

    private void PreviousFormButton_Click_1(object sender, EventArgs e)
    {
      EducationForm educationForm = new EducationForm();
      educationForm.Show();
      this.Hide();
    }

    private void NextFormButton_Click(object sender, EventArgs e)
    {
      AchievementForm achievementForm = new AchievementForm();
      achievementForm.Show();
      this.Hide();
    }

    private void AddSkillsButton_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
      {
        if (baseManager.IsIdenticSkillExist(skill))
          MessageBox.Show("Такой навык уже сущестувует.");

        else
          baseManager.AddSkill(skill);
      }

      else MessageBox.Show("Необходимо заполнить все поля");
    }
    private void UpdateSkillsButton_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
        baseManager.UpdateSkill(skill);

      else MessageBox.Show("Необходимо заполнить все поля");
    }

    private void SkillsListButton_Click(object sender, EventArgs e)
    {
      if (baseManager.IsSkillExist(PersonalInfo.PersonalInfoId))
      {
        SkillsListForm skillsListForm = new SkillsListForm();
        skillsListForm.Show();
        this.Hide();

      }
      else MessageBox.Show("Навык еще не добавлен. Добавьте его.");
    }

    public SkillsForm()
    {
      InitializeComponent();
    }

    public SkillsForm(Skill skill)
    {
      InitializeComponent();
      this.skill = skill;
      HardSkillField.Text = skill.Hardskill;
      SoftSkillField.Text = skill.Softskill;
    }
  }
}
