using System;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x020000C3 RID: 195
	public class RADARDSCLZW
	{
		// Token: 0x06000E1E RID: 3614 RVA: 0x0012CA20 File Offset: 0x0012BA20
		public RADARDSCLZW(string fileName2Write)
		{
			this.FileNameToWrite = null;
			this.RTxWriter = null;
			this.FileNameToWrite = fileName2Write;
			this.fMode = RADARDSCLZW.mode.write;
			bool flag = MyProject.Computer.FileSystem.FileExists(fileName2Write);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(fileName2Write);
			}
			this.RTxWriter = new RT4Writer(new FileStream(fileName2Write, FileMode.Create, FileAccess.Write));
			this.RTxWriter.Write(238);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0012CA9C File Offset: 0x0012BA9C
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

		// Token: 0x04000883 RID: 2179
		private const byte VALUE = 238;

		// Token: 0x04000884 RID: 2180
		private string FileNameToWrite;

		// Token: 0x04000885 RID: 2181
		private RT4Writer RTxWriter;

		// Token: 0x04000886 RID: 2182
		private RADARDSCLZW.mode fMode;

		// Token: 0x020000C4 RID: 196
		public enum mode
		{
			// Token: 0x04000888 RID: 2184
			read,
			// Token: 0x04000889 RID: 2185
			write
		}
	}
}
