using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.xmp.impl;
using FinalProject.DataBase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using FinalProject.Core;


namespace FinalProject
{
  public partial class InfoForm : Form
  {
    

    readonly PersonalInfo person = new PersonalInfo();
    readonly DataBaseManager baseManager = new DataBaseManager();

    public InfoForm()
    {
      InitializeComponent();

      GenderField.Text = "Выберите пол";

      string[] maleStatus = { "Холост", "Женат" };
      MaritalStatusField.Items.AddRange(maleStatus);
    }

    private void FullNameField_Click(object sender, EventArgs e)
    {
      if (FullNameField.Text == "Введите имя")
      {
        FullNameField.Text = "";
        FullNameField.ForeColor = Color.Black;
      }
    }
    private void FullNameField_TextChanged(object sender, EventArgs e)
    { 
      person.FullName = FullNameField.Text;
    }
    private void FullNameField_Leave(object sender, EventArgs e)
    {
      if (FullNameField.Text == "")
      {
        FullNameField.Text = "Введите имя";
        FullNameField.ForeColor = Color.Gray;
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
      string[] maritalStatus;
      GenderField.ForeColor = Color.Black;

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
        MaritalStatusField.Text = "Выберите статус";
      }

      MaritalStatusField.Items.Clear();
      MaritalStatusField.Items.AddRange(maritalStatus);
      MaritalStatusField.SelectedIndex = 0; 
  }

    private void MaritalStatusField_SelectedIndexChanged(object sender, EventArgs e)
    {
      person.MaritalStatus = MaritalStatusField.Items.ToString();
      MaritalStatusField.ForeColor = Color.Black;
    }

    private void CityField_Click(object sender, EventArgs e)
    {
      if (CityField.Text == "Введите город")
      {
        CityField.Text = "";
        CityField.ForeColor = Color.Black;
      }
    }
    private void CityField_TextChanged(object sender, EventArgs e)
    {
      person.City = CityField.Text;
    }
    private void CityField_Leave(object sender, EventArgs e)
    {
      if (CityField.Text == "")
      {
        CityField.Text = "Введите город";
        CityField.ForeColor = Color.Gray;
      }
    }

    private void EmailField_Click(object sender, EventArgs e)
    {
      if (EmailField.Text == "Введите почту")
      {
        EmailField.Text = "";
        EmailField.ForeColor = Color.Black;
      }
    }
    private void EmailField_TextChanged(object sender, EventArgs e)
    {
      person.Email = EmailField.Text;
    }
    private void EmailField_Leave(object sender, EventArgs e)
    {
      if (EmailField.Text == "")
      {
        EmailField.Text = "Введите почту";
        EmailField.ForeColor = Color.Gray;
      }
      if ((EmailField.Text!="Введите почту")&&(!Validator.IsValidEmail(EmailField.Text)))
        MessageBox.Show("Некорректный формат электронной почты. Пожалуйста, введите адрес в формате example@example.com");
    }

    private void PhoneNumberField_Click(object sender, EventArgs e)
    {
      if (PhoneNumberField.Text == "Введите номер телефона")
      {
        PhoneNumberField.Text = "";
        PhoneNumberField.ForeColor = Color.Black;
      }
    }
    private void PhoneNumberField_TextChanged(object sender, EventArgs e)
    {
      person.PhoneNumber = PhoneNumberField.Text;
    }
    private void PhoneNumberField_Leave(object sender, EventArgs e)
    {
      if (PhoneNumberField.Text == "")
      {
        PhoneNumberField.Text = "Введите номер телефона";
        PhoneNumberField.ForeColor = Color.Gray;
      }
      if ((PhoneNumberField.Text != "Введите номер телефона") && (!Validator.IsValidPhoneNumber(PhoneNumberField.Text)))
        MessageBox.Show("Некорректный формат электронной почты. Пожалуйста введите номер в формате 7 ХХХ ХХХ-ХХХХ");
    }

    private void ButtonSaveInfo_Click(object sender, EventArgs e)
    {
      person.FullName = FullNameField.Text;
      person.DateOfBirth = DateOfBirthField.Text;
      person.Gender = GenderField.Text;
      person.City = CityField.Text;
      person.PhoneNumber = PhoneNumberField.Text;
      person.Email = EmailField.Text;
      person.MaritalStatus = MaritalStatusField.Text;

      if (IsFieldsFilled())
      {
        baseManager.SavePersonalInfo(person);
        this.Hide();
        ExperienceForm experienceForm = new ExperienceForm();
        experienceForm.Show();
      }

      else MessageBox.Show("Необходимо заполнить все поля");

    }

    public bool IsFieldsFilled()
    {
      if (FullNameField.Text == "Введите имя")
      {
        FullNameField.ForeColor = Color.Red;
        return false;
      }

      if (GenderField.Text == "Выберите пол")
      {
        GenderField.ForeColor = Color.Red;
        return false;
      }

      if (MaritalStatusField.Text == "Выберите статус")
      {
        MaritalStatusField.ForeColor = Color.Red;
        return false;
      }

      if (CityField.Text == "Введите город")
      {
        CityField.ForeColor = Color.Red;
        return false; 
      }
      if (EmailField.Text == "Введите почту")
      {
        EmailField.ForeColor = Color.Red;
        return false;
      }
      if (PhoneNumberField.Text == "Введите номер телефона")
      {
        PhoneNumberField.ForeColor = Color.Red;
        return false;
      }

      else return true;
    }

  }
}
