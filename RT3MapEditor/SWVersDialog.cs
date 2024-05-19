using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x0200002F RID: 47
	[DesignerGenerated]
	public partial class SWVersDialog : Form
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0014909C File Offset: 0x0014809C
		// (set) Token: 0x0600037F RID: 895 RVA: 0x001490B4 File Offset: 0x001480B4
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000380 RID: 896 RVA: 0x001490C0 File Offset: 0x001480C0
		// (set) Token: 0x06000381 RID: 897 RVA: 0x001490D8 File Offset: 0x001480D8
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

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00149144 File Offset: 0x00148144
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0014915C File Offset: 0x0014815C
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

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00149168 File Offset: 0x00148168
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00149180 File Offset: 0x00148180
		internal virtual ComboBox SWVersionComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SWVersionComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SWVersionComboBox = value;
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x001491B8 File Offset: 0x001481B8
		public SWVersDialog()
		{
			ArrayList _ENCList = SWVersDialog.__ENCList;
			lock (_ENCList)
			{
				SWVersDialog.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
			bool flag = SWVersDialog.RT3SWVerList.Count == 0;
			if (flag)
			{
				SWVersDialog.RT3SWVerList.Add(new comboRTxVersionsItems("5.x/6.x", Common.RTxVersions.version56x));
				SWVersDialog.RT4SWVerList.Add(new comboRTxVersionsItems("7.02", Common.RTxVersions.version702));
				SWVersDialog.RT4SWVerList.Add(new comboRTxVersionsItems("7.10", Common.RTxVersions.version710));
				SWVersDialog.RT4SWVerList.Add(new comboRTxVersionsItems("7.11", Common.RTxVersions.version711));
				SWVersDialog.RT4SWVerList.Add(new comboRTxVersionsItems("8.11", Common.RTxVersions.version81));
				SWVersDialog.RT5SWVerList.Add(new comboRTxVersionsItems("8.0", Common.RTxVersions.version80));
				SWVersDialog.RT5SWVerList.Add(new comboRTxVersionsItems("8.10/8.11", Common.RTxVersions.version81));
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x001492C0 File Offset: 0x001482C0
		public DialogResult ShowDialog(Common.RTxTypes RTxType)
		{
			SWVersDialog.setRTxVersionCombo(this.SWVersionComboBox, RTxType);
			return base.ShowDialog();
		}

		// Token: 0x06000389 RID: 905 RVA: 0x001492E8 File Offset: 0x001482E8
		public Common.RTxVersions getSelectedSWVersion()
		{
			return (Common.RTxVersions)Conversions.ToInteger(this.SWVersionComboBox.SelectedValue);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0014930C File Offset: 0x0014830C
		public static void setRTxVersionCombo(ComboBox combo, Common.RTxTypes RTxType)
		{
			switch (RTxType)
			{
			case Common.RTxTypes.typeRT3:
				combo.DataSource = new BindingSource(SWVersDialog.RT3SWVerList, null);
				break;
			case Common.RTxTypes.typeRT4:
				combo.DataSource = new BindingSource(SWVersDialog.RT4SWVerList, null);
				break;
			case Common.RTxTypes.typeRT5HR:
				combo.DataSource = new BindingSource(SWVersDialog.RT5SWVerList, null);
				break;
			case Common.RTxTypes.typeRT5LR:
				combo.DataSource = new BindingSource(SWVersDialog.RT5SWVerList, null);
				break;
			}
			combo.DisplayMember = "display";
			combo.ValueMember = "value";
		}

		// Token: 0x0600038B RID: 907 RVA: 0x001493A4 File Offset: 0x001483A4
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x0600038C RID: 908 RVA: 0x001493B8 File Offset: 0x001483B8
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x04000210 RID: 528
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x04000212 RID: 530
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x04000213 RID: 531
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x04000214 RID: 532
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000215 RID: 533
		[AccessedThroughProperty("SWVersionComboBox")]
		private ComboBox _SWVersionComboBox;

		// Token: 0x04000216 RID: 534
		private static ArrayList RT3SWVerList = new ArrayList();

		// Token: 0x04000217 RID: 535
		private static ArrayList RT4SWVerList = new ArrayList();

		// Token: 0x04000218 RID: 536
		private static ArrayList RT5SWVerList = new ArrayList();
	}
}
