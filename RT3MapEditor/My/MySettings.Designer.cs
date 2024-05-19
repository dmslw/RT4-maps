using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor.My
{
	// Token: 0x02000055 RID: 85
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[CompilerGenerated]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x060009FD RID: 2557 RVA: 0x0015EA14 File Offset: 0x0015DA14
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			bool saveMySettingsOnExit = MyProject.Application.SaveMySettingsOnExit;
			if (saveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0015EA40 File Offset: 0x0015DA40
		public static MySettings Default
		{
			get
			{
				bool flag = !MySettings.addedHandler;
				if (flag)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						flag = !MySettings.addedHandler;
						if (flag)
						{
							MyProject.Application.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x0015EAC0 File Offset: 0x0015DAC0
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x0015EAE4 File Offset: 0x0015DAE4
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string importPath
		{
			get
			{
				return Conversions.ToString(this["importPath"]);
			}
			set
			{
				this["importPath"] = value;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0015EAF8 File Offset: 0x0015DAF8
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x0015EB1C File Offset: 0x0015DB1C
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string UICulture
		{
			get
			{
				return Conversions.ToString(this["UICulture"]);
			}
			set
			{
				this["UICulture"] = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0015EB30 File Offset: 0x0015DB30
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x0015EB54 File Offset: 0x0015DB54
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string tempDir
		{
			get
			{
				return Conversions.ToString(this["tempDir"]);
			}
			set
			{
				this["tempDir"] = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0015EB68 File Offset: 0x0015DB68
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x0015EB8C File Offset: 0x0015DB8C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string BurningCommand
		{
			get
			{
				return Conversions.ToString(this["BurningCommand"]);
			}
			set
			{
				this["BurningCommand"] = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0015EBA0 File Offset: 0x0015DBA0
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x0015EBC4 File Offset: 0x0015DBC4
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string mode
		{
			get
			{
				return Conversions.ToString(this["mode"]);
			}
			set
			{
				this["mode"] = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0015EBD8 File Offset: 0x0015DBD8
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x0015EBFC File Offset: 0x0015DBFC
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string exportPath
		{
			get
			{
				return Conversions.ToString(this["exportPath"]);
			}
			set
			{
				this["exportPath"] = value;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0015EC10 File Offset: 0x0015DC10
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x0015EC34 File Offset: 0x0015DC34
		[UserScopedSetting]
		[DefaultSettingValue("c:\\RTxMAP")]
		[DebuggerNonUserCode]
		public string WorkingDir
		{
			get
			{
				return Conversions.ToString(this["WorkingDir"]);
			}
			set
			{
				this["WorkingDir"] = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0015EC48 File Offset: 0x0015DC48
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x0015EC6C File Offset: 0x0015DC6C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("c:\\RTxMAP")]
		public string ISODir
		{
			get
			{
				return Conversions.ToString(this["ISODir"]);
			}
			set
			{
				this["ISODir"] = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0015EC80 File Offset: 0x0015DC80
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x0015ECA4 File Offset: 0x0015DCA4
		[DefaultSettingValue("1")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int BurnedMapNumber
		{
			get
			{
				return Conversions.ToInteger(this["BurnedMapNumber"]);
			}
			set
			{
				this["BurnedMapNumber"] = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0015ECBC File Offset: 0x0015DCBC
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x0015ECE0 File Offset: 0x0015DCE0
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool configComplete
		{
			get
			{
				return Conversions.ToBoolean(this["configComplete"]);
			}
			set
			{
				this["configComplete"] = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0015ECF8 File Offset: 0x0015DCF8
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x0015ED1C File Offset: 0x0015DD1C
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool importErrIncFormat
		{
			get
			{
				return Conversions.ToBoolean(this["importErrIncFormat"]);
			}
			set
			{
				this["importErrIncFormat"] = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0015ED34 File Offset: 0x0015DD34
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x0015ED58 File Offset: 0x0015DD58
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool importErrIncCoord
		{
			get
			{
				return Conversions.ToBoolean(this["importErrIncCoord"]);
			}
			set
			{
				this["importErrIncCoord"] = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0015ED70 File Offset: 0x0015DD70
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x0015ED94 File Offset: 0x0015DD94
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool importErrEmptyArea
		{
			get
			{
				return Conversions.ToBoolean(this["importErrEmptyArea"]);
			}
			set
			{
				this["importErrEmptyArea"] = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0015EDAC File Offset: 0x0015DDAC
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x0015EDD0 File Offset: 0x0015DDD0
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool ignoreRT3AltName
		{
			get
			{
				return Conversions.ToBoolean(this["ignoreRT3AltName"]);
			}
			set
			{
				this["ignoreRT3AltName"] = value;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0015EDE8 File Offset: 0x0015DDE8
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x0015EE0C File Offset: 0x0015DE0C
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool importAscQuoted
		{
			get
			{
				return Conversions.ToBoolean(this["importAscQuoted"]);
			}
			set
			{
				this["importAscQuoted"] = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0015EE24 File Offset: 0x0015DE24
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x0015EE48 File Offset: 0x0015DE48
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool importTxtQuoted
		{
			get
			{
				return Conversions.ToBoolean(this["importTxtQuoted"]);
			}
			set
			{
				this["importTxtQuoted"] = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0015EE60 File Offset: 0x0015DE60
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x0015EE84 File Offset: 0x0015DE84
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("9")]
		public int importCsvSepInt
		{
			get
			{
				return Conversions.ToInteger(this["importCsvSepInt"]);
			}
			set
			{
				this["importCsvSepInt"] = value;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0015EE9C File Offset: 0x0015DE9C
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x0015EEC0 File Offset: 0x0015DEC0
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool importLogError
		{
			get
			{
				return Conversions.ToBoolean(this["importLogError"]);
			}
			set
			{
				this["importLogError"] = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x0015EED8 File Offset: 0x0015DED8
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x0015EEFC File Offset: 0x0015DEFC
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool isFirstRun
		{
			get
			{
				return Conversions.ToBoolean(this["isFirstRun"]);
			}
			set
			{
				this["isFirstRun"] = value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0015EF14 File Offset: 0x0015DF14
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x0015EF38 File Offset: 0x0015DF38
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string strGpsPasPAN
		{
			get
			{
				return Conversions.ToString(this["strGpsPasPAN"]);
			}
			set
			{
				this["strGpsPasPAN"] = value;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0015EF4C File Offset: 0x0015DF4C
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x0015EF70 File Offset: 0x0015DF70
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string strGpsPasPL
		{
			get
			{
				return Conversions.ToString(this["strGpsPasPL"]);
			}
			set
			{
				this["strGpsPasPL"] = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0015EF84 File Offset: 0x0015DF84
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x0015EFA8 File Offset: 0x0015DFA8
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string strGpsPasRF
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRF"]);
			}
			set
			{
				this["strGpsPasRF"] = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0015EFBC File Offset: 0x0015DFBC
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x0015EFE0 File Offset: 0x0015DFE0
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string strGpsPasRM
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRM"]);
			}
			set
			{
				this["strGpsPasRM"] = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0015EFF4 File Offset: 0x0015DFF4
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x0015F018 File Offset: 0x0015E018
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string strGpsPasRFR
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRFR"]);
			}
			set
			{
				this["strGpsPasRFR"] = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0015F02C File Offset: 0x0015E02C
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x0015F050 File Offset: 0x0015E050
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string strGpsPasR
		{
			get
			{
				return Conversions.ToString(this["strGpsPasR"]);
			}
			set
			{
				this["strGpsPasR"] = value;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0015F064 File Offset: 0x0015E064
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x0015F088 File Offset: 0x0015E088
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string strGpsPasF
		{
			get
			{
				return Conversions.ToString(this["strGpsPasF"]);
			}
			set
			{
				this["strGpsPasF"] = value;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0015F09C File Offset: 0x0015E09C
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x0015F0C0 File Offset: 0x0015E0C0
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string strGpsPasNC
		{
			get
			{
				return Conversions.ToString(this["strGpsPasNC"]);
			}
			set
			{
				this["strGpsPasNC"] = value;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0015F0D4 File Offset: 0x0015E0D4
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x0015F0F8 File Offset: 0x0015E0F8
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string strGpsPasRD
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRD"]);
			}
			set
			{
				this["strGpsPasRD"] = value;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0015F10C File Offset: 0x0015E10C
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x0015F130 File Offset: 0x0015E130
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string strGpsPasKMH
		{
			get
			{
				return Conversions.ToString(this["strGpsPasKMH"]);
			}
			set
			{
				this["strGpsPasKMH"] = value;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0015F144 File Offset: 0x0015E144
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0015F168 File Offset: 0x0015E168
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string gpspasUserDefName
		{
			get
			{
				return Conversions.ToString(this["gpspasUserDefName"]);
			}
			set
			{
				this["gpspasUserDefName"] = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0015F17C File Offset: 0x0015E17C
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x0015F1A0 File Offset: 0x0015E1A0
		[DefaultSettingValue("1")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int gpspasDispMode
		{
			get
			{
				return Conversions.ToInteger(this["gpspasDispMode"]);
			}
			set
			{
				this["gpspasDispMode"] = value;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0015F1B8 File Offset: 0x0015E1B8
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x0015F1DC File Offset: 0x0015E1DC
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool isGpsPasMiscDisplayed
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasMiscDisplayed"]);
			}
			set
			{
				this["isGpsPasMiscDisplayed"] = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0015F1F4 File Offset: 0x0015E1F4
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0015F218 File Offset: 0x0015E218
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool isGpsPasTypeDisplayed
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasTypeDisplayed"]);
			}
			set
			{
				this["isGpsPasTypeDisplayed"] = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0015F230 File Offset: 0x0015E230
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x0015F254 File Offset: 0x0015E254
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isGpsPasNumDisplayed
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasNumDisplayed"]);
			}
			set
			{
				this["isGpsPasNumDisplayed"] = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x0015F26C File Offset: 0x0015E26C
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x0015F290 File Offset: 0x0015E290
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool isGpsPasRFRPostDisplayed
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasRFRPostDisplayed"]);
			}
			set
			{
				this["isGpsPasRFRPostDisplayed"] = value;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0015F2A8 File Offset: 0x0015E2A8
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x0015F2CC File Offset: 0x0015E2CC
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool isGpsPasSep1Displayed
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasSep1Displayed"]);
			}
			set
			{
				this["isGpsPasSep1Displayed"] = value;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0015F2E4 File Offset: 0x0015E2E4
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x0015F308 File Offset: 0x0015E308
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool isGpsPasSpeedDisplayed
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasSpeedDisplayed"]);
			}
			set
			{
				this["isGpsPasSpeedDisplayed"] = value;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0015F320 File Offset: 0x0015E320
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x0015F344 File Offset: 0x0015E344
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool isGpsPasSpeedUnitDisplayed
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasSpeedUnitDisplayed"]);
			}
			set
			{
				this["isGpsPasSpeedUnitDisplayed"] = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0015F35C File Offset: 0x0015E35C
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x0015F380 File Offset: 0x0015E380
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool isGpsPasSep2Displayed
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasSep2Displayed"]);
			}
			set
			{
				this["isGpsPasSep2Displayed"] = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0015F398 File Offset: 0x0015E398
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x0015F3BC File Offset: 0x0015E3BC
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool isGpsPasDirDisplayed
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasDirDisplayed"]);
			}
			set
			{
				this["isGpsPasDirDisplayed"] = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0015F3D4 File Offset: 0x0015E3D4
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x0015F3F8 File Offset: 0x0015E3F8
		[DefaultSettingValue("-")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string strGpsPasSep1
		{
			get
			{
				return Conversions.ToString(this["strGpsPasSep1"]);
			}
			set
			{
				this["strGpsPasSep1"] = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0015F40C File Offset: 0x0015E40C
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x0015F430 File Offset: 0x0015E430
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool isGpsPasStartDisplayed
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasStartDisplayed"]);
			}
			set
			{
				this["isGpsPasStartDisplayed"] = value;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0015F448 File Offset: 0x0015E448
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x0015F46C File Offset: 0x0015E46C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool isGpsPasEndDisplayed
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasEndDisplayed"]);
			}
			set
			{
				this["isGpsPasEndDisplayed"] = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0015F484 File Offset: 0x0015E484
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x0015F4A8 File Offset: 0x0015E4A8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string strGpsPasStart
		{
			get
			{
				return Conversions.ToString(this["strGpsPasStart"]);
			}
			set
			{
				this["strGpsPasStart"] = value;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0015F4BC File Offset: 0x0015E4BC
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x0015F4E0 File Offset: 0x0015E4E0
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string strGpsPasEnd
		{
			get
			{
				return Conversions.ToString(this["strGpsPasEnd"]);
			}
			set
			{
				this["strGpsPasEnd"] = value;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0015F4F4 File Offset: 0x0015E4F4
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x0015F518 File Offset: 0x0015E518
		[DefaultSettingValue("-")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string strGpsPasSep2
		{
			get
			{
				return Conversions.ToString(this["strGpsPasSep2"]);
			}
			set
			{
				this["strGpsPasSep2"] = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0015F52C File Offset: 0x0015E52C
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x0015F550 File Offset: 0x0015E550
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool ignoreRT3Borgate
		{
			get
			{
				return Conversions.ToBoolean(this["ignoreRT3Borgate"]);
			}
			set
			{
				this["ignoreRT3Borgate"] = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0015F568 File Offset: 0x0015E568
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x0015F58C File Offset: 0x0015E58C
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool changeEmbassy
		{
			get
			{
				return Conversions.ToBoolean(this["changeEmbassy"]);
			}
			set
			{
				this["changeEmbassy"] = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x0015F5A4 File Offset: 0x0015E5A4
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x0015F5C8 File Offset: 0x0015E5C8
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool changeIndustArea
		{
			get
			{
				return Conversions.ToBoolean(this["changeIndustArea"]);
			}
			set
			{
				this["changeIndustArea"] = value;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0015F5E0 File Offset: 0x0015E5E0
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x0015F604 File Offset: 0x0015E604
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool changeBorderCrossing
		{
			get
			{
				return Conversions.ToBoolean(this["changeBorderCrossing"]);
			}
			set
			{
				this["changeBorderCrossing"] = value;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0015F61C File Offset: 0x0015E61C
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x0015F640 File Offset: 0x0015E640
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool changePerfArts
		{
			get
			{
				return Conversions.ToBoolean(this["changePerfArts"]);
			}
			set
			{
				this["changePerfArts"] = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0015F658 File Offset: 0x0015E658
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x0015F67C File Offset: 0x0015E67C
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool changeCivicCenter
		{
			get
			{
				return Conversions.ToBoolean(this["changeCivicCenter"]);
			}
			set
			{
				this["changeCivicCenter"] = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0015F694 File Offset: 0x0015E694
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x0015F6B8 File Offset: 0x0015E6B8
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool changeMedicServ
		{
			get
			{
				return Conversions.ToBoolean(this["changeMedicServ"]);
			}
			set
			{
				this["changeMedicServ"] = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0015F6D0 File Offset: 0x0015E6D0
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x0015F6F4 File Offset: 0x0015E6F4
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool changeMotorb
		{
			get
			{
				return Conversions.ToBoolean(this["changeMotorb"]);
			}
			set
			{
				this["changeMotorb"] = value;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0015F70C File Offset: 0x0015E70C
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x0015F730 File Offset: 0x0015E730
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool STimportAll
		{
			get
			{
				return Conversions.ToBoolean(this["STimportAll"]);
			}
			set
			{
				this["STimportAll"] = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x0015F748 File Offset: 0x0015E748
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x0015F76C File Offset: 0x0015E76C
		[DefaultSettingValue("6")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte STimportAllMag
		{
			get
			{
				return Conversions.ToByte(this["STimportAllMag"]);
			}
			set
			{
				this["STimportAllMag"] = value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x0015F784 File Offset: 0x0015E784
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x0015F7A8 File Offset: 0x0015E7A8
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool STimportFixed
		{
			get
			{
				return Conversions.ToBoolean(this["STimportFixed"]);
			}
			set
			{
				this["STimportFixed"] = value;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x0015F7C0 File Offset: 0x0015E7C0
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x0015F7E4 File Offset: 0x0015E7E4
		[DefaultSettingValue("6")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte STImportFixedMag
		{
			get
			{
				return Conversions.ToByte(this["STImportFixedMag"]);
			}
			set
			{
				this["STImportFixedMag"] = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0015F7FC File Offset: 0x0015E7FC
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x0015F820 File Offset: 0x0015E820
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool STimportMobile
		{
			get
			{
				return Conversions.ToBoolean(this["STimportMobile"]);
			}
			set
			{
				this["STimportMobile"] = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0015F838 File Offset: 0x0015E838
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x0015F85C File Offset: 0x0015E85C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("6")]
		public byte STimportMobileMag
		{
			get
			{
				return Conversions.ToByte(this["STimportMobileMag"]);
			}
			set
			{
				this["STimportMobileMag"] = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0015F874 File Offset: 0x0015E874
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x0015F898 File Offset: 0x0015E898
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool STImportF120_130G
		{
			get
			{
				return Conversions.ToBoolean(this["STImportF120_130G"]);
			}
			set
			{
				this["STImportF120_130G"] = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0015F8B0 File Offset: 0x0015E8B0
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x0015F8D4 File Offset: 0x0015E8D4
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("8")]
		public byte STImportF120_130GMag
		{
			get
			{
				return Conversions.ToByte(this["STImportF120_130GMag"]);
			}
			set
			{
				this["STImportF120_130GMag"] = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0015F8EC File Offset: 0x0015E8EC
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x0015F910 File Offset: 0x0015E910
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool STImportF100_119
		{
			get
			{
				return Conversions.ToBoolean(this["STImportF100_119"]);
			}
			set
			{
				this["STImportF100_119"] = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0015F928 File Offset: 0x0015E928
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x0015F94C File Offset: 0x0015E94C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("8")]
		public byte STImportF100_119Mag
		{
			get
			{
				return Conversions.ToByte(this["STImportF100_119Mag"]);
			}
			set
			{
				this["STImportF100_119Mag"] = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0015F964 File Offset: 0x0015E964
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x0015F988 File Offset: 0x0015E988
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool STImportF80_99
		{
			get
			{
				return Conversions.ToBoolean(this["STImportF80_99"]);
			}
			set
			{
				this["STImportF80_99"] = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0015F9A0 File Offset: 0x0015E9A0
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x0015F9C4 File Offset: 0x0015E9C4
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("8")]
		public byte STImportF80_99Mag
		{
			get
			{
				return Conversions.ToByte(this["STImportF80_99Mag"]);
			}
			set
			{
				this["STImportF80_99Mag"] = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0015F9DC File Offset: 0x0015E9DC
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x0015FA00 File Offset: 0x0015EA00
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool STImportF60_79
		{
			get
			{
				return Conversions.ToBoolean(this["STImportF60_79"]);
			}
			set
			{
				this["STImportF60_79"] = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0015FA18 File Offset: 0x0015EA18
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x0015FA3C File Offset: 0x0015EA3C
		[DefaultSettingValue("8")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte STImportF60_79Mag
		{
			get
			{
				return Conversions.ToByte(this["STImportF60_79Mag"]);
			}
			set
			{
				this["STImportF60_79Mag"] = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0015FA54 File Offset: 0x0015EA54
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x0015FA78 File Offset: 0x0015EA78
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool STImportF0_59
		{
			get
			{
				return Conversions.ToBoolean(this["STImportF0_59"]);
			}
			set
			{
				this["STImportF0_59"] = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0015FA90 File Offset: 0x0015EA90
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x0015FAB4 File Offset: 0x0015EAB4
		[DebuggerNonUserCode]
		[DefaultSettingValue("8")]
		[UserScopedSetting]
		public byte STImportF0_59Mag
		{
			get
			{
				return Conversions.ToByte(this["STImportF0_59Mag"]);
			}
			set
			{
				this["STImportF0_59Mag"] = value;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0015FACC File Offset: 0x0015EACC
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x0015FAF0 File Offset: 0x0015EAF0
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool STImportM120_130
		{
			get
			{
				return Conversions.ToBoolean(this["STImportM120_130"]);
			}
			set
			{
				this["STImportM120_130"] = value;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0015FB08 File Offset: 0x0015EB08
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x0015FB2C File Offset: 0x0015EB2C
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool STImportM100_119
		{
			get
			{
				return Conversions.ToBoolean(this["STImportM100_119"]);
			}
			set
			{
				this["STImportM100_119"] = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0015FB44 File Offset: 0x0015EB44
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x0015FB68 File Offset: 0x0015EB68
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("6")]
		public byte STImportM100_119Mag
		{
			get
			{
				return Conversions.ToByte(this["STImportM100_119Mag"]);
			}
			set
			{
				this["STImportM100_119Mag"] = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0015FB80 File Offset: 0x0015EB80
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x0015FBA4 File Offset: 0x0015EBA4
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool STImportM80_99
		{
			get
			{
				return Conversions.ToBoolean(this["STImportM80_99"]);
			}
			set
			{
				this["STImportM80_99"] = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0015FBBC File Offset: 0x0015EBBC
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x0015FBE0 File Offset: 0x0015EBE0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("5")]
		public byte STImportM80_99Mag
		{
			get
			{
				return Conversions.ToByte(this["STImportM80_99Mag"]);
			}
			set
			{
				this["STImportM80_99Mag"] = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0015FBF8 File Offset: 0x0015EBF8
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x0015FC1C File Offset: 0x0015EC1C
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool STImportM60_79
		{
			get
			{
				return Conversions.ToBoolean(this["STImportM60_79"]);
			}
			set
			{
				this["STImportM60_79"] = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0015FC34 File Offset: 0x0015EC34
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x0015FC58 File Offset: 0x0015EC58
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool STImportM0_59
		{
			get
			{
				return Conversions.ToBoolean(this["STImportM0_59"]);
			}
			set
			{
				this["STImportM0_59"] = value;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0015FC70 File Offset: 0x0015EC70
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x0015FC94 File Offset: 0x0015EC94
		[UserScopedSetting]
		[DefaultSettingValue("4")]
		[DebuggerNonUserCode]
		public byte STImportM0_59Mag
		{
			get
			{
				return Conversions.ToByte(this["STImportM0_59Mag"]);
			}
			set
			{
				this["STImportM0_59Mag"] = value;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0015FCAC File Offset: 0x0015ECAC
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x0015FCD0 File Offset: 0x0015ECD0
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool STImportRFR
		{
			get
			{
				return Conversions.ToBoolean(this["STImportRFR"]);
			}
			set
			{
				this["STImportRFR"] = value;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0015FCE8 File Offset: 0x0015ECE8
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x0015FD0C File Offset: 0x0015ED0C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("4")]
		public byte STImportRFRMag
		{
			get
			{
				return Conversions.ToByte(this["STImportRFRMag"]);
			}
			set
			{
				this["STImportRFRMag"] = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0015FD24 File Offset: 0x0015ED24
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x0015FD48 File Offset: 0x0015ED48
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		public uint STImportMode
		{
			get
			{
				return Conversions.ToUInteger(this["STImportMode"]);
			}
			set
			{
				this["STImportMode"] = value;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0015FD60 File Offset: 0x0015ED60
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0015FD84 File Offset: 0x0015ED84
		[DefaultSettingValue("7")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public byte STImportM120_130Mag
		{
			get
			{
				return Conversions.ToByte(this["STImportM120_130Mag"]);
			}
			set
			{
				this["STImportM120_130Mag"] = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0015FD9C File Offset: 0x0015ED9C
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0015FDC0 File Offset: 0x0015EDC0
		[UserScopedSetting]
		[DefaultSettingValue("4")]
		[DebuggerNonUserCode]
		public byte STImportM60_79Mag
		{
			get
			{
				return Conversions.ToByte(this["STImportM60_79Mag"]);
			}
			set
			{
				this["STImportM60_79Mag"] = value;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0015FDD8 File Offset: 0x0015EDD8
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x0015FDFC File Offset: 0x0015EDFC
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public ushort STimportAllType
		{
			get
			{
				return Conversions.ToUShort(this["STimportAllType"]);
			}
			set
			{
				this["STimportAllType"] = value;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0015FE14 File Offset: 0x0015EE14
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x0015FE38 File Offset: 0x0015EE38
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		public ushort STimportFixedType
		{
			get
			{
				return Conversions.ToUShort(this["STimportFixedType"]);
			}
			set
			{
				this["STimportFixedType"] = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0015FE50 File Offset: 0x0015EE50
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x0015FE74 File Offset: 0x0015EE74
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("65535")]
		public ushort STimportMobileType
		{
			get
			{
				return Conversions.ToUShort(this["STimportMobileType"]);
			}
			set
			{
				this["STimportMobileType"] = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0015FE8C File Offset: 0x0015EE8C
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0015FEB0 File Offset: 0x0015EEB0
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportF120_130GType
		{
			get
			{
				return Conversions.ToUShort(this["STImportF120_130GType"]);
			}
			set
			{
				this["STImportF120_130GType"] = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0015FEC8 File Offset: 0x0015EEC8
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0015FEEC File Offset: 0x0015EEEC
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public ushort STImportF100_119Type
		{
			get
			{
				return Conversions.ToUShort(this["STImportF100_119Type"]);
			}
			set
			{
				this["STImportF100_119Type"] = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0015FF04 File Offset: 0x0015EF04
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0015FF28 File Offset: 0x0015EF28
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		public ushort STImportF80_99Type
		{
			get
			{
				return Conversions.ToUShort(this["STImportF80_99Type"]);
			}
			set
			{
				this["STImportF80_99Type"] = value;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0015FF40 File Offset: 0x0015EF40
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0015FF64 File Offset: 0x0015EF64
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportF60_79Type
		{
			get
			{
				return Conversions.ToUShort(this["STImportF60_79Type"]);
			}
			set
			{
				this["STImportF60_79Type"] = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0015FF7C File Offset: 0x0015EF7C
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0015FFA0 File Offset: 0x0015EFA0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("65535")]
		public ushort STImportF0_59Type
		{
			get
			{
				return Conversions.ToUShort(this["STImportF0_59Type"]);
			}
			set
			{
				this["STImportF0_59Type"] = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0015FFB8 File Offset: 0x0015EFB8
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0015FFDC File Offset: 0x0015EFDC
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportM120_130Type
		{
			get
			{
				return Conversions.ToUShort(this["STImportM120_130Type"]);
			}
			set
			{
				this["STImportM120_130Type"] = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0015FFF4 File Offset: 0x0015EFF4
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00160018 File Offset: 0x0015F018
		[DefaultSettingValue("65535")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public ushort STImportM100_119Type
		{
			get
			{
				return Conversions.ToUShort(this["STImportM100_119Type"]);
			}
			set
			{
				this["STImportM100_119Type"] = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00160030 File Offset: 0x0015F030
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00160054 File Offset: 0x0015F054
		[DefaultSettingValue("65535")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public ushort STImportM80_99Type
		{
			get
			{
				return Conversions.ToUShort(this["STImportM80_99Type"]);
			}
			set
			{
				this["STImportM80_99Type"] = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0016006C File Offset: 0x0015F06C
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00160090 File Offset: 0x0015F090
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportM60_79Type
		{
			get
			{
				return Conversions.ToUShort(this["STImportM60_79Type"]);
			}
			set
			{
				this["STImportM60_79Type"] = value;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x001600A8 File Offset: 0x0015F0A8
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x001600CC File Offset: 0x0015F0CC
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportM0_59Type
		{
			get
			{
				return Conversions.ToUShort(this["STImportM0_59Type"]);
			}
			set
			{
				this["STImportM0_59Type"] = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x001600E4 File Offset: 0x0015F0E4
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00160108 File Offset: 0x0015F108
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		public ushort STImportRFRType
		{
			get
			{
				return Conversions.ToUShort(this["STImportRFRType"]);
			}
			set
			{
				this["STImportRFRType"] = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00160120 File Offset: 0x0015F120
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00160144 File Offset: 0x0015F144
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool STImportAllTypeIsNP
		{
			get
			{
				return Conversions.ToBoolean(this["STImportAllTypeIsNP"]);
			}
			set
			{
				this["STImportAllTypeIsNP"] = value;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0016015C File Offset: 0x0015F15C
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00160180 File Offset: 0x0015F180
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool STImportFixedTypeIsNP
		{
			get
			{
				return Conversions.ToBoolean(this["STImportFixedTypeIsNP"]);
			}
			set
			{
				this["STImportFixedTypeIsNP"] = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00160198 File Offset: 0x0015F198
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x001601BC File Offset: 0x0015F1BC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool STImportMobileTypeIsNP
		{
			get
			{
				return Conversions.ToBoolean(this["STImportMobileTypeIsNP"]);
			}
			set
			{
				this["STImportMobileTypeIsNP"] = value;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x001601D4 File Offset: 0x0015F1D4
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x001601F8 File Offset: 0x0015F1F8
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort importDefaultType
		{
			get
			{
				return Conversions.ToUShort(this["importDefaultType"]);
			}
			set
			{
				this["importDefaultType"] = value;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00160210 File Offset: 0x0015F210
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00160234 File Offset: 0x0015F234
		[DebuggerNonUserCode]
		[DefaultSettingValue("6")]
		[UserScopedSetting]
		public byte importDefaultMag
		{
			get
			{
				return Conversions.ToByte(this["importDefaultMag"]);
			}
			set
			{
				this["importDefaultMag"] = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0016024C File Offset: 0x0015F24C
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00160270 File Offset: 0x0015F270
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("1")]
		public uint exportFormat
		{
			get
			{
				return Conversions.ToUInteger(this["exportFormat"]);
			}
			set
			{
				this["exportFormat"] = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00160288 File Offset: 0x0015F288
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x001602AC File Offset: 0x0015F2AC
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool exportLatCsv
		{
			get
			{
				return Conversions.ToBoolean(this["exportLatCsv"]);
			}
			set
			{
				this["exportLatCsv"] = value;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x001602C4 File Offset: 0x0015F2C4
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x001602E8 File Offset: 0x0015F2E8
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool exportNameCsv
		{
			get
			{
				return Conversions.ToBoolean(this["exportNameCsv"]);
			}
			set
			{
				this["exportNameCsv"] = value;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x00160300 File Offset: 0x0015F300
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00160324 File Offset: 0x0015F324
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool exportAddressCsv
		{
			get
			{
				return Conversions.ToBoolean(this["exportAddressCsv"]);
			}
			set
			{
				this["exportAddressCsv"] = value;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0016033C File Offset: 0x0015F33C
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00160360 File Offset: 0x0015F360
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool exportTelCsv
		{
			get
			{
				return Conversions.ToBoolean(this["exportTelCsv"]);
			}
			set
			{
				this["exportTelCsv"] = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00160378 File Offset: 0x0015F378
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x0016039C File Offset: 0x0015F39C
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool exportCityCsv
		{
			get
			{
				return Conversions.ToBoolean(this["exportCityCsv"]);
			}
			set
			{
				this["exportCityCsv"] = value;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x001603B4 File Offset: 0x0015F3B4
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x001603D8 File Offset: 0x0015F3D8
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool exportCommentCsv
		{
			get
			{
				return Conversions.ToBoolean(this["exportCommentCsv"]);
			}
			set
			{
				this["exportCommentCsv"] = value;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x001603F0 File Offset: 0x0015F3F0
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00160414 File Offset: 0x0015F414
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool exportBrandCsv
		{
			get
			{
				return Conversions.ToBoolean(this["exportBrandCsv"]);
			}
			set
			{
				this["exportBrandCsv"] = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0016042C File Offset: 0x0015F42C
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00160450 File Offset: 0x0015F450
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool exportRT3
		{
			get
			{
				return Conversions.ToBoolean(this["exportRT3"]);
			}
			set
			{
				this["exportRT3"] = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00160468 File Offset: 0x0015F468
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x0016048C File Offset: 0x0015F48C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string exportFieldLatCsv
		{
			get
			{
				return Conversions.ToString(this["exportFieldLatCsv"]);
			}
			set
			{
				this["exportFieldLatCsv"] = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x001604A0 File Offset: 0x0015F4A0
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x001604C4 File Offset: 0x0015F4C4
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string exportFieldLonCsv
		{
			get
			{
				return Conversions.ToString(this["exportFieldLonCsv"]);
			}
			set
			{
				this["exportFieldLonCsv"] = value;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x001604D8 File Offset: 0x0015F4D8
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x001604FC File Offset: 0x0015F4FC
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string exportFieldNameCsv
		{
			get
			{
				return Conversions.ToString(this["exportFieldNameCsv"]);
			}
			set
			{
				this["exportFieldNameCsv"] = value;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00160510 File Offset: 0x0015F510
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00160534 File Offset: 0x0015F534
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string exportFieldAddressCsv
		{
			get
			{
				return Conversions.ToString(this["exportFieldAddressCsv"]);
			}
			set
			{
				this["exportFieldAddressCsv"] = value;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00160548 File Offset: 0x0015F548
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x0016056C File Offset: 0x0015F56C
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string exportFieldCityCsv
		{
			get
			{
				return Conversions.ToString(this["exportFieldCityCsv"]);
			}
			set
			{
				this["exportFieldCityCsv"] = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00160580 File Offset: 0x0015F580
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x001605A4 File Offset: 0x0015F5A4
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string exportFieldTelCsv
		{
			get
			{
				return Conversions.ToString(this["exportFieldTelCsv"]);
			}
			set
			{
				this["exportFieldTelCsv"] = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x001605B8 File Offset: 0x0015F5B8
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x001605DC File Offset: 0x0015F5DC
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string exportFieldCommentCsv
		{
			get
			{
				return Conversions.ToString(this["exportFieldCommentCsv"]);
			}
			set
			{
				this["exportFieldCommentCsv"] = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x001605F0 File Offset: 0x0015F5F0
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x00160614 File Offset: 0x0015F614
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string exportFieldBrandCsv
		{
			get
			{
				return Conversions.ToString(this["exportFieldBrandCsv"]);
			}
			set
			{
				this["exportFieldBrandCsv"] = value;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00160628 File Offset: 0x0015F628
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x0016064C File Offset: 0x0015F64C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool exportAddressAsc
		{
			get
			{
				return Conversions.ToBoolean(this["exportAddressAsc"]);
			}
			set
			{
				this["exportAddressAsc"] = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00160664 File Offset: 0x0015F664
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00160688 File Offset: 0x0015F688
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool exportCityAsc
		{
			get
			{
				return Conversions.ToBoolean(this["exportCityAsc"]);
			}
			set
			{
				this["exportCityAsc"] = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x001606A0 File Offset: 0x0015F6A0
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x001606C4 File Offset: 0x0015F6C4
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool exportTelAsc
		{
			get
			{
				return Conversions.ToBoolean(this["exportTelAsc"]);
			}
			set
			{
				this["exportTelAsc"] = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x001606DC File Offset: 0x0015F6DC
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00160700 File Offset: 0x0015F700
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool exportCommentAsc
		{
			get
			{
				return Conversions.ToBoolean(this["exportCommentAsc"]);
			}
			set
			{
				this["exportCommentAsc"] = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00160718 File Offset: 0x0015F718
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x0016073C File Offset: 0x0015F73C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool exportBrandAsc
		{
			get
			{
				return Conversions.ToBoolean(this["exportBrandAsc"]);
			}
			set
			{
				this["exportBrandAsc"] = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00160754 File Offset: 0x0015F754
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00160778 File Offset: 0x0015F778
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool exportLonCsv
		{
			get
			{
				return Conversions.ToBoolean(this["exportLonCsv"]);
			}
			set
			{
				this["exportLonCsv"] = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00160790 File Offset: 0x0015F790
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x001607B4 File Offset: 0x0015F7B4
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string exportFieldLatTxt
		{
			get
			{
				return Conversions.ToString(this["exportFieldLatTxt"]);
			}
			set
			{
				this["exportFieldLatTxt"] = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x001607C8 File Offset: 0x0015F7C8
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x001607EC File Offset: 0x0015F7EC
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string exportFieldLonTxt
		{
			get
			{
				return Conversions.ToString(this["exportFieldLonTxt"]);
			}
			set
			{
				this["exportFieldLonTxt"] = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00160800 File Offset: 0x0015F800
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00160824 File Offset: 0x0015F824
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string exportFieldNameTxt
		{
			get
			{
				return Conversions.ToString(this["exportFieldNameTxt"]);
			}
			set
			{
				this["exportFieldNameTxt"] = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00160838 File Offset: 0x0015F838
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x0016085C File Offset: 0x0015F85C
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string exportFieldAddressTxt
		{
			get
			{
				return Conversions.ToString(this["exportFieldAddressTxt"]);
			}
			set
			{
				this["exportFieldAddressTxt"] = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00160870 File Offset: 0x0015F870
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x00160894 File Offset: 0x0015F894
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string exportFieldCityTxt
		{
			get
			{
				return Conversions.ToString(this["exportFieldCityTxt"]);
			}
			set
			{
				this["exportFieldCityTxt"] = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x001608A8 File Offset: 0x0015F8A8
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x001608CC File Offset: 0x0015F8CC
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string exportFieldTelTxt
		{
			get
			{
				return Conversions.ToString(this["exportFieldTelTxt"]);
			}
			set
			{
				this["exportFieldTelTxt"] = value;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x001608E0 File Offset: 0x0015F8E0
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00160904 File Offset: 0x0015F904
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string exportFieldCommentTxt
		{
			get
			{
				return Conversions.ToString(this["exportFieldCommentTxt"]);
			}
			set
			{
				this["exportFieldCommentTxt"] = value;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00160918 File Offset: 0x0015F918
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x0016093C File Offset: 0x0015F93C
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string exportFieldBrandTxt
		{
			get
			{
				return Conversions.ToString(this["exportFieldBrandTxt"]);
			}
			set
			{
				this["exportFieldBrandTxt"] = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00160950 File Offset: 0x0015F950
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00160974 File Offset: 0x0015F974
		[DebuggerNonUserCode]
		[DefaultSettingValue(" | ")]
		[UserScopedSetting]
		public string exportAscIntSeparator
		{
			get
			{
				return Conversions.ToString(this["exportAscIntSeparator"]);
			}
			set
			{
				this["exportAscIntSeparator"] = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00160988 File Offset: 0x0015F988
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x001609AC File Offset: 0x0015F9AC
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool exportCountryAsc
		{
			get
			{
				return Conversions.ToBoolean(this["exportCountryAsc"]);
			}
			set
			{
				this["exportCountryAsc"] = value;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x001609C4 File Offset: 0x0015F9C4
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x001609E8 File Offset: 0x0015F9E8
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool exportCountryCsv
		{
			get
			{
				return Conversions.ToBoolean(this["exportCountryCsv"]);
			}
			set
			{
				this["exportCountryCsv"] = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00160A00 File Offset: 0x0015FA00
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00160A24 File Offset: 0x0015FA24
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string exportFieldCountryTxt
		{
			get
			{
				return Conversions.ToString(this["exportFieldCountryTxt"]);
			}
			set
			{
				this["exportFieldCountryTxt"] = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00160A38 File Offset: 0x0015FA38
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00160A5C File Offset: 0x0015FA5C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string exportFieldCountryCsv
		{
			get
			{
				return Conversions.ToString(this["exportFieldCountryCsv"]);
			}
			set
			{
				this["exportFieldCountryCsv"] = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00160A70 File Offset: 0x0015FA70
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00160A94 File Offset: 0x0015FA94
		[DebuggerNonUserCode]
		[DefaultSettingValue("59")]
		[UserScopedSetting]
		public int exportCsvSepInt
		{
			get
			{
				return Conversions.ToInteger(this["exportCsvSepInt"]);
			}
			set
			{
				this["exportCsvSepInt"] = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00160AAC File Offset: 0x0015FAAC
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00160AD0 File Offset: 0x0015FAD0
		[DefaultSettingValue("42")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int exportDecSepCsvInt
		{
			get
			{
				return Conversions.ToInteger(this["exportDecSepCsvInt"]);
			}
			set
			{
				this["exportDecSepCsvInt"] = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00160AE8 File Offset: 0x0015FAE8
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00160B0C File Offset: 0x0015FB0C
		[DefaultSettingValue("9")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public int exportTxtSepInt
		{
			get
			{
				return Conversions.ToInteger(this["exportTxtSepInt"]);
			}
			set
			{
				this["exportTxtSepInt"] = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00160B24 File Offset: 0x0015FB24
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x00160B48 File Offset: 0x0015FB48
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("ERT3")]
		public string exportFieldERT3Txt
		{
			get
			{
				return Conversions.ToString(this["exportFieldERT3Txt"]);
			}
			set
			{
				this["exportFieldERT3Txt"] = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00160B5C File Offset: 0x0015FB5C
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00160B80 File Offset: 0x0015FB80
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("NRT3")]
		public string exportFieldNRT3Txt
		{
			get
			{
				return Conversions.ToString(this["exportFieldNRT3Txt"]);
			}
			set
			{
				this["exportFieldNRT3Txt"] = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00160B94 File Offset: 0x0015FB94
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00160BB8 File Offset: 0x0015FBB8
		[DefaultSettingValue("Type")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string exportFieldTypeTxt
		{
			get
			{
				return Conversions.ToString(this["exportFieldTypeTxt"]);
			}
			set
			{
				this["exportFieldTypeTxt"] = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00160BCC File Offset: 0x0015FBCC
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00160BF0 File Offset: 0x0015FBF0
		[DefaultSettingValue("Magnitude")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string exportFieldMagnitudeTxt
		{
			get
			{
				return Conversions.ToString(this["exportFieldMagnitudeTxt"]);
			}
			set
			{
				this["exportFieldMagnitudeTxt"] = value;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00160C04 File Offset: 0x0015FC04
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00160C28 File Offset: 0x0015FC28
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("ct")]
		public string exportFieldCtTxt
		{
			get
			{
				return Conversions.ToString(this["exportFieldCtTxt"]);
			}
			set
			{
				this["exportFieldCtTxt"] = value;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00160C3C File Offset: 0x0015FC3C
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00160C60 File Offset: 0x0015FC60
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool forceRadarDisplay
		{
			get
			{
				return Conversions.ToBoolean(this["forceRadarDisplay"]);
			}
			set
			{
				this["forceRadarDisplay"] = value;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00160C78 File Offset: 0x0015FC78
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x00160C9C File Offset: 0x0015FC9C
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool upgMap
		{
			get
			{
				return Conversions.ToBoolean(this["upgMap"]);
			}
			set
			{
				this["upgMap"] = value;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00160CB4 File Offset: 0x0015FCB4
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00160CD8 File Offset: 0x0015FCD8
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string USBKeyPath
		{
			get
			{
				return Conversions.ToString(this["USBKeyPath"]);
			}
			set
			{
				this["USBKeyPath"] = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00160D24 File Offset: 0x0015FD24
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x00160D48 File Offset: 0x0015FD48
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool configCompleteOnce
		{
			get
			{
				return Conversions.ToBoolean(this["configCompleteOnce"]);
			}
			set
			{
				this["configCompleteOnce"] = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00160D60 File Offset: 0x0015FD60
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x00160D84 File Offset: 0x0015FD84
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool autoLoad
		{
			get
			{
				return Conversions.ToBoolean(this["autoLoad"]);
			}
			set
			{
				this["autoLoad"] = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00160D9C File Offset: 0x0015FD9C
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x00160DC0 File Offset: 0x0015FDC0
		[DebuggerNonUserCode]
		[DefaultSettingValue("RT3")]
		[UserScopedSetting]
		public string RTxType
		{
			get
			{
				return Conversions.ToString(this["RTxType"]);
			}
			set
			{
				this["RTxType"] = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00160DD4 File Offset: 0x0015FDD4
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00160DF8 File Offset: 0x0015FDF8
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort ImportDefaultTypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["ImportDefaultTypeRT4"]);
			}
			set
			{
				this["ImportDefaultTypeRT4"] = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00160E10 File Offset: 0x0015FE10
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00160E34 File Offset: 0x0015FE34
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool RT4CDRMode
		{
			get
			{
				return Conversions.ToBoolean(this["RT4CDRMode"]);
			}
			set
			{
				this["RT4CDRMode"] = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00160E4C File Offset: 0x0015FE4C
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x00160E70 File Offset: 0x0015FE70
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool RT4USBMode
		{
			get
			{
				return Conversions.ToBoolean(this["RT4USBMode"]);
			}
			set
			{
				this["RT4USBMode"] = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00160E88 File Offset: 0x0015FE88
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x00160EAC File Offset: 0x0015FEAC
		[DefaultSettingValue("65535")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public ushort STimportAllTypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STimportAllTypeRT3"]);
			}
			set
			{
				this["STimportAllTypeRT3"] = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x00160EC4 File Offset: 0x0015FEC4
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x00160EE8 File Offset: 0x0015FEE8
		[DebuggerNonUserCode]
		[DefaultSettingValue("65535")]
		[UserScopedSetting]
		public ushort STimportAllTypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STimportAllTypeRT4"]);
			}
			set
			{
				this["STimportAllTypeRT4"] = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00160F00 File Offset: 0x0015FF00
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00160F24 File Offset: 0x0015FF24
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STimportFixedTypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STimportFixedTypeRT3"]);
			}
			set
			{
				this["STimportFixedTypeRT3"] = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00160F3C File Offset: 0x0015FF3C
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00160F60 File Offset: 0x0015FF60
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STimportFixedTypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STimportFixedTypeRT4"]);
			}
			set
			{
				this["STimportFixedTypeRT4"] = value;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00160F78 File Offset: 0x0015FF78
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00160F9C File Offset: 0x0015FF9C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		public ushort STImportF0_59TypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STImportF0_59TypeRT3"]);
			}
			set
			{
				this["STImportF0_59TypeRT3"] = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00160FB4 File Offset: 0x0015FFB4
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00160FD8 File Offset: 0x0015FFD8
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		public ushort STImportF0_59TypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STImportF0_59TypeRT4"]);
			}
			set
			{
				this["STImportF0_59TypeRT4"] = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00160FF0 File Offset: 0x0015FFF0
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00161014 File Offset: 0x00160014
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		public ushort STImportF60_79TypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STImportF60_79TypeRT3"]);
			}
			set
			{
				this["STImportF60_79TypeRT3"] = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0016102C File Offset: 0x0016002C
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00161050 File Offset: 0x00160050
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		public ushort STImportF60_79TypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STImportF60_79TypeRT4"]);
			}
			set
			{
				this["STImportF60_79TypeRT4"] = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00161068 File Offset: 0x00160068
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x0016108C File Offset: 0x0016008C
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportF80_99TypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STImportF80_99TypeRT3"]);
			}
			set
			{
				this["STImportF80_99TypeRT3"] = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x001610A4 File Offset: 0x001600A4
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x001610C8 File Offset: 0x001600C8
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public ushort STImportF80_99TypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STImportF80_99TypeRT4"]);
			}
			set
			{
				this["STImportF80_99TypeRT4"] = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x001610E0 File Offset: 0x001600E0
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00161104 File Offset: 0x00160104
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportF100_119TypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STImportF100_119TypeRT3"]);
			}
			set
			{
				this["STImportF100_119TypeRT3"] = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0016111C File Offset: 0x0016011C
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x00161140 File Offset: 0x00160140
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportF100_119TypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STImportF100_119TypeRT4"]);
			}
			set
			{
				this["STImportF100_119TypeRT4"] = value;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00161158 File Offset: 0x00160158
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x0016117C File Offset: 0x0016017C
		[DefaultSettingValue("65535")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public ushort STImportF120_130GTypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STImportF120_130GTypeRT3"]);
			}
			set
			{
				this["STImportF120_130GTypeRT3"] = value;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00161194 File Offset: 0x00160194
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x001611B8 File Offset: 0x001601B8
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		public ushort STImportF120_130GTypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STImportF120_130GTypeRT4"]);
			}
			set
			{
				this["STImportF120_130GTypeRT4"] = value;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x001611D0 File Offset: 0x001601D0
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x001611F4 File Offset: 0x001601F4
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportRFRTypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STImportRFRTypeRT3"]);
			}
			set
			{
				this["STImportRFRTypeRT3"] = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0016120C File Offset: 0x0016020C
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x00161230 File Offset: 0x00160230
		[DebuggerNonUserCode]
		[DefaultSettingValue("65535")]
		[UserScopedSetting]
		public ushort STImportRFRTypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STImportRFRTypeRT4"]);
			}
			set
			{
				this["STImportRFRTypeRT4"] = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00161248 File Offset: 0x00160248
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x0016126C File Offset: 0x0016026C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		public ushort STimportMobileTypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STimportMobileTypeRT3"]);
			}
			set
			{
				this["STimportMobileTypeRT3"] = value;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00161284 File Offset: 0x00160284
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x001612A8 File Offset: 0x001602A8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("65535")]
		public ushort STimportMobileTypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STimportMobileTypeRT4"]);
			}
			set
			{
				this["STimportMobileTypeRT4"] = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x001612C0 File Offset: 0x001602C0
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x001612E4 File Offset: 0x001602E4
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportM0_59TypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STImportM0_59TypeRT3"]);
			}
			set
			{
				this["STImportM0_59TypeRT3"] = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x001612FC File Offset: 0x001602FC
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00161320 File Offset: 0x00160320
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportM0_59TypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STImportM0_59TypeRT4"]);
			}
			set
			{
				this["STImportM0_59TypeRT4"] = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00161338 File Offset: 0x00160338
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x0016135C File Offset: 0x0016035C
		[DebuggerNonUserCode]
		[DefaultSettingValue("65535")]
		[UserScopedSetting]
		public ushort STImportM60_79TypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STImportM60_79TypeRT3"]);
			}
			set
			{
				this["STImportM60_79TypeRT3"] = value;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00161374 File Offset: 0x00160374
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00161398 File Offset: 0x00160398
		[DebuggerNonUserCode]
		[DefaultSettingValue("65535")]
		[UserScopedSetting]
		public ushort STImportM60_79TypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STImportM60_79TypeRT4"]);
			}
			set
			{
				this["STImportM60_79TypeRT4"] = value;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x001613B0 File Offset: 0x001603B0
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x001613D4 File Offset: 0x001603D4
		[DefaultSettingValue("65535")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public ushort STImportM80_99TypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STImportM80_99TypeRT3"]);
			}
			set
			{
				this["STImportM80_99TypeRT3"] = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x001613EC File Offset: 0x001603EC
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00161410 File Offset: 0x00160410
		[DefaultSettingValue("65535")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public ushort STImportM80_99TypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STImportM80_99TypeRT4"]);
			}
			set
			{
				this["STImportM80_99TypeRT4"] = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00161428 File Offset: 0x00160428
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x0016144C File Offset: 0x0016044C
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportM100_119TypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STImportM100_119TypeRT3"]);
			}
			set
			{
				this["STImportM100_119TypeRT3"] = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00161464 File Offset: 0x00160464
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00161488 File Offset: 0x00160488
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		public ushort STImportM100_119TypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STImportM100_119TypeRT4"]);
			}
			set
			{
				this["STImportM100_119TypeRT4"] = value;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x001614A0 File Offset: 0x001604A0
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x001614C4 File Offset: 0x001604C4
		[DefaultSettingValue("65535")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public ushort STImportM120_130TypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["STImportM120_130TypeRT3"]);
			}
			set
			{
				this["STImportM120_130TypeRT3"] = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x001614DC File Offset: 0x001604DC
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x00161500 File Offset: 0x00160500
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("65535")]
		public ushort STImportM120_130TypeRT4
		{
			get
			{
				return Conversions.ToUShort(this["STImportM120_130TypeRT4"]);
			}
			set
			{
				this["STImportM120_130TypeRT4"] = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00161518 File Offset: 0x00160518
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x0016153C File Offset: 0x0016053C
		[DefaultSettingValue("65535")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public ushort ImportDefaultTypeRT3
		{
			get
			{
				return Conversions.ToUShort(this["ImportDefaultTypeRT3"]);
			}
			set
			{
				this["ImportDefaultTypeRT3"] = value;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00161554 File Offset: 0x00160554
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x00161578 File Offset: 0x00160578
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool ignoreRT4Borgate
		{
			get
			{
				return Conversions.ToBoolean(this["ignoreRT4Borgate"]);
			}
			set
			{
				this["ignoreRT4Borgate"] = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00161590 File Offset: 0x00160590
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x001615B4 File Offset: 0x001605B4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool changeRT4Embassy
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT4Embassy"]);
			}
			set
			{
				this["changeRT4Embassy"] = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x001615CC File Offset: 0x001605CC
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x001615F0 File Offset: 0x001605F0
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool changeRT4IndustArea
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT4IndustArea"]);
			}
			set
			{
				this["changeRT4IndustArea"] = value;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00161608 File Offset: 0x00160608
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x0016162C File Offset: 0x0016062C
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool changeRT4BorderCrossing
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT4BorderCrossing"]);
			}
			set
			{
				this["changeRT4BorderCrossing"] = value;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00161644 File Offset: 0x00160644
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x00161668 File Offset: 0x00160668
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool changeRT4PerfArts
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT4PerfArts"]);
			}
			set
			{
				this["changeRT4PerfArts"] = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00161680 File Offset: 0x00160680
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x001616A4 File Offset: 0x001606A4
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool changeRT4CivicCenter
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT4CivicCenter"]);
			}
			set
			{
				this["changeRT4CivicCenter"] = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x001616BC File Offset: 0x001606BC
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x001616E0 File Offset: 0x001606E0
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool changeRT4MedicServ
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT4MedicServ"]);
			}
			set
			{
				this["changeRT4MedicServ"] = value;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x001616F8 File Offset: 0x001606F8
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x0016171C File Offset: 0x0016071C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool changeRT4Motorb
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT4Motorb"]);
			}
			set
			{
				this["changeRT4Motorb"] = value;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00161734 File Offset: 0x00160734
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00161758 File Offset: 0x00160758
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool ignoreRT4AltName
		{
			get
			{
				return Conversions.ToBoolean(this["ignoreRT4AltName"]);
			}
			set
			{
				this["ignoreRT4AltName"] = value;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00161770 File Offset: 0x00160770
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00161794 File Offset: 0x00160794
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string newChangeImpIgn
		{
			get
			{
				return Conversions.ToString(this["newChangeImpIgn"]);
			}
			set
			{
				this["newChangeImpIgn"] = value;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x001617A8 File Offset: 0x001607A8
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x001617CC File Offset: 0x001607CC
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool changeRT3Embassy
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT3Embassy"]);
			}
			set
			{
				this["changeRT3Embassy"] = value;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x001617E4 File Offset: 0x001607E4
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00161808 File Offset: 0x00160808
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool changeRT3IndustArea
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT3IndustArea"]);
			}
			set
			{
				this["changeRT3IndustArea"] = value;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00161820 File Offset: 0x00160820
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x00161844 File Offset: 0x00160844
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool changeRT3BorderCrossing
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT3BorderCrossing"]);
			}
			set
			{
				this["changeRT3BorderCrossing"] = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0016185C File Offset: 0x0016085C
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x00161880 File Offset: 0x00160880
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool changeRT3PerfArts
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT3PerfArts"]);
			}
			set
			{
				this["changeRT3PerfArts"] = value;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00161898 File Offset: 0x00160898
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x001618BC File Offset: 0x001608BC
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool changeRT3CivicCenter
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT3CivicCenter"]);
			}
			set
			{
				this["changeRT3CivicCenter"] = value;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x001618D4 File Offset: 0x001608D4
		// (set) Token: 0x06000B90 RID: 2960 RVA: 0x001618F8 File Offset: 0x001608F8
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool changeRT3MedicServ
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT3MedicServ"]);
			}
			set
			{
				this["changeRT3MedicServ"] = value;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00161910 File Offset: 0x00160910
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x00161934 File Offset: 0x00160934
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool changeRT3Motorb
		{
			get
			{
				return Conversions.ToBoolean(this["changeRT3Motorb"]);
			}
			set
			{
				this["changeRT3Motorb"] = value;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0016194C File Offset: 0x0016094C
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x00161970 File Offset: 0x00160970
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool ignoreRTxBorgate
		{
			get
			{
				return Conversions.ToBoolean(this["ignoreRTxBorgate"]);
			}
			set
			{
				this["ignoreRTxBorgate"] = value;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x00161988 File Offset: 0x00160988
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x001619AC File Offset: 0x001609AC
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool ignoreRTxAltName
		{
			get
			{
				return Conversions.ToBoolean(this["ignoreRTxAltName"]);
			}
			set
			{
				this["ignoreRTxAltName"] = value;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x001619C4 File Offset: 0x001609C4
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x001619E8 File Offset: 0x001609E8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool changeRTxEmbassy
		{
			get
			{
				return Conversions.ToBoolean(this["changeRTxEmbassy"]);
			}
			set
			{
				this["changeRTxEmbassy"] = value;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00161A00 File Offset: 0x00160A00
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x00161A24 File Offset: 0x00160A24
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool changeRTxIndustArea
		{
			get
			{
				return Conversions.ToBoolean(this["changeRTxIndustArea"]);
			}
			set
			{
				this["changeRTxIndustArea"] = value;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00161A3C File Offset: 0x00160A3C
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x00161A60 File Offset: 0x00160A60
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool changeRTxBorderCrossing
		{
			get
			{
				return Conversions.ToBoolean(this["changeRTxBorderCrossing"]);
			}
			set
			{
				this["changeRTxBorderCrossing"] = value;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x00161A78 File Offset: 0x00160A78
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x00161A9C File Offset: 0x00160A9C
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool changeRTxPerfArts
		{
			get
			{
				return Conversions.ToBoolean(this["changeRTxPerfArts"]);
			}
			set
			{
				this["changeRTxPerfArts"] = value;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00161AB4 File Offset: 0x00160AB4
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x00161AD8 File Offset: 0x00160AD8
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool changeRTxCivicCenter
		{
			get
			{
				return Conversions.ToBoolean(this["changeRTxCivicCenter"]);
			}
			set
			{
				this["changeRTxCivicCenter"] = value;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x00161AF0 File Offset: 0x00160AF0
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x00161B14 File Offset: 0x00160B14
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool changeRTxMedicServ
		{
			get
			{
				return Conversions.ToBoolean(this["changeRTxMedicServ"]);
			}
			set
			{
				this["changeRTxMedicServ"] = value;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00161B2C File Offset: 0x00160B2C
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x00161B50 File Offset: 0x00160B50
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool changeRTxMotorb
		{
			get
			{
				return Conversions.ToBoolean(this["changeRTxMotorb"]);
			}
			set
			{
				this["changeRTxMotorb"] = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00161B68 File Offset: 0x00160B68
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x00161B8C File Offset: 0x00160B8C
		[DefaultSettingValue("255")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte importDefaultMagRT3
		{
			get
			{
				return Conversions.ToByte(this["importDefaultMagRT3"]);
			}
			set
			{
				this["importDefaultMagRT3"] = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00161BA4 File Offset: 0x00160BA4
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x00161BC8 File Offset: 0x00160BC8
		[DebuggerNonUserCode]
		[DefaultSettingValue("3")]
		[UserScopedSetting]
		public byte importDefaultMagRT4
		{
			get
			{
				return Conversions.ToByte(this["importDefaultMagRT4"]);
			}
			set
			{
				this["importDefaultMagRT4"] = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00161BE0 File Offset: 0x00160BE0
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00161C04 File Offset: 0x00160C04
		[DefaultSettingValue("255")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte STimportAllMagRT3
		{
			get
			{
				return Conversions.ToByte(this["STimportAllMagRT3"]);
			}
			set
			{
				this["STimportAllMagRT3"] = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00161C1C File Offset: 0x00160C1C
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00161C40 File Offset: 0x00160C40
		[UserScopedSetting]
		[DefaultSettingValue("3")]
		[DebuggerNonUserCode]
		public byte STimportAllMagRT4
		{
			get
			{
				return Conversions.ToByte(this["STimportAllMagRT4"]);
			}
			set
			{
				this["STimportAllMagRT4"] = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00161C58 File Offset: 0x00160C58
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00161C7C File Offset: 0x00160C7C
		[DefaultSettingValue("255")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public byte STImportF0_59MagRT3
		{
			get
			{
				return Conversions.ToByte(this["STImportF0_59MagRT3"]);
			}
			set
			{
				this["STImportF0_59MagRT3"] = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00161C94 File Offset: 0x00160C94
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x00161CB8 File Offset: 0x00160CB8
		[DefaultSettingValue("3")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte STImportF0_59MagRT4
		{
			get
			{
				return Conversions.ToByte(this["STImportF0_59MagRT4"]);
			}
			set
			{
				this["STImportF0_59MagRT4"] = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00161CD0 File Offset: 0x00160CD0
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x00161CF4 File Offset: 0x00160CF4
		[UserScopedSetting]
		[DefaultSettingValue("255")]
		[DebuggerNonUserCode]
		public byte STImportF100_119MagRT3
		{
			get
			{
				return Conversions.ToByte(this["STImportF100_119MagRT3"]);
			}
			set
			{
				this["STImportF100_119MagRT3"] = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00161D0C File Offset: 0x00160D0C
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x00161D30 File Offset: 0x00160D30
		[DefaultSettingValue("3")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte STImportF100_119MagRT4
		{
			get
			{
				return Conversions.ToByte(this["STImportF100_119MagRT4"]);
			}
			set
			{
				this["STImportF100_119MagRT4"] = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00161D48 File Offset: 0x00160D48
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x00161D6C File Offset: 0x00160D6C
		[UserScopedSetting]
		[DefaultSettingValue("255")]
		[DebuggerNonUserCode]
		public byte STImportF120_130GMagRT3
		{
			get
			{
				return Conversions.ToByte(this["STImportF120_130GMagRT3"]);
			}
			set
			{
				this["STImportF120_130GMagRT3"] = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00161D84 File Offset: 0x00160D84
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x00161DA8 File Offset: 0x00160DA8
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("3")]
		public byte STImportF120_130GMagRT4
		{
			get
			{
				return Conversions.ToByte(this["STImportF120_130GMagRT4"]);
			}
			set
			{
				this["STImportF120_130GMagRT4"] = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00161DC0 File Offset: 0x00160DC0
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x00161DE4 File Offset: 0x00160DE4
		[DefaultSettingValue("255")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte STImportF60_79MagRT3
		{
			get
			{
				return Conversions.ToByte(this["STImportF60_79MagRT3"]);
			}
			set
			{
				this["STImportF60_79MagRT3"] = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00161DFC File Offset: 0x00160DFC
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x00161E20 File Offset: 0x00160E20
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("3")]
		public byte STImportF60_79MagRT4
		{
			get
			{
				return Conversions.ToByte(this["STImportF60_79MagRT4"]);
			}
			set
			{
				this["STImportF60_79MagRT4"] = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00161E38 File Offset: 0x00160E38
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x00161E5C File Offset: 0x00160E5C
		[DebuggerNonUserCode]
		[DefaultSettingValue("255")]
		[UserScopedSetting]
		public byte STImportF80_99MagRT3
		{
			get
			{
				return Conversions.ToByte(this["STImportF80_99MagRT3"]);
			}
			set
			{
				this["STImportF80_99MagRT3"] = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00161E74 File Offset: 0x00160E74
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00161E98 File Offset: 0x00160E98
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("3")]
		public byte STImportF80_99MagRT4
		{
			get
			{
				return Conversions.ToByte(this["STImportF80_99MagRT4"]);
			}
			set
			{
				this["STImportF80_99MagRT4"] = value;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00161EB0 File Offset: 0x00160EB0
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x00161ED4 File Offset: 0x00160ED4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("255")]
		public byte STImportFixedMagRT3
		{
			get
			{
				return Conversions.ToByte(this["STImportFixedMagRT3"]);
			}
			set
			{
				this["STImportFixedMagRT3"] = value;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00161EEC File Offset: 0x00160EEC
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00161F10 File Offset: 0x00160F10
		[UserScopedSetting]
		[DefaultSettingValue("3")]
		[DebuggerNonUserCode]
		public byte STImportFixedMagRT4
		{
			get
			{
				return Conversions.ToByte(this["STImportFixedMagRT4"]);
			}
			set
			{
				this["STImportFixedMagRT4"] = value;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00161F28 File Offset: 0x00160F28
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x00161F4C File Offset: 0x00160F4C
		[UserScopedSetting]
		[DefaultSettingValue("255")]
		[DebuggerNonUserCode]
		public byte STImportM0_59MagRT3
		{
			get
			{
				return Conversions.ToByte(this["STImportM0_59MagRT3"]);
			}
			set
			{
				this["STImportM0_59MagRT3"] = value;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00161F64 File Offset: 0x00160F64
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00161F88 File Offset: 0x00160F88
		[UserScopedSetting]
		[DefaultSettingValue("3")]
		[DebuggerNonUserCode]
		public byte STImportM0_59MagRT4
		{
			get
			{
				return Conversions.ToByte(this["STImportM0_59MagRT4"]);
			}
			set
			{
				this["STImportM0_59MagRT4"] = value;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00161FA0 File Offset: 0x00160FA0
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00161FC4 File Offset: 0x00160FC4
		[DefaultSettingValue("255")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte STImportM100_119MagRT3
		{
			get
			{
				return Conversions.ToByte(this["STImportM100_119MagRT3"]);
			}
			set
			{
				this["STImportM100_119MagRT3"] = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00161FDC File Offset: 0x00160FDC
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00162000 File Offset: 0x00161000
		[DefaultSettingValue("3")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte STImportM100_119MagRT4
		{
			get
			{
				return Conversions.ToByte(this["STImportM100_119MagRT4"]);
			}
			set
			{
				this["STImportM100_119MagRT4"] = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00162018 File Offset: 0x00161018
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x0016203C File Offset: 0x0016103C
		[UserScopedSetting]
		[DefaultSettingValue("255")]
		[DebuggerNonUserCode]
		public byte STImportM120_130MagRT3
		{
			get
			{
				return Conversions.ToByte(this["STImportM120_130MagRT3"]);
			}
			set
			{
				this["STImportM120_130MagRT3"] = value;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x00162054 File Offset: 0x00161054
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x00162078 File Offset: 0x00161078
		[DefaultSettingValue("3")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte STImportM120_130MagRT4
		{
			get
			{
				return Conversions.ToByte(this["STImportM120_130MagRT4"]);
			}
			set
			{
				this["STImportM120_130MagRT4"] = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00162090 File Offset: 0x00161090
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x001620B4 File Offset: 0x001610B4
		[UserScopedSetting]
		[DefaultSettingValue("255")]
		[DebuggerNonUserCode]
		public byte STImportM60_79MagRT3
		{
			get
			{
				return Conversions.ToByte(this["STImportM60_79MagRT3"]);
			}
			set
			{
				this["STImportM60_79MagRT3"] = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x001620CC File Offset: 0x001610CC
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x001620F0 File Offset: 0x001610F0
		[DefaultSettingValue("3")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte STImportM60_79MagRT4
		{
			get
			{
				return Conversions.ToByte(this["STImportM60_79MagRT4"]);
			}
			set
			{
				this["STImportM60_79MagRT4"] = value;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x00162108 File Offset: 0x00161108
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x0016212C File Offset: 0x0016112C
		[DefaultSettingValue("255")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public byte STImportM80_99MagRT3
		{
			get
			{
				return Conversions.ToByte(this["STImportM80_99MagRT3"]);
			}
			set
			{
				this["STImportM80_99MagRT3"] = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x00162144 File Offset: 0x00161144
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x00162168 File Offset: 0x00161168
		[DefaultSettingValue("3")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public byte STImportM80_99MagRT4
		{
			get
			{
				return Conversions.ToByte(this["STImportM80_99MagRT4"]);
			}
			set
			{
				this["STImportM80_99MagRT4"] = value;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x00162180 File Offset: 0x00161180
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x001621A4 File Offset: 0x001611A4
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("255")]
		public byte STimportMobileMagRT3
		{
			get
			{
				return Conversions.ToByte(this["STimportMobileMagRT3"]);
			}
			set
			{
				this["STimportMobileMagRT3"] = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x001621BC File Offset: 0x001611BC
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x001621E0 File Offset: 0x001611E0
		[DefaultSettingValue("3")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public byte STimportMobileMagRT4
		{
			get
			{
				return Conversions.ToByte(this["STimportMobileMagRT4"]);
			}
			set
			{
				this["STimportMobileMagRT4"] = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x001621F8 File Offset: 0x001611F8
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x0016221C File Offset: 0x0016121C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("255")]
		public byte STImportRFRMagRT3
		{
			get
			{
				return Conversions.ToByte(this["STImportRFRMagRT3"]);
			}
			set
			{
				this["STImportRFRMagRT3"] = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00162234 File Offset: 0x00161234
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00162258 File Offset: 0x00161258
		[DefaultSettingValue("3")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public byte STImportRFRMagRT4
		{
			get
			{
				return Conversions.ToByte(this["STImportRFRMagRT4"]);
			}
			set
			{
				this["STImportRFRMagRT4"] = value;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00162270 File Offset: 0x00161270
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00162294 File Offset: 0x00161294
		[UserScopedSetting]
		[DefaultSettingValue("map")]
		[DebuggerNonUserCode]
		public string RTxModeMap
		{
			get
			{
				return Conversions.ToString(this["RTxModeMap"]);
			}
			set
			{
				this["RTxModeMap"] = value;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x001622A8 File Offset: 0x001612A8
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x001622CC File Offset: 0x001612CC
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string WorkingDirAlert
		{
			get
			{
				return Conversions.ToString(this["WorkingDirAlert"]);
			}
			set
			{
				this["WorkingDirAlert"] = value;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x001622E0 File Offset: 0x001612E0
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x00162304 File Offset: 0x00161304
		[DebuggerNonUserCode]
		[DefaultSettingValue("002")]
		[UserScopedSetting]
		public string alertDIRCID
		{
			get
			{
				return Conversions.ToString(this["alertDIRCID"]);
			}
			set
			{
				this["alertDIRCID"] = value;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00162318 File Offset: 0x00161318
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x0016233C File Offset: 0x0016133C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("ver56x")]
		public string RTxVersion
		{
			get
			{
				return Conversions.ToString(this["RTxVersion"]);
			}
			set
			{
				this["RTxVersion"] = value;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00162350 File Offset: 0x00161350
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x00162374 File Offset: 0x00161374
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string strGpsPasPANMap
		{
			get
			{
				return Conversions.ToString(this["strGpsPasPANMap"]);
			}
			set
			{
				this["strGpsPasPANMap"] = value;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x00162388 File Offset: 0x00161388
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x001623AC File Offset: 0x001613AC
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string strGpsPasPLMap
		{
			get
			{
				return Conversions.ToString(this["strGpsPasPLMap"]);
			}
			set
			{
				this["strGpsPasPLMap"] = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x001623C0 File Offset: 0x001613C0
		// (set) Token: 0x06000BEE RID: 3054 RVA: 0x001623E4 File Offset: 0x001613E4
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string strGpsPasRFMap
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRFMap"]);
			}
			set
			{
				this["strGpsPasRFMap"] = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x001623F8 File Offset: 0x001613F8
		// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x0016241C File Offset: 0x0016141C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string strGpsPasRMMap
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRMMap"]);
			}
			set
			{
				this["strGpsPasRMMap"] = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00162430 File Offset: 0x00161430
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x00162454 File Offset: 0x00161454
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string strGpsPasRFRMap
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRFRMap"]);
			}
			set
			{
				this["strGpsPasRFRMap"] = value;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00162468 File Offset: 0x00161468
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x0016248C File Offset: 0x0016148C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string strGpsPasRMap
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRMap"]);
			}
			set
			{
				this["strGpsPasRMap"] = value;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x001624A0 File Offset: 0x001614A0
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x001624C4 File Offset: 0x001614C4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string strGpsPasFMap
		{
			get
			{
				return Conversions.ToString(this["strGpsPasFMap"]);
			}
			set
			{
				this["strGpsPasFMap"] = value;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x001624D8 File Offset: 0x001614D8
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x001624FC File Offset: 0x001614FC
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string strGpsPasNCMap
		{
			get
			{
				return Conversions.ToString(this["strGpsPasNCMap"]);
			}
			set
			{
				this["strGpsPasNCMap"] = value;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00162510 File Offset: 0x00161510
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00162534 File Offset: 0x00161534
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string strGpsPasRDMap
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRDMap"]);
			}
			set
			{
				this["strGpsPasRDMap"] = value;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00162548 File Offset: 0x00161548
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x0016256C File Offset: 0x0016156C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string strGpsPasKMHMap
		{
			get
			{
				return Conversions.ToString(this["strGpsPasKMHMap"]);
			}
			set
			{
				this["strGpsPasKMHMap"] = value;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00162580 File Offset: 0x00161580
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x001625A4 File Offset: 0x001615A4
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string gpspasUserDefNameMap
		{
			get
			{
				return Conversions.ToString(this["gpspasUserDefNameMap"]);
			}
			set
			{
				this["gpspasUserDefNameMap"] = value;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x001625B8 File Offset: 0x001615B8
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x001625DC File Offset: 0x001615DC
		[UserScopedSetting]
		[DefaultSettingValue("1")]
		[DebuggerNonUserCode]
		public int gpspasDispModeMap
		{
			get
			{
				return Conversions.ToInteger(this["gpspasDispModeMap"]);
			}
			set
			{
				this["gpspasDispModeMap"] = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x001625F4 File Offset: 0x001615F4
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x00162618 File Offset: 0x00161618
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool isGpsPasMiscDisplayedMap
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasMiscDisplayedMap"]);
			}
			set
			{
				this["isGpsPasMiscDisplayedMap"] = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00162630 File Offset: 0x00161630
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x00162654 File Offset: 0x00161654
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool isGpsPasTypeDisplayedMap
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasTypeDisplayedMap"]);
			}
			set
			{
				this["isGpsPasTypeDisplayedMap"] = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0016266C File Offset: 0x0016166C
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00162690 File Offset: 0x00161690
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool isGpsPasNumDisplayedMap
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasNumDisplayedMap"]);
			}
			set
			{
				this["isGpsPasNumDisplayedMap"] = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x001626A8 File Offset: 0x001616A8
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x001626CC File Offset: 0x001616CC
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool isGpsPasRFRPostDisplayedMap
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasRFRPostDisplayedMap"]);
			}
			set
			{
				this["isGpsPasRFRPostDisplayedMap"] = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x001626E4 File Offset: 0x001616E4
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x00162708 File Offset: 0x00161708
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool isGpsPasSep1DisplayedMap
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasSep1DisplayedMap"]);
			}
			set
			{
				this["isGpsPasSep1DisplayedMap"] = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00162720 File Offset: 0x00161720
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x00162744 File Offset: 0x00161744
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool isGpsPasSpeedDisplayedMap
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasSpeedDisplayedMap"]);
			}
			set
			{
				this["isGpsPasSpeedDisplayedMap"] = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x0016275C File Offset: 0x0016175C
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x00162780 File Offset: 0x00161780
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool isGpsPasSpeedUnitDisplayedMap
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasSpeedUnitDisplayedMap"]);
			}
			set
			{
				this["isGpsPasSpeedUnitDisplayedMap"] = value;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00162798 File Offset: 0x00161798
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x001627BC File Offset: 0x001617BC
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool isGpsPasSep2DisplayedMap
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasSep2DisplayedMap"]);
			}
			set
			{
				this["isGpsPasSep2DisplayedMap"] = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x001627D4 File Offset: 0x001617D4
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x001627F8 File Offset: 0x001617F8
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool isGpsPasDirDisplayedMap
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasDirDisplayedMap"]);
			}
			set
			{
				this["isGpsPasDirDisplayedMap"] = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00162810 File Offset: 0x00161810
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00162834 File Offset: 0x00161834
		[DefaultSettingValue("-")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string strGpsPasSep1Map
		{
			get
			{
				return Conversions.ToString(this["strGpsPasSep1Map"]);
			}
			set
			{
				this["strGpsPasSep1Map"] = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00162848 File Offset: 0x00161848
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x0016286C File Offset: 0x0016186C
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool isGpsPasStartDisplayedMap
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasStartDisplayedMap"]);
			}
			set
			{
				this["isGpsPasStartDisplayedMap"] = value;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00162884 File Offset: 0x00161884
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x001628A8 File Offset: 0x001618A8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isGpsPasEndDisplayedMap
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasEndDisplayedMap"]);
			}
			set
			{
				this["isGpsPasEndDisplayedMap"] = value;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x001628C0 File Offset: 0x001618C0
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x001628E4 File Offset: 0x001618E4
		[UserScopedSetting]
		[DefaultSettingValue("<")]
		[DebuggerNonUserCode]
		public string strGpsPasStartMap
		{
			get
			{
				return Conversions.ToString(this["strGpsPasStartMap"]);
			}
			set
			{
				this["strGpsPasStartMap"] = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x001628F8 File Offset: 0x001618F8
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x0016291C File Offset: 0x0016191C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string strGpsPasEndMap
		{
			get
			{
				return Conversions.ToString(this["strGpsPasEndMap"]);
			}
			set
			{
				this["strGpsPasEndMap"] = value;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00162930 File Offset: 0x00161930
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x00162954 File Offset: 0x00161954
		[DefaultSettingValue("-")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string strGpsPasSep2Map
		{
			get
			{
				return Conversions.ToString(this["strGpsPasSep2Map"]);
			}
			set
			{
				this["strGpsPasSep2Map"] = value;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00162968 File Offset: 0x00161968
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x0016298C File Offset: 0x0016198C
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string strGpsPasPANAlert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasPANAlert"]);
			}
			set
			{
				this["strGpsPasPANAlert"] = value;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x001629A0 File Offset: 0x001619A0
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x001629C4 File Offset: 0x001619C4
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string strGpsPasPLAlert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasPLAlert"]);
			}
			set
			{
				this["strGpsPasPLAlert"] = value;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x001629D8 File Offset: 0x001619D8
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x001629FC File Offset: 0x001619FC
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string strGpsPasRFAlert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRFAlert"]);
			}
			set
			{
				this["strGpsPasRFAlert"] = value;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00162A10 File Offset: 0x00161A10
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00162A34 File Offset: 0x00161A34
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string strGpsPasRMAlert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRMAlert"]);
			}
			set
			{
				this["strGpsPasRMAlert"] = value;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00162A48 File Offset: 0x00161A48
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00162A6C File Offset: 0x00161A6C
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string strGpsPasRFRAlert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRFRAlert"]);
			}
			set
			{
				this["strGpsPasRFRAlert"] = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00162A80 File Offset: 0x00161A80
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00162AA4 File Offset: 0x00161AA4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string strGpsPasRAlert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRAlert"]);
			}
			set
			{
				this["strGpsPasRAlert"] = value;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00162AB8 File Offset: 0x00161AB8
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00162ADC File Offset: 0x00161ADC
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string strGpsPasFAlert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasFAlert"]);
			}
			set
			{
				this["strGpsPasFAlert"] = value;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00162AF0 File Offset: 0x00161AF0
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00162B14 File Offset: 0x00161B14
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string strGpsPasNCAlert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasNCAlert"]);
			}
			set
			{
				this["strGpsPasNCAlert"] = value;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00162B28 File Offset: 0x00161B28
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x00162B4C File Offset: 0x00161B4C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string strGpsPasRDAlert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasRDAlert"]);
			}
			set
			{
				this["strGpsPasRDAlert"] = value;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00162B60 File Offset: 0x00161B60
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x00162B84 File Offset: 0x00161B84
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string strGpsPasKMHAlert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasKMHAlert"]);
			}
			set
			{
				this["strGpsPasKMHAlert"] = value;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00162B98 File Offset: 0x00161B98
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x00162BBC File Offset: 0x00161BBC
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string gpspasUserDefNameAlert
		{
			get
			{
				return Conversions.ToString(this["gpspasUserDefNameAlert"]);
			}
			set
			{
				this["gpspasUserDefNameAlert"] = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00162BD0 File Offset: 0x00161BD0
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x00162BF4 File Offset: 0x00161BF4
		[UserScopedSetting]
		[DefaultSettingValue("1")]
		[DebuggerNonUserCode]
		public int gpspasDispModeAlert
		{
			get
			{
				return Conversions.ToInteger(this["gpspasDispModeAlert"]);
			}
			set
			{
				this["gpspasDispModeAlert"] = value;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00162C0C File Offset: 0x00161C0C
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00162C30 File Offset: 0x00161C30
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isGpsPasMiscDisplayedAlert
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasMiscDisplayedAlert"]);
			}
			set
			{
				this["isGpsPasMiscDisplayedAlert"] = value;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00162C48 File Offset: 0x00161C48
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x00162C6C File Offset: 0x00161C6C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool isGpsPasTypeDisplayedAlert
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasTypeDisplayedAlert"]);
			}
			set
			{
				this["isGpsPasTypeDisplayedAlert"] = value;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00162C84 File Offset: 0x00161C84
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x00162CA8 File Offset: 0x00161CA8
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool isGpsPasNumDisplayedAlert
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasNumDisplayedAlert"]);
			}
			set
			{
				this["isGpsPasNumDisplayedAlert"] = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x00162CC0 File Offset: 0x00161CC0
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x00162CE4 File Offset: 0x00161CE4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool isGpsPasRFRPostDisplayedAlert
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasRFRPostDisplayedAlert"]);
			}
			set
			{
				this["isGpsPasRFRPostDisplayedAlert"] = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00162CFC File Offset: 0x00161CFC
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x00162D20 File Offset: 0x00161D20
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool isGpsPasSep1DisplayedAlert
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasSep1DisplayedAlert"]);
			}
			set
			{
				this["isGpsPasSep1DisplayedAlert"] = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00162D38 File Offset: 0x00161D38
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00162D5C File Offset: 0x00161D5C
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool isGpsPasSpeedDisplayedAlert
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasSpeedDisplayedAlert"]);
			}
			set
			{
				this["isGpsPasSpeedDisplayedAlert"] = value;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00162D74 File Offset: 0x00161D74
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x00162D98 File Offset: 0x00161D98
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool isGpsPasSpeedUnitDisplayedAlert
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasSpeedUnitDisplayedAlert"]);
			}
			set
			{
				this["isGpsPasSpeedUnitDisplayedAlert"] = value;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x00162DB0 File Offset: 0x00161DB0
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x00162DD4 File Offset: 0x00161DD4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool isGpsPasSep2DisplayedAlert
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasSep2DisplayedAlert"]);
			}
			set
			{
				this["isGpsPasSep2DisplayedAlert"] = value;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00162DEC File Offset: 0x00161DEC
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x00162E10 File Offset: 0x00161E10
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool isGpsPasDirDisplayedAlert
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasDirDisplayedAlert"]);
			}
			set
			{
				this["isGpsPasDirDisplayedAlert"] = value;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00162E28 File Offset: 0x00161E28
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x00162E4C File Offset: 0x00161E4C
		[DefaultSettingValue("-")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string strGpsPasSep1Alert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasSep1Alert"]);
			}
			set
			{
				this["strGpsPasSep1Alert"] = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00162E60 File Offset: 0x00161E60
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x00162E84 File Offset: 0x00161E84
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool isGpsPasStartDisplayedAlert
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasStartDisplayedAlert"]);
			}
			set
			{
				this["isGpsPasStartDisplayedAlert"] = value;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00162E9C File Offset: 0x00161E9C
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x00162EC0 File Offset: 0x00161EC0
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool isGpsPasEndDisplayedAlert
		{
			get
			{
				return Conversions.ToBoolean(this["isGpsPasEndDisplayedAlert"]);
			}
			set
			{
				this["isGpsPasEndDisplayedAlert"] = value;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00162ED8 File Offset: 0x00161ED8
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00162EFC File Offset: 0x00161EFC
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string strGpsPasStartAlert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasStartAlert"]);
			}
			set
			{
				this["strGpsPasStartAlert"] = value;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00162F10 File Offset: 0x00161F10
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x00162F34 File Offset: 0x00161F34
		[DebuggerNonUserCode]
		[DefaultSettingValue(">")]
		[UserScopedSetting]
		public string strGpsPasEndAlert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasEndAlert"]);
			}
			set
			{
				this["strGpsPasEndAlert"] = value;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00162F48 File Offset: 0x00161F48
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x00162F6C File Offset: 0x00161F6C
		[DebuggerNonUserCode]
		[DefaultSettingValue("-")]
		[UserScopedSetting]
		public string strGpsPasSep2Alert
		{
			get
			{
				return Conversions.ToString(this["strGpsPasSep2Alert"]);
			}
			set
			{
				this["strGpsPasSep2Alert"] = value;
			}
		}

		// Token: 0x04000484 RID: 1156
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000485 RID: 1157
		private static bool addedHandler;

		// Token: 0x04000486 RID: 1158
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
