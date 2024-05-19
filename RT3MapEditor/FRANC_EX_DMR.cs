using System;
using System.Diagnostics;
using System.IO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000084 RID: 132
	public class FRANC_EX_DMR
	{
		// Token: 0x06000D69 RID: 3433 RVA: 0x00123F5C File Offset: 0x00122F5C
		public FRANC_EX_DMR(string fileName, FRANC_EX_DMR.mode mode, Common.RTxMapType mapType, uint recNumber)
		{
			this.FileName = null;
			this.mapType = Common.RTxMapType.oldRT3;
			this.RT3Reader = null;
			this.RT3Writer = null;
			this.FileName = fileName;
			this.mapType = mapType;
			this.fMode = mode;
			bool flag = mapType == Common.RTxMapType.RT3;
			if (flag)
			{
				this.recordNumber = recNumber;
				this.zeroPoi = 65534;
			}
			else
			{
				this.recordNumber = recNumber;
				this.zeroPoi = 0;
			}
			flag = (mode == FRANC_EX_DMR.mode.read);
			if (flag)
			{
				bool flag2 = !File.Exists(fileName + ".orig");
				if (flag2)
				{
					this.resetPOIInfo();
				}
				this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
			}
			else
			{
				this.RT3Writer = new RT3Writer(new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite));
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00124024 File Offset: 0x00123024
		private void resetPOIInfo()
		{
			RT3Reader rt3Reader = null;
			RT3Writer rt3Writer = null;
			string text = this.FileName + ".tmp";
			bool flag = MyProject.Computer.FileSystem.FileExists(text);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(text);
			}
			string file = this.FileName + ".orig";
			flag = MyProject.Computer.FileSystem.FileExists(file);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(file);
			}
			file = this.FileName + ".orig1";
			flag = MyProject.Computer.FileSystem.FileExists(file);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(file);
			}
			checked
			{
				try
				{
					rt3Reader = new RT3Reader(new FileStream(this.FileName, FileMode.Open, FileAccess.Read));
					long length = rt3Reader.BaseStream.Length;
					flag = (length != (long)(68UL * unchecked((ulong)this.recordNumber)));
					if (flag)
					{
						throw new Exception(string.Format(Resources.strErrIncFileLength, this.FileName, length));
					}
					rt3Writer = new RT3Writer(File.Open(text, FileMode.OpenOrCreate, FileAccess.Write));
					FRANC_EX_DMR.FrancExDmrRecords francExDmrRecords = new FRANC_EX_DMR.FrancExDmrRecords();
					FRANC_EX_DMR.FrancExDmrRecords francExDmrRecords2 = francExDmrRecords;
					francExDmrRecords2.FRANCSEM_DSTIdx = uint.MaxValue;
					francExDmrRecords2.FRANCSAF_DSTIdx = uint.MaxValue;
					francExDmrRecords2.FRANCSHR_DSTIdx = uint.MaxValue;
					francExDmrRecords2.FRANCSTU_DSTIdx = uint.MaxValue;
					francExDmrRecords2.FRANCSSH_DSTIdx = uint.MaxValue;
					francExDmrRecords2.FRANCSSP_DSTIdx = uint.MaxValue;
					francExDmrRecords2.FRANCSTR_DSTIdx = uint.MaxValue;
					francExDmrRecords2.FRANCSAU_DSTIdx = uint.MaxValue;
					francExDmrRecords2.FRANCSCC_DSTIdx = uint.MaxValue;
					francExDmrRecords2.FRANCMIC_DSTIdx = uint.MaxValue;
					francExDmrRecords2.POISEM_Nb = this.zeroPoi;
					francExDmrRecords2.POISAF_Nb = this.zeroPoi;
					francExDmrRecords2.POISHR_Nb = this.zeroPoi;
					francExDmrRecords2.POISTU_Nb = this.zeroPoi;
					francExDmrRecords2.POISSH_Nb = this.zeroPoi;
					francExDmrRecords2.POISSP_Nb = this.zeroPoi;
					francExDmrRecords2.POISTR_Nb = this.zeroPoi;
					francExDmrRecords2.POISAU_Nb = this.zeroPoi;
					francExDmrRecords2.POISCC_Nb = this.zeroPoi;
					francExDmrRecords2.POIMIC_Nb = this.zeroPoi;
					long num = 0L;
					long num2 = rt3Reader.BaseStream.Length / 68L - 1L;
					long num3 = num;
					for (;;)
					{
						long num4 = num3;
						long num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						long offset = num3 * 68L;
						rt3Reader.BaseStream.Seek(offset, SeekOrigin.Begin);
						FRANC_EX_DMR.FrancExDmrRecords francExDmrRecords3 = francExDmrRecords;
						francExDmrRecords3.FRANCEXRIDPtr = rt3Reader.readRT3Uint32();
						francExDmrRecords3.unknown1 = rt3Reader.readRT3Uint16();
						francExDmrRecords3.unknown2 = rt3Reader.readRT3Uint16();
						rt3Writer.writeRT3(francExDmrRecords3.FRANCEXRIDPtr);
						rt3Writer.writeRT3(francExDmrRecords3.unknown1);
						rt3Writer.writeRT3(francExDmrRecords3.unknown2);
						rt3Writer.writeRT3(francExDmrRecords3.FRANCSEM_DSTIdx);
						rt3Writer.writeRT3(francExDmrRecords3.FRANCSAF_DSTIdx);
						rt3Writer.writeRT3(francExDmrRecords3.FRANCSHR_DSTIdx);
						rt3Writer.writeRT3(francExDmrRecords3.FRANCSTU_DSTIdx);
						rt3Writer.writeRT3(francExDmrRecords3.FRANCSSH_DSTIdx);
						rt3Writer.writeRT3(francExDmrRecords3.FRANCSSP_DSTIdx);
						rt3Writer.writeRT3(francExDmrRecords3.FRANCSTR_DSTIdx);
						rt3Writer.writeRT3(francExDmrRecords3.FRANCSAU_DSTIdx);
						rt3Writer.writeRT3(francExDmrRecords3.FRANCSCC_DSTIdx);
						rt3Writer.writeRT3(francExDmrRecords3.FRANCMIC_DSTIdx);
						rt3Writer.writeRT3(francExDmrRecords3.POISEM_Nb);
						rt3Writer.writeRT3(francExDmrRecords3.POISAF_Nb);
						rt3Writer.writeRT3(francExDmrRecords3.POISHR_Nb);
						rt3Writer.writeRT3(francExDmrRecords3.POISTU_Nb);
						rt3Writer.writeRT3(francExDmrRecords3.POISSH_Nb);
						rt3Writer.writeRT3(francExDmrRecords3.POISSP_Nb);
						rt3Writer.writeRT3(francExDmrRecords3.POISTR_Nb);
						rt3Writer.writeRT3(francExDmrRecords3.POISAU_Nb);
						rt3Writer.writeRT3(francExDmrRecords3.POISCC_Nb);
						rt3Writer.writeRT3(francExDmrRecords3.POIMIC_Nb);
						num3 += 1L;
					}
				}
				catch (Exception ex)
				{
					throw;
				}
				finally
				{
					rt3Reader.Close();
					rt3Writer.Close();
				}
				MyProject.Computer.FileSystem.RenameFile(this.FileName, Path.GetFileName(this.FileName) + ".orig1");
				MyProject.Computer.FileSystem.RenameFile(text, Path.GetFileName(this.FileName));
				MyProject.Computer.FileSystem.RenameFile(this.FileName + ".orig1", Path.GetFileName(this.FileName) + ".orig");
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x001244D0 File Offset: 0x001234D0
		public void updateRecord(ushort LS, POICategoryInfos POIcategoryInfo)
		{
			this.RT3Writer.Seek((int)(checked(LS * 68 + 8)), SeekOrigin.Begin);
			POICategoryInfos.categories categories = POICategoryInfos.categories.CAT_MIN;
			byte b;
			byte b2;
			do
			{
				bool flag = POIcategoryInfo.getNbPOIDSTPerCategory(categories) == 0;
				if (flag)
				{
					this.RT3Writer.writeRT3(uint.MaxValue);
				}
				else
				{
					this.RT3Writer.writeRT3(POIcategoryInfo.getIdxPOIDSTPerCategory(categories));
				}
				categories += 1;
				b = (byte)categories;
				b2 = 9;
			}
			while (b <= b2);
			this.RT3Writer.Seek((int)(checked(LS * 68 + 48)), SeekOrigin.Begin);
			POICategoryInfos.categories categories2 = POICategoryInfos.categories.CAT_MIN;
			byte b3;
			do
			{
				bool flag = POIcategoryInfo.getNbPOIDSTPerCategory(categories2) == 0;
				if (flag)
				{
					this.RT3Writer.writeRT3(this.zeroPoi);
				}
				else
				{
					this.RT3Writer.writeRT3(POIcategoryInfo.getNbPOIDSTPerCategory(categories2));
				}
				categories2 += 1;
				b3 = (byte)categories2;
				b2 = 9;
			}
			while (b3 <= b2);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00124590 File Offset: 0x00123590
		public void close()
		{
			bool flag = this.fMode == FRANC_EX_DMR.mode.read;
			if (flag)
			{
				this.RT3Reader.Close();
			}
			else
			{
				this.RT3Writer.Close();
			}
		}

		// Token: 0x04000624 RID: 1572
		public const int RECORDSIZE = 68;

		// Token: 0x04000625 RID: 1573
		public const int RT3RECORDNUMBER = 216;

		// Token: 0x04000626 RID: 1574
		public const int FIRSTIdxOFFSET = 8;

		// Token: 0x04000627 RID: 1575
		public const int FIRSTNbOFFSET = 48;

		// Token: 0x04000628 RID: 1576
		private string FileName;

		// Token: 0x04000629 RID: 1577
		private Common.RTxMapType mapType;

		// Token: 0x0400062A RID: 1578
		private RT3Reader RT3Reader;

		// Token: 0x0400062B RID: 1579
		private RT3Writer RT3Writer;

		// Token: 0x0400062C RID: 1580
		private FRANC_EX_DMR.mode fMode;

		// Token: 0x0400062D RID: 1581
		private uint recordNumber;

		// Token: 0x0400062E RID: 1582
		private ushort zeroPoi;

		// Token: 0x02000085 RID: 133
		public class FrancExDmrRecords
		{
			// Token: 0x06000D6D RID: 3437 RVA: 0x001245C8 File Offset: 0x001235C8
			[DebuggerNonUserCode]
			public FrancExDmrRecords()
			{
			}

			// Token: 0x0400062F RID: 1583
			public uint FRANCEXRIDPtr;

			// Token: 0x04000630 RID: 1584
			public ushort unknown1;

			// Token: 0x04000631 RID: 1585
			public ushort unknown2;

			// Token: 0x04000632 RID: 1586
			public uint FRANCSEM_DSTIdx;

			// Token: 0x04000633 RID: 1587
			public uint FRANCSAF_DSTIdx;

			// Token: 0x04000634 RID: 1588
			public uint FRANCSHR_DSTIdx;

			// Token: 0x04000635 RID: 1589
			public uint FRANCSTU_DSTIdx;

			// Token: 0x04000636 RID: 1590
			public uint FRANCSSH_DSTIdx;

			// Token: 0x04000637 RID: 1591
			public uint FRANCSSP_DSTIdx;

			// Token: 0x04000638 RID: 1592
			public uint FRANCSTR_DSTIdx;

			// Token: 0x04000639 RID: 1593
			public uint FRANCSAU_DSTIdx;

			// Token: 0x0400063A RID: 1594
			public uint FRANCSCC_DSTIdx;

			// Token: 0x0400063B RID: 1595
			public uint FRANCMIC_DSTIdx;

			// Token: 0x0400063C RID: 1596
			public ushort POISEM_Nb;

			// Token: 0x0400063D RID: 1597
			public ushort POISAF_Nb;

			// Token: 0x0400063E RID: 1598
			public ushort POISHR_Nb;

			// Token: 0x0400063F RID: 1599
			public ushort POISTU_Nb;

			// Token: 0x04000640 RID: 1600
			public ushort POISSH_Nb;

			// Token: 0x04000641 RID: 1601
			public ushort POISSP_Nb;

			// Token: 0x04000642 RID: 1602
			public ushort POISTR_Nb;

			// Token: 0x04000643 RID: 1603
			public ushort POISAU_Nb;

			// Token: 0x04000644 RID: 1604
			public ushort POISCC_Nb;

			// Token: 0x04000645 RID: 1605
			public ushort POIMIC_Nb;
		}

		// Token: 0x02000086 RID: 134
		public enum mode
		{
			// Token: 0x04000647 RID: 1607
			read,
			// Token: 0x04000648 RID: 1608
			write
		}
	}
}
