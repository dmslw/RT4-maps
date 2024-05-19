using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x0200005A RID: 90
	public class exportToRT3
	{
		// Token: 0x06000C64 RID: 3172 RVA: 0x00114744 File Offset: 0x00113744
		public exportToRT3(POILists POIList)
		{
			this._POIList = POIList;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00114758 File Offset: 0x00113758
		public bool exportToRT3Map(POICategoryInfos POIcategoryInfo, POITypeInfo POITypeInfo, ListOfPOILists completeList, Common.RTxMapType mapType, string countryMap)
		{
			bool result = true;
			bool displayRadarNeeded = false;
			MyProject.Application.Log.WriteEntry("exportToRT3.exportToRT3Map() begin", TraceEventType.Information);
			checked
			{
				try
				{
					try
					{
						foreach (POILists poilists in completeList)
						{
							bool flag = !poilists.fromRT3 && poilists.type == 4444;
							if (flag)
							{
								poilists.updatePOIName();
							}
							flag = (poilists.type == 1002 && poilists.POINumber > 0);
							if (flag)
							{
								displayRadarNeeded = true;
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
					MyProject.Application.Log.WriteEntry("exportToRT3.exportToRT3Map() step0", TraceEventType.Information);
					Application.DoEvents();
					buildSortedMapDicts buildSortedMapDicts = new buildSortedMapDicts(completeList, POITypeInfo, ref result);
					ToolStripProgressBar toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
					toolStripProgressBar.Value++;
					Application.DoEvents();
					MyProject.Application.Log.WriteEntry("exportToRT3.exportToRT3Map() step1", TraceEventType.Information);
					FRANC_NOMSERV_DAT franc_NOMSERV_DAT = new FRANC_NOMSERV_DAT(POIcategoryInfo.getMainPOIRT3File2Write("_NOMSERV.DAT"), FRANC_NOMSERV_DAT.mode.write);
					Application.DoEvents();
					franc_NOMSERV_DAT.writeToFile(buildSortedMapDicts);
					toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
					toolStripProgressBar.Value++;
					Application.DoEvents();
					buildSortedMapDicts.alphabeticDict = null;
					MyProject.Application.Log.WriteEntry("exportToRT3.exportToRT3Map() step02", TraceEventType.Information);
					buildSortedMapDicts.buildPlaneGeoDict(completeList);
					Application.DoEvents();
					this.rebuildPlaneCoordRT3Files(POIcategoryInfo, POITypeInfo, buildSortedMapDicts, mapType, countryMap, displayRadarNeeded);
					toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
					toolStripProgressBar.Value++;
					Application.DoEvents();
					buildSortedMapDicts.planeCoordDict = null;
					MyProject.Application.Log.WriteEntry("exportToRT3.exportToRT3Map() step3", TraceEventType.Information);
					this.rebuildGeoCoordRT3Files(POIcategoryInfo, POITypeInfo, buildSortedMapDicts, mapType, countryMap);
					toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
					toolStripProgressBar.Value++;
					Application.DoEvents();
					buildSortedMapDicts.geoCoordDict = null;
					MyProject.Application.Log.WriteEntry("exportToRT3.exportToRT3Map() step4", TraceEventType.Information);
				}
				catch (EndOfStreamException ex)
				{
					result = false;
					MyProject.Application.Log.WriteEntry(ex.Message);
					MyProject.Application.Log.WriteEntry(ex.StackTrace);
					Interaction.MsgBox(Resources.strErrUnexEOF + "\r\n" + Resources.strErrPatchAborted, MsgBoxStyle.Critical, null);
				}
				catch (Exception ex2)
				{
					result = false;
					MyProject.Application.Log.WriteEntry(ex2.Message);
					MyProject.Application.Log.WriteEntry(ex2.StackTrace);
					Interaction.MsgBox(ex2.Message + "\r\n" + Resources.strErrPatchAborted, MsgBoxStyle.Critical, null);
				}
				finally
				{
				}
				MyProject.Application.Log.WriteEntry("exportToRT3.exportToRT3Map() end", TraceEventType.Information);
				return result;
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00114ADC File Offset: 0x00113ADC
		private void rebuildPlaneCoordRT3Files(POICategoryInfos POIcategoryInfo, POITypeInfo POITypeInfo, buildSortedMapDicts sortedDicts, Common.RTxMapType mapType, string countryMap, bool displayRadarNeeded)
		{
			FRANCPOI_DAT francpoi_DAT = null;
			FRANCXXXDST francxxxdst = null;
			FRANCXXXDST francxxxdst2 = null;
			FRANCXXXDST francxxxdst3 = null;
			FRANCXXXDST francxxxdst4 = null;
			FRANCXXXDST francxxxdst5 = null;
			FRANCXXXDST francxxxdst6 = null;
			FRANCXXXDST francxxxdst7 = null;
			FRANCXXXDST francxxxdst8 = null;
			FRANCSCCDST francsccdst = null;
			FRANCSCCIMP francsccimp = null;
			FRANCDSP_POI francdsp_POI = null;
			FRANCDPA_LZW francdpa_LZW = null;
			FRANC_EX_DMR franc_EX_DMR = null;
			GRUPPODAT gruppodat = null;
			GUIDA_CHAMPERARD_POI guida_CHAMPERARD_POI = null;
			try
			{
				string fileEnd = null;
				francpoi_DAT = new FRANCPOI_DAT(POIcategoryInfo.getMainPOIRT3File2Write("POI.DAT"), FRANCPOI_DAT.mode.write, mapType);
				francxxxdst = new FRANCXXXDST(POIcategoryInfo.getDSTRT3File2Write(POICategoryInfos.categories.CAT_MIN), FRANCXXXDST.mode.write, mapType);
				francxxxdst2 = new FRANCXXXDST(POIcategoryInfo.getDSTRT3File2Write(POICategoryInfos.categories.CAT_SAF), FRANCXXXDST.mode.write, mapType);
				francxxxdst3 = new FRANCXXXDST(POIcategoryInfo.getDSTRT3File2Write(POICategoryInfos.categories.CAT_SHR), FRANCXXXDST.mode.write, mapType);
				francxxxdst4 = new FRANCXXXDST(POIcategoryInfo.getDSTRT3File2Write(POICategoryInfos.categories.CAT_STU), FRANCXXXDST.mode.write, mapType);
				francxxxdst5 = new FRANCXXXDST(POIcategoryInfo.getDSTRT3File2Write(POICategoryInfos.categories.CAT_SSH), FRANCXXXDST.mode.write, mapType);
				francxxxdst6 = new FRANCXXXDST(POIcategoryInfo.getDSTRT3File2Write(POICategoryInfos.categories.CAT_SSP), FRANCXXXDST.mode.write, mapType);
				francxxxdst7 = new FRANCXXXDST(POIcategoryInfo.getDSTRT3File2Write(POICategoryInfos.categories.CAT_STR), FRANCXXXDST.mode.write, mapType);
				francxxxdst8 = new FRANCXXXDST(POIcategoryInfo.getDSTRT3File2Write(POICategoryInfos.categories.CAT_SAU), FRANCXXXDST.mode.write, mapType);
				francsccdst = new FRANCSCCDST(POIcategoryInfo.getDSTRT3File2Write(POICategoryInfos.categories.CAT_SCC), FRANCSCCDST.mode.write, mapType);
				francsccimp = new FRANCSCCIMP(POIcategoryInfo.getIMPRT3File2Write(POICategoryInfos.categories.CAT_SCC), FRANCSCCIMP.mode.write, mapType);
				POITypeInfo.setFRANCXXXDSTPtr(francxxxdst, francxxxdst2, francxxxdst3, francxxxdst4, francxxxdst5, francxxxdst6, francxxxdst7, francxxxdst8, francsccdst);
				francdsp_POI = new FRANCDSP_POI(POIcategoryInfo.getMainPOIRT3File2Write("DSP.POI"), FRANCDSP_POI.mode.write, mapType);
				francdpa_LZW = new FRANCDPA_LZW(POIcategoryInfo.getMainPOIRT3File2Read("DPA.LZW"), POIcategoryInfo.getMainPOIRT3File2Write("DPA.LZW"), MyProject.Forms.FormMain.mapMngt.FRANC_EX_DPS);
				bool flag = mapType == Common.RTxMapType.RT3;
				string fileEnd2;
				if (flag)
				{
					fileEnd2 = "GRUPPO_2.DAT";
					fileEnd = "GRUPPO_2_DAT";
				}
				else
				{
					fileEnd2 = "GRUPPO_4_CID.DAT";
					fileEnd = "GRUPPO_4_CID_DAT";
				}
				gruppodat = new GRUPPODAT(GRUPPODAT.mode.write, POIcategoryInfo.getMainPOIRT3File2Write(fileEnd2), Path.Combine(MySettingsProperty.Settings.WorkingDir, "map.ini"), Path.Combine(MySettingsProperty.Settings.WorkingDir, "dest"), countryMap);
				gruppodat.copyGruppoDir(POIcategoryInfo.getMainPOIRT3File2Read(fileEnd), POIcategoryInfo.getMainPOIRT3File2Write(fileEnd));
				if (displayRadarNeeded)
				{
					bool flag2 = !(MySettingsProperty.Settings.forceRadarDisplay | gruppodat.getRadarDisplay());
					if (flag2)
					{
						bool flag3 = Interaction.MsgBox(Resources.strWarningDisplayRadar + "\r\n\r\n" + Resources.strAskDisplayRadar, MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes;
						if (flag3)
						{
							MySettingsProperty.Settings.forceRadarDisplay = true;
						}
					}
					gruppodat.setRadarDisplay(MySettingsProperty.Settings.forceRadarDisplay);
				}
				franc_EX_DMR = new FRANC_EX_DMR(POIcategoryInfo.getMainPOIRT3File2Write("EX.DMR"), FRANC_EX_DMR.mode.write, mapType, MyProject.Forms.FormMain.mapMngt.LSNb);
				guida_CHAMPERARD_POI = new GUIDA_CHAMPERARD_POI(POIcategoryInfo.getMainPOIRT3File2Write("GUIDA_CHAMPERARD.POI"), GUIDA_CHAMPERARD_POI.mode.write);
				POIDatas poidatas = null;
				SortedDictionary<buildSortedMapDicts.key128bits, POIDatas>.KeyCollection keys = sortedDicts.planeCoordDict.Keys;
				uint num = 0U;
				ushort num2 = 0;
				POIcategoryInfo.initNbIdxPOIDSTPerCategory();
				ushort num3 = 0;
				byte b = 0;
				byte b2 = 0;
				try
				{
					foreach (buildSortedMapDicts.key128bits key in keys)
					{
						poidatas = sortedDicts.planeCoordDict[key];
						POIDatas poidatas2 = poidatas;
						if (b2 != poidatas2.SS || b != poidatas2.MS)
						{
							goto IL_2E8;
						}
						if (num3 != poidatas2.LS)
						{
							goto IL_2E8;
						}
						bool flag4 = false;
						IL_2E9:
						bool flag3 = flag4;
						checked
						{
							if (flag3)
							{
								francdpa_LZW.update(poidatas2.LS, poidatas2.MS, poidatas2.SS, num, num2);
								flag3 = (num3 != poidatas2.LS);
								if (flag3)
								{
									franc_EX_DMR.updateRecord(num3, POIcategoryInfo);
									POIcategoryInfo.initNbPOIDSTPerCategory();
								}
								b = poidatas2.MS;
								num3 = poidatas2.LS;
								b2 = poidatas2.SS;
								num += (uint)num2;
								num2 = 0;
							}
							flag3 = (poidatas2.type != 4444);
							if (flag3)
							{
								francpoi_DAT.writeRecord(poidatas);
								flag3 = (poidatas2.type == 22184 && poidatas2.commentRT3 != null);
								if (flag3)
								{
									guida_CHAMPERARD_POI.addRecord(poidatas);
								}
							}
							bool flag5 = poidatas2.LS == 111 && poidatas2.MS == 133 && poidatas2.SS == 137 && poidatas2.type == 4444 && poidatas2.X == 690 && poidatas2.Y == 675 && poidatas2.magnitude == 3;
							flag3 = !flag5;
							if (flag3)
							{
								francdsp_POI.writeRecord(poidatas);
							}
							flag3 = poidatas2.isPlaneCoordSearchable;
							if (flag3)
							{
								bool flag2 = poidatas2.type == 4444;
								if (flag2)
								{
									francsccdst.writeRecord(poidatas);
									flag3 = (poidatas2.magnitude >= 4);
									if (flag3)
									{
										francsccimp.storeRecord(poidatas);
									}
								}
								else
								{
									POITypeInfo.getFRANCXXXDSTPtr(poidatas2.type).writeRecord(poidatas);
								}
								POIcategoryInfo.incNbPOIDSTPerCategory(POITypeInfo.getCategoryOfType(poidatas2.type));
							}
							flag3 = !flag5;
						}
						if (flag3)
						{
							num2 += 1;
						}
						continue;
						IL_2E8:
						flag4 = true;
						goto IL_2E9;
					}
				}
				finally
				{
					SortedDictionary<buildSortedMapDicts.key128bits, POIDatas>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				francdpa_LZW.update(poidatas.LS, poidatas.MS, poidatas.SS, num, num2);
				francdpa_LZW.copyUntilEnd();
				francdpa_LZW.close(true);
				franc_EX_DMR.updateRecord(num3, POIcategoryInfo);
				franc_EX_DMR.close();
				guida_CHAMPERARD_POI.writeToFile();
				guida_CHAMPERARD_POI.close();
				francpoi_DAT.close();
				francxxxdst.close();
				francxxxdst2.close();
				francxxxdst3.close();
				francxxxdst4.close();
				francxxxdst5.close();
				francxxxdst6.close();
				francxxxdst7.close();
				francxxxdst8.close();
				francsccdst.close();
				francsccimp.writeFile();
				francsccimp.close();
				francdsp_POI.close();
				gruppodat.buildFile(POIcategoryInfo.getMainPOIRT3File2Write(fileEnd));
				gruppodat.close();
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteEntry(ex.Message);
				MyProject.Application.Log.WriteEntry(ex.StackTrace);
				francpoi_DAT.close();
				francxxxdst.close();
				francxxxdst2.close();
				francxxxdst3.close();
				francxxxdst4.close();
				francxxxdst5.close();
				francxxxdst6.close();
				francxxxdst7.close();
				francxxxdst8.close();
				francsccdst.close();
				francsccimp.close();
				francdsp_POI.close();
				franc_EX_DMR.close();
				gruppodat.close();
				francdpa_LZW.close(false);
				guida_CHAMPERARD_POI.close();
				throw ex;
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00115180 File Offset: 0x00114180
		private void rebuildGeoCoordRT3Files(POICategoryInfos POIcategoryInfo, POITypeInfo POITypeInfo, buildSortedMapDicts sortedDicts, Common.RTxMapType mapType, string countryMap)
		{
			FRANCXXXDSC francxxxdsc = null;
			FRANCXXXDSC francxxxdsc2 = null;
			FRANCXXXDSC francxxxdsc3 = null;
			FRANCXXXDSC francxxxdsc4 = null;
			FRANCXXXDSC francxxxdsc5 = null;
			FRANCXXXDSC francxxxdsc6 = null;
			FRANCXXXDSC francxxxdsc7 = null;
			FRANCXXXDSC francxxxdsc8 = null;
			ZZZCOM_IND zzzcom_IND = null;
			checked
			{
				try
				{
					string text = Path.Combine(MySettingsProperty.Settings.WorkingDir, "dest");
					string path = Path.Combine(MySettingsProperty.Settings.WorkingDir, "orig");
					Dictionary<string, byte> dictionary = new Dictionary<string, byte>();
					string path2 = Path.Combine(MySettingsProperty.Settings.WorkingDir, "ZZZCOM.IND.lst");
					StreamReader streamReader = new StreamReader(path2);
					string text2 = streamReader.ReadLine();
					while (Operators.CompareString(text2, null, false) != 0)
					{
						dictionary.Add(text2, 0);
						text2 = streamReader.ReadLine();
					}
					francxxxdsc = new FRANCXXXDSC(POIcategoryInfo.getDSCRT3File2Write(POICategoryInfos.categories.CAT_MIN), FRANCXXXDSC.mode.write, mapType);
					francxxxdsc2 = new FRANCXXXDSC(POIcategoryInfo.getDSCRT3File2Write(POICategoryInfos.categories.CAT_SAF), FRANCXXXDSC.mode.write, mapType);
					francxxxdsc3 = new FRANCXXXDSC(POIcategoryInfo.getDSCRT3File2Write(POICategoryInfos.categories.CAT_SHR), FRANCXXXDSC.mode.write, mapType);
					francxxxdsc4 = new FRANCXXXDSC(POIcategoryInfo.getDSCRT3File2Write(POICategoryInfos.categories.CAT_STU), FRANCXXXDSC.mode.write, mapType);
					francxxxdsc5 = new FRANCXXXDSC(POIcategoryInfo.getDSCRT3File2Write(POICategoryInfos.categories.CAT_SSH), FRANCXXXDSC.mode.write, mapType);
					francxxxdsc6 = new FRANCXXXDSC(POIcategoryInfo.getDSCRT3File2Write(POICategoryInfos.categories.CAT_SSP), FRANCXXXDSC.mode.write, mapType);
					francxxxdsc7 = new FRANCXXXDSC(POIcategoryInfo.getDSCRT3File2Write(POICategoryInfos.categories.CAT_STR), FRANCXXXDSC.mode.write, mapType);
					francxxxdsc8 = new FRANCXXXDSC(POIcategoryInfo.getDSCRT3File2Write(POICategoryInfos.categories.CAT_SAU), FRANCXXXDSC.mode.write, mapType);
					POITypeInfo.setFRANCXXXDSCPtr(francxxxdsc, francxxxdsc2, francxxxdsc3, francxxxdsc4, francxxxdsc5, francxxxdsc6, francxxxdsc7, francxxxdsc8);
					POIcategoryInfo.initNbIdxPOIDSCPerCategory();
					byte b = byte.MaxValue;
					byte b2 = byte.MaxValue;
					byte b3 = byte.MaxValue;
					ushort num = ushort.MaxValue;
					ushort num2 = ushort.MaxValue;
					ZZZCOM_IND.FrancZZZComIndRecords francZZZComIndRecords = null;
					SortedDictionary<buildSortedMapDicts.key128bits, POIDatas>.KeyCollection keys = sortedDicts.geoCoordDict.Keys;
					bool flag6;
					try
					{
						foreach (buildSortedMapDicts.key128bits key128bits in keys)
						{
							POIDatas poidatas = sortedDicts.geoCoordDict[key128bits];
							byte index = (byte)((key128bits.KeyLow & unchecked((ulong)-16777216)) >> 24);
							byte b4 = (byte)((key128bits.KeyLow & 16711680UL) >> 16);
							bool flag = b4 == byte.MaxValue;
							POIDatas.POIAlias poialias;
							if (flag)
							{
								poialias = poidatas.listOfCanonical[(int)index];
							}
							else
							{
								poialias = poidatas.listOfAlternates[(int)b4];
							}
							POIDatas.POIAlias poialias2 = poialias;
							flag = (poidatas.type != 4444 && poidatas.isGeoCoordSearchable);
							if (flag)
							{
								if (b3 != poialias2.dpt || b2 != poialias2.area)
								{
									goto IL_254;
								}
								if (b != poialias2.country)
								{
									goto IL_254;
								}
								bool flag2 = false;
								IL_255:
								bool flag3 = flag2;
								bool flag4 = flag3 || num != poialias2.city;
								flag = (flag4 || num2 != poialias2.district);
								if (flag)
								{
									bool flag5 = zzzcom_IND != null;
									if (flag5)
									{
										flag6 = (francZZZComIndRecords != null && flag4);
										if (flag6)
										{
											francZZZComIndRecords = zzzcom_IND.updateFFFFDistrict(francZZZComIndRecords, POIcategoryInfo);
										}
										francZZZComIndRecords = zzzcom_IND.updateRecord(num, num2, flag4, POIcategoryInfo);
										flag6 = (francZZZComIndRecords != null && flag4);
										if (flag6)
										{
											francZZZComIndRecords = zzzcom_IND.updateFFFFDistrict(francZZZComIndRecords, POIcategoryInfo);
										}
									}
									POIcategoryInfo.initNbPOIDSCPerCategory(flag4);
									num = poialias2.city;
									num2 = poialias2.district;
									flag6 = flag3;
									if (flag6)
									{
										flag5 = (zzzcom_IND != null);
										if (flag5)
										{
											zzzcom_IND.writeToFile();
											zzzcom_IND = null;
										}
										flag6 = dictionary.ContainsKey(ZZZCOM_IND.getShortFileName(poialias2.country, poialias2.area, poialias2.dpt, mapType, countryMap));
										if (flag6)
										{
											zzzcom_IND = new ZZZCOM_IND(text, poialias2.country, poialias2.area, poialias2.dpt, mapType, countryMap, ZZZCOM_IND.mode.write);
											string key = zzzcom_IND.loadFromFile();
											dictionary.Remove(key);
										}
										else
										{
											zzzcom_IND = null;
											MyProject.Application.Log.WriteEntry(string.Format("RT3 map error: country {0:X}, area {1:X}, dpt {2:X}, city {3:X} referenced in the map without {4:X} file.", new object[]
											{
												poialias2.country,
												poialias2.area,
												poialias2.dpt,
												poialias2.city,
												ZZZCOM_IND.getShortFileName(poialias2.country, poialias2.area, poialias2.dpt, mapType, countryMap)
											}));
										}
										b = poialias2.country;
										b2 = poialias2.area;
										b3 = poialias2.dpt;
									}
								}
								POIcategoryInfo.incIdxPOIDSCPerCategory(POITypeInfo.getCategoryOfType(poidatas.type));
								POITypeInfo.getFRANCXXXDSCPtr(poidatas.type).writeRecord(poidatas, key128bits);
								continue;
								IL_254:
								flag2 = true;
								goto IL_255;
							}
						}
					}
					finally
					{
						SortedDictionary<buildSortedMapDicts.key128bits, POIDatas>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					flag6 = (zzzcom_IND != null);
					if (flag6)
					{
						zzzcom_IND.writeToFile();
						zzzcom_IND = null;
					}
					Dictionary<string, byte>.KeyCollection keys2 = dictionary.Keys;
					try
					{
						foreach (string path3 in keys2)
						{
							text2 = Path.Combine(text, path3);
							flag6 = MyProject.Computer.FileSystem.FileExists(text2);
							if (flag6)
							{
								MyProject.Computer.FileSystem.DeleteFile(text2);
							}
							MyProject.Computer.FileSystem.CopyFile(Path.Combine(path, path3), text2);
						}
					}
					finally
					{
						Dictionary<string, byte>.KeyCollection.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				catch (Exception ex)
				{
					MyProject.Application.Log.WriteEntry(ex.Message);
					MyProject.Application.Log.WriteEntry(ex.StackTrace);
					throw ex;
				}
				finally
				{
					francxxxdsc.close();
					francxxxdsc2.close();
					francxxxdsc3.close();
					francxxxdsc4.close();
					francxxxdsc5.close();
					francxxxdsc6.close();
					francxxxdsc7.close();
					francxxxdsc8.close();
				}
			}
		}

		// Token: 0x0400048F RID: 1167
		private POILists _POIList;
	}
}
