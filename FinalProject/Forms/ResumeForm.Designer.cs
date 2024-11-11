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
      this.Template1RadioButton.Location = new System.Drawing.Point(99, 100);
      this.Template1RadioButton.Name = "Template1RadioButton";
      this.Template1RadioButton.Size = new System.Drawing.Size(86, 20);
      this.Template1RadioButton.TabIndex = 0;
      this.Template1RadioButton.TabStop = true;
      this.Template1RadioButton.Text = "Шаблон1";
      this.Template1RadioButton.UseVisualStyleBackColor = true;
      // 
      // ShowTemplatePDFButton
      // 
      this.ShowTemplatePDFButton.Location = new System.Drawing.Point(54, 323);
      this.ShowTemplatePDFButton.Name = "ShowTemplatePDFButton";
      this.ShowTemplatePDFButton.Size = new System.Drawing.Size(177, 51);
      this.ShowTemplatePDFButton.TabIndex = 1;
      this.ShowTemplatePDFButton.Text = "Показать шаблон pdf";
      this.ShowTemplatePDFButton.UseVisualStyleBackColor = true;
      this.ShowTemplatePDFButton.Click += new System.EventHandler(this.ShowTemplateButton_Click);
      // 
      // ShowTemplateDOCButton
      // 
      this.ShowTemplateDOCButton.Location = new System.Drawing.Point(54, 387);
      this.ShowTemplateDOCButton.Name = "ShowTemplateDOCButton";
      this.ShowTemplateDOCButton.Size = new System.Drawing.Size(177, 51);
      this.ShowTemplateDOCButton.TabIndex = 2;
      this.ShowTemplateDOCButton.Text = "Показать шаблон doc";
      this.ShowTemplateDOCButton.UseVisualStyleBackColor = true;
      this.ShowTemplateDOCButton.Click += new System.EventHandler(this.ShowTemplateDOCButton_Click);
      // 
      // CreateResumePDFButton
      // 
      this.CreateResumePDFButton.Location = new System.Drawing.Point(312, 323);
      this.CreateResumePDFButton.Name = "CreateResumePDFButton";
      this.CreateResumePDFButton.Size = new System.Drawing.Size(177, 51);
      this.CreateResumePDFButton.TabIndex = 3;
      this.CreateResumePDFButton.Text = "Создать резюме pdf";
      this.CreateResumePDFButton.UseVisualStyleBackColor = true;
      this.CreateResumePDFButton.Click += new System.EventHandler(this.CreateResumePDFButton_Click);
      // 
      // CreateResumeDOCButton
      // 
      this.CreateResumeDOCButton.Location = new System.Drawing.Point(312, 387);
      this.CreateResumeDOCButton.Name = "CreateResumeDOCButton";
      this.CreateResumeDOCButton.Size = new System.Drawing.Size(177, 51);
      this.CreateResumeDOCButton.TabIndex = 4;
      this.CreateResumeDOCButton.Text = "Создать резюме doc";
      this.CreateResumeDOCButton.UseVisualStyleBackColor = true;
      this.CreateResumeDOCButton.Click += new System.EventHandler(this.CreateResumeDOCButton_Click);
      // 
      // Template3RadioButton
      // 
      this.Template3RadioButton.AutoSize = true;
      this.Template3RadioButton.Location = new System.Drawing.Point(99, 197);
      this.Template3RadioButton.Name = "Template3RadioButton";
      this.Template3RadioButton.Size = new System.Drawing.Size(86, 20);
      this.Template3RadioButton.TabIndex = 5;
      this.Template3RadioButton.TabStop = true;
      this.Template3RadioButton.Text = "Шаблон3";
      this.Template3RadioButton.UseVisualStyleBackColor = true;
      // 
      // Template2RadioButton
      // 
      this.Template2RadioButton.AutoSize = true;
      this.Template2RadioButton.Location = new System.Drawing.Point(99, 146);
      this.Template2RadioButton.Name = "Template2RadioButton";
      this.Template2RadioButton.Size = new System.Drawing.Size(86, 20);
      this.Template2RadioButton.TabIndex = 6;
      this.Template2RadioButton.TabStop = true;
      this.Template2RadioButton.Text = "Шаблон2";
      this.Template2RadioButton.UseVisualStyleBackColor = true;
      // 
      // ResumeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.Template2RadioButton);
      this.Controls.Add(this.Template3RadioButton);
      this.Controls.Add(this.CreateResumeDOCButton);
      this.Controls.Add(this.CreateResumePDFButton);
      this.Controls.Add(this.ShowTemplateDOCButton);
      this.Controls.Add(this.ShowTemplatePDFButton);
      this.Controls.Add(this.Template1RadioButton);
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