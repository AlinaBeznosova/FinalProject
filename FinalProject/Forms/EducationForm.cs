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
  public partial class EducationForm : Form
  {
   readonly private ExperienceForm experienceForm;
    private SkillsForm skillsForm;
    public EducationForm(ExperienceForm experienceForm)
    {
      InitializeComponent();
      this.experienceForm = experienceForm;
    }

    private void InstitutionField_TextChanged(object sender, EventArgs e)
    {

    }

    private void SpecialtyField_TextChanged(object sender, EventArgs e)
    {

    }

    private void YearOfGraduationField_ValueChanged(object sender, EventArgs e)
    {

    }

    private void AddMoreEducation_Click(object sender, EventArgs e)
    {

    }

    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      experienceForm.Show();
      this.Hide();
    }

    private void NoEducationButton_Click(object sender, EventArgs e)
    {
      skillsForm = new SkillsForm(this);
      this.Hide();
    }

    private void SaveAndNextButton_Click(object sender, EventArgs e)
    {
      skillsForm = new SkillsForm(this);
      this.Hide();
    }
  }
}
