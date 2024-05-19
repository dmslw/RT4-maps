namespace RT3MapEditor
{
	// Token: 0x02000027 RID: 39
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class NonFatalErrorBox : global::System.Windows.Forms.Form
	{
		// Token: 0x06000313 RID: 787 RVA: 0x0014675C File Offset: 0x0014575C
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

		// Token: 0x06000314 RID: 788 RVA: 0x00146794 File Offset: 0x00145794
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.NonFatalErrorBox));
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.errText = new global::System.Windows.Forms.Label();
			this.HelpProvider1 = new global::System.Windows.Forms.HelpProvider();
			this.IgnoreButton = new global::System.Windows.Forms.Button();
			this.IgnoreAllButton = new global::System.Windows.Forms.Button();
			this.AbortAllButton = new global::System.Windows.Forms.Button();
			this.AbortButton = new global::System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.TableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			this.PictureBox1.AccessibleDescription = null;
			this.PictureBox1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.PictureBox1, "PictureBox1");
			this.PictureBox1.BackgroundImage = null;
			this.PictureBox1.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.PictureBox1, null);
			this.HelpProvider1.SetHelpNavigator(this.PictureBox1, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("PictureBox1.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.PictureBox1, null);
			this.PictureBox1.ImageLocation = null;
			this.PictureBox1.Name = "PictureBox1";
			this.HelpProvider1.SetShowHelp(this.PictureBox1, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("PictureBox1.ShowHelp")));
			this.PictureBox1.TabStop = false;
			this.errText.AccessibleDescription = null;
			this.errText.AccessibleName = null;
			componentResourceManager.ApplyResources(this.errText, "errText");
			this.errText.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.errText, null);
			this.HelpProvider1.SetHelpNavigator(this.errText, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("errText.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.errText, null);
			global::System.Windows.Forms.Control errText = this.errText;
			global::System.Drawing.Size maximumSize = new global::System.Drawing.Size(500, 0);
			errText.MaximumSize = maximumSize;
			this.errText.Name = "errText";
			this.HelpProvider1.SetShowHelp(this.errText, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("errText.ShowHelp")));
			this.HelpProvider1.HelpNamespace = null;
			this.IgnoreButton.AccessibleDescription = null;
			this.IgnoreButton.AccessibleName = null;
			componentResourceManager.ApplyResources(this.IgnoreButton, "IgnoreButton");
			this.IgnoreButton.BackgroundImage = null;
			this.IgnoreButton.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.IgnoreButton, null);
			this.HelpProvider1.SetHelpNavigator(this.IgnoreButton, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("IgnoreButton.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.IgnoreButton, componentResourceManager.GetString("IgnoreButton.HelpString"));
			this.IgnoreButton.Name = "IgnoreButton";
			this.HelpProvider1.SetShowHelp(this.IgnoreButton, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("IgnoreButton.ShowHelp")));
			this.IgnoreButton.Tag = "";
			this.IgnoreAllButton.AccessibleDescription = null;
			this.IgnoreAllButton.AccessibleName = null;
			componentResourceManager.ApplyResources(this.IgnoreAllButton, "IgnoreAllButton");
			this.IgnoreAllButton.BackgroundImage = null;
			this.IgnoreAllButton.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.IgnoreAllButton, null);
			this.HelpProvider1.SetHelpNavigator(this.IgnoreAllButton, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("IgnoreAllButton.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.IgnoreAllButton, componentResourceManager.GetString("IgnoreAllButton.HelpString"));
			this.IgnoreAllButton.Name = "IgnoreAllButton";
			this.HelpProvider1.SetShowHelp(this.IgnoreAllButton, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("IgnoreAllButton.ShowHelp")));
			this.IgnoreAllButton.Tag = "";
			this.AbortAllButton.AccessibleDescription = null;
			this.AbortAllButton.AccessibleName = null;
			componentResourceManager.ApplyResources(this.AbortAllButton, "AbortAllButton");
			this.AbortAllButton.BackgroundImage = null;
			this.AbortAllButton.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.AbortAllButton, null);
			this.HelpProvider1.SetHelpNavigator(this.AbortAllButton, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("AbortAllButton.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.AbortAllButton, componentResourceManager.GetString("AbortAllButton.HelpString"));
			this.AbortAllButton.Name = "AbortAllButton";
			this.HelpProvider1.SetShowHelp(this.AbortAllButton, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("AbortAllButton.ShowHelp")));
			this.AbortAllButton.Tag = "";
			this.AbortButton.AccessibleDescription = null;
			this.AbortButton.AccessibleName = null;
			componentResourceManager.ApplyResources(this.AbortButton, "AbortButton");
			this.AbortButton.BackgroundImage = null;
			this.AbortButton.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.AbortButton, null);
			this.HelpProvider1.SetHelpNavigator(this.AbortButton, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("AbortButton.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.AbortButton, componentResourceManager.GetString("AbortButton.HelpString"));
			this.AbortButton.Name = "AbortButton";
			this.HelpProvider1.SetShowHelp(this.AbortButton, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("AbortButton.ShowHelp")));
			this.AbortButton.Tag = "";
			this.TableLayoutPanel2.AccessibleDescription = null;
			this.TableLayoutPanel2.AccessibleName = null;
			componentResourceManager.ApplyResources(this.TableLayoutPanel2, "TableLayoutPanel2");
			this.TableLayoutPanel2.BackgroundImage = null;
			this.TableLayoutPanel2.Controls.Add(this.AbortButton, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.AbortAllButton, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.IgnoreAllButton, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.IgnoreButton, 0, 0);
			this.TableLayoutPanel2.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.TableLayoutPanel2, null);
			this.HelpProvider1.SetHelpNavigator(this.TableLayoutPanel2, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("TableLayoutPanel2.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.TableLayoutPanel2, null);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.HelpProvider1.SetShowHelp(this.TableLayoutPanel2, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("TableLayoutPanel2.ShowHelp")));
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.Controls.Add(this.errText);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.TableLayoutPanel2);
			this.Font = null;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.HelpProvider1.SetHelpKeyword(this, componentResourceManager.GetString("$this.HelpKeyword"));
			this.HelpProvider1.SetHelpNavigator(this, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("$this.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this, null);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NonFatalErrorBox";
			this.HelpProvider1.SetShowHelp(this, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("$this.ShowHelp")));
			this.ShowInTaskbar = false;
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040001DE RID: 478
		private global::System.ComponentModel.IContainer components;
	}
}
