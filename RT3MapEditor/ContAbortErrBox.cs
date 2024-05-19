using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x0200001F RID: 31
	[DesignerGenerated]
	public partial class ContAbortErrBox : Form
	{
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00144C60 File Offset: 0x00143C60
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00144C78 File Offset: 0x00143C78
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TableLayoutPanel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TableLayoutPanel2 = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00144C84 File Offset: 0x00143C84
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00144C9C File Offset: 0x00143C9C
		internal virtual Button IgnoreAllButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IgnoreAllButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._IgnoreAllButton != null;
				if (flag)
				{
					this._IgnoreAllButton.Click -= this.IgnoreAll_Button_Click;
				}
				this._IgnoreAllButton = value;
				flag = (this._IgnoreAllButton != null);
				if (flag)
				{
					this._IgnoreAllButton.Click += this.IgnoreAll_Button_Click;
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00144D08 File Offset: 0x00143D08
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00144D20 File Offset: 0x00143D20
		internal virtual Button IgnoreButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IgnoreButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._IgnoreButton != null;
				if (flag)
				{
					this._IgnoreButton.Click -= this.Ignore_Button_Click;
				}
				this._IgnoreButton = value;
				flag = (this._IgnoreButton != null);
				if (flag)
				{
					this._IgnoreButton.Click += this.Ignore_Button_Click;
				}
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00144D8C File Offset: 0x00143D8C
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00144DA4 File Offset: 0x00143DA4
		internal virtual Label errText
		{
			[DebuggerNonUserCode]
			get
			{
				return this._errText;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._errText = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00144DB0 File Offset: 0x00143DB0
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x00144DC8 File Offset: 0x00143DC8
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00144DD4 File Offset: 0x00143DD4
		// (set) Token: 0x060002BA RID: 698 RVA: 0x00144DEC File Offset: 0x00143DEC
		internal virtual Button AbortButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AbortButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._AbortButton != null;
				if (flag)
				{
					this._AbortButton.Click -= this.Abort_Button_Click;
				}
				this._AbortButton = value;
				flag = (this._AbortButton != null);
				if (flag)
				{
					this._AbortButton.Click += this.Abort_Button_Click;
				}
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00144E58 File Offset: 0x00143E58
		public ContAbortErrBox()
		{
			ArrayList _ENCList = ContAbortErrBox.__ENCList;
			lock (_ENCList)
			{
				ContAbortErrBox.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
			this.ignoreErrors = false;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00144EB8 File Offset: 0x00143EB8
		public ContAbortErrBox(bool ignoreErrors)
		{
			ArrayList _ENCList = ContAbortErrBox.__ENCList;
			lock (_ENCList)
			{
				ContAbortErrBox.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
			this.ignoreErrors = ignoreErrors;
			this.errText = null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00144F20 File Offset: 0x00143F20
		public void showError(string errText, bool showIgnore, bool showIgnoreAll, bool showAbort)
		{
			MyProject.Application.Log.WriteEntry(errText);
			this.errText.Text = errText;
			bool flag = !this.ignoreErrors;
			if (flag)
			{
				this.IgnoreButton.Enabled = showIgnore;
				this.IgnoreAllButton.Enabled = showIgnoreAll;
				this.AbortButton.Enabled = showAbort;
				this.ShowDialog();
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00144F8C File Offset: 0x00143F8C
		private void IgnoreAll_Button_Click(object sender, EventArgs e)
		{
			this.ignoreErrors = true;
			this.Hide();
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00144FA0 File Offset: 0x00143FA0
		private void Abort_Button_Click(object sender, EventArgs e)
		{
			this.ignoreErrors = false;
			this.Hide();
			throw new SilentGUIException();
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00144FB8 File Offset: 0x00143FB8
		private void Ignore_Button_Click(object sender, EventArgs e)
		{
			this.ignoreErrors = false;
			this.Hide();
		}

		// Token: 0x040001A7 RID: 423
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040001A9 RID: 425
		[AccessedThroughProperty("TableLayoutPanel2")]
		private TableLayoutPanel _TableLayoutPanel2;

		// Token: 0x040001AA RID: 426
		[AccessedThroughProperty("IgnoreAllButton")]
		private Button _IgnoreAllButton;

		// Token: 0x040001AB RID: 427
		[AccessedThroughProperty("IgnoreButton")]
		private Button _IgnoreButton;

		// Token: 0x040001AC RID: 428
		[AccessedThroughProperty("errText")]
		private Label _errText;

		// Token: 0x040001AD RID: 429
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040001AE RID: 430
		[AccessedThroughProperty("AbortButton")]
		private Button _AbortButton;

		// Token: 0x040001AF RID: 431
		private bool ignoreErrors;
	}
}
