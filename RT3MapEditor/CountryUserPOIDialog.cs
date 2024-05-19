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
	// Token: 0x0200003A RID: 58
	[DesignerGenerated]
	public partial class CountryUserPOIDialog : Form
	{
		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00159244 File Offset: 0x00158244
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x0015925C File Offset: 0x0015825C
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

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00159268 File Offset: 0x00158268
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00159280 File Offset: 0x00158280
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

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x001592EC File Offset: 0x001582EC
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00159304 File Offset: 0x00158304
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00159370 File Offset: 0x00158370
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00159388 File Offset: 0x00158388
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x00159394 File Offset: 0x00158394
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x001593AC File Offset: 0x001583AC
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

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x001593B8 File Offset: 0x001583B8
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x001593D0 File Offset: 0x001583D0
		internal virtual RadioButton ItalyRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ItalyRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ItalyRadioButton != null;
				if (flag)
				{
					this._ItalyRadioButton.CheckedChanged -= this.ItalyRadioButton_CheckedChanged;
				}
				this._ItalyRadioButton = value;
				flag = (this._ItalyRadioButton != null);
				if (flag)
				{
					this._ItalyRadioButton.CheckedChanged += this.ItalyRadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0015943C File Offset: 0x0015843C
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00159454 File Offset: 0x00158454
		internal virtual RadioButton BeneluxRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BeneluxRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._BeneluxRadioButton != null;
				if (flag)
				{
					this._BeneluxRadioButton.CheckedChanged -= this.BeneluxRadioButton_CheckedChanged;
				}
				this._BeneluxRadioButton = value;
				flag = (this._BeneluxRadioButton != null);
				if (flag)
				{
					this._BeneluxRadioButton.CheckedChanged += this.BeneluxRadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x001594C0 File Offset: 0x001584C0
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x001594D8 File Offset: 0x001584D8
		internal virtual RadioButton SPRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SPRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._SPRadioButton != null;
				if (flag)
				{
					this._SPRadioButton.CheckedChanged -= this.SPRadioButton_CheckedChanged;
				}
				this._SPRadioButton = value;
				flag = (this._SPRadioButton != null);
				if (flag)
				{
					this._SPRadioButton.CheckedChanged += this.SPRadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00159544 File Offset: 0x00158544
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x0015955C File Offset: 0x0015855C
		internal virtual RadioButton FranceRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FranceRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._FranceRadioButton != null;
				if (flag)
				{
					this._FranceRadioButton.CheckedChanged -= this.FranceRadioButton_CheckedChanged;
				}
				this._FranceRadioButton = value;
				flag = (this._FranceRadioButton != null);
				if (flag)
				{
					this._FranceRadioButton.CheckedChanged += this.FranceRadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x001595C8 File Offset: 0x001585C8
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x001595E0 File Offset: 0x001585E0
		internal virtual RadioButton EENWRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EENWRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._EENWRadioButton != null;
				if (flag)
				{
					this._EENWRadioButton.CheckedChanged -= this.EENWRadioButton_CheckedChanged;
				}
				this._EENWRadioButton = value;
				flag = (this._EENWRadioButton != null);
				if (flag)
				{
					this._EENWRadioButton.CheckedChanged += this.EENWRadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0015964C File Offset: 0x0015864C
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00159664 File Offset: 0x00158664
		internal virtual RadioButton EENERadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EENERadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._EENERadioButton != null;
				if (flag)
				{
					this._EENERadioButton.CheckedChanged -= this.EENERadioButton_CheckedChanged;
				}
				this._EENERadioButton = value;
				flag = (this._EENERadioButton != null);
				if (flag)
				{
					this._EENERadioButton.CheckedChanged += this.EENERadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x001596D0 File Offset: 0x001586D0
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x001596E8 File Offset: 0x001586E8
		internal virtual RadioButton EESRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EESRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._EESRadioButton != null;
				if (flag)
				{
					this._EESRadioButton.CheckedChanged -= this.EESRadioButton_CheckedChanged;
				}
				this._EESRadioButton = value;
				flag = (this._EESRadioButton != null);
				if (flag)
				{
					this._EESRadioButton.CheckedChanged += this.EESRadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00159754 File Offset: 0x00158754
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x0015976C File Offset: 0x0015876C
		internal virtual RadioButton MERadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MERadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._MERadioButton != null;
				if (flag)
				{
					this._MERadioButton.CheckedChanged -= this.MERadioButton_CheckedChanged;
				}
				this._MERadioButton = value;
				flag = (this._MERadioButton != null);
				if (flag)
				{
					this._MERadioButton.CheckedChanged += this.MERadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x001597D8 File Offset: 0x001587D8
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x001597F0 File Offset: 0x001587F0
		internal virtual RadioButton GermanyRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GermanyRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._GermanyRadioButton != null;
				if (flag)
				{
					this._GermanyRadioButton.CheckedChanged -= this.GermanyRadioButton_CheckedChanged;
				}
				this._GermanyRadioButton = value;
				flag = (this._GermanyRadioButton != null);
				if (flag)
				{
					this._GermanyRadioButton.CheckedChanged += this.GermanyRadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0015985C File Offset: 0x0015885C
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00159874 File Offset: 0x00158874
		internal virtual RadioButton ScanRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ScanRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ScanRadioButton != null;
				if (flag)
				{
					this._ScanRadioButton.CheckedChanged -= this.ScanRadioButton_CheckedChanged;
				}
				this._ScanRadioButton = value;
				flag = (this._ScanRadioButton != null);
				if (flag)
				{
					this._ScanRadioButton.CheckedChanged += this.ScanRadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x001598E0 File Offset: 0x001588E0
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x001598F8 File Offset: 0x001588F8
		internal virtual RadioButton UKRadioButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UKRadioButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._UKRadioButton != null;
				if (flag)
				{
					this._UKRadioButton.CheckedChanged -= this.UKRadioButton_CheckedChanged;
				}
				this._UKRadioButton = value;
				flag = (this._UKRadioButton != null);
				if (flag)
				{
					this._UKRadioButton.CheckedChanged += this.UKRadioButton_CheckedChanged;
				}
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00159964 File Offset: 0x00158964
		public CountryUserPOIDialog()
		{
			base.Load += this.USBMapDialog_Load;
			base.Shown += this.USBMapDialog_Shown;
			ArrayList _ENCList = CountryUserPOIDialog.__ENCList;
			lock (_ENCList)
			{
				CountryUserPOIDialog.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x001599E4 File Offset: 0x001589E4
		private void updateGUI()
		{
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x001599E8 File Offset: 0x001589E8
		private void ItalyRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.CID = "001";
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x001599F8 File Offset: 0x001589F8
		private void FranceRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.CID = "002";
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00159A08 File Offset: 0x00158A08
		private void SPRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.CID = "003";
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00159A18 File Offset: 0x00158A18
		private void BeneluxRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.CID = "004";
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00159A28 File Offset: 0x00158A28
		private void UKRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.CID = "005";
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00159A38 File Offset: 0x00158A38
		private void ScanRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.CID = "006";
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00159A48 File Offset: 0x00158A48
		private void GermanyRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.CID = "012";
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00159A58 File Offset: 0x00158A58
		private void MERadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.CID = "013";
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00159A68 File Offset: 0x00158A68
		private void EESRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.CID = "020";
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00159A78 File Offset: 0x00158A78
		private void EENERadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.CID = "021";
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00159A88 File Offset: 0x00158A88
		private void EENWRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.CID = "022";
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00159A98 File Offset: 0x00158A98
		private void USBMapDialog_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00159A9C File Offset: 0x00158A9C
		private void USBMapDialog_Shown(object sender, EventArgs e)
		{
			this.CID = MySettingsProperty.Settings.alertDIRCID;
			string cid = this.CID;
			bool flag = Operators.CompareString(cid, "001", false) == 0;
			if (flag)
			{
				this.ItalyRadioButton.Select();
			}
			else
			{
				flag = (Operators.CompareString(cid, "002", false) == 0);
				if (flag)
				{
					this.FranceRadioButton.Select();
				}
				else
				{
					flag = (Operators.CompareString(cid, "003", false) == 0);
					if (flag)
					{
						this.SPRadioButton.Select();
					}
					else
					{
						flag = (Operators.CompareString(cid, "004", false) == 0);
						if (flag)
						{
							this.BeneluxRadioButton.Select();
						}
						else
						{
							flag = (Operators.CompareString(cid, "005", false) == 0);
							if (flag)
							{
								this.UKRadioButton.Select();
							}
							else
							{
								flag = (Operators.CompareString(cid, "006", false) == 0);
								if (flag)
								{
									this.ScanRadioButton.Select();
								}
								else
								{
									flag = (Operators.CompareString(cid, "012", false) == 0);
									if (flag)
									{
										this.GermanyRadioButton.Select();
									}
									else
									{
										flag = (Operators.CompareString(cid, "013", false) == 0);
										if (flag)
										{
											this.MERadioButton.Select();
										}
										else
										{
											flag = (Operators.CompareString(cid, "020", false) == 0);
											if (flag)
											{
												this.EESRadioButton.Select();
											}
											else
											{
												flag = (Operators.CompareString(cid, "021", false) == 0);
												if (flag)
												{
													this.EENERadioButton.Select();
												}
												else
												{
													flag = (Operators.CompareString(cid, "022", false) == 0);
													if (flag)
													{
														this.EENWRadioButton.Select();
													}
													else
													{
														this.FranceRadioButton.Select();
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			this.updateGUI();
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00159C64 File Offset: 0x00158C64
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00159C78 File Offset: 0x00158C78
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00159C8C File Offset: 0x00158C8C
		public string getCIDList()
		{
			return this.CID;
		}

		// Token: 0x040003B4 RID: 948
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040003B6 RID: 950
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x040003B7 RID: 951
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x040003B8 RID: 952
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x040003B9 RID: 953
		[AccessedThroughProperty("CIDGroupBox")]
		private GroupBox _CIDGroupBox;

		// Token: 0x040003BA RID: 954
		[AccessedThroughProperty("HelpProvider1")]
		private HelpProvider _HelpProvider1;

		// Token: 0x040003BB RID: 955
		[AccessedThroughProperty("ItalyRadioButton")]
		private RadioButton _ItalyRadioButton;

		// Token: 0x040003BC RID: 956
		[AccessedThroughProperty("BeneluxRadioButton")]
		private RadioButton _BeneluxRadioButton;

		// Token: 0x040003BD RID: 957
		[AccessedThroughProperty("SPRadioButton")]
		private RadioButton _SPRadioButton;

		// Token: 0x040003BE RID: 958
		[AccessedThroughProperty("FranceRadioButton")]
		private RadioButton _FranceRadioButton;

		// Token: 0x040003BF RID: 959
		[AccessedThroughProperty("EENWRadioButton")]
		private RadioButton _EENWRadioButton;

		// Token: 0x040003C0 RID: 960
		[AccessedThroughProperty("EENERadioButton")]
		private RadioButton _EENERadioButton;

		// Token: 0x040003C1 RID: 961
		[AccessedThroughProperty("EESRadioButton")]
		private RadioButton _EESRadioButton;

		// Token: 0x040003C2 RID: 962
		[AccessedThroughProperty("MERadioButton")]
		private RadioButton _MERadioButton;

		// Token: 0x040003C3 RID: 963
		[AccessedThroughProperty("GermanyRadioButton")]
		private RadioButton _GermanyRadioButton;

		// Token: 0x040003C4 RID: 964
		[AccessedThroughProperty("ScanRadioButton")]
		private RadioButton _ScanRadioButton;

		// Token: 0x040003C5 RID: 965
		[AccessedThroughProperty("UKRadioButton")]
		private RadioButton _UKRadioButton;

		// Token: 0x040003C6 RID: 966
		private string CID;
	}
}
