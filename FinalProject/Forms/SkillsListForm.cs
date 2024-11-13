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
  public partial class SkillsListForm : Form
  {
    readonly DataBase.DataBaseManager baseManager = new DataBase.DataBaseManager();

    private void SkillsListForm_Load(object sender, EventArgs e)
    {
      List<string> list = baseManager.SkillList(PersonalInfo.PersonalInfoId);
      int yPos = 10;
      foreach (string name in list)
      {
        RadioButton radioButton = new RadioButton
        {
          Text = name,
          Location = new Point(10, yPos),
          AutoSize = true
        };
        radioPanel.Controls.Add(radioButton);
        yPos += radioButton.Height + 5;
      }
    }

    private void SkillsListForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void DeleteSkillButton_Click(object sender, EventArgs e)
    {
      RadioButton selectedRadioButton = null;
      foreach (Control control in radioPanel.Controls)
      {
        if (control is RadioButton radioButton && radioButton.Checked)
        {
          selectedRadioButton = radioButton;
          break;
        }
      }
      if (selectedRadioButton != null)
      {

        string selectedSkill = selectedRadioButton.Text;
        baseManager.DeleteSkill(selectedSkill);

        this.Hide();
        SkillsListForm skillListForm = new SkillsListForm();
        skillListForm.Show();
      }
      else
      {
        MessageBox.Show("Выберите один из вариантов");
      }
    }

    private void EditSkill_Click(object sender, EventArgs e)
    {
      RadioButton selectedRadioButton = null;
      foreach (Control control in radioPanel.Controls)
      {
        if (control is RadioButton radioButton && radioButton.Checked)
        {
          selectedRadioButton = radioButton;
          break;
        }
      }

      if (selectedRadioButton != null)
      {
        string selectedSkill = selectedRadioButton.Text;
        Skill skill = baseManager.FindSkillByHardSkill(selectedSkill);

        this.Hide();
        SkillsForm skillForm = new SkillsForm(skill);
        skillForm.Show();
      }

      else
      {
        MessageBox.Show("Выберите один из вариантов");
      }
    }

    private void NextFormButton_Click(object sender, EventArgs e)
    {
      AchievementForm achievementForm = new AchievementForm();
      achievementForm.Show();
      this.Hide();
    }

    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      SkillsForm skillsForm = new SkillsForm();
      skillsForm.Show();
      this.Hide();
    }

    public SkillsListForm()
    {
      InitializeComponent();
    }
  }
}
