using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x020000B1 RID: 177
	public class POITypeInfo
	{
		// Token: 0x06000DE8 RID: 3560 RVA: 0x00129CB8 File Offset: 0x00128CB8
		public POITypeInfo(Common.RTxTypes RTxType, Common.RTxMapEditorMapModes RTxMapEditorMapMode)
		{
			this._RTxMapEditorMapMode = RTxMapEditorMapMode;
			this._RTxType = RTxType;
			this.initDefaultValues(RTxType);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00129CDC File Offset: 0x00128CDC
		public void setRTxMapEditorMapMode(Common.RTxMapEditorMapModes RTxMapEditorMapMode)
		{
			this._RTxMapEditorMapMode = RTxMapEditorMapMode;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00129CE8 File Offset: 0x00128CE8
		public bool isTypeDefined(ushort type)
		{
			return this.POITypInfoDict.ContainsKey(type);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00129D08 File Offset: 0x00128D08
		public string getNameOfType(ushort type)
		{
			POITypeInfo.POITypInfos poitypInfos = null;
			bool flag = this.POITypInfoDict.TryGetValue(type, out poitypInfos);
			string result;
			if (flag)
			{
				result = poitypInfos.name;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00129D3C File Offset: 0x00128D3C
		public ushort getTypeOfName(string name)
		{
			ushort num;
			bool flag = this._POINameTypeDict.TryGetValue(name, out num);
			ushort result;
			if (flag)
			{
				result = num;
			}
			else
			{
				result = 255;
			}
			return result;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00129D70 File Offset: 0x00128D70
		public byte getScaleOfType(ushort type)
		{
			POITypeInfo.POITypInfos poitypInfos = null;
			bool flag = this.POITypInfoDict.TryGetValue(type, out poitypInfos);
			byte result;
			if (flag)
			{
				result = poitypInfos.scale;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00129DA4 File Offset: 0x00128DA4
		public byte getLayerOfType(ushort type)
		{
			POITypeInfo.POITypInfos poitypInfos = null;
			bool flag = this.POITypInfoDict.TryGetValue(type, out poitypInfos);
			byte result;
			if (flag)
			{
				result = poitypInfos.layer;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00129DD8 File Offset: 0x00128DD8
		public POICategoryInfos.categories getCategoryOfType(ushort type)
		{
			POITypeInfo.POITypInfos poitypInfos = null;
			bool flag = this.POITypInfoDict.TryGetValue(type, out poitypInfos);
			POICategoryInfos.categories result;
			if (flag)
			{
				result = poitypInfos.category;
			}
			else
			{
				result = (POICategoryInfos.categories)0;
			}
			return result;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00129E0C File Offset: 0x00128E0C
		public Image getImageOfType(ushort type)
		{
			POITypeInfo.POITypInfos poitypInfos = null;
			bool flag = this.POITypInfoDict.TryGetValue(type, out poitypInfos);
			Image result;
			if (flag)
			{
				bool flag2 = this._RTxType == Common.RTxTypes.typeRT3;
				if (flag2)
				{
					result = poitypInfos.RT3image;
				}
				else
				{
					result = poitypInfos.RT4image;
				}
			}
			else
			{
				result = Resources._none;
			}
			return result;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00129E60 File Offset: 0x00128E60
		public void setFRANCXXXDSTPtr(FRANCXXXDST FRANCSEMDST, FRANCXXXDST FRANCSAFDST, FRANCXXXDST FRANCSHRDST, FRANCXXXDST FRANCSTUDST, FRANCXXXDST FRANCSSHDST, FRANCXXXDST FRANCSSPDST, FRANCXXXDST FRANCSTRDST, FRANCXXXDST FRANCSAUDST, FRANCSCCDST FRANCSCCDST)
		{
			SortedDictionary<ushort, POITypeInfo.POITypInfos>.KeyCollection keys = this.POITypInfoDict.Keys;
			try
			{
				foreach (ushort key in keys)
				{
					switch (this.POITypInfoDict[key].category)
					{
					case POICategoryInfos.categories.CAT_MIN:
						this.POITypInfoDict[key].FRANCXXXDSTPtr = FRANCSEMDST;
						break;
					case POICategoryInfos.categories.CAT_SAF:
						this.POITypInfoDict[key].FRANCXXXDSTPtr = FRANCSAFDST;
						break;
					case POICategoryInfos.categories.CAT_SHR:
						this.POITypInfoDict[key].FRANCXXXDSTPtr = FRANCSHRDST;
						break;
					case POICategoryInfos.categories.CAT_STU:
						this.POITypInfoDict[key].FRANCXXXDSTPtr = FRANCSTUDST;
						break;
					case POICategoryInfos.categories.CAT_SSH:
						this.POITypInfoDict[key].FRANCXXXDSTPtr = FRANCSSHDST;
						break;
					case POICategoryInfos.categories.CAT_SSP:
						this.POITypInfoDict[key].FRANCXXXDSTPtr = FRANCSSPDST;
						break;
					case POICategoryInfos.categories.CAT_STR:
						this.POITypInfoDict[key].FRANCXXXDSTPtr = FRANCSTRDST;
						break;
					case POICategoryInfos.categories.CAT_SAU:
						this.POITypInfoDict[key].FRANCXXXDSTPtr = FRANCSAUDST;
						break;
					case POICategoryInfos.categories.CAT_SCC:
						this.POITypInfoDict[key].FRANCSCCDSTPtr = FRANCSCCDST;
						break;
					}
				}
			}
			finally
			{
				SortedDictionary<ushort, POITypeInfo.POITypInfos>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00129FE0 File Offset: 0x00128FE0
		public FRANCXXXDST getFRANCXXXDSTPtr(ushort type)
		{
			return this.POITypInfoDict[type].FRANCXXXDSTPtr;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0012A004 File Offset: 0x00129004
		public void setFRANCXXXDSCPtr(FRANCXXXDSC FRANCSEMDSC, FRANCXXXDSC FRANCSAFDSC, FRANCXXXDSC FRANCSHRDSC, FRANCXXXDSC FRANCSTUDSC, FRANCXXXDSC FRANCSSHDSC, FRANCXXXDSC FRANCSSPDSC, FRANCXXXDSC FRANCSTRDSC, FRANCXXXDSC FRANCSAUDSC)
		{
			SortedDictionary<ushort, POITypeInfo.POITypInfos>.KeyCollection keys = this.POITypInfoDict.Keys;
			try
			{
				foreach (ushort key in keys)
				{
					switch (this.POITypInfoDict[key].category)
					{
					case POICategoryInfos.categories.CAT_MIN:
						this.POITypInfoDict[key].FRANCXXXDSCPtr = FRANCSEMDSC;
						break;
					case POICategoryInfos.categories.CAT_SAF:
						this.POITypInfoDict[key].FRANCXXXDSCPtr = FRANCSAFDSC;
						break;
					case POICategoryInfos.categories.CAT_SHR:
						this.POITypInfoDict[key].FRANCXXXDSCPtr = FRANCSHRDSC;
						break;
					case POICategoryInfos.categories.CAT_STU:
						this.POITypInfoDict[key].FRANCXXXDSCPtr = FRANCSTUDSC;
						break;
					case POICategoryInfos.categories.CAT_SSH:
						this.POITypInfoDict[key].FRANCXXXDSCPtr = FRANCSSHDSC;
						break;
					case POICategoryInfos.categories.CAT_SSP:
						this.POITypInfoDict[key].FRANCXXXDSCPtr = FRANCSSPDSC;
						break;
					case POICategoryInfos.categories.CAT_STR:
						this.POITypInfoDict[key].FRANCXXXDSCPtr = FRANCSTRDSC;
						break;
					case POICategoryInfos.categories.CAT_SAU:
						this.POITypInfoDict[key].FRANCXXXDSCPtr = FRANCSAUDSC;
						break;
					}
				}
			}
			finally
			{
				SortedDictionary<ushort, POITypeInfo.POITypInfos>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0012A168 File Offset: 0x00129168
		public FRANCXXXDSC getFRANCXXXDSCPtr(ushort type)
		{
			return this.POITypInfoDict[type].FRANCXXXDSCPtr;
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0012A18C File Offset: 0x0012918C
		public byte getTypeOrder(ushort type)
		{
			return this.POITypeHashDict[type];
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0012A1AC File Offset: 0x001291AC
		public bool isypeKnown(ushort type)
		{
			return this.POITypInfoDict.ContainsKey(type);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0012A1CC File Offset: 0x001291CC
		public ushort RT4TypeFromRT3Type(ushort RT3Type)
		{
			ushort num;
			bool flag = this._RT3Types2RT4Types.TryGetValue(RT3Type, out num);
			ushort result;
			if (flag)
			{
				result = num;
			}
			else
			{
				MyProject.Application.Log.WriteEntry(string.Format(Resources.strErrUnkRT3Type, RT3Type));
				Interaction.MsgBox(string.Format(Resources.strErrUnkRT3Type, RT3Type), MsgBoxStyle.Critical, null);
				result = RT3Type;
			}
			return result;
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0012A234 File Offset: 0x00129234
		public ushort RT3TypeFromRT4Type(ushort RT4Type)
		{
			ushort num;
			bool flag = this._RT4Types2RT3Types.TryGetValue(RT4Type, out num);
			ushort result;
			if (flag)
			{
				result = num;
			}
			else
			{
				MyProject.Application.Log.WriteEntry(string.Format(Resources.strErrUnkRT4Type, RT4Type));
				Interaction.MsgBox(string.Format(Resources.strErrUnkRT4Type, RT4Type), MsgBoxStyle.Critical, null);
				result = RT4Type;
			}
			return result;
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x0012A29C File Offset: 0x0012929C
		public SortedDictionary<string, ushort> POINameTypeDict
		{
			get
			{
				return this._POINameTypeDict;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x0012A2B4 File Offset: 0x001292B4
		public SortedDictionary<string, ushort> POINameTypeDictAlert
		{
			get
			{
				return this._POINameTypeDictAlert;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x0012A2CC File Offset: 0x001292CC
		public SortedDictionary<byte, string> POINameScaleDict
		{
			get
			{
				return this._POINameScaleDict;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x0012A2E4 File Offset: 0x001292E4
		public SortedDictionary<byte, string> POINameLayerDict
		{
			get
			{
				return this._POINameLayerDict;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x0012A2FC File Offset: 0x001292FC
		public SortedDictionary<byte, string> POIMagDict
		{
			get
			{
				return this._POIMagDict;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x0012A314 File Offset: 0x00129314
		public BindingSource POIMagBS
		{
			get
			{
				return new BindingSource(this._POIMagDict, null);
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x0012A334 File Offset: 0x00129334
		public BindingSource POITypeNameBS
		{
			get
			{
				return new BindingSource(this._POINameTypeDict, null);
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x0012A354 File Offset: 0x00129354
		public BindingSource POITypeNameWoNPBS
		{
			get
			{
				return new BindingSource(this._POINameTypeDictWoNP, null);
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x0012A374 File Offset: 0x00129374
		public BindingSource POITypeNameNPOnlyBS
		{
			get
			{
				return new BindingSource(this._POINameTypeDictNPOnly, null);
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0012A394 File Offset: 0x00129394
		public BindingSource POITypeNameAlert
		{
			get
			{
				return new BindingSource(this._POINameTypeDictAlert, null);
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x0012A3B4 File Offset: 0x001293B4
		public List<ushort> allDefinedTypes
		{
			get
			{
				return this._allDefinedTypes;
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0012A3CC File Offset: 0x001293CC
		private void initDefaultValues(Common.RTxTypes RTxType)
		{
			bool flag = this._POINameScaleDict == null;
			if (flag)
			{
				this._POINameScaleDict = new SortedDictionary<byte, string>();
				this._POINameScaleDict.Add(1, Resources.strScale1);
				this._POINameScaleDict.Add(2, Resources.strScale2);
				this._POINameScaleDict.Add(5, Resources.strScale5);
			}
			flag = (this._POIMagDict == null);
			if (flag)
			{
				this._POIMagDict = new SortedDictionary<byte, string>();
				this._POIMagDict.Add(1, Resources.strMag1);
				this._POIMagDict.Add(2, Resources.strMag2);
				this._POIMagDict.Add(3, Resources.strMag3);
				flag = (RTxType == Common.RTxTypes.typeRT3);
				if (flag)
				{
					this._POIMagDict.Add(4, Resources.strMag4);
					this._POIMagDict.Add(5, Resources.strMag5);
					this._POIMagDict.Add(6, Resources.strMag6);
					this._POIMagDict.Add(7, Resources.strMag7);
					this._POIMagDict.Add(8, Resources.strMag8);
				}
			}
			flag = (this.POITypInfoDict == null);
			checked
			{
				if (flag)
				{
					this.POITypInfoDict = new SortedDictionary<ushort, POITypeInfo.POITypInfos>();
					this._POINameTypeDict = new SortedDictionary<string, ushort>();
					this._POINameTypeDictWoNP = new SortedDictionary<string, ushort>();
					this._POINameTypeDictNPOnly = new SortedDictionary<string, ushort>();
					this._POINameTypeDictAlert = new SortedDictionary<string, ushort>();
					this._POINameLayerDict = new SortedDictionary<byte, string>();
					this.POITypeHashDict = new SortedDictionary<ushort, byte>();
					this._allDefinedTypes = new List<ushort>();
					this._RT3Types2RT4Types = new SortedDictionary<ushort, ushort>();
					this._RT4Types2RT3Types = new SortedDictionary<ushort, ushort>();
					this.POITypInfoDict.Add(1001, new POITypeInfo.POITypInfos(2, 5, Resources._03e9, Resources.artisan_champerard, Resources.str03e9Name, POICategoryInfos.categories.CAT_SAF, 313));
					this.POITypInfoDict.Add(1002, new POITypeInfo.POITypInfos(2, 70, Resources._03ea, Resources.radar2, Resources.str03eaName, POICategoryInfos.categories.CAT_SAU, 297));
					this.POITypInfoDict.Add(1003, new POITypeInfo.POITypInfos(2, 70, Resources._none, Resources.zone_accidentogene, Resources.str03ebName, POICategoryInfos.categories.CAT_SAU, 298));
					this.POITypInfoDict.Add(1004, new POITypeInfo.POITypInfos(2, 70, Resources._none, Resources._none, Resources.str03ecName, POICategoryInfos.categories.CAT_SAU, 299));
					this.POITypInfoDict.Add(2084, new POITypeInfo.POITypInfos(2, 4, Resources._0824, Resources.cantine, Resources.str0824Name, POICategoryInfos.categories.CAT_SAF, 312));
					this.POITypInfoDict.Add(3578, new POITypeInfo.POITypInfos(2, 51, Resources._none, Resources._none, Resources.str0dfaName, POICategoryInfos.categories.CAT_SAF, 335));
					this.POITypInfoDict.Add(3579, new POITypeInfo.POITypInfos(2, 70, Resources._none, Resources._none, Resources.str0dfbName, POICategoryInfos.categories.CAT_STU, 336));
					this.POITypInfoDict.Add(4013, new POITypeInfo.POITypInfos(2, 51, Resources._0fad, Resources.train_station, Resources.str0fadName, POICategoryInfos.categories.CAT_STR, 305));
					this.POITypInfoDict.Add(4100, new POITypeInfo.POITypInfos(2, 52, Resources._1004, Resources._none, Resources.str1004Name, POICategoryInfos.categories.CAT_STR, 304));
					this.POITypInfoDict.Add(4170, new POITypeInfo.POITypInfos(2, 53, Resources._104a, Resources.gare_route, Resources.str104aName, POICategoryInfos.categories.CAT_STR, 306));
					this.POITypInfoDict.Add(4444, new POITypeInfo.POITypInfos(byte.MaxValue, byte.MaxValue, Resources._115c, Resources.centreville, Resources.str115cName, POICategoryInfos.categories.CAT_SCC, 354));
					this.POITypInfoDict.Add(4482, new POITypeInfo.POITypInfos(2, 55, Resources._1182, Resources.tragett, Resources.str1182Name, POICategoryInfos.categories.CAT_STR, 263));
					this.POITypInfoDict.Add(4493, new POITypeInfo.POITypInfos(2, 56, Resources._118d, Resources.maritime, Resources.str118dName, POICategoryInfos.categories.CAT_STR, 264));
					this.POITypInfoDict.Add(4580, new POITypeInfo.POITypInfos(2, 50, Resources._11e4, Resources.aeroclub, Resources.str11e4Name, POICategoryInfos.categories.CAT_STR, 261));
					this.POITypInfoDict.Add(4581, new POITypeInfo.POITypInfos(2, 49, Resources._11e5, Resources.aeroport, Resources.str11e5Name, POICategoryInfos.categories.CAT_STR, 262));
					this.POITypInfoDict.Add(5000, new POITypeInfo.POITypInfos(2, 1, Resources._1388, Resources.affari, Resources.str1388Name, POICategoryInfos.categories.CAT_SAF, 307));
					this.POITypInfoDict.Add(5400, new POITypeInfo.POITypInfos(2, 2, Resources._none, Resources.supermarc, Resources.str1518Name, POICategoryInfos.categories.CAT_SAF, 311));
					this.POITypInfoDict.Add(5511, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str1587Name, POICategoryInfos.categories.CAT_SAU, 268));
					this.POITypInfoDict.Add(5512, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.fiat, Resources.str1588Name, POICategoryInfos.categories.CAT_SAU, 269));
					this.POITypInfoDict.Add(5513, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.lancia, Resources.str1589Name, POICategoryInfos.categories.CAT_SAU, 270));
					this.POITypInfoDict.Add(5514, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str158aName, POICategoryInfos.categories.CAT_SAU, 271));
					this.POITypInfoDict.Add(5515, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str158bName, POICategoryInfos.categories.CAT_SAU, 272));
					this.POITypInfoDict.Add(5516, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str158cName, POICategoryInfos.categories.CAT_SAU, 273));
					this.POITypInfoDict.Add(5517, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str158dName, POICategoryInfos.categories.CAT_SAU, 274));
					this.POITypInfoDict.Add(5518, new POITypeInfo.POITypInfos(2, 66, Resources._158e, Resources.citroen, Resources.str158eName, POICategoryInfos.categories.CAT_SAU, 275));
					this.POITypInfoDict.Add(5519, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str158fName, POICategoryInfos.categories.CAT_SAU, 276));
					this.POITypInfoDict.Add(5520, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str1590Name, POICategoryInfos.categories.CAT_SAU, 277));
					this.POITypInfoDict.Add(5521, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str1591Name, POICategoryInfos.categories.CAT_SAU, 278));
					this.POITypInfoDict.Add(5522, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str1592Name, POICategoryInfos.categories.CAT_SAU, 279));
					this.POITypInfoDict.Add(5523, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.peugeot, Resources.str1593Name, POICategoryInfos.categories.CAT_SAU, 280));
					this.POITypInfoDict.Add(5524, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str1594Name, POICategoryInfos.categories.CAT_SAU, 281));
					this.POITypInfoDict.Add(5525, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str1595Name, POICategoryInfos.categories.CAT_SAU, 282));
					this.POITypInfoDict.Add(5526, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str1596Name, POICategoryInfos.categories.CAT_SAU, 283));
					this.POITypInfoDict.Add(5527, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str1597Name, POICategoryInfos.categories.CAT_SAU, 284));
					this.POITypInfoDict.Add(5528, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str1598Name, POICategoryInfos.categories.CAT_SAU, 285));
					this.POITypInfoDict.Add(5529, new POITypeInfo.POITypInfos(2, 66, Resources._1587, Resources.garage, Resources.str1599Name, POICategoryInfos.categories.CAT_SAU, 286));
					this.POITypInfoDict.Add(5540, new POITypeInfo.POITypInfos(5, 238, Resources._15a4, Resources.statserv, Resources.str15a4Name, POICategoryInfos.categories.CAT_SAU, 266));
					this.POITypInfoDict.Add(5571, new POITypeInfo.POITypInfos(2, 67, Resources._none, Resources._none, Resources.str15c3Name, POICategoryInfos.categories.CAT_SAU, 353));
					this.POITypInfoDict.Add(5800, new POITypeInfo.POITypInfos(2, 10, Resources._16a8, Resources.ris, Resources.str16a8Name, POICategoryInfos.categories.CAT_SHR, 309));
					this.POITypInfoDict.Add(5813, new POITypeInfo.POITypInfos(2, 31, Resources._16b5, Resources.nightclu, Resources.str16b5Name, POICategoryInfos.categories.CAT_SSH, 322));
					this.POITypInfoDict.Add(5999, new POITypeInfo.POITypInfos(2, 20, Resources._176f, Resources.monument, Resources.str176fName, POICategoryInfos.categories.CAT_STU, 328));
					this.POITypInfoDict.Add(6000, new POITypeInfo.POITypInfos(2, 2, Resources._none, Resources._none, Resources.str1770Name, POICategoryInfos.categories.CAT_SAF, 334));
					this.POITypInfoDict.Add(6512, new POITypeInfo.POITypInfos(2, 2, Resources._1970, Resources.supermarc, Resources.str1970Name, POICategoryInfos.categories.CAT_SAF, 310));
					this.POITypInfoDict.Add(7011, new POITypeInfo.POITypInfos(2, 9, Resources._1b63, Resources.hotel, Resources.str1b63Name, POICategoryInfos.categories.CAT_SHR, 308));
					this.POITypInfoDict.Add(7012, new POITypeInfo.POITypInfos(2, 43, Resources._1b64, Resources.sci, Resources.str1b64Name, POICategoryInfos.categories.CAT_SSP, 321));
					this.POITypInfoDict.Add(7389, new POITypeInfo.POITypInfos(2, 24, Resources._1cdd, Resources.tourism_info, Resources.str1cddName, POICategoryInfos.categories.CAT_STU, 329));
					this.POITypInfoDict.Add(7390, new POITypeInfo.POITypInfos(2, 73, Resources._none, Resources._none, Resources.str1cdeName, POICategoryInfos.categories.CAT_SAF, 330));
					this.POITypInfoDict.Add(7510, new POITypeInfo.POITypInfos(2, 54, Resources._1d56, Resources.autonol, Resources.str1d56Name, POICategoryInfos.categories.CAT_STR, 265));
					this.POITypInfoDict.Add(7520, new POITypeInfo.POITypInfos(2, 64, Resources._1d60, Resources.autorim, Resources.str1d60Name, POICategoryInfos.categories.CAT_SAU, 303));
					this.POITypInfoDict.Add(7521, new POITypeInfo.POITypInfos(2, 63, Resources._1d61, Resources.parchegg, Resources.str1d61Name, POICategoryInfos.categories.CAT_SAU, 301));
					this.POITypInfoDict.Add(7522, new POITypeInfo.POITypInfos(2, 65, Resources._1d62, Resources.parkride, Resources.str1d62Name, POICategoryInfos.categories.CAT_SAU, 302));
					this.POITypInfoDict.Add(7538, new POITypeInfo.POITypInfos(2, 66, Resources._1d72, Resources.garage, Resources.str1d72Name, POICategoryInfos.categories.CAT_SAU, 267));
					this.POITypInfoDict.Add(7832, new POITypeInfo.POITypInfos(2, 30, Resources._1e98, Resources.cinema, Resources.str1e98Name, POICategoryInfos.categories.CAT_SSH, 324));
					this.POITypInfoDict.Add(7897, new POITypeInfo.POITypInfos(2, 60, Resources._1ed9, Resources.parkrepos, Resources.str1ed9Name, POICategoryInfos.categories.CAT_SAU, 300));
					this.POITypInfoDict.Add(7929, new POITypeInfo.POITypInfos(2, 29, Resources._none, Resources.attraction, Resources.str1ef9Name, POICategoryInfos.categories.CAT_SSH, 339));
					this.POITypInfoDict.Add(7933, new POITypeInfo.POITypInfos(2, 45, Resources._1efd, Resources.bowl, Resources.str1efdName, POICategoryInfos.categories.CAT_SSP, 315));
					this.POITypInfoDict.Add(7940, new POITypeInfo.POITypInfos(2, 40, Resources._1f04, Resources.complspo, Resources.str1f04Name, POICategoryInfos.categories.CAT_SSP, 320));
					this.POITypInfoDict.Add(7947, new POITypeInfo.POITypInfos(2, 39, Resources._1f0b, Resources.parcjar, Resources.str1f0bName, POICategoryInfos.categories.CAT_SSP, 318));
					this.POITypInfoDict.Add(7985, new POITypeInfo.POITypInfos(2, 32, Resources._1f31, Resources.casino, Resources.str1f31Name, POICategoryInfos.categories.CAT_SSH, 323));
					this.POITypInfoDict.Add(7990, new POITypeInfo.POITypInfos(2, 25, Resources._1f36, Resources.esposiz, Resources.str1f36Name, POICategoryInfos.categories.CAT_STU, 326));
					this.POITypInfoDict.Add(7992, new POITypeInfo.POITypInfos(2, 42, Resources._1f38, Resources.golf, Resources.str1f38Name, POICategoryInfos.categories.CAT_SSP, 317));
					this.POITypInfoDict.Add(7994, new POITypeInfo.POITypInfos(2, 26, Resources._none, Resources._none, Resources.str1f3aName, POICategoryInfos.categories.CAT_STU, 338));
					this.POITypInfoDict.Add(7996, new POITypeInfo.POITypInfos(2, 46, Resources._1f3c, Resources.parcdiv, Resources.str1f3cName, POICategoryInfos.categories.CAT_SSP, 316));
					this.POITypInfoDict.Add(7997, new POITypeInfo.POITypInfos(2, 41, Resources._1f3d, Resources.centrspo, Resources.str1f3dName, POICategoryInfos.categories.CAT_SSP, 319));
					this.POITypInfoDict.Add(7998, new POITypeInfo.POITypInfos(2, 44, Resources._1f3e, Resources.patinoire, Resources.str1f3eName, POICategoryInfos.categories.CAT_SSP, 314));
					this.POITypInfoDict.Add(7999, new POITypeInfo.POITypInfos(2, 19, Resources._1f3f, Resources.monument, Resources.str1f3fName, POICategoryInfos.categories.CAT_STU, 327));
					this.POITypInfoDict.Add(8060, new POITypeInfo.POITypInfos(1, 250, Resources._1f7c, Resources.ospedali, Resources.str1f7cName, POICategoryInfos.categories.CAT_MIN, 260));
					this.POITypInfoDict.Add(8200, new POITypeInfo.POITypInfos(1, 249, Resources._2008, Resources.univers, Resources.str2008Name, POICategoryInfos.categories.CAT_MIN, 257));
					this.POITypInfoDict.Add(8211, new POITypeInfo.POITypInfos(1, 249, Resources._2013, Resources.ecole, Resources.str2013Name, POICategoryInfos.categories.CAT_MIN, 258));
					this.POITypInfoDict.Add(8231, new POITypeInfo.POITypInfos(2, 22, Resources._none, Resources._none, Resources.str2027Name, POICategoryInfos.categories.CAT_STU, 337));
					this.POITypInfoDict.Add(8410, new POITypeInfo.POITypInfos(2, 22, Resources._20da, Resources.joconde, Resources.str20daName, POICategoryInfos.categories.CAT_STU, 325));
					this.POITypInfoDict.Add(8699, new POITypeInfo.POITypInfos(2, 66, Resources._none, Resources._none, Resources.str21fbName, POICategoryInfos.categories.CAT_SAU, 342));
					this.POITypInfoDict.Add(8700, new POITypeInfo.POITypInfos(2, 66, Resources._none, Resources._none, Resources.str21fcName, POICategoryInfos.categories.CAT_MIN, 343));
					this.POITypInfoDict.Add(8701, new POITypeInfo.POITypInfos(2, 66, Resources._none, Resources._none, Resources.str21fdName, POICategoryInfos.categories.CAT_MIN, 344));
					this.POITypInfoDict.Add(9121, new POITypeInfo.POITypInfos(1, 245, Resources._23a1, Resources.mairie, Resources.str23a1Name, POICategoryInfos.categories.CAT_MIN, 259));
					this.POITypInfoDict.Add(9211, new POITypeInfo.POITypInfos(1, 245, Resources._none, Resources.tribunal, Resources.str23fbName, POICategoryInfos.categories.CAT_MIN, 331));
					this.POITypInfoDict.Add(9212, new POITypeInfo.POITypInfos(1, 245, Resources._none, Resources._none, Resources.str23fcName, POICategoryInfos.categories.CAT_MIN, 332));
					this.POITypInfoDict.Add(9221, new POITypeInfo.POITypInfos(1, 245, Resources._none, Resources.police, Resources.str2405Name, POICategoryInfos.categories.CAT_MIN, 333));
					this.POITypInfoDict.Add(9583, new POITypeInfo.POITypInfos(1, 244, Resources._none, Resources._none, Resources.str256fName, POICategoryInfos.categories.CAT_MIN, 345));
					this.POITypInfoDict.Add(9991, new POITypeInfo.POITypInfos(2, 1, Resources._none, Resources._none, Resources.str2707Name, POICategoryInfos.categories.CAT_SAF, 256));
					this.POITypInfoDict.Add(9993, new POITypeInfo.POITypInfos(2, 79, Resources._none, Resources._none, Resources.str2709Name, POICategoryInfos.categories.CAT_MIN, 346));
					this.POITypInfoDict.Add(9998, new POITypeInfo.POITypInfos(2, 69, Resources._none, Resources._none, Resources.str270eName, POICategoryInfos.categories.CAT_STR, 340));
					this.POITypInfoDict.Add(9999, new POITypeInfo.POITypInfos(2, 68, Resources._none, Resources.douane, Resources.str270fName, POICategoryInfos.categories.CAT_STR, 341));
					this.POITypInfoDict.Add(12288, new POITypeInfo.POITypInfos(2, 68, Resources._none, Resources._none, Resources.str3000Name, POICategoryInfos.categories.CAT_STU, 347));
					this.POITypInfoDict.Add(12289, new POITypeInfo.POITypInfos(2, 68, Resources._none, Resources._none, Resources.str3001Name, POICategoryInfos.categories.CAT_STR, 348));
					this.POITypInfoDict.Add(12290, new POITypeInfo.POITypInfos(2, 68, Resources._none, Resources._none, Resources.str3002Name, POICategoryInfos.categories.CAT_SHR, 349));
					this.POITypInfoDict.Add(12291, new POITypeInfo.POITypInfos(2, 68, Resources._none, Resources._none, Resources.str3003Name, POICategoryInfos.categories.CAT_SHR, 350));
					this.POITypInfoDict.Add(12292, new POITypeInfo.POITypInfos(2, 68, Resources._none, Resources._none, Resources.str3004Name, POICategoryInfos.categories.CAT_SHR, 351));
					this.POITypInfoDict.Add(12293, new POITypeInfo.POITypInfos(2, 68, Resources._none, Resources.camping, Resources.str3005Name, POICategoryInfos.categories.CAT_STR, 352));
					this.POITypInfoDict.Add(22184, new POITypeInfo.POITypInfos(2, 10, Resources._56a8, Resources.ris_champerardKO, Resources.str56a8Name, POICategoryInfos.categories.CAT_SHR, 16693));
					SortedDictionary<ushort, POITypeInfo.POITypInfos>.KeyCollection keys = this.POITypInfoDict.Keys;
					byte b = 0;
					byte b2 = 0;
					try
					{
						foreach (ushort num in keys)
						{
							this._POINameTypeDict.Add(this.POITypInfoDict[num].name, num);
							flag = (num != 4444);
							if (flag)
							{
								this._POINameTypeDictWoNP.Add(this.POITypInfoDict[num].name, num);
							}
							else
							{
								this._POINameTypeDictNPOnly.Add(this.POITypInfoDict[num].name, num);
							}
							flag = (num == 1002 | num == 1003);
							if (flag)
							{
								this._POINameTypeDictAlert.Add(this.POITypInfoDict[num].name, num);
							}
							flag = !this._POINameLayerDict.ContainsKey(this.POITypInfoDict[num].layer);
							if (flag)
							{
								this._POINameLayerDict.Add(this.POITypInfoDict[num].layer, string.Format("{0:G} {1:G}", Resources.strLayer, this.POITypInfoDict[num].layer));
							}
							byte b3 = b;
							flag = (num == 5511);
							if (flag)
							{
								b2 = b;
							}
							flag = (num > 5511 & num <= 5529);
							if (flag)
							{
								b3 = b2;
							}
							this.POITypeHashDict.Add(num, 2 * b3);
							this.POITypeHashDict.Add(num | 32768, 2 * b3);
							b += 1;
							this._allDefinedTypes.Add(num);
							this._RT3Types2RT4Types.Add(num, this.POITypInfoDict[num].RT4Type);
							this._RT4Types2RT3Types.Add(this.POITypInfoDict[num].RT4Type, num);
						}
					}
					finally
					{
						SortedDictionary<ushort, POITypeInfo.POITypInfos>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0012B7E0 File Offset: 0x0012A7E0
		private string typeToKey(ushort type)
		{
			return string.Format("{0:X}POINumber", type);
		}

		// Token: 0x0400076A RID: 1898
		public const ushort RT3_TYPE_ENOGASTRONOMIE = 1001;

		// Token: 0x0400076B RID: 1899
		public const ushort RT4_TYPE_ENOGASTRONOMIE = 313;

		// Token: 0x0400076C RID: 1900
		public const ushort RT3_TYPE_RADAR = 1002;

		// Token: 0x0400076D RID: 1901
		public const ushort RT4_TYPE_RADAR = 297;

		// Token: 0x0400076E RID: 1902
		public const ushort RT3_TYPE_ZONES_DANGEUREUSES = 1003;

		// Token: 0x0400076F RID: 1903
		public const ushort RT4_TYPE_ZONES_DANGEUREUSES = 298;

		// Token: 0x04000770 RID: 1904
		public const ushort RT3_TYPE_ZONES_ACCIDENTOGENES = 1004;

		// Token: 0x04000771 RID: 1905
		public const ushort RT4_TYPE_ZONES_ACCIDENTOGENES = 299;

		// Token: 0x04000772 RID: 1906
		public const ushort RT3_TYPE_ÉTAB_VINICOLE = 2084;

		// Token: 0x04000773 RID: 1907
		public const ushort RT4_TYPE_ÉTAB_VINICOLE = 312;

		// Token: 0x04000774 RID: 1908
		public const ushort RT3_TYPE_ATM = 3578;

		// Token: 0x04000775 RID: 1909
		public const ushort RT4_TYPE_ATM = 335;

		// Token: 0x04000776 RID: 1910
		public const ushort RT3_TYPE_LIEU_DE_CULTE = 3579;

		// Token: 0x04000777 RID: 1911
		public const ushort RT4_TYPE_LIEU_DE_CULTE = 336;

		// Token: 0x04000778 RID: 1912
		public const ushort RT3_TYPE_GARE = 4013;

		// Token: 0x04000779 RID: 1913
		public const ushort RT4_TYPE_GARE = 305;

		// Token: 0x0400077A RID: 1914
		public const ushort RT3_TYPE_GARE_BANLIEUE = 4100;

		// Token: 0x0400077B RID: 1915
		public const ushort RT4_TYPE_GARE_BANLIEUE = 304;

		// Token: 0x0400077C RID: 1916
		public const ushort RT3_TYPE_GARE_ROUTIÈRE = 4170;

		// Token: 0x0400077D RID: 1917
		public const ushort RT4_TYPE_GARE_ROUTIÈRE = 306;

		// Token: 0x0400077E RID: 1918
		public const ushort RT3_TYPE_CENTRE_VILLE = 4444;

		// Token: 0x0400077F RID: 1919
		public const ushort RT4_TYPE_CENTRE_VILLE = 354;

		// Token: 0x04000780 RID: 1920
		public const ushort RT3_TYPE_GARE_MARITIME = 4482;

		// Token: 0x04000781 RID: 1921
		public const ushort RT4_TYPE_GARE_MARITIME = 263;

		// Token: 0x04000782 RID: 1922
		public const ushort RT3_TYPE_PORT_DE_PLAISANCE = 4493;

		// Token: 0x04000783 RID: 1923
		public const ushort RT4_TYPE_PORT_DE_PLAISANCE = 264;

		// Token: 0x04000784 RID: 1924
		public const ushort RT3_TYPE_AEROCLUB = 4580;

		// Token: 0x04000785 RID: 1925
		public const ushort RT4_TYPE_AEROCLUB = 261;

		// Token: 0x04000786 RID: 1926
		public const ushort RT3_TYPE_AÉROPORT = 4581;

		// Token: 0x04000787 RID: 1927
		public const ushort RT4_TYPE_AÉROPORT = 262;

		// Token: 0x04000788 RID: 1928
		public const ushort RT3_TYPE_SITE_INDUSTRIEL = 5000;

		// Token: 0x04000789 RID: 1929
		public const ushort RT4_TYPE_SITE_INDUSTRIEL = 307;

		// Token: 0x0400078A RID: 1930
		public const ushort RT3_TYPE_SUPERMARCHE = 5400;

		// Token: 0x0400078B RID: 1931
		public const ushort RT4_TYPE_SUPERMARCHE = 311;

		// Token: 0x0400078C RID: 1932
		public const ushort RT3_TYPE_FIRST_CONCESSIONNAIRE = 5511;

		// Token: 0x0400078D RID: 1933
		public const ushort RT4_TYPE_FIRST_CONCESSIONNAIRE = 268;

		// Token: 0x0400078E RID: 1934
		public const ushort RT3_TYPE_CONCESSIONNAIRE_ALFA = 5511;

		// Token: 0x0400078F RID: 1935
		public const ushort RT4_TYPE_CONCESSIONNAIRE_ALFA = 268;

		// Token: 0x04000790 RID: 1936
		public const ushort RT3_TYPE_CONCESSIONNAIRE_FIAT = 5512;

		// Token: 0x04000791 RID: 1937
		public const ushort RT4_TYPE_CONCESSIONNAIRE_FIAT = 269;

		// Token: 0x04000792 RID: 1938
		public const ushort RT3_TYPE_CONCESSIONNAIRE_LANCIA = 5513;

		// Token: 0x04000793 RID: 1939
		public const ushort RT4_TYPE_CONCESSIONNAIRE_LANCIA = 270;

		// Token: 0x04000794 RID: 1940
		public const ushort RT3_TYPE_CONCESSIONNAIRE_MASERATI = 5514;

		// Token: 0x04000795 RID: 1941
		public const ushort RT4_TYPE_CONCESSIONNAIRE_MASERATI = 271;

		// Token: 0x04000796 RID: 1942
		public const ushort RT3_TYPE_CONCESSIONNAIRE_DIVERS = 5515;

		// Token: 0x04000797 RID: 1943
		public const ushort RT4_TYPE_CONCESSIONNAIRE_DIVERS = 272;

		// Token: 0x04000798 RID: 1944
		public const ushort RT3_TYPE_CONCESSIONNAIRE_AUDI = 5516;

		// Token: 0x04000799 RID: 1945
		public const ushort RT4_TYPE_CONCESSIONNAIRE_AUDI = 273;

		// Token: 0x0400079A RID: 1946
		public const ushort RT3_TYPE_CONCESSIONNAIRE_BMW = 5517;

		// Token: 0x0400079B RID: 1947
		public const ushort RT4_TYPE_CONCESSIONNAIRE_BMW = 274;

		// Token: 0x0400079C RID: 1948
		public const ushort RT3_TYPE_CONCESSIONNAIRE_CITROËN = 5518;

		// Token: 0x0400079D RID: 1949
		public const ushort RT4_TYPE_CONCESSIONNAIRE_CITROËN = 275;

		// Token: 0x0400079E RID: 1950
		public const ushort RT3_TYPE_CONCESSIONNAIRE_FORD = 5519;

		// Token: 0x0400079F RID: 1951
		public const ushort RT4_TYPE_CONCESSIONNAIRE_FORD = 276;

		// Token: 0x040007A0 RID: 1952
		public const ushort RT3_TYPE_CONCESSIONNAIRE_GM = 5520;

		// Token: 0x040007A1 RID: 1953
		public const ushort RT4_TYPE_CONCESSIONNAIRE_GM = 277;

		// Token: 0x040007A2 RID: 1954
		public const ushort RT3_TYPE_CONCESSIONNAIRE_JAGUAR = 5521;

		// Token: 0x040007A3 RID: 1955
		public const ushort RT4_TYPE_CONCESSIONNAIRE_JAGUAR = 278;

		// Token: 0x040007A4 RID: 1956
		public const ushort RT3_TYPE_CONCESSIONNAIRE_OPEL = 5522;

		// Token: 0x040007A5 RID: 1957
		public const ushort RT4_TYPE_CONCESSIONNAIRE_OPEL = 279;

		// Token: 0x040007A6 RID: 1958
		public const ushort RT3_TYPE_CONCESSIONNAIRE_PEUGEOT = 5523;

		// Token: 0x040007A7 RID: 1959
		public const ushort RT4_TYPE_CONCESSIONNAIRE_PEUGEOT = 280;

		// Token: 0x040007A8 RID: 1960
		public const ushort RT3_TYPE_CONCESSIONNAIRE_PORSCHE = 5524;

		// Token: 0x040007A9 RID: 1961
		public const ushort RT4_TYPE_CONCESSIONNAIRE_PORSCHE = 281;

		// Token: 0x040007AA RID: 1962
		public const ushort RT3_TYPE_CONCESSIONNAIRE_RENAULT = 5525;

		// Token: 0x040007AB RID: 1963
		public const ushort RT4_TYPE_CONCESSIONNAIRE_RENAULT = 282;

		// Token: 0x040007AC RID: 1964
		public const ushort RT3_TYPE_CONCESSIONNAIRE_SAAB = 5526;

		// Token: 0x040007AD RID: 1965
		public const ushort RT4_TYPE_CONCESSIONNAIRE_SAAB = 283;

		// Token: 0x040007AE RID: 1966
		public const ushort RT3_TYPE_CONCESSIONNAIRE_VOLKSWAGEN = 5527;

		// Token: 0x040007AF RID: 1967
		public const ushort RT4_TYPE_CONCESSIONNAIRE_VOLKSWAGEN = 284;

		// Token: 0x040007B0 RID: 1968
		public const ushort RT3_TYPE_CONCESSIONNAIRE_VOLVO = 5528;

		// Token: 0x040007B1 RID: 1969
		public const ushort RT4_TYPE_CONCESSIONNAIRE_VOLVO = 285;

		// Token: 0x040007B2 RID: 1970
		public const ushort RT3_TYPE_CONCESSIONNAIRE_MERCEDES = 5529;

		// Token: 0x040007B3 RID: 1971
		public const ushort RT4_TYPE_CONCESSIONNAIRE_MERCEDES = 286;

		// Token: 0x040007B4 RID: 1972
		public const ushort RT3_TYPE_LAST_CONCESSIONNAIRE = 5529;

		// Token: 0x040007B5 RID: 1973
		public const ushort RT4_TYPE_LAST_CONCESSIONNAIRE = 286;

		// Token: 0x040007B6 RID: 1974
		public const ushort RT3_TYPE_STATION_SERVICE = 5540;

		// Token: 0x040007B7 RID: 1975
		public const ushort RT4_TYPE_STATION_SERVICE = 266;

		// Token: 0x040007B8 RID: 1976
		public const ushort RT3_TYPE_CONCESSIONNAIRE_MOTO = 5571;

		// Token: 0x040007B9 RID: 1977
		public const ushort RT4_TYPE_CONCESSIONNAIRE_MOTO = 353;

		// Token: 0x040007BA RID: 1978
		public const ushort RT3_TYPE_RESTAURANT = 5800;

		// Token: 0x040007BB RID: 1979
		public const ushort RT4_TYPE_RESTAURANT = 309;

		// Token: 0x040007BC RID: 1980
		public const ushort RT3_TYPE_VIE_NOCTURNE = 5813;

		// Token: 0x040007BD RID: 1981
		public const ushort RT4_TYPE_VIE_NOCTURNE = 322;

		// Token: 0x040007BE RID: 1982
		public const ushort RT3_TYPE_MONUMENT_HISTORIQUE = 5999;

		// Token: 0x040007BF RID: 1983
		public const ushort RT4_TYPE_MONUMENT_HISTORIQUE = 328;

		// Token: 0x040007C0 RID: 1984
		public const ushort RT3_TYPE_BANQUE = 6000;

		// Token: 0x040007C1 RID: 1985
		public const ushort RT4_TYPE_BANQUE = 334;

		// Token: 0x040007C2 RID: 1986
		public const ushort RT3_TYPE_CENTRE_COMMERCIAL = 6512;

		// Token: 0x040007C3 RID: 1987
		public const ushort RT4_TYPE_CENTRE_COMMERCIAL = 310;

		// Token: 0x040007C4 RID: 1988
		public const ushort RT3_TYPE_HÔTEL = 7011;

		// Token: 0x040007C5 RID: 1989
		public const ushort RT4_TYPE_HÔTEL = 308;

		// Token: 0x040007C6 RID: 1990
		public const ushort RT3_TYPE_STATION_SPORTS_HIVER = 7012;

		// Token: 0x040007C7 RID: 1991
		public const ushort RT4_TYPE_STATION_SPORTS_HIVER = 321;

		// Token: 0x040007C8 RID: 1992
		public const ushort RT3_TYPE_INFORMATION_TOURISTIQUE = 7389;

		// Token: 0x040007C9 RID: 1993
		public const ushort RT4_TYPE_INFORMATION_TOURISTIQUE = 329;

		// Token: 0x040007CA RID: 1994
		public const ushort RT3_TYPE_POSTE = 7390;

		// Token: 0x040007CB RID: 1995
		public const ushort RT4_TYPE_POSTE = 330;

		// Token: 0x040007CC RID: 1996
		public const ushort RT3_TYPE_AGENCE_LOCATION_VOITURES = 7510;

		// Token: 0x040007CD RID: 1997
		public const ushort RT4_TYPE_AGENCE_LOCATION_VOITURES = 265;

		// Token: 0x040007CE RID: 1998
		public const ushort RT3_TYPE_PARKING_DÉCOUVERT = 7520;

		// Token: 0x040007CF RID: 1999
		public const ushort RT4_TYPE_PARKING_DÉCOUVERT = 303;

		// Token: 0x040007D0 RID: 2000
		public const ushort RT3_TYPE_PARKING_COUVERT = 7521;

		// Token: 0x040007D1 RID: 2001
		public const ushort RT4_TYPE_PARKING_COUVERT = 301;

		// Token: 0x040007D2 RID: 2002
		public const ushort RT3_TYPE_PARKING_ÉCHANGE = 7522;

		// Token: 0x040007D3 RID: 2003
		public const ushort RT4_TYPE_PARKING_ÉCHANGE = 302;

		// Token: 0x040007D4 RID: 2004
		public const ushort RT3_TYPE_GARAGE = 7538;

		// Token: 0x040007D5 RID: 2005
		public const ushort RT4_TYPE_GARAGE = 267;

		// Token: 0x040007D6 RID: 2006
		public const ushort RT3_TYPE_CINEMA = 7832;

		// Token: 0x040007D7 RID: 2007
		public const ushort RT4_TYPE_CINEMA = 324;

		// Token: 0x040007D8 RID: 2008
		public const ushort RT3_TYPE_AIRE_REPOS = 7897;

		// Token: 0x040007D9 RID: 2009
		public const ushort RT4_TYPE_AIRE_REPOS = 300;

		// Token: 0x040007DA RID: 2010
		public const ushort RT3_TYPE_THÉÂTRE = 7929;

		// Token: 0x040007DB RID: 2011
		public const ushort RT4_TYPE_THÉÂTRE = 339;

		// Token: 0x040007DC RID: 2012
		public const ushort RT3_TYPE_BOWLING = 7933;

		// Token: 0x040007DD RID: 2013
		public const ushort RT4_TYPE_BOWLING = 315;

		// Token: 0x040007DE RID: 2014
		public const ushort RT3_TYPE_COMPLEXE_SPORTIF = 7940;

		// Token: 0x040007DF RID: 2015
		public const ushort RT4_TYPE_COMPLEXE_SPORTIF = 320;

		// Token: 0x040007E0 RID: 2016
		public const ushort RT3_TYPE_PARC_ET_JARDINS = 7947;

		// Token: 0x040007E1 RID: 2017
		public const ushort RT4_TYPE_PARC_ET_JARDINS = 318;

		// Token: 0x040007E2 RID: 2018
		public const ushort RT3_TYPE_CASINO = 7985;

		// Token: 0x040007E3 RID: 2019
		public const ushort RT4_TYPE_CASINO = 323;

		// Token: 0x040007E4 RID: 2020
		public const ushort RT3_TYPE_PALAIS_DES_CONGRÈS = 7990;

		// Token: 0x040007E5 RID: 2021
		public const ushort RT4_TYPE_PALAIS_DES_CONGRÈS = 326;

		// Token: 0x040007E6 RID: 2022
		public const ushort RT3_TYPE_TERRAIN_GOLF = 7992;

		// Token: 0x040007E7 RID: 2023
		public const ushort RT4_TYPE_TERRAIN_GOLF = 317;

		// Token: 0x040007E8 RID: 2024
		public const ushort RT3_TYPE_CENTRE_CULTUREL = 7994;

		// Token: 0x040007E9 RID: 2025
		public const ushort RT4_TYPE_CENTRE_CULTUREL = 338;

		// Token: 0x040007EA RID: 2026
		public const ushort RT3_TYPE_PARC_ATTRACTIONS = 7996;

		// Token: 0x040007EB RID: 2027
		public const ushort RT4_TYPE_PARC_ATTRACTIONS = 316;

		// Token: 0x040007EC RID: 2028
		public const ushort RT3_TYPE_CENTRE_SPORTIF = 7997;

		// Token: 0x040007ED RID: 2029
		public const ushort RT4_TYPE_CENTRE_SPORTIF = 319;

		// Token: 0x040007EE RID: 2030
		public const ushort RT3_TYPE_PATINOIRE = 7998;

		// Token: 0x040007EF RID: 2031
		public const ushort RT4_TYPE_PATINOIRE = 314;

		// Token: 0x040007F0 RID: 2032
		public const ushort RT3_TYPE_ATTRACTION_TOURISTIQUE = 7999;

		// Token: 0x040007F1 RID: 2033
		public const ushort RT4_TYPE_ATTRACTION_TOURISTIQUE = 327;

		// Token: 0x040007F2 RID: 2034
		public const ushort RT3_TYPE_HÔPITAL = 8060;

		// Token: 0x040007F3 RID: 2035
		public const ushort RT4_TYPE_HÔPITAL = 260;

		// Token: 0x040007F4 RID: 2036
		public const ushort RT3_TYPE_UNIVERSITÉ = 8200;

		// Token: 0x040007F5 RID: 2037
		public const ushort RT4_TYPE_UNIVERSITÉ = 257;

		// Token: 0x040007F6 RID: 2038
		public const ushort RT3_TYPE_ÉCOLE = 8211;

		// Token: 0x040007F7 RID: 2039
		public const ushort RT4_TYPE_ÉCOLE = 258;

		// Token: 0x040007F8 RID: 2040
		public const ushort RT3_TYPE_BIBLIOTHÈQUE = 8231;

		// Token: 0x040007F9 RID: 2041
		public const ushort RT4_TYPE_BIBLIOTHÈQUE = 337;

		// Token: 0x040007FA RID: 2042
		public const ushort RT3_TYPE_MUSÉE = 8410;

		// Token: 0x040007FB RID: 2043
		public const ushort RT4_TYPE_MUSÉE = 325;

		// Token: 0x040007FC RID: 2044
		public const ushort RT3_TYPE_CLUB_AUTOMOBILE = 8699;

		// Token: 0x040007FD RID: 2045
		public const ushort RT4_TYPE_CLUB_AUTOMOBILE = 342;

		// Token: 0x040007FE RID: 2046
		public const ushort RT3_TYPE_CONSEIL_GENERAL = 8700;

		// Token: 0x040007FF RID: 2047
		public const ushort RT4_TYPE_CONSEIL_GENERAL = 343;

		// Token: 0x04000800 RID: 2048
		public const ushort RT3_TYPE_PHARMACIE = 8701;

		// Token: 0x04000801 RID: 2049
		public const ushort RT4_TYPE_PHARMACIE = 344;

		// Token: 0x04000802 RID: 2050
		public const ushort RT3_TYPE_MAIRIE = 9121;

		// Token: 0x04000803 RID: 2051
		public const ushort RT4_TYPE_MAIRIE = 259;

		// Token: 0x04000804 RID: 2052
		public const ushort RT3_TYPE_PALAIS_JUSTICE = 9211;

		// Token: 0x04000805 RID: 2053
		public const ushort RT4_TYPE_PALAIS_JUSTICE = 331;

		// Token: 0x04000806 RID: 2054
		public const ushort RT3_FIRE_STATION = 9212;

		// Token: 0x04000807 RID: 2055
		public const ushort RT4_FIRE_STATION = 332;

		// Token: 0x04000808 RID: 2056
		public const ushort RT3_TYPE_COMMISSARIAT = 9221;

		// Token: 0x04000809 RID: 2057
		public const ushort RT4_TYPE_COMMISSARIAT = 333;

		// Token: 0x0400080A RID: 2058
		public const ushort RT3_TYPE_SERVICE_MEDICAL = 9583;

		// Token: 0x0400080B RID: 2059
		public const ushort RT4_TYPE_SERVICE_MEDICAL = 345;

		// Token: 0x0400080C RID: 2060
		public const ushort RT3_TYPE_ZONE_INDUST = 9991;

		// Token: 0x0400080D RID: 2061
		public const ushort RT4_TYPE_ZONE_INDUST = 256;

		// Token: 0x0400080E RID: 2062
		public const ushort RT3_TYPE_AMBASSADES = 9993;

		// Token: 0x0400080F RID: 2063
		public const ushort RT4_TYPE_AMBASSADES = 346;

		// Token: 0x04000810 RID: 2064
		public const ushort RT3_TYPE_BORGATE = 9998;

		// Token: 0x04000811 RID: 2065
		public const ushort RT4_TYPE_BORGATE = 340;

		// Token: 0x04000812 RID: 2066
		public const ushort RT3_TYPE_FRONTIÈRE = 9999;

		// Token: 0x04000813 RID: 2067
		public const ushort RT4_TYPE_FRONTIÈRE = 341;

		// Token: 0x04000814 RID: 2068
		public const ushort RT3_TYPE_LIBRAIRIE = 12288;

		// Token: 0x04000815 RID: 2069
		public const ushort RT4_TYPE_LIBRAIRIE = 347;

		// Token: 0x04000816 RID: 2070
		public const ushort RT3_TYPE_INTERCHANGE = 12289;

		// Token: 0x04000817 RID: 2071
		public const ushort RT4_TYPE_INTERCHANGE = 348;

		// Token: 0x04000818 RID: 2072
		public const ushort RT3_TYPE_BAR_OU_PUB = 12290;

		// Token: 0x04000819 RID: 2073
		public const ushort RT4_TYPE_BAR_OU_PUB = 349;

		// Token: 0x0400081A RID: 2074
		public const ushort RT3_TYPE_SALON_DE_THE = 12291;

		// Token: 0x0400081B RID: 2075
		public const ushort RT4_TYPE_SALON_DE_THE = 350;

		// Token: 0x0400081C RID: 2076
		public const ushort RT3_TYPE_MAISONS_HOTES = 12292;

		// Token: 0x0400081D RID: 2077
		public const ushort RT4_TYPE_MAISONS_HOTES = 351;

		// Token: 0x0400081E RID: 2078
		public const ushort RT3_TYPE_CAMPGROUND = 12293;

		// Token: 0x0400081F RID: 2079
		public const ushort RT4_TYPE_CAMPGROUND = 352;

		// Token: 0x04000820 RID: 2080
		public const ushort RT3_TYPE_RESTAURANT_CHAMPERARD = 22184;

		// Token: 0x04000821 RID: 2081
		public const ushort RT4_TYPE_RESTAURANT_CHAMPERARD = 16693;

		// Token: 0x04000822 RID: 2082
		private SortedDictionary<ushort, POITypeInfo.POITypInfos> POITypInfoDict;

		// Token: 0x04000823 RID: 2083
		private SortedDictionary<ushort, byte> POITypeHashDict;

		// Token: 0x04000824 RID: 2084
		private SortedDictionary<string, ushort> _POINameTypeDict;

		// Token: 0x04000825 RID: 2085
		private SortedDictionary<string, ushort> _POINameTypeDictWoNP;

		// Token: 0x04000826 RID: 2086
		private SortedDictionary<string, ushort> _POINameTypeDictNPOnly;

		// Token: 0x04000827 RID: 2087
		private SortedDictionary<string, ushort> _POINameTypeDictAlert;

		// Token: 0x04000828 RID: 2088
		private SortedDictionary<byte, string> _POINameScaleDict;

		// Token: 0x04000829 RID: 2089
		private SortedDictionary<byte, string> _POINameLayerDict;

		// Token: 0x0400082A RID: 2090
		private SortedDictionary<byte, string> _POIMagDict;

		// Token: 0x0400082B RID: 2091
		private List<ushort> _allDefinedTypes;

		// Token: 0x0400082C RID: 2092
		private SortedDictionary<ushort, ushort> _RT3Types2RT4Types;

		// Token: 0x0400082D RID: 2093
		private SortedDictionary<ushort, ushort> _RT4Types2RT3Types;

		// Token: 0x0400082E RID: 2094
		private Common.RTxMapEditorMapModes _RTxMapEditorMapMode;

		// Token: 0x0400082F RID: 2095
		private Common.RTxTypes _RTxType;

		// Token: 0x020000B2 RID: 178
		private class POITypInfos
		{
			// Token: 0x06000E06 RID: 3590 RVA: 0x0012B804 File Offset: 0x0012A804
			public POITypInfos(byte scale, byte layer, Image RT3image, Image RT4image, string name, POICategoryInfos.categories category, ushort RT4Type)
			{
				this.name = name;
				this.layer = layer;
				this.scale = scale;
				this.RT3image = RT3image;
				this.RT4image = RT4image;
				this.category = category;
				this.FRANCXXXDSTPtr = null;
				this.FRANCXXXDSCPtr = null;
				this.RT4Type = RT4Type;
			}

			// Token: 0x04000830 RID: 2096
			public string name;

			// Token: 0x04000831 RID: 2097
			public byte layer;

			// Token: 0x04000832 RID: 2098
			public byte scale;

			// Token: 0x04000833 RID: 2099
			public Image RT3image;

			// Token: 0x04000834 RID: 2100
			public Image RT4image;

			// Token: 0x04000835 RID: 2101
			public POICategoryInfos.categories category;

			// Token: 0x04000836 RID: 2102
			public FRANCXXXDST FRANCXXXDSTPtr;

			// Token: 0x04000837 RID: 2103
			public FRANCSCCDST FRANCSCCDSTPtr;

			// Token: 0x04000838 RID: 2104
			public FRANCXXXDSC FRANCXXXDSCPtr;

			// Token: 0x04000839 RID: 2105
			public ushort RT4Type;
		}
	}
}
