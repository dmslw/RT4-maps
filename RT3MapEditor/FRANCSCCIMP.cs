using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x0200009C RID: 156
	public class FRANCSCCIMP
	{
		// Token: 0x06000D9F RID: 3487 RVA: 0x0012684C File Offset: 0x0012584C
		public FRANCSCCIMP(string fileName, FRANCSCCIMP.mode mode, Common.RTxMapType mapType)
		{
			this.fileName = null;
			this.RTXReader = null;
			this.RTXWriter = null;
			this.mag4List = null;
			this.mag5List = null;
			this.mag6List = null;
			this.mag7List = null;
			this.mag8List = null;
			this.fileName = fileName;
			this.fMode = mode;
			this.mapType = mapType;
			this.mag4List = new List<POIDatas>();
			this.mag5List = new List<POIDatas>();
			this.mag6List = new List<POIDatas>();
			this.mag7List = new List<POIDatas>();
			this.mag8List = new List<POIDatas>();
			bool flag = mapType == Common.RTxMapType.RT3;
			if (flag)
			{
				bool flag2 = mode == FRANCSCCIMP.mode.read;
				if (flag2)
				{
					bool flag3 = mapType == Common.RTxMapType.RT3;
					if (flag3)
					{
						this.RTXReader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
					}
					else
					{
						this.RTXReader = new RT4Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
					}
				}
				else
				{
					bool flag3 = mapType == Common.RTxMapType.RT3;
					if (flag3)
					{
						this.RTXWriter = new RT3Writer(new FileStream(fileName, FileMode.Create, FileAccess.Write));
					}
					else
					{
						this.RTXWriter = new RT4Writer(new FileStream(fileName, FileMode.Create, FileAccess.Write));
					}
				}
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00126960 File Offset: 0x00125960
		public FRANCSCCIMP.FrancSCCIMPDatItems getNextRecord()
		{
			bool flag = true;
			FRANCSCCIMP.FrancSCCIMPDatItems francSCCIMPDatItems = new FRANCSCCIMP.FrancSCCIMPDatItems();
			bool flag2 = this.mapType != Common.RTxMapType.RT3;
			FRANCSCCIMP.FrancSCCIMPDatItems result;
			if (flag2)
			{
				result = null;
			}
			else
			{
				try
				{
					FRANCSCCIMP.FrancSCCIMPDatItems francSCCIMPDatItems2 = francSCCIMPDatItems;
					francSCCIMPDatItems2.name = this.RTXReader.readRT3String(36);
					flag = false;
					francSCCIMPDatItems2.SS = this.RTXReader.ReadByte();
					francSCCIMPDatItems2.MS = this.RTXReader.ReadByte();
					francSCCIMPDatItems2.LS = this.RTXReader.readLS();
					francSCCIMPDatItems2.X = this.RTXReader.readRT3Uint16();
					francSCCIMPDatItems2.Y = this.RTXReader.readRT3Uint16();
					francSCCIMPDatItems2.magnitude = this.RTXReader.ReadByte();
					flag = true;
				}
				catch (EndOfStreamException ex)
				{
					flag2 = !flag;
					if (flag2)
					{
						this.RTXReader.Close();
						throw;
					}
					francSCCIMPDatItems = null;
				}
				catch (Exception ex2)
				{
					this.RTXReader.Close();
					throw;
				}
				result = francSCCIMPDatItems;
			}
			return result;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00126A8C File Offset: 0x00125A8C
		public void storeRecord(POIDatas POIData)
		{
			bool flag = this.mapType != Common.RTxMapType.RT3;
			if (!flag)
			{
				flag = (POIData.fromRT3 || POIData.fullPatch);
				if (flag)
				{
					switch (POIData.magnitude)
					{
					case 4:
						this.mag4List.Add(POIData);
						break;
					case 5:
						this.mag5List.Add(POIData);
						break;
					case 6:
						this.mag6List.Add(POIData);
						break;
					case 7:
						this.mag7List.Add(POIData);
						break;
					case 8:
						this.mag8List.Add(POIData);
						break;
					}
				}
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00126B44 File Offset: 0x00125B44
		private void writeRecord(POIDatas POIData)
		{
			bool flag = this.mapType != Common.RTxMapType.RT3;
			if (!flag)
			{
				flag = (POIData.listOfCanonical.Count == 0);
				if (flag)
				{
					RT3Writer rtxwriter = this.RTXWriter;
					string text = "{..**..}";
					rtxwriter.writeRT3(ref text, 36);
				}
				else
				{
					flag = POIData.displayMagnitude;
					if (flag)
					{
						RT3Writer rtxwriter2 = this.RTXWriter;
						string text = POIData.listOfCanonical[0].name.Insert(0, Conversions.ToString(Strings.ChrW((int)(checked(48 + POIData.magnitude))))).TrimEnd(new char[]
						{
							'\0'
						}).ToLower();
						rtxwriter2.writeRT3(ref text, 36);
					}
					else
					{
						this.RTXWriter.writeRT3(ref POIData.listOfCanonical[0].name);
					}
				}
				this.RTXWriter.writeRT3(POIData.SS);
				this.RTXWriter.writeRT3(POIData.MS);
				this.RTXWriter.writeLS(POIData.LS);
				this.RTXWriter.writeRT3(POIData.X);
				this.RTXWriter.writeRT3(POIData.Y);
				this.RTXWriter.writeRT3(POIData.magnitude);
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00126C84 File Offset: 0x00125C84
		public void writeFile()
		{
			bool flag = this.mapType != Common.RTxMapType.RT3;
			checked
			{
				if (!flag)
				{
					int num = 0;
					int num2 = this.mag8List.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						this.writeRecord(this.mag8List[num3]);
						num3++;
					}
					int num6 = 0;
					int num7 = this.mag7List.Count - 1;
					int num8 = num6;
					for (;;)
					{
						int num9 = num8;
						int num5 = num7;
						if (num9 > num5)
						{
							break;
						}
						this.writeRecord(this.mag7List[num8]);
						num8++;
					}
					int num10 = 0;
					int num11 = this.mag6List.Count - 1;
					int num12 = num10;
					for (;;)
					{
						int num13 = num12;
						int num5 = num11;
						if (num13 > num5)
						{
							break;
						}
						this.writeRecord(this.mag6List[num12]);
						num12++;
					}
					int num14 = 0;
					int num15 = this.mag5List.Count - 1;
					int num16 = num14;
					for (;;)
					{
						int num17 = num16;
						int num5 = num15;
						if (num17 > num5)
						{
							break;
						}
						this.writeRecord(this.mag5List[num16]);
						num16++;
					}
					int num18 = 0;
					int num19 = this.mag4List.Count - 1;
					int num20 = num18;
					for (;;)
					{
						int num21 = num20;
						int num5 = num19;
						if (num21 > num5)
						{
							break;
						}
						this.writeRecord(this.mag4List[num20]);
						num20++;
					}
				}
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00126DB8 File Offset: 0x00125DB8
		public void close()
		{
			bool flag = this.mapType != Common.RTxMapType.RT3;
			if (!flag)
			{
				flag = (this.fMode == FRANCSCCIMP.mode.read);
				if (flag)
				{
					this.RTXReader.Close();
				}
				else
				{
					this.RTXWriter.Close();
				}
			}
		}

		// Token: 0x040006CE RID: 1742
		public const int NAMESIZE = 36;

		// Token: 0x040006CF RID: 1743
		private string fileName;

		// Token: 0x040006D0 RID: 1744
		private RT3Reader RTXReader;

		// Token: 0x040006D1 RID: 1745
		private RT3Writer RTXWriter;

		// Token: 0x040006D2 RID: 1746
		private FRANCSCCIMP.mode fMode;

		// Token: 0x040006D3 RID: 1747
		private Common.RTxMapType mapType;

		// Token: 0x040006D4 RID: 1748
		private List<POIDatas> mag4List;

		// Token: 0x040006D5 RID: 1749
		private List<POIDatas> mag5List;

		// Token: 0x040006D6 RID: 1750
		private List<POIDatas> mag6List;

		// Token: 0x040006D7 RID: 1751
		private List<POIDatas> mag7List;

		// Token: 0x040006D8 RID: 1752
		private List<POIDatas> mag8List;

		// Token: 0x0200009D RID: 157
		public class FrancSCCIMPDatItems
		{
			// Token: 0x06000DA5 RID: 3493 RVA: 0x00126E04 File Offset: 0x00125E04
			[DebuggerNonUserCode]
			public FrancSCCIMPDatItems()
			{
			}

			// Token: 0x040006D9 RID: 1753
			public string name;

			// Token: 0x040006DA RID: 1754
			public byte SS;

			// Token: 0x040006DB RID: 1755
			public byte MS;

			// Token: 0x040006DC RID: 1756
			public ushort LS;

			// Token: 0x040006DD RID: 1757
			public ushort X;

			// Token: 0x040006DE RID: 1758
			public ushort Y;

			// Token: 0x040006DF RID: 1759
			public byte magnitude;
		}

		// Token: 0x0200009E RID: 158
		public enum mode
		{
			// Token: 0x040006E1 RID: 1761
			read,
			// Token: 0x040006E2 RID: 1762
			write
		}
	}
}
