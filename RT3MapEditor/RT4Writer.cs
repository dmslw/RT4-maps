using System;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x020000CD RID: 205
	public class RT4Writer : RT3Writer
	{
		// Token: 0x06000E4C RID: 3660 RVA: 0x0012FC50 File Offset: 0x0012EC50
		public RT4Writer(Stream stream) : base(stream)
		{
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0012FC5C File Offset: 0x0012EC5C
		public override void writePOIType(ushort RT3Type)
		{
			base.writeRT3(MyProject.Forms.FormMain.mapMngt.POITypeInfo.RT4TypeFromRT3Type(RT3Type & 32767) | (RT3Type & 32768));
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0012FC90 File Offset: 0x0012EC90
		public override void writeLS(ushort LS)
		{
			base.writeRT3(LS);
		}
	}
}
