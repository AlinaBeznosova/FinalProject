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
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.AddMoreEducation = new System.Windows.Forms.Button();
      this.NextFormButton = new System.Windows.Forms.Button();
      this.AddEducationButton = new System.Windows.Forms.Button();
      this.YearOfGraduationField = new System.Windows.Forms.TextBox();
      this.EducationListButton = new System.Windows.Forms.Button();
      this.UpdateEducationButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // InstitutionField
      // 
      this.InstitutionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.InstitutionField.Location = new System.Drawing.Point(12, 36);
      this.InstitutionField.Multiline = true;
      this.InstitutionField.Name = "InstitutionField";
      this.InstitutionField.Size = new System.Drawing.Size(608, 98);
      this.InstitutionField.TabIndex = 0;
      this.InstitutionField.Text = "Учебное заведение";
      this.InstitutionField.Click += new System.EventHandler(this.InstitutionField_Click);
      this.InstitutionField.TextChanged += new System.EventHandler(this.InstitutionField_TextChanged);
      this.InstitutionField.Leave += new System.EventHandler(this.InstitutionField_Leave);
      // 
      // SpecialtyField
      // 
      this.SpecialtyField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SpecialtyField.Location = new System.Drawing.Point(12, 140);
      this.SpecialtyField.Multiline = true;
      this.SpecialtyField.Name = "SpecialtyField";
      this.SpecialtyField.Size = new System.Drawing.Size(608, 91);
      this.SpecialtyField.TabIndex = 1;
      this.SpecialtyField.Text = "Специальность";
      this.SpecialtyField.Click += new System.EventHandler(this.SpecialtyField_Click);
      this.SpecialtyField.TextChanged += new System.EventHandler(this.SpecialtyField_TextChanged);
      this.SpecialtyField.Leave += new System.EventHandler(this.SpecialtyField_Leave);
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.Location = new System.Drawing.Point(12, 318);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(147, 70);
      this.PreviousFormButton.TabIndex = 12;
      this.PreviousFormButton.Text = "Назад";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // AddMoreEducation
      // 
      this.AddMoreEducation.Location = new System.Drawing.Point(263, 248);
      this.AddMoreEducation.Name = "AddMoreEducation";
      this.AddMoreEducation.Size = new System.Drawing.Size(187, 55);
      this.AddMoreEducation.TabIndex = 13;
      this.AddMoreEducation.Text = "Очистить поля для добавления образования";
      this.AddMoreEducation.UseVisualStyleBackColor = true;
      this.AddMoreEducation.Click += new System.EventHandler(this.AddMoreEducation_Click);
      // 
      // NextFormButton
      // 
      this.NextFormButton.Location = new System.Drawing.Point(471, 319);
      this.NextFormButton.Name = "NextFormButton";
      this.NextFormButton.Size = new System.Drawing.Size(147, 69);
      this.NextFormButton.TabIndex = 14;
      this.NextFormButton.Text = "Далее";
      this.NextFormButton.UseVisualStyleBackColor = true;
      this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click_1);
      // 
      // AddEducationButton
      // 
      this.AddEducationButton.Location = new System.Drawing.Point(318, 319);
      this.AddEducationButton.Name = "AddEducationButton";
      this.AddEducationButton.Size = new System.Drawing.Size(147, 69);
      this.AddEducationButton.TabIndex = 15;
      this.AddEducationButton.Text = "Сохранить как новое образование";
      this.AddEducationButton.UseVisualStyleBackColor = true;
      this.AddEducationButton.Click += new System.EventHandler(this.AddEducationButton_Click);
      // 
      // YearOfGraduationField
      // 
      this.YearOfGraduationField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.YearOfGraduationField.Location = new System.Drawing.Point(12, 248);
      this.YearOfGraduationField.Multiline = true;
      this.YearOfGraduationField.Name = "YearOfGraduationField";
      this.YearOfGraduationField.Size = new System.Drawing.Size(245, 55);
      this.YearOfGraduationField.TabIndex = 16;
      this.YearOfGraduationField.Text = "Год окончания";
      this.YearOfGraduationField.Click += new System.EventHandler(this.YearOfGraduationField_Click);
      this.YearOfGraduationField.TextChanged += new System.EventHandler(this.YearOfGraduationField_TextChanged);
      this.YearOfGraduationField.Leave += new System.EventHandler(this.YearOfGraduationField_Leave);
      // 
      // EducationListButton
      // 
      this.EducationListButton.Location = new System.Drawing.Point(456, 248);
      this.EducationListButton.Name = "EducationListButton";
      this.EducationListButton.Size = new System.Drawing.Size(164, 55);
      this.EducationListButton.TabIndex = 17;
      this.EducationListButton.Text = "Показать список образования";
      this.EducationListButton.UseVisualStyleBackColor = true;
      this.EducationListButton.Click += new System.EventHandler(this.EducationListButton_Click);
      // 
      // UpdateEducationButton
      // 
      this.UpdateEducationButton.Location = new System.Drawing.Point(165, 318);
      this.UpdateEducationButton.Name = "UpdateEducationButton";
      this.UpdateEducationButton.Size = new System.Drawing.Size(147, 70);
      this.UpdateEducationButton.TabIndex = 18;
      this.UpdateEducationButton.Text = "Обновить существующее образование";
      this.UpdateEducationButton.UseVisualStyleBackColor = true;
      this.UpdateEducationButton.Click += new System.EventHandler(this.UpdateEducationButton_Click);
      // 
      // EducationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 403);
      this.Controls.Add(this.UpdateEducationButton);
      this.Controls.Add(this.EducationListButton);
      this.Controls.Add(this.YearOfGraduationField);
      this.Controls.Add(this.AddEducationButton);
      this.Controls.Add(this.NextFormButton);
      this.Controls.Add(this.AddMoreEducation);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.SpecialtyField);
      this.Controls.Add(this.InstitutionField);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "EducationForm";
      this.Text = "ОБразование";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EducationForm_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox InstitutionField;
    private System.Windows.Forms.TextBox SpecialtyField;
    private System.Windows.Forms.Button PreviousFormButton;
    private System.Windows.Forms.Button AddMoreEducation;
    private System.Windows.Forms.Button NextFormButton;
    private System.Windows.Forms.Button AddEducationButton;
    private System.Windows.Forms.TextBox YearOfGraduationField;
    private System.Windows.Forms.Button EducationListButton;
    private System.Windows.Forms.Button UpdateEducationButton;
  }
}