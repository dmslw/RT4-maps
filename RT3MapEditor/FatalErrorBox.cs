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
	// Token: 0x02000024 RID: 36
	[DesignerGenerated]
	public partial class FatalErrorBox : Form
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x00145784 File Offset: 0x00144784
		[DebuggerNonUserCode]
		public FatalErrorBox()
		{
			base.Closing += this.mclosing;
			ArrayList _ENCList = FatalErrorBox.__ENCList;
			lock (_ENCList)
			{
				FatalErrorBox.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00145A90 File Offset: 0x00144A90
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00145AA8 File Offset: 0x00144AA8
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00145AB4 File Offset: 0x00144AB4
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00145ACC File Offset: 0x00144ACC
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

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00145AD8 File Offset: 0x00144AD8
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00145AF0 File Offset: 0x00144AF0
		internal virtual Button QuitButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._QuitButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._QuitButton != null;
				if (flag)
				{
					this._QuitButton.Click -= this.QuitButton_Click;
				}
				this._QuitButton = value;
				flag = (this._QuitButton != null);
				if (flag)
				{
					this._QuitButton.Click += this.QuitButton_Click;
				}
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00145B5C File Offset: 0x00144B5C
		public void showError(string errText)
		{
			this.errText.Text = errText;
			this.ShowDialog();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00145B74 File Offset: 0x00144B74
		private void QuitButton_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00145B80 File Offset: 0x00144B80
		private void mclosing(object sender, CancelEventArgs e)
		{
			Application.ExitThread();
		}

		// Token: 0x040001C9 RID: 457
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040001CB RID: 459
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040001CC RID: 460
		[AccessedThroughProperty("errText")]
		private Label _errText;

		// Token: 0x040001CD RID: 461
		[AccessedThroughProperty("QuitButton")]
		private Button _QuitButton;
	}
}
