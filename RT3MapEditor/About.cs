using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x0200001B RID: 27
	[DesignerGenerated]
	public sealed partial class About : Form
	{
		// Token: 0x0600025D RID: 605 RVA: 0x00142C24 File Offset: 0x00141C24
		[DebuggerNonUserCode]
		public About()
		{
			base.Load += this.About_Load;
			ArrayList _ENCList = About.__ENCList;
			lock (_ENCList)
			{
				About.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00142CC8 File Offset: 0x00141CC8
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00142CE0 File Offset: 0x00141CE0
		internal TableLayoutPanel TableLayoutPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TableLayoutPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TableLayoutPanel = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00142CEC File Offset: 0x00141CEC
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00142D04 File Offset: 0x00141D04
		internal Label LabelProductName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelProductName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelProductName = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00142D10 File Offset: 0x00141D10
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00142D28 File Offset: 0x00141D28
		internal Label LabelVersion
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelVersion;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelVersion = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00142D34 File Offset: 0x00141D34
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00142D4C File Offset: 0x00141D4C
		internal Label LabelCompanyName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCompanyName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCompanyName = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00142D58 File Offset: 0x00141D58
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00142D70 File Offset: 0x00141D70
		internal Label LabelCopyright
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCopyright;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCopyright = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00143148 File Offset: 0x00142148
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00143160 File Offset: 0x00142160
		internal Label LabelAcknowledge
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelAcknowledge;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelAcknowledge = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0014316C File Offset: 0x0014216C
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00143184 File Offset: 0x00142184
		internal TableLayoutPanel TableLayoutPanel1
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00143190 File Offset: 0x00142190
		// (set) Token: 0x0600026F RID: 623 RVA: 0x001431A8 File Offset: 0x001421A8
		internal Button CameraButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CameraButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._CameraButton != null;
				if (flag)
				{
					this._CameraButton.Click -= this.CameraButton_Click;
				}
				this._CameraButton = value;
				flag = (this._CameraButton != null);
				if (flag)
				{
					this._CameraButton.Click += this.CameraButton_Click;
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00143214 File Offset: 0x00142214
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0014322C File Offset: 0x0014222C
		internal Button OKButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OKButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._OKButton != null;
				if (flag)
				{
					this._OKButton.Click -= this.OKButton_Click;
				}
				this._OKButton = value;
				flag = (this._OKButton != null);
				if (flag)
				{
					this._OKButton.Click += this.OKButton_Click;
				}
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00143298 File Offset: 0x00142298
		private void About_Load(object sender, EventArgs e)
		{
			this.LabelProductName.Text = MyProject.Application.Info.ProductName;
			this.LabelVersion.Text = string.Format("Version {0:G}", MyProject.Application.Info.Version.ToString());
			this.LabelCopyright.Text = MyProject.Application.Info.Copyright;
			this.LabelCompanyName.Text = MyProject.Application.Info.CompanyName;
			this.LabelAcknowledge.Text = Resources.aboutAck;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00143334 File Offset: 0x00142334
		private void OKButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00143340 File Offset: 0x00142340
		private void CameraButton_Click(object sender, EventArgs e)
		{
			MyProject.Forms.CameraList.ShowDialog();
		}

		// Token: 0x0400017D RID: 381
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x0400017E RID: 382
		[AccessedThroughProperty("TableLayoutPanel")]
		private TableLayoutPanel _TableLayoutPanel;

		// Token: 0x0400017F RID: 383
		[AccessedThroughProperty("LabelProductName")]
		private Label _LabelProductName;

		// Token: 0x04000180 RID: 384
		[AccessedThroughProperty("LabelVersion")]
		private Label _LabelVersion;

		// Token: 0x04000181 RID: 385
		[AccessedThroughProperty("LabelCompanyName")]
		private Label _LabelCompanyName;

		// Token: 0x04000182 RID: 386
		[AccessedThroughProperty("LabelCopyright")]
		private Label _LabelCopyright;

		// Token: 0x04000184 RID: 388
		[AccessedThroughProperty("LabelAcknowledge")]
		private Label _LabelAcknowledge;

		// Token: 0x04000185 RID: 389
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x04000186 RID: 390
		[AccessedThroughProperty("CameraButton")]
		private Button _CameraButton;

		// Token: 0x04000187 RID: 391
		[AccessedThroughProperty("OKButton")]
		private Button _OKButton;
	}
}
