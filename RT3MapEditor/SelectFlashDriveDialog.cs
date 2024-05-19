using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x0200002E RID: 46
	[DesignerGenerated]
	public partial class SelectFlashDriveDialog : Form
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00148A24 File Offset: 0x00147A24
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00148A3C File Offset: 0x00147A3C
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00148A48 File Offset: 0x00147A48
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00148A60 File Offset: 0x00147A60
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

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00148ACC File Offset: 0x00147ACC
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00148AE4 File Offset: 0x00147AE4
		internal virtual Label Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00148AF0 File Offset: 0x00147AF0
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00148B08 File Offset: 0x00147B08
		internal virtual ListView DriveListView
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DriveListView;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DriveListView = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00148B14 File Offset: 0x00147B14
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00148B2C File Offset: 0x00147B2C
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00148B98 File Offset: 0x00147B98
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00148BB0 File Offset: 0x00147BB0
		internal virtual Button Refresh_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Refresh_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Refresh_Button != null;
				if (flag)
				{
					this._Refresh_Button.Click -= this.Refresh_Button_Click;
				}
				this._Refresh_Button = value;
				flag = (this._Refresh_Button != null);
				if (flag)
				{
					this._Refresh_Button.Click += this.Refresh_Button_Click;
				}
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00148C1C File Offset: 0x00147C1C
		public SelectFlashDriveDialog(long sizeNeeded)
		{
			base.Load += this.SelectDriveDialog_Load;
			base.Shown += this.SelectDriveDialog_Shown;
			ArrayList _ENCList = SelectFlashDriveDialog.__ENCList;
			lock (_ENCList)
			{
				SelectFlashDriveDialog.__ENCList.Add(new WeakReference(this));
			}
			this.sizeNeeded = 0L;
			this.InitializeComponent();
			this.sizeNeeded = sizeNeeded;
			this.driveList = new DriveList(this.DriveListView, sizeNeeded, new DriveList.driveChanged(this.updateGUI));
			this.Label.Text = Resources.driveSelectLabel;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00148CDC File Offset: 0x00147CDC
		private void updateGUI()
		{
			this.OK_Button.Enabled = (this.driveList.getSelectedItem() != -1);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00148D00 File Offset: 0x00147D00
		private void SelectDriveDialog_Load(object sender, EventArgs e)
		{
			this.driveList.buildDriveList();
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00148D10 File Offset: 0x00147D10
		private void SelectDriveDialog_Shown(object sender, EventArgs e)
		{
			this.driveList.defaultSelect();
			this.updateGUI();
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00148D28 File Offset: 0x00147D28
		public string getDriveToUse()
		{
			return this.driveList.getDriveToUse();
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00148D48 File Offset: 0x00147D48
		public int getDriveSize()
		{
			return this.driveList.getDriveSize();
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00148D68 File Offset: 0x00147D68
		private void Refresh_Button_Click(object sender, EventArgs e)
		{
			this.driveList.buildDriveList();
			this.driveList.defaultSelect();
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00148D84 File Offset: 0x00147D84
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00148D98 File Offset: 0x00147D98
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x04000206 RID: 518
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x04000208 RID: 520
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x04000209 RID: 521
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x0400020A RID: 522
		[AccessedThroughProperty("Label")]
		private Label _Label;

		// Token: 0x0400020B RID: 523
		[AccessedThroughProperty("DriveListView")]
		private ListView _DriveListView;

		// Token: 0x0400020C RID: 524
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x0400020D RID: 525
		[AccessedThroughProperty("Refresh_Button")]
		private Button _Refresh_Button;

		// Token: 0x0400020E RID: 526
		private DriveList driveList;

		// Token: 0x0400020F RID: 527
		private long sizeNeeded;
	}
}
