namespace RT3MapEditor
{
	// Token: 0x0200002D RID: 45
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class selectCIDDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000354 RID: 852 RVA: 0x001480E8 File Offset: 0x001470E8
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

		// Token: 0x06000355 RID: 853 RVA: 0x00148138 File Offset: 0x00147138
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.selectCIDDialog));
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new global::System.Windows.Forms.Button();
			this.Cancel_Button = new global::System.Windows.Forms.Button();
			this.ComboBox = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
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
			this.ComboBox.AccessibleDescription = null;
			this.ComboBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.ComboBox, "ComboBox");
			this.ComboBox.BackgroundImage = null;
			this.ComboBox.Font = null;
			this.ComboBox.FormattingEnabled = true;
			this.ComboBox.Name = "ComboBox";
			this.Label1.AccessibleDescription = null;
			this.Label1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.Label1, "Label1");
			this.Label1.Font = null;
			this.Label1.Name = "Label1";
			this.AcceptButton = this.OK_Button;
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.CancelButton = this.Cancel_Button;
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.ComboBox);
			this.Controls.Add(this.TableLayoutPanel1);
			this.Font = null;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "selectCIDDialog";
			this.ShowInTaskbar = false;
			this.TableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040001FF RID: 511
		private global::System.ComponentModel.IContainer components;
	}
}
