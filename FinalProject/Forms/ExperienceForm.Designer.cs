namespace FinalProject
{
  partial class ExperienceForm
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
      this.PositionField = new System.Windows.Forms.TextBox();
      this.CompanyField = new System.Windows.Forms.TextBox();
      this.StartDateField = new System.Windows.Forms.DateTimePicker();
      this.EndDateField = new System.Windows.Forms.DateTimePicker();
      this.ResponsibilitiesField = new System.Windows.Forms.TextBox();
      this.NextButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.NoExperienceButton = new System.Windows.Forms.Button();
      this.AddMoreExperience = new System.Windows.Forms.Button();
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.SaveExperienceButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // PositionField
      // 
      this.PositionField.ForeColor = System.Drawing.Color.Black;
      this.PositionField.Location = new System.Drawing.Point(50, 37);
      this.PositionField.Multiline = true;
      this.PositionField.Name = "PositionField";
      this.PositionField.Size = new System.Drawing.Size(530, 70);
      this.PositionField.TabIndex = 0;
      this.PositionField.Text = "Должность";
      this.PositionField.Click += new System.EventHandler(this.PositionField_Click);
      this.PositionField.TextChanged += new System.EventHandler(this.PositionField_TextChanged);
      this.PositionField.Leave += new System.EventHandler(this.PositionField_Leave);
      // 
      // CompanyField
      // 
      this.CompanyField.ForeColor = System.Drawing.Color.Black;
      this.CompanyField.Location = new System.Drawing.Point(52, 113);
      this.CompanyField.Multiline = true;
      this.CompanyField.Name = "CompanyField";
      this.CompanyField.Size = new System.Drawing.Size(528, 70);
      this.CompanyField.TabIndex = 1;
      this.CompanyField.Text = "Компания";
      this.CompanyField.Click += new System.EventHandler(this.CompanyField_Click);
      this.CompanyField.TextChanged += new System.EventHandler(this.CompanyField_TextChanged);
      this.CompanyField.Leave += new System.EventHandler(this.CompanyField_Leave);
      // 
      // StartDateField
      // 
      this.StartDateField.CustomFormat = "MM.yyyy";
      this.StartDateField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.StartDateField.Location = new System.Drawing.Point(52, 312);
      this.StartDateField.Name = "StartDateField";
      this.StartDateField.Size = new System.Drawing.Size(202, 22);
      this.StartDateField.TabIndex = 2;
      this.StartDateField.ValueChanged += new System.EventHandler(this.StartDateField_ValueChanged);
      // 
      // EndDateField
      // 
      this.EndDateField.CustomFormat = "MM.yyyy";
      this.EndDateField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.EndDateField.Location = new System.Drawing.Point(52, 340);
      this.EndDateField.Name = "EndDateField";
      this.EndDateField.Size = new System.Drawing.Size(202, 22);
      this.EndDateField.TabIndex = 3;
      this.EndDateField.ValueChanged += new System.EventHandler(this.EndDateField_ValueChanged);
      // 
      // ResponsibilitiesField
      // 
      this.ResponsibilitiesField.ForeColor = System.Drawing.Color.Black;
      this.ResponsibilitiesField.Location = new System.Drawing.Point(52, 198);
      this.ResponsibilitiesField.Multiline = true;
      this.ResponsibilitiesField.Name = "ResponsibilitiesField";
      this.ResponsibilitiesField.Size = new System.Drawing.Size(528, 92);
      this.ResponsibilitiesField.TabIndex = 4;
      this.ResponsibilitiesField.Text = "Обязанности";
      this.ResponsibilitiesField.Click += new System.EventHandler(this.ResponsibilitiesField_Click);
      this.ResponsibilitiesField.TextChanged += new System.EventHandler(this.ResponsibilitiesField_TextChanged);
      this.ResponsibilitiesField.Leave += new System.EventHandler(this.ResponsibilitiesField_Leave);
      // 
      // NextButton
      // 
      this.NextButton.Location = new System.Drawing.Point(414, 386);
      this.NextButton.Name = "NextButton";
      this.NextButton.Size = new System.Drawing.Size(184, 52);
      this.NextButton.TabIndex = 5;
      this.NextButton.Text = "Далее";
      this.NextButton.UseVisualStyleBackColor = true;
      this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(49, 293);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(121, 16);
      this.label1.TabIndex = 6;
      this.label1.Text = "Период работы";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(29, 317);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(17, 16);
      this.label2.TabIndex = 7;
      this.label2.Text = "С";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(20, 345);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(26, 16);
      this.label3.TabIndex = 8;
      this.label3.Text = "До";
      // 
      // NoExperienceButton
      // 
      this.NoExperienceButton.Location = new System.Drawing.Point(212, 387);
      this.NoExperienceButton.Name = "NoExperienceButton";
      this.NoExperienceButton.Size = new System.Drawing.Size(196, 51);
      this.NoExperienceButton.TabIndex = 9;
      this.NoExperienceButton.Text = "Пропустить";
      this.NoExperienceButton.UseVisualStyleBackColor = true;
      this.NoExperienceButton.Click += new System.EventHandler(this.NoExperienceButton_Click);
      // 
      // AddMoreExperience
      // 
      this.AddMoreExperience.Location = new System.Drawing.Point(430, 312);
      this.AddMoreExperience.Name = "AddMoreExperience";
      this.AddMoreExperience.Size = new System.Drawing.Size(168, 51);
      this.AddMoreExperience.TabIndex = 10;
      this.AddMoreExperience.Text = "Добавить еще опыт";
      this.AddMoreExperience.UseVisualStyleBackColor = true;
      this.AddMoreExperience.Click += new System.EventHandler(this.AddMoreExperience_Click);
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.Location = new System.Drawing.Point(22, 385);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(184, 52);
      this.PreviousFormButton.TabIndex = 11;
      this.PreviousFormButton.Text = "Назад";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // SaveExperienceButton
      // 
      this.SaveExperienceButton.Location = new System.Drawing.Point(260, 312);
      this.SaveExperienceButton.Name = "SaveExperienceButton";
      this.SaveExperienceButton.Size = new System.Drawing.Size(164, 51);
      this.SaveExperienceButton.TabIndex = 12;
      this.SaveExperienceButton.Text = "Сохранить";
      this.SaveExperienceButton.UseVisualStyleBackColor = true;
      this.SaveExperienceButton.Click += new System.EventHandler(this.SaveExperienceButton_Click);
      // 
      // ExperienceForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(629, 450);
      this.Controls.Add(this.SaveExperienceButton);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.AddMoreExperience);
      this.Controls.Add(this.NoExperienceButton);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.NextButton);
      this.Controls.Add(this.ResponsibilitiesField);
      this.Controls.Add(this.EndDateField);
      this.Controls.Add(this.StartDateField);
      this.Controls.Add(this.CompanyField);
      this.Controls.Add(this.PositionField);
      this.Name = "ExperienceForm";
      this.Text = "Опыт работы";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExperienceForm_FormClosed);
      this.Load += new System.EventHandler(this.ExperienceForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox PositionField;
    private System.Windows.Forms.TextBox CompanyField;
    private System.Windows.Forms.DateTimePicker StartDateField;
    private System.Windows.Forms.DateTimePicker EndDateField;
    private System.Windows.Forms.TextBox ResponsibilitiesField;
    private System.Windows.Forms.Button NextButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button NoExperienceButton;
    private System.Windows.Forms.Button AddMoreExperience;
    private System.Windows.Forms.Button PreviousFormButton;
    private System.Windows.Forms.Button SaveExperienceButton;
  }
}