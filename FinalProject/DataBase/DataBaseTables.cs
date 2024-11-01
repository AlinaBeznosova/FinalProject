using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
  public class DataBaseTables
  {
    const string connectionString = "Data Source=\"C:\\Users\\Алина\\source\\repos\\FinalProject\\DataBase.db\"";
    readonly SQLiteConnection connection = new SQLiteConnection(connectionString);

    public DataBaseTables() { }

    private void CreateResumeTableIfNotExists()
    {
      connection.Open();
      var command = connection.CreateCommand();
      command.CommandText = @"
            CREATE TABLE IF NOT EXISTS Resume (
                ResumeId INTEGER PRIMARY KEY AUTOINCREMENT,
                PersonalInfoId INTEGER,
                ExperienceId INTEGER,
                FOREIGN KEY (PersonalInfoId) REFERENCES PersonalInfo (PersonalInfoId),
                FOREIGN KEY (ExperienceId) REFERENCES Experience (ExperienceId)
            );
        ";
      if (command.ExecuteNonQuery() == 0)
        throw new Exception("Не удалось создать таблицу Resume");
      connection.Close();
    }

    private void CreatePersonalInfoTableIfNotExists()
    {
      connection.Open();
      var command = connection.CreateCommand();
      command.CommandText = @"
            CREATE TABLE IF NOT EXISTS PersonalInfo (
                PersonalInfoId INTEGER PRIMARY KEY AUTOINCREMENT,
                FullName TEXT NOT NULL,
                DateOfBirth TEXT NOT NULL,
                Gender TEXT NOT NULL,
                City TEXT NOT NULL,
                PhoneNumber TEXT NOT NULL,
                Email TEXT NOT NULL,
                MaritalStatus TEXT NOT NULL
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
                ExperienceId INTEGER PRIMARY KEY AUTOINCREMENT,
                Position TEXT NOT NULL,
                Company TEXT NOT NULL,
                StartDate TEXT NOT NULL,
                EndDate TEXT NOT NULL,
                Responsibility TEXT NOT NULL,
            );
        ";
      if (command.ExecuteNonQuery() == 0)
        throw new Exception("Не удалось создать таблицу Experience");
      connection.Close();
    }
  }
}
