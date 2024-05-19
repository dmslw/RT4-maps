using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x0200001E RID: 30
	public class ChoseFile2ExportDialog
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x000FD20C File Offset: 0x000FC20C
		public ChoseFile2ExportDialog()
		{
			this.exportSaveFileDialog = new SaveFileDialog();
			this.exportSaveFileDialog.Title = Resources.exportTitle;
			this.exportSaveFileDialog.InitialDirectory = MySettingsProperty.Settings.exportPath;
			this.exportSaveFileDialog.RestoreDirectory = true;
			this.exportSaveFileDialog.OverwritePrompt = true;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000FD270 File Offset: 0x000FC270
		public DialogResult showDialog(string fileName)
		{
			this.exportSaveFileDialog.FileName = fileName;
			this.exportSaveFileDialog.InitialDirectory = MySettingsProperty.Settings.exportPath;
			string extension = Path.GetExtension(fileName);
			bool flag = Operators.CompareString(extension, ".asc", false) == 0;
			if (flag)
			{
				this.exportSaveFileDialog.Filter = "asc files (*.asc)|*.asc";
			}
			else
			{
				flag = (Operators.CompareString(extension, ".csv", false) == 0);
				if (flag)
				{
					this.exportSaveFileDialog.Filter = "csv files (*.csv)|*.csv";
				}
				else
				{
					flag = (Operators.CompareString(extension, ".rt3", false) == 0);
					if (flag)
					{
						this.exportSaveFileDialog.Filter = "rt3 files (*.rt3)|*.rt3";
					}
					else
					{
						flag = (Operators.CompareString(extension, ".kml", false) == 0);
						if (flag)
						{
							this.exportSaveFileDialog.Filter = "kml files (*.kml)|*.kml";
						}
						else
						{
							flag = (Operators.CompareString(extension, ".kmz", false) == 0);
							if (flag)
							{
								this.exportSaveFileDialog.Filter = "kmz files (*.kmz)|*.kmz";
							}
							else
							{
								this.exportSaveFileDialog.Filter = "all files (*.*)|*.*";
							}
						}
					}
				}
			}
			DialogResult dialogResult = this.exportSaveFileDialog.ShowDialog();
			flag = (dialogResult == DialogResult.OK && Operators.CompareString(this.exportSaveFileDialog.FileName, "", false) != 0);
			if (flag)
			{
				MySettingsProperty.Settings.exportPath = Path.GetDirectoryName(this.exportSaveFileDialog.FileName);
			}
			return dialogResult;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000FD3D8 File Offset: 0x000FC3D8
		public string getFileName()
		{
			return this.exportSaveFileDialog.FileName;
		}

		// Token: 0x040001A0 RID: 416
		private SaveFileDialog exportSaveFileDialog;

		// Token: 0x040001A1 RID: 417
		private const string ascFilter = "asc files (*.asc)|*.asc";

		// Token: 0x040001A2 RID: 418
		private const string csvFilter = "csv files (*.csv)|*.csv";

		// Token: 0x040001A3 RID: 419
		private const string txtRT3Filter = "rt3 files (*.rt3)|*.rt3";

		// Token: 0x040001A4 RID: 420
		private const string kmlFilter = "kml files (*.kml)|*.kml";

		// Token: 0x040001A5 RID: 421
		private const string kmzFilter = "kmz files (*.kmz)|*.kmz";

		// Token: 0x040001A6 RID: 422
		private const string allFilter = "all files (*.*)|*.*";
	}
}
