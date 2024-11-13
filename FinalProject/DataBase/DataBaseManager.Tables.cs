using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using log4net;

namespace FinalProject
{
  /// <summary>
  /// Таблицы базы данных.
  /// </summary>
  public class DataBaseManager
  {
    #region Поля и свойства
    /// <summary>
    /// Логер.
    /// </summary>
    private static readonly ILog _logger = LogManager.GetLogger(typeof(DataBaseManager));

    /// <summary>
    /// Путь к базе данных.
    /// </summary>
    const string connectionString = "Data Source=\"C:\\Users\\Алина\\source\\repos\\FinalProject\\DataBase.db\"";
    
    /// <summary>
    /// Подключение к базе данных.
    /// </summary>
    readonly SQLiteConnection connection = new SQLiteConnection(connectionString);
    #endregion

    #region Методы
    /// <summary>
    /// Проверяет существование базы данных и создает ее, если она не существует.
    /// </summary>
    public void EnsureDatabaseCreated()
    {
      if (!File.Exists(connectionString))
      {
        SQLiteConnection.CreateFile(connectionString);
      }
    }

    public bool TableExists(string tableName)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name=@tableName";
          command.Parameters.AddWithValue("@tableName", tableName);
          object result = command.ExecuteScalar();
          return result != null;
        }
      }
    }
    /// <summary>
    /// Проверяет существование всех необходимых таблиц и создает их, если они не существуют.
    /// </summary>
    public void EnsureTablesCreated()
    {
     
      try
      {
        connection.Open();
        _logger.Debug("Соединение с базой данных открыто");
        if (!TableExists("Users"))
          CreateUsersTable();
        if (!TableExists("PersonalInfo"))
          CreatePersonalInfoTable();
        if (!TableExists("Experience"))
          CreateExperienceTable();
        if (!TableExists("Education"))
          CreateEducationTable();
        if (!TableExists("Skills"))
          CreateSkillsTable();
        if (!TableExists("Achievements"))
          CreateAchievementsTable();
      }
      catch (SQLiteException ex)
      {
        _logger.Error("Ошибка создания таблиц", ex);
        MessageBox.Show("Ошибка создания таблиц: " + ex.Message);
      }
      finally
      {
        connection.Close();
        _logger.Debug("Соединение с базой данных закрыто");
      }
    }

    /// <summary>
    /// Создать таблицу пользователей.
    /// </summary>
    /// <exception cref="Exception">Исключение.</exception>
    private void CreateUsersTable()
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

    /// <summary>
    /// Создать таблицу личных данных.
    /// </summary>
    /// <exception cref="Exception">Исключение.</exception>
    private void CreatePersonalInfoTable()
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

    /// <summary>
    /// Создать таблицу опыта работы.
    /// </summary>
    /// <exception cref="Exception">Исключение.</exception>
    private void CreateExperienceTable()
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

    /// <summary>
    /// Создать таблицу образования.
    /// </summary>
    /// <exception cref="Exception">Исключение.</exception>
    private void CreateEducationTable()
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

    /// <summary>
    /// Создать таблицу навыков.
    /// </summary>
    /// <exception cref="Exception">Исключение.</exception>
    private void CreateSkillsTable()
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

    /// <summary>
    /// Создать таблицу достижений.
    /// </summary>
    /// <exception cref="Exception">Исключение.</exception>
    private void CreateAchievementsTable()
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
    #endregion

    #region Конструкторы
    /// <summary>
    /// Конструктор.
    /// </summary>
    public DataBaseManager() { }
    #endregion
  }
}
