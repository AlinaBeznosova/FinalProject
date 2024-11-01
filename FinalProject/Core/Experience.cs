using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  public class Experience
  {
    public string Position { get; set; }
    public string Company { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Responsibilities { get; set; }

    public Experience(string position, string company, DateTime startDate,
      DateTime endDate, string responsibilities)
    {
      Position = position;
      Company = company;
      StartDate = startDate;
      EndDate = endDate;
      Responsibilities = responsibilities;
    }
  }
}
