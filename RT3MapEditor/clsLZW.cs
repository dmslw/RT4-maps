using System;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x0200007D RID: 125
	public class clsLZW
	{
		// Token: 0x06000D43 RID: 3395 RVA: 0x00121B70 File Offset: 0x00120B70
		public clsLZW()
		{
			this.INIT_BITS = 8;
			this.BITS = 9;
			this.MAX_BITS = 10;
			this.HASHING_SHIFT = 4;
			checked
			{
				this.MAX_VALUE = (1 << this.BITS) - 1;
				this.MAX_CODE = this.MAX_VALUE - 1;
				this.CLEAR_CODE = 1 << this.BITS - 1;
				this.EOI = this.CLEAR_CODE + 1;
				this.FIRST_CODE = this.CLEAR_CODE + 2;
				this.EOF = -1;
				this.brInput = null;
				this.br1Input = null;
				this.bwOutput = null;
				this.codesOutput = null;
				this.iaCode_Value = new int[18042];
				this.iaPrefix_Code = new int[18042];
				this.baAppend_Character = new byte[18042];
				this.$STATIC$output_code$20118$output_bit_count$Init = new StaticLocalInitFlag();
				this.$STATIC$output_code$20118$output_bit_buffer$Init = new StaticLocalInitFlag();
				this.$STATIC$expand$2001$input_bit_count$Init = new StaticLocalInitFlag();
				this.$STATIC$input_code$20182$input_bit_count$Init = new StaticLocalInitFlag();
				this.$STATIC$expand$2001$input_bit_buffer$Init = new StaticLocalInitFlag();
				this.$STATIC$input_code$20182$input_bit_buffer$Init = new StaticLocalInitFlag();
				this.$STATIC$expand$2001$Mask32$Init = new StaticLocalInitFlag();
				this.$STATIC$input_code$20182$Mask32$Init = new StaticLocalInitFlag();
				this.$STATIC$expand$2001$resMask$Init = new StaticLocalInitFlag();
			}
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00121CAC File Offset: 0x00120CAC
		public void compress()
		{
			int num = this.FIRST_CODE;
			int num2 = 0;
			checked
			{
				int num3;
				int num4;
				do
				{
					this.iaCode_Value[num2] = -1;
					num2++;
					num3 = num2;
					num4 = 18040;
				}
				while (num3 <= num4);
				int num5 = this.ReadByte();
				for (int num6 = this.ReadByte(); num6 != -1; num6 = this.ReadByte())
				{
					int num7 = this.find_match(num5, num6);
					bool flag = this.iaCode_Value[num7] != -1;
					if (flag)
					{
						num5 = this.iaCode_Value[num7];
					}
					else
					{
						this.output_code(num5);
						flag = (num <= this.MAX_VALUE);
						if (flag)
						{
							this.iaCode_Value[num7] = num;
							num++;
							this.iaPrefix_Code[num7] = num5;
							this.baAppend_Character[num7] = (byte)num6;
						}
						flag = (num > this.MAX_VALUE);
						if (flag)
						{
							bool flag2 = this.BITS == 9;
							if (flag2)
							{
								this.BITS = 10;
								this.MAX_VALUE = (1 << this.BITS) - 1;
								this.MAX_CODE = this.MAX_VALUE - 1;
							}
							this.iaCode_Value[num7] = num;
							num++;
							this.iaPrefix_Code[num7] = num5;
							this.baAppend_Character[num7] = (byte)num6;
						}
						else
						{
							bool flag2 = this.BITS < this.MAX_BITS;
							if (flag2)
							{
							}
						}
						num5 = num6;
					}
				}
				this.output_code(num5);
				this.output_code(this.EOI);
				this.output_code(0);
			}
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00121E20 File Offset: 0x00120E20
		public void Origcompress()
		{
			int num = this.FIRST_CODE;
			int num2 = 0;
			checked
			{
				int num3;
				int num4;
				do
				{
					this.iaCode_Value[num2] = -1;
					num2++;
					num3 = num2;
					num4 = 18040;
				}
				while (num3 <= num4);
				int num5 = this.ReadByte();
				for (int num6 = this.ReadByte(); num6 != -1; num6 = this.ReadByte())
				{
					int num7 = this.find_match(num5, num6);
					bool flag = this.iaCode_Value[num7] != -1;
					if (flag)
					{
						num5 = this.iaCode_Value[num7];
					}
					else
					{
						flag = (num <= this.MAX_CODE);
						if (flag)
						{
							this.iaCode_Value[num7] = num;
							num++;
							this.iaPrefix_Code[num7] = num5;
							this.baAppend_Character[num7] = (byte)num6;
						}
						this.output_code(num5);
						num5 = num6;
					}
				}
				this.output_code(num5);
				this.output_code(this.MAX_VALUE);
				this.output_code(0);
			}
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00121F08 File Offset: 0x00120F08
		private int find_match(int iHashPrefix, int iHashCharacter)
		{
			int num = iHashCharacter << this.HASHING_SHIFT ^ iHashPrefix;
			bool flag = num == 0;
			checked
			{
				int num2;
				if (flag)
				{
					num2 = 1;
				}
				else
				{
					num2 = 18041 - num;
				}
				int result;
				for (;;)
				{
					flag = (this.iaCode_Value[num] == -1);
					if (flag)
					{
						result = num;
						break;
					}
					flag = (this.iaPrefix_Code[num] == iHashPrefix & (int)this.baAppend_Character[num] == iHashCharacter);
					if (flag)
					{
						result = num;
						break;
					}
					num -= num2;
					flag = (num < 0);
					if (flag)
					{
						num += 18041;
					}
				}
				return result;
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00121F90 File Offset: 0x00120F90
		private void output_code(int code)
		{
			Monitor.Enter(this.$STATIC$output_code$20118$output_bit_count$Init);
			try
			{
				bool flag = this.$STATIC$output_code$20118$output_bit_count$Init.State == 0;
				if (flag)
				{
					this.$STATIC$output_code$20118$output_bit_count$Init.State = 2;
					this.$STATIC$output_code$20118$output_bit_count = 0;
				}
				else
				{
					flag = (this.$STATIC$output_code$20118$output_bit_count$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$output_code$20118$output_bit_count$Init.State = 1;
				Monitor.Exit(this.$STATIC$output_code$20118$output_bit_count$Init);
			}
			Monitor.Enter(this.$STATIC$output_code$20118$output_bit_buffer$Init);
			try
			{
				bool flag = this.$STATIC$output_code$20118$output_bit_buffer$Init.State == 0;
				if (flag)
				{
					this.$STATIC$output_code$20118$output_bit_buffer$Init.State = 2;
					this.$STATIC$output_code$20118$output_bit_buffer = 0L;
				}
				else
				{
					flag = (this.$STATIC$output_code$20118$output_bit_buffer$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$output_code$20118$output_bit_buffer$Init.State = 1;
				Monitor.Exit(this.$STATIC$output_code$20118$output_bit_buffer$Init);
			}
			this.$STATIC$output_code$20118$output_bit_buffer |= (long)((long)code << checked(32 - this.BITS - this.$STATIC$output_code$20118$output_bit_count));
			checked
			{
				this.$STATIC$output_code$20118$output_bit_count += this.BITS;
				while (this.$STATIC$output_code$20118$output_bit_count >= 8)
				{
					this.WriteByteDebug((byte)(this.$STATIC$output_code$20118$output_bit_buffer >> 24 & 255L));
					this.$STATIC$output_code$20118$output_bit_buffer <<= 8;
					this.$STATIC$output_code$20118$output_bit_count -= 8;
				}
			}
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0012210C File Offset: 0x0012110C
		public void expand()
		{
			byte[] array = new byte[18042];
			Monitor.Enter(this.$STATIC$expand$2001$input_bit_count$Init);
			try
			{
				bool flag = this.$STATIC$expand$2001$input_bit_count$Init.State == 0;
				if (flag)
				{
					this.$STATIC$expand$2001$input_bit_count$Init.State = 2;
					this.$STATIC$expand$2001$input_bit_count = 0;
				}
				else
				{
					flag = (this.$STATIC$expand$2001$input_bit_count$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$expand$2001$input_bit_count$Init.State = 1;
				Monitor.Exit(this.$STATIC$expand$2001$input_bit_count$Init);
			}
			Monitor.Enter(this.$STATIC$expand$2001$input_bit_buffer$Init);
			try
			{
				bool flag = this.$STATIC$expand$2001$input_bit_buffer$Init.State == 0;
				if (flag)
				{
					this.$STATIC$expand$2001$input_bit_buffer$Init.State = 2;
					this.$STATIC$expand$2001$input_bit_buffer = 0U;
				}
				else
				{
					flag = (this.$STATIC$expand$2001$input_bit_buffer$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$expand$2001$input_bit_buffer$Init.State = 1;
				Monitor.Exit(this.$STATIC$expand$2001$input_bit_buffer$Init);
			}
			Monitor.Enter(this.$STATIC$expand$2001$Mask32$Init);
			try
			{
				bool flag = this.$STATIC$expand$2001$Mask32$Init.State == 0;
				if (flag)
				{
					this.$STATIC$expand$2001$Mask32$Init.State = 2;
					this.$STATIC$expand$2001$Mask32 = uint.MaxValue;
				}
				else
				{
					flag = (this.$STATIC$expand$2001$Mask32$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$expand$2001$Mask32$Init.State = 1;
				Monitor.Exit(this.$STATIC$expand$2001$Mask32$Init);
			}
			Monitor.Enter(this.$STATIC$expand$2001$resMask$Init);
			try
			{
				bool flag = this.$STATIC$expand$2001$resMask$Init.State == 0;
				if (flag)
				{
					this.$STATIC$expand$2001$resMask$Init.State = 2;
					this.$STATIC$expand$2001$resMask = 511;
				}
				else
				{
					flag = (this.$STATIC$expand$2001$resMask$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$expand$2001$resMask$Init.State = 1;
				Monitor.Exit(this.$STATIC$expand$2001$resMask$Init);
			}
			checked
			{
				for (;;)
				{
					IL_1C5:
					this.BITS = 9;
					this.MAX_VALUE = (1 << this.BITS) - 1;
					this.MAX_CODE = this.MAX_VALUE - 1;
					this.$STATIC$expand$2001$resMask = 511;
					this.FIRST_CODE = 258;
					int num = this.FIRST_CODE;
					while (this.$STATIC$expand$2001$input_bit_count < this.BITS)
					{
						this.$STATIC$expand$2001$input_bit_buffer = ((this.$STATIC$expand$2001$input_bit_buffer << 8 | (uint)this.brInput.ReadByte()) & this.$STATIC$expand$2001$Mask32);
						this.$STATIC$expand$2001$input_bit_count += 8;
					}
					int num2 = (int)((ushort)(this.$STATIC$expand$2001$input_bit_buffer >> this.$STATIC$expand$2001$input_bit_count - this.BITS & (uint)this.$STATIC$expand$2001$resMask));
					this.$STATIC$expand$2001$input_bit_count -= this.BITS;
					byte b = (byte)num2;
					this.bwOutput.Write((byte)num2);
					while (this.$STATIC$expand$2001$input_bit_count < this.BITS)
					{
						this.$STATIC$expand$2001$input_bit_buffer = ((this.$STATIC$expand$2001$input_bit_buffer << 8 | (uint)this.brInput.ReadByte()) & this.$STATIC$expand$2001$Mask32);
						this.$STATIC$expand$2001$input_bit_count += 8;
					}
					int num3 = (int)((ushort)(this.$STATIC$expand$2001$input_bit_buffer >> this.$STATIC$expand$2001$input_bit_count - this.BITS & (uint)this.$STATIC$expand$2001$resMask));
					this.$STATIC$expand$2001$input_bit_count -= this.BITS;
					while (num3 != this.EOI)
					{
						bool flag = num3 == this.CLEAR_CODE;
						if (flag)
						{
							int num4 = this.$STATIC$expand$2001$input_bit_count % 8;
							this.$STATIC$expand$2001$input_bit_count -= num4;
							this.$STATIC$expand$2001$input_bit_buffer = (this.$STATIC$expand$2001$input_bit_buffer << num4 & this.$STATIC$expand$2001$Mask32);
							goto IL_1C5;
						}
						flag = (num3 >= num);
						int i;
						int j;
						if (flag)
						{
							array[0] = b;
							i = 1;
							j = num2;
						}
						else
						{
							i = 0;
							j = num3;
						}
						while (j >= this.FIRST_CODE)
						{
							array[i] = this.baAppend_Character[j];
							i++;
							flag = (i > this.MAX_VALUE);
							if (flag)
							{
								goto Block_9;
							}
							j = this.iaPrefix_Code[j];
						}
						array[i] = (byte)j;
						b = array[i];
						while (i >= 0)
						{
							this.bwOutput.Write(array[i]);
							i--;
						}
						flag = (num <= this.MAX_VALUE);
						if (flag)
						{
							this.iaPrefix_Code[num] = num2;
							this.baAppend_Character[num] = b;
							num++;
						}
						flag = (num > this.MAX_VALUE && this.BITS == 9);
						if (flag)
						{
							this.BITS = 10;
							this.$STATIC$expand$2001$resMask = 1023;
							this.MAX_VALUE = (1 << this.BITS) - 1;
							this.MAX_CODE = this.MAX_VALUE - 1;
						}
						num2 = num3;
						while (this.$STATIC$expand$2001$input_bit_count < this.BITS)
						{
							this.$STATIC$expand$2001$input_bit_buffer = ((this.$STATIC$expand$2001$input_bit_buffer << 8 | (uint)this.brInput.ReadByte()) & this.$STATIC$expand$2001$Mask32);
							this.$STATIC$expand$2001$input_bit_count += 8;
						}
						num3 = (int)((ushort)(this.$STATIC$expand$2001$input_bit_buffer >> this.$STATIC$expand$2001$input_bit_count - this.BITS & (uint)this.$STATIC$expand$2001$resMask));
						this.$STATIC$expand$2001$input_bit_count -= this.BITS;
					}
					return;
				}
				Block_9:
				this.bwOutput.Flush();
				this.bwOutput.Close();
				long position = this.brInput.BaseStream.Position;
				throw new ApplicationException("Fatal error during iCurrCode expansion.");
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00122688 File Offset: 0x00121688
		public void expandNonOpt()
		{
			byte[] array = new byte[18042];
			checked
			{
				for (;;)
				{
					IL_0D:
					this.BITS = 9;
					this.MAX_VALUE = (1 << this.BITS) - 1;
					this.MAX_CODE = this.MAX_VALUE - 1;
					this.FIRST_CODE = 258;
					int num = this.FIRST_CODE;
					int num2 = this.input_code(true);
					byte b = (byte)num2;
					this.WriteByte((byte)num2);
					for (int num3 = this.input_code(false); num3 != this.EOI; num3 = this.input_code(false))
					{
						bool flag = num3 == this.CLEAR_CODE;
						if (flag)
						{
							goto IL_0D;
						}
						flag = (num3 >= num);
						int i;
						int j;
						if (flag)
						{
							array[0] = b;
							i = 1;
							j = num2;
						}
						else
						{
							i = 0;
							j = num3;
						}
						while (j >= this.FIRST_CODE)
						{
							array[i] = this.baAppend_Character[j];
							i++;
							flag = (i > this.MAX_VALUE);
							if (flag)
							{
								goto Block_3;
							}
							j = this.iaPrefix_Code[j];
						}
						array[i] = (byte)j;
						b = array[i];
						while (i >= 0)
						{
							this.WriteByte(array[i]);
							i--;
						}
						flag = (num <= this.MAX_VALUE);
						if (flag)
						{
							this.iaPrefix_Code[num] = num2;
							this.baAppend_Character[num] = b;
							num++;
						}
						flag = (num > this.MAX_VALUE);
						if (flag)
						{
							bool flag2 = this.BITS < this.MAX_BITS;
							if (flag2)
							{
								this.BITS++;
								this.MAX_VALUE = (1 << this.BITS) - 1;
								this.MAX_CODE = this.MAX_VALUE - 1;
							}
						}
						num2 = num3;
					}
					return;
				}
				Block_3:
				this.bwOutput.Flush();
				this.bwOutput.Close();
				long position = this.brInput.BaseStream.Position;
				throw new ApplicationException("Fatal error during iCurrCode expansion.");
			}
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0012287C File Offset: 0x0012187C
		public void expandWithCodes()
		{
			byte[] array = new byte[18042];
			checked
			{
				int num;
				int num3;
				for (;;)
				{
					IL_0D:
					this.BITS = 9;
					this.MAX_VALUE = (1 << this.BITS) - 1;
					this.MAX_CODE = this.MAX_VALUE - 1;
					this.FIRST_CODE = 258;
					num = this.FIRST_CODE;
					this.codesOutput.WriteLine("new stream. BITS = " + Conversions.ToString(this.BITS));
					int num2 = this.input_code(true);
					this.dumpChar(num2, num);
					byte b = (byte)num2;
					this.WriteByteDebug((byte)num2);
					num3 = this.input_code(false);
					this.dumpChar(num3, num);
					while (num3 != this.EOI)
					{
						bool flag = num3 == this.CLEAR_CODE;
						if (flag)
						{
							goto IL_0D;
						}
						flag = (num3 >= num);
						int i;
						int j;
						if (flag)
						{
							array[0] = b;
							i = 1;
							j = num2;
						}
						else
						{
							i = 0;
							j = num3;
						}
						while (j >= this.FIRST_CODE)
						{
							array[i] = this.baAppend_Character[j];
							i++;
							flag = (i > this.MAX_VALUE);
							if (flag)
							{
								goto Block_3;
							}
							j = this.iaPrefix_Code[j];
						}
						array[i] = (byte)j;
						b = array[i];
						while (i >= 0)
						{
							this.WriteByteDebug(array[i]);
							i--;
						}
						flag = (num <= this.MAX_VALUE);
						if (flag)
						{
							this.codesOutput.WriteLine("Entry #" + num.ToString("X4") + " added to string table");
							this.iaPrefix_Code[num] = num2;
							this.baAppend_Character[num] = b;
							num++;
						}
						else
						{
							this.codesOutput.WriteLine("Table full, no entry added");
						}
						flag = (num > this.MAX_VALUE);
						if (flag)
						{
							bool flag2 = this.BITS < this.MAX_BITS;
							if (flag2)
							{
								this.codesOutput.WriteLine("MAX_CODE reached code size " + Conversions.ToString(this.BITS) + " -> " + Conversions.ToString(this.BITS + 1));
								this.BITS++;
								this.MAX_VALUE = (1 << this.BITS) - 1;
								this.MAX_CODE = this.MAX_VALUE - 1;
							}
							else
							{
								this.codesOutput.WriteLine("MAX_CODE reached code size " + Conversions.ToString(this.BITS));
							}
						}
						num2 = num3;
						num3 = this.input_code(false);
						this.dumpChar(num3, num);
					}
					goto Block_9;
				}
				Block_3:
				this.bwOutput.Flush();
				this.bwOutput.Close();
				long position = this.brInput.BaseStream.Position;
				throw new ApplicationException("Fatal error during iCurrCode expansion.");
				Block_9:
				this.dumpChar(num3, num);
			}
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00122B54 File Offset: 0x00121B54
		private int input_code(bool resynchro)
		{
			Monitor.Enter(this.$STATIC$input_code$20182$input_bit_count$Init);
			try
			{
				bool flag = this.$STATIC$input_code$20182$input_bit_count$Init.State == 0;
				if (flag)
				{
					this.$STATIC$input_code$20182$input_bit_count$Init.State = 2;
					this.$STATIC$input_code$20182$input_bit_count = 0;
				}
				else
				{
					flag = (this.$STATIC$input_code$20182$input_bit_count$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$input_code$20182$input_bit_count$Init.State = 1;
				Monitor.Exit(this.$STATIC$input_code$20182$input_bit_count$Init);
			}
			Monitor.Enter(this.$STATIC$input_code$20182$input_bit_buffer$Init);
			try
			{
				bool flag = this.$STATIC$input_code$20182$input_bit_buffer$Init.State == 0;
				if (flag)
				{
					this.$STATIC$input_code$20182$input_bit_buffer$Init.State = 2;
					this.$STATIC$input_code$20182$input_bit_buffer = 0L;
				}
				else
				{
					flag = (this.$STATIC$input_code$20182$input_bit_buffer$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$input_code$20182$input_bit_buffer$Init.State = 1;
				Monitor.Exit(this.$STATIC$input_code$20182$input_bit_buffer$Init);
			}
			Monitor.Enter(this.$STATIC$input_code$20182$Mask32$Init);
			try
			{
				bool flag = this.$STATIC$input_code$20182$Mask32$Init.State == 0;
				if (flag)
				{
					this.$STATIC$input_code$20182$Mask32$Init.State = 2;
					this.$STATIC$input_code$20182$Mask32 = (long)((ulong)-1);
				}
				else
				{
					flag = (this.$STATIC$input_code$20182$Mask32$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$input_code$20182$Mask32$Init.State = 1;
				Monitor.Exit(this.$STATIC$input_code$20182$Mask32$Init);
			}
			checked
			{
				if (resynchro)
				{
					int num = this.$STATIC$input_code$20182$input_bit_count % 8;
					this.$STATIC$input_code$20182$input_bit_count -= num;
					this.$STATIC$input_code$20182$input_bit_buffer = (this.$STATIC$input_code$20182$input_bit_buffer << num & this.$STATIC$input_code$20182$Mask32);
				}
				while (this.$STATIC$input_code$20182$input_bit_count <= 24)
				{
					this.$STATIC$input_code$20182$input_bit_buffer = ((this.$STATIC$input_code$20182$input_bit_buffer | unchecked((long)((long)this.ReadByte() << checked(24 - this.$STATIC$input_code$20182$input_bit_count)))) & this.$STATIC$input_code$20182$Mask32);
					this.$STATIC$input_code$20182$input_bit_count += 8;
				}
				long num2 = this.$STATIC$input_code$20182$input_bit_buffer >> 32 - this.BITS & this.$STATIC$input_code$20182$Mask32;
				this.$STATIC$input_code$20182$input_bit_buffer = (this.$STATIC$input_code$20182$input_bit_buffer << this.BITS & this.$STATIC$input_code$20182$Mask32);
				this.$STATIC$input_code$20182$input_bit_count -= this.BITS;
				return (int)num2;
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00122D98 File Offset: 0x00121D98
		private void WriteByteDebug(byte b)
		{
			this.bwOutput.Write(b);
			this.bwOutput.Flush();
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00122DB8 File Offset: 0x00121DB8
		private void WriteByte(byte b)
		{
			this.bwOutput.Write(b);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00122DCC File Offset: 0x00121DCC
		private int ReadByte()
		{
			byte[] array = new byte[2];
			int num = this.brInput.Read(array, 0, 1);
			bool flag = num == 0;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				result = (int)array[0];
			}
			return result;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00122E04 File Offset: 0x00121E04
		private void dumpChar(int icode, int iNextCode)
		{
			string text = "";
			bool flag = icode == this.CLEAR_CODE;
			if (flag)
			{
				this.codesOutput.WriteLine("<CC> " + icode.ToString("X4") + " position: " + this.brInput.BaseStream.Position.ToString("X8"));
			}
			else
			{
				flag = (icode == this.EOI);
				if (flag)
				{
					this.codesOutput.WriteLine("<EOI> " + icode.ToString("X4") + " position: " + this.brInput.BaseStream.Position.ToString("X8"));
				}
				else
				{
					flag = (icode >= 33 && icode <= 127);
					string text2;
					if (flag)
					{
						text2 = Conversions.ToString(Strings.Chr(icode));
					}
					else
					{
						text2 = "*";
					}
					flag = (icode >= this.FIRST_CODE & icode >= checked(iNextCode + 1));
					if (flag)
					{
						text = "Err unknow entry in the table!";
					}
					this.codesOutput.WriteLine(string.Concat(new string[]
					{
						icode.ToString("X4"),
						"(",
						text2,
						" )position: ",
						this.brInput.BaseStream.Position.ToString("X8"),
						"  ",
						text
					}));
				}
			}
			this.codesOutput.Flush();
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00122F9C File Offset: 0x00121F9C
		public void dumpCodesRT3()
		{
			this.INIT_BITS = 8;
			checked
			{
				this.CLEAR_CODE = (int)Math.Round(Math.Pow(2.0, (double)this.INIT_BITS));
				this.EOI = this.CLEAR_CODE + 1;
				this.BITS = this.INIT_BITS + 1;
				this.MAX_VALUE = (1 << this.BITS) - 1;
				this.MAX_CODE = this.MAX_VALUE - 1;
				int num = this.input_code(false);
				this.dumpChar(num, 0);
				for (num = this.input_code(false); num != this.EOI; num = this.input_code(false))
				{
					bool flag = num == this.CLEAR_CODE;
					if (flag)
					{
						bool flag2 = this.BITS < 12;
						if (flag2)
						{
							this.BITS++;
						}
						else
						{
							this.BITS = 9;
						}
						this.BITS = 9;
						this.MAX_VALUE = (1 << this.BITS) - 1;
						this.MAX_CODE = this.MAX_VALUE - 1;
						this.codesOutput.WriteLine("<CC> " + num.ToString("X4") + " position: " + this.brInput.BaseStream.Position.ToString("X8"));
						this.codesOutput.Flush();
					}
					else
					{
						bool flag2 = num == this.MAX_VALUE;
						if (flag2)
						{
							this.BITS++;
							this.MAX_VALUE = (1 << this.BITS) - 1;
							this.MAX_CODE = this.MAX_VALUE - 1;
							this.codesOutput.WriteLine("<MAX VALUE> " + num.ToString("X4") + " position: " + this.brInput.BaseStream.Position.ToString("X8"));
							this.codesOutput.Flush();
						}
						else
						{
							this.dumpChar(num, 0);
						}
					}
				}
				this.codesOutput.WriteLine("<EOI> " + num.ToString("X4") + " position: " + this.brInput.BaseStream.Position.ToString("X8"));
			}
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x001231E0 File Offset: 0x001221E0
		public void dumpCodesLZW()
		{
			int num = this.input_code(false);
			this.codesOutput.WriteLine(num.ToString("X4"));
			for (num = this.input_code(false); num != this.MAX_VALUE; num = this.input_code(false))
			{
				this.codesOutput.WriteLine(num.ToString("X4"));
			}
		}

		// Token: 0x040005D9 RID: 1497
		private int INIT_BITS;

		// Token: 0x040005DA RID: 1498
		private int BITS;

		// Token: 0x040005DB RID: 1499
		private int MAX_BITS;

		// Token: 0x040005DC RID: 1500
		private int HASHING_SHIFT;

		// Token: 0x040005DD RID: 1501
		private int MAX_VALUE;

		// Token: 0x040005DE RID: 1502
		private int MAX_CODE;

		// Token: 0x040005DF RID: 1503
		private int CLEAR_CODE;

		// Token: 0x040005E0 RID: 1504
		private int EOI;

		// Token: 0x040005E1 RID: 1505
		private int FIRST_CODE;

		// Token: 0x040005E2 RID: 1506
		private const int TABLE_SIZE = 18041;

		// Token: 0x040005E3 RID: 1507
		private int EOF;

		// Token: 0x040005E4 RID: 1508
		public BinaryReader brInput;

		// Token: 0x040005E5 RID: 1509
		public BinaryReader br1Input;

		// Token: 0x040005E6 RID: 1510
		public BinaryWriter bwOutput;

		// Token: 0x040005E7 RID: 1511
		public StreamWriter codesOutput;

		// Token: 0x040005E8 RID: 1512
		private int[] iaCode_Value;

		// Token: 0x040005E9 RID: 1513
		private int[] iaPrefix_Code;

		// Token: 0x040005EA RID: 1514
		private byte[] baAppend_Character;

		// Token: 0x040005EB RID: 1515
		private int $STATIC$expand$2001$input_bit_count;

		// Token: 0x040005EC RID: 1516
		private int $STATIC$input_code$20182$input_bit_count;

		// Token: 0x040005ED RID: 1517
		private StaticLocalInitFlag $STATIC$output_code$20118$output_bit_count$Init;

		// Token: 0x040005EE RID: 1518
		private uint $STATIC$expand$2001$input_bit_buffer;

		// Token: 0x040005EF RID: 1519
		private long $STATIC$input_code$20182$input_bit_buffer;

		// Token: 0x040005F0 RID: 1520
		private StaticLocalInitFlag $STATIC$output_code$20118$output_bit_buffer$Init;

		// Token: 0x040005F1 RID: 1521
		private uint $STATIC$expand$2001$Mask32;

		// Token: 0x040005F2 RID: 1522
		private long $STATIC$input_code$20182$Mask32;

		// Token: 0x040005F3 RID: 1523
		private StaticLocalInitFlag $STATIC$expand$2001$input_bit_count$Init;

		// Token: 0x040005F4 RID: 1524
		private ushort $STATIC$expand$2001$resMask;

		// Token: 0x040005F5 RID: 1525
		private StaticLocalInitFlag $STATIC$input_code$20182$input_bit_count$Init;

		// Token: 0x040005F6 RID: 1526
		private StaticLocalInitFlag $STATIC$expand$2001$input_bit_buffer$Init;

		// Token: 0x040005F7 RID: 1527
		private StaticLocalInitFlag $STATIC$input_code$20182$input_bit_buffer$Init;

		// Token: 0x040005F8 RID: 1528
		private StaticLocalInitFlag $STATIC$expand$2001$Mask32$Init;

		// Token: 0x040005F9 RID: 1529
		private StaticLocalInitFlag $STATIC$input_code$20182$Mask32$Init;

		// Token: 0x040005FA RID: 1530
		private StaticLocalInitFlag $STATIC$expand$2001$resMask$Init;

		// Token: 0x040005FB RID: 1531
		private int $STATIC$output_code$20118$output_bit_count;

		// Token: 0x040005FC RID: 1532
		private long $STATIC$output_code$20118$output_bit_buffer;
	}
}
