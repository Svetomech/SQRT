namespace SQRT
{
  partial class frmMain
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
      this.txtSqrt = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // txtSqrt
      // 
      this.txtSqrt.Location = new System.Drawing.Point(0, 0);
      this.txtSqrt.Name = "txtSqrt";
      this.txtSqrt.Size = new System.Drawing.Size(100, 21);
      this.txtSqrt.TabIndex = 0;
      this.txtSqrt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSqrt_KeyPress);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(100, 21);
      this.Controls.Add(this.txtSqrt);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmMain";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Корень";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtSqrt;
  }
}

