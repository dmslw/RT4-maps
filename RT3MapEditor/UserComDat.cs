using System;
using System.IO;
using Microsoft.VisualBasic;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000074 RID: 116
	public class UserComDat
	{
		// Token: 0x06000D28 RID: 3368 RVA: 0x0011FB58 File Offset: 0x0011EB58
		public UserComDat(string fileName, Common.RTxTypes RTxType)
		{
			this.fileName = fileName;
			this._RTxType = RTxType;
			switch (Common.RTxVersion)
			{
			case Common.RTxVersions.version702:
				this.RTx_COM_USER_DAT_LENGTH = 38708;
				this.RTx_VIDEO_SPEED_SEEK = 5788;
				break;
			case Common.RTxVersions.version710:
				this.RTx_COM_USER_DAT_LENGTH = 29936;
				this.RTx_VIDEO_SPEED_SEEK = 5836;
				break;
			case Common.RTxVersions.version711:
				this.RTx_COM_USER_DAT_LENGTH = 29936;
				this.RTx_VIDEO_SPEED_SEEK = 5836;
				break;
			case Common.RTxVersions.version80:
				this.RTx_COM_USER_DAT_LENGTH = 52888;
				this.RTx_VIDEO_SPEED_SEEK = 6636;
				break;
			case Common.RTxVersions.version81:
				this.RTx_COM_USER_DAT_LENGTH = 55812;
				this.RTx_VIDEO_SPEED_SEEK = 7164;
				break;
			}
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0011FC24 File Offset: 0x0011EC24
		public bool isUserComDatValid()
		{
			RT3Reader rt3Reader = null;
			bool result = false;
			try
			{
				rt3Reader = new RT3Reader(new FileStream(this.fileName, FileMode.Open, FileAccess.Read));
				bool flag = rt3Reader.BaseStream.Length == (long)this.RTx_COM_USER_DAT_LENGTH;
				if (flag)
				{
					result = true;
				}
			}
			catch (Exception ex)
			{
			}
			finally
			{
				bool flag = rt3Reader != null;
				if (flag)
				{
					bool flag2 = rt3Reader.BaseStream != null;
					if (flag2)
					{
						rt3Reader.BaseStream.Close();
					}
					rt3Reader.Close();
				}
			}
			return result;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0011FCD0 File Offset: 0x0011ECD0
		public void check()
		{
			RT3Reader rt3Reader = null;
			RT3Writer rt3Writer = null;
			try
			{
				rt3Reader = new RT3Reader(new FileStream(this.fileName, FileMode.Open, FileAccess.Read));
				bool flag = rt3Reader.BaseStream.Length == (long)this.RTx_COM_USER_DAT_LENGTH;
				if (flag)
				{
					rt3Reader.BaseStream.Seek((long)this.RTx_VIDEO_SPEED_SEEK, SeekOrigin.Begin);
					byte b = rt3Reader.ReadByte();
					flag = (b > 5);
					if (flag)
					{
						b = 5;
						flag = (rt3Reader != null);
						if (flag)
						{
							bool flag2 = rt3Reader.BaseStream != null;
							if (flag2)
							{
								rt3Reader.BaseStream.Close();
							}
							rt3Reader.Close();
							rt3Reader = null;
						}
						rt3Writer = new RT3Writer(new FileStream(this.fileName, FileMode.Open, FileAccess.ReadWrite));
						rt3Writer.BaseStream.Seek((long)this.RTx_VIDEO_SPEED_SEEK, SeekOrigin.Begin);
						rt3Writer.Write(b);
						Interaction.MsgBox(Resources.strWarViSp, MsgBoxStyle.Exclamation, null);
					}
				}
			}
			catch (Exception ex)
			{
			}
			finally
			{
				bool flag2 = rt3Reader != null;
				if (flag2)
				{
					bool flag = rt3Reader.BaseStream != null;
					if (flag)
					{
						rt3Reader.BaseStream.Close();
					}
					rt3Reader.Close();
				}
				flag2 = (rt3Writer != null);
				if (flag2)
				{
					bool flag = rt3Writer.BaseStream != null;
					if (flag)
					{
						rt3Writer.BaseStream.Close();
					}
					rt3Writer.Close();
				}
			}
		}

		// Token: 0x04000595 RID: 1429
		private const int V702_COM_USER_DAT_LENGTH = 38708;

		// Token: 0x04000596 RID: 1430
		private const int V710_COM_USER_DAT_LENGTH = 29936;

		// Token: 0x04000597 RID: 1431
		private const int V711_COM_USER_DAT_LENGTH = 29936;

		// Token: 0x04000598 RID: 1432
		private const int V800_COM_USER_DAT_LENGTH = 52888;

		// Token: 0x04000599 RID: 1433
		private const int V810_COM_USER_DAT_LENGTH = 55812;

		// Token: 0x0400059A RID: 1434
		private const int V711_USER_1_SEEK = 5963;

		// Token: 0x0400059B RID: 1435
		private const string RT4_USER_1_STR = "User 1";

		// Token: 0x0400059C RID: 1436
		private const int V702_VIDEO_SPEED_SEEK = 5788;

		// Token: 0x0400059D RID: 1437
		private const int V710_VIDEO_SPEED_SEEK = 5836;

		// Token: 0x0400059E RID: 1438
		private const int V711_VIDEO_SPEED_SEEK = 5836;

		// Token: 0x0400059F RID: 1439
		private const int V800_VIDEO_SPEED_SEEK = 6636;

		// Token: 0x040005A0 RID: 1440
		private const int V810_VIDEO_SPEED_SEEK = 7164;

		// Token: 0x040005A1 RID: 1441
		private int RTx_COM_USER_DAT_LENGTH;

		// Token: 0x040005A2 RID: 1442
		private int RTx_VIDEO_SPEED_SEEK;

		// Token: 0x040005A3 RID: 1443
		private string fileName;

		// Token: 0x040005A4 RID: 1444
		private Common.RTxTypes _RTxType;
	}
}
