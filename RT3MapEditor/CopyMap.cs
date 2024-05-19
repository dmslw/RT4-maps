using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000038 RID: 56
	public class CopyMap
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x00102EF4 File Offset: 0x00101EF4
		[DebuggerNonUserCode]
		public CopyMap()
		{
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00102F00 File Offset: 0x00101F00
		public Common.RTxMapType getMapType(DirectoryInfo dirInfo, string mapPath)
		{
			bool flag = dirInfo.GetFiles("GRUPPO_1.DAT").Length == 1;
			if (flag)
			{
				MyProject.Application.Log.WriteEntry(Resources.strMapNotSupported, TraceEventType.Error);
				Interaction.MsgBox(Resources.strMapNotSupported, MsgBoxStyle.Critical, null);
				throw new SilentGUIException();
			}
			flag = (dirInfo.GetFiles("GRUPPO_2.DAT").Length == 1);
			Common.RTxMapType result;
			if (flag)
			{
				result = Common.RTxMapType.RT3;
			}
			else
			{
				flag = (dirInfo.GetFiles("GRUPPO_4_ROOT.DAT").Length == 1 && (dirInfo.GetFiles("CURR_VERS_NAVI.DAT").Length == 1 || dirInfo.GetFiles("CD_VER.NAV").Length == 1 || this.isTD4102301(mapPath)));
				if (!flag)
				{
					MyProject.Application.Log.WriteEntry(Resources.strMapNotRecognized, TraceEventType.Error);
					Interaction.MsgBox(Resources.strMapNotRecognized, MsgBoxStyle.Critical, null);
					throw new SilentGUIException();
				}
				result = Common.RTxMapType.RT4;
			}
			return result;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00102FE0 File Offset: 0x00101FE0
		private bool isTD4102301(string mapPath)
		{
			string text = Path.Combine(mapPath, "MAPPE\\002\\CD_VER.NAV.INF");
			string left = null;
			string left2 = null;
			string left3 = null;
			bool flag = !MyProject.Computer.FileSystem.FileExists(text) || MyProject.Computer.FileSystem.FileExists(Path.Combine(mapPath, "CURR_VERS_NAVI.DAT"));
			bool result;
			if (flag)
			{
				MyProject.Application.Log.WriteEntry(string.Format("{0:G} not found", text), TraceEventType.Information);
				result = false;
			}
			else
			{
				StreamReader streamReader = new StreamReader(text);
				string text2;
				do
				{
					text2 = streamReader.ReadLine();
					flag = text2.StartsWith("VERSION:");
					if (flag)
					{
						left2 = text2.Substring(8);
					}
					else
					{
						flag = text2.StartsWith("RELEASE:");
						if (flag)
						{
							left3 = text2.Substring(8);
						}
						else
						{
							flag = text2.StartsWith("CID:");
							if (flag)
							{
								left = text2.Substring(4);
							}
						}
					}
				}
				while (text2 != null && Operators.CompareString(text2, "", false) != 0);
				result = (Operators.CompareString(left, "002", false) == 0 & Operators.CompareString(left2, "4", false) == 0 & Operators.CompareString(left3, "1", false) == 0 & !MyProject.Computer.FileSystem.FileExists(Path.Combine(mapPath, "CD_VER.NAV")));
			}
			return result;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00103138 File Offset: 0x00102138
		public string getMapCountry(DirectoryInfo dirInfo, Common.RTxMapType mapType)
		{
			string text = null;
			checked
			{
				string result;
				switch (mapType)
				{
				case Common.RTxMapType.RT3:
				{
					FileInfo[] files = dirInfo.GetFiles("*POI.DAT");
					bool flag = files.Length != 1;
					if (flag)
					{
						MyProject.Application.Log.WriteEntry(Resources.strMapErrCountry, TraceEventType.Error);
						Interaction.MsgBox(Resources.strMapErrCountry, MsgBoxStyle.Critical, null);
						throw new SilentGUIException();
					}
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files[0].Name);
					result = fileNameWithoutExtension.Substring(0, fileNameWithoutExtension.Length - 3);
					break;
				}
				case Common.RTxMapType.RT4:
				{
					bool flag = dirInfo.GetDirectories("MAPPE").Length == 1;
					if (!flag)
					{
						MyProject.Application.Log.WriteEntry(Resources.strMapErrCountryMAPPE, TraceEventType.Error);
						Interaction.MsgBox(Resources.strMapErrCountryMAPPE, MsgBoxStyle.Critical, null);
						throw new SilentGUIException();
					}
					dirInfo = new DirectoryInfo(Path.Combine(dirInfo.FullName, "MAPPE"));
					DirectoryInfo[] directories = dirInfo.GetDirectories("0*");
					int num = 0;
					int num2 = directories.Length - 1;
					int num3 = num;
					bool flag3;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							goto Block_7;
						}
						flag = (Operators.CompareString(directories[num3].Name, "011", false) != 0);
						if (flag)
						{
							bool flag2 = Common.isCountrySetValid(directories[num3].Name);
							if (!flag2)
							{
								goto IL_168;
							}
							flag3 = (Operators.CompareString(text, null, false) == 0);
							if (!flag3)
							{
								break;
							}
							text = directories[num3].Name;
						}
						num3++;
					}
					MyProject.Application.Log.WriteEntry(Resources.strMapErrCountryUnique, TraceEventType.Error);
					Interaction.MsgBox(Resources.strMapErrCountryUnique, MsgBoxStyle.Critical, null);
					throw new SilentGUIException();
					IL_168:
					MyProject.Application.Log.WriteEntry(string.Format(Resources.strMapErrCountryUnk, directories[num3].Name), TraceEventType.Error);
					Interaction.MsgBox(string.Format(Resources.strMapErrCountryUnk, directories[num3].Name), MsgBoxStyle.Critical, null);
					throw new SilentGUIException();
					Block_7:
					flag3 = (Operators.CompareString(text, null, false) == 0);
					if (flag3)
					{
						MyProject.Application.Log.WriteEntry(Resources.strMapErrCountry, TraceEventType.Error);
						Interaction.MsgBox(Resources.strMapErrCountry, MsgBoxStyle.Critical, null);
						throw new SilentGUIException();
					}
					result = text;
					break;
				}
				default:
					throw new SilentGUIException();
				}
				return result;
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0010338C File Offset: 0x0010238C
		public string getMapDate(Common.RTxMapType mapType, CURR_VERS_NAVI CurrVersNavi, int selectedCID, string mapPath)
		{
			bool flag = mapType == Common.RTxMapType.RT3;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				flag = (CurrVersNavi != null);
				if (flag)
				{
					result = CurrVersNavi.getDateStr(selectedCID);
				}
				else
				{
					result = this.getDateFromRT4CD(mapPath);
				}
			}
			return result;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x001033D0 File Offset: 0x001023D0
		private string getDateFromRT4CD(string mapPath)
		{
			string text = Path.Combine(mapPath, "CD_VER.NAV");
			string result = null;
			bool flag = !MyProject.Computer.FileSystem.FileExists(text);
			if (flag)
			{
				MyProject.Application.Log.WriteEntry(string.Format("{0:G} not found", text), TraceEventType.Information);
			}
			else
			{
				StreamReader streamReader = new StreamReader(text);
				string text2;
				for (;;)
				{
					text2 = streamReader.ReadLine();
					flag = text2.StartsWith("DATA_MAPPE:");
					if (flag)
					{
						break;
					}
					if (text2 == null || Operators.CompareString(text2, "", false) == 0)
					{
						return result;
					}
				}
				result = text2.Substring(11);
			}
			return result;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00103474 File Offset: 0x00102474
		private bool checkMapVolName(string volName, Common.RTxMapType mapType, string countryMap, string mapVers, string mapRel)
		{
			bool flag = mapType == Common.RTxMapType.RT3;
			bool result;
			if (flag)
			{
				result = (volName.Length == 9 && Operators.CompareString(Conversions.ToString(volName[0]), "T", false) == 0 && Operators.CompareString(Conversions.ToString(volName[1]), "D", false) == 0 && char.IsDigit(volName[2]) && char.IsDigit(volName[3]) && char.IsDigit(volName[4]) && char.IsDigit(volName[5]) && char.IsDigit(volName[6]) && Operators.CompareString(Conversions.ToString(volName[7]), "0", false) == 0 && Operators.CompareString(Conversions.ToString(volName[8]), "0", false) == 0);
			}
			else
			{
				result = (volName.Length == 10 && Operators.CompareString(Conversions.ToString(volName[0]), "T", false) == 0 && Operators.CompareString(Conversions.ToString(volName[1]), "D", false) == 0 && Operators.CompareString(Conversions.ToString(volName[2]), "4", false) == 0 && Operators.CompareString(Conversions.ToString(volName[3]), "1", false) == 0 && volName[4] == countryMap[1] && volName[5] == countryMap[2] && char.IsDigit(volName[6]) && char.IsDigit(volName[7]) && char.IsDigit(volName[8]) && char.IsDigit(volName[9]));
			}
			return result;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00103638 File Offset: 0x00102638
		private string mapVolMask(Common.RTxMapType mapType, string countryMap, string mapVers, string mapRel, bool hddMap)
		{
			bool flag = mapType == Common.RTxMapType.RT3;
			string result;
			if (flag)
			{
				result = "\\T\\D\\3\\0\\09999";
			}
			else
			{
				result = string.Concat(new string[]
				{
					"\\T\\D\\4\\1\\",
					Conversions.ToString(countryMap[1]),
					"\\",
					Conversions.ToString(countryMap[2]),
					"9999"
				});
			}
			return result;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x001036A8 File Offset: 0x001026A8
		private string mapVolExample(string mapPath, Common.RTxMapType mapType, string countryMap, string mapVers, string mapRel, string mapDate, ref bool unsureLabel)
		{
			bool flag = mapType == Common.RTxMapType.RT3;
			string result;
			if (flag)
			{
				unsureLabel = false;
				result = Resources.strVolumeNameConfRT3;
			}
			else
			{
				result = "TD41" + Conversions.ToString(countryMap[1]) + Conversions.ToString(countryMap[2]) + this.endMapVol(mapPath, countryMap, mapVers, mapRel, mapDate, ref unsureLabel);
			}
			return result;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00103704 File Offset: 0x00102704
		public string getVolumeLabel(string mapPath, Common.RTxMapType mapType, string countryMap, string mapVers, string mapRel, ref long mapSize, bool hddMap, string mapDate)
		{
			bool flag = true;
			bool flag2 = mapType == Common.RTxMapType.RT3;
			string text;
			string text2;
			if (flag2)
			{
				text = Resources.strInvRT3VolName;
				text2 = Resources.strVolumeNameConfRT3;
			}
			else
			{
				text = Resources.strInvRT4VolName;
				text2 = Resources.strVolumeNameConfRT4;
			}
			string text3 = null;
			DriveInfo driveInfo = new DriveInfo(mapPath);
			flag2 = (driveInfo.DriveType == DriveType.CDRom);
			if (flag2)
			{
				bool flag3 = this.checkMapVolName(driveInfo.VolumeLabel, mapType, countryMap, mapVers, mapRel);
				if (!flag3)
				{
					MyProject.Application.Log.WriteEntry(text, TraceEventType.Error);
					Interaction.MsgBox(text, MsgBoxStyle.Critical, null);
					throw new SilentGUIException();
				}
				text3 = this.mapVolExample(mapPath, mapType, countryMap, mapVers, mapRel, mapDate, ref flag);
				text3 = driveInfo.VolumeLabel;
				mapSize = driveInfo.TotalSize;
			}
			else
			{
				bool flag3 = mapType == Common.RTxMapType.RT3;
				if (flag3)
				{
					flag2 = this.checkMapVolName(Path.GetFileName(mapPath), mapType, countryMap, mapVers, mapRel);
					if (flag2)
					{
						text3 = Path.GetFileName(mapPath);
					}
				}
				else
				{
					text3 = this.mapVolExample(mapPath, mapType, countryMap, mapVers, mapRel, mapDate, ref flag);
				}
				flag3 = flag;
				if (flag3)
				{
					MyProject.Forms.InputDialog.setValue(text2, text3, this.mapVolMask(mapType, countryMap, mapVers, mapRel, hddMap));
					flag3 = (MyProject.Forms.InputDialog.ShowDialog() == DialogResult.OK);
					if (!flag3)
					{
						throw new SilentGUIException();
					}
					text3 = MyProject.Forms.InputDialog.MaskedTextBox1.Text;
				}
				mapSize = CopyMap.getSize(mapPath, hddMap, countryMap);
				flag3 = !this.checkMapVolName(text3, mapType, countryMap, mapVers, mapRel);
				if (flag3)
				{
					MyProject.Application.Log.WriteEntry(text, TraceEventType.Error);
					Interaction.MsgBox(text, MsgBoxStyle.Critical, null);
					throw new SilentGUIException();
				}
			}
			return text3;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x001038A4 File Offset: 0x001028A4
		public void checkGruppoValidity(string mapPath, Common.RTxMapType mapType, string countryMap, bool hddMap, int mapVers)
		{
			bool flag = mapType == Common.RTxMapType.RT4;
			checked
			{
				if (flag)
				{
					string file = Path.Combine(mapPath, "GRUPPO_4_CID.DAT");
					string file2 = Path.Combine(mapPath, Path.Combine("MAPPE", Path.Combine(countryMap, "GRUPPO_4_CID.DAT")));
					flag = (MyProject.Computer.FileSystem.FileExists(file2) && (hddMap | (MyProject.Computer.FileSystem.FileExists(file) && MyProject.Computer.FileSystem.GetFileInfo(file).Length == MyProject.Computer.FileSystem.GetFileInfo(file2).Length)));
					if (!flag)
					{
						MyProject.Application.Log.WriteEntry(Resources.strErrGruppoCIDNotFound, TraceEventType.Error);
						Interaction.MsgBox(Resources.strErrGruppoCIDNotFound, MsgBoxStyle.Exclamation, null);
						throw new SilentGUIException();
					}
					byte[] array = MyProject.Computer.FileSystem.ReadAllBytes(file2);
					flag = !hddMap;
					if (flag)
					{
						byte[] array2 = MyProject.Computer.FileSystem.ReadAllBytes(file);
						int num = 0;
						int num2 = array2.Length - 1;
						int num3 = num;
						for (;;)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								goto IL_12B;
							}
							flag = (array2[num3] != array[num3]);
							if (flag)
							{
								break;
							}
							num3++;
						}
						MyProject.Application.Log.WriteEntry(Resources.strErrGruppoCIDNotIdentical, TraceEventType.Error);
						Interaction.MsgBox(Resources.strErrGruppoCIDNotIdentical, MsgBoxStyle.Exclamation, null);
						throw new SilentGUIException();
					}
					IL_12B:
					flag = (mapVers < 4);
					int count;
					string right;
					if (flag)
					{
						count = 7;
						right = "Map.ver";
					}
					else
					{
						count = 15;
						right = "NR_FILES_GROUP:";
					}
					flag = (Operators.CompareString(Common.RT3Encoding.GetString(array, 0, count), right, false) != 0);
					if (flag)
					{
						MyProject.Application.Log.WriteEntry(Resources.strErrGruppoNotSupported, TraceEventType.Error);
						Interaction.MsgBox(Resources.strErrGruppoNotSupported, MsgBoxStyle.Exclamation, null);
						throw new SilentGUIException();
					}
					string file3 = Path.Combine(mapPath, "GRUPPO_4_ROOT.DAT");
					flag = MyProject.Computer.FileSystem.FileExists(file3);
					if (!flag)
					{
						MyProject.Application.Log.WriteEntry(Resources.strErrGruppoROOTNotFound, TraceEventType.Error);
						Interaction.MsgBox(Resources.strErrGruppoROOTNotFound, MsgBoxStyle.Exclamation, null);
						throw new SilentGUIException();
					}
					byte[] array3 = MyProject.Computer.FileSystem.ReadAllBytes(file3);
				}
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00103AE8 File Offset: 0x00102AE8
		private void copyRootFiles(string mapRootPath, string origPath, string RTxPath, Label copyLabel)
		{
			ReadOnlyCollection<string> files = MyProject.Computer.FileSystem.GetFiles(mapRootPath, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, new string[0]);
			try
			{
				foreach (string text in files)
				{
					bool flag = Path.GetFileName(text).EndsWith("DPA.LZW") | Path.GetFileName(text).EndsWith(".POI") | Path.GetFileName(text).EndsWith("_EX.DPS") | Path.GetFileName(text).EndsWith("_EX.DMR") | Path.GetFileName(text).EndsWith(".DSC") | Path.GetFileName(text).EndsWith(".DST") | Path.GetFileName(text).Equals("GUIDA_CHAMPERARD.POI") | Path.GetFileName(text).Equals("SCITTANAME.DAT") | Path.GetFileName(text).EndsWith(".CAT") | Path.GetFileName(text).EndsWith(".DAT") | Path.GetFileName(text).EndsWith(".LOG");
					if (flag)
					{
						copyLabel.Text = string.Format(Resources.strCopyFromTo, text, origPath);
						Application.DoEvents();
						MyProject.Computer.FileSystem.CopyFile(text, Path.Combine(Path.Combine(origPath, RTxPath), Path.GetFileName(text)), UIOption.OnlyErrorDialogs, UICancelOption.ThrowException);
					}
				}
			}
			finally
			{
				IEnumerator<string> enumerator;
				bool flag = enumerator != null;
				if (flag)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00103C64 File Offset: 0x00102C64
		private void copyRT4RootFiles(Common.RTxMapType mapType, string mapPath, string origPath, Label copyLabel)
		{
			bool flag = mapType == Common.RTxMapType.RT4;
			if (flag)
			{
				ReadOnlyCollection<string> files = MyProject.Computer.FileSystem.GetFiles(mapPath, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, new string[0]);
				try
				{
					foreach (string text in files)
					{
						flag = (Path.GetFileName(text).EndsWith("CID.DAT") || Path.GetFileName(text).EndsWith("ROOT.DAT"));
						if (flag)
						{
							copyLabel.Text = string.Format(Resources.strCopyFromTo, text, origPath);
							Application.DoEvents();
							MyProject.Computer.FileSystem.CopyFile(text, Path.Combine(origPath, Path.GetFileName(text)), UIOption.OnlyErrorDialogs, UICancelOption.ThrowException);
						}
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
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00103D40 File Offset: 0x00102D40
		private void copySubDirFiles(string workingPath, string origPath, string destPath, string RTxPath, Label copyLabel)
		{
			StreamWriter streamWriter = null;
			string path = Path.Combine(workingPath, "ZZZCOM.IND.lst");
			try
			{
				streamWriter = new StreamWriter(path);
				ReadOnlyCollection<string> files = MyProject.Computer.FileSystem.GetFiles(Path.Combine(destPath, RTxPath), Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, new string[]
				{
					"*COM.IND"
				});
				try
				{
					foreach (string text in files)
					{
						copyLabel.Text = string.Format(Resources.strPatchFile, text);
						Application.DoEvents();
						MyProject.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(text.Replace(destPath, origPath)));
						ZZZCOM_IND zzzcom_IND = new ZZZCOM_IND(text, text.Replace(destPath, origPath));
						streamWriter.WriteLine(text.Replace(destPath, "").Remove(0, 1));
					}
				}
				finally
				{
					IEnumerator<string> enumerator;
					bool flag = enumerator != null;
					if (flag)
					{
						enumerator.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteException(ex);
				Interaction.MsgBox(string.Format(Resources.strErrCopy, origPath, destPath), MsgBoxStyle.OkOnly, null);
				throw new SilentGUIException();
			}
			finally
			{
				bool flag = streamWriter != null;
				if (flag)
				{
					streamWriter.Close();
				}
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00103ED4 File Offset: 0x00102ED4
		private void processGruppo(Common.RTxMapType mapType, string origPath, string countryMap, string mapIniName, ref string mapDesc, ref bool mapRadar, ref bool mapGuide, bool hddMap)
		{
			GRUPPODAT gruppodat = null;
			FRANC_EX_DMR franc_EX_DMR = null;
			MyProject.Application.Log.WriteEntry("processGruppo() begin", TraceEventType.Information);
			try
			{
				bool flag = mapType == Common.RTxMapType.RT3;
				if (flag)
				{
					gruppodat = new GRUPPODAT(GRUPPODAT.mode.read, Path.Combine(origPath, "GRUPPO_2.DAT"), mapIniName, origPath, countryMap);
					string left = gruppodat.splitFile(false);
					mapDesc = gruppodat.getLabel();
					mapRadar = gruppodat.getRadarDisplay();
					mapGuide = gruppodat.getGuideDisplay();
					GEOCART geocart = new GEOCART(Path.Combine(Path.Combine(origPath, "GRUPPO_2_DAT"), countryMap + ".Geo"), mapType);
					uint lsnb = geocart.LSNb;
					franc_EX_DMR = new FRANC_EX_DMR(Path.Combine(Path.Combine(origPath, "GRUPPO_2_DAT"), countryMap + "_EX.DMR"), FRANC_EX_DMR.mode.read, mapType, lsnb);
					franc_EX_DMR.close();
					franc_EX_DMR = null;
				}
				else
				{
					flag = Microsoft.VisualBasic.FileIO.FileSystem.FileExists(Path.Combine(origPath, "GRUPPO_4_CID.DAT"));
					if (flag)
					{
						gruppodat = new GRUPPODAT(GRUPPODAT.mode.read, Path.Combine(origPath, "GRUPPO_4_CID.DAT"), mapIniName, origPath, countryMap);
						string left = gruppodat.splitFile(hddMap);
						flag = (Operators.CompareString(left, "RT34", false) != 0 && !hddMap);
						if (flag)
						{
							MyProject.Application.Log.WriteEntry(Resources.strErrGruppoNotSupported, TraceEventType.Error);
							Interaction.MsgBox(Resources.strErrGruppoNotSupported, MsgBoxStyle.Exclamation, null);
							throw new CopyMap.gruppoEx();
						}
					}
					mapDesc = gruppodat.getLabel();
					mapRadar = gruppodat.getRadarDisplay();
					mapGuide = gruppodat.getGuideDisplay();
					GEOCART geocart = new GEOCART(Path.Combine(Path.Combine(origPath, "GRUPPO_4_CID_DAT"), "GeoCart.Geo"), mapType);
					uint lsnb = geocart.LSNb;
					franc_EX_DMR = new FRANC_EX_DMR(Path.Combine(Path.Combine(origPath, "GRUPPO_4_CID_DAT"), "EX.DMR"), FRANC_EX_DMR.mode.read, mapType, lsnb);
					franc_EX_DMR.close();
					franc_EX_DMR = null;
					flag = Microsoft.VisualBasic.FileIO.FileSystem.FileExists(Path.Combine(origPath, "GRUPPO_4_ROOT.DAT"));
					if (flag)
					{
						gruppodat = new GRUPPODAT(GRUPPODAT.mode.read, Path.Combine(origPath, "GRUPPO_4_ROOT.DAT"), mapIniName, origPath, countryMap);
						gruppodat.splitFile(hddMap);
					}
				}
			}
			catch (CopyMap.gruppoEx gruppoEx)
			{
				throw new SilentGUIException();
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteException(ex);
				Interaction.MsgBox(string.Format(Resources.strErrGruppoCopy, new object[0]), MsgBoxStyle.OkOnly, null);
				throw new SilentGUIException();
			}
			finally
			{
				bool flag = franc_EX_DMR != null;
				if (flag)
				{
					franc_EX_DMR.close();
					franc_EX_DMR = null;
				}
			}
			MyProject.Application.Log.WriteEntry("processGruppo() end", TraceEventType.Information);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00104198 File Offset: 0x00103198
		public void processConfigLog(Common.RTxMapType mapType, string origPath)
		{
			string text = Path.Combine(origPath, "CONFIG.LOG");
			FileInfo fileInfo = new FileInfo(text);
			bool flag = !MyProject.Computer.FileSystem.FileExists(text);
			if (flag)
			{
				RT3Writer rt3Writer = new RT3Writer(new FileStream(text, FileMode.Create, FileAccess.Write));
				rt3Writer.Close();
				fileInfo = new FileInfo(text);
			}
			fileInfo.IsReadOnly = false;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x001041F8 File Offset: 0x001031F8
		public static string getVers(Common.RTxMapType mapType, string destPath, string countryMap)
		{
			return CopyMap.processVers(mapType, destPath, countryMap, true);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00104214 File Offset: 0x00103214
		public static string getRel(Common.RTxMapType mapType, string destPath, string countryMap)
		{
			return CopyMap.processVers(mapType, destPath, countryMap, false);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00104230 File Offset: 0x00103230
		private static string processVers(Common.RTxMapType mapType, string destPath, string countryMap, bool vers)
		{
			string text = Path.Combine(destPath, "MAPPE\\" + countryMap + "\\CD_VER.NAV.INF");
			string result = "0";
			bool flag = mapType == Common.RTxMapType.RT4;
			if (flag)
			{
				bool flag2 = !MyProject.Computer.FileSystem.FileExists(text);
				if (flag2)
				{
					MyProject.Application.Log.WriteEntry(string.Format("{0:G} not found", text), TraceEventType.Information);
				}
				else
				{
					StreamReader streamReader = new StreamReader(text);
					string text2;
					for (;;)
					{
						text2 = streamReader.ReadLine();
						flag2 = (vers && text2.StartsWith("VERSION:"));
						if (flag2)
						{
							break;
						}
						flag2 = text2.StartsWith("RELEASE:");
						if (flag2)
						{
							goto Block_5;
						}
						if (text2 == null || Operators.CompareString(text2, "", false) == 0)
						{
							goto IL_D4;
						}
					}
					result = text2.Substring(8);
					goto IL_D4;
					Block_5:
					result = text2.Substring(8);
				}
				IL_D4:;
			}
			return result;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00104314 File Offset: 0x00103314
		public void CopyOrigFolder(string workingPath, string mapPath, string origPath, string destPath, string mapIniName, string countryMap, Common.RTxMapType maptype, bool hddMap, ref string mapDesc, ref bool mapRadar, ref bool mapGuide, Label copyLabel)
		{
			MyProject.Application.Log.WriteEntry("CopyOrigFolder() begin", TraceEventType.Information);
			FRANCDPA_LZW francdpa_LZW = null;
			try
			{
				bool flag = maptype == Common.RTxMapType.RT3;
				string mapRootPath;
				string text;
				if (flag)
				{
					mapRootPath = mapPath;
					text = "";
				}
				else
				{
					mapRootPath = Path.Combine(mapPath, "MAPPE\\" + countryMap);
					text = "MAPPE\\" + countryMap;
				}
				this.copyRootFiles(mapRootPath, origPath, text, copyLabel);
				this.copyRT4RootFiles(maptype, destPath, origPath, copyLabel);
				this.copySubDirFiles(workingPath, origPath, destPath, text, copyLabel);
				this.processGruppo(maptype, origPath, countryMap, mapIniName, ref mapDesc, ref mapRadar, ref mapGuide, hddMap);
				francdpa_LZW = new FRANCDPA_LZW(Path.Combine(Path.Combine(origPath, text), countryMap + "DPA.LZW"));
				francdpa_LZW.close(true);
				francdpa_LZW = null;
			}
			catch (SilentGUIException ex)
			{
				throw new SilentGUIException();
			}
			catch (Exception ex2)
			{
				MyProject.Application.Log.WriteException(ex2);
				Interaction.MsgBox(string.Format(Resources.strErrCopy, mapPath, destPath), MsgBoxStyle.OkOnly, null);
				throw new SilentGUIException();
			}
			finally
			{
				bool flag = francdpa_LZW != null;
				if (flag)
				{
					francdpa_LZW.close(false);
					francdpa_LZW = null;
				}
			}
			MyProject.Application.Log.WriteEntry("CopyOrigFolder() end", TraceEventType.Information);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00104488 File Offset: 0x00103488
		public void copyDestFolder(string mapPath, string destPath, string VolumeLabel, Common.RTxMapType mapType, string countryMap, string strVersion, string strRelease, bool hddMap, CURR_VERS_NAVI CurrVersNavi, Label copyLabel)
		{
			MyProject.Application.Log.WriteEntry("CopyDestFolder() begin", TraceEventType.Information);
			if (hddMap)
			{
				string strParam = string.Format("\"{0:G}\" \"{1:G}\" /q /i", mapPath, destPath);
				bool flag = this.startBackgroundProcess("xcopy.exe", strParam, null, string.Format(Resources.strCopyFromTo, mapPath, destPath), copyLabel) != 0;
				if (flag)
				{
					Interaction.MsgBox(string.Format(Resources.strErrCopy, mapPath, destPath), MsgBoxStyle.OkOnly, null);
					throw new SilentGUIException();
				}
				strParam = string.Format("\"{0:G}\" \"{1:G}\" /q /s /i", Path.Combine(Path.Combine(mapPath, "MAPPE"), countryMap), Path.Combine(Path.Combine(destPath, "MAPPE"), countryMap));
				flag = (this.startBackgroundProcess("xcopy.exe", strParam, null, string.Format(Resources.strCopyFromTo, mapPath, destPath), copyLabel) != 0);
				if (flag)
				{
					Interaction.MsgBox(string.Format(Resources.strErrCopy, mapPath, destPath), MsgBoxStyle.OkOnly, null);
					throw new SilentGUIException();
				}
			}
			else
			{
				string strParam = string.Format("\"{0:G}\" \"{1:G}\" /q /s /i", mapPath, destPath);
				bool flag = this.startBackgroundProcess("xcopy.exe", strParam, null, string.Format(Resources.strCopyFromTo, mapPath, destPath), copyLabel) != 0;
				if (flag)
				{
					Interaction.MsgBox(string.Format(Resources.strErrCopy, mapPath, destPath), MsgBoxStyle.OkOnly, null);
					throw new SilentGUIException();
				}
			}
			CopyMap.copyRT4FilesIfNeeded(destPath, mapPath, VolumeLabel, mapType, countryMap, strVersion, strRelease, hddMap);
			CopyMap.copyHddFilesIfNeeded(destPath, mapPath, VolumeLabel, mapType, countryMap, strVersion, strRelease, hddMap, CurrVersNavi);
			MyProject.Application.Log.WriteEntry("CopyDestFolder() end", TraceEventType.Information);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00104604 File Offset: 0x00103604
		public static void copyRT4FilesIfNeeded(string destPath, string mapPath, string volumeLabel, Common.RTxMapType mapType, string countryMap, string strVersion, string strRelease, bool hddMap)
		{
			try
			{
				bool flag = !hddMap && Operators.CompareString(volumeLabel, "TD41020301", false) == 0 && !MyProject.Computer.FileSystem.FileExists(Path.Combine(destPath, "DB_DWNL_PPC.OUT"));
				if (flag)
				{
					string text = Path.Combine(destPath, Path.Combine("MAPPE", countryMap));
					ZipFile zipFile = new ZipFile(Path.Combine(MyProject.Application.Info.DirectoryPath, "redist\\upg.dat"));
					zipFile.Password = "ZZZCOM.IND.lst";
					CopyMap.extractCopyFile(zipFile, "7", "CD_VER.LA", destPath, strVersion, strRelease);
					CopyMap.extractCopyFile(zipFile, "8", "CD_VER.NAV", destPath, strVersion, strRelease);
					CopyMap.extractCopyFile(zipFile, "3", "NAV_UPGRADE.CMD", destPath, strVersion, strRelease);
					CopyMap.extractCopyFile(zipFile, "6", "DB_DWNL_PPC.OUT.inf", destPath, strVersion, strRelease);
					CopyMap.extractCopyFile(zipFile, "9", "DB_DWNL_PPC.OUT", destPath, strVersion, strRelease);
					string text2 = Path.Combine(destPath, "UPG");
					flag = !MyProject.Computer.FileSystem.DirectoryExists(text2);
					if (flag)
					{
						MyProject.Computer.FileSystem.CreateDirectory(text2);
					}
					CopyMap.extractCopyFile(zipFile, "2", "builtins.out", text2, strVersion, strRelease);
					CopyMap.extractCopyFile(zipFile, "1", "builtins.out.inf", text2, strVersion, strRelease);
					CopyMap.extractCopyFile(zipFile, "4", "NAV_UPGRADE_SUB.CMD", text2, strVersion, strRelease);
				}
			}
			catch (SilentGUIException ex)
			{
				throw new SilentGUIException();
			}
			catch (Exception ex2)
			{
				Interaction.MsgBox(string.Format(Resources.strErrCopy, mapPath, destPath), MsgBoxStyle.OkOnly, null);
				throw new SilentGUIException();
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x001047EC File Offset: 0x001037EC
		public static void copyHddFilesIfNeeded(string destPath, string mapPath, string volumeLabel, Common.RTxMapType mapType, string countryMap, string strVersion, string strRelease, bool hddMap, CURR_VERS_NAVI CurrVersNavi)
		{
			try
			{
				bool flag = hddMap && mapType == Common.RTxMapType.RT4;
				if (flag)
				{
					string text = Path.Combine(destPath, "UPG");
					flag = MyProject.Computer.FileSystem.DirectoryExists(text);
					if (flag)
					{
						MyProject.Computer.FileSystem.DeleteDirectory(text, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
					}
					text = Path.Combine(destPath, "CURR_VERS_NAVI.DAT");
					flag = MyProject.Computer.FileSystem.FileExists(text);
					if (flag)
					{
						FileInfo fileInfo = new FileInfo(text);
						fileInfo.IsReadOnly = false;
						MyProject.Computer.FileSystem.DeleteFile(text);
					}
					text = Path.Combine(destPath, "CURR_VERS_NAVI.TXT");
					flag = MyProject.Computer.FileSystem.FileExists(text);
					if (flag)
					{
						FileInfo fileInfo = new FileInfo(text);
						fileInfo.IsReadOnly = false;
						MyProject.Computer.FileSystem.DeleteFile(text);
					}
					text = Path.Combine(destPath, "hdd.tst");
					flag = MyProject.Computer.FileSystem.FileExists(text);
					if (flag)
					{
						FileInfo fileInfo = new FileInfo(text);
						fileInfo.IsReadOnly = false;
						MyProject.Computer.FileSystem.DeleteFile(text);
					}
					text = Path.Combine(destPath, "CD_VER.NAV");
					flag = MyProject.Computer.FileSystem.FileExists(text);
					if (flag)
					{
						FileInfo fileInfo = new FileInfo(text);
						fileInfo.IsReadOnly = false;
						MyProject.Computer.FileSystem.DeleteFile(text);
					}
					text = Path.Combine(destPath, "CD_VER.LA");
					flag = MyProject.Computer.FileSystem.FileExists(text);
					if (flag)
					{
						FileInfo fileInfo = new FileInfo(text);
						fileInfo.IsReadOnly = false;
						MyProject.Computer.FileSystem.DeleteFile(text);
					}
					text = Path.Combine(destPath, "CD.inf");
					flag = MyProject.Computer.FileSystem.FileExists(text);
					if (flag)
					{
						FileInfo fileInfo = new FileInfo(text);
						fileInfo.IsReadOnly = false;
						MyProject.Computer.FileSystem.DeleteFile(text);
					}
					text = Path.Combine(destPath, "trc.txt");
					flag = MyProject.Computer.FileSystem.FileExists(text);
					if (flag)
					{
						FileInfo fileInfo = new FileInfo(text);
						fileInfo.IsReadOnly = false;
						MyProject.Computer.FileSystem.DeleteFile(text);
					}
					int cid = int.Parse(countryMap);
					CopyMap.createFileFromString("CD_VER.NAV", destPath, CurrVersNavi.getRootCdVerLaNa(cid));
					CopyMap.createFileFromString("CD_VER.LA", destPath, CurrVersNavi.getRootCdVerLaNa(cid));
					string path = Path.Combine(destPath, Path.Combine("MAPPE", countryMap));
					string destinationFileName = Path.Combine(destPath, "GRUPPO_4_CID.DAT");
					string sourceFileName = Path.Combine(path, "GRUPPO_4_CID.DAT");
					MyProject.Computer.FileSystem.CopyFile(sourceFileName, destinationFileName, true);
					ZipFile zipFile = new ZipFile(Path.Combine(MyProject.Application.Info.DirectoryPath, "redist\\upg.dat"));
					zipFile.Password = "ZZZCOM.IND.lst";
					CopyMap.extractCopyFile(zipFile, "3", "NAV_UPGRADE.CMD", destPath, strVersion, strRelease);
					CopyMap.extractCopyFile(zipFile, "15", "GRUPPO_4_MRE.DAT", destPath, strVersion, strRelease);
					CopyMap.extractCopyFile(zipFile, "13", "DB_DWNL.OUT.INF", destPath, strVersion, strRelease);
					CopyMap.extractCopyFile(zipFile, "12", "DB_DWNL.OUT", destPath, strVersion, strRelease);
					CopyMap.extractCopyFile(zipFile, "14", "SW_VER.dat", destPath, strVersion, strRelease);
					string text2 = Path.Combine(destPath, "UPG");
					flag = !MyProject.Computer.FileSystem.DirectoryExists(text2);
					if (flag)
					{
						MyProject.Computer.FileSystem.CreateDirectory(text2);
					}
					CopyMap.extractCopyFile(zipFile, "2", "builtins.out", text2, strVersion, strRelease);
					CopyMap.extractCopyFile(zipFile, "1", "builtins.out.inf", text2, strVersion, strRelease);
					CopyMap.extractCopyFile(zipFile, "4", "NAV_UPGRADE_SUB.CMD", text2, strVersion, strRelease);
					text2 = Path.Combine(destPath, "MAPPE\\011");
					flag = !MyProject.Computer.FileSystem.DirectoryExists(text2);
					if (flag)
					{
						MyProject.Computer.FileSystem.CreateDirectory(text2);
					}
				}
			}
			catch (SilentGUIException ex)
			{
				throw new SilentGUIException();
			}
			catch (Exception ex2)
			{
				Interaction.MsgBox(string.Format(Resources.strErrCopy, mapPath, destPath), MsgBoxStyle.OkOnly, null);
				throw new SilentGUIException();
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00104C90 File Offset: 0x00103C90
		public static void fillKeyToCopyMap(string destDrive, string countryMap, List<string> CIDList, bool fastCopy, bool highTrc, bool chkCRC)
		{
			try
			{
				CopyMap.fillKeyWithScriptEnv(destDrive, Common.scriptTypes.copyMap);
				string copyPath = Path.Combine(destDrive, "JANFI67_SCRIPTS");
				CopyMap.extractAndProcessScript(new ZipFile(Path.Combine(MyProject.Application.Info.DirectoryPath, "redist\\upg.dat"))
				{
					Password = "ZZZCOM.IND.lst"
				}, "24", "JANFI67_SCRIPT.CMD", copyPath, CIDList, fastCopy, highTrc, chkCRC, null);
			}
			catch (SilentGUIException ex)
			{
				throw new SilentGUIException();
			}
			catch (Exception ex2)
			{
				Interaction.MsgBox(string.Format(Resources.strErrCopy, "RTxMapEditor", destDrive), MsgBoxStyle.OkOnly, null);
				throw new SilentGUIException();
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00104D5C File Offset: 0x00103D5C
		public static void fillKeyToCopyConfig(string destDrive)
		{
			try
			{
				CopyMap.fillKeyWithScriptEnv(destDrive, Common.scriptTypes.copyConfig);
				ZipFile zipFile = new ZipFile(Path.Combine(MyProject.Application.Info.DirectoryPath, "redist\\upg.dat"));
				zipFile.Password = "ZZZCOM.IND.lst";
				string copyPath = Path.Combine(destDrive, "JANFI67_SCRIPTS");
				CopyMap.extractAndProcessScript(zipFile, "26", "JANFI67_SCRIPT.CMD", copyPath, null, false, false, false, null);
			}
			catch (SilentGUIException ex)
			{
				throw new SilentGUIException();
			}
			catch (Exception ex2)
			{
				Interaction.MsgBox(string.Format(Resources.strErrCopy, "RTxMapEditor", destDrive), MsgBoxStyle.OkOnly, null);
				throw new SilentGUIException();
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00104E24 File Offset: 0x00103E24
		public static void fillKeyWithScriptEnv(string destDrive, Common.scriptTypes scriptType)
		{
			try
			{
				string text = Path.Combine(destDrive, "JANFI67_SCRIPTS");
				MyProject.Computer.FileSystem.CreateDirectory(text);
				ZipFile zipFile = new ZipFile(Path.Combine(MyProject.Application.Info.DirectoryPath, "redist\\upg.dat"));
				zipFile.Password = "ZZZCOM.IND.lst";
				bool flag = scriptType == Common.scriptTypes.copyConfig | scriptType == Common.scriptTypes.copyMap;
				if (flag)
				{
					CopyMap.extractCopyFile(zipFile, "7", "CD_VER.LA", destDrive, "4", "1");
					CopyMap.extractCopyFile(zipFile, "8", "CD_VER.NAV", destDrive, "4", "1");
				}
				else
				{
					CopyMap.extractCopyFile(zipFile, "16", "CD_VER.LA", destDrive, null, null);
				}
				CopyMap.extractCopyFile(zipFile, "23", "NAV_UPGRADE.CMD", destDrive);
				CopyMap.extractCopyFile(zipFile, "2", "RTxUtils.out", text);
				CopyMap.extractCopyFile(zipFile, "1", "RTxUtils.out.inf", text);
				CopyMap.extractCopyFile(zipFile, "21", "RTx.dat", text);
				flag = (scriptType == Common.scriptTypes.patchDBDWNLPCC);
				if (flag)
				{
					CopyMap.extractCopyFile(zipFile, "9", "DB_DWNL_PPC.OUT", destDrive, "4", "1");
					CopyMap.extractCopyFile(zipFile, "6", "DB_DWNL_PPC.OUT.inf", destDrive, "4", "1");
				}
			}
			catch (SilentGUIException ex)
			{
				throw new SilentGUIException();
			}
			catch (Exception ex2)
			{
				Interaction.MsgBox(string.Format(Resources.strErrCopy, "RTxMapEditor", destDrive), MsgBoxStyle.OkOnly, null);
				throw new SilentGUIException();
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00104FE0 File Offset: 0x00103FE0
		public static void extractCopyFile(ZipFile zipFile, string fileNameIn, string fileNameOut, string copyPath)
		{
			CopyMap.extractCopyFile(zipFile, fileNameIn, fileNameOut, copyPath, null, null);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00104FF0 File Offset: 0x00103FF0
		public static void extractCopyFile(ZipFile zipFile, string fileNameIn, string fileNameOut, string copyPath, string strVersion, string strRelease)
		{
			Stream stream = null;
			FileStream fileStream = null;
			try
			{
				CopyMap.getUpgCompatVersRel(fileNameIn, strVersion, strRelease);
				stream = zipFile.GetInputStream(zipFile.GetEntry(CopyMap.getUpgCompatVersRel(fileNameIn, strVersion, strRelease)));
				fileStream = new FileStream(Path.Combine(copyPath, fileNameOut), FileMode.Create);
				int num;
				do
				{
					num = stream.ReadByte();
					bool flag = num != -1;
					if (flag)
					{
						fileStream.WriteByte(checked((byte)num));
					}
				}
				while (num != -1);
			}
			catch (SilentGUIException ex)
			{
				throw new SilentGUIException();
			}
			catch (Exception ex2)
			{
				MyProject.Application.Log.WriteException(ex2);
				MyProject.Application.Log.WriteEntry(Resources.strErrInternalExtract);
				Interaction.MsgBox(Resources.strErrInternalExtract, MsgBoxStyle.OkOnly, null);
				throw new SilentGUIException();
			}
			finally
			{
				bool flag = stream != null;
				if (flag)
				{
					stream.Close();
				}
				flag = (fileStream != null);
				if (flag)
				{
					fileStream.Close();
				}
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0010511C File Offset: 0x0010411C
		public static string StringToHexa(string strIn)
		{
			StringBuilder stringBuilder = new StringBuilder(250);
			int i = 0;
			int length = strIn.Length;
			checked
			{
				while (i < length)
				{
					char @string = strIn[i];
					stringBuilder.Append("\\x");
					stringBuilder.Append(Strings.Asc(@string).ToString("x2"));
					i++;
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00105190 File Offset: 0x00104190
		public static void extractAndProcessScript(ZipFile zipFile, string fileNameIn, string fileNameOut, string copyPath, List<string> CIDList, bool fastCopy, bool highTrc, bool chkCRC, string copyType)
		{
			StreamReader streamReader = null;
			StreamWriter streamWriter = null;
			int num = 1;
			string arg = "d4ps";
			string arg2 = "m8h4";
			string arg3 = "r49e";
			string arg4 = "b9d3";
			string arg5 = "i7gg";
			string arg6 = "o6Tz";
			string arg7 = "l14";
			string arg8 = "l25";
			string arg9 = "l74";
			string arg10 = "l89";
			string arg11 = "l37";
			string arg12 = "l82";
			string arg13 = "l83";
			string arg14 = "l44";
			string arg15 = "l19";
			string arg16 = "l31";
			string arg17 = "l3d";
			string arg18 = "l3e";
			string arg19 = "l3f";
			string arg20 = "l40";
			string arg21 = "l41";
			string arg22 = "l42";
			string arg23 = "l43";
			string arg24 = "l45";
			string arg25 = "l46";
			string arg26 = "l47";
			string arg27 = "l48";
			string arg28 = "l49";
			string arg29 = "l50";
			string arg30 = "l51";
			string arg31 = "l52";
			string arg32 = "(1)";
			string arg33 = "(822)";
			checked
			{
				try
				{
					Stream inputStream = zipFile.GetInputStream(zipFile.GetEntry(CopyMap.getUpgCompatVersRel(fileNameIn, null, null)));
					streamReader = new StreamReader(inputStream);
					FileStream stream = new FileStream(Path.Combine(copyPath, fileNameOut), FileMode.Create);
					streamWriter = new StreamWriter(stream, Common.RT3Encoding);
					do
					{
						string text = streamReader.ReadLine();
						bool flag = Operators.CompareString(fileNameIn, "24", false) == 0;
						if (flag)
						{
							bool flag2 = Operators.CompareString(text, "#define RTxMapEditor1", false) == 0;
							if (flag2)
							{
								if (highTrc)
								{
									streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg, "(1)"));
								}
								else
								{
									streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg, "(0)"));
								}
								if (chkCRC)
								{
									streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg2, "(1)"));
								}
								else
								{
									streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg2, "(0)"));
								}
								streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg3, CopyMap.StringToHexa(Resources.strRT4MapCopyQuest)));
								streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg4, CopyMap.StringToHexa(Resources.strRT4MapCopyDone)));
								streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg5, CopyMap.StringToHexa(Resources.strRT4MapCopyFailed)));
								streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg6, CopyMap.StringToHexa(Resources.strRT4MapCommonFiles)));
								streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg13, ""));
								streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg14, ""));
								streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg16, arg32));
							}
							else
							{
								bool flag3 = Operators.CompareString(text, "#define RTxMapEditor2", false) == 0;
								if (flag3)
								{
									try
									{
										foreach (string text2 in CIDList)
										{
											if (fastCopy)
											{
												streamWriter.WriteLine(string.Format("ld(l113==(0))l113=i524(\"\\x2f\\x48\",\"\\x2f\\x4d\\x41\\x50\\x50\\x45\\x2f{0:G}\",\"\\x2f\\x62\\x64\\x30\", \"\", \"{3:G} ({1:d}/{2:d})\");", new object[]
												{
													CopyMap.StringToHexa(text2),
													CopyMap.StringToHexa(num.ToString()),
													CopyMap.StringToHexa(CIDList.Count.ToString()),
													CopyMap.StringToHexa(Common.getCIDStr(text2))
												}));
											}
											else
											{
												streamWriter.WriteLine(string.Format("ld(l113==(0))l113=l112(\"\\x2f\\x48\",\"\\x2f\\x4d\\x41\\x50\\x50\\x45\\x2f{0:G}\",\"\\x2f\\x62\\x64\\x30\", \"\", \"{3:G} ({1:d}/{2:d})\");", new object[]
												{
													CopyMap.StringToHexa(text2),
													CopyMap.StringToHexa(num.ToString()),
													CopyMap.StringToHexa(CIDList.Count.ToString()),
													CopyMap.StringToHexa(Common.getCIDStr(text2))
												}));
											}
											num++;
										}
									}
									finally
									{
										List<string>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
								}
								else
								{
									streamWriter.WriteLine(text);
								}
							}
						}
						else
						{
							bool flag3 = Operators.CompareString(fileNameIn, "5", false) == 0;
							if (flag3)
							{
								bool flag2 = Operators.CompareString(text, "#define RTxMapEditor1", false) == 0;
								if (flag2)
								{
									streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg, "(0)"));
									streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg2, "(0)"));
									streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg8, CopyMap.StringToHexa(Resources.strRT4MapUpgUSBDone)));
									streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg9, CopyMap.StringToHexa(Resources.strRT4MapUpgCDROMDone)));
									streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg10, CopyMap.StringToHexa(Resources.strRT4MapUpgUSBFailed)));
									streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg11, CopyMap.StringToHexa(Resources.strRT4MapUpgCDROMFailed)));
									streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg16, arg33));
								}
								else
								{
									streamWriter.WriteLine(text);
								}
							}
							else
							{
								flag3 = (Operators.CompareString(fileNameIn, "26", false) == 0);
								if (flag3)
								{
									bool flag2 = Operators.CompareString(text, "#define RTxMapEditor1", false) == 0;
									if (flag2)
									{
										streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg, "(0)"));
										streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg2, "(1)"));
										streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg3, CopyMap.StringToHexa(Resources.strRT4TFFSConfCopyQuest)));
										streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg4, CopyMap.StringToHexa(Resources.strRT4TFFSConfCopyDone)));
										streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg5, CopyMap.StringToHexa(Resources.strRT4TFFSConfCopyFailed)));
										streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg7, CopyMap.StringToHexa(Resources.strRT4TFFSConfCopyInProgress)));
										streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg6, ""));
										streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg13, ""));
										streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg14, ""));
										streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg16, arg32));
									}
									else
									{
										flag3 = (Operators.CompareString(text, "#define RTxMapEditor2", false) == 0);
										if (!flag3)
										{
											streamWriter.WriteLine(text);
										}
									}
								}
								else
								{
									flag3 = (Operators.CompareString(fileNameIn, "34", false) == 0);
									if (flag3)
									{
										bool flag2 = Operators.CompareString(text, "#define RTxMapEditor1", false) == 0;
										if (flag2)
										{
											streamWriter.WriteLine();
											streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg, "(0)"));
											streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg2, "(0)"));
											flag3 = (Operators.CompareString(copyType, "Bootscreen.bmp", false) == 0);
											if (flag3)
											{
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg3, CopyMap.StringToHexa(Resources.strRT4BSCopyQuest)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg8, CopyMap.StringToHexa(Resources.strRT4BSCopyUSBDone)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg10, CopyMap.StringToHexa(Resources.strRT4BSCopyUSBFailed)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg9, CopyMap.StringToHexa(Resources.strRT4BSCopyCDROMDone)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg11, CopyMap.StringToHexa(Resources.strRT4BSCopyCDROMFailed)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg7, CopyMap.StringToHexa(Resources.strRT4BSCopyInProgress)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg12, CopyMap.StringToHexa("/Bootscreen.bmp")));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg13, CopyMap.StringToHexa("/F/Application/Boot/Bootscreen.bmp")));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg14, CopyMap.StringToHexa("")));
												streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg16, arg33));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg6, CopyMap.StringToHexa("")));
												streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg15, "(1)"));
											}
											else
											{
												flag3 = (Operators.CompareString(copyType, "Agenda.dat", false) == 0);
												if (flag3)
												{
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg3, string.Format(Resources.strRT4FileCopyQuest, "Agenda.dat")));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg8, Resources.strRT4BSCopyUSBDone));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg10, Resources.strRT4BSCopyUSBFailed));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg9, Resources.strRT4BSCopyCDROMDone));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg11, Resources.strRT4BSCopyCDROMFailed));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg7, copyType));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg12, Path.Combine("\\I\\USER_DATA\\Agenda\\".Replace("\\", "/"), "Agenda.dat")));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg13, ""));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg14, Path.Combine("/I/USER_DATA/Agenda/", "Agenda.dat")));
													streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg16, arg32));
													streamWriter.WriteLine(string.Format("#define {0:G} (0)", arg15));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg6, ""));
												}
												else
												{
													flag3 = (Operators.CompareString(copyType, "User_com.dat", false) == 0);
													if (flag3)
													{
														streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg3, string.Format(Resources.strRT4FileCopyQuest, "User_com.dat")));
														streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg8, Resources.strRT4BSCopyUSBDone));
														streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg10, Resources.strRT4BSCopyUSBFailed));
														streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg9, Resources.strRT4BSCopyCDROMDone));
														streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg11, Resources.strRT4BSCopyCDROMFailed));
														streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg7, copyType));
														streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg12, Path.Combine("\\I\\USER_DATA\\User_profile\\".Replace("\\", "/"), "User_com.dat")));
														streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg13, ""));
														streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg14, Path.Combine("/I/USER_DATA/User_profile/", "User_com.dat")));
														streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg16, arg32));
														streamWriter.WriteLine(string.Format("#define {0:G} (0)", arg15));
														streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg6, ""));
													}
												}
											}
										}
										else
										{
											flag3 = (Operators.CompareString(text, "#define RTxMapEditor2", false) == 0);
											if (!flag3)
											{
												streamWriter.WriteLine(text);
											}
										}
									}
									else
									{
										flag3 = (Operators.CompareString(fileNameIn, "44", false) == 0);
										if (flag3)
										{
											bool flag2 = Operators.CompareString(text, "#define RTxMapEditor1", false) == 0;
											if (flag2)
											{
												streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg, "(0)"));
												streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg2, "(1)"));
												streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg28, "(0)"));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg17, CopyMap.StringToHexa(Resources.strRT4DBDWNLUpgradeQuest)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg23, CopyMap.StringToHexa(Resources.strRT4DBDWNLRestoreQuest)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg18, CopyMap.StringToHexa(Resources.strRT4DBDWNLUpgradeDone)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg24, CopyMap.StringToHexa(Resources.strRT4DBDWNLRestoreDone)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg19, CopyMap.StringToHexa(Resources.strRT4DBDWNLUpgradeFailed)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg20, CopyMap.StringToHexa(Resources.strRT4DBDWNLRestoreFailed)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg25, CopyMap.StringToHexa(Resources.strRT4DBDWNLUpgradeAborted)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg21, CopyMap.StringToHexa(Resources.strRT4DBDWNLUpgradeNotNecessary)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg22, CopyMap.StringToHexa(Resources.strRT4DBDWNLUpgradeNotPossible)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg26, CopyMap.StringToHexa(Resources.strRT4RemoveCD)));
												streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg27, CopyMap.StringToHexa(Resources.strRT4RemoveKey)));
												streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg16, arg33));
											}
											else
											{
												flag3 = (Operators.CompareString(text, "#define RTxMapEditor2", false) == 0);
												if (!flag3)
												{
													streamWriter.WriteLine(text);
												}
											}
										}
										else
										{
											flag3 = (Operators.CompareString(fileNameIn, CopyMap.ZIP_FILE_POI_UPGRADE_SUB_CMD, false) == 0);
											if (flag3)
											{
												bool flag2 = Operators.CompareString(text, "#define RTxMapEditor1", false) == 0;
												if (flag2)
												{
													streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg, "(0)"));
													streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg2, "(1)"));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg29, CopyMap.StringToHexa(Resources.strRT4RemoveAlertQuest)));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg30, CopyMap.StringToHexa(Resources.strRT4RemoveAlertDone)));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg31, CopyMap.StringToHexa(Resources.strRT4VersionNotCompatible)));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg26, CopyMap.StringToHexa(Resources.strRT4RemoveCD)));
													streamWriter.WriteLine(string.Format("#define {0:G} \"{1:G}\"", arg27, CopyMap.StringToHexa(Resources.strRT4RemoveKey)));
													streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg16, arg33));
													streamWriter.WriteLine(string.Format("#define {0:G} {1:G}", arg28, "(0)"));
												}
												else
												{
													flag3 = (Operators.CompareString(text, "#define RTxMapEditor2", false) == 0);
													if (!flag3)
													{
														streamWriter.WriteLine(text);
													}
												}
											}
										}
									}
								}
							}
						}
					}
					while (!streamReader.EndOfStream);
				}
				catch (SilentGUIException ex)
				{
					throw new SilentGUIException();
				}
				catch (Exception ex2)
				{
					MyProject.Application.Log.WriteException(ex2);
					MyProject.Application.Log.WriteEntry(Resources.strErrInternalExtract);
					Interaction.MsgBox(Resources.strErrInternalExtract, MsgBoxStyle.OkOnly, null);
					throw new SilentGUIException();
				}
				finally
				{
					bool flag3 = streamReader != null;
					if (flag3)
					{
						streamReader.Close();
					}
					flag3 = (streamWriter != null);
					if (flag3)
					{
						streamWriter.Close();
					}
				}
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0010615C File Offset: 0x0010515C
		private static void createFileFromString(string fileNameOut, string copyPath, string str)
		{
			StreamWriter streamWriter = null;
			try
			{
				streamWriter = new StreamWriter(Path.Combine(copyPath, fileNameOut), false, Common.RT3Encoding);
				streamWriter.Write(str);
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(string.Format(Resources.strErrCopy, fileNameOut, copyPath), MsgBoxStyle.OkOnly, null);
				MyProject.Application.Log.WriteException(ex);
				throw new SilentGUIException();
			}
			finally
			{
				bool flag = streamWriter != null;
				if (flag)
				{
					streamWriter.Close();
				}
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x001061F8 File Offset: 0x001051F8
		private int startBackgroundProcess(string strCommand, string strParam, string WorkingDirectory, string label, Label copyLabel)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(strCommand, strParam);
			int result = -1;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			bool flag = WorkingDirectory != null;
			if (flag)
			{
				processStartInfo.WorkingDirectory = WorkingDirectory;
			}
			flag = (label != null);
			if (flag)
			{
				copyLabel.Text = label;
			}
			Application.DoEvents();
			Process process = Process.Start(processStartInfo);
			process.PriorityClass = ProcessPriorityClass.BelowNormal;
			int id = process.Id;
			while (!process.HasExited)
			{
				Application.DoEvents();
				Thread.Sleep(150);
			}
			flag = process.HasExited;
			if (flag)
			{
				result = process.ExitCode;
			}
			return result;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x001062C0 File Offset: 0x001052C0
		public bool checkMapAfterCopy(string mapPath, string workingPath, string origPath, string destPath, string mapIniName, string countryMap, Common.RTxMapType mapType)
		{
			return true;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x001062D4 File Offset: 0x001052D4
		public static long getSize(string path, bool hddMap, string CID)
		{
			long num = 0L;
			checked
			{
				try
				{
					if (hddMap)
					{
						string[] files = Directory.GetFiles(path, "*.*", System.IO.SearchOption.TopDirectoryOnly);
						foreach (string fileName in files)
						{
							num += new FileInfo(fileName).Length;
						}
						files = Directory.GetFiles(path, "MAPPE\\" + CID + "\\*.*", System.IO.SearchOption.AllDirectories);
						foreach (string fileName in files)
						{
							num += new FileInfo(fileName).Length;
						}
					}
					else
					{
						string[] files = Directory.GetFiles(path, "*.*", System.IO.SearchOption.AllDirectories);
						foreach (string fileName in files)
						{
							num += new FileInfo(fileName).Length;
						}
					}
				}
				catch (Exception ex)
				{
					num = 650000000L;
				}
				return num;
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x001063E4 File Offset: 0x001053E4
		private string endMapVol(string mapPath, string countryMap, string mapVers, string mapRel, string mapDate, ref bool unsureLabel)
		{
			unsureLabel = false;
			bool flag = Operators.CompareString(mapVers, "2", false) == 0 && (Operators.CompareString(mapRel, "2", false) == 0 | Operators.CompareString(mapRel, "6", false) == 0);
			string result;
			bool flag4;
			if (flag)
			{
				result = "0200";
			}
			else
			{
				flag = (Operators.CompareString(mapVers, "4", false) == 0 && Operators.CompareString(mapRel, "1", false) == 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(mapDate, "24/04/2007", false) == 0;
					if (flag2)
					{
						bool flag3;
						if (Operators.CompareString(countryMap, "001", false) != 0 && Operators.CompareString(countryMap, "006", false) != 0)
						{
							if (Operators.CompareString(countryMap, "020", false) != 0)
							{
								if (Operators.CompareString(countryMap, "021", false) != 0)
								{
									flag3 = false;
									goto IL_D9;
								}
							}
						}
						flag3 = true;
						IL_D9:
						flag4 = flag3;
						if (flag4)
						{
							result = "0301";
						}
						else
						{
							flag4 = (Operators.CompareString(countryMap, "002", false) == 0);
							if (flag4)
							{
								result = "0202";
							}
							else
							{
								bool flag5;
								if (Operators.CompareString(countryMap, "003", false) != 0 && Operators.CompareString(countryMap, "004", false) != 0)
								{
									if (Operators.CompareString(countryMap, "005", false) != 0)
									{
										if (Operators.CompareString(countryMap, "012", false) != 0)
										{
											if (Operators.CompareString(countryMap, "013", false) != 0)
											{
												flag5 = false;
												goto IL_161;
											}
										}
									}
								}
								flag5 = true;
								IL_161:
								flag4 = flag5;
								if (flag4)
								{
									result = "0201";
								}
								else
								{
									flag4 = (Operators.CompareString(countryMap, "022", false) == 0);
									if (flag4)
									{
										result = "0401";
									}
									else
									{
										unsureLabel = true;
										result = "9999";
									}
								}
							}
						}
					}
					else
					{
						flag4 = this.isTD4102301(mapPath);
						if (flag4)
						{
							result = "0301";
						}
						else
						{
							unsureLabel = true;
							result = "0500";
						}
					}
				}
				else
				{
					flag4 = (Operators.CompareString(mapVers, "5", false) == 0 && Operators.CompareString(mapRel, "2", false) == 0);
					if (flag4)
					{
						bool flag2 = Operators.CompareString(mapDate, "24/01/2008", false) == 0;
						if (flag2)
						{
							flag = (Operators.CompareString(countryMap, "002", false) == 0 || Operators.CompareString(countryMap, "003", false) == 0);
							if (flag)
							{
								result = "0401";
							}
							else
							{
								unsureLabel = true;
								result = "0550";
							}
						}
						else
						{
							unsureLabel = true;
							result = "0550";
						}
					}
					else
					{
						flag4 = (Operators.CompareString(mapVers, "6", false) == 0 && Operators.CompareString(mapRel, "1", false) == 0);
						if (flag4)
						{
							bool flag2 = Operators.CompareString(mapDate, "20/05/2008", false) == 0;
							if (flag2)
							{
								bool flag6;
								if (Operators.CompareString(countryMap, "001", false) != 0 && Operators.CompareString(countryMap, "002", false) != 0)
								{
									if (Operators.CompareString(countryMap, "006", false) != 0)
									{
										if (Operators.CompareString(countryMap, "021", false) != 0)
										{
											flag6 = false;
											goto IL_2E0;
										}
									}
								}
								flag6 = true;
								IL_2E0:
								flag = flag6;
								if (flag)
								{
									result = "0500";
								}
								else
								{
									flag4 = (Operators.CompareString(countryMap, "005", false) == 0);
									if (flag4)
									{
										result = "0400";
									}
									else
									{
										flag4 = (Operators.CompareString(countryMap, "022", false) == 0);
										if (flag4)
										{
											result = "0600";
										}
										else
										{
											unsureLabel = true;
											result = "0550";
										}
									}
								}
							}
							else
							{
								flag4 = (Operators.CompareString(mapDate, "19/05/2008", false) == 0);
								if (flag4)
								{
									flag2 = (Operators.CompareString(countryMap, "012", false) == 0);
									if (flag2)
									{
										result = "0400";
									}
									else
									{
										unsureLabel = true;
										result = "0550";
									}
								}
								else
								{
									flag4 = (Operators.CompareString(mapDate, "21/05/2008", false) == 0);
									if (flag4)
									{
										flag2 = (Operators.CompareString(countryMap, "020", false) == 0);
										if (flag2)
										{
											result = "0500";
										}
										else
										{
											unsureLabel = true;
											result = "0550";
										}
									}
									else
									{
										flag4 = (Operators.CompareString(mapDate, "05/05/2008", false) == 0);
										if (flag4)
										{
											bool flag7;
											if (Operators.CompareString(countryMap, "001", false) != 0 && Operators.CompareString(countryMap, "002", false) != 0)
											{
												if (Operators.CompareString(countryMap, "006", false) != 0)
												{
													if (Operators.CompareString(countryMap, "021", false) != 0)
													{
														flag7 = false;
														goto IL_435;
													}
												}
											}
											flag7 = true;
											IL_435:
											flag2 = flag7;
											if (flag2)
											{
												result = "0500";
											}
											else
											{
												flag4 = (Operators.CompareString(countryMap, "005", false) == 0);
												if (flag4)
												{
													result = "0400";
												}
												else
												{
													flag4 = (Operators.CompareString(countryMap, "012", false) == 0);
													if (flag4)
													{
														result = "0400";
													}
													else
													{
														flag4 = (Operators.CompareString(countryMap, "022", false) == 0);
														if (flag4)
														{
															result = "0600";
														}
														else
														{
															unsureLabel = true;
															result = "0550";
														}
													}
												}
											}
										}
										else
										{
											unsureLabel = true;
											result = "0550";
										}
									}
								}
							}
						}
						else
						{
							flag4 = (Operators.CompareString(mapVers, "6", false) == 0 && Operators.CompareString(mapRel, "2", false) == 0);
							if (flag4)
							{
								bool flag2 = Operators.CompareString(mapDate, "24/07/2008", false) == 0 || Operators.CompareString(mapDate, "23/07/2008", false) == 0;
								if (flag2)
								{
									flag = (Operators.CompareString(countryMap, "003", false) == 0);
									if (flag)
									{
										result = "0601";
									}
									else
									{
										flag4 = (Operators.CompareString(countryMap, "004", false) == 0);
										if (flag4)
										{
											result = "0401";
										}
										else
										{
											unsureLabel = true;
											result = "0550";
										}
									}
								}
								else
								{
									unsureLabel = true;
									result = "0550";
								}
							}
							else
							{
								flag4 = (Operators.CompareString(mapVers, "6", false) == 0 && Operators.CompareString(mapRel, "3", false) == 0);
								if (flag4)
								{
									bool flag2 = Operators.CompareString(mapDate, "24/07/2008", false) == 0 || Operators.CompareString(mapDate, "23/07/2008", false) == 0;
									if (flag2)
									{
										flag = (Operators.CompareString(countryMap, "013", false) == 0);
										if (flag)
										{
											result = "0401";
										}
										else
										{
											unsureLabel = true;
											result = "0550";
										}
									}
									else
									{
										unsureLabel = true;
										result = "0550";
									}
								}
								else
								{
									unsureLabel = true;
									result = "9999";
								}
							}
						}
					}
				}
			}
			flag4 = unsureLabel;
			if (flag4)
			{
				MyProject.Application.Log.WriteEntry(string.Format("Unknow map to copy : country {0:G}, version {1:G}, release {2:G}, date {3:G}", new object[]
				{
					countryMap,
					mapVers,
					mapRel,
					mapDate
				}), TraceEventType.Information);
				flag4 = (Interaction.MsgBox(string.Format(Resources.strWarUnkMap, new object[]
				{
					countryMap,
					mapVers,
					mapRel,
					mapDate
				}), MsgBoxStyle.YesNo, null) == MsgBoxResult.No);
				if (flag4)
				{
					MyProject.Application.Log.WriteEntry("Map refused by user", TraceEventType.Information);
					throw new SilentGUIException();
				}
			}
			return result;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00106AB0 File Offset: 0x00105AB0
		private static string getUpgCompatVersRel(string FileName, string mapVers, string mapRel)
		{
			bool flag = mapVers == null && mapRel == null;
			string result;
			if (flag)
			{
				result = FileName;
			}
			else
			{
				bool flag2;
				if (Operators.CompareString(mapVers, "2", false) != 0 || (Operators.CompareString(mapRel, "2", false) != 0 && Operators.CompareString(mapRel, "6", false) != 0))
				{
					if (Operators.CompareString(mapVers, "4", false) != 0 || Operators.CompareString(mapRel, "1", false) != 0)
					{
						if (Operators.CompareString(mapVers, "5", false) != 0 || Operators.CompareString(mapRel, "2", false) != 0)
						{
							if (Operators.CompareString(mapVers, "6", false) == 0)
							{
								if (Operators.CompareString(mapRel, "1", false) == 0 || Operators.CompareString(mapRel, "2", false) == 0)
								{
									goto IL_CB;
								}
								if (Operators.CompareString(mapRel, "3", false) == 0)
								{
									goto IL_CB;
								}
							}
							flag2 = false;
							goto IL_CC;
						}
					}
				}
				IL_CB:
				flag2 = true;
				IL_CC:
				flag = flag2;
				if (flag)
				{
					MyProject.Application.Log.WriteEntry(string.Format("UPG code {0:G}.{1:G} -> 4.1", mapVers, mapRel), TraceEventType.Information);
					result = FileName + ".4.1";
				}
				else
				{
					MyProject.Application.Log.WriteEntry(string.Format("UPG code {0:G}.{1:G} -> 4.1", mapVers, mapRel), TraceEventType.Information);
					flag = (Interaction.MsgBox(string.Format(Resources.strWarUnkMapVersRel, mapVers, mapRel), MsgBoxStyle.YesNo, null) == MsgBoxResult.No);
					if (flag)
					{
						MyProject.Application.Log.WriteEntry("Map refused by user", TraceEventType.Information);
						throw new SilentGUIException();
					}
					result = FileName + ".4.1";
				}
			}
			return result;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00106C20 File Offset: 0x00105C20
		public static bool isUpgradeSupported(int mapVers, int mapRel, string mapName)
		{
			if (mapVers != 4 || mapRel != 1)
			{
				if (mapVers != 5 || mapRel != 2)
				{
					if (mapVers == 6)
					{
						if (mapRel == 1 || mapRel == 2)
						{
							goto IL_2A;
						}
						if (mapRel == 3)
						{
							goto IL_2A;
						}
					}
					return false;
				}
			}
			IL_2A:
			return true;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00106C6C File Offset: 0x00105C6C
		public static bool isHddMapSupported(int mapVers, int mapRel)
		{
			if (mapVers != 2 || (mapRel != 2 && mapRel != 6))
			{
				if (mapVers != 4 || mapRel != 1)
				{
					if (mapVers != 5 || mapRel != 2)
					{
						if (mapVers == 6)
						{
							if (mapRel == 1 || mapRel == 2)
							{
								goto IL_38;
							}
							if (mapRel == 3)
							{
								goto IL_38;
							}
						}
						return false;
					}
				}
			}
			IL_38:
			return true;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00106CC4 File Offset: 0x00105CC4
		public static void copyAlertFiles(string CID)
		{
			string text = null;
			try
			{
				text = Path.Combine(MySettingsProperty.Settings.WorkingDirAlert, "dest");
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
				ZipFile zipFile = new ZipFile(Path.Combine(MyProject.Application.Info.DirectoryPath, "redist\\upg.dat"));
				zipFile.Password = "ZZZCOM.IND.lst";
				string text2 = Path.Combine(text, "UPG");
				flag = !MyProject.Computer.FileSystem.DirectoryExists(text2);
				if (flag)
				{
					MyProject.Computer.FileSystem.CreateDirectory(text2);
				}
				CopyMap.extractCopyFile(zipFile, "2", "RTxUtils.out", text2);
				CopyMap.extractCopyFile(zipFile, "1", "RTxUtils.out.inf", text2);
				CopyMap.extractCopyFile(zipFile, CopyMap.ZIP_FILE_POI_UPGRADE_CMD, "POI_UPGRADE.CMD", text2);
				CopyMap.extractAndProcessScript(zipFile, CopyMap.ZIP_FILE_POI_UPGRADE_SUB_CMD, "JANFI67_SCRIPT.CMD", text2, null, false, false, false, null);
			}
			catch (SilentGUIException ex)
			{
				throw new SilentGUIException();
			}
			catch (Exception ex2)
			{
				Interaction.MsgBox(string.Format(Resources.strErrCopy, MySettingsProperty.Settings.WorkingDirAlert, text), MsgBoxStyle.OkOnly, null);
				throw new SilentGUIException();
			}
		}

		// Token: 0x0400038C RID: 908
		private const string ZIP_FILE_BUILTINS_OUT_INF = "1";

		// Token: 0x0400038D RID: 909
		private const string ZIP_FILE_BUILTINS_OUT = "2";

		// Token: 0x0400038E RID: 910
		private const string ZIP_FILE_NAV_UPGRADE = "3";

		// Token: 0x0400038F RID: 911
		public const string ZIP_FILE_NAV_UPGRADE_SUB_CMD = "4";

		// Token: 0x04000390 RID: 912
		public const string ZIP_FILE_NAV_UPGRADE_SUB_UPGONLY_CMD = "5";

		// Token: 0x04000391 RID: 913
		private const string ZIP_FILE_DB_DWNL_PPC_OUT_INF = "6";

		// Token: 0x04000392 RID: 914
		private const string ZIP_FILE_CD_VER_LA = "7";

		// Token: 0x04000393 RID: 915
		private const string ZIP_FILE_CD_VER_NAV = "8";

		// Token: 0x04000394 RID: 916
		private const string ZIP_FILE_DB_DWNL_PPC_OUT = "9";

		// Token: 0x04000395 RID: 917
		private const string ZIP_FILE_CD_VER_LA_INF = "10";

		// Token: 0x04000396 RID: 918
		private const string ZIP_FILE_CD_VER_NAV_INF = "11";

		// Token: 0x04000397 RID: 919
		private const string ZIP_FILE_DB_DWNL_OUT = "12";

		// Token: 0x04000398 RID: 920
		private const string ZIP_FILE_DB_DWNL_OUT_INF = "13";

		// Token: 0x04000399 RID: 921
		private const string ZIP_FILE_SW_VER_DAT = "14";

		// Token: 0x0400039A RID: 922
		private const string ZIP_FILE_GRUPPO_4_MRE_DAT = "15";

		// Token: 0x0400039B RID: 923
		private const string ZIP_FILE_CD_VER_LA_MOD = "16";

		// Token: 0x0400039C RID: 924
		private static string ZIP_FILE_POI_UPGRADE_CMD = "17";

		// Token: 0x0400039D RID: 925
		private static string ZIP_FILE_POI_UPGRADE_SUB_CMD = "18";

		// Token: 0x0400039E RID: 926
		public const string ZIP_FILE_TABLE_UPGRADE_EXCL_DAT = "21";

		// Token: 0x0400039F RID: 927
		private const string ZIP_FILE_NAV_UPGRADEJANFI67_SCRIPT_CMD = "23";

		// Token: 0x040003A0 RID: 928
		private const string ZIP_FILE_NAV_UPGRADE_SUB_HDDMAP2USBCOPY_CMD = "24";

		// Token: 0x040003A1 RID: 929
		private const string ZIP_FILE_NAV_UPGRADE_SUB_CFG2USBCOPY_CMD = "26";

		// Token: 0x040003A2 RID: 930
		public const string ZIP_FILE_MM_BMP = "27";

		// Token: 0x040003A3 RID: 931
		public const string ZIP_FILE_CITROEN_BMP = "28";

		// Token: 0x040003A4 RID: 932
		public const string ZIP_FILE_FIAT_BMP = "29";

		// Token: 0x040003A5 RID: 933
		public const string ZIP_FILE_LANCIA_BMP = "29";

		// Token: 0x040003A6 RID: 934
		public const string ZIP_FILE_PEUGEOT_BMP = "31";

		// Token: 0x040003A7 RID: 935
		public const string ZIP_FILE_PC_BMP = "32";

		// Token: 0x040003A8 RID: 936
		public const string ZIP_FILE_RTX_BMP = "33";

		// Token: 0x040003A9 RID: 937
		public const string ZIP_FILE_FILE_TO_TFFS_HDD_COPY_CMD = "34";

		// Token: 0x040003AA RID: 938
		public const string ZIP_FILE_MM711_BMP = "35";

		// Token: 0x040003AB RID: 939
		public const string ZIP_FILE_PEUGEOT711_BMP = "36";

		// Token: 0x040003AC RID: 940
		public const string ZIP_FILE_MM711_HDBMP = "38";

		// Token: 0x040003AD RID: 941
		public const string ZIP_FILE_CITROEN_HDBMP = "39";

		// Token: 0x040003AE RID: 942
		public const string ZIP_FILE_FIAT_HDBMP = "40";

		// Token: 0x040003AF RID: 943
		public const string ZIP_FILE_LANCIA_HDBMP = "40";

		// Token: 0x040003B0 RID: 944
		public const string ZIP_FILE_PEUGEOT711_HDBMP = "41";

		// Token: 0x040003B1 RID: 945
		public const string ZIP_FILE_PC_HDBMP = "42";

		// Token: 0x040003B2 RID: 946
		public const string ZIP_FILE_RTX_HDBMP = "43";

		// Token: 0x040003B3 RID: 947
		public const string ZIP_FILE_NAV_UPGRADE_DBDWNL_PATCH_CMD = "44";

		// Token: 0x02000039 RID: 57
		private class gruppoEx : Exception
		{
			// Token: 0x06000676 RID: 1654 RVA: 0x00106EB8 File Offset: 0x00105EB8
			[DebuggerNonUserCode]
			public gruppoEx()
			{
			}
		}
	}
}
