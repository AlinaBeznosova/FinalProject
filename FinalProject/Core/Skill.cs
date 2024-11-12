using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  /// <summary>
  /// Навыки.
  /// </summary>
  public class Skill
  {
    #region Поля и свойства
    /// <summary>
    /// Технические навыки.
    /// </summary>
    public string Hardskill { get; set; }

    /// <summary>
    /// Универсальные навыки.
    /// </summary>
    public string Softskill { get; set; }
    #endregion

    #region Конструкторы
    /// <summary>
    /// Конструктор.
    /// </summary>
    public Skill() { }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="hardSkill">Технические навыки.</param>
    /// <param name="softSkill">Универсальные навыки.</param>
    public Skill(string hardSkill, string softSkill)
    {
      Hardskill = hardSkill;
      Softskill = softSkill;
    }
    #endregion
  }
}
