namespace FinalProject.Forms
{
  partial class EditExperienceForm
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
      this.DeleteExperienceButton = new System.Windows.Forms.Button();
      this.EditExperience = new System.Windows.Forms.Button();
      this.NextFormButton = new System.Windows.Forms.Button();
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.radioPanel = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // DeleteExperienceButton
      // 
      this.DeleteExperienceButton.Location = new System.Drawing.Point(2, 208);
      this.DeleteExperienceButton.Name = "DeleteExperienceButton";
      this.DeleteExperienceButton.Size = new System.Drawing.Size(220, 42);
      this.DeleteExperienceButton.TabIndex = 4;
      this.DeleteExperienceButton.Text = "Удалить";
      this.DeleteExperienceButton.UseVisualStyleBackColor = true;
      this.DeleteExperienceButton.Click += new System.EventHandler(this.DeleteExperienceButton_Click);
      // 
      // EditExperience
      // 
      this.EditExperience.Location = new System.Drawing.Point(2, 256);
      this.EditExperience.Name = "EditExperience";
      this.EditExperience.Size = new System.Drawing.Size(220, 42);
      this.EditExperience.TabIndex = 5;
      this.EditExperience.Text = "Редактировать";
      this.EditExperience.UseVisualStyleBackColor = true;
      this.EditExperience.Click += new System.EventHandler(this.EditExperience_Click);
      // 
      // NextFormButton
      // 
      this.NextFormButton.Location = new System.Drawing.Point(228, 256);
      this.NextFormButton.Name = "NextFormButton";
      this.NextFormButton.Size = new System.Drawing.Size(222, 42);
      this.NextFormButton.TabIndex = 6;
      this.NextFormButton.Text = "Далее";
      this.NextFormButton.UseVisualStyleBackColor = true;
      this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.Location = new System.Drawing.Point(228, 208);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(220, 42);
      this.PreviousFormButton.TabIndex = 7;
      this.PreviousFormButton.Text = "Добавить еще опыт работы";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // radioPanel
      // 
      this.radioPanel.AutoScroll = true;
      this.radioPanel.Location = new System.Drawing.Point(10, 10);
      this.radioPanel.Name = "radioPanel";
      this.radioPanel.Size = new System.Drawing.Size(438, 190);
      this.radioPanel.TabIndex = 8;
      // 
      // EditExperienceForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(452, 303);
      this.Controls.Add(this.radioPanel);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.NextFormButton);
      this.Controls.Add(this.EditExperience);
      this.Controls.Add(this.DeleteExperienceButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "EditExperienceForm";
      this.Text = "Имеющийся опыт работы";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditExperienceForm_FormClosed);
      this.Load += new System.EventHandler(this.EditExperienceForm_Load);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button DeleteExperienceButton;
    private System.Windows.Forms.Button EditExperience;
    private System.Windows.Forms.Button NextFormButton;
    private System.Windows.Forms.Button PreviousFormButton;
    private System.Windows.Forms.Panel radioPanel;
  }
}