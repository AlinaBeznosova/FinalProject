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
    readonly DataBaseManager baseManager = new DataBaseManager();
    readonly Skill skill = new Skill();
    readonly private EducationForm educationForm;
    private AchievementForm achievementForm;
    public SkillsForm(EducationForm educationForm)
    {
      InitializeComponent();
      this.educationForm = educationForm;
    }
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
    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      educationForm.Show();
      this.Hide();
    }

    private void NoSkillsButton_Click(object sender, EventArgs e)
    {
      achievementForm = new AchievementForm(this);
      this.Hide();
    }

    private void SaveAndNextButton_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
      {
        baseManager.AddSkill(skill);
        achievementForm = new AchievementForm(this);
        this.Hide();
      }

      else MessageBox.Show("Необходимо заполнить все поля");
      
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
  }
}
