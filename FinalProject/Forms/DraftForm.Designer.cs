namespace FinalProject.Forms
{
  partial class DraftForm
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
      this.DraftField = new System.Windows.Forms.RichTextBox();
      this.NewResumeButton = new System.Windows.Forms.Button();
      this.DraftChoiseField = new System.Windows.Forms.TextBox();
      this.WhatDraftLabel = new System.Windows.Forms.Label();
      this.ChoiseDraftButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // DraftField
      // 
      this.DraftField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.DraftField.Location = new System.Drawing.Point(55, 33);
      this.DraftField.Name = "DraftField";
      this.DraftField.ReadOnly = true;
      this.DraftField.Size = new System.Drawing.Size(482, 162);
      this.DraftField.TabIndex = 0;
      this.DraftField.Text = "";
      // 
      // NewResumeButton
      // 
      this.NewResumeButton.Location = new System.Drawing.Point(318, 312);
      this.NewResumeButton.Name = "NewResumeButton";
      this.NewResumeButton.Size = new System.Drawing.Size(219, 46);
      this.NewResumeButton.TabIndex = 1;
      this.NewResumeButton.Text = "Начать новое резюме";
      this.NewResumeButton.UseVisualStyleBackColor = true;
      this.NewResumeButton.Click += new System.EventHandler(this.NewResumeButton_Click);
      // 
      // DraftChoiseField
      // 
      this.DraftChoiseField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.DraftChoiseField.Location = new System.Drawing.Point(61, 238);
      this.DraftChoiseField.Multiline = true;
      this.DraftChoiseField.Name = "DraftChoiseField";
      this.DraftChoiseField.Size = new System.Drawing.Size(476, 49);
      this.DraftChoiseField.TabIndex = 2;
      this.DraftChoiseField.Text = "Введите ФИО";
      this.DraftChoiseField.Click += new System.EventHandler(this.DraftChoiseField_Click);
      this.DraftChoiseField.TextChanged += new System.EventHandler(this.DraftChoiseField_TextChanged);
      this.DraftChoiseField.Leave += new System.EventHandler(this.DraftChoiseField_Leave);
      // 
      // WhatDraftLabel
      // 
      this.WhatDraftLabel.AutoSize = true;
      this.WhatDraftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.WhatDraftLabel.Location = new System.Drawing.Point(62, 204);
      this.WhatDraftLabel.Name = "WhatDraftLabel";
      this.WhatDraftLabel.Size = new System.Drawing.Size(470, 20);
      this.WhatDraftLabel.TabIndex = 3;
      this.WhatDraftLabel.Text = "Какой черновик хотите продолжить редактрировать?";
      // 
      // ChoiseDraftButton
      // 
      this.ChoiseDraftButton.Location = new System.Drawing.Point(61, 312);
      this.ChoiseDraftButton.Name = "ChoiseDraftButton";
      this.ChoiseDraftButton.Size = new System.Drawing.Size(220, 46);
      this.ChoiseDraftButton.TabIndex = 4;
      this.ChoiseDraftButton.Text = "Продолжить редактирование";
      this.ChoiseDraftButton.UseVisualStyleBackColor = true;
      this.ChoiseDraftButton.Click += new System.EventHandler(this.ChoiseDraftButton_Click);
      // 
      // DraftForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(590, 392);
      this.Controls.Add(this.ChoiseDraftButton);
      this.Controls.Add(this.WhatDraftLabel);
      this.Controls.Add(this.DraftChoiseField);
      this.Controls.Add(this.NewResumeButton);
      this.Controls.Add(this.DraftField);
      this.Name = "DraftForm";
      this.Text = "Черновики";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DraftForm_FormClosed);
      this.Load += new System.EventHandler(this.DraftForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox DraftField;
    private System.Windows.Forms.Button NewResumeButton;
    private System.Windows.Forms.TextBox DraftChoiseField;
    private System.Windows.Forms.Label WhatDraftLabel;
    private System.Windows.Forms.Button ChoiseDraftButton;
  }
}