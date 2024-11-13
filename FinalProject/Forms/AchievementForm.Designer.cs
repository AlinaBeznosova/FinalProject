namespace FinalProject.Forms
{
  partial class AchievementForm
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
      this.AchievementField = new System.Windows.Forms.TextBox();
      this.UpdateAchievementButton = new System.Windows.Forms.Button();
      this.AchievementListButton = new System.Windows.Forms.Button();
      this.AddAchievementButton = new System.Windows.Forms.Button();
      this.NextFormButton = new System.Windows.Forms.Button();
      this.ClearFieldsButton = new System.Windows.Forms.Button();
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // AchievementField
      // 
      this.AchievementField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AchievementField.Location = new System.Drawing.Point(12, 37);
      this.AchievementField.Multiline = true;
      this.AchievementField.Name = "AchievementField";
      this.AchievementField.Size = new System.Drawing.Size(608, 188);
      this.AchievementField.TabIndex = 22;
      this.AchievementField.Text = "Профессиональные достижения";
      this.AchievementField.Click += new System.EventHandler(this.AchievementField_Click);
      this.AchievementField.TextChanged += new System.EventHandler(this.AchievementField_TextChanged);
      this.AchievementField.Leave += new System.EventHandler(this.AchievementField_Leave);
      // 
      // UpdateAchievementButton
      // 
      this.UpdateAchievementButton.Location = new System.Drawing.Point(163, 321);
      this.UpdateAchievementButton.Name = "UpdateAchievementButton";
      this.UpdateAchievementButton.Size = new System.Drawing.Size(147, 70);
      this.UpdateAchievementButton.TabIndex = 33;
      this.UpdateAchievementButton.Text = "Обновить существующие достижения";
      this.UpdateAchievementButton.UseVisualStyleBackColor = true;
      this.UpdateAchievementButton.Click += new System.EventHandler(this.UpdateAchievementButton_Click);
      // 
      // AchievementListButton
      // 
      this.AchievementListButton.Location = new System.Drawing.Point(316, 242);
      this.AchievementListButton.Name = "AchievementListButton";
      this.AchievementListButton.Size = new System.Drawing.Size(187, 55);
      this.AchievementListButton.TabIndex = 32;
      this.AchievementListButton.Text = "Показать список достижений";
      this.AchievementListButton.UseVisualStyleBackColor = true;
      this.AchievementListButton.Click += new System.EventHandler(this.AchievementListButton_Click);
      // 
      // AddAchievementButton
      // 
      this.AddAchievementButton.Location = new System.Drawing.Point(316, 322);
      this.AddAchievementButton.Name = "AddAchievementButton";
      this.AddAchievementButton.Size = new System.Drawing.Size(147, 69);
      this.AddAchievementButton.TabIndex = 31;
      this.AddAchievementButton.Text = "Сохранить как новые достижения";
      this.AddAchievementButton.UseVisualStyleBackColor = true;
      this.AddAchievementButton.Click += new System.EventHandler(this.AddAchievementButton_Click);
      // 
      // NextFormButton
      // 
      this.NextFormButton.Location = new System.Drawing.Point(469, 322);
      this.NextFormButton.Name = "NextFormButton";
      this.NextFormButton.Size = new System.Drawing.Size(147, 69);
      this.NextFormButton.TabIndex = 30;
      this.NextFormButton.Text = "Далее";
      this.NextFormButton.UseVisualStyleBackColor = true;
      this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
      // 
      // ClearFieldsButton
      // 
      this.ClearFieldsButton.Location = new System.Drawing.Point(114, 242);
      this.ClearFieldsButton.Name = "ClearFieldsButton";
      this.ClearFieldsButton.Size = new System.Drawing.Size(187, 55);
      this.ClearFieldsButton.TabIndex = 29;
      this.ClearFieldsButton.Text = "Очистить поле для добавления достижений";
      this.ClearFieldsButton.UseVisualStyleBackColor = true;
      this.ClearFieldsButton.Click += new System.EventHandler(this.ClearFieldsButton_Click);
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.Location = new System.Drawing.Point(10, 321);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(147, 70);
      this.PreviousFormButton.TabIndex = 28;
      this.PreviousFormButton.Text = "Назад";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // AchievementForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 403);
      this.Controls.Add(this.UpdateAchievementButton);
      this.Controls.Add(this.AchievementListButton);
      this.Controls.Add(this.AddAchievementButton);
      this.Controls.Add(this.NextFormButton);
      this.Controls.Add(this.ClearFieldsButton);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.AchievementField);
      this.Name = "AchievementForm";
      this.Text = "Достижения";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AchievementForm_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox AchievementField;
    private System.Windows.Forms.Button UpdateAchievementButton;
    private System.Windows.Forms.Button AchievementListButton;
    private System.Windows.Forms.Button AddAchievementButton;
    private System.Windows.Forms.Button NextFormButton;
    private System.Windows.Forms.Button ClearFieldsButton;
    private System.Windows.Forms.Button PreviousFormButton;
  }
}