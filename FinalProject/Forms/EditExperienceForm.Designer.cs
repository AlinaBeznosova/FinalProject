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
      this.PositionsList = new System.Windows.Forms.RichTextBox();
      this.PositionChoiseField = new System.Windows.Forms.TextBox();
      this.DeleteExperienceButton = new System.Windows.Forms.Button();
      this.EditExperience = new System.Windows.Forms.Button();
      this.NextFormButton = new System.Windows.Forms.Button();
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // PositionsList
      // 
      this.PositionsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PositionsList.Location = new System.Drawing.Point(35, 36);
      this.PositionsList.Name = "PositionsList";
      this.PositionsList.ReadOnly = true;
      this.PositionsList.Size = new System.Drawing.Size(482, 162);
      this.PositionsList.TabIndex = 1;
      this.PositionsList.Text = "";
      // 
      // PositionChoiseField
      // 
      this.PositionChoiseField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PositionChoiseField.Location = new System.Drawing.Point(35, 213);
      this.PositionChoiseField.Multiline = true;
      this.PositionChoiseField.Name = "PositionChoiseField";
      this.PositionChoiseField.Size = new System.Drawing.Size(482, 49);
      this.PositionChoiseField.TabIndex = 3;
      this.PositionChoiseField.Text = "Введите должность";
      this.PositionChoiseField.Click += new System.EventHandler(this.PositionChoiseField_Click);
      this.PositionChoiseField.TextChanged += new System.EventHandler(this.PositionChoiseField_TextChanged);
      this.PositionChoiseField.Leave += new System.EventHandler(this.PositionChoiseField_Leave);
      // 
      // DeleteExperienceButton
      // 
      this.DeleteExperienceButton.Location = new System.Drawing.Point(50, 268);
      this.DeleteExperienceButton.Name = "DeleteExperienceButton";
      this.DeleteExperienceButton.Size = new System.Drawing.Size(222, 44);
      this.DeleteExperienceButton.TabIndex = 4;
      this.DeleteExperienceButton.Text = "Удалить";
      this.DeleteExperienceButton.UseVisualStyleBackColor = true;
      this.DeleteExperienceButton.Click += new System.EventHandler(this.DeleteExperienceButton_Click);
      // 
      // EditExperience
      // 
      this.EditExperience.Location = new System.Drawing.Point(278, 268);
      this.EditExperience.Name = "EditExperience";
      this.EditExperience.Size = new System.Drawing.Size(222, 44);
      this.EditExperience.TabIndex = 5;
      this.EditExperience.Text = "Редактировать";
      this.EditExperience.UseVisualStyleBackColor = true;
      this.EditExperience.Click += new System.EventHandler(this.EditExperience_Click);
      // 
      // NextFormButton
      // 
      this.NextFormButton.Location = new System.Drawing.Point(278, 321);
      this.NextFormButton.Name = "NextFormButton";
      this.NextFormButton.Size = new System.Drawing.Size(222, 42);
      this.NextFormButton.TabIndex = 6;
      this.NextFormButton.Text = "Далее";
      this.NextFormButton.UseVisualStyleBackColor = true;
      this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.Location = new System.Drawing.Point(50, 321);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(222, 42);
      this.PreviousFormButton.TabIndex = 7;
      this.PreviousFormButton.Text = "Добавить еще опыт работы";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // EditExperienceForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(542, 375);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.NextFormButton);
      this.Controls.Add(this.EditExperience);
      this.Controls.Add(this.DeleteExperienceButton);
      this.Controls.Add(this.PositionChoiseField);
      this.Controls.Add(this.PositionsList);
      this.Name = "EditExperienceForm";
      this.Text = "Имеющийся опыт работы";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditExperienceForm_FormClosed);
      this.Load += new System.EventHandler(this.EditExperienceForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox PositionsList;
    private System.Windows.Forms.TextBox PositionChoiseField;
    private System.Windows.Forms.Button DeleteExperienceButton;
    private System.Windows.Forms.Button EditExperience;
    private System.Windows.Forms.Button NextFormButton;
    private System.Windows.Forms.Button PreviousFormButton;
  }
}