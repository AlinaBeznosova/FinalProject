using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProject.Core
{
  public static class Validator
  {
    public static bool IsValidEmail(string email)
    {
      var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
      return emailRegex.IsMatch(email);
    }
    public static bool IsValidDate(string date)
    {
      DateTime parsedDate;
      string[] formats = { "dd.MM.yyyy" };
      return DateTime.TryParseExact(date, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);
    }
    public static bool IsValidPhoneNumber(string phoneNumber)
    {
      var phoneRegex = new Regex(@"^\+7 $$\d{3}$$ \d{3}-\d{2} \d{2}$");
      return phoneRegex.IsMatch(phoneNumber);
    }
  }
}
