using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x020000A7 RID: 167
	public class GRUPPODAT
	{
		// Token: 0x06000DBA RID: 3514 RVA: 0x00127764 File Offset: 0x00126764
		public GRUPPODAT(GRUPPODAT.mode mode, string fileName, string mapIniName, string workingDir, string mapCountry)
		{
			this.fileName = null;
			this.relFileName = null;
			this.countryFileName = null;
			this.RT3Reader = null;
			this.RT3Writer = null;
			this.splitPathName = null;
			this.fileName = fileName;
			this.fmode = mode;
			this.mapIniName = mapIniName;
			bool flag = !workingDir.EndsWith(Conversions.ToString(Path.DirectorySeparatorChar));
			if (flag)
			{
				workingDir += Conversions.ToString(Path.DirectorySeparatorChar);
			}
			flag = (mode == GRUPPODAT.mode.read);
			if (flag)
			{
				this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
				this.relFileName = fileName.Replace(workingDir, "");
			}
			else
			{
				this.RT3Writer = new RT3Writer(new FileStream(fileName, FileMode.Create, FileAccess.Write));
				this.relFileName = fileName.Replace(workingDir, "").Replace("dest", "orig");
				this.countryFileName = Path.Combine(workingDir, Path.Combine("MAPPE", Path.Combine(mapCountry, this.relFileName)));
			}
			this.fileList = new List<GRUPPODAT.GruppoDatRecords>();
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0012787C File Offset: 0x0012687C
		public string splitFile(bool hddMap)
		{
			int num = 0;
			bool flag = Inifiles.ExistsSection(this.mapIniName, this.relFileName);
			if (flag)
			{
				Inifiles.DeleteSection(this.mapIniName, this.relFileName);
			}
			string text = Path.GetFileName(this.fileName);
			this.splitPathName = Path.Combine(Path.GetDirectoryName(this.fileName), text.Replace(".", "_"));
			Directory.CreateDirectory(this.splitPathName);
			string text2 = this.RT3Reader.readRT3String(18);
			flag = (text.ToUpper().StartsWith("GRUPPO_4_") && text2.StartsWith("NR_FILES_GROUP:"));
			checked
			{
				int num2;
				int num3;
				string text3;
				if (flag)
				{
					num2 = "NR_FILES_GROUP:".Length + 3;
					num3 = 0;
					text3 = "RT34";
					Inifiles.SetKey(this.mapIniName, this.relFileName, "number", text2.Substring(15, 3));
					Inifiles.SetKey(this.mapIniName, this.relFileName, "type", text3);
				}
				else
				{
					flag = (Operators.CompareString(text.ToUpper(), "GRUPPO_2.DAT", false) == 0);
					if (flag)
					{
						num2 = 0;
						num3 = 0;
						text3 = "RT3";
						Inifiles.SetKey(this.mapIniName, this.relFileName, "number", "-1");
						Inifiles.SetKey(this.mapIniName, this.relFileName, "type", text3);
						this.RT3Reader.BaseStream.Seek(0L, SeekOrigin.Begin);
					}
					else
					{
						flag = (hddMap && text2.StartsWith("Map.ver"));
						if (!flag)
						{
							MyProject.Application.Log.WriteEntry(Resources.strErrGruppoNotSupported, TraceEventType.Error);
							Interaction.MsgBox(Resources.strErrGruppoNotSupported, MsgBoxStyle.Exclamation, null);
							text3 = "";
							this.RT3Reader.Close();
							return text3;
						}
						num2 = 0;
						num3 = 0;
						text3 = "RT4OLD";
						Inifiles.SetKey(this.mapIniName, this.relFileName, "number", "-1");
						Inifiles.SetKey(this.mapIniName, this.relFileName, "type", text3);
						this.RT3Reader.BaseStream.Seek(0L, SeekOrigin.Begin);
					}
				}
				uint ptrFile;
				do
				{
					GRUPPODAT.GruppoDatRecords gruppoDatRecords = new GRUPPODAT.GruppoDatRecords();
					GRUPPODAT.GruppoDatRecords gruppoDatRecords2 = gruppoDatRecords;
					gruppoDatRecords2.origfileName = this.RT3Reader.readRT3String(15);
					gruppoDatRecords2.fileName = Strings.Left(gruppoDatRecords2.origfileName, gruppoDatRecords2.origfileName.IndexOf('\0'));
					gruppoDatRecords2.ptrFile = (uint)(unchecked((ulong)this.RT3Reader.readRT3Uint32()) + (ulong)(unchecked((long)num3)));
					flag = (this.fileList.Count == 0);
					if (flag)
					{
						ptrFile = gruppoDatRecords2.ptrFile;
					}
					gruppoDatRecords2.lenFile = this.RT3Reader.readRT3Uint32();
					this.fileList.Add(gruppoDatRecords);
					Inifiles.SetKey(this.mapIniName, this.relFileName, num.ToString(), gruppoDatRecords2.fileName);
					num++;
				}
				while (unchecked((long)(checked(this.fileList.Count * 23 + num2))) < (long)(unchecked((ulong)ptrFile) + (ulong)(unchecked((long)num3))));
				this.fileList.ForEach(new Action<GRUPPODAT.GruppoDatRecords>(this.fileCopy));
				this.RT3Reader.Close();
				return text3;
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00127BC0 File Offset: 0x00126BC0
		private void fileCopy(GRUPPODAT.GruppoDatRecords record)
		{
			BinaryWriter binaryWriter = new BinaryWriter(File.Create(Path.Combine(this.splitPathName, record.fileName)));
			this.RT3Reader.BaseStream.Seek((long)((ulong)record.ptrFile), SeekOrigin.Begin);
			binaryWriter.Write(this.RT3Reader.ReadBytes(checked((int)record.lenFile)));
			binaryWriter.Close();
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00127C24 File Offset: 0x00126C24
		public bool getRadarDisplay()
		{
			string key = Inifiles.GetKey(this.mapIniName, this.relFileName, "type");
			string left = key;
			bool flag = Operators.CompareString(left, "RT3", false) == 0;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				flag = (Operators.CompareString(left, "RT4OLD", false) == 0);
				if (flag)
				{
					result = false;
				}
				else
				{
					flag = (Operators.CompareString(left, "RT34", false) == 0);
					if (flag)
					{
						result = (MyProject.Computer.FileSystem.GetFileInfo(Path.Combine(this.splitPathName, "RADAR")).Length == 1L);
					}
					else
					{
						MyProject.Application.Log.WriteEntry(Resources.strErrGruppoNotSupported, TraceEventType.Error);
						Interaction.MsgBox(Resources.strErrGruppoNotSupported, MsgBoxStyle.Exclamation, null);
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00127CF4 File Offset: 0x00126CF4
		public void setRadarDisplay(bool value)
		{
			string key = Inifiles.GetKey(this.mapIniName, this.relFileName, "type");
			string left = key;
			bool flag = Operators.CompareString(left, "RT3", false) == 0;
			if (!flag)
			{
				flag = (Operators.CompareString(left, "RT4OLD", false) == 0);
				if (!flag)
				{
					flag = (Operators.CompareString(left, "RT34", false) == 0);
					if (flag)
					{
						RT3Writer rt3Writer = new RT3Writer(new FileStream(Path.Combine(this.splitPathName, "RADAR"), FileMode.Create, FileAccess.Write));
						if (value)
						{
							rt3Writer.Write(1);
						}
						rt3Writer.Close();
					}
				}
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00127DA0 File Offset: 0x00126DA0
		public bool getGuideDisplay()
		{
			string key = Inifiles.GetKey(this.mapIniName, this.relFileName, "type");
			string left = key;
			bool flag = Operators.CompareString(left, "RT3", false) == 0;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				flag = (Operators.CompareString(left, "RT34", false) == 0 || Operators.CompareString(left, "RT4OLD", false) == 0);
				if (flag)
				{
					result = (MyProject.Computer.FileSystem.GetFileInfo(Path.Combine(this.splitPathName, "GUIDE")).Length == 1L);
				}
				else
				{
					MyProject.Application.Log.WriteEntry(Resources.strErrGruppoNotSupported, TraceEventType.Error);
					Interaction.MsgBox(Resources.strErrGruppoNotSupported, MsgBoxStyle.Exclamation, null);
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00127E68 File Offset: 0x00126E68
		public void setGuideDisplay(bool value)
		{
			string key = Inifiles.GetKey(this.mapIniName, this.relFileName, "type");
			string left = key;
			bool flag = Operators.CompareString(left, "RT3", false) == 0;
			if (!flag)
			{
				flag = (Operators.CompareString(left, "RT34", false) == 0 || Operators.CompareString(left, "RT4OLD", false) == 0);
				if (flag)
				{
					RT3Writer rt3Writer = new RT3Writer(new FileStream(Path.Combine(this.splitPathName, "GUIDE"), FileMode.Create, FileAccess.Write));
					if (value)
					{
						rt3Writer.Write(1);
					}
					rt3Writer.Close();
				}
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00127F10 File Offset: 0x00126F10
		public string getLabel()
		{
			string text = null;
			StreamReader streamReader = new StreamReader(new FileStream(Path.Combine(this.splitPathName, "Label.txt"), FileMode.Open, FileAccess.Read));
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

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00127FAC File Offset: 0x00126FAC
		public void buildFile(string dirName)
		{
			Collection sectionKeys = Inifiles.GetSectionKeys(this.mapIniName, this.relFileName);
			bool flag = sectionKeys.Count == 0;
			if (flag)
			{
				throw new Exception(string.Format(Resources.strErrGRUPPO, this.relFileName));
			}
			string key = Inifiles.GetKey(this.mapIniName, this.relFileName, "type");
			string left = key;
			flag = (Operators.CompareString(left, "RT3", false) == 0 || Operators.CompareString(left, "RT4OLD", false) == 0);
			checked
			{
				int num;
				if (flag)
				{
					num = 0;
				}
				else
				{
					flag = (Operators.CompareString(left, "RT34", false) == 0);
					if (!flag)
					{
						return;
					}
					RT3Writer rt3Writer = this.RT3Writer;
					string text = "NR_FILES_GROUP:";
					rt3Writer.writeRT3Str(ref text);
					RT3Writer rt3Writer2 = this.RT3Writer;
					text = Inifiles.GetKey(this.mapIniName, this.relFileName, "number");
					rt3Writer2.writeRT3Str(ref text);
					num = "NR_FILES_GROUP:".Length + 3;
				}
				int num2 = sectionKeys.Count - 2;
				uint num3 = (uint)(num2 * 23 + num);
				int num4 = 0;
				int num5 = num2 - 1;
				int num6 = num4;
				for (;;)
				{
					int num7 = num6;
					int num8 = num5;
					if (num7 > num8)
					{
						break;
					}
					GRUPPODAT.GruppoDatRecords gruppoDatRecords = new GRUPPODAT.GruppoDatRecords();
					GRUPPODAT.GruppoDatRecords gruppoDatRecords2 = gruppoDatRecords;
					gruppoDatRecords2.origfileName = Inifiles.GetKey(this.mapIniName, this.relFileName, num6.ToString());
					gruppoDatRecords2.fileName = Path.Combine(dirName, gruppoDatRecords2.origfileName);
					gruppoDatRecords2.lenFile = (uint)MyProject.Computer.FileSystem.GetFileInfo(gruppoDatRecords2.fileName).Length;
					gruppoDatRecords2.ptrFile = num3;
					num3 += gruppoDatRecords2.lenFile;
					this.fileList.Add(gruppoDatRecords);
					this.RT3Writer.writeRT3(ref gruppoDatRecords2.origfileName, 15);
					this.RT3Writer.writeRT3(gruppoDatRecords2.ptrFile);
					this.RT3Writer.writeRT3(gruppoDatRecords2.lenFile);
					num6++;
				}
				this.fileList.ForEach(new Action<GRUPPODAT.GruppoDatRecords>(this.fileAdd));
				this.RT3Writer.Write(0);
				this.RT3Writer.Close();
				flag = (Operators.CompareString(key, "RT3", false) != 0);
				if (flag)
				{
					MyProject.Computer.FileSystem.CopyFile(this.fileName, this.countryFileName, true);
				}
				MyProject.Computer.FileSystem.DeleteDirectory(dirName, DeleteDirectoryOption.DeleteAllContents);
			}
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0012821C File Offset: 0x0012721C
		private void fileAdd(GRUPPODAT.GruppoDatRecords record)
		{
			BinaryReader binaryReader = new BinaryReader(File.Open(record.fileName, FileMode.Open));
			this.RT3Writer.Write(binaryReader.ReadBytes(checked((int)record.lenFile)));
			binaryReader.Close();
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00128260 File Offset: 0x00127260
		public void close()
		{
			bool flag = this.fmode == GRUPPODAT.mode.read;
			if (flag)
			{
				this.RT3Reader.Close();
			}
			else
			{
				this.RT3Writer.Close();
			}
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00128298 File Offset: 0x00127298
		public void copyGruppoDir(string orgiDir, string destDir)
		{
			MyProject.Computer.FileSystem.CopyDirectory(orgiDir, destDir, true);
			this.splitPathName = destDir;
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x001282B8 File Offset: 0x001272B8
		public static void upgradeMap10To11(string mapIniName)
		{
			Inifiles.SetKey(mapIniName, "GRUPPO_2.DAT", "type", "RT3");
			Inifiles.SetKey(mapIniName, "GRUPPO_2.DAT", "number", "-1");
		}

		// Token: 0x0400070F RID: 1807
		public const string OPT_HEADER_STR = "NR_FILES_GROUP:";

		// Token: 0x04000710 RID: 1808
		public const int OPT_HEADER_SIZE = 15;

		// Token: 0x04000711 RID: 1809
		public const string NO_HEADER_STR = "Map.ver";

		// Token: 0x04000712 RID: 1810
		public const int NO_HEADER_SIZE = 7;

		// Token: 0x04000713 RID: 1811
		private const int NUMSIZE = 3;

		// Token: 0x04000714 RID: 1812
		private const int RECORDSIZE = 23;

		// Token: 0x04000715 RID: 1813
		private const int FILENAMESIZE = 15;

		// Token: 0x04000716 RID: 1814
		public const string SECT_GRUPPO2_DAT = "GRUPPO_2.DAT";

		// Token: 0x04000717 RID: 1815
		public const string KEY_GRUPPO_TYPE = "type";

		// Token: 0x04000718 RID: 1816
		public const string GRUPPO_TYPE_RT3 = "RT3";

		// Token: 0x04000719 RID: 1817
		public const string GRUPPO_TYPE_RT34 = "RT34";

		// Token: 0x0400071A RID: 1818
		public const string GRUPPO_TYPE_RT4OLD = "RT4OLD";

		// Token: 0x0400071B RID: 1819
		public const string KEY_GRUPPO_NUMBER = "number";

		// Token: 0x0400071C RID: 1820
		private List<GRUPPODAT.GruppoDatRecords> fileList;

		// Token: 0x0400071D RID: 1821
		private string fileName;

		// Token: 0x0400071E RID: 1822
		private string relFileName;

		// Token: 0x0400071F RID: 1823
		private string countryFileName;

		// Token: 0x04000720 RID: 1824
		private RT3Reader RT3Reader;

		// Token: 0x04000721 RID: 1825
		private RT3Writer RT3Writer;

		// Token: 0x04000722 RID: 1826
		private GRUPPODAT.mode fmode;

		// Token: 0x04000723 RID: 1827
		private string mapIniName;

		// Token: 0x04000724 RID: 1828
		private string splitPathName;

		// Token: 0x020000A8 RID: 168
		public enum mode
		{
			// Token: 0x04000726 RID: 1830
			read,
			// Token: 0x04000727 RID: 1831
			write
		}

		// Token: 0x020000A9 RID: 169
		private class GruppoDatRecords
		{
			// Token: 0x06000DC7 RID: 3527 RVA: 0x001282E8 File Offset: 0x001272E8
			[DebuggerNonUserCode]
			public GruppoDatRecords()
			{
			}

			// Token: 0x04000728 RID: 1832
			public string origfileName;

			// Token: 0x04000729 RID: 1833
			public string fileName;

			// Token: 0x0400072A RID: 1834
			public uint ptrFile;

			// Token: 0x0400072B RID: 1835
			public uint lenFile;
		}

		// Token: 0x020000AA RID: 170
		private enum GruppoType
		{
			// Token: 0x0400072D RID: 1837
			GruppoRT3,
			// Token: 0x0400072E RID: 1838
			GruppoRT34
		}
	}
}
