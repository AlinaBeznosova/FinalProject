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
      this.ResponsibilitiesField = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.NextFormButton = new System.Windows.Forms.Button();
      this.ClearFieldsButton = new System.Windows.Forms.Button();
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.StartDateField = new System.Windows.Forms.TextBox();
      this.EndDateField = new System.Windows.Forms.TextBox();
      this.ShowExperienceListButton = new System.Windows.Forms.Button();
      this.UpdateExperienceButton = new System.Windows.Forms.Button();
      this.AddExperienceButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // PositionField
      // 
      this.PositionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PositionField.ForeColor = System.Drawing.Color.Black;
      this.PositionField.Location = new System.Drawing.Point(20, 35);
      this.PositionField.Multiline = true;
      this.PositionField.Name = "PositionField";
      this.PositionField.Size = new System.Drawing.Size(587, 70);
      this.PositionField.TabIndex = 0;
      this.PositionField.Text = "Должность";
      this.PositionField.Click += new System.EventHandler(this.PositionField_Click);
      this.PositionField.TextChanged += new System.EventHandler(this.PositionField_TextChanged);
      this.PositionField.Leave += new System.EventHandler(this.PositionField_Leave);
      // 
      // CompanyField
      // 
      this.CompanyField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CompanyField.ForeColor = System.Drawing.Color.Black;
      this.CompanyField.Location = new System.Drawing.Point(22, 111);
      this.CompanyField.Multiline = true;
      this.CompanyField.Name = "CompanyField";
      this.CompanyField.Size = new System.Drawing.Size(585, 70);
      this.CompanyField.TabIndex = 1;
      this.CompanyField.Text = "Компания";
      this.CompanyField.Click += new System.EventHandler(this.CompanyField_Click);
      this.CompanyField.TextChanged += new System.EventHandler(this.CompanyField_TextChanged);
      this.CompanyField.Leave += new System.EventHandler(this.CompanyField_Leave);
      // 
      // ResponsibilitiesField
      // 
      this.ResponsibilitiesField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ResponsibilitiesField.ForeColor = System.Drawing.Color.Black;
      this.ResponsibilitiesField.Location = new System.Drawing.Point(22, 196);
      this.ResponsibilitiesField.Multiline = true;
      this.ResponsibilitiesField.Name = "ResponsibilitiesField";
      this.ResponsibilitiesField.Size = new System.Drawing.Size(585, 92);
      this.ResponsibilitiesField.TabIndex = 4;
      this.ResponsibilitiesField.Text = "Обязанности";
      this.ResponsibilitiesField.Click += new System.EventHandler(this.ResponsibilitiesField_Click);
      this.ResponsibilitiesField.TextChanged += new System.EventHandler(this.ResponsibilitiesField_TextChanged);
      this.ResponsibilitiesField.Leave += new System.EventHandler(this.ResponsibilitiesField_Leave);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(19, 293);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(121, 16);
      this.label1.TabIndex = 6;
      this.label1.Text = "Период работы";
      // 
      // NextFormButton
      // 
      this.NextFormButton.Location = new System.Drawing.Point(470, 387);
      this.NextFormButton.Name = "NextFormButton";
      this.NextFormButton.Size = new System.Drawing.Size(147, 51);
      this.NextFormButton.TabIndex = 9;
      this.NextFormButton.Text = "Далее";
      this.NextFormButton.UseVisualStyleBackColor = true;
      this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
      // 
      // ClearFieldsButton
      // 
      this.ClearFieldsButton.Location = new System.Drawing.Point(260, 305);
      this.ClearFieldsButton.Name = "ClearFieldsButton";
      this.ClearFieldsButton.Size = new System.Drawing.Size(173, 63);
      this.ClearFieldsButton.TabIndex = 10;
      this.ClearFieldsButton.Text = "Очистить поля для добавления опыта";
      this.ClearFieldsButton.UseVisualStyleBackColor = true;
      this.ClearFieldsButton.Click += new System.EventHandler(this.ClearFieldsButton_Click);
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.Location = new System.Drawing.Point(11, 385);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(147, 52);
      this.PreviousFormButton.TabIndex = 11;
      this.PreviousFormButton.Text = "Назад";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // StartDateField
      // 
      this.StartDateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.StartDateField.Location = new System.Drawing.Point(22, 312);
      this.StartDateField.Name = "StartDateField";
      this.StartDateField.Size = new System.Drawing.Size(232, 26);
      this.StartDateField.TabIndex = 12;
      this.StartDateField.Text = "С мм.гггг";
      this.StartDateField.Click += new System.EventHandler(this.StartDateField_Click);
      this.StartDateField.TextChanged += new System.EventHandler(this.StartDateField_TextChanged);
      this.StartDateField.Leave += new System.EventHandler(this.StartDateField_Leave);
      // 
      // EndDateField
      // 
      this.EndDateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.EndDateField.Location = new System.Drawing.Point(22, 345);
      this.EndDateField.Name = "EndDateField";
      this.EndDateField.Size = new System.Drawing.Size(232, 26);
      this.EndDateField.TabIndex = 13;
      this.EndDateField.Text = "До мм.гггг";
      this.EndDateField.Click += new System.EventHandler(this.EndDateField_Click);
      this.EndDateField.TextChanged += new System.EventHandler(this.EndDateField_TextChanged);
      this.EndDateField.Leave += new System.EventHandler(this.EndDateField_Leave);
      // 
      // ShowExperienceListButton
      // 
      this.ShowExperienceListButton.Location = new System.Drawing.Point(439, 305);
      this.ShowExperienceListButton.Name = "ShowExperienceListButton";
      this.ShowExperienceListButton.Size = new System.Drawing.Size(168, 62);
      this.ShowExperienceListButton.TabIndex = 14;
      this.ShowExperienceListButton.Text = "Показать список опыта работы";
      this.ShowExperienceListButton.UseVisualStyleBackColor = true;
      this.ShowExperienceListButton.Click += new System.EventHandler(this.ShowExperienceListButton_Click);
      // 
      // UpdateExperienceButton
      // 
      this.UpdateExperienceButton.Location = new System.Drawing.Point(164, 386);
      this.UpdateExperienceButton.Name = "UpdateExperienceButton";
      this.UpdateExperienceButton.Size = new System.Drawing.Size(147, 51);
      this.UpdateExperienceButton.TabIndex = 15;
      this.UpdateExperienceButton.Text = "Обновить  существующий опыт";
      this.UpdateExperienceButton.UseVisualStyleBackColor = true;
      this.UpdateExperienceButton.Click += new System.EventHandler(this.UpdateExperienceButton_Click);
      // 
      // AddExperienceButton
      // 
      this.AddExperienceButton.Location = new System.Drawing.Point(317, 386);
      this.AddExperienceButton.Name = "AddExperienceButton";
      this.AddExperienceButton.Size = new System.Drawing.Size(147, 51);
      this.AddExperienceButton.TabIndex = 16;
      this.AddExperienceButton.Text = "Сохранить как новый опыт";
      this.AddExperienceButton.UseVisualStyleBackColor = true;
      this.AddExperienceButton.Click += new System.EventHandler(this.AddExperienceButton_Click);
      // 
      // ExperienceForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 453);
      this.Controls.Add(this.AddExperienceButton);
      this.Controls.Add(this.UpdateExperienceButton);
      this.Controls.Add(this.ShowExperienceListButton);
      this.Controls.Add(this.EndDateField);
      this.Controls.Add(this.StartDateField);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.ClearFieldsButton);
      this.Controls.Add(this.NextFormButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.ResponsibilitiesField);
      this.Controls.Add(this.CompanyField);
      this.Controls.Add(this.PositionField);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "ExperienceForm";
      this.Text = "Опыт работы";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExperienceForm_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox PositionField;
    private System.Windows.Forms.TextBox CompanyField;
    private System.Windows.Forms.TextBox ResponsibilitiesField;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button NextFormButton;
    private System.Windows.Forms.Button ClearFieldsButton;
    private System.Windows.Forms.Button PreviousFormButton;
    private System.Windows.Forms.TextBox StartDateField;
    private System.Windows.Forms.TextBox EndDateField;
    private System.Windows.Forms.Button ShowExperienceListButton;
    private System.Windows.Forms.Button UpdateExperienceButton;
    private System.Windows.Forms.Button AddExperienceButton;
  }
}