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
		// Token: 0x060009FC RID: 2556 RVA: 0x0015EA08 File Offset: 0x0015DA08
		[DebuggerNonUserCode]
		public MySettings()
		{
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00160CEC File Offset: 0x0015FCEC
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00160D10 File Offset: 0x0015FD10
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public NVPairList lastLoadedMaps
		{
			get
			{
				return (NVPairList)this["lastLoadedMaps"];
			}
			set
			{
				this["lastLoadedMaps"] = value;
			}
		}
	}
}
