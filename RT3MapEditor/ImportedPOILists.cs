using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x0200005B RID: 91
	public class ImportedPOILists
	{
		// Token: 0x06000C68 RID: 3176 RVA: 0x001157A0 File Offset: 0x001147A0
		public ImportedPOILists()
		{
			this.completeList = new ListOfPOILists();
			this.deletedList = new ListOfPOILists();
			this.currentIdx = -1;
			this.totalPOINumber_s = 0;
			this._modified = true;
			this.warnDial = null;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x001157E0 File Offset: 0x001147E0
		public POILists importFromFiles(string[] fileNames, bool allwaysload)
		{
			POILists poilists = null;
			STArchives starchives = null;
			bool flag = fileNames.Length == 1 & Operators.CompareString(Path.GetFileName(fileNames[0]), "google_earth_scdb.kmz", false) == 0;
			if (flag)
			{
				bool flag2 = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map;
				STArchives.ArchImportMode supportedModes;
				if (flag2)
				{
					supportedModes = (STArchives.ArchImportMode)1036U;
				}
				else
				{
					supportedModes = STArchives.ArchImportMode.AllRFIcon;
				}
				flag2 = (MyProject.Forms.ConfigDialog.ShowDialog((ConfigDialog.tabList)12U, ConfigDialog.tabList.STImport, supportedModes, true, true) == DialogResult.OK);
				if (flag2)
				{
					poilists = new POILists(false, false);
					List<POILists> list = poilists.importFromScdb(fileNames[0]);
					flag2 = (list != null);
					if (flag2)
					{
						MyProject.Forms.FormMain.ImportedFilesListBox.BeginUpdate();
						try
						{
							foreach (POILists poilists2 in list)
							{
								this.completeList.Add(poilists2);
								this._modified = true;
								poilists2.getPOINameType();
							}
						}
						finally
						{
							List<POILists>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						MyProject.Forms.FormMain.ImportedFilesListBox.EndUpdate();
						this.updateTotalPOINumber();
					}
				}
			}
			else
			{
				bool flag2 = fileNames.Length == 1 & Operators.CompareString(Path.GetExtension(fileNames[0]).ToLower(), ".zip", false) == 0;
				if (flag2)
				{
					starchives = new STArchives(fileNames[0]);
					flag2 = (starchives.archiveType != STArchives.STArchiveType.ArcUnknown);
					if (flag2)
					{
						bool fixedOnly = Path.GetFileName(fileNames[0]).StartsWith("WR_RF_7_");
						bool rfr = !Path.GetFileName(fileNames[0]).StartsWith("WR_RF_7_");
						STArchives.ArchImportMode supportedModes = starchives.supportedModes;
						flag2 = (MyProject.Forms.ConfigDialog.ShowDialog((ConfigDialog.tabList)12U, ConfigDialog.tabList.STImport, supportedModes, fixedOnly, rfr) == DialogResult.OK);
						if (flag2)
						{
							MyProject.Forms.FormMain.ImportedFilesListBox.BeginUpdate();
							try
							{
								foreach (STLists stlist in starchives.getLists2Import((STArchives.ArchImportMode)MySettingsProperty.Settings.STImportMode))
								{
									poilists = new POILists(false, true);
									flag2 = poilists.importFromArchive(stlist, starchives);
									if (flag2)
									{
										this.completeList.Add(poilists);
										this._modified = true;
									}
								}
							}
							finally
							{
								List<STLists>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							MyProject.Forms.FormMain.ImportedFilesListBox.EndUpdate();
							this.updateTotalPOINumber();
						}
					}
					else
					{
						Interaction.MsgBox(string.Format(Resources.strErrArchNotSupported, fileNames[0]), MsgBoxStyle.Critical, null);
					}
					starchives.close();
				}
				else
				{
					poilists = new POILists(false, false);
					flag2 = poilists.importFromFiles(fileNames, Common.RTxMapEditorMapMode);
					if (flag2)
					{
						flag = poilists.fromRT3;
						if (flag)
						{
							POILists poilists3 = this.existsInOrigMap(poilists.type);
							flag2 = (!allwaysload && poilists3 != null);
							if (flag2)
							{
								flag = (this.warnDial == null);
								if (flag)
								{
									this.warnDial = new dupListDialog();
								}
								switch (this.warnDial.showError(Resources.strImportDupLists))
								{
								case dupListDialog.DialResult.replace:
									this.completeList.Add(poilists);
									this.completeList.Remove(poilists3);
									this._modified = true;
									break;
								case dupListDialog.DialResult.both:
									this.completeList.Add(poilists);
									this._modified = true;
									break;
								}
							}
							else
							{
								this.completeList.Add(poilists);
								this._modified = true;
							}
							poilists3 = this.existsInOrigMap(5800);
							flag2 = (poilists.type == 22184 && poilists3 != null);
							if (flag2)
							{
								this.rebuildChamperard(poilists3, poilists);
							}
						}
						else
						{
							this.completeList.Add(poilists);
							this._modified = true;
						}
					}
					if (allwaysload)
					{
						poilists.setAllwaysLoaded();
					}
					this.updateTotalPOINumber();
				}
			}
			return poilists;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00115BE8 File Offset: 0x00114BE8
		public void importFromRT3Map(Common.RTxTypes RTxType)
		{
			List<POILists> list = null;
			MyProject.Application.Log.WriteEntry("importFromRT3Map() begin", TraceEventType.Information);
			commonFiles commonFiles = new commonFiles(MyProject.Forms.FormMain.mapMngt.POIcategoryInfo, this.mapType);
			POILists poilists = new POILists(true, false);
			list = poilists.importFromRT3Map(MyProject.Forms.FormMain.mapMngt.POIcategoryInfo, MyProject.Forms.FormMain.mapMngt.POITypeInfo, commonFiles, this.mapType);
			bool flag = list != null;
			if (flag)
			{
				bool flag2 = !Inifiles.ExistsSection(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP CONTENT");
				if (flag2)
				{
					try
					{
						foreach (POILists poilists2 in list)
						{
							Inifiles.SetKey(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP CONTENT", poilists2.ListofPOI[0].type.ToString("x4"), "1");
						}
					}
					finally
					{
						List<POILists>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				MyProject.Forms.FormMain.ImportedFilesListBox.BeginUpdate();
				list.Sort(new Comparison<POILists>(this.CompareName));
				try
				{
					foreach (POILists poilists3 in list)
					{
						flag2 = (Operators.CompareString(Inifiles.GetKey(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP CONTENT", poilists3.ListofPOI[0].type.ToString("x4")), "1", false) == 0);
						if (flag2)
						{
							flag = (poilists3.ListofPOI[0].type == 9993 && MySettingsProperty.Settings.changeRTxEmbassy);
							if (flag)
							{
								poilists3.setType(9121);
							}
							else
							{
								flag2 = (poilists3.ListofPOI[0].type == 9991 && MySettingsProperty.Settings.changeRTxIndustArea);
								if (flag2)
								{
									poilists3.setType(5000);
								}
								else
								{
									flag2 = (poilists3.ListofPOI[0].type == 9999 && MySettingsProperty.Settings.changeRTxBorderCrossing);
									if (flag2)
									{
										poilists3.setType(4444);
									}
									else
									{
										flag2 = (poilists3.ListofPOI[0].type == 7929 && MySettingsProperty.Settings.changeRTxPerfArts && RTxType == Common.RTxTypes.typeRT3);
										if (flag2)
										{
											poilists3.setType(7832);
										}
										else
										{
											flag2 = (poilists3.ListofPOI[0].type == 7994 && MySettingsProperty.Settings.changeRTxCivicCenter);
											if (flag2)
											{
												poilists3.setType(8410);
											}
											else
											{
												flag2 = (poilists3.ListofPOI[0].type == 5571 && MySettingsProperty.Settings.changeRTxMotorb);
												if (flag2)
												{
													poilists3.setType(7538);
												}
												else
												{
													flag2 = (poilists3.ListofPOI[0].type == 9583 && MySettingsProperty.Settings.changeRTxMedicServ);
													if (flag2)
													{
														poilists3.setType(8060);
													}
													else
													{
														poilists3.type = poilists3.ListofPOI[0].type;
														poilists3.scale = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getScaleOfType(poilists3.type);
														poilists3.layer = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getLayerOfType(poilists3.type);
													}
												}
											}
										}
									}
								}
							}
							flag2 = (poilists3.ListofPOI[0].type != 9998 || !MySettingsProperty.Settings.ignoreRTxBorgate);
							if (flag2)
							{
								this.completeList.Add(poilists3);
							}
						}
					}
				}
				finally
				{
					List<POILists>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				this.loadAllwaysLoadLists();
				MyProject.Forms.FormMain.ImportedFilesListBox.EndUpdate();
				this._modified = true;
				this.updateTotalPOINumber();
			}
			MyProject.Application.Log.WriteEntry("importFromRT3Map() end", TraceEventType.Information);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x001160B4 File Offset: 0x001150B4
		private void loadAllwaysLoadLists()
		{
			Collection sectionKeys = Inifiles.GetSectionKeys(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP ADDED");
			string[] array = (string[])Array.CreateInstance(typeof(string), 1);
			try
			{
				foreach (object obj in sectionKeys)
				{
					KeyValuePair<string, string> keyValuePair2;
					KeyValuePair<string, string> keyValuePair = (obj != null) ? ((KeyValuePair<string, string>)obj) : keyValuePair2;
					array[0] = Path.Combine(MySettingsProperty.Settings.WorkingDir, keyValuePair.Key + keyValuePair.Value);
					this.importFromFiles(array, true);
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0011618C File Offset: 0x0011518C
		public bool exportToRT3Map(DateTime processBegin, int mapVers, int mapRel, string mapName, bool hddMap)
		{
			string workingDir = MySettingsProperty.Settings.WorkingDir;
			string upgPath = Path.Combine(workingDir, "destUPG");
			string text = Path.Combine(workingDir, "dest");
			string path = Path.Combine(workingDir, "orig");
			string text2 = Path.Combine(text, "CONFIG.LOG");
			string sourceFileName = Path.Combine(path, "CONFIG.LOG");
			MyProject.Application.Log.WriteEntry("ImportedPOILists.exportToRT3Map() begin", TraceEventType.Information);
			bool flag = false;
			bool flag2 = this.completeList.Count > 0;
			if (flag2)
			{
				MyProject.Computer.FileSystem.CopyFile(sourceFileName, text2, UIOption.OnlyErrorDialogs, UICancelOption.ThrowException);
				MyProject.Computer.FileSystem.WriteAllText(text2, this.getContent(), true, Common.RT3Encoding);
				flag = this.completeList[0].exportToRT3Map(MyProject.Forms.FormMain.mapMngt.POIcategoryInfo, MyProject.Forms.FormMain.mapMngt.POITypeInfo, this.completeList, this.mapType, this.countryMap);
				flag2 = (flag && Common.RTxType != Common.RTxTypes.typeRT3 && MySettingsProperty.Settings.upgMap && CopyMap.isUpgradeSupported(mapVers, mapRel, mapName));
				if (flag2)
				{
					flag = this.copyUpgFiles(processBegin, text, upgPath, Conversions.ToString(mapVers), Conversions.ToString(mapRel));
				}
			}
			MyProject.Application.Log.WriteEntry("ImportedPOILists.exportToRT3Map() end", TraceEventType.Information);
			return flag;
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x001162FC File Offset: 0x001152FC
		public bool exportToAlert(string countryMap, string workingDirAlert)
		{
			MyProject.Application.Log.WriteEntry("ImportedPOILists.exportToAlert begin", TraceEventType.Information);
			bool flag = this.completeList.Count > 0;
			bool result;
			if (flag)
			{
				result = this.completeList[0].exportToAlert(MyProject.Forms.FormMain.mapMngt.POIcategoryInfo, MyProject.Forms.FormMain.mapMngt.POITypeInfo, this.completeList, workingDirAlert, countryMap);
			}
			MyProject.Application.Log.WriteEntry("ImportedPOILists.exportToAlert end", TraceEventType.Information);
			return result;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00116390 File Offset: 0x00115390
		public void removeLists(ListOfPOILists listsToRemove, bool neverLoadAgain)
		{
			try
			{
				foreach (POILists poilists in listsToRemove)
				{
					bool flag = poilists.remove(neverLoadAgain) == POILists.state.originalRemoved;
					if (flag)
					{
						this.deletedList.Add(poilists);
					}
					this.completeList.Remove(poilists);
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
			this._modified = true;
			this.updateTotalPOINumber();
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0011641C File Offset: 0x0011541C
		public void removeList(POILists listToRemove, bool neverLoadAgain)
		{
			bool flag = listToRemove.remove(neverLoadAgain) == POILists.state.originalRemoved;
			if (flag)
			{
				this.deletedList.Add(listToRemove);
			}
			this.completeList.Remove(listToRemove);
			this._modified = true;
			this.updateTotalPOINumber();
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00116464 File Offset: 0x00115464
		public void addToAllwaysLoadList(ListBox.SelectedObjectCollection listsToAllwaysLoad)
		{
			try
			{
				foreach (object obj in listsToAllwaysLoad)
				{
					POILists poilists = (POILists)obj;
					poilists.setAllwaysLoad();
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x001164CC File Offset: 0x001154CC
		public void mergeList(ListOfPOILists listsToMerge)
		{
			POILists poilists = listsToMerge[0];
			poilists.removeAllwaysLoad();
			listsToMerge.Remove(poilists);
			try
			{
				foreach (POILists poilists2 in listsToMerge)
				{
					poilists2.removeAllwaysLoad();
					poilists.ListofPOI.AddRange(poilists2.ListofPOI);
					bool flag = Operators.CompareString(poilists.name, "", false) != 0;
					POILists poilists3;
					if (flag)
					{
						poilists3 = poilists;
						poilists3.name += ", ";
					}
					poilists3 = poilists;
					poilists3.name += poilists2.name;
					this.completeList.Remove(poilists2);
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
			this._modified = true;
			this.updateTotalPOINumber();
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x001165C4 File Offset: 0x001155C4
		public void InitList(Common.RTxMapType mapType, string countryMap, uint LSColumnNb, uint LSLineNb, uint LSNb, Common.RTxMapEditorMapModes RTxMapEditorMapMode)
		{
			this.mapType = mapType;
			this.countryMap = countryMap;
			POIDatas.initShared(mapType, LSColumnNb, LSLineNb, LSNb, RTxMapEditorMapMode);
			this.completeList.Clear();
			this.deletedList.Clear();
			this._modified = true;
			this.updateTotalPOINumber();
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00116618 File Offset: 0x00115618
		public void ClearList()
		{
			this.mapType = Common.RTxMapType.Unknown;
			this.countryMap = "";
			this.completeList.Clear();
			this.deletedList.Clear();
			this._modified = true;
			this.updateTotalPOINumber();
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00116654 File Offset: 0x00115654
		private void getContentbyCat(StringBuilder stringBuidler, POILists.state state)
		{
			try
			{
				foreach (POILists poilists in this.completeList)
				{
					bool flag = poilists._state == state;
					if (flag)
					{
						stringBuidler.AppendLine(string.Format("{0:G} -> {1:G}", poilists.name, MyProject.Forms.FormMain.mapMngt.POITypeInfo.getNameOfType(poilists.type)));
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
			try
			{
				foreach (POILists poilists in this.deletedList)
				{
					bool flag = poilists._state == state;
					if (flag)
					{
						stringBuidler.AppendLine(poilists.name);
					}
				}
			}
			finally
			{
				IEnumerator<POILists> enumerator2;
				bool flag = enumerator2 != null;
				if (flag)
				{
					enumerator2.Dispose();
				}
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00116750 File Offset: 0x00115750
		public string getContent()
		{
			StringBuilder stringBuilder = new StringBuilder(20000);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(Resources.strPatchedMap);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(string.Format(Resources.strLogPOI, Common.strRTxType));
			stringBuilder.AppendLine(Resources.strLogOrig);
			this.getContentbyCat(stringBuilder, POILists.state.original);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(Resources.strLogDeleted);
			this.getContentbyCat(stringBuilder, POILists.state.originalRemoved);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(Resources.strLogAdded);
			this.getContentbyCat(stringBuilder, POILists.state.added);
			return stringBuilder.ToString();
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x001167F0 File Offset: 0x001157F0
		private int CompareName(POILists x, POILists y)
		{
			return string.Compare(x.name, y.name);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00116814 File Offset: 0x00115814
		public int updateTotalPOINumber()
		{
			this.totalPOINumber_s = 0;
			checked
			{
				try
				{
					foreach (POILists poilists in this.completeList)
					{
						this.totalPOINumber_s += poilists.POINumber;
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
				int result;
				return result;
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00116888 File Offset: 0x00115888
		private POILists existsInOrigMap(ushort type)
		{
			try
			{
				foreach (POILists poilists in this.completeList)
				{
					bool flag = poilists.fromRT3Map && poilists.type == type;
					if (flag)
					{
						return poilists;
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
			return null;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00116904 File Offset: 0x00115904
		private void rebuildChamperard(POILists restoList, POILists champerardList)
		{
			Cursor value = Cursor.Current;
			Application.DoEvents();
			Cursor.Current = Cursors.WaitCursor;
			MyProject.Forms.FormMain.ToolStripStatusLabelSatus.Text = Resources.strRebuildRest;
			MyProject.Forms.FormMain.ToolStripProgressBar1.Style = ProgressBarStyle.Blocks;
			MyProject.Forms.FormMain.ToolStripProgressBar1.Minimum = 0;
			MyProject.Forms.FormMain.ToolStripProgressBar1.Maximum = 12;
			Application.DoEvents();
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 0;
			SortedDictionary<uint, POIDatas> sortedDictionary = new SortedDictionary<uint, POIDatas>();
			try
			{
				foreach (POIDatas poidatas in restoList.ListofPOI)
				{
					sortedDictionary.Add(poidatas.UId, poidatas);
				}
			}
			finally
			{
				List<POIDatas>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 1;
			SortedDictionary<uint, POIDatas> sortedDictionary2 = new SortedDictionary<uint, POIDatas>();
			try
			{
				foreach (POIDatas poidatas2 in champerardList.ListofPOI)
				{
					sortedDictionary2.Add(poidatas2.UId, poidatas2);
				}
			}
			finally
			{
				List<POIDatas>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			SortedDictionary<uint, POIDatas> sortedDictionary3 = new SortedDictionary<uint, POIDatas>();
			MyProject.Application.Log.WriteEntry(string.Format("*** {0:D} {1:d} {2:d}  ***", sortedDictionary.Count, sortedDictionary2.Count, sortedDictionary3.Count));
			this.rebuildChampByNameTel(sortedDictionary, sortedDictionary2, sortedDictionary3, true);
			MyProject.Application.Log.WriteEntry(string.Format("*** {0:G} {1:G} {2:G}  ***", sortedDictionary.Count, sortedDictionary2.Count, sortedDictionary3.Count));
			this.rebuildChampByTel(sortedDictionary, sortedDictionary2, sortedDictionary3, true);
			MyProject.Application.Log.WriteEntry(string.Format("*** {0:G} {1:G} {2:G}  ***", sortedDictionary.Count, sortedDictionary2.Count, sortedDictionary3.Count));
			this.rebuildChampByCoord(sortedDictionary, sortedDictionary2, sortedDictionary3, true);
			MyProject.Application.Log.WriteEntry(string.Format("*** {0:G} {1:G} {2:G}  ***", sortedDictionary.Count, sortedDictionary2.Count, sortedDictionary3.Count));
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 11;
			champerardList.ListofPOI.Clear();
			try
			{
				foreach (POIDatas poidatas2 in sortedDictionary3.Values)
				{
					champerardList.ListofPOI.Add(poidatas2);
				}
			}
			finally
			{
				SortedDictionary<uint, POIDatas>.ValueCollection.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 12;
			restoList.ListofPOI.Clear();
			try
			{
				foreach (POIDatas poidatas in sortedDictionary.Values)
				{
					restoList.ListofPOI.Add(poidatas);
				}
			}
			finally
			{
				SortedDictionary<uint, POIDatas>.ValueCollection.Enumerator enumerator4;
				((IDisposable)enumerator4).Dispose();
			}
			Cursor.Current = value;
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 0;
			Application.DoEvents();
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00116C98 File Offset: 0x00115C98
		private void rebuildChampByNameTel(SortedDictionary<uint, POIDatas> initRestoDict, SortedDictionary<uint, POIDatas> initChamperardDict, SortedDictionary<uint, POIDatas> finalChamperardDict, bool updateInitLists)
		{
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 2;
			SortedDictionary<string, POIDatas> sortedDictionary = new SortedDictionary<string, POIDatas>();
			SortedDictionary<string, POIDatas> sortedDictionary2 = new SortedDictionary<string, POIDatas>();
			try
			{
				foreach (POIDatas poidatas in initRestoDict.Values)
				{
					string key = poidatas.nameForExport + poidatas.telForExport;
					bool flag = !sortedDictionary2.ContainsKey(key);
					if (flag)
					{
						bool flag2 = sortedDictionary.ContainsKey(key);
						if (flag2)
						{
							sortedDictionary2.Add(key, poidatas);
							sortedDictionary.Remove(key);
						}
						else
						{
							sortedDictionary.Add(key, poidatas);
						}
					}
				}
			}
			finally
			{
				SortedDictionary<uint, POIDatas>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 3;
			SortedDictionary<string, POIDatas> sortedDictionary3 = new SortedDictionary<string, POIDatas>();
			SortedDictionary<string, POIDatas> sortedDictionary4 = new SortedDictionary<string, POIDatas>();
			try
			{
				foreach (POIDatas poidatas2 in initChamperardDict.Values)
				{
					string key = poidatas2.nameForExport + poidatas2.telForExport;
					bool flag2 = !sortedDictionary4.ContainsKey(key);
					if (flag2)
					{
						bool flag = sortedDictionary3.ContainsKey(key);
						if (flag)
						{
							sortedDictionary4.Add(key, poidatas2);
							sortedDictionary3.Remove(key);
						}
						else
						{
							sortedDictionary3.Add(key, poidatas2);
						}
					}
				}
			}
			finally
			{
				SortedDictionary<uint, POIDatas>.ValueCollection.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 4;
			try
			{
				foreach (string key in sortedDictionary3.Keys)
				{
					bool flag2 = sortedDictionary.ContainsKey(key);
					if (flag2)
					{
						POIDatas poidatas3 = sortedDictionary[key];
						poidatas3.type = 22184;
						poidatas3.commentRT3 = sortedDictionary3[key].commentForExport;
						finalChamperardDict.Add(poidatas3.UId, poidatas3);
						if (updateInitLists)
						{
							initRestoDict.Remove(poidatas3.UId);
							POIDatas poidatas2 = sortedDictionary3[key];
							initChamperardDict.Remove(poidatas2.UId);
						}
					}
				}
			}
			finally
			{
				SortedDictionary<string, POIDatas>.KeyCollection.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00116EF0 File Offset: 0x00115EF0
		private void rebuildChampByCoord(SortedDictionary<uint, POIDatas> initRestoDict, SortedDictionary<uint, POIDatas> initChamperardDict, SortedDictionary<uint, POIDatas> finalChamperardDict, bool updateInitLists)
		{
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 8;
			SortedDictionary<ulong, POIDatas> sortedDictionary = new SortedDictionary<ulong, POIDatas>();
			SortedDictionary<ulong, POIDatas> sortedDictionary2 = new SortedDictionary<ulong, POIDatas>();
			try
			{
				foreach (POIDatas poidatas in initRestoDict.Values)
				{
					ulong key = (ulong)poidatas._ERTX | (ulong)poidatas._NRTX << 32;
					bool flag = !sortedDictionary2.ContainsKey(key);
					if (flag)
					{
						bool flag2 = sortedDictionary.ContainsKey(key);
						if (flag2)
						{
							sortedDictionary2.Add(key, poidatas);
							sortedDictionary.Remove(key);
						}
						else
						{
							sortedDictionary.Add(key, poidatas);
						}
					}
				}
			}
			finally
			{
				SortedDictionary<uint, POIDatas>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 9;
			SortedDictionary<ulong, POIDatas> sortedDictionary3 = new SortedDictionary<ulong, POIDatas>();
			SortedDictionary<ulong, POIDatas> sortedDictionary4 = new SortedDictionary<ulong, POIDatas>();
			try
			{
				foreach (POIDatas poidatas2 in initChamperardDict.Values)
				{
					ulong key = (ulong)poidatas2._ERTX | (ulong)poidatas2._NRTX << 32;
					bool flag2 = !sortedDictionary4.ContainsKey(key);
					if (flag2)
					{
						bool flag = sortedDictionary3.ContainsKey(key);
						if (flag)
						{
							sortedDictionary4.Add(key, poidatas2);
							sortedDictionary3.Remove(key);
						}
						else
						{
							sortedDictionary3.Add(key, poidatas2);
						}
					}
				}
			}
			finally
			{
				SortedDictionary<uint, POIDatas>.ValueCollection.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 10;
			try
			{
				foreach (ulong key in sortedDictionary3.Keys)
				{
					bool flag2 = sortedDictionary.ContainsKey(key);
					if (flag2)
					{
						POIDatas poidatas3 = sortedDictionary[key];
						poidatas3.type = 22184;
						poidatas3.commentRT3 = sortedDictionary3[key].commentForExport;
						finalChamperardDict.Add(poidatas3.UId, poidatas3);
						if (updateInitLists)
						{
							initRestoDict.Remove(poidatas3.UId);
							POIDatas poidatas2 = sortedDictionary3[key];
							initChamperardDict.Remove(poidatas2.UId);
						}
					}
				}
			}
			finally
			{
				SortedDictionary<ulong, POIDatas>.KeyCollection.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00117158 File Offset: 0x00116158
		private void rebuildChampByTel(SortedDictionary<uint, POIDatas> initRestoDict, SortedDictionary<uint, POIDatas> initChamperardDict, SortedDictionary<uint, POIDatas> finalChamperardDict, bool updateInitLists)
		{
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 5;
			SortedDictionary<ulong, POIDatas> sortedDictionary = new SortedDictionary<ulong, POIDatas>();
			SortedDictionary<ulong, POIDatas> sortedDictionary2 = new SortedDictionary<ulong, POIDatas>();
			try
			{
				foreach (POIDatas poidatas in initRestoDict.Values)
				{
					ulong key = poidatas.telRT3;
					bool flag = !sortedDictionary2.ContainsKey(key);
					if (flag)
					{
						bool flag2 = sortedDictionary.ContainsKey(key);
						if (flag2)
						{
							sortedDictionary2.Add(key, poidatas);
							sortedDictionary.Remove(key);
						}
						else
						{
							sortedDictionary.Add(key, poidatas);
						}
					}
				}
			}
			finally
			{
				SortedDictionary<uint, POIDatas>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 6;
			SortedDictionary<ulong, POIDatas> sortedDictionary3 = new SortedDictionary<ulong, POIDatas>();
			SortedDictionary<ulong, POIDatas> sortedDictionary4 = new SortedDictionary<ulong, POIDatas>();
			try
			{
				foreach (POIDatas poidatas2 in initChamperardDict.Values)
				{
					ulong key = poidatas2.telRT3;
					bool flag2 = !sortedDictionary4.ContainsKey(key);
					if (flag2)
					{
						bool flag = sortedDictionary3.ContainsKey(key);
						if (flag)
						{
							sortedDictionary4.Add(key, poidatas2);
							sortedDictionary3.Remove(key);
						}
						else
						{
							sortedDictionary3.Add(key, poidatas2);
						}
					}
				}
			}
			finally
			{
				SortedDictionary<uint, POIDatas>.ValueCollection.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 7;
			try
			{
				foreach (ulong key in sortedDictionary3.Keys)
				{
					bool flag2 = sortedDictionary.ContainsKey(key);
					if (flag2)
					{
						POIDatas poidatas3 = sortedDictionary[key];
						poidatas3.type = 22184;
						poidatas3.commentRT3 = sortedDictionary3[key].commentForExport;
						finalChamperardDict.Add(poidatas3.UId, poidatas3);
						if (updateInitLists)
						{
							initRestoDict.Remove(poidatas3.UId);
							POIDatas poidatas2 = sortedDictionary3[key];
							initChamperardDict.Remove(poidatas2.UId);
						}
					}
				}
			}
			finally
			{
				SortedDictionary<ulong, POIDatas>.KeyCollection.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x001173A4 File Offset: 0x001163A4
		private bool copyUpgFiles(DateTime processBegin, string destPath, string upgPath, string strVersion, string strRelease)
		{
			try
			{
				bool flag = MyProject.Computer.FileSystem.DirectoryExists(upgPath);
				if (flag)
				{
					MyProject.Computer.FileSystem.DeleteDirectory(upgPath, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
				}
				MyProject.Computer.FileSystem.CreateDirectory(upgPath);
				ReadOnlyCollection<string> files = MyProject.Computer.FileSystem.GetFiles(destPath, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, new string[]
				{
					"*"
				});
				try
				{
					foreach (string text in files)
					{
						if (DateTime.Compare(MyProject.Computer.FileSystem.GetFileInfo(text).LastWriteTime, processBegin) >= 0 || Path.GetFileNameWithoutExtension(text).StartsWith("GRUPPO_4_ROOT", StringComparison.InvariantCultureIgnoreCase))
						{
							goto IL_C0;
						}
						if (Path.GetFileNameWithoutExtension(text).StartsWith("CD_VER", StringComparison.InvariantCultureIgnoreCase))
						{
							goto IL_C0;
						}
						if (Path.GetFileNameWithoutExtension(text).StartsWith("builtins", StringComparison.InvariantCultureIgnoreCase))
						{
							goto IL_D5;
						}
						if (Path.GetFileNameWithoutExtension(text).StartsWith("NAV_UPGRADE", StringComparison.InvariantCultureIgnoreCase))
						{
							goto IL_EA;
						}
						if (Path.GetFileNameWithoutExtension(text).StartsWith("DB_DWNL_PPC", StringComparison.InvariantCultureIgnoreCase))
						{
							goto IL_102;
						}
						bool flag2 = false;
						IL_103:
						flag = flag2;
						if (flag)
						{
							MyProject.Computer.FileSystem.CopyFile(text, text.Replace(destPath, upgPath));
						}
						continue;
						IL_102:
						flag2 = true;
						goto IL_103;
						IL_EA:
						goto IL_102;
						IL_D5:
						goto IL_EA;
						IL_C0:
						goto IL_D5;
					}
				}
				finally
				{
					IEnumerator<string> enumerator;
					flag = (enumerator != null);
					if (flag)
					{
						enumerator.Dispose();
					}
				}
				ZipFile zipFile = new ZipFile(Path.Combine(MyProject.Application.Info.DirectoryPath, "redist\\upg.dat"));
				zipFile.Password = "ZZZCOM.IND.lst";
				CopyMap.extractCopyFile(zipFile, "21", "table_upgrade_excl.dat", Path.Combine(upgPath, "UPG"));
				CopyMap.extractAndProcessScript(zipFile, "5", "NAV_UPGRADE_SUB.CMD", Path.Combine(upgPath, "UPG"), null, false, false, false, null);
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteException(ex);
				Interaction.MsgBox(string.Format(Resources.strErrCopy, destPath, upgPath), MsgBoxStyle.OkOnly, null);
				return false;
			}
			return true;
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x001175E4 File Offset: 0x001165E4
		public int totalPOINumber
		{
			get
			{
				return this.totalPOINumber_s;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x001175FC File Offset: 0x001165FC
		public ListOfPOILists ListOfPOIList
		{
			get
			{
				return this.completeList;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00117614 File Offset: 0x00116614
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x0011762C File Offset: 0x0011662C
		public bool modified
		{
			get
			{
				return this._modified;
			}
			set
			{
				this._modified = value;
			}
		}

		// Token: 0x04000490 RID: 1168
		private ListOfPOILists completeList;

		// Token: 0x04000491 RID: 1169
		private ListOfPOILists deletedList;

		// Token: 0x04000492 RID: 1170
		private int currentIdx;

		// Token: 0x04000493 RID: 1171
		private int totalPOINumber_s;

		// Token: 0x04000494 RID: 1172
		private bool _modified;

		// Token: 0x04000495 RID: 1173
		private Common.RTxMapType mapType;

		// Token: 0x04000496 RID: 1174
		private string countryMap;

		// Token: 0x04000497 RID: 1175
		private dupListDialog warnDial;
	}
}
