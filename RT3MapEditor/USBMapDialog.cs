using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x02000041 RID: 65
	[DesignerGenerated]
	public partial class USBMapDialog : Form
	{
		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0015D890 File Offset: 0x0015C890
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x0015D8A8 File Offset: 0x0015C8A8
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

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0015D8B4 File Offset: 0x0015C8B4
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x0015D8CC File Offset: 0x0015C8CC
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0015D938 File Offset: 0x0015C938
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x0015D950 File Offset: 0x0015C950
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

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0015D9BC File Offset: 0x0015C9BC
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x0015D9D4 File Offset: 0x0015C9D4
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

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0015D9E0 File Offset: 0x0015C9E0
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x0015D9F8 File Offset: 0x0015C9F8
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0015DA64 File Offset: 0x0015CA64
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0015DA7C File Offset: 0x0015CA7C
		internal virtual CheckBox ItalyCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ItalyCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ItalyCheckBox != null;
				if (flag)
				{
					this._ItalyCheckBox.CheckedChanged -= this.ItalyCheckBox_CheckedChanged;
				}
				this._ItalyCheckBox = value;
				flag = (this._ItalyCheckBox != null);
				if (flag)
				{
					this._ItalyCheckBox.CheckedChanged += this.ItalyCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0015DAE8 File Offset: 0x0015CAE8
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0015DB00 File Offset: 0x0015CB00
		internal virtual CheckBox FranceCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FranceCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._FranceCheckBox != null;
				if (flag)
				{
					this._FranceCheckBox.CheckedChanged -= this.FranceCheckBox_CheckedChanged;
				}
				this._FranceCheckBox = value;
				flag = (this._FranceCheckBox != null);
				if (flag)
				{
					this._FranceCheckBox.CheckedChanged += this.FranceCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0015DB6C File Offset: 0x0015CB6C
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x0015DB84 File Offset: 0x0015CB84
		internal virtual CheckBox SPCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SPCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._SPCheckBox != null;
				if (flag)
				{
					this._SPCheckBox.CheckedChanged -= this.SPCheckBox_CheckedChanged;
				}
				this._SPCheckBox = value;
				flag = (this._SPCheckBox != null);
				if (flag)
				{
					this._SPCheckBox.CheckedChanged += this.SPCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0015DBF0 File Offset: 0x0015CBF0
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x0015DC08 File Offset: 0x0015CC08
		internal virtual CheckBox BeneluxCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BeneluxCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._BeneluxCheckBox != null;
				if (flag)
				{
					this._BeneluxCheckBox.CheckedChanged -= this.BeneluxCheckBox_CheckedChanged;
				}
				this._BeneluxCheckBox = value;
				flag = (this._BeneluxCheckBox != null);
				if (flag)
				{
					this._BeneluxCheckBox.CheckedChanged += this.BeneluxCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0015DC74 File Offset: 0x0015CC74
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x0015DC8C File Offset: 0x0015CC8C
		internal virtual CheckBox UKCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UKCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._UKCheckBox != null;
				if (flag)
				{
					this._UKCheckBox.CheckedChanged -= this.UKCheckBox_CheckedChanged;
				}
				this._UKCheckBox = value;
				flag = (this._UKCheckBox != null);
				if (flag)
				{
					this._UKCheckBox.CheckedChanged += this.UKCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0015DCF8 File Offset: 0x0015CCF8
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x0015DD10 File Offset: 0x0015CD10
		internal virtual CheckBox ScanCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ScanCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ScanCheckBox != null;
				if (flag)
				{
					this._ScanCheckBox.CheckedChanged -= this.ScanCheckBox_CheckedChanged;
				}
				this._ScanCheckBox = value;
				flag = (this._ScanCheckBox != null);
				if (flag)
				{
					this._ScanCheckBox.CheckedChanged += this.ScanCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x0015DD7C File Offset: 0x0015CD7C
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x0015DD94 File Offset: 0x0015CD94
		internal virtual CheckBox GermanyCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GermanyCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._GermanyCheckBox != null;
				if (flag)
				{
					this._GermanyCheckBox.CheckedChanged -= this.GermanyCheckBox_CheckedChanged;
				}
				this._GermanyCheckBox = value;
				flag = (this._GermanyCheckBox != null);
				if (flag)
				{
					this._GermanyCheckBox.CheckedChanged += this.GermanyCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0015DE00 File Offset: 0x0015CE00
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x0015DE18 File Offset: 0x0015CE18
		internal virtual CheckBox MECheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MECheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._MECheckBox != null;
				if (flag)
				{
					this._MECheckBox.CheckedChanged -= this.MECheckBox_CheckedChanged;
				}
				this._MECheckBox = value;
				flag = (this._MECheckBox != null);
				if (flag)
				{
					this._MECheckBox.CheckedChanged += this.MECheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x0015DE84 File Offset: 0x0015CE84
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x0015DE9C File Offset: 0x0015CE9C
		internal virtual CheckBox EESCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EESCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._EESCheckBox != null;
				if (flag)
				{
					this._EESCheckBox.CheckedChanged -= this.EESCheckBox_CheckedChanged;
				}
				this._EESCheckBox = value;
				flag = (this._EESCheckBox != null);
				if (flag)
				{
					this._EESCheckBox.CheckedChanged += this.EESCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0015DF08 File Offset: 0x0015CF08
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x0015DF20 File Offset: 0x0015CF20
		internal virtual CheckBox EENECheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EENECheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._EENECheckBox != null;
				if (flag)
				{
					this._EENECheckBox.CheckedChanged -= this.EENECheckBox_CheckedChanged;
				}
				this._EENECheckBox = value;
				flag = (this._EENECheckBox != null);
				if (flag)
				{
					this._EENECheckBox.CheckedChanged += this.EENECheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0015DF8C File Offset: 0x0015CF8C
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x0015DFA4 File Offset: 0x0015CFA4
		internal virtual CheckBox EENWCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EENWCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._EENWCheckBox != null;
				if (flag)
				{
					this._EENWCheckBox.CheckedChanged -= this.EENWCheckBox_CheckedChanged;
				}
				this._EENWCheckBox = value;
				flag = (this._EENWCheckBox != null);
				if (flag)
				{
					this._EENWCheckBox.CheckedChanged += this.EENWCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x0015E010 File Offset: 0x0015D010
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x0015E028 File Offset: 0x0015D028
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0015E034 File Offset: 0x0015D034
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x0015E04C File Offset: 0x0015D04C
		internal virtual Label SizeLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SizeLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SizeLabel = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x0015E058 File Offset: 0x0015D058
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0015E070 File Offset: 0x0015D070
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

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0015E07C File Offset: 0x0015D07C
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x0015E094 File Offset: 0x0015D094
		internal virtual GroupBox CIDGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CIDGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CIDGroupBox = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0015E0A0 File Offset: 0x0015D0A0
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x0015E0B8 File Offset: 0x0015D0B8
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

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0015E0C4 File Offset: 0x0015D0C4
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x0015E0DC File Offset: 0x0015D0DC
		internal virtual GroupBox OptionGroupBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OptionGroupBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OptionGroupBox = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0015E0E8 File Offset: 0x0015D0E8
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x0015E100 File Offset: 0x0015D100
		internal virtual CheckBox DebugCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DebugCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DebugCheckBox = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0015E10C File Offset: 0x0015D10C
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x0015E124 File Offset: 0x0015D124
		internal virtual CheckBox FastCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FastCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._FastCheckBox != null;
				if (flag)
				{
					this._FastCheckBox.CheckedChanged -= this.FastCheckBox_CheckedChanged;
				}
				this._FastCheckBox = value;
				flag = (this._FastCheckBox != null);
				if (flag)
				{
					this._FastCheckBox.CheckedChanged += this.FastCheckBox_CheckedChanged;
				}
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0015E190 File Offset: 0x0015D190
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0015E1A8 File Offset: 0x0015D1A8
		internal virtual CheckBox CRCCheckBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CRCCheckBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CRCCheckBox = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0015E1B4 File Offset: 0x0015D1B4
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0015E1CC File Offset: 0x0015D1CC
		internal virtual Label DurLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DurLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DurLabel = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0015E1D8 File Offset: 0x0015D1D8
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x0015E1F0 File Offset: 0x0015D1F0
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

		// Token: 0x06000746 RID: 1862 RVA: 0x0015E1FC File Offset: 0x0015D1FC
		public USBMapDialog()
		{
			base.Load += this.USBMapDialog_Load;
			base.Shown += this.USBMapDialog_Shown;
			ArrayList _ENCList = USBMapDialog.__ENCList;
			lock (_ENCList)
			{
				USBMapDialog.__ENCList.Add(new WeakReference(this));
			}
			this.neededSize = 10;
			this.availSize = 0;
			this.CIDList = new List<string>();
			this.prevCRCCheck = false;
			this.InitializeComponent();
			this.driveList = new DriveList(this.DriveListView, 0L, new DriveList.driveChanged(this.updateGUI));
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0015E2C0 File Offset: 0x0015D2C0
		private void updateGUI()
		{
			bool flag = this.neededSize == 10;
			int num;
			if (flag)
			{
				num = 0;
			}
			else
			{
				num = this.neededSize;
			}
			this.SizeLabel.Text = string.Format("{0:G} / {1:G}", num, this.driveList.getDriveSize());
			flag = (this.neededSize <= this.driveList.getDriveSize());
			if (flag)
			{
				this.OK_Button.Enabled = true;
				this.SizeLabel.ForeColor = Control.DefaultForeColor;
			}
			else
			{
				this.OK_Button.Enabled = false;
				this.SizeLabel.ForeColor = Color.Red;
			}
			this.DurLabel.Text = string.Format("{0:G} min", Conversion.Int((double)(checked(this.neededSize * 1024)) / 23100.0));
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0015E3A8 File Offset: 0x0015D3A8
		private void ItalyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.ItalyCheckBox.Checked;
			checked
			{
				if (@checked)
				{
					this.neededSize += 340;
					this.CIDList.Add("001");
				}
				else
				{
					this.neededSize -= 340;
					this.CIDList.Remove("001");
				}
				this.updateGUI();
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0015E418 File Offset: 0x0015D418
		private void FranceCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.FranceCheckBox.Checked;
			checked
			{
				if (@checked)
				{
					this.neededSize += 450;
					this.CIDList.Add("002");
				}
				else
				{
					this.neededSize -= 450;
					this.CIDList.Remove("002");
				}
				this.updateGUI();
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0015E488 File Offset: 0x0015D488
		private void SPCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.SPCheckBox.Checked;
			checked
			{
				if (@checked)
				{
					this.neededSize += 360;
					this.CIDList.Add("003");
				}
				else
				{
					this.neededSize -= 360;
					this.CIDList.Remove("003");
				}
				this.updateGUI();
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0015E4F8 File Offset: 0x0015D4F8
		private void BeneluxCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.BeneluxCheckBox.Checked;
			checked
			{
				if (@checked)
				{
					this.neededSize += 150;
					this.CIDList.Add("004");
				}
				else
				{
					this.neededSize -= 150;
					this.CIDList.Remove("004");
				}
				this.updateGUI();
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0015E568 File Offset: 0x0015D568
		private void UKCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.UKCheckBox.Checked;
			checked
			{
				if (@checked)
				{
					this.neededSize += 260;
					this.CIDList.Add("005");
				}
				else
				{
					this.neededSize -= 260;
					this.CIDList.Remove("005");
				}
				this.updateGUI();
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0015E5D8 File Offset: 0x0015D5D8
		private void ScanCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.ScanCheckBox.Checked;
			checked
			{
				if (@checked)
				{
					this.neededSize += 410;
					this.CIDList.Add("006");
				}
				else
				{
					this.neededSize -= 410;
					this.CIDList.Remove("006");
				}
				this.updateGUI();
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0015E648 File Offset: 0x0015D648
		private void GermanyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.GermanyCheckBox.Checked;
			checked
			{
				if (@checked)
				{
					this.neededSize += 450;
					this.CIDList.Add("012");
				}
				else
				{
					this.neededSize -= 450;
					this.CIDList.Remove("012");
				}
				this.updateGUI();
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0015E6B8 File Offset: 0x0015D6B8
		private void MECheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.MECheckBox.Checked;
			checked
			{
				if (@checked)
				{
					this.neededSize += 180;
					this.CIDList.Add("013");
				}
				else
				{
					this.neededSize -= 180;
					this.CIDList.Remove("013");
				}
				this.updateGUI();
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0015E728 File Offset: 0x0015D728
		private void EESCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.EESCheckBox.Checked;
			checked
			{
				if (@checked)
				{
					this.neededSize += 60;
					this.CIDList.Add("020");
				}
				else
				{
					this.neededSize -= 60;
					this.CIDList.Remove("020");
				}
				this.updateGUI();
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0015E794 File Offset: 0x0015D794
		private void EENECheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.EENECheckBox.Checked;
			checked
			{
				if (@checked)
				{
					this.neededSize += 20;
					this.CIDList.Add("021");
				}
				else
				{
					this.neededSize -= 20;
					this.CIDList.Remove("021");
				}
				this.updateGUI();
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0015E800 File Offset: 0x0015D800
		private void EENWCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.EENWCheckBox.Checked;
			checked
			{
				if (@checked)
				{
					this.neededSize += 170;
					this.CIDList.Add("022");
				}
				else
				{
					this.neededSize -= 170;
					this.CIDList.Remove("022");
				}
				this.updateGUI();
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0015E870 File Offset: 0x0015D870
		private void FastCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.FastCheckBox.Checked;
			if (@checked)
			{
				this.prevCRCCheck = this.CRCCheckBox.Checked;
				this.CRCCheckBox.Enabled = false;
				this.CRCCheckBox.Checked = false;
			}
			else
			{
				this.CRCCheckBox.Enabled = true;
				this.CRCCheckBox.Checked = this.prevCRCCheck;
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0015E8DC File Offset: 0x0015D8DC
		private void USBMapDialog_Load(object sender, EventArgs e)
		{
			this.driveList.buildDriveList();
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0015E8EC File Offset: 0x0015D8EC
		private void USBMapDialog_Shown(object sender, EventArgs e)
		{
			this.driveList.defaultSelect();
			this.updateGUI();
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0015E904 File Offset: 0x0015D904
		private void Refresh_Button_Click(object sender, EventArgs e)
		{
			this.driveList.buildDriveList();
			this.driveList.defaultSelect();
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0015E920 File Offset: 0x0015D920
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0015E934 File Offset: 0x0015D934
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0015E948 File Offset: 0x0015D948
		public string getDriveToUse()
		{
			return this.driveList.getDriveToUse();
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0015E968 File Offset: 0x0015D968
		public List<string> getCIDList()
		{
			return this.CIDList;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0015E980 File Offset: 0x0015D980
		public bool getFastCopy()
		{
			return this.FastCheckBox.Checked;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0015E9A0 File Offset: 0x0015D9A0
		public bool getCRCCheck()
		{
			return this.CRCCheckBox.Checked;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0015E9C0 File Offset: 0x0015D9C0
		public bool getTraceHigh()
		{
			return this.DebugCheckBox.Checked;
		}

		// Token: 0x040003F5 RID: 1013
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040003F7 RID: 1015
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x040003F8 RID: 1016
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x040003F9 RID: 1017
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x040003FA RID: 1018
		[AccessedThroughProperty("DriveListView")]
		private ListView _DriveListView;

		// Token: 0x040003FB RID: 1019
		[AccessedThroughProperty("Refresh_Button")]
		private Button _Refresh_Button;

		// Token: 0x040003FC RID: 1020
		[AccessedThroughProperty("ItalyCheckBox")]
		private CheckBox _ItalyCheckBox;

		// Token: 0x040003FD RID: 1021
		[AccessedThroughProperty("FranceCheckBox")]
		private CheckBox _FranceCheckBox;

		// Token: 0x040003FE RID: 1022
		[AccessedThroughProperty("SPCheckBox")]
		private CheckBox _SPCheckBox;

		// Token: 0x040003FF RID: 1023
		[AccessedThroughProperty("BeneluxCheckBox")]
		private CheckBox _BeneluxCheckBox;

		// Token: 0x04000400 RID: 1024
		[AccessedThroughProperty("UKCheckBox")]
		private CheckBox _UKCheckBox;

		// Token: 0x04000401 RID: 1025
		[AccessedThroughProperty("ScanCheckBox")]
		private CheckBox _ScanCheckBox;

		// Token: 0x04000402 RID: 1026
		[AccessedThroughProperty("GermanyCheckBox")]
		private CheckBox _GermanyCheckBox;

		// Token: 0x04000403 RID: 1027
		[AccessedThroughProperty("MECheckBox")]
		private CheckBox _MECheckBox;

		// Token: 0x04000404 RID: 1028
		[AccessedThroughProperty("EESCheckBox")]
		private CheckBox _EESCheckBox;

		// Token: 0x04000405 RID: 1029
		[AccessedThroughProperty("EENECheckBox")]
		private CheckBox _EENECheckBox;

		// Token: 0x04000406 RID: 1030
		[AccessedThroughProperty("EENWCheckBox")]
		private CheckBox _EENWCheckBox;

		// Token: 0x04000407 RID: 1031
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000408 RID: 1032
		[AccessedThroughProperty("SizeLabel")]
		private Label _SizeLabel;

		// Token: 0x04000409 RID: 1033
		[AccessedThroughProperty("USBGroupBox")]
		private GroupBox _USBGroupBox;

		// Token: 0x0400040A RID: 1034
		[AccessedThroughProperty("CIDGroupBox")]
		private GroupBox _CIDGroupBox;

		// Token: 0x0400040B RID: 1035
		[AccessedThroughProperty("HelpProvider1")]
		private HelpProvider _HelpProvider1;

		// Token: 0x0400040C RID: 1036
		[AccessedThroughProperty("OptionGroupBox")]
		private GroupBox _OptionGroupBox;

		// Token: 0x0400040D RID: 1037
		[AccessedThroughProperty("DebugCheckBox")]
		private CheckBox _DebugCheckBox;

		// Token: 0x0400040E RID: 1038
		[AccessedThroughProperty("FastCheckBox")]
		private CheckBox _FastCheckBox;

		// Token: 0x0400040F RID: 1039
		[AccessedThroughProperty("CRCCheckBox")]
		private CheckBox _CRCCheckBox;

		// Token: 0x04000410 RID: 1040
		[AccessedThroughProperty("DurLabel")]
		private Label _DurLabel;

		// Token: 0x04000411 RID: 1041
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000412 RID: 1042
		private DriveList driveList;

		// Token: 0x04000413 RID: 1043
		private int neededSize;

		// Token: 0x04000414 RID: 1044
		private int availSize;

		// Token: 0x04000415 RID: 1045
		private List<string> CIDList;

		// Token: 0x04000416 RID: 1046
		private bool prevCRCCheck;
	}
}
