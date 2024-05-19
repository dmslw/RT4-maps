using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x02000022 RID: 34
	[DesignerGenerated]
	public partial class dupListDialog : Form
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00145424 File Offset: 0x00144424
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x0014543C File Offset: 0x0014443C
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00145448 File Offset: 0x00144448
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00145460 File Offset: 0x00144460
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0014546C File Offset: 0x0014446C
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00145484 File Offset: 0x00144484
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00145490 File Offset: 0x00144490
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x001454A8 File Offset: 0x001444A8
		internal virtual Button cancel1Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cancel1Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._cancel1Button != null;
				if (flag)
				{
					this._cancel1Button.Click -= this.cancel1Button_Click;
				}
				this._cancel1Button = value;
				flag = (this._cancel1Button != null);
				if (flag)
				{
					this._cancel1Button.Click += this.cancel1Button_Click;
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00145514 File Offset: 0x00144514
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0014552C File Offset: 0x0014452C
		internal virtual Button bothButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._bothButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._bothButton != null;
				if (flag)
				{
					this._bothButton.Click -= this.bothButton_Click;
				}
				this._bothButton = value;
				flag = (this._bothButton != null);
				if (flag)
				{
					this._bothButton.Click += this.bothButton_Click;
				}
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00145598 File Offset: 0x00144598
		// (set) Token: 0x060002DB RID: 731 RVA: 0x001455B0 File Offset: 0x001445B0
		internal virtual Button replaceButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._replaceButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._replaceButton != null;
				if (flag)
				{
					this._replaceButton.Click -= this.replaceButton_Click;
				}
				this._replaceButton = value;
				flag = (this._replaceButton != null);
				if (flag)
				{
					this._replaceButton.Click += this.replaceButton_Click;
				}
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0014561C File Offset: 0x0014461C
		public dupListDialog()
		{
			base.Closing += this.mclosing;
			ArrayList _ENCList = dupListDialog.__ENCList;
			lock (_ENCList)
			{
				dupListDialog.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00145688 File Offset: 0x00144688
		public dupListDialog.DialResult showError(string errText, string[] strContext)
		{
			bool flag = strContext != null;
			if (flag)
			{
				this.errText.Text = errText + "\r\n" + string.Join(" ", strContext);
			}
			else
			{
				this.errText.Text = errText;
			}
			this.ShowDialog();
			return this.result;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x001456E8 File Offset: 0x001446E8
		public dupListDialog.DialResult showError(string errText)
		{
			this.errText.Text = errText;
			this.ShowDialog();
			return this.result;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00145714 File Offset: 0x00144714
		private void replaceButton_Click(object sender, EventArgs e)
		{
			this.result = dupListDialog.DialResult.replace;
			this.Hide();
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00145728 File Offset: 0x00144728
		private void bothButton_Click(object sender, EventArgs e)
		{
			this.result = dupListDialog.DialResult.both;
			this.Hide();
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0014573C File Offset: 0x0014473C
		private void cancel1Button_Click(object sender, EventArgs e)
		{
			this.result = dupListDialog.DialResult.cancel;
			this.Hide();
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00145750 File Offset: 0x00144750
		private void mclosing(object sender, CancelEventArgs e)
		{
			bool flag = this.DialogResult == DialogResult.Cancel;
			if (flag)
			{
				this.result = dupListDialog.DialResult.replace;
			}
		}

		// Token: 0x040001BC RID: 444
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040001BE RID: 446
		[AccessedThroughProperty("errText")]
		private Label _errText;

		// Token: 0x040001BF RID: 447
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040001C0 RID: 448
		[AccessedThroughProperty("TableLayoutPanel2")]
		private TableLayoutPanel _TableLayoutPanel2;

		// Token: 0x040001C1 RID: 449
		[AccessedThroughProperty("cancel1Button")]
		private Button _cancel1Button;

		// Token: 0x040001C2 RID: 450
		[AccessedThroughProperty("bothButton")]
		private Button _bothButton;

		// Token: 0x040001C3 RID: 451
		[AccessedThroughProperty("replaceButton")]
		private Button _replaceButton;

		// Token: 0x040001C4 RID: 452
		private dupListDialog.DialResult result;

		// Token: 0x02000023 RID: 35
		public enum DialResult
		{
			// Token: 0x040001C6 RID: 454
			replace,
			// Token: 0x040001C7 RID: 455
			both,
			// Token: 0x040001C8 RID: 456
			cancel
		}
	}
}
