using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x0200003B RID: 59
	[DesignerGenerated]
	public partial class DBDWNLPPCPatchDialog : Form
	{
		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x0015A5E4 File Offset: 0x001595E4
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x0015A5FC File Offset: 0x001595FC
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TableLayoutPanel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TableLayoutPanel1 = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0015A608 File Offset: 0x00159608
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x0015A620 File Offset: 0x00159620
		internal virtual Button OK_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OK_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._OK_Button != null;
				if (flag)
				{
					this._OK_Button.Click -= this.OK_Button_Click;
				}
				this._OK_Button = value;
				flag = (this._OK_Button != null);
				if (flag)
				{
					this._OK_Button.Click += this.OK_Button_Click;
				}
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0015A68C File Offset: 0x0015968C
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x0015A6A4 File Offset: 0x001596A4
		internal virtual Button Cancel_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Cancel_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Cancel_Button != null;
				if (flag)
				{
					this._Cancel_Button.Click -= this.Cancel_Button_Click;
				}
				this._Cancel_Button = value;
				flag = (this._Cancel_Button != null);
				if (flag)
				{
					this._Cancel_Button.Click += this.Cancel_Button_Click;
				}
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0015A710 File Offset: 0x00159710
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x0015A728 File Offset: 0x00159728
		internal virtual ListView DriveListView
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DriveListView;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DriveListView = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0015A734 File Offset: 0x00159734
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x0015A74C File Offset: 0x0015974C
		internal virtual Button Refresh_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Refresh_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Refresh_Button != null;
				if (flag)
				{
					this._Refresh_Button.Click -= this.Refresh_Button_Click;
				}
				this._Refresh_Button = value;
				flag = (this._Refresh_Button != null);
				if (flag)
				{
					this._Refresh_Button.Click += this.Refresh_Button_Click;
				}
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0015A7B8 File Offset: 0x001597B8
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x0015A7D0 File Offset: 0x001597D0
		internal virtual GroupBox USBGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._USBGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._USBGroupBox = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0015A7DC File Offset: 0x001597DC
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x0015A7F4 File Offset: 0x001597F4
		internal virtual HelpProvider HelpProvider1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HelpProvider1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HelpProvider1 = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0015A800 File Offset: 0x00159800
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x0015A818 File Offset: 0x00159818
		internal virtual RadioButton USB_RadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._USB_RadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._USB_RadioButton != null;
				if (flag)
				{
					this._USB_RadioButton.CheckedChanged -= this.USB_RadioButton_CheckedChanged;
				}
				this._USB_RadioButton = value;
				flag = (this._USB_RadioButton != null);
				if (flag)
				{
					this._USB_RadioButton.CheckedChanged += this.USB_RadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x0015A884 File Offset: 0x00159884
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x0015A89C File Offset: 0x0015989C
		internal virtual RadioButton CD_ROM_RadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CD_ROM_RadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._CD_ROM_RadioButton != null;
				if (flag)
				{
					this._CD_ROM_RadioButton.CheckedChanged -= this.CD_ROM_RadioButton_CheckedChanged;
				}
				this._CD_ROM_RadioButton = value;
				flag = (this._CD_ROM_RadioButton != null);
				if (flag)
				{
					this._CD_ROM_RadioButton.CheckedChanged += this.CD_ROM_RadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0015A908 File Offset: 0x00159908
		public DBDWNLPPCPatchDialog(Common.RTxTypes RTxType)
		{
			base.Shown += this.BootScreenDialog_Shown;
			base.Load += this.BootScreenDialog_Load;
			ArrayList _ENCList = DBDWNLPPCPatchDialog.__ENCList;
			lock (_ENCList)
			{
				DBDWNLPPCPatchDialog.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
			this.RTxMapEditorMode = RTxType;
			this.driveList = new DriveList(this.DriveListView, 0L, new DriveList.driveChanged(this.updateGUI));
			bool flag = RTxType == Common.RTxTypes.typeRT4 || RTxType == Common.RTxTypes.typeRT5LR;
			if (flag)
			{
			}
			flag = MySettingsProperty.Settings.RT4USBMode;
			if (flag)
			{
				this.USB_RadioButton.Enabled = true;
				this.DriveListView.Enabled = true;
				this.Refresh_Button.Enabled = true;
				this.USB_RadioButton.Select();
			}
			else
			{
				this.USB_RadioButton.Enabled = false;
				this.DriveListView.Enabled = false;
				this.Refresh_Button.Enabled = false;
				this.CD_ROM_RadioButton.Select();
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0015AA38 File Offset: 0x00159A38
		private void BootScreenDialog_Load(object sender, EventArgs e)
		{
			this.driveList.buildDriveList();
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0015AA48 File Offset: 0x00159A48
		private void BootScreenDialog_Shown(object sender, EventArgs e)
		{
			this.driveList.defaultSelect();
			this.updateGUI();
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0015AA60 File Offset: 0x00159A60
		private void updateGUI()
		{
			bool @checked = this.USB_RadioButton.Checked;
			if (@checked)
			{
				this.DriveListView.Enabled = true;
				this.Refresh_Button.Enabled = true;
			}
			else
			{
				this.DriveListView.Enabled = false;
				this.Refresh_Button.Enabled = false;
			}
			this.OK_Button.Enabled = (this.CD_ROM_RadioButton.Checked || (this.USB_RadioButton.Checked && Operators.CompareString(this.driveList.getDriveToUse(), "", false) != 0));
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0015AAFC File Offset: 0x00159AFC
		private void CD_ROM_RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.updateGUI();
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0015AB08 File Offset: 0x00159B08
		private void USB_RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.updateGUI();
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0015AB14 File Offset: 0x00159B14
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0015AB28 File Offset: 0x00159B28
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0015AB3C File Offset: 0x00159B3C
		private void Refresh_Button_Click(object sender, EventArgs e)
		{
			this.driveList.buildDriveList();
			this.driveList.defaultSelect();
			this.updateGUI();
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0015AB60 File Offset: 0x00159B60
		public string getDriveToUse()
		{
			bool @checked = this.USB_RadioButton.Checked;
			string result;
			if (@checked)
			{
				result = this.driveList.getDriveToUse();
			}
			else
			{
				result = "CD-ROM";
			}
			return result;
		}

		// Token: 0x040003C7 RID: 967
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040003C9 RID: 969
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x040003CA RID: 970
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x040003CB RID: 971
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x040003CC RID: 972
		[AccessedThroughProperty("DriveListView")]
		private ListView _DriveListView;

		// Token: 0x040003CD RID: 973
		[AccessedThroughProperty("Refresh_Button")]
		private Button _Refresh_Button;

		// Token: 0x040003CE RID: 974
		[AccessedThroughProperty("USBGroupBox")]
		private GroupBox _USBGroupBox;

		// Token: 0x040003CF RID: 975
		[AccessedThroughProperty("HelpProvider1")]
		private HelpProvider _HelpProvider1;

		// Token: 0x040003D0 RID: 976
		[AccessedThroughProperty("USB_RadioButton")]
		private RadioButton _USB_RadioButton;

		// Token: 0x040003D1 RID: 977
		[AccessedThroughProperty("CD_ROM_RadioButton")]
		private RadioButton _CD_ROM_RadioButton;

		// Token: 0x040003D2 RID: 978
		public const string RES_CD_ROM = "CD-ROM";

		// Token: 0x040003D3 RID: 979
		private DriveList driveList;

		// Token: 0x040003D4 RID: 980
		private Common.RTxTypes RTxMapEditorMode;
	}
}
