using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x0200007B RID: 123
	public class CATPOI
	{
		// Token: 0x06000D3E RID: 3390 RVA: 0x0012195C File Offset: 0x0012095C
		public CATPOI(string fileName, Common.RTxMapType mapType)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this._sdBrandList = new SortedDictionary<ushort, CATPOI.CATPOIRecords>();
			bool flag = mapType == Common.RTxMapType.RT4;
			checked
			{
				if (flag)
				{
					CATPOI.CATPOIRecords catpoirecords = new CATPOI.CATPOIRecords();
					catpoirecords._brandName = Resources.strBandNoBrand;
					catpoirecords.brandIdx = 0;
					catpoirecords._idx = 0;
					this._sdBrandList.Add(0, catpoirecords);
					this.FileName = fileName;
					this.mapType = mapType;
					this._isValid = true;
					try
					{
						MyProject.Application.Log.WriteEntry("loading CAT.POI", TraceEventType.Information);
						this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
						long length = this.RT3Reader.BaseStream.Length;
						flag = (length % 23L != 0L);
						if (flag)
						{
							throw new Exception(string.Format(Resources.strErrIncFileLength, fileName, length));
						}
						int num = (int)Math.Round((double)length / 23.0);
						int num2 = 1;
						int num3 = num;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							catpoirecords = new CATPOI.CATPOIRecords();
							catpoirecords._brandName = this.RT3Reader.readRT3String(21);
							catpoirecords.brandIdx = unchecked(this.RT3Reader.readRT3Uint16() + 1);
							catpoirecords._idx = num4;
							this._sdBrandList.Add((ushort)num4, catpoirecords);
							num4++;
						}
					}
					catch (Exception ex)
					{
						this._isValid = false;
						throw;
					}
					finally
					{
						flag = (this.RT3Reader != null);
						if (flag)
						{
							this.RT3Reader.Close();
						}
					}
				}
				MyProject.Application.Log.WriteEntry("CAT.POI loaded", TraceEventType.Information);
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00121B1C File Offset: 0x00120B1C
		public SortedDictionary<ushort, CATPOI.CATPOIRecords> sdBrandList
		{
			get
			{
				return this._sdBrandList;
			}
		}

		// Token: 0x040005D0 RID: 1488
		public const int RECORDSIZE = 23;

		// Token: 0x040005D1 RID: 1489
		private string FileName;

		// Token: 0x040005D2 RID: 1490
		private RT3Reader RT3Reader;

		// Token: 0x040005D3 RID: 1491
		private Common.RTxMapType mapType;

		// Token: 0x040005D4 RID: 1492
		private SortedDictionary<ushort, CATPOI.CATPOIRecords> _sdBrandList;

		// Token: 0x040005D5 RID: 1493
		private bool _isValid;

		// Token: 0x0200007C RID: 124
		public class CATPOIRecords
		{
			// Token: 0x06000D40 RID: 3392 RVA: 0x00121B34 File Offset: 0x00120B34
			[DebuggerNonUserCode]
			public CATPOIRecords()
			{
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00121B40 File Offset: 0x00120B40
			public string brandName
			{
				get
				{
					return this._brandName;
				}
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00121B58 File Offset: 0x00120B58
			public int idx
			{
				get
				{
					return this._idx;
				}
			}

			// Token: 0x040005D6 RID: 1494
			public string _brandName;

			// Token: 0x040005D7 RID: 1495
			public ushort brandIdx;

			// Token: 0x040005D8 RID: 1496
			public int _idx;
		}
	}
}
