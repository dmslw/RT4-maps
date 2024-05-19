using System;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x020000B3 RID: 179
	public class POIVERPOI
	{
		// Token: 0x06000E07 RID: 3591 RVA: 0x0012B860 File Offset: 0x0012A860
		public POIVERPOI(string fileName2Write)
		{
			this.FileNameToWrite = null;
			this.RTxWriter = null;
			DateTime now = DateTime.Now;
			this.FileNameToWrite = fileName2Write;
			this.fMode = POIVERPOI.mode.write;
			bool flag = MyProject.Computer.FileSystem.FileExists(fileName2Write);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(fileName2Write);
			}
			this.RTxWriter = new StreamWriter(new FileStream(fileName2Write, FileMode.Create, FileAccess.Write), Common.RT3Encoding);
			this.RTxWriter.WriteLine("CONTINENT_ID:01");
			this.RTxWriter.WriteLine("CONTINENT_NAME:EUROPE");
			this.RTxWriter.WriteLine("CD_NAME:RTXMAPEDITOR_ALERT");
			this.RTxWriter.WriteLine("POI_PROVIDER:UNKNOWN");
			this.RTxWriter.WriteLine(string.Format("DATA_POI:{0:G}", now.ToString("dd/MM/yyyy")));
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0012B93C File Offset: 0x0012A93C
		public void close(bool remove)
		{
			this.RTxWriter.Close();
			if (remove)
			{
				MyProject.Computer.FileSystem.DeleteFile(this.FileNameToWrite);
			}
		}

		// Token: 0x0400083A RID: 2106
		private string FileNameToWrite;

		// Token: 0x0400083B RID: 2107
		private StreamWriter RTxWriter;

		// Token: 0x0400083C RID: 2108
		private POIVERPOI.mode fMode;

		// Token: 0x020000B4 RID: 180
		public enum mode
		{
			// Token: 0x0400083E RID: 2110
			read,
			// Token: 0x0400083F RID: 2111
			write
		}
	}
}
