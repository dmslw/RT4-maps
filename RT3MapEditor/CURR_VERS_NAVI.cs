using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x0200007F RID: 127
	public class CURR_VERS_NAVI
	{
		// Token: 0x06000D53 RID: 3411 RVA: 0x00123338 File Offset: 0x00122338
		public CURR_VERS_NAVI(string fileName, CURR_VERS_NAVI.mode mode)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.RT3Writer = null;
			this.fmode = mode;
			this.data = new CURR_VERS_NAVI.CurrVersNaviData();
			this.FileName = fileName;
			bool flag = mode == CURR_VERS_NAVI.mode.read;
			if (flag)
			{
				this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
			}
			else
			{
				this.RT3Writer = new RT3Writer(new FileStream(fileName, FileMode.Create, FileAccess.Write));
			}
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x001233B0 File Offset: 0x001223B0
		public void loadFromFile()
		{
			int num = 0;
			checked
			{
				try
				{
					MyProject.Application.Log.WriteEntry(string.Format("loading {0:G} ", this.FileName));
					long length = this.RT3Reader.BaseStream.Length;
					bool flag = decimal.Compare(new decimal(length), 3120m) != 0;
					if (flag)
					{
						throw new Exception(string.Format(Resources.strErrIncFileLength, this.FileName, length));
					}
					int num2 = 0;
					num = 0;
					int num3;
					int num4;
					do
					{
						this.data.versionNumber[num] = this.RT3Reader.readRT3Uint32();
						num++;
						num3 = num;
						num4 = 39;
					}
					while (num3 <= num4);
					num2 = 1;
					num = 0;
					int num5;
					do
					{
						this.data.releaseNumber[num] = this.RT3Reader.readRT3Uint32();
						num++;
						num5 = num;
						num4 = 39;
					}
					while (num5 <= num4);
					num2 = 2;
					num = 0;
					int num6;
					do
					{
						string text = this.RT3Reader.readRT3String(20).Replace('\n', '\0').Replace('\r', '\0');
						this.data.CIDDate[num] = Strings.Left(text, text.IndexOf('\0'));
						num++;
						num6 = num;
						num4 = 39;
					}
					while (num6 <= num4);
					num2 = 3;
					num = 0;
					int num7;
					do
					{
						string text = this.RT3Reader.readRT3String(30).Replace('\n', '\0').Replace('\r', '\0');
						this.data.CIDName[num] = Strings.Left(text, text.IndexOf('\0'));
						num++;
						num7 = num;
						num4 = 39;
					}
					while (num7 <= num4);
					num2 = 4;
					num = 0;
					int num8;
					do
					{
						string text = this.RT3Reader.readRT3String(15).Replace('\n', '\0').Replace('\r', '\0');
						this.data.CIDProvider[num] = Strings.Left(text, text.IndexOf('\0'));
						num++;
						num8 = num;
						num4 = 39;
					}
					while (num8 <= num4);
					num2 = 5;
					num = 0;
					int num9;
					do
					{
						this.data.CIDQuarter[num] = this.RT3Reader.ReadByte();
						num++;
						num9 = num;
						num4 = 39;
					}
					while (num9 <= num4);
					num2 = 6;
					num = 0;
					int num10;
					do
					{
						this.data.CIDYear[num] = this.RT3Reader.readRT3Uint32();
						num++;
						num10 = num;
						num4 = 39;
					}
					while (num10 <= num4);
				}
				catch (Exception ex)
				{
					int num2;
					string message = string.Format("unable to load {0:G}, index {1:G} step {2:G}", this.FileName, num, num2);
					MyProject.Application.Log.WriteEntry(message);
					MyProject.Application.Log.WriteEntry(ex.StackTrace);
					throw new SilentGUIException();
				}
				finally
				{
					this.RT3Reader.Close();
				}
				MyProject.Application.Log.WriteEntry(string.Format("{0:G} loaded : {1:G} entries", this.FileName, 40));
			}
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00123688 File Offset: 0x00122688
		public List<string> getCIDList()
		{
			bool flag = true;
			List<string> list = new List<string>();
			int num = 0;
			checked
			{
				int num2 = this.data.CIDName.Length - 1;
				int num3 = num;
				bool flag2;
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					flag2 = (this.data.CIDName[num3] != null && this.data.CIDName[num3].Length > 0 && CopyMap.isHddMapSupported((int)this.data.versionNumber[num3], (int)this.data.releaseNumber[num3]));
					if (flag2)
					{
						list.Add(this.data.CIDName[num3]);
						flag = false;
					}
					else
					{
						list.Add("");
					}
					num3++;
				}
				flag2 = flag;
				List<string> result;
				if (flag2)
				{
					result = null;
				}
				else
				{
					result = list;
				}
				return result;
			}
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0012374C File Offset: 0x0012274C
		public string getRootCdVerLaNa(int CID)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			stringBuilder.AppendLine("CID:" + CID.ToString("d3"));
			stringBuilder.AppendLine("CD_NAME:" + this.data.CIDName[CID]);
			stringBuilder.AppendLine("CD_PROVIDER:" + this.data.CIDProvider[CID]);
			stringBuilder.AppendLine("DATA_MAPPE:" + this.data.CIDDate[CID]);
			stringBuilder.AppendLine("QUARTER:" + Conversions.ToString(this.data.CIDQuarter[CID]));
			stringBuilder.AppendLine("YEAR:" + Conversions.ToString(this.data.CIDYear[CID]));
			return stringBuilder.ToString();
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0012382C File Offset: 0x0012282C
		public string getCidCdVerLaNa(int CID)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			stringBuilder.AppendLine("CID:" + CID.ToString("d3"));
			stringBuilder.AppendLine("VERSION:" + this.data.versionNumber[CID].ToString("d1"));
			stringBuilder.AppendLine("RELEASE:" + this.data.releaseNumber[CID].ToString("d1"));
			stringBuilder.AppendLine("CD_NAME:" + this.data.CIDName[CID]);
			return stringBuilder.ToString();
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x001238E4 File Offset: 0x001228E4
		public string getReleaseStr(int CID)
		{
			return this.data.releaseNumber[CID].ToString("d1");
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00123914 File Offset: 0x00122914
		public string getVersionStr(int CID)
		{
			return this.data.versionNumber[CID].ToString();
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0012393C File Offset: 0x0012293C
		public string getDateStr(int CID)
		{
			return this.data.CIDDate[CID];
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0012395C File Offset: 0x0012295C
		public string getProviderStr(int CID)
		{
			return this.data.CIDProvider[CID];
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0012397C File Offset: 0x0012297C
		public string getQuarterStr(int CID)
		{
			return this.data.CIDQuarter[CID].ToString("d1");
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x001239AC File Offset: 0x001229AC
		public string getYearStr(int CID)
		{
			return this.data.CIDYear[CID].ToString("d4");
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x001239DC File Offset: 0x001229DC
		public string getFileName()
		{
			return this.FileName;
		}

		// Token: 0x04000600 RID: 1536
		private const int NB_RECORD = 40;

		// Token: 0x04000601 RID: 1537
		private const int CID_DATE_LEN = 20;

		// Token: 0x04000602 RID: 1538
		private const int CID_NAME_LEN = 30;

		// Token: 0x04000603 RID: 1539
		private const int CID_PROV_LEN = 15;

		// Token: 0x04000604 RID: 1540
		private const ulong FILE_SIZE = 3120UL;

		// Token: 0x04000605 RID: 1541
		private string FileName;

		// Token: 0x04000606 RID: 1542
		private RT3Reader RT3Reader;

		// Token: 0x04000607 RID: 1543
		private RT3Writer RT3Writer;

		// Token: 0x04000608 RID: 1544
		private CURR_VERS_NAVI.mode fmode;

		// Token: 0x04000609 RID: 1545
		private CURR_VERS_NAVI.CurrVersNaviData data;

		// Token: 0x02000080 RID: 128
		public enum mode
		{
			// Token: 0x0400060B RID: 1547
			read,
			// Token: 0x0400060C RID: 1548
			write
		}

		// Token: 0x02000081 RID: 129
		private class CurrVersNaviData
		{
			// Token: 0x06000D5F RID: 3423 RVA: 0x001239F4 File Offset: 0x001229F4
			public CurrVersNaviData()
			{
				this.versionNumber = new uint[41];
				this.releaseNumber = new uint[41];
				this.CIDDate = new string[41];
				this.CIDName = new string[41];
				this.CIDProvider = new string[41];
				this.CIDQuarter = new byte[41];
				this.CIDYear = new uint[41];
			}

			// Token: 0x0400060D RID: 1549
			public uint[] versionNumber;

			// Token: 0x0400060E RID: 1550
			public uint[] releaseNumber;

			// Token: 0x0400060F RID: 1551
			public string[] CIDDate;

			// Token: 0x04000610 RID: 1552
			public string[] CIDName;

			// Token: 0x04000611 RID: 1553
			public string[] CIDProvider;

			// Token: 0x04000612 RID: 1554
			public byte[] CIDQuarter;

			// Token: 0x04000613 RID: 1555
			public uint[] CIDYear;
		}
	}
}
