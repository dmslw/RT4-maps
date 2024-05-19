using System;
using System.Runtime.InteropServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x0200006E RID: 110
	public class projection
	{
		// Token: 0x06000D03 RID: 3331 RVA: 0x0011EC5C File Offset: 0x0011DC5C
		public projection()
		{
			this.RT3args = new string[]
			{
				"proj=tmerc",
				"ellps=WGS84",
				"lon_0=10.2",
				"lat_0=52.8",
				"k=0.9996",
				"x_0=1948383.3119",
				"y_0=2253150.74792"
			};
			this.RT4args = new string[]
			{
				"proj=tmerc",
				"ellps=WGS84",
				"lon_0=10.2",
				"lat_0=52.8",
				"k=0.9996",
				"x_0=3350062.3119",
				"y_0=2750202.74792"
			};
		}

		// Token: 0x06000D04 RID: 3332
		[DllImport("proj.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr _pj_init(int nargs, [In] [Out] string[] args);

		// Token: 0x06000D05 RID: 3333
		[DllImport("proj.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern XY _pj_fwd(LP lp, IntPtr PJ);

		// Token: 0x06000D06 RID: 3334
		[DllImport("proj.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern LP _pj_inv(XY xy, IntPtr PJ);

		// Token: 0x06000D07 RID: 3335
		[DllImport("proj.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern void _pj_free(ref IntPtr PJ);

		// Token: 0x06000D08 RID: 3336 RVA: 0x0011ED0C File Offset: 0x0011DD0C
		public bool init(Common.RTxMapType mapType)
		{
			bool flag = mapType == Common.RTxMapType.RT3;
			string[] array;
			if (flag)
			{
				array = this.RT3args;
			}
			else
			{
				array = this.RT4args;
			}
			this.@ref = 0;
			bool result = true;
			try
			{
				this.@ref = projection._pj_init(array.Length, array);
			}
			catch (DllNotFoundException ex)
			{
				MyProject.Forms.FatalErrorBox.showError(ex.Message);
			}
			catch (EntryPointNotFoundException ex2)
			{
				MyProject.Forms.FatalErrorBox.showError(ex2.Message);
			}
			catch (Exception ex3)
			{
				MyProject.Forms.FatalErrorBox.showError("Unknown fatal error");
			}
			IntPtr value;
			flag = (this.@ref == value);
			if (flag)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0011EE08 File Offset: 0x0011DE08
		public XY proj(double lam, double phi)
		{
			LP lp;
			lp.lam = lam * 3.141592653589793 / 180.0;
			lp.phi = phi * 3.141592653589793 / 180.0;
			return projection._pj_fwd(lp, this.@ref);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0011EE5C File Offset: 0x0011DE5C
		public LP proj_inv(double x, double y)
		{
			XY xy;
			xy.X = x;
			xy.Y = y;
			return projection._pj_inv(xy, this.@ref);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0011EE88 File Offset: 0x0011DE88
		public static int ERT4ToERT3(int ERT4)
		{
			return checked(ERT4 - 1401679);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0011EEA4 File Offset: 0x0011DEA4
		public static int NRT4ToNRT3(int NRT4)
		{
			return checked(NRT4 - 497052);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0011EEC0 File Offset: 0x0011DEC0
		public static int ERT3ToERT4(int ERT3)
		{
			return checked(ERT3 + 1401679);
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0011EEDC File Offset: 0x0011DEDC
		public static int NRT3ToNRT4(int NRT3)
		{
			return checked(NRT3 + 497052);
		}

		// Token: 0x0400054D RID: 1357
		private IntPtr @ref;

		// Token: 0x0400054E RID: 1358
		private string[] RT3args;

		// Token: 0x0400054F RID: 1359
		private string[] RT4args;

		// Token: 0x04000550 RID: 1360
		private const int dXRT3 = 0;

		// Token: 0x04000551 RID: 1361
		private const int dYRT3 = 0;

		// Token: 0x04000552 RID: 1362
		private const int dXRT4 = 1401679;

		// Token: 0x04000553 RID: 1363
		private const int dYRT4 = 497052;
	}
}
