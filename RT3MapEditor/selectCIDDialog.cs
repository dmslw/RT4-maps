using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x0200002D RID: 45
	[DesignerGenerated]
	public partial class selectCIDDialog : Form
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00148468 File Offset: 0x00147468
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00148480 File Offset: 0x00147480
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

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0014848C File Offset: 0x0014748C
		// (set) Token: 0x06000359 RID: 857 RVA: 0x001484A4 File Offset: 0x001474A4
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

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00148510 File Offset: 0x00147510
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00148528 File Offset: 0x00147528
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

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00148594 File Offset: 0x00147594
		// (set) Token: 0x0600035D RID: 861 RVA: 0x001485AC File Offset: 0x001475AC
		internal virtual ComboBox ComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600035E RID: 862 RVA: 0x001485B8 File Offset: 0x001475B8
		// (set) Token: 0x0600035F RID: 863 RVA: 0x001485D0 File Offset: 0x001475D0
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x001485DC File Offset: 0x001475DC
		public selectCIDDialog(List<string> CIDList, string mapPath, ref bool noCidFound)
		{
			ArrayList _ENCList = selectCIDDialog.__ENCList;
			lock (_ENCList)
			{
				selectCIDDialog.__ENCList.Add(new WeakReference(this));
			}
			this.CIDComboList = new ArrayList();
			this.InitializeComponent();
			noCidFound = true;
			int num = 0;
			checked
			{
				int num2 = CIDList.Count - 1;
				int num3 = num;
				bool flag;
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					flag = (CIDList[num3] != null && CIDList[num3].Length > 0 && MyProject.Computer.FileSystem.DirectoryExists(Path.Combine(Path.Combine(mapPath, "MAPPE"), num3.ToString("d3"))));
					if (flag)
					{
						this.CIDComboList.Add(new comboIntItems(CIDList[num3], num3));
						noCidFound = false;
					}
					num3++;
				}
				flag = !noCidFound;
				if (flag)
				{
					this.ComboBox.DataSource = new BindingSource(this.CIDComboList, null);
					this.ComboBox.DisplayMember = "display";
					this.ComboBox.ValueMember = "value";
				}
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0014870C File Offset: 0x0014770C
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00148720 File Offset: 0x00147720
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00148734 File Offset: 0x00147734
		public int getSelectedCID()
		{
			return Conversions.ToInteger(this.ComboBox.SelectedValue);
		}

		// Token: 0x040001FE RID: 510
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x04000200 RID: 512
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x04000201 RID: 513
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x04000202 RID: 514
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x04000203 RID: 515
		[AccessedThroughProperty("ComboBox")]
		private ComboBox _ComboBox;

		// Token: 0x04000204 RID: 516
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000205 RID: 517
		private ArrayList CIDComboList;
	}
}
