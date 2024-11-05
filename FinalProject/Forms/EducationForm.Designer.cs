namespace FinalProject.Forms
{
  partial class EducationForm
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
      this.InstitutionField = new System.Windows.Forms.TextBox();
      this.SpecialtyField = new System.Windows.Forms.TextBox();
      this.YearOfGraduationField = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.AddMoreEducation = new System.Windows.Forms.Button();
      this.NoEducationButton = new System.Windows.Forms.Button();
      this.SaveAndNextButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // InstitutionField
      // 
      this.InstitutionField.Location = new System.Drawing.Point(57, 48);
      this.InstitutionField.Multiline = true;
      this.InstitutionField.Name = "InstitutionField";
      this.InstitutionField.Size = new System.Drawing.Size(482, 98);
      this.InstitutionField.TabIndex = 0;
      this.InstitutionField.Text = "Учебное заведение";
      this.InstitutionField.TextChanged += new System.EventHandler(this.InstitutionField_TextChanged);
      // 
      // SpecialtyField
      // 
      this.SpecialtyField.Location = new System.Drawing.Point(57, 152);
      this.SpecialtyField.Multiline = true;
      this.SpecialtyField.Name = "SpecialtyField";
      this.SpecialtyField.Size = new System.Drawing.Size(482, 91);
      this.SpecialtyField.TabIndex = 1;
      this.SpecialtyField.Text = "Специальность";
      this.SpecialtyField.TextChanged += new System.EventHandler(this.SpecialtyField_TextChanged);
      // 
      // YearOfGraduationField
      // 
      this.YearOfGraduationField.CustomFormat = "yyyy";
      this.YearOfGraduationField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.YearOfGraduationField.Location = new System.Drawing.Point(57, 301);
      this.YearOfGraduationField.Name = "YearOfGraduationField";
      this.YearOfGraduationField.Size = new System.Drawing.Size(200, 22);
      this.YearOfGraduationField.TabIndex = 2;
      this.YearOfGraduationField.ValueChanged += new System.EventHandler(this.YearOfGraduationField_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(54, 271);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 16);
      this.label1.TabIndex = 3;
      this.label1.Text = "Год окончания";
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.Location = new System.Drawing.Point(12, 386);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(184, 52);
      this.PreviousFormButton.TabIndex = 12;
      this.PreviousFormButton.Text = "Назад";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // AddMoreEducation
      // 
      this.AddMoreEducation.Location = new System.Drawing.Point(285, 271);
      this.AddMoreEducation.Name = "AddMoreEducation";
      this.AddMoreEducation.Size = new System.Drawing.Size(254, 72);
      this.AddMoreEducation.TabIndex = 13;
      this.AddMoreEducation.Text = "Добавить образование";
      this.AddMoreEducation.UseVisualStyleBackColor = true;
      this.AddMoreEducation.Click += new System.EventHandler(this.AddMoreEducation_Click);
      // 
      // NoEducationButton
      // 
      this.NoEducationButton.Location = new System.Drawing.Point(209, 387);
      this.NoEducationButton.Name = "NoEducationButton";
      this.NoEducationButton.Size = new System.Drawing.Size(196, 51);
      this.NoEducationButton.TabIndex = 14;
      this.NoEducationButton.Text = "Пропустить";
      this.NoEducationButton.UseVisualStyleBackColor = true;
      this.NoEducationButton.Click += new System.EventHandler(this.NoEducationButton_Click);
      // 
      // SaveAndNextButton
      // 
      this.SaveAndNextButton.Location = new System.Drawing.Point(411, 386);
      this.SaveAndNextButton.Name = "SaveAndNextButton";
      this.SaveAndNextButton.Size = new System.Drawing.Size(184, 52);
      this.SaveAndNextButton.TabIndex = 15;
      this.SaveAndNextButton.Text = "Далее";
      this.SaveAndNextButton.UseVisualStyleBackColor = true;
      this.SaveAndNextButton.Click += new System.EventHandler(this.SaveAndNextButton_Click);
      // 
      // EducationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(629, 450);
      this.Controls.Add(this.SaveAndNextButton);
      this.Controls.Add(this.NoEducationButton);
      this.Controls.Add(this.AddMoreEducation);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.YearOfGraduationField);
      this.Controls.Add(this.SpecialtyField);
      this.Controls.Add(this.InstitutionField);
      this.Name = "EducationForm";
      this.Text = "ОБразование";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox InstitutionField;
    private System.Windows.Forms.TextBox SpecialtyField;
    private System.Windows.Forms.DateTimePicker YearOfGraduationField;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button PreviousFormButton;
    private System.Windows.Forms.Button AddMoreEducation;
    private System.Windows.Forms.Button NoEducationButton;
    private System.Windows.Forms.Button SaveAndNextButton;
  }
}