using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject;


namespace FinalProject.Core
{
  /// <summary>
  /// Валидатор.
  /// </summary>
  public static class Validator
  {
    #region Методы
    /// <summary>
    /// Проверка электронной почты.
    /// </summary>
    /// <param name="email">Электронная почта.</param>
    /// <returns></returns>
    public static bool IsValidEmail(string email)
    {
      var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"); // example@example.com
      return emailRegex.IsMatch(email);
    }

    /// <summary>
    /// Проверка даты.
    /// </summary>
    /// <param name="date">Дата.</param>
    /// <returns></returns>
    public static bool IsValidDate(string date) //dd.MM.yyyy
    {
      var dateRegex = new Regex(@"^\d{2}\.\d{2}\.\d{4}$");
      return dateRegex.IsMatch(date);

    }

    /// <summary>
    /// Проверка даты.
    /// </summary>
    /// <param name="date">Дата.</param>
    /// <returns></returns>
    public static bool IsValidYear(string date) //yyyy
    {
      var dateRegex = new Regex(@"\b(?:19|20)\d{2}\b");
      return dateRegex.IsMatch(date);

    }

    /// <summary>
    /// Проверка даты.
    /// </summary>
    /// <param name="date">Дата.</param>
    /// <returns></returns>
    public static bool IsValidMonth(string date) //MM.yyyy
    {
      var dateRegex = new Regex(@"\b(0[1-9]|1[0-2]).(19|20)\d{2}\b");
      return dateRegex.IsMatch(date);
    }

    /// <summary>
    /// Проверка номера телефона.
    /// </summary>
    /// <param name="phoneNumber">Номер телефона.</param>
    /// <returns></returns>
    public static bool IsValidPhoneNumber(string phoneNumber)
    {
      var phoneRegex = new Regex(@"^\+?7?\s?\d{3}\s?\d{3}-?\d{4}$");
      return phoneRegex.IsMatch(phoneNumber.Replace(" ", "").Replace("-", ""));
    }

    /// <summary>
    /// Проверка ФИО.
    /// </summary>
    /// <param name="fio">ФИО.</param>
    /// <returns></returns>
    public static bool ValidateFIO(string fio)
    {
      var fioRegex = new Regex(@"^[А-Яа-яЁё]+ [А-Яа-яЁё]+ [А-Яа-яЁё]+$");
      return fioRegex.IsMatch(fio);
    }

    /// <summary>
    /// Проверка города.
    /// </summary>
    /// <param name="city">Город.</param>
    /// <returns></returns>
    public static bool ValidateCity(string city)
    {
      var fioRegex = new Regex(@"^\s*[А-Яа-яЁё]+(\s+[А-Яа-яЁё]+)*\s*$");
      return fioRegex.IsMatch(city);
    }
    #endregion
  }
}
