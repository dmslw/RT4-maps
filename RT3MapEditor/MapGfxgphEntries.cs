using System;
using System.Collections.Generic;

namespace RT3MapEditor
{
	// Token: 0x02000070 RID: 112
	public class MapGfxgphEntries
	{
		// Token: 0x06000D12 RID: 3346 RVA: 0x0011F018 File Offset: 0x0011E018
		public MapGfxgphEntries(RT3Reader RT3Reader, MapGfxgphHeaders header)
		{
			this.data = new List<MapGfxgphEntry>();
			this.loadFromFile(RT3Reader, header);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0011F038 File Offset: 0x0011E038
		private void loadFromFile(RT3Reader RT3Reader, MapGfxgphHeaders header)
		{
			this.lastPosUsed = MapGfxgphEntry.firstDataAddr(header);
			uint num = 0U;
			checked
			{
				uint num2 = header.recordNb - 1U;
				uint num3 = num;
				for (;;)
				{
					uint num4 = num3;
					uint num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					MapGfxgphEntry item = new MapGfxgphEntry(RT3Reader, header, num3, ref this.lastPosUsed);
					this.data.Add(item);
					num3 += 1U;
				}
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0011F088 File Offset: 0x0011E088
		public void saveEntriesAsFiles(string strPath)
		{
			int num = 0;
			checked
			{
				int num2 = this.data.Count - 1;
				int num3 = num;
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					MapGfxgphEntry mapGfxgphEntry = this.data[num3];
					mapGfxgphEntry.saveEntryAsFile(strPath, num3);
					num3++;
				}
			}
		}

		// Token: 0x04000559 RID: 1369
		private List<MapGfxgphEntry> data;

		// Token: 0x0400055A RID: 1370
		private long lastPosUsed;
	}
}
