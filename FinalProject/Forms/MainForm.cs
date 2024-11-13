using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Core;
using FinalProject.DataBase;


namespace FinalProject.Forms
{
  
  public partial class MainForm : Form
  {
    readonly private Logger _logger = new Logger();
    private InfoForm infoForm;
    readonly User user = new User();
    readonly DataBase.DataBaseManager baseManager = new DataBase.DataBaseManager();

    private void LoginField_Click(object sender, EventArgs e)
    {
      if (LoginField.Text == "Логин")
        LoginField.Text = "";
    }
    private void LoginField_TextChanged(object sender, EventArgs e)
    {
      user.Login = LoginField.Text;
    }

    private void LoginField_Leave(object sender, EventArgs e)
    {
      if ((LoginField.Text == "") || (LoginField.Text == " ") || (LoginField.Text.Contains("\n")))
        LoginField.Text = "Логин";
    }

    private void PasswordField_Click(object sender, EventArgs e)
    {
      if (PasswordField.Text == "Пароль")
        PasswordField.Text = "";
    }

    private void PasswordField_TextChanged(object sender, EventArgs e)
    {
      user.Password = PasswordField.Text;
    }

    private void PasswordField_Leave(object sender, EventArgs e)
    {
      if ((PasswordField.Text == "") || (PasswordField.Text == " ") || (PasswordField.Text.Contains("\n")))
        PasswordField.Text = "Пароль";
    }

    private void ToRegisterForm_Click(object sender, EventArgs e)
    {
      this.Hide();
      RegisterForm register = new RegisterForm();
      register.Show();
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (baseManager.IsUserExist(user))
        {
          _logger.LogInfo("Пользователь найден.");
          if (baseManager.CheckForDrafts(User.UserId))
          {
            _logger.LogInfo("Найдены черновики для пользователя.");
            DialogResult dialogResult = MessageBox.Show("Есть черновики. Хотите продолжить редактирование?", "Черновики", MessageBoxButtons.YesNo);
            _logger.LogInfo("Показан диалог о черновиках.");
            if (dialogResult == DialogResult.Yes)
            {
              _logger.LogInfo("Пользователь выбрал продолжить редактирование черновиков.");
              this.Hide();
              DraftForm draftForm = new DraftForm();
              draftForm.Show();
            }
            else
            {
              _logger.LogInfo("Пользователь отказался продолжить редактирование черновиков.");
              this.Hide();
              infoForm = new InfoForm();
              infoForm.Show();
            }
          }
          else
          {
            _logger.LogInfo("Черновики для пользователя не найдены.");
            this.Hide();
            infoForm = new InfoForm();
            infoForm.Show();
          }
        }
        else
        {
          _logger.LogInfo("Пользователь не найден.");
          MessageBox.Show("Пользователь не найден");
        }
      }
      catch (Exception ex)
      {
        _logger.LogError("Ошибка при обработке кнопки входа.", ex);
        MessageBox.Show("Произошла ошибка при обработке кнопки входа.");
      }
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    public MainForm()
    {
      InitializeComponent();
    }

  }
}
