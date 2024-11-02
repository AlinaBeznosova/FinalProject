namespace FinalProject
{
  partial class InfoForm
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.FullNameField = new System.Windows.Forms.TextBox();
      this.DateOfBirthField = new System.Windows.Forms.DateTimePicker();
      this.ButtonNextFormWithSave = new System.Windows.Forms.Button();
      this.labelFullName = new System.Windows.Forms.Label();
      this.labelDateOfBirth = new System.Windows.Forms.Label();
      this.labelGender = new System.Windows.Forms.Label();
      this.labelCity = new System.Windows.Forms.Label();
      this.CityField = new System.Windows.Forms.TextBox();
      this.labelPhoneNumber = new System.Windows.Forms.Label();
      this.labelEmail = new System.Windows.Forms.Label();
      this.EmailField = new System.Windows.Forms.TextBox();
      this.labelStatus = new System.Windows.Forms.Label();
      this.GenderField = new System.Windows.Forms.ComboBox();
      this.MaritalStatusField = new System.Windows.Forms.ComboBox();
      this.PhoneNumberField = new System.Windows.Forms.TextBox();
      this.labelInfo = new System.Windows.Forms.Label();
      this.labelContacts = new System.Windows.Forms.Label();
      this.personalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // FullNameField
      // 
      this.FullNameField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FullNameField.ForeColor = System.Drawing.Color.Gray;
      this.FullNameField.Location = new System.Drawing.Point(46, 82);
      this.FullNameField.Multiline = true;
      this.FullNameField.Name = "FullNameField";
      this.FullNameField.Size = new System.Drawing.Size(287, 41);
      this.FullNameField.TabIndex = 0;
      this.FullNameField.Text = "Введите имя";
      this.FullNameField.Click += new System.EventHandler(this.FullNameField_Click);
      this.FullNameField.TextChanged += new System.EventHandler(this.FullNameField_TextChanged);
      this.FullNameField.Leave += new System.EventHandler(this.FullNameField_Leave);
      // 
      // DateOfBirthField
      // 
      this.DateOfBirthField.CustomFormat = "dd.MM.yyyy";
      this.DateOfBirthField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.DateOfBirthField.Location = new System.Drawing.Point(46, 145);
      this.DateOfBirthField.Name = "DateOfBirthField";
      this.DateOfBirthField.Size = new System.Drawing.Size(287, 22);
      this.DateOfBirthField.TabIndex = 1;
      this.DateOfBirthField.ValueChanged += new System.EventHandler(this.DateOfBirth_ValueChanged);
      this.DateOfBirthField.Leave += new System.EventHandler(this.DateOfBirthField_Leave);
      // 
      // ButtonNextFormWithSave
      // 
      this.ButtonNextFormWithSave.Location = new System.Drawing.Point(265, 286);
      this.ButtonNextFormWithSave.Name = "ButtonNextFormWithSave";
      this.ButtonNextFormWithSave.Size = new System.Drawing.Size(156, 44);
      this.ButtonNextFormWithSave.TabIndex = 3;
      this.ButtonNextFormWithSave.Text = "Далее";
      this.ButtonNextFormWithSave.UseVisualStyleBackColor = true;
      this.ButtonNextFormWithSave.Click += new System.EventHandler(this.ButtonSaveInfo_Click);
      // 
      // labelFullName
      // 
      this.labelFullName.AutoSize = true;
      this.labelFullName.Location = new System.Drawing.Point(50, 63);
      this.labelFullName.Name = "labelFullName";
      this.labelFullName.Size = new System.Drawing.Size(38, 16);
      this.labelFullName.TabIndex = 5;
      this.labelFullName.Text = "ФИО";
      // 
      // labelDateOfBirth
      // 
      this.labelDateOfBirth.AutoSize = true;
      this.labelDateOfBirth.Location = new System.Drawing.Point(50, 126);
      this.labelDateOfBirth.Name = "labelDateOfBirth";
      this.labelDateOfBirth.Size = new System.Drawing.Size(106, 16);
      this.labelDateOfBirth.TabIndex = 6;
      this.labelDateOfBirth.Text = "Дата рождения";
      // 
      // labelGender
      // 
      this.labelGender.AutoSize = true;
      this.labelGender.Location = new System.Drawing.Point(50, 170);
      this.labelGender.Name = "labelGender";
      this.labelGender.Size = new System.Drawing.Size(33, 16);
      this.labelGender.TabIndex = 7;
      this.labelGender.Text = "Пол";
      // 
      // labelCity
      // 
      this.labelCity.AutoSize = true;
      this.labelCity.Location = new System.Drawing.Point(341, 71);
      this.labelCity.Name = "labelCity";
      this.labelCity.Size = new System.Drawing.Size(131, 16);
      this.labelCity.TabIndex = 8;
      this.labelCity.Text = "Место проживания";
      // 
      // CityField
      // 
      this.CityField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CityField.ForeColor = System.Drawing.Color.Gray;
      this.CityField.Location = new System.Drawing.Point(339, 90);
      this.CityField.Multiline = true;
      this.CityField.Name = "CityField";
      this.CityField.Size = new System.Drawing.Size(250, 41);
      this.CityField.TabIndex = 9;
      this.CityField.Text = "Введите город";
      this.CityField.Click += new System.EventHandler(this.CityField_Click);
      this.CityField.TextChanged += new System.EventHandler(this.CityField_TextChanged);
      this.CityField.Leave += new System.EventHandler(this.CityField_Leave);
      // 
      // labelPhoneNumber
      // 
      this.labelPhoneNumber.AutoSize = true;
      this.labelPhoneNumber.Location = new System.Drawing.Point(341, 197);
      this.labelPhoneNumber.Name = "labelPhoneNumber";
      this.labelPhoneNumber.Size = new System.Drawing.Size(146, 16);
      this.labelPhoneNumber.TabIndex = 10;
      this.labelPhoneNumber.Text = "Контактный телефон";
      // 
      // labelEmail
      // 
      this.labelEmail.AutoSize = true;
      this.labelEmail.Location = new System.Drawing.Point(341, 134);
      this.labelEmail.Name = "labelEmail";
      this.labelEmail.Size = new System.Drawing.Size(136, 16);
      this.labelEmail.TabIndex = 12;
      this.labelEmail.Text = "Электронная почта";
      // 
      // EmailField
      // 
      this.EmailField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.EmailField.ForeColor = System.Drawing.Color.Gray;
      this.EmailField.Location = new System.Drawing.Point(339, 153);
      this.EmailField.Multiline = true;
      this.EmailField.Name = "EmailField";
      this.EmailField.Size = new System.Drawing.Size(250, 41);
      this.EmailField.TabIndex = 13;
      this.EmailField.Text = "Введите почту";
      this.EmailField.Click += new System.EventHandler(this.EmailField_Click);
      this.EmailField.TextChanged += new System.EventHandler(this.EmailField_TextChanged);
      this.EmailField.Leave += new System.EventHandler(this.EmailField_Leave);
      // 
      // labelStatus
      // 
      this.labelStatus.AutoSize = true;
      this.labelStatus.Location = new System.Drawing.Point(50, 216);
      this.labelStatus.Name = "labelStatus";
      this.labelStatus.Size = new System.Drawing.Size(149, 16);
      this.labelStatus.TabIndex = 14;
      this.labelStatus.Text = "Семейное положение";
      // 
      // GenderField
      // 
      this.GenderField.ForeColor = System.Drawing.Color.DimGray;
      this.GenderField.FormattingEnabled = true;
      this.GenderField.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
      this.GenderField.Location = new System.Drawing.Point(46, 189);
      this.GenderField.Name = "GenderField";
      this.GenderField.Size = new System.Drawing.Size(287, 24);
      this.GenderField.TabIndex = 15;
      this.GenderField.Text = "Выберите пол";
      this.GenderField.SelectedIndexChanged += new System.EventHandler(this.GenderField_SelectedIndexChanged);
      // 
      // MaritalStatusField
      // 
      this.MaritalStatusField.ForeColor = System.Drawing.Color.DimGray;
      this.MaritalStatusField.FormattingEnabled = true;
      this.MaritalStatusField.Location = new System.Drawing.Point(46, 235);
      this.MaritalStatusField.Name = "MaritalStatusField";
      this.MaritalStatusField.Size = new System.Drawing.Size(287, 24);
      this.MaritalStatusField.TabIndex = 16;
      this.MaritalStatusField.Text = "Выберите статус";
      this.MaritalStatusField.SelectedIndexChanged += new System.EventHandler(this.MaritalStatusField_SelectedIndexChanged);
      // 
      // PhoneNumberField
      // 
      this.PhoneNumberField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PhoneNumberField.ForeColor = System.Drawing.Color.Gray;
      this.PhoneNumberField.Location = new System.Drawing.Point(339, 218);
      this.PhoneNumberField.Multiline = true;
      this.PhoneNumberField.Name = "PhoneNumberField";
      this.PhoneNumberField.Size = new System.Drawing.Size(250, 41);
      this.PhoneNumberField.TabIndex = 17;
      this.PhoneNumberField.Text = "Введите номер телефона";
      this.PhoneNumberField.Click += new System.EventHandler(this.PhoneNumberField_Click);
      this.PhoneNumberField.TextChanged += new System.EventHandler(this.PhoneNumberField_TextChanged);
      this.PhoneNumberField.Leave += new System.EventHandler(this.PhoneNumberField_Leave);
      // 
      // labelInfo
      // 
      this.labelInfo.AutoSize = true;
      this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelInfo.Location = new System.Drawing.Point(111, 34);
      this.labelInfo.Name = "labelInfo";
      this.labelInfo.Size = new System.Drawing.Size(159, 25);
      this.labelInfo.TabIndex = 18;
      this.labelInfo.Text = "Личные данные";
      // 
      // labelContacts
      // 
      this.labelContacts.AutoSize = true;
      this.labelContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelContacts.Location = new System.Drawing.Point(365, 34);
      this.labelContacts.Name = "labelContacts";
      this.labelContacts.Size = new System.Drawing.Size(200, 25);
      this.labelContacts.TabIndex = 19;
      this.labelContacts.Text = "Контактные данные";
      // 
      // personalInfoBindingSource
      // 
      this.personalInfoBindingSource.DataSource = typeof(FinalProject.InfoForm);
      // 
      // InfoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.labelContacts);
      this.Controls.Add(this.labelInfo);
      this.Controls.Add(this.PhoneNumberField);
      this.Controls.Add(this.MaritalStatusField);
      this.Controls.Add(this.GenderField);
      this.Controls.Add(this.labelStatus);
      this.Controls.Add(this.EmailField);
      this.Controls.Add(this.labelEmail);
      this.Controls.Add(this.labelPhoneNumber);
      this.Controls.Add(this.CityField);
      this.Controls.Add(this.labelCity);
      this.Controls.Add(this.labelGender);
      this.Controls.Add(this.labelDateOfBirth);
      this.Controls.Add(this.labelFullName);
      this.Controls.Add(this.ButtonNextFormWithSave);
      this.Controls.Add(this.DateOfBirthField);
      this.Controls.Add(this.FullNameField);
      this.Name = "InfoForm";
      this.Text = "Личная Инфомрация";
      ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox FullNameField;
    private System.Windows.Forms.DateTimePicker DateOfBirthField;
    private System.Windows.Forms.BindingSource personalInfoBindingSource;
    private System.Windows.Forms.Button ButtonNextFormWithSave;
    private System.Windows.Forms.Label labelFullName;
    private System.Windows.Forms.Label labelDateOfBirth;
    private System.Windows.Forms.Label labelGender;
    private System.Windows.Forms.Label labelCity;
    private System.Windows.Forms.TextBox CityField;
    private System.Windows.Forms.Label labelPhoneNumber;
    private System.Windows.Forms.Label labelEmail;
    private System.Windows.Forms.TextBox EmailField;
    private System.Windows.Forms.Label labelStatus;
    private System.Windows.Forms.ComboBox GenderField;
    private System.Windows.Forms.ComboBox MaritalStatusField;
    private System.Windows.Forms.TextBox PhoneNumberField;
    private System.Windows.Forms.Label labelInfo;
    private System.Windows.Forms.Label labelContacts;
  }
}

