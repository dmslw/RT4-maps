using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000087 RID: 135
	public class FRANC_EX_DPS
	{
		// Token: 0x06000D6E RID: 3438 RVA: 0x001245D4 File Offset: 0x001235D4
		public FRANC_EX_DPS(string fileName, uint LSNb)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.dict = new Dictionary<uint, ushort>(32768);
			this.FileName = fileName;
			checked
			{
				this.recordNumber = 256U * LSNb;
				try
				{
					this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
					long length = this.RT3Reader.BaseStream.Length;
					bool flag = length != (long)(20UL * unchecked((ulong)this.recordNumber));
					if (flag)
					{
						throw new Exception(string.Format(Resources.strErrIncFileLength, fileName, length));
					}
					uint num = 0U;
					uint num2 = (uint)(unchecked((ulong)this.recordNumber) - 1UL);
					uint num3 = num;
					ushort num7;
					for (;;)
					{
						uint num4 = num3;
						uint num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						this.RT3Reader.BaseStream.Seek((long)(20UL * unchecked((ulong)num3) + 18UL), SeekOrigin.Begin);
						ushort num6 = this.RT3Reader.readRT3Uint16();
						flag = (num6 != ushort.MaxValue);
						if (flag)
						{
							this.dict.Add(num3, num6);
							num7 = num6;
						}
						num3 += 1U;
					}
					this.lastFRANCDPA_POIIdx = (uint)(256 * (num7 + 1) - 1);
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
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0012472C File Offset: 0x0012372C
		public uint getFRANCDPA_POIIdx(uint LSMSNumber, byte SSNumber)
		{
			ushort num;
			bool flag = !this.dict.TryGetValue(LSMSNumber, out num);
			uint result;
			if (flag)
			{
				result = uint.MaxValue;
			}
			else
			{
				result = (uint)(checked(256 * num + (ushort)SSNumber));
			}
			return result;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00124760 File Offset: 0x00123760
		public bool isUpToDate(string fileName)
		{
			return Operators.CompareString(this.FileName, fileName, false) == 0;
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00124784 File Offset: 0x00123784
		public void close()
		{
			this.RT3Reader.Close();
		}

		// Token: 0x04000649 RID: 1609
		private const int RECORDSIZE = 20;

		// Token: 0x0400064A RID: 1610
		private const ushort IDXFRANDPA_OFFSET = 18;

		// Token: 0x0400064B RID: 1611
		private const ushort RT3RECORDNUMBER = 52296;

		// Token: 0x0400064C RID: 1612
		public uint lastFRANCDPA_POIIdx;

		// Token: 0x0400064D RID: 1613
		private uint recordNumber;

		// Token: 0x0400064E RID: 1614
		private const uint INITIALSIZE = 32768U;

		// Token: 0x0400064F RID: 1615
		private string FileName;

		// Token: 0x04000650 RID: 1616
		private RT3Reader RT3Reader;

		// Token: 0x04000651 RID: 1617
		private Dictionary<uint, ushort> dict;

		// Token: 0x02000088 RID: 136
		private class FrancExDpsRecords
		{
			// Token: 0x06000D72 RID: 3442 RVA: 0x00124794 File Offset: 0x00123794
			[DebuggerNonUserCode]
			public FrancExDpsRecords()
			{
			}

			// Token: 0x04000652 RID: 1618
			public uint idxFRANC_EX_DPS;

			// Token: 0x04000653 RID: 1619
			public uint idxFRANC_EX_RID;

			// Token: 0x04000654 RID: 1620
			public ushort recBbInFRANC_EX_RID;

			// Token: 0x04000655 RID: 1621
			public ushort unknown1;

			// Token: 0x04000656 RID: 1622
			public ushort unknown2;

			// Token: 0x04000657 RID: 1623
			public ushort rotation;

			// Token: 0x04000658 RID: 1624
			public byte Coef1;

			// Token: 0x04000659 RID: 1625
			public byte Coef2;

			// Token: 0x0400065A RID: 1626
			public ushort IdxInFRANCDPA_LZW;
		}
	}
}
