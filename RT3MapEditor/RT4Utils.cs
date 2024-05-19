using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000075 RID: 117
	public class RT4Utils
	{
		// Token: 0x06000D2B RID: 3371 RVA: 0x0011FE48 File Offset: 0x0011EE48
		public RT4Utils()
		{
			this._RTxType = Common.RTxType;
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0011FE60 File Offset: 0x0011EE60
		public void configBootScreen()
		{
			BootScreenDialog bootScreenDialog = new BootScreenDialog(this._RTxType);
			MyProject.Application.Log.WriteEntry("configBootScreen() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			try
			{
				bool flag = this._RTxType == Common.RTxTypes.typeRT5HR && Interaction.MsgBox(Resources.strWarBootScrNotTested, MsgBoxStyle.OkCancel, null) == MsgBoxResult.Cancel;
				if (flag)
				{
					throw new SilentGUIException();
				}
				flag = (bootScreenDialog.ShowDialog() == DialogResult.OK);
				if (flag)
				{
					string driveToUse = bootScreenDialog.getDriveToUse();
					flag = (Operators.CompareString(driveToUse, "CD-ROM", false) == 0);
					string text;
					if (flag)
					{
						text = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
						MyProject.Computer.FileSystem.CreateDirectory(text);
					}
					else
					{
						flag = FileUtils.eraseDrive(driveToUse);
						if (!flag)
						{
							return;
						}
						text = driveToUse;
						formMain.wizardState.OperationInProgress(Resources.strStatusUpgradeUSBKey);
					}
					CopyMap.fillKeyWithScriptEnv(text, Common.scriptTypes.copyBootScreen);
					ZipFile zipFile = new ZipFile(Path.Combine(MyProject.Application.Info.DirectoryPath, "redist\\upg.dat"));
					zipFile.Password = "ZZZCOM.IND.lst";
					string copyPath = Path.Combine(text, "JANFI67_SCRIPTS");
					CopyMap.extractAndProcessScript(zipFile, "34", "JANFI67_SCRIPT.CMD", copyPath, null, false, false, false, "Bootscreen.bmp");
					string text2 = Path.Combine(text, "Bootscreen.bmp");
					Stream outputStream = new FileStream(text2, FileMode.Create);
					bootScreenDialog.WriteBootScreen(outputStream, text2);
					flag = !BootScreenDialog.CheckFinalBMPFile(text2);
					if (flag)
					{
						Interaction.MsgBox(Resources.strErrIncOutBmp, MsgBoxStyle.Exclamation, null);
						throw new SilentGUIException();
					}
					RT4Inf rt4Inf = new RT4Inf(text2);
					flag = (Operators.CompareString(driveToUse, "CD-ROM", false) == 0);
					if (flag)
					{
						formMain.wizardState.OperationInProgress(Resources.strISOInProgress);
						string text3 = FileUtils.createISO(text, MySettingsProperty.Settings.ISODir, "BOOTSCR");
						flag = (text3 != null);
						if (flag)
						{
							FileUtils.burnISO(text3);
						}
						MyProject.Computer.FileSystem.DeleteDirectory(text, DeleteDirectoryOption.DeleteAllContents);
					}
					else
					{
						DriveController driveController = new DriveController();
						driveController.Eject(driveToUse);
						Interaction.MsgBox(Resources.strUSBOK, MsgBoxStyle.Information, null);
					}
				}
			}
			catch (SilentGUIException ex)
			{
			}
			catch (Exception ex2)
			{
				MyProject.Application.Log.WriteException(ex2);
				MyProject.Application.Log.WriteEntry(Resources.strErrBootScreen);
				Interaction.MsgBox(Resources.strErrBootScreen, MsgBoxStyle.Information, null);
			}
			finally
			{
				formMain.wizardState.changeState(WizardState.states.NOCHANGE);
			}
			formMain = null;
			MyProject.Application.Log.WriteEntry("configBootScreen() end", TraceEventType.Information);
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00120160 File Offset: 0x0011F160
		public void patchDBDWNLPPC()
		{
			DBDWNLPPCPatchDialog dbdwnlppcpatchDialog = new DBDWNLPPCPatchDialog(this._RTxType);
			MyProject.Application.Log.WriteEntry("patchDBDWNLPPC() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			try
			{
				bool flag = dbdwnlppcpatchDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					string driveToUse = dbdwnlppcpatchDialog.getDriveToUse();
					flag = (Operators.CompareString(driveToUse, "CD-ROM", false) == 0);
					string text;
					if (flag)
					{
						text = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
						MyProject.Computer.FileSystem.CreateDirectory(text);
					}
					else
					{
						flag = FileUtils.eraseDrive(driveToUse);
						if (!flag)
						{
							return;
						}
						text = driveToUse;
						formMain.wizardState.OperationInProgress(Resources.strStatusUpgradeUSBKey);
					}
					CopyMap.fillKeyWithScriptEnv(text, Common.scriptTypes.patchDBDWNLPCC);
					ZipFile zipFile = new ZipFile(Path.Combine(MyProject.Application.Info.DirectoryPath, "redist\\upg.dat"));
					zipFile.Password = "ZZZCOM.IND.lst";
					string copyPath = Path.Combine(text, "JANFI67_SCRIPTS");
					CopyMap.extractAndProcessScript(zipFile, "44", "JANFI67_SCRIPT.CMD", copyPath, null, false, false, false, "DB_DWNL_PPC.OUT");
					flag = (Operators.CompareString(driveToUse, "CD-ROM", false) == 0);
					if (flag)
					{
						formMain.wizardState.OperationInProgress(Resources.strISOInProgress);
						string text2 = FileUtils.createISO(text, MySettingsProperty.Settings.ISODir, "RADDISP");
						flag = (text2 != null);
						if (flag)
						{
							FileUtils.burnISO(text2);
						}
						MyProject.Computer.FileSystem.DeleteDirectory(text, DeleteDirectoryOption.DeleteAllContents);
					}
					else
					{
						DriveController driveController = new DriveController();
						driveController.Eject(driveToUse);
						Interaction.MsgBox(Resources.strUSBOK, MsgBoxStyle.Information, null);
					}
				}
			}
			catch (SilentGUIException ex)
			{
			}
			catch (Exception ex2)
			{
				MyProject.Application.Log.WriteException(ex2);
				MyProject.Application.Log.WriteEntry(Resources.strErrBootScreen);
				Interaction.MsgBox(Resources.strErrBootScreen, MsgBoxStyle.Information, null);
			}
			finally
			{
				formMain.wizardState.changeState(WizardState.states.NOCHANGE);
			}
			formMain = null;
			MyProject.Application.Log.WriteEntry("patchDBDWNLPPC() end", TraceEventType.Information);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x001203DC File Offset: 0x0011F3DC
		public void configFileCopyToRT4(string fileName)
		{
			SelectFlashDriveDialog selectFlashDriveDialog = new SelectFlashDriveDialog(10000000L);
			string text = null;
			Cursor cursor = null;
			MyProject.Application.Log.WriteEntry("configFileCopyToRT4() begin", TraceEventType.Information);
			bool flag = Operators.CompareString(fileName, "Agenda.dat", false) == 0;
			string text2;
			if (flag)
			{
				text2 = "\\I\\USER_DATA\\Agenda\\" + fileName;
			}
			else
			{
				flag = (Operators.CompareString(fileName, "User_com.dat", false) == 0);
				if (!flag)
				{
					Interaction.MsgBox(Resources.strErrInvalidFileName, MsgBoxStyle.Exclamation, null);
					return;
				}
				text2 = "\\I\\USER_DATA\\User_profile\\" + fileName;
			}
			Interaction.MsgBox(string.Format(Resources.strUseUSBToCopyFile, text2), MsgBoxStyle.Information, null);
			FormMain formMain = MyProject.Forms.FormMain;
			flag = (selectFlashDriveDialog.ShowDialog() == DialogResult.OK);
			if (flag)
			{
				text = selectFlashDriveDialog.getDriveToUse();
				text2 = Path.Combine(text, text2.Substring(1));
				try
				{
					formMain.wizardState.OperationInProgress(Resources.strStatusUpgradeUSBKey);
					Application.DoEvents();
					cursor = formMain.Cursor;
					formMain.Cursor = Cursors.WaitCursor;
					MyProject.Forms.FormMain.ToolStripProgressBar1.MarqueeAnimationSpeed = 150;
					MyProject.Forms.FormMain.ToolStripProgressBar1.Visible = true;
					MyProject.Forms.FormMain.ToolStripProgressBar1.Enabled = true;
					Application.DoEvents();
					flag = (!MyProject.Computer.FileSystem.FileExists(text2) || !MyProject.Computer.FileSystem.FileExists(Path.Combine(text, Path.Combine("JANFI67_SCRIPTS", "JANFI67_SCRIPT.CMD"))));
					if (flag)
					{
						throw new IncUSBKeyException(string.Format(Resources.strErrUnable2Open, text2));
					}
					UserComDat userComDat = new UserComDat(text2, this._RTxType);
					bool flag2 = userComDat.isUserComDatValid();
					flag = (Operators.CompareString(fileName, "Agenda.dat", false) == 0);
					bool flag3;
					if (flag)
					{
						flag3 = !flag2;
					}
					else
					{
						flag = (Operators.CompareString(fileName, "User_com.dat", false) == 0);
						if (flag)
						{
							flag3 = flag2;
							flag = flag3;
							if (flag)
							{
								userComDat.check();
							}
						}
					}
					flag = !flag3;
					if (flag)
					{
						throw new InvRT4ConfigFileException(string.Format(Resources.strErrRT4ConfFileInc, fileName));
					}
					RT4Inf rt4Inf = new RT4Inf(text2, true);
					ZipFile zipFile = new ZipFile(Path.Combine(MyProject.Application.Info.DirectoryPath, "redist\\upg.dat"));
					zipFile.Password = "ZZZCOM.IND.lst";
					string copyPath = Path.Combine(text, "JANFI67_SCRIPTS");
					CopyMap.extractAndProcessScript(zipFile, "34", "JANFI67_SCRIPT.CMD", copyPath, null, false, false, false, fileName);
				}
				catch (InvRT4ConfigFileException ex)
				{
					Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, null);
					formMain.wizardState.changeState(WizardState.states.NOCHANGE);
					return;
				}
				catch (IncUSBKeyException ex2)
				{
					Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, null);
					formMain.wizardState.changeState(WizardState.states.NOCHANGE);
					return;
				}
				catch (Exception ex3)
				{
					Interaction.MsgBox(Resources.strUSBNOK, MsgBoxStyle.Critical, null);
					formMain.wizardState.changeState(WizardState.states.NOCHANGE);
					return;
				}
				finally
				{
					MyProject.Forms.FormMain.ToolStripProgressBar1.MarqueeAnimationSpeed = 0;
					formMain.Cursor = cursor;
					DriveController driveController = new DriveController();
					driveController.Eject(text);
				}
				formMain.wizardState.changeState(WizardState.states.NOCHANGE);
				Interaction.MsgBox(Resources.strUSBOK, MsgBoxStyle.Information, null);
			}
			formMain = null;
			MyProject.Application.Log.WriteEntry("configFileCopyToRT4() end", TraceEventType.Information);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x001207F4 File Offset: 0x0011F7F4
		public void RT4Config2USB()
		{
			SelectFlashDriveDialog selectFlashDriveDialog = new SelectFlashDriveDialog(10000000L);
			string text = null;
			Cursor cursor = null;
			MyProject.Application.Log.WriteEntry("RT4Config2USB() begin", TraceEventType.Information);
			FormMain formMain = MyProject.Forms.FormMain;
			bool flag = selectFlashDriveDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				text = selectFlashDriveDialog.getDriveToUse();
				flag = (Interaction.MsgBox(string.Format(Resources.strWarningEraseDrive, text), MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question, null) == MsgBoxResult.Yes);
				if (flag)
				{
					try
					{
						MyProject.Forms.FormMain.wizardState.OperationInProgress(Resources.strStatusUSBErase);
						cursor = formMain.Cursor;
						formMain.Cursor = Cursors.WaitCursor;
						MyProject.Forms.FormMain.ToolStripProgressBar1.MarqueeAnimationSpeed = 150;
						MyProject.Forms.FormMain.ToolStripProgressBar1.Visible = true;
						MyProject.Forms.FormMain.ToolStripProgressBar1.Enabled = true;
						Application.DoEvents();
						foreach (string path in Directory.GetDirectories(text, "*", System.IO.SearchOption.TopDirectoryOnly))
						{
							MyProject.Computer.FileSystem.DeleteDirectory(Path.Combine(text, path), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
						}
						foreach (string path2 in Directory.GetFiles(text, "*", System.IO.SearchOption.TopDirectoryOnly))
						{
							MyProject.Computer.FileSystem.DeleteFile(Path.Combine(text, path2), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.ThrowException);
						}
						formMain.wizardState.OperationInProgress(Resources.strStatusUpgradeUSBKey);
						Application.DoEvents();
						CopyMap.fillKeyToCopyConfig(text);
					}
					catch (Exception ex)
					{
						Interaction.MsgBox(Resources.strUSBNOK, MsgBoxStyle.Critical, null);
						formMain.wizardState.changeState(WizardState.states.NOCHANGE);
						return;
					}
					finally
					{
						MyProject.Forms.FormMain.ToolStripProgressBar1.MarqueeAnimationSpeed = 0;
						formMain.Cursor = cursor;
						DriveController driveController = new DriveController();
						driveController.Eject(text);
					}
					formMain.wizardState.changeState(WizardState.states.NOCHANGE);
					Interaction.MsgBox(Resources.strUSBOK, MsgBoxStyle.Information, null);
				}
			}
			formMain = null;
			MyProject.Application.Log.WriteEntry("RT4Config2USB() end", TraceEventType.Information);
		}

		// Token: 0x040005A5 RID: 1445
		private Common.RTxTypes _RTxType;
	}
}
