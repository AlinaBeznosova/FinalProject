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
      this.SaveExperienceButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // PositionField
      // 
      this.PositionField.ForeColor = System.Drawing.Color.Black;
      this.PositionField.Location = new System.Drawing.Point(66, 53);
      this.PositionField.Multiline = true;
      this.PositionField.Name = "PositionField";
      this.PositionField.Size = new System.Drawing.Size(228, 44);
      this.PositionField.TabIndex = 0;
      this.PositionField.Text = "Должность";
      this.PositionField.Click += new System.EventHandler(this.PositionField_Click);
      this.PositionField.TextChanged += new System.EventHandler(this.PositionField_TextChanged);
      this.PositionField.Leave += new System.EventHandler(this.PositionField_Leave);
      // 
      // CompanyField
      // 
      this.CompanyField.ForeColor = System.Drawing.Color.Black;
      this.CompanyField.Location = new System.Drawing.Point(62, 148);
      this.CompanyField.Multiline = true;
      this.CompanyField.Name = "CompanyField";
      this.CompanyField.Size = new System.Drawing.Size(231, 47);
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
      this.StartDateField.Location = new System.Drawing.Point(81, 230);
      this.StartDateField.Name = "StartDateField";
      this.StartDateField.Size = new System.Drawing.Size(202, 22);
      this.StartDateField.TabIndex = 2;
      this.StartDateField.ValueChanged += new System.EventHandler(this.StartDateField_ValueChanged);
      // 
      // EndDateField
      // 
      this.EndDateField.CustomFormat = "MM.yyyy";
      this.EndDateField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.EndDateField.Location = new System.Drawing.Point(81, 282);
      this.EndDateField.Name = "EndDateField";
      this.EndDateField.Size = new System.Drawing.Size(202, 22);
      this.EndDateField.TabIndex = 3;
      this.EndDateField.ValueChanged += new System.EventHandler(this.EndDateField_ValueChanged);
      // 
      // ResponsibilitiesField
      // 
      this.ResponsibilitiesField.ForeColor = System.Drawing.Color.Black;
      this.ResponsibilitiesField.Location = new System.Drawing.Point(383, 60);
      this.ResponsibilitiesField.Multiline = true;
      this.ResponsibilitiesField.Name = "ResponsibilitiesField";
      this.ResponsibilitiesField.Size = new System.Drawing.Size(238, 107);
      this.ResponsibilitiesField.TabIndex = 4;
      this.ResponsibilitiesField.Text = "Обязанности";
      this.ResponsibilitiesField.Click += new System.EventHandler(this.ResponsibilitiesField_Click);
      this.ResponsibilitiesField.TextChanged += new System.EventHandler(this.ResponsibilitiesField_TextChanged);
      this.ResponsibilitiesField.Leave += new System.EventHandler(this.ResponsibilitiesField_Leave);
      // 
      // SaveExperienceButton
      // 
      this.SaveExperienceButton.Location = new System.Drawing.Point(81, 350);
      this.SaveExperienceButton.Name = "SaveExperienceButton";
      this.SaveExperienceButton.Size = new System.Drawing.Size(184, 52);
      this.SaveExperienceButton.TabIndex = 5;
      this.SaveExperienceButton.Text = "Сохранить опыт";
      this.SaveExperienceButton.UseVisualStyleBackColor = true;
      this.SaveExperienceButton.Click += new System.EventHandler(this.SaveExperienceButton_Click);
      // 
      // ExperienceForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.SaveExperienceButton);
      this.Controls.Add(this.ResponsibilitiesField);
      this.Controls.Add(this.EndDateField);
      this.Controls.Add(this.StartDateField);
      this.Controls.Add(this.CompanyField);
      this.Controls.Add(this.PositionField);
      this.Name = "ExperienceForm";
      this.Text = "Опыт работы";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExperienceForm_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox PositionField;
    private System.Windows.Forms.TextBox CompanyField;
    private System.Windows.Forms.DateTimePicker StartDateField;
    private System.Windows.Forms.DateTimePicker EndDateField;
    private System.Windows.Forms.TextBox ResponsibilitiesField;
    private System.Windows.Forms.Button SaveExperienceButton;
  }
}