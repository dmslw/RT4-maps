﻿namespace RT3MapEditor
{
	// Token: 0x02000041 RID: 65
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class USBMapDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x0015BE50 File Offset: 0x0015AE50
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

		// Token: 0x0600070F RID: 1807 RVA: 0x0015BEA0 File Offset: 0x0015AEA0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.USBMapDialog));
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new global::System.Windows.Forms.Button();
			this.Cancel_Button = new global::System.Windows.Forms.Button();
			this.DriveListView = new global::System.Windows.Forms.ListView();
			this.Refresh_Button = new global::System.Windows.Forms.Button();
			this.ItalyCheckBox = new global::System.Windows.Forms.CheckBox();
			this.FranceCheckBox = new global::System.Windows.Forms.CheckBox();
			this.SPCheckBox = new global::System.Windows.Forms.CheckBox();
			this.BeneluxCheckBox = new global::System.Windows.Forms.CheckBox();
			this.UKCheckBox = new global::System.Windows.Forms.CheckBox();
			this.ScanCheckBox = new global::System.Windows.Forms.CheckBox();
			this.GermanyCheckBox = new global::System.Windows.Forms.CheckBox();
			this.MECheckBox = new global::System.Windows.Forms.CheckBox();
			this.EESCheckBox = new global::System.Windows.Forms.CheckBox();
			this.EENECheckBox = new global::System.Windows.Forms.CheckBox();
			this.EENWCheckBox = new global::System.Windows.Forms.CheckBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.SizeLabel = new global::System.Windows.Forms.Label();
			this.USBGroupBox = new global::System.Windows.Forms.GroupBox();
			this.CIDGroupBox = new global::System.Windows.Forms.GroupBox();
			this.DurLabel = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.HelpProvider1 = new global::System.Windows.Forms.HelpProvider();
			this.OptionGroupBox = new global::System.Windows.Forms.GroupBox();
			this.CRCCheckBox = new global::System.Windows.Forms.CheckBox();
			this.DebugCheckBox = new global::System.Windows.Forms.CheckBox();
			this.FastCheckBox = new global::System.Windows.Forms.CheckBox();
			this.TableLayoutPanel1.SuspendLayout();
			this.USBGroupBox.SuspendLayout();
			this.CIDGroupBox.SuspendLayout();
			this.OptionGroupBox.SuspendLayout();
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
			this.ItalyCheckBox.AccessibleDescription = null;
			this.ItalyCheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.ItalyCheckBox, "ItalyCheckBox");
			this.ItalyCheckBox.BackgroundImage = null;
			this.ItalyCheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.ItalyCheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.ItalyCheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("ItalyCheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.ItalyCheckBox, componentResourceManager.GetString("ItalyCheckBox.HelpString"));
			this.ItalyCheckBox.Name = "ItalyCheckBox";
			this.HelpProvider1.SetShowHelp(this.ItalyCheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("ItalyCheckBox.ShowHelp")));
			this.ItalyCheckBox.UseVisualStyleBackColor = true;
			this.FranceCheckBox.AccessibleDescription = null;
			this.FranceCheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.FranceCheckBox, "FranceCheckBox");
			this.FranceCheckBox.BackgroundImage = null;
			this.FranceCheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.FranceCheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.FranceCheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("FranceCheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.FranceCheckBox, componentResourceManager.GetString("FranceCheckBox.HelpString"));
			this.FranceCheckBox.Name = "FranceCheckBox";
			this.HelpProvider1.SetShowHelp(this.FranceCheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("FranceCheckBox.ShowHelp")));
			this.FranceCheckBox.UseVisualStyleBackColor = true;
			this.SPCheckBox.AccessibleDescription = null;
			this.SPCheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.SPCheckBox, "SPCheckBox");
			this.SPCheckBox.BackgroundImage = null;
			this.SPCheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.SPCheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.SPCheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("SPCheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.SPCheckBox, componentResourceManager.GetString("SPCheckBox.HelpString"));
			this.SPCheckBox.Name = "SPCheckBox";
			this.HelpProvider1.SetShowHelp(this.SPCheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("SPCheckBox.ShowHelp")));
			this.SPCheckBox.UseVisualStyleBackColor = true;
			this.BeneluxCheckBox.AccessibleDescription = null;
			this.BeneluxCheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.BeneluxCheckBox, "BeneluxCheckBox");
			this.BeneluxCheckBox.BackgroundImage = null;
			this.BeneluxCheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.BeneluxCheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.BeneluxCheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("BeneluxCheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.BeneluxCheckBox, componentResourceManager.GetString("BeneluxCheckBox.HelpString"));
			this.BeneluxCheckBox.Name = "BeneluxCheckBox";
			this.HelpProvider1.SetShowHelp(this.BeneluxCheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("BeneluxCheckBox.ShowHelp")));
			this.BeneluxCheckBox.UseVisualStyleBackColor = true;
			this.UKCheckBox.AccessibleDescription = null;
			this.UKCheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.UKCheckBox, "UKCheckBox");
			this.UKCheckBox.BackgroundImage = null;
			this.UKCheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.UKCheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.UKCheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("UKCheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.UKCheckBox, componentResourceManager.GetString("UKCheckBox.HelpString"));
			this.UKCheckBox.Name = "UKCheckBox";
			this.HelpProvider1.SetShowHelp(this.UKCheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("UKCheckBox.ShowHelp")));
			this.UKCheckBox.UseVisualStyleBackColor = true;
			this.ScanCheckBox.AccessibleDescription = null;
			this.ScanCheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.ScanCheckBox, "ScanCheckBox");
			this.ScanCheckBox.BackgroundImage = null;
			this.ScanCheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.ScanCheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.ScanCheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("ScanCheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.ScanCheckBox, componentResourceManager.GetString("ScanCheckBox.HelpString"));
			this.ScanCheckBox.Name = "ScanCheckBox";
			this.HelpProvider1.SetShowHelp(this.ScanCheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("ScanCheckBox.ShowHelp")));
			this.ScanCheckBox.UseVisualStyleBackColor = true;
			this.GermanyCheckBox.AccessibleDescription = null;
			this.GermanyCheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.GermanyCheckBox, "GermanyCheckBox");
			this.GermanyCheckBox.BackgroundImage = null;
			this.GermanyCheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.GermanyCheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.GermanyCheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("GermanyCheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.GermanyCheckBox, componentResourceManager.GetString("GermanyCheckBox.HelpString"));
			this.GermanyCheckBox.Name = "GermanyCheckBox";
			this.HelpProvider1.SetShowHelp(this.GermanyCheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("GermanyCheckBox.ShowHelp")));
			this.GermanyCheckBox.UseVisualStyleBackColor = true;
			this.MECheckBox.AccessibleDescription = null;
			this.MECheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.MECheckBox, "MECheckBox");
			this.MECheckBox.BackgroundImage = null;
			this.MECheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.MECheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.MECheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("MECheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.MECheckBox, componentResourceManager.GetString("MECheckBox.HelpString"));
			this.MECheckBox.Name = "MECheckBox";
			this.HelpProvider1.SetShowHelp(this.MECheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("MECheckBox.ShowHelp")));
			this.MECheckBox.UseVisualStyleBackColor = true;
			this.EESCheckBox.AccessibleDescription = null;
			this.EESCheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.EESCheckBox, "EESCheckBox");
			this.EESCheckBox.BackgroundImage = null;
			this.EESCheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.EESCheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.EESCheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("EESCheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.EESCheckBox, componentResourceManager.GetString("EESCheckBox.HelpString"));
			this.EESCheckBox.Name = "EESCheckBox";
			this.HelpProvider1.SetShowHelp(this.EESCheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("EESCheckBox.ShowHelp")));
			this.EESCheckBox.UseVisualStyleBackColor = true;
			this.EENECheckBox.AccessibleDescription = null;
			this.EENECheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.EENECheckBox, "EENECheckBox");
			this.EENECheckBox.BackgroundImage = null;
			this.EENECheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.EENECheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.EENECheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("EENECheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.EENECheckBox, componentResourceManager.GetString("EENECheckBox.HelpString"));
			this.EENECheckBox.Name = "EENECheckBox";
			this.HelpProvider1.SetShowHelp(this.EENECheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("EENECheckBox.ShowHelp")));
			this.EENECheckBox.UseVisualStyleBackColor = true;
			this.EENWCheckBox.AccessibleDescription = null;
			this.EENWCheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.EENWCheckBox, "EENWCheckBox");
			this.EENWCheckBox.BackgroundImage = null;
			this.EENWCheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.EENWCheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.EENWCheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("EENWCheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.EENWCheckBox, componentResourceManager.GetString("EENWCheckBox.HelpString"));
			this.EENWCheckBox.Name = "EENWCheckBox";
			this.HelpProvider1.SetShowHelp(this.EENWCheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("EENWCheckBox.ShowHelp")));
			this.EENWCheckBox.UseVisualStyleBackColor = true;
			this.Label3.AccessibleDescription = null;
			this.Label3.AccessibleName = null;
			componentResourceManager.ApplyResources(this.Label3, "Label3");
			this.Label3.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.Label3, null);
			this.HelpProvider1.SetHelpNavigator(this.Label3, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("Label3.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.Label3, null);
			this.Label3.Name = "Label3";
			this.HelpProvider1.SetShowHelp(this.Label3, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("Label3.ShowHelp")));
			this.SizeLabel.AccessibleDescription = null;
			this.SizeLabel.AccessibleName = null;
			componentResourceManager.ApplyResources(this.SizeLabel, "SizeLabel");
			this.SizeLabel.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.SizeLabel, null);
			this.HelpProvider1.SetHelpNavigator(this.SizeLabel, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("SizeLabel.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.SizeLabel, null);
			this.SizeLabel.Name = "SizeLabel";
			this.HelpProvider1.SetShowHelp(this.SizeLabel, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("SizeLabel.ShowHelp")));
			this.USBGroupBox.AccessibleDescription = null;
			this.USBGroupBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.USBGroupBox, "USBGroupBox");
			this.USBGroupBox.BackgroundImage = null;
			this.USBGroupBox.Controls.Add(this.DriveListView);
			this.USBGroupBox.Controls.Add(this.Refresh_Button);
			this.USBGroupBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.USBGroupBox, null);
			this.HelpProvider1.SetHelpNavigator(this.USBGroupBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("USBGroupBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.USBGroupBox, null);
			this.USBGroupBox.Name = "USBGroupBox";
			this.HelpProvider1.SetShowHelp(this.USBGroupBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("USBGroupBox.ShowHelp")));
			this.USBGroupBox.TabStop = false;
			this.CIDGroupBox.AccessibleDescription = null;
			this.CIDGroupBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.CIDGroupBox, "CIDGroupBox");
			this.CIDGroupBox.BackgroundImage = null;
			this.CIDGroupBox.Controls.Add(this.DurLabel);
			this.CIDGroupBox.Controls.Add(this.Label1);
			this.CIDGroupBox.Controls.Add(this.EENWCheckBox);
			this.CIDGroupBox.Controls.Add(this.EENECheckBox);
			this.CIDGroupBox.Controls.Add(this.EESCheckBox);
			this.CIDGroupBox.Controls.Add(this.MECheckBox);
			this.CIDGroupBox.Controls.Add(this.GermanyCheckBox);
			this.CIDGroupBox.Controls.Add(this.ScanCheckBox);
			this.CIDGroupBox.Controls.Add(this.UKCheckBox);
			this.CIDGroupBox.Controls.Add(this.BeneluxCheckBox);
			this.CIDGroupBox.Controls.Add(this.SPCheckBox);
			this.CIDGroupBox.Controls.Add(this.FranceCheckBox);
			this.CIDGroupBox.Controls.Add(this.ItalyCheckBox);
			this.CIDGroupBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.CIDGroupBox, null);
			this.HelpProvider1.SetHelpNavigator(this.CIDGroupBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("CIDGroupBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.CIDGroupBox, null);
			this.CIDGroupBox.Name = "CIDGroupBox";
			this.HelpProvider1.SetShowHelp(this.CIDGroupBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("CIDGroupBox.ShowHelp")));
			this.CIDGroupBox.TabStop = false;
			this.DurLabel.AccessibleDescription = null;
			this.DurLabel.AccessibleName = null;
			componentResourceManager.ApplyResources(this.DurLabel, "DurLabel");
			this.DurLabel.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.DurLabel, null);
			this.HelpProvider1.SetHelpNavigator(this.DurLabel, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("DurLabel.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.DurLabel, null);
			this.DurLabel.Name = "DurLabel";
			this.HelpProvider1.SetShowHelp(this.DurLabel, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("DurLabel.ShowHelp")));
			this.Label1.AccessibleDescription = null;
			this.Label1.AccessibleName = null;
			componentResourceManager.ApplyResources(this.Label1, "Label1");
			this.Label1.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.Label1, null);
			this.HelpProvider1.SetHelpNavigator(this.Label1, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("Label1.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.Label1, null);
			this.Label1.Name = "Label1";
			this.HelpProvider1.SetShowHelp(this.Label1, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("Label1.ShowHelp")));
			this.HelpProvider1.HelpNamespace = null;
			this.OptionGroupBox.AccessibleDescription = null;
			this.OptionGroupBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.OptionGroupBox, "OptionGroupBox");
			this.OptionGroupBox.BackgroundImage = null;
			this.OptionGroupBox.Controls.Add(this.CRCCheckBox);
			this.OptionGroupBox.Controls.Add(this.DebugCheckBox);
			this.OptionGroupBox.Controls.Add(this.FastCheckBox);
			this.OptionGroupBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.OptionGroupBox, null);
			this.HelpProvider1.SetHelpNavigator(this.OptionGroupBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("OptionGroupBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.OptionGroupBox, null);
			this.OptionGroupBox.Name = "OptionGroupBox";
			this.HelpProvider1.SetShowHelp(this.OptionGroupBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("OptionGroupBox.ShowHelp")));
			this.OptionGroupBox.TabStop = false;
			this.CRCCheckBox.AccessibleDescription = null;
			this.CRCCheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.CRCCheckBox, "CRCCheckBox");
			this.CRCCheckBox.BackgroundImage = null;
			this.CRCCheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.CRCCheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.CRCCheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("CRCCheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.CRCCheckBox, null);
			this.CRCCheckBox.Name = "CRCCheckBox";
			this.HelpProvider1.SetShowHelp(this.CRCCheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("CRCCheckBox.ShowHelp")));
			this.CRCCheckBox.UseVisualStyleBackColor = true;
			this.DebugCheckBox.AccessibleDescription = null;
			this.DebugCheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.DebugCheckBox, "DebugCheckBox");
			this.DebugCheckBox.BackgroundImage = null;
			this.DebugCheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.DebugCheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.DebugCheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("DebugCheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.DebugCheckBox, null);
			this.DebugCheckBox.Name = "DebugCheckBox";
			this.HelpProvider1.SetShowHelp(this.DebugCheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("DebugCheckBox.ShowHelp")));
			this.DebugCheckBox.UseVisualStyleBackColor = true;
			this.FastCheckBox.AccessibleDescription = null;
			this.FastCheckBox.AccessibleName = null;
			componentResourceManager.ApplyResources(this.FastCheckBox, "FastCheckBox");
			this.FastCheckBox.BackgroundImage = null;
			this.FastCheckBox.Font = null;
			this.HelpProvider1.SetHelpKeyword(this.FastCheckBox, null);
			this.HelpProvider1.SetHelpNavigator(this.FastCheckBox, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("FastCheckBox.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this.FastCheckBox, null);
			this.FastCheckBox.Name = "FastCheckBox";
			this.HelpProvider1.SetShowHelp(this.FastCheckBox, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("FastCheckBox.ShowHelp")));
			this.FastCheckBox.UseVisualStyleBackColor = true;
			this.AcceptButton = this.OK_Button;
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.CancelButton = this.Cancel_Button;
			this.Controls.Add(this.OptionGroupBox);
			this.Controls.Add(this.USBGroupBox);
			this.Controls.Add(this.SizeLabel);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.TableLayoutPanel1);
			this.Controls.Add(this.CIDGroupBox);
			this.Font = null;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.HelpProvider1.SetHelpKeyword(this, null);
			this.HelpProvider1.SetHelpNavigator(this, (global::System.Windows.Forms.HelpNavigator)global::Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("$this.HelpNavigator")));
			this.HelpProvider1.SetHelpString(this, null);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "USBMapDialog";
			this.HelpProvider1.SetShowHelp(this, global::Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("$this.ShowHelp")));
			this.ShowInTaskbar = false;
			this.TableLayoutPanel1.ResumeLayout(false);
			this.USBGroupBox.ResumeLayout(false);
			this.CIDGroupBox.ResumeLayout(false);
			this.CIDGroupBox.PerformLayout();
			this.OptionGroupBox.ResumeLayout(false);
			this.OptionGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040003F6 RID: 1014
		private global::System.ComponentModel.IContainer components;
	}
}
