using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000082 RID: 130
	public class DCN_CAT
	{
		// Token: 0x06000D61 RID: 3425 RVA: 0x00123A74 File Offset: 0x00122A74
		public DCN_CAT(string fileName)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.maxUid = 0;
			this.list = null;
			this.dict = new SortedDictionary<string, DCN_CAT.dcnRecords>();
			this.FileName = fileName;
			this._isValid = true;
			checked
			{
				try
				{
					MyProject.Application.Log.WriteEntry("loading DCN.CAT", TraceEventType.Information);
					this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
					long length = this.RT3Reader.BaseStream.Length;
					bool flag = length % 54L != 0L;
					if (flag)
					{
						throw new Exception(string.Format(Resources.strErrIncFileLength, fileName, length));
					}
					int num = (int)Math.Round((double)length / 54.0);
					int num2 = 0;
					int num3 = 0;
					int num4 = num - 1;
					int num5 = num3;
					DCN_CAT.dcnRecords dcnRecords2;
					for (;;)
					{
						int num6 = num5;
						int num7 = num4;
						if (num6 > num7)
						{
							goto IL_258;
						}
						DCN_CAT.dcnRecords dcnRecords = new DCN_CAT.dcnRecords();
						dcnRecords2 = dcnRecords;
						byte[] array = this.RT3Reader.readRT3StringAsByteArray(46);
						dcnRecords2.cityName = Common.RT3Encoding.GetString(array);
						dcnRecords2.idxName = this.RT3Reader.ReadByte();
						dcnRecords2.country = this.RT3Reader.ReadByte();
						dcnRecords2.area = this.RT3Reader.ReadByte();
						dcnRecords2.department = this.RT3Reader.ReadByte();
						dcnRecords2.city = this.RT3Reader.readRT3Uint16();
						dcnRecords2.district = this.RT3Reader.readRT3Uint16();
						string text = this.buildKey(array, dcnRecords2.country, dcnRecords2.area, dcnRecords2.department, dcnRecords2.city, dcnRecords2.district, num2);
						flag = !this.dict.ContainsKey(text);
						if (flag)
						{
							num2 = 0;
							this.dict.Add(text, dcnRecords);
						}
						else
						{
							num2++;
							flag = (num2 > this.maxUid);
							if (flag)
							{
								this.maxUid = num2;
								flag = (this.maxUid >= 15);
								if (flag)
								{
									break;
								}
							}
							this.dict.Add(text.Remove(text.Length - 1) + num2.ToString("X1"), dcnRecords);
						}
						num5++;
					}
					MyProject.Application.Log.WriteEntry(string.Format("more than 15 synonyms of {0:G}", dcnRecords2.cityName), TraceEventType.Information);
					this._isValid = false;
					IL_258:
					MyProject.Application.Log.WriteEntry("DCN.CAT loaded", TraceEventType.Information);
				}
				catch (Exception ex)
				{
					this._isValid = false;
					throw;
				}
				finally
				{
					this.RT3Reader.Close();
				}
				this.dump2File();
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00123D58 File Offset: 0x00122D58
		public bool insertZipCodeRecord()
		{
			return true;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00123D6C File Offset: 0x00122D6C
		public DCN_CAT.dcnRecords getRecordByIdx(uint idx)
		{
			bool flag = (ulong)idx < (ulong)((long)this.list.Count);
			DCN_CAT.dcnRecords result;
			if (flag)
			{
				result = this.list[checked((int)idx)];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00123DA8 File Offset: 0x00122DA8
		public void write2file(string fileName)
		{
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x00123DAC File Offset: 0x00122DAC
		public bool isvalid
		{
			get
			{
				return this._isValid;
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00123DC4 File Offset: 0x00122DC4
		private string buildKey(byte[] value, byte ct, byte area, byte dpt, ushort city, ushort district, int uid)
		{
			StringBuilder stringBuilder = new StringBuilder(60);
			int num = 0;
			checked
			{
				int num2 = value.Length - 1;
				int num3 = num;
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					byte b = value[num3];
					bool flag = b == 92 || b == 0;
					if (flag)
					{
						break;
					}
					stringBuilder.Append(DCN_CAT.tlsStr[(int)(b - 32)]);
					num3++;
				}
				return string.Concat(new string[]
				{
					stringBuilder.ToString().PadRight(45),
					ct.ToString("X2"),
					area.ToString("X2"),
					dpt.ToString("X2"),
					city.ToString("X4"),
					district.ToString("X4"),
					uid.ToString("X1")
				});
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00123EB0 File Offset: 0x00122EB0
		private void dump2File()
		{
			int num = 0;
			StreamWriter streamWriter = new StreamWriter("C:\\Documents and Settings\\Papy\\Mes documents\\voiture\\RT3\\POI\\rechercheUK\\DCN.CAT1.txt", false, Common.RT3Encoding);
			checked
			{
				try
				{
					foreach (DCN_CAT.dcnRecords dcnRecords in this.dict.Values)
					{
						streamWriter.WriteLine(string.Format("{0:G46}", dcnRecords.cityName.Replace("\0", " ")));
						num++;
					}
				}
				finally
				{
					SortedDictionary<string, DCN_CAT.dcnRecords>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				streamWriter.Close();
			}
		}

		// Token: 0x04000614 RID: 1556
		public const int RECORDSIZE = 54;

		// Token: 0x04000615 RID: 1557
		private const uint INITIALSIZE = 118784U;

		// Token: 0x04000616 RID: 1558
		private string FileName;

		// Token: 0x04000617 RID: 1559
		private RT3Reader RT3Reader;

		// Token: 0x04000618 RID: 1560
		private SortedDictionary<string, DCN_CAT.dcnRecords> dict;

		// Token: 0x04000619 RID: 1561
		private int maxUid;

		// Token: 0x0400061A RID: 1562
		private List<DCN_CAT.dcnRecords> list;

		// Token: 0x0400061B RID: 1563
		private bool _isValid;

		// Token: 0x0400061C RID: 1564
		private static string tlsStr = " !\"#$%&   *+,  /0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~                                  ¡¢£¤¥¦§¨©ª«¬ ®¯°±²³´µ¶•¸¹º»¼½¾¿AAAAAAECEEEEIIIIDNOOOOO×OUUUUYÞßAAAAAAECEEEEIIIIONOOOOO÷OUUUUYþY";

		// Token: 0x02000083 RID: 131
		public class dcnRecords
		{
			// Token: 0x06000D68 RID: 3432 RVA: 0x00123F50 File Offset: 0x00122F50
			[DebuggerNonUserCode]
			public dcnRecords()
			{
			}

			// Token: 0x0400061D RID: 1565
			public string cityName;

			// Token: 0x0400061E RID: 1566
			public byte idxName;

			// Token: 0x0400061F RID: 1567
			public byte country;

			// Token: 0x04000620 RID: 1568
			public byte area;

			// Token: 0x04000621 RID: 1569
			public byte department;

			// Token: 0x04000622 RID: 1570
			public ushort city;

			// Token: 0x04000623 RID: 1571
			public ushort district;
		}
	}
}
