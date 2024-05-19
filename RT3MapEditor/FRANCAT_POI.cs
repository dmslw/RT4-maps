using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x0200008C RID: 140
	public class FRANCAT_POI
	{
		// Token: 0x06000D7D RID: 3453 RVA: 0x00124DA4 File Offset: 0x00123DA4
		public FRANCAT_POI(string fileName)
		{
			this.FileName = null;
			this.RT3Reader = null;
			bool flag = true;
			this.dict = new Dictionary<ushort, string>(1500);
			this.FileName = fileName;
			ushort num;
			try
			{
				MyProject.Application.Log.WriteEntry(string.Format("loading {0:G} ", fileName));
				num = 0;
				this.RT3Reader = new RT3Reader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
				for (;;)
				{
					string value = this.RT3Reader.readRT3String(21).TrimEnd(new char[]
					{
						'\0'
					});
					flag = false;
					ushort num2 = this.RT3Reader.readRT3Uint16();
					flag = true;
					num += 1;
					this.dict.Add(num, value);
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

		// Token: 0x06000D7E RID: 3454 RVA: 0x00124F98 File Offset: 0x00123F98
		public FRANCAT_POI()
		{
			this.FileName = null;
			this.RT3Reader = null;
			this.dict = new Dictionary<ushort, string>(1500);
			this.FileName = null;
			MyProject.Application.Log.WriteEntry(string.Format("empty FRANCAT.POI created", new object[0]));
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00124FF4 File Offset: 0x00123FF4
		public string getBrandName(ushort brandCode)
		{
			string result = null;
			bool flag = brandCode == 0 || !this.dict.TryGetValue(brandCode + 1, out result);
			if (flag)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0400066A RID: 1642
		private const uint INITIALSIZE = 1500U;

		// Token: 0x0400066B RID: 1643
		private string FileName;

		// Token: 0x0400066C RID: 1644
		private RT3Reader RT3Reader;

		// Token: 0x0400066D RID: 1645
		private Dictionary<ushort, string> dict;

		// Token: 0x0200008D RID: 141
		public class FrancatPOIRecords
		{
			// Token: 0x06000D80 RID: 3456 RVA: 0x00125028 File Offset: 0x00124028
			[DebuggerNonUserCode]
			public FrancatPOIRecords()
			{
			}

			// Token: 0x0400066E RID: 1646
			public string brandName;

			// Token: 0x0400066F RID: 1647
			public ushort brandCode;
		}
	}
}
