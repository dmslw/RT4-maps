namespace RT3MapEditor
{
	// Token: 0x02000022 RID: 34
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class dupListDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x060002CE RID: 718 RVA: 0x00144FDC File Offset: 0x00143FDC
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

		// Token: 0x060002CF RID: 719 RVA: 0x0014502C File Offset: 0x0014402C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.dupListDialog));
			this.errText = new global::System.Windows.Forms.Label();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.TableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.cancel1Button = new global::System.Windows.Forms.Button();
			this.bothButton = new global::System.Windows.Forms.Button();
			this.replaceButton = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.TableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			this.errText.AccessibleDescription = null;
			this.errText.AccessibleName = null;
			componentResourceManager.ApplyResources(this.errText, "errText");
			this.errText.Font = null;
			global::System.Windows.Forms.Control errText = this.errText;
			global::System.Drawing.Size maximumSize = new global::System.Drawing.Size(500, 0);
			errText.MaximumSize = maximumSize;
			this.errText.Name = "errText";
			this.PictureBox1.AccessibleDescription = null;
			this.PictureBox1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.PictureBox1, "PictureBox1");
			this.PictureBox1.BackgroundImage = null;
			this.PictureBox1.Font = null;
			this.PictureBox1.ImageLocation = null;
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.TabStop = false;
			this.TableLayoutPanel2.AccessibleDescription = null;
			this.TableLayoutPanel2.AccessibleName = null;
			componentResourceManager.ApplyResources(this.TableLayoutPanel2, "TableLayoutPanel2");
			this.TableLayoutPanel2.BackgroundImage = null;
			this.TableLayoutPanel2.Controls.Add(this.cancel1Button, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.bothButton, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.replaceButton, 0, 0);
			this.TableLayoutPanel2.Font = null;
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.cancel1Button.AccessibleDescription = null;
			this.cancel1Button.AccessibleName = null;
			componentResourceManager.ApplyResources(this.cancel1Button, "cancel1Button");
			this.cancel1Button.BackgroundImage = null;
			this.cancel1Button.Font = null;
			this.cancel1Button.Name = "cancel1Button";
			this.cancel1Button.Tag = "";
			this.bothButton.AccessibleDescription = null;
			this.bothButton.AccessibleName = null;
			componentResourceManager.ApplyResources(this.bothButton, "bothButton");
			this.bothButton.BackgroundImage = null;
			this.bothButton.Font = null;
			this.bothButton.Name = "bothButton";
			this.bothButton.Tag = "";
			this.replaceButton.AccessibleDescription = null;
			this.replaceButton.AccessibleName = null;
			componentResourceManager.ApplyResources(this.replaceButton, "replaceButton");
			this.replaceButton.BackgroundImage = null;
			this.replaceButton.Font = null;
			this.replaceButton.Name = "replaceButton";
			this.replaceButton.Tag = "";
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.Controls.Add(this.TableLayoutPanel2);
			this.Controls.Add(this.errText);
			this.Controls.Add(this.PictureBox1);
			this.Font = null;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "dupListDialog";
			this.ShowInTaskbar = false;
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040001BD RID: 445
		private global::System.ComponentModel.IContainer components;
	}
}
