using System;
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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace FinalProject
{
  public partial class InfoForm : Form
  {
    readonly PersonalInfo personal;
    private ExperienceForm experienceForm;
    readonly PersonalInfo person = new PersonalInfo();
    readonly DataBaseManager baseManager = new DataBaseManager();

    

    public InfoForm(PersonalInfo personalInfo)
    {
      InitializeComponent();
      this.personal = personalInfo;
      FullNameField.Text = personalInfo.FullName;
      DateOfBirthField.Text = personalInfo.DateOfBirth;
      GenderField.Text = personalInfo.Gender;
      CityField.Text = personalInfo.City;
      PhoneNumberField.Text = personalInfo.PhoneNumber;
      EmailField.Text = personalInfo.Email;
      MaritalStatusField.Text = personalInfo.MaritalStatus;
    }
    
    public InfoForm()
    {
      InitializeComponent();
      string[] maleStatus = { "Холост", "Женат" };
      MaritalStatusField.Items.AddRange(maleStatus);
      GenderField.Text = "Пол";
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
      FullNameField.ForeColor = Color.Black;
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
    private void DateOfBirthField_Click(object sender, EventArgs e)
    {
      if (DateOfBirthField.Text == "Дата рождения")
        DateOfBirthField.Text = "";
    }
    private void DateOfBirthField_TextChanged(object sender, EventArgs e)
    {
      DateOfBirthField.ForeColor = Color.Black;
      person.DateOfBirth = DateOfBirthField.Text;
    }

    private void DateOfBirthField_Leave(object sender, EventArgs e)
    {
      if ((DateOfBirthField.Text == "") || (DateOfBirthField.Text == " ") || (DateOfBirthField.Text.Contains("\n")))
      {
        DateOfBirthField.Text = "Дата рождения";
      }
      if ((!Validator.IsValidDate(DateOfBirthField.Text) && (DateOfBirthField.Text != "Дата рождения")))
        MessageBox.Show("Некорректный формат даты. Пожалуйста, введите дату в формате дд.мм.гггг");
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
      GenderField.ForeColor = Color.Black;
      person.Gender = GenderField.Text;
      MaritalStatusField.Items.Clear(); 
      MaritalStatusField.Items.AddRange(maritalStatus);
    }

    private void MaritalStatusField_SelectedIndexChanged(object sender, EventArgs e)
    {
      person.MaritalStatus = MaritalStatusField.Text;
      MaritalStatusField.ForeColor = Color.Black;
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
      CityField.ForeColor = Color.Black;
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
      EmailField.ForeColor = Color.Black;
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
      PhoneNumberField.ForeColor = Color.Black;
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

    private void NextFormButton_Click(object sender, EventArgs e)
    {
      if (IsFieldsFilled())
      {
        if (baseManager.IsIdenticPersonExist(person))
        {
          experienceForm = new ExperienceForm(this);
          experienceForm.Show();
          this.Hide();
        }
        else if (baseManager.IsCurrentPersonExist(person))
        {
          baseManager.UpdatePersonalInfo(person);
          experienceForm = new ExperienceForm(this);
          experienceForm.Show();
          this.Hide();
        }
        else
        {
          baseManager.SavePersonalInfo(person);
          experienceForm = new ExperienceForm(this);
          experienceForm.Show();
          this.Hide();
        }
        }

      else MessageBox.Show("Необходимо заполнить все поля");

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
      if (DateOfBirthField.Text =="Дата рождения")
      {
        DateOfBirthField.ForeColor = Color.Red;
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
