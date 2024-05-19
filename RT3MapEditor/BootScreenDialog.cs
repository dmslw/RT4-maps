using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public partial class BootScreenDialog : Form
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0013FD3C File Offset: 0x0013ED3C
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x0013FD54 File Offset: 0x0013ED54
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0013FD60 File Offset: 0x0013ED60
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0013FD78 File Offset: 0x0013ED78
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0013FDE4 File Offset: 0x0013EDE4
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0013FDFC File Offset: 0x0013EDFC
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0013FE68 File Offset: 0x0013EE68
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0013FE80 File Offset: 0x0013EE80
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0013FE8C File Offset: 0x0013EE8C
		// (set) Token: 0x060001DB RID: 475 RVA: 0x0013FEA4 File Offset: 0x0013EEA4
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0013FF10 File Offset: 0x0013EF10
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0013FF28 File Offset: 0x0013EF28
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0013FF34 File Offset: 0x0013EF34
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0013FF4C File Offset: 0x0013EF4C
		internal virtual GroupBox BSGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BSGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._BSGroupBox = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0013FF58 File Offset: 0x0013EF58
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0013FF70 File Offset: 0x0013EF70
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0013FF7C File Offset: 0x0013EF7C
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x0013FF94 File Offset: 0x0013EF94
		internal virtual RadioButton Fiat_RadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Fiat_RadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Fiat_RadioButton != null;
				if (flag)
				{
					this._Fiat_RadioButton.CheckedChanged -= this.Fiat_RadioButton_CheckedChanged;
				}
				this._Fiat_RadioButton = value;
				flag = (this._Fiat_RadioButton != null);
				if (flag)
				{
					this._Fiat_RadioButton.CheckedChanged += this.Fiat_RadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00140000 File Offset: 0x0013F000
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00140018 File Offset: 0x0013F018
		internal virtual RadioButton Cit_RadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Cit_RadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Cit_RadioButton != null;
				if (flag)
				{
					this._Cit_RadioButton.CheckedChanged -= this.Cit_RadioButton_CheckedChanged;
				}
				this._Cit_RadioButton = value;
				flag = (this._Cit_RadioButton != null);
				if (flag)
				{
					this._Cit_RadioButton.CheckedChanged += this.Cit_RadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00140084 File Offset: 0x0013F084
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x0014009C File Offset: 0x0013F09C
		internal virtual RadioButton Peu_RadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Peu_RadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Peu_RadioButton != null;
				if (flag)
				{
					this._Peu_RadioButton.CheckedChanged -= this.Peu_RadioButton_CheckedChanged;
				}
				this._Peu_RadioButton = value;
				flag = (this._Peu_RadioButton != null);
				if (flag)
				{
					this._Peu_RadioButton.CheckedChanged += this.Peu_RadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00140108 File Offset: 0x0013F108
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00140120 File Offset: 0x0013F120
		internal virtual RadioButton MM_RadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MM_RadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._MM_RadioButton != null;
				if (flag)
				{
					this._MM_RadioButton.CheckedChanged -= this.MM_RadioButton_CheckedChanged;
				}
				this._MM_RadioButton = value;
				flag = (this._MM_RadioButton != null);
				if (flag)
				{
					this._MM_RadioButton.CheckedChanged += this.MM_RadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0014018C File Offset: 0x0013F18C
		// (set) Token: 0x060001EB RID: 491 RVA: 0x001401A4 File Offset: 0x0013F1A4
		internal virtual Button Browse_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Browse_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Browse_Button != null;
				if (flag)
				{
					this._Browse_Button.Click -= this.Browse_Button_Click;
				}
				this._Browse_Button = value;
				flag = (this._Browse_Button != null);
				if (flag)
				{
					this._Browse_Button.Click += this.Browse_Button_Click;
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00140210 File Offset: 0x0013F210
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00140228 File Offset: 0x0013F228
		internal virtual RadioButton Custom_RadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Custom_RadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Custom_RadioButton != null;
				if (flag)
				{
					this._Custom_RadioButton.CheckedChanged -= this.Custom_RadioButton_CheckedChanged;
				}
				this._Custom_RadioButton = value;
				flag = (this._Custom_RadioButton != null);
				if (flag)
				{
					this._Custom_RadioButton.CheckedChanged += this.Custom_RadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00140294 File Offset: 0x0013F294
		// (set) Token: 0x060001EF RID: 495 RVA: 0x001402AC File Offset: 0x0013F2AC
		internal virtual Button Preview_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Preview_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Preview_Button != null;
				if (flag)
				{
					this._Preview_Button.Click -= this.Preview_Button_Click;
				}
				this._Preview_Button = value;
				flag = (this._Preview_Button != null);
				if (flag)
				{
					this._Preview_Button.Click += this.Preview_Button_Click;
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00140318 File Offset: 0x0013F318
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00140330 File Offset: 0x0013F330
		internal virtual RadioButton PC_RadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PC_RadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._PC_RadioButton != null;
				if (flag)
				{
					this._PC_RadioButton.CheckedChanged -= this.PC_RadioButton_CheckedChanged;
				}
				this._PC_RadioButton = value;
				flag = (this._PC_RadioButton != null);
				if (flag)
				{
					this._PC_RadioButton.CheckedChanged += this.PC_RadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0014039C File Offset: 0x0013F39C
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x001403B4 File Offset: 0x0013F3B4
		internal virtual RadioButton Lan_RadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Lan_RadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Lan_RadioButton != null;
				if (flag)
				{
					this._Lan_RadioButton.CheckedChanged -= this.Lan_RadioButton_CheckedChanged;
				}
				this._Lan_RadioButton = value;
				flag = (this._Lan_RadioButton != null);
				if (flag)
				{
					this._Lan_RadioButton.CheckedChanged += this.Lan_RadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00140420 File Offset: 0x0013F420
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00140438 File Offset: 0x0013F438
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x001404A4 File Offset: 0x0013F4A4
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x001404BC File Offset: 0x0013F4BC
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00140528 File Offset: 0x0013F528
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00140540 File Offset: 0x0013F540
		internal virtual RadioButton RTx_RadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RTx_RadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RTx_RadioButton != null;
				if (flag)
				{
					this._RTx_RadioButton.CheckedChanged -= this.RTx_RadioButton_CheckedChanged;
				}
				this._RTx_RadioButton = value;
				flag = (this._RTx_RadioButton != null);
				if (flag)
				{
					this._RTx_RadioButton.CheckedChanged += this.RTx_RadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001FA RID: 506 RVA: 0x001405AC File Offset: 0x0013F5AC
		// (set) Token: 0x060001FB RID: 507 RVA: 0x001405C4 File Offset: 0x0013F5C4
		internal virtual TextBox Path_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Path_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Path_TextBox = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001FC RID: 508 RVA: 0x001405D0 File Offset: 0x0013F5D0
		// (set) Token: 0x060001FD RID: 509 RVA: 0x001405E8 File Offset: 0x0013F5E8
		internal virtual PictureBox Preview_PictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Preview_PictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Preview_PictureBox = value;
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x001405F4 File Offset: 0x0013F5F4
		public BootScreenDialog(Common.RTxTypes RTxMapEditorMode)
		{
			base.Load += this.BootScreenDialog_Load;
			base.Shown += this.BootScreenDialog_Shown;
			ArrayList _ENCList = BootScreenDialog.__ENCList;
			lock (_ENCList)
			{
				BootScreenDialog.__ENCList.Add(new WeakReference(this));
			}
			this.selectedScreen = null;
			this.selectedPath = null;
			this.FileDialog = new OpenFileDialog();
			this.bootScreen = null;
			this.customBootScreen = null;
			this.ScreenPreview = null;
			this.inputStream = null;
			this.reDimDialog = null;
			this.InitializeComponent();
			this.RTxMapEditorMode = RTxMapEditorMode;
			this.driveList = new DriveList(this.DriveListView, 0L, new DriveList.driveChanged(this.updateGUI));
			this.zipFile = new ZipFile(Path.Combine(MyProject.Application.Info.DirectoryPath, "redist\\upg.dat"));
			this.zipFile.Password = "ZZZCOM.IND.lst";
			bool flag = RTxScreen.isLRScreen();
			if (flag)
			{
				switch (Common.RTxVersion)
				{
				case Common.RTxVersions.version702:
				case Common.RTxVersions.version710:
					this.selectedScreen = "27";
					break;
				default:
					this.selectedScreen = "35";
					break;
				}
			}
			else
			{
				this.selectedScreen = "38";
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
			this.Custom_RadioButton.Select();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x001407DC File Offset: 0x0013F7DC
		private void BootScreenDialog_Load(object sender, EventArgs e)
		{
			this.driveList.buildDriveList();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x001407EC File Offset: 0x0013F7EC
		private void BootScreenDialog_Shown(object sender, EventArgs e)
		{
			this.driveList.defaultSelect();
			bool flag = RTxScreen.isLRScreen();
			if (flag)
			{
				switch (Common.RTxVersion)
				{
				case Common.RTxVersions.version702:
				case Common.RTxVersions.version710:
					this.selectedScreen = "27";
					break;
				default:
					this.selectedScreen = "35";
					break;
				}
			}
			else
			{
				this.selectedScreen = "38";
			}
			this.MM_RadioButton.Checked = true;
			this.updateGUI();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00140868 File Offset: 0x0013F868
		private void updateGUI()
		{
			bool flag = this.USB_RadioButton.Checked;
			if (flag)
			{
				this.DriveListView.Enabled = true;
				this.Refresh_Button.Enabled = true;
			}
			else
			{
				this.DriveListView.Enabled = false;
				this.Refresh_Button.Enabled = false;
			}
			flag = (this.inputStream != null);
			if (flag)
			{
				this.inputStream.Close();
				this.inputStream = null;
			}
			flag = this.Custom_RadioButton.Checked;
			bool flag2;
			if (flag)
			{
				this.Browse_Button.Enabled = true;
				this.Path_TextBox.Text = this.selectedPath;
				flag = (this.selectedPath != null && this.selectedPath.Length > 0);
				if (flag)
				{
					this.inputStream = new FileStream(this.selectedPath, FileMode.Open);
					flag = this.isCustomFileOK(false);
					if (flag)
					{
						flag2 = true;
						this.Preview_Button.Enabled = true;
					}
					else
					{
						flag2 = false;
						this.Preview_Button.Enabled = false;
					}
					this.inputStream.Close();
					this.inputStream = null;
				}
				else
				{
					flag2 = false;
					this.Preview_Button.Enabled = false;
					this.bootScreen = null;
				}
			}
			else
			{
				this.Browse_Button.Enabled = false;
				flag2 = true;
				this.Preview_Button.Enabled = true;
				this.inputStream = this.zipFile.GetInputStream(this.zipFile.GetEntry(this.selectedScreen));
				this.bootScreen = new Bitmap(this.inputStream);
			}
			this.OK_Button.Enabled = (flag2 && (this.CD_ROM_RadioButton.Checked || (this.USB_RadioButton.Checked && Operators.CompareString(this.driveList.getDriveToUse(), "", false) != 0)));
			this.Preview_PictureBox.Image = this.bootScreen;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00140A48 File Offset: 0x0013FA48
		private bool isCustomFileOK(bool reFrame)
		{
			bool result = true;
			try
			{
				bool flag = this.customBootScreen != null;
				if (flag)
				{
					this.bootScreen = this.customBootScreen;
				}
				else
				{
					this.bootScreen = new Bitmap(this.inputStream);
				}
				flag = (this.bootScreen.Height != RTxScreen.RTx_SCREEN_HEIGHT || this.bootScreen.Width != RTxScreen.RTx_SCREEN_WIDTH);
				if (flag)
				{
					if (reFrame)
					{
						bool flag2 = this.reDimDialog == null;
						if (flag2)
						{
							this.reDimDialog = new BootScreenFramingDialog();
						}
						flag2 = (this.reDimDialog.ShowDialog(ref this.bootScreen) != DialogResult.OK);
						if (flag2)
						{
							result = false;
						}
						else
						{
							flag2 = (this.bootScreen.Height != RTxScreen.RTx_SCREEN_HEIGHT || this.bootScreen.Width != RTxScreen.RTx_SCREEN_WIDTH);
							if (flag2)
							{
								Interaction.MsgBox(string.Format(Resources.strErrImageSize, Path.GetFileName(this.selectedPath)), MsgBoxStyle.Exclamation, Resources.strErrErrTitle);
								result = false;
							}
						}
					}
					else
					{
						result = false;
					}
				}
			}
			catch (ArgumentException ex)
			{
				Interaction.MsgBox(string.Format(Resources.strErrOpenImage, Path.GetFileName(this.selectedPath)), MsgBoxStyle.Exclamation, Resources.strErrErrTitle);
				result = false;
			}
			catch (Exception ex2)
			{
				Interaction.MsgBox(string.Format(Resources.strErrOpenImage, Path.GetFileName(this.selectedPath)), MsgBoxStyle.Exclamation, Resources.strErrErrTitle);
				result = false;
			}
			return result;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00140C04 File Offset: 0x0013FC04
		public void WriteBootScreen(Stream outputStream, string outputFileName)
		{
			bool @checked = this.Custom_RadioButton.Checked;
			if (@checked)
			{
				Bitmap bitmap = new Bitmap(RTxScreen.RTx_SCREEN_WIDTH, RTxScreen.RTx_SCREEN_HEIGHT, PixelFormat.Format24bppRgb);
				Graphics graphics = Graphics.FromImage(bitmap);
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.DrawImage(this.bootScreen, 0, 0, RTxScreen.RTx_SCREEN_WIDTH, RTxScreen.RTx_SCREEN_HEIGHT);
				graphics.Dispose();
				bitmap.Save(outputStream, ImageFormat.Bmp);
				outputStream.Close();
				BinaryWriter binaryWriter = new BinaryWriter(new FileStream(outputFileName, FileMode.Open));
				binaryWriter.Seek(34, SeekOrigin.Begin);
				binaryWriter.Write(64);
				binaryWriter.Write(36);
				binaryWriter.Write(5);
				binaryWriter.Write(0);
				binaryWriter.Close();
			}
			else
			{
				this.inputStream = this.zipFile.GetInputStream(this.zipFile.GetEntry(this.selectedScreen));
				FileUtils.streamCopy(this.inputStream, outputStream);
				this.inputStream.Close();
				outputStream.Close();
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00140D08 File Offset: 0x0013FD08
		public static bool CheckFinalBMPFile(string fileName)
		{
			BinaryReader binaryReader = null;
			bool result = false;
			try
			{
				uint num = checked((uint)MyProject.Computer.FileSystem.GetFileInfo(fileName).Length);
				binaryReader = new BinaryReader(new FileStream(fileName, FileMode.Open));
				BootScreenDialog.bmpHeader bmpHeader;
				bmpHeader.magic = binaryReader.ReadUInt16();
				bmpHeader.fileSize = binaryReader.ReadUInt32();
				bmpHeader.reserved1 = binaryReader.ReadUInt16();
				bmpHeader.reserved2 = binaryReader.ReadUInt16();
				bmpHeader.bmpStart = binaryReader.ReadUInt32();
				BootScreenDialog.DIBHeader dibheader;
				dibheader.headerSize = binaryReader.ReadUInt32();
				dibheader.bmWidth = binaryReader.ReadInt32();
				dibheader.bmHeight = binaryReader.ReadInt32();
				dibheader.colorPlane = binaryReader.ReadUInt16();
				dibheader.bpp = binaryReader.ReadUInt16();
				dibheader.compression = binaryReader.ReadUInt32();
				dibheader.bmSize = binaryReader.ReadUInt32();
				dibheader.hRes = binaryReader.ReadUInt32();
				dibheader.vRes = binaryReader.ReadUInt32();
				dibheader.palColorNumber = binaryReader.ReadUInt32();
				dibheader.importantColorNumber = binaryReader.ReadUInt32();
				ushort bpp = dibheader.bpp;
				bool flag = bpp == 8;
				if (flag)
				{
					result = (bmpHeader.magic == 19778 && bmpHeader.reserved1 == 0 && bmpHeader.reserved2 == 0 && (ulong)dibheader.headerSize == 40UL && dibheader.bmWidth == RTxScreen.RTx_SCREEN_WIDTH && dibheader.bmHeight == RTxScreen.RTx_SCREEN_HEIGHT && dibheader.colorPlane == 1 && ((ulong)dibheader.compression == 1UL || (ulong)dibheader.compression == 0UL) && (ulong)dibheader.palColorNumber <= 256UL);
				}
				else
				{
					flag = (bpp == 24);
					if (flag)
					{
						bool flag2;
						if (bmpHeader.magic == 19778)
						{
							if ((ulong)bmpHeader.fileSize != 337014UL || dibheader.bmWidth != 480 || dibheader.bmHeight != 234)
							{
								if ((ulong)bmpHeader.fileSize != 1070454UL || dibheader.bmWidth != 800 || dibheader.bmHeight != 446)
								{
									goto IL_29D;
								}
							}
							if (bmpHeader.fileSize == num && bmpHeader.reserved1 == 0 && bmpHeader.reserved2 == 0 && (ulong)bmpHeader.bmpStart == 54UL && (ulong)dibheader.headerSize == 40UL && dibheader.bmWidth == RTxScreen.RTx_SCREEN_WIDTH && dibheader.bmHeight == RTxScreen.RTx_SCREEN_HEIGHT && dibheader.colorPlane == 1 && (ulong)dibheader.compression == 0UL && (ulong)dibheader.bmSize == 336960UL)
							{
								flag2 = true;
								goto IL_2A1;
							}
						}
						IL_29D:
						flag2 = false;
						IL_2A1:
						result = flag2;
					}
					else
					{
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				result = false;
			}
			finally
			{
				bool flag = binaryReader != null;
				if (flag)
				{
					binaryReader.Close();
				}
			}
			return result;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0014102C File Offset: 0x0014002C
		private void CD_ROM_RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.updateGUI();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00141038 File Offset: 0x00140038
		private void USB_RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.updateGUI();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00141044 File Offset: 0x00140044
		private void MM_RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = RTxScreen.isLRScreen();
			if (flag)
			{
				switch (Common.RTxVersion)
				{
				case Common.RTxVersions.version702:
				case Common.RTxVersions.version710:
					this.selectedScreen = "27";
					break;
				default:
					this.selectedScreen = "35";
					break;
				}
			}
			else
			{
				this.selectedScreen = "38";
			}
			this.updateGUI();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x001410A8 File Offset: 0x001400A8
		private void Cit_RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = RTxScreen.isLRScreen();
			if (flag)
			{
				this.selectedScreen = "28";
			}
			else
			{
				this.selectedScreen = "39";
			}
			this.updateGUI();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x001410E4 File Offset: 0x001400E4
		private void Fiat_RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = RTxScreen.isLRScreen();
			if (flag)
			{
				this.selectedScreen = "29";
			}
			else
			{
				this.selectedScreen = "40";
			}
			this.updateGUI();
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00141120 File Offset: 0x00140120
		private void Lan_RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = RTxScreen.isLRScreen();
			if (flag)
			{
				this.selectedScreen = "29";
			}
			else
			{
				this.selectedScreen = "40";
			}
			this.updateGUI();
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0014115C File Offset: 0x0014015C
		private void Peu_RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = RTxScreen.isLRScreen();
			if (flag)
			{
				switch (Common.RTxVersion)
				{
				case Common.RTxVersions.version702:
				case Common.RTxVersions.version710:
					this.selectedScreen = "31";
					break;
				default:
					this.selectedScreen = "36";
					break;
				}
			}
			else
			{
				this.selectedScreen = "41";
			}
			this.updateGUI();
		}

		// Token: 0x0600020C RID: 524 RVA: 0x001411C0 File Offset: 0x001401C0
		private void PC_RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = RTxScreen.isLRScreen();
			if (flag)
			{
				this.selectedScreen = "32";
			}
			else
			{
				this.selectedScreen = "42";
			}
			this.updateGUI();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x001411FC File Offset: 0x001401FC
		private void RTx_RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = RTxScreen.isLRScreen();
			if (flag)
			{
				this.selectedScreen = "33";
			}
			else
			{
				this.selectedScreen = "43";
			}
			this.updateGUI();
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00141238 File Offset: 0x00140238
		private void Custom_RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.updateGUI();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00141244 File Offset: 0x00140244
		private void Browse_Button_Click(object sender, EventArgs e)
		{
			this.FileDialog.Title = Resources.strLoadCustomScreen;
			this.FileDialog.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png;*.tif)|*.bmp;*.jpg;*.gif;*.png;*.tif";
			this.FileDialog.CheckFileExists = true;
			this.FileDialog.ReadOnlyChecked = true;
			bool flag = this.FileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.customBootScreen = null;
				this.selectedPath = this.FileDialog.FileName;
				this.Browse_Button.Enabled = true;
				this.Path_TextBox.Text = this.selectedPath;
				this.inputStream = new FileStream(this.selectedPath, FileMode.Open);
				flag = !this.isCustomFileOK(true);
				if (flag)
				{
					this.selectedPath = null;
					this.Path_TextBox.Text = "";
					this.bootScreen = null;
					this.customBootScreen = null;
				}
				else
				{
					this.customBootScreen = this.bootScreen;
				}
				this.inputStream.Close();
				this.inputStream = null;
			}
			this.updateGUI();
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0014134C File Offset: 0x0014034C
		private void Preview_Button_Click(object sender, EventArgs e)
		{
			bool flag = this.ScreenPreview == null;
			if (flag)
			{
				this.ScreenPreview = new ScreenPreview();
			}
			this.ScreenPreview.PictureBox.Image = this.bootScreen;
			this.ScreenPreview.ShowDialog();
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00141398 File Offset: 0x00140398
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06000212 RID: 530 RVA: 0x001413AC File Offset: 0x001403AC
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x001413C0 File Offset: 0x001403C0
		private void Refresh_Button_Click(object sender, EventArgs e)
		{
			this.driveList.buildDriveList();
			this.driveList.defaultSelect();
			this.updateGUI();
		}

		// Token: 0x06000214 RID: 532 RVA: 0x001413E4 File Offset: 0x001403E4
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

		// Token: 0x04000102 RID: 258
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x04000104 RID: 260
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x04000105 RID: 261
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x04000106 RID: 262
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x04000107 RID: 263
		[AccessedThroughProperty("DriveListView")]
		private ListView _DriveListView;

		// Token: 0x04000108 RID: 264
		[AccessedThroughProperty("Refresh_Button")]
		private Button _Refresh_Button;

		// Token: 0x04000109 RID: 265
		[AccessedThroughProperty("USBGroupBox")]
		private GroupBox _USBGroupBox;

		// Token: 0x0400010A RID: 266
		[AccessedThroughProperty("BSGroupBox")]
		private GroupBox _BSGroupBox;

		// Token: 0x0400010B RID: 267
		[AccessedThroughProperty("HelpProvider1")]
		private HelpProvider _HelpProvider1;

		// Token: 0x0400010C RID: 268
		[AccessedThroughProperty("Fiat_RadioButton")]
		private RadioButton _Fiat_RadioButton;

		// Token: 0x0400010D RID: 269
		[AccessedThroughProperty("Cit_RadioButton")]
		private RadioButton _Cit_RadioButton;

		// Token: 0x0400010E RID: 270
		[AccessedThroughProperty("Peu_RadioButton")]
		private RadioButton _Peu_RadioButton;

		// Token: 0x0400010F RID: 271
		[AccessedThroughProperty("MM_RadioButton")]
		private RadioButton _MM_RadioButton;

		// Token: 0x04000110 RID: 272
		[AccessedThroughProperty("Browse_Button")]
		private Button _Browse_Button;

		// Token: 0x04000111 RID: 273
		[AccessedThroughProperty("Custom_RadioButton")]
		private RadioButton _Custom_RadioButton;

		// Token: 0x04000112 RID: 274
		[AccessedThroughProperty("Preview_Button")]
		private Button _Preview_Button;

		// Token: 0x04000113 RID: 275
		[AccessedThroughProperty("PC_RadioButton")]
		private RadioButton _PC_RadioButton;

		// Token: 0x04000114 RID: 276
		[AccessedThroughProperty("Lan_RadioButton")]
		private RadioButton _Lan_RadioButton;

		// Token: 0x04000115 RID: 277
		[AccessedThroughProperty("USB_RadioButton")]
		private RadioButton _USB_RadioButton;

		// Token: 0x04000116 RID: 278
		[AccessedThroughProperty("CD_ROM_RadioButton")]
		private RadioButton _CD_ROM_RadioButton;

		// Token: 0x04000117 RID: 279
		[AccessedThroughProperty("RTx_RadioButton")]
		private RadioButton _RTx_RadioButton;

		// Token: 0x04000118 RID: 280
		[AccessedThroughProperty("Path_TextBox")]
		private TextBox _Path_TextBox;

		// Token: 0x04000119 RID: 281
		[AccessedThroughProperty("Preview_PictureBox")]
		private PictureBox _Preview_PictureBox;

		// Token: 0x0400011A RID: 282
		public const string RES_CD_ROM = "CD-ROM";

		// Token: 0x0400011B RID: 283
		private DriveList driveList;

		// Token: 0x0400011C RID: 284
		private string selectedScreen;

		// Token: 0x0400011D RID: 285
		private string selectedPath;

		// Token: 0x0400011E RID: 286
		private OpenFileDialog FileDialog;

		// Token: 0x0400011F RID: 287
		private Bitmap bootScreen;

		// Token: 0x04000120 RID: 288
		private Bitmap customBootScreen;

		// Token: 0x04000121 RID: 289
		private ScreenPreview ScreenPreview;

		// Token: 0x04000122 RID: 290
		private ZipFile zipFile;

		// Token: 0x04000123 RID: 291
		private Stream inputStream;

		// Token: 0x04000124 RID: 292
		private BootScreenFramingDialog reDimDialog;

		// Token: 0x04000125 RID: 293
		private Common.RTxTypes RTxMapEditorMode;

		// Token: 0x02000011 RID: 17
		private struct bmpHeader
		{
			// Token: 0x04000126 RID: 294
			public ushort magic;

			// Token: 0x04000127 RID: 295
			public uint fileSize;

			// Token: 0x04000128 RID: 296
			public ushort reserved1;

			// Token: 0x04000129 RID: 297
			public ushort reserved2;

			// Token: 0x0400012A RID: 298
			public uint bmpStart;
		}

		// Token: 0x02000012 RID: 18
		private struct DIBHeader
		{
			// Token: 0x0400012B RID: 299
			public uint headerSize;

			// Token: 0x0400012C RID: 300
			public int bmWidth;

			// Token: 0x0400012D RID: 301
			public int bmHeight;

			// Token: 0x0400012E RID: 302
			public ushort colorPlane;

			// Token: 0x0400012F RID: 303
			public ushort bpp;

			// Token: 0x04000130 RID: 304
			public uint compression;

			// Token: 0x04000131 RID: 305
			public uint bmSize;

			// Token: 0x04000132 RID: 306
			public uint hRes;

			// Token: 0x04000133 RID: 307
			public uint vRes;

			// Token: 0x04000134 RID: 308
			public uint palColorNumber;

			// Token: 0x04000135 RID: 309
			public uint importantColorNumber;
		}
	}
}
