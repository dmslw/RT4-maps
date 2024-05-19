using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x0200001D RID: 29
	[DesignerGenerated]
	public partial class CameraList : Form
	{
		// Token: 0x0600029D RID: 669 RVA: 0x00144254 File Offset: 0x00143254
		[DebuggerNonUserCode]
		public CameraList()
		{
			base.Load += this.CameraList_Load;
			ArrayList _ENCList = CameraList.__ENCList;
			lock (_ENCList)
			{
				CameraList.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00144524 File Offset: 0x00143524
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0014453C File Offset: 0x0014353C
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

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00144548 File Offset: 0x00143548
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00144560 File Offset: 0x00143560
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x001445CC File Offset: 0x001435CC
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x001445E4 File Offset: 0x001435E4
		internal virtual RichTextBox RichTextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RichTextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._RichTextBox1 != null;
				if (flag)
				{
					this._RichTextBox1.LinkClicked -= this.RichTextBox1_Link_Clicked;
				}
				this._RichTextBox1 = value;
				flag = (this._RichTextBox1 != null);
				if (flag)
				{
					this._RichTextBox1.LinkClicked += this.RichTextBox1_Link_Clicked;
				}
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00144650 File Offset: 0x00143650
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00144664 File Offset: 0x00143664
		private void RichTextBox1_Link_Clicked(object sender, LinkClickedEventArgs e)
		{
			Process.Start(e.LinkText);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00144674 File Offset: 0x00143674
		private void CameraList_Load(object sender, EventArgs e)
		{
			this.RichTextBox1.LoadFile(Path.Combine(MyProject.Forms.FormMain.CurrentWorkingDir, "documentation\\list-" + MySettingsProperty.Settings.UICulture + ".rtf"));
		}

		// Token: 0x0400019B RID: 411
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x0400019D RID: 413
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x0400019E RID: 414
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x0400019F RID: 415
		[AccessedThroughProperty("RichTextBox1")]
		private RichTextBox _RichTextBox1;
	}
}
