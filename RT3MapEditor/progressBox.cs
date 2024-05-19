using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x0200002A RID: 42
	[DesignerGenerated]
	public partial class progressBox : Form
	{
		// Token: 0x06000333 RID: 819 RVA: 0x00147630 File Offset: 0x00146630
		[DebuggerNonUserCode]
		public progressBox()
		{
			ArrayList _ENCList = progressBox.__ENCList;
			lock (_ENCList)
			{
				progressBox.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000336 RID: 822 RVA: 0x001477D4 File Offset: 0x001467D4
		// (set) Token: 0x06000337 RID: 823 RVA: 0x001477EC File Offset: 0x001467EC
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

		// Token: 0x040001F0 RID: 496
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040001F2 RID: 498
		[AccessedThroughProperty("Label")]
		private Label _Label;
	}
}
