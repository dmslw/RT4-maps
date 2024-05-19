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
	// Token: 0x02000027 RID: 39
	[DesignerGenerated]
	public partial class NonFatalErrorBox : Form
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00146FA8 File Offset: 0x00145FA8
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00146FC0 File Offset: 0x00145FC0
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00146FCC File Offset: 0x00145FCC
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00146FE4 File Offset: 0x00145FE4
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00146FF0 File Offset: 0x00145FF0
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00147008 File Offset: 0x00146008
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00147014 File Offset: 0x00146014
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0014702C File Offset: 0x0014602C
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00147098 File Offset: 0x00146098
		// (set) Token: 0x0600031E RID: 798 RVA: 0x001470B0 File Offset: 0x001460B0
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
					this._IgnoreAllButton.Click -= this.OK_Button_Click;
				}
				this._IgnoreAllButton = value;
				flag = (this._IgnoreAllButton != null);
				if (flag)
				{
					this._IgnoreAllButton.Click += this.OK_Button_Click;
				}
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0014711C File Offset: 0x0014611C
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00147134 File Offset: 0x00146134
		internal virtual Button AbortAllButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AbortAllButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._AbortAllButton != null;
				if (flag)
				{
					this._AbortAllButton.Click -= this.ButtonAbortAll_Click;
				}
				this._AbortAllButton = value;
				flag = (this._AbortAllButton != null);
				if (flag)
				{
					this._AbortAllButton.Click += this.ButtonAbortAll_Click;
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000321 RID: 801 RVA: 0x001471A0 File Offset: 0x001461A0
		// (set) Token: 0x06000322 RID: 802 RVA: 0x001471B8 File Offset: 0x001461B8
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
					this._AbortButton.Click -= this.Cancel_Button_Click;
				}
				this._AbortButton = value;
				flag = (this._AbortButton != null);
				if (flag)
				{
					this._AbortButton.Click += this.Cancel_Button_Click;
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00147224 File Offset: 0x00146224
		// (set) Token: 0x06000324 RID: 804 RVA: 0x0014723C File Offset: 0x0014623C
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

		// Token: 0x06000325 RID: 805 RVA: 0x00147248 File Offset: 0x00146248
		public NonFatalErrorBox()
		{
			base.Closing += this.mclosing;
			ArrayList _ENCList = NonFatalErrorBox.__ENCList;
			lock (_ENCList)
			{
				NonFatalErrorBox.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
			this.ignoreErrors = false;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x001472BC File Offset: 0x001462BC
		public NonFatalErrorBox.DialResult showError(string errText, string[] strContext, bool showIgnore, bool showIgnoreAll, bool showAbort, bool showAbortAll)
		{
			bool flag = MySettingsProperty.Settings.importLogError;
			bool flag2;
			if (flag)
			{
				flag2 = (strContext != null);
				if (flag2)
				{
					MyProject.Application.Log.WriteEntry(errText + "\r\n" + string.Join(" ", strContext));
				}
				else
				{
					MyProject.Application.Log.WriteEntry(errText);
				}
			}
			flag2 = !this.ignoreErrors;
			if (flag2)
			{
				flag = (strContext != null);
				if (flag)
				{
					this.errText.Text = errText + "\r\n" + string.Join(" ", strContext);
				}
				else
				{
					this.errText.Text = errText;
				}
				this.IgnoreButton.Enabled = showIgnore;
				this.IgnoreAllButton.Enabled = showIgnoreAll;
				this.AbortButton.Enabled = showAbort;
				this.AbortAllButton.Enabled = showAbortAll;
				this.ShowDialog();
			}
			return this.result;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x001473B4 File Offset: 0x001463B4
		public NonFatalErrorBox.DialResult showError(string errText, string strContext, bool showIgnore, bool showIgnoreAll, bool showAbort, bool showAbortAll)
		{
			bool flag = MySettingsProperty.Settings.importLogError;
			bool flag2;
			if (flag)
			{
				flag2 = (strContext != null);
				if (flag2)
				{
					MyProject.Application.Log.WriteEntry(errText + "\r\n" + strContext);
				}
				else
				{
					MyProject.Application.Log.WriteEntry(errText);
				}
			}
			flag2 = !this.ignoreErrors;
			if (flag2)
			{
				flag = (strContext != null);
				if (flag)
				{
					this.errText.Text = errText + "\r\n" + strContext;
				}
				else
				{
					this.errText.Text = errText;
				}
				this.IgnoreButton.Enabled = showIgnore;
				this.IgnoreAllButton.Enabled = showIgnoreAll;
				this.AbortButton.Enabled = showAbort;
				this.AbortAllButton.Enabled = showAbortAll;
				this.ShowDialog();
			}
			return this.result;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00147498 File Offset: 0x00146498
		public NonFatalErrorBox.DialResult showError(string errText, bool showIgnore, bool showIgnoreAll, bool showAbort, bool showAbortAll)
		{
			bool flag = MySettingsProperty.Settings.importLogError;
			if (flag)
			{
				MyProject.Application.Log.WriteEntry(errText);
			}
			flag = !this.ignoreErrors;
			if (flag)
			{
				this.errText.Text = errText;
				this.IgnoreButton.Enabled = showIgnore;
				this.IgnoreAllButton.Enabled = showIgnoreAll;
				this.AbortButton.Enabled = showAbort;
				this.AbortAllButton.Enabled = showAbortAll;
				this.ShowDialog();
			}
			return this.result;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00147528 File Offset: 0x00146528
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.result = NonFatalErrorBox.DialResult.IgnoreAll;
			this.ignoreErrors = true;
			this.Hide();
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00147544 File Offset: 0x00146544
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.result = NonFatalErrorBox.DialResult.Abort;
			this.ignoreErrors = false;
			this.Hide();
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00147560 File Offset: 0x00146560
		private void Ignore_Button_Click(object sender, EventArgs e)
		{
			this.result = NonFatalErrorBox.DialResult.Ignore;
			this.ignoreErrors = false;
			this.Hide();
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0014757C File Offset: 0x0014657C
		private void ButtonAbortAll_Click(object sender, EventArgs e)
		{
			this.result = NonFatalErrorBox.DialResult.AbortAll;
			this.ignoreErrors = false;
			this.Hide();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00147598 File Offset: 0x00146598
		private void mclosing(object sender, CancelEventArgs e)
		{
			bool flag = this.DialogResult == DialogResult.Cancel;
			if (flag)
			{
				bool enabled = this.IgnoreButton.Enabled;
				if (enabled)
				{
					this.result = NonFatalErrorBox.DialResult.Ignore;
				}
				else
				{
					enabled = this.IgnoreAllButton.Enabled;
					if (enabled)
					{
						this.result = NonFatalErrorBox.DialResult.IgnoreAll;
					}
					else
					{
						enabled = this.AbortButton.Enabled;
						if (enabled)
						{
							this.result = NonFatalErrorBox.DialResult.Abort;
						}
						else
						{
							enabled = this.AbortAllButton.Enabled;
							if (enabled)
							{
								this.result = NonFatalErrorBox.DialResult.AbortAll;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00147614 File Offset: 0x00146614
		public void resetIgnoreErrors()
		{
			this.ignoreErrors = false;
		}

		// Token: 0x040001DD RID: 477
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040001DF RID: 479
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040001E0 RID: 480
		[AccessedThroughProperty("errText")]
		private Label _errText;

		// Token: 0x040001E1 RID: 481
		[AccessedThroughProperty("HelpProvider1")]
		private HelpProvider _HelpProvider1;

		// Token: 0x040001E2 RID: 482
		[AccessedThroughProperty("IgnoreButton")]
		private Button _IgnoreButton;

		// Token: 0x040001E3 RID: 483
		[AccessedThroughProperty("IgnoreAllButton")]
		private Button _IgnoreAllButton;

		// Token: 0x040001E4 RID: 484
		[AccessedThroughProperty("AbortAllButton")]
		private Button _AbortAllButton;

		// Token: 0x040001E5 RID: 485
		[AccessedThroughProperty("AbortButton")]
		private Button _AbortButton;

		// Token: 0x040001E6 RID: 486
		[AccessedThroughProperty("TableLayoutPanel2")]
		private TableLayoutPanel _TableLayoutPanel2;

		// Token: 0x040001E7 RID: 487
		private NonFatalErrorBox.DialResult result;

		// Token: 0x040001E8 RID: 488
		private bool ignoreErrors;

		// Token: 0x02000028 RID: 40
		public enum DialResult
		{
			// Token: 0x040001EA RID: 490
			Ignore,
			// Token: 0x040001EB RID: 491
			IgnoreAll,
			// Token: 0x040001EC RID: 492
			Abort,
			// Token: 0x040001ED RID: 493
			AbortAll,
			// Token: 0x040001EE RID: 494
			Close
		}
	}
}
