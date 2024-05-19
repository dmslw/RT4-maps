namespace RT3MapEditor
{
	// Token: 0x02000013 RID: 19
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class BootScreenFramingDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000217 RID: 535 RVA: 0x001414C4 File Offset: 0x001404C4
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

		// Token: 0x06000218 RID: 536 RVA: 0x00141514 File Offset: 0x00140514
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.BootScreenFramingDialog));
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.Cancel_Button = new global::System.Windows.Forms.Button();
			this.OK_Button = new global::System.Windows.Forms.Button();
			this.PictureBox = new global::System.Windows.Forms.PictureBox();
			this.Stretch_Button = new global::System.Windows.Forms.Button();
			this.Center_Button = new global::System.Windows.Forms.Button();
			this.Crop_Button = new global::System.Windows.Forms.Button();
			this.Label = new global::System.Windows.Forms.Label();
			this.bkgColor_Button = new global::System.Windows.Forms.Button();
			this.Zoom_TrackBar = new global::System.Windows.Forms.TrackBar();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.TableLayoutPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Zoom_TrackBar).BeginInit();
			this.SuspendLayout();
			componentResourceManager.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 1, 0);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			componentResourceManager.ApplyResources(this.Cancel_Button, "Cancel_Button");
			this.Cancel_Button.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_Button.Name = "Cancel_Button";
			componentResourceManager.ApplyResources(this.OK_Button, "OK_Button");
			this.OK_Button.Name = "OK_Button";
			this.PictureBox.BackColor = global::System.Drawing.Color.Black;
			this.PictureBox.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			componentResourceManager.ApplyResources(this.PictureBox, "PictureBox");
			this.PictureBox.Name = "PictureBox";
			this.PictureBox.TabStop = false;
			this.Stretch_Button.BackgroundImage = global::RT3MapEditor.My.Resources.Resources.etirer1;
			componentResourceManager.ApplyResources(this.Stretch_Button, "Stretch_Button");
			this.Stretch_Button.Name = "Stretch_Button";
			this.Stretch_Button.UseVisualStyleBackColor = true;
			this.Center_Button.BackgroundImage = global::RT3MapEditor.My.Resources.Resources.centrer1;
			componentResourceManager.ApplyResources(this.Center_Button, "Center_Button");
			this.Center_Button.Name = "Center_Button";
			this.Center_Button.UseVisualStyleBackColor = true;
			this.Crop_Button.BackgroundImage = global::RT3MapEditor.My.Resources.Resources.recadrer1;
			componentResourceManager.ApplyResources(this.Crop_Button, "Crop_Button");
			this.Crop_Button.Name = "Crop_Button";
			this.Crop_Button.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.Label, "Label");
			this.Label.Name = "Label";
			this.bkgColor_Button.BackgroundImage = global::RT3MapEditor.My.Resources.Resources.color;
			componentResourceManager.ApplyResources(this.bkgColor_Button, "bkgColor_Button");
			this.bkgColor_Button.Name = "bkgColor_Button";
			this.bkgColor_Button.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.Zoom_TrackBar, "Zoom_TrackBar");
			this.Zoom_TrackBar.Name = "Zoom_TrackBar";
			componentResourceManager.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			componentResourceManager.ApplyResources(this.Label2, "Label2");
			this.Label2.Name = "Label2";
			this.AcceptButton = this.OK_Button;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_Button;
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Zoom_TrackBar);
			this.Controls.Add(this.bkgColor_Button);
			this.Controls.Add(this.Label);
			this.Controls.Add(this.Crop_Button);
			this.Controls.Add(this.Center_Button);
			this.Controls.Add(this.Stretch_Button);
			this.Controls.Add(this.PictureBox);
			this.Controls.Add(this.TableLayoutPanel1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BootScreenFramingDialog";
			this.ShowInTaskbar = false;
			this.TableLayoutPanel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Zoom_TrackBar).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000137 RID: 311
		private global::System.ComponentModel.IContainer components;
	}
}
