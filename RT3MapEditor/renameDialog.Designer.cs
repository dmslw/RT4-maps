namespace RT3MapEditor
{
	// Token: 0x0200002B RID: 43
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class renameDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000339 RID: 825 RVA: 0x00147808 File Offset: 0x00146808
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				bool flag = this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00147994 File Offset: 0x00146994
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.renameDialog));
			this.Label = new global::System.Windows.Forms.Label();
			this.NameTextBox = new global::System.Windows.Forms.TextBox();
			this.OK = new global::System.Windows.Forms.Button();
			this.Cancel = new global::System.Windows.Forms.Button();
			this.SuspendLayout();
			this.Label.AccessibleDescription = null;
			this.Label.AccessibleName = null;
			componentResourceManager.ApplyResources(this.Label, "Label");
			this.Label.Font = null;
			this.Label.Name = "Label";
			this.NameTextBox.AccessibleDescription = null;
			this.NameTextBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.NameTextBox, "NameTextBox");
			this.NameTextBox.BackgroundImage = null;
			this.NameTextBox.Font = null;
			this.NameTextBox.Name = "NameTextBox";
			this.OK.AccessibleDescription = null;
			this.OK.AccessibleName = null;
			componentResourceManager.ApplyResources(this.OK, "OK");
			this.OK.BackgroundImage = null;
			this.OK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.OK.Font = null;
			this.OK.Name = "OK";
			this.Cancel.AccessibleDescription = null;
			this.Cancel.AccessibleName = null;
			componentResourceManager.ApplyResources(this.Cancel, "Cancel");
			this.Cancel.BackgroundImage = null;
			this.Cancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Font = null;
			this.Cancel.Name = "Cancel";
			this.AcceptButton = this.OK;
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.CancelButton = this.Cancel;
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.Label);
			this.Font = null;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "renameDialog";
			this.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040001F8 RID: 504
		private global::System.ComponentModel.IContainer components;
	}
}
