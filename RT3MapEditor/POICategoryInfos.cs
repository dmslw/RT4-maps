using System;
using System.Collections.Generic;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x020000AE RID: 174
	public class POICategoryInfos
	{
		// Token: 0x06000DCF RID: 3535 RVA: 0x001288AC File Offset: 0x001278AC
		public POICategoryInfos(POITypeInfo POITypeInfo)
		{
			this.RT3CatInfoDict = new POICategoryInfos.RT3CatInfos[10];
			this.FilesToRead = null;
			this.FilesToWrite = null;
			this.AllPOIListDict = null;
			string file = Path.Combine(MySettingsProperty.Settings.WorkingDir, "map.ini");
			bool flag = MyProject.Computer.FileSystem.FileExists(file);
			POICategoryInfos.RT3CatInfos rt3CatInfos = null;
			string key = Inifiles.GetKey(file, "MAP DESCRIPTION", "mapCountry");
			Common.RTxMapType mapType = Common.getMapType(Inifiles.GetKey(file, "MAP DESCRIPTION", "mapType"));
			bool flag2 = mapType == Common.RTxMapType.RT3;
			string path2;
			string text;
			string text3;
			string path4;
			string text4;
			string item;
			if (flag2)
			{
				string path = Path.Combine(MySettingsProperty.Settings.WorkingDir, "orig");
				path2 = Path.Combine(MySettingsProperty.Settings.WorkingDir, "orig");
				text = Path.Combine(path, "GRUPPO_2_DAT");
				string text2 = Path.Combine(path, "GRUPPO_2.DAT");
				text3 = Path.Combine(path, "GRUPPO_2_DAT");
				string path3 = Path.Combine(MySettingsProperty.Settings.WorkingDir, "dest");
				path4 = Path.Combine(MySettingsProperty.Settings.WorkingDir, "dest");
				text4 = Path.Combine(path3, "GRUPPO_2_DAT");
				item = Path.Combine(path3, "GRUPPO_2.DAT");
				string text5 = Path.Combine(path3, "GRUPPO_2_DAT");
			}
			else
			{
				string path = Path.Combine(MySettingsProperty.Settings.WorkingDir, "orig");
				path2 = Path.Combine(Path.Combine(MySettingsProperty.Settings.WorkingDir, "orig"), "MAPPE\\" + key);
				text = Path.Combine(path, "GRUPPO_4_CID_DAT");
				string text2 = Path.Combine(path, "GRUPPO_4_CID.DAT");
				text3 = Path.Combine(path, "GRUPPO_4_ROOT_DAT");
				string path3 = Path.Combine(MySettingsProperty.Settings.WorkingDir, "dest");
				path4 = Path.Combine(Path.Combine(MySettingsProperty.Settings.WorkingDir, "dest"), "MAPPE\\" + key);
				text4 = Path.Combine(path3, "GRUPPO_4_CID_DAT");
				item = Path.Combine(path3, "GRUPPO_4_CID.DAT");
				string text5 = Path.Combine(path3, "GRUPPO_4_ROOT_DAT");
			}
			this.FilesToRead = new List<string>();
			this.FilesToRead.Add(Path.Combine(path2, key + "POI.DAT"));
			this.FilesToRead.Add(Path.Combine(path2, key + "_NOMSERV.DAT"));
			this.FilesToRead.Add(Path.Combine(path2, key + "DSP.POI"));
			this.FilesToRead.Add(Path.Combine(path2, key + "DPA.LZW"));
			this.FilesToRead.Add(Path.Combine(path2, key + "_EX.DPS"));
			flag2 = (mapType == Common.RTxMapType.RT3);
			if (flag2)
			{
				this.FilesToRead.Add(Path.Combine(path2, key + "CAT.POI"));
			}
			else
			{
				this.FilesToRead.Add(Path.Combine(text, "CAT.POI"));
			}
			this.FilesToRead.Add(Path.Combine(path2, "GUIDA_CHAMPERARD.POI"));
			this.FilesToRead.Add(Path.Combine(path2, "SCITTANAME.DAT"));
			this.FilesToRead.Add(Path.Combine(path2, "DCN.CAT"));
			this.FilesToRead.Add(text);
			this.FilesToRead.Add(text3);
			this.FilesToRead.Add(Path.Combine(text3, "PrefInt"));
			flag2 = (mapType == Common.RTxMapType.RT3);
			if (flag2)
			{
				this.FilesToRead.Add(Path.Combine(text, key + "_EX.DMR"));
				this.FilesToRead.Add(Path.Combine(text, key + "COM.LET"));
				this.FilesToRead.Add(Path.Combine(text, key + ".Geo"));
			}
			else
			{
				this.FilesToRead.Add(Path.Combine(text, "GeoCart.Geo"));
				this.FilesToRead.Add(Path.Combine(text, "CAT.POI"));
				this.FilesToRead.Add(Path.Combine(text, "EX.DMR"));
				this.FilesToRead.Add(Path.Combine(text, "COM.LET"));
			}
			this.FilesToWrite = new List<string>();
			this.FilesToWrite.Add(Path.Combine(path4, key + "POI.DAT"));
			this.FilesToWrite.Add(Path.Combine(path4, key + "_NOMSERV.DAT"));
			this.FilesToWrite.Add(Path.Combine(path4, key + "DSP.POI"));
			this.FilesToWrite.Add(Path.Combine(path4, key + "DPA.LZW"));
			this.FilesToWrite.Add(Path.Combine(path4, "GUIDA_CHAMPERARD.POI"));
			this.FilesToWrite.Add(text4);
			this.FilesToWrite.Add(item);
			flag2 = (mapType == Common.RTxMapType.RT3);
			if (flag2)
			{
				this.FilesToWrite.Add(Path.Combine(text4, key + "_EX.DMR"));
			}
			else
			{
				this.FilesToWrite.Add(Path.Combine(text4, "EX.DMR"));
			}
			rt3CatInfos = new POICategoryInfos.RT3CatInfos();
			POICategoryInfos.RT3CatInfos rt3CatInfos2 = rt3CatInfos;
			rt3CatInfos2.DSCFile2ReadName = Path.Combine(path2, key + "SEM.DSC");
			rt3CatInfos2.DSCFile2WriteName = Path.Combine(path4, key + "SEM.DSC");
			rt3CatInfos2.DSTFile2ReadName = Path.Combine(path2, key + "SEM.DST");
			rt3CatInfos2.DSTFile2WriteName = Path.Combine(path4, key + "SEM.DST");
			rt3CatInfos2.POIListDict = new Dictionary<ushort, POILists>();
			try
			{
				foreach (ushort num in POITypeInfo.allDefinedTypes)
				{
					flag2 = (POITypeInfo.getCategoryOfType(num) == POICategoryInfos.categories.CAT_MIN);
					if (flag2)
					{
						rt3CatInfos2.POIListDict.Add(num, new POILists(true, false));
					}
				}
			}
			finally
			{
				List<ushort>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.RT3CatInfoDict[1] = rt3CatInfos;
			rt3CatInfos = new POICategoryInfos.RT3CatInfos();
			POICategoryInfos.RT3CatInfos rt3CatInfos3 = rt3CatInfos;
			rt3CatInfos3.DSCFile2ReadName = Path.Combine(path2, key + "SAF.DSC");
			rt3CatInfos3.DSCFile2WriteName = Path.Combine(path4, key + "SAF.DSC");
			rt3CatInfos3.DSTFile2ReadName = Path.Combine(path2, key + "SAF.DST");
			rt3CatInfos3.DSTFile2WriteName = Path.Combine(path4, key + "SAF.DST");
			rt3CatInfos3.POIListDict = new Dictionary<ushort, POILists>();
			try
			{
				foreach (ushort num2 in POITypeInfo.allDefinedTypes)
				{
					flag2 = (POITypeInfo.getCategoryOfType(num2) == POICategoryInfos.categories.CAT_SAF);
					if (flag2)
					{
						rt3CatInfos3.POIListDict.Add(num2, new POILists(true, false));
					}
				}
			}
			finally
			{
				List<ushort>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			this.RT3CatInfoDict[2] = rt3CatInfos;
			rt3CatInfos = new POICategoryInfos.RT3CatInfos();
			POICategoryInfos.RT3CatInfos rt3CatInfos4 = rt3CatInfos;
			rt3CatInfos4.DSCFile2ReadName = Path.Combine(path2, key + "SHR.DSC");
			rt3CatInfos4.DSCFile2WriteName = Path.Combine(path4, key + "SHR.DSC");
			rt3CatInfos4.DSTFile2ReadName = Path.Combine(path2, key + "SHR.DST");
			rt3CatInfos4.DSTFile2WriteName = Path.Combine(path4, key + "SHR.DST");
			rt3CatInfos4.POIListDict = new Dictionary<ushort, POILists>();
			try
			{
				foreach (ushort num3 in POITypeInfo.allDefinedTypes)
				{
					flag2 = (POITypeInfo.getCategoryOfType(num3) == POICategoryInfos.categories.CAT_SHR);
					if (flag2)
					{
						rt3CatInfos4.POIListDict.Add(num3, new POILists(true, false));
					}
				}
			}
			finally
			{
				List<ushort>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			this.RT3CatInfoDict[3] = rt3CatInfos;
			rt3CatInfos = new POICategoryInfos.RT3CatInfos();
			POICategoryInfos.RT3CatInfos rt3CatInfos5 = rt3CatInfos;
			rt3CatInfos5.DSCFile2ReadName = Path.Combine(path2, key + "STU.DSC");
			rt3CatInfos5.DSCFile2WriteName = Path.Combine(path4, key + "STU.DSC");
			rt3CatInfos5.DSTFile2ReadName = Path.Combine(path2, key + "STU.DST");
			rt3CatInfos5.DSTFile2WriteName = Path.Combine(path4, key + "STU.DST");
			rt3CatInfos5.POIListDict = new Dictionary<ushort, POILists>();
			try
			{
				foreach (ushort num4 in POITypeInfo.allDefinedTypes)
				{
					flag2 = (POITypeInfo.getCategoryOfType(num4) == POICategoryInfos.categories.CAT_STU);
					if (flag2)
					{
						rt3CatInfos5.POIListDict.Add(num4, new POILists(true, false));
					}
				}
			}
			finally
			{
				List<ushort>.Enumerator enumerator4;
				((IDisposable)enumerator4).Dispose();
			}
			this.RT3CatInfoDict[4] = rt3CatInfos;
			rt3CatInfos = new POICategoryInfos.RT3CatInfos();
			POICategoryInfos.RT3CatInfos rt3CatInfos6 = rt3CatInfos;
			rt3CatInfos6.DSCFile2ReadName = Path.Combine(path2, key + "SSH.DSC");
			rt3CatInfos6.DSCFile2WriteName = Path.Combine(path4, key + "SSH.DSC");
			rt3CatInfos6.DSTFile2ReadName = Path.Combine(path2, key + "SSH.DST");
			rt3CatInfos6.DSTFile2WriteName = Path.Combine(path4, key + "SSH.DST");
			rt3CatInfos6.POIListDict = new Dictionary<ushort, POILists>();
			try
			{
				foreach (ushort num5 in POITypeInfo.allDefinedTypes)
				{
					flag2 = (POITypeInfo.getCategoryOfType(num5) == POICategoryInfos.categories.CAT_SSH);
					if (flag2)
					{
						rt3CatInfos6.POIListDict.Add(num5, new POILists(true, false));
					}
				}
			}
			finally
			{
				List<ushort>.Enumerator enumerator5;
				((IDisposable)enumerator5).Dispose();
			}
			this.RT3CatInfoDict[5] = rt3CatInfos;
			rt3CatInfos = new POICategoryInfos.RT3CatInfos();
			POICategoryInfos.RT3CatInfos rt3CatInfos7 = rt3CatInfos;
			rt3CatInfos7.DSCFile2ReadName = Path.Combine(path2, key + "SSP.DSC");
			rt3CatInfos7.DSCFile2WriteName = Path.Combine(path4, key + "SSP.DSC");
			rt3CatInfos7.DSTFile2ReadName = Path.Combine(path2, key + "SSP.DST");
			rt3CatInfos7.DSTFile2WriteName = Path.Combine(path4, key + "SSP.DST");
			rt3CatInfos7.POIListDict = new Dictionary<ushort, POILists>();
			try
			{
				foreach (ushort num6 in POITypeInfo.allDefinedTypes)
				{
					flag2 = (POITypeInfo.getCategoryOfType(num6) == POICategoryInfos.categories.CAT_SSP);
					if (flag2)
					{
						rt3CatInfos7.POIListDict.Add(num6, new POILists(true, false));
					}
				}
			}
			finally
			{
				List<ushort>.Enumerator enumerator6;
				((IDisposable)enumerator6).Dispose();
			}
			this.RT3CatInfoDict[6] = rt3CatInfos;
			rt3CatInfos = new POICategoryInfos.RT3CatInfos();
			POICategoryInfos.RT3CatInfos rt3CatInfos8 = rt3CatInfos;
			rt3CatInfos8.DSCFile2ReadName = Path.Combine(path2, key + "STR.DSC");
			rt3CatInfos8.DSCFile2WriteName = Path.Combine(path4, key + "STR.DSC");
			rt3CatInfos8.DSTFile2ReadName = Path.Combine(path2, key + "STR.DST");
			rt3CatInfos8.DSTFile2WriteName = Path.Combine(path4, key + "STR.DST");
			rt3CatInfos8.POIListDict = new Dictionary<ushort, POILists>();
			try
			{
				foreach (ushort num7 in POITypeInfo.allDefinedTypes)
				{
					flag2 = (POITypeInfo.getCategoryOfType(num7) == POICategoryInfos.categories.CAT_STR);
					if (flag2)
					{
						rt3CatInfos8.POIListDict.Add(num7, new POILists(true, false));
					}
				}
			}
			finally
			{
				List<ushort>.Enumerator enumerator7;
				((IDisposable)enumerator7).Dispose();
			}
			this.RT3CatInfoDict[7] = rt3CatInfos;
			rt3CatInfos = new POICategoryInfos.RT3CatInfos();
			POICategoryInfos.RT3CatInfos rt3CatInfos9 = rt3CatInfos;
			rt3CatInfos9.DSCFile2ReadName = Path.Combine(path2, key + "SAU.DSC");
			rt3CatInfos9.DSCFile2WriteName = Path.Combine(path4, key + "SAU.DSC");
			rt3CatInfos9.DSTFile2ReadName = Path.Combine(path2, key + "SAU.DST");
			rt3CatInfos9.DSTFile2WriteName = Path.Combine(path4, key + "SAU.DST");
			rt3CatInfos9.POIListDict = new Dictionary<ushort, POILists>();
			try
			{
				foreach (ushort num8 in POITypeInfo.allDefinedTypes)
				{
					flag2 = (POITypeInfo.getCategoryOfType(num8) == POICategoryInfos.categories.CAT_SAU);
					if (flag2)
					{
						rt3CatInfos9.POIListDict.Add(num8, new POILists(true, false));
					}
				}
			}
			finally
			{
				List<ushort>.Enumerator enumerator8;
				((IDisposable)enumerator8).Dispose();
			}
			this.RT3CatInfoDict[8] = rt3CatInfos;
			rt3CatInfos = new POICategoryInfos.RT3CatInfos();
			POICategoryInfos.RT3CatInfos rt3CatInfos10 = rt3CatInfos;
			rt3CatInfos10.DSTFile2ReadName = Path.Combine(path2, key + "SCC.DST");
			rt3CatInfos10.DSTFile2WriteName = Path.Combine(path4, key + "SCC.DST");
			rt3CatInfos10.IMPFile2WriteName = Path.Combine(path4, key + "SCC.IMP");
			rt3CatInfos10.POIListDict = new Dictionary<ushort, POILists>();
			try
			{
				foreach (ushort num9 in POITypeInfo.allDefinedTypes)
				{
					flag2 = (POITypeInfo.getCategoryOfType(num9) == POICategoryInfos.categories.CAT_SCC);
					if (flag2)
					{
						rt3CatInfos10.POIListDict.Add(num9, new POILists(true, false));
					}
				}
			}
			finally
			{
				List<ushort>.Enumerator enumerator9;
				((IDisposable)enumerator9).Dispose();
			}
			this.RT3CatInfoDict[9] = rt3CatInfos;
			this.AllPOIListDict = new Dictionary<ushort, POILists>();
			POICategoryInfos.categories categories = POICategoryInfos.categories.CAT_MIN;
			byte b;
			byte b2;
			do
			{
				try
				{
					foreach (ushort key2 in this.RT3CatInfoDict[(int)categories].POIListDict.Keys)
					{
						this.AllPOIListDict.Add(key2, this.RT3CatInfoDict[(int)categories].POIListDict[key2]);
					}
				}
				finally
				{
					Dictionary<ushort, POILists>.KeyCollection.Enumerator enumerator10;
					((IDisposable)enumerator10).Dispose();
				}
				categories += 1;
				b = (byte)categories;
				b2 = 9;
			}
			while (b <= b2);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x001296F8 File Offset: 0x001286F8
		public string getDSCRT3File2Read(POICategoryInfos.categories category)
		{
			return this.RT3CatInfoDict[(int)category].DSCFile2ReadName;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00129718 File Offset: 0x00128718
		public string getDSCRT3File2Write(POICategoryInfos.categories category)
		{
			return this.RT3CatInfoDict[(int)category].DSCFile2WriteName;
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00129738 File Offset: 0x00128738
		public string getDSTRT3File2Read(POICategoryInfos.categories category)
		{
			return this.RT3CatInfoDict[(int)category].DSTFile2ReadName;
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00129758 File Offset: 0x00128758
		public string getDSTRT3File2Write(POICategoryInfos.categories category)
		{
			return this.RT3CatInfoDict[(int)category].DSTFile2WriteName;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00129778 File Offset: 0x00128778
		public string getIMPRT3File2Write(POICategoryInfos.categories category)
		{
			return this.RT3CatInfoDict[(int)category].IMPFile2WriteName;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00129798 File Offset: 0x00128798
		public string getMainPOIRT3File2Read(string fileEnd)
		{
			try
			{
				foreach (string text in this.FilesToRead)
				{
					bool flag = text.EndsWith(fileEnd);
					if (flag)
					{
						return text;
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return null;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00129800 File Offset: 0x00128800
		public string getMainPOIRT3File2Write(string fileEnd)
		{
			try
			{
				foreach (string text in this.FilesToWrite)
				{
					bool flag = text.EndsWith(fileEnd);
					if (flag)
					{
						return text;
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return null;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00129868 File Offset: 0x00128868
		public Dictionary<ushort, POILists> getPOIListDict(POICategoryInfos.categories category)
		{
			return this.RT3CatInfoDict[(int)category].POIListDict;
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00129888 File Offset: 0x00128888
		public Dictionary<ushort, POILists> getAllPOIListDict()
		{
			return this.AllPOIListDict;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x001298A0 File Offset: 0x001288A0
		public static string getCategoryName(POICategoryInfos.categories category)
		{
			string result;
			switch (category)
			{
			case POICategoryInfos.categories.CAT_MIN:
				result = "SEM";
				break;
			case POICategoryInfos.categories.CAT_SAF:
				result = "SAF";
				break;
			case POICategoryInfos.categories.CAT_SHR:
				result = "SHR";
				break;
			case POICategoryInfos.categories.CAT_STU:
				result = "STU";
				break;
			case POICategoryInfos.categories.CAT_SSH:
				result = "SSH";
				break;
			case POICategoryInfos.categories.CAT_SSP:
				result = "SSP";
				break;
			case POICategoryInfos.categories.CAT_STR:
				result = "STR";
				break;
			case POICategoryInfos.categories.CAT_SAU:
				result = "SAU";
				break;
			case POICategoryInfos.categories.CAT_SCC:
				result = "SCC";
				break;
			default:
				result = "Unknown";
				break;
			}
			return result;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00129950 File Offset: 0x00128950
		public void initNbIdxPOIDSTPerCategory()
		{
			POICategoryInfos.categories categories = POICategoryInfos.categories.CAT_MIN;
			byte b;
			byte b2;
			do
			{
				this.RT3CatInfoDict[(int)categories].FRANCXXX_DSTIdx = 0U;
				this.RT3CatInfoDict[(int)categories].DSTPOINumber = 0;
				categories += 1;
				b = (byte)categories;
				b2 = 9;
			}
			while (b <= b2);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0012998C File Offset: 0x0012898C
		public ushort getNbPOIDSTPerCategory(POICategoryInfos.categories category)
		{
			return this.RT3CatInfoDict[(int)category].DSTPOINumber;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x001299AC File Offset: 0x001289AC
		public void initNbPOIDSTPerCategory()
		{
			POICategoryInfos.categories categories = POICategoryInfos.categories.CAT_MIN;
			byte b;
			byte b2;
			do
			{
				POICategoryInfos.RT3CatInfos[] rt3CatInfoDict = this.RT3CatInfoDict;
				int num = (int)categories;
				rt3CatInfoDict[num].FRANCXXX_DSTIdx = checked(this.RT3CatInfoDict[num].FRANCXXX_DSTIdx + (uint)this.RT3CatInfoDict[(int)categories].DSTPOINumber);
				this.RT3CatInfoDict[(int)categories].DSTPOINumber = 0;
				categories += 1;
				b = (byte)categories;
				b2 = 9;
			}
			while (b <= b2);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00129A04 File Offset: 0x00128A04
		public void incNbPOIDSTPerCategory(POICategoryInfos.categories category)
		{
			bool flag = this.RT3CatInfoDict[(int)category].DSTPOINumber != ushort.MaxValue;
			if (flag)
			{
				this.RT3CatInfoDict[(int)category].DSTPOINumber = this.RT3CatInfoDict[(int)category].DSTPOINumber + 1;
			}
			else
			{
				this.RT3CatInfoDict[(int)category].DSTPOINumber = 1;
			}
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00129A60 File Offset: 0x00128A60
		public void incIdxPOIDSTPerCategory(POICategoryInfos.categories category)
		{
			this.RT3CatInfoDict[(int)category].FRANCXXX_DSTIdx = checked(this.RT3CatInfoDict[(int)category].FRANCXXX_DSTIdx + 1U);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00129A90 File Offset: 0x00128A90
		public uint getIdxPOIDSTPerCategory(POICategoryInfos.categories category)
		{
			return this.RT3CatInfoDict[(int)category].FRANCXXX_DSTIdx;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00129AB0 File Offset: 0x00128AB0
		public void initNbIdxPOIDSCPerCategory()
		{
			POICategoryInfos.categories categories = POICategoryInfos.categories.CAT_MIN;
			byte b;
			byte b2;
			do
			{
				this.RT3CatInfoDict[(int)categories].FRANCXXX_DSCIdx = 0U;
				this.RT3CatInfoDict[(int)categories].FRANCXXX_DSCOldIdx = 0U;
				this.RT3CatInfoDict[(int)categories].DSCPOINumber = 0U;
				this.RT3CatInfoDict[(int)categories].FRANCXXX_DSCCityIdx = 0U;
				this.RT3CatInfoDict[(int)categories].FRANCXXX_DSCCityOldIdx = 0U;
				this.RT3CatInfoDict[(int)categories].DSCCityPOINumber = 0U;
				categories += 1;
				b = (byte)categories;
				b2 = 9;
			}
			while (b <= b2);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00129B24 File Offset: 0x00128B24
		public void initNbPOIDSCPerCategory(bool cityChanged)
		{
			POICategoryInfos.categories categories = POICategoryInfos.categories.CAT_MIN;
			byte b;
			byte b2;
			do
			{
				this.RT3CatInfoDict[(int)categories].DSCPOINumber = 0U;
				this.RT3CatInfoDict[(int)categories].FRANCXXX_DSCOldIdx = this.RT3CatInfoDict[(int)categories].FRANCXXX_DSCIdx;
				if (cityChanged)
				{
					this.RT3CatInfoDict[(int)categories].DSCCityPOINumber = 0U;
					this.RT3CatInfoDict[(int)categories].FRANCXXX_DSCCityOldIdx = this.RT3CatInfoDict[(int)categories].FRANCXXX_DSCOldIdx;
				}
				categories += 1;
				b = (byte)categories;
				b2 = 9;
			}
			while (b <= b2);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00129B98 File Offset: 0x00128B98
		public void incIdxPOIDSCPerCategory(POICategoryInfos.categories category)
		{
			checked
			{
				this.RT3CatInfoDict[(int)category].DSCPOINumber = this.RT3CatInfoDict[(int)category].DSCPOINumber + 1U;
				this.RT3CatInfoDict[(int)category].FRANCXXX_DSCIdx = this.RT3CatInfoDict[(int)category].FRANCXXX_DSCIdx + 1U;
				this.RT3CatInfoDict[(int)category].DSCCityPOINumber = this.RT3CatInfoDict[(int)category].DSCCityPOINumber + 1U;
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00129C04 File Offset: 0x00128C04
		public uint getNbPOIDSCPerCategory(POICategoryInfos.categories category)
		{
			return this.RT3CatInfoDict[(int)category].DSCPOINumber;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00129C24 File Offset: 0x00128C24
		public uint getCityNbPOIDSCPerCategory(POICategoryInfos.categories category)
		{
			return this.RT3CatInfoDict[(int)category].DSCCityPOINumber;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00129C44 File Offset: 0x00128C44
		public uint getOldIdxPOIDSCPerCategory(POICategoryInfos.categories category)
		{
			return this.RT3CatInfoDict[(int)category].FRANCXXX_DSCOldIdx;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00129C64 File Offset: 0x00128C64
		public uint getOldCityIdxPOIDSCPerCategory(POICategoryInfos.categories category)
		{
			return this.RT3CatInfoDict[(int)category].FRANCXXX_DSCCityOldIdx;
		}

		// Token: 0x04000741 RID: 1857
		public const string STR_SAF = "SAF";

		// Token: 0x04000742 RID: 1858
		public const string STR_SAU = "SAU";

		// Token: 0x04000743 RID: 1859
		public const string STR_SEM = "SEM";

		// Token: 0x04000744 RID: 1860
		public const string STR_SSP = "SSP";

		// Token: 0x04000745 RID: 1861
		public const string STR_STU = "STU";

		// Token: 0x04000746 RID: 1862
		public const string STR_SSH = "SSH";

		// Token: 0x04000747 RID: 1863
		public const string STR_SHR = "SHR";

		// Token: 0x04000748 RID: 1864
		public const string STR_SCC = "SCC";

		// Token: 0x04000749 RID: 1865
		public const string STR_STR = "STR";

		// Token: 0x0400074A RID: 1866
		private const int CATEGORYNUMBER = 9;

		// Token: 0x0400074B RID: 1867
		private POICategoryInfos.RT3CatInfos[] RT3CatInfoDict;

		// Token: 0x0400074C RID: 1868
		private List<string> FilesToRead;

		// Token: 0x0400074D RID: 1869
		private List<string> FilesToWrite;

		// Token: 0x0400074E RID: 1870
		private Dictionary<ushort, POILists> AllPOIListDict;

		// Token: 0x020000AF RID: 175
		public enum categories : byte
		{
			// Token: 0x04000750 RID: 1872
			CAT_MIN = 1,
			// Token: 0x04000751 RID: 1873
			CAT_SEM = 1,
			// Token: 0x04000752 RID: 1874
			CAT_SAF,
			// Token: 0x04000753 RID: 1875
			CAT_SHR,
			// Token: 0x04000754 RID: 1876
			CAT_STU,
			// Token: 0x04000755 RID: 1877
			CAT_SSH,
			// Token: 0x04000756 RID: 1878
			CAT_SSP,
			// Token: 0x04000757 RID: 1879
			CAT_STR,
			// Token: 0x04000758 RID: 1880
			CAT_SAU,
			// Token: 0x04000759 RID: 1881
			CAT_SCC,
			// Token: 0x0400075A RID: 1882
			CAT_MAX = 9,
			// Token: 0x0400075B RID: 1883
			CAT_MAX_MAX
		}

		// Token: 0x020000B0 RID: 176
		private class RT3CatInfos
		{
			// Token: 0x06000DE7 RID: 3559 RVA: 0x00129C84 File Offset: 0x00128C84
			public RT3CatInfos()
			{
				this.DSCFile2ReadName = null;
				this.DSCFile2WriteName = null;
				this.DSTFile2ReadName = null;
				this.DSTFile2WriteName = null;
				this.IMPFile2WriteName = null;
				this.POIListDict = null;
			}

			// Token: 0x0400075C RID: 1884
			public string DSCFile2ReadName;

			// Token: 0x0400075D RID: 1885
			public string DSCFile2WriteName;

			// Token: 0x0400075E RID: 1886
			public string DSTFile2ReadName;

			// Token: 0x0400075F RID: 1887
			public string DSTFile2WriteName;

			// Token: 0x04000760 RID: 1888
			public string IMPFile2WriteName;

			// Token: 0x04000761 RID: 1889
			public Dictionary<ushort, POILists> POIListDict;

			// Token: 0x04000762 RID: 1890
			public ushort DSTPOINumber;

			// Token: 0x04000763 RID: 1891
			public uint FRANCXXX_DSTIdx;

			// Token: 0x04000764 RID: 1892
			public uint DSCPOINumber;

			// Token: 0x04000765 RID: 1893
			public uint FRANCXXX_DSCIdx;

			// Token: 0x04000766 RID: 1894
			public uint FRANCXXX_DSCOldIdx;

			// Token: 0x04000767 RID: 1895
			public uint DSCCityPOINumber;

			// Token: 0x04000768 RID: 1896
			public uint FRANCXXX_DSCCityIdx;

			// Token: 0x04000769 RID: 1897
			public uint FRANCXXX_DSCCityOldIdx;
		}
	}
}
