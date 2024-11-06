using FinalProject.Core;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FinalProject.DataBase
{
  public class DataBaseManager
  {
    const string connectionString = "Data Source=\"C:\\Users\\Алина\\source\\repos\\FinalProject\\DataBase.db\"";
    public DataBaseManager() { }

    /// <summary>
    /// Регистрация пользователя. Добавление в таблицу Users.
    /// </summary>
    /// <param name="user">Пользователь.</param>
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
            User.UserId = Convert.ToInt32(userId);
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


            command.Parameters.AddWithValue("@userId", User.UserId);
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


            command.Parameters.AddWithValue("@userId", User.UserId);
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

    public void AddEducation(Education education)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          connection.Open();
          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                   INSERT INTO Education (
                     UserId,
                     Institution,
                     Specialty,
                     YearOfGraduation) 
                   VALUES (
                     @userId,
                     @institution, 
                     @specialty, 
                     @yearOfGraduation)";


            command.Parameters.AddWithValue("@userId", User.UserId);
            command.Parameters.AddWithValue("@institution", education.Institution);
            command.Parameters.AddWithValue("@specialty", education.Specialty);
            command.Parameters.AddWithValue("@yearOfGraduation", education.YearOfGraduation);

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
    public void AddSkill(Skill skill)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          connection.Open();
          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                   INSERT INTO Skills (
                     UserId,
                     HardSkill,
                     SoftSkill) 
                   VALUES (
                     @userId,
                     @hardSkill, 
                     @softSkill)";

            command.Parameters.AddWithValue("@userId", User.UserId);
            command.Parameters.AddWithValue("@hardSkill", skill.Hardskill);
            command.Parameters.AddWithValue("@softSkill", skill.Softskill);

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
    public void AddAchievement(Achievement achievement)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          connection.Open();
          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                   INSERT INTO Achievements (
                     UserId,
                     AchievementName) 
                   VALUES (
                     @userId,
                     @achievementName)";


            command.Parameters.AddWithValue("@userId", User.UserId);
            command.Parameters.AddWithValue("@achievementName", achievement.AchievementName);

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

    public bool CheckForDrafts(int currentUserId)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = "SELECT * FROM PersonalInfo WHERE UserId = @userId";
          command.Parameters.AddWithValue("@userId", currentUserId);

          object result = command.ExecuteScalar();
          return result != null;
        }
      }
    }

    public List<string> DraftNames(int currentUserId)
    {
      List<string> fullNames = new List<string>();
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = "SELECT FullName FROM PersonalInfo WHERE UserId = @userId";
          command.Parameters.AddWithValue("@userId", currentUserId);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              fullNames.Add(reader["FullName"].ToString());
            }
          }
        }
      }
      return fullNames;
    }

    public PersonalInfo FindInfoByFullName(string FIO)
    {
      PersonalInfo person = new PersonalInfo();
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = @"
                   SELECT * FROM PersonalInfo 
                   WHERE FullName = @fullName AND UserId = @userId";

          command.Parameters.AddWithValue("@fullName", FIO);
          command.Parameters.AddWithValue("@userId", User.UserId);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            if (reader.Read())
            {
              person.FullName = reader["FullName"].ToString();
              person.DateOfBirth = reader["DateOfBirth"].ToString();
              person.Gender = reader["Gender"].ToString();
              person.MaritalStatus = reader["MaritalStatus"].ToString();
              person.City = reader["City"].ToString();
              person.Email = reader["Email"].ToString();
              person.PhoneNumber = reader["PhoneNumber"].ToString();

            }
          }
        }
      }
      return person;
    }


  }
}
