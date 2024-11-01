using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.DataBase
{
  public class DataBaseManager
  {
    const string connectionString = "Data Source=\"C:\\Users\\Алина\\source\\repos\\FinalProject\\DataBase.db\"";
    readonly SQLiteConnection connection = new SQLiteConnection(connectionString);
    public DataBaseManager() { }

    
    public void SavePersonalInfo(PersonalInfo person) 
    {
      string name = person.FullName;
      string date = person.DateOfBirth;
      string gender = person.Gender;
      string city = person.City;
      string phoneNumber = person.PhoneNumber;
      string email = person.Email; 
      string maritalStatus = person.MaritalStatus;

      connection.Open();
      SQLiteCommand command = connection.CreateCommand();
      command.CommandText = @"
               INSERT INTO PersonalInfo (
                 FullName,
                 DateOfBirth,
                 Gender,
                 City,
                 PhoneNumber,
                 Email,
                 MaritalStatus) 
               VALUES (
                 @name, 
                 @date, 
                 @gender,
                 @city,
                 @phoneNumber,
                 @email,
                 @maritalStatus)";

      command.Parameters.AddWithValue("@name", name);
      command.Parameters.AddWithValue("@date", date);
      command.Parameters.AddWithValue("@gender", gender);
      command.Parameters.AddWithValue("@city", city);
      command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
      command.Parameters.AddWithValue("@email", email);
      command.Parameters.AddWithValue("@maritalStatus", maritalStatus);

      if (command.ExecuteNonQuery() != 0)
        MessageBox.Show("Данные сохранены");
      else
        MessageBox.Show("Данные не сохранены");
      connection.Close();
    }
  }
}
