﻿using FinalProject.Core;
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
  public partial class EditExperienceForm : Form
  {
    
    readonly DataBase.DataBaseManager baseManager = new DataBase.DataBaseManager();
   
    private void EditExperienceForm_Load(object sender, EventArgs e)
    {
      List<string> list = baseManager.ExperienceList(PersonalInfo.PersonalInfoId);
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

    private void EditExperienceForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }


    private void DeleteExperienceButton_Click(object sender, EventArgs e)
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

        string selectedPosition = selectedRadioButton.Text;
        baseManager.DeleteExperience(selectedPosition);

        this.Hide();
        EditExperienceForm editExperienceForm = new EditExperienceForm();
        editExperienceForm.Show();
      }
      else
      {
        MessageBox.Show("Выберите один из вариантов");
      }
    }
   

    private void EditExperience_Click(object sender, EventArgs e)
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
        string selectedPosition = selectedRadioButton.Text;
        Experience experience = baseManager.FindExperienceByPosition(selectedPosition);

        this.Hide();
        ExperienceForm experienceForm = new ExperienceForm(experience);
        experienceForm.Show();
      }

      else
      {
        MessageBox.Show("Выберите один из вариантов");
      }
    }

    private void NextFormButton_Click(object sender, EventArgs e)
    {
      EducationForm educationForm = new EducationForm();
      educationForm.Show();
      this.Hide();
    }

    private void PreviousFormButton_Click(object sender, EventArgs e)
    {
      ExperienceForm exp = new ExperienceForm();
      exp.Show();
      this.Hide();
    }

    public EditExperienceForm()
    {
      InitializeComponent();
    }

  }
}
