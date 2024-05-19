using System;
using System.Collections.Generic;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x020000BD RID: 189
	public class RADAR_PE_LZW
	{
		// Token: 0x06000E16 RID: 3606 RVA: 0x0012C48C File Offset: 0x0012B48C
		public RADAR_PE_LZW(string fileName2Write)
		{
			this.FileNameToWrite = null;
			this.RTxWriter = null;
			this._nextIndex = 1U;
			this.FileNameToWrite = fileName2Write;
			this.fMode = RADAR_PE_LZW.mode.write;
			bool flag = MyProject.Computer.FileSystem.FileExists(fileName2Write);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(fileName2Write);
			}
			this.RTxWriter = new RT4Writer(new FileStream(fileName2Write, FileMode.Create, FileAccess.Write));
			this.itemDict = new SortedDictionary<uint, RADAR_PE_LZW.RadarPeLzwRecords>();
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0012C50C File Offset: 0x0012B50C
		public uint addOrUpdateEntry(ushort LS, byte MS, ushort SS, uint idxInRadar)
		{
			uint key;
			bool flag;
			checked
			{
				uint num = 65536U * (uint)LS + 256U * (uint)MS;
				key = num + (uint)SS;
				flag = !this.itemDict.ContainsKey(num);
				if (flag)
				{
					uint num2 = 0U;
					uint num3;
					uint num4;
					do
					{
						RADAR_PE_LZW.RadarPeLzwRecords radarPeLzwRecords = new RADAR_PE_LZW.RadarPeLzwRecords();
						radarPeLzwRecords.idx = this._nextIndex;
						this.itemDict.Add(num + num2, radarPeLzwRecords);
						num2 += 1U;
						num3 = num2;
						num4 = 255U;
					}
					while (num3 <= num4);
					this._nextIndex += 1U;
				}
			}
			flag = ((ulong)this.itemDict[key].idxInRadar == 0UL);
			if (flag)
			{
				this.itemDict[key].idxInRadar = idxInRadar;
				this.itemDict[key].radarNb = 1;
			}
			else
			{
				RADAR_PE_LZW.RadarPeLzwRecords radarPeLzwRecords2 = this.itemDict[key];
				radarPeLzwRecords2.radarNb += 1;
			}
			return this.itemDict[key].idx;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0012C608 File Offset: 0x0012B608
		public void close(bool compress, bool remove)
		{
			SortedDictionary<uint, RADAR_PE_LZW.RadarPeLzwRecords>.KeyCollection keys = this.itemDict.Keys;
			try
			{
				foreach (uint key in keys)
				{
					this.RTxWriter.writeRT3(this.itemDict[key].idxInRadar);
					this.RTxWriter.writeRT3(this.itemDict[key].radarNb);
				}
			}
			finally
			{
				SortedDictionary<uint, RADAR_PE_LZW.RadarPeLzwRecords>.KeyCollection.Enumerator enumerator;
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

		// Token: 0x0400086D RID: 2157
		public const int RECORDSIZE = 6;

		// Token: 0x0400086E RID: 2158
		private string FileNameToWrite;

		// Token: 0x0400086F RID: 2159
		private RT4Writer RTxWriter;

		// Token: 0x04000870 RID: 2160
		private RADAR_PE_LZW.mode fMode;

		// Token: 0x04000871 RID: 2161
		private SortedDictionary<uint, RADAR_PE_LZW.RadarPeLzwRecords> itemDict;

		// Token: 0x04000872 RID: 2162
		private uint _nextIndex;

		// Token: 0x020000BE RID: 190
		public class RadarPeLzwRecords
		{
			// Token: 0x06000E19 RID: 3609 RVA: 0x0012C768 File Offset: 0x0012B768
			public RadarPeLzwRecords()
			{
				this.idxInRadar = 0U;
				this.radarNb = 0;
				this.idx = 0U;
			}

			// Token: 0x04000873 RID: 2163
			public uint idxInRadar;

			// Token: 0x04000874 RID: 2164
			public ushort radarNb;

			// Token: 0x04000875 RID: 2165
			public uint idx;
		}

		// Token: 0x020000BF RID: 191
		public enum mode
		{
			// Token: 0x04000877 RID: 2167
			read,
			// Token: 0x04000878 RID: 2168
			write
		}
	}
}
