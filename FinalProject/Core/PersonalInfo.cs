using FinalProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject
{
  /// <summary>
  /// Личные данные.
  /// </summary>
  public class PersonalInfo
  {
    /// <summary>
    /// ФИО.
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Дата рождения.
    /// </summary>
    public string DateOfBirth { get; set; }

    /// <summary>
    /// Пол.
    /// </summary>
    public string Gender { get; set; }

    /// <summary>
    /// Город проживания.
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Номер телефона.
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Электронная почта.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Семейное положение.
    /// </summary>
    public string MaritalStatus { get; set; }

    /// <summary>
    /// Конструктор.
    /// </summary>
    public PersonalInfo() { }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="fullName">ФИО.</param>
    /// <param name="dateOfBirth">Дата рождения.</param>
    /// <param name="gender">Пол.</param>
    /// <param name="city">Город проживания.</param>
    /// <param name="phoneNumber">Номер телефона.</param>
    /// <param name="email">Электронная почта.</param>
    /// <param name="maritalStatus">Семейное положение.</param>
    /// <exception cref="ArgumentException">Исключения, которые могут возникнуть при некорректных данных.</exception>
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
