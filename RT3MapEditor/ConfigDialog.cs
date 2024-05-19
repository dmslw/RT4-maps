using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000030 RID: 48
	[DesignerGenerated]
	public partial class ConfigDialog : Form
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00150F4C File Offset: 0x0014FF4C
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00150F64 File Offset: 0x0014FF64
		internal virtual HelpProvider HelpProviderConfig
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HelpProviderConfig;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HelpProviderConfig = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00150F70 File Offset: 0x0014FF70
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00150F88 File Offset: 0x0014FF88
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

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00150FF4 File Offset: 0x0014FFF4
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0015100C File Offset: 0x0015000C
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
					this._Cancel_Button.MouseLeave -= this.Cancel_Button_MouseLeave;
					this._Cancel_Button.MouseEnter -= this.Cancel_Button_MouseEnter;
					this._Cancel_Button.Click -= this.Cancel_Button_Click;
				}
				this._Cancel_Button = value;
				flag = (this._Cancel_Button != null);
				if (flag)
				{
					this._Cancel_Button.MouseLeave += this.Cancel_Button_MouseLeave;
					this._Cancel_Button.MouseEnter += this.Cancel_Button_MouseEnter;
					this._Cancel_Button.Click += this.Cancel_Button_Click;
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000396 RID: 918 RVA: 0x001510DC File Offset: 0x001500DC
		// (set) Token: 0x06000397 RID: 919 RVA: 0x001510F4 File Offset: 0x001500F4
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00151100 File Offset: 0x00150100
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00151118 File Offset: 0x00150118
		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00151124 File Offset: 0x00150124
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0015113C File Offset: 0x0015013C
		internal virtual TabControl ConfigTabControl
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ConfigTabControl;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ConfigTabControl = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00151148 File Offset: 0x00150148
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00151160 File Offset: 0x00150160
		internal virtual TabPage TabPageGeneral
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPageGeneral;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPageGeneral = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0015116C File Offset: 0x0015016C
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00151184 File Offset: 0x00150184
		internal virtual GroupBox FolderGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FolderGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FolderGroupBox = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00151190 File Offset: 0x00150190
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x001511A8 File Offset: 0x001501A8
		internal virtual Button ISODelete_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ISODelete_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ISODelete_Button != null;
				if (flag)
				{
					this._ISODelete_Button.Click -= this.ISODelete_Button_Click;
				}
				this._ISODelete_Button = value;
				flag = (this._ISODelete_Button != null);
				if (flag)
				{
					this._ISODelete_Button.Click += this.ISODelete_Button_Click;
				}
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00151214 File Offset: 0x00150214
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x0015122C File Offset: 0x0015022C
		internal virtual Button WorkingDirErase_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WorkingDirErase_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._WorkingDirErase_Button != null;
				if (flag)
				{
					this._WorkingDirErase_Button.Click -= this.workingDirErase_Button_Click;
				}
				this._WorkingDirErase_Button = value;
				flag = (this._WorkingDirErase_Button != null);
				if (flag)
				{
					this._WorkingDirErase_Button.Click += this.workingDirErase_Button_Click;
				}
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00151298 File Offset: 0x00150298
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x001512B0 File Offset: 0x001502B0
		internal virtual ProgressBar ProgressBar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ProgressBar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ProgressBar = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x001512BC File Offset: 0x001502BC
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x001512D4 File Offset: 0x001502D4
		internal virtual Label CopyLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopyLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CopyLabel = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x001512E0 File Offset: 0x001502E0
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x001512F8 File Offset: 0x001502F8
		internal virtual Button ISODirBrowse_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ISODirBrowse_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ISODirBrowse_Button != null;
				if (flag)
				{
					this._ISODirBrowse_Button.Click -= this.ISODirBrowse_Button_Click;
				}
				this._ISODirBrowse_Button = value;
				flag = (this._ISODirBrowse_Button != null);
				if (flag)
				{
					this._ISODirBrowse_Button.Click += this.ISODirBrowse_Button_Click;
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00151364 File Offset: 0x00150364
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0015137C File Offset: 0x0015037C
		internal virtual TextBox ISODir_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ISODir_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ISODir_TextBox != null;
				if (flag)
				{
					this._ISODir_TextBox.TextChanged -= this.ISODir_TextBox_TextChanged;
					this._ISODir_TextBox.Validating -= this.ISODir_TextBox_Validating;
				}
				this._ISODir_TextBox = value;
				flag = (this._ISODir_TextBox != null);
				if (flag)
				{
					this._ISODir_TextBox.TextChanged += this.ISODir_TextBox_TextChanged;
					this._ISODir_TextBox.Validating += this.ISODir_TextBox_Validating;
				}
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00151418 File Offset: 0x00150418
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00151430 File Offset: 0x00150430
		internal virtual Label ISODirLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ISODirLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ISODirLabel = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0015143C File Offset: 0x0015043C
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00151454 File Offset: 0x00150454
		internal virtual Button WorkingDirFill_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WorkingDirFill_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._WorkingDirFill_Button != null;
				if (flag)
				{
					this._WorkingDirFill_Button.Click -= this.WorkingDirFill_Button_Click;
				}
				this._WorkingDirFill_Button = value;
				flag = (this._WorkingDirFill_Button != null);
				if (flag)
				{
					this._WorkingDirFill_Button.Click += this.WorkingDirFill_Button_Click;
				}
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x001514C0 File Offset: 0x001504C0
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x001514D8 File Offset: 0x001504D8
		internal virtual Button WorkingDirBrowse_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WorkingDirBrowse_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._WorkingDirBrowse_Button != null;
				if (flag)
				{
					this._WorkingDirBrowse_Button.Click -= this.workingDIRBrowse_Button_Click;
				}
				this._WorkingDirBrowse_Button = value;
				flag = (this._WorkingDirBrowse_Button != null);
				if (flag)
				{
					this._WorkingDirBrowse_Button.Click += this.workingDIRBrowse_Button_Click;
				}
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00151544 File Offset: 0x00150544
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0015155C File Offset: 0x0015055C
		internal virtual Label workingDir_Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._workingDir_Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._workingDir_Label = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00151568 File Offset: 0x00150568
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00151580 File Offset: 0x00150580
		internal virtual TextBox WorkingDir_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WorkingDir_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._WorkingDir_TextBox != null;
				if (flag)
				{
					this._WorkingDir_TextBox.TextChanged -= this.workingDir_TextBox_TextChanged;
					this._WorkingDir_TextBox.Validating -= this.workingDir_TextBox_Validating;
				}
				this._WorkingDir_TextBox = value;
				flag = (this._WorkingDir_TextBox != null);
				if (flag)
				{
					this._WorkingDir_TextBox.TextChanged += this.workingDir_TextBox_TextChanged;
					this._WorkingDir_TextBox.Validating += this.workingDir_TextBox_Validating;
				}
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0015161C File Offset: 0x0015061C
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00151634 File Offset: 0x00150634
		internal virtual GroupBox BurnGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BurnGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._BurnGroupBox = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00151640 File Offset: 0x00150640
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00151658 File Offset: 0x00150658
		internal virtual Button CommandBrowse_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CommandBrowse_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._CommandBrowse_Button != null;
				if (flag)
				{
					this._CommandBrowse_Button.Click -= this.CommandBrowse_Button_Click;
				}
				this._CommandBrowse_Button = value;
				flag = (this._CommandBrowse_Button != null);
				if (flag)
				{
					this._CommandBrowse_Button.Click += this.CommandBrowse_Button_Click;
				}
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003BA RID: 954 RVA: 0x001516C4 File Offset: 0x001506C4
		// (set) Token: 0x060003BB RID: 955 RVA: 0x001516DC File Offset: 0x001506DC
		internal virtual TextBox Command_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Command_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Command_TextBox = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003BC RID: 956 RVA: 0x001516E8 File Offset: 0x001506E8
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00151700 File Offset: 0x00150700
		internal virtual Label Command_Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Command_Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Command_Label = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0015170C File Offset: 0x0015070C
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00151724 File Offset: 0x00150724
		internal virtual TabPage TabPageImport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPageImport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPageImport = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00151730 File Offset: 0x00150730
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00151748 File Offset: 0x00150748
		internal virtual GroupBox GroupBoxImportTxtOptions
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBoxImportTxtOptions;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBoxImportTxtOptions = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00151754 File Offset: 0x00150754
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x0015176C File Offset: 0x0015076C
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00151778 File Offset: 0x00150778
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00151790 File Offset: 0x00150790
		internal virtual CheckBox txtImportQuoteCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtImportQuoteCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtImportQuoteCheckBox = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0015179C File Offset: 0x0015079C
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x001517B4 File Offset: 0x001507B4
		internal virtual ComboBox importTxtSepComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._importTxtSepComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._importTxtSepComboBox = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x001517C0 File Offset: 0x001507C0
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x001517D8 File Offset: 0x001507D8
		internal virtual GroupBox GroupBoxImportRT3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBoxImportRT3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBoxImportRT3 = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003CA RID: 970 RVA: 0x001517E4 File Offset: 0x001507E4
		// (set) Token: 0x060003CB RID: 971 RVA: 0x001517FC File Offset: 0x001507FC
		internal virtual CheckBox changeRT3MedicServCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._changeRT3MedicServCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._changeRT3MedicServCheckBox = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00151808 File Offset: 0x00150808
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00151820 File Offset: 0x00150820
		internal virtual CheckBox changeRT3MotorbCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._changeRT3MotorbCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._changeRT3MotorbCheckBox = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0015182C File Offset: 0x0015082C
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00151844 File Offset: 0x00150844
		internal virtual CheckBox changeRT3CivicCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._changeRT3CivicCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._changeRT3CivicCheckBox = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00151850 File Offset: 0x00150850
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00151868 File Offset: 0x00150868
		internal virtual CheckBox changeRT3PerfArtsCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._changeRT3PerfArtsCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._changeRT3PerfArtsCheckBox = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00151874 File Offset: 0x00150874
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0015188C File Offset: 0x0015088C
		internal virtual CheckBox changeRT3BorderCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._changeRT3BorderCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._changeRT3BorderCheckBox = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00151898 File Offset: 0x00150898
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x001518B0 File Offset: 0x001508B0
		internal virtual CheckBox changeRT3IndustCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._changeRT3IndustCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._changeRT3IndustCheckBox = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x001518BC File Offset: 0x001508BC
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x001518D4 File Offset: 0x001508D4
		internal virtual CheckBox changeRT3EmbassyCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._changeRT3EmbassyCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._changeRT3EmbassyCheckBox = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x001518E0 File Offset: 0x001508E0
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x001518F8 File Offset: 0x001508F8
		internal virtual CheckBox ignoreRT3BorgateCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ignoreRT3BorgateCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ignoreRT3BorgateCheckBox = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00151904 File Offset: 0x00150904
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0015191C File Offset: 0x0015091C
		internal virtual CheckBox IgnoreRT3AltNameCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IgnoreRT3AltNameCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._IgnoreRT3AltNameCheckBox = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00151928 File Offset: 0x00150928
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00151940 File Offset: 0x00150940
		internal virtual GroupBox GroupBoxImportErrMngt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBoxImportErrMngt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBoxImportErrMngt = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0015194C File Offset: 0x0015094C
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00151964 File Offset: 0x00150964
		internal virtual CheckBox importLogErrCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._importLogErrCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._importLogErrCheckBox = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00151970 File Offset: 0x00150970
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00151988 File Offset: 0x00150988
		internal virtual CheckBox ImportEmptyAreaCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImportEmptyAreaCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImportEmptyAreaCheckBox = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00151994 File Offset: 0x00150994
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x001519AC File Offset: 0x001509AC
		internal virtual CheckBox importIncCoordCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._importIncCoordCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._importIncCoordCheckBox = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x001519B8 File Offset: 0x001509B8
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x001519D0 File Offset: 0x001509D0
		internal virtual CheckBox importIncFormatCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._importIncFormatCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._importIncFormatCheckBox = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x001519DC File Offset: 0x001509DC
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x001519F4 File Offset: 0x001509F4
		internal virtual GroupBox GroupBoxImportAscOptions
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBoxImportAscOptions;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBoxImportAscOptions = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00151A00 File Offset: 0x00150A00
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00151A18 File Offset: 0x00150A18
		internal virtual CheckBox ascImportQuoteCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ascImportQuoteCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ascImportQuoteCheckBox = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00151A24 File Offset: 0x00150A24
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00151A3C File Offset: 0x00150A3C
		internal virtual TabPage TabPageSTImport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPageSTImport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPageSTImport = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00151A48 File Offset: 0x00150A48
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00151A60 File Offset: 0x00150A60
		internal virtual GroupBox GroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox4 = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00151A6C File Offset: 0x00150A6C
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00151A84 File Offset: 0x00150A84
		internal virtual ComboBox STImportModeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportModeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportModeComboBox = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00151A90 File Offset: 0x00150A90
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00151AA8 File Offset: 0x00150AA8
		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00151AB4 File Offset: 0x00150AB4
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00151ACC File Offset: 0x00150ACC
		internal virtual PictureBox STImportMobilePictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportMobilePictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportMobilePictureBox = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00151AD8 File Offset: 0x00150AD8
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00151AF0 File Offset: 0x00150AF0
		internal virtual ComboBox STImportF120_130GTypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF120_130GTypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF120_130GTypeComboBox = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00151AFC File Offset: 0x00150AFC
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00151B14 File Offset: 0x00150B14
		internal virtual PictureBox STImportFixedPictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportFixedPictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportFixedPictureBox = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00151B20 File Offset: 0x00150B20
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00151B38 File Offset: 0x00150B38
		internal virtual ComboBox STImportMobileMagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportMobileMagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportMobileMagComboBox = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00151B44 File Offset: 0x00150B44
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00151B5C File Offset: 0x00150B5C
		internal virtual PictureBox STImportAllPictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportAllPictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportAllPictureBox = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00151B68 File Offset: 0x00150B68
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00151B80 File Offset: 0x00150B80
		internal virtual ComboBox STImportF100_119MagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF100_119MagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF100_119MagComboBox = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00151B8C File Offset: 0x00150B8C
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00151BA4 File Offset: 0x00150BA4
		internal virtual PictureBox STImportRFRPictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportRFRPictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportRFRPictureBox = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00151BB0 File Offset: 0x00150BB0
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00151BC8 File Offset: 0x00150BC8
		internal virtual ComboBox STImportMobileTypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportMobileTypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportMobileTypeComboBox = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00151BD4 File Offset: 0x00150BD4
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00151BEC File Offset: 0x00150BEC
		internal virtual PictureBox STImportM0_59PictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM0_59PictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM0_59PictureBox = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00151BF8 File Offset: 0x00150BF8
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00151C10 File Offset: 0x00150C10
		internal virtual ComboBox STImportF100_119TypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF100_119TypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF100_119TypeComboBox = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00151C1C File Offset: 0x00150C1C
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00151C34 File Offset: 0x00150C34
		internal virtual PictureBox STImportM60_79PictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM60_79PictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM60_79PictureBox = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00151C40 File Offset: 0x00150C40
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00151C58 File Offset: 0x00150C58
		internal virtual ComboBox STImportAllTypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportAllTypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportAllTypeComboBox = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00151C64 File Offset: 0x00150C64
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00151C7C File Offset: 0x00150C7C
		internal virtual PictureBox STImportM80_99PictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM80_99PictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM80_99PictureBox = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00151C88 File Offset: 0x00150C88
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00151CA0 File Offset: 0x00150CA0
		internal virtual ComboBox STImportFixedTypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportFixedTypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportFixedTypeComboBox = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00151CAC File Offset: 0x00150CAC
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00151CC4 File Offset: 0x00150CC4
		internal virtual PictureBox STImportM100_119PictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM100_119PictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM100_119PictureBox = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00151CD0 File Offset: 0x00150CD0
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00151CE8 File Offset: 0x00150CE8
		internal virtual ComboBox STImportFixedMagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportFixedMagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportFixedMagComboBox = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00151CF4 File Offset: 0x00150CF4
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00151D0C File Offset: 0x00150D0C
		internal virtual PictureBox STImportM120_130PictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM120_130PictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM120_130PictureBox = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00151D18 File Offset: 0x00150D18
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00151D30 File Offset: 0x00150D30
		internal virtual ComboBox STImportF120_130GMagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF120_130GMagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF120_130GMagComboBox = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00151D3C File Offset: 0x00150D3C
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00151D54 File Offset: 0x00150D54
		internal virtual PictureBox STImportF0_59PictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF0_59PictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF0_59PictureBox = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00151D60 File Offset: 0x00150D60
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00151D78 File Offset: 0x00150D78
		internal virtual ComboBox STImportAllMagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportAllMagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportAllMagComboBox = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00151D84 File Offset: 0x00150D84
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00151D9C File Offset: 0x00150D9C
		internal virtual PictureBox STImportF60_79PictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF60_79PictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF60_79PictureBox = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00151DA8 File Offset: 0x00150DA8
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00151DC0 File Offset: 0x00150DC0
		internal virtual Label STImportF120_130GLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF120_130GLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF120_130GLabel = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00151DCC File Offset: 0x00150DCC
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00151DE4 File Offset: 0x00150DE4
		internal virtual PictureBox STImportF80_99PictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF80_99PictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF80_99PictureBox = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00151DF0 File Offset: 0x00150DF0
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00151E08 File Offset: 0x00150E08
		internal virtual Label STImport100_119Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImport100_119Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImport100_119Label = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00151E14 File Offset: 0x00150E14
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00151E2C File Offset: 0x00150E2C
		internal virtual PictureBox STImportF100_119PictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF100_119PictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF100_119PictureBox = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00151E38 File Offset: 0x00150E38
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00151E50 File Offset: 0x00150E50
		internal virtual Label STImportMobileLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportMobileLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportMobileLabel = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00151E5C File Offset: 0x00150E5C
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00151E74 File Offset: 0x00150E74
		internal virtual PictureBox STImportF120_130GPictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF120_130GPictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF120_130GPictureBox = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00151E80 File Offset: 0x00150E80
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00151E98 File Offset: 0x00150E98
		internal virtual ComboBox STImportM120_130MagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM120_130MagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM120_130MagComboBox = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00151EA4 File Offset: 0x00150EA4
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00151EBC File Offset: 0x00150EBC
		internal virtual CheckBox STImportRFRCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportRFRCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportRFRCheckBox = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00151EC8 File Offset: 0x00150EC8
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00151EE0 File Offset: 0x00150EE0
		internal virtual CheckBox STImportF100_119CheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF100_119CheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF100_119CheckBox = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00151EEC File Offset: 0x00150EEC
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00151F04 File Offset: 0x00150F04
		internal virtual Label STImportRFRLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportRFRLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportRFRLabel = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00151F10 File Offset: 0x00150F10
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00151F28 File Offset: 0x00150F28
		internal virtual Label STImportAllLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportAllLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportAllLabel = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00151F34 File Offset: 0x00150F34
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00151F4C File Offset: 0x00150F4C
		internal virtual ComboBox STImportRFRMagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportRFRMagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportRFRMagComboBox = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00151F58 File Offset: 0x00150F58
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00151F70 File Offset: 0x00150F70
		internal virtual CheckBox STImportAllCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportAllCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportAllCheckBox = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00151F7C File Offset: 0x00150F7C
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00151F94 File Offset: 0x00150F94
		internal virtual ComboBox STImportRFRTypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportRFRTypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportRFRTypeComboBox = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00151FA0 File Offset: 0x00150FA0
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00151FB8 File Offset: 0x00150FB8
		internal virtual Label STImportFixedLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportFixedLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportFixedLabel = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00151FC4 File Offset: 0x00150FC4
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00151FDC File Offset: 0x00150FDC
		internal virtual CheckBox STImportM0_59CheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM0_59CheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM0_59CheckBox = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00151FE8 File Offset: 0x00150FE8
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00152000 File Offset: 0x00151000
		internal virtual CheckBox STImportF120_130GCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF120_130GCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF120_130GCheckBox = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0015200C File Offset: 0x0015100C
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00152024 File Offset: 0x00151024
		internal virtual CheckBox STImportM60_79CheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM60_79CheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM60_79CheckBox = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00152030 File Offset: 0x00151030
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00152048 File Offset: 0x00151048
		internal virtual CheckBox STImportMobileCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportMobileCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportMobileCheckBox = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00152054 File Offset: 0x00151054
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x0015206C File Offset: 0x0015106C
		internal virtual CheckBox STImportM80_99CheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM80_99CheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM80_99CheckBox = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00152078 File Offset: 0x00151078
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00152090 File Offset: 0x00151090
		internal virtual CheckBox STImportFixedCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportFixedCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportFixedCheckBox = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0015209C File Offset: 0x0015109C
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x001520B4 File Offset: 0x001510B4
		internal virtual CheckBox STImportM100_119CheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM100_119CheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM100_119CheckBox = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x001520C0 File Offset: 0x001510C0
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x001520D8 File Offset: 0x001510D8
		internal virtual ComboBox STImportF80_99TypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF80_99TypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF80_99TypeComboBox = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x001520E4 File Offset: 0x001510E4
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x001520FC File Offset: 0x001510FC
		internal virtual CheckBox STImportM120_130CheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM120_130CheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM120_130CheckBox = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00152108 File Offset: 0x00151108
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00152120 File Offset: 0x00151120
		internal virtual ComboBox STImport60_79TypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImport60_79TypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImport60_79TypeComboBox = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x0015212C File Offset: 0x0015112C
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x00152144 File Offset: 0x00151144
		internal virtual CheckBox STImportF0_59CheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF0_59CheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF0_59CheckBox = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00152150 File Offset: 0x00151150
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00152168 File Offset: 0x00151168
		internal virtual ComboBox STImportF0_59TypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF0_59TypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF0_59TypeComboBox = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00152174 File Offset: 0x00151174
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x0015218C File Offset: 0x0015118C
		internal virtual CheckBox STImportF60_79CheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF60_79CheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF60_79CheckBox = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00152198 File Offset: 0x00151198
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x001521B0 File Offset: 0x001511B0
		internal virtual ComboBox STImportM120_130TypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM120_130TypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM120_130TypeComboBox = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x001521BC File Offset: 0x001511BC
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x001521D4 File Offset: 0x001511D4
		internal virtual CheckBox STImportF80_99CheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF80_99CheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF80_99CheckBox = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x001521E0 File Offset: 0x001511E0
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x001521F8 File Offset: 0x001511F8
		internal virtual ComboBox STImportM100_119TypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM100_119TypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM100_119TypeComboBox = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00152204 File Offset: 0x00151204
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x0015221C File Offset: 0x0015121C
		internal virtual Label STImportM120_130Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM120_130Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM120_130Label = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00152228 File Offset: 0x00151228
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00152240 File Offset: 0x00151240
		internal virtual ComboBox STImportM80_99TypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM80_99TypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM80_99TypeComboBox = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0015224C File Offset: 0x0015124C
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00152264 File Offset: 0x00151264
		internal virtual Label STImportM100_119Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM100_119Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM100_119Label = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00152270 File Offset: 0x00151270
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00152288 File Offset: 0x00151288
		internal virtual ComboBox STImportM60_79TypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM60_79TypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM60_79TypeComboBox = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00152294 File Offset: 0x00151294
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x001522AC File Offset: 0x001512AC
		internal virtual Label STImportM80_99Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM80_99Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM80_99Label = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x001522B8 File Offset: 0x001512B8
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x001522D0 File Offset: 0x001512D0
		internal virtual ComboBox STImportM0_59TypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM0_59TypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM0_59TypeComboBox = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x001522DC File Offset: 0x001512DC
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x001522F4 File Offset: 0x001512F4
		internal virtual Label STImportM60_79Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM60_79Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM60_79Label = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00152300 File Offset: 0x00151300
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00152318 File Offset: 0x00151318
		internal virtual ComboBox STImportF80_99MagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF80_99MagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF80_99MagComboBox = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00152324 File Offset: 0x00151324
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0015233C File Offset: 0x0015133C
		internal virtual Label STImportM0_59Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM0_59Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM0_59Label = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00152348 File Offset: 0x00151348
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00152360 File Offset: 0x00151360
		internal virtual ComboBox STImportF60_79MagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF60_79MagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF60_79MagComboBox = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0015236C File Offset: 0x0015136C
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00152384 File Offset: 0x00151384
		internal virtual Label STImporF0_59Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImporF0_59Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImporF0_59Label = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00152390 File Offset: 0x00151390
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x001523A8 File Offset: 0x001513A8
		internal virtual ComboBox STImporF0_59MagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImporF0_59MagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImporF0_59MagComboBox = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x001523B4 File Offset: 0x001513B4
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x001523CC File Offset: 0x001513CC
		internal virtual Label STImportF60_79Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF60_79Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF60_79Label = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x001523D8 File Offset: 0x001513D8
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x001523F0 File Offset: 0x001513F0
		internal virtual ComboBox STImportM100_119MagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM100_119MagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM100_119MagComboBox = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x001523FC File Offset: 0x001513FC
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00152414 File Offset: 0x00151414
		internal virtual Label STImportF80_99Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportF80_99Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportF80_99Label = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00152420 File Offset: 0x00151420
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00152438 File Offset: 0x00151438
		internal virtual ComboBox STImportM80_99MagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM80_99MagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM80_99MagComboBox = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00152444 File Offset: 0x00151444
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x0015245C File Offset: 0x0015145C
		internal virtual ComboBox STImportM60_79MagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM60_79MagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM60_79MagComboBox = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00152468 File Offset: 0x00151468
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00152480 File Offset: 0x00151480
		internal virtual ComboBox STImportM0_59MagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportM0_59MagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportM0_59MagComboBox = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0015248C File Offset: 0x0015148C
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x001524A4 File Offset: 0x001514A4
		internal virtual TabPage TabPageName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPageName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPageName = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x001524B0 File Offset: 0x001514B0
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x001524C8 File Offset: 0x001514C8
		internal virtual Label nameExampleValueLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._nameExampleValueLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._nameExampleValueLabel = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x001524D4 File Offset: 0x001514D4
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x001524EC File Offset: 0x001514EC
		internal virtual Label nameExampleLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._nameExampleLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._nameExampleLabel = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x001524F8 File Offset: 0x001514F8
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00152510 File Offset: 0x00151510
		internal virtual GroupBox gpspasDisplayModeGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasDisplayModeGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasDisplayModeGroupBox = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0015251C File Offset: 0x0015151C
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00152534 File Offset: 0x00151534
		internal virtual CheckBox isGpsPasStartDisplayedCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._isGpsPasStartDisplayedCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._isGpsPasStartDisplayedCheckBox = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00152540 File Offset: 0x00151540
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00152558 File Offset: 0x00151558
		internal virtual CheckBox isGpsPasEndDisplayedCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._isGpsPasEndDisplayedCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._isGpsPasEndDisplayedCheckBox = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00152564 File Offset: 0x00151564
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x0015257C File Offset: 0x0015157C
		internal virtual CheckBox isGpsPasMiscDisplayedCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._isGpsPasMiscDisplayedCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._isGpsPasMiscDisplayedCheckBox = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00152588 File Offset: 0x00151588
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x001525A0 File Offset: 0x001515A0
		internal virtual CheckBox isGpsPasDirDisplayedCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._isGpsPasDirDisplayedCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._isGpsPasDirDisplayedCheckBox = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x001525AC File Offset: 0x001515AC
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x001525C4 File Offset: 0x001515C4
		internal virtual CheckBox isGpsPasSep2DisplayedCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._isGpsPasSep2DisplayedCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._isGpsPasSep2DisplayedCheckBox = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x001525D0 File Offset: 0x001515D0
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x001525E8 File Offset: 0x001515E8
		internal virtual CheckBox isGpsPasSpeedUnitDisplayedCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._isGpsPasSpeedUnitDisplayedCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._isGpsPasSpeedUnitDisplayedCheckBox = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x001525F4 File Offset: 0x001515F4
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x0015260C File Offset: 0x0015160C
		internal virtual CheckBox isGpsPasSpeedDisplayedCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._isGpsPasSpeedDisplayedCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._isGpsPasSpeedDisplayedCheckBox = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00152618 File Offset: 0x00151618
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00152630 File Offset: 0x00151630
		internal virtual CheckBox isGpsPasSep1DisplayedCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._isGpsPasSep1DisplayedCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._isGpsPasSep1DisplayedCheckBox = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0015263C File Offset: 0x0015163C
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00152654 File Offset: 0x00151654
		internal virtual CheckBox isGpsPasNumDisplayedCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._isGpsPasNumDisplayedCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._isGpsPasNumDisplayedCheckBox = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00152660 File Offset: 0x00151660
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00152678 File Offset: 0x00151678
		internal virtual CheckBox isGpsPasTypeDisplayedCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._isGpsPasTypeDisplayedCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._isGpsPasTypeDisplayedCheckBox = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00152684 File Offset: 0x00151684
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x0015269C File Offset: 0x0015169C
		internal virtual CheckBox isGpsPasRFRPostDisplayedCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._isGpsPasRFRPostDisplayedCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._isGpsPasRFRPostDisplayedCheckBox = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x001526A8 File Offset: 0x001516A8
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x001526C0 File Offset: 0x001516C0
		internal virtual GroupBox gpspasUserDefNameGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasUserDefNameGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasUserDefNameGroupBox = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x001526CC File Offset: 0x001516CC
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x001526E4 File Offset: 0x001516E4
		internal virtual TextBox gpspasUserDefNameTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasUserDefNameTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasUserDefNameTextBox = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x001526F0 File Offset: 0x001516F0
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00152708 File Offset: 0x00151708
		internal virtual GroupBox gpspasDirectionGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasDirectionGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasDirectionGroupBox = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00152714 File Offset: 0x00151714
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x0015272C File Offset: 0x0015172C
		internal virtual TextBox gpspasUnkTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasUnkTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasUnkTextBox = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00152738 File Offset: 0x00151738
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00152750 File Offset: 0x00151750
		internal virtual Label gpspasUnkLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasUnkLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasUnkLabel = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0015275C File Offset: 0x0015175C
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00152774 File Offset: 0x00151774
		internal virtual TextBox gpspasRearTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasRearTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasRearTextBox = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00152780 File Offset: 0x00151780
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00152798 File Offset: 0x00151798
		internal virtual Label gpspasRearLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasRearLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasRearLabel = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x001527A4 File Offset: 0x001517A4
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x001527BC File Offset: 0x001517BC
		internal virtual TextBox gpspasFrontTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasFrontTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasFrontTextBox = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x001527C8 File Offset: 0x001517C8
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x001527E0 File Offset: 0x001517E0
		internal virtual Label gpspasFrontLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasFrontLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasFrontLabel = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x001527EC File Offset: 0x001517EC
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00152804 File Offset: 0x00151804
		internal virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00152810 File Offset: 0x00151810
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00152828 File Offset: 0x00151828
		internal virtual TextBox gpspasSep2TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasSep2TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasSep2TextBox = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00152834 File Offset: 0x00151834
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x0015284C File Offset: 0x0015184C
		internal virtual TextBox gpspasSep1TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasSep1TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasSep1TextBox = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00152858 File Offset: 0x00151858
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00152870 File Offset: 0x00151870
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0015287C File Offset: 0x0015187C
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00152894 File Offset: 0x00151894
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x001528A0 File Offset: 0x001518A0
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x001528B8 File Offset: 0x001518B8
		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x001528C4 File Offset: 0x001518C4
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x001528DC File Offset: 0x001518DC
		internal virtual TextBox gpspasEndTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasEndTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasEndTextBox = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x001528E8 File Offset: 0x001518E8
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00152900 File Offset: 0x00151900
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0015290C File Offset: 0x0015190C
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00152924 File Offset: 0x00151924
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00152930 File Offset: 0x00151930
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00152948 File Offset: 0x00151948
		internal virtual TextBox gpspasStartTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasStartTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasStartTextBox = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00152954 File Offset: 0x00151954
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x0015296C File Offset: 0x0015196C
		internal virtual GroupBox gpspasSpeedGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasSpeedGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasSpeedGroupBox = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00152978 File Offset: 0x00151978
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00152990 File Offset: 0x00151990
		internal virtual TextBox gpspasSpeedUnitTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasSpeedUnitTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasSpeedUnitTextBox = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0015299C File Offset: 0x0015199C
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x001529B4 File Offset: 0x001519B4
		internal virtual Label gpspasSpeedLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasSpeedLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasSpeedLabel = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x001529C0 File Offset: 0x001519C0
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x001529D8 File Offset: 0x001519D8
		internal virtual GroupBox gpspasTypeGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasTypeGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasTypeGroupBox = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x001529E4 File Offset: 0x001519E4
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x001529FC File Offset: 0x001519FC
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00152A08 File Offset: 0x00151A08
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00152A20 File Offset: 0x00151A20
		internal virtual Button gpspasGraphTypeButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasGraphTypeButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasGraphTypeButton = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00152A2C File Offset: 0x00151A2C
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00152A44 File Offset: 0x00151A44
		internal virtual Button gpspasTextTypeButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasTextTypeButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasTextTypeButton = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00152A50 File Offset: 0x00151A50
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00152A68 File Offset: 0x00151A68
		internal virtual TextBox gpspasRDTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasRDTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasRDTextBox = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00152A74 File Offset: 0x00151A74
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00152A8C File Offset: 0x00151A8C
		internal virtual Label gpspasRDLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasRDLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasRDLabel = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00152A98 File Offset: 0x00151A98
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00152AB0 File Offset: 0x00151AB0
		internal virtual TextBox gpspasRFRTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasRFRTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasRFRTextBox = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00152ABC File Offset: 0x00151ABC
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00152AD4 File Offset: 0x00151AD4
		internal virtual TextBox gpspasRMTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasRMTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasRMTextBox = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00152AE0 File Offset: 0x00151AE0
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00152AF8 File Offset: 0x00151AF8
		internal virtual TextBox gpspasRFTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasRFTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasRFTextBox = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00152B04 File Offset: 0x00151B04
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00152B1C File Offset: 0x00151B1C
		internal virtual TextBox gpspasPLTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasPLTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasPLTextBox = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00152B28 File Offset: 0x00151B28
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00152B40 File Offset: 0x00151B40
		internal virtual TextBox gpspasPANTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasPANTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasPANTextBox = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00152B4C File Offset: 0x00151B4C
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00152B64 File Offset: 0x00151B64
		internal virtual Label gpspasRFRLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasRFRLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasRFRLabel = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00152B70 File Offset: 0x00151B70
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00152B88 File Offset: 0x00151B88
		internal virtual Label gpspasRMLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasRMLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasRMLabel = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00152B94 File Offset: 0x00151B94
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00152BAC File Offset: 0x00151BAC
		internal virtual Label gpspasRFLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasRFLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasRFLabel = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00152BB8 File Offset: 0x00151BB8
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x00152BD0 File Offset: 0x00151BD0
		internal virtual Label gpspasPLLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasPLLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasPLLabel = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00152BDC File Offset: 0x00151BDC
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00152BF4 File Offset: 0x00151BF4
		internal virtual Label gpspasPANLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._gpspasPANLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._gpspasPANLabel = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00152C00 File Offset: 0x00151C00
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00152C18 File Offset: 0x00151C18
		internal virtual ComboBox STImportAllNPTypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportAllNPTypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportAllNPTypeComboBox = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00152C24 File Offset: 0x00151C24
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00152C3C File Offset: 0x00151C3C
		internal virtual ComboBox STImportFixedNPTypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportFixedNPTypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportFixedNPTypeComboBox = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00152C48 File Offset: 0x00151C48
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00152C60 File Offset: 0x00151C60
		internal virtual ComboBox STImportMobileNPTypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STImportMobileNPTypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STImportMobileNPTypeComboBox = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00152C6C File Offset: 0x00151C6C
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00152C84 File Offset: 0x00151C84
		internal virtual GroupBox GroupBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox5 = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00152C90 File Offset: 0x00151C90
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00152CA8 File Offset: 0x00151CA8
		internal virtual ComboBox importDefaultTypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._importDefaultTypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._importDefaultTypeComboBox = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00152CB4 File Offset: 0x00151CB4
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00152CCC File Offset: 0x00151CCC
		internal virtual PictureBox importDefaultPictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._importDefaultPictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._importDefaultPictureBox = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00152CD8 File Offset: 0x00151CD8
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00152CF0 File Offset: 0x00151CF0
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00152CFC File Offset: 0x00151CFC
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00152D14 File Offset: 0x00151D14
		internal virtual ComboBox importDefaultMagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._importDefaultMagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._importDefaultMagComboBox = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00152D20 File Offset: 0x00151D20
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00152D38 File Offset: 0x00151D38
		internal virtual TabPage TabPageExport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPageExport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPageExport = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00152D44 File Offset: 0x00151D44
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00152D5C File Offset: 0x00151D5C
		internal virtual GroupBox GroupBox8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox8 = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00152D68 File Offset: 0x00151D68
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00152D80 File Offset: 0x00151D80
		internal virtual RadioButton exportTxtRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportTxtRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportTxtRadioButton = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00152D8C File Offset: 0x00151D8C
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00152DA4 File Offset: 0x00151DA4
		internal virtual RadioButton exportAscRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportAscRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportAscRadioButton = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00152DB0 File Offset: 0x00151DB0
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00152DC8 File Offset: 0x00151DC8
		internal virtual GroupBox GroupBox7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox7 = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00152DD4 File Offset: 0x00151DD4
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00152DEC File Offset: 0x00151DEC
		internal virtual CheckBox exportTelCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportTelCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportTelCheckBox = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00152DF8 File Offset: 0x00151DF8
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00152E10 File Offset: 0x00151E10
		internal virtual CheckBox exportAddressCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportAddressCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportAddressCheckBox = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00152E1C File Offset: 0x00151E1C
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00152E34 File Offset: 0x00151E34
		internal virtual CheckBox exportNameCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportNameCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportNameCheckBox = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00152E40 File Offset: 0x00151E40
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00152E58 File Offset: 0x00151E58
		internal virtual CheckBox exportLatCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportLatCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportLatCheckBox = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00152E64 File Offset: 0x00151E64
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00152E7C File Offset: 0x00151E7C
		internal virtual CheckBox exportBrandCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportBrandCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportBrandCheckBox = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00152E88 File Offset: 0x00151E88
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00152EA0 File Offset: 0x00151EA0
		internal virtual CheckBox exportCommentCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportCommentCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportCommentCheckBox = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00152EAC File Offset: 0x00151EAC
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00152EC4 File Offset: 0x00151EC4
		internal virtual CheckBox exportCityCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportCityCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportCityCheckBox = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00152ED0 File Offset: 0x00151ED0
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00152EE8 File Offset: 0x00151EE8
		internal virtual RadioButton exportCsvRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportCsvRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportCsvRadioButton = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00152EF4 File Offset: 0x00151EF4
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00152F0C File Offset: 0x00151F0C
		internal virtual TextBox exportFieldBrandTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportFieldBrandTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportFieldBrandTextBox = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00152F18 File Offset: 0x00151F18
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00152F30 File Offset: 0x00151F30
		internal virtual TextBox exportFieldCommentTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportFieldCommentTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportFieldCommentTextBox = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00152F3C File Offset: 0x00151F3C
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00152F54 File Offset: 0x00151F54
		internal virtual TextBox exportFieldTelTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportFieldTelTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportFieldTelTextBox = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00152F60 File Offset: 0x00151F60
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00152F78 File Offset: 0x00151F78
		internal virtual TextBox exportFieldCityTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportFieldCityTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportFieldCityTextBox = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00152F84 File Offset: 0x00151F84
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00152F9C File Offset: 0x00151F9C
		internal virtual TextBox exportFieldAddressTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportFieldAddressTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportFieldAddressTextBox = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00152FA8 File Offset: 0x00151FA8
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00152FC0 File Offset: 0x00151FC0
		internal virtual TextBox exportFieldNameTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportFieldNameTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportFieldNameTextBox = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00152FCC File Offset: 0x00151FCC
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00152FE4 File Offset: 0x00151FE4
		internal virtual TextBox exportFieldLonTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportFieldLonTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportFieldLonTextBox = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00152FF0 File Offset: 0x00151FF0
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00153008 File Offset: 0x00152008
		internal virtual TextBox exportFieldLatTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportFieldLatTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportFieldLatTextBox = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00153014 File Offset: 0x00152014
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x0015302C File Offset: 0x0015202C
		internal virtual CheckBox exportLonCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportLonCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportLonCheckBox = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00153038 File Offset: 0x00152038
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00153050 File Offset: 0x00152050
		internal virtual CheckBox exportRT3CheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportRT3CheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportRT3CheckBox = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0015305C File Offset: 0x0015205C
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00153074 File Offset: 0x00152074
		internal virtual GroupBox kmlExpOptGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._kmlExpOptGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._kmlExpOptGroupBox = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00153080 File Offset: 0x00152080
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00153098 File Offset: 0x00152098
		internal virtual CheckBox CheckBox10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox10 = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x001530A4 File Offset: 0x001520A4
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x001530BC File Offset: 0x001520BC
		internal virtual RadioButton exportKmlRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportKmlRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportKmlRadioButton = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x001530C8 File Offset: 0x001520C8
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x001530E0 File Offset: 0x001520E0
		internal virtual CheckBox CheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox1 = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x001530EC File Offset: 0x001520EC
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00153104 File Offset: 0x00152104
		internal virtual GroupBox csvExpOptGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._csvExpOptGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._csvExpOptGroupBox = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00153110 File Offset: 0x00152110
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00153128 File Offset: 0x00152128
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00153134 File Offset: 0x00152134
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x0015314C File Offset: 0x0015214C
		internal virtual GroupBox ascExpOptGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ascExpOptGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ascExpOptGroupBox = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00153158 File Offset: 0x00152158
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00153170 File Offset: 0x00152170
		internal virtual TextBox ascExportIntSepTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ascExportIntSepTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ascExportIntSepTextBox = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0015317C File Offset: 0x0015217C
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00153194 File Offset: 0x00152194
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x001531A0 File Offset: 0x001521A0
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x001531B8 File Offset: 0x001521B8
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x001531C4 File Offset: 0x001521C4
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x001531DC File Offset: 0x001521DC
		internal virtual CheckBox CheckBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox3 = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x001531E8 File Offset: 0x001521E8
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00153200 File Offset: 0x00152200
		internal virtual ComboBox ComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox1 = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0015320C File Offset: 0x0015220C
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00153224 File Offset: 0x00152224
		internal virtual TextBox exportFieldCountryTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportFieldCountryTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportFieldCountryTextBox = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00153230 File Offset: 0x00152230
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00153248 File Offset: 0x00152248
		internal virtual CheckBox exportCountryCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportCountryCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportCountryCheckBox = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00153254 File Offset: 0x00152254
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x0015326C File Offset: 0x0015226C
		internal virtual ComboBox exportCsvDecSepComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportCsvDecSepComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportCsvDecSepComboBox = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00153278 File Offset: 0x00152278
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00153290 File Offset: 0x00152290
		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0015329C File Offset: 0x0015229C
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x001532B4 File Offset: 0x001522B4
		internal virtual ComboBox exportCsvSepComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exportCsvSepComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exportCsvSepComboBox = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x001532C0 File Offset: 0x001522C0
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x001532D8 File Offset: 0x001522D8
		internal virtual GroupBox RT4GroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT4GroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RT4GroupBox = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x001532E4 File Offset: 0x001522E4
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x001532FC File Offset: 0x001522FC
		internal virtual CheckBox upgMapCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._upgMapCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._upgMapCheckBox = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00153308 File Offset: 0x00152308
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00153320 File Offset: 0x00152320
		internal virtual GroupBox RTxMapGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RTxMapGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RTxMapGroupBox = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0015332C File Offset: 0x0015232C
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x00153344 File Offset: 0x00152344
		internal virtual CheckBox AutoLoadCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AutoLoadCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._AutoLoadCheckBox = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00153350 File Offset: 0x00152350
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00153368 File Offset: 0x00152368
		internal virtual RadioButton RT4RadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT4RadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT4RadioButton != null;
				if (flag)
				{
					this._RT4RadioButton.Click -= this.RT4RadioButton_Click;
				}
				this._RT4RadioButton = value;
				flag = (this._RT4RadioButton != null);
				if (flag)
				{
					this._RT4RadioButton.Click += this.RT4RadioButton_Click;
				}
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x001533D4 File Offset: 0x001523D4
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x001533EC File Offset: 0x001523EC
		internal virtual RadioButton RT3RadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT3RadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT3RadioButton != null;
				if (flag)
				{
					this._RT3RadioButton.Click -= this.RT3RadioButton_Click;
				}
				this._RT3RadioButton = value;
				flag = (this._RT3RadioButton != null);
				if (flag)
				{
					this._RT3RadioButton.Click += this.RT3RadioButton_Click;
				}
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00153458 File Offset: 0x00152458
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x00153470 File Offset: 0x00152470
		internal virtual CheckBox CDRCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CDRCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._CDRCheckBox != null;
				if (flag)
				{
					this._CDRCheckBox.CheckedChanged -= this.CDRCheckBox_CheckedChanged;
				}
				this._CDRCheckBox = value;
				flag = (this._CDRCheckBox != null);
				if (flag)
				{
					this._CDRCheckBox.CheckedChanged += this.CDRCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x001534DC File Offset: 0x001524DC
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x001534F4 File Offset: 0x001524F4
		internal virtual CheckBox USBCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._USBCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._USBCheckBox != null;
				if (flag)
				{
					this._USBCheckBox.CheckedChanged -= this.USBCheckBox_CheckedChanged;
				}
				this._USBCheckBox = value;
				flag = (this._USBCheckBox != null);
				if (flag)
				{
					this._USBCheckBox.CheckedChanged += this.USBCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00153560 File Offset: 0x00152560
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00153578 File Offset: 0x00152578
		internal virtual RadioButton RT5HRRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT5HRRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT5HRRadioButton != null;
				if (flag)
				{
					this._RT5HRRadioButton.Click -= this.RT5HRRadioButton_Click;
				}
				this._RT5HRRadioButton = value;
				flag = (this._RT5HRRadioButton != null);
				if (flag)
				{
					this._RT5HRRadioButton.Click += this.RT5HRRadioButton_Click;
				}
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x001535E4 File Offset: 0x001525E4
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x001535FC File Offset: 0x001525FC
		internal virtual CheckBox forceRT3RadarDisplay
		{
			[DebuggerNonUserCode]
			get
			{
				return this._forceRT3RadarDisplay;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._forceRT3RadarDisplay = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00153608 File Offset: 0x00152608
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00153620 File Offset: 0x00152620
		internal virtual RadioButton RT5LRRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT5LRRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT5LRRadioButton != null;
				if (flag)
				{
					this._RT5LRRadioButton.Click -= this.RT5LRRadioButton_Click;
				}
				this._RT5LRRadioButton = value;
				flag = (this._RT5LRRadioButton != null);
				if (flag)
				{
					this._RT5LRRadioButton.Click += this.RT5LRRadioButton_Click;
				}
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0015368C File Offset: 0x0015268C
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x001536A4 File Offset: 0x001526A4
		internal virtual ComboBox SWVersComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SWVersComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SWVersComboBox = value;
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x001536B0 File Offset: 0x001526B0
		public ConfigDialog()
		{
			ArrayList _ENCList = ConfigDialog.__ENCList;
			lock (_ENCList)
			{
				ConfigDialog.__ENCList.Add(new WeakReference(this));
			}
			this.folderDialog = new FolderBrowserDialog();
			this.FileDialog = new OpenFileDialog();
			this.copyMap = new CopyMap();
			this.oldCursor = null;
			this.firstCursor = this.Cursor;
			this.mapIniName = null;
			this.IniFileExists = false;
			this.RT3SWVerList = new ArrayList();
			this.RT4SWVerList = new ArrayList();
			this.RT5SWVerList = new ArrayList();
			this.SWVersDialog = new SWVersDialog();
			this.InitializeComponent();
			SWVersDialog.setRTxVersionCombo(this.SWVersComboBox, Common.RTxType);
			this.SWVersComboBox.SelectedValue = Common.RTxVersion;
			this._oldRTxType = Common.RTxType;
			this.configDialogNameTabPage = new ConfigDialogNameTabPage(this);
			this.configDialogImportTabPage = new ConfigDialogImportTabPage(this, Common.RTxType);
			this.configDialogSTArchTabPage = new configDialogSTArchTabPage(this);
			this.configDialogExportTabPage = new ConfigDialogExportTabPage(this);
			this.reloadMap = false;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x001537E4 File Offset: 0x001527E4
		public DialogResult ShowDialog(ConfigDialog.tabList enabledTabs, ConfigDialog.tabList activeTab)
		{
			return this.ShowDialog(enabledTabs, activeTab, STArchives.ArchImportMode.Allmodes, false, true);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00153808 File Offset: 0x00152808
		public DialogResult ShowDialog(ConfigDialog.tabList enabledTabs, ConfigDialog.tabList activeTab, STArchives.ArchImportMode supportedModes, bool fixedOnly, bool RFR)
		{
			MyProject.Application.Log.WriteEntry("configDialog_ShowDialog() begin", TraceEventType.Information);
			this.reloadMap = false;
			this.EnableTabPages(enabledTabs);
			this.activateTabPage(activeTab);
			bool enabled = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map;
			this.WorkingDir_TextBox.Enabled = enabled;
			this.WorkingDirBrowse_Button.Enabled = enabled;
			this.WorkingDirFill_Button.Enabled = enabled;
			this.WorkingDirErase_Button.Enabled = enabled;
			this.ISODir_TextBox.Enabled = enabled;
			this.ISODirBrowse_Button.Enabled = enabled;
			this.ISODelete_Button.Enabled = enabled;
			this.WorkingDir_TextBox.Text = MySettingsProperty.Settings.WorkingDir;
			this.ISODir_TextBox.Text = MySettingsProperty.Settings.ISODir;
			bool flag = MyProject.Computer.FileSystem.FileExists(MySettingsProperty.Settings.BurningCommand);
			if (flag)
			{
				this.Command_TextBox.Text = MySettingsProperty.Settings.BurningCommand;
			}
			else
			{
				this.Command_TextBox.Text = "";
			}
			this.AutoLoadCheckBox.Checked = MySettingsProperty.Settings.autoLoad;
			flag = (Common.RTxType == Common.RTxTypes.typeRT5HR);
			if (flag)
			{
				this.RT3RadioButton.Checked = false;
				this.RT4RadioButton.Checked = false;
				this.RT5HRRadioButton.Checked = true;
				this.RT5LRRadioButton.Checked = false;
				this.RT4GroupBox.Enabled = true;
			}
			else
			{
				flag = (Common.RTxType == Common.RTxTypes.typeRT5LR);
				if (flag)
				{
					this.RT3RadioButton.Checked = false;
					this.RT4RadioButton.Checked = false;
					this.RT5HRRadioButton.Checked = false;
					this.RT5LRRadioButton.Checked = true;
					this.RT4GroupBox.Enabled = true;
				}
				else
				{
					flag = (Common.RTxType == Common.RTxTypes.typeRT4);
					if (flag)
					{
						this.RT3RadioButton.Checked = false;
						this.RT4RadioButton.Checked = true;
						this.RT5HRRadioButton.Checked = false;
						this.RT5LRRadioButton.Checked = false;
						this.RT4GroupBox.Enabled = true;
					}
					else
					{
						this.RT3RadioButton.Checked = true;
						this.RT4RadioButton.Checked = false;
						this.RT5HRRadioButton.Checked = false;
						this.RT5LRRadioButton.Checked = false;
						this.RT4GroupBox.Enabled = false;
					}
				}
			}
			this.forceRT3RadarDisplay.Checked = MySettingsProperty.Settings.forceRadarDisplay;
			this.CDRCheckBox.Checked = MySettingsProperty.Settings.RT4CDRMode;
			this.USBCheckBox.Checked = MySettingsProperty.Settings.RT4USBMode;
			this.upgMapCheckBox.Checked = MySettingsProperty.Settings.upgMap;
			this.configDialogImportTabPage.showDialog();
			this.configDialogNameTabPage.showDialog();
			this.configDialogSTArchTabPage.showDialog(supportedModes, fixedOnly, RFR);
			this.configDialogExportTabPage.showDialog();
			this.updateGUI();
			this.configDialogSTArchTabPage.updateGUI();
			this.ProgressBar.Enabled = false;
			this.ProgressBar.Visible = false;
			DialogResult result = base.ShowDialog();
			MyProject.Application.Log.WriteEntry("configDialog_ShowDialog() end", TraceEventType.Information);
			return result;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00153B40 File Offset: 0x00152B40
		private void updateGUI()
		{
			this.FolderGroupBox.Enabled = true;
			this.BurnGroupBox.Enabled = true;
			this.WorkingDirErase_Button.Enabled = (MyProject.Computer.FileSystem.DirectoryExists(this.WorkingDir_TextBox.Text) & Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
			this.mapIniName = Path.Combine(this.WorkingDir_TextBox.Text, "map.ini");
			this.IniFileExists = MyProject.Computer.FileSystem.FileExists(this.mapIniName);
			bool iniFileExists = this.IniFileExists;
			if (iniFileExists)
			{
				string key = Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "mapName");
				string file = Path.Combine(this.ISODir_TextBox.Text, key + ".iso");
				this.ISODelete_Button.Enabled = (MyProject.Computer.FileSystem.FileExists(file) & Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
			}
			else
			{
				this.ISODelete_Button.Enabled = false;
			}
			switch (this.isConfigCompleteGUI())
			{
			case ConfigDialog.configStatus.OK:
				this.CopyLabel.Text = string.Format(Resources.strMapCopied, Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "mapName"), Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "mapDesc"));
				this.OK_Button.Enabled = true;
				break;
			case ConfigDialog.configStatus.TooOld:
				this.CopyLabel.Text = string.Format(Resources.strMapTooOld, new object[0]);
				this.OK_Button.Enabled = true;
				break;
			case ConfigDialog.configStatus.mapKO:
				this.CopyLabel.Text = string.Format(Resources.strMapNotCopied, new object[0]);
				this.OK_Button.Enabled = true;
				break;
			case ConfigDialog.configStatus.configKO:
				this.CopyLabel.Text = string.Format(Resources.strMapCopied, Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "mapName"), Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "mapDesc"));
				this.OK_Button.Enabled = false;
				break;
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00153D64 File Offset: 0x00152D64
		private void EnableTabPages(ConfigDialog.tabList enabledTabs)
		{
			this.ConfigTabControl.TabPages[this.getTabName(ConfigDialog.tabList.general)].Enabled = ((enabledTabs & ConfigDialog.tabList.general) == ConfigDialog.tabList.general);
			this.ConfigTabControl.TabPages[this.getTabName(ConfigDialog.tabList.import)].Enabled = ((enabledTabs & ConfigDialog.tabList.import) == ConfigDialog.tabList.import);
			this.ConfigTabControl.TabPages[this.getTabName(ConfigDialog.tabList.STImport)].Enabled = ((enabledTabs & ConfigDialog.tabList.STImport) == ConfigDialog.tabList.STImport);
			this.ConfigTabControl.TabPages[this.getTabName(ConfigDialog.tabList.gpspassionName)].Enabled = ((enabledTabs & ConfigDialog.tabList.gpspassionName) == ConfigDialog.tabList.gpspassionName);
			this.ConfigTabControl.TabPages[this.getTabName(ConfigDialog.tabList.Export)].Enabled = ((enabledTabs & ConfigDialog.tabList.Export) == ConfigDialog.tabList.Export);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00153E28 File Offset: 0x00152E28
		private string getTabName(ConfigDialog.tabList activeTab)
		{
			switch (activeTab)
			{
			case ConfigDialog.tabList.general:
				return "TabPageGeneral";
			case ConfigDialog.tabList.import:
				return "TabPageImport";
			case ConfigDialog.tabList.STImport:
				return "TabPageSTImport";
			case ConfigDialog.tabList.gpspassionName:
				return "TabPageName";
			case ConfigDialog.tabList.Export:
				return "TabPageExport";
			}
			return "TabPageGeneral";
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00153EBC File Offset: 0x00152EBC
		private void activateTabPage(ConfigDialog.tabList activeTab)
		{
			bool flag = activeTab != ConfigDialog.tabList.last;
			if (flag)
			{
				this.ConfigTabControl.SelectedTab = this.ConfigTabControl.TabPages[this.getTabName(activeTab)];
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00153EFC File Offset: 0x00152EFC
		private void RT5HRRadioButton_Click(object sender, EventArgs e)
		{
			this.SWVersDialog.ShowDialog(Common.RTxTypes.typeRT5HR);
			this.RTxChangeMode();
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00153F14 File Offset: 0x00152F14
		private void RT5LRRadioButton_Click(object sender, EventArgs e)
		{
			this.SWVersDialog.ShowDialog(Common.RTxTypes.typeRT5LR);
			this.RTxChangeMode();
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00153F2C File Offset: 0x00152F2C
		private void RT4RadioButton_Click(object sender, EventArgs e)
		{
			this.SWVersDialog.ShowDialog(Common.RTxTypes.typeRT4);
			this.RTxChangeMode();
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00153F44 File Offset: 0x00152F44
		private void RT3RadioButton_Click(object sender, EventArgs e)
		{
			this.SWVersDialog.ShowDialog(Common.RTxTypes.typeRT3);
			this.RTxChangeMode();
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00153F5C File Offset: 0x00152F5C
		private void RTxChangeMode()
		{
			bool flag = Interaction.MsgBox(Resources.strChangeRTxMode, MsgBoxStyle.OkCancel, null) == MsgBoxResult.Ok;
			if (flag)
			{
				SWVersDialog.setRTxVersionCombo(this.SWVersComboBox, Common.RTxType);
				this.SWVersComboBox.SelectedValue = this.SWVersDialog.getSelectedSWVersion();
				flag = this.RT3RadioButton.Checked;
				if (flag)
				{
					Common.setRTxType(Common.RTxTypes.typeRT3);
					Common.setRTxVersion(this.SWVersDialog.getSelectedSWVersion());
				}
				else
				{
					flag = this.RT4RadioButton.Checked;
					if (flag)
					{
						Common.setRTxType(Common.RTxTypes.typeRT4);
						Common.setRTxVersion(this.SWVersDialog.getSelectedSWVersion());
					}
					else
					{
						flag = this.RT5HRRadioButton.Checked;
						if (flag)
						{
							Common.setRTxType(Common.RTxTypes.typeRT5HR);
							Common.setRTxVersion(this.SWVersDialog.getSelectedSWVersion());
						}
						else
						{
							Common.setRTxType(Common.RTxTypes.typeRT5LR);
							Common.setRTxVersion(this.SWVersDialog.getSelectedSWVersion());
						}
					}
				}
				MyProject.Application.Log.WriteEntry(string.Format("New RTXMode is {0:G}", Common.strRTxType), TraceEventType.Information);
				this.DialogResult = DialogResult.Abort;
				this.Close();
			}
			else
			{
				switch (this._oldRTxType)
				{
				case Common.RTxTypes.typeRT3:
					this.RT3RadioButton.Checked = true;
					this.RT4RadioButton.Checked = false;
					this.RT5HRRadioButton.Checked = false;
					this.RT5LRRadioButton.Checked = false;
					break;
				case Common.RTxTypes.typeRT4:
					this.RT3RadioButton.Checked = false;
					this.RT4RadioButton.Checked = true;
					this.RT5HRRadioButton.Checked = false;
					this.RT5LRRadioButton.Checked = false;
					break;
				case Common.RTxTypes.typeRT5HR:
					this.RT3RadioButton.Checked = false;
					this.RT4RadioButton.Checked = false;
					this.RT5HRRadioButton.Checked = true;
					this.RT5LRRadioButton.Checked = false;
					break;
				case Common.RTxTypes.typeRT5LR:
					this.RT3RadioButton.Checked = false;
					this.RT4RadioButton.Checked = false;
					this.RT5HRRadioButton.Checked = false;
					this.RT5LRRadioButton.Checked = true;
					break;
				}
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0015417C File Offset: 0x0015317C
		private void CDRCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.updateGUI();
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00154188 File Offset: 0x00153188
		private void USBCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.updateGUI();
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00154194 File Offset: 0x00153194
		private void workingDIRBrowse_Button_Click(object sender, EventArgs e)
		{
			this.folderDialog.ShowNewFolderButton = true;
			this.folderDialog.Description = Resources.strSelectWorkingDir;
			this.folderDialog.SelectedPath = this.WorkingDir_TextBox.Text;
			bool flag = this.folderDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.WorkingDir_TextBox.Text = this.folderDialog.SelectedPath;
			}
			this.updateGUI();
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0015420C File Offset: 0x0015320C
		private void workingDir_TextBox_Validating(object sender, CancelEventArgs e)
		{
			this.ISODir_TextBox.Text = this.WorkingDir_TextBox.Text;
			this.updateGUI();
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00154230 File Offset: 0x00153230
		private void workingDir_TextBox_TextChanged(object sender, EventArgs e)
		{
			this.ISODir_TextBox.Text = this.WorkingDir_TextBox.Text;
			this.updateGUI();
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00154254 File Offset: 0x00153254
		private void startLongProcess()
		{
			this.oldCursor = this.Cursor;
			this.Cursor = Cursors.WaitCursor;
			this.ProgressBar.MarqueeAnimationSpeed = 150;
			this.ProgressBar.Visible = true;
			this.ProgressBar.Enabled = true;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x001542A8 File Offset: 0x001532A8
		private void endLongProcess()
		{
			this.ProgressBar.MarqueeAnimationSpeed = 0;
			this.ProgressBar.Enabled = false;
			this.ProgressBar.Visible = false;
			this.Cursor = this.oldCursor;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x001542E0 File Offset: 0x001532E0
		private void WorkingDirFill_Button_Click(object sender, EventArgs e)
		{
			MyProject.Application.Log.WriteEntry("WorkingDirFill() begin", TraceEventType.Information);
			string text = "";
			string text2 = null;
			bool flag = false;
			bool flag2 = false;
			string text3 = this.WorkingDir_TextBox.Text;
			string origPath = Path.Combine(text3, "orig");
			string destPath = Path.Combine(text3, "dest");
			string directory = Path.Combine(text3, "temp");
			string file = Path.Combine(text3, "map.ini");
			CURR_VERS_NAVI curr_VERS_NAVI = null;
			int selectedCID = -1;
			bool flag3 = true;
			progressBox progressBox = new progressBox();
			checked
			{
				bool flag6;
				try
				{
					this.folderDialog.ShowNewFolderButton = false;
					this.folderDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
					this.folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
					this.folderDialog.Description = Resources.strSelectOrigMap;
					bool flag4 = this.folderDialog.ShowDialog() != DialogResult.OK;
					if (!flag4)
					{
						string selectedPath = this.folderDialog.SelectedPath;
						DirectoryInfo directoryInfo = new DirectoryInfo(selectedPath);
						Common.RTxMapType mapType = this.copyMap.getMapType(directoryInfo, selectedPath);
						string text4 = Path.Combine(selectedPath, "CURR_VERS_NAVI.DAT");
						flag4 = MyProject.Computer.FileSystem.FileExists(text4);
						string valeur;
						bool flag5;
						string text5;
						if (flag4)
						{
							valeur = "1";
							flag5 = true;
							curr_VERS_NAVI = new CURR_VERS_NAVI(text4, CURR_VERS_NAVI.mode.read);
							curr_VERS_NAVI.loadFromFile();
							List<string> cidlist = curr_VERS_NAVI.getCIDList();
							flag4 = (cidlist != null);
							if (!flag4)
							{
								MyProject.Application.Log.WriteEntry(Resources.strErrHddMapNotSup, TraceEventType.Error);
								Interaction.MsgBox(Resources.strErrHddMapNotSup, MsgBoxStyle.Exclamation, null);
								goto IL_6BB;
							}
							selectCIDDialog selectCIDDialog = new selectCIDDialog(cidlist, selectedPath, ref flag3);
							flag4 = flag3;
							if (flag4)
							{
								MyProject.Application.Log.WriteEntry(Resources.strErrHddMapNotSup, TraceEventType.Error);
								Interaction.MsgBox(Resources.strErrHddMapNotSup, MsgBoxStyle.Exclamation, null);
								goto IL_6BB;
							}
							selectCIDDialog.ShowDialog();
							flag4 = (selectCIDDialog.DialogResult != DialogResult.OK);
							if (flag4)
							{
								goto IL_6BB;
							}
							selectedCID = selectCIDDialog.getSelectedCID();
							text5 = selectedCID.ToString("d3");
						}
						else
						{
							valeur = "0";
							flag5 = false;
							text5 = this.copyMap.getMapCountry(directoryInfo, mapType);
							flag4 = (mapType == Common.RTxMapType.RT4);
							if (flag4)
							{
								int.TryParse(text5, out selectedCID);
							}
						}
						string vers = CopyMap.getVers(mapType, selectedPath, text5);
						int mapVers = int.Parse(vers);
						string rel = CopyMap.getRel(mapType, selectedPath, text5);
						int num = int.Parse(rel);
						string mapDate = this.copyMap.getMapDate(mapType, curr_VERS_NAVI, selectedCID, selectedPath);
						long num2;
						text = this.copyMap.getVolumeLabel(selectedPath, mapType, text5, vers, rel, ref num2, flag5, mapDate);
						int num3 = (int)Math.Round(Math.Round((double)num2 / 1048576.0));
						this.copyMap.checkGruppoValidity(selectedPath, mapType, text5, flag5, mapVers);
						this.Panel1.Enabled = false;
						this.CopyLabel.Text = string.Format(Resources.strDeleting, text3);
						directoryInfo = new DirectoryInfo(text3);
						flag4 = directoryInfo.Exists;
						if (flag4)
						{
							flag6 = (Interaction.MsgBox(string.Format(Resources.strWarningEraseDir, text3), MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question, null) != MsgBoxResult.Yes);
							if (flag6)
							{
								goto IL_6BB;
							}
							this.startLongProcess();
							MyProject.Computer.FileSystem.DeleteDirectory(text3, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
							this.endLongProcess();
						}
						flag6 = (mapType == Common.RTxMapType.RT3);
						long num4;
						if (flag6)
						{
							num4 = (long)Math.Round(unchecked(1.38 * (double)num2));
						}
						else
						{
							flag6 = flag5;
							if (flag6)
							{
								num4 = (long)Math.Round(unchecked(1.25 * (double)num2));
							}
							else
							{
								num4 = (long)Math.Round(unchecked(1.2 * (double)num2));
							}
						}
						DriveInfo driveInfo = new DriveInfo(text3);
						int num5 = (int)Math.Round(Math.Round((double)num4 / 1048576.0));
						flag6 = (driveInfo.AvailableFreeSpace < num4);
						if (flag6)
						{
							MyProject.Application.Log.WriteEntry(string.Format(Resources.strNotEnoughSpace, driveInfo.Name, num5), TraceEventType.Error);
							Interaction.MsgBox(string.Format(Resources.strNotEnoughSpace, driveInfo.Name, num5), MsgBoxStyle.Exclamation, null);
						}
						else
						{
							Interaction.MsgBox(string.Format(Resources.strWarningCopy, new object[]
							{
								num3,
								selectedPath,
								text3,
								text
							}), MsgBoxStyle.Exclamation, null);
							this.startLongProcess();
							this.copyMap.copyDestFolder(selectedPath, destPath, text, mapType, text5, vers, rel, flag5, curr_VERS_NAVI, this.CopyLabel);
							this.endLongProcess();
							this.startLongProcess();
							this.copyMap.CopyOrigFolder(text3, selectedPath, origPath, destPath, file, text5, mapType, flag5, ref text2, ref flag, ref flag2, this.CopyLabel);
							this.endLongProcess();
							this.Panel1.Enabled = true;
							this.copyMap.processConfigLog(mapType, origPath);
							this.copyMap.checkMapAfterCopy(selectedPath, text3, origPath, destPath, file, text5, mapType);
							MyProject.Computer.FileSystem.CreateDirectory(directory);
							Inifiles.SetKey(file, "MAP DESCRIPTION", "hddMap", valeur);
							Inifiles.SetKey(file, "MAP DESCRIPTION", "mapRadarAllowed", flag.ToString());
							Inifiles.SetKey(file, "MAP DESCRIPTION", "mapGuideAllowed", flag2.ToString());
							Inifiles.SetKey(file, "MAP DESCRIPTION", "mapName", text);
							Inifiles.SetKey(file, "MAP DESCRIPTION", "mapCountry", text5);
							Inifiles.SetKey(file, "MAP DESCRIPTION", "mapType", Common.getStrMapType(mapType));
							Inifiles.SetKey(file, "MAP DESCRIPTION", "mapSize", num2.ToString());
							Inifiles.SetKey(file, "MAP DESCRIPTION", "mapDesc", text2);
							Inifiles.SetKey(file, "MAP DESCRIPTION", "mapVers", vers);
							Inifiles.SetKey(file, "MAP DESCRIPTION", "mapRel", rel);
							Inifiles.SetKey(file, "MAP DESCRIPTION", "ISOPath", this.ISODir_TextBox.Text);
							Inifiles.SetKey(file, "MAP VERSION", "version", "1.2");
						}
					}
				}
				catch (SilentGUIException ex)
				{
				}
				catch (Exception ex2)
				{
					MyProject.Application.Log.WriteException(ex2);
					Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, null);
				}
				finally
				{
					this.endLongProcess();
					this.Cursor = this.firstCursor;
					this.Panel1.Enabled = true;
					this.updateGUI();
				}
				IL_6BB:
				flag6 = MyProject.Computer.FileSystem.FileExists(file);
				if (flag6)
				{
					this.CopyLabel.Text = string.Format(Resources.strMapCopied, text, text2);
				}
				else
				{
					this.CopyLabel.Text = string.Format(Resources.strMapNotCopied, new object[0]);
				}
				MyProject.Application.Log.WriteEntry("WorkingDirFill() end", TraceEventType.Information);
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00154A60 File Offset: 0x00153A60
		private void workingDirErase_Button_Click(object sender, EventArgs e)
		{
			MyProject.Application.Log.WriteEntry("workingDirErase() begin", TraceEventType.Information);
			string text = this.WorkingDir_TextBox.Text;
			DirectoryInfo directoryInfo = new DirectoryInfo(text);
			bool exists = directoryInfo.Exists;
			if (exists)
			{
				bool flag = Interaction.MsgBox(string.Format(Resources.strWarningEraseFolder, text), MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes;
				if (flag)
				{
					this.Panel1.Enabled = false;
					this.CopyLabel.Text = string.Format(Resources.strDeleting, text);
					Application.DoEvents();
					try
					{
						MyProject.Computer.FileSystem.DeleteDirectory(text, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
					}
					catch (Exception ex)
					{
						MyProject.Application.Log.WriteException(ex);
					}
					this.Panel1.Enabled = true;
				}
			}
			else
			{
				MyProject.Application.Log.WriteEntry(string.Format(Resources.strWarningNoDir, text), TraceEventType.Information);
				Interaction.MsgBox(string.Format(Resources.strWarningNoDir, text), MsgBoxStyle.Exclamation, null);
			}
			this.updateGUI();
			MyProject.Application.Log.WriteEntry("workingDirErase() end", TraceEventType.Information);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00154B94 File Offset: 0x00153B94
		private void ISODirBrowse_Button_Click(object sender, EventArgs e)
		{
			this.folderDialog.ShowNewFolderButton = true;
			this.folderDialog.Description = Resources.strSelectISODir;
			this.folderDialog.SelectedPath = this.ISODir_TextBox.Text;
			bool flag = this.folderDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.ISODir_TextBox.Text = this.folderDialog.SelectedPath;
			}
			this.updateGUI();
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00154C0C File Offset: 0x00153C0C
		private void ISODir_TextBox_Validating(object sender, CancelEventArgs e)
		{
			this.updateGUI();
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00154C18 File Offset: 0x00153C18
		private void ISODir_TextBox_TextChanged(object sender, EventArgs e)
		{
			this.updateGUI();
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00154C24 File Offset: 0x00153C24
		private void ISODelete_Button_Click(object sender, EventArgs e)
		{
			string file = Path.Combine(this.WorkingDir_TextBox.Text, "map.ini");
			MyProject.Application.Log.WriteEntry("ISODelete() begin", TraceEventType.Information);
			string key = Inifiles.GetKey(file, "MAP DESCRIPTION", "mapName");
			string text = Path.Combine(this.ISODir_TextBox.Text, key + ".iso");
			bool flag = MyProject.Computer.FileSystem.FileExists(text);
			if (flag)
			{
				bool flag2 = Interaction.MsgBox(string.Format(Resources.strWarningEraseFile, text), MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes;
				if (flag2)
				{
					try
					{
						MyProject.Computer.FileSystem.DeleteFile(text, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
					}
					catch (Exception ex)
					{
						MyProject.Application.Log.WriteException(ex);
					}
					this.updateGUI();
				}
			}
			else
			{
				MyProject.Application.Log.WriteEntry(string.Format(Resources.strWarningNoFile, text), TraceEventType.Information);
				Interaction.MsgBox(string.Format(Resources.strWarningNoFile, text), MsgBoxStyle.Exclamation, null);
			}
			MyProject.Application.Log.WriteEntry("ISODelete() begin", TraceEventType.Information);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00154D5C File Offset: 0x00153D5C
		private void CommandBrowse_Button_Click(object sender, EventArgs e)
		{
			bool flag = MyProject.Computer.FileSystem.FileExists(this.Command_TextBox.Text);
			if (flag)
			{
				this.FileDialog.FileName = this.Command_TextBox.Text;
			}
			else
			{
				this.FileDialog.FileName = "";
				this.FileDialog.InitialDirectory = MySettingsProperty.Settings.BurningCommand;
			}
			this.FileDialog.Title = Resources.strInstallBurner;
			this.FileDialog.Filter = "exe files (*.exe)|*.exe";
			this.FileDialog.CheckFileExists = true;
			this.FileDialog.ReadOnlyChecked = true;
			flag = (this.FileDialog.ShowDialog() == DialogResult.OK);
			if (flag)
			{
				this.Command_TextBox.Text = this.FileDialog.FileName;
			}
			this.updateGUI();
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00154E38 File Offset: 0x00153E38
		private void forceRT3RadarDisplay_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.Visible & this.forceRT3RadarDisplay.Checked;
			if (flag)
			{
				Interaction.MsgBox(Resources.strWarningDisplayRadar, MsgBoxStyle.Exclamation, null);
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00154E6C File Offset: 0x00153E6C
		private void OK_Button_Click(object sender, EventArgs e)
		{
			bool flag = false;
			MySettingsProperty.Settings.WorkingDir = this.WorkingDir_TextBox.Text;
			MySettingsProperty.Settings.ISODir = this.ISODir_TextBox.Text;
			bool flag2 = MyProject.Computer.FileSystem.FileExists(this.Command_TextBox.Text);
			if (flag2)
			{
				MySettingsProperty.Settings.BurningCommand = this.Command_TextBox.Text;
			}
			else
			{
				MySettingsProperty.Settings.BurningCommand = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
			}
			MySettingsProperty.Settings.autoLoad = this.AutoLoadCheckBox.Checked;
			MySettingsProperty.Settings.forceRadarDisplay = this.forceRT3RadarDisplay.Checked;
			flag2 = this.RT3RadioButton.Checked;
			bool flag3;
			if (flag2)
			{
				flag3 = (Common.RTxType != Common.RTxTypes.typeRT3);
				if (flag3)
				{
					flag = true;
				}
				Common.setRTxType(Common.RTxTypes.typeRT3);
			}
			else
			{
				flag3 = this.RT4RadioButton.Checked;
				if (flag3)
				{
					flag2 = (Common.RTxType != Common.RTxTypes.typeRT4);
					if (flag2)
					{
						flag = true;
					}
					Common.setRTxType(Common.RTxTypes.typeRT4);
				}
				else
				{
					flag3 = this.RT5HRRadioButton.Checked;
					if (flag3)
					{
						flag2 = (Common.RTxType != Common.RTxTypes.typeRT5HR);
						if (flag2)
						{
							flag = true;
						}
						Common.setRTxType(Common.RTxTypes.typeRT5HR);
					}
					else
					{
						flag3 = (Common.RTxType != Common.RTxTypes.typeRT5LR);
						if (flag3)
						{
							flag = true;
						}
						Common.setRTxType(Common.RTxTypes.typeRT5LR);
					}
				}
			}
			MySettingsProperty.Settings.upgMap = this.upgMapCheckBox.Checked;
			MySettingsProperty.Settings.RT4CDRMode = this.CDRCheckBox.Checked;
			MySettingsProperty.Settings.RT4USBMode = this.USBCheckBox.Checked;
			this.configDialogImportTabPage.OK_Button_Click();
			this.configDialogNameTabPage.OK_Button_Click();
			this.configDialogSTArchTabPage.OK_Button_Click();
			this.configDialogExportTabPage.OK_Button_Click();
			ConfigDialog.isConfigComplete();
			flag3 = flag;
			if (flag3)
			{
				MyProject.Application.Log.WriteEntry(string.Format("New RTXType is {0:G}", Common.strRTxType), TraceEventType.Information);
				Interaction.MsgBox(Resources.strChangeLanguage, MsgBoxStyle.OkOnly, null);
				this.DialogResult = DialogResult.Abort;
			}
			else
			{
				Common.setRTxVersion((Common.RTxVersions)Conversions.ToInteger(this.SWVersComboBox.SelectedValue));
				this.DialogResult = DialogResult.OK;
			}
			this.Close();
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00155094 File Offset: 0x00154094
		private void Cancel_Button_MouseEnter(object sender, EventArgs e)
		{
			base.AutoValidate = AutoValidate.Disable;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x001550A0 File Offset: 0x001540A0
		private void Cancel_Button_MouseLeave(object sender, EventArgs e)
		{
			base.AutoValidate = AutoValidate.EnableAllowFocusChange;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x001550AC File Offset: 0x001540AC
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.WorkingDir_TextBox.Text = MySettingsProperty.Settings.WorkingDir;
			this.ISODir_TextBox.Text = MySettingsProperty.Settings.ISODir;
			this.Command_TextBox.Text = MySettingsProperty.Settings.BurningCommand;
			this.upgMapCheckBox.Checked = MySettingsProperty.Settings.upgMap;
			ConfigDialog.isConfigComplete();
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00155128 File Offset: 0x00154128
		private bool createFolderIfNeeded(string path, CancelEventArgs e, bool confirm, bool spaceAllowed)
		{
			bool flag = true;
			bool flag2 = Directory.Exists(path);
			bool result;
			if (flag2)
			{
				result = true;
			}
			else
			{
				flag2 = (Operators.CompareString(path, "", false) == 0);
				if (flag2)
				{
					result = false;
				}
				else
				{
					flag2 = (flag && confirm);
					if (flag2)
					{
						flag = (Interaction.MsgBox(string.Format(Resources.strCreateFolder, path), MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question, null) == MsgBoxResult.Yes);
					}
					flag2 = flag;
					if (flag2)
					{
						try
						{
							Directory.CreateDirectory(path);
						}
						catch (Exception ex)
						{
							MyProject.Application.Log.WriteException(ex);
							Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
							flag = false;
						}
					}
					flag2 = !flag;
					if (flag2)
					{
						bool flag3 = e != null;
						if (flag3)
						{
							e.Cancel = true;
						}
					}
					result = flag;
				}
			}
			return result;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00155200 File Offset: 0x00154200
		private ConfigDialog.configStatus isConfigCompleteGUI()
		{
			bool flag = Common.RTxType == Common.RTxTypes.typeRT3 || this.CDRCheckBox.Checked || this.USBCheckBox.Checked;
			ConfigDialog.configStatus result;
			if (flag)
			{
				result = MapUpgrade.upgradeMap(this.WorkingDir_TextBox.Text);
			}
			else
			{
				flag = (MapUpgrade.upgradeMap(this.WorkingDir_TextBox.Text) == ConfigDialog.configStatus.mapKO);
				if (flag)
				{
					result = ConfigDialog.configStatus.mapKO;
				}
				else
				{
					result = ConfigDialog.configStatus.configKO;
				}
			}
			return result;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00155274 File Offset: 0x00154274
		public static ConfigDialog.configStatus isConfigComplete(string mapPath)
		{
			ConfigDialog.configStatus configStatus = MapUpgrade.upgradeMap(mapPath);
			MySettingsProperty.Settings.configComplete = (configStatus == ConfigDialog.configStatus.OK);
			return configStatus;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0015529C File Offset: 0x0015429C
		public static ConfigDialog.configStatus isConfigComplete()
		{
			ConfigDialog.configStatus configStatus = MapUpgrade.upgradeMap(MySettingsProperty.Settings.WorkingDir);
			MySettingsProperty.Settings.configComplete = (configStatus == ConfigDialog.configStatus.OK);
			return configStatus;
		}

		// Token: 0x04000219 RID: 537
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x0400021B RID: 539
		[AccessedThroughProperty("HelpProviderConfig")]
		private HelpProvider _HelpProviderConfig;

		// Token: 0x0400021C RID: 540
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x0400021D RID: 541
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x0400021E RID: 542
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x0400021F RID: 543
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000220 RID: 544
		[AccessedThroughProperty("ConfigTabControl")]
		private TabControl _ConfigTabControl;

		// Token: 0x04000221 RID: 545
		[AccessedThroughProperty("TabPageGeneral")]
		private TabPage _TabPageGeneral;

		// Token: 0x04000222 RID: 546
		[AccessedThroughProperty("FolderGroupBox")]
		private GroupBox _FolderGroupBox;

		// Token: 0x04000223 RID: 547
		[AccessedThroughProperty("ISODelete_Button")]
		private Button _ISODelete_Button;

		// Token: 0x04000224 RID: 548
		[AccessedThroughProperty("WorkingDirErase_Button")]
		private Button _WorkingDirErase_Button;

		// Token: 0x04000225 RID: 549
		[AccessedThroughProperty("ProgressBar")]
		private ProgressBar _ProgressBar;

		// Token: 0x04000226 RID: 550
		[AccessedThroughProperty("CopyLabel")]
		private Label _CopyLabel;

		// Token: 0x04000227 RID: 551
		[AccessedThroughProperty("ISODirBrowse_Button")]
		private Button _ISODirBrowse_Button;

		// Token: 0x04000228 RID: 552
		[AccessedThroughProperty("ISODir_TextBox")]
		private TextBox _ISODir_TextBox;

		// Token: 0x04000229 RID: 553
		[AccessedThroughProperty("ISODirLabel")]
		private Label _ISODirLabel;

		// Token: 0x0400022A RID: 554
		[AccessedThroughProperty("WorkingDirFill_Button")]
		private Button _WorkingDirFill_Button;

		// Token: 0x0400022B RID: 555
		[AccessedThroughProperty("WorkingDirBrowse_Button")]
		private Button _WorkingDirBrowse_Button;

		// Token: 0x0400022C RID: 556
		[AccessedThroughProperty("workingDir_Label")]
		private Label _workingDir_Label;

		// Token: 0x0400022D RID: 557
		[AccessedThroughProperty("WorkingDir_TextBox")]
		private TextBox _WorkingDir_TextBox;

		// Token: 0x0400022E RID: 558
		[AccessedThroughProperty("BurnGroupBox")]
		private GroupBox _BurnGroupBox;

		// Token: 0x0400022F RID: 559
		[AccessedThroughProperty("CommandBrowse_Button")]
		private Button _CommandBrowse_Button;

		// Token: 0x04000230 RID: 560
		[AccessedThroughProperty("Command_TextBox")]
		private TextBox _Command_TextBox;

		// Token: 0x04000231 RID: 561
		[AccessedThroughProperty("Command_Label")]
		private Label _Command_Label;

		// Token: 0x04000232 RID: 562
		[AccessedThroughProperty("TabPageImport")]
		private TabPage _TabPageImport;

		// Token: 0x04000233 RID: 563
		[AccessedThroughProperty("GroupBoxImportTxtOptions")]
		private GroupBox _GroupBoxImportTxtOptions;

		// Token: 0x04000234 RID: 564
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000235 RID: 565
		[AccessedThroughProperty("txtImportQuoteCheckBox")]
		private CheckBox _txtImportQuoteCheckBox;

		// Token: 0x04000236 RID: 566
		[AccessedThroughProperty("importTxtSepComboBox")]
		private ComboBox _importTxtSepComboBox;

		// Token: 0x04000237 RID: 567
		[AccessedThroughProperty("GroupBoxImportRT3")]
		private GroupBox _GroupBoxImportRT3;

		// Token: 0x04000238 RID: 568
		[AccessedThroughProperty("changeRT3MedicServCheckBox")]
		private CheckBox _changeRT3MedicServCheckBox;

		// Token: 0x04000239 RID: 569
		[AccessedThroughProperty("changeRT3MotorbCheckBox")]
		private CheckBox _changeRT3MotorbCheckBox;

		// Token: 0x0400023A RID: 570
		[AccessedThroughProperty("changeRT3CivicCheckBox")]
		private CheckBox _changeRT3CivicCheckBox;

		// Token: 0x0400023B RID: 571
		[AccessedThroughProperty("changeRT3PerfArtsCheckBox")]
		private CheckBox _changeRT3PerfArtsCheckBox;

		// Token: 0x0400023C RID: 572
		[AccessedThroughProperty("changeRT3BorderCheckBox")]
		private CheckBox _changeRT3BorderCheckBox;

		// Token: 0x0400023D RID: 573
		[AccessedThroughProperty("changeRT3IndustCheckBox")]
		private CheckBox _changeRT3IndustCheckBox;

		// Token: 0x0400023E RID: 574
		[AccessedThroughProperty("changeRT3EmbassyCheckBox")]
		private CheckBox _changeRT3EmbassyCheckBox;

		// Token: 0x0400023F RID: 575
		[AccessedThroughProperty("ignoreRT3BorgateCheckBox")]
		private CheckBox _ignoreRT3BorgateCheckBox;

		// Token: 0x04000240 RID: 576
		[AccessedThroughProperty("IgnoreRT3AltNameCheckBox")]
		private CheckBox _IgnoreRT3AltNameCheckBox;

		// Token: 0x04000241 RID: 577
		[AccessedThroughProperty("GroupBoxImportErrMngt")]
		private GroupBox _GroupBoxImportErrMngt;

		// Token: 0x04000242 RID: 578
		[AccessedThroughProperty("importLogErrCheckBox")]
		private CheckBox _importLogErrCheckBox;

		// Token: 0x04000243 RID: 579
		[AccessedThroughProperty("ImportEmptyAreaCheckBox")]
		private CheckBox _ImportEmptyAreaCheckBox;

		// Token: 0x04000244 RID: 580
		[AccessedThroughProperty("importIncCoordCheckBox")]
		private CheckBox _importIncCoordCheckBox;

		// Token: 0x04000245 RID: 581
		[AccessedThroughProperty("importIncFormatCheckBox")]
		private CheckBox _importIncFormatCheckBox;

		// Token: 0x04000246 RID: 582
		[AccessedThroughProperty("GroupBoxImportAscOptions")]
		private GroupBox _GroupBoxImportAscOptions;

		// Token: 0x04000247 RID: 583
		[AccessedThroughProperty("ascImportQuoteCheckBox")]
		private CheckBox _ascImportQuoteCheckBox;

		// Token: 0x04000248 RID: 584
		[AccessedThroughProperty("TabPageSTImport")]
		private TabPage _TabPageSTImport;

		// Token: 0x04000249 RID: 585
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x0400024A RID: 586
		[AccessedThroughProperty("STImportModeComboBox")]
		private ComboBox _STImportModeComboBox;

		// Token: 0x0400024B RID: 587
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x0400024C RID: 588
		[AccessedThroughProperty("STImportMobilePictureBox")]
		private PictureBox _STImportMobilePictureBox;

		// Token: 0x0400024D RID: 589
		[AccessedThroughProperty("STImportF120_130GTypeComboBox")]
		private ComboBox _STImportF120_130GTypeComboBox;

		// Token: 0x0400024E RID: 590
		[AccessedThroughProperty("STImportFixedPictureBox")]
		private PictureBox _STImportFixedPictureBox;

		// Token: 0x0400024F RID: 591
		[AccessedThroughProperty("STImportMobileMagComboBox")]
		private ComboBox _STImportMobileMagComboBox;

		// Token: 0x04000250 RID: 592
		[AccessedThroughProperty("STImportAllPictureBox")]
		private PictureBox _STImportAllPictureBox;

		// Token: 0x04000251 RID: 593
		[AccessedThroughProperty("STImportF100_119MagComboBox")]
		private ComboBox _STImportF100_119MagComboBox;

		// Token: 0x04000252 RID: 594
		[AccessedThroughProperty("STImportRFRPictureBox")]
		private PictureBox _STImportRFRPictureBox;

		// Token: 0x04000253 RID: 595
		[AccessedThroughProperty("STImportMobileTypeComboBox")]
		private ComboBox _STImportMobileTypeComboBox;

		// Token: 0x04000254 RID: 596
		[AccessedThroughProperty("STImportM0_59PictureBox")]
		private PictureBox _STImportM0_59PictureBox;

		// Token: 0x04000255 RID: 597
		[AccessedThroughProperty("STImportF100_119TypeComboBox")]
		private ComboBox _STImportF100_119TypeComboBox;

		// Token: 0x04000256 RID: 598
		[AccessedThroughProperty("STImportM60_79PictureBox")]
		private PictureBox _STImportM60_79PictureBox;

		// Token: 0x04000257 RID: 599
		[AccessedThroughProperty("STImportAllTypeComboBox")]
		private ComboBox _STImportAllTypeComboBox;

		// Token: 0x04000258 RID: 600
		[AccessedThroughProperty("STImportM80_99PictureBox")]
		private PictureBox _STImportM80_99PictureBox;

		// Token: 0x04000259 RID: 601
		[AccessedThroughProperty("STImportFixedTypeComboBox")]
		private ComboBox _STImportFixedTypeComboBox;

		// Token: 0x0400025A RID: 602
		[AccessedThroughProperty("STImportM100_119PictureBox")]
		private PictureBox _STImportM100_119PictureBox;

		// Token: 0x0400025B RID: 603
		[AccessedThroughProperty("STImportFixedMagComboBox")]
		private ComboBox _STImportFixedMagComboBox;

		// Token: 0x0400025C RID: 604
		[AccessedThroughProperty("STImportM120_130PictureBox")]
		private PictureBox _STImportM120_130PictureBox;

		// Token: 0x0400025D RID: 605
		[AccessedThroughProperty("STImportF120_130GMagComboBox")]
		private ComboBox _STImportF120_130GMagComboBox;

		// Token: 0x0400025E RID: 606
		[AccessedThroughProperty("STImportF0_59PictureBox")]
		private PictureBox _STImportF0_59PictureBox;

		// Token: 0x0400025F RID: 607
		[AccessedThroughProperty("STImportAllMagComboBox")]
		private ComboBox _STImportAllMagComboBox;

		// Token: 0x04000260 RID: 608
		[AccessedThroughProperty("STImportF60_79PictureBox")]
		private PictureBox _STImportF60_79PictureBox;

		// Token: 0x04000261 RID: 609
		[AccessedThroughProperty("STImportF120_130GLabel")]
		private Label _STImportF120_130GLabel;

		// Token: 0x04000262 RID: 610
		[AccessedThroughProperty("STImportF80_99PictureBox")]
		private PictureBox _STImportF80_99PictureBox;

		// Token: 0x04000263 RID: 611
		[AccessedThroughProperty("STImport100_119Label")]
		private Label _STImport100_119Label;

		// Token: 0x04000264 RID: 612
		[AccessedThroughProperty("STImportF100_119PictureBox")]
		private PictureBox _STImportF100_119PictureBox;

		// Token: 0x04000265 RID: 613
		[AccessedThroughProperty("STImportMobileLabel")]
		private Label _STImportMobileLabel;

		// Token: 0x04000266 RID: 614
		[AccessedThroughProperty("STImportF120_130GPictureBox")]
		private PictureBox _STImportF120_130GPictureBox;

		// Token: 0x04000267 RID: 615
		[AccessedThroughProperty("STImportM120_130MagComboBox")]
		private ComboBox _STImportM120_130MagComboBox;

		// Token: 0x04000268 RID: 616
		[AccessedThroughProperty("STImportRFRCheckBox")]
		private CheckBox _STImportRFRCheckBox;

		// Token: 0x04000269 RID: 617
		[AccessedThroughProperty("STImportF100_119CheckBox")]
		private CheckBox _STImportF100_119CheckBox;

		// Token: 0x0400026A RID: 618
		[AccessedThroughProperty("STImportRFRLabel")]
		private Label _STImportRFRLabel;

		// Token: 0x0400026B RID: 619
		[AccessedThroughProperty("STImportAllLabel")]
		private Label _STImportAllLabel;

		// Token: 0x0400026C RID: 620
		[AccessedThroughProperty("STImportRFRMagComboBox")]
		private ComboBox _STImportRFRMagComboBox;

		// Token: 0x0400026D RID: 621
		[AccessedThroughProperty("STImportAllCheckBox")]
		private CheckBox _STImportAllCheckBox;

		// Token: 0x0400026E RID: 622
		[AccessedThroughProperty("STImportRFRTypeComboBox")]
		private ComboBox _STImportRFRTypeComboBox;

		// Token: 0x0400026F RID: 623
		[AccessedThroughProperty("STImportFixedLabel")]
		private Label _STImportFixedLabel;

		// Token: 0x04000270 RID: 624
		[AccessedThroughProperty("STImportM0_59CheckBox")]
		private CheckBox _STImportM0_59CheckBox;

		// Token: 0x04000271 RID: 625
		[AccessedThroughProperty("STImportF120_130GCheckBox")]
		private CheckBox _STImportF120_130GCheckBox;

		// Token: 0x04000272 RID: 626
		[AccessedThroughProperty("STImportM60_79CheckBox")]
		private CheckBox _STImportM60_79CheckBox;

		// Token: 0x04000273 RID: 627
		[AccessedThroughProperty("STImportMobileCheckBox")]
		private CheckBox _STImportMobileCheckBox;

		// Token: 0x04000274 RID: 628
		[AccessedThroughProperty("STImportM80_99CheckBox")]
		private CheckBox _STImportM80_99CheckBox;

		// Token: 0x04000275 RID: 629
		[AccessedThroughProperty("STImportFixedCheckBox")]
		private CheckBox _STImportFixedCheckBox;

		// Token: 0x04000276 RID: 630
		[AccessedThroughProperty("STImportM100_119CheckBox")]
		private CheckBox _STImportM100_119CheckBox;

		// Token: 0x04000277 RID: 631
		[AccessedThroughProperty("STImportF80_99TypeComboBox")]
		private ComboBox _STImportF80_99TypeComboBox;

		// Token: 0x04000278 RID: 632
		[AccessedThroughProperty("STImportM120_130CheckBox")]
		private CheckBox _STImportM120_130CheckBox;

		// Token: 0x04000279 RID: 633
		[AccessedThroughProperty("STImport60_79TypeComboBox")]
		private ComboBox _STImport60_79TypeComboBox;

		// Token: 0x0400027A RID: 634
		[AccessedThroughProperty("STImportF0_59CheckBox")]
		private CheckBox _STImportF0_59CheckBox;

		// Token: 0x0400027B RID: 635
		[AccessedThroughProperty("STImportF0_59TypeComboBox")]
		private ComboBox _STImportF0_59TypeComboBox;

		// Token: 0x0400027C RID: 636
		[AccessedThroughProperty("STImportF60_79CheckBox")]
		private CheckBox _STImportF60_79CheckBox;

		// Token: 0x0400027D RID: 637
		[AccessedThroughProperty("STImportM120_130TypeComboBox")]
		private ComboBox _STImportM120_130TypeComboBox;

		// Token: 0x0400027E RID: 638
		[AccessedThroughProperty("STImportF80_99CheckBox")]
		private CheckBox _STImportF80_99CheckBox;

		// Token: 0x0400027F RID: 639
		[AccessedThroughProperty("STImportM100_119TypeComboBox")]
		private ComboBox _STImportM100_119TypeComboBox;

		// Token: 0x04000280 RID: 640
		[AccessedThroughProperty("STImportM120_130Label")]
		private Label _STImportM120_130Label;

		// Token: 0x04000281 RID: 641
		[AccessedThroughProperty("STImportM80_99TypeComboBox")]
		private ComboBox _STImportM80_99TypeComboBox;

		// Token: 0x04000282 RID: 642
		[AccessedThroughProperty("STImportM100_119Label")]
		private Label _STImportM100_119Label;

		// Token: 0x04000283 RID: 643
		[AccessedThroughProperty("STImportM60_79TypeComboBox")]
		private ComboBox _STImportM60_79TypeComboBox;

		// Token: 0x04000284 RID: 644
		[AccessedThroughProperty("STImportM80_99Label")]
		private Label _STImportM80_99Label;

		// Token: 0x04000285 RID: 645
		[AccessedThroughProperty("STImportM0_59TypeComboBox")]
		private ComboBox _STImportM0_59TypeComboBox;

		// Token: 0x04000286 RID: 646
		[AccessedThroughProperty("STImportM60_79Label")]
		private Label _STImportM60_79Label;

		// Token: 0x04000287 RID: 647
		[AccessedThroughProperty("STImportF80_99MagComboBox")]
		private ComboBox _STImportF80_99MagComboBox;

		// Token: 0x04000288 RID: 648
		[AccessedThroughProperty("STImportM0_59Label")]
		private Label _STImportM0_59Label;

		// Token: 0x04000289 RID: 649
		[AccessedThroughProperty("STImportF60_79MagComboBox")]
		private ComboBox _STImportF60_79MagComboBox;

		// Token: 0x0400028A RID: 650
		[AccessedThroughProperty("STImporF0_59Label")]
		private Label _STImporF0_59Label;

		// Token: 0x0400028B RID: 651
		[AccessedThroughProperty("STImporF0_59MagComboBox")]
		private ComboBox _STImporF0_59MagComboBox;

		// Token: 0x0400028C RID: 652
		[AccessedThroughProperty("STImportF60_79Label")]
		private Label _STImportF60_79Label;

		// Token: 0x0400028D RID: 653
		[AccessedThroughProperty("STImportM100_119MagComboBox")]
		private ComboBox _STImportM100_119MagComboBox;

		// Token: 0x0400028E RID: 654
		[AccessedThroughProperty("STImportF80_99Label")]
		private Label _STImportF80_99Label;

		// Token: 0x0400028F RID: 655
		[AccessedThroughProperty("STImportM80_99MagComboBox")]
		private ComboBox _STImportM80_99MagComboBox;

		// Token: 0x04000290 RID: 656
		[AccessedThroughProperty("STImportM60_79MagComboBox")]
		private ComboBox _STImportM60_79MagComboBox;

		// Token: 0x04000291 RID: 657
		[AccessedThroughProperty("STImportM0_59MagComboBox")]
		private ComboBox _STImportM0_59MagComboBox;

		// Token: 0x04000292 RID: 658
		[AccessedThroughProperty("TabPageName")]
		private TabPage _TabPageName;

		// Token: 0x04000293 RID: 659
		[AccessedThroughProperty("nameExampleValueLabel")]
		private Label _nameExampleValueLabel;

		// Token: 0x04000294 RID: 660
		[AccessedThroughProperty("nameExampleLabel")]
		private Label _nameExampleLabel;

		// Token: 0x04000295 RID: 661
		[AccessedThroughProperty("gpspasDisplayModeGroupBox")]
		private GroupBox _gpspasDisplayModeGroupBox;

		// Token: 0x04000296 RID: 662
		[AccessedThroughProperty("isGpsPasStartDisplayedCheckBox")]
		private CheckBox _isGpsPasStartDisplayedCheckBox;

		// Token: 0x04000297 RID: 663
		[AccessedThroughProperty("isGpsPasEndDisplayedCheckBox")]
		private CheckBox _isGpsPasEndDisplayedCheckBox;

		// Token: 0x04000298 RID: 664
		[AccessedThroughProperty("isGpsPasMiscDisplayedCheckBox")]
		private CheckBox _isGpsPasMiscDisplayedCheckBox;

		// Token: 0x04000299 RID: 665
		[AccessedThroughProperty("isGpsPasDirDisplayedCheckBox")]
		private CheckBox _isGpsPasDirDisplayedCheckBox;

		// Token: 0x0400029A RID: 666
		[AccessedThroughProperty("isGpsPasSep2DisplayedCheckBox")]
		private CheckBox _isGpsPasSep2DisplayedCheckBox;

		// Token: 0x0400029B RID: 667
		[AccessedThroughProperty("isGpsPasSpeedUnitDisplayedCheckBox")]
		private CheckBox _isGpsPasSpeedUnitDisplayedCheckBox;

		// Token: 0x0400029C RID: 668
		[AccessedThroughProperty("isGpsPasSpeedDisplayedCheckBox")]
		private CheckBox _isGpsPasSpeedDisplayedCheckBox;

		// Token: 0x0400029D RID: 669
		[AccessedThroughProperty("isGpsPasSep1DisplayedCheckBox")]
		private CheckBox _isGpsPasSep1DisplayedCheckBox;

		// Token: 0x0400029E RID: 670
		[AccessedThroughProperty("isGpsPasNumDisplayedCheckBox")]
		private CheckBox _isGpsPasNumDisplayedCheckBox;

		// Token: 0x0400029F RID: 671
		[AccessedThroughProperty("isGpsPasTypeDisplayedCheckBox")]
		private CheckBox _isGpsPasTypeDisplayedCheckBox;

		// Token: 0x040002A0 RID: 672
		[AccessedThroughProperty("isGpsPasRFRPostDisplayedCheckBox")]
		private CheckBox _isGpsPasRFRPostDisplayedCheckBox;

		// Token: 0x040002A1 RID: 673
		[AccessedThroughProperty("gpspasUserDefNameGroupBox")]
		private GroupBox _gpspasUserDefNameGroupBox;

		// Token: 0x040002A2 RID: 674
		[AccessedThroughProperty("gpspasUserDefNameTextBox")]
		private TextBox _gpspasUserDefNameTextBox;

		// Token: 0x040002A3 RID: 675
		[AccessedThroughProperty("gpspasDirectionGroupBox")]
		private GroupBox _gpspasDirectionGroupBox;

		// Token: 0x040002A4 RID: 676
		[AccessedThroughProperty("gpspasUnkTextBox")]
		private TextBox _gpspasUnkTextBox;

		// Token: 0x040002A5 RID: 677
		[AccessedThroughProperty("gpspasUnkLabel")]
		private Label _gpspasUnkLabel;

		// Token: 0x040002A6 RID: 678
		[AccessedThroughProperty("gpspasRearTextBox")]
		private TextBox _gpspasRearTextBox;

		// Token: 0x040002A7 RID: 679
		[AccessedThroughProperty("gpspasRearLabel")]
		private Label _gpspasRearLabel;

		// Token: 0x040002A8 RID: 680
		[AccessedThroughProperty("gpspasFrontTextBox")]
		private TextBox _gpspasFrontTextBox;

		// Token: 0x040002A9 RID: 681
		[AccessedThroughProperty("gpspasFrontLabel")]
		private Label _gpspasFrontLabel;

		// Token: 0x040002AA RID: 682
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x040002AB RID: 683
		[AccessedThroughProperty("gpspasSep2TextBox")]
		private TextBox _gpspasSep2TextBox;

		// Token: 0x040002AC RID: 684
		[AccessedThroughProperty("gpspasSep1TextBox")]
		private TextBox _gpspasSep1TextBox;

		// Token: 0x040002AD RID: 685
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040002AE RID: 686
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040002AF RID: 687
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x040002B0 RID: 688
		[AccessedThroughProperty("gpspasEndTextBox")]
		private TextBox _gpspasEndTextBox;

		// Token: 0x040002B1 RID: 689
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040002B2 RID: 690
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040002B3 RID: 691
		[AccessedThroughProperty("gpspasStartTextBox")]
		private TextBox _gpspasStartTextBox;

		// Token: 0x040002B4 RID: 692
		[AccessedThroughProperty("gpspasSpeedGroupBox")]
		private GroupBox _gpspasSpeedGroupBox;

		// Token: 0x040002B5 RID: 693
		[AccessedThroughProperty("gpspasSpeedUnitTextBox")]
		private TextBox _gpspasSpeedUnitTextBox;

		// Token: 0x040002B6 RID: 694
		[AccessedThroughProperty("gpspasSpeedLabel")]
		private Label _gpspasSpeedLabel;

		// Token: 0x040002B7 RID: 695
		[AccessedThroughProperty("gpspasTypeGroupBox")]
		private GroupBox _gpspasTypeGroupBox;

		// Token: 0x040002B8 RID: 696
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040002B9 RID: 697
		[AccessedThroughProperty("gpspasGraphTypeButton")]
		private Button _gpspasGraphTypeButton;

		// Token: 0x040002BA RID: 698
		[AccessedThroughProperty("gpspasTextTypeButton")]
		private Button _gpspasTextTypeButton;

		// Token: 0x040002BB RID: 699
		[AccessedThroughProperty("gpspasRDTextBox")]
		private TextBox _gpspasRDTextBox;

		// Token: 0x040002BC RID: 700
		[AccessedThroughProperty("gpspasRDLabel")]
		private Label _gpspasRDLabel;

		// Token: 0x040002BD RID: 701
		[AccessedThroughProperty("gpspasRFRTextBox")]
		private TextBox _gpspasRFRTextBox;

		// Token: 0x040002BE RID: 702
		[AccessedThroughProperty("gpspasRMTextBox")]
		private TextBox _gpspasRMTextBox;

		// Token: 0x040002BF RID: 703
		[AccessedThroughProperty("gpspasRFTextBox")]
		private TextBox _gpspasRFTextBox;

		// Token: 0x040002C0 RID: 704
		[AccessedThroughProperty("gpspasPLTextBox")]
		private TextBox _gpspasPLTextBox;

		// Token: 0x040002C1 RID: 705
		[AccessedThroughProperty("gpspasPANTextBox")]
		private TextBox _gpspasPANTextBox;

		// Token: 0x040002C2 RID: 706
		[AccessedThroughProperty("gpspasRFRLabel")]
		private Label _gpspasRFRLabel;

		// Token: 0x040002C3 RID: 707
		[AccessedThroughProperty("gpspasRMLabel")]
		private Label _gpspasRMLabel;

		// Token: 0x040002C4 RID: 708
		[AccessedThroughProperty("gpspasRFLabel")]
		private Label _gpspasRFLabel;

		// Token: 0x040002C5 RID: 709
		[AccessedThroughProperty("gpspasPLLabel")]
		private Label _gpspasPLLabel;

		// Token: 0x040002C6 RID: 710
		[AccessedThroughProperty("gpspasPANLabel")]
		private Label _gpspasPANLabel;

		// Token: 0x040002C7 RID: 711
		[AccessedThroughProperty("STImportAllNPTypeComboBox")]
		private ComboBox _STImportAllNPTypeComboBox;

		// Token: 0x040002C8 RID: 712
		[AccessedThroughProperty("STImportFixedNPTypeComboBox")]
		private ComboBox _STImportFixedNPTypeComboBox;

		// Token: 0x040002C9 RID: 713
		[AccessedThroughProperty("STImportMobileNPTypeComboBox")]
		private ComboBox _STImportMobileNPTypeComboBox;

		// Token: 0x040002CA RID: 714
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x040002CB RID: 715
		[AccessedThroughProperty("importDefaultTypeComboBox")]
		private ComboBox _importDefaultTypeComboBox;

		// Token: 0x040002CC RID: 716
		[AccessedThroughProperty("importDefaultPictureBox")]
		private PictureBox _importDefaultPictureBox;

		// Token: 0x040002CD RID: 717
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040002CE RID: 718
		[AccessedThroughProperty("importDefaultMagComboBox")]
		private ComboBox _importDefaultMagComboBox;

		// Token: 0x040002CF RID: 719
		[AccessedThroughProperty("TabPageExport")]
		private TabPage _TabPageExport;

		// Token: 0x040002D0 RID: 720
		[AccessedThroughProperty("GroupBox8")]
		private GroupBox _GroupBox8;

		// Token: 0x040002D1 RID: 721
		[AccessedThroughProperty("exportTxtRadioButton")]
		private RadioButton _exportTxtRadioButton;

		// Token: 0x040002D2 RID: 722
		[AccessedThroughProperty("exportAscRadioButton")]
		private RadioButton _exportAscRadioButton;

		// Token: 0x040002D3 RID: 723
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		// Token: 0x040002D4 RID: 724
		[AccessedThroughProperty("exportTelCheckBox")]
		private CheckBox _exportTelCheckBox;

		// Token: 0x040002D5 RID: 725
		[AccessedThroughProperty("exportAddressCheckBox")]
		private CheckBox _exportAddressCheckBox;

		// Token: 0x040002D6 RID: 726
		[AccessedThroughProperty("exportNameCheckBox")]
		private CheckBox _exportNameCheckBox;

		// Token: 0x040002D7 RID: 727
		[AccessedThroughProperty("exportLatCheckBox")]
		private CheckBox _exportLatCheckBox;

		// Token: 0x040002D8 RID: 728
		[AccessedThroughProperty("exportBrandCheckBox")]
		private CheckBox _exportBrandCheckBox;

		// Token: 0x040002D9 RID: 729
		[AccessedThroughProperty("exportCommentCheckBox")]
		private CheckBox _exportCommentCheckBox;

		// Token: 0x040002DA RID: 730
		[AccessedThroughProperty("exportCityCheckBox")]
		private CheckBox _exportCityCheckBox;

		// Token: 0x040002DB RID: 731
		[AccessedThroughProperty("exportCsvRadioButton")]
		private RadioButton _exportCsvRadioButton;

		// Token: 0x040002DC RID: 732
		[AccessedThroughProperty("exportFieldBrandTextBox")]
		private TextBox _exportFieldBrandTextBox;

		// Token: 0x040002DD RID: 733
		[AccessedThroughProperty("exportFieldCommentTextBox")]
		private TextBox _exportFieldCommentTextBox;

		// Token: 0x040002DE RID: 734
		[AccessedThroughProperty("exportFieldTelTextBox")]
		private TextBox _exportFieldTelTextBox;

		// Token: 0x040002DF RID: 735
		[AccessedThroughProperty("exportFieldCityTextBox")]
		private TextBox _exportFieldCityTextBox;

		// Token: 0x040002E0 RID: 736
		[AccessedThroughProperty("exportFieldAddressTextBox")]
		private TextBox _exportFieldAddressTextBox;

		// Token: 0x040002E1 RID: 737
		[AccessedThroughProperty("exportFieldNameTextBox")]
		private TextBox _exportFieldNameTextBox;

		// Token: 0x040002E2 RID: 738
		[AccessedThroughProperty("exportFieldLonTextBox")]
		private TextBox _exportFieldLonTextBox;

		// Token: 0x040002E3 RID: 739
		[AccessedThroughProperty("exportFieldLatTextBox")]
		private TextBox _exportFieldLatTextBox;

		// Token: 0x040002E4 RID: 740
		[AccessedThroughProperty("exportLonCheckBox")]
		private CheckBox _exportLonCheckBox;

		// Token: 0x040002E5 RID: 741
		[AccessedThroughProperty("exportRT3CheckBox")]
		private CheckBox _exportRT3CheckBox;

		// Token: 0x040002E6 RID: 742
		[AccessedThroughProperty("kmlExpOptGroupBox")]
		private GroupBox _kmlExpOptGroupBox;

		// Token: 0x040002E7 RID: 743
		[AccessedThroughProperty("CheckBox10")]
		private CheckBox _CheckBox10;

		// Token: 0x040002E8 RID: 744
		[AccessedThroughProperty("exportKmlRadioButton")]
		private RadioButton _exportKmlRadioButton;

		// Token: 0x040002E9 RID: 745
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x040002EA RID: 746
		[AccessedThroughProperty("csvExpOptGroupBox")]
		private GroupBox _csvExpOptGroupBox;

		// Token: 0x040002EB RID: 747
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040002EC RID: 748
		[AccessedThroughProperty("ascExpOptGroupBox")]
		private GroupBox _ascExpOptGroupBox;

		// Token: 0x040002ED RID: 749
		[AccessedThroughProperty("ascExportIntSepTextBox")]
		private TextBox _ascExportIntSepTextBox;

		// Token: 0x040002EE RID: 750
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040002EF RID: 751
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040002F0 RID: 752
		[AccessedThroughProperty("CheckBox3")]
		private CheckBox _CheckBox3;

		// Token: 0x040002F1 RID: 753
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x040002F2 RID: 754
		[AccessedThroughProperty("exportFieldCountryTextBox")]
		private TextBox _exportFieldCountryTextBox;

		// Token: 0x040002F3 RID: 755
		[AccessedThroughProperty("exportCountryCheckBox")]
		private CheckBox _exportCountryCheckBox;

		// Token: 0x040002F4 RID: 756
		[AccessedThroughProperty("exportCsvDecSepComboBox")]
		private ComboBox _exportCsvDecSepComboBox;

		// Token: 0x040002F5 RID: 757
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x040002F6 RID: 758
		[AccessedThroughProperty("exportCsvSepComboBox")]
		private ComboBox _exportCsvSepComboBox;

		// Token: 0x040002F7 RID: 759
		[AccessedThroughProperty("RT4GroupBox")]
		private GroupBox _RT4GroupBox;

		// Token: 0x040002F8 RID: 760
		[AccessedThroughProperty("upgMapCheckBox")]
		private CheckBox _upgMapCheckBox;

		// Token: 0x040002F9 RID: 761
		[AccessedThroughProperty("RTxMapGroupBox")]
		private GroupBox _RTxMapGroupBox;

		// Token: 0x040002FA RID: 762
		[AccessedThroughProperty("AutoLoadCheckBox")]
		private CheckBox _AutoLoadCheckBox;

		// Token: 0x040002FB RID: 763
		[AccessedThroughProperty("RT4RadioButton")]
		private RadioButton _RT4RadioButton;

		// Token: 0x040002FC RID: 764
		[AccessedThroughProperty("RT3RadioButton")]
		private RadioButton _RT3RadioButton;

		// Token: 0x040002FD RID: 765
		[AccessedThroughProperty("CDRCheckBox")]
		private CheckBox _CDRCheckBox;

		// Token: 0x040002FE RID: 766
		[AccessedThroughProperty("USBCheckBox")]
		private CheckBox _USBCheckBox;

		// Token: 0x040002FF RID: 767
		[AccessedThroughProperty("RT5HRRadioButton")]
		private RadioButton _RT5HRRadioButton;

		// Token: 0x04000300 RID: 768
		[AccessedThroughProperty("forceRT3RadarDisplay")]
		private CheckBox _forceRT3RadarDisplay;

		// Token: 0x04000301 RID: 769
		[AccessedThroughProperty("RT5LRRadioButton")]
		private RadioButton _RT5LRRadioButton;

		// Token: 0x04000302 RID: 770
		[AccessedThroughProperty("SWVersComboBox")]
		private ComboBox _SWVersComboBox;

		// Token: 0x04000303 RID: 771
		public bool reloadMap;

		// Token: 0x04000304 RID: 772
		private FolderBrowserDialog folderDialog;

		// Token: 0x04000305 RID: 773
		private OpenFileDialog FileDialog;

		// Token: 0x04000306 RID: 774
		private ConfigDialogNameTabPage configDialogNameTabPage;

		// Token: 0x04000307 RID: 775
		private ConfigDialogImportTabPage configDialogImportTabPage;

		// Token: 0x04000308 RID: 776
		private configDialogSTArchTabPage configDialogSTArchTabPage;

		// Token: 0x04000309 RID: 777
		private ConfigDialogExportTabPage configDialogExportTabPage;

		// Token: 0x0400030A RID: 778
		private CopyMap copyMap;

		// Token: 0x0400030B RID: 779
		private Cursor oldCursor;

		// Token: 0x0400030C RID: 780
		private Cursor firstCursor;

		// Token: 0x0400030D RID: 781
		private string mapIniName;

		// Token: 0x0400030E RID: 782
		private bool IniFileExists;

		// Token: 0x0400030F RID: 783
		private Common.RTxTypes _oldRTxType;

		// Token: 0x04000310 RID: 784
		private ArrayList RT3SWVerList;

		// Token: 0x04000311 RID: 785
		private ArrayList RT4SWVerList;

		// Token: 0x04000312 RID: 786
		private ArrayList RT5SWVerList;

		// Token: 0x04000313 RID: 787
		private SWVersDialog SWVersDialog;

		// Token: 0x02000031 RID: 49
		public enum configStatus
		{
			// Token: 0x04000315 RID: 789
			OK,
			// Token: 0x04000316 RID: 790
			TooOld,
			// Token: 0x04000317 RID: 791
			mapKO,
			// Token: 0x04000318 RID: 792
			configKO
		}

		// Token: 0x02000032 RID: 50
		public enum tabList : uint
		{
			// Token: 0x0400031A RID: 794
			last,
			// Token: 0x0400031B RID: 795
			general,
			// Token: 0x0400031C RID: 796
			import,
			// Token: 0x0400031D RID: 797
			STImport = 4U,
			// Token: 0x0400031E RID: 798
			gpspassionName = 8U,
			// Token: 0x0400031F RID: 799
			Export = 16U,
			// Token: 0x04000320 RID: 800
			all = 65535U
		}
	}
}
