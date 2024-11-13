using Aspose.Words.Drawing;
using FinalProject.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject.Forms
{
  public partial class AchievementForm : Form
  {
    readonly Achievement achievement = new Achievement();
    readonly DataBase.DataBaseManager baseManager = new DataBase.DataBaseManager();

    

    private void AchievementField_Click(object sender, EventArgs e)
    {
      if (AchievementField.Text == "Профессиональные достижения")
        AchievementField.Text = "";
    }

    private void AchievementField_TextChanged(object sender, EventArgs e)
    {
      achievement.AchievementName = AchievementField.Text;
    }

    private void AchievementField_Leave(object sender, EventArgs e)
    {
      if (AchievementField.Text == "")
        AchievementField.Text = "Профессиональные достижения";
    }
    private void AchievementForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }
    public bool IsFieldsFilled()
    {
      if (AchievementField.Text == "Профессиональные достижения")
      {
        AchievementField.ForeColor = Color.Red;
        return false;
      }

      else return true;
    }

    private void ClearFieldsButton_Click(object sender, EventArgs e)
    {
      foreach (Control control in this.Controls)
      {
        if (control is System.Windows.Forms.TextBox textBox)
        {
          textBox.Text = string.Empty;
        }
      }
    }

    private void AchievementListButton_Click(object sender, EventArgs e)
    {
      if (baseManager.IsAchievementExist(PersonalInfo.PersonalInfoId))
      {
        AchievementListForm achievementList = new AchievementListForm();
        achievementList.Show();
        this.Hide();

      }
      else MessageBox.Show("Достижение еще не добавлено. Добавьте его.");
    }

    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      SkillsForm skillsForm = new SkillsForm();
      skillsForm.Show();
      this.Hide();
    }

    private void UpdateAchievementButton_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
        baseManager.UpdateAchievement(achievement);

      else MessageBox.Show("Необходимо заполнить все поля");
    }

    private void AddAchievementButton_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
      {
        if (baseManager.IsAchievementExist(PersonalInfo.PersonalInfoId))
          MessageBox.Show("Такое достижение уже сущестувует.");

        else
          baseManager.AddAchievement(achievement);
      }

      else MessageBox.Show("Необходимо заполнить все поля");
    }

    private void NextFormButton_Click(object sender, EventArgs e)
    {
      ResumeForm resumeForm = new ResumeForm();
      resumeForm.Show();
      this.Hide();
    }

    public AchievementForm()
    {
      InitializeComponent();
    }

    public AchievementForm(Achievement achievement)
    {
      InitializeComponent();
      this.achievement = achievement;
      AchievementField.Text = achievement.AchievementName;
    }

  }
}
