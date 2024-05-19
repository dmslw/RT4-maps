using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor.My
{
	// Token: 0x02000056 RID: 86
	[CompilerGenerated]
	[HideModuleName]
	[DebuggerNonUserCode]
	[StandardModule]
	internal sealed class MySettingsProperty
	{
		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00162F80 File Offset: 0x00161F80
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
