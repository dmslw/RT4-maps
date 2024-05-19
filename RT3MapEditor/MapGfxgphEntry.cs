using System;
using System.IO;
using System.Text;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x02000071 RID: 113
	public class MapGfxgphEntry
	{
		// Token: 0x06000D15 RID: 3349 RVA: 0x0011F0CC File Offset: 0x0011E0CC
		public MapGfxgphEntry(RT3Reader RT3Reader, MapGfxgphHeaders header, uint entryNumner, ref long lastPosUsed)
		{
			this.fileName = new byte[48];
			this.oEncoder = new ASCIIEncoding();
			this.loadFromFile(RT3Reader, header, entryNumner, ref lastPosUsed);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0011F0FC File Offset: 0x0011E0FC
		private void loadFromFile(RT3Reader RT3Reader, MapGfxgphHeaders header, uint entryNumner, ref long lastPosUsed)
		{
			checked
			{
				RT3Reader.BaseStream.Seek((long)(64UL + unchecked((ulong)entryNumner) * 60UL), SeekOrigin.Begin);
				this.fileName = RT3Reader.ReadBytes(47);
				this.unk1 = RT3Reader.ReadByte();
				bool flag = this.unk1 != byte.MaxValue && this.unk1 != 0;
				if (flag)
				{
					MyProject.Forms.ContAbortErrBox.showError(string.Format("Unknown {0:G} value for unk1 (&HFF)", this.unk1.ToString()), true, true, true);
				}
				this.ptr1ToBloc = RT3Reader.readRT3Uint32();
				this.ptr = (long)(unchecked((ulong)this.ptr1ToBloc) + 60UL);
				flag = (this.ptr < (long)(64UL + 60UL * unchecked((ulong)header.recordNb)) || this.ptr < lastPosUsed);
				if (flag)
				{
					MyProject.Forms.ContAbortErrBox.showError(string.Format("Incorrect value for ptr1ToBloc {0:X} in entry {1:X)", this.ptr1ToBloc, entryNumner), true, true, true);
				}
				this.blocLength = RT3Reader.readRT3Uint32();
				flag = (this.ptr + (long)(unchecked((ulong)this.blocLength)) > RT3Reader.BaseStream.Length);
				if (flag)
				{
					MyProject.Forms.ContAbortErrBox.showError(string.Format("Incorrect value for blocLength {0:X} in entry {1:X)", this.blocLength, entryNumner), true, true, true);
				}
				this.ptr2ToBloc = RT3Reader.readRT3Uint32();
				flag = (this.ptr2ToBloc != this.ptr1ToBloc);
				if (flag)
				{
					MyProject.Forms.ContAbortErrBox.showError(string.Format("Incorrect value for ptr2ToBloc {0:X} in entry {1:X)", this.ptr2ToBloc, entryNumner), true, true, true);
				}
				RT3Reader.BaseStream.Seek(this.ptr, SeekOrigin.Begin);
				this.bloc = RT3Reader.ReadBytes((int)this.blocLength);
				lastPosUsed = RT3Reader.BaseStream.Position;
			}
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0011F2D8 File Offset: 0x0011E2D8
		public static long firstDataAddr(MapGfxgphHeaders header)
		{
			return (long)(checked(64UL + unchecked((ulong)header.recordNb) * 60UL - 1UL));
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0011F2FC File Offset: 0x0011E2FC
		public void saveEntryAsFile(string strBasePath, int i)
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			stringBuilder.Append(i.ToString("X4"));
			bool flag = this.isDDSEntry();
			if (flag)
			{
				stringBuilder.Append("-DDS");
				stringBuilder.Append("-");
				stringBuilder.Append(this.getSurfaceFormat());
			}
			stringBuilder.Append("-");
			string text = this.oEncoder.GetString(this.fileName).Replace("/", "\\");
			flag = (text.IndexOf('\0') != -1);
			if (flag)
			{
				text = text.Substring(0, text.IndexOf('\0'));
			}
			stringBuilder.Append(Path.GetFileName(text));
			string path = Path.Combine(strBasePath, stringBuilder.ToString());
			FileStream fileStream = new FileStream(path, FileMode.Create);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			binaryWriter.Write(this.bloc);
			binaryWriter.Close();
			fileStream.Close();
			text = Path.Combine(strBasePath, text);
			flag = !MyProject.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(text));
			if (flag)
			{
				MyProject.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(text));
			}
			FileStream fileStream2 = new FileStream(text, FileMode.Create);
			BinaryWriter binaryWriter2 = new BinaryWriter(fileStream2);
			binaryWriter2.Write(this.bloc);
			binaryWriter2.Close();
			fileStream2.Close();
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0011F468 File Offset: 0x0011E468
		private bool isDDSEntry()
		{
			bool flag = this.bloc.Length > 4;
			return flag && (this.bloc[0] == 68 & this.bloc[1] == 68 & this.bloc[2] == 83 & this.bloc[3] == 32);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0011F4C4 File Offset: 0x0011E4C4
		private string getSurfaceFormat()
		{
			bool flag = this.bloc[80] == 64;
			string result;
			if (flag)
			{
				result = "RGB";
			}
			else
			{
				flag = (this.bloc[80] == 65);
				if (flag)
				{
					result = "ARGB";
				}
				else
				{
					flag = (this.bloc[80] == 4);
					if (flag)
					{
						result = this.oEncoder.GetString(this.bloc, 84, 4);
					}
					else
					{
						result = "";
					}
				}
			}
			return result;
		}

		// Token: 0x0400055B RID: 1371
		private const byte DDPF_ALPHAPIXELS = 1;

		// Token: 0x0400055C RID: 1372
		private const byte DDPF_FOURCC = 4;

		// Token: 0x0400055D RID: 1373
		private const byte DDPF_RGB = 64;

		// Token: 0x0400055E RID: 1374
		private const int FILENAME_SIZE = 47;

		// Token: 0x0400055F RID: 1375
		private const int BAT_ENTRY_SIZE = 60;

		// Token: 0x04000560 RID: 1376
		private const byte UNK1_VALUE1 = 255;

		// Token: 0x04000561 RID: 1377
		private const byte UNK1_VALUE2 = 0;

		// Token: 0x04000562 RID: 1378
		public byte[] fileName;

		// Token: 0x04000563 RID: 1379
		public byte unk1;

		// Token: 0x04000564 RID: 1380
		public uint ptr1ToBloc;

		// Token: 0x04000565 RID: 1381
		public uint blocLength;

		// Token: 0x04000566 RID: 1382
		public uint ptr2ToBloc;

		// Token: 0x04000567 RID: 1383
		public byte[] bloc;

		// Token: 0x04000568 RID: 1384
		public long ptr;

		// Token: 0x04000569 RID: 1385
		private ASCIIEncoding oEncoder;
	}
}
