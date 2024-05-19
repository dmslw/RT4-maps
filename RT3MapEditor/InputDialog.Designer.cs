namespace RT3MapEditor
{
	// Token: 0x02000025 RID: 37
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class InputDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x00145BF4 File Offset: 0x00144BF4
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

		// Token: 0x060002F3 RID: 755 RVA: 0x00145C2C File Offset: 0x00144C2C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.InputDialog));
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.YES_Button = new global::System.Windows.Forms.Button();
			this.Cancel_Button = new global::System.Windows.Forms.Button();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.warningText = new global::System.Windows.Forms.Label();
			this.MaskedTextBox1 = new global::System.Windows.Forms.MaskedTextBox();
			this.TableLayoutPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.TableLayoutPanel1.AccessibleDescription = null;
			this.TableLayoutPanel1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
			this.TableLayoutPanel1.BackgroundImage = null;
			this.TableLayoutPanel1.Controls.Add(this.YES_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			this.TableLayoutPanel1.Font = null;
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.YES_Button.AccessibleDescription = null;
			this.YES_Button.AccessibleName = null;
			componentResourceManager.ApplyResources(this.YES_Button, "YES_Button");
			this.YES_Button.BackgroundImage = null;
			this.YES_Button.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.YES_Button.Font = null;
			this.YES_Button.Name = "YES_Button";
			this.Cancel_Button.AccessibleDescription = null;
			this.Cancel_Button.AccessibleName = null;
			componentResourceManager.ApplyResources(this.Cancel_Button, "Cancel_Button");
			this.Cancel_Button.BackgroundImage = null;
			this.Cancel_Button.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_Button.Font = null;
			this.Cancel_Button.Name = "Cancel_Button";
			this.PictureBox1.AccessibleDescription = null;
			this.PictureBox1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.PictureBox1, "PictureBox1");
			this.PictureBox1.BackgroundImage = null;
			this.PictureBox1.Font = null;
			this.PictureBox1.ImageLocation = null;
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.TabStop = false;
			this.warningText.AccessibleDescription = null;
			this.warningText.AccessibleName = null;
			componentResourceManager.ApplyResources(this.warningText, "warningText");
			this.warningText.Font = null;
			this.warningText.Name = "warningText";
			this.MaskedTextBox1.AccessibleDescription = null;
			this.MaskedTextBox1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.MaskedTextBox1, "MaskedTextBox1");
			this.MaskedTextBox1.BackgroundImage = null;
			this.MaskedTextBox1.Font = null;
			this.MaskedTextBox1.Name = "MaskedTextBox1";
			this.AcceptButton = this.YES_Button;
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.CancelButton = this.Cancel_Button;
			this.ControlBox = false;
			this.Controls.Add(this.MaskedTextBox1);
			this.Controls.Add(this.warningText);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.TableLayoutPanel1);
			this.Font = null;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InputDialog";
			this.ShowInTaskbar = false;
			this.TableLayoutPanel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040001CF RID: 463
		private global::System.ComponentModel.IContainer components;
	}
}
