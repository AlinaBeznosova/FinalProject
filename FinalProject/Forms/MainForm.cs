using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Core;
using FinalProject.DataBase;

namespace FinalProject.Forms
{
  
  public partial class MainForm : Form
  {
    readonly User user = new User();
    readonly DataBaseManager baseManager = new DataBaseManager();
    public MainForm()
    {
      InitializeComponent();
    }

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
      if (baseManager.FindUser(user))
      {
        this.Hide();
        InfoForm infoForm = new InfoForm();
        infoForm.Show();
      }
      else MessageBox.Show("Пользователь не найден");
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }
  }
}
