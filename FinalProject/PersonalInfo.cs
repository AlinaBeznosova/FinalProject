using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  public enum Sex
  {
    Муж,
    Жен
  }
  class PersonalInfo
  {
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }

    public PersonalInfo() { }
  }
}
