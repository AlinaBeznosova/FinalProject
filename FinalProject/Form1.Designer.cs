namespace FinalProject
{
  partial class Form1
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
      this.ButtonSaveInfo = new System.Windows.Forms.Button();
      this.ButtonCreatePDF = new System.Windows.Forms.Button();
      this.labelFullName = new System.Windows.Forms.Label();
      this.labelDateOfBirth = new System.Windows.Forms.Label();
      this.labelGender = new System.Windows.Forms.Label();
      this.labelCity = new System.Windows.Forms.Label();
      this.CityField = new System.Windows.Forms.TextBox();
      this.labelPhoneNumber = new System.Windows.Forms.Label();
      this.PhoneNumberField = new System.Windows.Forms.MaskedTextBox();
      this.labelEmail = new System.Windows.Forms.Label();
      this.EmailField = new System.Windows.Forms.TextBox();
      this.labelStatus = new System.Windows.Forms.Label();
      this.GenderField = new System.Windows.Forms.ComboBox();
      this.MaritalStatusField = new System.Windows.Forms.ComboBox();
      this.personalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // FullNameField
      // 
      this.FullNameField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FullNameField.ForeColor = System.Drawing.Color.Gray;
      this.FullNameField.Location = new System.Drawing.Point(46, 48);
      this.FullNameField.Multiline = true;
      this.FullNameField.Name = "FullNameField";
      this.FullNameField.Size = new System.Drawing.Size(287, 41);
      this.FullNameField.TabIndex = 0;
      this.FullNameField.Text = "Введите имя";
      this.FullNameField.TextChanged += new System.EventHandler(this.FullNameField_TextChanged);
      this.FullNameField.Enter += new System.EventHandler(this.FullNameField_Enter);
      this.FullNameField.Leave += new System.EventHandler(this.FullNameField_Leave);
      // 
      // DateOfBirthField
      // 
      this.DateOfBirthField.CustomFormat = "dd.MM.yyyy";
      this.DateOfBirthField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.DateOfBirthField.Location = new System.Drawing.Point(46, 110);
      this.DateOfBirthField.Name = "DateOfBirthField";
      this.DateOfBirthField.Size = new System.Drawing.Size(200, 22);
      this.DateOfBirthField.TabIndex = 1;
      this.DateOfBirthField.ValueChanged += new System.EventHandler(this.DateOfBirth_ValueChanged);
      // 
      // ButtonSaveInfo
      // 
      this.ButtonSaveInfo.Location = new System.Drawing.Point(46, 291);
      this.ButtonSaveInfo.Name = "ButtonSaveInfo";
      this.ButtonSaveInfo.Size = new System.Drawing.Size(156, 44);
      this.ButtonSaveInfo.TabIndex = 3;
      this.ButtonSaveInfo.Text = "Сохранить данные";
      this.ButtonSaveInfo.UseVisualStyleBackColor = true;
      this.ButtonSaveInfo.Click += new System.EventHandler(this.ButtonSaveInfo_Click);
      // 
      // ButtonCreatePDF
      // 
      this.ButtonCreatePDF.Location = new System.Drawing.Point(228, 290);
      this.ButtonCreatePDF.Name = "ButtonCreatePDF";
      this.ButtonCreatePDF.Size = new System.Drawing.Size(151, 45);
      this.ButtonCreatePDF.TabIndex = 4;
      this.ButtonCreatePDF.Text = "Создать PDF";
      this.ButtonCreatePDF.UseVisualStyleBackColor = true;
      this.ButtonCreatePDF.Click += new System.EventHandler(this.ButtonCreatePDF_Click);
      // 
      // labelFullName
      // 
      this.labelFullName.AutoSize = true;
      this.labelFullName.Location = new System.Drawing.Point(50, 28);
      this.labelFullName.Name = "labelFullName";
      this.labelFullName.Size = new System.Drawing.Size(38, 16);
      this.labelFullName.TabIndex = 5;
      this.labelFullName.Text = "ФИО";
      // 
      // labelDateOfBirth
      // 
      this.labelDateOfBirth.AutoSize = true;
      this.labelDateOfBirth.Location = new System.Drawing.Point(50, 91);
      this.labelDateOfBirth.Name = "labelDateOfBirth";
      this.labelDateOfBirth.Size = new System.Drawing.Size(106, 16);
      this.labelDateOfBirth.TabIndex = 6;
      this.labelDateOfBirth.Text = "Дата рождения";
      // 
      // labelGender
      // 
      this.labelGender.AutoSize = true;
      this.labelGender.Location = new System.Drawing.Point(50, 139);
      this.labelGender.Name = "labelGender";
      this.labelGender.Size = new System.Drawing.Size(33, 16);
      this.labelGender.TabIndex = 7;
      this.labelGender.Text = "Пол";
      // 
      // labelCity
      // 
      this.labelCity.AutoSize = true;
      this.labelCity.Location = new System.Drawing.Point(351, 28);
      this.labelCity.Name = "labelCity";
      this.labelCity.Size = new System.Drawing.Size(131, 16);
      this.labelCity.TabIndex = 8;
      this.labelCity.Text = "Место проживания";
      // 
      // CityField
      // 
      this.CityField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CityField.ForeColor = System.Drawing.Color.Gray;
      this.CityField.Location = new System.Drawing.Point(339, 48);
      this.CityField.Multiline = true;
      this.CityField.Name = "CityField";
      this.CityField.Size = new System.Drawing.Size(199, 41);
      this.CityField.TabIndex = 9;
      this.CityField.Text = "Введите город";
      this.CityField.TextChanged += new System.EventHandler(this.CityField_TextChanged);
      this.CityField.Enter += new System.EventHandler(this.CityField_Enter);
      this.CityField.Leave += new System.EventHandler(this.CityField_Leave);
      // 
      // labelPhoneNumber
      // 
      this.labelPhoneNumber.AutoSize = true;
      this.labelPhoneNumber.Location = new System.Drawing.Point(351, 178);
      this.labelPhoneNumber.Name = "labelPhoneNumber";
      this.labelPhoneNumber.Size = new System.Drawing.Size(146, 16);
      this.labelPhoneNumber.TabIndex = 10;
      this.labelPhoneNumber.Text = "Контактный телефон";
      // 
      // PhoneNumberField
      // 
      this.PhoneNumberField.Location = new System.Drawing.Point(339, 197);
      this.PhoneNumberField.Mask = "+7 (999) 999-0000";
      this.PhoneNumberField.Name = "PhoneNumberField";
      this.PhoneNumberField.Size = new System.Drawing.Size(199, 22);
      this.PhoneNumberField.TabIndex = 11;
      this.PhoneNumberField.TextChanged += new System.EventHandler(this.PhoneNumberField_TextChanged);
      // 
      // labelEmail
      // 
      this.labelEmail.AutoSize = true;
      this.labelEmail.Location = new System.Drawing.Point(351, 101);
      this.labelEmail.Name = "labelEmail";
      this.labelEmail.Size = new System.Drawing.Size(136, 16);
      this.labelEmail.TabIndex = 12;
      this.labelEmail.Text = "Электронная почта";
      // 
      // EmailField
      // 
      this.EmailField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.EmailField.ForeColor = System.Drawing.Color.Gray;
      this.EmailField.Location = new System.Drawing.Point(339, 120);
      this.EmailField.Multiline = true;
      this.EmailField.Name = "EmailField";
      this.EmailField.Size = new System.Drawing.Size(199, 41);
      this.EmailField.TabIndex = 13;
      this.EmailField.Text = "Введите почту";
      this.EmailField.TextChanged += new System.EventHandler(this.EmailField_TextChanged);
      this.EmailField.Enter += new System.EventHandler(this.EmailField_Enter);
      this.EmailField.Leave += new System.EventHandler(this.EmailField_Leave);
      // 
      // labelStatus
      // 
      this.labelStatus.AutoSize = true;
      this.labelStatus.Location = new System.Drawing.Point(50, 200);
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
            "М",
            "Ж"});
      this.GenderField.Location = new System.Drawing.Point(46, 158);
      this.GenderField.Name = "GenderField";
      this.GenderField.Size = new System.Drawing.Size(192, 24);
      this.GenderField.TabIndex = 15;
      this.GenderField.Text = "Выберите пол";
      this.GenderField.SelectedIndexChanged += new System.EventHandler(this.GenderField_SelectedIndexChanged);
      // 
      // MaritalStatusField
      // 
      this.MaritalStatusField.ForeColor = System.Drawing.Color.DimGray;
      this.MaritalStatusField.FormattingEnabled = true;
      this.MaritalStatusField.Items.AddRange(new object[] {
            "холост",
            "холоста",
            "женат",
            "замужем"});
      this.MaritalStatusField.Location = new System.Drawing.Point(46, 219);
      this.MaritalStatusField.Name = "MaritalStatusField";
      this.MaritalStatusField.Size = new System.Drawing.Size(187, 24);
      this.MaritalStatusField.TabIndex = 16;
      this.MaritalStatusField.Text = "Выберите статус";
      this.MaritalStatusField.SelectedIndexChanged += new System.EventHandler(this.MaritalStatusField_SelectedIndexChanged);
      // 
      // personalInfoBindingSource
      // 
      this.personalInfoBindingSource.DataSource = typeof(FinalProject.Form1);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.MaritalStatusField);
      this.Controls.Add(this.GenderField);
      this.Controls.Add(this.labelStatus);
      this.Controls.Add(this.EmailField);
      this.Controls.Add(this.labelEmail);
      this.Controls.Add(this.PhoneNumberField);
      this.Controls.Add(this.labelPhoneNumber);
      this.Controls.Add(this.CityField);
      this.Controls.Add(this.labelCity);
      this.Controls.Add(this.labelGender);
      this.Controls.Add(this.labelDateOfBirth);
      this.Controls.Add(this.labelFullName);
      this.Controls.Add(this.ButtonCreatePDF);
      this.Controls.Add(this.ButtonSaveInfo);
      this.Controls.Add(this.DateOfBirthField);
      this.Controls.Add(this.FullNameField);
      this.Name = "Form1";
      this.Text = "Личная Инфомрация";
      ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox FullNameField;
    private System.Windows.Forms.DateTimePicker DateOfBirthField;
    private System.Windows.Forms.BindingSource personalInfoBindingSource;
    private System.Windows.Forms.Button ButtonSaveInfo;
    private System.Windows.Forms.Button ButtonCreatePDF;
    private System.Windows.Forms.Label labelFullName;
    private System.Windows.Forms.Label labelDateOfBirth;
    private System.Windows.Forms.Label labelGender;
    private System.Windows.Forms.Label labelCity;
    private System.Windows.Forms.TextBox CityField;
    private System.Windows.Forms.Label labelPhoneNumber;
    private System.Windows.Forms.MaskedTextBox PhoneNumberField;
    private System.Windows.Forms.Label labelEmail;
    private System.Windows.Forms.TextBox EmailField;
    private System.Windows.Forms.Label labelStatus;
    private System.Windows.Forms.ComboBox GenderField;
    private System.Windows.Forms.ComboBox MaritalStatusField;
  }
}

