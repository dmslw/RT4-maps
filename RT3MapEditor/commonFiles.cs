using System;
using System.Windows.Forms;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x0200007E RID: 126
	public class commonFiles
	{
		// Token: 0x06000D52 RID: 3410 RVA: 0x0012324C File Offset: 0x0012224C
		public commonFiles(POICategoryInfos POIcategoryInfo, Common.RTxMapType mapType)
		{
			this.francPOIDat = null;
			this.francNomservDat = null;
			this.GuidaChamperadPoi = null;
			this.francPOIDat = new FRANCPOI_DAT(POIcategoryInfo.getMainPOIRT3File2Read("POI.DAT"), FRANCPOI_DAT.mode.read, mapType);
			this.francPOIDat.loadFromFile();
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 2;
			Application.DoEvents();
			this.francNomservDat = new FRANC_NOMSERV_DAT(POIcategoryInfo.getMainPOIRT3File2Read("_NOMSERV.DAT"), FRANC_NOMSERV_DAT.mode.read);
			this.francNomservDat.loadFromFile();
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 3;
			Application.DoEvents();
			this.GuidaChamperadPoi = new GUIDA_CHAMPERARD_POI(POIcategoryInfo.getMainPOIRT3File2Read("GUIDA_CHAMPERARD.POI"), GUIDA_CHAMPERARD_POI.mode.read);
			this.GuidaChamperadPoi.loadFromFile();
			MyProject.Forms.FormMain.ToolStripProgressBar1.Value = 4;
			Application.DoEvents();
		}

		// Token: 0x040005FD RID: 1533
		public FRANCPOI_DAT francPOIDat;

		// Token: 0x040005FE RID: 1534
		public FRANC_NOMSERV_DAT francNomservDat;

		// Token: 0x040005FF RID: 1535
		public GUIDA_CHAMPERARD_POI GuidaChamperadPoi;
	}
}
