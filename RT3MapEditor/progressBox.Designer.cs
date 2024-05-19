namespace RT3MapEditor
{
	// Token: 0x0200002A RID: 42
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class progressBox : global::System.Windows.Forms.Form
	{
		// Token: 0x06000334 RID: 820 RVA: 0x00147688 File Offset: 0x00146688
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

		// Token: 0x06000335 RID: 821 RVA: 0x001476C0 File Offset: 0x001466C0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.progressBox));
			this.Label = new global::System.Windows.Forms.Label();
			this.SuspendLayout();
			this.Label.AccessibleDescription = null;
			this.Label.AccessibleName = null;
			componentResourceManager.ApplyResources(this.Label, "Label");
			this.Label.Font = null;
			this.Label.Name = "Label";
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.ControlBox = false;
			this.Controls.Add(this.Label);
			this.Cursor = global::System.Windows.Forms.Cursors.WaitCursor;
			this.Font = null;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "progressBox";
			this.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040001F1 RID: 497
		private global::System.ComponentModel.IContainer components;
	}
}
