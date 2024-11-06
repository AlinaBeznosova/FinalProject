﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core
{
  public class User
  {
    public static int UserId { get; set; }
    public string Login {  get; set; }
    public string Password { get; set; }

    public User() { }

    public User(string login, string password)
    {
      Login = login;
      Password = password;
    }
  }
}
