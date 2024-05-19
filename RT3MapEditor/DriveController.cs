using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace RT3MapEditor
{
	// Token: 0x0200004B RID: 75
	public class DriveController
	{
		// Token: 0x06000799 RID: 1945 RVA: 0x0010BEF0 File Offset: 0x0010AEF0
		[DebuggerNonUserCode]
		public DriveController()
		{
		}

		// Token: 0x0600079A RID: 1946
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, ref uint lpBytesReturned, IntPtr lpOverlapped);

		// Token: 0x0600079B RID: 1947
		[DllImport("kernel32", CharSet = CharSet.Unicode, EntryPoint = "CreateFileW", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr CreateFile([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName, int dwDesiredAccess, int dwShareMode, IntPtr lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile);

		// Token: 0x0600079C RID: 1948
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool CloseHandle(IntPtr hObject);

		// Token: 0x0600079D RID: 1949 RVA: 0x0010BEFC File Offset: 0x0010AEFC
		private IntPtr OpenVolume(DriveInfo drive)
		{
			string arg = Conversions.ToString(Conversions.ToChar(drive.Name));
			int dwDesiredAccess;
			switch (drive.DriveType)
			{
			case DriveType.Removable:
				dwDesiredAccess = -1073741824;
				goto IL_5F;
			case DriveType.CDRom:
				dwDesiredAccess = int.MinValue;
				goto IL_5F;
			}
			throw new ArgumentException(string.Format("Cannot eject--'{0}' is not a removable drive.", drive.Name));
			IL_5F:
			string text = string.Format("\\\\.\\{0}:", arg);
			IntPtr intPtr;
			IntPtr result = DriveController.CreateFile(ref text, dwDesiredAccess, 3, intPtr, 3, 0, intPtr);
			bool flag = result.ToInt64() == -1L;
			if (flag)
			{
				throw new IOException("Unable to open volume");
			}
			return result;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0010BFA8 File Offset: 0x0010AFA8
		private bool LockVolume(IntPtr hVolume)
		{
			uint num = 500U;
			int num2 = 1;
			checked
			{
				for (;;)
				{
					IntPtr intPtr;
					uint num3;
					bool flag = DriveController.DeviceIoControl(hVolume, 589848U, intPtr, 0U, intPtr, 0U, ref num3, intPtr);
					if (flag)
					{
						break;
					}
					Thread.Sleep((int)num);
					num2++;
					int num4 = num2;
					int num5 = 20;
					if (num4 > num5)
					{
						goto Block_2;
					}
				}
				return true;
				Block_2:
				return false;
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0010BFFC File Offset: 0x0010AFFC
		private bool DismountVolume(IntPtr hVolume)
		{
			IntPtr intPtr;
			uint num;
			return DriveController.DeviceIoControl(hVolume, 589856U, intPtr, 0U, intPtr, 0U, ref num, intPtr);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0010C020 File Offset: 0x0010B020
		private bool PreventRemovalOfVolume(IntPtr hVolume, bool fPreventRemoval)
		{
			int num = Marshal.SizeOf(typeof(DriveController.PREVENT_MEDIA_REMOVAL));
			bool result = false;
			IntPtr intPtr = IntPtr.Zero;
			try
			{
				intPtr = Marshal.AllocCoTaskMem(num);
				DriveController.PREVENT_MEDIA_REMOVAL prevent_MEDIA_REMOVAL;
				prevent_MEDIA_REMOVAL.PreventMediaRemoval = fPreventRemoval;
				Marshal.StructureToPtr(prevent_MEDIA_REMOVAL, intPtr, false);
				IntPtr intPtr2;
				uint num2;
				result = DriveController.DeviceIoControl(hVolume, 2967556U, intPtr, checked((uint)num), intPtr2, 0U, ref num2, intPtr2);
			}
			finally
			{
				bool flag = intPtr != IntPtr.Zero;
				if (flag)
				{
					Marshal.FreeCoTaskMem(intPtr);
				}
			}
			return result;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0010C0B4 File Offset: 0x0010B0B4
		private bool EjectMedia(IntPtr hVolume)
		{
			IntPtr intPtr;
			uint num;
			return DriveController.DeviceIoControl(hVolume, 2967560U, intPtr, 0U, intPtr, 0U, ref num, intPtr);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0010C0D8 File Offset: 0x0010B0D8
		private bool LoadMedia(IntPtr hVolume)
		{
			IntPtr intPtr;
			uint num;
			return DriveController.DeviceIoControl(hVolume, 2967564U, intPtr, 0U, intPtr, 0U, ref num, intPtr);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0010C0FC File Offset: 0x0010B0FC
		public bool Eject(string driveName)
		{
			DriveInfo drive = new DriveInfo(driveName);
			bool result = false;
			IntPtr intPtr = this.OpenVolume(drive);
			bool flag = this.LockVolume(intPtr) && this.DismountVolume(intPtr);
			bool flag2;
			if (flag)
			{
				flag2 = (this.PreventRemovalOfVolume(intPtr, false) && this.EjectMedia(intPtr));
				if (flag2)
				{
					result = true;
				}
			}
			flag2 = !DriveController.CloseHandle(intPtr);
			if (flag2)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0010C178 File Offset: 0x0010B178
		public bool Load(string driveName)
		{
			DriveInfo drive = new DriveInfo(driveName);
			bool result = false;
			IntPtr intPtr = this.OpenVolume(drive);
			bool flag = this.LoadMedia(intPtr);
			if (flag)
			{
				result = true;
			}
			flag = !DriveController.CloseHandle(intPtr);
			if (flag)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000472 RID: 1138
		private const int LOCK_TIMEOUT = 10000;

		// Token: 0x04000473 RID: 1139
		private const int LOCK_RETRIES = 20;

		// Token: 0x04000474 RID: 1140
		private const int GENERIC_READ = -2147483648;

		// Token: 0x04000475 RID: 1141
		private const int GENERIC_WRITE = 1073741824;

		// Token: 0x04000476 RID: 1142
		private const int OPEN_EXISTING = 3;

		// Token: 0x04000477 RID: 1143
		private const int FILE_SHARE_READ = 1;

		// Token: 0x04000478 RID: 1144
		private const int FILE_SHARE_WRITE = 2;

		// Token: 0x04000479 RID: 1145
		private const int INVALID_HANDLE_VALUE = -1;

		// Token: 0x0400047A RID: 1146
		private const int FSCTL_LOCK_VOLUME = 589848;

		// Token: 0x0400047B RID: 1147
		private const int FSCTL_DISMOUNT_VOLUME = 589856;

		// Token: 0x0400047C RID: 1148
		private const int IOCTL_STORAGE_MEDIA_REMOVAL = 2967556;

		// Token: 0x0400047D RID: 1149
		private const int IOCTL_STORAGE_EJECT_MEDIA = 2967560;

		// Token: 0x0400047E RID: 1150
		private const int IOCTL_STORAGE_LOAD_MEDIA = 2967564;

		// Token: 0x0200004C RID: 76
		private struct PREVENT_MEDIA_REMOVAL
		{
			// Token: 0x0400047F RID: 1151
			public bool PreventMediaRemoval;
		}
	}
}
