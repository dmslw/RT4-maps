using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x020000D1 RID: 209
	public class ZZZCOM_IND
	{
		// Token: 0x06000E56 RID: 3670 RVA: 0x0012FF74 File Offset: 0x0012EF74
		public ZZZCOM_IND(string filePath, byte country, byte area, byte dpt, Common.RTxMapType mapType, string countryMap, ZZZCOM_IND.mode mode)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.RT3Writer = null;
			this.countryMap = countryMap;
			this.mapType = mapType;
			this.fMode = mode;
			this.shortFileName = ZZZCOM_IND.getShortFileName(country, area, dpt, mapType, countryMap);
			this.FileName = Path.Combine(filePath, this.shortFileName);
			this.data = new Dictionary<uint, ZZZCOM_IND.FrancZZZComIndRecords>();
			bool flag = mode == ZZZCOM_IND.mode.read;
			if (flag)
			{
				this.fileStream = new FileStream(this.FileName, FileMode.Open, FileAccess.Read);
				this.RT3Reader = new RT3Reader(this.fileStream);
			}
			else
			{
				this.fileStream = new FileStream(this.FileName, FileMode.Open, FileAccess.ReadWrite);
				this.RT3Writer = new RT3Writer(this.fileStream);
				this.RT3Reader = new RT3Reader(this.fileStream);
				this.fileSize = this.RT3Writer.BaseStream.Length;
			}
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00130064 File Offset: 0x0012F064
		public ZZZCOM_IND(string fileName2Read, string fileName2Write)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.RT3Writer = null;
			this.data = new Dictionary<uint, ZZZCOM_IND.FrancZZZComIndRecords>();
			this.RT3Reader = new RT3Reader(new FileStream(fileName2Read, FileMode.Open, FileAccess.Read));
			this.RT3Writer = new RT3Writer(new FileStream(fileName2Write, FileMode.Create, FileAccess.Write));
			this.loadFromFile();
			this.writeTemplate();
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x001300D0 File Offset: 0x0012F0D0
		public string loadFromFile()
		{
			checked
			{
				try
				{
					this.RT3Reader.BaseStream.Seek(0L, SeekOrigin.Begin);
					long length = this.RT3Reader.BaseStream.Length;
					bool flag = length % 52L != 0L;
					if (flag)
					{
						throw new Exception(string.Format(Resources.strErrIncFileLength, this.FileName, length));
					}
					uint num = (uint)(length / 52L);
					uint num2 = 1U;
					uint num3 = num;
					uint num4 = num2;
					for (;;)
					{
						uint num5 = num4;
						uint num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						ZZZCOM_IND.FrancZZZComIndRecords francZZZComIndRecords = new ZZZCOM_IND.FrancZZZComIndRecords();
						ZZZCOM_IND.FrancZZZComIndRecords francZZZComIndRecords2 = francZZZComIndRecords;
						francZZZComIndRecords2.city = this.RT3Reader.readRT3Uint16();
						francZZZComIndRecords2.district = this.RT3Reader.readRT3Uint16();
						francZZZComIndRecords2.idxLZWZZZ_TOP = this.RT3Reader.readRT3Uint32();
						francZZZComIndRecords2.idxZZZTOP_LET = this.RT3Reader.readRT3Uint32();
						francZZZComIndRecords2.FRANCSEM_DSCIdx = this.RT3Reader.readRT3Uint32();
						francZZZComIndRecords2.FRANCSAF_DSCIdx = this.RT3Reader.readRT3Uint32();
						francZZZComIndRecords2.FRANCSHR_DSCIdx = this.RT3Reader.readRT3Uint32();
						francZZZComIndRecords2.FRANCSTU_DSCIdx = this.RT3Reader.readRT3Uint32();
						francZZZComIndRecords2.FRANCSSH_DSCIdx = this.RT3Reader.readRT3Uint32();
						francZZZComIndRecords2.FRANCSSP_DSCIdx = this.RT3Reader.readRT3Uint32();
						francZZZComIndRecords2.FRANCSTR_DSCIdx = this.RT3Reader.readRT3Uint32();
						francZZZComIndRecords2.FRANCSAU_DSCIdx = this.RT3Reader.readRT3Uint32();
						francZZZComIndRecords2.FRANCSCC_DSCIdx = this.RT3Reader.readRT3Uint32();
						francZZZComIndRecords2.FRANCMIC_DSCIdx = this.RT3Reader.readRT3Uint32();
						this.data.Add((uint)((int)francZZZComIndRecords2.city << 16 | (int)francZZZComIndRecords2.district), francZZZComIndRecords);
						num4 += 1U;
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
				finally
				{
					this.RT3Reader.BaseStream.Seek(0L, SeekOrigin.Begin);
					this.RT3Writer.Seek(0, SeekOrigin.Begin);
				}
				return this.shortFileName;
			}
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x001302FC File Offset: 0x0012F2FC
		public void writeToFile()
		{
			try
			{
				Dictionary<uint, ZZZCOM_IND.FrancZZZComIndRecords>.KeyCollection keys = this.data.Keys;
				try
				{
					foreach (uint key in keys)
					{
						ZZZCOM_IND.FrancZZZComIndRecords francZZZComIndRecords = this.data[key];
						ZZZCOM_IND.FrancZZZComIndRecords francZZZComIndRecords2 = francZZZComIndRecords;
						this.RT3Writer.writeRT3(francZZZComIndRecords2.city);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.district);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.idxLZWZZZ_TOP);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.idxZZZTOP_LET);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.FRANCSEM_DSCIdx);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.FRANCSAF_DSCIdx);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.FRANCSHR_DSCIdx);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.FRANCSTU_DSCIdx);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.FRANCSSH_DSCIdx);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.FRANCSSP_DSCIdx);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.FRANCSTR_DSCIdx);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.FRANCSAU_DSCIdx);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.FRANCSCC_DSCIdx);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.FRANCMIC_DSCIdx);
					}
				}
				finally
				{
					Dictionary<uint, ZZZCOM_IND.FrancZZZComIndRecords>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				this.RT3Writer.Close();
			}
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x001304DC File Offset: 0x0012F4DC
		private void writeTemplate()
		{
			try
			{
				Dictionary<uint, ZZZCOM_IND.FrancZZZComIndRecords>.KeyCollection keys = this.data.Keys;
				try
				{
					foreach (uint key in keys)
					{
						ZZZCOM_IND.FrancZZZComIndRecords francZZZComIndRecords = this.data[key];
						ZZZCOM_IND.FrancZZZComIndRecords francZZZComIndRecords2 = francZZZComIndRecords;
						this.RT3Writer.writeRT3(francZZZComIndRecords2.city);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.district);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.idxLZWZZZ_TOP);
						this.RT3Writer.writeRT3(francZZZComIndRecords2.idxZZZTOP_LET);
						this.RT3Writer.writeRT3(uint.MaxValue);
						this.RT3Writer.writeRT3(uint.MaxValue);
						this.RT3Writer.writeRT3(uint.MaxValue);
						this.RT3Writer.writeRT3(uint.MaxValue);
						this.RT3Writer.writeRT3(uint.MaxValue);
						this.RT3Writer.writeRT3(uint.MaxValue);
						this.RT3Writer.writeRT3(uint.MaxValue);
						this.RT3Writer.writeRT3(uint.MaxValue);
						this.RT3Writer.writeRT3(uint.MaxValue);
						this.RT3Writer.writeRT3(uint.MaxValue);
					}
				}
				finally
				{
					Dictionary<uint, ZZZCOM_IND.FrancZZZComIndRecords>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				this.RT3Writer.Close();
			}
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00130680 File Offset: 0x0012F680
		public ZZZCOM_IND.FrancZZZComIndRecords updateRecord(ushort city, ushort district, bool cityChanged, POICategoryInfos POIcategoryInfo)
		{
			ZZZCOM_IND.FrancZZZComIndRecords result = null;
			uint num;
			bool flag;
			if (cityChanged)
			{
				num = (uint)((int)city << 16 | 65535);
				flag = this.data.ContainsKey(num);
				if (flag)
				{
					result = this.data[num];
				}
				num = ((num & 4294901760U) | (uint)district);
			}
			else
			{
				num = (uint)((int)city << 16 | (int)district);
			}
			flag = !this.data.ContainsKey(num);
			if (flag)
			{
				MyProject.Application.Log.WriteEntry(string.Format("Warning: updateRecord city {0:X} district {1:X} not found in {2:G}. Skipped", city, district, this.shortFileName));
			}
			else
			{
				ZZZCOM_IND.FrancZZZComIndRecords francZZZComIndRecords = this.data[num];
				ZZZCOM_IND.FrancZZZComIndRecords francZZZComIndRecords2 = francZZZComIndRecords;
				flag = ((ulong)POIcategoryInfo.getNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_MIN) != 0UL);
				if (flag)
				{
					francZZZComIndRecords2.FRANCSEM_DSCIdx = POIcategoryInfo.getOldIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_MIN);
				}
				flag = ((ulong)POIcategoryInfo.getNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_SAF) != 0UL);
				if (flag)
				{
					francZZZComIndRecords2.FRANCSAF_DSCIdx = POIcategoryInfo.getOldIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_SAF);
				}
				flag = ((ulong)POIcategoryInfo.getNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_SHR) != 0UL);
				if (flag)
				{
					francZZZComIndRecords2.FRANCSHR_DSCIdx = POIcategoryInfo.getOldIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_SHR);
				}
				flag = ((ulong)POIcategoryInfo.getNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_STU) != 0UL);
				if (flag)
				{
					francZZZComIndRecords2.FRANCSTU_DSCIdx = POIcategoryInfo.getOldIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_STU);
				}
				flag = ((ulong)POIcategoryInfo.getNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_SSH) != 0UL);
				if (flag)
				{
					francZZZComIndRecords2.FRANCSSH_DSCIdx = POIcategoryInfo.getOldIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_SSH);
				}
				flag = ((ulong)POIcategoryInfo.getNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_SSP) != 0UL);
				if (flag)
				{
					francZZZComIndRecords2.FRANCSSP_DSCIdx = POIcategoryInfo.getOldIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_SSP);
				}
				flag = ((ulong)POIcategoryInfo.getNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_STR) != 0UL);
				if (flag)
				{
					francZZZComIndRecords2.FRANCSTR_DSCIdx = POIcategoryInfo.getOldIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_STR);
				}
				flag = ((ulong)POIcategoryInfo.getNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_SAU) != 0UL);
				if (flag)
				{
					francZZZComIndRecords2.FRANCSAU_DSCIdx = POIcategoryInfo.getOldIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_SAU);
				}
			}
			return result;
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00130868 File Offset: 0x0012F868
		public ZZZCOM_IND.FrancZZZComIndRecords updateFFFFDistrict(ZZZCOM_IND.FrancZZZComIndRecords currentFFFFRecord, POICategoryInfos POIcategoryInfo)
		{
			bool flag = (ulong)POIcategoryInfo.getCityNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_MIN) != 0UL;
			if (flag)
			{
				currentFFFFRecord.FRANCSEM_DSCIdx = POIcategoryInfo.getOldCityIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_MIN);
			}
			flag = ((ulong)POIcategoryInfo.getCityNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_SAF) != 0UL);
			if (flag)
			{
				currentFFFFRecord.FRANCSAF_DSCIdx = POIcategoryInfo.getOldCityIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_SAF);
			}
			flag = ((ulong)POIcategoryInfo.getCityNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_SHR) != 0UL);
			if (flag)
			{
				currentFFFFRecord.FRANCSHR_DSCIdx = POIcategoryInfo.getOldCityIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_SHR);
			}
			flag = ((ulong)POIcategoryInfo.getCityNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_STU) != 0UL);
			if (flag)
			{
				currentFFFFRecord.FRANCSTU_DSCIdx = POIcategoryInfo.getOldCityIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_STU);
			}
			flag = ((ulong)POIcategoryInfo.getCityNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_SSH) != 0UL);
			if (flag)
			{
				currentFFFFRecord.FRANCSSH_DSCIdx = POIcategoryInfo.getOldCityIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_SSH);
			}
			flag = ((ulong)POIcategoryInfo.getCityNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_SSP) != 0UL);
			if (flag)
			{
				currentFFFFRecord.FRANCSSP_DSCIdx = POIcategoryInfo.getOldCityIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_SSP);
			}
			flag = ((ulong)POIcategoryInfo.getCityNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_STR) != 0UL);
			if (flag)
			{
				currentFFFFRecord.FRANCSTR_DSCIdx = POIcategoryInfo.getOldCityIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_STR);
			}
			flag = ((ulong)POIcategoryInfo.getCityNbPOIDSCPerCategory(POICategoryInfos.categories.CAT_SAU) != 0UL);
			if (flag)
			{
				currentFFFFRecord.FRANCSAU_DSCIdx = POIcategoryInfo.getOldCityIdxPOIDSCPerCategory(POICategoryInfos.categories.CAT_SAU);
			}
			return null;
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00130988 File Offset: 0x0012F988
		public void close()
		{
			bool flag = this.fMode == ZZZCOM_IND.mode.read;
			if (flag)
			{
				this.RT3Reader.Close();
			}
			else
			{
				this.RT3Reader.Close();
				this.RT3Writer.Close();
			}
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x001309CC File Offset: 0x0012F9CC
		public static string getShortFileName(byte country, byte area, byte dpt, Common.RTxMapType mapType, string countryMap)
		{
			bool flag = mapType == Common.RTxMapType.RT3;
			string result;
			if (flag)
			{
				result = string.Format("{0:d}_{1:G}\\IND\\{2:G}COM.IND", country, area.ToString("d2"), dpt.ToString("d3"));
			}
			else
			{
				result = string.Format("{0:G}\\{1:d}\\{2:G}_{3:G}\\IND\\{4:G}COM.IND", new object[]
				{
					"MAPPE",
					countryMap,
					country,
					area.ToString("d2"),
					dpt.ToString("d3")
				});
			}
			return result;
		}

		// Token: 0x0400093B RID: 2363
		public const int RECORDSIZE = 52;

		// Token: 0x0400093C RID: 2364
		public const int FIRSTIdxOFFSET = 12;

		// Token: 0x0400093D RID: 2365
		private string FileName;

		// Token: 0x0400093E RID: 2366
		private string shortFileName;

		// Token: 0x0400093F RID: 2367
		private FileStream fileStream;

		// Token: 0x04000940 RID: 2368
		private RT3Reader RT3Reader;

		// Token: 0x04000941 RID: 2369
		private RT3Writer RT3Writer;

		// Token: 0x04000942 RID: 2370
		private ZZZCOM_IND.mode fMode;

		// Token: 0x04000943 RID: 2371
		private long fileSize;

		// Token: 0x04000944 RID: 2372
		private Common.RTxMapType mapType;

		// Token: 0x04000945 RID: 2373
		private string countryMap;

		// Token: 0x04000946 RID: 2374
		private Dictionary<uint, ZZZCOM_IND.FrancZZZComIndRecords> data;

		// Token: 0x020000D2 RID: 210
		public class FrancZZZComIndRecords
		{
			// Token: 0x06000E5F RID: 3679 RVA: 0x00130A60 File Offset: 0x0012FA60
			[DebuggerNonUserCode]
			public FrancZZZComIndRecords()
			{
			}

			// Token: 0x04000947 RID: 2375
			public ushort city;

			// Token: 0x04000948 RID: 2376
			public ushort district;

			// Token: 0x04000949 RID: 2377
			public uint idxLZWZZZ_TOP;

			// Token: 0x0400094A RID: 2378
			public uint idxZZZTOP_LET;

			// Token: 0x0400094B RID: 2379
			public uint FRANCSEM_DSCIdx;

			// Token: 0x0400094C RID: 2380
			public uint FRANCSAF_DSCIdx;

			// Token: 0x0400094D RID: 2381
			public uint FRANCSHR_DSCIdx;

			// Token: 0x0400094E RID: 2382
			public uint FRANCSTU_DSCIdx;

			// Token: 0x0400094F RID: 2383
			public uint FRANCSSH_DSCIdx;

			// Token: 0x04000950 RID: 2384
			public uint FRANCSSP_DSCIdx;

			// Token: 0x04000951 RID: 2385
			public uint FRANCSTR_DSCIdx;

			// Token: 0x04000952 RID: 2386
			public uint FRANCSAU_DSCIdx;

			// Token: 0x04000953 RID: 2387
			public uint FRANCSCC_DSCIdx;

			// Token: 0x04000954 RID: 2388
			public uint FRANCMIC_DSCIdx;
		}

		// Token: 0x020000D3 RID: 211
		public enum mode
		{
			// Token: 0x04000956 RID: 2390
			read,
			// Token: 0x04000957 RID: 2391
			write
		}
	}
}
