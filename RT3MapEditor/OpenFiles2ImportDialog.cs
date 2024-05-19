using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000029 RID: 41
	public class OpenFiles2ImportDialog
	{
		// Token: 0x0600032F RID: 815 RVA: 0x000FD904 File Offset: 0x000FC904
		public OpenFiles2ImportDialog()
		{
			this.OpenFileDialog = new OpenFileDialog();
			this.OpenFileDialog.Title = Resources.strImportTitle;
			this.OpenFileDialog.InitialDirectory = MySettingsProperty.Settings.importPath;
			this.OpenFileDialog.Filter = Resources.strFileType;
			this.OpenFileDialog.FilterIndex = 1;
			this.OpenFileDialog.RestoreDirectory = true;
			this.OpenFileDialog.Multiselect = true;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000FD984 File Offset: 0x000FC984
		public DialogResult showDialog()
		{
			this.OpenFileDialog.InitialDirectory = MySettingsProperty.Settings.importPath;
			DialogResult result = this.OpenFileDialog.ShowDialog();
			bool flag = Operators.CompareString(this.OpenFileDialog.FileName, "", false) != 0;
			if (flag)
			{
				MySettingsProperty.Settings.importPath = Path.GetDirectoryName(this.OpenFileDialog.FileName);
			}
			return result;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x000FD9F8 File Offset: 0x000FC9F8
		public string[] getFileNames()
		{
			return this.OpenFileDialog.FileNames;
		}

		// Token: 0x040001EF RID: 495
		private OpenFileDialog OpenFileDialog;
	}
}
