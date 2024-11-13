namespace FinalProject.Forms
{
  partial class EducationListForm
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
      this.radioPanel = new System.Windows.Forms.Panel();
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.NextFormButton = new System.Windows.Forms.Button();
      this.EditEducation = new System.Windows.Forms.Button();
      this.DeleteEducationButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // radioPanel
      // 
      this.radioPanel.AutoScroll = true;
      this.radioPanel.Location = new System.Drawing.Point(10, 10);
      this.radioPanel.Name = "radioPanel";
      this.radioPanel.Size = new System.Drawing.Size(438, 190);
      this.radioPanel.TabIndex = 14;
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.Location = new System.Drawing.Point(228, 206);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(220, 42);
      this.PreviousFormButton.TabIndex = 18;
      this.PreviousFormButton.Text = "Добавить еще образование";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // NextFormButton
      // 
      this.NextFormButton.Location = new System.Drawing.Point(228, 254);
      this.NextFormButton.Name = "NextFormButton";
      this.NextFormButton.Size = new System.Drawing.Size(222, 42);
      this.NextFormButton.TabIndex = 17;
      this.NextFormButton.Text = "Далее";
      this.NextFormButton.UseVisualStyleBackColor = true;
      this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
      // 
      // EditEducation
      // 
      this.EditEducation.Location = new System.Drawing.Point(2, 254);
      this.EditEducation.Name = "EditEducation";
      this.EditEducation.Size = new System.Drawing.Size(220, 42);
      this.EditEducation.TabIndex = 16;
      this.EditEducation.Text = "Редактировать";
      this.EditEducation.UseVisualStyleBackColor = true;
      this.EditEducation.Click += new System.EventHandler(this.EditEducation_Click);
      // 
      // DeleteEducationButton
      // 
      this.DeleteEducationButton.Location = new System.Drawing.Point(2, 206);
      this.DeleteEducationButton.Name = "DeleteEducationButton";
      this.DeleteEducationButton.Size = new System.Drawing.Size(220, 42);
      this.DeleteEducationButton.TabIndex = 15;
      this.DeleteEducationButton.Text = "Удалить";
      this.DeleteEducationButton.UseVisualStyleBackColor = true;
      this.DeleteEducationButton.Click += new System.EventHandler(this.DeleteEducationButton_Click);
      // 
      // EducationListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(452, 303);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.NextFormButton);
      this.Controls.Add(this.EditEducation);
      this.Controls.Add(this.DeleteEducationButton);
      this.Controls.Add(this.radioPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "EducationListForm";
      this.Text = "EducationListForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EducationListForm_FormClosed);
      this.Load += new System.EventHandler(this.EducationListForm_Load);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel radioPanel;
    private System.Windows.Forms.Button PreviousFormButton;
    private System.Windows.Forms.Button NextFormButton;
    private System.Windows.Forms.Button EditEducation;
    private System.Windows.Forms.Button DeleteEducationButton;
  }
}