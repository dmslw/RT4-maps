using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x0200004D RID: 77
	public class FileUtils
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x0010C1C0 File Offset: 0x0010B1C0
		[DebuggerNonUserCode]
		public FileUtils()
		{
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0010C1CC File Offset: 0x0010B1CC
		public static bool eraseDrive(string destDrive)
		{
			Cursor cursor = null;
			MyProject.Application.Log.WriteEntry("eraseDrive() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			bool flag = Interaction.MsgBox(string.Format(Resources.strWarningEraseDrive, destDrive), MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question, null) == MsgBoxResult.Yes;
			bool result;
			if (flag)
			{
				try
				{
					formMain.wizardState.OperationInProgress(Resources.strStatusUSBErase);
					cursor = formMain.Cursor;
					formMain.Cursor = Cursors.WaitCursor;
					formMain.ToolStripProgressBar1.MarqueeAnimationSpeed = 150;
					formMain.ToolStripProgressBar1.Visible = true;
					formMain.ToolStripProgressBar1.Enabled = true;
					Application.DoEvents();
					foreach (string path in Directory.GetDirectories(destDrive, "*", System.IO.SearchOption.TopDirectoryOnly))
					{
						MyProject.Computer.FileSystem.DeleteDirectory(Path.Combine(destDrive, path), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
						Application.DoEvents();
					}
					foreach (string path2 in Directory.GetFiles(destDrive, "*", System.IO.SearchOption.TopDirectoryOnly))
					{
						MyProject.Computer.FileSystem.DeleteFile(Path.Combine(destDrive, path2), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
						Application.DoEvents();
					}
					Application.DoEvents();
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(Resources.strErrUSBErase, MsgBoxStyle.Critical, null);
					formMain.wizardState.changeState(WizardState.states.NOCHANGE);
					return false;
				}
				finally
				{
					formMain.ToolStripProgressBar1.MarqueeAnimationSpeed = 0;
					formMain.Cursor = cursor;
				}
				formMain.wizardState.changeState(WizardState.states.NOCHANGE);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0010C3D4 File Offset: 0x0010B3D4
		public static void streamCopy(Stream input, Stream output)
		{
			byte[] array = new byte[4097];
			int num;
			do
			{
				num = input.Read(array, 0, array.Length);
				output.Write(array, 0, num);
			}
			while (num > 0);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0010C410 File Offset: 0x0010B410
		public static string createISO(string srcDir, string ISOPath, string ISOName)
		{
			Cursor cursor = null;
			string text = Path.Combine(ISOPath, ISOName + ".iso");
			int value = 0;
			int num = -1;
			MyProject.Application.Log.WriteEntry("createISO() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			try
			{
				cursor = formMain.Cursor;
				formMain.Cursor = Cursors.WaitCursor;
				formMain.wizardState.OperationInProgress(Resources.strISOStart);
				Application.DoEvents();
				bool flag = MyProject.Computer.FileSystem.FileExists(text);
				if (flag)
				{
					MyProject.Computer.FileSystem.DeleteFile(text);
				}
				string arguments = string.Format("-iso-level 2 -J -rational-rock -A \"RTxMapEditor {0:G}\" -publisher \"Janfi67@planete-citroen.com\" -preparer \"Janfi67@planete-citroen.com\" -o \"{1:G}\" -V {2:G} \"{3:G}\"", new object[]
				{
					MyProject.Application.Info.Version.ToString(),
					text,
					ISOName,
					srcDir
				});
				Process process = Process.Start(new ProcessStartInfo("mkisofs.exe", arguments)
				{
					CreateNoWindow = true,
					RedirectStandardError = true,
					UseShellExecute = false,
					WindowStyle = ProcessWindowStyle.Hidden,
					WorkingDirectory = MyProject.Forms.FormMain.CurrentWorkingDir
				});
				process.PriorityClass = ProcessPriorityClass.BelowNormal;
				int id = process.Id;
				string text2 = process.StandardError.ReadLine();
				MyProject.Forms.FormMain.ToolStripProgressBar1.Style = ProgressBarStyle.Blocks;
				MyProject.Forms.FormMain.ToolStripProgressBar1.Minimum = 0;
				MyProject.Forms.FormMain.ToolStripProgressBar1.Maximum = 100;
				while (text2 != null)
				{
					MyProject.Forms.FormMain.ToolStripStatusLabelSatus.Text = Resources.strISOInProgress;
					MyProject.Application.Log.WriteEntry(text2, TraceEventType.Information);
					flag = int.TryParse(text2.Substring(0, Math.Max(text2.IndexOf("."), 0)), out value);
					if (flag)
					{
						MyProject.Forms.FormMain.ToolStripProgressBar1.Value = value;
					}
					Application.DoEvents();
					text2 = process.StandardError.ReadLine();
				}
				process.WaitForExit();
				formMain.ToolStripProgressBar1.Value = 0;
				flag = process.HasExited;
				if (flag)
				{
					num = process.ExitCode;
				}
				flag = (num != 0);
				if (flag)
				{
					Interaction.MsgBox(string.Format(Resources.strISOErrRun, num), MsgBoxStyle.Critical, null);
					formMain.wizardState.changeState(WizardState.states.NOCHANGE);
					return null;
				}
			}
			catch (Exception ex)
			{
				formMain.wizardState.changeState(WizardState.states.NOCHANGE);
				Interaction.MsgBox(Resources.strISOError, MsgBoxStyle.Critical, null);
				return null;
			}
			finally
			{
				formMain.Cursor = cursor;
			}
			formMain.wizardState.changeState(WizardState.states.ISOOK);
			formMain = null;
			MyProject.Application.Log.WriteEntry("createISO() end", TraceEventType.Information);
			return text;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0010C750 File Offset: 0x0010B750
		public static bool burnISO(string ISOFileName)
		{
			MyProject.Application.Log.WriteEntry("burnISO() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			bool flag = Operators.CompareString(MySettingsProperty.Settings.BurningCommand, "", false) == 0 | !MyProject.Computer.FileSystem.FileExists(MySettingsProperty.Settings.BurningCommand);
			if (flag)
			{
				MyProject.Application.Log.WriteEntry(Resources.strErrNoBurnerConfigured, TraceEventType.Error);
				Interaction.MsgBox(Resources.strErrNoBurnerConfigured, MsgBoxStyle.Critical, null);
				flag = (MyProject.Forms.ConfigDialog.ShowDialog(ConfigDialog.tabList.general, ConfigDialog.tabList.general) != DialogResult.OK);
				if (flag)
				{
					MyProject.Application.Log.WriteEntry(Resources.strErrNoBurnerConfigured, TraceEventType.Error);
					return false;
				}
			}
			try
			{
				Process process = Process.Start(MySettingsProperty.Settings.BurningCommand, "\"" + ISOFileName + "\"");
				int id = process.Id;
				process.WaitForExit();
				flag = process.HasExited;
				if (flag)
				{
					int exitCode = process.ExitCode;
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(Resources.strErrBurnCmd, MsgBoxStyle.Critical, null);
				return false;
			}
			formMain.wizardState.changeState(WizardState.states.NOCHANGE);
			formMain = null;
			MyProject.Application.Log.WriteEntry("burnISO() end", TraceEventType.Information);
			return true;
		}
	}
}
