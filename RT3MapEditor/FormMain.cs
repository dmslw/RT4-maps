using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public partial class FormMain : Form
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00139A70 File Offset: 0x00138A70
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00139A88 File Offset: 0x00138A88
		internal virtual MenuStrip MenuStrip
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MenuStrip;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuStrip = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00139A94 File Offset: 0x00138A94
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00139AAC File Offset: 0x00138AAC
		internal virtual ToolStripMenuItem File_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._File_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._File_ToolStripMenuItem = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00139AB8 File Offset: 0x00138AB8
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00139AD0 File Offset: 0x00138AD0
		internal virtual ToolStripMenuItem Import_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Import_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Import_ToolStripMenuItem != null;
				if (flag)
				{
					this._Import_ToolStripMenuItem.Click -= this.ImportToolStripMenuItem_Click;
				}
				this._Import_ToolStripMenuItem = value;
				flag = (this._Import_ToolStripMenuItem != null);
				if (flag)
				{
					this._Import_ToolStripMenuItem.Click += this.ImportToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00139B3C File Offset: 0x00138B3C
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00139B54 File Offset: 0x00138B54
		internal virtual ToolStripMenuItem Exit_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Exit_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Exit_ToolStripMenuItem != null;
				if (flag)
				{
					this._Exit_ToolStripMenuItem.Click -= this.SortirToolStripMenuItem_Click;
				}
				this._Exit_ToolStripMenuItem = value;
				flag = (this._Exit_ToolStripMenuItem != null);
				if (flag)
				{
					this._Exit_ToolStripMenuItem.Click += this.SortirToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00139BC0 File Offset: 0x00138BC0
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00139BD8 File Offset: 0x00138BD8
		internal virtual ToolStripMenuItem Help_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Help_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Help_ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00139BE4 File Offset: 0x00138BE4
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00139BFC File Offset: 0x00138BFC
		internal virtual ToolStripMenuItem ÀProposToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ÀProposToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ÀProposToolStripMenuItem != null;
				if (flag)
				{
					this._ÀProposToolStripMenuItem.Click -= this.ÀProposToolStripMenuItem_Click;
				}
				this._ÀProposToolStripMenuItem = value;
				flag = (this._ÀProposToolStripMenuItem != null);
				if (flag)
				{
					this._ÀProposToolStripMenuItem.Click += this.ÀProposToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00139C68 File Offset: 0x00138C68
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00139C80 File Offset: 0x00138C80
		internal virtual ToolStrip ToolStrip
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStrip;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStrip = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00139C8C File Offset: 0x00138C8C
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00139CA4 File Offset: 0x00138CA4
		internal virtual ToolStripButton Import_ToolStripButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Import_ToolStripButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Import_ToolStripButton != null;
				if (flag)
				{
					this._Import_ToolStripButton.Click -= this.ToolStripButtonImporter_Click;
				}
				this._Import_ToolStripButton = value;
				flag = (this._Import_ToolStripButton != null);
				if (flag)
				{
					this._Import_ToolStripButton.Click += this.ToolStripButtonImporter_Click;
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00139D10 File Offset: 0x00138D10
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00139D28 File Offset: 0x00138D28
		internal virtual StatusStrip StatusStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StatusStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StatusStrip1 = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00139D34 File Offset: 0x00138D34
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00139D4C File Offset: 0x00138D4C
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripStatusLabel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripStatusLabel1 = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00139D58 File Offset: 0x00138D58
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00139D70 File Offset: 0x00138D70
		internal virtual ToolStripStatusLabel ToolStripStatusLabelSatus
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripStatusLabelSatus;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripStatusLabelSatus = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00139D7C File Offset: 0x00138D7C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00139D94 File Offset: 0x00138D94
		internal virtual ToolStripMenuItem Language_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Language_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Language_ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00139DA0 File Offset: 0x00138DA0
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00139DB8 File Offset: 0x00138DB8
		internal virtual ToolStripMenuItem FrançaisToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FrançaisToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._FrançaisToolStripMenuItem != null;
				if (flag)
				{
					this._FrançaisToolStripMenuItem.Click -= this.FrançaisToolStripMenuItem_Click;
				}
				this._FrançaisToolStripMenuItem = value;
				flag = (this._FrançaisToolStripMenuItem != null);
				if (flag)
				{
					this._FrançaisToolStripMenuItem.Click += this.FrançaisToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00139E24 File Offset: 0x00138E24
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00139E3C File Offset: 0x00138E3C
		internal virtual ToolStripMenuItem EnglishToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EnglishToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._EnglishToolStripMenuItem != null;
				if (flag)
				{
					this._EnglishToolStripMenuItem.Click -= this.EnglishToolStripMenuItem_Click;
				}
				this._EnglishToolStripMenuItem = value;
				flag = (this._EnglishToolStripMenuItem != null);
				if (flag)
				{
					this._EnglishToolStripMenuItem.Click += this.EnglishToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00139EA8 File Offset: 0x00138EA8
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00139EC0 File Offset: 0x00138EC0
		internal virtual ToolStripButton Patch_ToolStripButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Patch_ToolStripButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Patch_ToolStripButton != null;
				if (flag)
				{
					this._Patch_ToolStripButton.Click -= this.Patch_ToolStripButton_Click;
				}
				this._Patch_ToolStripButton = value;
				flag = (this._Patch_ToolStripButton != null);
				if (flag)
				{
					this._Patch_ToolStripButton.Click += this.Patch_ToolStripButton_Click;
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00139F2C File Offset: 0x00138F2C
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00139F44 File Offset: 0x00138F44
		internal virtual ToolStripButton Burn_ToolStripButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Burn_ToolStripButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Burn_ToolStripButton != null;
				if (flag)
				{
					this._Burn_ToolStripButton.Click -= this.Burn_ToolStripButton_Click;
				}
				this._Burn_ToolStripButton = value;
				flag = (this._Burn_ToolStripButton != null);
				if (flag)
				{
					this._Burn_ToolStripButton.Click += this.Burn_ToolStripButton_Click;
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00139FB0 File Offset: 0x00138FB0
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00139FC8 File Offset: 0x00138FC8
		internal virtual ToolStripButton Configure_ToolStripButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Configure_ToolStripButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Configure_ToolStripButton != null;
				if (flag)
				{
					this._Configure_ToolStripButton.Click -= this.Configure_ToolStripButton_Click;
				}
				this._Configure_ToolStripButton = value;
				flag = (this._Configure_ToolStripButton != null);
				if (flag)
				{
					this._Configure_ToolStripButton.Click += this.Configure_ToolStripButton_Click;
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0013A034 File Offset: 0x00139034
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0013A04C File Offset: 0x0013904C
		internal virtual ToolStripMenuItem Patch_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Patch_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Patch_ToolStripMenuItem != null;
				if (flag)
				{
					this._Patch_ToolStripMenuItem.Click -= this.Patch_ToolStripMenuItem_Click;
				}
				this._Patch_ToolStripMenuItem = value;
				flag = (this._Patch_ToolStripMenuItem != null);
				if (flag)
				{
					this._Patch_ToolStripMenuItem.Click += this.Patch_ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0013A0B8 File Offset: 0x001390B8
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0013A0D0 File Offset: 0x001390D0
		internal virtual ToolStripMenuItem Burn_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Burn_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Burn_ToolStripMenuItem != null;
				if (flag)
				{
					this._Burn_ToolStripMenuItem.Click -= this.Burn_ToolStripMenuItem_Click;
				}
				this._Burn_ToolStripMenuItem = value;
				flag = (this._Burn_ToolStripMenuItem != null);
				if (flag)
				{
					this._Burn_ToolStripMenuItem.Click += this.Burn_ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0013A13C File Offset: 0x0013913C
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0013A154 File Offset: 0x00139154
		internal virtual ContextMenuStrip ImportedFilesContextMenuStrip
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImportedFilesContextMenuStrip;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImportedFilesContextMenuStrip = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0013A160 File Offset: 0x00139160
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0013A178 File Offset: 0x00139178
		internal virtual ToolStripMenuItem DeleteToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DeleteToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._DeleteToolStripMenuItem != null;
				if (flag)
				{
					this._DeleteToolStripMenuItem.Click -= this.DeleteToolStripMenuItem_Click;
				}
				this._DeleteToolStripMenuItem = value;
				flag = (this._DeleteToolStripMenuItem != null);
				if (flag)
				{
					this._DeleteToolStripMenuItem.Click += this.DeleteToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0013A1E4 File Offset: 0x001391E4
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0013A1FC File Offset: 0x001391FC
		internal virtual ToolStripMenuItem MergeToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MergeToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._MergeToolStripMenuItem != null;
				if (flag)
				{
					this._MergeToolStripMenuItem.Click -= this.MergeToolStripMenuItem_Click;
				}
				this._MergeToolStripMenuItem = value;
				flag = (this._MergeToolStripMenuItem != null);
				if (flag)
				{
					this._MergeToolStripMenuItem.Click += this.MergeToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0013A268 File Offset: 0x00139268
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0013A280 File Offset: 0x00139280
		internal virtual ToolStripMenuItem RenameToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RenameToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RenameToolStripMenuItem != null;
				if (flag)
				{
					this._RenameToolStripMenuItem.Click -= this.RenameToolStripMenuItem_Click;
				}
				this._RenameToolStripMenuItem = value;
				flag = (this._RenameToolStripMenuItem != null);
				if (flag)
				{
					this._RenameToolStripMenuItem.Click += this.RenameToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0013A2EC File Offset: 0x001392EC
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0013A304 File Offset: 0x00139304
		internal virtual ToolStripMenuItem RemoveDuplicatesToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RemoveDuplicatesToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RemoveDuplicatesToolStripMenuItem != null;
				if (flag)
				{
					this._RemoveDuplicatesToolStripMenuItem.Click -= this.RemoveDuplicatesToolStripMenuItem_Click;
				}
				this._RemoveDuplicatesToolStripMenuItem = value;
				flag = (this._RemoveDuplicatesToolStripMenuItem != null);
				if (flag)
				{
					this._RemoveDuplicatesToolStripMenuItem.Click += this.RemoveDuplicatesToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0013A370 File Offset: 0x00139370
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0013A388 File Offset: 0x00139388
		internal virtual TabControl RT3OptionTabControl
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT3OptionTabControl;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RT3OptionTabControl = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0013A394 File Offset: 0x00139394
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0013A3AC File Offset: 0x001393AC
		internal virtual TabPage RT3OptionTabPage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT3OptionTabPage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RT3OptionTabPage = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0013A3B8 File Offset: 0x001393B8
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0013A3D0 File Offset: 0x001393D0
		internal virtual ComboBox RT3OTypeComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT3OTypeComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT3OTypeComboBox != null;
				if (flag)
				{
					this._RT3OTypeComboBox.SelectedIndexChanged -= this.RT3OTypeComboBoxSelectedIndexChanged;
				}
				this._RT3OTypeComboBox = value;
				flag = (this._RT3OTypeComboBox != null);
				if (flag)
				{
					this._RT3OTypeComboBox.SelectedIndexChanged += this.RT3OTypeComboBoxSelectedIndexChanged;
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0013A43C File Offset: 0x0013943C
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0013A454 File Offset: 0x00139454
		internal virtual ComboBox RT3OLayerComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT3OLayerComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT3OLayerComboBox != null;
				if (flag)
				{
					this._RT3OLayerComboBox.SelectedIndexChanged -= this.RT3OLayerComboBoxSelectedIndexChanged;
				}
				this._RT3OLayerComboBox = value;
				flag = (this._RT3OLayerComboBox != null);
				if (flag)
				{
					this._RT3OLayerComboBox.SelectedIndexChanged += this.RT3OLayerComboBoxSelectedIndexChanged;
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0013A4C0 File Offset: 0x001394C0
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0013A4D8 File Offset: 0x001394D8
		internal virtual Label POITypeLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._POITypeLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._POITypeLabel = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0013A4E4 File Offset: 0x001394E4
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0013A4FC File Offset: 0x001394FC
		internal virtual ComboBox RT3OScaleComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT3OScaleComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT3OScaleComboBox != null;
				if (flag)
				{
					this._RT3OScaleComboBox.SelectedIndexChanged -= this.RT3OScaleComboBoxSelectedIndexChanged;
				}
				this._RT3OScaleComboBox = value;
				flag = (this._RT3OScaleComboBox != null);
				if (flag)
				{
					this._RT3OScaleComboBox.SelectedIndexChanged += this.RT3OScaleComboBoxSelectedIndexChanged;
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0013A568 File Offset: 0x00139568
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0013A580 File Offset: 0x00139580
		internal virtual Label POIScaleLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._POIScaleLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._POIScaleLabel = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0013A58C File Offset: 0x0013958C
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0013A5A4 File Offset: 0x001395A4
		internal virtual Label POILayerLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._POILayerLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._POILayerLabel = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0013A5B0 File Offset: 0x001395B0
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0013A5C8 File Offset: 0x001395C8
		internal virtual TabPage namedPlaceTabPage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._namedPlaceTabPage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._namedPlaceTabPage = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0013A5D4 File Offset: 0x001395D4
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0013A5EC File Offset: 0x001395EC
		internal virtual TabPage TabPage3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage3 = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0013A5F8 File Offset: 0x001395F8
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0013A610 File Offset: 0x00139610
		internal virtual TabPage TabPage4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage4 = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0013A61C File Offset: 0x0013961C
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0013A634 File Offset: 0x00139634
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0013A640 File Offset: 0x00139640
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0013A658 File Offset: 0x00139658
		internal virtual GroupBox ImportedFilesPropertiesGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImportedFilesPropertiesGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImportedFilesPropertiesGroupBox = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0013A664 File Offset: 0x00139664
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0013A67C File Offset: 0x0013967C
		internal virtual ToolStripButton ISO_ToolStripButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ISO_ToolStripButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ISO_ToolStripButton != null;
				if (flag)
				{
					this._ISO_ToolStripButton.Click -= this.ISO_ToolStripButton_Click;
				}
				this._ISO_ToolStripButton = value;
				flag = (this._ISO_ToolStripButton != null);
				if (flag)
				{
					this._ISO_ToolStripButton.Click += this.ISO_ToolStripButton_Click;
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0013A6E8 File Offset: 0x001396E8
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0013A700 File Offset: 0x00139700
		internal virtual ToolStripMenuItem ISO_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ISO_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ISO_ToolStripMenuItem != null;
				if (flag)
				{
					this._ISO_ToolStripMenuItem.Click -= this.ISO_ToolStripMenuItem_Click;
				}
				this._ISO_ToolStripMenuItem = value;
				flag = (this._ISO_ToolStripMenuItem != null);
				if (flag)
				{
					this._ISO_ToolStripMenuItem.Click += this.ISO_ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0013A76C File Offset: 0x0013976C
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0013A784 File Offset: 0x00139784
		internal virtual ToolStripMenuItem ConfigureF_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ConfigureF_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ConfigureF_ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0013A790 File Offset: 0x00139790
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0013A7A8 File Offset: 0x001397A8
		internal virtual PictureBox POITypePictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._POITypePictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._POITypePictureBox = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0013A7B4 File Offset: 0x001397B4
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0013A7CC File Offset: 0x001397CC
		internal virtual ToolStripProgressBar ToolStripProgressBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripProgressBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripProgressBar1 = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0013A7D8 File Offset: 0x001397D8
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0013A7F0 File Offset: 0x001397F0
		internal virtual ToolStripMenuItem UsersGuideToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UsersGuideToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._UsersGuideToolStripMenuItem != null;
				if (flag)
				{
					this._UsersGuideToolStripMenuItem.Click -= this.UsersGuideToolStripMenuItem_Click;
				}
				this._UsersGuideToolStripMenuItem = value;
				flag = (this._UsersGuideToolStripMenuItem != null);
				if (flag)
				{
					this._UsersGuideToolStripMenuItem.Click += this.UsersGuideToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0013A85C File Offset: 0x0013985C
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0013A874 File Offset: 0x00139874
		internal virtual ToolStripMenuItem LogfileToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LogfileToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._LogfileToolStripMenuItem != null;
				if (flag)
				{
					this._LogfileToolStripMenuItem.Click -= this.LogfileToolStripMenuItem_Click;
				}
				this._LogfileToolStripMenuItem = value;
				flag = (this._LogfileToolStripMenuItem != null);
				if (flag)
				{
					this._LogfileToolStripMenuItem.Click += this.LogfileToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0013A8E0 File Offset: 0x001398E0
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0013A8F8 File Offset: 0x001398F8
		internal virtual ToolStripMenuItem LicenseToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LicenseToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._LicenseToolStripMenuItem != null;
				if (flag)
				{
					this._LicenseToolStripMenuItem.Click -= this.LicenseToolStripMenuItem_Click;
				}
				this._LicenseToolStripMenuItem = value;
				flag = (this._LicenseToolStripMenuItem != null);
				if (flag)
				{
					this._LicenseToolStripMenuItem.Click += this.LicenseToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0013A964 File Offset: 0x00139964
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0013A97C File Offset: 0x0013997C
		internal virtual TextBox UserDefNameTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UserDefNameTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UserDefNameTextBox = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0013A988 File Offset: 0x00139988
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0013A9A0 File Offset: 0x001399A0
		internal virtual ComboBox ComboBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox3 = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0013A9AC File Offset: 0x001399AC
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0013A9C4 File Offset: 0x001399C4
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

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0013A9D0 File Offset: 0x001399D0
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0013A9E8 File Offset: 0x001399E8
		internal virtual ComboBox ComboBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox2 = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0013A9F4 File Offset: 0x001399F4
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0013AA0C File Offset: 0x00139A0C
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

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0013AA18 File Offset: 0x00139A18
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0013AA30 File Offset: 0x00139A30
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0013AA3C File Offset: 0x00139A3C
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0013AA54 File Offset: 0x00139A54
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0013AA60 File Offset: 0x00139A60
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0013AA78 File Offset: 0x00139A78
		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0013AA84 File Offset: 0x00139A84
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0013AA9C File Offset: 0x00139A9C
		internal virtual RadioButton nameGpsPassionRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._nameGpsPassionRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._nameGpsPassionRadioButton = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0013AAA8 File Offset: 0x00139AA8
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0013AAC0 File Offset: 0x00139AC0
		internal virtual RadioButton nameUserDefinedRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._nameUserDefinedRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._nameUserDefinedRadioButton = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0013AACC File Offset: 0x00139ACC
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0013AAE4 File Offset: 0x00139AE4
		internal virtual RadioButton nameAsIsRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._nameAsIsRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._nameAsIsRadioButton = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0013AAF0 File Offset: 0x00139AF0
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0013AB08 File Offset: 0x00139B08
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0013AB14 File Offset: 0x00139B14
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0013AB2C File Offset: 0x00139B2C
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0013AB38 File Offset: 0x00139B38
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0013AB50 File Offset: 0x00139B50
		internal virtual ComboBox RT3OMagComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT3OMagComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT3OMagComboBox != null;
				if (flag)
				{
					this._RT3OMagComboBox.SelectedIndexChanged -= this.RT3OMagComboBox_SelectedIndexChanged;
				}
				this._RT3OMagComboBox = value;
				flag = (this._RT3OMagComboBox != null);
				if (flag)
				{
					this._RT3OMagComboBox.SelectedIndexChanged += this.RT3OMagComboBox_SelectedIndexChanged;
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0013ABBC File Offset: 0x00139BBC
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0013ABD4 File Offset: 0x00139BD4
		internal virtual Label POIMagLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._POIMagLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._POIMagLabel = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0013ABE0 File Offset: 0x00139BE0
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0013ABF8 File Offset: 0x00139BF8
		internal virtual Panel namegpspasFormatPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._namegpspasFormatPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._namegpspasFormatPanel = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0013AC04 File Offset: 0x00139C04
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0013AC1C File Offset: 0x00139C1C
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

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0013AC28 File Offset: 0x00139C28
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0013AC40 File Offset: 0x00139C40
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

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0013AC4C File Offset: 0x00139C4C
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0013AC64 File Offset: 0x00139C64
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

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0013AC70 File Offset: 0x00139C70
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0013AC88 File Offset: 0x00139C88
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0013AC94 File Offset: 0x00139C94
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0013ACAC File Offset: 0x00139CAC
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

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0013ACB8 File Offset: 0x00139CB8
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0013ACD0 File Offset: 0x00139CD0
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0013ACDC File Offset: 0x00139CDC
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0013ACF4 File Offset: 0x00139CF4
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

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0013AD00 File Offset: 0x00139D00
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0013AD18 File Offset: 0x00139D18
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

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0013AD24 File Offset: 0x00139D24
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0013AD3C File Offset: 0x00139D3C
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0013AD48 File Offset: 0x00139D48
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0013AD60 File Offset: 0x00139D60
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0013AD6C File Offset: 0x00139D6C
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0013AD84 File Offset: 0x00139D84
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

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0013AD90 File Offset: 0x00139D90
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0013ADA8 File Offset: 0x00139DA8
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0013ADB4 File Offset: 0x00139DB4
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0013ADCC File Offset: 0x00139DCC
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

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0013ADD8 File Offset: 0x00139DD8
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x0013ADF0 File Offset: 0x00139DF0
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0013ADFC File Offset: 0x00139DFC
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0013AE14 File Offset: 0x00139E14
		internal virtual ToolStripMenuItem ExportToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExportToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ExportToolStripMenuItem != null;
				if (flag)
				{
					this._ExportToolStripMenuItem.Click -= this.ExportToolStripMenuItem_Click;
				}
				this._ExportToolStripMenuItem = value;
				flag = (this._ExportToolStripMenuItem != null);
				if (flag)
				{
					this._ExportToolStripMenuItem.Click += this.ExportToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0013AE80 File Offset: 0x00139E80
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0013AE98 File Offset: 0x00139E98
		internal virtual CheckBox RT3OFullPatchCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT3OFullPatchCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT3OFullPatchCheckBox != null;
				if (flag)
				{
					this._RT3OFullPatchCheckBox.CheckedChanged -= this.RT3OFullPatchCheckBox_CheckedChanged;
				}
				this._RT3OFullPatchCheckBox = value;
				flag = (this._RT3OFullPatchCheckBox != null);
				if (flag)
				{
					this._RT3OFullPatchCheckBox.CheckedChanged += this.RT3OFullPatchCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0013AF04 File Offset: 0x00139F04
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0013AF1C File Offset: 0x00139F1C
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0013AF28 File Offset: 0x00139F28
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0013AF40 File Offset: 0x00139F40
		internal virtual CheckBox RT3ODisplayMagCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT3ODisplayMagCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT3ODisplayMagCheckBox != null;
				if (flag)
				{
					this._RT3ODisplayMagCheckBox.CheckedChanged -= this.RT3ODisplayMagCheckBox_CheckedChanged;
				}
				this._RT3ODisplayMagCheckBox = value;
				flag = (this._RT3ODisplayMagCheckBox != null);
				if (flag)
				{
					this._RT3ODisplayMagCheckBox.CheckedChanged += this.RT3ODisplayMagCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0013AFAC File Offset: 0x00139FAC
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0013AFC4 File Offset: 0x00139FC4
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0013AFD0 File Offset: 0x00139FD0
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0013AFE8 File Offset: 0x00139FE8
		internal virtual ToolStripMenuItem POIradarListsToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._POIradarListsToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._POIradarListsToolStripMenuItem != null;
				if (flag)
				{
					this._POIradarListsToolStripMenuItem.Click -= this.POIradarListsToolStripMenuItem_Click;
				}
				this._POIradarListsToolStripMenuItem = value;
				flag = (this._POIradarListsToolStripMenuItem != null);
				if (flag)
				{
					this._POIradarListsToolStripMenuItem.Click += this.POIradarListsToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0013B054 File Offset: 0x0013A054
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0013B06C File Offset: 0x0013A06C
		internal virtual ToolStripMenuItem HackingToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HackingToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._HackingToolStripMenuItem = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0013B078 File Offset: 0x0013A078
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0013B090 File Offset: 0x0013A090
		internal virtual ToolStripMenuItem RT3MapEditorAndTheHackingToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT3MapEditorAndTheHackingToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT3MapEditorAndTheHackingToolStripMenuItem != null;
				if (flag)
				{
					this._RT3MapEditorAndTheHackingToolStripMenuItem.Click -= this.RT3MapEditorAndTheHackingToolStripMenuItem_Click;
				}
				this._RT3MapEditorAndTheHackingToolStripMenuItem = value;
				flag = (this._RT3MapEditorAndTheHackingToolStripMenuItem != null);
				if (flag)
				{
					this._RT3MapEditorAndTheHackingToolStripMenuItem.Click += this.RT3MapEditorAndTheHackingToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0013B0FC File Offset: 0x0013A0FC
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0013B114 File Offset: 0x0013A114
		internal virtual ToolStripMenuItem PortuguêsToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PortuguêsToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._PortuguêsToolStripMenuItem != null;
				if (flag)
				{
					this._PortuguêsToolStripMenuItem.Click -= this.PortuguêsToolStripMenuItem_Click;
				}
				this._PortuguêsToolStripMenuItem = value;
				flag = (this._PortuguêsToolStripMenuItem != null);
				if (flag)
				{
					this._PortuguêsToolStripMenuItem.Click += this.PortuguêsToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0013B180 File Offset: 0x0013A180
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0013B198 File Offset: 0x0013A198
		internal virtual ToolStripButton USB_ToolStripButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._USB_ToolStripButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._USB_ToolStripButton != null;
				if (flag)
				{
					this._USB_ToolStripButton.Click -= this.USB_ToolStripButton1_Click;
				}
				this._USB_ToolStripButton = value;
				flag = (this._USB_ToolStripButton != null);
				if (flag)
				{
					this._USB_ToolStripButton.Click += this.USB_ToolStripButton1_Click;
				}
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0013B204 File Offset: 0x0013A204
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0013B21C File Offset: 0x0013A21C
		internal virtual ToolStripMenuItem USB_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._USB_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._USB_ToolStripMenuItem != null;
				if (flag)
				{
					this._USB_ToolStripMenuItem.Click -= this.USBToolStripMenuItem_Click;
				}
				this._USB_ToolStripMenuItem = value;
				flag = (this._USB_ToolStripMenuItem != null);
				if (flag)
				{
					this._USB_ToolStripMenuItem.Click += this.USBToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0013B288 File Offset: 0x0013A288
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0013B2A0 File Offset: 0x0013A2A0
		internal virtual ToolStripMenuItem RT4_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT4_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RT4_ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0013B2AC File Offset: 0x0013A2AC
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0013B2C4 File Offset: 0x0013A2C4
		internal virtual ToolStripMenuItem RT4MapUSBToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT4MapUSBToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT4MapUSBToolStripMenuItem != null;
				if (flag)
				{
					this._RT4MapUSBToolStripMenuItem.Click -= this.RT4MapUSBToolStripMenuItem_Click;
				}
				this._RT4MapUSBToolStripMenuItem = value;
				flag = (this._RT4MapUSBToolStripMenuItem != null);
				if (flag)
				{
					this._RT4MapUSBToolStripMenuItem.Click += this.RT4MapUSBToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0013B330 File Offset: 0x0013A330
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0013B348 File Offset: 0x0013A348
		internal virtual ToolStripMenuItem Tools_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tools_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Tools_ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0013B354 File Offset: 0x0013A354
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0013B36C File Offset: 0x0013A36C
		internal virtual ToolStripMenuItem SplitMapGfxgphToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SplitMapGfxgphToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._SplitMapGfxgphToolStripMenuItem != null;
				if (flag)
				{
					this._SplitMapGfxgphToolStripMenuItem.Click -= this.SplitMapGfxgphToolStripMenuItem_Click;
				}
				this._SplitMapGfxgphToolStripMenuItem = value;
				flag = (this._SplitMapGfxgphToolStripMenuItem != null);
				if (flag)
				{
					this._SplitMapGfxgphToolStripMenuItem.Click += this.SplitMapGfxgphToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0013B3D8 File Offset: 0x0013A3D8
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0013B3F0 File Offset: 0x0013A3F0
		internal virtual ToolStripMenuItem LoadMap_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LoadMap_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._LoadMap_ToolStripMenuItem != null;
				if (flag)
				{
					this._LoadMap_ToolStripMenuItem.Click -= this.LoadMapToolStripMenuItem_Click;
				}
				this._LoadMap_ToolStripMenuItem = value;
				flag = (this._LoadMap_ToolStripMenuItem != null);
				if (flag)
				{
					this._LoadMap_ToolStripMenuItem.Click += this.LoadMapToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0013B45C File Offset: 0x0013A45C
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0013B474 File Offset: 0x0013A474
		internal virtual ToolStripMenuItem AddAllPOIToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AddAllPOIToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._AddAllPOIToolStripMenuItem != null;
				if (flag)
				{
					this._AddAllPOIToolStripMenuItem.Click -= this.AddAllPOIToolStripMenuItem_Click;
				}
				this._AddAllPOIToolStripMenuItem = value;
				flag = (this._AddAllPOIToolStripMenuItem != null);
				if (flag)
				{
					this._AddAllPOIToolStripMenuItem.Click += this.AddAllPOIToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0013B4E0 File Offset: 0x0013A4E0
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0013B4F8 File Offset: 0x0013A4F8
		internal virtual GroupBox ImportedFilesGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImportedFilesGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImportedFilesGroupBox = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0013B504 File Offset: 0x0013A504
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0013B51C File Offset: 0x0013A51C
		internal virtual ListBox ImportedFilesListBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImportedFilesListBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ImportedFilesListBox != null;
				if (flag)
				{
					this._ImportedFilesListBox.SelectedIndexChanged -= this.ImportedFilesListBoxSelectionChange;
					this._ImportedFilesListBox.DragDrop -= this.ImportedFilesListBox_DragDrop;
					this._ImportedFilesListBox.DragEnter -= this.ImportedFilesListBox_DragEnter;
				}
				this._ImportedFilesListBox = value;
				flag = (this._ImportedFilesListBox != null);
				if (flag)
				{
					this._ImportedFilesListBox.SelectedIndexChanged += this.ImportedFilesListBoxSelectionChange;
					this._ImportedFilesListBox.DragDrop += this.ImportedFilesListBox_DragDrop;
					this._ImportedFilesListBox.DragEnter += this.ImportedFilesListBox_DragEnter;
				}
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0013B5EC File Offset: 0x0013A5EC
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0013B604 File Offset: 0x0013A604
		internal virtual ToolStripSeparator ToolStripSeparator3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator3 = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0013B610 File Offset: 0x0013A610
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0013B628 File Offset: 0x0013A628
		internal virtual ToolStripSeparator ToolStripSeparator2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator2 = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0013B634 File Offset: 0x0013A634
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0013B64C File Offset: 0x0013A64C
		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0013B658 File Offset: 0x0013A658
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0013B670 File Offset: 0x0013A670
		internal virtual ToolStripSeparator ToolStripSeparator5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator5 = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0013B67C File Offset: 0x0013A67C
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0013B694 File Offset: 0x0013A694
		internal virtual ToolStripSeparator ToolStripSeparator4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator4 = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0013B6A0 File Offset: 0x0013A6A0
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0013B6B8 File Offset: 0x0013A6B8
		internal virtual ToolStripLabel Or_ToolStripLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Or_ToolStripLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Or_ToolStripLabel = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0013B6C4 File Offset: 0x0013A6C4
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0013B6DC File Offset: 0x0013A6DC
		internal virtual ToolStripMenuItem Map9ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map9ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map9ToolStripMenuItem != null;
				if (flag)
				{
					this._Map9ToolStripMenuItem.Click -= this.Map9ToolStripMenuItem_Click;
				}
				this._Map9ToolStripMenuItem = value;
				flag = (this._Map9ToolStripMenuItem != null);
				if (flag)
				{
					this._Map9ToolStripMenuItem.Click += this.Map9ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0013B748 File Offset: 0x0013A748
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0013B760 File Offset: 0x0013A760
		internal virtual ToolStripMenuItem Map8ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map8ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map8ToolStripMenuItem != null;
				if (flag)
				{
					this._Map8ToolStripMenuItem.Click -= this.Map8ToolStripMenuItem_Click;
				}
				this._Map8ToolStripMenuItem = value;
				flag = (this._Map8ToolStripMenuItem != null);
				if (flag)
				{
					this._Map8ToolStripMenuItem.Click += this.Map8ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0013B7CC File Offset: 0x0013A7CC
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0013B7E4 File Offset: 0x0013A7E4
		internal virtual ToolStripMenuItem Map7ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map7ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map7ToolStripMenuItem != null;
				if (flag)
				{
					this._Map7ToolStripMenuItem.Click -= this.Map7ToolStripMenuItem_Click;
				}
				this._Map7ToolStripMenuItem = value;
				flag = (this._Map7ToolStripMenuItem != null);
				if (flag)
				{
					this._Map7ToolStripMenuItem.Click += this.Map7ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0013B850 File Offset: 0x0013A850
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0013B868 File Offset: 0x0013A868
		internal virtual ToolStripMenuItem Map6ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map6ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map6ToolStripMenuItem != null;
				if (flag)
				{
					this._Map6ToolStripMenuItem.Click -= this.Map6ToolStripMenuItem_Click;
				}
				this._Map6ToolStripMenuItem = value;
				flag = (this._Map6ToolStripMenuItem != null);
				if (flag)
				{
					this._Map6ToolStripMenuItem.Click += this.Map6ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0013B8D4 File Offset: 0x0013A8D4
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0013B8EC File Offset: 0x0013A8EC
		internal virtual ToolStripMenuItem Map5ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map5ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map5ToolStripMenuItem != null;
				if (flag)
				{
					this._Map5ToolStripMenuItem.Click -= this.Map5ToolStripMenuItem_Click;
				}
				this._Map5ToolStripMenuItem = value;
				flag = (this._Map5ToolStripMenuItem != null);
				if (flag)
				{
					this._Map5ToolStripMenuItem.Click += this.Map5ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0013B958 File Offset: 0x0013A958
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0013B970 File Offset: 0x0013A970
		internal virtual ToolStripMenuItem Map4ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map4ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map4ToolStripMenuItem != null;
				if (flag)
				{
					this._Map4ToolStripMenuItem.Click -= this.Map4ToolStripMenuItem_Click;
				}
				this._Map4ToolStripMenuItem = value;
				flag = (this._Map4ToolStripMenuItem != null);
				if (flag)
				{
					this._Map4ToolStripMenuItem.Click += this.Map4ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0013B9DC File Offset: 0x0013A9DC
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0013B9F4 File Offset: 0x0013A9F4
		internal virtual ToolStripMenuItem Map3ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map3ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map3ToolStripMenuItem != null;
				if (flag)
				{
					this._Map3ToolStripMenuItem.Click -= this.Map3ToolStripMenuItem_Click;
				}
				this._Map3ToolStripMenuItem = value;
				flag = (this._Map3ToolStripMenuItem != null);
				if (flag)
				{
					this._Map3ToolStripMenuItem.Click += this.Map3ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0013BA60 File Offset: 0x0013AA60
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0013BA78 File Offset: 0x0013AA78
		internal virtual ToolStripMenuItem Map2ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map2ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map2ToolStripMenuItem != null;
				if (flag)
				{
					this._Map2ToolStripMenuItem.Click -= this.Map2ToolStripMenuItem_Click;
				}
				this._Map2ToolStripMenuItem = value;
				flag = (this._Map2ToolStripMenuItem != null);
				if (flag)
				{
					this._Map2ToolStripMenuItem.Click += this.Map2ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0013BAE4 File Offset: 0x0013AAE4
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0013BAFC File Offset: 0x0013AAFC
		internal virtual ToolStripMenuItem Map1ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map1ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map1ToolStripMenuItem != null;
				if (flag)
				{
					this._Map1ToolStripMenuItem.Click -= this.Map1ToolStripMenuItem_Click;
				}
				this._Map1ToolStripMenuItem = value;
				flag = (this._Map1ToolStripMenuItem != null);
				if (flag)
				{
					this._Map1ToolStripMenuItem.Click += this.Map1ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0013BB68 File Offset: 0x0013AB68
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0013BB80 File Offset: 0x0013AB80
		internal virtual ToolStripMenuItem Map0ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map0ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map0ToolStripMenuItem != null;
				if (flag)
				{
					this._Map0ToolStripMenuItem.Click -= this.Map0ToolStripMenuItem_Click;
				}
				this._Map0ToolStripMenuItem = value;
				flag = (this._Map0ToolStripMenuItem != null);
				if (flag)
				{
					this._Map0ToolStripMenuItem.Click += this.Map0ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0013BBEC File Offset: 0x0013ABEC
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0013BC04 File Offset: 0x0013AC04
		internal virtual ToolStripSeparator MapToolStripSeparator
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MapToolStripSeparator;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MapToolStripSeparator = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0013BC10 File Offset: 0x0013AC10
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0013BC28 File Offset: 0x0013AC28
		internal virtual ToolStripSplitButton LoadMap_ToolStripButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LoadMap_ToolStripButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._LoadMap_ToolStripButton != null;
				if (flag)
				{
					this._LoadMap_ToolStripButton.Click -= this.Load_ToolStripButton_Click;
				}
				this._LoadMap_ToolStripButton = value;
				flag = (this._LoadMap_ToolStripButton != null);
				if (flag)
				{
					this._LoadMap_ToolStripButton.Click += this.Load_ToolStripButton_Click;
				}
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0013BC94 File Offset: 0x0013AC94
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0013BCAC File Offset: 0x0013ACAC
		internal virtual ToolStripMenuItem Map0ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map0ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map0ToolStripMenuItem1 != null;
				if (flag)
				{
					this._Map0ToolStripMenuItem1.Click -= this.Map0ToolStripMenuItem0_Click;
				}
				this._Map0ToolStripMenuItem1 = value;
				flag = (this._Map0ToolStripMenuItem1 != null);
				if (flag)
				{
					this._Map0ToolStripMenuItem1.Click += this.Map0ToolStripMenuItem0_Click;
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0013BD18 File Offset: 0x0013AD18
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0013BD30 File Offset: 0x0013AD30
		internal virtual ToolStripMenuItem Map1ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map1ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map1ToolStripMenuItem1 != null;
				if (flag)
				{
					this._Map1ToolStripMenuItem1.Click -= this.Map0ToolStripMenuItem1_Click;
				}
				this._Map1ToolStripMenuItem1 = value;
				flag = (this._Map1ToolStripMenuItem1 != null);
				if (flag)
				{
					this._Map1ToolStripMenuItem1.Click += this.Map0ToolStripMenuItem1_Click;
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0013BD9C File Offset: 0x0013AD9C
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0013BDB4 File Offset: 0x0013ADB4
		internal virtual ToolStripMenuItem Map2ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map2ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map2ToolStripMenuItem1 != null;
				if (flag)
				{
					this._Map2ToolStripMenuItem1.Click -= this.Map0ToolStripMenuItem2_Click;
				}
				this._Map2ToolStripMenuItem1 = value;
				flag = (this._Map2ToolStripMenuItem1 != null);
				if (flag)
				{
					this._Map2ToolStripMenuItem1.Click += this.Map0ToolStripMenuItem2_Click;
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0013BE20 File Offset: 0x0013AE20
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0013BE38 File Offset: 0x0013AE38
		internal virtual ToolStripMenuItem Map3ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map3ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map3ToolStripMenuItem1 != null;
				if (flag)
				{
					this._Map3ToolStripMenuItem1.Click -= this.Map0ToolStripMenuItem3_Click;
				}
				this._Map3ToolStripMenuItem1 = value;
				flag = (this._Map3ToolStripMenuItem1 != null);
				if (flag)
				{
					this._Map3ToolStripMenuItem1.Click += this.Map0ToolStripMenuItem3_Click;
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0013BEA4 File Offset: 0x0013AEA4
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0013BEBC File Offset: 0x0013AEBC
		internal virtual ToolStripMenuItem Map4ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map4ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map4ToolStripMenuItem1 != null;
				if (flag)
				{
					this._Map4ToolStripMenuItem1.Click -= this.Map0ToolStripMenuItem4_Click;
				}
				this._Map4ToolStripMenuItem1 = value;
				flag = (this._Map4ToolStripMenuItem1 != null);
				if (flag)
				{
					this._Map4ToolStripMenuItem1.Click += this.Map0ToolStripMenuItem4_Click;
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0013BF28 File Offset: 0x0013AF28
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0013BF40 File Offset: 0x0013AF40
		internal virtual ToolStripMenuItem Map5ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map5ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map5ToolStripMenuItem1 != null;
				if (flag)
				{
					this._Map5ToolStripMenuItem1.Click -= this.Map0ToolStripMenuItem5_Click;
				}
				this._Map5ToolStripMenuItem1 = value;
				flag = (this._Map5ToolStripMenuItem1 != null);
				if (flag)
				{
					this._Map5ToolStripMenuItem1.Click += this.Map0ToolStripMenuItem5_Click;
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0013BFAC File Offset: 0x0013AFAC
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0013BFC4 File Offset: 0x0013AFC4
		internal virtual ToolStripMenuItem Map6ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map6ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map6ToolStripMenuItem1 != null;
				if (flag)
				{
					this._Map6ToolStripMenuItem1.Click -= this.Map0ToolStripMenuItem6_Click;
				}
				this._Map6ToolStripMenuItem1 = value;
				flag = (this._Map6ToolStripMenuItem1 != null);
				if (flag)
				{
					this._Map6ToolStripMenuItem1.Click += this.Map0ToolStripMenuItem6_Click;
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0013C030 File Offset: 0x0013B030
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0013C048 File Offset: 0x0013B048
		internal virtual ToolStripMenuItem Map7ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map7ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map7ToolStripMenuItem1 != null;
				if (flag)
				{
					this._Map7ToolStripMenuItem1.Click -= this.Map0ToolStripMenuItem7_Click;
				}
				this._Map7ToolStripMenuItem1 = value;
				flag = (this._Map7ToolStripMenuItem1 != null);
				if (flag)
				{
					this._Map7ToolStripMenuItem1.Click += this.Map0ToolStripMenuItem7_Click;
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0013C0B4 File Offset: 0x0013B0B4
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0013C0CC File Offset: 0x0013B0CC
		internal virtual ToolStripMenuItem Map8ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map8ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map8ToolStripMenuItem1 != null;
				if (flag)
				{
					this._Map8ToolStripMenuItem1.Click -= this.Map0ToolStripMenuItem8_Click;
				}
				this._Map8ToolStripMenuItem1 = value;
				flag = (this._Map8ToolStripMenuItem1 != null);
				if (flag)
				{
					this._Map8ToolStripMenuItem1.Click += this.Map0ToolStripMenuItem8_Click;
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0013C138 File Offset: 0x0013B138
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0013C150 File Offset: 0x0013B150
		internal virtual ToolStripMenuItem Map9ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Map9ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Map9ToolStripMenuItem1 != null;
				if (flag)
				{
					this._Map9ToolStripMenuItem1.Click -= this.Map0ToolStripMenuItem9_Click;
				}
				this._Map9ToolStripMenuItem1 = value;
				flag = (this._Map9ToolStripMenuItem1 != null);
				if (flag)
				{
					this._Map9ToolStripMenuItem1.Click += this.Map0ToolStripMenuItem9_Click;
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0013C1BC File Offset: 0x0013B1BC
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0013C1D4 File Offset: 0x0013B1D4
		internal virtual ToolStripMenuItem DeleteAndNeverLoadToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DeleteAndNeverLoadToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._DeleteAndNeverLoadToolStripMenuItem != null;
				if (flag)
				{
					this._DeleteAndNeverLoadToolStripMenuItem.Click -= this.DeleteAndNeverLoadToolStripMenuItem_Click;
				}
				this._DeleteAndNeverLoadToolStripMenuItem = value;
				flag = (this._DeleteAndNeverLoadToolStripMenuItem != null);
				if (flag)
				{
					this._DeleteAndNeverLoadToolStripMenuItem.Click += this.DeleteAndNeverLoadToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0013C240 File Offset: 0x0013B240
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0013C258 File Offset: 0x0013B258
		internal virtual ToolStripMenuItem AlwaysAddToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AlwaysAddToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._AlwaysAddToolStripMenuItem != null;
				if (flag)
				{
					this._AlwaysAddToolStripMenuItem.Click -= this.AlwaysAddToolStripMenuItem_Click;
				}
				this._AlwaysAddToolStripMenuItem = value;
				flag = (this._AlwaysAddToolStripMenuItem != null);
				if (flag)
				{
					this._AlwaysAddToolStripMenuItem.Click += this.AlwaysAddToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0013C2C4 File Offset: 0x0013B2C4
		// (set) Token: 0x0600014C RID: 332 RVA: 0x0013C2DC File Offset: 0x0013B2DC
		internal virtual ToolStripMenuItem AllToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AllToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._AllToolStripMenuItem != null;
				if (flag)
				{
					this._AllToolStripMenuItem.Click -= this.AllToolStripMenuItem_Click;
				}
				this._AllToolStripMenuItem = value;
				flag = (this._AllToolStripMenuItem != null);
				if (flag)
				{
					this._AllToolStripMenuItem.Click += this.AllToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0013C348 File Offset: 0x0013B348
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0013C360 File Offset: 0x0013B360
		internal virtual ToolStripMenuItem ImportationToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImportationToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ImportationToolStripMenuItem != null;
				if (flag)
				{
					this._ImportationToolStripMenuItem.Click -= this.ImportationToolStripMenuItem_Click;
				}
				this._ImportationToolStripMenuItem = value;
				flag = (this._ImportationToolStripMenuItem != null);
				if (flag)
				{
					this._ImportationToolStripMenuItem.Click += this.ImportationToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0013C3CC File Offset: 0x0013B3CC
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0013C3E4 File Offset: 0x0013B3E4
		internal virtual ToolStripMenuItem RadarImportationToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadarImportationToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RadarImportationToolStripMenuItem != null;
				if (flag)
				{
					this._RadarImportationToolStripMenuItem.Click -= this.RadarImportationToolStripMenuItem_Click;
				}
				this._RadarImportationToolStripMenuItem = value;
				flag = (this._RadarImportationToolStripMenuItem != null);
				if (flag)
				{
					this._RadarImportationToolStripMenuItem.Click += this.RadarImportationToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0013C450 File Offset: 0x0013B450
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0013C468 File Offset: 0x0013B468
		internal virtual ToolStripMenuItem RadarNameToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadarNameToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RadarNameToolStripMenuItem != null;
				if (flag)
				{
					this._RadarNameToolStripMenuItem.Click -= this.RadarNameToolStripMenuItem_Click;
				}
				this._RadarNameToolStripMenuItem = value;
				flag = (this._RadarNameToolStripMenuItem != null);
				if (flag)
				{
					this._RadarNameToolStripMenuItem.Click += this.RadarNameToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0013C4D4 File Offset: 0x0013B4D4
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0013C4EC File Offset: 0x0013B4EC
		internal virtual ToolStripMenuItem ExportationToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExportationToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ExportationToolStripMenuItem != null;
				if (flag)
				{
					this._ExportationToolStripMenuItem.Click -= this.ExportationToolStripMenuItem_Click;
				}
				this._ExportationToolStripMenuItem = value;
				flag = (this._ExportationToolStripMenuItem != null);
				if (flag)
				{
					this._ExportationToolStripMenuItem.Click += this.ExportationToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0013C558 File Offset: 0x0013B558
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0013C570 File Offset: 0x0013B570
		internal virtual ToolStripMenuItem ReloadMapWithAllPOIToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ReloadMapWithAllPOIToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ReloadMapWithAllPOIToolStripMenuItem != null;
				if (flag)
				{
					this._ReloadMapWithAllPOIToolStripMenuItem.Click -= this.ReloadMapWithAllPOIToolStripMenuItem_Click;
				}
				this._ReloadMapWithAllPOIToolStripMenuItem = value;
				flag = (this._ReloadMapWithAllPOIToolStripMenuItem != null);
				if (flag)
				{
					this._ReloadMapWithAllPOIToolStripMenuItem.Click += this.ReloadMapWithAllPOIToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0013C5DC File Offset: 0x0013B5DC
		// (set) Token: 0x06000158 RID: 344 RVA: 0x0013C5F4 File Offset: 0x0013B5F4
		internal virtual ToolStripMenuItem RT4ConfigurationUSBKeyToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RT4ConfigurationUSBKeyToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RT4ConfigurationUSBKeyToolStripMenuItem != null;
				if (flag)
				{
					this._RT4ConfigurationUSBKeyToolStripMenuItem.Click -= this.RT4ConfigurationUSBKeyToolStripMenuItem_Click;
				}
				this._RT4ConfigurationUSBKeyToolStripMenuItem = value;
				flag = (this._RT4ConfigurationUSBKeyToolStripMenuItem != null);
				if (flag)
				{
					this._RT4ConfigurationUSBKeyToolStripMenuItem.Click += this.RT4ConfigurationUSBKeyToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0013C660 File Offset: 0x0013B660
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0013C678 File Offset: 0x0013B678
		internal virtual ToolStripMenuItem BootScreenRT4ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BootScreenRT4ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._BootScreenRT4ToolStripMenuItem != null;
				if (flag)
				{
					this._BootScreenRT4ToolStripMenuItem.Click -= this.BootScreenRT4ToolStripMenuItem_Click;
				}
				this._BootScreenRT4ToolStripMenuItem = value;
				flag = (this._BootScreenRT4ToolStripMenuItem != null);
				if (flag)
				{
					this._BootScreenRT4ToolStripMenuItem.Click += this.BootScreenRT4ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0013C6E4 File Offset: 0x0013B6E4
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0013C6FC File Offset: 0x0013B6FC
		internal virtual ToolStripSeparator ToolStripSeparator6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator6 = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0013C708 File Offset: 0x0013B708
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0013C720 File Offset: 0x0013B720
		internal virtual ToolStripMenuItem AgendatdatRT4ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AgendatdatRT4ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._AgendatdatRT4ToolStripMenuItem != null;
				if (flag)
				{
					this._AgendatdatRT4ToolStripMenuItem.Click -= this.AgendatdatRT4ToolStripMenuItem_Click;
				}
				this._AgendatdatRT4ToolStripMenuItem = value;
				flag = (this._AgendatdatRT4ToolStripMenuItem != null);
				if (flag)
				{
					this._AgendatdatRT4ToolStripMenuItem.Click += this.AgendatdatRT4ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0013C78C File Offset: 0x0013B78C
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0013C7A4 File Offset: 0x0013B7A4
		internal virtual ToolStripMenuItem UsercomdatRT4ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UsercomdatRT4ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._UsercomdatRT4ToolStripMenuItem != null;
				if (flag)
				{
					this._UsercomdatRT4ToolStripMenuItem.Click -= this.UsercomdatRT4ToolStripMenuItem_Click;
				}
				this._UsercomdatRT4ToolStripMenuItem = value;
				flag = (this._UsercomdatRT4ToolStripMenuItem != null);
				if (flag)
				{
					this._UsercomdatRT4ToolStripMenuItem.Click += this.UsercomdatRT4ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0013C810 File Offset: 0x0013B810
		// (set) Token: 0x06000162 RID: 354 RVA: 0x0013C828 File Offset: 0x0013B828
		internal virtual ToolStripMenuItem CoordConv_ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CoordConv_ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._CoordConv_ToolStripMenuItem != null;
				if (flag)
				{
					this._CoordConv_ToolStripMenuItem.Click -= this.CoordConv_ToolStripMenuItem_Click;
				}
				this._CoordConv_ToolStripMenuItem = value;
				flag = (this._CoordConv_ToolStripMenuItem != null);
				if (flag)
				{
					this._CoordConv_ToolStripMenuItem.Click += this.CoordConv_ToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0013C894 File Offset: 0x0013B894
		// (set) Token: 0x06000164 RID: 356 RVA: 0x0013C8AC File Offset: 0x0013B8AC
		internal virtual ToolStripMenuItem RadarIconDisplayRTxToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadarIconDisplayRTxToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RadarIconDisplayRTxToolStripMenuItem != null;
				if (flag)
				{
					this._RadarIconDisplayRTxToolStripMenuItem.Click -= this.RadarIconDisplayRTxToolStripMenuItem_Click;
				}
				this._RadarIconDisplayRTxToolStripMenuItem = value;
				flag = (this._RadarIconDisplayRTxToolStripMenuItem != null);
				if (flag)
				{
					this._RadarIconDisplayRTxToolStripMenuItem.Click += this.RadarIconDisplayRTxToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0013C918 File Offset: 0x0013B918
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0013C930 File Offset: 0x0013B930
		internal virtual ToolStripMenuItem ModeToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ModeToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ModeToolStripMenuItem = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0013C93C File Offset: 0x0013B93C
		// (set) Token: 0x06000168 RID: 360 RVA: 0x0013C954 File Offset: 0x0013B954
		internal virtual ToolStripMenuItem MapToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MapToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._MapToolStripMenuItem != null;
				if (flag)
				{
					this._MapToolStripMenuItem.Click -= this.MapToolStripMenuItem_Click;
				}
				this._MapToolStripMenuItem = value;
				flag = (this._MapToolStripMenuItem != null);
				if (flag)
				{
					this._MapToolStripMenuItem.Click += this.MapToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0013C9C0 File Offset: 0x0013B9C0
		// (set) Token: 0x0600016A RID: 362 RVA: 0x0013C9D8 File Offset: 0x0013B9D8
		internal virtual ToolStripMenuItem AlertToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AlertToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._AlertToolStripMenuItem != null;
				if (flag)
				{
					this._AlertToolStripMenuItem.Click -= this.AlertToolStripMenuItem_Click;
				}
				this._AlertToolStripMenuItem = value;
				flag = (this._AlertToolStripMenuItem != null);
				if (flag)
				{
					this._AlertToolStripMenuItem.Click += this.AlertToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0013CA44 File Offset: 0x0013BA44
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0013CA5C File Offset: 0x0013BA5C
		internal virtual ToolStripMenuItem ExtractBMPFromToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExtractBMPFromToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ExtractBMPFromToolStripMenuItem != null;
				if (flag)
				{
					this._ExtractBMPFromToolStripMenuItem.Click -= this.ExtractBMPFromToolStripMenuItem_Click;
				}
				this._ExtractBMPFromToolStripMenuItem = value;
				flag = (this._ExtractBMPFromToolStripMenuItem != null);
				if (flag)
				{
					this._ExtractBMPFromToolStripMenuItem.Click += this.ExtractBMPFromToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0013CAC8 File Offset: 0x0013BAC8
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0013CAE0 File Offset: 0x0013BAE0
		internal virtual NumericUpDown Speed_NumericUpDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Speed_NumericUpDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Speed_NumericUpDown != null;
				if (flag)
				{
					this._Speed_NumericUpDown.ValueChanged -= this.Speed_NumericUpDown_ValueChanged;
				}
				this._Speed_NumericUpDown = value;
				flag = (this._Speed_NumericUpDown != null);
				if (flag)
				{
					this._Speed_NumericUpDown.ValueChanged += this.Speed_NumericUpDown_ValueChanged;
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0013CB4C File Offset: 0x0013BB4C
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0013CB64 File Offset: 0x0013BB64
		internal virtual Label SpeedLimit_Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SpeedLimit_Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SpeedLimit_Label = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0013CB70 File Offset: 0x0013BB70
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0013CB88 File Offset: 0x0013BB88
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0013CB94 File Offset: 0x0013BB94
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0013CBAC File Offset: 0x0013BBAC
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

		// Token: 0x06000175 RID: 373 RVA: 0x0013CBB8 File Offset: 0x0013BBB8
		public FormMain()
		{
			base.Load += this.FormMain_Load;
			base.Shown += this.FormMain_Shown;
			base.Closed += this.FormMain_Closed;
			ArrayList _ENCList = FormMain.__ENCList;
			lock (_ENCList)
			{
				FormMain.__ENCList.Add(new WeakReference(this));
			}
			this.common = new Common();
			this.selectedPOIList = null;
			this.itemNbSelectedInPOIList = 0;
			this.CurrentWorkingDir = Environment.CurrentDirectory;
			this.openFiles2ImportDialog = null;
			this.choseFile2ExportDialog = null;
			this.formMainNameTabPage = null;
			this.isFirstRun = true;
			this.userSettings = null;
			this.RTxScreen = new RTxScreen();
			this.mapMngt = new MAPMngt();
			this.RT4Mngt = new RT4Utils();
			string fullLogFileName = MyProject.Application.Log.DefaultFileLogWriter.FullLogFileName;
			string text = Path.ChangeExtension(fullLogFileName, ".log.old");
			bool flag = MyProject.Computer.FileSystem.FileExists(fullLogFileName);
			if (flag)
			{
				bool flag2 = MyProject.Computer.FileSystem.GetFileInfo(fullLogFileName).Length > 500000L;
				if (flag2)
				{
					bool flag3 = MyProject.Computer.FileSystem.FileExists(text);
					if (flag3)
					{
						MyProject.Computer.FileSystem.DeleteFile(text);
					}
					MyProject.Application.Log.DefaultFileLogWriter.Close();
					MyProject.Computer.FileSystem.CopyFile(fullLogFileName, text);
					MyProject.Computer.FileSystem.DeleteFile(fullLogFileName);
				}
			}
			MyProject.Application.Log.WriteEntry(string.Concat(new string[]
			{
				MyProject.Application.Info.ProductName,
				" ",
				MyProject.Application.Info.Version.ToString(),
				" (",
				MyProject.Application.Info.DirectoryPath,
				") started at ",
				DateAndTime.Now.ToString()
			}), TraceEventType.Information);
			this.userSettings = new userSettings();
			Common.setRTxMapEditorMapMode(MySettingsProperty.Settings.RTxModeMap);
			Common.setRTxType(MySettingsProperty.Settings.RTxType);
			Common.setRTxVersion(MySettingsProperty.Settings.RTxVersion);
			this.userSettings.readUpgSettings(ref this.isFirstRun);
			this.mapMngt.createCultDepItems(Common.RTxMapEditorMapMode);
			this.InitializeComponent();
			this.userSettings.SetLastLoadedMaps(this.File_ToolStripMenuItem, this.LoadMap_ToolStripButton);
			this.formMainNameTabPage = new formMainNameTabPage();
			this.openFiles2ImportDialog = new OpenFiles2ImportDialog();
			this.choseFile2ExportDialog = new ChoseFile2ExportDialog();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0013CE9C File Offset: 0x0013BE9C
		private void bindWithRTxType()
		{
			bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map;
			if (flag)
			{
				this.RT3OTypeComboBox.DataSource = new BindingSource(this.mapMngt.POITypeInfo.POINameTypeDict, null);
				this.RT3OTypeComboBox.ValueMember = "Value";
				this.RT3OTypeComboBox.DisplayMember = "Key";
				this.RT3OTypeComboBox.SelectedIndex = -1;
			}
			else
			{
				this.RT3OTypeComboBox.DataSource = new BindingSource(this.mapMngt.POITypeInfo.POINameTypeDictAlert, null);
				this.RT3OTypeComboBox.ValueMember = "Value";
				this.RT3OTypeComboBox.DisplayMember = "Key";
				this.RT3OTypeComboBox.SelectedIndex = -1;
			}
			this.RT3OScaleComboBox.DataSource = new BindingSource(this.mapMngt.POITypeInfo.POINameScaleDict, null);
			this.RT3OScaleComboBox.ValueMember = "Key";
			this.RT3OScaleComboBox.DisplayMember = "Value";
			this.RT3OScaleComboBox.SelectedIndex = -1;
			this.RT3OLayerComboBox.DataSource = new BindingSource(this.mapMngt.POITypeInfo.POINameLayerDict, null);
			this.RT3OLayerComboBox.ValueMember = "Key";
			this.RT3OLayerComboBox.DisplayMember = "Value";
			this.RT3OLayerComboBox.SelectedIndex = -1;
			magComboBoxInit.init(this.RT3OMagComboBox);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0013D00C File Offset: 0x0013C00C
		private void FormMain_Load(object sender, EventArgs e)
		{
			string fileName = Path.Combine(this.CurrentWorkingDir, "documentation\\licence-" + MySettingsProperty.Settings.UICulture + ".rtf");
			bool flag = this.isFirstRun;
			if (flag)
			{
				MyProject.Application.Log.WriteEntry("License screen", TraceEventType.Information);
				LicenseDialog licenseDialog = new LicenseDialog(fileName);
				flag = (licenseDialog.ShowDialog() == DialogResult.OK);
				if (flag)
				{
					MyProject.Application.Log.WriteEntry("License accepted", TraceEventType.Information);
					MySettingsProperty.Settings.isFirstRun = false;
					MySettingsProperty.Settings.Save();
					try
					{
						Process.Start(Path.Combine(this.CurrentWorkingDir, "documentation\\piratage-fr.pdf"));
					}
					catch (Exception ex)
					{
						Interaction.MsgBox(Resources.strNoAcroReader, MsgBoxStyle.Exclamation, null);
					}
				}
				else
				{
					MyProject.Application.Log.WriteEntry("License refused", TraceEventType.Information);
					MySettingsProperty.Settings.isFirstRun = true;
					Application.Exit();
					MySettingsProperty.Settings.Save();
				}
			}
			this.wizardState = new WizardState(this);
			this.bindingListOfPOIList = new BindingSource(this.mapMngt.importedPOIList.ListOfPOIList, null);
			this.ImportedFilesListBox.DataSource = this.bindingListOfPOIList;
			this.ImportedFilesListBox.DisplayMember = "Name";
			this.DeleteToolStripMenuItem.Enabled = false;
			this.RenameToolStripMenuItem.Enabled = false;
			this.MergeToolStripMenuItem.Enabled = false;
			this.RemoveDuplicatesToolStripMenuItem.Enabled = false;
			this.AutoValidate = AutoValidate.EnablePreventFocusChange;
			this.bindWithRTxType();
			this.formMainNameTabPage.load();
			MyProject.Forms.AllPOIParamDialog.initDefaultValues();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0013D1D0 File Offset: 0x0013C1D0
		private void FormMain_Shown(object sender, EventArgs e)
		{
			bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map;
			if (flag)
			{
				bool flag2 = MySettingsProperty.Settings.autoLoad && ConfigDialog.isConfigComplete() == ConfigDialog.configStatus.OK;
				if (flag2)
				{
					this.mapMngt.loadMap(Common.RTxType, false, null);
				}
				else
				{
					this.wizardState.changeState(WizardState.states.NOT_LOADED);
					this.ImportedFilesListBox.SelectedIndex = -1;
				}
				this.Patch_ToolStripButton.Text = Resources.strPatchButtonMap;
				this.Patch_ToolStripMenuItem.Text = Resources.strPatchButtonMap;
			}
			else
			{
				bool flag2 = !this.mapMngt.loadFictMap(MySettingsProperty.Settings.alertDIRCID);
				if (flag2)
				{
					this.Patch_ToolStripButton.Text = Resources.strPatchButtonMap;
					this.Patch_ToolStripMenuItem.Text = Resources.strPatchButtonMap;
					Common.setRTxMapEditorMapMode(Common.RTxMapEditorMapModes.map);
					this.wizardState.changeState(WizardState.states.NOT_LOADED);
				}
				else
				{
					this.Patch_ToolStripButton.Text = Resources.strPatchButtonAlert;
					this.Patch_ToolStripMenuItem.Text = Resources.strPatchButtonAlert;
				}
				this.ImportedFilesListBox.SelectedIndex = -1;
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0013D2E8 File Offset: 0x0013C2E8
		private void FormMain_Closed(object sender, EventArgs e)
		{
			this.userSettings.writeSettings(false);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0013D2FC File Offset: 0x0013C2FC
		private void Load_ToolStripButton_Click(object sender, EventArgs e)
		{
			bool flag = !((ToolStripSplitButton)sender).DropDownButtonPressed;
			if (flag)
			{
				this.loadMap();
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0013D328 File Offset: 0x0013C328
		private void LoadMapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.loadMap();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0013D334 File Offset: 0x0013C334
		private void loadMap()
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = false;
			folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
			bool flag;
			try
			{
				flag = MyProject.Computer.FileSystem.DirectoryExists(MySettingsProperty.Settings.WorkingDir);
				if (flag)
				{
					folderBrowserDialog.SelectedPath = MySettingsProperty.Settings.WorkingDir;
				}
				else
				{
					folderBrowserDialog.SelectedPath = MyProject.Computer.FileSystem.GetParentPath(MySettingsProperty.Settings.WorkingDir);
				}
			}
			catch (Exception ex)
			{
				folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
			}
			folderBrowserDialog.Description = Resources.strSelectMap;
			flag = (folderBrowserDialog.ShowDialog() == DialogResult.OK);
			if (flag)
			{
				this.mapMngt.loadMap(Common.RTxType, true, folderBrowserDialog.SelectedPath);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0013D410 File Offset: 0x0013C410
		private void ReloadMapWithAllPOIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.mapMngt.reloadMap();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0013D420 File Offset: 0x0013C420
		private void Map0ToolStripMenuItem0_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0013D434 File Offset: 0x0013C434
		private void Map0ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0013D448 File Offset: 0x0013C448
		private void Map0ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0013D45C File Offset: 0x0013C45C
		private void Map0ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0013D470 File Offset: 0x0013C470
		private void Map0ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0013D484 File Offset: 0x0013C484
		private void Map0ToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0013D498 File Offset: 0x0013C498
		private void Map0ToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0013D4AC File Offset: 0x0013C4AC
		private void Map0ToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0013D4C0 File Offset: 0x0013C4C0
		private void Map0ToolStripMenuItem8_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0013D4D4 File Offset: 0x0013C4D4
		private void Map0ToolStripMenuItem9_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0013D4E8 File Offset: 0x0013C4E8
		private void Map0ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0013D4FC File Offset: 0x0013C4FC
		private void Map1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0013D510 File Offset: 0x0013C510
		private void Map2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0013D524 File Offset: 0x0013C524
		private void Map3ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0013D538 File Offset: 0x0013C538
		private void Map4ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0013D54C File Offset: 0x0013C54C
		private void Map5ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0013D560 File Offset: 0x0013C560
		private void Map6ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0013D574 File Offset: 0x0013C574
		private void Map7ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0013D588 File Offset: 0x0013C588
		private void Map8ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0013D59C File Offset: 0x0013C59C
		private void Map9ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MapXToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0013D5B0 File Offset: 0x0013C5B0
		private void MapXToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.mapMngt.loadMap(Common.RTxType, true, ((ToolStripMenuItem)sender).ToolTipText);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0013D5D4 File Offset: 0x0013C5D4
		private void ToolStripButtonImporter_Click(object sender, EventArgs e)
		{
			this.mapMngt.importPOI();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0013D5E4 File Offset: 0x0013C5E4
		private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.mapMngt.importPOI();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0013D5F4 File Offset: 0x0013C5F4
		private void ImportedFilesListBox_DragEnter(object sender, DragEventArgs e)
		{
			bool enabled = this.Import_ToolStripMenuItem.Enabled;
			if (enabled)
			{
				bool flag = e.Data.GetDataPresent(DataFormats.FileDrop);
				if (flag)
				{
					string[] filesName = (string[])e.Data.GetData(DataFormats.FileDrop);
					flag = this.mapMngt.checkFileListForAdding(filesName);
					if (flag)
					{
						e.Effect = DragDropEffects.Copy;
					}
					else
					{
						e.Effect = DragDropEffects.None;
					}
				}
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0013D670 File Offset: 0x0013C670
		private void ImportedFilesListBox_DragDrop(object sender, DragEventArgs e)
		{
			string[] filesName = (string[])e.Data.GetData(DataFormats.FileDrop);
			this.mapMngt.importPOI(filesName);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0013D6A4 File Offset: 0x0013C6A4
		private void Patch_ToolStripButton_Click(object sender, EventArgs e)
		{
			bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert & decimal.Compare(this.Speed_NumericUpDown.Value, 999m) != 0;
			if (flag)
			{
				this.Speed_NumericUpDown.Value = this.Speed_NumericUpDown.Value;
			}
			this.mapMngt.patch();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0013D708 File Offset: 0x0013C708
		private void Patch_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.mapMngt.patch();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0013D718 File Offset: 0x0013C718
		private void ISO_ToolStripButton_Click(object sender, EventArgs e)
		{
			this.mapMngt.genISO();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0013D728 File Offset: 0x0013C728
		private void ISO_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.mapMngt.genISO();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0013D738 File Offset: 0x0013C738
		private void USBToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.mapMngt.copyToUSB();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0013D748 File Offset: 0x0013C748
		private void USB_ToolStripButton1_Click(object sender, EventArgs e)
		{
			this.mapMngt.copyToUSB();
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0013D758 File Offset: 0x0013C758
		private void Burn_ToolStripButton_Click(object sender, EventArgs e)
		{
			this.mapMngt.burn();
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0013D768 File Offset: 0x0013C768
		private void Burn_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.mapMngt.burn();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0013D778 File Offset: 0x0013C778
		private void RT4MapUSBToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.mapMngt.RT4map2USB();
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0013D788 File Offset: 0x0013C788
		private void RT4ConfigurationUSBKeyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.RT4Mngt.RT4Config2USB();
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0013D798 File Offset: 0x0013C798
		private void BootScreenRT4ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.RT4Mngt.configBootScreen();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0013D7A8 File Offset: 0x0013C7A8
		private void AgendatdatRT4ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.RT4Mngt.configFileCopyToRT4("Agenda.dat");
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0013D7C0 File Offset: 0x0013C7C0
		private void UsercomdatRT4ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.RT4Mngt.configFileCopyToRT4("User_com.dat");
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0013D7D8 File Offset: 0x0013C7D8
		private void RadarIconDisplayRTxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.RT4Mngt.patchDBDWNLPPC();
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0013D7E8 File Offset: 0x0013C7E8
		private void FrançaisToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ChangeLangage("fr");
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0013D7F8 File Offset: 0x0013C7F8
		private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ChangeLangage("en");
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0013D808 File Offset: 0x0013C808
		private void PortuguêsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ChangeLangage("pt");
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0013D818 File Offset: 0x0013C818
		private void ChangeLangage(string lang)
		{
			MyProject.Application.ChangeUICulture(lang);
			MySettingsProperty.Settings.UICulture = lang;
			MyProject.Application.Log.WriteEntry(Resources.strChangeLanguage, TraceEventType.Information);
			Interaction.MsgBox(Resources.strChangeLanguage, MsgBoxStyle.OkOnly, null);
			this.userSettings.writeSettings(false);
			Application.Exit();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0013D878 File Offset: 0x0013C878
		private void ÀProposToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.About.ShowDialog(this);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0013D890 File Offset: 0x0013C890
		private void UsersGuideToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = MySettingsProperty.Settings.UICulture;
				bool flag = Operators.CompareString(text, "pt", false) == 0;
				if (flag)
				{
					text = "en";
				}
				Process.Start(Path.Combine(this.CurrentWorkingDir, "documentation\\userguideRTxMapEditor-" + text + ".pdf"));
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(Resources.strNoAcroReader, MsgBoxStyle.Exclamation, null);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0013D918 File Offset: 0x0013C918
		private void LicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start(Path.Combine(this.CurrentWorkingDir, "documentation\\licence-" + MySettingsProperty.Settings.UICulture + ".pdf"));
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0013D948 File Offset: 0x0013C948
		private void RT3MapEditorAndTheHackingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(Path.Combine(this.CurrentWorkingDir, "documentation\\piratage-fr.pdf"));
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(Resources.strNoAcroReader, MsgBoxStyle.Exclamation, null);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0013D9A0 File Offset: 0x0013C9A0
		private void LogfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Application.Log.DefaultFileLogWriter.Flush();
			Process.Start(MyProject.Application.Log.DefaultFileLogWriter.FullLogFileName);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0013D9D4 File Offset: 0x0013C9D4
		private void POIradarListsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.CameraList.ShowDialog();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0013D9E8 File Offset: 0x0013C9E8
		private void SplitMapGfxgphToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MapGfxgph mapGfxgph = new MapGfxgph("Q:\\SW RT3-RT4\\MaJ RT4\\8.10DR11\\Data_Base\\Graphics\\Night\\MapGfx.gph");
				mapGfxgph.loadFromFile();
				mapGfxgph.saveEntriesAsFiles("Q:\\SW RT3-RT4\\RT4\\textures\\textures-8.1LR\\Night\\MapGfx");
			}
			catch (SilentGUIException ex)
			{
			}
			catch (GUIException ex2)
			{
			}
			catch (Exception ex3)
			{
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0013DA78 File Offset: 0x0013CA78
		private void AddAllPOIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.mapMngt.addAllPOI();
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0013DA88 File Offset: 0x0013CA88
		private void Configure_ToolStripButton_Click(object sender, EventArgs e)
		{
			this.GUIConfig(ConfigDialog.tabList.last);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0013DA94 File Offset: 0x0013CA94
		private void AllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.GUIConfig(ConfigDialog.tabList.general);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0013DAA0 File Offset: 0x0013CAA0
		private void ImportationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.GUIConfig(ConfigDialog.tabList.import);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0013DAAC File Offset: 0x0013CAAC
		private void RadarImportationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.GUIConfig(ConfigDialog.tabList.STImport);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0013DAB8 File Offset: 0x0013CAB8
		private void RadarNameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.GUIConfig(ConfigDialog.tabList.gpspassionName);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0013DAC4 File Offset: 0x0013CAC4
		private void ExportationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.GUIConfig(ConfigDialog.tabList.Export);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0013DAD4 File Offset: 0x0013CAD4
		private void GUIConfig(ConfigDialog.tabList activeTab)
		{
			DialogResult dialogResult = MyProject.Forms.ConfigDialog.ShowDialog(ConfigDialog.tabList.all, activeTab);
			bool flag = dialogResult == DialogResult.OK;
			if (flag)
			{
				this.wizardState.UpdateMainFormVisibility();
				flag = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert);
				if (flag)
				{
					bool flag2 = !this.mapMngt.loadFictMap(MySettingsProperty.Settings.alertDIRCID);
					if (flag2)
					{
						this.userSettings.writeRTxModeDepSettings();
						this.mapMngt.unloadMap();
						Common.setRTxMapEditorMapMode(Common.RTxMapEditorMapModes.map);
						this.userSettings.readRTxModeDepSettings();
						this.wizardState.changeState(WizardState.states.NOT_LOADED);
					}
					this.ImportedFilesListBox.SelectedIndex = -1;
				}
				else
				{
					bool flag2 = ConfigDialog.isConfigComplete() == ConfigDialog.configStatus.OK;
					if (flag2)
					{
						this.mapMngt.loadMap(Common.RTxType, MyProject.Forms.ConfigDialog.reloadMap, null);
						this.ImportedFilesListBox.SelectedIndex = -1;
					}
					else
					{
						this.wizardState.changeState(WizardState.states.NOT_LOADED);
					}
				}
			}
			else
			{
				bool flag2 = dialogResult == DialogResult.Abort;
				if (flag2)
				{
					this.userSettings.writeSettings(true);
					Application.Exit();
				}
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0013DBEC File Offset: 0x0013CBEC
		private void SortirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.userSettings.writeSettings(false);
			Application.Exit();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0013DC04 File Offset: 0x0013CC04
		private void ComboBox_SelectedIndexChanged(object sender, EventArgs e, int maxVal)
		{
			ComboBox comboBox = (ComboBox)sender;
			bool flag = comboBox.SelectedIndex != -1 && this.itemNbSelectedInPOIList == 1;
			if (flag)
			{
				bool flag2 = this.RT3OTypeComboBox.Equals(RuntimeHelpers.GetObjectValue(sender));
				if (flag2)
				{
					this.POITypePictureBox.Image = this.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(this.RT3OTypeComboBox.SelectedValue));
					flag2 = (Conversions.ToUShort(this.RT3OTypeComboBox.SelectedValue) != 4444);
					if (flag2)
					{
						flag = this.selectedPOIList.fromRT3;
						if (flag)
						{
							this.RT3OScaleComboBox.SelectedValue = this.mapMngt.POITypeInfo.getScaleOfType(Conversions.ToUShort(this.RT3OTypeComboBox.SelectedValue));
							this.RT3OLayerComboBox.SelectedValue = this.mapMngt.POITypeInfo.getLayerOfType(Conversions.ToUShort(this.RT3OTypeComboBox.SelectedValue));
						}
						else
						{
							this.RT3OScaleComboBox.SelectedValue = this.selectedPOIList.scale;
							this.RT3OLayerComboBox.SelectedValue = this.selectedPOIList.layer;
						}
						this.RT3OMagComboBox.SelectedIndex = -1;
						this.namedPlaceTabPage.Enabled = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert);
					}
					else
					{
						this.RT3OScaleComboBox.SelectedIndex = -1;
						this.RT3OLayerComboBox.SelectedIndex = -1;
						flag2 = this.selectedPOIList.fromRT3;
						if (flag2)
						{
							this.RT3OMagComboBox.SelectedIndex = -1;
							this.namedPlaceTabPage.Enabled = false;
						}
						else
						{
							this.RT3OMagComboBox.SelectedValue = this.selectedPOIList.magnitude;
							this.namedPlaceTabPage.Enabled = true;
						}
						this.formMainNameTabPage.setValuesFromSelectedList();
					}
					this.selectedPOIList.setType(Conversions.ToUShort(this.RT3OTypeComboBox.SelectedValue));
					this.RT3OMagComboBox.Enabled = (!this.selectedPOIList.fromRT3 & this.selectedPOIList.type == 4444);
					this.RT3OFullPatchCheckBox.Enabled = (!this.selectedPOIList.fromRT3 & this.selectedPOIList.type == 4444 & this.selectedPOIList.magnitude >= 4);
					this.RT3OFullPatchCheckBox.Checked = this.selectedPOIList.fullPatch;
					this.RT3ODisplayMagCheckBox.Enabled = (this.selectedPOIList.type == 4444);
					this.RT3ODisplayMagCheckBox.Checked = this.selectedPOIList.displayMagnitude;
				}
				else
				{
					flag2 = this.RT3OScaleComboBox.Equals(RuntimeHelpers.GetObjectValue(sender));
					if (flag2)
					{
						flag = (this.RT3OScaleComboBox.SelectedIndex != -1);
						if (flag)
						{
							this.selectedPOIList.setScale(Conversions.ToByte(this.RT3OScaleComboBox.SelectedValue));
						}
					}
					else
					{
						flag2 = this.RT3OLayerComboBox.Equals(RuntimeHelpers.GetObjectValue(sender));
						if (flag2)
						{
							flag = (this.RT3OLayerComboBox.SelectedIndex != -1);
							if (flag)
							{
								this.selectedPOIList.setLayer(Conversions.ToByte(this.RT3OLayerComboBox.SelectedValue));
							}
						}
						else
						{
							flag2 = this.RT3OMagComboBox.Equals(RuntimeHelpers.GetObjectValue(sender));
							if (flag2)
							{
								flag = (this.RT3OMagComboBox.SelectedIndex != -1);
								if (flag)
								{
									this.selectedPOIList.setMagnitude(Conversions.ToByte(this.RT3OMagComboBox.SelectedValue));
									this.RT3OFullPatchCheckBox.Enabled = (!this.selectedPOIList.fromRT3 & this.selectedPOIList.type == 4444 & this.selectedPOIList.magnitude >= 4);
									this.RT3OFullPatchCheckBox.Checked = this.selectedPOIList.fullPatch;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0013E000 File Offset: 0x0013D000
		private void RT3OTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboBox_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e, 65535);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0013E018 File Offset: 0x0013D018
		private void RT3OLayerComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboBox_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e, 255);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0013E030 File Offset: 0x0013D030
		private void RT3OScaleComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboBox_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e, 255);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0013E048 File Offset: 0x0013D048
		private void RT3OMagComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboBox_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e, 255);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0013E060 File Offset: 0x0013D060
		private void RT3OFullPatchCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.selectedPOIList.setFullPatch(this.RT3OFullPatchCheckBox.Checked);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0013E07C File Offset: 0x0013D07C
		private void RT3ODisplayMagCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.selectedPOIList.setDisplayMagnitude(this.RT3ODisplayMagCheckBox.Checked);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0013E098 File Offset: 0x0013D098
		private void Speed_NumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			bool visible = this.Visible;
			if (visible)
			{
				bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert & !this.selectedPOIList.fromArchive;
				if (flag)
				{
					uint speed = Convert.ToUInt32(this.Speed_NumericUpDown.Value);
					this.selectedPOIList.setSpeed(speed);
				}
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0013E0F4 File Offset: 0x0013D0F4
		private void ImportedPOIListsBindingSource_CurrentChanged_1(object sender, EventArgs e)
		{
			this.ImportedFilesListBox.Refresh();
			this.itemNbSelectedInPOIList = this.ImportedFilesListBox.SelectedIndices.Count;
			bool flag = this.itemNbSelectedInPOIList == 1;
			if (flag)
			{
				this.selectedPOIList = (POILists)this.ImportedFilesListBox.SelectedItem;
			}
			else
			{
				this.selectedPOIList = null;
			}
			this.wizardState.UpdateMainFormGUI();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0013E160 File Offset: 0x0013D160
		public void ImportedFilesListBoxSelectionChange(object sender, EventArgs e)
		{
			this.itemNbSelectedInPOIList = this.ImportedFilesListBox.SelectedIndices.Count;
			bool flag = this.itemNbSelectedInPOIList == 1;
			if (flag)
			{
				this.selectedPOIList = (POILists)this.ImportedFilesListBox.SelectedItem;
			}
			else
			{
				this.selectedPOIList = null;
			}
			this.wizardState.UpdateMainFormGUI();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0013E1C0 File Offset: 0x0013D1C0
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.DeleteList(false);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0013E1CC File Offset: 0x0013D1CC
		private void DeleteAndNeverLoadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.DeleteList(true);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0013E1D8 File Offset: 0x0013D1D8
		private void DeleteList(bool neverLoadAgain)
		{
			ListOfPOILists listOfPOILists = new ListOfPOILists();
			try
			{
				foreach (object obj in this.ImportedFilesListBox.SelectedItems)
				{
					POILists item = (POILists)obj;
					listOfPOILists.Add(item);
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.ImportedFilesListBox.SelectedIndex = -1;
			this.ImportedFilesListBox.BeginUpdate();
			this.mapMngt.importedPOIList.removeLists(listOfPOILists, neverLoadAgain);
			this.ImportedFilesListBox.EndUpdate();
			this.wizardState.changeState(WizardState.states.NOCHANGE);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0013E298 File Offset: 0x0013D298
		private void AlwaysAddToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.mapMngt.importedPOIList.addToAllwaysLoadList(this.ImportedFilesListBox.SelectedItems);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0013E2B8 File Offset: 0x0013D2B8
		private void MergeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListOfPOILists listOfPOILists = new ListOfPOILists();
			int selectedIndex = this.ImportedFilesListBox.SelectedIndices[0];
			try
			{
				foreach (object obj in this.ImportedFilesListBox.SelectedItems)
				{
					POILists item = (POILists)obj;
					listOfPOILists.Add(item);
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.ImportedFilesListBox.SelectedIndex = -1;
			this.ImportedFilesListBox.BeginUpdate();
			this.mapMngt.importedPOIList.mergeList(listOfPOILists);
			this.ImportedFilesListBox.EndUpdate();
			this.ImportedFilesListBox.SelectedIndex = selectedIndex;
			this.wizardState.changeState(WizardState.states.NOCHANGE);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0013E398 File Offset: 0x0013D398
		private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			renameDialog renameDialog = new renameDialog(this.selectedPOIList.name);
			renameDialog.ShowDialog();
			bool flag = renameDialog.DialogResult == DialogResult.OK;
			if (flag)
			{
				this.selectedPOIList.name = renameDialog.newName();
				this.bindingListOfPOIList.ResetBindings(false);
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0013E3EC File Offset: 0x0013D3EC
		private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = MyProject.Forms.ConfigDialog.ShowDialog(ConfigDialog.tabList.Export, ConfigDialog.tabList.Export) == DialogResult.OK;
			if (flag)
			{
				this.selectedPOIList.export(this.mapMngt.mapType, true, checked((exportToFile.exportFormat)MySettingsProperty.Settings.exportFormat));
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0013E43C File Offset: 0x0013D43C
		private void RemoveDuplicatesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int count = this.ImportedFilesListBox.Items.Count;
			MyProject.Forms.DupDialog.ShowDialog(this.mapMngt.importedPOIList.ListOfPOIList, this.ImportedFilesListBox.SelectedIndices, this.ImportedFilesListBox.SelectedItems, this.mapMngt.mapType);
			bool flag = this.ImportedFilesListBox.Items.Count != count;
			if (flag)
			{
				this.ImportedFilesListBox.SelectedIndex = checked(this.ImportedFilesListBox.Items.Count - 1);
			}
			this.wizardState.changeState(WizardState.states.NOCHANGE);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0013E4E4 File Offset: 0x0013D4E4
		private void CoordConv_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.mapMngt.mapType != Common.RTxMapType.Unknown;
			if (flag)
			{
				MyProject.Forms.CoordConvDialog.ShowDialog();
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0013E51C File Offset: 0x0013D51C
		private void MapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.userSettings.writeRTxModeDepSettings();
			this.mapMngt.unloadMap();
			Common.setRTxMapEditorMapMode(Common.RTxMapEditorMapModes.map);
			this.userSettings.readRTxModeDepSettings();
			this.bindWithRTxType();
			this.Patch_ToolStripButton.Text = Resources.strPatchButtonMap;
			this.Patch_ToolStripMenuItem.Text = Resources.strPatchButtonMap;
			this.mapMngt.POITypeInfo.setRTxMapEditorMapMode(Common.RTxMapEditorMapMode);
			this.wizardState.changeState(WizardState.states.NOT_LOADED);
			this.wizardState.UpdateMainFormVisibility();
			this.userSettings.lastLoadedMaps.updateMenu();
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0013E5C0 File Offset: 0x0013D5C0
		private void AlertToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = MyProject.Forms.CountryUserPOIDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				MySettingsProperty.Settings.alertDIRCID = MyProject.Forms.CountryUserPOIDialog.getCIDList();
				this.mapMngt.unloadMap();
				flag = this.mapMngt.loadFictMap(MySettingsProperty.Settings.alertDIRCID);
				if (flag)
				{
					this.userSettings.writeRTxModeDepSettings();
					Common.setRTxMapEditorMapMode(Common.RTxMapEditorMapModes.alert);
					this.userSettings.readRTxModeDepSettings();
					this.bindWithRTxType();
					this.Patch_ToolStripButton.Text = Resources.strPatchButtonAlert;
					this.Patch_ToolStripMenuItem.Text = Resources.strPatchButtonAlert;
					this.mapMngt.POITypeInfo.setRTxMapEditorMapMode(Common.RTxMapEditorMapMode);
					this.wizardState.changeState(WizardState.states.LOADED);
				}
				else
				{
					this.Patch_ToolStripMenuItem.Text = Resources.strPatchButtonMap;
					this.Patch_ToolStripButton.Text = Resources.strPatchButtonMap;
					Common.setRTxMapEditorMapMode(Common.RTxMapEditorMapModes.map);
					this.userSettings.readRTxModeDepSettings();
					this.wizardState.changeState(WizardState.states.NOT_LOADED);
					this.ImportedFilesListBox.SelectedIndex = -1;
				}
				this.wizardState.UpdateMainFormVisibility();
				this.userSettings.lastLoadedMaps.updateMenu();
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0013E704 File Offset: 0x0013D704
		private void ExtractBMPFromToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BMPUtils bmputils = new BMPUtils();
		}

		// Token: 0x04000061 RID: 97
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x04000063 RID: 99
		[AccessedThroughProperty("MenuStrip")]
		private MenuStrip _MenuStrip;

		// Token: 0x04000064 RID: 100
		[AccessedThroughProperty("File_ToolStripMenuItem")]
		private ToolStripMenuItem _File_ToolStripMenuItem;

		// Token: 0x04000065 RID: 101
		[AccessedThroughProperty("Import_ToolStripMenuItem")]
		private ToolStripMenuItem _Import_ToolStripMenuItem;

		// Token: 0x04000066 RID: 102
		[AccessedThroughProperty("Exit_ToolStripMenuItem")]
		private ToolStripMenuItem _Exit_ToolStripMenuItem;

		// Token: 0x04000067 RID: 103
		[AccessedThroughProperty("Help_ToolStripMenuItem")]
		private ToolStripMenuItem _Help_ToolStripMenuItem;

		// Token: 0x04000068 RID: 104
		[AccessedThroughProperty("ÀProposToolStripMenuItem")]
		private ToolStripMenuItem _ÀProposToolStripMenuItem;

		// Token: 0x04000069 RID: 105
		[AccessedThroughProperty("ToolStrip")]
		private ToolStrip _ToolStrip;

		// Token: 0x0400006A RID: 106
		[AccessedThroughProperty("Import_ToolStripButton")]
		private ToolStripButton _Import_ToolStripButton;

		// Token: 0x0400006B RID: 107
		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip _StatusStrip1;

		// Token: 0x0400006C RID: 108
		[AccessedThroughProperty("ToolStripStatusLabel1")]
		private ToolStripStatusLabel _ToolStripStatusLabel1;

		// Token: 0x0400006D RID: 109
		[AccessedThroughProperty("ToolStripStatusLabelSatus")]
		private ToolStripStatusLabel _ToolStripStatusLabelSatus;

		// Token: 0x0400006E RID: 110
		[AccessedThroughProperty("Language_ToolStripMenuItem")]
		private ToolStripMenuItem _Language_ToolStripMenuItem;

		// Token: 0x0400006F RID: 111
		[AccessedThroughProperty("FrançaisToolStripMenuItem")]
		private ToolStripMenuItem _FrançaisToolStripMenuItem;

		// Token: 0x04000070 RID: 112
		[AccessedThroughProperty("EnglishToolStripMenuItem")]
		private ToolStripMenuItem _EnglishToolStripMenuItem;

		// Token: 0x04000071 RID: 113
		[AccessedThroughProperty("Patch_ToolStripButton")]
		private ToolStripButton _Patch_ToolStripButton;

		// Token: 0x04000072 RID: 114
		[AccessedThroughProperty("Burn_ToolStripButton")]
		private ToolStripButton _Burn_ToolStripButton;

		// Token: 0x04000073 RID: 115
		[AccessedThroughProperty("Configure_ToolStripButton")]
		private ToolStripButton _Configure_ToolStripButton;

		// Token: 0x04000074 RID: 116
		[AccessedThroughProperty("Patch_ToolStripMenuItem")]
		private ToolStripMenuItem _Patch_ToolStripMenuItem;

		// Token: 0x04000075 RID: 117
		[AccessedThroughProperty("Burn_ToolStripMenuItem")]
		private ToolStripMenuItem _Burn_ToolStripMenuItem;

		// Token: 0x04000076 RID: 118
		[AccessedThroughProperty("ImportedFilesContextMenuStrip")]
		private ContextMenuStrip _ImportedFilesContextMenuStrip;

		// Token: 0x04000077 RID: 119
		[AccessedThroughProperty("DeleteToolStripMenuItem")]
		private ToolStripMenuItem _DeleteToolStripMenuItem;

		// Token: 0x04000078 RID: 120
		[AccessedThroughProperty("MergeToolStripMenuItem")]
		private ToolStripMenuItem _MergeToolStripMenuItem;

		// Token: 0x04000079 RID: 121
		[AccessedThroughProperty("RenameToolStripMenuItem")]
		private ToolStripMenuItem _RenameToolStripMenuItem;

		// Token: 0x0400007A RID: 122
		[AccessedThroughProperty("RemoveDuplicatesToolStripMenuItem")]
		private ToolStripMenuItem _RemoveDuplicatesToolStripMenuItem;

		// Token: 0x0400007B RID: 123
		[AccessedThroughProperty("RT3OptionTabControl")]
		private TabControl _RT3OptionTabControl;

		// Token: 0x0400007C RID: 124
		[AccessedThroughProperty("RT3OptionTabPage")]
		private TabPage _RT3OptionTabPage;

		// Token: 0x0400007D RID: 125
		[AccessedThroughProperty("RT3OTypeComboBox")]
		private ComboBox _RT3OTypeComboBox;

		// Token: 0x0400007E RID: 126
		[AccessedThroughProperty("RT3OLayerComboBox")]
		private ComboBox _RT3OLayerComboBox;

		// Token: 0x0400007F RID: 127
		[AccessedThroughProperty("POITypeLabel")]
		private Label _POITypeLabel;

		// Token: 0x04000080 RID: 128
		[AccessedThroughProperty("RT3OScaleComboBox")]
		private ComboBox _RT3OScaleComboBox;

		// Token: 0x04000081 RID: 129
		[AccessedThroughProperty("POIScaleLabel")]
		private Label _POIScaleLabel;

		// Token: 0x04000082 RID: 130
		[AccessedThroughProperty("POILayerLabel")]
		private Label _POILayerLabel;

		// Token: 0x04000083 RID: 131
		[AccessedThroughProperty("namedPlaceTabPage")]
		private TabPage _namedPlaceTabPage;

		// Token: 0x04000084 RID: 132
		[AccessedThroughProperty("TabPage3")]
		private TabPage _TabPage3;

		// Token: 0x04000085 RID: 133
		[AccessedThroughProperty("TabPage4")]
		private TabPage _TabPage4;

		// Token: 0x04000086 RID: 134
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x04000087 RID: 135
		[AccessedThroughProperty("ImportedFilesPropertiesGroupBox")]
		private GroupBox _ImportedFilesPropertiesGroupBox;

		// Token: 0x04000088 RID: 136
		[AccessedThroughProperty("ISO_ToolStripButton")]
		private ToolStripButton _ISO_ToolStripButton;

		// Token: 0x04000089 RID: 137
		[AccessedThroughProperty("ISO_ToolStripMenuItem")]
		private ToolStripMenuItem _ISO_ToolStripMenuItem;

		// Token: 0x0400008A RID: 138
		[AccessedThroughProperty("ConfigureF_ToolStripMenuItem")]
		private ToolStripMenuItem _ConfigureF_ToolStripMenuItem;

		// Token: 0x0400008B RID: 139
		[AccessedThroughProperty("POITypePictureBox")]
		private PictureBox _POITypePictureBox;

		// Token: 0x0400008C RID: 140
		[AccessedThroughProperty("ToolStripProgressBar1")]
		private ToolStripProgressBar _ToolStripProgressBar1;

		// Token: 0x0400008D RID: 141
		[AccessedThroughProperty("UsersGuideToolStripMenuItem")]
		private ToolStripMenuItem _UsersGuideToolStripMenuItem;

		// Token: 0x0400008E RID: 142
		[AccessedThroughProperty("LogfileToolStripMenuItem")]
		private ToolStripMenuItem _LogfileToolStripMenuItem;

		// Token: 0x0400008F RID: 143
		[AccessedThroughProperty("LicenseToolStripMenuItem")]
		private ToolStripMenuItem _LicenseToolStripMenuItem;

		// Token: 0x04000090 RID: 144
		[AccessedThroughProperty("UserDefNameTextBox")]
		private TextBox _UserDefNameTextBox;

		// Token: 0x04000091 RID: 145
		[AccessedThroughProperty("ComboBox3")]
		private ComboBox _ComboBox3;

		// Token: 0x04000092 RID: 146
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000093 RID: 147
		[AccessedThroughProperty("ComboBox2")]
		private ComboBox _ComboBox2;

		// Token: 0x04000094 RID: 148
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000095 RID: 149
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000096 RID: 150
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x04000097 RID: 151
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000098 RID: 152
		[AccessedThroughProperty("nameGpsPassionRadioButton")]
		private RadioButton _nameGpsPassionRadioButton;

		// Token: 0x04000099 RID: 153
		[AccessedThroughProperty("nameUserDefinedRadioButton")]
		private RadioButton _nameUserDefinedRadioButton;

		// Token: 0x0400009A RID: 154
		[AccessedThroughProperty("nameAsIsRadioButton")]
		private RadioButton _nameAsIsRadioButton;

		// Token: 0x0400009B RID: 155
		[AccessedThroughProperty("nameExampleValueLabel")]
		private Label _nameExampleValueLabel;

		// Token: 0x0400009C RID: 156
		[AccessedThroughProperty("nameExampleLabel")]
		private Label _nameExampleLabel;

		// Token: 0x0400009D RID: 157
		[AccessedThroughProperty("RT3OMagComboBox")]
		private ComboBox _RT3OMagComboBox;

		// Token: 0x0400009E RID: 158
		[AccessedThroughProperty("POIMagLabel")]
		private Label _POIMagLabel;

		// Token: 0x0400009F RID: 159
		[AccessedThroughProperty("namegpspasFormatPanel")]
		private Panel _namegpspasFormatPanel;

		// Token: 0x040000A0 RID: 160
		[AccessedThroughProperty("isGpsPasMiscDisplayedCheckBox")]
		private CheckBox _isGpsPasMiscDisplayedCheckBox;

		// Token: 0x040000A1 RID: 161
		[AccessedThroughProperty("isGpsPasDirDisplayedCheckBox")]
		private CheckBox _isGpsPasDirDisplayedCheckBox;

		// Token: 0x040000A2 RID: 162
		[AccessedThroughProperty("isGpsPasSep2DisplayedCheckBox")]
		private CheckBox _isGpsPasSep2DisplayedCheckBox;

		// Token: 0x040000A3 RID: 163
		[AccessedThroughProperty("isGpsPasSpeedUnitDisplayedCheckBox")]
		private CheckBox _isGpsPasSpeedUnitDisplayedCheckBox;

		// Token: 0x040000A4 RID: 164
		[AccessedThroughProperty("isGpsPasSpeedDisplayedCheckBox")]
		private CheckBox _isGpsPasSpeedDisplayedCheckBox;

		// Token: 0x040000A5 RID: 165
		[AccessedThroughProperty("isGpsPasSep1DisplayedCheckBox")]
		private CheckBox _isGpsPasSep1DisplayedCheckBox;

		// Token: 0x040000A6 RID: 166
		[AccessedThroughProperty("isGpsPasNumDisplayedCheckBox")]
		private CheckBox _isGpsPasNumDisplayedCheckBox;

		// Token: 0x040000A7 RID: 167
		[AccessedThroughProperty("isGpsPasTypeDisplayedCheckBox")]
		private CheckBox _isGpsPasTypeDisplayedCheckBox;

		// Token: 0x040000A8 RID: 168
		[AccessedThroughProperty("isGpsPasRFRPostDisplayedCheckBox")]
		private CheckBox _isGpsPasRFRPostDisplayedCheckBox;

		// Token: 0x040000A9 RID: 169
		[AccessedThroughProperty("HelpProvider1")]
		private HelpProvider _HelpProvider1;

		// Token: 0x040000AA RID: 170
		[AccessedThroughProperty("isGpsPasStartDisplayedCheckBox")]
		private CheckBox _isGpsPasStartDisplayedCheckBox;

		// Token: 0x040000AB RID: 171
		[AccessedThroughProperty("isGpsPasEndDisplayedCheckBox")]
		private CheckBox _isGpsPasEndDisplayedCheckBox;

		// Token: 0x040000AC RID: 172
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040000AD RID: 173
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040000AE RID: 174
		[AccessedThroughProperty("ExportToolStripMenuItem")]
		private ToolStripMenuItem _ExportToolStripMenuItem;

		// Token: 0x040000AF RID: 175
		[AccessedThroughProperty("RT3OFullPatchCheckBox")]
		private CheckBox _RT3OFullPatchCheckBox;

		// Token: 0x040000B0 RID: 176
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040000B1 RID: 177
		[AccessedThroughProperty("RT3ODisplayMagCheckBox")]
		private CheckBox _RT3ODisplayMagCheckBox;

		// Token: 0x040000B2 RID: 178
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040000B3 RID: 179
		[AccessedThroughProperty("POIradarListsToolStripMenuItem")]
		private ToolStripMenuItem _POIradarListsToolStripMenuItem;

		// Token: 0x040000B4 RID: 180
		[AccessedThroughProperty("HackingToolStripMenuItem")]
		private ToolStripMenuItem _HackingToolStripMenuItem;

		// Token: 0x040000B5 RID: 181
		[AccessedThroughProperty("RT3MapEditorAndTheHackingToolStripMenuItem")]
		private ToolStripMenuItem _RT3MapEditorAndTheHackingToolStripMenuItem;

		// Token: 0x040000B6 RID: 182
		[AccessedThroughProperty("PortuguêsToolStripMenuItem")]
		private ToolStripMenuItem _PortuguêsToolStripMenuItem;

		// Token: 0x040000B7 RID: 183
		[AccessedThroughProperty("USB_ToolStripButton")]
		private ToolStripButton _USB_ToolStripButton;

		// Token: 0x040000B8 RID: 184
		[AccessedThroughProperty("USB_ToolStripMenuItem")]
		private ToolStripMenuItem _USB_ToolStripMenuItem;

		// Token: 0x040000B9 RID: 185
		[AccessedThroughProperty("RT4_ToolStripMenuItem")]
		private ToolStripMenuItem _RT4_ToolStripMenuItem;

		// Token: 0x040000BA RID: 186
		[AccessedThroughProperty("RT4MapUSBToolStripMenuItem")]
		private ToolStripMenuItem _RT4MapUSBToolStripMenuItem;

		// Token: 0x040000BB RID: 187
		[AccessedThroughProperty("Tools_ToolStripMenuItem")]
		private ToolStripMenuItem _Tools_ToolStripMenuItem;

		// Token: 0x040000BC RID: 188
		[AccessedThroughProperty("SplitMapGfxgphToolStripMenuItem")]
		private ToolStripMenuItem _SplitMapGfxgphToolStripMenuItem;

		// Token: 0x040000BD RID: 189
		[AccessedThroughProperty("LoadMap_ToolStripMenuItem")]
		private ToolStripMenuItem _LoadMap_ToolStripMenuItem;

		// Token: 0x040000BE RID: 190
		[AccessedThroughProperty("AddAllPOIToolStripMenuItem")]
		private ToolStripMenuItem _AddAllPOIToolStripMenuItem;

		// Token: 0x040000BF RID: 191
		[AccessedThroughProperty("ImportedFilesGroupBox")]
		private GroupBox _ImportedFilesGroupBox;

		// Token: 0x040000C0 RID: 192
		[AccessedThroughProperty("ImportedFilesListBox")]
		private ListBox _ImportedFilesListBox;

		// Token: 0x040000C1 RID: 193
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x040000C2 RID: 194
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x040000C3 RID: 195
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x040000C4 RID: 196
		[AccessedThroughProperty("ToolStripSeparator5")]
		private ToolStripSeparator _ToolStripSeparator5;

		// Token: 0x040000C5 RID: 197
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x040000C6 RID: 198
		[AccessedThroughProperty("Or_ToolStripLabel")]
		private ToolStripLabel _Or_ToolStripLabel;

		// Token: 0x040000C7 RID: 199
		[AccessedThroughProperty("Map9ToolStripMenuItem")]
		private ToolStripMenuItem _Map9ToolStripMenuItem;

		// Token: 0x040000C8 RID: 200
		[AccessedThroughProperty("Map8ToolStripMenuItem")]
		private ToolStripMenuItem _Map8ToolStripMenuItem;

		// Token: 0x040000C9 RID: 201
		[AccessedThroughProperty("Map7ToolStripMenuItem")]
		private ToolStripMenuItem _Map7ToolStripMenuItem;

		// Token: 0x040000CA RID: 202
		[AccessedThroughProperty("Map6ToolStripMenuItem")]
		private ToolStripMenuItem _Map6ToolStripMenuItem;

		// Token: 0x040000CB RID: 203
		[AccessedThroughProperty("Map5ToolStripMenuItem")]
		private ToolStripMenuItem _Map5ToolStripMenuItem;

		// Token: 0x040000CC RID: 204
		[AccessedThroughProperty("Map4ToolStripMenuItem")]
		private ToolStripMenuItem _Map4ToolStripMenuItem;

		// Token: 0x040000CD RID: 205
		[AccessedThroughProperty("Map3ToolStripMenuItem")]
		private ToolStripMenuItem _Map3ToolStripMenuItem;

		// Token: 0x040000CE RID: 206
		[AccessedThroughProperty("Map2ToolStripMenuItem")]
		private ToolStripMenuItem _Map2ToolStripMenuItem;

		// Token: 0x040000CF RID: 207
		[AccessedThroughProperty("Map1ToolStripMenuItem")]
		private ToolStripMenuItem _Map1ToolStripMenuItem;

		// Token: 0x040000D0 RID: 208
		[AccessedThroughProperty("Map0ToolStripMenuItem")]
		private ToolStripMenuItem _Map0ToolStripMenuItem;

		// Token: 0x040000D1 RID: 209
		[AccessedThroughProperty("MapToolStripSeparator")]
		private ToolStripSeparator _MapToolStripSeparator;

		// Token: 0x040000D2 RID: 210
		[AccessedThroughProperty("LoadMap_ToolStripButton")]
		private ToolStripSplitButton _LoadMap_ToolStripButton;

		// Token: 0x040000D3 RID: 211
		[AccessedThroughProperty("Map0ToolStripMenuItem1")]
		private ToolStripMenuItem _Map0ToolStripMenuItem1;

		// Token: 0x040000D4 RID: 212
		[AccessedThroughProperty("Map1ToolStripMenuItem1")]
		private ToolStripMenuItem _Map1ToolStripMenuItem1;

		// Token: 0x040000D5 RID: 213
		[AccessedThroughProperty("Map2ToolStripMenuItem1")]
		private ToolStripMenuItem _Map2ToolStripMenuItem1;

		// Token: 0x040000D6 RID: 214
		[AccessedThroughProperty("Map3ToolStripMenuItem1")]
		private ToolStripMenuItem _Map3ToolStripMenuItem1;

		// Token: 0x040000D7 RID: 215
		[AccessedThroughProperty("Map4ToolStripMenuItem1")]
		private ToolStripMenuItem _Map4ToolStripMenuItem1;

		// Token: 0x040000D8 RID: 216
		[AccessedThroughProperty("Map5ToolStripMenuItem1")]
		private ToolStripMenuItem _Map5ToolStripMenuItem1;

		// Token: 0x040000D9 RID: 217
		[AccessedThroughProperty("Map6ToolStripMenuItem1")]
		private ToolStripMenuItem _Map6ToolStripMenuItem1;

		// Token: 0x040000DA RID: 218
		[AccessedThroughProperty("Map7ToolStripMenuItem1")]
		private ToolStripMenuItem _Map7ToolStripMenuItem1;

		// Token: 0x040000DB RID: 219
		[AccessedThroughProperty("Map8ToolStripMenuItem1")]
		private ToolStripMenuItem _Map8ToolStripMenuItem1;

		// Token: 0x040000DC RID: 220
		[AccessedThroughProperty("Map9ToolStripMenuItem1")]
		private ToolStripMenuItem _Map9ToolStripMenuItem1;

		// Token: 0x040000DD RID: 221
		[AccessedThroughProperty("DeleteAndNeverLoadToolStripMenuItem")]
		private ToolStripMenuItem _DeleteAndNeverLoadToolStripMenuItem;

		// Token: 0x040000DE RID: 222
		[AccessedThroughProperty("AlwaysAddToolStripMenuItem")]
		private ToolStripMenuItem _AlwaysAddToolStripMenuItem;

		// Token: 0x040000DF RID: 223
		[AccessedThroughProperty("AllToolStripMenuItem")]
		private ToolStripMenuItem _AllToolStripMenuItem;

		// Token: 0x040000E0 RID: 224
		[AccessedThroughProperty("ImportationToolStripMenuItem")]
		private ToolStripMenuItem _ImportationToolStripMenuItem;

		// Token: 0x040000E1 RID: 225
		[AccessedThroughProperty("RadarImportationToolStripMenuItem")]
		private ToolStripMenuItem _RadarImportationToolStripMenuItem;

		// Token: 0x040000E2 RID: 226
		[AccessedThroughProperty("RadarNameToolStripMenuItem")]
		private ToolStripMenuItem _RadarNameToolStripMenuItem;

		// Token: 0x040000E3 RID: 227
		[AccessedThroughProperty("ExportationToolStripMenuItem")]
		private ToolStripMenuItem _ExportationToolStripMenuItem;

		// Token: 0x040000E4 RID: 228
		[AccessedThroughProperty("ReloadMapWithAllPOIToolStripMenuItem")]
		private ToolStripMenuItem _ReloadMapWithAllPOIToolStripMenuItem;

		// Token: 0x040000E5 RID: 229
		[AccessedThroughProperty("RT4ConfigurationUSBKeyToolStripMenuItem")]
		private ToolStripMenuItem _RT4ConfigurationUSBKeyToolStripMenuItem;

		// Token: 0x040000E6 RID: 230
		[AccessedThroughProperty("BootScreenRT4ToolStripMenuItem")]
		private ToolStripMenuItem _BootScreenRT4ToolStripMenuItem;

		// Token: 0x040000E7 RID: 231
		[AccessedThroughProperty("ToolStripSeparator6")]
		private ToolStripSeparator _ToolStripSeparator6;

		// Token: 0x040000E8 RID: 232
		[AccessedThroughProperty("AgendatdatRT4ToolStripMenuItem")]
		private ToolStripMenuItem _AgendatdatRT4ToolStripMenuItem;

		// Token: 0x040000E9 RID: 233
		[AccessedThroughProperty("UsercomdatRT4ToolStripMenuItem")]
		private ToolStripMenuItem _UsercomdatRT4ToolStripMenuItem;

		// Token: 0x040000EA RID: 234
		[AccessedThroughProperty("CoordConv_ToolStripMenuItem")]
		private ToolStripMenuItem _CoordConv_ToolStripMenuItem;

		// Token: 0x040000EB RID: 235
		[AccessedThroughProperty("RadarIconDisplayRTxToolStripMenuItem")]
		private ToolStripMenuItem _RadarIconDisplayRTxToolStripMenuItem;

		// Token: 0x040000EC RID: 236
		[AccessedThroughProperty("ModeToolStripMenuItem")]
		private ToolStripMenuItem _ModeToolStripMenuItem;

		// Token: 0x040000ED RID: 237
		[AccessedThroughProperty("MapToolStripMenuItem")]
		private ToolStripMenuItem _MapToolStripMenuItem;

		// Token: 0x040000EE RID: 238
		[AccessedThroughProperty("AlertToolStripMenuItem")]
		private ToolStripMenuItem _AlertToolStripMenuItem;

		// Token: 0x040000EF RID: 239
		[AccessedThroughProperty("ExtractBMPFromToolStripMenuItem")]
		private ToolStripMenuItem _ExtractBMPFromToolStripMenuItem;

		// Token: 0x040000F0 RID: 240
		[AccessedThroughProperty("Speed_NumericUpDown")]
		private NumericUpDown _Speed_NumericUpDown;

		// Token: 0x040000F1 RID: 241
		[AccessedThroughProperty("SpeedLimit_Label")]
		private Label _SpeedLimit_Label;

		// Token: 0x040000F2 RID: 242
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040000F3 RID: 243
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040000F4 RID: 244
		public Common common;

		// Token: 0x040000F5 RID: 245
		public POILists selectedPOIList;

		// Token: 0x040000F6 RID: 246
		public int itemNbSelectedInPOIList;

		// Token: 0x040000F7 RID: 247
		public string CurrentWorkingDir;

		// Token: 0x040000F8 RID: 248
		public WizardState wizardState;

		// Token: 0x040000F9 RID: 249
		public OpenFiles2ImportDialog openFiles2ImportDialog;

		// Token: 0x040000FA RID: 250
		public ChoseFile2ExportDialog choseFile2ExportDialog;

		// Token: 0x040000FB RID: 251
		public formMainNameTabPage formMainNameTabPage;

		// Token: 0x040000FC RID: 252
		private BindingSource bindingListOfPOIList;

		// Token: 0x040000FD RID: 253
		private bool isFirstRun;

		// Token: 0x040000FE RID: 254
		public userSettings userSettings;

		// Token: 0x040000FF RID: 255
		public RTxScreen RTxScreen;

		// Token: 0x04000100 RID: 256
		public MAPMngt mapMngt;

		// Token: 0x04000101 RID: 257
		public RT4Utils RT4Mngt;
	}
}
