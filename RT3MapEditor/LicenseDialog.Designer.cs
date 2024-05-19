namespace RT3MapEditor
{
	// Token: 0x02000026 RID: 38
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class LicenseDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000303 RID: 771 RVA: 0x001461D4 File Offset: 0x001451D4
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

		// Token: 0x06000304 RID: 772 RVA: 0x00146224 File Offset: 0x00145224
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.LicenseDialog));
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new global::System.Windows.Forms.Button();
			this.Cancel_Button = new global::System.Windows.Forms.Button();
			this.LicenseRichTextBox = new global::System.Windows.Forms.RichTextBox();
			this.LicenseLabel = new global::System.Windows.Forms.Label();
			this.TableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			this.TableLayoutPanel1.AccessibleDescription = null;
			this.TableLayoutPanel1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
			this.TableLayoutPanel1.BackgroundImage = null;
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			this.TableLayoutPanel1.Font = null;
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.OK_Button.AccessibleDescription = null;
			this.OK_Button.AccessibleName = null;
			componentResourceManager.ApplyResources(this.OK_Button, "OK_Button");
			this.OK_Button.BackgroundImage = null;
			this.OK_Button.Font = null;
			this.OK_Button.Name = "OK_Button";
			this.Cancel_Button.AccessibleDescription = null;
			this.Cancel_Button.AccessibleName = null;
			componentResourceManager.ApplyResources(this.Cancel_Button, "Cancel_Button");
			this.Cancel_Button.BackgroundImage = null;
			this.Cancel_Button.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_Button.Font = null;
			this.Cancel_Button.Name = "Cancel_Button";
			this.LicenseRichTextBox.AccessibleDescription = null;
			this.LicenseRichTextBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.LicenseRichTextBox, "LicenseRichTextBox");
			this.LicenseRichTextBox.BackgroundImage = null;
			this.LicenseRichTextBox.Font = null;
			this.LicenseRichTextBox.Name = "LicenseRichTextBox";
			this.LicenseLabel.AccessibleDescription = null;
			this.LicenseLabel.AccessibleName = null;
			componentResourceManager.ApplyResources(this.LicenseLabel, "LicenseLabel");
			this.LicenseLabel.Font = null;
			this.LicenseLabel.Name = "LicenseLabel";
			this.AcceptButton = this.OK_Button;
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.CancelButton = this.Cancel_Button;
			this.Controls.Add(this.LicenseLabel);
			this.Controls.Add(this.LicenseRichTextBox);
			this.Controls.Add(this.TableLayoutPanel1);
			this.Font = null;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LicenseDialog";
			this.ShowInTaskbar = false;
			this.TableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x040001D7 RID: 471
		private global::System.ComponentModel.IContainer components;
	}
}
