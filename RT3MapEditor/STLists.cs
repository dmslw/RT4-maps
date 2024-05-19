using System;
using System.Collections.Generic;
using ICSharpCode.SharpZipLib.Zip;

namespace RT3MapEditor
{
	// Token: 0x020000D9 RID: 217
	public class STLists
	{
		// Token: 0x06000E6F RID: 3695 RVA: 0x00132B14 File Offset: 0x00131B14
		public STLists(string name, ushort POItype, byte magnitude)
		{
			this.displayName = name;
			this.POIType = POItype;
			this.magnitude = magnitude;
			this.listOfST = new List<STLists.STListsEntry>();
		}

		// Token: 0x040009DA RID: 2522
		public string displayName;

		// Token: 0x040009DB RID: 2523
		public List<STLists.STListsEntry> listOfST;

		// Token: 0x040009DC RID: 2524
		public ushort POIType;

		// Token: 0x040009DD RID: 2525
		public byte magnitude;

		// Token: 0x020000DA RID: 218
		public class STListsEntry
		{
			// Token: 0x06000E70 RID: 3696 RVA: 0x00132B40 File Offset: 0x00131B40
			public STListsEntry(ZipEntry zipEntry, STArchives.entryType entryType)
			{
				this.zipEntry = zipEntry;
				this.entryType = entryType;
			}

			// Token: 0x040009DE RID: 2526
			public ZipEntry zipEntry;

			// Token: 0x040009DF RID: 2527
			public STArchives.entryType entryType;
		}
	}
}
