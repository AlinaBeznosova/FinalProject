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
  public static class Validator
  {
    public static bool IsValidEmail(string email)
    {
      var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"); // example@example.com
      return emailRegex.IsMatch(email);
    }
    public static bool IsValidDate(string date)
    {
      var dateRegex = new Regex(@"^\d{2}\.\d{2}\.\d{4}$");
      return dateRegex.IsMatch(date);

    }
    public static bool IsValidPhoneNumber(string phoneNumber)
    {
      var phoneRegex = new Regex(@"^\+?7?\s?\d{3}\s?\d{3}-?\d{4}$");
      return phoneRegex.IsMatch(phoneNumber.Replace(" ", "").Replace("-", ""));
    }
    public static bool ValidateFIO(string fio)
    {
      var fioRegex = new Regex(@"^[А-Яа-яЁё]+ [А-Яа-яЁё]+ [А-Яа-яЁё]+$");
      return fioRegex.IsMatch(fio);
    }
    public static bool ValidateCity(string city)
    {
      var fioRegex = new Regex(@"^\s*[А-Яа-яЁё]+(\s+[А-Яа-яЁё]+)*\s*$");
      return fioRegex.IsMatch(city);
    }
    /* public static string CapitalizeFirstLetters(string inputString)
     {
       string[] words = inputString.Split(' ');

       for(int i =0; i < words.Length; i++)
       {
         words[i].Substring(0).ToUpper();
       }
       return string.Join(" ", words);

     }*/

  }
}
