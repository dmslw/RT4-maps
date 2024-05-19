using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000047 RID: 71
	public class MAPMngt
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x00109AC4 File Offset: 0x00108AC4
		public MAPMngt()
		{
			this.importedPOIList = null;
			this.mapType = Common.RTxMapType.Unknown;
			this.LSColumnNb = 0U;
			this.LSLineNb = 0U;
			this.LSNb = 0U;
			this.POIcategoryInfo = null;
			this.POITypeInfo = null;
			this.GEOCART = null;
			this.CATPOI = null;
			this.FRANC_EX_DPS = null;
			this.SCITTANAME_DAT = null;
			this.DCN_CAT = null;
			this.FRANCCOM_LET = null;
			this.PrefInt = null;
			this.FRANCAT_POI = null;
			this.mapIniName = null;
			this.countryMap = "";
			this.mapCDId = "";
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00109B60 File Offset: 0x00108B60
		public void createCultDepItems(Common.RTxMapEditorMapModes RTxMapEditorMapMode)
		{
			this.POITypeInfo = new POITypeInfo(Common.RTxType, RTxMapEditorMapMode);
			this.importedPOIList = new ImportedPOILists();
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00109B80 File Offset: 0x00108B80
		public bool loadMap(Common.RTxTypes RTxype, bool reloadMap, string mapPath)
		{
			bool flag = mapPath != null;
			if (flag)
			{
				MySettingsProperty.Settings.WorkingDir = mapPath;
			}
			try
			{
				bool flag2;
				if (!reloadMap && this.FRANC_EX_DPS != null)
				{
					if (this.FRANC_EX_DPS.isUpToDate(this.POIcategoryInfo.getMainPOIRT3File2Read("_EX.DPS")))
					{
						flag2 = false;
						goto IL_4A;
					}
				}
				flag2 = true;
				IL_4A:
				flag = flag2;
				if (flag)
				{
					this.unloadMap();
				}
				this.mapIniName = Path.Combine(MySettingsProperty.Settings.WorkingDir, "map.ini");
				flag = !MyProject.Computer.FileSystem.FileExists(this.mapIniName);
				if (flag)
				{
					throw new Exception(string.Format("{0:G} not found, map not loaded", this.mapIniName));
				}
				flag = (ConfigDialog.isConfigComplete() != ConfigDialog.configStatus.OK);
				if (flag)
				{
					throw new Exception(string.Format("{0:G} not found, map not loaded", this.mapIniName));
				}
				string key = Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "mapType");
				this.mapType = Common.getMapType(key);
				this.countryMap = Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "mapCountry");
				this.mapName = Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "mapName");
				this.mapDesc = Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "mapDesc");
				this.hddMap = Conversions.ToBoolean(Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "hddMap"));
				flag = !int.TryParse(Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "mapVers"), NumberStyles.Integer, Common.cultENUS, out this.mapVers);
				if (flag)
				{
					this.mapVers = 0;
				}
				flag = !int.TryParse(Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "mapRel"), NumberStyles.Integer, Common.cultENUS, out this.mapRel);
				if (flag)
				{
					this.mapRel = 0;
				}
				MyProject.Application.Log.WriteEntry(string.Format("loadMap() begin : {0:G} type {1:G} country {2:G} ", new object[]
				{
					Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "mapName"),
					key,
					this.countryMap,
					TraceEventType.Information
				}));
				FormMain formMain = MyProject.Forms.FormMain;
				this.POIcategoryInfo = new POICategoryInfos(this.POITypeInfo);
				bool flag3;
				if (!reloadMap && this.FRANC_EX_DPS != null)
				{
					if (this.FRANC_EX_DPS.isUpToDate(this.POIcategoryInfo.getMainPOIRT3File2Read("_EX.DPS")))
					{
						flag3 = false;
						goto IL_275;
					}
				}
				flag3 = true;
				IL_275:
				flag = flag3;
				if (flag)
				{
					DateTime now = DateAndTime.Now;
					Application.DoEvents();
					Cursor cursor = formMain.Cursor;
					formMain.Cursor = Cursors.WaitCursor;
					formMain.wizardState.OperationInProgress(Resources.strImportFromRT3Start);
					formMain.ToolStripProgressBar1.Style = ProgressBarStyle.Blocks;
					formMain.ToolStripProgressBar1.Minimum = 0;
					formMain.ToolStripProgressBar1.Maximum = 23;
					this.GEOCART = new GEOCART(this.POIcategoryInfo.getMainPOIRT3File2Read(".Geo"), this.mapType);
					this.CATPOI = new CATPOI(this.POIcategoryInfo.getMainPOIRT3File2Read("CAT.POI"), this.mapType);
					this.LSColumnNb = this.GEOCART.LSColumnNb;
					this.LSLineNb = this.GEOCART.LSLineNb;
					this.LSNb = this.GEOCART.LSNb;
					this.importedPOIList.InitList(Common.getMapType(key), this.countryMap, this.LSColumnNb, this.LSLineNb, this.LSNb, Common.RTxMapEditorMapModes.map);
					Application.DoEvents();
					this.FRANC_EX_DPS = new FRANC_EX_DPS(this.POIcategoryInfo.getMainPOIRT3File2Read("_EX.DPS"), this.LSNb);
					this.SCITTANAME_DAT = new SCITTANAME_DAT(this.POIcategoryInfo.getMainPOIRT3File2Read("SCITTANAME.DAT"));
					this.PrefInt = new PrefInt(this.POIcategoryInfo.getMainPOIRT3File2Read("PrefInt"));
					this.FRANCAT_POI = new FRANCAT_POI(this.POIcategoryInfo.getMainPOIRT3File2Read("CAT.POI"));
					formMain.ToolStripProgressBar1.Value = 1;
					Application.DoEvents();
					this.ImportFromRT3(RTxype);
					formMain.Cursor = cursor;
					formMain.ToolStripProgressBar1.Value = 0;
					Application.DoEvents();
					TimeSpan timeSpan = DateAndTime.Now.Subtract(now);
					MyProject.Application.Log.WriteEntry("import done in " + Conversions.ToString(timeSpan.TotalMilliseconds));
				}
				flag = (this.importedPOIList.ListOfPOIList != null);
				if (flag)
				{
					MySettingsProperty.Settings.configCompleteOnce = true;
					formMain.userSettings.lastLoadedMaps.addEntry(MySettingsProperty.Settings.WorkingDir, this.mapDesc);
					formMain.wizardState.changeState(WizardState.states.LOADED);
					formMain.ImportedFilesListBox.SelectedIndex = -1;
					formMain.ImportedFilesListBox.SelectedIndex = checked(formMain.ImportedFilesListBox.Items.Count - 1);
					MySettingsProperty.Settings.ISODir = Inifiles.GetKey(this.mapIniName, "MAP DESCRIPTION", "ISOPath");
				}
				else
				{
					MyProject.Application.Log.WriteEntry(string.Format(Resources.strErrNoMapFound, MySettingsProperty.Settings.WorkingDir), TraceEventType.Information);
					Interaction.MsgBox(string.Format(Resources.strErrNoMapFound, MySettingsProperty.Settings.WorkingDir), MsgBoxStyle.Exclamation, null);
					formMain.wizardState.changeState(WizardState.states.NOT_LOADED);
					formMain.userSettings.lastLoadedMaps.removeEntry(MySettingsProperty.Settings.WorkingDir);
					formMain.ImportedFilesListBox.SelectedIndex = -1;
					MySettingsProperty.Settings.WorkingDir = "";
					MySettingsProperty.Settings.ISODir = "";
				}
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteEntry(string.Format(Resources.strErrNoMapFound, MySettingsProperty.Settings.WorkingDir), TraceEventType.Information);
				Interaction.MsgBox(string.Format(Resources.strErrNoMapFound, MySettingsProperty.Settings.WorkingDir), MsgBoxStyle.Exclamation, null);
				MyProject.Forms.FormMain.wizardState.changeState(WizardState.states.NOT_LOADED);
				MyProject.Forms.FormMain.userSettings.lastLoadedMaps.removeEntry(MySettingsProperty.Settings.WorkingDir);
				MySettingsProperty.Settings.WorkingDir = "";
				MySettingsProperty.Settings.ISODir = "";
			}
			MyProject.Application.Log.WriteEntry("loadMap() end", TraceEventType.Information);
			return true;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0010A224 File Offset: 0x00109224
		public void unloadMap()
		{
			this.importedPOIList.ClearList();
			this.mapType = Common.RTxMapType.Unknown;
			this.LSColumnNb = 0U;
			this.LSLineNb = 0U;
			this.LSNb = 0U;
			this.GEOCART = null;
			this.CATPOI = null;
			this.FRANC_EX_DPS = null;
			this.SCITTANAME_DAT = null;
			this.DCN_CAT = null;
			this.FRANCCOM_LET = null;
			this.PrefInt = null;
			this.FRANCAT_POI = null;
			this.mapIniName = null;
			this.countryMap = "";
			this.mapCDId = "";
			this.mapVers = 0;
			this.mapRel = 0;
			this.mapName = "";
			this.hddMap = false;
			this.mapDesc = "";
			MyProject.Forms.FormMain.wizardState.changeState(WizardState.states.NOT_LOADED);
			MyProject.Forms.FormMain.ImportedFilesListBox.SelectedIndex = -1;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0010A308 File Offset: 0x00109308
		public void reloadMap()
		{
			Inifiles.DeleteSection(this.mapIniName, "MAP CONTENT");
			this.loadMap(Common.RTxType, true, null);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0010A32C File Offset: 0x0010932C
		public bool loadFictMap(string CID)
		{
			try
			{
				this.mapCDId = CID;
				this.countryMap = Common.getCIDStr(CID);
				this.mapDesc = Common.getCIDStr(CID);
				string text = Path.Combine(MySettingsProperty.Settings.WorkingDirAlert, "dest");
				bool flag = !MyProject.Computer.FileSystem.DirectoryExists(MySettingsProperty.Settings.WorkingDirAlert);
				if (flag)
				{
					MyProject.Computer.FileSystem.CreateDirectory(MySettingsProperty.Settings.WorkingDirAlert);
				}
				flag = MyProject.Computer.FileSystem.DirectoryExists(text);
				if (flag)
				{
					MyProject.Computer.FileSystem.DeleteDirectory(text, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
				}
				MyProject.Computer.FileSystem.CreateDirectory(text);
				MyProject.Computer.FileSystem.CreateDirectory(Path.Combine(text, string.Format("{0:G}\\{1:G}", "MAPPE\\POI_USER", CID)));
				CopyMap.copyAlertFiles(CID);
				this.LSColumnNb = GEOCART.defaultLSColumnNb;
				this.LSLineNb = GEOCART.defaultLSLineNb;
				this.LSNb = GEOCART.defaultLSNb;
				this.SCITTANAME_DAT = new SCITTANAME_DAT();
				this.PrefInt = new PrefInt();
				this.FRANCAT_POI = new FRANCAT_POI();
				FormMain formMain = MyProject.Forms.FormMain;
				this.POIcategoryInfo = new POICategoryInfos(this.POITypeInfo);
				this.importedPOIList.InitList(Common.RTxMapType.RT4, CID, this.LSColumnNb, this.LSLineNb, this.LSNb, Common.RTxMapEditorMapModes.alert);
				formMain.wizardState.changeState(WizardState.states.LOADED);
				formMain.ImportedFilesListBox.SelectedIndex = -1;
				formMain.ImportedFilesListBox.SelectedIndex = checked(formMain.ImportedFilesListBox.Items.Count - 1);
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteEntry(string.Format(Resources.strErrFictMapNotCreated, MySettingsProperty.Settings.WorkingDirAlert), TraceEventType.Information);
				MyProject.Application.Log.WriteEntry(ex.Message, TraceEventType.Information);
				Interaction.MsgBox(string.Format(string.Format(Resources.strErrFictMapNotCreated, MySettingsProperty.Settings.WorkingDirAlert), MsgBoxStyle.Exclamation), MsgBoxStyle.OkOnly, null);
				MyProject.Forms.FormMain.wizardState.changeState(WizardState.states.NOT_LOADED);
				return false;
			}
			MyProject.Application.Log.WriteEntry("loadFictMap() end", TraceEventType.Information);
			return true;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0010A5A0 File Offset: 0x001095A0
		private void ImportFromRT3(Common.RTxTypes RTxType)
		{
			MyProject.Application.Log.WriteEntry("ImportFromRT3() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			this.importedPOIList.importFromRT3Map(RTxType);
			bool flag = this.importedPOIList.ListOfPOIList != null;
			if (flag)
			{
				formMain.wizardState.changeState(WizardState.states.LOADED);
				formMain.ImportedFilesListBox.SelectedIndex = -1;
				formMain.ImportedFilesListBox.SelectedIndex = checked(formMain.ImportedFilesListBox.Items.Count - 1);
			}
			else
			{
				formMain.wizardState.changeState(WizardState.states.NOT_LOADED);
				formMain.ImportedFilesListBox.SelectedIndex = -1;
			}
			MyProject.Application.Log.WriteEntry("ImportFromRT3() end", TraceEventType.Information);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0010A660 File Offset: 0x00109660
		public void importPOI()
		{
			MyProject.Application.Log.WriteEntry("importPOI() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			bool flag = formMain.openFiles2ImportDialog.showDialog() == DialogResult.OK;
			if (flag)
			{
				bool flag2 = this.checkFileListForAdding(formMain.openFiles2ImportDialog.getFileNames());
				if (flag2)
				{
					this.importedPOIList.importFromFiles(formMain.openFiles2ImportDialog.getFileNames(), false);
					flag2 = (this.importedPOIList.ListOfPOIList != null);
					if (flag2)
					{
						formMain.wizardState.changeState(WizardState.states.LOADED);
						formMain.ImportedFilesListBox.SelectedIndex = -1;
						formMain.ImportedFilesListBox.SelectedIndex = checked(formMain.ImportedFilesListBox.Items.Count - 1);
					}
					else
					{
						formMain.ImportedFilesListBox.SelectedIndex = -1;
					}
				}
				else
				{
					Interaction.MsgBox(Resources.strCombinationNotAllowed, MsgBoxStyle.Exclamation, null);
				}
			}
			MyProject.Application.Log.WriteEntry("importPOI() end", TraceEventType.Information);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0010A75C File Offset: 0x0010975C
		public void importPOI(string[] filesName)
		{
			MyProject.Application.Log.WriteEntry("importPOI(filesName) begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			this.importedPOIList.importFromFiles(filesName, false);
			bool flag = this.importedPOIList.ListOfPOIList != null;
			if (flag)
			{
				formMain.wizardState.changeState(WizardState.states.LOADED);
				formMain.ImportedFilesListBox.SelectedIndex = -1;
				formMain.ImportedFilesListBox.SelectedIndex = checked(formMain.ImportedFilesListBox.Items.Count - 1);
			}
			else
			{
				formMain.ImportedFilesListBox.SelectedIndex = -1;
			}
			MyProject.Application.Log.WriteEntry("importPOI(filesName) end", TraceEventType.Information);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0010A810 File Offset: 0x00109810
		public bool checkFileListForAdding(string[] filesName)
		{
			int num = 0;
			int num2 = 0;
			bool flag = true;
			checked
			{
				bool flag2;
				foreach (string text in filesName)
				{
					flag2 = MyProject.Computer.FileSystem.FileExists(text);
					if (!flag2)
					{
						flag = false;
						break;
					}
					string left = Path.GetExtension(text).ToLower();
					flag2 = (Operators.CompareString(left, ".asc", false) == 0 || Operators.CompareString(left, ".csv", false) == 0);
					if (!flag2)
					{
						if (Operators.CompareString(left, ".rt3", false) == 0 || Operators.CompareString(left, ".zip", false) == 0)
						{
							goto IL_AB;
						}
						if (Operators.CompareString(Path.GetFileName(text).ToLower(), "google_earth_scdb.kmz", false) == 0)
						{
							goto IL_AB;
						}
						bool flag3 = false;
						IL_AC:
						flag2 = flag3;
						if (flag2)
						{
							num++;
							goto IL_BE;
						}
						flag = false;
						break;
						IL_AB:
						flag3 = true;
						goto IL_AC;
					}
					num2++;
					IL_BE:;
				}
				flag2 = flag;
				if (flag2)
				{
					bool flag4;
					if (num != 1 || num2 != 0)
					{
						if (num != 0 || num2 <= 0)
						{
							flag4 = false;
							goto IL_FD;
						}
					}
					flag4 = true;
					IL_FD:
					bool flag5 = flag4;
					flag = flag5;
				}
				else
				{
					flag = false;
				}
				return flag;
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0010A938 File Offset: 0x00109938
		public void patch()
		{
			MyProject.Application.Log.WriteEntry("patch() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			DateTime now = DateAndTime.Now;
			Application.DoEvents();
			Cursor cursor = formMain.Cursor;
			formMain.Cursor = Cursors.WaitCursor;
			bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map;
			if (flag)
			{
				MyProject.Forms.FormMain.wizardState.OperationInProgress(Resources.strExportToRT3Start);
			}
			else
			{
				MyProject.Forms.FormMain.wizardState.OperationInProgress(Resources.strExportToAlertStart);
			}
			MyProject.Forms.FormMain.ToolStripProgressBar1.Style = ProgressBarStyle.Blocks;
			MyProject.Forms.FormMain.ToolStripProgressBar1.Minimum = 0;
			MyProject.Forms.FormMain.ToolStripProgressBar1.Maximum = 4;
			Application.DoEvents();
			flag = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
			bool flag2;
			if (flag)
			{
				flag2 = this.importedPOIList.exportToRT3Map(now, this.mapVers, this.mapRel, this.mapName, this.hddMap);
			}
			else
			{
				flag2 = this.importedPOIList.exportToAlert(MySettingsProperty.Settings.alertDIRCID, MySettingsProperty.Settings.WorkingDirAlert);
			}
			formMain.Cursor = cursor;
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 0;
			Application.DoEvents();
			TimeSpan timeSpan = DateAndTime.Now.Subtract(now);
			MyProject.Application.Log.WriteEntry("export done in " + Conversions.ToString(timeSpan.TotalMilliseconds));
			flag = flag2;
			if (flag)
			{
				formMain.wizardState.changeState(WizardState.states.PATCHED);
			}
			else
			{
				formMain.wizardState.changeState(WizardState.states.NOCHANGE);
			}
			MyProject.Application.Log.WriteEntry("patch() end", TraceEventType.Information);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0010AB0C File Offset: 0x00109B0C
		public void genISO()
		{
			Cursor cursor = null;
			long num = 0L;
			string file = null;
			MyProject.Application.Log.WriteEntry("genISO() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			try
			{
				cursor = formMain.Cursor;
				formMain.Cursor = Cursors.WaitCursor;
				string text = null;
				string text2 = null;
				bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert;
				string text3;
				string text4;
				if (flag)
				{
					text3 = "RTxAlert";
					text = Path.Combine(MySettingsProperty.Settings.WorkingDirAlert, "RTxAlert") + ".iso";
					text2 = Path.Combine(MySettingsProperty.Settings.WorkingDirAlert, "dest");
					text4 = "1000000";
				}
				else
				{
					file = Path.Combine(MySettingsProperty.Settings.WorkingDir, "map.ini");
					text3 = Inifiles.GetKey(file, "MAP DESCRIPTION", "mapName");
					text4 = Inifiles.GetKey(file, "MAP DESCRIPTION", "mapSize");
					flag = (Common.RTxType != Common.RTxTypes.typeRT3 && MySettingsProperty.Settings.upgMap && CopyMap.isUpgradeSupported(this.mapVers, this.mapRel, text3));
					if (flag)
					{
						text = Path.Combine(MySettingsProperty.Settings.ISODir, text3) + "UPG.iso";
						text2 = Path.Combine(MySettingsProperty.Settings.WorkingDir, "destUPG");
						text4 = "60000000";
					}
					else
					{
						flag = (Common.RTxType != Common.RTxTypes.typeRT3 && MySettingsProperty.Settings.upgMap);
						if (flag)
						{
							Interaction.MsgBox(Resources.strNoUpgrade, MsgBoxStyle.Exclamation, null);
						}
						text = Path.Combine(MySettingsProperty.Settings.ISODir, text3) + ".iso";
						text2 = Path.Combine(MySettingsProperty.Settings.WorkingDir, "dest");
						text4 = Inifiles.GetKey(file, "MAP DESCRIPTION", "mapSize");
					}
				}
				flag = MyProject.Computer.FileSystem.FileExists(text);
				if (flag)
				{
					MyProject.Computer.FileSystem.DeleteFile(text);
				}
				flag = (Operators.CompareString(text4, "", false) == 0);
				if (flag)
				{
					Inifiles.SetKey(file, "MAP DESCRIPTION", "mapSize", "650000000");
					text4 = Inifiles.GetKey(file, "MAP DESCRIPTION", "mapSize");
				}
				try
				{
					flag = !long.TryParse(text4, out num);
					if (flag)
					{
						num = 650000000L;
					}
				}
				catch (Exception ex)
				{
					num = 650000000L;
				}
				DriveInfo driveInfo = new DriveInfo(text);
				flag = (driveInfo.AvailableFreeSpace < num);
				if (flag)
				{
					int num2 = checked((int)Math.Round(Math.Round((double)num / 1048576.0)));
					Interaction.MsgBox(string.Format(Resources.strNotEnoughSpace, driveInfo.Name, num2), MsgBoxStyle.Exclamation, null);
				}
				else
				{
					string arguments = string.Format("-iso-level 2 -J -rational-rock -A \"RTxMapEditor {0:G}\" -publisher \"Janfi67@planete-citroen.com\" -preparer \"Janfi67@planete-citroen.com\" -o \"{1:G}\" -V {2:G} \"{3:G}\"", new object[]
					{
						MyProject.Application.Info.Version.ToString(),
						text,
						text3,
						text2
					});
					ProcessStartInfo processStartInfo = new ProcessStartInfo("mkisofs.exe", arguments);
					processStartInfo.CreateNoWindow = true;
					processStartInfo.RedirectStandardError = true;
					processStartInfo.UseShellExecute = false;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.WorkingDirectory = MyProject.Forms.FormMain.CurrentWorkingDir;
					formMain.wizardState.OperationInProgress(Resources.strISOStart);
					Application.DoEvents();
					Process process = Process.Start(processStartInfo);
					process.PriorityClass = ProcessPriorityClass.BelowNormal;
					int id = process.Id;
					int value = 0;
					string text5 = process.StandardError.ReadLine();
					MyProject.Forms.FormMain.ToolStripProgressBar1.Style = ProgressBarStyle.Blocks;
					MyProject.Forms.FormMain.ToolStripProgressBar1.Minimum = 0;
					MyProject.Forms.FormMain.ToolStripProgressBar1.Maximum = 100;
					while (text5 != null)
					{
						MyProject.Forms.FormMain.ToolStripStatusLabelSatus.Text = Resources.strISOInProgress;
						MyProject.Application.Log.WriteEntry(text5, TraceEventType.Information);
						flag = int.TryParse(text5.Substring(0, Math.Max(text5.IndexOf("."), 0)), out value);
						if (flag)
						{
							MyProject.Forms.FormMain.ToolStripProgressBar1.Value = value;
						}
						Application.DoEvents();
						text5 = process.StandardError.ReadLine();
					}
					process.WaitForExit();
					MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 0;
					int num3 = -1;
					flag = process.HasExited;
					if (flag)
					{
						num3 = process.ExitCode;
					}
					flag = (num3 != 0);
					if (flag)
					{
						Interaction.MsgBox(string.Format(Resources.strISOErrRun, num3), MsgBoxStyle.Critical, null);
						formMain.wizardState.changeState(WizardState.states.NOCHANGE);
						return;
					}
				}
			}
			catch (Exception ex2)
			{
				formMain.wizardState.changeState(WizardState.states.NOCHANGE);
				Interaction.MsgBox(Resources.strISOError, MsgBoxStyle.Critical, null);
				return;
			}
			finally
			{
				formMain.Cursor = cursor;
			}
			formMain.wizardState.changeState(WizardState.states.ISOOK);
			formMain = null;
			MyProject.Application.Log.WriteEntry("genISO() end", TraceEventType.Information);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0010B0A4 File Offset: 0x0010A0A4
		public void copyToUSB()
		{
			string file = Path.Combine(MySettingsProperty.Settings.WorkingDir, "map.ini");
			string key = Inifiles.GetKey(file, "MAP DESCRIPTION", "mapName");
			string text = null;
			Cursor cursor = null;
			MyProject.Application.Log.WriteEntry("copyToUSB() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map && this.mapType != Common.RTxMapType.RT4;
			if (flag)
			{
				Interaction.MsgBox(Resources.strErrRT4Only, MsgBoxStyle.Exclamation, null);
			}
			else
			{
				flag = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert);
				string text2;
				if (flag)
				{
					text2 = Path.Combine(MySettingsProperty.Settings.WorkingDirAlert, "dest");
				}
				else
				{
					flag = (Common.RTxType != Common.RTxTypes.typeRT3 && MySettingsProperty.Settings.upgMap && CopyMap.isUpgradeSupported(this.mapVers, this.mapRel, key));
					if (flag)
					{
						text2 = Path.Combine(MySettingsProperty.Settings.WorkingDir, "destUPG");
					}
					else
					{
						flag = (Common.RTxType != Common.RTxTypes.typeRT3 && MySettingsProperty.Settings.upgMap);
						if (flag)
						{
							Interaction.MsgBox(Resources.strNoUpgrade, MsgBoxStyle.Exclamation, null);
						}
						text2 = Path.Combine(MySettingsProperty.Settings.WorkingDir, "dest");
					}
				}
				long size = CopyMap.getSize(text2, false, "");
				SelectFlashDriveDialog selectFlashDriveDialog = new SelectFlashDriveDialog(size);
				flag = (selectFlashDriveDialog.ShowDialog() == DialogResult.OK);
				if (flag)
				{
					text = selectFlashDriveDialog.getDriveToUse();
					flag = (Interaction.MsgBox(string.Format(Resources.strWarningEraseDrive, text), MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question, null) == MsgBoxResult.Yes);
					if (flag)
					{
						try
						{
							MyProject.Forms.FormMain.wizardState.OperationInProgress(Resources.strStatusUSBErase);
							cursor = formMain.Cursor;
							formMain.Cursor = Cursors.WaitCursor;
							MyProject.Forms.FormMain.ToolStripProgressBar1.MarqueeAnimationSpeed = 150;
							MyProject.Forms.FormMain.ToolStripProgressBar1.Visible = true;
							MyProject.Forms.FormMain.ToolStripProgressBar1.Enabled = true;
							Application.DoEvents();
							foreach (string path in Directory.GetDirectories(text, "*", System.IO.SearchOption.TopDirectoryOnly))
							{
								MyProject.Computer.FileSystem.DeleteDirectory(Path.Combine(text, path), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
							}
							foreach (string path2 in Directory.GetFiles(text, "*", System.IO.SearchOption.TopDirectoryOnly))
							{
								MyProject.Computer.FileSystem.DeleteFile(Path.Combine(text, path2), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
							}
							MyProject.Forms.FormMain.wizardState.OperationInProgress(Resources.strCopyMap2USB);
							Application.DoEvents();
							MyProject.Computer.FileSystem.CopyDirectory(text2, text, UIOption.AllDialogs, UICancelOption.DoNothing);
						}
						catch (Exception ex)
						{
							Interaction.MsgBox(Resources.strNoUpgrade, MsgBoxStyle.Critical, null);
							formMain.wizardState.changeState(WizardState.states.NOCHANGE);
							return;
						}
						finally
						{
							MyProject.Forms.FormMain.ToolStripProgressBar1.MarqueeAnimationSpeed = 0;
							formMain.Cursor = cursor;
							DriveController driveController = new DriveController();
							driveController.Eject(text);
						}
						formMain.wizardState.changeState(WizardState.states.USBOK);
						Interaction.MsgBox(Resources.strUSBOK, MsgBoxStyle.Information, null);
					}
				}
				formMain = null;
				MyProject.Application.Log.WriteEntry("copyToUSB() end", TraceEventType.Information);
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0010B45C File Offset: 0x0010A45C
		public void burn()
		{
			MyProject.Application.Log.WriteEntry("burn() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			bool flag = Operators.CompareString(MySettingsProperty.Settings.BurningCommand, "", false) == 0 | !MyProject.Computer.FileSystem.FileExists(MySettingsProperty.Settings.BurningCommand);
			if (flag)
			{
				MyProject.Application.Log.WriteEntry(Resources.strErrNoBurnerConfigured, TraceEventType.Error);
				Interaction.MsgBox(Resources.strErrNoBurnerConfigured, MsgBoxStyle.Critical, null);
				flag = (MyProject.Forms.ConfigDialog.ShowDialog(ConfigDialog.tabList.general, ConfigDialog.tabList.general) != DialogResult.OK);
				if (flag)
				{
					MyProject.Application.Log.WriteEntry(Resources.strErrNoBurnerConfigured, TraceEventType.Error);
					return;
				}
			}
			try
			{
				flag = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert);
				string str;
				if (flag)
				{
					str = Path.Combine(MySettingsProperty.Settings.WorkingDirAlert, "RTxAlert") + ".iso";
				}
				else
				{
					string file = Path.Combine(MySettingsProperty.Settings.WorkingDir, "map.ini");
					string key = Inifiles.GetKey(file, "MAP DESCRIPTION", "mapName");
					flag = (Common.RTxType != Common.RTxTypes.typeRT3 && MySettingsProperty.Settings.upgMap && CopyMap.isUpgradeSupported(this.mapVers, this.mapRel, key));
					if (flag)
					{
						str = Path.Combine(MySettingsProperty.Settings.ISODir, key) + "UPG.iso";
					}
					else
					{
						flag = (Common.RTxType != Common.RTxTypes.typeRT3 && MySettingsProperty.Settings.upgMap);
						if (flag)
						{
							Interaction.MsgBox(Resources.strNoUpgradeCD, MsgBoxStyle.Exclamation, null);
						}
						str = Path.Combine(MySettingsProperty.Settings.ISODir, key) + ".iso";
					}
				}
				Process process = Process.Start(MySettingsProperty.Settings.BurningCommand, "\"" + str + "\"");
				int id = process.Id;
				process.WaitForExit();
				flag = process.HasExited;
				if (flag)
				{
					int exitCode = process.ExitCode;
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(Resources.strErrBurnCmd, MsgBoxStyle.Critical, null);
				return;
			}
			formMain.wizardState.changeState(WizardState.states.BURNED);
			formMain = null;
			MyProject.Application.Log.WriteEntry("burn() end", TraceEventType.Information);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0010B6D4 File Offset: 0x0010A6D4
		public void RT4map2USB()
		{
			USBMapDialog usbmapDialog = new USBMapDialog();
			string text = null;
			Cursor cursor = null;
			MyProject.Application.Log.WriteEntry("RT4map2USB() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			bool flag = usbmapDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				text = usbmapDialog.getDriveToUse();
				flag = (Interaction.MsgBox(string.Format(Resources.strWarningEraseDrive, text), MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question, null) == MsgBoxResult.Yes);
				if (flag)
				{
					try
					{
						MyProject.Forms.FormMain.wizardState.OperationInProgress(Resources.strStatusUSBErase);
						cursor = formMain.Cursor;
						formMain.Cursor = Cursors.WaitCursor;
						formMain.ToolStripProgressBar1.MarqueeAnimationSpeed = 150;
						formMain.ToolStripProgressBar1.Visible = true;
						formMain.ToolStripProgressBar1.Enabled = true;
						Application.DoEvents();
						foreach (string path in Directory.GetDirectories(text, "*", System.IO.SearchOption.TopDirectoryOnly))
						{
							MyProject.Computer.FileSystem.DeleteDirectory(Path.Combine(text, path), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
						}
						foreach (string path2 in Directory.GetFiles(text, "*", System.IO.SearchOption.TopDirectoryOnly))
						{
							MyProject.Computer.FileSystem.DeleteFile(Path.Combine(text, path2), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
						}
						formMain.wizardState.OperationInProgress(Resources.strStatusUpgradeUSBKey);
						Application.DoEvents();
						CopyMap.fillKeyToCopyMap(text, this.countryMap, usbmapDialog.getCIDList(), usbmapDialog.getFastCopy(), usbmapDialog.getTraceHigh(), usbmapDialog.getCRCCheck());
					}
					catch (Exception ex)
					{
						Interaction.MsgBox(Resources.strUSBNOK, MsgBoxStyle.Critical, null);
						formMain.wizardState.changeState(WizardState.states.NOCHANGE);
						return;
					}
					finally
					{
						MyProject.Forms.FormMain.ToolStripProgressBar1.MarqueeAnimationSpeed = 0;
						formMain.Cursor = cursor;
						DriveController driveController = new DriveController();
						driveController.Eject(text);
					}
					formMain.wizardState.changeState(WizardState.states.NOCHANGE);
					Interaction.MsgBox(Resources.strUSBOK, MsgBoxStyle.Information, null);
				}
			}
			formMain = null;
			MyProject.Application.Log.WriteEntry("RT4map2USB() end", TraceEventType.Information);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0010B950 File Offset: 0x0010A950
		public void addAllPOI()
		{
			string[] array = new string[]
			{
				""
			};
			MyProject.Application.Log.WriteEntry("addAllPOI() begin", TraceEventType.Information);
			bool flag = MyProject.Forms.AllPOIParamDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				double lat = MyProject.Forms.AllPOIParamDialog.lat;
				double lon = MyProject.Forms.AllPOIParamDialog.lon;
				uint num;
				uint num2;
				int num3;
				projection projection;
				uint num4;
				uint num10;
				uint num11;
				LP lp;
				checked
				{
					num = (uint)MyProject.Forms.AllPOIParamDialog.EWSpacing;
					num2 = (uint)MyProject.Forms.AllPOIParamDialog.NSSpacing;
					num3 = Convert.ToInt32(MyProject.Forms.AllPOIParamDialog.POIplNumericUpDown.Value);
					projection = new projection();
					flag = !projection.init(Common.RTxMapType.RT4);
					if (flag)
					{
						MyProject.Forms.FatalErrorBox.showError("Fatal error during projection initialization");
					}
					XY xy = projection.proj(lon, lat);
					num4 = (uint)Math.Round(Math.Round(xy.X));
					uint num5 = (uint)Math.Round(Math.Round(xy.Y));
					ushort num6 = (ushort)(unchecked((ulong)num4 / 256000UL % (ulong)this.LSColumnNb) + unchecked((ulong)this.LSColumnNb) * (unchecked((ulong)num5) / 256000UL));
					ushort num7 = (ushort)((byte)(unchecked((ulong)num4) % 256000UL / 16000UL + 16UL * (unchecked((ulong)num5) % 256000UL / 16000UL)));
					byte b = (byte)(unchecked((ulong)num4) % 16000UL / 1000UL + 16UL * (unchecked((ulong)num5) % 16000UL / 1000UL));
					ushort num8 = (ushort)(unchecked((ulong)num4) % 1000UL);
					ushort num9 = (ushort)(unchecked((ulong)num5) % 1000UL);
					num10 = num4;
					num11 = num5;
					lp = projection.proj_inv(num10, num11);
				}
				double num12 = Math.Round(180.0 * lp.phi / 3.141592653589793, 6);
				double num13 = Math.Round(180.0 * lp.lam / 3.141592653589793, 6);
				int num14 = 1;
				string text = Path.Combine(Path.GetTempPath(), "tmp.asc");
				try
				{
					foreach (ushort type in this.POITypeInfo.allDefinedTypes)
					{
						exportToFile.exportOneSampleToAsc(text, num13.ToString(Common.cultENUS), num12.ToString(Common.cultENUS), this.POITypeInfo.getNameOfType(type));
						array[0] = text;
						this.importedPOIList.importFromFiles(array, false).setType(type);
						checked
						{
							num14++;
							flag = (num14 > num3);
							if (flag)
							{
								num14 = 1;
								num11 -= num2;
								num10 = num4;
							}
							else
							{
								num10 += num;
							}
							lp = projection.proj_inv(num10, num11);
						}
						num12 = Math.Round(180.0 * lp.phi / 3.141592653589793, 6);
						num13 = Math.Round(180.0 * lp.lam / 3.141592653589793, 6);
					}
				}
				finally
				{
					List<ushort>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			MyProject.Application.Log.WriteEntry("addAllPOI() end", TraceEventType.Information);
		}

		// Token: 0x0400044B RID: 1099
		public ImportedPOILists importedPOIList;

		// Token: 0x0400044C RID: 1100
		public Common.RTxMapType mapType;

		// Token: 0x0400044D RID: 1101
		public uint LSColumnNb;

		// Token: 0x0400044E RID: 1102
		public uint LSLineNb;

		// Token: 0x0400044F RID: 1103
		public uint LSNb;

		// Token: 0x04000450 RID: 1104
		public POICategoryInfos POIcategoryInfo;

		// Token: 0x04000451 RID: 1105
		public POITypeInfo POITypeInfo;

		// Token: 0x04000452 RID: 1106
		private GEOCART GEOCART;

		// Token: 0x04000453 RID: 1107
		public CATPOI CATPOI;

		// Token: 0x04000454 RID: 1108
		public FRANC_EX_DPS FRANC_EX_DPS;

		// Token: 0x04000455 RID: 1109
		public SCITTANAME_DAT SCITTANAME_DAT;

		// Token: 0x04000456 RID: 1110
		public DCN_CAT DCN_CAT;

		// Token: 0x04000457 RID: 1111
		private FRANCCOM_LET FRANCCOM_LET;

		// Token: 0x04000458 RID: 1112
		public PrefInt PrefInt;

		// Token: 0x04000459 RID: 1113
		public FRANCAT_POI FRANCAT_POI;

		// Token: 0x0400045A RID: 1114
		public string mapIniName;

		// Token: 0x0400045B RID: 1115
		public string countryMap;

		// Token: 0x0400045C RID: 1116
		public string mapCDId;

		// Token: 0x0400045D RID: 1117
		private int mapVers;

		// Token: 0x0400045E RID: 1118
		private int mapRel;

		// Token: 0x0400045F RID: 1119
		private string mapName;

		// Token: 0x04000460 RID: 1120
		private bool hddMap;

		// Token: 0x04000461 RID: 1121
		public string mapDesc;
	}
}
