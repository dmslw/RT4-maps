using System;
using System.Collections;
using System.Globalization;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000008 RID: 8
	public class Common
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000FC7B0 File Offset: 0x000FB7B0
		public Common()
		{
			this.gpsPasField3DispModeItemList = new ArrayList();
			this.gpsPasField2DispModeItemList = new ArrayList();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000FC7D4 File Offset: 0x000FB7D4
		public static string getStrMapType(Common.RTxMapType mapType)
		{
			string result;
			switch (mapType)
			{
			case Common.RTxMapType.oldRT3:
				result = "OLDRT3";
				break;
			case Common.RTxMapType.RT3:
				result = "RT3";
				break;
			case Common.RTxMapType.RT4:
				result = "RT4";
				break;
			case Common.RTxMapType.Unknown:
				result = "Unknown";
				break;
			default:
				result = "Unknown";
				break;
			}
			return result;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000FC834 File Offset: 0x000FB834
		public static Common.RTxMapType getMapType(string strMapType)
		{
			bool flag = Operators.CompareString(strMapType, "OLDRT3", false) == 0;
			Common.RTxMapType result;
			if (flag)
			{
				result = Common.RTxMapType.oldRT3;
			}
			else
			{
				flag = (Operators.CompareString(strMapType, "RT3", false) == 0);
				if (flag)
				{
					result = Common.RTxMapType.RT3;
				}
				else
				{
					flag = (Operators.CompareString(strMapType, "RT4", false) == 0);
					if (flag)
					{
						result = Common.RTxMapType.RT4;
					}
					else
					{
						result = Common.RTxMapType.Unknown;
					}
				}
			}
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000FC89C File Offset: 0x000FB89C
		public static bool isCountrySetValid(string mapCountry)
		{
			if (Operators.CompareString(mapCountry, "001", false) != 0 && Operators.CompareString(mapCountry, "002", false) != 0)
			{
				if (Operators.CompareString(mapCountry, "003", false) != 0)
				{
					if (Operators.CompareString(mapCountry, "004", false) != 0)
					{
						if (Operators.CompareString(mapCountry, "005", false) != 0)
						{
							if (Operators.CompareString(mapCountry, "006", false) != 0)
							{
								if (Operators.CompareString(mapCountry, "012", false) != 0)
								{
									if (Operators.CompareString(mapCountry, "013", false) != 0)
									{
										if (Operators.CompareString(mapCountry, "020", false) != 0)
										{
											if (Operators.CompareString(mapCountry, "021", false) != 0)
											{
												if (Operators.CompareString(mapCountry, "022", false) != 0)
												{
													return false;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000FC97C File Offset: 0x000FB97C
		public static string getCIDStr(string CID)
		{
			bool flag = Operators.CompareString(CID, "001", false) == 0;
			string result;
			if (flag)
			{
				result = Resources.strRT4CID001;
			}
			else
			{
				flag = (Operators.CompareString(CID, "002", false) == 0);
				if (flag)
				{
					result = Resources.strRT4CID002;
				}
				else
				{
					flag = (Operators.CompareString(CID, "003", false) == 0);
					if (flag)
					{
						result = Resources.strRT4CID003;
					}
					else
					{
						flag = (Operators.CompareString(CID, "004", false) == 0);
						if (flag)
						{
							result = Resources.strRT4CID004;
						}
						else
						{
							flag = (Operators.CompareString(CID, "005", false) == 0);
							if (flag)
							{
								result = Resources.strRT4CID005;
							}
							else
							{
								flag = (Operators.CompareString(CID, "006", false) == 0);
								if (flag)
								{
									result = Resources.strRT4CID006;
								}
								else
								{
									flag = (Operators.CompareString(CID, "012", false) == 0);
									if (flag)
									{
										result = Resources.strRT4CID012;
									}
									else
									{
										flag = (Operators.CompareString(CID, "013", false) == 0);
										if (flag)
										{
											result = Resources.strRT4CID013;
										}
										else
										{
											flag = (Operators.CompareString(CID, "020", false) == 0);
											if (flag)
											{
												result = Resources.strRT4CID020;
											}
											else
											{
												flag = (Operators.CompareString(CID, "021", false) == 0);
												if (flag)
												{
													result = Resources.strRT4CID021;
												}
												else
												{
													flag = (Operators.CompareString(CID, "022", false) == 0);
													if (flag)
													{
														result = Resources.strRT4CID022;
													}
													else
													{
														result = "unknwon";
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000FCB0C File Offset: 0x000FBB0C
		public static Common.RTxTypes RTxType
		{
			get
			{
				return Common._RTxType;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000FCB24 File Offset: 0x000FBB24
		public static string strRTxType
		{
			get
			{
				return MySettingsProperty.Settings.RTxType;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000FCB40 File Offset: 0x000FBB40
		public static void setRTxType(string type)
		{
			bool flag = Operators.CompareString(type, "RT3", false) == 0;
			if (flag)
			{
				Common._RTxType = Common.RTxTypes.typeRT3;
			}
			else
			{
				flag = (Operators.CompareString(type, "RT4", false) == 0);
				if (flag)
				{
					Common._RTxType = Common.RTxTypes.typeRT4;
				}
				else
				{
					flag = (Operators.CompareString(type, "RT5HR", false) == 0);
					if (flag)
					{
						Common._RTxType = Common.RTxTypes.typeRT5HR;
					}
					else
					{
						flag = (Operators.CompareString(type, "RT5LR", false) == 0);
						if (flag)
						{
							Common._RTxType = Common.RTxTypes.typeRT5LR;
						}
						else
						{
							MySettingsProperty.Settings.RTxType = "RT3";
							Common._RTxType = Common.RTxTypes.typeRT3;
						}
					}
				}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000FCBDC File Offset: 0x000FBBDC
		public static void setRTxType(Common.RTxTypes type)
		{
			Common._RTxType = type;
			switch (type)
			{
			case Common.RTxTypes.typeRT3:
				MySettingsProperty.Settings.RTxType = "RT3";
				break;
			case Common.RTxTypes.typeRT4:
				MySettingsProperty.Settings.RTxType = "RT4";
				break;
			case Common.RTxTypes.typeRT5HR:
				MySettingsProperty.Settings.RTxType = "RT5HR";
				break;
			case Common.RTxTypes.typeRT5LR:
				MySettingsProperty.Settings.RTxType = "RT5LR";
				break;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000FCC58 File Offset: 0x000FBC58
		public static Common.RTxVersions RTxVersion
		{
			get
			{
				return Common._RTxVersion;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000FCC70 File Offset: 0x000FBC70
		public static void setRTxVersion(string RTxVersion)
		{
			bool flag = Operators.CompareString(RTxVersion, "ver56x", false) == 0;
			if (flag)
			{
				Common._RTxVersion = Common.RTxVersions.version56x;
			}
			else
			{
				flag = (Operators.CompareString(RTxVersion, "ver702", false) == 0);
				if (flag)
				{
					Common._RTxVersion = Common.RTxVersions.version702;
				}
				else
				{
					flag = (Operators.CompareString(RTxVersion, "ver710", false) == 0);
					if (flag)
					{
						Common._RTxVersion = Common.RTxVersions.version710;
					}
					else
					{
						flag = (Operators.CompareString(RTxVersion, "ver711", false) == 0);
						if (flag)
						{
							Common._RTxVersion = Common.RTxVersions.version711;
						}
						else
						{
							flag = (Operators.CompareString(RTxVersion, "ver80", false) == 0);
							if (flag)
							{
								Common._RTxVersion = Common.RTxVersions.version80;
							}
							else
							{
								flag = (Operators.CompareString(RTxVersion, "ver81", false) == 0);
								if (flag)
								{
									Common._RTxVersion = Common.RTxVersions.version81;
								}
								else
								{
									MySettingsProperty.Settings.RTxVersion = "ver56x";
									Common._RTxVersion = Common.RTxVersions.version56x;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000FCD48 File Offset: 0x000FBD48
		public static void setRTxVersion(Common.RTxVersions version)
		{
			Common._RTxVersion = version;
			switch (version)
			{
			case Common.RTxVersions.version56x:
				MySettingsProperty.Settings.RTxVersion = "ver56x";
				break;
			case Common.RTxVersions.version702:
				MySettingsProperty.Settings.RTxVersion = "ver710";
				break;
			case Common.RTxVersions.version710:
				MySettingsProperty.Settings.RTxVersion = "ver702";
				break;
			case Common.RTxVersions.version711:
				MySettingsProperty.Settings.RTxVersion = "ver711";
				break;
			case Common.RTxVersions.version80:
				MySettingsProperty.Settings.RTxVersion = "ver80";
				break;
			case Common.RTxVersions.version81:
				MySettingsProperty.Settings.RTxVersion = "ver81";
				break;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000FCDF4 File Offset: 0x000FBDF4
		public static Common.RTxMapEditorMapModes RTxMapEditorMapMode
		{
			get
			{
				return Common._RTxMapEditorMapMode;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000FCE0C File Offset: 0x000FBE0C
		public static void setRTxMapEditorMapMode(string mode)
		{
			bool flag = Operators.CompareString(mode, "map", false) == 0;
			if (flag)
			{
				Common._RTxMapEditorMapMode = Common.RTxMapEditorMapModes.map;
			}
			else
			{
				flag = (Operators.CompareString(mode, "alert", false) == 0);
				if (flag)
				{
					Common._RTxMapEditorMapMode = Common.RTxMapEditorMapModes.alert;
				}
				else
				{
					MySettingsProperty.Settings.RTxModeMap = "map";
					Common._RTxMapEditorMapMode = Common.RTxMapEditorMapModes.map;
				}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000FCE70 File Offset: 0x000FBE70
		public static void setRTxMapEditorMapMode(Common.RTxMapEditorMapModes mode)
		{
			Common._RTxMapEditorMapMode = mode;
			switch (mode)
			{
			case Common.RTxMapEditorMapModes.map:
				MySettingsProperty.Settings.RTxModeMap = "map";
				break;
			case Common.RTxMapEditorMapModes.alert:
				MySettingsProperty.Settings.RTxModeMap = "alert";
				break;
			}
			MyProject.Forms.FormMain.wizardState.UpdateMainFormVisibility();
		}

		// Token: 0x0400001B RID: 27
		public const string STR_RTxTypeRT3 = "RT3";

		// Token: 0x0400001C RID: 28
		public const string STR_RTxTypeRT4 = "RT4";

		// Token: 0x0400001D RID: 29
		public const string STR_RTxTypeRT5LR = "RT5LR";

		// Token: 0x0400001E RID: 30
		public const string STR_RTxTypeRT5HR = "RT5HR";

		// Token: 0x0400001F RID: 31
		private static Common.RTxTypes _RTxType = Common.RTxTypes.typeRT3;

		// Token: 0x04000020 RID: 32
		private static Common.RTxVersions _RTxVersion = Common.RTxVersions.version56x;

		// Token: 0x04000021 RID: 33
		public const string STR_RTxVersion56x = "ver56x";

		// Token: 0x04000022 RID: 34
		public const string STR_RTxVersion702 = "ver702";

		// Token: 0x04000023 RID: 35
		public const string STR_RTxVersion710 = "ver710";

		// Token: 0x04000024 RID: 36
		public const string STR_RTxVersion711 = "ver711";

		// Token: 0x04000025 RID: 37
		public const string STR_RTxVersion80 = "ver80";

		// Token: 0x04000026 RID: 38
		public const string STR_RTxVersion81 = "ver81";

		// Token: 0x04000027 RID: 39
		public const string STR_RTxMapEditorModeMap = "map";

		// Token: 0x04000028 RID: 40
		public const string STR_RTxMapEditorModeAlert = "alert";

		// Token: 0x04000029 RID: 41
		private static Common.RTxMapEditorMapModes _RTxMapEditorMapMode = Common.RTxMapEditorMapModes.map;

		// Token: 0x0400002A RID: 42
		public const string STR_UNAMED = "{..**..}";

		// Token: 0x0400002B RID: 43
		public const string STR_MAP_ORIG = "orig";

		// Token: 0x0400002C RID: 44
		public const string STR_MAP_DEST = "dest";

		// Token: 0x0400002D RID: 45
		public const string STR_MAP_UPG = "destUPG";

		// Token: 0x0400002E RID: 46
		public const string STR_MAP_TEMP = "temp";

		// Token: 0x0400002F RID: 47
		public const string STR_REDIST_ARC = "redist\\upg.dat";

		// Token: 0x04000030 RID: 48
		public const string STR_Fr = "fr";

		// Token: 0x04000031 RID: 49
		public const string STR_It = "it";

		// Token: 0x04000032 RID: 50
		public const string STR_De = "de";

		// Token: 0x04000033 RID: 51
		public const string STR_En = "en";

		// Token: 0x04000034 RID: 52
		public const string STR_Pt = "pt";

		// Token: 0x04000035 RID: 53
		public const string STR_ASC_EXT = ".asc";

		// Token: 0x04000036 RID: 54
		public const string STR_CSV_EXT = ".csv";

		// Token: 0x04000037 RID: 55
		public const string STR_KML_EXT = ".kml";

		// Token: 0x04000038 RID: 56
		public const string STR_KMZ_EXT = ".kmz";

		// Token: 0x04000039 RID: 57
		public const string STR_RT3_EXT = ".rt3";

		// Token: 0x0400003A RID: 58
		public const string STR_RTxME_EXT = ".rtxme";

		// Token: 0x0400003B RID: 59
		public const string STR_CULT_EN_US = "en-US";

		// Token: 0x0400003C RID: 60
		public const string STR_CULT_FR_FR = "fr-FR";

		// Token: 0x0400003D RID: 61
		public static CultureInfo cultENUS = new CultureInfo("en-US");

		// Token: 0x0400003E RID: 62
		public static CultureInfo cultFRFR = new CultureInfo("fr-FR");

		// Token: 0x0400003F RID: 63
		public static Encoding RT3Encoding = Encoding.GetEncoding("iso-8859-1");

		// Token: 0x04000040 RID: 64
		public const ushort MSK_TYPE = 32767;

		// Token: 0x04000041 RID: 65
		public const ushort MSK_TYPE_FLAG = 32768;

		// Token: 0x04000042 RID: 66
		public ArrayList gpsPasField3DispModeItemList;

		// Token: 0x04000043 RID: 67
		public ArrayList gpsPasField2DispModeItemList;

		// Token: 0x04000044 RID: 68
		public const byte MAX_COUNTRY_CODE = 52;

		// Token: 0x02000009 RID: 9
		public enum RTxMapType
		{
			// Token: 0x04000046 RID: 70
			oldRT3,
			// Token: 0x04000047 RID: 71
			RT3,
			// Token: 0x04000048 RID: 72
			RT4,
			// Token: 0x04000049 RID: 73
			Unknown
		}

		// Token: 0x0200000A RID: 10
		public enum RTxTypes
		{
			// Token: 0x0400004B RID: 75
			typeRT3,
			// Token: 0x0400004C RID: 76
			typeRT4,
			// Token: 0x0400004D RID: 77
			typeRT5HR,
			// Token: 0x0400004E RID: 78
			typeRT5LR
		}

		// Token: 0x0200000B RID: 11
		public enum RTxVersions
		{
			// Token: 0x04000050 RID: 80
			version56x,
			// Token: 0x04000051 RID: 81
			version702,
			// Token: 0x04000052 RID: 82
			version710,
			// Token: 0x04000053 RID: 83
			version711,
			// Token: 0x04000054 RID: 84
			version80,
			// Token: 0x04000055 RID: 85
			version81
		}

		// Token: 0x0200000C RID: 12
		public enum RTxMapEditorMapModes
		{
			// Token: 0x04000057 RID: 87
			map,
			// Token: 0x04000058 RID: 88
			alert
		}

		// Token: 0x0200000D RID: 13
		public enum scriptTypes
		{
			// Token: 0x0400005A RID: 90
			copyMap,
			// Token: 0x0400005B RID: 91
			copyConfig,
			// Token: 0x0400005C RID: 92
			copyBootScreen,
			// Token: 0x0400005D RID: 93
			patchDBDWNLPCC
		}

		// Token: 0x0200000E RID: 14
		public enum errorRange
		{
			// Token: 0x0400005F RID: 95
			rangePOIDatas = 100,
			// Token: 0x04000060 RID: 96
			rangePOILists = 200
		}
	}
}
