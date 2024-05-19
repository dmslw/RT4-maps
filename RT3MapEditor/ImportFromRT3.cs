using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x0200005F RID: 95
	public class ImportFromRT3
	{
		// Token: 0x06000C8D RID: 3213 RVA: 0x00118C54 File Offset: 0x00117C54
		public ImportFromRT3(POILists POIList)
		{
			this._POIList = POIList;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00118C68 File Offset: 0x00117C68
		public List<POILists> importFromRT3Map(POICategoryInfos POIcategoryInfo, POITypeInfo POITypeInfo, commonFiles commonFiles, Common.RTxMapType mapType)
		{
			Dictionary<ushort, POILists> dictionary = null;
			POIDatas poidatas = null;
			List<POILists> list = new List<POILists>();
			SortedDictionary<uint, POIDatas> poidict = new SortedDictionary<uint, POIDatas>();
			POILists poilists = null;
			checked
			{
				try
				{
					POICategoryInfos.categories categories = POICategoryInfos.categories.CAT_MIN;
					ToolStripProgressBar toolStripProgressBar;
					byte b;
					byte b2;
					do
					{
						bool flag = categories == POICategoryInfos.categories.CAT_SCC;
						if (flag)
						{
							this.loadFromSCCDST(POIcategoryInfo, POITypeInfo, ref poidatas, ref poilists, mapType);
							toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
							toolStripProgressBar.Value++;
							Application.DoEvents();
							flag = (poilists.POINumber > 0);
							if (flag)
							{
								poilists._state = POILists.state.original;
								poilists.name = POITypeInfo.getNameOfType(4444);
								poilists.type = 4444;
								poilists.isReadOnly = false;
								poilists.noDelete = true;
								list.Add(poilists);
							}
						}
						else
						{
							this.loadFromXXXDSC(POIcategoryInfo, categories, poidict, commonFiles, ref poidatas, ref dictionary, mapType);
							toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
							toolStripProgressBar.Value++;
							Application.DoEvents();
							this.loadFromXXXDST(POIcategoryInfo, categories, poidict, commonFiles, ref poidatas, ref dictionary, mapType);
							toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
							toolStripProgressBar.Value++;
							Application.DoEvents();
							try
							{
								foreach (ushort num in dictionary.Keys)
								{
									flag = (dictionary[num].POINumber > 0);
									if (flag)
									{
										dictionary[num]._state = POILists.state.original;
										dictionary[num].name = POITypeInfo.getNameOfType(num);
										dictionary[num].type = num;
										dictionary[num].isReadOnly = false;
										dictionary[num].noDelete = false;
										list.Add(dictionary[num]);
									}
								}
							}
							finally
							{
								Dictionary<ushort, POILists>.KeyCollection.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						unchecked
						{
							categories += 1;
							b = (byte)categories;
							b2 = 9;
						}
					}
					while (b <= b2);
					this.loadFromDSPPOI(POIcategoryInfo, commonFiles, poidict, ref poidatas, list, POITypeInfo, mapType);
					toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
					toolStripProgressBar.Value++;
					Application.DoEvents();
					commonFiles.francNomservDat.unusedlRecords();
					toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
					toolStripProgressBar.Value++;
					Application.DoEvents();
				}
				catch (KeyNotFoundException ex)
				{
					list = null;
					bool flag = poidatas != null;
					if (flag)
					{
						POICategoryInfos.categories categories;
						MyProject.Application.Log.WriteEntry(string.Format(Resources.strErrUnkTypeInCat, poidatas.type, categories));
						MyProject.Application.Log.WriteEntry(ex.StackTrace);
						Interaction.MsgBox(string.Format(Resources.strErrUnkTypeInCat, poidatas.type, categories), MsgBoxStyle.Critical, null);
					}
					else
					{
						POICategoryInfos.categories categories;
						MyProject.Application.Log.WriteEntry(string.Format(Resources.strErrUnkTypeInCat, 65535, categories));
						MyProject.Application.Log.WriteEntry(ex.StackTrace);
						Interaction.MsgBox(string.Format(Resources.strErrUnkTypeInCat, 65535, categories), MsgBoxStyle.Critical, null);
					}
				}
				catch (Exception ex2)
				{
					list = null;
					bool flag = poidatas != null;
					if (flag)
					{
						POICategoryInfos.categories categories;
						MyProject.Application.Log.WriteEntry(string.Format("Exception: category: {0:G}, type: {1:X}, message: {2:G}", categories, poidatas.type, ex2.Message));
						MyProject.Application.Log.WriteEntry(ex2.StackTrace);
						Interaction.MsgBox(string.Format("Exception: category: {0:G}, type: {1:X}, message: {2:G}", categories, poidatas.type, ex2.Message), MsgBoxStyle.Critical, null);
					}
					else
					{
						POICategoryInfos.categories categories;
						MyProject.Application.Log.WriteEntry(string.Format("Exception: category: {0:G}, message: {1:G}", categories, ex2.Message));
						MyProject.Application.Log.WriteEntry(ex2.StackTrace);
						Interaction.MsgBox(string.Format("Exception: category: {0:G}, message: {1:G}", categories, ex2.Message), MsgBoxStyle.Critical, null);
					}
				}
				return list;
			}
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00119118 File Offset: 0x00118118
		private void loadFromSCCDST(POICategoryInfos POIcategoryInfo, POITypeInfo POITypeInfo, ref POIDatas POIData, ref POILists SCCPOIList, Common.RTxMapType mapType)
		{
			string categoryName = POICategoryInfos.getCategoryName(POICategoryInfos.categories.CAT_SCC);
			int num = 0;
			int num2 = 0;
			POIDatas.categoryName = categoryName;
			SCCPOIList = POIcategoryInfo.getPOIListDict(POICategoryInfos.categories.CAT_SCC)[4444];
			FRANCSCCDST francsccdst = new FRANCSCCDST(POIcategoryInfo.getDSTRT3File2Read(POICategoryInfos.categories.CAT_SCC), FRANCSCCDST.mode.read, mapType);
			checked
			{
				for (FRANCSCCDST.FrancSCCDSTDatItems nextRecord = francsccdst.getNextRecord(); nextRecord != null; nextRecord = francsccdst.getNextRecord())
				{
					POIData = new POIDatas();
					POIData.initByRT3values(nextRecord);
					bool flag = !POIData.toSkip;
					if (flag)
					{
						SCCPOIList.ListofPOI.Add(POIData);
						num++;
					}
					else
					{
						num2++;
					}
				}
				francsccdst.close();
				MyProject.Application.Log.WriteEntry(string.Format("{0:G} records read, {1:G} records skipped in category {2:G} (.DST file)", num, num2, categoryName));
			}
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x001191F0 File Offset: 0x001181F0
		private void loadFromXXXDSC(POICategoryInfos POIcategoryInfo, POICategoryInfos.categories category, SortedDictionary<uint, POIDatas> POIDict, commonFiles commonFiles, ref POIDatas POIData, ref Dictionary<ushort, POILists> POIListDicts, Common.RTxMapType mapType)
		{
			string categoryName = POICategoryInfos.getCategoryName(category);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			POIDatas.categoryName = categoryName;
			POIListDicts = POIcategoryInfo.getPOIListDict(category);
			FRANCXXXDSC francxxxdsc = new FRANCXXXDSC(POIcategoryInfo.getDSCRT3File2Read(category), FRANCXXXDSC.mode.read, mapType);
			checked
			{
				for (FRANCXXXDSC.FrancDSCDatItems nextRecord = francxxxdsc.getNextRecord(); nextRecord != null; nextRecord = francxxxdsc.getNextRecord())
				{
					bool flag = !POIDict.ContainsKey(nextRecord.FrancPOIPtr);
					if (flag)
					{
						POIData = new POIDatas();
						POIData.initByRT3values(nextRecord, commonFiles);
						flag = !POIData.toSkip;
						if (flag)
						{
							POIDict.Add(nextRecord.FrancPOIPtr, POIData);
							POIListDicts[POIData.type].ListofPOI.Add(POIData);
							num++;
						}
						else
						{
							num3++;
						}
					}
					else
					{
						POIDict[nextRecord.FrancPOIPtr].addAlias(nextRecord, commonFiles);
						num2++;
					}
				}
				francxxxdsc.close();
				MyProject.Application.Log.WriteEntry(string.Format("{0:G} records read, {1:G} alias, read, {2:G} records skipped in category {3:G} (.DSC file)", new object[]
				{
					num,
					num2,
					num3,
					categoryName
				}));
			}
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00119340 File Offset: 0x00118340
		private void loadFromXXXDST(POICategoryInfos POIcategoryInfo, POICategoryInfos.categories category, SortedDictionary<uint, POIDatas> POIDict, commonFiles commonFiles, ref POIDatas POIData, ref Dictionary<ushort, POILists> POIListDicts, Common.RTxMapType mapType)
		{
			string categoryName = POICategoryInfos.getCategoryName(category);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			POIDatas.categoryName = categoryName;
			POIListDicts = POIcategoryInfo.getPOIListDict(category);
			FRANCXXXDST francxxxdst = new FRANCXXXDST(POIcategoryInfo.getDSTRT3File2Read(category), FRANCXXXDST.mode.read, mapType);
			checked
			{
				bool flag;
				for (FRANCXXXDST.FrancDSTDatItems nextRecord = francxxxdst.getNextRecord(); nextRecord != null; nextRecord = francxxxdst.getNextRecord())
				{
					flag = !POIDict.ContainsKey(nextRecord.FrancPOIPtr);
					if (flag)
					{
						POIData = new POIDatas();
						POIData.initByRT3values(nextRecord, commonFiles);
						flag = !POIData.toSkip;
						if (flag)
						{
							num++;
							POIDict.Add(nextRecord.FrancPOIPtr, POIData);
							POIListDicts[POIData.type].ListofPOI.Add(POIData);
						}
						else
						{
							num3++;
						}
					}
					else
					{
						POIDict[nextRecord.FrancPOIPtr].isPlaneCoordSearchable = true;
						num2++;
					}
				}
				flag = (num != 0);
				if (flag)
				{
					MyProject.Application.Log.WriteEntry(string.Format("RT3 map error: {0:G} records read, {1:G} alias, read, {2:G} records skipped in category {3:G} (.DST file)", new object[]
					{
						num,
						num2,
						num3,
						categoryName
					}));
				}
				else
				{
					MyProject.Application.Log.WriteEntry(string.Format("{0:G} records read, {1:G} alias, read, {2:G} records skipped in category {3:G} (.DST file)", new object[]
					{
						num,
						num2,
						num3,
						categoryName
					}));
				}
				francxxxdst.close();
			}
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x001194EC File Offset: 0x001184EC
		private void loadFromDSPPOI(POICategoryInfos POIcategoryInfo, commonFiles commonFiles, SortedDictionary<uint, POIDatas> POIDict, ref POIDatas POIData, List<POILists> list2return, POITypeInfo POITypeInfo, Common.RTxMapType mapType)
		{
			FRANCDSP_POI francdsp_POI = new FRANCDSP_POI(POIcategoryInfo.getMainPOIRT3File2Read("DSP.POI"), FRANCDSP_POI.mode.read, mapType);
			List<uint> orphanPOIList = francdsp_POI.getOrphanPOIList(POIDict);
			Dictionary<ushort, POILists> allPOIListDict = POIcategoryInfo.getAllPOIListDict();
			bool flag = orphanPOIList.Count > 0;
			checked
			{
				if (flag)
				{
					MyProject.Application.Log.WriteEntry(string.Format("RT3 map error in FRANCDSP.POI:  {0:G} orphan records", orphanPOIList.Count));
					int num = 0;
					int num2 = orphanPOIList.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						POIData = new POIDatas();
						POIData.initByRT3values(commonFiles.francPOIDat.getRecordByRT3Ptr(orphanPOIList[num3]), commonFiles);
						flag = !POIDict.ContainsKey(orphanPOIList[num3]);
						if (flag)
						{
							bool flag2 = !POIData.toSkip;
							if (flag2)
							{
								POIDict.Add(orphanPOIList[num3], POIData);
								flag2 = (allPOIListDict[POIData.type].POINumber == 0);
								if (flag2)
								{
									allPOIListDict[POIData.type]._state = POILists.state.original;
									allPOIListDict[POIData.type].name = POITypeInfo.getNameOfType(POIData.type);
									allPOIListDict[POIData.type].type = POIData.type;
									allPOIListDict[POIData.type].isReadOnly = false;
									allPOIListDict[POIData.type].noDelete = false;
									list2return.Add(allPOIListDict[POIData.type]);
								}
								allPOIListDict[POIData.type].ListofPOI.Add(POIData);
								int num6;
								num6++;
							}
						}
						else
						{
							MyProject.Application.Log.WriteEntry(string.Format("RT3 map error in FRANCDSP.POI: duplicate reference to FRANCPOI.DAT {0:X}. Record skipped", orphanPOIList[num3]));
						}
						num3++;
					}
				}
			}
		}

		// Token: 0x040004AF RID: 1199
		private POILists _POIList;
	}
}
