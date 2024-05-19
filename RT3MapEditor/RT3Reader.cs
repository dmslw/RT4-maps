using System;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;

namespace RT3MapEditor
{
	// Token: 0x020000C9 RID: 201
	public class RT3Reader : BinaryReader
	{
		// Token: 0x06000E29 RID: 3625 RVA: 0x0012DB6C File Offset: 0x0012CB6C
		public RT3Reader(Stream stream) : base(stream, Common.RT3Encoding)
		{
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0012DB80 File Offset: 0x0012CB80
		public string readRT3String()
		{
			int num = 0;
			StringBuilder stringBuilder = new StringBuilder(128);
			byte b = base.ReadByte();
			checked
			{
				while (b != 0 && num < 128)
				{
					stringBuilder.Append(Strings.ChrW((int)b));
					num++;
					b = base.ReadByte();
				}
				stringBuilder.Append(Strings.ChrW((int)b));
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0012DBEC File Offset: 0x0012CBEC
		public string readRT3String(int length)
		{
			string text = new string(base.ReadChars(length));
			bool flag = text.Length != length;
			string result;
			if (flag)
			{
				base.ReadByte();
				result = null;
			}
			else
			{
				result = text;
			}
			return result;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0012DC2C File Offset: 0x0012CC2C
		public byte[] readRT3StringAsByteArray(int length)
		{
			return base.ReadBytes(length);
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0012DC48 File Offset: 0x0012CC48
		public string readRT3String36()
		{
			string text = new string(base.ReadChars(36));
			bool flag = text.Length != 36;
			string result;
			if (flag)
			{
				base.ReadByte();
				result = null;
			}
			else
			{
				result = text;
			}
			return result;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0012DC8C File Offset: 0x0012CC8C
		public ushort readRT3Uint16()
		{
			ushort num = base.ReadUInt16();
			return checked((ushort)((num & 255) << 8) | (ushort)((num & 65280) >> 8));
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0012DCBC File Offset: 0x0012CCBC
		public uint readRT3Uint32()
		{
			uint num = base.ReadUInt32();
			return checked((uint)((uint)(unchecked((ulong)num) & 255UL) << 24) | (uint)((uint)(unchecked((ulong)num) & 65280UL) << 8) | (uint)((unchecked((ulong)num) & 16711680UL) >> 8) | (uint)((unchecked((ulong)num) & 18446744073692774400UL) >> 24));
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0012DD0C File Offset: 0x0012CD0C
		public virtual ushort readLS()
		{
			return (ushort)base.ReadByte();
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0012DD24 File Offset: 0x0012CD24
		public virtual ushort readPOIType()
		{
			return this.readRT3Uint16();
		}
	}
}
