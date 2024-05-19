using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

namespace RT3MapEditor
{
	// Token: 0x02000040 RID: 64
	public class ListOfPOILists : BindingList<POILists>
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x001078B8 File Offset: 0x001068B8
		[DebuggerNonUserCode]
		public ListOfPOILists()
		{
			ArrayList _ENCList = ListOfPOILists.__ENCList;
			lock (_ENCList)
			{
				ListOfPOILists.__ENCList.Add(new WeakReference(this));
			}
		}

		// Token: 0x040003F4 RID: 1012
		private static ArrayList __ENCList = new ArrayList();
	}
}
