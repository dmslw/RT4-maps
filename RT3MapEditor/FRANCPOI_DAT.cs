using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x02000096 RID: 150
	public class FRANCPOI_DAT
	{
		// Token: 0x06000D90 RID: 3472 RVA: 0x00125CFC File Offset: 0x00124CFC
		public FRANCPOI_DAT(string fileName, FRANCPOI_DAT.mode mode, Common.RTxMapType mapType)
		{
			this.FileName = null;
			this.RTxReader = null;
			this.RTxWriter = null;
			this.NextRecordPointer = 1U;
			this.recordNumber = 0U;
			this.NextUnusedRecord = 0U;
			this.data = new Dictionary<uint, FRANCPOI_DAT.FrancPOIDatRecords>(350000);
			this.FileName = fileName;
			this.fMode = mode;
			this.mapType = mapType;
			bool flag = mapType == Common.RTxMapType.RT3;
			if (flag)
			{
				this.FIXEDRECORDLENGTH = 27;
			}
			else
			{
				this.FIXEDRECORDLENGTH = 28;
			}
			flag = (mode == FRANCPOI_DAT.mode.read);
			if (flag)
			{
				bool flag2 = mapType == Common.RTxMapType.RT3;
				if (flag2)
				{
					this.RTxReader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
				}
				else
				{
					this.RTxReader = new RT4Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
				}
			}
			else
			{
				bool flag2 = mapType == Common.RTxMapType.RT3;
				if (flag2)
				{
					this.RTxWriter = new RT3Writer(new FileStream(fileName, FileMode.Create, FileAccess.Write));
				}
				else
				{
					this.RTxWriter = new RT4Writer(new FileStream(fileName, FileMode.Create, FileAccess.Write));
				}
			}
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00125DF0 File Offset: 0x00124DF0
		public void loadFromFile()
		{
			bool flag = true;
			uint num = 0U;
			checked
			{
				try
				{
					MyProject.Application.Log.WriteEntry(string.Format("loading {0:G} ", this.FileName));
					for (;;)
					{
						FRANCPOI_DAT.FrancPOIDatRecords francPOIDatRecords = new FRANCPOI_DAT.FrancPOIDatRecords();
						num = (uint)(this.RTxReader.BaseStream.Position + 1L);
						FRANCPOI_DAT.FrancPOIDatRecords francPOIDatRecords2 = francPOIDatRecords;
						francPOIDatRecords2.address = this.RTxReader.readRT3String();
						flag = false;
						francPOIDatRecords2.SS = this.RTxReader.ReadByte();
						francPOIDatRecords2.MS = this.RTxReader.ReadByte();
						francPOIDatRecords2.LS = this.RTxReader.readLS();
						francPOIDatRecords2.type = this.RTxReader.readPOIType();
						francPOIDatRecords2.FrancNomServIdx = this.RTxReader.readRT3Uint32();
						francPOIDatRecords2.ScittaNamePtr = this.RTxReader.readRT3Uint32();
						francPOIDatRecords2.scale = this.RTxReader.ReadByte();
						francPOIDatRecords2.layer = this.RTxReader.ReadByte();
						francPOIDatRecords2.compound = this.RTxReader.readRT3Uint32();
						francPOIDatRecords2.tel = this.RTxReader.ReadUInt64();
						francPOIDatRecords2.brandIdx = (ushort)(francPOIDatRecords2.compound & 1023U);
						francPOIDatRecords2.X = (ushort)((francPOIDatRecords2.compound & 1047552U) >> 10);
						francPOIDatRecords2.Y = (ushort)((francPOIDatRecords2.compound & 1072693248U) >> 20);
						francPOIDatRecords2.francatFlag = (byte)((francPOIDatRecords2.compound & 3221225472U) >> 30);
						flag = true;
						this.data.Add(num, francPOIDatRecords);
						this.recordNumber = (uint)(unchecked((ulong)this.recordNumber) + 1UL);
					}
				}
				catch (EndOfStreamException ex)
				{
					bool flag2 = !flag;
					if (flag2)
					{
						string message = string.Format("unable to load {0:G}, ptr {1:G}, idx {2:G}", this.FileName, num, this.recordNumber);
						MyProject.Application.Log.WriteEntry(message);
						MyProject.Application.Log.WriteEntry(ex.StackTrace);
						throw new Exception(message);
					}
				}
				catch (Exception ex2)
				{
					string message2 = string.Format("unable to load {0:G}, ptr {1:G}, idx {2:G}", this.FileName, num, this.recordNumber);
					MyProject.Application.Log.WriteEntry(message2);
					MyProject.Application.Log.WriteEntry(ex2.StackTrace);
					throw new Exception(message2);
				}
				finally
				{
					this.RTxReader.Close();
				}
				MyProject.Application.Log.WriteEntry(string.Format("{0:G} loaded : {1:G} entries", this.FileName, this.recordNumber));
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x001260F8 File Offset: 0x001250F8
		public uint writeRecord(POIDatas POIData)
		{
			this.RTxWriter.writeRT3(ref POIData.addressRT3);
			this.RTxWriter.writeRT3(POIData.SS);
			this.RTxWriter.writeRT3(POIData.MS);
			this.RTxWriter.writeLS(POIData.LS);
			this.RTxWriter.writePOIType(POIData.type);
			this.RTxWriter.writeRT3(POIData.listOfCanonical[0].alphabeticalEntry.idxInNOMSERVDAT);
			this.RTxWriter.writeRT3(POIData.scittaPtr);
			this.RTxWriter.writeRT3(POIData.scale);
			this.RTxWriter.writeRT3(POIData.layer);
			this.RTxWriter.writeRT3(POIData.compound);
			this.RTxWriter.Write(POIData.telRT3);
			POIData.franpoiPtr = this.NextRecordPointer;
			this.NextRecordPointer = checked((uint)(unchecked((ulong)this.NextRecordPointer) + (ulong)(unchecked((long)this.FIXEDRECORDLENGTH)) + (ulong)(unchecked((long)POIData.addressRT3.Length))));
			uint result;
			return result;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00126210 File Offset: 0x00125210
		public void close()
		{
			bool flag = this.fMode == FRANCPOI_DAT.mode.read;
			if (flag)
			{
				this.RTxReader.Close();
			}
			else
			{
				this.RTxWriter.Close();
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00126248 File Offset: 0x00125248
		public FRANCPOI_DAT.FrancPOIDatRecords getRecordByRT3Ptr(uint RT3Pointer)
		{
			bool flag = this.data.ContainsKey(RT3Pointer);
			FRANCPOI_DAT.FrancPOIDatRecords result;
			if (flag)
			{
				result = this.data[RT3Pointer];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00126280 File Offset: 0x00125280
		public uint _addRecord(FRANCPOI_DAT.FrancPOIDatRecords newRecord)
		{
			newRecord.compound = (uint)((int)(newRecord.brandIdx & 1023) | (int)(newRecord.X & 1023) << 10 | (int)(newRecord.Y & 1023) << 20 | (int)(newRecord.francatFlag & 3) << 30);
			this.data.Add(this.NextRecordPointer, newRecord);
			uint nextRecordPointer = this.NextRecordPointer;
			checked
			{
				this.NextRecordPointer = (uint)(unchecked((ulong)this.NextRecordPointer) + 28UL + (ulong)(unchecked((long)newRecord.address.Length)));
				this.recordNumber = (uint)(unchecked((ulong)this.recordNumber) + 1UL);
				return nextRecordPointer;
			}
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0012631C File Offset: 0x0012531C
		public void _clear()
		{
			this.data = new Dictionary<uint, FRANCPOI_DAT.FrancPOIDatRecords>(350000);
			this.NextRecordPointer = 1U;
			this.recordNumber = 0U;
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00126340 File Offset: 0x00125340
		public bool _dumpToFile()
		{
			bool result = false;
			checked
			{
				try
				{
					uint num = 0U;
					uint num2 = (uint)(this.data.Count - 1);
					uint num3 = num;
					for (;;)
					{
						uint num4 = num3;
						uint num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						FRANCPOI_DAT.FrancPOIDatRecords francPOIDatRecords = this.data[num3];
						FRANCPOI_DAT.FrancPOIDatRecords francPOIDatRecords2 = francPOIDatRecords;
						this.RTxWriter.writeRT3(ref francPOIDatRecords2.address);
						this.RTxWriter.writeRT3(francPOIDatRecords2.SS);
						this.RTxWriter.writeRT3(francPOIDatRecords2.MS);
						this.RTxWriter.writeLS(francPOIDatRecords2.LS);
						this.RTxWriter.writePOIType(francPOIDatRecords2.type);
						this.RTxWriter.writeRT3(francPOIDatRecords2.FrancNomServIdx);
						this.RTxWriter.writeRT3(francPOIDatRecords2.ScittaNamePtr);
						this.RTxWriter.writeRT3(francPOIDatRecords2.scale);
						this.RTxWriter.writeRT3(francPOIDatRecords2.layer);
						this.RTxWriter.writeRT3(francPOIDatRecords2.compound);
						this.RTxWriter.Write(francPOIDatRecords2.tel);
						num3 += 1U;
					}
				}
				catch (Exception ex)
				{
					result = false;
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				}
				finally
				{
					this.RTxWriter.Close();
				}
				return result;
			}
		}

		// Token: 0x0400069F RID: 1695
		public const int RT3FIXEDRECORDLENGTH = 27;

		// Token: 0x040006A0 RID: 1696
		public const int RT4FIXEDRECORDLENGTH = 28;

		// Token: 0x040006A1 RID: 1697
		private const uint INITIALSIZE = 350000U;

		// Token: 0x040006A2 RID: 1698
		private string FileName;

		// Token: 0x040006A3 RID: 1699
		private RT3Reader RTxReader;

		// Token: 0x040006A4 RID: 1700
		private RT3Writer RTxWriter;

		// Token: 0x040006A5 RID: 1701
		private FRANCPOI_DAT.mode fMode;

		// Token: 0x040006A6 RID: 1702
		private Common.RTxMapType mapType;

		// Token: 0x040006A7 RID: 1703
		private int FIXEDRECORDLENGTH;

		// Token: 0x040006A8 RID: 1704
		private Dictionary<uint, FRANCPOI_DAT.FrancPOIDatRecords> data;

		// Token: 0x040006A9 RID: 1705
		private uint NextRecordPointer;

		// Token: 0x040006AA RID: 1706
		private uint recordNumber;

		// Token: 0x040006AB RID: 1707
		private uint NextUnusedRecord;

		// Token: 0x02000097 RID: 151
		public class FrancPOIDatRecords
		{
			// Token: 0x06000D98 RID: 3480 RVA: 0x001264C8 File Offset: 0x001254C8
			[DebuggerNonUserCode]
			public FrancPOIDatRecords()
			{
			}

			// Token: 0x040006AC RID: 1708
			public string address;

			// Token: 0x040006AD RID: 1709
			public byte SS;

			// Token: 0x040006AE RID: 1710
			public byte MS;

			// Token: 0x040006AF RID: 1711
			public ushort LS;

			// Token: 0x040006B0 RID: 1712
			public ushort type;

			// Token: 0x040006B1 RID: 1713
			public uint FrancNomServIdx;

			// Token: 0x040006B2 RID: 1714
			public uint ScittaNamePtr;

			// Token: 0x040006B3 RID: 1715
			public byte scale;

			// Token: 0x040006B4 RID: 1716
			public byte layer;

			// Token: 0x040006B5 RID: 1717
			public uint compound;

			// Token: 0x040006B6 RID: 1718
			public ushort X;

			// Token: 0x040006B7 RID: 1719
			public ushort Y;

			// Token: 0x040006B8 RID: 1720
			public ushort brandIdx;

			// Token: 0x040006B9 RID: 1721
			public byte francatFlag;

			// Token: 0x040006BA RID: 1722
			public ulong tel;
		}

		// Token: 0x02000098 RID: 152
		public enum mode
		{
			// Token: 0x040006BC RID: 1724
			read,
			// Token: 0x040006BD RID: 1725
			write
		}
	}
}
