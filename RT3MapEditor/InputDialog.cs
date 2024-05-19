using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x02000025 RID: 37
	[DesignerGenerated]
	public partial class InputDialog : Form
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x00145B9C File Offset: 0x00144B9C
		[DebuggerNonUserCode]
		public InputDialog()
		{
			ArrayList _ENCList = InputDialog.__ENCList;
			lock (_ENCList)
			{
				InputDialog.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00146008 File Offset: 0x00145008
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00146020 File Offset: 0x00145020
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

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0014602C File Offset: 0x0014502C
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00146044 File Offset: 0x00145044
		internal virtual Button YES_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._YES_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._YES_Button = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00146050 File Offset: 0x00145050
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00146068 File Offset: 0x00145068
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
				this._Cancel_Button = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00146074 File Offset: 0x00145074
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0014608C File Offset: 0x0014508C
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00146098 File Offset: 0x00145098
		// (set) Token: 0x060002FD RID: 765 RVA: 0x001460B0 File Offset: 0x001450B0
		internal virtual Label warningText
		{
			[DebuggerNonUserCode]
			get
			{
				return this._warningText;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._warningText = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002FE RID: 766 RVA: 0x001460BC File Offset: 0x001450BC
		// (set) Token: 0x060002FF RID: 767 RVA: 0x001460D4 File Offset: 0x001450D4
		internal virtual MaskedTextBox MaskedTextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MaskedTextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._MaskedTextBox1 != null;
				if (flag)
				{
					this._MaskedTextBox1.TextChanged -= this.MaskedTextBox1_TextChanged;
				}
				this._MaskedTextBox1 = value;
				flag = (this._MaskedTextBox1 != null);
				if (flag)
				{
					this._MaskedTextBox1.TextChanged += this.MaskedTextBox1_TextChanged;
				}
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00146140 File Offset: 0x00145140
		public void setValue(string text, string value, string mask)
		{
			this.warningText.Text = text;
			this.MaskedTextBox1.Text = value;
			this.MaskedTextBox1.Mask = mask;
			this.MaskedTextBox1.Text = value;
			this.YES_Button.Enabled = this.MaskedTextBox1.MaskFull;
			this.MaskedTextBox1.Select();
		}

		// Token: 0x06000301 RID: 769 RVA: 0x001461A8 File Offset: 0x001451A8
		private void MaskedTextBox1_TextChanged(object sender, EventArgs e)
		{
			this.YES_Button.Enabled = this.MaskedTextBox1.MaskFull;
		}

		// Token: 0x040001CE RID: 462
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040001D0 RID: 464
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x040001D1 RID: 465
		[AccessedThroughProperty("YES_Button")]
		private Button _YES_Button;

		// Token: 0x040001D2 RID: 466
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x040001D3 RID: 467
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040001D4 RID: 468
		[AccessedThroughProperty("warningText")]
		private Label _warningText;

		// Token: 0x040001D5 RID: 469
		[AccessedThroughProperty("MaskedTextBox1")]
		private MaskedTextBox _MaskedTextBox1;
	}
}
