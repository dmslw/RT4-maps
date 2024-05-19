using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x0200003C RID: 60
	[DesignerGenerated]
	public partial class DupDialog : Form
	{
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0015B148 File Offset: 0x0015A148
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x0015B160 File Offset: 0x0015A160
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

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0015B16C File Offset: 0x0015A16C
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x0015B184 File Offset: 0x0015A184
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
					this._Close_Button.Click -= this.Close_Button_Click;
				}
				this._Close_Button = value;
				flag = (this._Close_Button != null);
				if (flag)
				{
					this._Close_Button.Click += this.Close_Button_Click;
				}
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0015B1F0 File Offset: 0x0015A1F0
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x0015B208 File Offset: 0x0015A208
		internal virtual Label ListNbLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ListNbLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ListNbLabel = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0015B214 File Offset: 0x0015A214
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x0015B22C File Offset: 0x0015A22C
		internal virtual ListBox choiceLists_ListBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._choiceLists_ListBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._choiceLists_ListBox != null;
				if (flag)
				{
					this._choiceLists_ListBox.SelectedIndexChanged -= this.choiceLists_ListBoxSelectionChange;
				}
				this._choiceLists_ListBox = value;
				flag = (this._choiceLists_ListBox != null);
				if (flag)
				{
					this._choiceLists_ListBox.SelectedIndexChanged += this.choiceLists_ListBoxSelectionChange;
				}
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0015B298 File Offset: 0x0015A298
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x0015B2B0 File Offset: 0x0015A2B0
		internal virtual NumericUpDown Dist_NumericUpDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Dist_NumericUpDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Dist_NumericUpDown != null;
				if (flag)
				{
					this._Dist_NumericUpDown.ValueChanged -= this.Dist_NumericUpDown_ValueChanged;
				}
				this._Dist_NumericUpDown = value;
				flag = (this._Dist_NumericUpDown != null);
				if (flag)
				{
					this._Dist_NumericUpDown.ValueChanged += this.Dist_NumericUpDown_ValueChanged;
				}
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0015B31C File Offset: 0x0015A31C
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x0015B334 File Offset: 0x0015A334
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0015B340 File Offset: 0x0015A340
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x0015B358 File Offset: 0x0015A358
		internal virtual Button Find_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Find_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Find_Button != null;
				if (flag)
				{
					this._Find_Button.Click -= this.Find_Button_Click;
				}
				this._Find_Button = value;
				flag = (this._Find_Button != null);
				if (flag)
				{
					this._Find_Button.Click += this.Find_Button_Click;
				}
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0015B3C4 File Offset: 0x0015A3C4
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x0015B3DC File Offset: 0x0015A3DC
		internal virtual Button Remove_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Remove_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Remove_Button != null;
				if (flag)
				{
					this._Remove_Button.Click -= this.Remove_Button_Click;
				}
				this._Remove_Button = value;
				flag = (this._Remove_Button != null);
				if (flag)
				{
					this._Remove_Button.Click += this.Remove_Button_Click;
				}
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0015B448 File Offset: 0x0015A448
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x0015B460 File Offset: 0x0015A460
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0015B46C File Offset: 0x0015A46C
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x0015B484 File Offset: 0x0015A484
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0015B490 File Offset: 0x0015A490
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x0015B4A8 File Offset: 0x0015A4A8
		internal virtual ComboBox Brand_ComboBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Brand_ComboBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Brand_ComboBox != null;
				if (flag)
				{
					this._Brand_ComboBox.SelectedIndexChanged -= this.Brand_ComboBox_SelectedIndexChanged;
				}
				this._Brand_ComboBox = value;
				flag = (this._Brand_ComboBox != null);
				if (flag)
				{
					this._Brand_ComboBox.SelectedIndexChanged += this.Brand_ComboBox_SelectedIndexChanged;
				}
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0015B514 File Offset: 0x0015A514
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x0015B52C File Offset: 0x0015A52C
		internal virtual ToolTip ToolTip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip1 = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0015B538 File Offset: 0x0015A538
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x0015B550 File Offset: 0x0015A550
		internal virtual Label curList_Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._curList_Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._curList_Label = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0015B55C File Offset: 0x0015A55C
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x0015B574 File Offset: 0x0015A574
		internal virtual Label NbDup_Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NbDup_Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NbDup_Label = value;
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0015B580 File Offset: 0x0015A580
		public DupDialog()
		{
			ArrayList _ENCList = DupDialog.__ENCList;
			lock (_ENCList)
			{
				DupDialog.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
			this.completeSdBrandList = MyProject.Forms.FormMain.mapMngt.CATPOI.sdBrandList;
			this.sdBrandList = new SortedDictionary<ushort, CATPOI.CATPOIRecords>();
			this.choiceList = new ListOfPOILists();
			this.refList = new List<POILists>();
			this.listOfBrand = new DupDialog.listOfBrands();
			CATPOI.CATPOIRecords catpoirecords = new CATPOI.CATPOIRecords();
			catpoirecords._brandName = Resources.strBrandAllBrands;
			catpoirecords.brandIdx = ushort.MaxValue;
			catpoirecords._idx = 65535;
			this.listOfBrand.Add(catpoirecords);
			this.bindingChoiceList = new BindingSource(this.choiceList, null);
			this.choiceLists_ListBox.DataSource = this.bindingChoiceList;
			this.choiceLists_ListBox.DisplayMember = "Name";
			this.bindingBrandList = new BindingSource(this.listOfBrand, null);
			this.Brand_ComboBox.DataSource = this.bindingBrandList;
			this.Brand_ComboBox.DisplayMember = "brandName";
			this.Brand_ComboBox.ValueMember = "idx";
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0015B6D4 File Offset: 0x0015A6D4
		public DialogResult ShowDialog(ListOfPOILists completeList, ListBox.SelectedIndexCollection selectedList, ListBox.SelectedObjectCollection selectedItems, Common.RTxMapType mapType)
		{
			int index = 0;
			List<int> list = new List<int>();
			checked
			{
				this.curList = (POILists)selectedItems[selectedItems.Count - 1];
				this.curListName = this.curList.name;
				this.curList_Label.Text = string.Format(Resources.strListToUse, "\"" + this.curListName + "\"");
				int num = 0;
				int num2 = selectedList.Count - 2;
				int num3 = num;
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					list.Add(selectedList[num3]);
					num3++;
				}
				this.choiceLists_ListBox.BeginUpdate();
				this.choiceList.Clear();
				try
				{
					foreach (POILists poilists in completeList)
					{
						bool flag = !poilists.Equals(this.curList);
						if (flag)
						{
							this.choiceList.Add(poilists);
						}
					}
				}
				finally
				{
					IEnumerator<POILists> enumerator;
					bool flag = enumerator != null;
					if (flag)
					{
						enumerator.Dispose();
					}
				}
				this.choiceLists_ListBox.EndUpdate();
				num3 = 0;
				int num6 = 0;
				this.choiceLists_ListBox.SetSelected(num6, false);
				bool flag2;
				try
				{
					foreach (POILists poilists in completeList)
					{
						bool flag = !poilists.Equals(this.curList);
						if (flag)
						{
							flag2 = (num3 < list.Count && list[num3] == num6);
							if (flag2)
							{
								this.choiceLists_ListBox.SetSelected(num6, true);
								num3++;
							}
							num6++;
						}
					}
				}
				finally
				{
					IEnumerator<POILists> enumerator2;
					flag2 = (enumerator2 != null);
					if (flag2)
					{
						enumerator2.Dispose();
					}
				}
				flag2 = (this.choiceLists_ListBox.SelectedItems.Count == 0);
				if (flag2)
				{
					num6 = 0;
					index = num6;
					try
					{
						foreach (POILists poilists in this.choiceList)
						{
							flag2 = (this.curList.type == poilists.type);
							if (flag2)
							{
								index = num6;
								break;
							}
							num6++;
						}
					}
					finally
					{
						IEnumerator<POILists> enumerator3;
						flag2 = (enumerator3 != null);
						if (flag2)
						{
							enumerator3.Dispose();
						}
					}
					this.choiceLists_ListBox.SetSelected(index, true);
				}
				this.state = DupDialog.states.idle;
				this.NbDup_Label.Text = "";
				base.ShowDialog();
				this.updateGUI();
				DialogResult result;
				return result;
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0015B96C File Offset: 0x0015A96C
		public void choiceLists_ListBoxSelectionChange(object sender, EventArgs e)
		{
			bool flag = this.choiceLists_ListBox.SelectedItems.Count == 1;
			if (flag)
			{
				this.ListNbLabel.Text = Resources.strOneList;
			}
			else
			{
				this.ListNbLabel.Text = string.Format(Resources.strMoreLists, this.choiceLists_ListBox.SelectedItems.Count);
			}
			this.sdBrandList.Clear();
			try
			{
				foreach (object obj in this.choiceLists_ListBox.SelectedItems)
				{
					POILists poilists = (POILists)obj;
					try
					{
						foreach (ushort key in poilists.buildBrandDict().Keys)
						{
							flag = !this.sdBrandList.ContainsKey(key);
							if (flag)
							{
								this.sdBrandList.Add(key, this.completeSdBrandList[key]);
							}
						}
					}
					finally
					{
						SortedDictionary<ushort, int>.KeyCollection.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag = (enumerator is IDisposable);
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.Brand_ComboBox.BeginUpdate();
			this.bindingBrandList.Clear();
			flag = (this.sdBrandList.Count > 0);
			if (flag)
			{
				CATPOI.CATPOIRecords catpoirecords = new CATPOI.CATPOIRecords();
				catpoirecords._brandName = Resources.strBrandAllBrands;
				catpoirecords.brandIdx = ushort.MaxValue;
				catpoirecords._idx = 65535;
				this.bindingBrandList.Add(catpoirecords);
			}
			try
			{
				foreach (ushort key in this.sdBrandList.Keys)
				{
					this.bindingBrandList.Add(this.sdBrandList[key]);
				}
			}
			finally
			{
				SortedDictionary<ushort, CATPOI.CATPOIRecords>.KeyCollection.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			this.Brand_ComboBox.EndUpdate();
			this.state = DupDialog.states.idle;
			this.updateGUI();
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0015BB98 File Offset: 0x0015AB98
		private void Dist_NumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			this.state = DupDialog.states.idle;
			this.updateGUI();
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0015BBAC File Offset: 0x0015ABAC
		private void Brand_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.state = DupDialog.states.idle;
			this.updateGUI();
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0015BBC0 File Offset: 0x0015ABC0
		private void updateGUI()
		{
			switch (this.state)
			{
			case DupDialog.states.idle:
				this.Find_Button.Enabled = (this.choiceLists_ListBox.SelectedIndices.Count > 0);
				this.Remove_Button.Enabled = false;
				break;
			case DupDialog.states.found:
				this.Find_Button.Enabled = false;
				this.Remove_Button.Enabled = true;
				break;
			case DupDialog.states.removed:
				this.Find_Button.Enabled = false;
				this.Remove_Button.Enabled = false;
				break;
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0015BC54 File Offset: 0x0015AC54
		private void Find_Button_Click(object sender, EventArgs e)
		{
			this.refList.Clear();
			bool flag;
			try
			{
				foreach (object obj in this.choiceLists_ListBox.SelectedItems)
				{
					POILists poilists = (POILists)obj;
					this.refList.Add(poilists);
					CATPOI.CATPOIRecords catpoirecords = (CATPOI.CATPOIRecords)this.Brand_ComboBox.SelectedItem;
					poilists.buildSdPOIByCell(catpoirecords.idx);
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag = (enumerator is IDisposable);
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			int num = this.curList.FindDuplicates(this.refList, Convert.ToInt32(this.Dist_NumericUpDown.Value));
			this.NbDup_Label.Text = num.ToString();
			flag = (num > 0);
			if (flag)
			{
				this.state = DupDialog.states.found;
			}
			this.updateGUI();
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0015BD48 File Offset: 0x0015AD48
		private void Remove_Button_Click(object sender, EventArgs e)
		{
			bool flag = this.curList.removeDup() == null;
			if (flag)
			{
				MyProject.Forms.FormMain.mapMngt.importedPOIList.removeList(this.curList, false);
			}
			else
			{
				MyProject.Forms.FormMain.mapMngt.importedPOIList.updateTotalPOINumber();
			}
			this.state = DupDialog.states.removed;
			this.updateGUI();
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0015BDB8 File Offset: 0x0015ADB8
		private void Save_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0015BDCC File Offset: 0x0015ADCC
		private void Close_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x040003D5 RID: 981
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x040003D7 RID: 983
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x040003D8 RID: 984
		[AccessedThroughProperty("Close_Button")]
		private Button _Close_Button;

		// Token: 0x040003D9 RID: 985
		[AccessedThroughProperty("ListNbLabel")]
		private Label _ListNbLabel;

		// Token: 0x040003DA RID: 986
		[AccessedThroughProperty("choiceLists_ListBox")]
		private ListBox _choiceLists_ListBox;

		// Token: 0x040003DB RID: 987
		[AccessedThroughProperty("Dist_NumericUpDown")]
		private NumericUpDown _Dist_NumericUpDown;

		// Token: 0x040003DC RID: 988
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040003DD RID: 989
		[AccessedThroughProperty("Find_Button")]
		private Button _Find_Button;

		// Token: 0x040003DE RID: 990
		[AccessedThroughProperty("Remove_Button")]
		private Button _Remove_Button;

		// Token: 0x040003DF RID: 991
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040003E0 RID: 992
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040003E1 RID: 993
		[AccessedThroughProperty("Brand_ComboBox")]
		private ComboBox _Brand_ComboBox;

		// Token: 0x040003E2 RID: 994
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		// Token: 0x040003E3 RID: 995
		[AccessedThroughProperty("curList_Label")]
		private Label _curList_Label;

		// Token: 0x040003E4 RID: 996
		[AccessedThroughProperty("NbDup_Label")]
		private Label _NbDup_Label;

		// Token: 0x040003E5 RID: 997
		private POILists curList;

		// Token: 0x040003E6 RID: 998
		private string curListName;

		// Token: 0x040003E7 RID: 999
		private ListOfPOILists choiceList;

		// Token: 0x040003E8 RID: 1000
		private BindingSource bindingChoiceList;

		// Token: 0x040003E9 RID: 1001
		private DupDialog.listOfBrands listOfBrand;

		// Token: 0x040003EA RID: 1002
		private SortedDictionary<ushort, CATPOI.CATPOIRecords> sdBrandList;

		// Token: 0x040003EB RID: 1003
		private SortedDictionary<ushort, CATPOI.CATPOIRecords> completeSdBrandList;

		// Token: 0x040003EC RID: 1004
		private BindingSource bindingBrandList;

		// Token: 0x040003ED RID: 1005
		private List<POILists> refList;

		// Token: 0x040003EE RID: 1006
		private DupDialog.states state;

		// Token: 0x0200003D RID: 61
		private class listOfBrands : BindingList<CATPOI.CATPOIRecords>
		{
			// Token: 0x060006F5 RID: 1781 RVA: 0x0015BDF0 File Offset: 0x0015ADF0
			[DebuggerNonUserCode]
			public listOfBrands()
			{
				ArrayList _ENCList = DupDialog.listOfBrands.__ENCList;
				lock (_ENCList)
				{
					DupDialog.listOfBrands.__ENCList.Add(new WeakReference(this));
				}
			}

			// Token: 0x040003EF RID: 1007
			private static ArrayList __ENCList = new ArrayList();
		}

		// Token: 0x0200003E RID: 62
		private enum states
		{
			// Token: 0x040003F1 RID: 1009
			idle,
			// Token: 0x040003F2 RID: 1010
			found,
			// Token: 0x040003F3 RID: 1011
			removed
		}
	}
}
