using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace RT3MapEditor.My
{
	// Token: 0x02000002 RID: 2
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00135A0C File Offset: 0x00134A0C
		[STAThread]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerHidden]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			MyProject.Application.Run(Args);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00135A48 File Offset: 0x00134A48
		[DebuggerStepThrough]
		public MyApplication() : base(AuthenticationMode.Windows)
		{
			ArrayList _ENCList = MyApplication.__ENCList;
			lock (_ENCList)
			{
				MyApplication.__ENCList.Add(new WeakReference(this));
			}
			this.IsSingleInstance = true;
			this.EnableVisualStyles = true;
			this.SaveMySettingsOnExit = false;
			this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00135ABC File Offset: 0x00134ABC
		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			this.MainForm = MyProject.Forms.FormMain;
		}

		// Token: 0x04000001 RID: 1
		private static ArrayList __ENCList = new ArrayList();
	}
}
