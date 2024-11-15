﻿namespace FinalProject.Forms
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.LoginField = new System.Windows.Forms.TextBox();
      this.PasswordField = new System.Windows.Forms.TextBox();
      this.LoginButton = new System.Windows.Forms.Button();
      this.ToRegisterForm = new System.Windows.Forms.Label();
      this.labellogin = new System.Windows.Forms.Label();
      this.labelpass = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // LoginField
      // 
      this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LoginField.Location = new System.Drawing.Point(34, 53);
      this.LoginField.Multiline = true;
      this.LoginField.Name = "LoginField";
      this.LoginField.Size = new System.Drawing.Size(287, 36);
      this.LoginField.TabIndex = 0;
      this.LoginField.Click += new System.EventHandler(this.LoginField_Click);
      this.LoginField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
      this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
      // 
      // PasswordField
      // 
      this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PasswordField.Location = new System.Drawing.Point(34, 117);
      this.PasswordField.Name = "PasswordField";
      this.PasswordField.Size = new System.Drawing.Size(287, 36);
      this.PasswordField.TabIndex = 1;
      this.PasswordField.UseSystemPasswordChar = true;
      this.PasswordField.Click += new System.EventHandler(this.PasswordField_Click);
      this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
      this.PasswordField.Leave += new System.EventHandler(this.PasswordField_Leave);
      // 
      // LoginButton
      // 
      this.LoginButton.Location = new System.Drawing.Point(32, 202);
      this.LoginButton.Name = "LoginButton";
      this.LoginButton.Size = new System.Drawing.Size(289, 47);
      this.LoginButton.TabIndex = 2;
      this.LoginButton.Text = "Войти";
      this.LoginButton.UseVisualStyleBackColor = true;
      this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
      // 
      // ToRegisterForm
      // 
      this.ToRegisterForm.AutoSize = true;
      this.ToRegisterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ToRegisterForm.Location = new System.Drawing.Point(132, 285);
      this.ToRegisterForm.Name = "ToRegisterForm";
      this.ToRegisterForm.Size = new System.Drawing.Size(91, 16);
      this.ToRegisterForm.TabIndex = 3;
      this.ToRegisterForm.Text = "Регистрация";
      this.ToRegisterForm.Click += new System.EventHandler(this.ToRegisterForm_Click);
      // 
      // labellogin
      // 
      this.labellogin.AutoSize = true;
      this.labellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labellogin.Location = new System.Drawing.Point(30, 30);
      this.labellogin.Name = "labellogin";
      this.labellogin.Size = new System.Drawing.Size(64, 20);
      this.labellogin.TabIndex = 4;
      this.labellogin.Text = "Логин";
      // 
      // labelpass
      // 
      this.labelpass.AutoSize = true;
      this.labelpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelpass.Location = new System.Drawing.Point(30, 94);
      this.labelpass.Name = "labelpass";
      this.labelpass.Size = new System.Drawing.Size(78, 20);
      this.labelpass.TabIndex = 5;
      this.labelpass.Text = "Пароль";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(111, 265);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(132, 20);
      this.label1.TabIndex = 6;
      this.label1.Text = "Нет аккаунта?";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(352, 323);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.labelpass);
      this.Controls.Add(this.labellogin);
      this.Controls.Add(this.ToRegisterForm);
      this.Controls.Add(this.LoginButton);
      this.Controls.Add(this.PasswordField);
      this.Controls.Add(this.LoginField);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "MainForm";
      this.Text = "Авторизация";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox LoginField;
    private System.Windows.Forms.TextBox PasswordField;
    private System.Windows.Forms.Button LoginButton;
    private System.Windows.Forms.Label ToRegisterForm;
    private System.Windows.Forms.Label labellogin;
    private System.Windows.Forms.Label labelpass;
    private System.Windows.Forms.Label label1;
  }
}