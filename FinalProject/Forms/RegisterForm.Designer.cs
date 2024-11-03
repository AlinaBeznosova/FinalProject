namespace FinalProject.Forms
{
  partial class RegisterForm
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
      this.labelpass = new System.Windows.Forms.Label();
      this.labellogin = new System.Windows.Forms.Label();
      this.RegisterButton = new System.Windows.Forms.Button();
      this.PasswordField = new System.Windows.Forms.TextBox();
      this.LoginField = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // labelpass
      // 
      this.labelpass.AutoSize = true;
      this.labelpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelpass.Location = new System.Drawing.Point(62, 104);
      this.labelpass.Name = "labelpass";
      this.labelpass.Size = new System.Drawing.Size(78, 20);
      this.labelpass.TabIndex = 11;
      this.labelpass.Text = "Пароль";
      // 
      // labellogin
      // 
      this.labellogin.AutoSize = true;
      this.labellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labellogin.Location = new System.Drawing.Point(62, 40);
      this.labellogin.Name = "labellogin";
      this.labellogin.Size = new System.Drawing.Size(64, 20);
      this.labellogin.TabIndex = 10;
      this.labellogin.Text = "Логин";
      // 
      // RegisterButton
      // 
      this.RegisterButton.Location = new System.Drawing.Point(64, 212);
      this.RegisterButton.Name = "RegisterButton";
      this.RegisterButton.Size = new System.Drawing.Size(289, 47);
      this.RegisterButton.TabIndex = 8;
      this.RegisterButton.Text = "Зарегистрироваться";
      this.RegisterButton.UseVisualStyleBackColor = true;
      this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
      // 
      // PasswordField
      // 
      this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PasswordField.Location = new System.Drawing.Point(66, 127);
      this.PasswordField.Name = "PasswordField";
      this.PasswordField.Size = new System.Drawing.Size(287, 36);
      this.PasswordField.TabIndex = 7;
      this.PasswordField.UseSystemPasswordChar = true;
      this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
      // 
      // LoginField
      // 
      this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LoginField.Location = new System.Drawing.Point(66, 63);
      this.LoginField.Multiline = true;
      this.LoginField.Name = "LoginField";
      this.LoginField.Size = new System.Drawing.Size(287, 36);
      this.LoginField.TabIndex = 6;
      this.LoginField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
      // 
      // RegisterForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(415, 331);
      this.Controls.Add(this.labelpass);
      this.Controls.Add(this.labellogin);
      this.Controls.Add(this.RegisterButton);
      this.Controls.Add(this.PasswordField);
      this.Controls.Add(this.LoginField);
      this.Name = "RegisterForm";
      this.Text = "Регистрация";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelpass;
    private System.Windows.Forms.Label labellogin;
    private System.Windows.Forms.Button RegisterButton;
    private System.Windows.Forms.TextBox PasswordField;
    private System.Windows.Forms.TextBox LoginField;
  }
}