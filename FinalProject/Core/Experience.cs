using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  /// <summary>
  /// Опыт работы.
  /// </summary>
  public class Experience
  {
    /// <summary>
    /// Должность.
    /// </summary>
    public string Position { get; set; }

    /// <summary>
    /// Компания.
    /// </summary>
    public string Company { get; set; }

    /// <summary>
    /// Дата начала работы.
    /// </summary>
    public string StartDate { get; set; }

    /// <summary>
    /// Дата окончания работы.
    /// </summary>
    public string EndDate { get; set; }

    /// <summary>
    /// Обязанности.
    /// </summary>
    public string Responsibilities { get; set; }

    /// <summary>
    /// Конструктор.
    /// </summary>
    public Experience() { }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="position">Должность.</param>
    /// <param name="company">Компания.</param>
    /// <param name="startDate">Дата начала работы.</param>
    /// <param name="endDate">Дата окончания работы.</param>
    /// <param name="responsibilities">Обязанности.</param>
    public Experience(string position, string company, string startDate,
      string endDate, string responsibilities)
    {
      Position = position;
      Company = company;
      StartDate = startDate;
      EndDate = endDate;
      Responsibilities = responsibilities;
    }
  }
}
