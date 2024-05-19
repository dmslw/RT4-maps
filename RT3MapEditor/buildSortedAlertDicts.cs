using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualBasic;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x02000076 RID: 118
	public class buildSortedAlertDicts
	{
		// Token: 0x06000D30 RID: 3376 RVA: 0x00120A70 File Offset: 0x0011FA70
		public buildSortedAlertDicts(ListOfPOILists completeList, POITypeInfo POITypeInfo, ref bool result)
		{
			this.LSBPlaneCoord = 0U;
			this.lastLS = 0;
			this.lastMS = 0;
			this.lastSS = 0;
			this.result = true;
			this.POITypeInfo = POITypeInfo;
			this.planeCoordDict = new SortedDictionary<buildSortedAlertDicts.key128bits, POIDatas>();
			try
			{
				foreach (POILists poilists in completeList)
				{
					poilists.ListofPOI.ForEach(new Action<POIDatas>(this.buildPlaneCoordDictFromPOIDatas));
				}
			}
			finally
			{
				IEnumerator<POILists> enumerator;
				bool flag = enumerator != null;
				if (flag)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00120B18 File Offset: 0x0011FB18
		private void buildPlaneCoordDictFromPOIDatas(POIDatas POIData)
		{
			buildSortedAlertDicts.key128bits key128bits = new buildSortedAlertDicts.key128bits();
			bool flag = true;
			bool flag2;
			if (this.lastSS == POIData.SS && this.lastMS == POIData.MS)
			{
				if (this.lastLS == POIData.LS)
				{
					flag2 = false;
					goto IL_3B;
				}
			}
			flag2 = true;
			IL_3B:
			bool flag3 = flag2;
			if (flag3)
			{
				this.LSBPlaneCoord = 0U;
				this.lastLS = POIData.LS;
				this.lastMS = POIData.MS;
				this.lastSS = POIData.SS;
			}
			key128bits.keyHigh = ((ulong)POIData.LS << 48 | (ulong)POIData.MS << 40 | (ulong)POIData.SS << 32 | ((ulong)POIData.X & 1023UL) << 22 | (((ulong)POIData.Y & 1023UL) << 12 & (ulong)-13));
			key128bits.KeyLow = 0UL;
			while (flag)
			{
				flag3 = !this.planeCoordDict.ContainsKey(key128bits);
				if (flag3)
				{
					this.planeCoordDict.Add(key128bits, POIData);
					flag = false;
				}
				else
				{
					flag3 = ((ulong)this.LSBPlaneCoord < (ulong)-1);
					if (!flag3)
					{
						Interaction.MsgBox(string.Format("Error: more than 0xFFFFFFFF POI at the same location (LS={0:X} MS={1:X} SS={2:X} X={3:X} Y={4:X} type={5:X})", new object[]
						{
							POIData.LS,
							POIData.MS,
							POIData.SS,
							POIData.X,
							POIData.Y,
							POIData.type
						}), MsgBoxStyle.Critical, null);
						MyProject.Application.Log.WriteEntry(string.Format("Error: more than 0xFFFFFFFF POI at the same location (LS={0:X} MS={1:X} SS={2:X} X={3:X} Y={4:X} type={5:X})", new object[]
						{
							POIData.LS,
							POIData.MS,
							POIData.SS,
							POIData.X,
							POIData.Y,
							POIData.type
						}));
						throw new Exception(string.Format("Error: more than 0xFFFFFFFF POI at the same location (LS={0:X} MS={1:X} SS={2:X} X={3:X} Y={4:X} type={5:X})", new object[]
						{
							POIData.LS,
							POIData.MS,
							POIData.SS,
							POIData.X,
							POIData.Y,
							POIData.type
						}));
					}
					this.LSBPlaneCoord = checked((uint)(unchecked((ulong)this.LSBPlaneCoord) + 1UL));
					key128bits.KeyLow = ((key128bits.KeyLow & 18446744069414584320UL) | (ulong)this.LSBPlaneCoord);
				}
			}
		}

		// Token: 0x040005A6 RID: 1446
		public SortedDictionary<buildSortedAlertDicts.key128bits, POIDatas> planeCoordDict;

		// Token: 0x040005A7 RID: 1447
		public const ulong MSK_LSBPLANECOORDUL = 4294967295UL;

		// Token: 0x040005A8 RID: 1448
		public const ulong MSK_NOT_LSBPLANECOORDUL = 18446744069414584320UL;

		// Token: 0x040005A9 RID: 1449
		public const ulong MSK_LSBPLANECOORDUI = 4294967295UL;

		// Token: 0x040005AA RID: 1450
		private uint LSBPlaneCoord;

		// Token: 0x040005AB RID: 1451
		private ushort lastLS;

		// Token: 0x040005AC RID: 1452
		private byte lastMS;

		// Token: 0x040005AD RID: 1453
		private byte lastSS;

		// Token: 0x040005AE RID: 1454
		private POITypeInfo POITypeInfo;

		// Token: 0x040005AF RID: 1455
		private bool result;

		// Token: 0x02000077 RID: 119
		public class key128bits : IComparable<buildSortedAlertDicts.key128bits>
		{
			// Token: 0x06000D32 RID: 3378 RVA: 0x00120DD4 File Offset: 0x0011FDD4
			[DebuggerNonUserCode]
			public key128bits()
			{
			}

			// Token: 0x06000D33 RID: 3379 RVA: 0x00120DE0 File Offset: 0x0011FDE0
			public int CompareTo(buildSortedAlertDicts.key128bits other)
			{
				bool flag = this.keyHigh > other.keyHigh;
				int result;
				if (flag)
				{
					result = 1;
				}
				else
				{
					flag = (this.keyHigh < other.keyHigh);
					if (flag)
					{
						result = -1;
					}
					else
					{
						flag = (this.KeyLow > other.KeyLow);
						if (flag)
						{
							result = 1;
						}
						else
						{
							flag = (this.KeyLow < other.KeyLow);
							if (flag)
							{
								result = -1;
							}
							else
							{
								result = 0;
							}
						}
					}
				}
				return result;
			}

			// Token: 0x040005B0 RID: 1456
			public ulong keyHigh;

			// Token: 0x040005B1 RID: 1457
			public ulong KeyLow;
		}
	}
}
