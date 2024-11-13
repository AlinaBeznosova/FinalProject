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
      this.SoftSkillField = new System.Windows.Forms.TextBox();
      this.UpdateSkillsButton = new System.Windows.Forms.Button();
      this.SkillsListButton = new System.Windows.Forms.Button();
      this.AddSkillsButton = new System.Windows.Forms.Button();
      this.NextFormButton = new System.Windows.Forms.Button();
      this.ClearFieldsButton = new System.Windows.Forms.Button();
      this.PreviousFormButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // HardSkillField
      // 
      this.HardSkillField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.HardSkillField.Location = new System.Drawing.Point(12, 37);
      this.HardSkillField.Multiline = true;
      this.HardSkillField.Name = "HardSkillField";
      this.HardSkillField.Size = new System.Drawing.Size(608, 84);
      this.HardSkillField.TabIndex = 0;
      this.HardSkillField.Text = "Технические навыки";
      this.HardSkillField.Click += new System.EventHandler(this.HardSkillField_Click);
      this.HardSkillField.TextChanged += new System.EventHandler(this.HardSkillField_TextChanged);
      this.HardSkillField.Leave += new System.EventHandler(this.HardSkillField_Leave);
      // 
      // SoftSkillField
      // 
      this.SoftSkillField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SoftSkillField.Location = new System.Drawing.Point(12, 136);
      this.SoftSkillField.Multiline = true;
      this.SoftSkillField.Name = "SoftSkillField";
      this.SoftSkillField.Size = new System.Drawing.Size(608, 84);
      this.SoftSkillField.TabIndex = 21;
      this.SoftSkillField.Text = "Универсальные навыки";
      this.SoftSkillField.Click += new System.EventHandler(this.SoftSkillField_Click);
      this.SoftSkillField.TextChanged += new System.EventHandler(this.SoftSkillField_TextChanged);
      this.SoftSkillField.Leave += new System.EventHandler(this.SoftSkillField_Leave);
      // 
      // UpdateSkillsButton
      // 
      this.UpdateSkillsButton.Location = new System.Drawing.Point(161, 321);
      this.UpdateSkillsButton.Name = "UpdateSkillsButton";
      this.UpdateSkillsButton.Size = new System.Drawing.Size(147, 70);
      this.UpdateSkillsButton.TabIndex = 27;
      this.UpdateSkillsButton.Text = "Обновить существующий навык";
      this.UpdateSkillsButton.UseVisualStyleBackColor = true;
      this.UpdateSkillsButton.Click += new System.EventHandler(this.UpdateSkillsButton_Click);
      // 
      // SkillsListButton
      // 
      this.SkillsListButton.Location = new System.Drawing.Point(314, 242);
      this.SkillsListButton.Name = "SkillsListButton";
      this.SkillsListButton.Size = new System.Drawing.Size(187, 55);
      this.SkillsListButton.TabIndex = 26;
      this.SkillsListButton.Text = "Показать список образования";
      this.SkillsListButton.UseVisualStyleBackColor = true;
      this.SkillsListButton.Click += new System.EventHandler(this.SkillsListButton_Click);
      // 
      // AddSkillsButton
      // 
      this.AddSkillsButton.Location = new System.Drawing.Point(314, 322);
      this.AddSkillsButton.Name = "AddSkillsButton";
      this.AddSkillsButton.Size = new System.Drawing.Size(147, 69);
      this.AddSkillsButton.TabIndex = 25;
      this.AddSkillsButton.Text = "Сохранить как новый навык";
      this.AddSkillsButton.UseVisualStyleBackColor = true;
      this.AddSkillsButton.Click += new System.EventHandler(this.AddSkillsButton_Click);
      // 
      // NextFormButton
      // 
      this.NextFormButton.Location = new System.Drawing.Point(467, 322);
      this.NextFormButton.Name = "NextFormButton";
      this.NextFormButton.Size = new System.Drawing.Size(147, 69);
      this.NextFormButton.TabIndex = 24;
      this.NextFormButton.Text = "Далее";
      this.NextFormButton.UseVisualStyleBackColor = true;
      this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
      // 
      // ClearFieldsButton
      // 
      this.ClearFieldsButton.Location = new System.Drawing.Point(112, 242);
      this.ClearFieldsButton.Name = "ClearFieldsButton";
      this.ClearFieldsButton.Size = new System.Drawing.Size(187, 55);
      this.ClearFieldsButton.TabIndex = 23;
      this.ClearFieldsButton.Text = "Очистить поля для добавления навыков";
      this.ClearFieldsButton.UseVisualStyleBackColor = true;
      this.ClearFieldsButton.Click += new System.EventHandler(this.ClearFieldsButton_Click);
      // 
      // PreviousFormButton
      // 
      this.PreviousFormButton.Location = new System.Drawing.Point(8, 321);
      this.PreviousFormButton.Name = "PreviousFormButton";
      this.PreviousFormButton.Size = new System.Drawing.Size(147, 70);
      this.PreviousFormButton.TabIndex = 22;
      this.PreviousFormButton.Text = "Назад";
      this.PreviousFormButton.UseVisualStyleBackColor = true;
      this.PreviousFormButton.Click += new System.EventHandler(this.PreviousFormButton_Click_1);
      // 
      // SkillsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 403);
      this.Controls.Add(this.UpdateSkillsButton);
      this.Controls.Add(this.SkillsListButton);
      this.Controls.Add(this.AddSkillsButton);
      this.Controls.Add(this.NextFormButton);
      this.Controls.Add(this.ClearFieldsButton);
      this.Controls.Add(this.PreviousFormButton);
      this.Controls.Add(this.SoftSkillField);
      this.Controls.Add(this.HardSkillField);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "SkillsForm";
      this.Text = "Навыки";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SkillsForm_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox HardSkillField;
    private System.Windows.Forms.TextBox SoftSkillField;
    private System.Windows.Forms.Button UpdateSkillsButton;
    private System.Windows.Forms.Button SkillsListButton;
    private System.Windows.Forms.Button AddSkillsButton;
    private System.Windows.Forms.Button NextFormButton;
    private System.Windows.Forms.Button ClearFieldsButton;
    private System.Windows.Forms.Button PreviousFormButton;
  }
}