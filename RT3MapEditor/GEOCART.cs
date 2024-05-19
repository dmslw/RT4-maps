using System;
using System.IO;

namespace RT3MapEditor
{
	// Token: 0x020000A5 RID: 165
	public class GEOCART
	{
		// Token: 0x06000DB2 RID: 3506 RVA: 0x00127570 File Offset: 0x00126570
		public GEOCART(string fileName, Common.RTxMapType mapType)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.record = new GEOCART.GeoCartRecords();
			this.FileName = fileName;
			try
			{
				this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
				GEOCART.GeoCartRecords geoCartRecords = this.record;
				this.RT3Reader.BaseStream.Seek(28L, SeekOrigin.Begin);
				bool flag = mapType == Common.RTxMapType.RT3;
				if (flag)
				{
					geoCartRecords.lineNumber = (ushort)this.RT3Reader.ReadByte();
					geoCartRecords.ColNumber = (ushort)this.RT3Reader.ReadByte();
					geoCartRecords.LSNumber = (ushort)this.RT3Reader.ReadByte();
				}
				else
				{
					geoCartRecords.lineNumber = this.RT3Reader.readRT3Uint16();
					geoCartRecords.ColNumber = this.RT3Reader.readRT3Uint16();
					geoCartRecords.LSNumber = this.RT3Reader.readRT3Uint16();
					geoCartRecords.mapVersion = this.RT3Reader.readRT3String();
					geoCartRecords.CountrySetCode = this.RT3Reader.readRT3String();
				}
			}
			catch (Exception ex)
			{
				throw;
			}
			finally
			{
				this.RT3Reader.Close();
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x001276AC File Offset: 0x001266AC
		public uint LSColumnNb
		{
			get
			{
				return (uint)this.record.ColNumber;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x001276CC File Offset: 0x001266CC
		public uint LSLineNb
		{
			get
			{
				return (uint)this.record.lineNumber;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x001276EC File Offset: 0x001266EC
		public uint LSNb
		{
			get
			{
				return (uint)this.record.LSNumber;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x0012770C File Offset: 0x0012670C
		public static uint defaultLSColumnNb
		{
			get
			{
				return 28U;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00127720 File Offset: 0x00126720
		public static uint defaultLSLineNb
		{
			get
			{
				return 26U;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00127734 File Offset: 0x00126734
		public static uint defaultLSNb
		{
			get
			{
				return 728U;
			}
		}

		// Token: 0x04000704 RID: 1796
		private string FileName;

		// Token: 0x04000705 RID: 1797
		private RT3Reader RT3Reader;

		// Token: 0x04000706 RID: 1798
		private GEOCART.GeoCartRecords record;

		// Token: 0x04000707 RID: 1799
		private const uint _defaultLSColumnNb = 28U;

		// Token: 0x04000708 RID: 1800
		private const uint _defaultLSLineNb = 26U;

		// Token: 0x04000709 RID: 1801
		private const uint _defaultLSNb = 728U;

		// Token: 0x020000A6 RID: 166
		private class GeoCartRecords
		{
			// Token: 0x06000DB9 RID: 3513 RVA: 0x0012774C File Offset: 0x0012674C
			public GeoCartRecords()
			{
				this.mapVersion = null;
				this.CountrySetCode = null;
			}

			// Token: 0x0400070A RID: 1802
			public ushort lineNumber;

			// Token: 0x0400070B RID: 1803
			public ushort ColNumber;

			// Token: 0x0400070C RID: 1804
			public ushort LSNumber;

			// Token: 0x0400070D RID: 1805
			public string mapVersion;

			// Token: 0x0400070E RID: 1806
			public string CountrySetCode;
		}
	}
}
