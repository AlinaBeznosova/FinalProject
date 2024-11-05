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
    readonly private SkillsForm skillsForm;
    public AchievementForm(SkillsForm skillsForm)
    {
      InitializeComponent();
      this.skillsForm = skillsForm;
    }

    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      skillsForm.Show();
      this.Hide();
    }
  }
}
