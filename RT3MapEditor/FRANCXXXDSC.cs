using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;

namespace RT3MapEditor
{
	// Token: 0x0200009F RID: 159
	public class FRANCXXXDSC
	{
		// Token: 0x06000DA6 RID: 3494 RVA: 0x00126E10 File Offset: 0x00125E10
		public FRANCXXXDSC(string fileName, FRANCXXXDSC.mode mode, Common.RTxMapType mapType)
		{
			this.fileName = null;
			this.fileName = fileName;
			this.fMode = mode;
			this.mapType = mapType;
			bool flag = mode == FRANCXXXDSC.mode.read;
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

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00126EB4 File Offset: 0x00125EB4
		public FRANCXXXDSC.FrancDSCDatItems getNextRecord()
		{
			bool flag = true;
			FRANCXXXDSC.FrancDSCDatItems francDSCDatItems = new FRANCXXXDSC.FrancDSCDatItems();
			try
			{
				FRANCXXXDSC.FrancDSCDatItems francDSCDatItems2 = francDSCDatItems;
				francDSCDatItems2.type = this.RTxReader.readPOIType();
				flag = false;
				francDSCDatItems2.country = this.RTxReader.ReadByte();
				francDSCDatItems2.area = this.RTxReader.ReadByte();
				francDSCDatItems2.department = this.RTxReader.ReadByte();
				francDSCDatItems2.city = this.RTxReader.readRT3Uint16();
				francDSCDatItems2.district = this.RTxReader.readRT3Uint16();
				francDSCDatItems2.FrancPOIPtr = this.RTxReader.readRT3Uint32();
				francDSCDatItems2.FrancNomServIdx = this.RTxReader.readRT3Uint32();
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
				francDSCDatItems = null;
			}
			catch (Exception ex2)
			{
				this.RTxReader.Close();
				throw;
			}
			return francDSCDatItems;
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00126FD4 File Offset: 0x00125FD4
		public uint writeRecord(POIDatas POIData, buildSortedMapDicts.key128bits key)
		{
			bool flag = (key.KeyLow & 16711680UL) == 16711680UL;
			if (flag)
			{
				int index = checked((int)((key.KeyLow & unchecked((ulong)-16777216)) >> 24));
				POIDatas.POIAlias poialias = POIData.listOfCanonical[index];
				this.RTxWriter.writePOIType(poialias.typeFlagged);
				this.RTxWriter.writeRT3(poialias.country);
				this.RTxWriter.writeRT3(poialias.area);
				this.RTxWriter.writeRT3(poialias.dpt);
				this.RTxWriter.writeRT3(poialias.city);
				this.RTxWriter.writeRT3(poialias.district);
				this.RTxWriter.writeRT3(POIData.franpoiPtr);
				this.RTxWriter.writeRT3(poialias.alphabeticalEntry.idxInNOMSERVDAT);
			}
			else
			{
				flag = ((key.KeyLow & (ulong)-16777216) == (ulong)-16777216);
				if (flag)
				{
					int index = checked((int)((key.KeyLow & 16711680UL) >> 16));
					POIDatas.POIAlias poialias2 = POIData.listOfAlternates[index];
					this.RTxWriter.writePOIType(poialias2.typeFlagged);
					this.RTxWriter.writeRT3(poialias2.country);
					this.RTxWriter.writeRT3(poialias2.area);
					this.RTxWriter.writeRT3(poialias2.dpt);
					this.RTxWriter.writeRT3(poialias2.city);
					this.RTxWriter.writeRT3(poialias2.district);
					this.RTxWriter.writeRT3(POIData.franpoiPtr);
					this.RTxWriter.writeRT3(poialias2.alphabeticalEntry.idxInNOMSERVDAT);
				}
			}
			uint result;
			return result;
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00127194 File Offset: 0x00126194
		public void close()
		{
			bool flag = this.fMode == FRANCXXXDSC.mode.read;
			if (flag)
			{
				this.RTxReader.Close();
			}
			else
			{
				this.RTxWriter.Close();
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x001271CC File Offset: 0x001261CC
		public bool _loadFromFile()
		{
			bool flag = true;
			bool flag2 = this.fileName.EndsWith("SCC.DSC") | this.fileName.EndsWith("MIC.DSC");
			bool result;
			if (flag2)
			{
				Interaction.MsgBox("Unexpected category type in " + this.fileName, MsgBoxStyle.Critical, null);
				result = false;
			}
			else
			{
				result = flag;
			}
			return result;
		}

		// Token: 0x040006E3 RID: 1763
		private string fileName;

		// Token: 0x040006E4 RID: 1764
		private RT3Reader RTxReader;

		// Token: 0x040006E5 RID: 1765
		private RT3Writer RTxWriter;

		// Token: 0x040006E6 RID: 1766
		private FRANCXXXDSC.mode fMode;

		// Token: 0x040006E7 RID: 1767
		private Common.RTxMapType mapType;

		// Token: 0x020000A0 RID: 160
		public class FrancDSCDatItems
		{
			// Token: 0x06000DAB RID: 3499 RVA: 0x00127224 File Offset: 0x00126224
			[DebuggerNonUserCode]
			public FrancDSCDatItems()
			{
			}

			// Token: 0x040006E8 RID: 1768
			public ushort type;

			// Token: 0x040006E9 RID: 1769
			public byte country;

			// Token: 0x040006EA RID: 1770
			public byte area;

			// Token: 0x040006EB RID: 1771
			public byte department;

			// Token: 0x040006EC RID: 1772
			public ushort city;

			// Token: 0x040006ED RID: 1773
			public ushort district;

			// Token: 0x040006EE RID: 1774
			public uint FrancPOIPtr;

			// Token: 0x040006EF RID: 1775
			public uint FrancNomServIdx;
		}

		// Token: 0x020000A1 RID: 161
		public enum mode
		{
			// Token: 0x040006F1 RID: 1777
			read,
			// Token: 0x040006F2 RID: 1778
			write
		}
	}
}
