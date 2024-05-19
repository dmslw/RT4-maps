using System;
using System.Collections.Generic;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x020000C0 RID: 192
	public class RADAR_PS_LZW
	{
		// Token: 0x06000E1A RID: 3610 RVA: 0x0012C788 File Offset: 0x0012B788
		public RADAR_PS_LZW(string fileName2Write, uint LSNb)
		{
			this.FileNameToWrite = null;
			this.RTxWriter = null;
			this.FileNameToWrite = fileName2Write;
			this.fMode = RADAR_PS_LZW.mode.write;
			bool flag = MyProject.Computer.FileSystem.FileExists(fileName2Write);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(fileName2Write);
			}
			this.RTxWriter = new RT4Writer(new FileStream(fileName2Write, FileMode.Create, FileAccess.Write));
			this.itemDict = new SortedDictionary<uint, RADAR_PS_LZW.RadarPsLzwRecords>();
			uint num = 0U;
			checked
			{
				uint num2 = LSNb * 256U - 1U;
				uint num3 = num;
				for (;;)
				{
					uint num4 = num3;
					uint num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					RADAR_PS_LZW.RadarPsLzwRecords value = new RADAR_PS_LZW.RadarPsLzwRecords();
					this.itemDict.Add(num3, value);
					num3 += 1U;
				}
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0012C830 File Offset: 0x0012B830
		public void addOrUpdateEntry(ushort LS, byte MS, uint idxInPE)
		{
			uint key = (uint)(checked(256 * LS + (ushort)MS));
			bool flag = (ulong)this.itemDict[key].idxInPE == 0UL;
			if (flag)
			{
				this.itemDict[key].idxInPE = idxInPE;
				this.itemDict[key].radarNb = 1;
			}
			else
			{
				RADAR_PS_LZW.RadarPsLzwRecords radarPsLzwRecords = this.itemDict[key];
				radarPsLzwRecords.radarNb += 1;
			}
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0012C8A8 File Offset: 0x0012B8A8
		public void close(bool compress, bool remove)
		{
			SortedDictionary<uint, RADAR_PS_LZW.RadarPsLzwRecords>.KeyCollection keys = this.itemDict.Keys;
			try
			{
				foreach (uint key in keys)
				{
					this.RTxWriter.writeRT3(this.itemDict[key].idxInPE);
					this.RTxWriter.writeRT3(this.itemDict[key].radarNb);
				}
			}
			finally
			{
				SortedDictionary<uint, RADAR_PS_LZW.RadarPsLzwRecords>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			long length = this.RTxWriter.BaseStream.Length;
			this.RTxWriter.Close();
			bool flag = compress && !remove;
			if (flag)
			{
				bool flag2 = length > 0L;
				if (flag2)
				{
					RT3LZW rt3LZW = new RT3LZW(this.FileNameToWrite, RT3LZW.mode.write, 929);
					MyProject.Computer.FileSystem.DeleteFile(this.FileNameToWrite);
					MyProject.Computer.FileSystem.RenameFile(this.FileNameToWrite + ".lzw", Path.GetFileName(this.FileNameToWrite));
				}
				else
				{
					MyProject.Computer.FileSystem.DeleteFile(this.FileNameToWrite);
				}
			}
			if (remove)
			{
				MyProject.Computer.FileSystem.DeleteFile(this.FileNameToWrite);
			}
		}

		// Token: 0x04000879 RID: 2169
		public const int RECORDSIZE = 6;

		// Token: 0x0400087A RID: 2170
		private string FileNameToWrite;

		// Token: 0x0400087B RID: 2171
		private RT4Writer RTxWriter;

		// Token: 0x0400087C RID: 2172
		private RADAR_PS_LZW.mode fMode;

		// Token: 0x0400087D RID: 2173
		private SortedDictionary<uint, RADAR_PS_LZW.RadarPsLzwRecords> itemDict;

		// Token: 0x020000C1 RID: 193
		public class RadarPsLzwRecords
		{
			// Token: 0x06000E1D RID: 3613 RVA: 0x0012CA08 File Offset: 0x0012BA08
			public RadarPsLzwRecords()
			{
				this.idxInPE = 0U;
				this.radarNb = 0;
			}

			// Token: 0x0400087E RID: 2174
			public uint idxInPE;

			// Token: 0x0400087F RID: 2175
			public ushort radarNb;
		}

		// Token: 0x020000C2 RID: 194
		public enum mode
		{
			// Token: 0x04000881 RID: 2177
			read,
			// Token: 0x04000882 RID: 2178
			write
		}
	}
}
