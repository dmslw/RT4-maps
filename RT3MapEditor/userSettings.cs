using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x020000DB RID: 219
	public class userSettings
	{
		// Token: 0x06000E71 RID: 3697 RVA: 0x00132B5C File Offset: 0x00131B5C
		public userSettings()
		{
			this.lastLoadedMaps = null;
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00132B70 File Offset: 0x00131B70
		public void readUpgSettings(ref bool isFirstRun)
		{
			bool flag = ApplicationDeployment.IsNetworkDeployed;
			checked
			{
				bool flag3;
				if (flag)
				{
					MyProject.Application.Log.WriteEntry("ClickOnce deployement", TraceEventType.Information);
					MyProject.Application.Log.WriteEntry(Conversions.ToString(ApplicationDeployment.CurrentDeployment.IsFirstRun));
					isFirstRun = (ApplicationDeployment.CurrentDeployment.IsFirstRun || MySettingsProperty.Settings.isFirstRun);
					flag = isFirstRun;
					if (flag)
					{
						try
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(ApplicationDeployment.CurrentDeployment.DataDirectory);
							MyProject.Application.Log.WriteEntry(directoryInfo.FullName);
							DirectoryInfo parent = Directory.GetParent(directoryInfo.FullName);
							parent = parent.Parent;
							DateTime creationTimeUtc = new DateTime(0L);
							int num = -1;
							FileInfo[] files = parent.GetFiles("user.config", SearchOption.AllDirectories);
							flag = (files != null && files.Length > 0);
							if (flag)
							{
								int num2 = files.Length - 1;
								for (;;)
								{
									int num3 = num2;
									int num4 = 0;
									if (num3 < num4)
									{
										break;
									}
									bool flag2 = files[num2].DirectoryName.IndexOf("rt3m..tion_7d88b0c315963c37_0000.0003_") != -1 || files[num2].DirectoryName.IndexOf("rt3m..tion_e26275c46e9162ff_0000.0004_") != -1;
									if (flag2)
									{
										flag3 = (DateTime.Compare(files[num2].CreationTimeUtc, creationTimeUtc) > 0);
										if (flag3)
										{
											creationTimeUtc = files[num2].CreationTimeUtc;
											num = num2;
										}
									}
									num2 += -1;
								}
							}
							flag3 = (num != -1);
							if (flag3)
							{
								MyProject.Application.Log.WriteEntry("copy " + files[num].DirectoryName + " to " + Path.Combine(directoryInfo.FullName, "0.3.0.2"));
								MyProject.Computer.FileSystem.CopyDirectory(files[num].DirectoryName, Path.Combine(directoryInfo.FullName, "0.3.0.2"), true);
							}
						}
						catch (Exception ex)
						{
							MyProject.Application.Log.WriteEntry("Previous installation not found", TraceEventType.Information);
						}
					}
				}
				else
				{
					MyProject.Application.Log.WriteEntry("not a ClickOnce deployement", TraceEventType.Information);
					isFirstRun = MySettingsProperty.Settings.isFirstRun;
				}
				flag3 = isFirstRun;
				if (flag3)
				{
					MyProject.Application.Log.WriteEntry("Try to upgrade Settings from a previous version", TraceEventType.Information);
					MyProject.Application.Log.WriteEntry(MySettingsProperty.Settings.WorkingDir);
					MyProject.Application.Log.WriteEntry(Conversions.ToString(MySettingsProperty.Settings.GetPreviousVersion("WorkingDir")));
					MySettingsProperty.Settings.Upgrade();
					MySettingsProperty.Settings.isFirstRun = true;
					MySettingsProperty.Settings.Save();
					MySettingsProperty.Settings.Reload();
				}
				this.initEmptySetting(isFirstRun);
				this.readRTxTypeDepSettings();
				this.readRTxModeDepSettings();
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00132E48 File Offset: 0x00131E48
		private void initEmptySetting(bool isFirstRun)
		{
			this.InitPath(isFirstRun);
			bool flag = MySettingsProperty.Settings.importCsvSepInt == 0;
			if (flag)
			{
				MySettingsProperty.Settings.importCsvSepInt = 9;
			}
			this.initCulture(isFirstRun);
			this.initGpsPassionStrings(isFirstRun);
			this.copyIconsToRT3Icons(isFirstRun);
			this.initRT3Icons(isFirstRun);
			this.initRT4Icons(isFirstRun);
			this.copyChangeType();
			this.initExportFiledName();
			this.copyMagToRT3Mag(isFirstRun);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00132EBC File Offset: 0x00131EBC
		private void InitPath(bool isFirstRun)
		{
			bool flag = Operators.CompareString(MySettingsProperty.Settings.importPath, "", false) == 0;
			if (flag)
			{
				MySettingsProperty.Settings.importPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportPath, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.tempDir, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.tempDir = Path.GetTempPath();
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.WorkingDir, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.WorkingDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "RTxMap");
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.WorkingDirAlert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.WorkingDirAlert = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "UserPOI");
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.ISODir, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.ISODir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "RTxMap");
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.alertDIRCID, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.alertDIRCID = "002";
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.BurningCommand, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.BurningCommand = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
			}
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0013305C File Offset: 0x0013205C
		private void initCulture(bool isFirstRun)
		{
			bool flag = Operators.CompareString(MySettingsProperty.Settings.UICulture, "", false) == 0;
			bool flag2;
			if (flag)
			{
				flag2 = (Operators.CompareString(Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName, "fr", false) == 0);
				if (flag2)
				{
					MySettingsProperty.Settings.UICulture = "fr";
				}
				else
				{
					flag2 = (Operators.CompareString(Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName, "pt", false) == 0);
					if (flag2)
					{
						MySettingsProperty.Settings.UICulture = "pt";
					}
					else
					{
						MySettingsProperty.Settings.UICulture = "en";
					}
				}
			}
			flag2 = (isFirstRun && Operators.CompareString(MySettingsProperty.Settings.UICulture, "en", false) == 0);
			if (flag2)
			{
				MySettingsProperty.Settings.UICulture = "pt";
			}
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(MySettingsProperty.Settings.UICulture);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00133150 File Offset: 0x00132150
		private void initGpsPassionStrings(bool isFirstRun)
		{
			bool flag = Operators.CompareString(MySettingsProperty.Settings.strGpsPasFMap, "", false) == 0;
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasFMap = Resources.strGpsPasFMap;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasRMap, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasRMap = Resources.strGpsPasRMap;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasNCMap, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasNCMap = Resources.strGpsPasNCMap;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasPANMap, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasPANMap = Resources.strGpsPasPANMap;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasPLMap, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasPLMap = Resources.strGpsPasPLMap;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasRDMap, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasRDMap = Resources.strGpsPasRDMap;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasRFMap, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasRFMap = Resources.strGpsPasRFMap;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasRFRMap, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasRFRMap = Resources.strGpsPasRFRMap;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasRMMap, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasRMMap = Resources.strGpsPasRMMap;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasKMHMap, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasKMHMap = Resources.strGpsPasKmhMap;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasSep1Map, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasSep1Map = " ";
			}
			flag = MySettingsProperty.Settings.strGpsPasSep1Map.StartsWith("\r");
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasSep1Map = " ";
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasSep2Map, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasSep2Map = "-";
			}
			flag = MySettingsProperty.Settings.strGpsPasSep2Map.StartsWith("\r");
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasSep2Map = " ";
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasFAlert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasFAlert = Resources.strGpsPasFAlert;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasRAlert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasRAlert = Resources.strGpsPasRAlert;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasNCAlert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasNCAlert = Resources.strGpsPasNCAlert;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasPANAlert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasPANAlert = Resources.strGpsPasPANAlert;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasPLAlert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasPLAlert = Resources.strGpsPasPLAlert;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasRDAlert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasRDAlert = Resources.strGpsPasRDAlert;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasRFAlert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasRFAlert = Resources.strGpsPasRFAlert;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasRFRAlert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasRFRAlert = Resources.strGpsPasRFRAlert;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasRMAlert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasRMAlert = Resources.strGpsPasRMAlert;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasKMHAlert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasKMHAlert = Resources.strGpsPasKmhAlert;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasSep1Alert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasSep1Alert = " ";
			}
			flag = MySettingsProperty.Settings.strGpsPasSep1Alert.StartsWith("\r");
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasSep1Alert = " ";
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.strGpsPasSep2Alert, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasSep2Alert = "-";
			}
			flag = MySettingsProperty.Settings.strGpsPasSep2Alert.StartsWith("\r");
			if (flag)
			{
				MySettingsProperty.Settings.strGpsPasSep2Alert = " ";
			}
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0013363C File Offset: 0x0013263C
		private void copyMagToRT3Mag(bool isFirstRun)
		{
			bool flag = MySettingsProperty.Settings.STimportAllMagRT3 == byte.MaxValue;
			if (flag)
			{
				MySettingsProperty.Settings.STimportAllMagRT3 = MySettingsProperty.Settings.STimportAllMag;
			}
			flag = (MySettingsProperty.Settings.STImportFixedMagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportFixedMagRT3 = MySettingsProperty.Settings.STImportFixedMag;
			}
			flag = (MySettingsProperty.Settings.STimportMobileMagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STimportMobileMagRT3 = MySettingsProperty.Settings.STimportMobileMag;
			}
			flag = (MySettingsProperty.Settings.STImportRFRMagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportRFRMagRT3 = MySettingsProperty.Settings.STImportRFRMag;
			}
			flag = (MySettingsProperty.Settings.STImportF120_130GMagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF120_130GMagRT3 = MySettingsProperty.Settings.STImportF120_130GMag;
			}
			flag = (MySettingsProperty.Settings.STImportF100_119MagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF100_119MagRT3 = MySettingsProperty.Settings.STImportF100_119Mag;
			}
			flag = (MySettingsProperty.Settings.STImportF80_99MagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF80_99MagRT3 = MySettingsProperty.Settings.STImportF80_99Mag;
			}
			flag = (MySettingsProperty.Settings.STImportF60_79MagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF60_79MagRT3 = MySettingsProperty.Settings.STImportF60_79Mag;
			}
			flag = (MySettingsProperty.Settings.STImportF0_59MagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF0_59MagRT3 = MySettingsProperty.Settings.STImportF0_59Mag;
			}
			flag = (MySettingsProperty.Settings.STImportM120_130MagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM120_130MagRT3 = MySettingsProperty.Settings.STImportM120_130Mag;
			}
			flag = (MySettingsProperty.Settings.STImportM100_119MagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM100_119MagRT3 = MySettingsProperty.Settings.STImportM100_119Mag;
			}
			flag = (MySettingsProperty.Settings.STImportM80_99MagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM80_99MagRT3 = MySettingsProperty.Settings.STImportM80_99Mag;
			}
			flag = (MySettingsProperty.Settings.STImportM60_79MagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM60_79MagRT3 = MySettingsProperty.Settings.STImportM60_79Mag;
			}
			flag = (MySettingsProperty.Settings.STImportM0_59MagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM0_59MagRT3 = MySettingsProperty.Settings.STImportM0_59Mag;
			}
			flag = (MySettingsProperty.Settings.importDefaultMagRT3 == byte.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.importDefaultMagRT3 = MySettingsProperty.Settings.importDefaultMag;
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x001338D0 File Offset: 0x001328D0
		private void copyIconsToRT3Icons(bool isFirstRun)
		{
			bool flag = MySettingsProperty.Settings.STimportAllTypeRT3 == ushort.MaxValue;
			if (flag)
			{
				MySettingsProperty.Settings.STimportAllTypeRT3 = MySettingsProperty.Settings.STimportAllType;
			}
			flag = (MySettingsProperty.Settings.STimportFixedTypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STimportFixedTypeRT3 = MySettingsProperty.Settings.STimportFixedType;
			}
			flag = (MySettingsProperty.Settings.STimportMobileTypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STimportMobileTypeRT3 = MySettingsProperty.Settings.STimportMobileType;
			}
			flag = (MySettingsProperty.Settings.STImportRFRTypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportRFRTypeRT3 = MySettingsProperty.Settings.STImportRFRType;
			}
			flag = (MySettingsProperty.Settings.STImportF120_130GTypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF120_130GTypeRT3 = MySettingsProperty.Settings.STImportF120_130GType;
			}
			flag = (MySettingsProperty.Settings.STImportF100_119TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF100_119TypeRT3 = MySettingsProperty.Settings.STImportF100_119Type;
			}
			flag = (MySettingsProperty.Settings.STImportF80_99TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF80_99TypeRT3 = MySettingsProperty.Settings.STImportF80_99Type;
			}
			flag = (MySettingsProperty.Settings.STImportF60_79TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF60_79TypeRT3 = MySettingsProperty.Settings.STImportF60_79Type;
			}
			flag = (MySettingsProperty.Settings.STImportF0_59TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF0_59TypeRT3 = MySettingsProperty.Settings.STImportF0_59Type;
			}
			flag = (MySettingsProperty.Settings.STImportM120_130TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM120_130TypeRT3 = MySettingsProperty.Settings.STImportM120_130Type;
			}
			flag = (MySettingsProperty.Settings.STImportM100_119TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM100_119TypeRT3 = MySettingsProperty.Settings.STImportM100_119Type;
			}
			flag = (MySettingsProperty.Settings.STImportM80_99TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM80_99TypeRT3 = MySettingsProperty.Settings.STImportM80_99Type;
			}
			flag = (MySettingsProperty.Settings.STImportM60_79TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM60_79TypeRT3 = MySettingsProperty.Settings.STImportM60_79Type;
			}
			flag = (MySettingsProperty.Settings.STImportM0_59TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM0_59TypeRT3 = MySettingsProperty.Settings.STImportM0_59Type;
			}
			flag = (MySettingsProperty.Settings.ImportDefaultTypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.ImportDefaultTypeRT3 = MySettingsProperty.Settings.importDefaultType;
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00133B64 File Offset: 0x00132B64
		private void initRT3Icons(bool isFirstRun)
		{
			bool flag = MySettingsProperty.Settings.STimportAllTypeRT3 == ushort.MaxValue;
			if (flag)
			{
				MySettingsProperty.Settings.STimportAllTypeRT3 = 1002;
			}
			flag = (MySettingsProperty.Settings.STimportFixedTypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STimportFixedTypeRT3 = 1002;
			}
			flag = (MySettingsProperty.Settings.STimportMobileTypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STimportMobileTypeRT3 = 7522;
			}
			flag = (MySettingsProperty.Settings.STImportF120_130GTypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF120_130GTypeRT3 = 1002;
			}
			flag = (MySettingsProperty.Settings.STImportF100_119TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF100_119TypeRT3 = 1002;
			}
			flag = (MySettingsProperty.Settings.STImportF80_99TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF80_99TypeRT3 = 1002;
			}
			flag = (MySettingsProperty.Settings.STImportF60_79TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF60_79TypeRT3 = 1002;
			}
			flag = (MySettingsProperty.Settings.STImportF0_59TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF0_59TypeRT3 = 1002;
			}
			flag = (MySettingsProperty.Settings.STImportM120_130TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM120_130TypeRT3 = 7522;
			}
			flag = (MySettingsProperty.Settings.STImportM100_119TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM100_119TypeRT3 = 7522;
			}
			flag = (MySettingsProperty.Settings.STImportM80_99TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM80_99TypeRT3 = 7522;
			}
			flag = (MySettingsProperty.Settings.STImportM60_79TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM60_79TypeRT3 = 7522;
			}
			flag = (MySettingsProperty.Settings.STImportM0_59TypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM0_59TypeRT3 = 7522;
			}
			flag = (MySettingsProperty.Settings.STImportRFRTypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportRFRTypeRT3 = 1002;
			}
			flag = (MySettingsProperty.Settings.ImportDefaultTypeRT3 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.ImportDefaultTypeRT3 = 1002;
			}
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00133DB0 File Offset: 0x00132DB0
		private void initRT4Icons(bool isFirstRun)
		{
			bool flag = MySettingsProperty.Settings.STimportAllTypeRT4 == ushort.MaxValue;
			if (flag)
			{
				MySettingsProperty.Settings.STimportAllTypeRT4 = 1002;
			}
			flag = (MySettingsProperty.Settings.STimportFixedTypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STimportFixedTypeRT4 = 1002;
			}
			flag = (MySettingsProperty.Settings.STimportMobileTypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STimportMobileTypeRT4 = 7522;
			}
			flag = (MySettingsProperty.Settings.STImportF120_130GTypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF120_130GTypeRT4 = 1002;
			}
			flag = (MySettingsProperty.Settings.STImportF100_119TypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF100_119TypeRT4 = 1002;
			}
			flag = (MySettingsProperty.Settings.STImportF80_99TypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF80_99TypeRT4 = 1002;
			}
			flag = (MySettingsProperty.Settings.STImportF60_79TypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF60_79TypeRT4 = 1002;
			}
			flag = (MySettingsProperty.Settings.STImportF0_59TypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportF0_59TypeRT4 = 1002;
			}
			flag = (MySettingsProperty.Settings.STImportM120_130TypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM120_130TypeRT4 = 7522;
			}
			flag = (MySettingsProperty.Settings.STImportM100_119TypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM100_119TypeRT4 = 7522;
			}
			flag = (MySettingsProperty.Settings.STImportM80_99TypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM80_99TypeRT4 = 7522;
			}
			flag = (MySettingsProperty.Settings.STImportM60_79TypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM60_79TypeRT4 = 7522;
			}
			flag = (MySettingsProperty.Settings.STImportM0_59TypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportM0_59TypeRT4 = 7522;
			}
			flag = (MySettingsProperty.Settings.STImportRFRTypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.STImportRFRTypeRT4 = 1002;
			}
			flag = (MySettingsProperty.Settings.ImportDefaultTypeRT4 == ushort.MaxValue);
			if (flag)
			{
				MySettingsProperty.Settings.ImportDefaultTypeRT4 = 1002;
			}
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00133FFC File Offset: 0x00132FFC
		private void copyChangeType()
		{
			bool flag = Operators.CompareString(MySettingsProperty.Settings.newChangeImpIgn, "", false) == 0;
			if (flag)
			{
				MySettingsProperty.Settings.changeRT3BorderCrossing = MySettingsProperty.Settings.changeBorderCrossing;
				MySettingsProperty.Settings.changeRT3CivicCenter = MySettingsProperty.Settings.changeCivicCenter;
				MySettingsProperty.Settings.changeRT3Embassy = MySettingsProperty.Settings.changeEmbassy;
				MySettingsProperty.Settings.changeRT3IndustArea = MySettingsProperty.Settings.changeIndustArea;
				MySettingsProperty.Settings.changeRT3MedicServ = MySettingsProperty.Settings.changeMedicServ;
				MySettingsProperty.Settings.changeRT3Motorb = MySettingsProperty.Settings.changeMotorb;
				MySettingsProperty.Settings.changeRT3PerfArts = MySettingsProperty.Settings.changePerfArts;
				MySettingsProperty.Settings.newChangeImpIgn = "done";
			}
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x001340D0 File Offset: 0x001330D0
		private void readRTxTypeDepSettings()
		{
			bool flag = Common.RTxType == Common.RTxTypes.typeRT3;
			if (flag)
			{
				MySettingsProperty.Settings.STimportAllType = MySettingsProperty.Settings.STimportAllTypeRT3;
				MySettingsProperty.Settings.STimportFixedType = MySettingsProperty.Settings.STimportFixedTypeRT3;
				MySettingsProperty.Settings.STimportMobileType = MySettingsProperty.Settings.STimportMobileTypeRT3;
				MySettingsProperty.Settings.STImportRFRType = MySettingsProperty.Settings.STImportRFRTypeRT3;
				MySettingsProperty.Settings.STImportF120_130GType = MySettingsProperty.Settings.STImportF120_130GTypeRT3;
				MySettingsProperty.Settings.STImportF100_119Type = MySettingsProperty.Settings.STImportF100_119TypeRT3;
				MySettingsProperty.Settings.STImportF80_99Type = MySettingsProperty.Settings.STImportF80_99TypeRT3;
				MySettingsProperty.Settings.STImportF60_79Type = MySettingsProperty.Settings.STImportF60_79TypeRT3;
				MySettingsProperty.Settings.STImportF0_59Type = MySettingsProperty.Settings.STImportF0_59TypeRT3;
				MySettingsProperty.Settings.STImportM120_130Type = MySettingsProperty.Settings.STImportM120_130TypeRT3;
				MySettingsProperty.Settings.STImportM100_119Type = MySettingsProperty.Settings.STImportM100_119TypeRT3;
				MySettingsProperty.Settings.STImportM80_99Type = MySettingsProperty.Settings.STImportM80_99TypeRT3;
				MySettingsProperty.Settings.STImportM60_79Type = MySettingsProperty.Settings.STImportM60_79TypeRT3;
				MySettingsProperty.Settings.STImportM0_59Type = MySettingsProperty.Settings.STImportM0_59TypeRT3;
				MySettingsProperty.Settings.importDefaultType = MySettingsProperty.Settings.ImportDefaultTypeRT3;
				MySettingsProperty.Settings.changeRTxBorderCrossing = MySettingsProperty.Settings.changeRT3BorderCrossing;
				MySettingsProperty.Settings.changeRTxCivicCenter = MySettingsProperty.Settings.changeRT3CivicCenter;
				MySettingsProperty.Settings.changeRTxEmbassy = MySettingsProperty.Settings.changeRT3Embassy;
				MySettingsProperty.Settings.changeRTxIndustArea = MySettingsProperty.Settings.changeRT3IndustArea;
				MySettingsProperty.Settings.changeRTxMedicServ = MySettingsProperty.Settings.changeRT3MedicServ;
				MySettingsProperty.Settings.changeRTxMotorb = MySettingsProperty.Settings.changeRT3Motorb;
				MySettingsProperty.Settings.changeRTxPerfArts = MySettingsProperty.Settings.changeRT3PerfArts;
				MySettingsProperty.Settings.ignoreRTxBorgate = MySettingsProperty.Settings.ignoreRT3Borgate;
				MySettingsProperty.Settings.ignoreRTxAltName = MySettingsProperty.Settings.ignoreRT3AltName;
				MySettingsProperty.Settings.STimportAllMag = MySettingsProperty.Settings.STimportAllMagRT3;
				MySettingsProperty.Settings.STImportFixedMag = MySettingsProperty.Settings.STImportFixedMagRT3;
				MySettingsProperty.Settings.STimportMobileMag = MySettingsProperty.Settings.STimportMobileMagRT3;
				MySettingsProperty.Settings.STImportRFRMag = MySettingsProperty.Settings.STImportRFRMagRT3;
				MySettingsProperty.Settings.STImportF120_130GMag = MySettingsProperty.Settings.STImportF120_130GMagRT3;
				MySettingsProperty.Settings.STImportF100_119Mag = MySettingsProperty.Settings.STImportF100_119MagRT3;
				MySettingsProperty.Settings.STImportF80_99Mag = MySettingsProperty.Settings.STImportF80_99MagRT3;
				MySettingsProperty.Settings.STImportF60_79Mag = MySettingsProperty.Settings.STImportF60_79MagRT3;
				MySettingsProperty.Settings.STImportF0_59Mag = MySettingsProperty.Settings.STImportF0_59MagRT3;
				MySettingsProperty.Settings.STImportM120_130Mag = MySettingsProperty.Settings.STImportM120_130MagRT3;
				MySettingsProperty.Settings.STImportM100_119Mag = MySettingsProperty.Settings.STImportM100_119MagRT3;
				MySettingsProperty.Settings.STImportM80_99Mag = MySettingsProperty.Settings.STImportM80_99MagRT3;
				MySettingsProperty.Settings.STImportM60_79Mag = MySettingsProperty.Settings.STImportM60_79MagRT3;
				MySettingsProperty.Settings.STImportM0_59Mag = MySettingsProperty.Settings.STImportM0_59MagRT3;
				MySettingsProperty.Settings.importDefaultMag = MySettingsProperty.Settings.importDefaultMagRT3;
			}
			else
			{
				MySettingsProperty.Settings.STimportAllType = MySettingsProperty.Settings.STimportAllTypeRT4;
				MySettingsProperty.Settings.STimportFixedType = MySettingsProperty.Settings.STimportFixedTypeRT4;
				MySettingsProperty.Settings.STimportMobileType = MySettingsProperty.Settings.STimportMobileTypeRT4;
				MySettingsProperty.Settings.STImportRFRType = MySettingsProperty.Settings.STImportRFRTypeRT4;
				MySettingsProperty.Settings.STImportF120_130GType = MySettingsProperty.Settings.STImportF120_130GTypeRT4;
				MySettingsProperty.Settings.STImportF100_119Type = MySettingsProperty.Settings.STImportF100_119TypeRT4;
				MySettingsProperty.Settings.STImportF80_99Type = MySettingsProperty.Settings.STImportF80_99TypeRT4;
				MySettingsProperty.Settings.STImportF60_79Type = MySettingsProperty.Settings.STImportF60_79TypeRT4;
				MySettingsProperty.Settings.STImportF0_59Type = MySettingsProperty.Settings.STImportF0_59TypeRT4;
				MySettingsProperty.Settings.STImportM120_130Type = MySettingsProperty.Settings.STImportM120_130TypeRT4;
				MySettingsProperty.Settings.STImportM100_119Type = MySettingsProperty.Settings.STImportM100_119TypeRT4;
				MySettingsProperty.Settings.STImportM80_99Type = MySettingsProperty.Settings.STImportM80_99TypeRT4;
				MySettingsProperty.Settings.STImportM60_79Type = MySettingsProperty.Settings.STImportM60_79TypeRT4;
				MySettingsProperty.Settings.STImportM0_59Type = MySettingsProperty.Settings.STImportM0_59TypeRT4;
				MySettingsProperty.Settings.importDefaultType = MySettingsProperty.Settings.ImportDefaultTypeRT4;
				MySettingsProperty.Settings.changeRTxBorderCrossing = MySettingsProperty.Settings.changeRT4BorderCrossing;
				MySettingsProperty.Settings.changeRTxCivicCenter = MySettingsProperty.Settings.changeRT4CivicCenter;
				MySettingsProperty.Settings.changeRTxEmbassy = MySettingsProperty.Settings.changeRT4Embassy;
				MySettingsProperty.Settings.changeRTxIndustArea = MySettingsProperty.Settings.changeRT4IndustArea;
				MySettingsProperty.Settings.changeRTxMedicServ = MySettingsProperty.Settings.changeRT4MedicServ;
				MySettingsProperty.Settings.changeRTxMotorb = MySettingsProperty.Settings.changeRT4Motorb;
				MySettingsProperty.Settings.changeRTxPerfArts = MySettingsProperty.Settings.changeRT4PerfArts;
				MySettingsProperty.Settings.ignoreRTxBorgate = MySettingsProperty.Settings.ignoreRT4Borgate;
				MySettingsProperty.Settings.ignoreRTxAltName = MySettingsProperty.Settings.ignoreRT4AltName;
				MySettingsProperty.Settings.STimportAllMag = MySettingsProperty.Settings.STimportAllMagRT4;
				MySettingsProperty.Settings.STImportFixedMag = MySettingsProperty.Settings.STImportFixedMagRT4;
				MySettingsProperty.Settings.STimportMobileMag = MySettingsProperty.Settings.STimportMobileMagRT4;
				MySettingsProperty.Settings.STImportRFRMag = MySettingsProperty.Settings.STImportRFRMagRT4;
				MySettingsProperty.Settings.STImportF120_130GMag = MySettingsProperty.Settings.STImportF120_130GMagRT4;
				MySettingsProperty.Settings.STImportF100_119Mag = MySettingsProperty.Settings.STImportF100_119MagRT4;
				MySettingsProperty.Settings.STImportF80_99Mag = MySettingsProperty.Settings.STImportF80_99MagRT4;
				MySettingsProperty.Settings.STImportF60_79Mag = MySettingsProperty.Settings.STImportF60_79MagRT4;
				MySettingsProperty.Settings.STImportF0_59Mag = MySettingsProperty.Settings.STImportF0_59MagRT4;
				MySettingsProperty.Settings.STImportM120_130Mag = MySettingsProperty.Settings.STImportM120_130MagRT4;
				MySettingsProperty.Settings.STImportM100_119Mag = MySettingsProperty.Settings.STImportM100_119MagRT4;
				MySettingsProperty.Settings.STImportM80_99Mag = MySettingsProperty.Settings.STImportM80_99MagRT4;
				MySettingsProperty.Settings.STImportM60_79Mag = MySettingsProperty.Settings.STImportM60_79MagRT4;
				MySettingsProperty.Settings.STImportM0_59Mag = MySettingsProperty.Settings.STImportM0_59MagRT4;
				MySettingsProperty.Settings.importDefaultMag = MySettingsProperty.Settings.importDefaultMagRT4;
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0013475C File Offset: 0x0013375C
		private void writeRTxTypeDepSettings()
		{
			bool flag = Common.RTxType == Common.RTxTypes.typeRT3;
			if (flag)
			{
				MySettingsProperty.Settings.STimportAllTypeRT3 = MySettingsProperty.Settings.STimportAllType;
				MySettingsProperty.Settings.STimportFixedTypeRT3 = MySettingsProperty.Settings.STimportFixedType;
				MySettingsProperty.Settings.STimportMobileTypeRT3 = MySettingsProperty.Settings.STimportMobileType;
				MySettingsProperty.Settings.STImportRFRTypeRT3 = MySettingsProperty.Settings.STImportRFRType;
				MySettingsProperty.Settings.STImportF120_130GTypeRT3 = MySettingsProperty.Settings.STImportF120_130GType;
				MySettingsProperty.Settings.STImportF100_119TypeRT3 = MySettingsProperty.Settings.STImportF100_119Type;
				MySettingsProperty.Settings.STImportF80_99TypeRT3 = MySettingsProperty.Settings.STImportF80_99Type;
				MySettingsProperty.Settings.STImportF60_79TypeRT3 = MySettingsProperty.Settings.STImportF60_79Type;
				MySettingsProperty.Settings.STImportF0_59TypeRT3 = MySettingsProperty.Settings.STImportF0_59Type;
				MySettingsProperty.Settings.STImportM120_130TypeRT3 = MySettingsProperty.Settings.STImportM120_130Type;
				MySettingsProperty.Settings.STImportM100_119TypeRT3 = MySettingsProperty.Settings.STImportM100_119Type;
				MySettingsProperty.Settings.STImportM80_99TypeRT3 = MySettingsProperty.Settings.STImportM80_99Type;
				MySettingsProperty.Settings.STImportM60_79TypeRT3 = MySettingsProperty.Settings.STImportM60_79Type;
				MySettingsProperty.Settings.STImportM0_59TypeRT3 = MySettingsProperty.Settings.STImportM0_59Type;
				MySettingsProperty.Settings.ImportDefaultTypeRT3 = MySettingsProperty.Settings.importDefaultType;
				MySettingsProperty.Settings.changeRT3BorderCrossing = MySettingsProperty.Settings.changeRTxBorderCrossing;
				MySettingsProperty.Settings.changeRT3CivicCenter = MySettingsProperty.Settings.changeRTxCivicCenter;
				MySettingsProperty.Settings.changeRT3IndustArea = MySettingsProperty.Settings.changeRTxIndustArea;
				MySettingsProperty.Settings.changeRT3MedicServ = MySettingsProperty.Settings.changeRTxMedicServ;
				MySettingsProperty.Settings.changeRT3Motorb = MySettingsProperty.Settings.changeRTxMotorb;
				MySettingsProperty.Settings.changeRT3PerfArts = MySettingsProperty.Settings.changeRTxPerfArts;
				MySettingsProperty.Settings.ignoreRT3Borgate = MySettingsProperty.Settings.ignoreRTxBorgate;
				MySettingsProperty.Settings.ignoreRT3AltName = MySettingsProperty.Settings.ignoreRTxAltName;
				MySettingsProperty.Settings.STimportAllMagRT3 = MySettingsProperty.Settings.STimportAllMag;
				MySettingsProperty.Settings.STImportFixedMagRT3 = MySettingsProperty.Settings.STImportFixedMag;
				MySettingsProperty.Settings.STimportMobileMagRT3 = MySettingsProperty.Settings.STimportMobileMag;
				MySettingsProperty.Settings.STImportRFRMagRT3 = MySettingsProperty.Settings.STImportRFRMag;
				MySettingsProperty.Settings.STImportF120_130GMagRT3 = MySettingsProperty.Settings.STImportF120_130GMag;
				MySettingsProperty.Settings.STImportF100_119MagRT3 = MySettingsProperty.Settings.STImportF100_119Mag;
				MySettingsProperty.Settings.STImportF80_99MagRT3 = MySettingsProperty.Settings.STImportF80_99Mag;
				MySettingsProperty.Settings.STImportF60_79MagRT3 = MySettingsProperty.Settings.STImportF60_79Mag;
				MySettingsProperty.Settings.STImportF0_59MagRT3 = MySettingsProperty.Settings.STImportF0_59Mag;
				MySettingsProperty.Settings.STImportM120_130MagRT3 = MySettingsProperty.Settings.STImportM120_130Mag;
				MySettingsProperty.Settings.STImportM100_119MagRT3 = MySettingsProperty.Settings.STImportM100_119Mag;
				MySettingsProperty.Settings.STImportM80_99MagRT3 = MySettingsProperty.Settings.STImportM80_99Mag;
				MySettingsProperty.Settings.STImportM60_79MagRT3 = MySettingsProperty.Settings.STImportM60_79Mag;
				MySettingsProperty.Settings.STImportM0_59MagRT3 = MySettingsProperty.Settings.STImportM0_59Mag;
				MySettingsProperty.Settings.importDefaultMagRT3 = MySettingsProperty.Settings.importDefaultMag;
			}
			else
			{
				MySettingsProperty.Settings.STimportAllTypeRT4 = MySettingsProperty.Settings.STimportAllType;
				MySettingsProperty.Settings.STimportFixedTypeRT4 = MySettingsProperty.Settings.STimportFixedType;
				MySettingsProperty.Settings.STimportMobileTypeRT4 = MySettingsProperty.Settings.STimportMobileType;
				MySettingsProperty.Settings.STImportRFRTypeRT4 = MySettingsProperty.Settings.STImportRFRType;
				MySettingsProperty.Settings.STImportF120_130GTypeRT4 = MySettingsProperty.Settings.STImportF120_130GType;
				MySettingsProperty.Settings.STImportF100_119TypeRT4 = MySettingsProperty.Settings.STImportF100_119Type;
				MySettingsProperty.Settings.STImportF80_99TypeRT4 = MySettingsProperty.Settings.STImportF80_99Type;
				MySettingsProperty.Settings.STImportF60_79TypeRT4 = MySettingsProperty.Settings.STImportF60_79Type;
				MySettingsProperty.Settings.STImportF0_59TypeRT4 = MySettingsProperty.Settings.STImportF0_59Type;
				MySettingsProperty.Settings.STImportM120_130TypeRT4 = MySettingsProperty.Settings.STImportM120_130Type;
				MySettingsProperty.Settings.STImportM100_119TypeRT4 = MySettingsProperty.Settings.STImportM100_119Type;
				MySettingsProperty.Settings.STImportM80_99TypeRT4 = MySettingsProperty.Settings.STImportM80_99Type;
				MySettingsProperty.Settings.STImportM60_79TypeRT4 = MySettingsProperty.Settings.STImportM60_79Type;
				MySettingsProperty.Settings.STImportM0_59TypeRT4 = MySettingsProperty.Settings.STImportM0_59Type;
				MySettingsProperty.Settings.ImportDefaultTypeRT4 = MySettingsProperty.Settings.importDefaultType;
				MySettingsProperty.Settings.changeRT4BorderCrossing = MySettingsProperty.Settings.changeRTxBorderCrossing;
				MySettingsProperty.Settings.changeRT4CivicCenter = MySettingsProperty.Settings.changeRTxCivicCenter;
				MySettingsProperty.Settings.changeRT4IndustArea = MySettingsProperty.Settings.changeRTxIndustArea;
				MySettingsProperty.Settings.changeRT4MedicServ = MySettingsProperty.Settings.changeRTxMedicServ;
				MySettingsProperty.Settings.changeRT4Motorb = MySettingsProperty.Settings.changeRTxMotorb;
				MySettingsProperty.Settings.changeRT4PerfArts = MySettingsProperty.Settings.changeRTxPerfArts;
				MySettingsProperty.Settings.ignoreRT4Borgate = MySettingsProperty.Settings.ignoreRTxBorgate;
				MySettingsProperty.Settings.ignoreRT4AltName = MySettingsProperty.Settings.ignoreRTxAltName;
				MySettingsProperty.Settings.STimportAllMagRT4 = MySettingsProperty.Settings.STimportAllMag;
				MySettingsProperty.Settings.STImportFixedMagRT4 = MySettingsProperty.Settings.STImportFixedMag;
				MySettingsProperty.Settings.STimportMobileMagRT4 = MySettingsProperty.Settings.STimportMobileMag;
				MySettingsProperty.Settings.STImportRFRMagRT4 = MySettingsProperty.Settings.STImportRFRMag;
				MySettingsProperty.Settings.STImportF120_130GMagRT4 = MySettingsProperty.Settings.STImportF120_130GMag;
				MySettingsProperty.Settings.STImportF100_119MagRT4 = MySettingsProperty.Settings.STImportF100_119Mag;
				MySettingsProperty.Settings.STImportF80_99MagRT4 = MySettingsProperty.Settings.STImportF80_99Mag;
				MySettingsProperty.Settings.STImportF60_79MagRT4 = MySettingsProperty.Settings.STImportF60_79Mag;
				MySettingsProperty.Settings.STImportF0_59MagRT4 = MySettingsProperty.Settings.STImportF0_59Mag;
				MySettingsProperty.Settings.STImportM120_130MagRT4 = MySettingsProperty.Settings.STImportM120_130Mag;
				MySettingsProperty.Settings.STImportM100_119MagRT4 = MySettingsProperty.Settings.STImportM100_119Mag;
				MySettingsProperty.Settings.STImportM80_99MagRT4 = MySettingsProperty.Settings.STImportM80_99Mag;
				MySettingsProperty.Settings.STImportM60_79MagRT4 = MySettingsProperty.Settings.STImportM60_79Mag;
				MySettingsProperty.Settings.STImportM0_59MagRT4 = MySettingsProperty.Settings.STImportM0_59Mag;
				MySettingsProperty.Settings.importDefaultMagRT4 = MySettingsProperty.Settings.importDefaultMag;
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00134DC0 File Offset: 0x00133DC0
		public void readRTxModeDepSettings()
		{
			bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map;
			if (flag)
			{
				MySettingsProperty.Settings.isGpsPasDirDisplayed = MySettingsProperty.Settings.isGpsPasDirDisplayedMap;
				MySettingsProperty.Settings.isGpsPasEndDisplayed = MySettingsProperty.Settings.isGpsPasEndDisplayedMap;
				MySettingsProperty.Settings.isGpsPasMiscDisplayed = MySettingsProperty.Settings.isGpsPasMiscDisplayedMap;
				MySettingsProperty.Settings.isGpsPasNumDisplayed = MySettingsProperty.Settings.isGpsPasNumDisplayedMap;
				MySettingsProperty.Settings.isGpsPasRFRPostDisplayed = MySettingsProperty.Settings.isGpsPasRFRPostDisplayedMap;
				MySettingsProperty.Settings.isGpsPasSep1Displayed = MySettingsProperty.Settings.isGpsPasSep1DisplayedMap;
				MySettingsProperty.Settings.isGpsPasSep2Displayed = MySettingsProperty.Settings.isGpsPasSep2DisplayedMap;
				MySettingsProperty.Settings.isGpsPasSpeedDisplayed = MySettingsProperty.Settings.isGpsPasSpeedDisplayedMap;
				MySettingsProperty.Settings.isGpsPasSpeedUnitDisplayed = MySettingsProperty.Settings.isGpsPasSpeedUnitDisplayedMap;
				MySettingsProperty.Settings.isGpsPasStartDisplayed = MySettingsProperty.Settings.isGpsPasStartDisplayedMap;
				MySettingsProperty.Settings.isGpsPasTypeDisplayed = MySettingsProperty.Settings.isGpsPasTypeDisplayedMap;
				MySettingsProperty.Settings.strGpsPasF = MySettingsProperty.Settings.strGpsPasFMap;
				MySettingsProperty.Settings.strGpsPasR = MySettingsProperty.Settings.strGpsPasRMap;
				MySettingsProperty.Settings.strGpsPasNC = MySettingsProperty.Settings.strGpsPasNCMap;
				MySettingsProperty.Settings.strGpsPasPAN = MySettingsProperty.Settings.strGpsPasPANMap;
				MySettingsProperty.Settings.strGpsPasPL = MySettingsProperty.Settings.strGpsPasPLMap;
				MySettingsProperty.Settings.strGpsPasRD = MySettingsProperty.Settings.strGpsPasRDMap;
				MySettingsProperty.Settings.strGpsPasRF = MySettingsProperty.Settings.strGpsPasRFMap;
				MySettingsProperty.Settings.strGpsPasRFR = MySettingsProperty.Settings.strGpsPasRFRMap;
				MySettingsProperty.Settings.strGpsPasRM = MySettingsProperty.Settings.strGpsPasRMMap;
				MySettingsProperty.Settings.strGpsPasKMH = MySettingsProperty.Settings.strGpsPasKMHMap;
				MySettingsProperty.Settings.strGpsPasSep1 = MySettingsProperty.Settings.strGpsPasSep1Map;
				MySettingsProperty.Settings.strGpsPasSep1 = MySettingsProperty.Settings.strGpsPasSep1Map;
				MySettingsProperty.Settings.strGpsPasSep2 = MySettingsProperty.Settings.strGpsPasSep2Map;
				MySettingsProperty.Settings.strGpsPasSep2 = MySettingsProperty.Settings.strGpsPasSep2Map;
			}
			else
			{
				MySettingsProperty.Settings.isGpsPasDirDisplayed = MySettingsProperty.Settings.isGpsPasDirDisplayedAlert;
				MySettingsProperty.Settings.isGpsPasEndDisplayed = MySettingsProperty.Settings.isGpsPasEndDisplayedAlert;
				MySettingsProperty.Settings.isGpsPasMiscDisplayed = MySettingsProperty.Settings.isGpsPasMiscDisplayedAlert;
				MySettingsProperty.Settings.isGpsPasNumDisplayed = MySettingsProperty.Settings.isGpsPasNumDisplayedAlert;
				MySettingsProperty.Settings.isGpsPasRFRPostDisplayed = MySettingsProperty.Settings.isGpsPasRFRPostDisplayedAlert;
				MySettingsProperty.Settings.isGpsPasSep1Displayed = MySettingsProperty.Settings.isGpsPasSep1DisplayedAlert;
				MySettingsProperty.Settings.isGpsPasSep2Displayed = MySettingsProperty.Settings.isGpsPasSep2DisplayedAlert;
				MySettingsProperty.Settings.isGpsPasSpeedDisplayed = MySettingsProperty.Settings.isGpsPasSpeedDisplayedAlert;
				MySettingsProperty.Settings.isGpsPasSpeedUnitDisplayed = MySettingsProperty.Settings.isGpsPasSpeedUnitDisplayedAlert;
				MySettingsProperty.Settings.isGpsPasStartDisplayed = MySettingsProperty.Settings.isGpsPasStartDisplayedAlert;
				MySettingsProperty.Settings.isGpsPasTypeDisplayed = MySettingsProperty.Settings.isGpsPasTypeDisplayedAlert;
				MySettingsProperty.Settings.strGpsPasF = MySettingsProperty.Settings.strGpsPasFAlert;
				MySettingsProperty.Settings.strGpsPasR = MySettingsProperty.Settings.strGpsPasRAlert;
				MySettingsProperty.Settings.strGpsPasNC = MySettingsProperty.Settings.strGpsPasNCAlert;
				MySettingsProperty.Settings.strGpsPasPAN = MySettingsProperty.Settings.strGpsPasPANAlert;
				MySettingsProperty.Settings.strGpsPasPL = MySettingsProperty.Settings.strGpsPasPLAlert;
				MySettingsProperty.Settings.strGpsPasRD = MySettingsProperty.Settings.strGpsPasRDAlert;
				MySettingsProperty.Settings.strGpsPasRF = MySettingsProperty.Settings.strGpsPasRFAlert;
				MySettingsProperty.Settings.strGpsPasRFR = MySettingsProperty.Settings.strGpsPasRFRAlert;
				MySettingsProperty.Settings.strGpsPasRM = MySettingsProperty.Settings.strGpsPasRMAlert;
				MySettingsProperty.Settings.strGpsPasKMH = MySettingsProperty.Settings.strGpsPasKMHAlert;
				MySettingsProperty.Settings.strGpsPasSep1 = MySettingsProperty.Settings.strGpsPasSep1Alert;
				MySettingsProperty.Settings.strGpsPasSep1 = MySettingsProperty.Settings.strGpsPasSep1Alert;
				MySettingsProperty.Settings.strGpsPasSep2 = MySettingsProperty.Settings.strGpsPasSep2Alert;
				MySettingsProperty.Settings.strGpsPasSep2 = MySettingsProperty.Settings.strGpsPasSep2Alert;
			}
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00135200 File Offset: 0x00134200
		public void writeRTxModeDepSettings()
		{
			bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map;
			if (flag)
			{
				MySettingsProperty.Settings.isGpsPasDirDisplayedMap = MySettingsProperty.Settings.isGpsPasDirDisplayed;
				MySettingsProperty.Settings.isGpsPasEndDisplayedMap = MySettingsProperty.Settings.isGpsPasEndDisplayed;
				MySettingsProperty.Settings.isGpsPasMiscDisplayedMap = MySettingsProperty.Settings.isGpsPasMiscDisplayed;
				MySettingsProperty.Settings.isGpsPasNumDisplayedMap = MySettingsProperty.Settings.isGpsPasNumDisplayed;
				MySettingsProperty.Settings.isGpsPasRFRPostDisplayed = MySettingsProperty.Settings.isGpsPasRFRPostDisplayed;
				MySettingsProperty.Settings.isGpsPasSep1DisplayedMap = MySettingsProperty.Settings.isGpsPasSep1DisplayedMap;
				MySettingsProperty.Settings.isGpsPasSep2DisplayedMap = MySettingsProperty.Settings.isGpsPasSep2Displayed;
				MySettingsProperty.Settings.isGpsPasSpeedDisplayedMap = MySettingsProperty.Settings.isGpsPasSpeedDisplayed;
				MySettingsProperty.Settings.isGpsPasSpeedUnitDisplayedMap = MySettingsProperty.Settings.isGpsPasSpeedUnitDisplayed;
				MySettingsProperty.Settings.isGpsPasStartDisplayedMap = MySettingsProperty.Settings.isGpsPasStartDisplayed;
				MySettingsProperty.Settings.isGpsPasTypeDisplayedMap = MySettingsProperty.Settings.isGpsPasTypeDisplayed;
				MySettingsProperty.Settings.strGpsPasFMap = MySettingsProperty.Settings.strGpsPasF;
				MySettingsProperty.Settings.strGpsPasRMap = MySettingsProperty.Settings.strGpsPasR;
				MySettingsProperty.Settings.strGpsPasNCMap = MySettingsProperty.Settings.strGpsPasNC;
				MySettingsProperty.Settings.strGpsPasPANMap = MySettingsProperty.Settings.strGpsPasPAN;
				MySettingsProperty.Settings.strGpsPasPLMap = MySettingsProperty.Settings.strGpsPasPL;
				MySettingsProperty.Settings.strGpsPasRDMap = MySettingsProperty.Settings.strGpsPasRD;
				MySettingsProperty.Settings.strGpsPasRFMap = MySettingsProperty.Settings.strGpsPasRF;
				MySettingsProperty.Settings.strGpsPasRFRMap = MySettingsProperty.Settings.strGpsPasRFR;
				MySettingsProperty.Settings.strGpsPasRMMap = MySettingsProperty.Settings.strGpsPasRM;
				MySettingsProperty.Settings.strGpsPasKMHMap = MySettingsProperty.Settings.strGpsPasKMH;
				MySettingsProperty.Settings.strGpsPasSep1Map = MySettingsProperty.Settings.strGpsPasSep1;
				MySettingsProperty.Settings.strGpsPasSep1Map = MySettingsProperty.Settings.strGpsPasSep1;
				MySettingsProperty.Settings.strGpsPasSep2Map = MySettingsProperty.Settings.strGpsPasSep2;
				MySettingsProperty.Settings.strGpsPasSep2Map = MySettingsProperty.Settings.strGpsPasSep2;
			}
			else
			{
				MySettingsProperty.Settings.isGpsPasDirDisplayedAlert = MySettingsProperty.Settings.isGpsPasDirDisplayed;
				MySettingsProperty.Settings.isGpsPasEndDisplayedAlert = MySettingsProperty.Settings.isGpsPasEndDisplayed;
				MySettingsProperty.Settings.isGpsPasMiscDisplayedAlert = MySettingsProperty.Settings.isGpsPasMiscDisplayed;
				MySettingsProperty.Settings.isGpsPasNumDisplayedAlert = MySettingsProperty.Settings.isGpsPasNumDisplayed;
				MySettingsProperty.Settings.isGpsPasRFRPostDisplayed = MySettingsProperty.Settings.isGpsPasRFRPostDisplayed;
				MySettingsProperty.Settings.isGpsPasSep1DisplayedAlert = MySettingsProperty.Settings.isGpsPasSep1DisplayedAlert;
				MySettingsProperty.Settings.isGpsPasSep2DisplayedAlert = MySettingsProperty.Settings.isGpsPasSep2Displayed;
				MySettingsProperty.Settings.isGpsPasSpeedDisplayedAlert = MySettingsProperty.Settings.isGpsPasSpeedDisplayed;
				MySettingsProperty.Settings.isGpsPasSpeedUnitDisplayedAlert = MySettingsProperty.Settings.isGpsPasSpeedUnitDisplayed;
				MySettingsProperty.Settings.isGpsPasStartDisplayedAlert = MySettingsProperty.Settings.isGpsPasStartDisplayed;
				MySettingsProperty.Settings.isGpsPasTypeDisplayedAlert = MySettingsProperty.Settings.isGpsPasTypeDisplayed;
				MySettingsProperty.Settings.strGpsPasFAlert = MySettingsProperty.Settings.strGpsPasF;
				MySettingsProperty.Settings.strGpsPasRAlert = MySettingsProperty.Settings.strGpsPasR;
				MySettingsProperty.Settings.strGpsPasNCAlert = MySettingsProperty.Settings.strGpsPasNC;
				MySettingsProperty.Settings.strGpsPasPANAlert = MySettingsProperty.Settings.strGpsPasPAN;
				MySettingsProperty.Settings.strGpsPasPLAlert = MySettingsProperty.Settings.strGpsPasPL;
				MySettingsProperty.Settings.strGpsPasRDAlert = MySettingsProperty.Settings.strGpsPasRD;
				MySettingsProperty.Settings.strGpsPasRFAlert = MySettingsProperty.Settings.strGpsPasRF;
				MySettingsProperty.Settings.strGpsPasRFRAlert = MySettingsProperty.Settings.strGpsPasRFR;
				MySettingsProperty.Settings.strGpsPasRMAlert = MySettingsProperty.Settings.strGpsPasRM;
				MySettingsProperty.Settings.strGpsPasKMHAlert = MySettingsProperty.Settings.strGpsPasKMH;
				MySettingsProperty.Settings.strGpsPasSep1Alert = MySettingsProperty.Settings.strGpsPasSep1;
				MySettingsProperty.Settings.strGpsPasSep1Alert = MySettingsProperty.Settings.strGpsPasSep1;
				MySettingsProperty.Settings.strGpsPasSep2Alert = MySettingsProperty.Settings.strGpsPasSep2;
				MySettingsProperty.Settings.strGpsPasSep2Alert = MySettingsProperty.Settings.strGpsPasSep2;
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00135640 File Offset: 0x00134640
		private void initExportFiledName()
		{
			bool flag = Operators.CompareString(MySettingsProperty.Settings.exportFieldLatCsv, "", false) == 0;
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldLatCsv = Resources.strFieldLat;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldLonCsv, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldLonCsv = Resources.strFieldLon;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldNameCsv, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldNameCsv = Resources.strFieldName;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldAddressCsv, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldAddressCsv = Resources.strFieldAddress;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldCityCsv, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldCityCsv = Resources.strFieldCity;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldCountryCsv, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldCountryCsv = Resources.strFieldCountry;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldTelCsv, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldTelCsv = Resources.strFieldTel;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldCommentCsv, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldCommentCsv = Resources.strFieldComment;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldBrandCsv, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldBrandCsv = Resources.strFieldBrand;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldLatTxt, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldLatTxt = Resources.strFieldLat;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldLonTxt, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldLonTxt = Resources.strFieldLon;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldNameTxt, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldNameTxt = Resources.strFieldName;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldAddressTxt, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldAddressTxt = Resources.strFieldAddress;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldCityTxt, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldCityTxt = Resources.strFieldCity;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldCountryTxt, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldCountryTxt = Resources.strFieldCountry;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldTelTxt, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldTelTxt = Resources.strFieldTel;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldCommentTxt, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldCommentTxt = Resources.strFieldComment;
			}
			flag = (Operators.CompareString(MySettingsProperty.Settings.exportFieldBrandTxt, "", false) == 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportFieldBrandTxt = Resources.strFieldBrand;
			}
			flag = MySettingsProperty.Settings.exportAscIntSeparator.StartsWith("\r");
			if (flag)
			{
				MySettingsProperty.Settings.exportAscIntSeparator = " ";
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x001359A4 File Offset: 0x001349A4
		public void SetLastLoadedMaps(ToolStripMenuItem MapToolStripMenuItem, ToolStripSplitButton Load_ToolStripButton)
		{
			this.lastLoadedMaps = new LastLoadedMaps(MapToolStripMenuItem, Load_ToolStripButton);
			this.lastLoadedMaps.loadFromSettings();
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x001359C4 File Offset: 0x001349C4
		public void writeSettings(bool changeType)
		{
			this.lastLoadedMaps.saveInSettings();
			bool flag = !changeType;
			if (flag)
			{
				this.writeRTxTypeDepSettings();
			}
			MySettingsProperty.Settings.Save();
		}

		// Token: 0x040009E0 RID: 2528
		public LastLoadedMaps lastLoadedMaps;
	}
}
