using System;
using System.Diagnostics;
using System.IO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x0200008E RID: 142
	public class FRANCCOM_LET
	{
		// Token: 0x06000D81 RID: 3457 RVA: 0x00125034 File Offset: 0x00124034
		public FRANCCOM_LET(string fileName)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.FileName = fileName;
			checked
			{
				try
				{
					MyProject.Application.Log.WriteEntry("loading " + fileName, TraceEventType.Information);
					this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
					long length = this.RT3Reader.BaseStream.Length;
					bool flag = length % 20L != 0L;
					if (flag)
					{
						throw new Exception(string.Format(Resources.strErrIncFileLength, fileName, length));
					}
					int num = (int)Math.Round((double)length / 20.0);
					int num2 = 0;
					int num3 = num - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						FRANCCOM_LET.francComLetRecords francComLetRecords = new FRANCCOM_LET.francComLetRecords();
						FRANCCOM_LET.francComLetRecords francComLetRecords2 = francComLetRecords;
						francComLetRecords2.ptr = this.RT3Reader.readRT3Uint32();
						francComLetRecords2.strBeg = this.RT3Reader.readRT3String(11).TrimEnd(new char[]
						{
							'\0'
						});
						francComLetRecords2.idxDcnCat = this.RT3Reader.readRT3Uint32();
						francComLetRecords2.cityNb = this.RT3Reader.ReadByte();
						francComLetRecords2.idxRecord = num4;
						flag = !MyProject.Forms.FormMain.mapMngt.DCN_CAT.getRecordByIdx(francComLetRecords2.idxDcnCat).cityName.StartsWith(francComLetRecords2.strBeg);
						if (flag)
						{
							MyProject.Application.Log.WriteEntry(string.Format("idx incohérent : {0:X6}, {1:G11}", francComLetRecords2.idxDcnCat, francComLetRecords2.strBeg), TraceEventType.Information);
						}
						num4++;
					}
					MyProject.Application.Log.WriteEntry(fileName + " loaded", TraceEventType.Information);
				}
				catch (Exception ex)
				{
					throw;
				}
				finally
				{
					this.RT3Reader.Close();
				}
			}
		}

		// Token: 0x04000670 RID: 1648
		public const int RECORDSIZE = 20;

		// Token: 0x04000671 RID: 1649
		private const uint INITIALSIZE = 8192U;

		// Token: 0x04000672 RID: 1650
		private string FileName;

		// Token: 0x04000673 RID: 1651
		private RT3Reader RT3Reader;

		// Token: 0x0200008F RID: 143
		public class francComLetRecords
		{
			// Token: 0x06000D82 RID: 3458 RVA: 0x0012524C File Offset: 0x0012424C
			[DebuggerNonUserCode]
			public francComLetRecords()
			{
			}

			// Token: 0x04000674 RID: 1652
			public uint ptr;

			// Token: 0x04000675 RID: 1653
			public string strBeg;

			// Token: 0x04000676 RID: 1654
			public uint idxDcnCat;

			// Token: 0x04000677 RID: 1655
			public byte cityNb;

			// Token: 0x04000678 RID: 1656
			public int idxRecord;
		}
	}
}
