using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace RT3MapEditor
{
	// Token: 0x02000093 RID: 147
	public class FRANCDSP_POI
	{
		// Token: 0x06000D8A RID: 3466 RVA: 0x001259EC File Offset: 0x001249EC
		public FRANCDSP_POI(string fileName, FRANCDSP_POI.mode mode, Common.RTxMapType mapType)
		{
			this.fileName = null;
			this.fileName = fileName;
			this.fMode = mode;
			this.mapType = mapType;
			bool flag = mode == FRANCDSP_POI.mode.read;
			if (flag)
			{
				bool flag2 = mapType == Common.RTxMapType.RT3;
				if (flag2)
				{
					this.RTxReader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
				}
				else
				{
					this.RTxReader = new RT4Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
				}
			}
			else
			{
				bool flag2 = mapType == Common.RTxMapType.RT3;
				if (flag2)
				{
					this.RTxWriter = new RT3Writer(new FileStream(fileName, FileMode.Create, FileAccess.Write));
				}
				else
				{
					this.RTxWriter = new RT4Writer(new FileStream(fileName, FileMode.Create, FileAccess.Write));
				}
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00125A90 File Offset: 0x00124A90
		public FRANCDSP_POI.FrancDspPoiRecords getNextRecord()
		{
			bool flag = true;
			FRANCDSP_POI.FrancDspPoiRecords francDspPoiRecords = new FRANCDSP_POI.FrancDspPoiRecords();
			try
			{
				FRANCDSP_POI.FrancDspPoiRecords francDspPoiRecords2 = francDspPoiRecords;
				francDspPoiRecords2.type = this.RTxReader.readPOIType();
				flag = false;
				francDspPoiRecords2.extX = this.RTxReader.readRT3Uint16();
				francDspPoiRecords2.extY = this.RTxReader.readRT3Uint16();
				francDspPoiRecords2.FrancPOIPtr = this.RTxReader.readRT3Uint32();
				francDspPoiRecords2.scale = this.RTxReader.ReadByte();
				francDspPoiRecords2.layer = this.RTxReader.ReadByte();
				flag = true;
			}
			catch (EndOfStreamException ex)
			{
				bool flag2 = !flag;
				if (flag2)
				{
					this.RTxReader.Close();
					throw;
				}
				francDspPoiRecords = null;
			}
			catch (Exception ex2)
			{
				this.RTxReader.Close();
				throw;
			}
			return francDspPoiRecords;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00125B8C File Offset: 0x00124B8C
		public uint writeRecord(POIDatas POIData)
		{
			this.RTxWriter.writePOIType(POIData.type);
			checked
			{
				this.RTxWriter.writeRT3(1000 * (ushort)(POIData.SS % 16) + POIData.X);
				this.RTxWriter.writeRT3(1000 * (ushort)(POIData.SS / 16) + POIData.Y);
				this.RTxWriter.writeRT3(POIData.franpoiPtr);
				this.RTxWriter.writeRT3(POIData.scale);
				this.RTxWriter.writeRT3(POIData.layer);
				uint result;
				return result;
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00125C30 File Offset: 0x00124C30
		public void close()
		{
			bool flag = this.fMode == FRANCDSP_POI.mode.read;
			if (flag)
			{
				this.RTxReader.Close();
			}
			else
			{
				this.RTxWriter.Close();
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00125C68 File Offset: 0x00124C68
		public List<uint> getOrphanPOIList(SortedDictionary<uint, POIDatas> POIDict)
		{
			FRANCDSP_POI.FrancDspPoiRecords francDspPoiRecords = new FRANCDSP_POI.FrancDspPoiRecords();
			List<uint> list = new List<uint>();
			this.RTxReader.BaseStream.Seek(0L, SeekOrigin.Begin);
			for (francDspPoiRecords = this.getNextRecord(); francDspPoiRecords != null; francDspPoiRecords = this.getNextRecord())
			{
				FRANCDSP_POI.FrancDspPoiRecords francDspPoiRecords2 = francDspPoiRecords;
				bool flag = francDspPoiRecords2.type != 4444 && !POIDict.ContainsKey(francDspPoiRecords2.FrancPOIPtr);
				if (flag)
				{
					list.Add(francDspPoiRecords2.FrancPOIPtr);
				}
			}
			return list;
		}

		// Token: 0x04000691 RID: 1681
		private string fileName;

		// Token: 0x04000692 RID: 1682
		private RT3Reader RTxReader;

		// Token: 0x04000693 RID: 1683
		private RT3Writer RTxWriter;

		// Token: 0x04000694 RID: 1684
		private FRANCDSP_POI.mode fMode;

		// Token: 0x04000695 RID: 1685
		private Common.RTxMapType mapType;

		// Token: 0x02000094 RID: 148
		public class FrancDspPoiRecords
		{
			// Token: 0x06000D8F RID: 3471 RVA: 0x00125CF0 File Offset: 0x00124CF0
			[DebuggerNonUserCode]
			public FrancDspPoiRecords()
			{
			}

			// Token: 0x04000696 RID: 1686
			public ushort type;

			// Token: 0x04000697 RID: 1687
			public ushort extX;

			// Token: 0x04000698 RID: 1688
			public ushort extY;

			// Token: 0x04000699 RID: 1689
			public uint FrancPOIPtr;

			// Token: 0x0400069A RID: 1690
			public byte scale;

			// Token: 0x0400069B RID: 1691
			public byte layer;
		}

		// Token: 0x02000095 RID: 149
		public enum mode
		{
			// Token: 0x0400069D RID: 1693
			read,
			// Token: 0x0400069E RID: 1694
			write
		}
	}
}
