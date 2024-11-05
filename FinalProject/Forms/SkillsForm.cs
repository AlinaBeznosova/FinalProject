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
    readonly private EducationForm educationForm;
    private AchievementForm achievementForm;
    public SkillsForm(EducationForm educationForm)
    {
      InitializeComponent();
      this.educationForm = educationForm;
    }

    private void HardSkillField_TextChanged(object sender, EventArgs e)
    {

    }

    private void SoftSkillField_TextChanged(object sender, EventArgs e)
    {

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
      achievementForm = new AchievementForm(this);
      this.Hide();
    }
  }
}
