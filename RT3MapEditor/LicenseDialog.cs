using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x02000026 RID: 38
	[DesignerGenerated]
	public partial class LicenseDialog : Form
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00146540 File Offset: 0x00145540
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00146558 File Offset: 0x00145558
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

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00146564 File Offset: 0x00145564
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0014657C File Offset: 0x0014557C
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000309 RID: 777 RVA: 0x001465E8 File Offset: 0x001455E8
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00146600 File Offset: 0x00145600
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

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0014666C File Offset: 0x0014566C
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00146684 File Offset: 0x00145684
		internal virtual RichTextBox LicenseRichTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LicenseRichTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LicenseRichTextBox = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00146690 File Offset: 0x00145690
		// (set) Token: 0x0600030E RID: 782 RVA: 0x001466A8 File Offset: 0x001456A8
		internal virtual Label LicenseLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LicenseLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LicenseLabel = value;
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x001466B4 File Offset: 0x001456B4
		public LicenseDialog(string FileName)
		{
			ArrayList _ENCList = LicenseDialog.__ENCList;
			lock (_ENCList)
			{
				LicenseDialog.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
			this.LicenseRichTextBox.LoadFile(Path.Combine(Environment.CurrentDirectory, FileName));
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00146724 File Offset: 0x00145724
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00146738 File Offset: 0x00145738
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x040001D6 RID: 470
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040001D8 RID: 472
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x040001D9 RID: 473
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x040001DA RID: 474
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x040001DB RID: 475
		[AccessedThroughProperty("LicenseRichTextBox")]
		private RichTextBox _LicenseRichTextBox;

		// Token: 0x040001DC RID: 476
		[AccessedThroughProperty("LicenseLabel")]
		private Label _LicenseLabel;
	}
}
