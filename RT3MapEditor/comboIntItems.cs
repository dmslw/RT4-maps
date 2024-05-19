using System;

namespace RT3MapEditor
{
	// Token: 0x02000016 RID: 22
	public class comboIntItems
	{
		// Token: 0x06000246 RID: 582 RVA: 0x000FCF38 File Offset: 0x000FBF38
		public comboIntItems(string display, int value)
		{
			this._display = display;
			this._value = value;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000247 RID: 583 RVA: 0x000FCF54 File Offset: 0x000FBF54
		// (set) Token: 0x06000248 RID: 584 RVA: 0x000FCF6C File Offset: 0x000FBF6C
		public string display
		{
			get
			{
				return this._display;
			}
			set
			{
				this._display = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000FCF78 File Offset: 0x000FBF78
		// (set) Token: 0x0600024A RID: 586 RVA: 0x000FCF90 File Offset: 0x000FBF90
		public int value
		{
			get
			{
				return this._value;
			}
			set
			{
				value = this._value;
			}
		}

		// Token: 0x04000171 RID: 369
		public const string DISPLAY_PROP = "display";

		// Token: 0x04000172 RID: 370
		public const string VALUE_PROP = "value";

		// Token: 0x04000173 RID: 371
		private string _display;

		// Token: 0x04000174 RID: 372
		private int _value;
	}
}
