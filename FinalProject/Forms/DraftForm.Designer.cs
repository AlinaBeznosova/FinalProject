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
      this.NewResumeButton = new System.Windows.Forms.Button();
      this.ChoiseDraftButton = new System.Windows.Forms.Button();
      this.radioPanel = new System.Windows.Forms.Panel();
      this.DeleteDraftButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // NewResumeButton
      // 
      this.NewResumeButton.Location = new System.Drawing.Point(295, 241);
      this.NewResumeButton.Name = "NewResumeButton";
      this.NewResumeButton.Size = new System.Drawing.Size(148, 46);
      this.NewResumeButton.TabIndex = 1;
      this.NewResumeButton.Text = "Начать новое резюме";
      this.NewResumeButton.UseVisualStyleBackColor = true;
      this.NewResumeButton.Click += new System.EventHandler(this.NewResumeButton_Click);
      // 
      // ChoiseDraftButton
      // 
      this.ChoiseDraftButton.Location = new System.Drawing.Point(156, 241);
      this.ChoiseDraftButton.Name = "ChoiseDraftButton";
      this.ChoiseDraftButton.Size = new System.Drawing.Size(133, 46);
      this.ChoiseDraftButton.TabIndex = 4;
      this.ChoiseDraftButton.Text = "Продолжить редактирование";
      this.ChoiseDraftButton.UseVisualStyleBackColor = true;
      this.ChoiseDraftButton.Click += new System.EventHandler(this.ChoiseDraftButton_Click);
      // 
      // radioPanel
      // 
      this.radioPanel.AutoScroll = true;
      this.radioPanel.Location = new System.Drawing.Point(10, 10);
      this.radioPanel.Name = "radioPanel";
      this.radioPanel.Size = new System.Drawing.Size(433, 216);
      this.radioPanel.TabIndex = 5;
      // 
      // DeleteDraftButton
      // 
      this.DeleteDraftButton.Location = new System.Drawing.Point(10, 241);
      this.DeleteDraftButton.Name = "DeleteDraftButton";
      this.DeleteDraftButton.Size = new System.Drawing.Size(140, 46);
      this.DeleteDraftButton.TabIndex = 6;
      this.DeleteDraftButton.Text = "Удалить черновик";
      this.DeleteDraftButton.UseVisualStyleBackColor = true;
      this.DeleteDraftButton.Click += new System.EventHandler(this.DeleteDraftButton_Click);
      // 
      // DraftForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(452, 303);
      this.Controls.Add(this.DeleteDraftButton);
      this.Controls.Add(this.radioPanel);
      this.Controls.Add(this.ChoiseDraftButton);
      this.Controls.Add(this.NewResumeButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "DraftForm";
      this.Text = "Черновики";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DraftForm_FormClosed);
      this.Load += new System.EventHandler(this.DraftForm_Load);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button NewResumeButton;
    private System.Windows.Forms.Button ChoiseDraftButton;
    private System.Windows.Forms.Panel radioPanel;
    private System.Windows.Forms.Button DeleteDraftButton;
  }
}