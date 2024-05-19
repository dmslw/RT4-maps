using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x0200001C RID: 28
	[DesignerGenerated]
	public partial class AllPOIParamDialog : Form
	{
		// Token: 0x06000276 RID: 630 RVA: 0x00143364 File Offset: 0x00142364
		[DebuggerNonUserCode]
		public AllPOIParamDialog()
		{
			ArrayList _ENCList = AllPOIParamDialog.__ENCList;
			lock (_ENCList)
			{
				AllPOIParamDialog.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00143C98 File Offset: 0x00142C98
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00143CB0 File Offset: 0x00142CB0
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

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00143CBC File Offset: 0x00142CBC
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00143CD4 File Offset: 0x00142CD4
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

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00143D40 File Offset: 0x00142D40
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00143D58 File Offset: 0x00142D58
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00143DC4 File Offset: 0x00142DC4
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00143DDC File Offset: 0x00142DDC
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00143DE8 File Offset: 0x00142DE8
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00143E00 File Offset: 0x00142E00
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00143E0C File Offset: 0x00142E0C
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00143E24 File Offset: 0x00142E24
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

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00143E30 File Offset: 0x00142E30
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00143E48 File Offset: 0x00142E48
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00143E54 File Offset: 0x00142E54
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00143E6C File Offset: 0x00142E6C
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00143E78 File Offset: 0x00142E78
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00143E90 File Offset: 0x00142E90
		internal virtual MaskedTextBox LatMaskedTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LatMaskedTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._LatMaskedTextBox != null;
				if (flag)
				{
					this._LatMaskedTextBox.TextChanged -= this.LatMaskedTextBox_TextChanged;
				}
				this._LatMaskedTextBox = value;
				flag = (this._LatMaskedTextBox != null);
				if (flag)
				{
					this._LatMaskedTextBox.TextChanged += this.LatMaskedTextBox_TextChanged;
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00143EFC File Offset: 0x00142EFC
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00143F14 File Offset: 0x00142F14
		internal virtual MaskedTextBox LonMaskedTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LonMaskedTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._LonMaskedTextBox != null;
				if (flag)
				{
					this._LonMaskedTextBox.TextChanged -= this.LonMaskedTextBox_TextChanged;
				}
				this._LonMaskedTextBox = value;
				flag = (this._LonMaskedTextBox != null);
				if (flag)
				{
					this._LonMaskedTextBox.TextChanged += this.LonMaskedTextBox_TextChanged;
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00143F80 File Offset: 0x00142F80
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00143F98 File Offset: 0x00142F98
		internal virtual MaskedTextBox EWspaMaskedTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EWspaMaskedTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._EWspaMaskedTextBox != null;
				if (flag)
				{
					this._EWspaMaskedTextBox.TextChanged -= this.EWspaMaskedTextBox_TextChanged;
				}
				this._EWspaMaskedTextBox = value;
				flag = (this._EWspaMaskedTextBox != null);
				if (flag)
				{
					this._EWspaMaskedTextBox.TextChanged += this.EWspaMaskedTextBox_TextChanged;
				}
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00144004 File Offset: 0x00143004
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0014401C File Offset: 0x0014301C
		internal virtual MaskedTextBox NSspaMaskedTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NSspaMaskedTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._NSspaMaskedTextBox != null;
				if (flag)
				{
					this._NSspaMaskedTextBox.TextChanged -= this.NSspaMaskedTextBox_TextChanged;
				}
				this._NSspaMaskedTextBox = value;
				flag = (this._NSspaMaskedTextBox != null);
				if (flag)
				{
					this._NSspaMaskedTextBox.TextChanged += this.NSspaMaskedTextBox_TextChanged;
				}
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00144088 File Offset: 0x00143088
		// (set) Token: 0x06000292 RID: 658 RVA: 0x001440A0 File Offset: 0x001430A0
		internal virtual NumericUpDown POIplNumericUpDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._POIplNumericUpDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._POIplNumericUpDown = value;
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x001440AC File Offset: 0x001430AC
		public void initDefaultValues()
		{
			this.LatMaskedTextBox.Text = "48.48580";
			this.LonMaskedTextBox.Text = "7.67470";
			this.EWspaMaskedTextBox.Text = "100";
			this.NSspaMaskedTextBox.Text = "125";
			this.POIplNumericUpDown.Value = 15m;
			this.checkGUIFields();
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0014411C File Offset: 0x0014311C
		private bool checkGUIFields()
		{
			bool flag;
			if (double.TryParse(this.LatMaskedTextBox.Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, Common.cultENUS, out this.lat) && double.TryParse(this.LonMaskedTextBox.Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, Common.cultENUS, out this.lon))
			{
				if (int.TryParse(this.EWspaMaskedTextBox.Text, out this.EWSpacing))
				{
					if (int.TryParse(this.NSspaMaskedTextBox.Text, out this.NSSpacing))
					{
						flag = false;
						goto IL_7D;
					}
				}
			}
			flag = true;
			IL_7D:
			bool flag2 = flag;
			if (flag2)
			{
				this.OK_Button.Enabled = false;
			}
			else
			{
				this.OK_Button.Enabled = true;
			}
			bool result;
			return result;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x001441CC File Offset: 0x001431CC
		public new DialogResult ShowDialog()
		{
			this.checkGUIFields();
			return base.ShowDialog();
		}

		// Token: 0x06000296 RID: 662 RVA: 0x001441EC File Offset: 0x001431EC
		private void LatMaskedTextBox_TextChanged(object sender, EventArgs e)
		{
			this.checkGUIFields();
		}

		// Token: 0x06000297 RID: 663 RVA: 0x001441F8 File Offset: 0x001431F8
		private void LonMaskedTextBox_TextChanged(object sender, EventArgs e)
		{
			this.checkGUIFields();
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00144204 File Offset: 0x00143204
		private void EWspaMaskedTextBox_TextChanged(object sender, EventArgs e)
		{
			this.checkGUIFields();
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00144210 File Offset: 0x00143210
		private void NSspaMaskedTextBox_TextChanged(object sender, EventArgs e)
		{
			this.checkGUIFields();
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0014421C File Offset: 0x0014321C
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00144230 File Offset: 0x00143230
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x04000188 RID: 392
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x0400018A RID: 394
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x0400018B RID: 395
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x0400018C RID: 396
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x0400018D RID: 397
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400018E RID: 398
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400018F RID: 399
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000190 RID: 400
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000191 RID: 401
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000192 RID: 402
		[AccessedThroughProperty("LatMaskedTextBox")]
		private MaskedTextBox _LatMaskedTextBox;

		// Token: 0x04000193 RID: 403
		[AccessedThroughProperty("LonMaskedTextBox")]
		private MaskedTextBox _LonMaskedTextBox;

		// Token: 0x04000194 RID: 404
		[AccessedThroughProperty("EWspaMaskedTextBox")]
		private MaskedTextBox _EWspaMaskedTextBox;

		// Token: 0x04000195 RID: 405
		[AccessedThroughProperty("NSspaMaskedTextBox")]
		private MaskedTextBox _NSspaMaskedTextBox;

		// Token: 0x04000196 RID: 406
		[AccessedThroughProperty("POIplNumericUpDown")]
		private NumericUpDown _POIplNumericUpDown;

		// Token: 0x04000197 RID: 407
		public double lat;

		// Token: 0x04000198 RID: 408
		public double lon;

		// Token: 0x04000199 RID: 409
		public int EWSpacing;

		// Token: 0x0400019A RID: 410
		public int NSSpacing;
	}
}
