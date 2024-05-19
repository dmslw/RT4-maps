namespace RT3MapEditor
{
	// Token: 0x0200002C RID: 44
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ScreenPreview : global::System.Windows.Forms.Form
	{
		// Token: 0x06000349 RID: 841 RVA: 0x00147D30 File Offset: 0x00146D30
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00147D80 File Offset: 0x00146D80
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.ScreenPreview));
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.Close_Button = new global::System.Windows.Forms.Button();
			this.PictureBox = new global::System.Windows.Forms.PictureBox();
			this.TableLayoutPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox).BeginInit();
			this.SuspendLayout();
			this.TableLayoutPanel1.AccessibleDescription = null;
			this.TableLayoutPanel1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
			this.TableLayoutPanel1.BackgroundImage = null;
			this.TableLayoutPanel1.Controls.Add(this.Close_Button, 0, 0);
			this.TableLayoutPanel1.Font = null;
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.Close_Button.AccessibleDescription = null;
			this.Close_Button.AccessibleName = null;
			componentResourceManager.ApplyResources(this.Close_Button, "Close_Button");
			this.Close_Button.BackgroundImage = null;
			this.Close_Button.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.Close_Button.Font = null;
			this.Close_Button.Name = "Close_Button";
			this.PictureBox.AccessibleDescription = null;
			this.PictureBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.PictureBox, "PictureBox");
			this.PictureBox.BackgroundImage = null;
			this.PictureBox.Font = null;
			this.PictureBox.ImageLocation = null;
			this.PictureBox.Name = "PictureBox";
			this.PictureBox.TabStop = false;
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.CancelButton = this.Close_Button;
			this.Controls.Add(this.PictureBox);
			this.Controls.Add(this.TableLayoutPanel1);
			this.Font = null;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = null;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ScreenPreview";
			this.ShowInTaskbar = false;
			this.TableLayoutPanel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040001FA RID: 506
		private global::System.ComponentModel.IContainer components;
	}
}
