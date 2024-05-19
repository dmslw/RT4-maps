using System;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x0200006F RID: 111
	public class MapGfxgph
	{
		// Token: 0x06000D0F RID: 3343 RVA: 0x0011EEF8 File Offset: 0x0011DEF8
		public MapGfxgph(string fileName)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.RT3Writer = null;
			this.FileName = fileName;
			bool flag = MyProject.Computer.FileSystem.FileExists(fileName);
			if (flag)
			{
				this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
			}
			else
			{
				this.FileName = null;
				MyProject.Forms.ContAbortErrBox.showError(string.Format("No {0:G} file found", fileName), false, false, true);
			}
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0011EF7C File Offset: 0x0011DF7C
		public void loadFromFile()
		{
			MyProject.Application.Log.WriteEntry(string.Format("loading {0:G}", this.FileName));
			this.header = new MapGfxgphHeaders(this.RT3Reader);
			this.entryList = new MapGfxgphEntries(this.RT3Reader, this.header);
			MyProject.Application.Log.WriteEntry(string.Format("{0:G} loaded : {1:G} entries", this.FileName, this.header.recordNb));
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0011F004 File Offset: 0x0011E004
		public void saveEntriesAsFiles(string strPath)
		{
			this.entryList.saveEntriesAsFiles(strPath);
		}

		// Token: 0x04000554 RID: 1364
		private string FileName;

		// Token: 0x04000555 RID: 1365
		private RT3Reader RT3Reader;

		// Token: 0x04000556 RID: 1366
		private RT3Writer RT3Writer;

		// Token: 0x04000557 RID: 1367
		private MapGfxgphHeaders header;

		// Token: 0x04000558 RID: 1368
		private MapGfxgphEntries entryList;
	}
}
