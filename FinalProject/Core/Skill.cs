using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  public class Skill
  {
    public string Hardskill { get; set; }
    public string Softskill { get; set; }

    public Skill() { }
    public Skill(string hardSkill, string softSkill)
    {
      Hardskill = hardSkill;
      Softskill = softSkill;
    }
  }
}
