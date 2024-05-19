namespace RT3MapEditor
{
	// Token: 0x02000024 RID: 36
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class FatalErrorBox : global::System.Windows.Forms.Form
	{
		// Token: 0x060002E5 RID: 741 RVA: 0x001457F0 File Offset: 0x001447F0
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00145828 File Offset: 0x00144828
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.FatalErrorBox));
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.errText = new global::System.Windows.Forms.Label();
			this.QuitButton = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.PictureBox1.AccessibleDescription = null;
			this.PictureBox1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.PictureBox1, "PictureBox1");
			this.PictureBox1.BackgroundImage = null;
			this.PictureBox1.ErrorImage = null;
			this.PictureBox1.Font = null;
			this.PictureBox1.ImageLocation = null;
			this.PictureBox1.InitialImage = null;
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.TabStop = false;
			this.errText.AccessibleDescription = null;
			this.errText.AccessibleName = null;
			componentResourceManager.ApplyResources(this.errText, "errText");
			this.errText.Font = null;
			global::System.Windows.Forms.Control errText = this.errText;
			global::System.Drawing.Size maximumSize = new global::System.Drawing.Size(500, 0);
			errText.MaximumSize = maximumSize;
			this.errText.Name = "errText";
			this.QuitButton.AccessibleDescription = null;
			this.QuitButton.AccessibleName = null;
			componentResourceManager.ApplyResources(this.QuitButton, "QuitButton");
			this.QuitButton.BackgroundImage = null;
			this.QuitButton.Font = null;
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Tag = "";
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.ControlBox = false;
			this.Controls.Add(this.QuitButton);
			this.Controls.Add(this.errText);
			this.Controls.Add(this.PictureBox1);
			this.Font = null;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FatalErrorBox";
			this.ShowInTaskbar = false;
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040001CA RID: 458
		private global::System.ComponentModel.IContainer components;
	}
}
