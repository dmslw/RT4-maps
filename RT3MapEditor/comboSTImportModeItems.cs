using System;

namespace RT3MapEditor
{
	// Token: 0x02000018 RID: 24
	public class comboSTImportModeItems
	{
		// Token: 0x06000250 RID: 592 RVA: 0x000FD000 File Offset: 0x000FC000
		public comboSTImportModeItems(string display, STArchives.ArchImportMode value)
		{
			this._display = display;
			this._value = value;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000FD01C File Offset: 0x000FC01C
		// (set) Token: 0x06000252 RID: 594 RVA: 0x000FD034 File Offset: 0x000FC034
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

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000253 RID: 595 RVA: 0x000FD040 File Offset: 0x000FC040
		// (set) Token: 0x06000254 RID: 596 RVA: 0x000FD058 File Offset: 0x000FC058
		public STArchives.ArchImportMode value
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

		// Token: 0x04000179 RID: 377
		public const string DISPLAY_PROP = "display";

		// Token: 0x0400017A RID: 378
		public const string VALUE_PROP = "value";

		// Token: 0x0400017B RID: 379
		private string _display;

		// Token: 0x0400017C RID: 380
		private STArchives.ArchImportMode _value;
	}
}
