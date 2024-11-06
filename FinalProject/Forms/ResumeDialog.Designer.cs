namespace FinalProject.Forms
{
  partial class ResumeDialog
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
      this.OpenDraftButton = new System.Windows.Forms.Button();
      this.NewResumeButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // OpenDraftButton
      // 
      this.OpenDraftButton.Location = new System.Drawing.Point(26, 21);
      this.OpenDraftButton.Name = "OpenDraftButton";
      this.OpenDraftButton.Size = new System.Drawing.Size(259, 35);
      this.OpenDraftButton.TabIndex = 0;
      this.OpenDraftButton.Text = "Открыть черновик";
      this.OpenDraftButton.UseVisualStyleBackColor = true;
      this.OpenDraftButton.Click += new System.EventHandler(this.OpenDraftButton_Click);
      // 
      // NewResumeButton
      // 
      this.NewResumeButton.Location = new System.Drawing.Point(26, 62);
      this.NewResumeButton.Name = "NewResumeButton";
      this.NewResumeButton.Size = new System.Drawing.Size(259, 35);
      this.NewResumeButton.TabIndex = 1;
      this.NewResumeButton.Text = "Начать новое резюме";
      this.NewResumeButton.UseVisualStyleBackColor = true;
      this.NewResumeButton.Click += new System.EventHandler(this.NewResumeButton_Click);
      // 
      // ResumeDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(316, 119);
      this.Controls.Add(this.NewResumeButton);
      this.Controls.Add(this.OpenDraftButton);
      this.Name = "ResumeDialog";
      this.Text = "Выберите действие";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResumeDialog_FormClosed);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button OpenDraftButton;
    private System.Windows.Forms.Button NewResumeButton;
  }
}