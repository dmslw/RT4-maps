using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x0200002C RID: 44
	[DesignerGenerated]
	public partial class ScreenPreview : Form
	{
		// Token: 0x06000348 RID: 840 RVA: 0x00147CD8 File Offset: 0x00146CD8
		[DebuggerNonUserCode]
		public ScreenPreview()
		{
			ArrayList _ENCList = ScreenPreview.__ENCList;
			lock (_ENCList)
			{
				ScreenPreview.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00147FE4 File Offset: 0x00146FE4
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00147FFC File Offset: 0x00146FFC
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00148008 File Offset: 0x00147008
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00148020 File Offset: 0x00147020
		internal virtual Button Close_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Close_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Close_Button != null;
				if (flag)
				{
					this._Close_Button.Click -= this.Cancel_Button_Click;
				}
				this._Close_Button = value;
				flag = (this._Close_Button != null);
				if (flag)
				{
					this._Close_Button.Click += this.Cancel_Button_Click;
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0014808C File Offset: 0x0014708C
		// (set) Token: 0x06000350 RID: 848 RVA: 0x001480A4 File Offset: 0x001470A4
		internal virtual PictureBox PictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox = value;
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x001480B0 File Offset: 0x001470B0
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06000352 RID: 850 RVA: 0x001480C4 File Offset: 0x001470C4
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x040001F9 RID: 505
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040001FB RID: 507
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x040001FC RID: 508
		[AccessedThroughProperty("Close_Button")]
		private Button _Close_Button;

		// Token: 0x040001FD RID: 509
		[AccessedThroughProperty("PictureBox")]
		private PictureBox _PictureBox;
	}
}
