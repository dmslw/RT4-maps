namespace RT3MapEditor
{
	// Token: 0x0200002F RID: 47
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SWVersDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x0600037C RID: 892 RVA: 0x00148DAC File Offset: 0x00147DAC
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

		// Token: 0x0600037D RID: 893 RVA: 0x00148DFC File Offset: 0x00147DFC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.SWVersDialog));
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.SWVersionComboBox = new global::System.Windows.Forms.ComboBox();
			this.TableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			this.TableLayoutPanel1.AccessibleDescription = null;
			this.TableLayoutPanel1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
			this.TableLayoutPanel1.BackgroundImage = null;
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Font = null;
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.OK_Button.AccessibleDescription = null;
			this.OK_Button.AccessibleName = null;
			componentResourceManager.ApplyResources(this.OK_Button, "OK_Button");
			this.OK_Button.BackgroundImage = null;
			this.OK_Button.Font = null;
			this.OK_Button.Name = "OK_Button";
			this.Label1.AccessibleDescription = null;
			this.Label1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.Label1, "Label1");
			this.Label1.Font = null;
			this.Label1.Name = "Label1";
			this.SWVersionComboBox.AccessibleDescription = null;
			this.SWVersionComboBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.SWVersionComboBox, "SWVersionComboBox");
			this.SWVersionComboBox.BackgroundImage = null;
			this.SWVersionComboBox.Font = null;
			this.SWVersionComboBox.FormattingEnabled = true;
			this.SWVersionComboBox.Name = "SWVersionComboBox";
			this.AcceptButton = this.OK_Button;
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.Controls.Add(this.SWVersionComboBox);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TableLayoutPanel1);
			this.Font = null;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = null;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SWVersDialog";
			this.ShowInTaskbar = false;
			this.TableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000211 RID: 529
		private global::System.ComponentModel.IContainer components;
	}
}
