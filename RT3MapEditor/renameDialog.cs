using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x0200002B RID: 43
	[DesignerGenerated]
	public partial class renameDialog : Form
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00147844 File Offset: 0x00146844
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0014785C File Offset: 0x0014685C
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00147868 File Offset: 0x00146868
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00147880 File Offset: 0x00146880
		internal virtual TextBox NameTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NameTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NameTextBox = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0014788C File Offset: 0x0014688C
		// (set) Token: 0x0600033F RID: 831 RVA: 0x001478A4 File Offset: 0x001468A4
		internal virtual Button OK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._OK != null;
				if (flag)
				{
					this._OK.Click -= this.OK_Click;
				}
				this._OK = value;
				flag = (this._OK != null);
				if (flag)
				{
					this._OK.Click += this.OK_Click;
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00147910 File Offset: 0x00146910
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00147928 File Offset: 0x00146928
		internal virtual Button Cancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Cancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Cancel != null;
				if (flag)
				{
					this._Cancel.Click -= this.Cancel_Click;
				}
				this._Cancel = value;
				flag = (this._Cancel != null);
				if (flag)
				{
					this._Cancel.Click += this.Cancel_Click;
				}
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00147C28 File Offset: 0x00146C28
		public renameDialog(string oldName)
		{
			ArrayList _ENCList = renameDialog.__ENCList;
			lock (_ENCList)
			{
				renameDialog.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
			this.NameTextBox.Text = oldName;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00147C90 File Offset: 0x00146C90
		private void OK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00147C9C File Offset: 0x00146C9C
		private void Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00147CA8 File Offset: 0x00146CA8
		public string newName()
		{
			return this.NameTextBox.Text;
		}

		// Token: 0x040001F3 RID: 499
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040001F4 RID: 500
		[AccessedThroughProperty("Label")]
		private Label _Label;

		// Token: 0x040001F5 RID: 501
		[AccessedThroughProperty("NameTextBox")]
		private TextBox _NameTextBox;

		// Token: 0x040001F6 RID: 502
		[AccessedThroughProperty("OK")]
		private Button _OK;

		// Token: 0x040001F7 RID: 503
		[AccessedThroughProperty("Cancel")]
		private Button _Cancel;
	}
}
