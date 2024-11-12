using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using FinalProject.Core;
using System.Windows;
using Aspose.Words.Drawing;

namespace FinalProject
{
  /// <summary>
  /// Резюме.
  /// </summary>
  public class Resume
  {
    #region Поля и свойства
    /// <summary>
    /// Личные данные.
    /// </summary>
    public PersonalInfo PersonalInfo { get; set; }

    /// <summary>
    /// Опыт работы.
    /// </summary>
    public List<Experience> Experiences { get; set; }

    /// <summary>
    /// Образование.
    /// </summary>
    public List<Education> Educations { get; set; }

    /// <summary>
    /// Навыки.
    /// </summary>
    public List<Skill> Skills { get; set; }

    /// <summary>
    /// Достижения.
    /// </summary>
    public List<Achievement> Achievements { get; set; }

    /// <summary>
    /// Логер.
    /// </summary>
    private readonly Logger _logger;
    #endregion

    #region Методы
    /// <summary>
    /// Добавить личные данные.
    /// </summary>
    /// <param name="personalInfo">Личные данные.</param>
    public void AddInfo(PersonalInfo personalInfo)
    {
      try
      {
        PersonalInfo = personalInfo;
        _logger.LogInfo("Добавлены личные данные: " + personalInfo.FullName);
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при добавлении личных данных", ex);
      }
    }
    
    /// <summary>
    /// Добавить опыт работы.
    /// </summary>
    /// <param name="experience">Опыт работы.</param>
    public void AddExperience(Experience experience)
    { 
      try
      {
        Experiences.Add(experience);
        _logger.LogInfo("Добавлен опыт работы: " + experience.Position);
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при добавлении опыта работы", ex);
      }
    }

    /// <summary>
    /// Редактировать опыт работы.
    /// </summary>
    /// <param name="position">Должность.</param>
    /// <param name="updatedExperience">Отредактированный опыт работы.</param>
    public void EditExperience(string position, Experience updatedExperience)
    {
      try
      {
        var experienceToEdit = Experiences.Find(e => e.Position == position);
        if (experienceToEdit != null)
        {
          experienceToEdit.Position = updatedExperience.Position;
          experienceToEdit.Company = updatedExperience.Company;
          experienceToEdit.StartDate = updatedExperience.StartDate;
          experienceToEdit.EndDate = updatedExperience.EndDate;
          experienceToEdit.Responsibilities = updatedExperience.Responsibilities;
        }
        else
        {
          throw new ArgumentException("Опыт с указанной должностью не найден");
        }
        _logger.LogInfo("Опыт отредактирован: " + updatedExperience.Position);
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при редактировании опыта", ex);
      }
    }

    /// <summary>
    /// Удалить опыт работы.
    /// </summary>
    /// <param name="position">Должность.</param>
    public void DeleteExperience(string position)
    {
      try
      {
        var experienceToDelete = Experiences.Find(e => e.Position == position);
        if (experienceToDelete != null)
        {
          Experiences.Remove(experienceToDelete);
        }
        else
        {
          throw new ArgumentException("Опыт с указанной должностью не найден");
        }
        _logger.LogInfo("Опыт с дольжностью"  + position + "удален:");
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при удалении опыта", ex);
      }
    }

    /// <summary>
    /// Добавить образование.
    /// </summary>
    /// <param name="education">Образование.</param>
    public void AddEducation(Education education)
    {
      try
      {
        Educations.Add(education);
        _logger.LogInfo("Добавлено образование: " + education.Institution);
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при добавлении образования", ex);
      }
    }

    /// <summary>
    /// Редактировать образование.
    /// </summary>
    /// <param name="institution">Учебное заведение.</param>
    /// <param name="updatedEducation">Отредактированное образование.</param>
    public void EditEducation(string institution, Education updatedEducation)
    { try
      {
        var educationToEdit = Educations.Find(e => e.Institution == institution);
        if (educationToEdit != null)
        {
          educationToEdit.Institution = updatedEducation.Institution;
          educationToEdit.Specialty = updatedEducation.Specialty;
          educationToEdit.YearOfGraduation = updatedEducation.YearOfGraduation;
        }
        else
        {
          throw new ArgumentException("Образование с указанным учреждением не найдено");
        }
        _logger.LogInfo("Образование отредактивроано"+ updatedEducation.Institution );
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при редактировании образования", ex);
      }
    }

    /// <summary>
    /// Удалить образование.
    /// </summary>
    /// <param name="institution">Учебное заведение.</param>
    public void DeleteEducation(string institution)
    {
      try
      {
        var educationToDelete = Educations.Find(e => e.Institution == institution);
        if (educationToDelete != null)
        {
          Educations.Remove(educationToDelete);
        }
        else
        {
          throw new ArgumentException("Образование с указанным учреждением не найдено");
        }
        _logger.LogInfo("Образование удалено" + institution);
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при удалении образования", ex);
      }
    }

    /// <summary>
    /// Добавить навык.
    /// </summary>
    /// <param name="skill">Навык.</param>
    public void AddSkill(Skill skill)
    {
      try
      {
        Skills.Add(skill);
        _logger.LogInfo("Добавлены навыки: " + skill.Hardskill);
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при добавлении навыков", ex);
      }
    }

    /// <summary>
    /// Редактировать навык.
    /// </summary>
    /// <param name="hardSkill">Навык.</param>
    /// <param name="updatedSkill">Отредактированный навык.</param>
    public void EditSkill(string hardSkill, Skill updatedSkill)
    {
      try
      {
        var skillToEdit = Skills.Find(s => s.Hardskill == hardSkill);
        if (skillToEdit != null)
        {
          skillToEdit.Hardskill = updatedSkill.Hardskill;
          skillToEdit.Softskill = updatedSkill.Softskill;
          
        }
        else
        {
          throw new ArgumentException("Навык не найден");
        }
        _logger.LogInfo("Навыки отредактированы");
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при редактировании навыков", ex);
      }
    }

    /// <summary>
    /// Удалить навык.
    /// </summary>
    /// <param name="hardSkill">Навык.</param>
    public void DeleteSkill(string hardSkill)
    {
      try
      {
        var skillToDelete = Skills.Find(s => s.Hardskill == hardSkill);
        if (skillToDelete != null)
        {
          Skills.Remove(skillToDelete);
        }
        else
        {
          throw new ArgumentException("Навык не найден");
        }
        _logger.LogInfo("Навыки удалены" + hardSkill);
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при удалении навыка", ex);
      }
    }

      /// <summary>
      /// Добавить достижение.
      /// </summary>
      /// <param name="achievement">Достижение.</param>
      public void AddAchievement(Achievement achievement)
    {
       try
      {
        Achievements.Add(achievement);
        _logger.LogInfo("Добавлены достижения: " + achievement.AchievementName);
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при добавлении достижений", ex);
      }
    }

    /// <summary>
    /// Редактировать достижения.
    /// </summary>
    /// <param name="achievementName">Достижение.</param>
    /// <param name="updatedAchievement">Отредактированное достижение.</param>
    public void EditAchievement(string achievementName, Achievement updatedAchievement)
    {
      try
      {
        var achievementToEdit = Achievements.Find(a => a.AchievementName == achievementName);
        if (achievementToEdit != null)
        {
          achievementToEdit.AchievementName = updatedAchievement.AchievementName;
        }
        else
        {
          throw new ArgumentException("Достижение не найдено");
        }
        _logger.LogInfo("Достижение отредактировано: " + updatedAchievement.AchievementName);
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при редактировании достижений", ex);
      }
    }

   /// <summary>
   /// Удалить достижения.
   /// </summary>
   /// <param name="achievementName">Достижение.</param>
    public void DeleteAchievement(string achievementName)
    {
      try
      {
        var achievementToDelete = Achievements.Find(a => a.AchievementName == achievementName);
        if (achievementToDelete != null)
        {
          Achievements.Remove(achievementToDelete);
        }
        else
        {
          throw new ArgumentException("Достижение не найдено");
        }
        _logger.LogInfo("Удалены достижения: " + achievementName);
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при удалении достижений", ex);
      }
    }
    #endregion

    #region Конструктор
    /// <summary>
    /// Конструктор.
    /// </summary>
    public Resume()
    {
      _logger = new Logger();
      Experiences = new List<Experience>();
      Educations = new List<Education>();
      Skills = new List<Skill>();
      Achievements = new List<Achievement>();
    }
    #endregion
  }
}
