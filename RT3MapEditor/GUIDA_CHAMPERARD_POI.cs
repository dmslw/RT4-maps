using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x020000AB RID: 171
	public class GUIDA_CHAMPERARD_POI
	{
		// Token: 0x06000DC8 RID: 3528 RVA: 0x001282F4 File Offset: 0x001272F4
		public GUIDA_CHAMPERARD_POI(string fileName, GUIDA_CHAMPERARD_POI.mode mode)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.RT3Writer = null;
			this.FileName = fileName;
			this.dict = new Dictionary<uint, GUIDA_CHAMPERARD_POI.GuidaChamperardRecords>(4096);
			bool flag = mode == GUIDA_CHAMPERARD_POI.mode.read;
			if (flag)
			{
				bool flag2 = MyProject.Computer.FileSystem.FileExists(fileName);
				if (flag2)
				{
					this.fmode = mode;
					this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
				}
				else
				{
					this.dict = new Dictionary<uint, GUIDA_CHAMPERARD_POI.GuidaChamperardRecords>();
					MyProject.Application.Log.WriteEntry(string.Format("No {0:G} file found", fileName));
					this.FileName = "";
					this.fmode = GUIDA_CHAMPERARD_POI.mode.none;
				}
			}
			else
			{
				this.fmode = mode;
				this.nextStr = 0U;
				this.recordNumber = 0U;
				this.strOffset = 0U;
			}
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x001283C8 File Offset: 0x001273C8
		public void loadFromFile()
		{
			GUIDA_CHAMPERARD_POI.GuidaChamperardRecords guidaChamperardRecords = null;
			bool flag = this.fmode != GUIDA_CHAMPERARD_POI.mode.none;
			checked
			{
				if (flag)
				{
					try
					{
						MyProject.Application.Log.WriteEntry(string.Format("loading {0:G}", this.FileName));
						this.recordNumber = this.RT3Reader.readRT3Uint32();
						GUIDA_CHAMPERARD_POI.GuidaChamperardRecords guidaChamperardRecords2 = null;
						uint num = 0U;
						uint num2 = this.recordNumber - 1U;
						uint num3 = num;
						for (;;)
						{
							uint num4 = num3;
							uint num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							guidaChamperardRecords = new GUIDA_CHAMPERARD_POI.GuidaChamperardRecords();
							GUIDA_CHAMPERARD_POI.GuidaChamperardRecords guidaChamperardRecords3 = guidaChamperardRecords;
							guidaChamperardRecords3.FrancPOIDatPtr = this.RT3Reader.readRT3Uint32();
							guidaChamperardRecords3.strPtr = this.RT3Reader.readRT3Uint32();
							flag = !this.dict.ContainsKey(guidaChamperardRecords3.FrancPOIDatPtr);
							if (flag)
							{
								this.dict.Add(guidaChamperardRecords3.FrancPOIDatPtr, guidaChamperardRecords);
							}
							else
							{
								MyProject.Application.Log.WriteEntry(string.Format("RT3 map error: record {0:G} has already an entry ({1:X}), skipped", num3, guidaChamperardRecords3.FrancPOIDatPtr));
							}
							flag = (guidaChamperardRecords2 != null);
							if (flag)
							{
								long position = this.RT3Reader.BaseStream.Position;
								this.RT3Reader.BaseStream.Seek((long)(unchecked((ulong)guidaChamperardRecords2.strPtr)), SeekOrigin.Begin);
								guidaChamperardRecords2.comment = this.RT3Reader.readRT3String((int)(guidaChamperardRecords3.strPtr - guidaChamperardRecords2.strPtr));
								this.RT3Reader.BaseStream.Seek(position, SeekOrigin.Begin);
							}
							guidaChamperardRecords2 = guidaChamperardRecords;
							num3 += 1U;
						}
						this.RT3Reader.BaseStream.Seek((long)(unchecked((ulong)guidaChamperardRecords2.strPtr)), SeekOrigin.Begin);
						guidaChamperardRecords.comment = this.RT3Reader.readRT3String((int)(this.RT3Reader.BaseStream.Length - (long)(unchecked((ulong)guidaChamperardRecords.strPtr))));
					}
					catch (Exception ex)
					{
						uint num3;
						string message = string.Format("unable to load {0:G}, index {1:G}", this.FileName, num3);
						MyProject.Application.Log.WriteEntry(message);
						MyProject.Application.Log.WriteEntry(ex.StackTrace);
						throw new Exception(message);
					}
					finally
					{
						this.RT3Reader.Close();
					}
					MyProject.Application.Log.WriteEntry(string.Format("{0:G} loaded : {1:G} entries", this.FileName, this.recordNumber));
				}
			}
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00128650 File Offset: 0x00127650
		public GUIDA_CHAMPERARD_POI.GuidaChamperardRecords getRecordByRT3Ptr(uint RT3Pointer)
		{
			bool flag = this.dict.ContainsKey(RT3Pointer);
			GUIDA_CHAMPERARD_POI.GuidaChamperardRecords result;
			if (flag)
			{
				result = this.dict[RT3Pointer];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00128688 File Offset: 0x00127688
		public void addRecord(POIDatas POIData)
		{
			GUIDA_CHAMPERARD_POI.GuidaChamperardRecords guidaChamperardRecords = new GUIDA_CHAMPERARD_POI.GuidaChamperardRecords();
			checked
			{
				this.recordNumber += 1U;
				guidaChamperardRecords.comment = POIData.commentRT3;
				guidaChamperardRecords.strPtr = this.nextStr;
				guidaChamperardRecords.FrancPOIDatPtr = POIData.franpoiPtr;
				this.dict.Add(guidaChamperardRecords.FrancPOIDatPtr, guidaChamperardRecords);
				this.nextStr += (uint)POIData.commentRT3.Length;
			}
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00128700 File Offset: 0x00127700
		public void writeToFile()
		{
			bool flag = this.dict.Count > 0;
			checked
			{
				if (flag)
				{
					this.RT3Writer = new RT3Writer(new FileStream(this.FileName, FileMode.Create, FileAccess.Write));
					this.RT3Writer.writeRT3(this.recordNumber);
					this.strOffset = 4U + 8U * this.recordNumber;
					Dictionary<uint, GUIDA_CHAMPERARD_POI.GuidaChamperardRecords>.KeyCollection keys = this.dict.Keys;
					try
					{
						foreach (uint key in keys)
						{
							GUIDA_CHAMPERARD_POI.GuidaChamperardRecords guidaChamperardRecords = this.dict[key];
							this.RT3Writer.writeRT3(guidaChamperardRecords.FrancPOIDatPtr);
							this.RT3Writer.writeRT3(guidaChamperardRecords.strPtr + this.strOffset);
						}
					}
					finally
					{
						Dictionary<uint, GUIDA_CHAMPERARD_POI.GuidaChamperardRecords>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					try
					{
						foreach (uint key2 in keys)
						{
							GUIDA_CHAMPERARD_POI.GuidaChamperardRecords guidaChamperardRecords = this.dict[key2];
							this.RT3Writer.writeRT3Str(ref guidaChamperardRecords.comment);
						}
					}
					finally
					{
						Dictionary<uint, GUIDA_CHAMPERARD_POI.GuidaChamperardRecords>.KeyCollection.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00128848 File Offset: 0x00127848
		public void close()
		{
			bool flag = this.fmode == GUIDA_CHAMPERARD_POI.mode.read;
			if (flag)
			{
				this.RT3Reader.Close();
			}
			else
			{
				flag = (this.fmode == GUIDA_CHAMPERARD_POI.mode.write);
				if (flag)
				{
					bool flag2 = this.RT3Writer != null;
					if (flag2)
					{
						this.RT3Writer.Close();
					}
				}
			}
		}

		// Token: 0x0400072F RID: 1839
		public const int RECORDSIZE = 8;

		// Token: 0x04000730 RID: 1840
		public const ushort TABRECORD_OFFSET = 4;

		// Token: 0x04000731 RID: 1841
		private const uint INITIALSIZE = 4096U;

		// Token: 0x04000732 RID: 1842
		private GUIDA_CHAMPERARD_POI.mode fmode;

		// Token: 0x04000733 RID: 1843
		private string FileName;

		// Token: 0x04000734 RID: 1844
		private RT3Reader RT3Reader;

		// Token: 0x04000735 RID: 1845
		private RT3Writer RT3Writer;

		// Token: 0x04000736 RID: 1846
		private Dictionary<uint, GUIDA_CHAMPERARD_POI.GuidaChamperardRecords> dict;

		// Token: 0x04000737 RID: 1847
		private uint recordNumber;

		// Token: 0x04000738 RID: 1848
		private uint nextStr;

		// Token: 0x04000739 RID: 1849
		private uint strOffset;

		// Token: 0x020000AC RID: 172
		public class GuidaChamperardRecords
		{
			// Token: 0x06000DCE RID: 3534 RVA: 0x001288A0 File Offset: 0x001278A0
			[DebuggerNonUserCode]
			public GuidaChamperardRecords()
			{
			}

			// Token: 0x0400073A RID: 1850
			public uint FrancPOIDatPtr;

			// Token: 0x0400073B RID: 1851
			public uint strPtr;

			// Token: 0x0400073C RID: 1852
			public string comment;
		}

		// Token: 0x020000AD RID: 173
		public enum mode
		{
			// Token: 0x0400073E RID: 1854
			read,
			// Token: 0x0400073F RID: 1855
			write,
			// Token: 0x04000740 RID: 1856
			none
		}
	}
}
