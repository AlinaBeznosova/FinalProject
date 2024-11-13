namespace FinalProject.Forms
{
  partial class AchievementListForm
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
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.NextFormButton = new System.Windows.Forms.Button();
      this.EditAchievement = new System.Windows.Forms.Button();
      this.DeleteAchievementButton = new System.Windows.Forms.Button();
      this.radioPanel = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
      this.PreviousFormButton.Location = new System.Drawing.Point(227, 204);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(220, 42);
      this.PreviousFormButton.TabIndex = 28;
      this.PreviousFormButton.Text = "Добавить еще достижения";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // NextFormButton
      // 
      this.NextFormButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
      this.NextFormButton.Location = new System.Drawing.Point(227, 252);
      this.NextFormButton.Name = "NextFormButton";
      this.NextFormButton.Size = new System.Drawing.Size(222, 42);
      this.NextFormButton.TabIndex = 27;
      this.NextFormButton.Text = "Далее";
      this.NextFormButton.UseVisualStyleBackColor = true;
      this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
      // 
      // EditAchievement
      // 
      this.EditAchievement.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
      this.EditAchievement.Location = new System.Drawing.Point(1, 252);
      this.EditAchievement.Name = "EditAchievement";
      this.EditAchievement.Size = new System.Drawing.Size(220, 42);
      this.EditAchievement.TabIndex = 26;
      this.EditAchievement.Text = "Редактировать";
      this.EditAchievement.UseVisualStyleBackColor = true;
      this.EditAchievement.Click += new System.EventHandler(this.EditAchievement_Click);
      // 
      // DeleteAchievementButton
      // 
      this.DeleteAchievementButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
      this.DeleteAchievementButton.Location = new System.Drawing.Point(1, 204);
      this.DeleteAchievementButton.Name = "DeleteAchievementButton";
      this.DeleteAchievementButton.Size = new System.Drawing.Size(220, 42);
      this.DeleteAchievementButton.TabIndex = 25;
      this.DeleteAchievementButton.Text = "Удалить";
      this.DeleteAchievementButton.UseVisualStyleBackColor = true;
      this.DeleteAchievementButton.Click += new System.EventHandler(this.DeleteAchievementButton_Click);
      // 
      // radioPanel
      // 
      this.radioPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
      this.radioPanel.AutoScroll = true;
      this.radioPanel.Location = new System.Drawing.Point(10, 10);
      this.radioPanel.Name = "radioPanel";
      this.radioPanel.Size = new System.Drawing.Size(438, 190);
      this.radioPanel.TabIndex = 24;
      // 
      // AchievementListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(452, 303);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.NextFormButton);
      this.Controls.Add(this.EditAchievement);
      this.Controls.Add(this.DeleteAchievementButton);
      this.Controls.Add(this.radioPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "AchievementListForm";
      this.Text = "AchievementListForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AchievementListForm_FormClosed);
      this.Load += new System.EventHandler(this.AchievementListForm_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button PreviousFormButton;
    private System.Windows.Forms.Button NextFormButton;
    private System.Windows.Forms.Button EditAchievement;
    private System.Windows.Forms.Button DeleteAchievementButton;
    private System.Windows.Forms.Panel radioPanel;
  }
}