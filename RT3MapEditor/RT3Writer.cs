using System;
using System.IO;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x020000CA RID: 202
	public class RT3Writer : BinaryWriter
	{
		// Token: 0x06000E32 RID: 3634 RVA: 0x0012DD3C File Offset: 0x0012CD3C
		public RT3Writer(Stream stream) : base(stream, Common.RT3Encoding)
		{
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0012DD50 File Offset: 0x0012CD50
		public void writeRT3(byte value)
		{
			base.Write(value);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0012DD5C File Offset: 0x0012CD5C
		public void writeRT3(ushort value)
		{
			checked
			{
				byte value2 = (byte)((value & 65280) >> 8);
				base.Write(value2);
				base.Write((byte)(value & 255));
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0012DD90 File Offset: 0x0012CD90
		public void writeRT3(uint value)
		{
			checked
			{
				byte value2 = (byte)((unchecked((ulong)value) & 18446744073692774400UL) >> 24);
				base.Write(value2);
				value2 = (byte)((unchecked((ulong)value) & 16711680UL) >> 16);
				base.Write(value2);
				value2 = (byte)((unchecked((ulong)value) & 65280UL) >> 8);
				base.Write(value2);
				base.Write((byte)(unchecked((ulong)value) & 255UL));
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0012DDF4 File Offset: 0x0012CDF4
		public void writeRT3(ulong value)
		{
			base.Write(value);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0012DE00 File Offset: 0x0012CE00
		public void writeRT3(ref string value)
		{
			int length = value.Length;
			checked
			{
				int index = length - 1;
				int num = 0;
				int num2 = length - 1;
				int num3 = num;
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					base.Write(value[num3]);
					num3++;
				}
				bool flag = length == 0 || value[index] != '\0';
				if (flag)
				{
					base.Write(0);
				}
			}
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0012DE64 File Offset: 0x0012CE64
		public void writeRT3Str(ref string value)
		{
			int length = value.Length;
			checked
			{
				int num = length - 1;
				int num2 = 0;
				int num3 = length - 1;
				int num4 = num2;
				for (;;)
				{
					int num5 = num4;
					int num6 = num3;
					if (num5 > num6)
					{
						break;
					}
					base.Write(value[num4]);
					num4++;
				}
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0012DEA4 File Offset: 0x0012CEA4
		public void writeRT3(ref string str, int maxLen)
		{
			int length = str.Length;
			checked
			{
				int num = length - 1;
				bool flag = length > maxLen;
				if (flag)
				{
					throw new Exception(string.Format(Resources.strErrStringTooLong, length, maxLen));
				}
				int num2 = 0;
				int num3 = num;
				int i = num2;
				for (;;)
				{
					int num4 = i;
					int num5 = num3;
					if (num4 > num5)
					{
						break;
					}
					base.Write(str[i]);
					i++;
				}
				while (i < maxLen)
				{
					base.Write(0);
					i++;
				}
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0012DF24 File Offset: 0x0012CF24
		public virtual void writePOIType(ushort RT3Type)
		{
			this.writeRT3(RT3Type);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0012DF30 File Offset: 0x0012CF30
		public virtual void writeLS(ushort LS)
		{
			this.writeRT3(checked((byte)LS));
		}
	}
}
