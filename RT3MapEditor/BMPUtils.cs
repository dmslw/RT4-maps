using System;
using System.IO;

namespace RT3MapEditor
{
	// Token: 0x02000048 RID: 72
	public class BMPUtils
	{
		// Token: 0x06000798 RID: 1944 RVA: 0x0010BC9C File Offset: 0x0010AC9C
		public BMPUtils()
		{
			string path = "Q:\\SW RT3-RT4\\MaJ RT4\\8.10DR11\\Data_Base\\Graphics\\HARM00\\GEN_HA00.gph";
			string path2 = "Q:\\SW RT3-RT4\\MaJ RT4\\8.10DR11\\Data_Base\\Graphics\\HARM00\\img.bmp";
			uint num = 907960U;
			BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.Read));
			binaryReader.BaseStream.Seek((long)((ulong)num), SeekOrigin.Begin);
			ushort num2 = checked((ushort)(unchecked(256 * (int)binaryReader.ReadByte()))) + (ushort)binaryReader.ReadByte();
			ushort num3 = checked((ushort)(unchecked(256 * (int)binaryReader.ReadByte()))) + (ushort)binaryReader.ReadByte();
			BinaryWriter binaryWriter = new BinaryWriter(File.Open(path2, FileMode.Create));
			BMPUtils.bmpHeader bmpHeader;
			bmpHeader.magic = 19778;
			checked
			{
				bmpHeader.fileSize = (uint)(54 + 4 * num2 * num3 - 4);
				bmpHeader.reserved1 = 0;
				bmpHeader.reserved2 = 0;
				bmpHeader.bmpStart = 54U;
				binaryWriter.Write(bmpHeader.magic);
				binaryWriter.Write(bmpHeader.fileSize);
				binaryWriter.Write(bmpHeader.reserved1);
				binaryWriter.Write(bmpHeader.reserved2);
				binaryWriter.Write(bmpHeader.bmpStart);
				BMPUtils.DIBHeader dibheader;
				dibheader.headerSize = 40U;
				dibheader.bmWidth = (int)num2;
				dibheader.bmHeight = (int)num3;
				dibheader.colorPlane = 1;
				dibheader.bpp = 24;
				dibheader.compression = 0U;
				dibheader.bmSize = (uint)(4 * num2 * num3);
				dibheader.hRes = 0U;
				dibheader.vRes = 0U;
				dibheader.palColorNumber = 0U;
				dibheader.importantColorNumber = 0U;
				binaryWriter.Write(dibheader.headerSize);
				binaryWriter.Write(dibheader.bmWidth);
				binaryWriter.Write(dibheader.bmHeight);
				binaryWriter.Write(dibheader.colorPlane);
				binaryWriter.Write(dibheader.bpp);
				binaryWriter.Write(dibheader.compression);
				binaryWriter.Write(dibheader.bmSize);
				binaryWriter.Write(dibheader.hRes);
				binaryWriter.Write(dibheader.vRes);
				binaryWriter.Write(dibheader.palColorNumber);
				binaryWriter.Write(dibheader.importantColorNumber);
				num += 12U;
				binaryReader.BaseStream.Seek((long)(unchecked((ulong)num)), SeekOrigin.Begin);
				int num4 = (int)(num2 * num3);
				int num5 = 1;
				int num6 = num4;
				int num7 = num5;
				for (;;)
				{
					int num8 = num7;
					int num9 = num6;
					if (num8 > num9)
					{
						break;
					}
					uint value = binaryReader.ReadUInt32();
					binaryWriter.Write(value);
					num7++;
				}
				binaryReader.Close();
				binaryWriter.Close();
			}
		}

		// Token: 0x02000049 RID: 73
		private struct bmpHeader
		{
			// Token: 0x04000462 RID: 1122
			public ushort magic;

			// Token: 0x04000463 RID: 1123
			public uint fileSize;

			// Token: 0x04000464 RID: 1124
			public ushort reserved1;

			// Token: 0x04000465 RID: 1125
			public ushort reserved2;

			// Token: 0x04000466 RID: 1126
			public uint bmpStart;
		}

		// Token: 0x0200004A RID: 74
		private struct DIBHeader
		{
			// Token: 0x04000467 RID: 1127
			public uint headerSize;

			// Token: 0x04000468 RID: 1128
			public int bmWidth;

			// Token: 0x04000469 RID: 1129
			public int bmHeight;

			// Token: 0x0400046A RID: 1130
			public ushort colorPlane;

			// Token: 0x0400046B RID: 1131
			public ushort bpp;

			// Token: 0x0400046C RID: 1132
			public uint compression;

			// Token: 0x0400046D RID: 1133
			public uint bmSize;

			// Token: 0x0400046E RID: 1134
			public uint hRes;

			// Token: 0x0400046F RID: 1135
			public uint vRes;

			// Token: 0x04000470 RID: 1136
			public uint palColorNumber;

			// Token: 0x04000471 RID: 1137
			public uint importantColorNumber;
		}
	}
}
