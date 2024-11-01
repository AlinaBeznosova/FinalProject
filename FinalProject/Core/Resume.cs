using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  public class Resume
  {
    public PersonalInfo PersonalInfo { get; set; }
    public List<Experience> Experiences { get; set; }
    public List<Education> Educations { get; set; }
    public List<Skill> Skills { get; set; }
    public List<Achievement> Achievements { get; set; }

    public Resume()
    {
      Experiences = new List<Experience>();
      Educations = new List<Education>();
      Skills = new List<Skill>();
      Achievements = new List<Achievement>();
    }

    public void AddExperience(Experience experience)
    {
      Experiences.Add(experience);
    }

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

    public void AddEducation(Education education)
    {
      Educations.Add(education);
    }

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

    public void AddSkill(Skill skill)
    {
      Skills.Add(skill);
    }

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

    public void AddAchievement(Achievement achievement)
    {
      Achievements.Add(achievement);
    }

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
