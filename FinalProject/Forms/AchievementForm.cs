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
  public partial class AchievementForm : Form
  {

    readonly Achievement achievement = new Achievement();
    readonly DataBaseManager baseManager = new DataBaseManager();
    readonly private SkillsForm skillsForm;
    private ResumeForm resumeForm;
    public AchievementForm(SkillsForm skillsForm)
    {
      InitializeComponent();
      this.skillsForm = skillsForm;
    }

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
    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      skillsForm.Show();
      this.Hide();
    }

    private void NoSkillsButton_Click(object sender, EventArgs e)
    {
      resumeForm = new ResumeForm(this);
      resumeForm.Show();
      this.Hide();
    }

    private void SaveAndNextButton_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
      {
        baseManager.AddAchievement(achievement);
        resumeForm = new ResumeForm(this);
        resumeForm.Show();
        this.Hide();
      }

      else MessageBox.Show("Необходимо заполнить все поля");
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
  }
}
