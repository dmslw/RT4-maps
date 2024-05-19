using System;
using System.Drawing;

namespace RT3MapEditor
{
	// Token: 0x02000073 RID: 115
	public class RTxScreen
	{
		// Token: 0x06000D1F RID: 3359 RVA: 0x0011F9A8 File Offset: 0x0011E9A8
		public static bool isLRScreen()
		{
			return Common.RTxType != Common.RTxTypes.typeRT5HR;
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0011F9C8 File Offset: 0x0011E9C8
		public static int RTx_SCREEN_WIDTH
		{
			get
			{
				bool flag = Common.RTxType == Common.RTxTypes.typeRT5HR;
				int result;
				if (flag)
				{
					result = 800;
				}
				else
				{
					result = 480;
				}
				return result;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0011F9F8 File Offset: 0x0011E9F8
		public static int RTx_SCREEN_HEIGHT
		{
			get
			{
				bool flag = Common.RTxType == Common.RTxTypes.typeRT5HR;
				int result;
				if (flag)
				{
					result = 446;
				}
				else
				{
					result = 234;
				}
				return result;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0011FA28 File Offset: 0x0011EA28
		public static int RTx_SCREEN_WIDTH_SQ_PIXEL
		{
			get
			{
				bool flag = Common.RTxType == Common.RTxTypes.typeRT5HR;
				int result;
				if (flag)
				{
					result = 800;
				}
				else
				{
					result = 480;
				}
				return result;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x0011FA58 File Offset: 0x0011EA58
		public static int RTx_SCREEN_HEIGHT_SQ_PIXEL
		{
			get
			{
				bool flag = Common.RTxType == Common.RTxTypes.typeRT5HR;
				int result;
				if (flag)
				{
					result = 454;
				}
				else
				{
					result = 270;
				}
				return result;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0011FA88 File Offset: 0x0011EA88
		public static double RTx_SCREEN_RATIO
		{
			get
			{
				bool flag = Common.RTxType == Common.RTxTypes.typeRT5HR;
				double result;
				if (flag)
				{
					result = 1.7613636;
				}
				else
				{
					result = 1.7613636;
				}
				return result;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x0011FAC0 File Offset: 0x0011EAC0
		public static double RTx_PIXEL_RATIO
		{
			get
			{
				bool flag = Common.RTxType == Common.RTxTypes.typeRT5HR;
				double result;
				if (flag)
				{
					result = 1.01837120574887;
				}
				else
				{
					result = 1.15136476426799;
				}
				return result;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0011FAF8 File Offset: 0x0011EAF8
		public static Rectangle RTxScreenRectangle
		{
			get
			{
				bool flag = Common.RTxType == Common.RTxTypes.typeRT5HR;
				Rectangle result;
				if (flag)
				{
					result = RTxScreen._HRscreenRectangle;
				}
				else
				{
					result = RTxScreen._LRscreenRectangle;
				}
				return result;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x0011FB28 File Offset: 0x0011EB28
		public static Rectangle RTxScreenRectangleSqPixel
		{
			get
			{
				bool flag = Common.RTxType == Common.RTxTypes.typeRT5HR;
				Rectangle result;
				if (flag)
				{
					result = RTxScreen._HRscreenRectangleSqPixel;
				}
				else
				{
					result = RTxScreen._LRscreenRectangleSqPixel;
				}
				return result;
			}
		}

		// Token: 0x04000585 RID: 1413
		public const int LR_SCREEN_WIDTH = 480;

		// Token: 0x04000586 RID: 1414
		public const int HR_SCREEN_WIDTH = 800;

		// Token: 0x04000587 RID: 1415
		public const int LR_SCREEN_HEIGHT = 234;

		// Token: 0x04000588 RID: 1416
		public const int HR_SCREEN_HEIGHT = 446;

		// Token: 0x04000589 RID: 1417
		private const int LR_SCREEN_WIDTH_SQ_PIXEL = 480;

		// Token: 0x0400058A RID: 1418
		private const int HR_SCREEN_WIDTH_SQ_PIXEL = 800;

		// Token: 0x0400058B RID: 1419
		private const int LR_SCREEN_HEIGHT_SQ_PIXEL = 270;

		// Token: 0x0400058C RID: 1420
		private const int HR_SCREEN_HEIGHT_SQ_PIXEL = 454;

		// Token: 0x0400058D RID: 1421
		private const double LR_SCREEN_RATIO = 1.7613636;

		// Token: 0x0400058E RID: 1422
		private const double HR_SCREEN_RATIO = 1.7613636;

		// Token: 0x0400058F RID: 1423
		private const double LR_PIXEL_RATIO = 1.15136476426799;

		// Token: 0x04000590 RID: 1424
		private const double HR_PIXEL_RATIO = 1.01837120574887;

		// Token: 0x04000591 RID: 1425
		private static Rectangle _LRscreenRectangle = new Rectangle(0, 0, 480, 234);

		// Token: 0x04000592 RID: 1426
		private static Rectangle _HRscreenRectangle = new Rectangle(0, 0, 800, 446);

		// Token: 0x04000593 RID: 1427
		private static Rectangle _LRscreenRectangleSqPixel = new Rectangle(0, 0, 480, 270);

		// Token: 0x04000594 RID: 1428
		private static Rectangle _HRscreenRectangleSqPixel = new Rectangle(0, 0, 800, 454);
	}
}
