using System;
using System.IO;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x02000072 RID: 114
	public class MapGfxgphHeaders
	{
		// Token: 0x06000D1B RID: 3355 RVA: 0x0011F53C File Offset: 0x0011E53C
		public MapGfxgphHeaders(RT3Reader RT3Reader)
		{
			this.nameStr = new byte[17];
			this.fmtStr = new byte[9];
			this.oEncoder = new ASCIIEncoding();
			this.loadFromFile(RT3Reader);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0011F574 File Offset: 0x0011E574
		private void loadFromFile(RT3Reader RT3Reader)
		{
			RT3Reader.BaseStream.Seek(0L, SeekOrigin.Begin);
			this.nameStr = RT3Reader.ReadBytes(16);
			bool flag = Operators.CompareString(this.oEncoder.GetString(this.nameStr), "GDBF2000_navJOUR", false) != 0;
			if (flag)
			{
				MyProject.Forms.ContAbortErrBox.showError(string.Format("Unknown {0:G} value for header1 (header)", this.oEncoder.GetString(this.nameStr)), true, true, true);
			}
			this.fileID = RT3Reader.readRT3Uint32();
			flag = (this.fileID != 256U);
			if (flag)
			{
				MyProject.Forms.ContAbortErrBox.showError(string.Format("Unknown {0:X} value for FileID (header)", this.fileID), true, true, true);
			}
			this.unk1 = RT3Reader.readRT3Uint32();
			flag = (this.unk1 != 455546U);
			if (flag)
			{
				MyProject.Forms.ContAbortErrBox.showError(string.Format("Unknown {0:X} value for unk1 (header)", this.unk1), true, true, true);
			}
			this.fmtStr = RT3Reader.ReadBytes(8);
			flag = (Operators.CompareString(this.oEncoder.GetString(this.fmtStr), "RAWD2000", false) != 0);
			if (flag)
			{
				MyProject.Forms.ContAbortErrBox.showError(string.Format("Unknown {0:G} value for header2 (header)", this.oEncoder.GetString(this.fmtStr)), true, true, true);
			}
			this.unk2 = RT3Reader.readRT3Uint32();
			flag = (this.unk2 != 455540U);
			if (flag)
			{
				MyProject.Forms.ContAbortErrBox.showError(string.Format("Unknown {0:X} value for unk2 (header)", this.unk2), true, true, true);
			}
			this.unk3 = RT3Reader.readRT3Uint32();
			flag = (this.unk3 != 1U);
			if (flag)
			{
				MyProject.Forms.ContAbortErrBox.showError(string.Format("Unknown {0:X} value for unk3 (header)", this.unk3), true, true, true);
			}
			this.unk4 = RT3Reader.readRT3Uint32();
			flag = (this.unk4 != 0U);
			if (flag)
			{
				MyProject.Forms.ContAbortErrBox.showError(string.Format("Unknown {0:X} value for unk4 (header)", this.unk4), true, true, true);
			}
			this.unk5 = RT3Reader.readRT3Uint32();
			flag = (this.unk5 != 455533U);
			if (flag)
			{
				MyProject.Forms.ContAbortErrBox.showError(string.Format("Unknown {0:X} value for unk5 (header)", this.unk5), true, true, true);
			}
			this.unk6 = RT3Reader.readRT3Uint32();
			flag = (this.unk6 != 0U);
			if (flag)
			{
				MyProject.Forms.ContAbortErrBox.showError(string.Format("Unknown {0:X} value for unk6 (header)", this.unk6), true, true, true);
			}
			this.unk7 = RT3Reader.readRT3Uint32();
			flag = (this.unk7 != 0U);
			if (flag)
			{
				MyProject.Forms.ContAbortErrBox.showError(string.Format("Unknown {0:X} value for unk7 (header)", this.unk7), true, true, true);
			}
			this.size = RT3Reader.readRT3Uint32();
			flag = (RT3Reader.BaseStream.Length != (long)(checked(unchecked((ulong)this.size) + 64UL - 2UL)));
			if (flag)
			{
				MyProject.Forms.ContAbortErrBox.showError(string.Format("Incorrect size {0:X} (header)", this.size), true, true, true);
			}
			this.recordNb = RT3Reader.readRT3Uint32();
			flag = (this.recordNb != 6825U);
			if (flag)
			{
				MyProject.Forms.ContAbortErrBox.showError(string.Format("Incorrect record number {0:X} (header)", this.recordNb), true, true, true);
			}
		}

		// Token: 0x0400056A RID: 1386
		public const int HEADER_SIZE = 64;

		// Token: 0x0400056B RID: 1387
		private const int NAME_STR_SIZE = 16;

		// Token: 0x0400056C RID: 1388
		private const string NAME_STR_VALUE = "GDBF2000_navJOUR";

		// Token: 0x0400056D RID: 1389
		private const uint FILEID_VALUE = 256U;

		// Token: 0x0400056E RID: 1390
		private const int FMT_STR_SIZE = 8;

		// Token: 0x0400056F RID: 1391
		private const string FMT_STR_VALUE = "RAWD2000";

		// Token: 0x04000570 RID: 1392
		private const uint UNK1_VALUE = 455546U;

		// Token: 0x04000571 RID: 1393
		private const uint UNK2_VALUE = 455540U;

		// Token: 0x04000572 RID: 1394
		private const uint UNK3_VALUE = 1U;

		// Token: 0x04000573 RID: 1395
		private const uint UNK4_VALUE = 0U;

		// Token: 0x04000574 RID: 1396
		private const uint UNK5_VALUE = 455533U;

		// Token: 0x04000575 RID: 1397
		private const uint UNK6_VALUE = 0U;

		// Token: 0x04000576 RID: 1398
		private const uint UNK7_VALUE = 0U;

		// Token: 0x04000577 RID: 1399
		private const uint RECORDNB_VALUE = 6825U;

		// Token: 0x04000578 RID: 1400
		public byte[] nameStr;

		// Token: 0x04000579 RID: 1401
		public uint fileID;

		// Token: 0x0400057A RID: 1402
		public uint unk1;

		// Token: 0x0400057B RID: 1403
		public byte[] fmtStr;

		// Token: 0x0400057C RID: 1404
		public uint unk2;

		// Token: 0x0400057D RID: 1405
		public uint unk3;

		// Token: 0x0400057E RID: 1406
		public uint unk4;

		// Token: 0x0400057F RID: 1407
		public uint unk5;

		// Token: 0x04000580 RID: 1408
		public uint unk6;

		// Token: 0x04000581 RID: 1409
		public uint unk7;

		// Token: 0x04000582 RID: 1410
		public uint size;

		// Token: 0x04000583 RID: 1411
		public uint recordNb;

		// Token: 0x04000584 RID: 1412
		private ASCIIEncoding oEncoder;
	}
}
