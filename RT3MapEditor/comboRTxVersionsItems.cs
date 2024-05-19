using System;

namespace RT3MapEditor
{
	// Token: 0x02000017 RID: 23
	public class comboRTxVersionsItems
	{
		// Token: 0x0600024B RID: 587 RVA: 0x000FCF9C File Offset: 0x000FBF9C
		public comboRTxVersionsItems(string display, Common.RTxVersions value)
		{
			this._display = display;
			this._value = value;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600024C RID: 588 RVA: 0x000FCFB8 File Offset: 0x000FBFB8
		// (set) Token: 0x0600024D RID: 589 RVA: 0x000FCFD0 File Offset: 0x000FBFD0
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000FCFDC File Offset: 0x000FBFDC
		// (set) Token: 0x0600024F RID: 591 RVA: 0x000FCFF4 File Offset: 0x000FBFF4
		public Common.RTxVersions value
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

		// Token: 0x04000175 RID: 373
		public const string DISPLAY_PROP = "display";

		// Token: 0x04000176 RID: 374
		public const string VALUE_PROP = "value";

		// Token: 0x04000177 RID: 375
		private string _display;

		// Token: 0x04000178 RID: 376
		private Common.RTxVersions _value;
	}
}
