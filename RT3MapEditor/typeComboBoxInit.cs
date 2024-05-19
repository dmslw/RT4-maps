using System;
using System.Diagnostics;
using System.Windows.Forms;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x0200001A RID: 26
	public class typeComboBoxInit
	{
		// Token: 0x06000257 RID: 599 RVA: 0x000FD0C0 File Offset: 0x000FC0C0
		[DebuggerNonUserCode]
		public typeComboBoxInit()
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000FD0CC File Offset: 0x000FC0CC
		public static void init(ComboBox combo)
		{
			combo.DataSource = MyProject.Forms.FormMain.mapMngt.POITypeInfo.POITypeNameBS;
			combo.ValueMember = "Value";
			combo.DisplayMember = "Key";
			combo.SelectedIndex = -1;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000FD11C File Offset: 0x000FC11C
		public static void initWoNP(ComboBox combo)
		{
			combo.DataSource = MyProject.Forms.FormMain.mapMngt.POITypeInfo.POITypeNameWoNPBS;
			combo.ValueMember = "Value";
			combo.DisplayMember = "Key";
			combo.SelectedIndex = -1;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000FD16C File Offset: 0x000FC16C
		public static void initNPOnly(ComboBox combo)
		{
			combo.DataSource = MyProject.Forms.FormMain.mapMngt.POITypeInfo.POITypeNameNPOnlyBS;
			combo.ValueMember = "Value";
			combo.DisplayMember = "Key";
			combo.SelectedIndex = -1;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000FD1BC File Offset: 0x000FC1BC
		public static void initAlert(ComboBox combo)
		{
			combo.DataSource = MyProject.Forms.FormMain.mapMngt.POITypeInfo.POITypeNameAlert;
			combo.ValueMember = "Value";
			combo.DisplayMember = "Key";
			combo.SelectedIndex = -1;
		}
	}
}
