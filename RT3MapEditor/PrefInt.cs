using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x020000B7 RID: 183
	public class PrefInt
	{
		// Token: 0x06000E0B RID: 3595 RVA: 0x0012BB24 File Offset: 0x0012AB24
		public PrefInt(string fileName)
		{
			this.FileName = null;
			this.RT3Reader = null;
			bool flag = true;
			this.prefDict = new Dictionary<byte, string>(50);
			this.invPrefDict = new SortedDictionary<string, byte>();
			this.countryNameDict = new Dictionary<byte, string>(50);
			this.FileName = fileName;
			checked
			{
				int num;
				try
				{
					MyProject.Application.Log.WriteEntry(string.Format("loading {0:G} ", fileName));
					num = 0;
					this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
					for (;;)
					{
						byte b = this.RT3Reader.ReadByte();
						flag = false;
						string text = this.RT3Reader.readRT3String(4).TrimEnd(new char[]
						{
							'\0'
						});
						flag = true;
						num++;
						this.prefDict.Add(b, text);
						bool flag2 = !this.invPrefDict.ContainsKey(text);
						if (flag2)
						{
							this.invPrefDict.Add(text, b);
						}
						this.countryNameDict.Add(b, this._countryName(b));
					}
				}
				catch (EndOfStreamException ex)
				{
					bool flag2 = !flag;
					if (flag2)
					{
						string message = string.Format("unable to load {0:G}, idx {1:G}", fileName, num);
						MyProject.Application.Log.WriteEntry(message);
						MyProject.Application.Log.WriteEntry(ex.StackTrace);
						throw new Exception(message);
					}
				}
				catch (Exception ex2)
				{
					string message2 = string.Format("unable to load {0:G}, idx {1:G}", fileName, num);
					MyProject.Application.Log.WriteEntry(message2);
					MyProject.Application.Log.WriteEntry(ex2.StackTrace);
					throw new Exception(message2);
				}
				finally
				{
					this.RT3Reader.Close();
				}
				MyProject.Application.Log.WriteEntry(string.Format("{0:G} loaded : {1:G} entries", fileName, num));
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0012BD64 File Offset: 0x0012AD64
		public PrefInt()
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.prefDict = new Dictionary<byte, string>(50);
			this.invPrefDict = new SortedDictionary<string, byte>();
			this.countryNameDict = new Dictionary<byte, string>(50);
			this.FileName = null;
			byte b = 0;
			byte b2;
			byte b3;
			do
			{
				bool flag = this._countryName(b) != null;
				if (flag)
				{
					this.countryNameDict.Add(b, this._countryName(b));
				}
				b += 1;
				b2 = b;
				b3 = 52;
			}
			while (b2 <= b3);
			MyProject.Application.Log.WriteEntry(string.Format("empty Prefint created : no entry", new object[0]));
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0012BE0C File Offset: 0x0012AE0C
		private string _countryName(byte countryCode)
		{
			switch (countryCode)
			{
			case 1:
				return Resources.strCountry01;
			case 2:
				return Resources.strCountry02;
			case 3:
				return Resources.strCountry03;
			case 4:
				return Resources.strCountry04;
			case 5:
				return Resources.strCountry05;
			case 6:
				return Resources.strCountry04;
			case 7:
				return Resources.strCountry07;
			case 8:
				return Resources.strCountry08;
			case 9:
				return Resources.strCountry09;
			case 10:
				return Resources.strCountry0a;
			case 11:
				return Resources.strCountry0b;
			case 12:
				return Resources.strCountry0c;
			case 13:
				return Resources.strCountry0d;
			case 14:
				return Resources.strCountry0e;
			case 15:
				return Resources.strCountry0f;
			case 16:
				return Resources.strCountry10;
			case 17:
				return Resources.strCountry11;
			case 18:
				return Resources.strCountry12;
			case 19:
				return Resources.strCountry13;
			case 21:
				return Resources.strCountry15;
			case 22:
				return Resources.strCountry16;
			case 23:
				return Resources.StrCountry17;
			case 24:
				return Resources.strCountry18;
			case 25:
				return Resources.strCountry19;
			case 29:
				return Resources.strCountry1d;
			case 30:
				return Resources.strCountry1e;
			case 31:
				return Resources.strCountry1f;
			case 32:
				return Resources.strCountry20;
			case 36:
				return Resources.strCountry24;
			case 38:
				return Resources.strCountry26;
			case 39:
				return Resources.strCountry27;
			case 40:
				return Resources.strCountry28;
			case 42:
				return Resources.strCountry2a;
			case 43:
				return Resources.strCountry2b;
			case 48:
				return Resources.strCountry30;
			case 52:
				return Resources.strCountry34;
			}
			return null;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0012C120 File Offset: 0x0012B120
		public string getPrefix(byte countryCode)
		{
			string result = null;
			bool flag = !this.prefDict.TryGetValue(countryCode, out result);
			if (flag)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0012C14C File Offset: 0x0012B14C
		public string getCountry(byte countryCode)
		{
			string result = null;
			bool flag = !this.countryNameDict.TryGetValue(countryCode, out result);
			if (flag)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0012C178 File Offset: 0x0012B178
		public string getPrefix(string numTel)
		{
			bool flag = numTel.Length < 3 | !numTel.StartsWith("+");
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				flag = this.invPrefDict.ContainsKey(numTel.Substring(1, 2));
				if (flag)
				{
					result = numTel.Substring(1, 2);
				}
				else
				{
					flag = this.invPrefDict.ContainsKey(numTel.Substring(1, 3));
					if (flag)
					{
						result = numTel.Substring(1, 3);
					}
					else
					{
						result = null;
					}
				}
			}
			return result;
		}

		// Token: 0x04000849 RID: 2121
		private const uint INITIALSIZE = 50U;

		// Token: 0x0400084A RID: 2122
		private string FileName;

		// Token: 0x0400084B RID: 2123
		private RT3Reader RT3Reader;

		// Token: 0x0400084C RID: 2124
		private Dictionary<byte, string> prefDict;

		// Token: 0x0400084D RID: 2125
		private SortedDictionary<string, byte> invPrefDict;

		// Token: 0x0400084E RID: 2126
		private Dictionary<byte, string> countryNameDict;

		// Token: 0x020000B8 RID: 184
		public class PrefIntRecord
		{
			// Token: 0x06000E11 RID: 3601 RVA: 0x0012C1F8 File Offset: 0x0012B1F8
			[DebuggerNonUserCode]
			public PrefIntRecord()
			{
			}

			// Token: 0x0400084F RID: 2127
			public byte countryCode;

			// Token: 0x04000850 RID: 2128
			public string prefix;
		}
	}
}
