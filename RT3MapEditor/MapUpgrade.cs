using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000062 RID: 98
	public class MapUpgrade
	{
		// Token: 0x06000C9B RID: 3227 RVA: 0x0011A2E4 File Offset: 0x001192E4
		[DebuggerNonUserCode]
		public MapUpgrade()
		{
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0011A2F0 File Offset: 0x001192F0
		private static bool upgradeMap10To11(string mapIniName, string workingDir)
		{
			MyProject.Application.Log.WriteEntry("Map version 1.0 found, trying to upgrade to 1.1...", TraceEventType.Information);
			try
			{
				string text = Path.Combine(workingDir, "orig");
				string path = Path.Combine(workingDir, "dest");
				MyProject.Computer.FileSystem.CopyFile(Path.Combine(path, "CONFIG.LOG"), Path.Combine(text, "CONFIG.LOG"), UIOption.OnlyErrorDialogs, UICancelOption.ThrowException);
				MyProject.Computer.FileSystem.CopyFile(Path.Combine(path, "DCN.CAT"), Path.Combine(text, "DCN.CAT"), UIOption.OnlyErrorDialogs, UICancelOption.ThrowException);
				GRUPPODAT.upgradeMap10To11(mapIniName);
				Inifiles.SetKey(mapIniName, "MAP DESCRIPTION", "mapDesc", MapUpgrade.getLabel(text));
				Inifiles.SetKey(mapIniName, "MAP DESCRIPTION", "mapRadarAllowed", true.ToString());
				Inifiles.SetKey(mapIniName, "MAP DESCRIPTION", "mapGuideAllowed", true.ToString());
				Inifiles.SetKey(mapIniName, "MAP VERSION", "version", "1.1");
				MyProject.Application.Log.WriteEntry("Upgrade succesful", TraceEventType.Information);
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteEntry("Upgrade failed", TraceEventType.Information);
				Interaction.MsgBox(Resources.strMapTooOld, MsgBoxStyle.Critical, null);
				return false;
			}
			return true;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0011A454 File Offset: 0x00119454
		private static bool upgradeMap11To12(string mapIniName, string workingDir)
		{
			string text = Path.Combine(workingDir, "dest");
			string key = Inifiles.GetKey(mapIniName, "MAP DESCRIPTION", "mapType");
			string key2 = Inifiles.GetKey(mapIniName, "MAP DESCRIPTION", "mapCountry");
			string key3 = Inifiles.GetKey(mapIniName, "MAP DESCRIPTION", "mapName");
			MyProject.Application.Log.WriteEntry("Map version 1.1 found, trying to upgrade to 1.2...", TraceEventType.Information);
			try
			{
				Inifiles.SetKey(mapIniName, "MAP DESCRIPTION", "hddMap", "0");
				Inifiles.SetKey(mapIniName, "MAP DESCRIPTION", "mapVers", CopyMap.getVers(Common.getMapType(key), text, key2));
				Inifiles.SetKey(mapIniName, "MAP DESCRIPTION", "mapRel", CopyMap.getRel(Common.getMapType(key), text, key2));
				Inifiles.SetKey(mapIniName, "MAP VERSION", "version", "1.2");
				CopyMap.copyRT4FilesIfNeeded(text, text, key3, Common.getMapType(key), key2, CopyMap.getVers(Common.getMapType(key), text, key2), CopyMap.getRel(Common.getMapType(key), text, key2), false);
				MyProject.Application.Log.WriteEntry("Upgrade succesful", TraceEventType.Information);
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteEntry("Upgrade failed", TraceEventType.Information);
				Interaction.MsgBox(Resources.strMapTooOld, MsgBoxStyle.Critical, null);
				return false;
			}
			return true;
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0011A5B8 File Offset: 0x001195B8
		public static ConfigDialog.configStatus upgradeMap(string workingDir)
		{
			string text = Path.Combine(workingDir, "map.ini");
			bool flag = MyProject.Computer.FileSystem.FileExists(text);
			ConfigDialog.configStatus result;
			if (flag)
			{
				string key = Inifiles.GetKey(text, "MAP DESCRIPTION", "ISOPath");
				flag = (Operators.CompareString(key, "", false) == 0);
				if (flag)
				{
					Inifiles.SetKey(text, "MAP DESCRIPTION", "ISOPath", workingDir);
				}
				string key2 = Inifiles.GetKey(text, "MAP VERSION", "version");
				flag = (Operators.CompareString(key2, "1.2", false) != 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(key2, "1.0", false) == 0;
					bool flag3;
					if (flag2)
					{
						flag3 = !MapUpgrade.upgradeMap10To11(text, workingDir);
						if (flag3)
						{
							return ConfigDialog.configStatus.TooOld;
						}
						key2 = Inifiles.GetKey(text, "MAP VERSION", "version");
					}
					flag3 = (Operators.CompareString(key2, "1.1", false) == 0);
					if (flag3)
					{
						flag2 = !MapUpgrade.upgradeMap11To12(text, workingDir);
						if (flag2)
						{
							return ConfigDialog.configStatus.mapKO;
						}
						key2 = Inifiles.GetKey(text, "MAP VERSION", "version");
					}
					flag3 = (Operators.CompareString(key2, "1.2", false) != 0);
					if (flag3)
					{
						return ConfigDialog.configStatus.mapKO;
					}
				}
				result = ConfigDialog.configStatus.OK;
			}
			else
			{
				result = ConfigDialog.configStatus.mapKO;
			}
			return result;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0011A6F4 File Offset: 0x001196F4
		private static string getLabel(string origPath)
		{
			string text = null;
			StreamReader streamReader = new StreamReader(new FileStream(Path.Combine(Path.Combine(origPath, "GRUPPO_2_DAT"), "Label.txt"), FileMode.Open, FileAccess.Read));
			string text2;
			do
			{
				text2 = streamReader.ReadLine();
				bool flag = text2 != null;
				if (flag)
				{
					text = text + text2.TrimEnd(new char[]
					{
						' '
					}) + " ";
				}
			}
			while (text2 != null && text2.Length != 0);
			return text.TrimEnd(new char[]
			{
				' '
			});
		}
	}
}
