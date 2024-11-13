using FinalProject.Core;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using log4net;
using Aspose.Words.Bibliography;


namespace FinalProject.DataBase
{
  /// <summary>
  /// Управление базой данных.
  /// </summary>
  public class DataBaseManager
  {
    #region Поля и свойства
    /// <summary>
    /// Логер.
    /// </summary>
    private static readonly ILog _logger = LogManager.GetLogger(typeof(DataBaseManager));

    /// <summary>
    /// Путь подключения к баз данных.
    /// </summary>
    const string connectionString = "Data Source=\"C:\\Users\\Алина\\source\\repos\\FinalProject\\DataBase.db\"";
    #endregion

    #region Методы
    /// <summary>
    /// Зарегистрировать пользователя. Добавить в таблицу Users.
    /// </summary>
    /// <param name="user">Пользователь.</param>
    public void RegisterUser(User user)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка регистрации пользователя");
          _logger.Debug("Открытие соединения с базой данных");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

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

          _logger.Debug("Выполнение запроса на регистрацию пользователя");
          int rowsAffected = command.ExecuteNonQuery();
          _logger.Debug("Запрос на регистрацию пользователя выполнен");

          if (rowsAffected > 0)
          {
            _logger.Info("Пользователь зарегистрирован успешно");
            MessageBox.Show("Пользователь зарегистрирован");
          }
          else
          {
            _logger.Warn("Пользователь не зарегистрирован");
            MessageBox.Show("Пользователь не зарегистрирован");
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка регистрации пользователя", ex);
          MessageBox.Show("Ошибка регистрации пользователя: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
    }

    /// <summary>
    /// Существует пользователь в таблице Users? Авторизовать, если да.
    /// </summary>
    /// <param name="user">Пользователь.</param>
    /// <returns>true - если сущесвует, false -  если не существует.</returns>
    public bool IsUserExist(User user)
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
    
    /// <summary>
    /// Проверка есть ли у пользователя черновики.
    /// </summary>
    /// <param name="currentUserId">Текущий id пользователя.</param>
    /// <returns>true - если есть, false - если нет.</returns>
    public bool CheckForDrafts(int currentUserId)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = "SELECT * FROM PersonalInfo WHERE UserId = @userId";
          command.Parameters.AddWithValue("@userId", currentUserId);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            return reader.Read();
          }
        }
      }
    }

    /// <summary>
    /// Список черновиков пользователя.
    /// </summary>
    /// <param name="currentUserId">Текущий id пользователя.</param>
    /// <returns></returns>
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

    /// <summary>
    /// Найти личность по ФИО.
    /// </summary>
    /// <param name="FIO">ФИО.</param>
    /// <returns>Личность из таблицы PersonalInfo.</returns>
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
          
          object personId = command.ExecuteScalar();
          PersonalInfo.PersonalInfoId = Convert.ToInt32(personId);

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

    /// <summary>
    /// Существует личность в таблице PersonalInfo? 
    /// </summary>
    /// <param name="person">Личность.</param>
    /// <returns>true - если существует, false - если не существует.</returns>
    public bool IsIdenticPersonExist(PersonalInfo person)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = @"
                   SELECT * FROM PersonalInfo 
                   WHERE
                     FullName = @name AND
                     DateOfBirth = @date AND 
                     Gender = @gender AND 
                     City =  @city AND 
                     PhoneNumber = @phoneNumber AND
                     Email = @email AND 
                     MaritalStatus = @maritalStatus
                      ";

          command.Parameters.AddWithValue("@name", person.FullName);
          command.Parameters.AddWithValue("@date", person.DateOfBirth);
          command.Parameters.AddWithValue("@gender", person.Gender);
          command.Parameters.AddWithValue("@city", person.City);
          command.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
          command.Parameters.AddWithValue("@email", person.Email);
          command.Parameters.AddWithValue("@maritalStatus", person.MaritalStatus);


          object personId = command.ExecuteScalar();

          if (personId != null)
          {
            PersonalInfo.PersonalInfoId = Convert.ToInt32(personId);
            return true;
          }
          else
          {
            return false;
          }
        }
      }
    }

    /// <summary>
    /// Обновить личные данные.
    /// </summary>
    /// <param name="person">Личность.</param>
    public void UpdatePersonalInfo(PersonalInfo person)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка обновления личной информации пользователя");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                        UPDATE PersonalInfo
                        SET FullName = @name,
                            DateOfBirth = @date,
                            Gender = @gender,
                            City = @city,
                            PhoneNumber = @phoneNumber,
                            Email = @email,
                            MaritalStatus = @maritalStatus
                        WHERE UserId = @userId AND PersonalInfoId = @personalInfoId
                    ";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@userId", User.UserId);
            command.Parameters.AddWithValue("@personalInfoId",PersonalInfo.PersonalInfoId);
            command.Parameters.AddWithValue("@name", person.FullName);
            command.Parameters.AddWithValue("@date", person.DateOfBirth);
            command.Parameters.AddWithValue("@gender", person.Gender);
            command.Parameters.AddWithValue("@city", person.City);
            command.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
            command.Parameters.AddWithValue("@email", person.Email);
            command.Parameters.AddWithValue("@maritalStatus", person.MaritalStatus);

            _logger.Debug("Выполнение запроса на обновление личной информации пользователя");
            int rowsAffected = command.ExecuteNonQuery();
            _logger.Debug("Запрос на обновление личной информации пользователя выполнен");

            if (rowsAffected != 0)
            {
              _logger.Info("Личная информация пользователя обновлена успешно");
              MessageBox.Show("Данные обновлены");
            }
            else
            {
              _logger.Warn("Личная информация пользователя не обновлена");
              MessageBox.Show("Данные не обновлены");
            }
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка обновления личной информации пользователя", ex);
          MessageBox.Show("Ошибка обновления данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
    }

    /// <summary>
    /// Сохранить личные данные в таблицу PersonalInfo.
    /// </summary>
    /// <param name="person">Личность.</param>
    public void AddPersonalInfo(PersonalInfo person)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка сохранения личной информации пользователя");
          _logger.Debug("Открытие соединения с базой данных");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

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

            _logger.Debug("Выполнение запроса на сохранение личной информации пользователя");
            command.ExecuteNonQuery();
            _logger.Debug("Запрос на сохранение личной информации пользователя выполнен");

            var personId = connection.LastInsertRowId;
            PersonalInfo.PersonalInfoId = Convert.ToInt32(personId);
            _logger.Info("Личная информация пользователя сохранена успешно");
            MessageBox.Show("Данные сохранены");
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка сохранения данных пользователя", ex);
          MessageBox.Show("Ошибка сохранения данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
    }

   /// <summary>
   /// Удалить черновик.
   /// </summary>
   /// <param name="fullName">ФИО.</param>
   /// <param name="currentPersonalInfo">Текущий id личности.</param>
    public void DeleteDraft(string fullName, int currentPersonalInfo)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка удаления личных данных");
          _logger.Debug("Открытие соединения с базой данных");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

          using (SQLiteTransaction transaction = connection.BeginTransaction())
          {
            using (SQLiteCommand command = connection.CreateCommand())
            {
              
              command.CommandText = @"
                        DELETE FROM Experience 
                          WHERE 
                          PersonalInfoId = @personalInfoId";
              command.Parameters.AddWithValue("@personalInfoId", currentPersonalInfo);
              _logger.Debug("Выполнение запроса на удаление опыта работы");
              command.ExecuteNonQuery();
              _logger.Debug("Запрос на удаление опыта работы выполнен");

              command.CommandText = @"
                        DELETE FROM Education 
                          WHERE 
                          PersonalInfoId = @personalInfoId";
              command.Parameters.Clear();
              command.Parameters.AddWithValue("@personalInfoId", currentPersonalInfo);
              _logger.Debug("Выполнение запроса на удаление образования");
              command.ExecuteNonQuery();
              _logger.Debug("Запрос на удаление образования выполнен");

              command.CommandText = @"
                        DELETE FROM Skills 
                          WHERE 
                          PersonalInfoId = @personalInfoId";
              command.Parameters.Clear();
              command.Parameters.AddWithValue("@personalInfoId", currentPersonalInfo);
              _logger.Debug("Выполнение запроса на удаление навыков");
              command.ExecuteNonQuery();
              _logger.Debug("Запрос на удаление навыков выполнен");

              command.CommandText = @"
                        DELETE FROM Achievements 
                          WHERE 
                          PersonalInfoId = @personalInfoId";
              command.Parameters.Clear();
              command.Parameters.AddWithValue("@personalInfoId", currentPersonalInfo);
              _logger.Debug("Выполнение запроса на удаление достижений");
              command.ExecuteNonQuery();
              _logger.Debug("Запрос на удаление достижений выполнен");

              command.CommandText = @"
                        DELETE FROM PersonalInfo 
                          WHERE 
                          UserId = @userId AND
                          PersonalInfoId = @personalInfoId AND
                          FullName = @fullName";
              command.Parameters.Clear();
              command.Parameters.AddWithValue("@userId", User.UserId);
              command.Parameters.AddWithValue("@personalInfoId", currentPersonalInfo);
              command.Parameters.AddWithValue("@fullName", fullName);
              _logger.Debug("Выполнение запроса на удаление личной информации");
              int rowsAffectedPersonalInfo = command.ExecuteNonQuery();
              _logger.Debug("Запрос на удаление личной информации выполнен");

              if (rowsAffectedPersonalInfo > 0)
              {
                transaction.Commit();
                _logger.Info("Личные данные удалены успешно");
                MessageBox.Show("Личные данные удалены успешно");
              }
              else
              {
                transaction.Rollback();
                _logger.Warn("Личные данные не найдены или не удалены");
                MessageBox.Show("Личные данные не найдены или не удалены");
              }
            }
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка удаления личных данных", ex);
          MessageBox.Show("Ошибка удаления данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
  }

    /// <summary>
    /// Существует ли уже такой опыт работы?
    /// </summary>
    /// <param name="experience">Опыт работы.</param>
    /// <returns>true если хоть одна запись найдена.</returns>
    public bool IsIdenticExperienceExist(Experience experience)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = @"
                   SELECT * FROM Experience
                   WHERE
                     Position = @position AND
                     Company = @company AND 
                     Responsibilities = @responsibilities AND 
                     StartDate =  @startDate AND 
                     EndDate = @endDate";

          command.Parameters.AddWithValue("@position",experience.Position);
          command.Parameters.AddWithValue("@company", experience.Company);
          command.Parameters.AddWithValue("@responsibilities", experience.Responsibilities);
          command.Parameters.AddWithValue("@startDate",experience.StartDate);
          command.Parameters.AddWithValue("@endDate",experience.EndDate);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            return reader.Read(); 
          }
        }
      }
    }

    /// <summary>
    /// Добавить опыт работы в таблицу Experience.
    /// </summary>
    /// <param name="experience">Опыт работы.</param>
    public void AddExperience(Experience experience)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка сохранения опыта работы");
          _logger.Debug("Открытие соединения с базой данных");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                        INSERT INTO Experience (
                          PersonalInfoId,
                          Position,
                          Company,
                          StartDate,
                          EndDate,
                          Responsibilities) 
                        VALUES (
                          @personalInfoId,
                          @position, 
                          @company, 
                          @startDate,
                          @endDate,
                          @responsibilities)";

            command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
            command.Parameters.AddWithValue("@position", experience.Position);
            command.Parameters.AddWithValue("@company", experience.Company);
            command.Parameters.AddWithValue("@startDate", experience.StartDate);
            command.Parameters.AddWithValue("@endDate", experience.EndDate);
            command.Parameters.AddWithValue("@responsibilities", experience.Responsibilities);

            _logger.Debug("Выполнение запроса на сохранение опыта работы");
            int rowsAffected = command.ExecuteNonQuery();
            _logger.Debug("Запрос на сохранение опыта работы выполнен");

            if (rowsAffected > 0)
            {
              
              _logger.Info("Опыт работы сохранен успешно");
              MessageBox.Show("Данные сохранены");
            }
            else
            {
              _logger.Warn("Опыт работы не сохранен");
              MessageBox.Show("Данные не сохранены");
            }
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка сохранения данных опыта работы", ex);
          MessageBox.Show("Ошибка сохранения данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
    }

    /// <summary>
    /// Существует ли опыт работы у личности?
    /// </summary>
    /// <param name="currentPersonId">Текущий id личности.</param>
    /// <returns>true - если хоть одна запись существует.</returns>
    public bool IsExperienceExist(int currentPersonId)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = "SELECT * FROM Experience WHERE PersonalInfoId = @personalInfoId";
          command.Parameters.AddWithValue("@personalInfoId", currentPersonId);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            return reader.Read();
          }
        }
      }
    }

    /// <summary>
    /// Список имеющегося опыта работы конкретной личности.
    /// </summary>
    /// <param name="currentPersonId">Текущий id личности.</param>
    /// <returns>Список должностей.</returns>
    public List<string> ExperienceList(int currentPersonId)
    {
      List<string> experienceList = new List<string>();
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = "SELECT Position FROM Experience WHERE PersonalInfoId = @personalInfoId";
          command.Parameters.AddWithValue("@personalInfoId", currentPersonId);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              experienceList.Add(reader["Position"].ToString());
            }
          }
        }
      }
      return experienceList;
    }

    /// <summary>
    /// Найти опыт работы по должности.
    /// </summary>
    /// <param name="position">Должность.</param>
    /// <param name="currentExpId">Текущий id пользователя.</param>
    /// <returns>Опыт работы.</returns>
    public Experience FindExperienceByPosition(string position)
    {
      Experience experience = new Experience();
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = @"
                  SELECT * FROM Experience 
                   WHERE
                     PersonalInfoId = @personalInfoId AND
                     Position = @position";

          command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
          command.Parameters.AddWithValue("@position",position);
          

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            if (reader.Read())
            {
              experience.Position = reader["Position"].ToString();
              experience.Company = reader["Company"].ToString();
              experience.StartDate = reader["StartDate"].ToString();
              experience.EndDate = reader["EndDate"].ToString();
              experience.Responsibilities = reader["Responsibilities"].ToString();

            }
          }
        }
      }
      return experience;
    }

    /// <summary>
    /// Обновить опыт работы.
    /// </summary>
    /// <param name="experience">Опыт работы.</param>
    public void UpdateExperience(Experience experience)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка обновления опыта работы");
          _logger.Debug("Открытие соединения с базой данных");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                        UPDATE Experience
                        SET Position = @position,
                            Company = @company,
                            StartDate = @startDate,
                            EndDate = @endDate,
                            Responsibilities = @responsibilities
                        WHERE PersonalInfoId = @personalInfoId ";

            
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
            command.Parameters.AddWithValue("@position", experience.Position);
            command.Parameters.AddWithValue("@company", experience.Company);
            command.Parameters.AddWithValue("@startDate", experience.StartDate);
            command.Parameters.AddWithValue("@endDate", experience.EndDate);
            command.Parameters.AddWithValue("@responsibilities", experience.Responsibilities);

            _logger.Debug("Выполнение запроса на обновление опыта работы");
            int rowsAffected = command.ExecuteNonQuery();
            _logger.Debug("Запрос на обновление опыта работы выполнен");

            if (rowsAffected > 0)
            {
              _logger.Info("Опыт работы обновлен успешно");
              MessageBox.Show("Данные обновлены");
            }
            else
            {
              _logger.Warn("Опыт работы не обновлен");
              MessageBox.Show("Данные не обновлены");
            }
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка обновления данных опыта работы", ex);
          MessageBox.Show("Ошибка обновления данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
    }

    /// <summary>
    /// Удалить опыт работы.
    /// </summary>
    /// <param name="position">Должность.</param>
    public void DeleteExperience(string position)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка удаления опыта работы");
          _logger.Debug("Открытие соединения с базой данных");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                        DELETE FROM Experience 
                          WHERE 
                          PersonalInfoId = @personalInfoId AND
                          Position = @position";

            command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
            command.Parameters.AddWithValue("@position", position);

            _logger.Debug("Выполнение запроса на удаление опыта работы");
            int rowsAffected = command.ExecuteNonQuery();
            _logger.Debug("Запрос на удаление опыта работы выполнен");

            if (rowsAffected > 0)
            {
              _logger.Info("Опыт работы удален успешно");
              MessageBox.Show("Должность удалена успешно");
            }
            else
            {
              _logger.Warn("Опыт работы не найден или не удален");
              MessageBox.Show("Должность не найдена или не удалена");
            }
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка удаления данных опыта работы", ex);
          MessageBox.Show("Ошибка удаления данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
    }

    /// <summary>
    /// Существует ли уже такое образование?
    /// </summary>
    /// <param name="education">Образование.</param>
    /// <returns>true если хоть одна запись найдена.</returns>
    public bool IsIdenticEducationExist(Education education)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = @"
                   SELECT * FROM Experience
                   WHERE
                     Institution = @institution AND
                     Specialty = @specialty AND
                     YearOfGraduation = @YearOfGraduation ";

          command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
          command.Parameters.AddWithValue("@institution", education.Institution);
          command.Parameters.AddWithValue("@specialty", education.Specialty);
          command.Parameters.AddWithValue("@yearOfGraduation", education.YearOfGraduation);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            return reader.Read();
          }
        }
      }
    }

    /// <summary>
    /// Добавить образование в таблицу Education.
    /// </summary>
    /// <param name="education">Образование.</param>
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
                     PersonalInfoId,
                     Institution,
                     Specialty,
                     YearOfGraduation) 
                   VALUES (
                     @personalInfoId,
                     @institution, 
                     @specialty, 
                     @yearOfGraduation)";


            command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
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
   
    /// <summary>
    /// Существует ли образование у личности?
    /// </summary>
    /// <param name="currentPersonalInfoId">Текущий Id пользователя.</param>
    /// <returns>true - если хоть одна запись существует.</returns>
    public bool IsEducationExist(int currentPersonId)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = "SELECT * FROM Education WHERE PersonalInfoId = @personalInfoId";
          command.Parameters.AddWithValue("@personalInfoId", currentPersonId);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            return reader.Read();
          }
        }
      }
    }

    /// <summary>
    /// Список образования у конкретной личности.
    /// </summary>
    /// <param name="currentPersonId">Текущий Id личности.</param>
    /// <returns>Список институтов.</returns>
    public List<string> EducationList(int currentPersonId)
    {
      List<string> educationList = new List<string>();
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = "SELECT * FROM Education WHERE PersonalInfoId = @personalInfoId";
          command.Parameters.AddWithValue("@personalInfoId", currentPersonId);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              educationList.Add(reader["Institution"].ToString());
            }
          }
        }
      }
      return educationList;
    }

    /// <summary>
    /// Найти образование по учебному заведению.
    /// </summary>
    /// <param name="institution">Учебное заведение.</param>
    /// <returns>Образование.</returns>
    public Education FindEducationByInstitution(string institution)
    {
      Education education = new Education();
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = @"
                  SELECT * FROM Education 
                   WHERE
                     PersonalInfoId = @personalInfoId AND
                     Institution = @institution";

          command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
          command.Parameters.AddWithValue("@institution", institution);


          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            if (reader.Read())
            {
              education.Institution = reader["Institution"].ToString();
              education.Specialty = reader["Specialty"].ToString();
              education.YearOfGraduation = reader["YearOfGraduation"].ToString();
            }
          }
        }
      }
      return education;
    }

    /// <summary>
    /// Обновить образование.
    /// </summary>
    /// <param name="education">Образование.</param>
    public void UpdateEducation(Education education)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка обновления опыта работы");
          _logger.Debug("Открытие соединения с базой данных");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                        UPDATE Education
                        SET Institution = @institution 
                            Specialty = @specialty 
                            YearOfGraduation = @YearOfGraduation 
                        WHERE PersonalInfoId = @personalInfoId ";


            command.Parameters.Clear();
            command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
            command.Parameters.AddWithValue("@institution", education.Institution);
            command.Parameters.AddWithValue("@specialty", education.Specialty);
            command.Parameters.AddWithValue("@yearOfGraduation", education.YearOfGraduation);

            _logger.Debug("Выполнение запроса на обновление оразования");
            int rowsAffected = command.ExecuteNonQuery();
            _logger.Debug("Запрос на обновление образования выполнен");

            if (rowsAffected > 0)
            {
              _logger.Info("Образование обновлено успешно");
              MessageBox.Show("Данные обновлены");
            }
            else
            {
              _logger.Warn("Образование не обновлено");
              MessageBox.Show("Данные не обновлены");
            }
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка обновления данных образования", ex);
          MessageBox.Show("Ошибка обновления данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
    }

    /// <summary>
    /// Удалить образование.
    /// </summary>
    /// <param name="institution">Учебное заведение.</param>
    public void DeleteEducation(string institution)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка удаления опыта работы");
          _logger.Debug("Открытие соединения с базой данных");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                        DELETE FROM Education 
                          WHERE 
                          PersonalInfoId = @personalInfoId AND
                     Institution = @institution  ";

            command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
            command.Parameters.AddWithValue("@institution", institution);

            _logger.Debug("Выполнение запроса на удаление образования");
            int rowsAffected = command.ExecuteNonQuery();
            _logger.Debug("Запрос на удаление образования выполнен");

            if (rowsAffected > 0)
            {
              _logger.Info("Образование удалено успешно");
              MessageBox.Show("Образование удалено успешно");
            }
            else
            {
              _logger.Warn("Образование не найдено или не удалено");
              MessageBox.Show("Образование не найдено или не удалено");
            }
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка удаления образования", ex);
          MessageBox.Show("Ошибка удаления данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
    }

    /// <summary>
    /// Существует ли уже такой навык?
    /// </summary>
    /// <param name="skill">Навык.</param>
    /// <returns>true - если существует хоть одна запись.</returns>
    public bool IsIdenticSkillExist(Skill skill)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = @"
                   SELECT * FROM Skills
                   WHERE
                     HardSkill = @hardSkill AND
                     SoftSkill = @softSkill ";

          command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
          command.Parameters.AddWithValue("@hardSkill", skill.Hardskill);
          command.Parameters.AddWithValue("@softSkill",skill.Softskill);
          

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            return reader.Read();
          }
        }
      }
    }

    /// <summary>
    /// Добавить навык в таблицу Skills.
    /// </summary>
    /// <param name="skill">Навык.</param>
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
                     PersonalInfoId,
                     HardSkill,
                     SoftSkill) 
                   VALUES (
                     @personalInfoId,
                     @hardSkill, 
                     @softSkill)";

            command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
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

    /// <summary>
    /// Существует ли навык у личности?
    /// </summary>
    /// <param name="currentPersonId">Текщий id личности.</param>
    /// <returns>true - если хоть одна запись существует.</returns>
    public bool IsSkillExist(int currentPersonId)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = "SELECT * FROM Skills WHERE PersonalInfoId = @personalInfoId";

          command.Parameters.AddWithValue("@personalInfoId", currentPersonId);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            return reader.Read();
          }
        }
      }
    }

    /// <summary>
    /// Список навыков у конкретной личности.
    /// </summary>
    /// <param name="currentPersonId">Текущий Id личности.</param>
    /// <returns>Список навыков.</returns>
    public List<string> SkillList(int currentPersonId)
    {
      List<string> skillList = new List<string>();
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = "SELECT * FROM Skills WHERE PersonalInfoId = @personalInfoId";

          command.Parameters.AddWithValue("@personalInfoId", currentPersonId);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              skillList.Add(reader["HardSkill"].ToString());
            }
          }
        }
      }
      return skillList;
    }

    /// <summary>
    /// Найти нывки по техническим навыкам.
    /// </summary>
    /// <param name="hardSkill">Технические навыки.</param>
    /// <returns>Навыки.</returns>
    public Skill FindSkillByHardSkill(string hardSkill)
    {
      Skill skill = new Skill();
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = @"
                  SELECT * FROM Skills 
                   WHERE
                     PersonalInfoId = @personalInfoId AND
                     HardSkill = @hardSkill";

          command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
          command.Parameters.AddWithValue("@hardSkill", hardSkill);


          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            if (reader.Read())
            {
              skill.Hardskill = reader["HardSkill"].ToString();
              skill.Softskill = reader["Softskill"].ToString();
            }
          }
        }
      }
      return skill;
    }

    /// <summary>
    /// Обновить нfвыки.
    /// </summary>
    /// <param name="skill">Навыки.</param>
    public void UpdateSkill(Skill skill)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка обновления навыков");
          _logger.Debug("Открытие соединения с базой данных");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                        UPDATE Skills
                        SET HardSkill = @hardSkill 
                            SoftSkill = @softSkill 
                        WHERE PersonalInfoId = @personalInfoId ";


            command.Parameters.Clear();
            command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
            command.Parameters.AddWithValue("@hardSkill", skill.Hardskill);
            command.Parameters.AddWithValue("@softSkill", skill.Softskill);


            _logger.Debug("Выполнение запроса на обновление навыков");
            int rowsAffected = command.ExecuteNonQuery();
            _logger.Debug("Запрос на обновление навыков выполнен");

            if (rowsAffected > 0)
            {
              _logger.Info("Навыки обновлены успешно");
              MessageBox.Show("Данные обновлены");
            }
            else
            {
              _logger.Warn("Навыки не обновлены");
              MessageBox.Show("Данные не обновлены");
            }
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка обновления данных навыков", ex);
          MessageBox.Show("Ошибка обновления данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
    }

    /// <summary>
    /// Удалить навык.
    /// </summary>
    /// <param name="skill">Навык.</param>
    public void DeleteSkill(string skill)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка удаления навыка");
          _logger.Debug("Открытие соединения с базой данных");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                        DELETE FROM Skills 
                          WHERE 
                          PersonalInfoId = @personalInfoId AND
                     HardSkill = @hardSkill ";

            command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
            command.Parameters.AddWithValue("@hardSkill", skill);
           
            

            _logger.Debug("Выполнение запроса на удаление навыка");
            int rowsAffected = command.ExecuteNonQuery();
            _logger.Debug("Запрос на удаление навыка выполнен");

            if (rowsAffected > 0)
            {
              _logger.Info("Навык удален успешно");
              MessageBox.Show("Навык удален успешно");
            }
            else
            {
              _logger.Warn("Навык не найден или не удален");
              MessageBox.Show("Навык не найден или не удален");
            }
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка удаления навыка", ex);
          MessageBox.Show("Ошибка удаления данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
    }

    /// <summary>
    /// Существует ли уже такое достижение?
    /// </summary>
    /// <param name="achievement">Достижение.</param>
    /// <returns>true - если существует хоть одна запись.</returns>
    public bool IsIdenticAchievementExist(Achievement achievement)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = @"
                   SELECT * FROM Achievements
                   WHERE
                     AchievementName = @achievementName ";

          command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
          command.Parameters.AddWithValue("@achievementName", achievement.AchievementName);


          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            return reader.Read();
          }
        }
      }
    }

    /// <summary>
    /// Добавить достижение в таблицу Achievements.
    /// </summary>
    /// <param name="achievement">Достижение.</param>
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
                     PersonalInfoId,
                     AchievementName) 
                   VALUES (
                     @personalInfoId,
                     @achievementName)";


            command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
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

    /// <summary>
    /// Существует ли достижение у личности?
    /// </summary>
    /// <param name="currentPersonId">Текщий id личности.</param>
    /// <returns>true - если хоть одна запись существует.</returns>
    public bool IsAchievementExist(int currentPersonId)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = "SELECT * FROM Achievements WHERE PersonalInfoId = @personalInfoId";

          command.Parameters.AddWithValue("@personalInfoId", currentPersonId);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            return reader.Read();
          }
        }
      }
    }

    /// <summary>
    /// Список достижений у конкретной личности.
    /// </summary>
    /// <param name="currentPersonId">Текущий Id личности.</param>
    /// <returns>Список достижений.</returns>
    public List<string> AchievementList(int currentPersonId)
    {
      List<string> achievementList = new List<string>();
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = "SELECT * FROM Achievements WHERE PersonalInfoId = @personalInfoId";

          command.Parameters.AddWithValue("@personalInfoId", currentPersonId);

          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              achievementList.Add(reader["AchievementName"].ToString());
            }
          }
        }
      }
      return achievementList;
    }

    /// <summary>
    /// Найти достижение .
    /// </summary>
    /// <param name="ahievementName">Достижение.</param>
    /// <returns>Достижение.</returns>
    public Achievement FindAchievement(string ahievementName)
    {
      Achievement achievement = new Achievement();
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        connection.Open();
        using (SQLiteCommand command = connection.CreateCommand())
        {
          command.CommandText = @"
                  SELECT * FROM Achievements 
                   WHERE
                     PersonalInfoId = @personalInfoId AND
                     AchievementName = @achievementName";

          command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
          command.Parameters.AddWithValue("@achievementName", ahievementName);


          using (SQLiteDataReader reader = command.ExecuteReader())
          {
            if (reader.Read())
            {
              achievement.AchievementName = reader["AchievementName"].ToString();
             
            }
          }
        }
      }
      return achievement;
    }

    /// <summary>
    /// Обновить достижение.
    /// </summary>
    /// <param name="achievement">Достижение.</param>
    public void UpdateAchievement(Achievement achievement)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка обновления достижения");
          _logger.Debug("Открытие соединения с базой данных");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                        UPDATE Achievements
                        SET AchievementName = @achievementName 
                        WHERE PersonalInfoId = @personalInfoId ";


            command.Parameters.Clear();
            command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
            command.Parameters.AddWithValue("@achievementName", achievement.AchievementName);

            _logger.Debug("Выполнение запроса на обновление достижения");
            int rowsAffected = command.ExecuteNonQuery();
            _logger.Debug("Запрос на обновление достижения выполнен");

            if (rowsAffected > 0)
            {
              _logger.Info("Достижение обновлено успешно");
              MessageBox.Show("Данные обновлены");
            }
            else
            {
              _logger.Warn("Достижение не обновлено");
              MessageBox.Show("Данные не обновлены");
            }
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка обновления данных достижений", ex);
          MessageBox.Show("Ошибка обновления данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
    }

    /// <summary>
    /// Удалить достижение.
    /// </summary>
    /// <param name="achievement">Достижение.</param>
    public void DeleteAchievement(string achievement)
    {
      using (SQLiteConnection connection = new SQLiteConnection(connectionString))
      {
        try
        {
          _logger.Info("Попытка удаления достижения");
          _logger.Debug("Открытие соединения с базой данных");
          connection.Open();
          _logger.Debug("Соединение с базой данных открыто");

          using (SQLiteCommand command = connection.CreateCommand())
          {
            command.CommandText = @"
                        DELETE FROM Achievements 
                          WHERE 
                          PersonalInfoId = @personalInfoId AND
                     AchievementName = @achievementName  ";

            command.Parameters.AddWithValue("@personalInfoId", PersonalInfo.PersonalInfoId);
            command.Parameters.AddWithValue("@achievementName",achievement);

            _logger.Debug("Выполнение запроса на удаление достижения");
            int rowsAffected = command.ExecuteNonQuery();
            _logger.Debug("Запрос на удаление достижения выполнен");

            if (rowsAffected > 0)
            {
              _logger.Info("Достижение удалено успешно");
              MessageBox.Show("Достижение удалено успешно");
            }
            else
            {
              _logger.Warn("Достижение не найдено или не удалено");
              MessageBox.Show("Достижение не найдено или не удалено");
            }
          }
        }
        catch (SQLiteException ex)
        {
          _logger.Error("Ошибка удаления достижения", ex);
          MessageBox.Show("Ошибка удаления данных: " + ex.Message);
        }
        finally
        {
          connection.Close();
          _logger.Debug("Соединение с базой данных закрыто");
        }
      }
    }
    #endregion

    #region Конструкторы
    /// <summary>
    /// Контруктор.
    /// </summary>
    public DataBaseManager() { }
    #endregion
  }
}
