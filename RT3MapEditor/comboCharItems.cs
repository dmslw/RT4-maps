using System;

namespace RT3MapEditor
{
	// Token: 0x02000015 RID: 21
	public class comboCharItems
	{
		// Token: 0x06000241 RID: 577 RVA: 0x000FCED4 File Offset: 0x000FBED4
		public comboCharItems(string display, char value)
		{
			this._display = display;
			this._value = value;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000242 RID: 578 RVA: 0x000FCEF0 File Offset: 0x000FBEF0
		// (set) Token: 0x06000243 RID: 579 RVA: 0x000FCF08 File Offset: 0x000FBF08
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

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000244 RID: 580 RVA: 0x000FCF14 File Offset: 0x000FBF14
		// (set) Token: 0x06000245 RID: 581 RVA: 0x000FCF2C File Offset: 0x000FBF2C
		public char value
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

		// Token: 0x0400016D RID: 365
		public const string DISPLAY_PROP = "display";

		// Token: 0x0400016E RID: 366
		public const string VALUE_PROP = "value";

		// Token: 0x0400016F RID: 367
		private string _display;

		// Token: 0x04000170 RID: 368
		private char _value;
	}
}
