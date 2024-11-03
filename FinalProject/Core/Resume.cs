using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  /// <summary>
  /// Резюме.
  /// </summary>
  public class Resume
  {
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
    /// Конструктор.
    /// </summary>
    public Resume()
    {
      Experiences = new List<Experience>();
      Educations = new List<Education>();
      Skills = new List<Skill>();
      Achievements = new List<Achievement>();
    }

    /// <summary>
    /// Добавить опыт работы.
    /// </summary>
    /// <param name="experience">Опыт работы.</param>
    public void AddExperience(Experience experience)
    {
      Experiences.Add(experience);
    }

    /// <summary>
    /// Изменить опыт работы.
    /// </summary>
    /// <param name="position">Должность, которую нужно изменить.</param>
    /// <param name="updatedExperience">Новый опыт работы.</param>
    /// <exception cref="ArgumentException">Исключение, которое возникает, если должность не найдена.</exception>
    public void EditExperience(string position, Experience updatedExperience)
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
      
    }

    /// <summary>
    /// Удалить опыт работы.
    /// </summary>
    /// <param name="position">Должность, которую нужно удалить.</param>
    /// <exception cref="ArgumentException">Исключение, если должность не найдена.</exception>
    public void DeleteExperience(string position)
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
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="education"></param>
    public void AddEducation(Education education)
    {
      Educations.Add(education);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="institution"></param>
    /// <param name="updatedEducation"></param>
    /// <exception cref="ArgumentException"></exception>
    public void EditEducation(string institution, Education updatedEducation)
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
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="institution"></param>
    /// <exception cref="ArgumentException"></exception>
    public void DeleteEducation(string institution)
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
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="skill"></param>
    public void AddSkill(Skill skill)
    {
      Skills.Add(skill);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="skillName"></param>
    /// <param name="updatedSkill"></param>
    /// <exception cref="ArgumentException"></exception>
    public void EditSkill(string skillName, Skill updatedSkill)
    {
      var skillToEdit = Skills.Find(s => s.SkillName == skillName);
      if (skillToEdit != null)
      {
        skillToEdit.SkillName = updatedSkill.SkillName; 
      }
      else
      {
        throw new ArgumentException("Навык не найден");
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="skillName"></param>
    /// <exception cref="ArgumentException"></exception>
    public void DeleteSkill(string skillName)
    {
      var skillToDelete = Skills.Find(s => s.SkillName == skillName);
      if (skillToDelete != null)
      {
        Skills.Remove(skillToDelete);
      }
      else
      {
        throw new ArgumentException("Навык не найден");
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="achievement"></param>
    public void AddAchievement(Achievement achievement)
    {
      Achievements.Add(achievement);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="achievementName"></param>
    /// <param name="updatedAchievement"></param>
    /// <exception cref="ArgumentException"></exception>
    public void EditAchievement(string achievementName, Achievement updatedAchievement)
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
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="achievementName"></param>
    /// <exception cref="ArgumentException"></exception>
    public void DeleteAchievement(string achievementName)
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
    }
  }
}
