using System;
using System.Diagnostics;
using System.Windows.Forms;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x02000019 RID: 25
	public class magComboBoxInit
	{
		// Token: 0x06000255 RID: 597 RVA: 0x000FD064 File Offset: 0x000FC064
		[DebuggerNonUserCode]
		public magComboBoxInit()
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000FD070 File Offset: 0x000FC070
		public static void init(ComboBox combo)
		{
			combo.DataSource = MyProject.Forms.FormMain.mapMngt.POITypeInfo.POIMagBS;
			combo.ValueMember = "Key";
			combo.DisplayMember = "Value";
			combo.SelectedIndex = -1;
		}
	}
}
