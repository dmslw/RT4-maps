using System;
using System.Diagnostics;
using System.IO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x020000B9 RID: 185
	public class RADAR_LZW
	{
		// Token: 0x06000E12 RID: 3602 RVA: 0x0012C204 File Offset: 0x0012B204
		public RADAR_LZW(string fileName2Write)
		{
			this.FileNameToWrite = null;
			this.RTxWriter = null;
			this._idx = 0U;
			this.FileNameToWrite = fileName2Write;
			this.fMode = RADAR_LZW.mode.write;
			bool flag = MyProject.Computer.FileSystem.FileExists(fileName2Write);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(fileName2Write);
			}
			this.RTxWriter = new RT4Writer(new FileStream(fileName2Write, FileMode.Create, FileAccess.Write));
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0012C278 File Offset: 0x0012B278
		public uint addRecord(POIDatas POIData)
		{
			this.RTxWriter.writeRT3(POIData.SS);
			this.RTxWriter.writeRT3(POIData.MS);
			this.RTxWriter.writeLS(POIData.LS);
			checked
			{
				this.RTxWriter.writeRT3(1000 * (ushort)(POIData.SS % 16) + POIData.X);
				this.RTxWriter.writeRT3(1000 * (ushort)(POIData.SS / 16) + POIData.Y);
				this.RTxWriter.writeRT3((POIData.speed * 2048U & 524287U) | ((uint)Math.Round(unchecked(POIData.angle * 17.430555555555557)) << 19 & 4294443008U));
				this.RTxWriter.writeRT3(ref POIData.listOfCanonical[0].name, 41);
				this.RTxWriter.writeRT3(ref POIData.listOfCanonical[0].name, 68);
				RT3Writer rtxWriter = this.RTxWriter;
				string strRT4AlertCopyright = Resources.strRT4AlertCopyright;
				rtxWriter.writeRT3(ref strRT4AlertCopyright, 120);
				this._idx += 1U;
				return this._idx;
			}
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0012C3B0 File Offset: 0x0012B3B0
		public void close(bool compress, bool remove)
		{
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

		// Token: 0x04000851 RID: 2129
		public const int RECORDSIZE = 241;

		// Token: 0x04000852 RID: 2130
		public const int NAMESIZE = 41;

		// Token: 0x04000853 RID: 2131
		public const int ROADSIZE = 68;

		// Token: 0x04000854 RID: 2132
		public const int CITYSIZE = 120;

		// Token: 0x04000855 RID: 2133
		public const uint MSK_SPEED = 524287U;

		// Token: 0x04000856 RID: 2134
		public const uint MSK_ANGLE = 4294443008U;

		// Token: 0x04000857 RID: 2135
		public const uint SPEED_UNIT = 2048U;

		// Token: 0x04000858 RID: 2136
		public const double ANGLE_UNIT = 17.430555555555557;

		// Token: 0x04000859 RID: 2137
		private string FileNameToWrite;

		// Token: 0x0400085A RID: 2138
		private RT4Writer RTxWriter;

		// Token: 0x0400085B RID: 2139
		private RADAR_LZW.mode fMode;

		// Token: 0x0400085C RID: 2140
		private uint _idx;

		// Token: 0x020000BA RID: 186
		public class RadarLzwRecords
		{
			// Token: 0x06000E15 RID: 3605 RVA: 0x0012C480 File Offset: 0x0012B480
			[DebuggerNonUserCode]
			public RadarLzwRecords()
			{
			}

			// Token: 0x0400085D RID: 2141
			public byte SS;

			// Token: 0x0400085E RID: 2142
			public byte MS;

			// Token: 0x0400085F RID: 2143
			public ushort LS;

			// Token: 0x04000860 RID: 2144
			public ushort ExtX;

			// Token: 0x04000861 RID: 2145
			public ushort ExtY;

			// Token: 0x04000862 RID: 2146
			public uint speedAngle;

			// Token: 0x04000863 RID: 2147
			public string name;

			// Token: 0x04000864 RID: 2148
			public string road;

			// Token: 0x04000865 RID: 2149
			public string city;
		}

		// Token: 0x020000BB RID: 187
		public enum mode
		{
			// Token: 0x04000867 RID: 2151
			read,
			// Token: 0x04000868 RID: 2152
			write
		}

		// Token: 0x020000BC RID: 188
		public enum CoordChange
		{
			// Token: 0x0400086A RID: 2154
			noChange,
			// Token: 0x0400086B RID: 2155
			SSChange,
			// Token: 0x0400086C RID: 2156
			LSMSSSChange
		}
	}
}
