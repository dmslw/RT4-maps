using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x020000CF RID: 207
	public class SCITTANAME_DAT
	{
		// Token: 0x06000E50 RID: 3664 RVA: 0x0012FCA8 File Offset: 0x0012ECA8
		public SCITTANAME_DAT(string fileName)
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.lastPos = 0U;
			this.dict = new Dictionary<string, uint>(30000);
			this.invDict = new Dictionary<uint, string>(30000);
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
						uint num2 = (uint)this.RT3Reader.BaseStream.Position;
						string text = this.RT3Reader.readRT3String().TrimEnd(new char[]
						{
							'\0'
						});
						num++;
						this.dict.Add(text, num2);
						this.invDict.Add(num2, text);
					}
				}
				catch (EndOfStreamException ex)
				{
					uint num2;
					this.lastPos = num2 - 1U;
				}
				catch (Exception ex2)
				{
					uint num2;
					string message = string.Format("unable to load {0:G}, ptr {1:G}, idx {2:G}", fileName, num2, num);
					MyProject.Application.Log.WriteEntry(message);
					MyProject.Application.Log.WriteEntry(ex2.StackTrace);
					throw new Exception(message);
				}
				finally
				{
					this.RT3Reader.Close();
				}
				MyProject.Application.Log.WriteEntry(string.Format("{0:G} loaded : {1:G} entries", fileName, num));
			}
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0012FE7C File Offset: 0x0012EE7C
		public SCITTANAME_DAT()
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.lastPos = 0U;
			this.dict = new Dictionary<string, uint>(30000);
			this.invDict = new Dictionary<uint, string>(30000);
			this.FileName = null;
			MyProject.Application.Log.WriteEntry(string.Format("Empty SCITTANAME.DAT created : no entry", new object[0]));
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0012FEF0 File Offset: 0x0012EEF0
		public uint cityExists(string cityName)
		{
			uint num;
			bool flag = this.dict.TryGetValue(cityName.ToUpper(), out num);
			uint result;
			if (flag)
			{
				result = num;
			}
			else
			{
				result = this.lastPos;
			}
			return result;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0012FF24 File Offset: 0x0012EF24
		public uint nullNamePtr()
		{
			return this.lastPos;
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0012FF3C File Offset: 0x0012EF3C
		public string getCityName(uint key)
		{
			string text = null;
			bool flag = this.invDict.TryGetValue(key, out text);
			string result;
			if (flag)
			{
				result = text;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x04000934 RID: 2356
		private const uint INITIALSIZE = 30000U;

		// Token: 0x04000935 RID: 2357
		private string FileName;

		// Token: 0x04000936 RID: 2358
		private RT3Reader RT3Reader;

		// Token: 0x04000937 RID: 2359
		private Dictionary<string, uint> dict;

		// Token: 0x04000938 RID: 2360
		private Dictionary<uint, string> invDict;

		// Token: 0x04000939 RID: 2361
		private uint lastPos;

		// Token: 0x020000D0 RID: 208
		public class scittaNameRecord
		{
			// Token: 0x06000E55 RID: 3669 RVA: 0x0012FF68 File Offset: 0x0012EF68
			[DebuggerNonUserCode]
			public scittaNameRecord()
			{
			}

			// Token: 0x0400093A RID: 2362
			public string name;
		}
	}
}
