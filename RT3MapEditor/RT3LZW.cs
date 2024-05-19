using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x020000C5 RID: 197
	public class RT3LZW
	{
		// Token: 0x06000E20 RID: 3616 RVA: 0x0012CB6C File Offset: 0x0012BB6C
		public RT3LZW(string fileName, RT3LZW.mode mode, int blocSize)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.RT3Writer = null;
			this.HASHING_SHIFT = 4;
			this.BITS = 9;
			this.MAX_BITS = 10;
			checked
			{
				this.CLEAR_CODE = 1 << this.BITS - 1;
				this.EOI = this.CLEAR_CODE + 1;
				this.FIRST_CODE = this.CLEAR_CODE + 2;
				this.MAX_VALUE = (1 << this.BITS) - 1;
				this.MAX_CODE = this.MAX_VALUE - 1;
				this.iaCode_Value = new int[5022];
				this.iaPrefix_Code = new int[5022];
				this.baAppend_Character = new byte[5022];
				this.$STATIC$expandLZWStream$20311281711281758$input_bit_count$Init = new StaticLocalInitFlag();
				this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer$Init = new StaticLocalInitFlag();
				this.$STATIC$expandLZWStream$20311281711281758$Mask32$Init = new StaticLocalInitFlag();
				this.$STATIC$expandLZWStream$20311281711281758$resMask$Init = new StaticLocalInitFlag();
				this.FileName = fileName;
				this.fmode = mode;
				this.blocSize = blocSize;
				bool flag = mode == RT3LZW.mode.read;
				if (flag)
				{
					this.expandRT3File(blocSize);
				}
				else
				{
					this.compressRT3File(blocSize);
				}
			}
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0012CC8C File Offset: 0x0012BC8C
		private void compressRT3File(int blocSize)
		{
			BinaryReader binaryReader = new BinaryReader(new FileStream(this.FileName, FileMode.Open, FileAccess.Read));
			string text = this.FileName + ".lzw";
			bool flag = MyProject.Computer.FileSystem.FileExists(text);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(text);
			}
			BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, FileMode.OpenOrCreate, FileAccess.Write));
			this.blocTable = new List<RT3LZW.blocTableRecords>();
			binaryWriter.Seek(14, SeekOrigin.Begin);
			this.compressLZWStream(binaryReader, binaryWriter, this.blocTable, blocSize);
			this.RT3LZWHeader = new RT3LZW.RT3LZWHeaders();
			RT3LZW.RT3LZWHeaders rt3LZWHeader = this.RT3LZWHeader;
			rt3LZWHeader.header = 21330;
			checked
			{
				rt3LZWHeader.blocNumber = (uint)this.blocTable.Count;
				rt3LZWHeader.blocTablePtr = (uint)binaryWriter.BaseStream.Position;
				rt3LZWHeader.decompressedLen = (uint)binaryReader.BaseStream.Length;
				try
				{
					foreach (RT3LZW.blocTableRecords blocTableRecords in this.blocTable)
					{
						binaryWriter.Write(blocTableRecords.blocPtr);
						binaryWriter.Write(blocTableRecords.expandedIdx);
					}
				}
				finally
				{
					List<RT3LZW.blocTableRecords>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				binaryWriter.Seek(0, SeekOrigin.Begin);
				RT3LZW.RT3LZWHeaders rt3LZWHeader2 = this.RT3LZWHeader;
				binaryWriter.Write(rt3LZWHeader2.header);
				binaryWriter.Write(rt3LZWHeader2.blocNumber);
				binaryWriter.Write(rt3LZWHeader2.blocTablePtr);
				binaryWriter.Write(rt3LZWHeader2.decompressedLen);
				binaryWriter.Close();
				binaryReader.Close();
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0012CE34 File Offset: 0x0012BE34
		public void compressLZWStream(BinaryReader brInput, BinaryWriter bwOutput, List<RT3LZW.blocTableRecords> blocTable, int blocSize)
		{
			int num = 0;
			int i = 0;
			int num2 = 0;
			long num3 = 0L;
			RT3LZW.blocTableRecords blocTableRecords = null;
			int num4 = this.FIRST_CODE;
			this.BITS = 9;
			checked
			{
				this.MAX_VALUE = (1 << this.BITS) - 1;
				this.MAX_CODE = this.MAX_VALUE - 1;
				int num5 = 0;
				int num6;
				int num7;
				do
				{
					this.iaCode_Value[num5] = -1;
					num5++;
					num6 = num5;
					num7 = 5020;
				}
				while (num6 <= num7);
				bool flag2;
				try
				{
					num = (int)brInput.ReadByte();
					for (;;)
					{
						IL_71:
						int num8 = (int)brInput.ReadByte();
						for (;;)
						{
							int num9 = this.find_match(num, num8);
							bool flag = this.iaCode_Value[num9] != -1;
							if (flag)
							{
								num = this.iaCode_Value[num9];
							}
							else
							{
								num2 = (num2 << this.BITS | (num & this.MAX_VALUE));
								i += this.BITS;
								while (i > 8)
								{
									flag = (num3 % unchecked((long)blocSize) == 0L);
									if (flag)
									{
										flag2 = (blocTableRecords != null);
										if (flag2)
										{
											blocTableRecords.expandedIdx = (uint)brInput.BaseStream.Position - 2U;
										}
										blocTableRecords = new RT3LZW.blocTableRecords();
										blocTableRecords.blocPtr = (uint)bwOutput.BaseStream.Position;
										blocTable.Add(blocTableRecords);
									}
									bwOutput.Write((byte)(num2 >> i - 8 & 255));
									i -= 8;
									num3 += 1L;
								}
								flag2 = (num4 <= this.MAX_VALUE + 1);
								if (flag2)
								{
									this.iaCode_Value[num9] = num4;
									num4++;
									this.iaPrefix_Code[num9] = num;
									this.baAppend_Character[num9] = (byte)num8;
								}
								flag2 = (num4 > this.MAX_VALUE + 1);
								if (flag2)
								{
									flag = (this.BITS == 9);
									if (!flag)
									{
										num2 = (num2 << this.BITS | this.CLEAR_CODE);
										i += this.BITS;
										while (i > 8)
										{
											flag2 = (num3 % unchecked((long)blocSize) == 0L);
											if (flag2)
											{
												flag = (blocTableRecords != null);
												if (flag)
												{
													blocTableRecords.expandedIdx = (uint)brInput.BaseStream.Position - 2U;
												}
												blocTableRecords = new RT3LZW.blocTableRecords();
												blocTableRecords.blocPtr = (uint)bwOutput.BaseStream.Position;
												blocTable.Add(blocTableRecords);
											}
											bwOutput.Write((byte)(num2 >> i - 8 & 255));
											i -= 8;
											num3 += 1L;
										}
										flag2 = (i > 0);
										if (flag2)
										{
											num2 <<= 8 - i;
											i = 8;
											flag2 = (num3 % unchecked((long)blocSize) == 0L);
											if (flag2)
											{
												flag = (blocTableRecords != null);
												if (flag)
												{
													blocTableRecords.expandedIdx = (uint)brInput.BaseStream.Position - 2U;
												}
												blocTableRecords = new RT3LZW.blocTableRecords();
												blocTableRecords.blocPtr = (uint)bwOutput.BaseStream.Position;
												blocTable.Add(blocTableRecords);
											}
											bwOutput.Write((byte)(num2 >> i - 8 & 255));
											num3 += 1L;
										}
										num2 = 0;
										i = 0;
										num4 = this.FIRST_CODE;
										this.BITS = 9;
										this.MAX_VALUE = (1 << this.BITS) - 1;
										this.MAX_CODE = this.MAX_VALUE - 1;
										int num10 = 0;
										int num11;
										do
										{
											this.iaCode_Value[num10] = -1;
											num10++;
											num11 = num10;
											num7 = 5020;
										}
										while (num11 <= num7);
										num = num8;
										goto IL_71;
									}
									this.BITS = 10;
									this.MAX_VALUE = (1 << this.BITS) - 1;
									this.MAX_CODE = this.MAX_VALUE - 1;
								}
								num = num8;
							}
							num8 = (int)brInput.ReadByte();
						}
						break;
					}
				}
				catch (EndOfStreamException ex)
				{
				}
				catch (Exception ex2)
				{
					throw;
				}
				num2 = (num2 << this.BITS | (num & this.MAX_VALUE));
				i += this.BITS;
				while (i > 8)
				{
					flag2 = (num3 % unchecked((long)blocSize) == 0L);
					if (flag2)
					{
						bool flag = blocTableRecords != null;
						if (flag)
						{
							blocTableRecords.expandedIdx = (uint)brInput.BaseStream.Position - 2U;
						}
						blocTableRecords = new RT3LZW.blocTableRecords();
						blocTableRecords.blocPtr = (uint)bwOutput.BaseStream.Position;
						blocTable.Add(blocTableRecords);
					}
					bwOutput.Write((byte)(num2 >> i - 8 & 255));
					i -= 8;
					num3 += 1L;
				}
				num2 = (num2 << this.BITS | this.EOI);
				i += this.BITS;
				while (i > 8)
				{
					flag2 = (num3 % unchecked((long)blocSize) == 0L);
					if (flag2)
					{
						blocTableRecords.expandedIdx = (uint)brInput.BaseStream.Position - 2U;
						blocTableRecords = new RT3LZW.blocTableRecords();
						blocTableRecords.blocPtr = (uint)bwOutput.BaseStream.Position;
						blocTable.Add(blocTableRecords);
					}
					bwOutput.Write((byte)(num2 >> i - 8 & 255));
					i -= 8;
					num3 += 1L;
				}
				flag2 = (i > 0);
				if (flag2)
				{
					num2 <<= 8 - i;
					i = 8;
					blocTableRecords.expandedIdx = (uint)brInput.BaseStream.Position - 1U;
					bwOutput.Write((byte)(num2 >> i - 8 & 255));
					num3 += 1L;
				}
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0012D3C0 File Offset: 0x0012C3C0
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
					num2 = 5021 - num;
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
						num += 5021;
					}
				}
				return result;
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0012D448 File Offset: 0x0012C448
		private void expandRT3File(int blocSize)
		{
			BinaryReader binaryReader = new BinaryReader(new FileStream(this.FileName, FileMode.Open, FileAccess.Read));
			this.RT3LZWHeader = new RT3LZW.RT3LZWHeaders();
			RT3LZW.RT3LZWHeaders rt3LZWHeader = this.RT3LZWHeader;
			rt3LZWHeader.header = binaryReader.ReadUInt16();
			rt3LZWHeader.blocNumber = binaryReader.ReadUInt32();
			rt3LZWHeader.blocTablePtr = binaryReader.ReadUInt32();
			rt3LZWHeader.decompressedLen = binaryReader.ReadUInt32();
			bool flag = rt3LZWHeader.header != 21330;
			if (flag)
			{
				throw new Exception(string.Format("{0:G} is not a valid RT3 compressed file", this.FileName));
			}
			this.blocTable = new List<RT3LZW.blocTableRecords>();
			binaryReader.BaseStream.Seek((long)((ulong)this.RT3LZWHeader.blocTablePtr), SeekOrigin.Begin);
			ushort num = 0;
			ushort num2 = checked((ushort)(unchecked((ulong)this.RT3LZWHeader.blocNumber) - 1UL));
			ushort num3 = num;
			for (;;)
			{
				ushort num4 = num3;
				ushort num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				RT3LZW.blocTableRecords blocTableRecords = new RT3LZW.blocTableRecords();
				RT3LZW.blocTableRecords blocTableRecords2 = blocTableRecords;
				blocTableRecords2.blocPtr = binaryReader.ReadUInt32();
				blocTableRecords2.expandedIdx = binaryReader.ReadUInt32();
				this.blocTable.Add(blocTableRecords);
				num3 += 1;
			}
			string text = this.FileName + ".exp";
			flag = MyProject.Computer.FileSystem.FileExists(text);
			if (flag)
			{
				MyProject.Computer.FileSystem.DeleteFile(text);
			}
			BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, FileMode.OpenOrCreate, FileAccess.Write));
			binaryReader.BaseStream.Seek(14L, SeekOrigin.Begin);
			this.expandLZWStream(binaryReader, binaryWriter, blocSize);
			binaryWriter.Close();
			binaryReader.Close();
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0012D5D4 File Offset: 0x0012C5D4
		private void expandLZWStream(BinaryReader brInput, BinaryWriter bwOutput, int blocSize)
		{
			byte[] array = new byte[5022];
			Monitor.Enter(this.$STATIC$expandLZWStream$20311281711281758$input_bit_count$Init);
			try
			{
				bool flag = this.$STATIC$expandLZWStream$20311281711281758$input_bit_count$Init.State == 0;
				if (flag)
				{
					this.$STATIC$expandLZWStream$20311281711281758$input_bit_count$Init.State = 2;
					this.$STATIC$expandLZWStream$20311281711281758$input_bit_count = 0;
				}
				else
				{
					flag = (this.$STATIC$expandLZWStream$20311281711281758$input_bit_count$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$expandLZWStream$20311281711281758$input_bit_count$Init.State = 1;
				Monitor.Exit(this.$STATIC$expandLZWStream$20311281711281758$input_bit_count$Init);
			}
			Monitor.Enter(this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer$Init);
			try
			{
				bool flag = this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer$Init.State == 0;
				if (flag)
				{
					this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer$Init.State = 2;
					this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer = 0U;
				}
				else
				{
					flag = (this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer$Init.State = 1;
				Monitor.Exit(this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer$Init);
			}
			Monitor.Enter(this.$STATIC$expandLZWStream$20311281711281758$Mask32$Init);
			try
			{
				bool flag = this.$STATIC$expandLZWStream$20311281711281758$Mask32$Init.State == 0;
				if (flag)
				{
					this.$STATIC$expandLZWStream$20311281711281758$Mask32$Init.State = 2;
					this.$STATIC$expandLZWStream$20311281711281758$Mask32 = uint.MaxValue;
				}
				else
				{
					flag = (this.$STATIC$expandLZWStream$20311281711281758$Mask32$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$expandLZWStream$20311281711281758$Mask32$Init.State = 1;
				Monitor.Exit(this.$STATIC$expandLZWStream$20311281711281758$Mask32$Init);
			}
			Monitor.Enter(this.$STATIC$expandLZWStream$20311281711281758$resMask$Init);
			try
			{
				bool flag = this.$STATIC$expandLZWStream$20311281711281758$resMask$Init.State == 0;
				if (flag)
				{
					this.$STATIC$expandLZWStream$20311281711281758$resMask$Init.State = 2;
					this.$STATIC$expandLZWStream$20311281711281758$resMask = 511;
				}
				else
				{
					flag = (this.$STATIC$expandLZWStream$20311281711281758$resMask$Init.State == 2);
					if (flag)
					{
						throw new IncompleteInitialization();
					}
				}
			}
			finally
			{
				this.$STATIC$expandLZWStream$20311281711281758$resMask$Init.State = 1;
				Monitor.Exit(this.$STATIC$expandLZWStream$20311281711281758$resMask$Init);
			}
			checked
			{
				for (;;)
				{
					IL_1C5:
					this.BITS = 9;
					this.MAX_VALUE = (1 << this.BITS) - 1;
					this.MAX_CODE = this.MAX_VALUE - 1;
					this.$STATIC$expandLZWStream$20311281711281758$resMask = 511;
					int num = this.FIRST_CODE;
					while (this.$STATIC$expandLZWStream$20311281711281758$input_bit_count < this.BITS)
					{
						this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer = ((this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer << 8 | (uint)brInput.ReadByte()) & this.$STATIC$expandLZWStream$20311281711281758$Mask32);
						this.$STATIC$expandLZWStream$20311281711281758$input_bit_count += 8;
					}
					int num2 = (int)((ushort)(this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer >> this.$STATIC$expandLZWStream$20311281711281758$input_bit_count - this.BITS & (uint)this.$STATIC$expandLZWStream$20311281711281758$resMask));
					this.$STATIC$expandLZWStream$20311281711281758$input_bit_count -= this.BITS;
					byte b = (byte)num2;
					bwOutput.Write((byte)num2);
					while (this.$STATIC$expandLZWStream$20311281711281758$input_bit_count < this.BITS)
					{
						this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer = ((this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer << 8 | (uint)brInput.ReadByte()) & this.$STATIC$expandLZWStream$20311281711281758$Mask32);
						this.$STATIC$expandLZWStream$20311281711281758$input_bit_count += 8;
					}
					int num3 = (int)((ushort)(this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer >> this.$STATIC$expandLZWStream$20311281711281758$input_bit_count - this.BITS & (uint)this.$STATIC$expandLZWStream$20311281711281758$resMask));
					this.$STATIC$expandLZWStream$20311281711281758$input_bit_count -= this.BITS;
					while (num3 != this.EOI)
					{
						bool flag = num3 == this.CLEAR_CODE;
						if (flag)
						{
							int num4 = this.$STATIC$expandLZWStream$20311281711281758$input_bit_count % 8;
							this.$STATIC$expandLZWStream$20311281711281758$input_bit_count -= num4;
							this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer = (this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer << num4 & this.$STATIC$expandLZWStream$20311281711281758$Mask32);
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
							bwOutput.Write(array[i]);
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
							this.$STATIC$expandLZWStream$20311281711281758$resMask = 1023;
							this.MAX_VALUE = (1 << this.BITS) - 1;
							this.MAX_CODE = this.MAX_VALUE - 1;
						}
						num2 = num3;
						while (this.$STATIC$expandLZWStream$20311281711281758$input_bit_count < this.BITS)
						{
							this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer = ((this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer << 8 | (uint)brInput.ReadByte()) & this.$STATIC$expandLZWStream$20311281711281758$Mask32);
							this.$STATIC$expandLZWStream$20311281711281758$input_bit_count += 8;
						}
						num3 = (int)((ushort)(this.$STATIC$expandLZWStream$20311281711281758$input_bit_buffer >> this.$STATIC$expandLZWStream$20311281711281758$input_bit_count - this.BITS & (uint)this.$STATIC$expandLZWStream$20311281711281758$resMask));
						this.$STATIC$expandLZWStream$20311281711281758$input_bit_count -= this.BITS;
					}
					return;
				}
				Block_9:
				bwOutput.Flush();
				bwOutput.Close();
				long position = brInput.BaseStream.Position;
				throw new ApplicationException("Fatal error during iCurrCode expansion.");
			}
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0012DB1C File Offset: 0x0012CB1C
		public void _close()
		{
			bool flag = this.fmode == RT3LZW.mode.read;
			if (flag)
			{
				this.RT3Reader.Close();
			}
			else
			{
				this.RT3Writer.Close();
			}
		}

		// Token: 0x0400088A RID: 2186
		public const int HEADERSIZE = 14;

		// Token: 0x0400088B RID: 2187
		public const int BLOCSIZE1 = 929;

		// Token: 0x0400088C RID: 2188
		public const int BLOCSIZE2 = 9290;

		// Token: 0x0400088D RID: 2189
		public const int RECORDSIZE = 8;

		// Token: 0x0400088E RID: 2190
		private string FileName;

		// Token: 0x0400088F RID: 2191
		private RT3Reader RT3Reader;

		// Token: 0x04000890 RID: 2192
		private RT3Writer RT3Writer;

		// Token: 0x04000891 RID: 2193
		private RT3LZW.mode fmode;

		// Token: 0x04000892 RID: 2194
		private int blocSize;

		// Token: 0x04000893 RID: 2195
		private RT3LZW.RT3LZWHeaders RT3LZWHeader;

		// Token: 0x04000894 RID: 2196
		private List<RT3LZW.blocTableRecords> blocTable;

		// Token: 0x04000895 RID: 2197
		private int HASHING_SHIFT;

		// Token: 0x04000896 RID: 2198
		private int BITS;

		// Token: 0x04000897 RID: 2199
		private int MAX_BITS;

		// Token: 0x04000898 RID: 2200
		private int CLEAR_CODE;

		// Token: 0x04000899 RID: 2201
		private int EOI;

		// Token: 0x0400089A RID: 2202
		private int FIRST_CODE;

		// Token: 0x0400089B RID: 2203
		private int MAX_VALUE;

		// Token: 0x0400089C RID: 2204
		private int MAX_CODE;

		// Token: 0x0400089D RID: 2205
		private const int TABLE_SIZE = 5021;

		// Token: 0x0400089E RID: 2206
		private int[] iaCode_Value;

		// Token: 0x0400089F RID: 2207
		private int[] iaPrefix_Code;

		// Token: 0x040008A0 RID: 2208
		private byte[] baAppend_Character;

		// Token: 0x040008A1 RID: 2209
		private StaticLocalInitFlag $STATIC$expandLZWStream$20311281711281758$input_bit_count$Init;

		// Token: 0x040008A2 RID: 2210
		private StaticLocalInitFlag $STATIC$expandLZWStream$20311281711281758$input_bit_buffer$Init;

		// Token: 0x040008A3 RID: 2211
		private StaticLocalInitFlag $STATIC$expandLZWStream$20311281711281758$Mask32$Init;

		// Token: 0x040008A4 RID: 2212
		private int $STATIC$expandLZWStream$20311281711281758$input_bit_count;

		// Token: 0x040008A5 RID: 2213
		private StaticLocalInitFlag $STATIC$expandLZWStream$20311281711281758$resMask$Init;

		// Token: 0x040008A6 RID: 2214
		private uint $STATIC$expandLZWStream$20311281711281758$input_bit_buffer;

		// Token: 0x040008A7 RID: 2215
		private uint $STATIC$expandLZWStream$20311281711281758$Mask32;

		// Token: 0x040008A8 RID: 2216
		private ushort $STATIC$expandLZWStream$20311281711281758$resMask;

		// Token: 0x020000C6 RID: 198
		public class RT3LZWHeaders
		{
			// Token: 0x06000E27 RID: 3623 RVA: 0x0012DB54 File Offset: 0x0012CB54
			[DebuggerNonUserCode]
			public RT3LZWHeaders()
			{
			}

			// Token: 0x040008A9 RID: 2217
			public ushort header;

			// Token: 0x040008AA RID: 2218
			public uint blocNumber;

			// Token: 0x040008AB RID: 2219
			public uint blocTablePtr;

			// Token: 0x040008AC RID: 2220
			public uint decompressedLen;
		}

		// Token: 0x020000C7 RID: 199
		public class blocTableRecords
		{
			// Token: 0x06000E28 RID: 3624 RVA: 0x0012DB60 File Offset: 0x0012CB60
			[DebuggerNonUserCode]
			public blocTableRecords()
			{
			}

			// Token: 0x040008AD RID: 2221
			public uint blocPtr;

			// Token: 0x040008AE RID: 2222
			public uint expandedIdx;
		}

		// Token: 0x020000C8 RID: 200
		public enum mode
		{
			// Token: 0x040008B0 RID: 2224
			read,
			// Token: 0x040008B1 RID: 2225
			write
		}
	}
}
