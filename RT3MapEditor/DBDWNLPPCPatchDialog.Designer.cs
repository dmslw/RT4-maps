namespace RT3MapEditor
{
	// Token: 0x0200003B RID: 59
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class DBDWNLPPCPatchDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x060006AD RID: 1709 RVA: 0x00159CB4 File Offset: 0x00158CB4
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

		// Token: 0x060006AE RID: 1710 RVA: 0x00159D04 File Offset: 0x00158D04
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.DBDWNLPPCPatchDialog));
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new global::System.Windows.Forms.Button();
			this.Cancel_Button = new global::System.Windows.Forms.Button();
			this.DriveListView = new global::System.Windows.Forms.ListView();
			this.Refresh_Button = new global::System.Windows.Forms.Button();
			this.USBGroupBox = new global::System.Windows.Forms.GroupBox();
			this.USB_RadioButton = new global::System.Windows.Forms.RadioButton();
			this.CD_ROM_RadioButton = new global::System.Windows.Forms.RadioButton();
			this.HelpProvider1 = new global::System.Windows.Forms.HelpProvider();
			this.TableLayoutPanel1.SuspendLayout();
			this.USBGroupBox.SuspendLayout();
			this.SuspendLayout();
			this.TableLayoutPanel1.AccessibleDescription = null;
			this.TableLayoutPanel1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
			this.TableLayoutPanel1.BackgroundImage = null;
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			this.TableLayoutPanel1.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.TableLayoutPanel1, null);
			this.HelpProvider1.SetHelpNavigator(this.TableLayoutPanel1, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("TableLayoutPanel1.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.TableLayoutPanel1, null);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.HelpProvider1.SetShowHelp(this.TableLayoutPanel1, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("TableLayoutPanel1.ShowHelp")));
			this.OK_Button.AccessibleDescription = null;
			this.OK_Button.AccessibleName = null;
			componentResourceManager.ApplyResources(this.OK_Button, "OK_Button");
			this.OK_Button.BackgroundImage = null;
			this.OK_Button.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.OK_Button, null);
			this.HelpProvider1.SetHelpNavigator(this.OK_Button, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("OK_Button.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.OK_Button, null);
			this.OK_Button.Name = "OK_Button";
			this.HelpProvider1.SetShowHelp(this.OK_Button, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("OK_Button.ShowHelp")));
			this.Cancel_Button.AccessibleDescription = null;
			this.Cancel_Button.AccessibleName = null;
			componentResourceManager.ApplyResources(this.Cancel_Button, "Cancel_Button");
			this.Cancel_Button.BackgroundImage = null;
			this.Cancel_Button.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_Button.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.Cancel_Button, null);
			this.HelpProvider1.SetHelpNavigator(this.Cancel_Button, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("Cancel_Button.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.Cancel_Button, null);
			this.Cancel_Button.Name = "Cancel_Button";
			this.HelpProvider1.SetShowHelp(this.Cancel_Button, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("Cancel_Button.ShowHelp")));
			this.DriveListView.AccessibleDescription = null;
			this.DriveListView.AccessibleName = null;
			componentResourceManager.ApplyResources(this.DriveListView, "DriveListView");
			this.DriveListView.BackgroundImage = null;
			this.DriveListView.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.DriveListView, null);
			this.HelpProvider1.SetHelpNavigator(this.DriveListView, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("DriveListView.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.DriveListView, null);
			this.DriveListView.Name = "DriveListView";
			this.HelpProvider1.SetShowHelp(this.DriveListView, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("DriveListView.ShowHelp")));
			this.DriveListView.UseCompatibleStateImageBehavior = false;
			this.Refresh_Button.AccessibleDescription = null;
			this.Refresh_Button.AccessibleName = null;
			componentResourceManager.ApplyResources(this.Refresh_Button, "Refresh_Button");
			this.Refresh_Button.BackgroundImage = null;
			this.Refresh_Button.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.Refresh_Button, null);
			this.HelpProvider1.SetHelpNavigator(this.Refresh_Button, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("Refresh_Button.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.Refresh_Button, null);
			this.Refresh_Button.Name = "Refresh_Button";
			this.HelpProvider1.SetShowHelp(this.Refresh_Button, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("Refresh_Button.ShowHelp")));
			this.Refresh_Button.UseVisualStyleBackColor = true;
			this.USBGroupBox.AccessibleDescription = null;
			this.USBGroupBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.USBGroupBox, "USBGroupBox");
			this.USBGroupBox.BackgroundImage = null;
			this.USBGroupBox.Controls.Add(this.USB_RadioButton);
			this.USBGroupBox.Controls.Add(this.CD_ROM_RadioButton);
			this.USBGroupBox.Controls.Add(this.DriveListView);
			this.USBGroupBox.Controls.Add(this.Refresh_Button);
			this.USBGroupBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.USBGroupBox, null);
			this.HelpProvider1.SetHelpNavigator(this.USBGroupBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("USBGroupBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.USBGroupBox, null);
			this.USBGroupBox.Name = "USBGroupBox";
			this.HelpProvider1.SetShowHelp(this.USBGroupBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("USBGroupBox.ShowHelp")));
			this.USBGroupBox.TabStop = false;
			this.USB_RadioButton.AccessibleDescription = null;
			this.USB_RadioButton.AccessibleName = null;
			componentResourceManager.ApplyResources(this.USB_RadioButton, "USB_RadioButton");
			this.USB_RadioButton.BackgroundImage = null;
			this.USB_RadioButton.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.USB_RadioButton, null);
			this.HelpProvider1.SetHelpNavigator(this.USB_RadioButton, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("USB_RadioButton.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.USB_RadioButton, null);
			this.USB_RadioButton.Name = "USB_RadioButton";
			this.HelpProvider1.SetShowHelp(this.USB_RadioButton, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("USB_RadioButton.ShowHelp")));
			this.USB_RadioButton.TabStop = true;
			this.USB_RadioButton.UseVisualStyleBackColor = true;
			this.CD_ROM_RadioButton.AccessibleDescription = null;
			this.CD_ROM_RadioButton.AccessibleName = null;
			componentResourceManager.ApplyResources(this.CD_ROM_RadioButton, "CD_ROM_RadioButton");
			this.CD_ROM_RadioButton.BackgroundImage = null;
			this.CD_ROM_RadioButton.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.CD_ROM_RadioButton, null);
			this.HelpProvider1.SetHelpNavigator(this.CD_ROM_RadioButton, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("CD_ROM_RadioButton.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.CD_ROM_RadioButton, null);
			this.CD_ROM_RadioButton.Name = "CD_ROM_RadioButton";
			this.HelpProvider1.SetShowHelp(this.CD_ROM_RadioButton, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("CD_ROM_RadioButton.ShowHelp")));
			this.CD_ROM_RadioButton.TabStop = true;
			this.CD_ROM_RadioButton.UseVisualStyleBackColor = true;
			this.HelpProvider1.HelpNamespace = null;
			this.AcceptButton = this.OK_Button;
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.CancelButton = this.Cancel_Button;
			this.Controls.Add(this.USBGroupBox);
			this.Controls.Add(this.TableLayoutPanel1);
			this.Font = null;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.HelpProvider1.SetHelpKeyword(this, null);
			this.HelpProvider1.SetHelpNavigator(this, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("$this.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this, null);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DBDWNLPPCPatchDialog";
			this.HelpProvider1.SetShowHelp(this, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("$this.ShowHelp")));
			this.ShowInTaskbar = false;
			this.TableLayoutPanel1.ResumeLayout(false);
			this.USBGroupBox.ResumeLayout(false);
			this.USBGroupBox.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040003C8 RID: 968
		private global::System.ComponentModel.IContainer components;
	}
}
