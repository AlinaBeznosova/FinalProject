using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  public class Education
  {
    public string Institution { get; set; }
    public string Specialty { get; set; }
    public string YearOfGraduation { get; set; }

    public Education() { }
    public Education(string institution, string specialty, string yearOfGraduation)
    {
      Institution = institution;
      Specialty = specialty;
      YearOfGraduation = yearOfGraduation;
    }
  }

}
