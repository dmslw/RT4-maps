using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000089 RID: 137
	public class FRANC_NOMSERV_DAT
	{
		// Token: 0x06000D73 RID: 3443 RVA: 0x001247A0 File Offset: 0x001237A0
		public FRANC_NOMSERV_DAT(string fileName, FRANC_NOMSERV_DAT.mode mode)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.RT3Writer = null;
			this.recordNumber = 1U;
			this.fmode = mode;
			this.data = new Dictionary<uint, FRANC_NOMSERV_DAT.FrancNomservDatRecords>(4500000);
			this.FileName = fileName;
			bool flag = mode == FRANC_NOMSERV_DAT.mode.read;
			if (flag)
			{
				this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
			}
			else
			{
				this.RT3Writer = new RT3Writer(new FileStream(fileName, FileMode.Create, FileAccess.Write));
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00124824 File Offset: 0x00123824
		public void loadFromFile()
		{
			uint num = 0U;
			checked
			{
				try
				{
					MyProject.Application.Log.WriteEntry(string.Format("loading {0:G} ", this.FileName));
					long length = this.RT3Reader.BaseStream.Length;
					bool flag = length % 37L != 0L;
					if (flag)
					{
						throw new Exception(string.Format(Resources.strErrIncFileLength, this.FileName, length));
					}
					this.recordNumber = (uint)(length / 37L);
					uint num2 = 1U;
					uint num3 = this.recordNumber;
					num = num2;
					for (;;)
					{
						uint num4 = num;
						uint num5 = num3;
						if (num4 > num5)
						{
							break;
						}
						FRANC_NOMSERV_DAT.FrancNomservDatRecords francNomservDatRecords = new FRANC_NOMSERV_DAT.FrancNomservDatRecords();
						FRANC_NOMSERV_DAT.FrancNomservDatRecords francNomservDatRecords2 = francNomservDatRecords;
						francNomservDatRecords2.name = this.RT3Reader.readRT3String(36);
						francNomservDatRecords2.index = this.RT3Reader.ReadByte();
						this.data.Add(num, francNomservDatRecords);
						num += 1U;
					}
				}
				catch (Exception ex)
				{
					string message = string.Format("unable to load {0:G}, index {1:G}", this.FileName, num);
					MyProject.Application.Log.WriteEntry(message);
					MyProject.Application.Log.WriteEntry(ex.StackTrace);
					throw new Exception(message);
				}
				finally
				{
					this.RT3Reader.Close();
				}
				MyProject.Application.Log.WriteEntry(string.Format("{0:G} loaded : {1:G} entries", this.FileName, this.recordNumber));
			}
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x001249C8 File Offset: 0x001239C8
		public FRANC_NOMSERV_DAT.FrancNomservDatRecords getRecordByRT3Idx(uint RT3Idx)
		{
			bool flag = this.data.ContainsKey(RT3Idx);
			FRANC_NOMSERV_DAT.FrancNomservDatRecords result;
			if (flag)
			{
				result = this.data[RT3Idx];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00124A00 File Offset: 0x00123A00
		public void writeToFile(buildSortedMapDicts sortedDicts)
		{
			uint num = 1U;
			try
			{
				SortedDictionary<string, buildSortedMapDicts.alphabeticValue>.KeyCollection keys = sortedDicts.alphabeticDict.Keys;
				try
				{
					foreach (string key in keys)
					{
						this.RT3Writer.writeRT3(ref key, 36);
						buildSortedMapDicts.alphabeticValue alphabeticValue = sortedDicts.alphabeticDict[key];
						this.RT3Writer.writeRT3(alphabeticValue.idxName);
						alphabeticValue.idxInNOMSERVDAT = num;
						num = checked((uint)(unchecked((ulong)num) + 1UL));
					}
				}
				finally
				{
					SortedDictionary<string, buildSortedMapDicts.alphabeticValue>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				throw;
			}
			finally
			{
				this.RT3Writer.Close();
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00124ADC File Offset: 0x00123ADC
		public int unusedlRecords()
		{
			int num = 0;
			int num2 = 0;
			uint num3 = 1U;
			checked
			{
				uint num4 = (uint)this.data.Count;
				uint num5 = num3;
				for (;;)
				{
					uint num6 = num5;
					uint num7 = num4;
					if (num6 > num7)
					{
						break;
					}
					bool flag = !this.data[num5].used;
					if (flag)
					{
						bool flag2 = this.data[num5].index == 1;
						if (flag2)
						{
							num++;
						}
						else
						{
							num2++;
						}
					}
					num5 += 1U;
				}
				MyProject.Application.Log.WriteEntry(string.Format("Total unused records in FRANC_NOMSERV.DAT: {0:d} canonical, {1:d} alternate", num, num2));
				return num + num2;
			}
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00124B7C File Offset: 0x00123B7C
		public uint _addRecord(FRANC_NOMSERV_DAT.FrancNomservDatRecords newRecord)
		{
			int length = newRecord.name.Length;
			checked
			{
				bool flag = newRecord.name[length - 1] != '\0';
				if (flag)
				{
					bool flag2 = length >= 36;
					if (flag2)
					{
						Interaction.MsgBox("String too long", MsgBoxStyle.Critical, null);
						return 65535U;
					}
					string value = new string('\0', 36 - length);
					newRecord.name = newRecord.name.Insert(length, value);
				}
				else
				{
					bool flag2 = length > 36;
					if (flag2)
					{
						Interaction.MsgBox("String too long", MsgBoxStyle.Critical, null);
						return 65535U;
					}
					flag2 = (length < 36);
					if (flag2)
					{
						string value2 = new string('\0', 36 - length);
						newRecord.name = newRecord.name.Insert(length, value2);
					}
				}
				this.data.Add(this.recordNumber, newRecord);
				this.recordNumber = (uint)(unchecked((ulong)this.recordNumber) + 1UL);
				return this.recordNumber;
			}
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00124C84 File Offset: 0x00123C84
		public bool _dumpToFile()
		{
			bool result = false;
			checked
			{
				try
				{
					uint num = 1U;
					uint num2 = (uint)this.data.Count;
					uint num3 = num;
					for (;;)
					{
						uint num4 = num3;
						uint num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						FRANC_NOMSERV_DAT.FrancNomservDatRecords francNomservDatRecords = this.data[num3];
						FRANC_NOMSERV_DAT.FrancNomservDatRecords francNomservDatRecords2 = francNomservDatRecords;
						this.RT3Writer.writeRT3(ref francNomservDatRecords2.name, 36);
						this.RT3Writer.writeRT3(francNomservDatRecords2.index);
						num3 += 1U;
					}
				}
				catch (Exception ex)
				{
					result = false;
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				}
				finally
				{
					this.RT3Writer.Close();
				}
				return result;
			}
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00124D44 File Offset: 0x00123D44
		public void _clear()
		{
			this.data = new Dictionary<uint, FRANC_NOMSERV_DAT.FrancNomservDatRecords>(4500000);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00124D58 File Offset: 0x00123D58
		public void close()
		{
			bool flag = this.fmode == FRANC_NOMSERV_DAT.mode.read;
			if (flag)
			{
				this.RT3Reader.Close();
			}
			else
			{
				this.RT3Writer.Close();
			}
		}

		// Token: 0x0400065B RID: 1627
		public const int NAMESIZE = 36;

		// Token: 0x0400065C RID: 1628
		public const int RECORDSIZE = 37;

		// Token: 0x0400065D RID: 1629
		private const uint INITIALSIZE = 4500000U;

		// Token: 0x0400065E RID: 1630
		private string FileName;

		// Token: 0x0400065F RID: 1631
		private RT3Reader RT3Reader;

		// Token: 0x04000660 RID: 1632
		private RT3Writer RT3Writer;

		// Token: 0x04000661 RID: 1633
		private FRANC_NOMSERV_DAT.mode fmode;

		// Token: 0x04000662 RID: 1634
		private Dictionary<uint, FRANC_NOMSERV_DAT.FrancNomservDatRecords> data;

		// Token: 0x04000663 RID: 1635
		private uint recordNumber;

		// Token: 0x0200008A RID: 138
		public class FrancNomservDatRecords
		{
			// Token: 0x06000D7C RID: 3452 RVA: 0x00124D90 File Offset: 0x00123D90
			public FrancNomservDatRecords()
			{
				this.used = false;
			}

			// Token: 0x04000664 RID: 1636
			public string name;

			// Token: 0x04000665 RID: 1637
			public byte index;

			// Token: 0x04000666 RID: 1638
			public bool used;
		}

		// Token: 0x0200008B RID: 139
		public enum mode
		{
			// Token: 0x04000668 RID: 1640
			read,
			// Token: 0x04000669 RID: 1641
			write
		}
	}
}
