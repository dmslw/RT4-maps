using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x020000CB RID: 203
	public class RT4Inf
	{
		// Token: 0x06000E3D RID: 3645 RVA: 0x0012F14C File Offset: 0x0012E14C
		public RT4Inf(string fileName, bool withInfFile, string versField, string typeField, string IDField, string compressedField, string sizeField, string uSizeField, string entryField)
		{
			this.infFileName = null;
			this.dataFileName = null;
			this.infLines = null;
			this.idxCRC = 0;
			this.idxSize = -1;
			this.idxVers = -1;
			this.dataFileName = fileName;
			this.infFileName = fileName + ".inf";
			if (withInfFile)
			{
				this.loadInfFile(this.infFileName);
			}
			else
			{
				this.createInfFile(fileName, versField, typeField, IDField, compressedField, uSizeField, sizeField, entryField);
			}
			this.setCRC16Low(this.computeCRC16(fileName), false);
			this.setCRCHigh(false);
			this.rewrite(this.infFileName);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0012F1F4 File Offset: 0x0012E1F4
		public RT4Inf(string fileName)
		{
			this.infFileName = null;
			this.dataFileName = null;
			this.infLines = null;
			this.idxCRC = 0;
			this.idxSize = -1;
			this.idxVers = -1;
			bool flag = Operators.CompareString(Path.GetExtension(fileName).ToLower(), ".bmp", false) == 0;
			if (flag)
			{
				this.dataFileName = fileName;
				this.infFileName = fileName + ".inf";
				this.createInfFile(fileName, "DEFAULT", "TYPE:DATA", null, "COMPRESSED:NO", null, "DEFAULT", null);
				this.setCRC16Low(this.computeCRC16(fileName), false);
				this.setCRCHigh(false);
				this.rewrite(this.infFileName);
				return;
			}
			throw new Exception();
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0012F2B8 File Offset: 0x0012E2B8
		public RT4Inf(string fileName, bool isconfigFile)
		{
			this.infFileName = null;
			this.dataFileName = null;
			this.infLines = null;
			this.idxCRC = 0;
			this.idxSize = -1;
			this.idxVers = -1;
			bool flag = Operators.CompareString(Path.GetExtension(fileName).ToLower(), ".dat", false) == 0 && isconfigFile;
			if (flag)
			{
				this.dataFileName = fileName;
				this.infFileName = fileName + ".inf";
				this.infLines = new List<string>();
				this.infLines.Add("12345678");
				this.setCRC16Low(this.computeCRC16(fileName), true);
				this.setCRCHigh(true);
				this.rewriteSimple(this.infFileName);
				return;
			}
			throw new Exception();
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0012F380 File Offset: 0x0012E380
		private void createInfFile(string fileName, string versField, string typeField, string IDField, string compressedField, string uSizeField, string sizeField, string entryField)
		{
			int num = 0;
			this.infLines = new List<string>();
			this.infLines.Add("12345678");
			checked
			{
				num++;
				bool flag = versField != null;
				bool flag2;
				if (flag)
				{
					flag2 = (Operators.CompareString(versField, "DEFAULT", false) == 0);
					if (flag2)
					{
						this.infLines.Add("VER:" + this.dateToStr(fileName));
					}
					else
					{
						this.infLines.Add(versField);
					}
					this.idxVers = num;
					num++;
				}
				flag2 = (typeField != null);
				if (flag2)
				{
					this.infLines.Add(typeField);
					num++;
				}
				flag2 = (IDField != null);
				if (flag2)
				{
					this.infLines.Add(IDField);
					num++;
				}
				flag2 = (compressedField != null);
				if (flag2)
				{
					this.infLines.Add(compressedField);
					num++;
				}
				flag2 = (uSizeField != null);
				if (flag2)
				{
					this.infLines.Add(uSizeField);
					num++;
				}
				flag2 = (sizeField != null);
				if (flag2)
				{
					flag = (Operators.CompareString(sizeField, "DEFAULT", false) == 0);
					if (flag)
					{
						this.infLines.Add("SIZE:" + MyProject.Computer.FileSystem.GetFileInfo(fileName).Length.ToString("D"));
					}
					else
					{
						this.infLines.Add(sizeField);
					}
					this.idxSize = num;
					num++;
				}
				flag2 = (entryField != null);
				if (flag2)
				{
					this.infLines.Add(entryField);
					num++;
				}
				bool flag3;
				if (this.idxVers != -1 && this.idxVers != this.idxCRC)
				{
					if (this.idxSize != -1)
					{
						if (this.idxSize != this.idxCRC)
						{
							flag3 = false;
							goto IL_1C0;
						}
					}
				}
				flag3 = true;
				IL_1C0:
				flag2 = flag3;
				if (flag2)
				{
					MyProject.Application.Log.WriteEntry(string.Format("{0:G} : incorrect format", this.infFileName), TraceEventType.Information);
					throw new Exception();
				}
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0012F57C File Offset: 0x0012E57C
		private void loadInfFile(string infFileName)
		{
			StreamReader streamReader = null;
			int num = 0;
			this.infLines = new List<string>();
			checked
			{
				bool flag;
				try
				{
					streamReader = new StreamReader(new FileStream(infFileName, FileMode.Open, FileAccess.Read));
					for (;;)
					{
						string text = streamReader.ReadLine();
						flag = (text != null);
						if (!flag)
						{
							break;
						}
						this.infLines.Add(text);
						flag = text.ToUpper().StartsWith("VER:");
						if (flag)
						{
							this.idxVers = num;
						}
						else
						{
							flag = text.ToUpper().StartsWith("SIZE:");
							if (flag)
							{
								this.idxSize = num;
							}
						}
						num++;
					}
				}
				catch (EndOfStreamException ex)
				{
				}
				catch (Exception ex2)
				{
					MyProject.Application.Log.WriteEntry(string.Format("{0:G} cannot be read", infFileName), TraceEventType.Information);
					throw;
				}
				finally
				{
					flag = (streamReader != null);
					if (flag)
					{
						streamReader.Close();
					}
				}
				bool flag2;
				if (this.idxVers != -1 && this.idxVers != this.idxCRC)
				{
					if (this.idxSize != -1)
					{
						if (this.idxSize != this.idxCRC)
						{
							flag2 = false;
							goto IL_118;
						}
					}
				}
				flag2 = true;
				IL_118:
				flag = flag2;
				if (flag)
				{
					MyProject.Application.Log.WriteEntry(string.Format("{0:G} : incorrect format", infFileName), TraceEventType.Information);
					throw new Exception();
				}
			}
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0012F6F4 File Offset: 0x0012E6F4
		private string dateToStr(string fileName)
		{
			FileInfo fileInfo = MyProject.Computer.FileSystem.GetFileInfo(fileName);
			DateTime lastWriteTimeUtc = fileInfo.LastWriteTimeUtc;
			return string.Concat(new string[]
			{
				(lastWriteTimeUtc.Year % 100).ToString("D2"),
				".",
				lastWriteTimeUtc.Month.ToString("D2"),
				".",
				lastWriteTimeUtc.Day.ToString("D2"),
				".",
				lastWriteTimeUtc.Hour.ToString("D2"),
				".",
				lastWriteTimeUtc.Minute.ToString("D2")
			});
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0012F7DC File Offset: 0x0012E7DC
		private ushort computeCRC16(string fileName)
		{
			BinaryReader binaryReader = null;
			byte b = 0;
			byte b2 = 0;
			try
			{
				binaryReader = new BinaryReader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
				for (;;)
				{
					byte b3 = b2 ^ binaryReader.ReadByte();
					b2 = (b ^ RT4Inf.highBytes[(int)b3]);
					b = RT4Inf.lowBytes[(int)b3];
				}
			}
			catch (EndOfStreamException ex)
			{
			}
			catch (Exception ex2)
			{
				MyProject.Application.Log.WriteEntry(string.Format("{0:G} cannot be read", fileName), TraceEventType.Information);
				throw;
			}
			finally
			{
				bool flag = binaryReader != null;
				if (flag)
				{
					binaryReader.Close();
				}
			}
			return (ushort)(b2 << 8) | (ushort)b;
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0012F8AC File Offset: 0x0012E8AC
		private static ushort computeCRC16(StringBuilder strBuilder)
		{
			byte b = 0;
			byte b2 = 0;
			try
			{
				StringReader stringReader = new StringReader(strBuilder.ToString());
				for (int num = stringReader.Read(); num != -1; num = stringReader.Read())
				{
					byte b3 = b2 ^ checked((byte)num);
					b2 = (b ^ RT4Inf.highBytes[(int)b3]);
					b = RT4Inf.lowBytes[(int)b3];
				}
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteEntry("Error while calculating .inf CRC", TraceEventType.Information);
				throw;
			}
			return (ushort)(b2 << 8) | (ushort)b;
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0012F950 File Offset: 0x0012E950
		private void setCRC16Low(ushort newCrcLow, bool simpleInfFile)
		{
			try
			{
				if (simpleInfFile)
				{
					this.infLines[this.idxCRC] = newCrcLow.ToString("x4") + "\n";
				}
				else
				{
					this.infLines[this.idxCRC] = newCrcLow.ToString("x4");
				}
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteEntry("Cannot read CRC", TraceEventType.Information);
				throw;
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0012F9EC File Offset: 0x0012E9EC
		private void setCRCHigh(bool simpleInfFile)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			int num = 0;
			checked
			{
				int num2 = this.infLines.Count - 1;
				int num3 = num;
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					if (simpleInfFile)
					{
						stringBuilder.Append(this.infLines[num3]);
					}
					else
					{
						stringBuilder.AppendLine(this.infLines[num3]);
					}
					num3++;
				}
				ushort num6 = RT4Inf.computeCRC16(stringBuilder);
				this.infLines[this.idxCRC] = this.infLines[this.idxCRC].Insert(0, num6.ToString("x4"));
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0012FA94 File Offset: 0x0012EA94
		private void rewrite(string fileName)
		{
			StreamWriter streamWriter = null;
			checked
			{
				try
				{
					streamWriter = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write));
					int num = 0;
					int num2 = this.infLines.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						streamWriter.WriteLine(this.infLines[num3]);
						num3++;
					}
				}
				catch (Exception ex)
				{
					MyProject.Application.Log.WriteEntry(string.Format("cannot rewrite {0:G}", fileName), TraceEventType.Information);
					throw;
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
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0012FB4C File Offset: 0x0012EB4C
		private void rewriteSimple(string fileName)
		{
			StreamWriter streamWriter = null;
			try
			{
				streamWriter = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write));
				streamWriter.Write(this.infLines[this.idxCRC]);
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteEntry(string.Format("cannot rewrite {0:G}", fileName), TraceEventType.Information);
				throw;
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

		// Token: 0x040008B2 RID: 2226
		public const string DEFAULT_VALUE = "DEFAULT";

		// Token: 0x040008B3 RID: 2227
		public const string VERS_FIELD_HEAD = "VER:";

		// Token: 0x040008B4 RID: 2228
		public const string TYPE_FIELD_HEAD = "TYPE:";

		// Token: 0x040008B5 RID: 2229
		public const string ID_FIELD_HEAD = "ID:";

		// Token: 0x040008B6 RID: 2230
		public const string COMPRESSED_FIELD_HEAD = "COMPRESSED:";

		// Token: 0x040008B7 RID: 2231
		public const string SIZE_FIELD_HEAD = "SIZE:";

		// Token: 0x040008B8 RID: 2232
		public const string USIZE_FIELD_HEAD = "USIZE:";

		// Token: 0x040008B9 RID: 2233
		public const string ENTRY_FIELD_HEAD = "ENTRY:";

		// Token: 0x040008BA RID: 2234
		private static byte[] lowBytes = new byte[]
		{
			0,
			43,
			87,
			124,
			175,
			132,
			248,
			211,
			246,
			221,
			161,
			138,
			89,
			114,
			14,
			37,
			69,
			110,
			18,
			57,
			234,
			193,
			189,
			150,
			179,
			152,
			228,
			207,
			28,
			55,
			75,
			96,
			139,
			160,
			220,
			247,
			36,
			15,
			115,
			88,
			125,
			86,
			42,
			1,
			210,
			249,
			133,
			174,
			206,
			229,
			153,
			178,
			97,
			74,
			54,
			29,
			56,
			19,
			111,
			68,
			151,
			188,
			192,
			235,
			190,
			149,
			233,
			194,
			17,
			58,
			70,
			109,
			72,
			99,
			31,
			52,
			231,
			204,
			176,
			155,
			251,
			208,
			172,
			135,
			84,
			127,
			3,
			40,
			13,
			38,
			90,
			113,
			162,
			137,
			245,
			222,
			53,
			30,
			98,
			73,
			154,
			177,
			205,
			230,
			195,
			232,
			148,
			191,
			108,
			71,
			59,
			16,
			112,
			91,
			39,
			12,
			223,
			244,
			136,
			163,
			134,
			173,
			209,
			250,
			41,
			2,
			126,
			85,
			212,
			byte.MaxValue,
			131,
			168,
			123,
			80,
			44,
			7,
			34,
			9,
			117,
			94,
			141,
			166,
			218,
			241,
			145,
			186,
			198,
			237,
			62,
			21,
			105,
			66,
			103,
			76,
			48,
			27,
			200,
			227,
			159,
			180,
			95,
			116,
			8,
			35,
			240,
			219,
			167,
			140,
			169,
			130,
			254,
			213,
			6,
			45,
			81,
			122,
			26,
			49,
			77,
			102,
			181,
			158,
			226,
			201,
			236,
			199,
			187,
			144,
			67,
			104,
			20,
			63,
			106,
			65,
			61,
			22,
			197,
			238,
			146,
			185,
			156,
			183,
			203,
			224,
			51,
			24,
			100,
			79,
			47,
			4,
			120,
			83,
			128,
			171,
			215,
			252,
			217,
			242,
			142,
			165,
			118,
			93,
			33,
			10,
			225,
			202,
			182,
			157,
			78,
			101,
			25,
			50,
			23,
			60,
			64,
			107,
			184,
			147,
			239,
			196,
			164,
			143,
			243,
			216,
			11,
			32,
			92,
			119,
			82,
			121,
			5,
			46,
			253,
			214,
			170,
			129
		};

		// Token: 0x040008BB RID: 2235
		private static byte[] highBytes = new byte[]
		{
			0,
			223,
			190,
			97,
			124,
			163,
			194,
			29,
			211,
			12,
			109,
			178,
			175,
			112,
			17,
			206,
			141,
			82,
			51,
			236,
			241,
			46,
			79,
			144,
			94,
			129,
			224,
			63,
			34,
			253,
			156,
			67,
			26,
			197,
			164,
			123,
			102,
			185,
			216,
			7,
			201,
			22,
			119,
			168,
			181,
			106,
			11,
			212,
			151,
			72,
			41,
			246,
			235,
			52,
			85,
			138,
			68,
			155,
			250,
			37,
			56,
			231,
			134,
			89,
			31,
			192,
			161,
			126,
			99,
			188,
			221,
			2,
			204,
			19,
			114,
			173,
			176,
			111,
			14,
			209,
			146,
			77,
			44,
			243,
			238,
			49,
			80,
			143,
			65,
			158,
			byte.MaxValue,
			32,
			61,
			226,
			131,
			92,
			5,
			218,
			187,
			100,
			121,
			166,
			199,
			24,
			214,
			9,
			104,
			183,
			170,
			117,
			20,
			203,
			136,
			87,
			54,
			233,
			244,
			43,
			74,
			149,
			91,
			132,
			229,
			58,
			39,
			248,
			153,
			70,
			21,
			202,
			171,
			116,
			105,
			182,
			215,
			8,
			198,
			25,
			120,
			167,
			186,
			101,
			4,
			219,
			152,
			71,
			38,
			249,
			228,
			59,
			90,
			133,
			75,
			148,
			245,
			42,
			55,
			232,
			137,
			86,
			15,
			208,
			177,
			110,
			115,
			172,
			205,
			18,
			220,
			3,
			98,
			189,
			160,
			127,
			30,
			193,
			130,
			93,
			60,
			227,
			254,
			33,
			64,
			159,
			81,
			142,
			239,
			48,
			45,
			242,
			147,
			76,
			10,
			213,
			180,
			107,
			118,
			169,
			200,
			23,
			217,
			6,
			103,
			184,
			165,
			122,
			27,
			196,
			135,
			88,
			57,
			230,
			251,
			36,
			69,
			154,
			84,
			139,
			234,
			53,
			40,
			247,
			150,
			73,
			16,
			207,
			174,
			113,
			108,
			179,
			210,
			13,
			195,
			28,
			125,
			162,
			191,
			96,
			1,
			222,
			157,
			66,
			35,
			252,
			225,
			62,
			95,
			128,
			78,
			145,
			240,
			47,
			50,
			237,
			140,
			83
		};

		// Token: 0x040008BC RID: 2236
		private string infFileName;

		// Token: 0x040008BD RID: 2237
		private string dataFileName;

		// Token: 0x040008BE RID: 2238
		private List<string> infLines;

		// Token: 0x040008BF RID: 2239
		private int idxCRC;

		// Token: 0x040008C0 RID: 2240
		private int idxSize;

		// Token: 0x040008C1 RID: 2241
		private int idxVers;
	}
}
