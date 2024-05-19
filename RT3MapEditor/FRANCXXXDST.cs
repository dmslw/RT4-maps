using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;

namespace RT3MapEditor
{
	// Token: 0x020000A2 RID: 162
	public class FRANCXXXDST
	{
		// Token: 0x06000DAC RID: 3500 RVA: 0x00127230 File Offset: 0x00126230
		public FRANCXXXDST(string fileName, FRANCXXXDST.mode mode, Common.RTxMapType mapType)
		{
			this.fileName = null;
			this.fileName = fileName;
			this.fMode = mode;
			this.mapType = mapType;
			bool flag = mode == FRANCXXXDST.mode.read;
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

		// Token: 0x06000DAD RID: 3501 RVA: 0x001272D4 File Offset: 0x001262D4
		public FRANCXXXDST.FrancDSTDatItems getNextRecord()
		{
			FRANCXXXDST.FrancDSTDatItems francDSTDatItems = new FRANCXXXDST.FrancDSTDatItems();
			bool flag = true;
			try
			{
				FRANCXXXDST.FrancDSTDatItems francDSTDatItems2 = francDSTDatItems;
				francDSTDatItems2.type = this.RTxReader.readPOIType();
				flag = false;
				francDSTDatItems2.name = this.RTxReader.readRT3String(36);
				francDSTDatItems2.SS = this.RTxReader.ReadByte();
				francDSTDatItems2.MS = this.RTxReader.ReadByte();
				francDSTDatItems2.LS = this.RTxReader.readLS();
				francDSTDatItems2.X = this.RTxReader.readRT3Uint16();
				francDSTDatItems2.Y = this.RTxReader.readRT3Uint16();
				francDSTDatItems2.FrancPOIPtr = this.RTxReader.readRT3Uint32();
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
				francDSTDatItems = null;
			}
			catch (Exception ex2)
			{
				this.RTxReader.Close();
				throw;
			}
			return francDSTDatItems;
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x001273F8 File Offset: 0x001263F8
		public uint writeRecord(POIDatas POIData)
		{
			this.RTxWriter.writePOIType(POIData.type);
			bool flag = POIData.listOfCanonical.Count == 0;
			if (flag)
			{
				RT3Writer rtxWriter = this.RTxWriter;
				string text = "{..**..}";
				rtxWriter.writeRT3(ref text, 36);
			}
			else
			{
				this.RTxWriter.writeRT3(ref POIData.listOfCanonical[0].name, 36);
			}
			this.RTxWriter.writeRT3(POIData.SS);
			this.RTxWriter.writeRT3(POIData.MS);
			this.RTxWriter.writeLS(POIData.LS);
			this.RTxWriter.writeRT3(POIData.X);
			this.RTxWriter.writeRT3(POIData.Y);
			this.RTxWriter.writeRT3(POIData.franpoiPtr);
			uint result;
			return result;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x001274D4 File Offset: 0x001264D4
		public void close()
		{
			bool flag = this.fMode == FRANCXXXDST.mode.read;
			if (flag)
			{
				this.RTxReader.Close();
			}
			else
			{
				this.RTxWriter.Close();
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0012750C File Offset: 0x0012650C
		public bool _loadFromFile()
		{
			bool flag = true;
			bool flag2 = this.fileName.EndsWith("SCC.DST") | this.fileName.EndsWith("MIC.DST");
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

		// Token: 0x040006F3 RID: 1779
		public const int NAMESIZE = 36;

		// Token: 0x040006F4 RID: 1780
		private string fileName;

		// Token: 0x040006F5 RID: 1781
		private RT3Reader RTxReader;

		// Token: 0x040006F6 RID: 1782
		private RT3Writer RTxWriter;

		// Token: 0x040006F7 RID: 1783
		private FRANCXXXDST.mode fMode;

		// Token: 0x040006F8 RID: 1784
		private Common.RTxMapType mapType;

		// Token: 0x020000A3 RID: 163
		public class FrancDSTDatItems
		{
			// Token: 0x06000DB1 RID: 3505 RVA: 0x00127564 File Offset: 0x00126564
			[DebuggerNonUserCode]
			public FrancDSTDatItems()
			{
			}

			// Token: 0x040006F9 RID: 1785
			public ushort type;

			// Token: 0x040006FA RID: 1786
			public string name;

			// Token: 0x040006FB RID: 1787
			public byte SS;

			// Token: 0x040006FC RID: 1788
			public byte MS;

			// Token: 0x040006FD RID: 1789
			public ushort LS;

			// Token: 0x040006FE RID: 1790
			public ushort X;

			// Token: 0x040006FF RID: 1791
			public ushort Y;

			// Token: 0x04000700 RID: 1792
			public uint FrancPOIPtr;
		}

		// Token: 0x020000A4 RID: 164
		public enum mode
		{
			// Token: 0x04000702 RID: 1794
			read,
			// Token: 0x04000703 RID: 1795
			write
		}
	}
}
