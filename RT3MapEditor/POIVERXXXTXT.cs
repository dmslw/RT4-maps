using System;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x020000B5 RID: 181
	public class POIVERXXXTXT
	{
		// Token: 0x06000E09 RID: 3593 RVA: 0x0012B974 File Offset: 0x0012A974
		public POIVERXXXTXT(string fileName2Write, bool isRADAR, POICategoryInfos.categories category, byte type, string descr, string countryName)
		{
			this.FileNameToWrite = null;
			this.RTxWriter = null;
			DateTime now = DateTime.Now;
			this.FileNameToWrite = fileName2Write;
			this.isRADAR = isRADAR;
			this.category = (byte)category;
			this.type = type;
			this.fMode = POIVERXXXTXT.mode.write;
			bool flag = MyProject.Computer.FileSystem.FileExists(fileName2Write);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(fileName2Write);
			}
			this.RTxWriter = new StreamWriter(new FileStream(fileName2Write, FileMode.Create, FileAccess.Write), Common.RT3Encoding);
			this.RTxWriter.WriteLine("POI_PROVIDER:RTxMapEditor");
			this.RTxWriter.WriteLine(string.Format("POI_MACRO_CAT:{0:G}", POICategoryInfos.getCategoryName(category)));
			this.RTxWriter.WriteLine(string.Format("POI_CAT:{0:D}", type));
			this.RTxWriter.WriteLine(string.Format("DATA_POI:{0:G}", now.ToString("dd/MM/yyyy")));
			this.RTxWriter.WriteLine("NAME_ICON:");
			this.RTxWriter.WriteLine("NAME_SOUND:");
			this.RTxWriter.WriteLine(string.Format("DESCRIPTION:{0:G}", descr));
			if (isRADAR)
			{
				this.RTxWriter.WriteLine("PREFIX:RADAR");
			}
			else
			{
				this.RTxWriter.WriteLine("PREFIX:DANGERZ");
			}
			this.RTxWriter.WriteLine(string.Format("NAME_COUNTRY:{0:G}", countryName));
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0012BAEC File Offset: 0x0012AAEC
		public void close(bool remove)
		{
			this.RTxWriter.Close();
			if (remove)
			{
				MyProject.Computer.FileSystem.DeleteFile(this.FileNameToWrite);
			}
		}

		// Token: 0x04000840 RID: 2112
		private string FileNameToWrite;

		// Token: 0x04000841 RID: 2113
		private StreamWriter RTxWriter;

		// Token: 0x04000842 RID: 2114
		private POIVERXXXTXT.mode fMode;

		// Token: 0x04000843 RID: 2115
		private bool isRADAR;

		// Token: 0x04000844 RID: 2116
		private byte type;

		// Token: 0x04000845 RID: 2117
		private byte category;

		// Token: 0x020000B6 RID: 182
		public enum mode
		{
			// Token: 0x04000847 RID: 2119
			read,
			// Token: 0x04000848 RID: 2120
			write
		}
	}
}
