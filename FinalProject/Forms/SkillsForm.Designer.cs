namespace FinalProject.Forms
{
  partial class SkillsForm
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
      this.HardSkillField = new System.Windows.Forms.TextBox();
      this.SaveAndNextButton = new System.Windows.Forms.Button();
      this.NoSkillsButton = new System.Windows.Forms.Button();
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.SoftSkillField = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // HardSkillField
      // 
      this.HardSkillField.Location = new System.Drawing.Point(40, 87);
      this.HardSkillField.Multiline = true;
      this.HardSkillField.Name = "HardSkillField";
      this.HardSkillField.Size = new System.Drawing.Size(542, 84);
      this.HardSkillField.TabIndex = 0;
      this.HardSkillField.Text = "Технические навыки";
      this.HardSkillField.TextChanged += new System.EventHandler(this.HardSkillField_TextChanged);
      // 
      // SaveAndNextButton
      // 
      this.SaveAndNextButton.Location = new System.Drawing.Point(417, 386);
      this.SaveAndNextButton.Name = "SaveAndNextButton";
      this.SaveAndNextButton.Size = new System.Drawing.Size(184, 52);
      this.SaveAndNextButton.TabIndex = 19;
      this.SaveAndNextButton.Text = "Далее";
      this.SaveAndNextButton.UseVisualStyleBackColor = true;
      this.SaveAndNextButton.Click += new System.EventHandler(this.SaveAndNextButton_Click);
      // 
      // NoSkillsButton
      // 
      this.NoSkillsButton.Location = new System.Drawing.Point(215, 386);
      this.NoSkillsButton.Name = "NoSkillsButton";
      this.NoSkillsButton.Size = new System.Drawing.Size(196, 51);
      this.NoSkillsButton.TabIndex = 18;
      this.NoSkillsButton.Text = "Пропустить";
      this.NoSkillsButton.UseVisualStyleBackColor = true;
      this.NoSkillsButton.Click += new System.EventHandler(this.NoSkillsButton_Click);
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.Location = new System.Drawing.Point(25, 385);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(184, 52);
      this.PreviousFormButton.TabIndex = 16;
      this.PreviousFormButton.Text = "Назад";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click);
      // 
      // SoftSkillField
      // 
      this.SoftSkillField.Location = new System.Drawing.Point(40, 221);
      this.SoftSkillField.Multiline = true;
      this.SoftSkillField.Name = "SoftSkillField";
      this.SoftSkillField.Size = new System.Drawing.Size(542, 84);
      this.SoftSkillField.TabIndex = 21;
      this.SoftSkillField.Text = "Универсальные навыки";
      this.SoftSkillField.TextChanged += new System.EventHandler(this.SoftSkillField_TextChanged);
      // 
      // SkillsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(629, 450);
      this.Controls.Add(this.SoftSkillField);
      this.Controls.Add(this.SaveAndNextButton);
      this.Controls.Add(this.NoSkillsButton);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.HardSkillField);
      this.Name = "SkillsForm";
      this.Text = "Навыки";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox HardSkillField;
    private System.Windows.Forms.Button SaveAndNextButton;
    private System.Windows.Forms.Button NoSkillsButton;
    private System.Windows.Forms.Button PreviousFormButton;
    private System.Windows.Forms.TextBox SoftSkillField;
  }
}