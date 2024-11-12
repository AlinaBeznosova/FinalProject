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
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.NextFormButton = new System.Windows.Forms.Button();
      this.EditExperience = new System.Windows.Forms.Button();
      this.DeleteExperienceButton = new System.Windows.Forms.Button();
      this.PositionChoiseField = new System.Windows.Forms.TextBox();
      this.PositionsList = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.Location = new System.Drawing.Point(47, 327);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(222, 42);
      this.PreviousFormButton.TabIndex = 13;
      this.PreviousFormButton.Text = "Добавить еще образование";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // NextFormButton
      // 
      this.NextFormButton.Location = new System.Drawing.Point(275, 327);
      this.NextFormButton.Name = "NextFormButton";
      this.NextFormButton.Size = new System.Drawing.Size(222, 42);
      this.NextFormButton.TabIndex = 12;
      this.NextFormButton.Text = "Далее";
      this.NextFormButton.UseVisualStyleBackColor = true;
      this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
      // 
      // EditExperience
      // 
      this.EditExperience.Location = new System.Drawing.Point(275, 274);
      this.EditExperience.Name = "EditExperience";
      this.EditExperience.Size = new System.Drawing.Size(222, 44);
      this.EditExperience.TabIndex = 11;
      this.EditExperience.Text = "Редактировать";
      this.EditExperience.UseVisualStyleBackColor = true;
      this.EditExperience.Click += new System.EventHandler(this.EditExperience_Click);
      // 
      // DeleteExperienceButton
      // 
      this.DeleteExperienceButton.Location = new System.Drawing.Point(47, 274);
      this.DeleteExperienceButton.Name = "DeleteExperienceButton";
      this.DeleteExperienceButton.Size = new System.Drawing.Size(222, 44);
      this.DeleteExperienceButton.TabIndex = 10;
      this.DeleteExperienceButton.Text = "Удалить";
      this.DeleteExperienceButton.UseVisualStyleBackColor = true;
      this.DeleteExperienceButton.Click += new System.EventHandler(this.DeleteExperienceButton_Click);
      // 
      // PositionChoiseField
      // 
      this.PositionChoiseField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PositionChoiseField.Location = new System.Drawing.Point(32, 219);
      this.PositionChoiseField.Multiline = true;
      this.PositionChoiseField.Name = "PositionChoiseField";
      this.PositionChoiseField.Size = new System.Drawing.Size(482, 49);
      this.PositionChoiseField.TabIndex = 9;
      this.PositionChoiseField.Text = "Введите учебное заведение";
      this.PositionChoiseField.Click += new System.EventHandler(this.PositionChoiseField_Click);
      this.PositionChoiseField.TextChanged += new System.EventHandler(this.PositionChoiseField_TextChanged);
      this.PositionChoiseField.Leave += new System.EventHandler(this.PositionChoiseField_Leave);
      // 
      // PositionsList
      // 
      this.PositionsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PositionsList.Location = new System.Drawing.Point(32, 42);
      this.PositionsList.Name = "PositionsList";
      this.PositionsList.ReadOnly = true;
      this.PositionsList.Size = new System.Drawing.Size(482, 162);
      this.PositionsList.TabIndex = 8;
      this.PositionsList.Text = "";
      // 
      // EducationListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(549, 401);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.NextFormButton);
      this.Controls.Add(this.EditExperience);
      this.Controls.Add(this.DeleteExperienceButton);
      this.Controls.Add(this.PositionChoiseField);
      this.Controls.Add(this.PositionsList);
      this.Name = "EducationListForm";
      this.Text = "EducationListForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EducationListForm_FormClosed);
      this.Load += new System.EventHandler(this.EducationListForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button PreviousFormButton;
    private System.Windows.Forms.Button NextFormButton;
    private System.Windows.Forms.Button EditExperience;
    private System.Windows.Forms.Button DeleteExperienceButton;
    private System.Windows.Forms.TextBox PositionChoiseField;
    private System.Windows.Forms.RichTextBox PositionsList;
  }
}