using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualBasic;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x02000078 RID: 120
	public class buildSortedMapDicts
	{
		// Token: 0x06000D34 RID: 3380 RVA: 0x00120E58 File Offset: 0x0011FE58
		public buildSortedMapDicts(ListOfPOILists completeList, POITypeInfo POITypeInfo, ref bool result)
		{
			this.LSBPlaneCoord = 0U;
			this.lastLS = 0;
			this.lastMS = 0;
			this.lastSS = 0;
			this.LSBGeoCoord = 0;
			this.lastCountry = 0;
			this.lastArea = 0;
			this.lastDpt = 0;
			this.lastCity = 0;
			this.lastDistrict = 0;
			this.nextIdxInFrancPOIDAT = 1U;
			this.result = true;
			this.POITypeInfo = POITypeInfo;
			this.nextIdxInFrancPOIDAT = 1U;
			this.alphabeticDict = new SortedDictionary<string, buildSortedMapDicts.alphabeticValue>(StringComparer.Ordinal);
			this.planeCoordDict = new SortedDictionary<buildSortedMapDicts.key128bits, POIDatas>();
			try
			{
				foreach (POILists poilists in completeList)
				{
					poilists.ListofPOI.ForEach(new Action<POIDatas>(this.buildAphabeticDictFromPOIDatas));
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

		// Token: 0x06000D35 RID: 3381 RVA: 0x00120F48 File Offset: 0x0011FF48
		public void buildPlaneGeoDict(ListOfPOILists completeList)
		{
			this.geoCoordDict = new SortedDictionary<buildSortedMapDicts.key128bits, POIDatas>();
			try
			{
				foreach (POILists poilists in completeList)
				{
					poilists.ListofPOI.ForEach(new Action<POIDatas>(this.buildPlaneCoordDictFromPOIDatas));
					poilists.ListofPOI.ForEach(new Action<POIDatas>(this.buildGeoCoordDictFromPOIDatas));
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

		// Token: 0x06000D36 RID: 3382 RVA: 0x00120FD8 File Offset: 0x0011FFD8
		private void buildAphabeticDictFromPOIDatas(POIDatas POIData)
		{
			bool flag = POIData.type != 4444;
			if (flag)
			{
				try
				{
					foreach (POIDatas.POIAlias poialias in POIData.listOfCanonical)
					{
						bool flag2 = !this.alphabeticDict.ContainsKey(poialias.name);
						if (flag2)
						{
							buildSortedMapDicts.alphabeticValue value = new buildSortedMapDicts.alphabeticValue(poialias.idxName);
							this.alphabeticDict.Add(poialias.name, value);
						}
						poialias.alphabeticalEntry = this.alphabeticDict[poialias.name];
					}
				}
				finally
				{
					List<POIDatas.POIAlias>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (POIDatas.POIAlias poialias2 in POIData.listOfAlternates)
					{
						bool flag2 = !this.alphabeticDict.ContainsKey(poialias2.name);
						if (flag2)
						{
							buildSortedMapDicts.alphabeticValue value = new buildSortedMapDicts.alphabeticValue(poialias2.idxName);
							this.alphabeticDict.Add(poialias2.name, value);
						}
						poialias2.alphabeticalEntry = this.alphabeticDict[poialias2.name];
					}
				}
				finally
				{
					List<POIDatas.POIAlias>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00121130 File Offset: 0x00120130
		private void buildPlaneCoordDictFromPOIDatas(POIDatas POIData)
		{
			buildSortedMapDicts.key128bits key128bits = new buildSortedMapDicts.key128bits();
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
			key128bits.keyHigh = ((ulong)POIData.LS << 48 | (ulong)POIData.MS << 40 | (ulong)POIData.SS << 32 | checked(15UL - unchecked((ulong)POIData.magnitude)) << 28 | (ulong)this.POITypeInfo.getTypeOrder(POIData.type) << 20 | ((ulong)POIData.X & 1023UL) << 10 | ((ulong)POIData.Y & 1023UL));
			flag3 = (POIData.type == 4444);
			if (flag3)
			{
				key128bits.KeyLow = (0UL | ((ulong)this.LSBPlaneCoord & (ulong)-1));
			}
			else
			{
				key128bits.KeyLow = ((ulong)POIData.listOfCanonical[0].alphabeticalEntry.idxInNOMSERVDAT << 32 | ((ulong)this.LSBPlaneCoord & (ulong)-1));
			}
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

		// Token: 0x06000D38 RID: 3384 RVA: 0x00121454 File Offset: 0x00120454
		private void buildGeoCoordDictFromPOIDatas(POIDatas POIData)
		{
			bool flag = POIData.type != 4444;
			checked
			{
				if (flag)
				{
					byte b = 0;
					byte b2 = byte.MaxValue;
					try
					{
						foreach (POIDatas.POIAlias poialias in POIData.listOfCanonical)
						{
							this.addgeoCoordEntry(POIData, poialias, b, b2);
							b += 1;
						}
					}
					finally
					{
						List<POIDatas.POIAlias>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					b = byte.MaxValue;
					b2 = 0;
					try
					{
						foreach (POIDatas.POIAlias poialias2 in POIData.listOfAlternates)
						{
							this.addgeoCoordEntry(POIData, poialias2, b, b2);
							b2 += 1;
						}
					}
					finally
					{
						List<POIDatas.POIAlias>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0012153C File Offset: 0x0012053C
		private void addgeoCoordEntry(POIDatas POIData, POIDatas.POIAlias POIAlias, byte idxCan, byte idxAlt)
		{
			buildSortedMapDicts.key128bits key128bits = new buildSortedMapDicts.key128bits();
			bool flag = true;
			bool flag2;
			if (this.lastCity == POIAlias.city && this.lastDpt == POIAlias.dpt)
			{
				if (this.lastArea == POIAlias.area)
				{
					if (this.lastCountry == POIAlias.country)
					{
						if (this.lastDistrict == POIAlias.district)
						{
							flag2 = false;
							goto IL_5B;
						}
					}
				}
			}
			flag2 = true;
			IL_5B:
			bool flag3 = flag2;
			if (flag3)
			{
				this.LSBGeoCoord = 0;
				this.lastCountry = POIAlias.country;
				this.lastArea = POIAlias.area;
				this.lastDpt = POIAlias.dpt;
				this.lastCity = POIAlias.city;
				this.lastDistrict = POIAlias.district;
			}
			flag3 = (POIAlias.district == ushort.MaxValue);
			ushort num;
			if (flag3)
			{
				num = 0;
			}
			else
			{
				num = POIAlias.district;
			}
			key128bits.keyHigh = ((ulong)POIAlias.country << 56 | (ulong)POIAlias.area << 48 | (ulong)POIAlias.dpt << 40 | (ulong)POIAlias.city << 24 | (ulong)num << 8 | (ulong)this.POITypeInfo.getTypeOrder(POIAlias.typeFlagged & 49151));
			key128bits.KeyLow = ((ulong)POIAlias.alphabeticalEntry.idxInNOMSERVDAT << 32 | ((ulong)idxCan & 255UL) << 24 | ((ulong)idxAlt & 255UL) << 16 | ((ulong)this.LSBGeoCoord & 65535UL));
			while (flag)
			{
				flag3 = !this.geoCoordDict.ContainsKey(key128bits);
				if (flag3)
				{
					this.geoCoordDict.Add(key128bits, POIData);
					flag = false;
				}
				else
				{
					flag3 = ((ulong)this.LSBGeoCoord < 65535UL);
					if (!flag3)
					{
						Interaction.MsgBox(string.Format("Error: more than 65536 occurences of a POI at at the same location (country={0:X} area={1:X} dpt={2:X} city={3:X} district={4:X} type={5:X})", new object[]
						{
							POIAlias.country,
							POIAlias.area,
							POIAlias.dpt,
							POIAlias.city,
							POIAlias.district,
							POIAlias.typeFlagged
						}), MsgBoxStyle.Critical, null);
						MyProject.Application.Log.WriteEntry(string.Format("Error: more than 65536 occurences of a POI at at the same location (country={0:X} area={1:X} dpt={2:X} city={3:X} district={4:X} type={5:X})", new object[]
						{
							POIAlias.country,
							POIAlias.area,
							POIAlias.dpt,
							POIAlias.city,
							POIAlias.district,
							POIAlias.typeFlagged
						}));
						throw new Exception(string.Format("Error: more than 65536 occurences of a POI at at the same location (country={0:X} area={1:X} dpt={2:X} city={3:X} district={4:X} type={5:X})", new object[]
						{
							POIAlias.country,
							POIAlias.area,
							POIAlias.dpt,
							POIAlias.city,
							POIAlias.district,
							POIAlias.typeFlagged
						}));
					}
					this.LSBGeoCoord += 1;
					key128bits.KeyLow = ((key128bits.KeyLow & 18446744073709486080UL) | (ulong)this.LSBGeoCoord);
				}
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0012189C File Offset: 0x0012089C
		private uint _getnextIdxInFrancPOIDAT()
		{
			uint num = this.nextIdxInFrancPOIDAT;
			this.nextIdxInFrancPOIDAT = checked((uint)(unchecked((ulong)this.nextIdxInFrancPOIDAT) + 1UL));
			return num;
		}

		// Token: 0x040005B2 RID: 1458
		public SortedDictionary<string, buildSortedMapDicts.alphabeticValue> alphabeticDict;

		// Token: 0x040005B3 RID: 1459
		public SortedDictionary<buildSortedMapDicts.key128bits, POIDatas> planeCoordDict;

		// Token: 0x040005B4 RID: 1460
		public SortedDictionary<buildSortedMapDicts.key128bits, POIDatas> geoCoordDict;

		// Token: 0x040005B5 RID: 1461
		public const ulong MSK_CAN_IDX = 4278190080UL;

		// Token: 0x040005B6 RID: 1462
		public const int SHIFT_CAN_IDX = 24;

		// Token: 0x040005B7 RID: 1463
		public const ulong MSK_ALT_IDX = 16711680UL;

		// Token: 0x040005B8 RID: 1464
		public const int SHIFT_ALT_IDX = 16;

		// Token: 0x040005B9 RID: 1465
		public const ulong MSK_LSBGEOCOORDUL = 65535UL;

		// Token: 0x040005BA RID: 1466
		public const ulong MSK_NOT_LSBGEOCOORDUL = 18446744073709486080UL;

		// Token: 0x040005BB RID: 1467
		public const ulong MSK_LSBGEOCOORDUI = 65535UL;

		// Token: 0x040005BC RID: 1468
		public const ulong MSK_LSBPLANECOORDUL = 4294967295UL;

		// Token: 0x040005BD RID: 1469
		public const ulong MSK_NOT_LSBPLANECOORDUL = 18446744069414584320UL;

		// Token: 0x040005BE RID: 1470
		public const ulong MSK_LSBPLANECOORDUI = 4294967295UL;

		// Token: 0x040005BF RID: 1471
		private uint LSBPlaneCoord;

		// Token: 0x040005C0 RID: 1472
		private ushort lastLS;

		// Token: 0x040005C1 RID: 1473
		private byte lastMS;

		// Token: 0x040005C2 RID: 1474
		private byte lastSS;

		// Token: 0x040005C3 RID: 1475
		private ushort LSBGeoCoord;

		// Token: 0x040005C4 RID: 1476
		private byte lastCountry;

		// Token: 0x040005C5 RID: 1477
		private byte lastArea;

		// Token: 0x040005C6 RID: 1478
		private byte lastDpt;

		// Token: 0x040005C7 RID: 1479
		private ushort lastCity;

		// Token: 0x040005C8 RID: 1480
		private ushort lastDistrict;

		// Token: 0x040005C9 RID: 1481
		private uint nextIdxInFrancPOIDAT;

		// Token: 0x040005CA RID: 1482
		private POITypeInfo POITypeInfo;

		// Token: 0x040005CB RID: 1483
		private bool result;

		// Token: 0x02000079 RID: 121
		public class alphabeticValue
		{
			// Token: 0x06000D3B RID: 3387 RVA: 0x001218C4 File Offset: 0x001208C4
			public alphabeticValue(byte idxName)
			{
				this.idxName = idxName;
			}

			// Token: 0x040005CC RID: 1484
			public byte idxName;

			// Token: 0x040005CD RID: 1485
			public uint idxInNOMSERVDAT;
		}

		// Token: 0x0200007A RID: 122
		public class key128bits : IComparable<buildSortedMapDicts.key128bits>
		{
			// Token: 0x06000D3C RID: 3388 RVA: 0x001218D8 File Offset: 0x001208D8
			[DebuggerNonUserCode]
			public key128bits()
			{
			}

			// Token: 0x06000D3D RID: 3389 RVA: 0x001218E4 File Offset: 0x001208E4
			public int CompareTo(buildSortedMapDicts.key128bits other)
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

			// Token: 0x040005CE RID: 1486
			public ulong keyHigh;

			// Token: 0x040005CF RID: 1487
			public ulong KeyLow;
		}
	}
}
