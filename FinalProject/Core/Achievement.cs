using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  /// <summary>
  /// Достижения.
  /// </summary>
  public class Achievement
  {
    #region Поля и свойства
    /// <summary>
    /// Достижение.
    /// </summary>
    public string AchievementName { get; set; }
    #endregion

    #region Конструкторы
    /// <summary>
    /// Конструктор.
    /// </summary>
    public Achievement() { }
    
    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="achievementName">Достижение.</param>
    public Achievement(string achievementName)
    {
      AchievementName = achievementName;
    }
    #endregion
  }
}
