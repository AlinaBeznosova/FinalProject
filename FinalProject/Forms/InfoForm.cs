﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.DataBase;
using FinalProject.Core;
using FinalProject.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace FinalProject
{
  public partial class InfoForm : Form
  {
    
    private ExperienceForm experienceForm;
    readonly PersonalInfo person = new PersonalInfo();
    readonly DataBaseManager baseManager = new DataBaseManager();

    public InfoForm()
    {
      InitializeComponent();
      GenderField.Text = "Пол";
      string[] maleStatus = { "Холост", "Женат" };
      MaritalStatusField.Items.AddRange(maleStatus);
    }
    private void InfoForm_Load(object sender, EventArgs e)
    {
      
    }

    private void FullNameField_Click(object sender, EventArgs e)
    {
      if (FullNameField.Text == "ФИО")
      {
        FullNameField.Text = "";
      }
    }
    private void FullNameField_TextChanged(object sender, EventArgs e)
    {
     
     person.FullName = FullNameField.Text;
     
    }
    private void FullNameField_Leave(object sender, EventArgs e)
    {
      
      if ((FullNameField.Text == "")|| (FullNameField.Text == " ") || (FullNameField.Text.Contains("\n")))
      {
        FullNameField.Text = "ФИО";
      }
      if ((!Validator.ValidateFIO(FullNameField.Text) && FullNameField.Text !="ФИО"))
      {
        MessageBox.Show("Поле ФИО заполнено неверно");
      }
      

    }
    private void DateOfBirth_ValueChanged(object sender, EventArgs e)
    {
      person.DateOfBirth = DateOfBirthField.Text;
    }
    private void DateOfBirthField_Leave(object sender, EventArgs e)
    {
      if (!Validator.IsValidDate(DateOfBirthField.Text))
        MessageBox.Show("Введите другую дату");
    }

    private void GenderField_SelectedIndexChanged(object sender, EventArgs e)
    {
      string selectedGender = GenderField.SelectedItem.ToString();
      string[] maritalStatus ;


      if (selectedGender == "Мужской")
      {
        maritalStatus = new string[] { "Холост", "Женат" };
      }
      else if (selectedGender == "Женский")
      {
        maritalStatus = new string[] { "Холоста", "Замужем" };
      }
      else
      {
        maritalStatus = new string[] { };
      }

      person.Gender = GenderField.Text;
      MaritalStatusField.Items.Clear(); 
      MaritalStatusField.Items.AddRange(maritalStatus);
    }

    private void MaritalStatusField_SelectedIndexChanged(object sender, EventArgs e)
    {
      person.MaritalStatus = MaritalStatusField.Text;
      
    }

    private void CityField_Click(object sender, EventArgs e)
    {
      if (CityField.Text == "Город")
      {
        CityField.Text = "";
      }
    }
    private void CityField_TextChanged(object sender, EventArgs e)
    {
      person.City = CityField.Text;
    }
    private void CityField_Leave(object sender, EventArgs e)
    {
      if ((CityField.Text == "") || (CityField.Text == " ") || (CityField.Text.Contains("\n")))
      {
        CityField.Text = "Город";
      }
      if ((!Validator.ValidateCity(CityField.Text) && CityField.Text != "Город"))
      {
        MessageBox.Show("Поле город заполнено неверно");
      }
    }

    private void EmailField_Click(object sender, EventArgs e)
    {
      if (EmailField.Text == "Электронная почта")
      {
        EmailField.Text = "";
      }
    }
    private void EmailField_TextChanged(object sender, EventArgs e)
    {
      person.Email = EmailField.Text;
    }
    private void EmailField_Leave(object sender, EventArgs e)
    {
      if ((EmailField.Text == "") || (EmailField.Text == " ") || (EmailField.Text.Contains("\n")))
      {
        EmailField.Text = "Электронная почта";

      }
      if ((EmailField.Text!="Электронная почта")&&(!Validator.IsValidEmail(EmailField.Text)))
        MessageBox.Show("Некорректный формат электронной почты. Пожалуйста, введите адрес в формате example@example.com");
    }

    private void PhoneNumberField_Click(object sender, EventArgs e)
    {
      if (PhoneNumberField.Text == "Номер телефона")
      {
        PhoneNumberField.Text = "";

      }
    }
    private void PhoneNumberField_TextChanged(object sender, EventArgs e)
    {
      person.PhoneNumber = PhoneNumberField.Text;
    }
    private void PhoneNumberField_Leave(object sender, EventArgs e)
    {
      if ((PhoneNumberField.Text == "") || (PhoneNumberField.Text == " ") || (PhoneNumberField.Text.Contains("\n")))
      {
        PhoneNumberField.Text = "Номер телефона";

      }
      if ((PhoneNumberField.Text != "Номер телефона") && (!Validator.IsValidPhoneNumber(PhoneNumberField.Text)))
        MessageBox.Show("Некорректный формат электронной почты. Пожалуйста введите номер в формате 7 ХХХ ХХХ-ХХХХ");
    }
    private void SaveInfoButton_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
      {
        baseManager.SavePersonalInfo(person);
      }

      else MessageBox.Show("Необходимо заполнить все поля");
    }

    private void NextFormButton_Click(object sender, EventArgs e)
    {
        experienceForm = new ExperienceForm(this);
        experienceForm.Show();
        this.Hide();
    }

    private void InfoForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
    public bool IsFieldsFilled()
    {
      if (FullNameField.Text == "ФИО")
      {

        FullNameField.ForeColor = Color.Red;
        return false;
      }

      if (GenderField.Text == "Пол")
      {
        GenderField.ForeColor = Color.Red;
        return false;
      }

      if (MaritalStatusField.Text == "Статус")
      {
        MaritalStatusField.ForeColor = Color.Red;
        return false;
      }

      if (CityField.Text == "Город") 
      {
        CityField.ForeColor = Color.Red;
        return false;
      }
      if (EmailField.Text == "Электронная почта") 
      {
        EmailField.ForeColor = Color.Red;
        return false;
      }
      if (PhoneNumberField.Text == "Номер телефона") 
      {
        PhoneNumberField.ForeColor = Color.Red;
        return false;
      }

      else return true;
    }

    
  }
}
