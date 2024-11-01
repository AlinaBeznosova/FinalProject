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
      this.nameField = new System.Windows.Forms.TextBox();
      this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
      this.genderField = new System.Windows.Forms.ComboBox();
      this.buttonSaveInfo = new System.Windows.Forms.Button();
      this.buttonCreatePDF = new System.Windows.Forms.Button();
      this.personalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // nameField
      // 
      this.nameField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.nameField.ForeColor = System.Drawing.Color.Gray;
      this.nameField.Location = new System.Drawing.Point(46, 48);
      this.nameField.Multiline = true;
      this.nameField.Name = "nameField";
      this.nameField.Size = new System.Drawing.Size(199, 41);
      this.nameField.TabIndex = 0;
      this.nameField.Text = "Введите имя";
      this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
      this.nameField.Enter += new System.EventHandler(this.nameField_Enter);
      this.nameField.Leave += new System.EventHandler(this.nameField_Leave);
      // 
      // dateOfBirth
      // 
      this.dateOfBirth.CustomFormat = "dd.MM.yyyy";
      this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateOfBirth.Location = new System.Drawing.Point(46, 110);
      this.dateOfBirth.Name = "dateOfBirth";
      this.dateOfBirth.Size = new System.Drawing.Size(200, 22);
      this.dateOfBirth.TabIndex = 1;
      this.dateOfBirth.ValueChanged += new System.EventHandler(this.dateOfBirth_ValueChanged);
      // 
      // genderField
      // 
      this.genderField.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personalInfoBindingSource, "Gender", true));
      this.genderField.ForeColor = System.Drawing.Color.DimGray;
      this.genderField.FormattingEnabled = true;
      this.genderField.Items.AddRange(new object[] {
            "male",
            "female"});
      this.genderField.Location = new System.Drawing.Point(46, 158);
      this.genderField.Name = "genderField";
      this.genderField.Size = new System.Drawing.Size(165, 24);
      this.genderField.TabIndex = 2;
      this.genderField.Text = "Выберите пол";
      this.genderField.SelectedIndexChanged += new System.EventHandler(this.genderField_SelectedIndexChanged);
      // 
      // buttonSaveInfo
      // 
      this.buttonSaveInfo.Location = new System.Drawing.Point(55, 219);
      this.buttonSaveInfo.Name = "buttonSaveInfo";
      this.buttonSaveInfo.Size = new System.Drawing.Size(156, 44);
      this.buttonSaveInfo.TabIndex = 3;
      this.buttonSaveInfo.Text = "Сохранить данные";
      this.buttonSaveInfo.UseVisualStyleBackColor = true;
      this.buttonSaveInfo.Click += new System.EventHandler(this.buttonSaveInfo_Click);
      // 
      // buttonCreatePDF
      // 
      this.buttonCreatePDF.Location = new System.Drawing.Point(59, 286);
      this.buttonCreatePDF.Name = "buttonCreatePDF";
      this.buttonCreatePDF.Size = new System.Drawing.Size(151, 45);
      this.buttonCreatePDF.TabIndex = 4;
      this.buttonCreatePDF.Text = "Создать PDF";
      this.buttonCreatePDF.UseVisualStyleBackColor = true;
      this.buttonCreatePDF.Click += new System.EventHandler(this.buttonCreatePDF_Click);
      // 
      // personalInfoBindingSource
      // 
      this.personalInfoBindingSource.DataSource = typeof(FinalProject.PersonalInfo);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.buttonCreatePDF);
      this.Controls.Add(this.buttonSaveInfo);
      this.Controls.Add(this.genderField);
      this.Controls.Add(this.dateOfBirth);
      this.Controls.Add(this.nameField);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox nameField;
    private System.Windows.Forms.DateTimePicker dateOfBirth;
    private System.Windows.Forms.ComboBox genderField;
    private System.Windows.Forms.BindingSource personalInfoBindingSource;
    private System.Windows.Forms.Button buttonSaveInfo;
    private System.Windows.Forms.Button buttonCreatePDF;
  }
}

