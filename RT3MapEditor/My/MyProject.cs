using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor.My
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[HideModuleName]
	[StandardModule]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00135B18 File Offset: 0x00134B18
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00135B34 File Offset: 0x00134B34
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00135B50 File Offset: 0x00134B50
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00135B6C File Offset: 0x00134B6C
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00135B88 File Offset: 0x00134B88
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000004 RID: 4
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000005 RID: 5
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000006 RID: 6
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000005 RID: 5
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyForms
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600000C RID: 12 RVA: 0x00135BA4 File Offset: 0x00134BA4
			// (set) Token: 0x0600001E RID: 30 RVA: 0x00135E74 File Offset: 0x00134E74
			public About About
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_About = MyProject.MyForms.Create__Instance__<About>(this.m_About);
					return this.m_About;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_About;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<About>(ref this.m_About);
					}
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600000D RID: 13 RVA: 0x00135BCC File Offset: 0x00134BCC
			// (set) Token: 0x0600001F RID: 31 RVA: 0x00135EB8 File Offset: 0x00134EB8
			public AllPOIParamDialog AllPOIParamDialog
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_AllPOIParamDialog = MyProject.MyForms.Create__Instance__<AllPOIParamDialog>(this.m_AllPOIParamDialog);
					return this.m_AllPOIParamDialog;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_AllPOIParamDialog;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AllPOIParamDialog>(ref this.m_AllPOIParamDialog);
					}
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600000E RID: 14 RVA: 0x00135BF4 File Offset: 0x00134BF4
			// (set) Token: 0x06000020 RID: 32 RVA: 0x00135EFC File Offset: 0x00134EFC
			public BootScreenFramingDialog BootScreenFramingDialog
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_BootScreenFramingDialog = MyProject.MyForms.Create__Instance__<BootScreenFramingDialog>(this.m_BootScreenFramingDialog);
					return this.m_BootScreenFramingDialog;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_BootScreenFramingDialog;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<BootScreenFramingDialog>(ref this.m_BootScreenFramingDialog);
					}
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600000F RID: 15 RVA: 0x00135C1C File Offset: 0x00134C1C
			// (set) Token: 0x06000021 RID: 33 RVA: 0x00135F40 File Offset: 0x00134F40
			public CameraList CameraList
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_CameraList = MyProject.MyForms.Create__Instance__<CameraList>(this.m_CameraList);
					return this.m_CameraList;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_CameraList;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CameraList>(ref this.m_CameraList);
					}
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000010 RID: 16 RVA: 0x00135C44 File Offset: 0x00134C44
			// (set) Token: 0x06000022 RID: 34 RVA: 0x00135F84 File Offset: 0x00134F84
			public ConfigDialog ConfigDialog
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_ConfigDialog = MyProject.MyForms.Create__Instance__<ConfigDialog>(this.m_ConfigDialog);
					return this.m_ConfigDialog;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_ConfigDialog;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ConfigDialog>(ref this.m_ConfigDialog);
					}
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000011 RID: 17 RVA: 0x00135C6C File Offset: 0x00134C6C
			// (set) Token: 0x06000023 RID: 35 RVA: 0x00135FC8 File Offset: 0x00134FC8
			public ContAbortErrBox ContAbortErrBox
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_ContAbortErrBox = MyProject.MyForms.Create__Instance__<ContAbortErrBox>(this.m_ContAbortErrBox);
					return this.m_ContAbortErrBox;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_ContAbortErrBox;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ContAbortErrBox>(ref this.m_ContAbortErrBox);
					}
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000012 RID: 18 RVA: 0x00135C94 File Offset: 0x00134C94
			// (set) Token: 0x06000024 RID: 36 RVA: 0x0013600C File Offset: 0x0013500C
			public CoordConvDialog CoordConvDialog
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_CoordConvDialog = MyProject.MyForms.Create__Instance__<CoordConvDialog>(this.m_CoordConvDialog);
					return this.m_CoordConvDialog;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_CoordConvDialog;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CoordConvDialog>(ref this.m_CoordConvDialog);
					}
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000013 RID: 19 RVA: 0x00135CBC File Offset: 0x00134CBC
			// (set) Token: 0x06000025 RID: 37 RVA: 0x00136050 File Offset: 0x00135050
			public CountryUserPOIDialog CountryUserPOIDialog
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_CountryUserPOIDialog = MyProject.MyForms.Create__Instance__<CountryUserPOIDialog>(this.m_CountryUserPOIDialog);
					return this.m_CountryUserPOIDialog;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_CountryUserPOIDialog;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CountryUserPOIDialog>(ref this.m_CountryUserPOIDialog);
					}
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000014 RID: 20 RVA: 0x00135CE4 File Offset: 0x00134CE4
			// (set) Token: 0x06000026 RID: 38 RVA: 0x00136094 File Offset: 0x00135094
			public DupDialog DupDialog
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_DupDialog = MyProject.MyForms.Create__Instance__<DupDialog>(this.m_DupDialog);
					return this.m_DupDialog;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_DupDialog;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<DupDialog>(ref this.m_DupDialog);
					}
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000015 RID: 21 RVA: 0x00135D0C File Offset: 0x00134D0C
			// (set) Token: 0x06000027 RID: 39 RVA: 0x001360D8 File Offset: 0x001350D8
			public dupListDialog dupListDialog
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_dupListDialog = MyProject.MyForms.Create__Instance__<dupListDialog>(this.m_dupListDialog);
					return this.m_dupListDialog;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_dupListDialog;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<dupListDialog>(ref this.m_dupListDialog);
					}
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000016 RID: 22 RVA: 0x00135D34 File Offset: 0x00134D34
			// (set) Token: 0x06000028 RID: 40 RVA: 0x0013611C File Offset: 0x0013511C
			public FatalErrorBox FatalErrorBox
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_FatalErrorBox = MyProject.MyForms.Create__Instance__<FatalErrorBox>(this.m_FatalErrorBox);
					return this.m_FatalErrorBox;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_FatalErrorBox;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FatalErrorBox>(ref this.m_FatalErrorBox);
					}
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000017 RID: 23 RVA: 0x00135D5C File Offset: 0x00134D5C
			// (set) Token: 0x06000029 RID: 41 RVA: 0x00136160 File Offset: 0x00135160
			public FormMain FormMain
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_FormMain = MyProject.MyForms.Create__Instance__<FormMain>(this.m_FormMain);
					return this.m_FormMain;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_FormMain;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FormMain>(ref this.m_FormMain);
					}
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000018 RID: 24 RVA: 0x00135D84 File Offset: 0x00134D84
			// (set) Token: 0x0600002A RID: 42 RVA: 0x001361A4 File Offset: 0x001351A4
			public InputDialog InputDialog
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_InputDialog = MyProject.MyForms.Create__Instance__<InputDialog>(this.m_InputDialog);
					return this.m_InputDialog;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_InputDialog;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<InputDialog>(ref this.m_InputDialog);
					}
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000019 RID: 25 RVA: 0x00135DAC File Offset: 0x00134DAC
			// (set) Token: 0x0600002B RID: 43 RVA: 0x001361E8 File Offset: 0x001351E8
			public NonFatalErrorBox NonFatalErrorBox
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_NonFatalErrorBox = MyProject.MyForms.Create__Instance__<NonFatalErrorBox>(this.m_NonFatalErrorBox);
					return this.m_NonFatalErrorBox;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_NonFatalErrorBox;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<NonFatalErrorBox>(ref this.m_NonFatalErrorBox);
					}
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600001A RID: 26 RVA: 0x00135DD4 File Offset: 0x00134DD4
			// (set) Token: 0x0600002C RID: 44 RVA: 0x0013622C File Offset: 0x0013522C
			public progressBox progressBox
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_progressBox = MyProject.MyForms.Create__Instance__<progressBox>(this.m_progressBox);
					return this.m_progressBox;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_progressBox;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<progressBox>(ref this.m_progressBox);
					}
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600001B RID: 27 RVA: 0x00135DFC File Offset: 0x00134DFC
			// (set) Token: 0x0600002D RID: 45 RVA: 0x00136270 File Offset: 0x00135270
			public ScreenPreview ScreenPreview
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_ScreenPreview = MyProject.MyForms.Create__Instance__<ScreenPreview>(this.m_ScreenPreview);
					return this.m_ScreenPreview;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_ScreenPreview;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ScreenPreview>(ref this.m_ScreenPreview);
					}
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600001C RID: 28 RVA: 0x00135E24 File Offset: 0x00134E24
			// (set) Token: 0x0600002E RID: 46 RVA: 0x001362B4 File Offset: 0x001352B4
			public SWVersDialog SWVersDialog
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_SWVersDialog = MyProject.MyForms.Create__Instance__<SWVersDialog>(this.m_SWVersDialog);
					return this.m_SWVersDialog;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_SWVersDialog;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SWVersDialog>(ref this.m_SWVersDialog);
					}
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600001D RID: 29 RVA: 0x00135E4C File Offset: 0x00134E4C
			// (set) Token: 0x0600002F RID: 47 RVA: 0x001362F8 File Offset: 0x001352F8
			public USBMapDialog USBMapDialog
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_USBMapDialog = MyProject.MyForms.Create__Instance__<USBMapDialog>(this.m_USBMapDialog);
					return this.m_USBMapDialog;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_USBMapDialog;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<USBMapDialog>(ref this.m_USBMapDialog);
					}
				}
			}

			// Token: 0x06000030 RID: 48 RVA: 0x0013633C File Offset: 0x0013533C
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				bool flag = Instance == null || Instance.IsDisposed;
				if (flag)
				{
					bool flag2 = MyProject.MyForms.m_FormBeingCreated != null;
					if (flag2)
					{
						bool flag3 = MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x06000031 RID: 49 RVA: 0x00136478 File Offset: 0x00135478
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000032 RID: 50 RVA: 0x001364A4 File Offset: 0x001354A4
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public MyForms()
			{
			}

			// Token: 0x06000033 RID: 51 RVA: 0x001364B0 File Offset: 0x001354B0
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000034 RID: 52 RVA: 0x001364D0 File Offset: 0x001354D0
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000035 RID: 53 RVA: 0x001364E8 File Offset: 0x001354E8
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000036 RID: 54 RVA: 0x00136504 File Offset: 0x00135504
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000007 RID: 7
			public About m_About;

			// Token: 0x04000008 RID: 8
			public AllPOIParamDialog m_AllPOIParamDialog;

			// Token: 0x04000009 RID: 9
			public BootScreenFramingDialog m_BootScreenFramingDialog;

			// Token: 0x0400000A RID: 10
			public CameraList m_CameraList;

			// Token: 0x0400000B RID: 11
			public ConfigDialog m_ConfigDialog;

			// Token: 0x0400000C RID: 12
			public ContAbortErrBox m_ContAbortErrBox;

			// Token: 0x0400000D RID: 13
			public CoordConvDialog m_CoordConvDialog;

			// Token: 0x0400000E RID: 14
			public CountryUserPOIDialog m_CountryUserPOIDialog;

			// Token: 0x0400000F RID: 15
			public DupDialog m_DupDialog;

			// Token: 0x04000010 RID: 16
			public dupListDialog m_dupListDialog;

			// Token: 0x04000011 RID: 17
			public FatalErrorBox m_FatalErrorBox;

			// Token: 0x04000012 RID: 18
			public FormMain m_FormMain;

			// Token: 0x04000013 RID: 19
			public InputDialog m_InputDialog;

			// Token: 0x04000014 RID: 20
			public NonFatalErrorBox m_NonFatalErrorBox;

			// Token: 0x04000015 RID: 21
			public progressBox m_progressBox;

			// Token: 0x04000016 RID: 22
			public ScreenPreview m_ScreenPreview;

			// Token: 0x04000017 RID: 23
			public SWVersDialog m_SWVersDialog;

			// Token: 0x04000018 RID: 24
			public USBMapDialog m_USBMapDialog;

			// Token: 0x04000019 RID: 25
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;
		}

		// Token: 0x02000006 RID: 6
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyWebServices
		{
			// Token: 0x06000037 RID: 55 RVA: 0x0013651C File Offset: 0x0013551C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000038 RID: 56 RVA: 0x0013653C File Offset: 0x0013553C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000039 RID: 57 RVA: 0x00136554 File Offset: 0x00135554
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x0600003A RID: 58 RVA: 0x00136570 File Offset: 0x00135570
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600003B RID: 59 RVA: 0x00136588 File Offset: 0x00135588
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				bool flag = instance == null;
				T result;
				if (flag)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x0600003C RID: 60 RVA: 0x001365B4 File Offset: 0x001355B4
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x0600003D RID: 61 RVA: 0x001365D4 File Offset: 0x001355D4
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600003E RID: 62 RVA: 0x001365E0 File Offset: 0x001355E0
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					bool flag = MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null;
					if (flag)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x0600003F RID: 63 RVA: 0x00136614 File Offset: 0x00135614
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x0400001A RID: 26
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}
