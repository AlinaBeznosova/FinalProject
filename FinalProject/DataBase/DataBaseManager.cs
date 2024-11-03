using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using FinalProject.Core;

namespace FinalProject.DataBase
{
  public class DataBaseManager
  {
    const string connectionString = "Data Source=\"C:\\Users\\Алина\\source\\repos\\FinalProject\\DataBase.db\"";
    public DataBaseManager() { }

    public void RegisterUser(User user)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          connection.Open();
          SQLiteCommand command = connection.CreateCommand();

          command.CommandText = @"
                   INSERT INTO Users (
                     Login,
                     Password) 
                   VALUES (
                     @login, 
                     @password)";

          command.Parameters.AddWithValue("@login", user.Login);
          
          command.Parameters.AddWithValue("@password", user.Password);

          int rowsAffected = command.ExecuteNonQuery();
          
          

          if (rowsAffected > 0)
          {
            MessageBox.Show("Пользователь зарегистрирован");
          }
          else
          {
            MessageBox.Show("Пользователь не зарегистрирован");
          }
         
        }
        catch (SQLiteException ex)
        {
          MessageBox.Show("Ошибка регистрации пользователя: " + ex.Message);
        }
        finally
        {
          connection.Close();
        }
      }
    }

    public bool FindUser(User user)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = @"
                   SELECT * FROM Users 
                   WHERE Login = @login AND Password = @password";

          command.Parameters.AddWithValue("@login", user.Login);
          command.Parameters.AddWithValue("@password", user.Password);

          object userId = command.ExecuteScalar();

          if (userId != null)
          {
            User.CurrentUserId = Convert.ToInt32(userId);
            return true;
          }
          else
          {
            return false;
          }
        
        }
      }
    }
    
    public void SavePersonalInfo(PersonalInfo person) 
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          connection.Open();
          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                   INSERT INTO PersonalInfo (
                     UserId,
                     FullName,
                     DateOfBirth,
                     Gender,
                     City,
                     PhoneNumber,
                     Email,
                     MaritalStatus) 
                   VALUES (
                     @userId,
                     @name, 
                     @date, 
                     @gender,
                     @city,
                     @phoneNumber,
                     @email,
                     @maritalStatus)";

            command.Parameters.AddWithValue("@userId", User.CurrentUserId);
            command.Parameters.AddWithValue("@name", person.FullName);
            command.Parameters.AddWithValue("@date", person.DateOfBirth);
            command.Parameters.AddWithValue("@gender", person.Gender);
            command.Parameters.AddWithValue("@city", person.City);
            command.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
            command.Parameters.AddWithValue("@email", person.Email);
            command.Parameters.AddWithValue("@maritalStatus", person.MaritalStatus);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
              MessageBox.Show("Данные сохранены");
            }
            else
            {
              MessageBox.Show("Данные не сохранены");
            }
          }
        }
        catch (SQLiteException ex)
        {
          MessageBox.Show("Ошибка сохранения данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
        }
      }
  }

    public void AddExperience(Experience experience)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          connection.Open();
          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                   INSERT INTO Experience (
                     UserId,
                     Position,
                     Company,
                     StartDate,
                     EndDate,
                     Responsibilities) 
                   VALUES (
                     @userId,
                     @position, 
                     @company, 
                     @startDate,
                     @endDate,
                     @responsibilities)";

            command.Parameters.AddWithValue("@userId", User.CurrentUserId);
            command.Parameters.AddWithValue("@position", experience.Position);
            command.Parameters.AddWithValue("@company", experience.Company);
            command.Parameters.AddWithValue("@startDate", experience.StartDate);
            command.Parameters.AddWithValue("@endDate", experience.EndDate);
            command.Parameters.AddWithValue("@responsibilities", experience.Responsibilities);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
              MessageBox.Show("Данные сохранены");
            }
            else
            {
              MessageBox.Show("Данные не сохранены");
            }
          }
        }
        catch (SQLiteException ex)
        {
          MessageBox.Show("Ошибка сохранения данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
        }
      }
    }
  }
}
