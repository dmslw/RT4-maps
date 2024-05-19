using System;
using System.IO;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x020000CC RID: 204
	public class RT4Reader : RT3Reader
	{
		// Token: 0x06000E49 RID: 3657 RVA: 0x0012FBE8 File Offset: 0x0012EBE8
		public RT4Reader(Stream stream) : base(stream)
		{
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0012FBF4 File Offset: 0x0012EBF4
		public override ushort readPOIType()
		{
			ushort num = base.readRT3Uint16();
			return MyProject.Forms.FormMain.mapMngt.POITypeInfo.RT3TypeFromRT4Type(num & 32767) | (num & 32768);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0012FC38 File Offset: 0x0012EC38
		public override ushort readLS()
		{
			return base.readRT3Uint16();
		}
	}
}
