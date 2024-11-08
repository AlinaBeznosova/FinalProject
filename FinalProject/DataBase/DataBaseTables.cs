using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FinalProject
{
  public class DataBaseTables
  {
    const string connectionString = "Data Source=\"C:\\Users\\Алина\\source\\repos\\FinalProject\\DataBase.db\"";
    readonly SQLiteConnection connection = new SQLiteConnection(connectionString);

    public DataBaseTables() { }
   
    private void CreateUsersTableIfNotExists()
    {
      connection.Open();
      var command = connection.CreateCommand();
      command.CommandText = @"
             CREATE TABLE IF NOT EXISTS Users (
	               UserId	 INTEGER PRIMARY KEY AUTOINCREMENT,
	               Login	TEXT NOT NULL,
	               Password	TEXT NOT NULL
             );
        ";
      if (command.ExecuteNonQuery() == 0)
        throw new Exception("Не удалось создать таблицу Users");
      connection.Close();
    }
    private void CreatePersonalInfoTableIfNotExists()
    {
      connection.Open();
      var command = connection.CreateCommand();
      command.CommandText = @"
            CREATE TABLE IF NOT EXISTS PersonalInfo (
                PersonalInfoId INTEGER PRIMARY KEY AUTOINCREMENT,
                UserId	INTEGER NOT NULL,
                FullName TEXT NOT NULL,
                DateOfBirth TEXT NOT NULL,
                Gender TEXT NOT NULL,
                City TEXT NOT NULL,
                PhoneNumber TEXT NOT NULL,
                Email TEXT NOT NULL,
                MaritalStatus TEXT NOT NULL,
                FOREIGN KEY(UserId) REFERENCES Users(UserId)
            );
        ";
      if (command.ExecuteNonQuery() == 0)
        throw new Exception("Не удалось создать таблицу PersonalInfo");
      connection.Close();
    }

    private void CreateExperienceTableIfNotExists()
    {
      connection.Open();
      var command = connection.CreateCommand();
      command.CommandText = @"
            CREATE TABLE IF NOT EXISTS Experience (
                ExperienceId	INTEGER PRIMARY KEY AUTOINCREMENT,
	              PersonalInfoId	INTEGER NOT NULL,
	              Position	TEXT NOT NULL,
	              Company	TEXT NOT NULL,
	              StartDate	TEXT NOT NULL,
	              EndDate	TEXT NOT NULL,
	              Responsibilities	TEXT NOT NULL,
	              FOREIGN KEY(PersonalInfoId) REFERENCES PersonalInfo(PersonalInfoId)
            );
        ";
      if (command.ExecuteNonQuery() == 0)
        throw new Exception("Не удалось создать таблицу Experience");
      connection.Close();
    }
    private void CreateEducationTableIfNotExists()
    {
      connection.Open();
      var command = connection.CreateCommand();
      command.CommandText = @"
            CREATE TABLE IF NOT EXIST Education (
	              EducationId	INTEGER PRIMARY KEY AUTOINCREMENT,
	              PersonalInfoId	INTEGER NOT NULL,
	              Institution	TEXT NOT NULL,
	              Specialty	TEXT NOT NULL,
	              YearOfGraduation	INTEGER NOT NULL,
	              FOREIGN KEY(PersonalInfoId) REFERENCES PersonalInfo(PersonalInfoId)
            );
        ";
      if (command.ExecuteNonQuery() == 0)
        throw new Exception("Не удалось создать таблицу Education");
      connection.Close();
    }
    private void CreateSkillsTableIfNotExists()
    {
      connection.Open();
      var command = connection.CreateCommand();
      command.CommandText = @"
            CREATE TABLE IF NOT EXIST Skills (
	              SkillId INTEGER PRIMARY KEY AUTOINCREMENT,
	              PersonalInfoId	INTEGER NOT NULL,
	              HardSkill	TEXT NOT NULL,
	              SoftSkill	TEXT NOT NULL,
	              FOREIGN KEY(PersonalInfoId) REFERENCES PersonalInfo(PersonalInfoId)
            );
        ";
      if (command.ExecuteNonQuery() == 0)
        throw new Exception("Не удалось создать таблицу Skills");
      connection.Close();
    }

    private void CreateAchievementsTableIfNotExists()
    {
      connection.Open();
      var command = connection.CreateCommand();
      command.CommandText = @"
            CREATE TABLE IF NOT EXIST Achievements (
	              AchievementId	INTEGER PRIMARY KEY AUTOINCREMENT,
	              PersonalInfoId	INTEGER NOT NULL,
	              AchievementName TEXT NOT NULL,
	              FOREIGN KEY(PersonalInfoId) REFERENCES PersonalInfo(PersonalInfoId)
            );
        ";
      if (command.ExecuteNonQuery() == 0)
        throw new Exception("Не удалось создать таблицу Achievements");
      connection.Close();
    }
    private void CreateResumeTableIfNotExists()
    {
      connection.Open();
      var command = connection.CreateCommand();
      command.CommandText = @"
             CREATE TABLE IF NOT EXISTS Resumes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT,
                    Address TEXT,
                    Gender TEXT,
                    Email TEXT,
                    Phone TEXT,
                    FOREIGN KEY (UserId) REFERENCES Users (Id)
             );
        ";
      if (command.ExecuteNonQuery() == 0)
        throw new Exception("Не удалось создать таблицу Resume");
      connection.Close();
    }
  }
}
