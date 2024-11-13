namespace FinalProject.Forms
{
  partial class SkillsListForm
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
      this.EditSkill = new System.Windows.Forms.Button();
      this.DeleteSkillButton = new System.Windows.Forms.Button();
      this.radioPanel = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
      this.PreviousFormButton.Location = new System.Drawing.Point(228, 203);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(220, 42);
      this.PreviousFormButton.TabIndex = 23;
      this.PreviousFormButton.Text = "Добавить еще навыки";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // NextFormButton
      // 
      this.NextFormButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
      this.NextFormButton.Location = new System.Drawing.Point(228, 251);
      this.NextFormButton.Name = "NextFormButton";
      this.NextFormButton.Size = new System.Drawing.Size(222, 42);
      this.NextFormButton.TabIndex = 22;
      this.NextFormButton.Text = "Далее";
      this.NextFormButton.UseVisualStyleBackColor = true;
      this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
      // 
      // EditSkill
      // 
      this.EditSkill.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
      this.EditSkill.Location = new System.Drawing.Point(2, 251);
      this.EditSkill.Name = "EditSkill";
      this.EditSkill.Size = new System.Drawing.Size(220, 42);
      this.EditSkill.TabIndex = 21;
      this.EditSkill.Text = "Редактировать";
      this.EditSkill.UseVisualStyleBackColor = true;
      this.EditSkill.Click += new System.EventHandler(this.EditSkill_Click);
      // 
      // DeleteSkillButton
      // 
      this.DeleteSkillButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
      this.DeleteSkillButton.Location = new System.Drawing.Point(2, 203);
      this.DeleteSkillButton.Name = "DeleteSkillButton";
      this.DeleteSkillButton.Size = new System.Drawing.Size(220, 42);
      this.DeleteSkillButton.TabIndex = 20;
      this.DeleteSkillButton.Text = "Удалить";
      this.DeleteSkillButton.UseVisualStyleBackColor = true;
      this.DeleteSkillButton.Click += new System.EventHandler(this.DeleteSkillButton_Click);
      // 
      // radioPanel
      // 
      this.radioPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
      this.radioPanel.AutoScroll = true;
      this.radioPanel.Location = new System.Drawing.Point(10, 10);
      this.radioPanel.Name = "radioPanel";
      this.radioPanel.Size = new System.Drawing.Size(438, 190);
      this.radioPanel.TabIndex = 19;
      // 
      // SkillsListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(452, 303);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.NextFormButton);
      this.Controls.Add(this.EditSkill);
      this.Controls.Add(this.DeleteSkillButton);
      this.Controls.Add(this.radioPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "SkillsListForm";
      this.Text = "SkillsListForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SkillsListForm_FormClosed);
      this.Load += new System.EventHandler(this.SkillsListForm_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button PreviousFormButton;
    private System.Windows.Forms.Button NextFormButton;
    private System.Windows.Forms.Button EditSkill;
    private System.Windows.Forms.Button DeleteSkillButton;
    private System.Windows.Forms.Panel radioPanel;
  }
}