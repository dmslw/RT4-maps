using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000057 RID: 87
	public class exportToAlert
	{
		// Token: 0x06000C56 RID: 3158 RVA: 0x00112BB4 File Offset: 0x00111BB4
		public exportToAlert(POILists POIList)
		{
			this._POIList = POIList;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00112BC8 File Offset: 0x00111BC8
		public bool exportToAlert(POICategoryInfos POIcategoryInfo, POITypeInfo POITypeInfo, ListOfPOILists completeList, string workingDirAlert, string countryMap)
		{
			bool result = true;
			bool displayRadarNeeded = false;
			MyProject.Application.Log.WriteEntry("exportToAlert.exportToAlert() begin", TraceEventType.Information);
			checked
			{
				try
				{
					try
					{
						foreach (POILists poilists in completeList)
						{
							poilists.updatePOIName();
							bool flag = poilists.type == 1002 && poilists.POINumber > 0;
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
					MyProject.Application.Log.WriteEntry("ExportToRT3.exportToAlert() step0", TraceEventType.Information);
					Application.DoEvents();
					buildSortedAlertDicts sortedDicts = new buildSortedAlertDicts(completeList, POITypeInfo, ref result);
					ToolStripProgressBar toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
					toolStripProgressBar.Value++;
					Application.DoEvents();
					MyProject.Application.Log.WriteEntry("ExportToRT3.exportToAlert() step1", TraceEventType.Information);
					Application.DoEvents();
					this.rebuildPlaneCoordAlert(POIcategoryInfo, POITypeInfo, sortedDicts, workingDirAlert, countryMap, displayRadarNeeded);
					toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
					toolStripProgressBar.Value++;
					Application.DoEvents();
					MyProject.Application.Log.WriteEntry("ExportToRT3.exportToAlert() step02", TraceEventType.Information);
					Application.DoEvents();
					toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
					toolStripProgressBar.Value++;
					Application.DoEvents();
					MyProject.Application.Log.WriteEntry("ExportToRT3.exportToAlert() step3", TraceEventType.Information);
					toolStripProgressBar = MyProject.Forms.FormMain.ToolStripProgressBar1;
					toolStripProgressBar.Value++;
					Application.DoEvents();
					MyProject.Application.Log.WriteEntry("ExportToRT3.exportToAlert() step4", TraceEventType.Information);
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
				MyProject.Application.Log.WriteEntry("ExportToRT3.exportToAlert() end", TraceEventType.Information);
				return result;
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00112ED8 File Offset: 0x00111ED8
		private void rebuildPlaneCoordAlert(POICategoryInfos POIcategoryInfo, POITypeInfo POITypeInfo, buildSortedAlertDicts sortedDicts, string workingDirAlert, string countryMap, bool displayRadarNeeded)
		{
			RADAR_LZW radar_LZW = null;
			RADAR_LZW radar_LZW2 = null;
			RADAR_PE_LZW radar_PE_LZW = null;
			RADAR_PE_LZW radar_PE_LZW2 = null;
			RADAR_PS_LZW radar_PS_LZW = null;
			RADAR_PS_LZW radar_PS_LZW2 = null;
			RADARDSCLZW radardsclzw = null;
			RADARDSCLZW radardsclzw2 = null;
			POIVERPOI poiverpoi = null;
			string path = Path.Combine(workingDirAlert, string.Format("{0:G}\\{1:G}\\{2:G}", "dest", "MAPPE\\POI_USER", countryMap));
			try
			{
				radar_LZW = new RADAR_LZW(Path.Combine(path, "RADAR.LZW"));
				radar_LZW2 = new RADAR_LZW(Path.Combine(path, "DANGERZ.LZW"));
				radar_PE_LZW = new RADAR_PE_LZW(Path.Combine(path, "RADAR_PE.LZW"));
				radar_PE_LZW2 = new RADAR_PE_LZW(Path.Combine(path, "DANGERZ_PE.LZW"));
				radar_PS_LZW = new RADAR_PS_LZW(Path.Combine(path, "RADAR_PS.LZW"), MyProject.Forms.FormMain.mapMngt.LSNb);
				radar_PS_LZW2 = new RADAR_PS_LZW(Path.Combine(path, "DANGERZ_PS.LZW"), MyProject.Forms.FormMain.mapMngt.LSNb);
				radardsclzw = new RADARDSCLZW(Path.Combine(path, "RADARDSC.LZW"));
				radardsclzw2 = new RADARDSCLZW(Path.Combine(path, "DANGERZDSC.LZW"));
				bool flag2;
				if (displayRadarNeeded)
				{
					bool flag = !MySettingsProperty.Settings.forceRadarDisplay;
					if (flag)
					{
						flag2 = (Interaction.MsgBox(Resources.strWarningDisplayRadar + "\r\n\r\n" + Resources.strAskDisplayRadar, MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes);
						if (flag2)
						{
							MySettingsProperty.Settings.forceRadarDisplay = true;
						}
					}
				}
				bool flag3 = true;
				bool flag4 = true;
				SortedDictionary<buildSortedAlertDicts.key128bits, POIDatas>.KeyCollection keys = sortedDicts.planeCoordDict.Keys;
				try
				{
					foreach (buildSortedAlertDicts.key128bits key in keys)
					{
						POIDatas poidatas = sortedDicts.planeCoordDict[key];
						switch (poidatas.type)
						{
						case 1002:
							flag3 = false;
							this.updatePSPE(poidatas, radar_LZW, radar_PS_LZW, radar_PE_LZW);
							break;
						case 1003:
							flag4 = false;
							this.updatePSPE(poidatas, radar_LZW2, radar_PS_LZW2, radar_PE_LZW2);
							break;
						}
					}
				}
				finally
				{
					SortedDictionary<buildSortedAlertDicts.key128bits, POIDatas>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				radar_LZW.close(true, flag3);
				radar_LZW2.close(true, flag4);
				radar_PE_LZW.close(true, flag3);
				radar_PE_LZW2.close(true, flag4);
				radar_PS_LZW.close(true, flag3);
				radar_PS_LZW2.close(true, flag4);
				radardsclzw.close(true, flag3);
				radardsclzw2.close(true, flag4);
				flag2 = !flag3;
				if (flag2)
				{
					POIVERXXXTXT poiverxxxtxt = new POIVERXXXTXT(Path.Combine(path, "POI_VER_RADAR.TXT"), true, POICategoryInfos.categories.CAT_SAU, 41, "RADAR", Common.getCIDStr(countryMap));
					poiverxxxtxt.close(false);
				}
				flag2 = !flag4;
				if (flag2)
				{
					POIVERXXXTXT poiverxxxtxt2 = new POIVERXXXTXT(Path.Combine(path, "POI_VER_DANGERZ.TXT"), false, POICategoryInfos.categories.CAT_SAU, 42, "ZONE DANGEREUSE", Common.getCIDStr(countryMap));
					poiverxxxtxt2.close(false);
				}
				flag2 = (!flag3 || !flag4);
				if (flag2)
				{
					string path2 = Path.Combine(workingDirAlert, string.Format("{0:G}", "dest"));
					poiverpoi = new POIVERPOI(Path.Combine(path2, "POI_VER.POI"));
					poiverpoi.close(false);
				}
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteEntry(ex.Message);
				MyProject.Application.Log.WriteEntry(ex.StackTrace);
				radar_LZW.close(true, true);
				radar_LZW2.close(true, true);
				radar_PE_LZW.close(true, true);
				radar_PE_LZW2.close(true, true);
				radar_PS_LZW.close(true, true);
				radar_PS_LZW2.close(true, true);
				radardsclzw.close(true, true);
				radardsclzw2.close(true, true);
				poiverpoi.close(true);
				throw ex;
			}
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x001132B0 File Offset: 0x001122B0
		private void updatePSPE(POIDatas POIData, RADAR_LZW RADARLZW, RADAR_PS_LZW RADARPSLZW, RADAR_PE_LZW RADARPELZW)
		{
			uint idxInRadar = RADARLZW.addRecord(POIData);
			uint idxInPE = RADARPELZW.addOrUpdateEntry(POIData.LS, POIData.MS, (ushort)POIData.SS, idxInRadar);
			RADARPSLZW.addOrUpdateEntry(POIData.LS, POIData.MS, idxInPE);
		}

		// Token: 0x04000487 RID: 1159
		private POILists _POIList;
	}
}
