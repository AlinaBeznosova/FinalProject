using FinalProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject
{
  public class PersonalInfo
  {
    public string FullName { get; set; }
    public string DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string MaritalStatus { get; set; }

    public PersonalInfo() { }
    public PersonalInfo(string fullName, string dateOfBirth, string gender, string city, string phoneNumber, string email, string maritalStatus) 
    {
      if (!Validator.IsValidDate(dateOfBirth))
        throw new ArgumentException("Дата рождения должна быть в формате dd.MM.yyyy.", nameof(dateOfBirth));

      if (!Validator.IsValidPhoneNumber(phoneNumber))
        throw new ArgumentException("Номер телефона имеет неверный формат.", nameof(phoneNumber));

      if (!Validator.IsValidEmail(email))
        throw new ArgumentException("Электронная почта имеет неверный формат.", nameof(email));

      FullName = fullName;
      DateOfBirth = dateOfBirth;
      Gender = gender;
      City = city;
      PhoneNumber = phoneNumber;
      Email = email;
      MaritalStatus = maritalStatus;
    }
  }
}
