namespace RT3MapEditor
{
	// Token: 0x0200001D RID: 29
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CameraList : global::System.Windows.Forms.Form
	{
		// Token: 0x0600029E RID: 670 RVA: 0x001442C0 File Offset: 0x001432C0
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

		// Token: 0x0600029F RID: 671 RVA: 0x001442F8 File Offset: 0x001432F8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.CameraList));
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new global::System.Windows.Forms.Button();
			this.RichTextBox1 = new global::System.Windows.Forms.RichTextBox();
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
			this.RichTextBox1.AccessibleDescription = null;
			this.RichTextBox1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.RichTextBox1, "RichTextBox1");
			this.RichTextBox1.BackColor = global::System.Drawing.SystemColors.Control;
			this.RichTextBox1.BackgroundImage = null;
			this.RichTextBox1.Font = null;
			this.RichTextBox1.Name = "RichTextBox1";
			this.RichTextBox1.ReadOnly = true;
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.Controls.Add(this.RichTextBox1);
			this.Controls.Add(this.TableLayoutPanel1);
			this.Font = null;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CameraList";
			this.ShowInTaskbar = false;
			this.TableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x0400019C RID: 412
		private global::System.ComponentModel.IContainer components;
	}
}
