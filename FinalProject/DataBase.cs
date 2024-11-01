using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  class DataBase
  {
   static string connectionString = "Data Source=DataBase.db";
    SQLiteConnection connection = new SQLiteConnection(connectionString);


  }
}
