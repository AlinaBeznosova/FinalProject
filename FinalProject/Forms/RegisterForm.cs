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
  public partial class RegisterForm : Form
  {
    readonly User user = new User();
    readonly DataBaseManager baseManager = new DataBaseManager();
    public RegisterForm()
    {
      InitializeComponent();
    }

    private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void LoginField_TextChanged(object sender, EventArgs e)
    {
      user.Login = LoginField.Text;
    }

    private void PasswordField_TextChanged(object sender, EventArgs e)
    {
      user.Password = PasswordField.Text;
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
      if (baseManager.IsUserExist(user))
        MessageBox.Show("Такой пользователь уже существует");

      else
      {
        baseManager.RegisterUser(user);
        this.Hide();
        MainForm mainForm = new MainForm();
        mainForm.Show();
        
      }
    }
  }
}
