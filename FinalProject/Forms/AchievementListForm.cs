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
  public partial class AchievementListForm : Form
  {
    readonly DataBase.DataBaseManager baseManager = new DataBase.DataBaseManager();

    private void AchievementListForm_Load(object sender, EventArgs e)
    {
      List<string> list = baseManager.AchievementList(PersonalInfo.PersonalInfoId);
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

    private void AchievementListForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void DeleteAchievementButton_Click(object sender, EventArgs e)
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

        string selectedAchievement = selectedRadioButton.Text;
        baseManager.DeleteAchievement(selectedAchievement);

        this.Hide();
        AchievementListForm achievementListForm = new AchievementListForm();
        achievementListForm.Show();
      }
      else
      {
        MessageBox.Show("Выберите один из вариантов");
      }
    }

    private void EditAchievement_Click(object sender, EventArgs e)
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
        string selectedAchievement = selectedRadioButton.Text;
        Achievement achievement = baseManager.FindAchievement(selectedAchievement);

        this.Hide();
        AchievementForm achievementForm = new AchievementForm(achievement);
        achievementForm.Show();
      }

      else
      {
        MessageBox.Show("Выберите один из вариантов");
      }
    }

    private void NextFormButton_Click(object sender, EventArgs e)
    {
      ResumeForm resumeForm = new ResumeForm();
      resumeForm.Show();
      this.Hide();
    }

    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      AchievementListForm achievementListForm = new AchievementListForm();
      achievementListForm.Show();
      this.Hide();
    }

    public AchievementListForm()
    {
      InitializeComponent();
    }
  }
}
