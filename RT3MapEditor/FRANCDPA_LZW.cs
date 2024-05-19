using System;
using System.Diagnostics;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x02000090 RID: 144
	public class FRANCDPA_LZW
	{
		// Token: 0x06000D83 RID: 3459 RVA: 0x00125258 File Offset: 0x00124258
		public FRANCDPA_LZW(string fileName)
		{
			this.FileNameToRead = null;
			this.FileNameToWrite = null;
			this.RT3Reader = null;
			this.RT3Writer = null;
			this.FRANC_EX_DPS = null;
			this.newLSMS = 0;
			this.newLS = 0;
			this.newMS = 0;
			this.newSS = 0;
			this.record = null;
			this.nbRecords = 0;
			this.FileNameToRead = fileName;
			this.fMode = FRANCDPA_LZW.mode.read;
			bool flag = !File.Exists(fileName + ".orig");
			if (flag)
			{
				RT3LZW rt3LZW = new RT3LZW(fileName, RT3LZW.mode.read, 9290);
				MyProject.Computer.FileSystem.RenameFile(fileName, Path.GetFileName(fileName) + ".orig1");
				MyProject.Computer.FileSystem.RenameFile(fileName + ".exp", Path.GetFileName(fileName));
				MyProject.Computer.FileSystem.RenameFile(fileName + ".orig1", Path.GetFileName(fileName) + ".orig");
			}
			this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00125370 File Offset: 0x00124370
		public FRANCDPA_LZW(string fileName, string fileName2Write, FRANC_EX_DPS FRANC_EX_DPS)
		{
			this.FileNameToRead = null;
			this.FileNameToWrite = null;
			this.RT3Reader = null;
			this.RT3Writer = null;
			this.FRANC_EX_DPS = null;
			this.newLSMS = 0;
			this.newLS = 0;
			this.newMS = 0;
			this.newSS = 0;
			this.record = null;
			this.nbRecords = 0;
			this.FileNameToRead = fileName;
			this.FileNameToWrite = fileName2Write;
			this.FRANC_EX_DPS = FRANC_EX_DPS;
			this.fMode = FRANCDPA_LZW.mode.write;
			this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
			this.nbRecords = checked((int)Math.Round((double)this.RT3Reader.BaseStream.Length / 16.0));
			bool flag = MyProject.Computer.FileSystem.FileExists(fileName2Write);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(fileName2Write);
			}
			this.RT3Writer = new RT3Writer(new FileStream(fileName2Write, FileMode.Create, FileAccess.Write));
			this.nextFRANCDPA_LZWToPatch = uint.MaxValue;
			this.firstFRANCDPA_LZWToReset = 0U;
			this.record = new FRANCDPA_LZW.FrancDpaLzwRecords();
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0012547C File Offset: 0x0012447C
		public void update(ushort LS, byte MS, byte SS, uint idxPOIForThisSS, ushort PONbForThisSS)
		{
			FRANCDPA_LZW.FrancDpaLzwRecords francDpaLzwRecords = this.record;
			bool flag = this.nextFRANCDPA_LZWToPatch != uint.MaxValue;
			if (flag)
			{
				francDpaLzwRecords.FRANCDETDRSPtr = this.RT3Reader.readRT3Uint32();
				francDpaLzwRecords.FRANCDSPPOIIdx = this.RT3Reader.readRT3Uint32();
				francDpaLzwRecords.POINumber = this.RT3Reader.readRT3Uint16();
				francDpaLzwRecords.FRANCDEGPtr = this.RT3Reader.readRT3Uint32();
				francDpaLzwRecords.FRANCDEGRecNB = this.RT3Reader.readRT3Uint16();
				flag = (PONbForThisSS == 0);
				if (flag)
				{
					francDpaLzwRecords.FRANCDSPPOIIdx = 1073741823U;
					francDpaLzwRecords.POINumber = 0;
				}
				else
				{
					francDpaLzwRecords.FRANCDSPPOIIdx = (idxPOIForThisSS | (francDpaLzwRecords.FRANCDSPPOIIdx & 3221225472U));
					francDpaLzwRecords.POINumber = PONbForThisSS;
				}
				this.RT3Writer.writeRT3(francDpaLzwRecords.FRANCDETDRSPtr);
				this.RT3Writer.writeRT3(francDpaLzwRecords.FRANCDSPPOIIdx);
				this.RT3Writer.writeRT3(francDpaLzwRecords.POINumber);
				this.RT3Writer.writeRT3(francDpaLzwRecords.FRANCDEGPtr);
				this.RT3Writer.writeRT3(francDpaLzwRecords.FRANCDEGRecNB);
			}
			checked
			{
				this.nextFRANCDPA_LZWToPatch = MyProject.Forms.FormMain.mapMngt.FRANC_EX_DPS.getFRANCDPA_POIIdx((uint)((int)MS + ((int)LS << 8)), SS);
				while (this.firstFRANCDPA_LZWToReset != this.nextFRANCDPA_LZWToPatch & this.firstFRANCDPA_LZWToReset <= this.FRANC_EX_DPS.lastFRANCDPA_POIIdx)
				{
					francDpaLzwRecords.FRANCDETDRSPtr = this.RT3Reader.readRT3Uint32();
					francDpaLzwRecords.FRANCDSPPOIIdx = this.RT3Reader.readRT3Uint32();
					francDpaLzwRecords.POINumber = this.RT3Reader.readRT3Uint16();
					francDpaLzwRecords.FRANCDEGPtr = this.RT3Reader.readRT3Uint32();
					francDpaLzwRecords.FRANCDEGRecNB = this.RT3Reader.readRT3Uint16();
					francDpaLzwRecords.FRANCDSPPOIIdx = 1073741823U;
					francDpaLzwRecords.POINumber = 0;
					this.RT3Writer.writeRT3(francDpaLzwRecords.FRANCDETDRSPtr);
					this.RT3Writer.writeRT3(francDpaLzwRecords.FRANCDSPPOIIdx);
					this.RT3Writer.writeRT3(francDpaLzwRecords.POINumber);
					this.RT3Writer.writeRT3(francDpaLzwRecords.FRANCDEGPtr);
					this.RT3Writer.writeRT3(francDpaLzwRecords.FRANCDEGRecNB);
					this.firstFRANCDPA_LZWToReset += 1U;
				}
				this.firstFRANCDPA_LZWToReset = this.nextFRANCDPA_LZWToPatch + 1U;
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x001256CC File Offset: 0x001246CC
		public void copyUntilEnd()
		{
			checked
			{
				int i = (int)Math.Round((double)this.RT3Reader.BaseStream.Position / 16.0);
				FRANCDPA_LZW.FrancDpaLzwRecords francDpaLzwRecords = this.record;
				while (i < this.nbRecords)
				{
					francDpaLzwRecords.FRANCDETDRSPtr = this.RT3Reader.readRT3Uint32();
					francDpaLzwRecords.FRANCDSPPOIIdx = this.RT3Reader.readRT3Uint32();
					francDpaLzwRecords.POINumber = this.RT3Reader.readRT3Uint16();
					francDpaLzwRecords.FRANCDEGPtr = this.RT3Reader.readRT3Uint32();
					francDpaLzwRecords.FRANCDEGRecNB = this.RT3Reader.readRT3Uint16();
					this.RT3Writer.writeRT3(francDpaLzwRecords.FRANCDETDRSPtr);
					this.RT3Writer.writeRT3(francDpaLzwRecords.FRANCDSPPOIIdx);
					this.RT3Writer.writeRT3(francDpaLzwRecords.POINumber);
					this.RT3Writer.writeRT3(francDpaLzwRecords.FRANCDEGPtr);
					this.RT3Writer.writeRT3(francDpaLzwRecords.FRANCDEGRecNB);
					i++;
				}
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x001257D0 File Offset: 0x001247D0
		public void close(bool compress)
		{
			bool flag = this.fMode == FRANCDPA_LZW.mode.read;
			if (flag)
			{
				this.RT3Reader.Close();
			}
			else
			{
				this.RT3Writer.Close();
				this.RT3Reader.Close();
				if (compress)
				{
					RT3LZW rt3LZW = new RT3LZW(this.FileNameToWrite, RT3LZW.mode.write, 9290);
					MyProject.Computer.FileSystem.DeleteFile(this.FileNameToWrite);
					MyProject.Computer.FileSystem.RenameFile(this.FileNameToWrite + ".lzw", Path.GetFileName(this.FileNameToWrite));
				}
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00125870 File Offset: 0x00124870
		private void _resetPOIInfo()
		{
			byte[] array = new byte[17];
			BinaryReader binaryReader = new BinaryReader(new FileStream(this.FileNameToRead + ".exp", FileMode.Open, FileAccess.Read));
			string text = this.FileNameToRead + ".tmp";
			bool flag = MyProject.Computer.FileSystem.FileExists(text);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(text);
			}
			BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, FileMode.OpenOrCreate, FileAccess.Write));
			long num = 0L;
			checked
			{
				long num2 = binaryReader.BaseStream.Length / 16L - 1L;
				long num3 = num;
				for (;;)
				{
					long num4 = num3;
					long num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					array = binaryReader.ReadBytes(16);
					array[4] = (array[4] | 63);
					array[5] = byte.MaxValue;
					array[6] = byte.MaxValue;
					array[7] = byte.MaxValue;
					array[8] = 0;
					array[9] = 0;
					binaryWriter.Write(array);
					num3 += 1L;
				}
				binaryReader.Close();
				binaryWriter.Close();
				MyProject.Computer.FileSystem.RenameFile(this.FileNameToRead, Path.GetFileName(this.FileNameToRead) + ".orig1");
				MyProject.Computer.FileSystem.RenameFile(text, Path.GetFileName(this.FileNameToRead));
				MyProject.Computer.FileSystem.RenameFile(this.FileNameToRead + ".orig1", Path.GetFileName(this.FileNameToRead) + ".orig");
			}
		}

		// Token: 0x04000679 RID: 1657
		public const int RECORDSIZE = 16;

		// Token: 0x0400067A RID: 1658
		public const ushort IDXFRANSDSPPOI_OFFSET = 5;

		// Token: 0x0400067B RID: 1659
		private string FileNameToRead;

		// Token: 0x0400067C RID: 1660
		private string FileNameToWrite;

		// Token: 0x0400067D RID: 1661
		private RT3Reader RT3Reader;

		// Token: 0x0400067E RID: 1662
		private RT3Writer RT3Writer;

		// Token: 0x0400067F RID: 1663
		private FRANCDPA_LZW.mode fMode;

		// Token: 0x04000680 RID: 1664
		private FRANC_EX_DPS FRANC_EX_DPS;

		// Token: 0x04000681 RID: 1665
		private uint nextFRANCDPA_LZWToPatch;

		// Token: 0x04000682 RID: 1666
		private uint firstFRANCDPA_LZWToReset;

		// Token: 0x04000683 RID: 1667
		private ushort newLSMS;

		// Token: 0x04000684 RID: 1668
		private byte newLS;

		// Token: 0x04000685 RID: 1669
		private byte newMS;

		// Token: 0x04000686 RID: 1670
		private byte newSS;

		// Token: 0x04000687 RID: 1671
		private FRANCDPA_LZW.FrancDpaLzwRecords record;

		// Token: 0x04000688 RID: 1672
		private int nbRecords;

		// Token: 0x02000091 RID: 145
		public class FrancDpaLzwRecords
		{
			// Token: 0x06000D89 RID: 3465 RVA: 0x001259E0 File Offset: 0x001249E0
			[DebuggerNonUserCode]
			public FrancDpaLzwRecords()
			{
			}

			// Token: 0x04000689 RID: 1673
			public uint FRANCDETDRSPtr;

			// Token: 0x0400068A RID: 1674
			public uint FRANCDSPPOIIdx;

			// Token: 0x0400068B RID: 1675
			public ushort POINumber;

			// Token: 0x0400068C RID: 1676
			public uint FRANCDEGPtr;

			// Token: 0x0400068D RID: 1677
			public ushort FRANCDEGRecNB;
		}

		// Token: 0x02000092 RID: 146
		public enum mode
		{
			// Token: 0x0400068F RID: 1679
			read,
			// Token: 0x04000690 RID: 1680
			write
		}
	}
}
