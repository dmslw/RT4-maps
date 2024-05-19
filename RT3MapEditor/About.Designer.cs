namespace RT3MapEditor
{
	// Token: 0x0200001B RID: 27
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public sealed partial class About : global::System.Windows.Forms.Form
	{
		// Token: 0x0600025E RID: 606 RVA: 0x00142C90 File Offset: 0x00141C90
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

		// Token: 0x06000269 RID: 617 RVA: 0x00142D7C File Offset: 0x00141D7C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.About));
			this.TableLayoutPanel = new global::System.Windows.Forms.TableLayoutPanel();
			this.LabelProductName = new global::System.Windows.Forms.Label();
			this.LabelVersion = new global::System.Windows.Forms.Label();
			this.LabelCopyright = new global::System.Windows.Forms.Label();
			this.LabelCompanyName = new global::System.Windows.Forms.Label();
			this.LabelAcknowledge = new global::System.Windows.Forms.Label();
			this.OKButton = new global::System.Windows.Forms.Button();
			this.CameraButton = new global::System.Windows.Forms.Button();
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.TableLayoutPanel.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			this.TableLayoutPanel.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.TableLayoutPanel, "TableLayoutPanel");
			this.TableLayoutPanel.Controls.Add(this.LabelProductName, 0, 0);
			this.TableLayoutPanel.Controls.Add(this.LabelVersion, 0, 1);
			this.TableLayoutPanel.Controls.Add(this.LabelCopyright, 0, 2);
			this.TableLayoutPanel.Controls.Add(this.LabelCompanyName, 0, 3);
			this.TableLayoutPanel.Controls.Add(this.LabelAcknowledge, 0, 4);
			this.TableLayoutPanel.Name = "TableLayoutPanel";
			componentResourceManager.ApplyResources(this.LabelProductName, "LabelProductName");
			global::System.Windows.Forms.Control labelProductName = this.LabelProductName;
			global::System.Drawing.Size maximumSize = new global::System.Drawing.Size(0, 17);
			labelProductName.MaximumSize = maximumSize;
			this.LabelProductName.Name = "LabelProductName";
			this.LabelVersion.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.LabelVersion, "LabelVersion");
			global::System.Windows.Forms.Control labelVersion = this.LabelVersion;
			maximumSize = new global::System.Drawing.Size(0, 17);
			labelVersion.MaximumSize = maximumSize;
			this.LabelVersion.Name = "LabelVersion";
			componentResourceManager.ApplyResources(this.LabelCopyright, "LabelCopyright");
			global::System.Windows.Forms.Control labelCopyright = this.LabelCopyright;
			maximumSize = new global::System.Drawing.Size(0, 17);
			labelCopyright.MaximumSize = maximumSize;
			this.LabelCopyright.Name = "LabelCopyright";
			componentResourceManager.ApplyResources(this.LabelCompanyName, "LabelCompanyName");
			global::System.Windows.Forms.Control labelCompanyName = this.LabelCompanyName;
			maximumSize = new global::System.Drawing.Size(0, 17);
			labelCompanyName.MaximumSize = maximumSize;
			this.LabelCompanyName.Name = "LabelCompanyName";
			componentResourceManager.ApplyResources(this.LabelAcknowledge, "LabelAcknowledge");
			this.LabelAcknowledge.Name = "LabelAcknowledge";
			componentResourceManager.ApplyResources(this.OKButton, "OKButton");
			this.OKButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.OKButton.Name = "OKButton";
			componentResourceManager.ApplyResources(this.CameraButton, "CameraButton");
			this.CameraButton.Name = "CameraButton";
			this.CameraButton.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
			this.TableLayoutPanel1.Controls.Add(this.CameraButton, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.OKButton, 1, 0);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TableLayoutPanel1);
			this.Controls.Add(this.TableLayoutPanel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.ShowInTaskbar = false;
			this.TableLayoutPanel.ResumeLayout(false);
			this.TableLayoutPanel.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x04000183 RID: 387
		private global::System.ComponentModel.IContainer components;
	}
}
