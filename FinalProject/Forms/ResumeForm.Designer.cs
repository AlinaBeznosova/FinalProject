namespace FinalProject.Forms
{
  partial class ResumeForm
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
      this.Template1RadioButton = new System.Windows.Forms.RadioButton();
      this.ShowTemplatePDFButton = new System.Windows.Forms.Button();
      this.ShowTemplateDOCButton = new System.Windows.Forms.Button();
      this.CreateResumePDFButton = new System.Windows.Forms.Button();
      this.CreateResumeDOCButton = new System.Windows.Forms.Button();
      this.Template3RadioButton = new System.Windows.Forms.RadioButton();
      this.Template2RadioButton = new System.Windows.Forms.RadioButton();
      this.SuspendLayout();
      // 
      // Template1RadioButton
      // 
      this.Template1RadioButton.AutoSize = true;
      this.Template1RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Template1RadioButton.Location = new System.Drawing.Point(28, 38);
      this.Template1RadioButton.Name = "Template1RadioButton";
      this.Template1RadioButton.Size = new System.Drawing.Size(193, 29);
      this.Template1RadioButton.TabIndex = 0;
      this.Template1RadioButton.TabStop = true;
      this.Template1RadioButton.Text = "1. В одну колонку";
      this.Template1RadioButton.UseVisualStyleBackColor = true;
      // 
      // ShowTemplatePDFButton
      // 
      this.ShowTemplatePDFButton.Location = new System.Drawing.Point(12, 204);
      this.ShowTemplatePDFButton.Name = "ShowTemplatePDFButton";
      this.ShowTemplatePDFButton.Size = new System.Drawing.Size(177, 51);
      this.ShowTemplatePDFButton.TabIndex = 1;
      this.ShowTemplatePDFButton.Text = "Показать шаблон .pdf";
      this.ShowTemplatePDFButton.UseVisualStyleBackColor = true;
      this.ShowTemplatePDFButton.Click += new System.EventHandler(this.ShowTemplateButton_Click);
      // 
      // ShowTemplateDOCButton
      // 
      this.ShowTemplateDOCButton.Location = new System.Drawing.Point(12, 261);
      this.ShowTemplateDOCButton.Name = "ShowTemplateDOCButton";
      this.ShowTemplateDOCButton.Size = new System.Drawing.Size(177, 51);
      this.ShowTemplateDOCButton.TabIndex = 2;
      this.ShowTemplateDOCButton.Text = "Показать шаблон .docx";
      this.ShowTemplateDOCButton.UseVisualStyleBackColor = true;
      this.ShowTemplateDOCButton.Click += new System.EventHandler(this.ShowTemplateDOCButton_Click);
      // 
      // CreateResumePDFButton
      // 
      this.CreateResumePDFButton.Location = new System.Drawing.Point(204, 204);
      this.CreateResumePDFButton.Name = "CreateResumePDFButton";
      this.CreateResumePDFButton.Size = new System.Drawing.Size(177, 51);
      this.CreateResumePDFButton.TabIndex = 3;
      this.CreateResumePDFButton.Text = "Создать резюме .pdf";
      this.CreateResumePDFButton.UseVisualStyleBackColor = true;
      this.CreateResumePDFButton.Click += new System.EventHandler(this.CreateResumePDFButton_Click);
      // 
      // CreateResumeDOCButton
      // 
      this.CreateResumeDOCButton.Location = new System.Drawing.Point(204, 261);
      this.CreateResumeDOCButton.Name = "CreateResumeDOCButton";
      this.CreateResumeDOCButton.Size = new System.Drawing.Size(177, 51);
      this.CreateResumeDOCButton.TabIndex = 4;
      this.CreateResumeDOCButton.Text = "Создать резюме .docx";
      this.CreateResumeDOCButton.UseVisualStyleBackColor = true;
      this.CreateResumeDOCButton.Click += new System.EventHandler(this.CreateResumeDOCButton_Click);
      // 
      // Template3RadioButton
      // 
      this.Template3RadioButton.AutoSize = true;
      this.Template3RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Template3RadioButton.Location = new System.Drawing.Point(28, 135);
      this.Template3RadioButton.Name = "Template3RadioButton";
      this.Template3RadioButton.Size = new System.Drawing.Size(186, 29);
      this.Template3RadioButton.TabIndex = 5;
      this.Template3RadioButton.TabStop = true;
      this.Template3RadioButton.Text = "3. В три колонки";
      this.Template3RadioButton.UseVisualStyleBackColor = true;
      // 
      // Template2RadioButton
      // 
      this.Template2RadioButton.AutoSize = true;
      this.Template2RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Template2RadioButton.Location = new System.Drawing.Point(28, 84);
      this.Template2RadioButton.Name = "Template2RadioButton";
      this.Template2RadioButton.Size = new System.Drawing.Size(185, 29);
      this.Template2RadioButton.TabIndex = 6;
      this.Template2RadioButton.TabStop = true;
      this.Template2RadioButton.Text = "2. В две колонки";
      this.Template2RadioButton.UseVisualStyleBackColor = true;
      // 
      // ResumeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(400, 348);
      this.Controls.Add(this.Template2RadioButton);
      this.Controls.Add(this.Template3RadioButton);
      this.Controls.Add(this.CreateResumeDOCButton);
      this.Controls.Add(this.CreateResumePDFButton);
      this.Controls.Add(this.ShowTemplateDOCButton);
      this.Controls.Add(this.ShowTemplatePDFButton);
      this.Controls.Add(this.Template1RadioButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "ResumeForm";
      this.Text = "Шаблон резюме";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResumeForm_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RadioButton Template1RadioButton;
    private System.Windows.Forms.Button ShowTemplatePDFButton;
    private System.Windows.Forms.Button ShowTemplateDOCButton;
    private System.Windows.Forms.Button CreateResumePDFButton;
    private System.Windows.Forms.Button CreateResumeDOCButton;
    private System.Windows.Forms.RadioButton Template3RadioButton;
    private System.Windows.Forms.RadioButton Template2RadioButton;
  }
}