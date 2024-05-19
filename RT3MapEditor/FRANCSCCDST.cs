using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x02000099 RID: 153
	public class FRANCSCCDST
	{
		// Token: 0x06000D99 RID: 3481 RVA: 0x001264D4 File Offset: 0x001254D4
		public FRANCSCCDST(string fileName, FRANCSCCDST.mode mode, Common.RTxMapType mapType)
		{
			this.fileName = null;
			this.RTxReader = null;
			this.RTxWriter = null;
			this.fileName = fileName;
			this.fMode = mode;
			this.mapType = mapType;
			bool flag = mode == FRANCSCCDST.mode.read;
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

		// Token: 0x06000D9A RID: 3482 RVA: 0x00126584 File Offset: 0x00125584
		public FRANCSCCDST.FrancSCCDSTDatItems getNextRecord()
		{
			bool flag = true;
			FRANCSCCDST.FrancSCCDSTDatItems francSCCDSTDatItems = new FRANCSCCDST.FrancSCCDSTDatItems();
			try
			{
				FRANCSCCDST.FrancSCCDSTDatItems francSCCDSTDatItems2 = francSCCDSTDatItems;
				francSCCDSTDatItems2.name = this.RTxReader.readRT3String(36);
				flag = false;
				francSCCDSTDatItems2.SS = this.RTxReader.ReadByte();
				francSCCDSTDatItems2.MS = this.RTxReader.ReadByte();
				francSCCDSTDatItems2.LS = this.RTxReader.readLS();
				francSCCDSTDatItems2.X = this.RTxReader.readRT3Uint16();
				francSCCDSTDatItems2.Y = this.RTxReader.readRT3Uint16();
				francSCCDSTDatItems2.magnitude = this.RTxReader.ReadByte();
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
				francSCCDSTDatItems = null;
			}
			catch (Exception ex2)
			{
				this.RTxReader.Close();
				throw;
			}
			return francSCCDSTDatItems;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00126694 File Offset: 0x00125694
		public uint writeRecord(POIDatas POIData)
		{
			bool flag = POIData.listOfCanonical.Count == 0;
			if (flag)
			{
				RT3Writer rtxWriter = this.RTxWriter;
				string text = "{..**..}";
				rtxWriter.writeRT3(ref text, 36);
			}
			else
			{
				flag = POIData.displayMagnitude;
				if (flag)
				{
					RT3Writer rtxWriter2 = this.RTxWriter;
					string text = POIData.listOfCanonical[0].name.Insert(0, Conversions.ToString(Strings.ChrW((int)(checked(48 + POIData.magnitude))))).TrimEnd(new char[]
					{
						'\0'
					});
					rtxWriter2.writeRT3(ref text, 36);
				}
				else
				{
					this.RTxWriter.writeRT3(ref POIData.listOfCanonical[0].name, 36);
				}
			}
			this.RTxWriter.writeRT3(POIData.SS);
			this.RTxWriter.writeRT3(POIData.MS);
			this.RTxWriter.writeLS(POIData.LS);
			this.RTxWriter.writeRT3(POIData.X);
			this.RTxWriter.writeRT3(POIData.Y);
			this.RTxWriter.writeRT3(POIData.magnitude);
			uint result;
			return result;
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x001267BC File Offset: 0x001257BC
		public void close()
		{
			bool flag = this.fMode == FRANCSCCDST.mode.read;
			if (flag)
			{
				this.RTxReader.Close();
			}
			else
			{
				this.RTxWriter.Close();
			}
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x001267F4 File Offset: 0x001257F4
		public bool _loadFromFile()
		{
			bool flag = true;
			bool flag2 = !this.fileName.EndsWith("SCC.DST");
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

		// Token: 0x040006BE RID: 1726
		public const int NAMESIZE = 36;

		// Token: 0x040006BF RID: 1727
		private string fileName;

		// Token: 0x040006C0 RID: 1728
		private RT3Reader RTxReader;

		// Token: 0x040006C1 RID: 1729
		private RT3Writer RTxWriter;

		// Token: 0x040006C2 RID: 1730
		private FRANCSCCDST.mode fMode;

		// Token: 0x040006C3 RID: 1731
		private Common.RTxMapType mapType;

		// Token: 0x0200009A RID: 154
		public class FrancSCCDSTDatItems
		{
			// Token: 0x06000D9E RID: 3486 RVA: 0x00126840 File Offset: 0x00125840
			[DebuggerNonUserCode]
			public FrancSCCDSTDatItems()
			{
			}

			// Token: 0x040006C4 RID: 1732
			public string name;

			// Token: 0x040006C5 RID: 1733
			public byte SS;

			// Token: 0x040006C6 RID: 1734
			public byte MS;

			// Token: 0x040006C7 RID: 1735
			public ushort LS;

			// Token: 0x040006C8 RID: 1736
			public ushort X;

			// Token: 0x040006C9 RID: 1737
			public ushort Y;

			// Token: 0x040006CA RID: 1738
			public byte magnitude;
		}

		// Token: 0x0200009B RID: 155
		public enum mode
		{
			// Token: 0x040006CC RID: 1740
			read,
			// Token: 0x040006CD RID: 1741
			write
		}
	}
}
