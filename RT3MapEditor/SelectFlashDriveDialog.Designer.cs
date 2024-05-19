namespace RT3MapEditor
{
	// Token: 0x0200002E RID: 46
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SelectFlashDriveDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000365 RID: 869 RVA: 0x00148768 File Offset: 0x00147768
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

		// Token: 0x06000366 RID: 870 RVA: 0x001487B8 File Offset: 0x001477B8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.SelectFlashDriveDialog));
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.Cancel_Button = new global::System.Windows.Forms.Button();
			this.Refresh_Button = new global::System.Windows.Forms.Button();
			this.OK_Button = new global::System.Windows.Forms.Button();
			this.Label = new global::System.Windows.Forms.Label();
			this.DriveListView = new global::System.Windows.Forms.ListView();
			this.TableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			componentResourceManager.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.Refresh_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 1, 0);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			componentResourceManager.ApplyResources(this.Cancel_Button, "Cancel_Button");
			this.Cancel_Button.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_Button.Name = "Cancel_Button";
			componentResourceManager.ApplyResources(this.Refresh_Button, "Refresh_Button");
			this.Refresh_Button.Name = "Refresh_Button";
			this.Refresh_Button.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.OK_Button, "OK_Button");
			this.OK_Button.Name = "OK_Button";
			componentResourceManager.ApplyResources(this.Label, "Label");
			this.Label.Name = "Label";
			this.DriveListView.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
			componentResourceManager.ApplyResources(this.DriveListView, "DriveListView");
			this.DriveListView.MultiSelect = false;
			this.DriveListView.Name = "DriveListView";
			this.DriveListView.UseCompatibleStateImageBehavior = false;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.DriveListView);
			this.Controls.Add(this.Label);
			this.Controls.Add(this.TableLayoutPanel1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectFlashDriveDialog";
			this.ShowInTaskbar = false;
			this.TableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000207 RID: 519
		private global::System.ComponentModel.IContainer components;
	}
}
