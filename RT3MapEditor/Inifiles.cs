using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x02000044 RID: 68
	public class Inifiles
	{
		// Token: 0x06000771 RID: 1905 RVA: 0x001090BC File Offset: 0x001080BC
		[DebuggerNonUserCode]
		public Inifiles()
		{
		}

		// Token: 0x06000772 RID: 1906
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetPrivateProfileSectionA", ExactSpelling = true, SetLastError = true)]
		private static extern int GetPrivateProfileSection([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpAppName, IntPtr lpReturnedBuffer, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

		// Token: 0x06000773 RID: 1907
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetPrivateProfileSectionNamesA", ExactSpelling = true, SetLastError = true)]
		private static extern int GetPrivateProfileSectionNames(IntPtr lpszReturnBuffer, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

		// Token: 0x06000774 RID: 1908
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetPrivateProfileStringA", ExactSpelling = true, SetLastError = true)]
		private static extern int GetPrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault, IntPtr lpReturnedBuffer, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

		// Token: 0x06000775 RID: 1909
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "WritePrivateProfileSectionA", ExactSpelling = true, SetLastError = true)]
		private static extern bool WritePrivateProfileSection([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpAppName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

		// Token: 0x06000776 RID: 1910
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "WritePrivateProfileStringA", ExactSpelling = true, SetLastError = true)]
		private static extern bool WritePrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

		// Token: 0x06000777 RID: 1911 RVA: 0x001090C8 File Offset: 0x001080C8
		public static bool ExistsSection(string File, string Section)
		{
			IntPtr lpReturnedBuffer = Marshal.StringToHGlobalAnsi(new string('\0', 1024));
			int privateProfileSection = Inifiles.GetPrivateProfileSection(ref Section, lpReturnedBuffer, 1024, ref File);
			return privateProfileSection != 0;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00109104 File Offset: 0x00108104
		public static Collection GetAllSections(string File)
		{
			IntPtr intPtr = Marshal.StringToHGlobalAnsi(new string('\0', 1024));
			int privateProfileSectionNames = Inifiles.GetPrivateProfileSectionNames(intPtr, 1024, ref File);
			string text = Marshal.PtrToStringAnsi(intPtr, privateProfileSectionNames);
			Marshal.FreeHGlobal(intPtr);
			Collection collection = new Collection();
			string text2 = "";
			int num = 0;
			checked
			{
				int num2 = privateProfileSectionNames - 1;
				int num3 = num;
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					bool flag = Operators.CompareString(Conversions.ToString(text[num3]), "\0", false) == 0;
					if (flag)
					{
						collection.Add(text2, null, null, null);
						text2 = "";
					}
					else
					{
						text2 += Conversions.ToString(text[num3]);
					}
					num3++;
				}
				return collection;
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x001091C0 File Offset: 0x001081C0
		public static Collection GetSectionKeys(string File, string Section)
		{
			Collection collection = new Collection();
			IntPtr intPtr = Marshal.StringToHGlobalAnsi(new string('\0', 4096));
			int privateProfileSection = Inifiles.GetPrivateProfileSection(ref Section, intPtr, 4096, ref File);
			string text = Marshal.PtrToStringAnsi(intPtr, privateProfileSection);
			Marshal.FreeHGlobal(intPtr);
			string[] array = text.Split(new char[]
			{
				'\0'
			});
			foreach (string text2 in array)
			{
				bool flag = Operators.CompareString(text2, "", false) != 0;
				if (flag)
				{
					string key = text2.Substring(0, text2.IndexOf('='));
					KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>(key, text2.Substring(checked(text2.IndexOf('=') + 1)));
					collection.Add(keyValuePair, key, null, null);
				}
			}
			return collection;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x001092A0 File Offset: 0x001082A0
		public static string GetKey(string File, string Section, string Cle)
		{
			IntPtr intPtr = Marshal.StringToHGlobalAnsi(new string('\0', 1024));
			string text = "";
			int privateProfileString = Inifiles.GetPrivateProfileString(ref Section, ref Cle, ref text, intPtr, 1024, ref File);
			string result = Marshal.PtrToStringAnsi(intPtr, privateProfileString);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x001092EC File Offset: 0x001082EC
		public static bool SetSection(string File, string Section, string Valeur)
		{
			return Inifiles.WritePrivateProfileSection(ref Section, ref Valeur, ref File);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00109308 File Offset: 0x00108308
		public static bool SetKey(string File, string Section, string Cle, string Valeur)
		{
			return Inifiles.WritePrivateProfileString(ref Section, ref Cle, ref Valeur, ref File);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00109328 File Offset: 0x00108328
		public static bool DeleteSection(string File, string Section)
		{
			string text = "";
			return Inifiles.WritePrivateProfileSection(ref Section, ref text, ref File);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0010934C File Offset: 0x0010834C
		public static bool DeleteKey(string File, string Section, string Cle)
		{
			StringBuilder stringBuilder = new StringBuilder(4096);
			Collection sectionKeys = Inifiles.GetSectionKeys(File, Section);
			try
			{
				foreach (object obj in sectionKeys)
				{
					KeyValuePair<string, string> keyValuePair2;
					KeyValuePair<string, string> keyValuePair = (obj != null) ? ((KeyValuePair<string, string>)obj) : keyValuePair2;
					bool flag = Operators.CompareString(keyValuePair.Key, Cle, false) != 0;
					if (flag)
					{
						stringBuilder.Append(keyValuePair.Key);
						stringBuilder.Append('=');
						stringBuilder.Append(keyValuePair.Value);
						stringBuilder.Append('\0');
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			stringBuilder.Append('\0');
			string text = stringBuilder.ToString();
			return Inifiles.WritePrivateProfileSection(ref Section, ref text, ref File);
		}

		// Token: 0x04000423 RID: 1059
		private const int SECTION_SIZE = 4096;

		// Token: 0x04000424 RID: 1060
		private const int KEY_SIZE = 1024;
	}
}
