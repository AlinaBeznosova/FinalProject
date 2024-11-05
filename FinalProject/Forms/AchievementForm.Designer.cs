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
      this.SaveAndNextButton = new System.Windows.Forms.Button();
      this.NoSkillsButton = new System.Windows.Forms.Button();
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.AchievementField = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // SaveAndNextButton
      // 
      this.SaveAndNextButton.Location = new System.Drawing.Point(420, 386);
      this.SaveAndNextButton.Name = "SaveAndNextButton";
      this.SaveAndNextButton.Size = new System.Drawing.Size(184, 52);
      this.SaveAndNextButton.TabIndex = 25;
      this.SaveAndNextButton.Text = "Далее";
      this.SaveAndNextButton.UseVisualStyleBackColor = true;
      // 
      // NoSkillsButton
      // 
      this.NoSkillsButton.Location = new System.Drawing.Point(218, 386);
      this.NoSkillsButton.Name = "NoSkillsButton";
      this.NoSkillsButton.Size = new System.Drawing.Size(196, 51);
      this.NoSkillsButton.TabIndex = 24;
      this.NoSkillsButton.Text = "Пропустить";
      this.NoSkillsButton.UseVisualStyleBackColor = true;
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.Location = new System.Drawing.Point(28, 386);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(184, 52);
      this.PreviousFormButton.TabIndex = 23;
      this.PreviousFormButton.Text = "Назад";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // AchievementField
      // 
      this.AchievementField.Location = new System.Drawing.Point(38, 142);
      this.AchievementField.Multiline = true;
      this.AchievementField.Name = "AchievementField";
      this.AchievementField.Size = new System.Drawing.Size(542, 84);
      this.AchievementField.TabIndex = 22;
      this.AchievementField.Text = "Профессиональные достижения";
      // 
      // AchievementForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(629, 450);
      this.Controls.Add(this.SaveAndNextButton);
      this.Controls.Add(this.NoSkillsButton);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.AchievementField);
      this.Name = "AchievementForm";
      this.Text = "Достижения";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button SaveAndNextButton;
    private System.Windows.Forms.Button NoSkillsButton;
    private System.Windows.Forms.Button PreviousFormButton;
    private System.Windows.Forms.TextBox AchievementField;
  }
}