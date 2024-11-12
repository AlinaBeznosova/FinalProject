using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  /// <summary>
  ///Образование.
  /// </summary>
  public class Education
  {
    #region Поля и свойства
    /// <summary>
    /// Учебное заведение.
    /// </summary>
    public string Institution { get; set; }

    /// <summary>
    /// Специальность.
    /// </summary>
    public string Specialty { get; set; }

    /// <summary>
    /// Год окончания.
    /// </summary>
    public string YearOfGraduation { get; set; }
    #endregion

    #region Конструкторы
    /// <summary>
    /// Конструктор.
    /// </summary>
    public Education() { }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="institution">Учебное заведение.</param>
    /// <param name="specialty">Специальноть.</param>
    /// <param name="yearOfGraduation">Год окончания.</param>
    public Education(string institution, string specialty, string yearOfGraduation)
    {
      Institution = institution;
      Specialty = specialty;
      YearOfGraduation = yearOfGraduation;
    }
    #endregion
  }
}
