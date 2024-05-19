using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000066 RID: 102
	public class POILists
	{
		// Token: 0x06000CCD RID: 3277 RVA: 0x0011D21C File Offset: 0x0011C21C
		public POILists(bool fromRT3, bool fromArchive)
		{
			this._name = null;
			this._listOfPOI = null;
			this._listOfPOIToKeep = null;
			this._listOfPOIInDup = null;
			this._fromRT3 = false;
			this._fromRT3Map = false;
			this.isReadOnly = false;
			this.noDelete = false;
			this.brandIdx = 0;
			this.maxDist = 0;
			this._state = POILists.state.empty;
			this._listOfPOI = new List<POIDatas>();
			this._allwaysLoad = false;
			this._sdPOIByCell = null;
			this._sdBrandIdx = null;
			this._fromArchive = fromArchive;
			if (fromRT3)
			{
				this._fromRT3 = true;
				this._fromRT3Map = true;
				this._fullPatch = false;
				this._displayMagnitude = false;
				this.POIName = new POIName(POIName.nameTypes.RT3);
			}
			else
			{
				this._fromRT3 = false;
				this._fromRT3Map = false;
				this._fullPatch = false;
				this._displayMagnitude = false;
				this.POIName = new POIName(POIName.nameTypes.notChecked);
				this.type = 4444;
				this.scale = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getScaleOfType(this.type);
				this.layer = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getLayerOfType(this.type);
				this.magnitude = 5;
			}
			if (fromArchive)
			{
				this.speed = 999U;
			}
			else
			{
				this.speed = 0U;
			}
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x0011D37C File Offset: 0x0011C37C
		public bool importFromFiles(string[] fileNames, Common.RTxMapEditorMapModes RTxMapEditorMapMode)
		{
			importFromFiles importFromFiles = new importFromFiles(this);
			return importFromFiles.importFromFiles(fileNames, RTxMapEditorMapMode);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0011D3A0 File Offset: 0x0011C3A0
		public bool importFromArchive(STLists STList, STArchives archive)
		{
			importFromFiles importFromFiles = new importFromFiles(this);
			return importFromFiles.importFromArchive(STList, archive);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0011D3C4 File Offset: 0x0011C3C4
		public List<POILists> importFromScdb(string fileName)
		{
			importFromScdb importFromScdb = new importFromScdb(this);
			return importFromScdb.importFromScdb(fileName);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0011D3E4 File Offset: 0x0011C3E4
		public List<POILists> importFromRT3Map(POICategoryInfos POIcategoryInfo, POITypeInfo POITypeInfo, commonFiles commonFiles, Common.RTxMapType mapType)
		{
			ImportFromRT3 importFromRT = new ImportFromRT3(this);
			return importFromRT.importFromRT3Map(POIcategoryInfo, POITypeInfo, commonFiles, mapType);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0011D408 File Offset: 0x0011C408
		public bool exportToRT3Map(POICategoryInfos POIcategoryInfo, POITypeInfo POITypeInfo, ListOfPOILists completeList, Common.RTxMapType mapType, string countryMap)
		{
			exportToRT3 exportToRT = new exportToRT3(this);
			return exportToRT.exportToRT3Map(POIcategoryInfo, POITypeInfo, completeList, mapType, countryMap);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0011D430 File Offset: 0x0011C430
		public bool exportToAlert(POICategoryInfos POIcategoryInfo, POITypeInfo POITypeInfo, ListOfPOILists completeList, string workingDirAlert, string countryMap)
		{
			exportToAlert exportToAlert = new exportToAlert(this);
			return exportToAlert.exportToAlert(POIcategoryInfo, POITypeInfo, completeList, workingDirAlert, countryMap);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0011D458 File Offset: 0x0011C458
		public void export(Common.RTxMapType mapType, bool withGUI, exportToFile.exportFormat exportFormat)
		{
			exportToFile exportToFile = new exportToFile(this);
			exportToFile.export(mapType, withGUI, exportFormat);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0011D478 File Offset: 0x0011C478
		public void setType(ushort type)
		{
			this.type = type;
			this.scale = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getScaleOfType(type);
			this.layer = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getLayerOfType(type);
			bool flag = this.POINumber != 0 && type != this.ListofPOI[0].type;
			checked
			{
				if (flag)
				{
					int num = 0;
					int num2 = this.ListofPOI.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						this.ListofPOI[num3].setType(type);
						num3++;
					}
				}
				this.updateAllwaysLoadFile();
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0011D52C File Offset: 0x0011C52C
		public void setScale(byte scale)
		{
			bool flag = !this.fromRT3 && this.POINumber != 0 && scale != this.ListofPOI[0].scale;
			checked
			{
				if (flag)
				{
					this.scale = scale;
					int num = 0;
					int num2 = this.ListofPOI.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						this.ListofPOI[num3].setScale(scale);
						num3++;
					}
				}
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0011D5A0 File Offset: 0x0011C5A0
		public void setLayer(byte layer)
		{
			bool flag = !this.fromRT3 && this.POINumber != 0 && layer != this.ListofPOI[0].layer;
			checked
			{
				if (flag)
				{
					this.layer = layer;
					int num = 0;
					int num2 = this.ListofPOI.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						this.ListofPOI[num3].setLayer(layer);
						num3++;
					}
				}
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0011D614 File Offset: 0x0011C614
		public void setMagnitude(byte magnitude)
		{
			bool flag = !this.fromRT3;
			checked
			{
				if (flag)
				{
					this.magnitude = magnitude;
					flag = (this.POINumber != 0 && this.type == 4444 && magnitude != this.ListofPOI[0].magnitude);
					if (flag)
					{
						int num = 0;
						int num2 = this.ListofPOI.Count - 1;
						int num3 = num;
						for (;;)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							this.ListofPOI[num3].setMagnitude(magnitude);
							num3++;
						}
					}
				}
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0011D69C File Offset: 0x0011C69C
		public void setFullPatch(bool fullPatch)
		{
			bool flag = !this.fromRT3 && this.POINumber != 0 && this.type == 4444 && this.magnitude >= 4;
			checked
			{
				if (flag)
				{
					this.fullPatch = fullPatch;
					int num = 0;
					int num2 = this.ListofPOI.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						this.ListofPOI[num3].setFullPatch(fullPatch);
						num3++;
					}
				}
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0011D714 File Offset: 0x0011C714
		public void setDisplayMagnitude(bool displayMagnitude)
		{
			bool flag = this.POINumber != 0 && this.type == 4444;
			checked
			{
				if (flag)
				{
					this.displayMagnitude = displayMagnitude;
					int num = 0;
					int num2 = this.ListofPOI.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						this.ListofPOI[num3].setDisplayMagnitude(displayMagnitude);
						num3++;
					}
				}
			}
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0011D77C File Offset: 0x0011C77C
		public void setSpeed(uint speed)
		{
			bool flag = this.POINumber != 0 & speed != 999U;
			checked
			{
				if (flag)
				{
					this.speed = speed;
					int num = 0;
					int num2 = this.ListofPOI.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						this.ListofPOI[num3].setSpeed(speed);
						num3++;
					}
				}
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0011D7E0 File Offset: 0x0011C7E0
		public void setAllwaysLoad()
		{
			string text = Inifiles.GetKey(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP ADDED", this.nameForExport);
			bool flag = Operators.CompareString(text, "", false) != 0;
			if (flag)
			{
				Interaction.MsgBox(string.Format(Resources.strWarningListExists, this.name), MsgBoxStyle.Exclamation, null);
			}
			else
			{
				this._allwaysLoad = true;
				flag = this._fromRT3;
				if (flag)
				{
					this.export(MyProject.Forms.FormMain.mapMngt.mapType, false, exportToFile.exportFormat.exportRT3);
					text = ".rt3";
				}
				else
				{
					this.export(MyProject.Forms.FormMain.mapMngt.mapType, false, exportToFile.exportFormat.exportRTxME);
					text = ".rtxme";
				}
				Inifiles.SetKey(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP ADDED", this.nameForExport, text);
			}
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x0011D8CC File Offset: 0x0011C8CC
		public void setAllwaysLoaded()
		{
			bool flag = Operators.CompareString(Inifiles.GetKey(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP ADDED", this.nameForExport), "", false) != 0;
			if (flag)
			{
				this._allwaysLoad = true;
			}
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0011D920 File Offset: 0x0011C920
		public void removeAllwaysLoad()
		{
			bool flag = this._allwaysLoad;
			if (flag)
			{
				this._allwaysLoad = false;
				string key = Inifiles.GetKey(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP ADDED", this.nameForExport);
				Inifiles.DeleteKey(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP ADDED", this.nameForExport);
				string file = Path.Combine(MySettingsProperty.Settings.WorkingDir, this.nameForExport + key);
				flag = MyProject.Computer.FileSystem.FileExists(file);
				if (flag)
				{
					MyProject.Computer.FileSystem.DeleteFile(file);
				}
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0011D9D0 File Offset: 0x0011C9D0
		private void updateAllwaysLoadFile()
		{
			string key = Inifiles.GetKey(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP ADDED", this.nameForExport);
			bool allwaysLoad = this._allwaysLoad;
			if (allwaysLoad)
			{
				bool flag = Operators.CompareString(key, ".rt3", false) == 0;
				if (flag)
				{
					this.export(MyProject.Forms.FormMain.mapMngt.mapType, false, exportToFile.exportFormat.exportRT3);
				}
				else
				{
					this.export(MyProject.Forms.FormMain.mapMngt.mapType, false, exportToFile.exportFormat.exportRTxME);
				}
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0011DA60 File Offset: 0x0011CA60
		private void setNeverLoadAgain()
		{
			bool fromRT3Map = this.fromRT3Map;
			if (fromRT3Map)
			{
				Inifiles.SetKey(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP CONTENT", this.type.ToString("x4"), "0");
			}
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0011DAB0 File Offset: 0x0011CAB0
		public POIName.nameTypes getPOINameType()
		{
			return this.POIName.getNameType(this);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0011DAD0 File Offset: 0x0011CAD0
		public void updatePOIName()
		{
			int num = 0;
			checked
			{
				int num2 = this.ListofPOI.Count - 1;
				int num3 = num;
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					bool flag = this.ListofPOI[num3].listOfCanonical.Count > 0;
					if (flag)
					{
						this.ListofPOI[num3].listOfCanonical[0].name = this.POIName.translateName(this.ListofPOI[num3].origName);
						flag = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert);
						if (flag)
						{
							uint num6 = POIName.getSpeed(this.ListofPOI[num3].origName);
							flag = (unchecked((ulong)num6) != 999UL);
							if (flag)
							{
								this.ListofPOI[num3].speed = num6;
							}
						}
					}
					num3++;
				}
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0011DBA8 File Offset: 0x0011CBA8
		public POILists.state remove(bool neverLoadAgain)
		{
			this.removeAllwaysLoad();
			if (neverLoadAgain)
			{
				this.setNeverLoadAgain();
			}
			this._listOfPOI = null;
			bool flag = this._state == POILists.state.original;
			if (flag)
			{
				this._state = POILists.state.originalRemoved;
			}
			else
			{
				this._state = POILists.state.addedRemoved;
			}
			flag = this._allwaysLoad;
			if (flag)
			{
			}
			return this._state;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0011DC08 File Offset: 0x0011CC08
		public NonFatalErrorBox.DialResult displayImportErr(POIDatas.errorCodes errorCode, string fileName, string[] currentRow, importFromFiles.index idx, int numLine, bool multipleImport)
		{
			string errText;
			NonFatalErrorBox.DialResult result;
			switch (errorCode)
			{
			case POIDatas.errorCodes.LatOutOfRange:
			{
				bool flag = MySettingsProperty.Settings.importErrIncCoord;
				if (flag)
				{
					errText = string.Format(Resources.strErrLatOutOfRange, numLine, fileName, currentRow[idx.lat]);
					result = MyProject.Forms.NonFatalErrorBox.showError(errText, currentRow, true, true, true, multipleImport);
				}
				else
				{
					result = NonFatalErrorBox.DialResult.Ignore;
				}
				return result;
			}
			case POIDatas.errorCodes.LonOutOfRange:
			{
				bool flag = MySettingsProperty.Settings.importErrIncCoord;
				if (flag)
				{
					errText = string.Format(Resources.strErrLonOutOfRange, numLine, fileName, currentRow[idx.lon]);
					result = MyProject.Forms.NonFatalErrorBox.showError(errText, currentRow, true, true, true, multipleImport);
				}
				else
				{
					result = NonFatalErrorBox.DialResult.Ignore;
				}
				return result;
			}
			case POIDatas.errorCodes.incorrectName:
				errText = string.Format(Resources.strErrIncorrectName, numLine, fileName, currentRow[idx.name]);
				return MyProject.Forms.NonFatalErrorBox.showError(errText, currentRow, true, true, true, multipleImport);
			case POIDatas.errorCodes.incorrectLatFormat:
			{
				bool flag = MySettingsProperty.Settings.importErrIncCoord;
				if (flag)
				{
					errText = string.Format(Resources.strErrIncorrectLat, numLine, fileName, currentRow[idx.lat]);
					result = MyProject.Forms.NonFatalErrorBox.showError(errText, currentRow, true, true, true, multipleImport);
				}
				else
				{
					result = NonFatalErrorBox.DialResult.Ignore;
				}
				return result;
			}
			case POIDatas.errorCodes.incorrectLonFormat:
			{
				bool flag = MySettingsProperty.Settings.importErrIncCoord;
				if (flag)
				{
					errText = string.Format(Resources.strErrIncorrectLon, numLine, fileName, currentRow[idx.lon]);
					result = MyProject.Forms.NonFatalErrorBox.showError(errText, currentRow, true, true, true, multipleImport);
				}
				else
				{
					result = NonFatalErrorBox.DialResult.Ignore;
				}
				return result;
			}
			case POIDatas.errorCodes.LSMSempty:
			{
				bool flag = MySettingsProperty.Settings.importErrEmptyArea;
				if (flag)
				{
					errText = string.Format(Resources.strErrLSMSempty, new object[]
					{
						numLine,
						fileName,
						currentRow[idx.lat],
						currentRow[idx.lon]
					});
					result = MyProject.Forms.NonFatalErrorBox.showError(errText, currentRow, true, true, true, multipleImport);
				}
				else
				{
					result = NonFatalErrorBox.DialResult.Ignore;
				}
				return result;
			}
			case POIDatas.errorCodes.ERT3OutOfRange:
			{
				bool flag = MySettingsProperty.Settings.importErrIncCoord;
				if (flag)
				{
					errText = string.Format(Resources.strErrERT3OutOfRange, numLine, fileName, currentRow[idx.ERT3]);
					result = MyProject.Forms.NonFatalErrorBox.showError(errText, currentRow, true, true, true, multipleImport);
				}
				else
				{
					result = NonFatalErrorBox.DialResult.Ignore;
				}
				return result;
			}
			case POIDatas.errorCodes.NRT3OutOfRange:
			{
				bool flag = MySettingsProperty.Settings.importErrIncCoord;
				if (flag)
				{
					errText = string.Format(Resources.strErrNRT3OutOfRange, numLine, fileName, currentRow[idx.NRT3]);
					result = MyProject.Forms.NonFatalErrorBox.showError(errText, currentRow, true, true, true, multipleImport);
				}
				else
				{
					result = NonFatalErrorBox.DialResult.Ignore;
				}
				return result;
			}
			}
			errText = string.Format(Resources.strErrUnknown, numLine, fileName);
			result = MyProject.Forms.NonFatalErrorBox.showError(errText, currentRow, true, true, true, multipleImport);
			return result;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0011DEFC File Offset: 0x0011CEFC
		private string calcNameForExport(string strName)
		{
			bool fromRT3Map = this._fromRT3Map;
			string result;
			if (fromRT3Map)
			{
				result = POILists.translateInFileName(string.Format("{0:G}-{1:G}", Inifiles.GetKey(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP DESCRIPTION", "mapName"), strName));
			}
			else
			{
				result = POILists.translateInFileName(strName);
			}
			return result;
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x0011DF58 File Offset: 0x0011CF58
		public SortedDictionary<ushort, int> buildBrandDict()
		{
			bool flag = this._sdBrandIdx == null;
			if (flag)
			{
				this._sdBrandIdx = new SortedDictionary<ushort, int>();
				try
				{
					foreach (POIDatas poidatas in this._listOfPOI)
					{
						flag = !this._sdBrandIdx.ContainsKey(poidatas.brandIdx);
						if (flag)
						{
							this._sdBrandIdx.Add(poidatas.brandIdx, 1);
						}
					}
				}
				finally
				{
					List<POIDatas>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			return this._sdBrandIdx;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0011DFFC File Offset: 0x0011CFFC
		public int FindDuplicates(List<POILists> refList, int dist)
		{
			int num = 0;
			bool flag = this.maxDist != dist;
			if (flag)
			{
				POIDatas.maxDist = dist;
				try
				{
					foreach (POIDatas poidatas in this._listOfPOI)
					{
						poidatas.buildNeighborCells(dist);
					}
				}
				finally
				{
					List<POIDatas>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.maxDist = dist;
			}
			this._listOfPOIToKeep = new List<POIDatas>();
			this._listOfPOIInDup = new List<POIDatas>();
			checked
			{
				try
				{
					foreach (POIDatas poidatas in this._listOfPOI)
					{
						bool flag2 = true;
						try
						{
							foreach (POILists poilists in refList)
							{
								flag = poidatas.isDup(poilists._sdPOIByCell);
								if (flag)
								{
									flag2 = false;
									break;
								}
							}
						}
						finally
						{
							List<POILists>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						flag = flag2;
						if (flag)
						{
							this._listOfPOIToKeep.Add(poidatas);
						}
						else
						{
							this._listOfPOIInDup.Add(poidatas);
							num++;
						}
					}
				}
				finally
				{
					List<POIDatas>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				return num;
			}
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0011E168 File Offset: 0x0011D168
		public POILists removeDup()
		{
			bool flag = this._listOfPOIToKeep.Count == 0;
			POILists result;
			if (flag)
			{
				result = null;
			}
			else
			{
				this._listOfPOI = null;
				this._listOfPOI = this._listOfPOIToKeep;
				this._listOfPOIInDup = null;
				this._sdPOIByCell = null;
				this.maxDist = 0;
				result = this;
			}
			return result;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0011E1C0 File Offset: 0x0011D1C0
		public void buildSdPOIByCell(int brandIdx)
		{
			List<POIDatas> list = null;
			bool flag = this._sdPOIByCell == null || brandIdx != this.brandIdx;
			if (flag)
			{
				this._sdPOIByCell = new SortedDictionary<uint, List<POIDatas>>();
				try
				{
					foreach (POIDatas poidatas in this._listOfPOI)
					{
						uint key = poidatas.cellId();
						flag = (brandIdx == 65535 || brandIdx == (int)poidatas.brandIdx);
						if (flag)
						{
							bool flag2 = !this._sdPOIByCell.TryGetValue(key, out list);
							if (flag2)
							{
								list = new List<POIDatas>();
								this._sdPOIByCell.Add(key, list);
							}
							list.Add(poidatas);
						}
					}
				}
				finally
				{
					List<POIDatas>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.brandIdx = brandIdx;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0011E2A0 File Offset: 0x0011D2A0
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x0011E2B8 File Offset: 0x0011D2B8
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				bool flag = this._allwaysLoad;
				if (flag)
				{
					string cle = this.calcNameForExport(value);
					flag = (Operators.CompareString(Inifiles.GetKey(MyProject.Forms.FormMain.mapMngt.mapIniName, "MAP ADDED", cle), "", false) != 0);
					if (flag)
					{
						Interaction.MsgBox(string.Format(Resources.strWarningListExists1, value), MsgBoxStyle.Exclamation, null);
					}
					else
					{
						this.removeAllwaysLoad();
						this._name = value;
						this.setAllwaysLoad();
					}
				}
				else
				{
					this._name = value;
				}
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0011E348 File Offset: 0x0011D348
		public string nameForExport
		{
			get
			{
				return this.calcNameForExport(this._name);
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0011E368 File Offset: 0x0011D368
		public bool allwaysLoad
		{
			get
			{
				return this._allwaysLoad;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0011E380 File Offset: 0x0011D380
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x0011E398 File Offset: 0x0011D398
		public List<POIDatas> ListofPOI
		{
			get
			{
				return this._listOfPOI;
			}
			set
			{
				this._listOfPOI = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0011E3A4 File Offset: 0x0011D3A4
		public int POINumber
		{
			get
			{
				bool flag = this._listOfPOI != null;
				int result;
				if (flag)
				{
					result = this._listOfPOI.Count;
				}
				else
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x0011E3DC File Offset: 0x0011D3DC
		public bool fromRT3
		{
			get
			{
				return this._fromRT3;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0011E3F4 File Offset: 0x0011D3F4
		public bool fromRT3Map
		{
			get
			{
				return this._fromRT3Map;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x0011E40C File Offset: 0x0011D40C
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x0011E424 File Offset: 0x0011D424
		public bool fullPatch
		{
			get
			{
				return this._fullPatch;
			}
			set
			{
				this._fullPatch = value;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0011E430 File Offset: 0x0011D430
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x0011E448 File Offset: 0x0011D448
		public bool displayMagnitude
		{
			get
			{
				return this._displayMagnitude;
			}
			set
			{
				this._displayMagnitude = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0011E454 File Offset: 0x0011D454
		public SortedDictionary<ushort, int> sdBrandIdx
		{
			get
			{
				return this._sdBrandIdx;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x0011E46C File Offset: 0x0011D46C
		public bool fromArchive
		{
			get
			{
				return this._fromArchive;
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0011E484 File Offset: 0x0011D484
		public static string translateInFileName(string name)
		{
			string text = POILists.forbiddenChars;
			int i = 0;
			int length = text.Length;
			checked
			{
				while (i < length)
				{
					char oldChar = text[i];
					name = name.Replace(oldChar, '-');
					i++;
				}
				return name;
			}
		}

		// Token: 0x04000512 RID: 1298
		private string _name;

		// Token: 0x04000513 RID: 1299
		private List<POIDatas> _listOfPOI;

		// Token: 0x04000514 RID: 1300
		private List<POIDatas> _listOfPOIToKeep;

		// Token: 0x04000515 RID: 1301
		private List<POIDatas> _listOfPOIInDup;

		// Token: 0x04000516 RID: 1302
		public bool _fromRT3;

		// Token: 0x04000517 RID: 1303
		private bool _fromRT3Map;

		// Token: 0x04000518 RID: 1304
		public bool _fullPatch;

		// Token: 0x04000519 RID: 1305
		public bool _displayMagnitude;

		// Token: 0x0400051A RID: 1306
		public bool isReadOnly;

		// Token: 0x0400051B RID: 1307
		public bool noDelete;

		// Token: 0x0400051C RID: 1308
		private bool _fromArchive;

		// Token: 0x0400051D RID: 1309
		public ushort type;

		// Token: 0x0400051E RID: 1310
		public byte scale;

		// Token: 0x0400051F RID: 1311
		public byte layer;

		// Token: 0x04000520 RID: 1312
		public byte magnitude;

		// Token: 0x04000521 RID: 1313
		public uint speed;

		// Token: 0x04000522 RID: 1314
		public POIName POIName;

		// Token: 0x04000523 RID: 1315
		private bool _allwaysLoad;

		// Token: 0x04000524 RID: 1316
		private SortedDictionary<uint, List<POIDatas>> _sdPOIByCell;

		// Token: 0x04000525 RID: 1317
		private int brandIdx;

		// Token: 0x04000526 RID: 1318
		private SortedDictionary<ushort, int> _sdBrandIdx;

		// Token: 0x04000527 RID: 1319
		private int maxDist;

		// Token: 0x04000528 RID: 1320
		private static string forbiddenChars = new string(Path.GetInvalidFileNameChars()) + "=";

		// Token: 0x04000529 RID: 1321
		public POILists.state _state;

		// Token: 0x02000067 RID: 103
		public enum state
		{
			// Token: 0x0400052B RID: 1323
			empty,
			// Token: 0x0400052C RID: 1324
			original,
			// Token: 0x0400052D RID: 1325
			added,
			// Token: 0x0400052E RID: 1326
			originalRemoved,
			// Token: 0x0400052F RID: 1327
			addedRemoved
		}
	}
}
