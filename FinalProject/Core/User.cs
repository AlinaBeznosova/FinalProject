using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core
{
  /// <summary>
  /// Пользователь.
  /// </summary>
  public class User
  {
    #region Поля и свойства
    /// <summary>
    /// Id пользователя.
    /// </summary>
    public static int UserId { get; set; }

    /// <summary>
    /// Логин.
    /// </summary>
    public string Login {  get; set; }

    /// <summary>
    /// Пароль.
    /// </summary>
    public string Password { get; set; }
    #endregion

    #region Конструкторы
    /// <summary>
    /// Конструктор.
    /// </summary>
    public User() { }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="login">Логин.</param>
    /// <param name="password">Пароль.</param>
    public User(string login, string password)
    {
      Login = login;
      Password = password;
    }
    #endregion
  }
}
