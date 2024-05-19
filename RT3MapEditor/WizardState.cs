using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000042 RID: 66
	public class WizardState
	{
		// Token: 0x0600075E RID: 1886 RVA: 0x00107908 File Offset: 0x00106908
		public WizardState(FormMain formMain)
		{
			this.UpdateMainFormVisibility();
			this.state = WizardState.states.STARTING;
			this.startingState();
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00107928 File Offset: 0x00106928
		private void setMode(Common.RTxMapEditorMapModes mode)
		{
			bool flag = mode == Common.RTxMapEditorMapModes.alert;
			if (flag)
			{
				this.strMode = Resources.strStatusAlert;
				flag = (MyProject.Forms.FormMain.mapMngt.mapDesc == null || MyProject.Forms.FormMain.mapMngt.mapDesc.Length == 0);
				if (flag)
				{
					MyProject.Forms.FormMain.ToolStripStatusLabel1.Text = string.Format("{0:G} : ", Resources.strStatusAlertMode);
				}
				else
				{
					MyProject.Forms.FormMain.ToolStripStatusLabel1.Text = string.Format("{0:G} {1:G} : ", Resources.strStatusAlert, MyProject.Forms.FormMain.mapMngt.mapDesc);
				}
			}
			else
			{
				this.strMode = Resources.strStatusMap;
				flag = (MyProject.Forms.FormMain.mapMngt.mapDesc == null || MyProject.Forms.FormMain.mapMngt.mapDesc.Length == 0);
				if (flag)
				{
					MyProject.Forms.FormMain.ToolStripStatusLabel1.Text = string.Format("{0:G} : ", Resources.strStatusMapMode);
				}
				else
				{
					MyProject.Forms.FormMain.ToolStripStatusLabel1.Text = string.Format("{0:G} {1:G} : ", Resources.strStatusMap, MyProject.Forms.FormMain.mapMngt.mapDesc);
				}
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00107A94 File Offset: 0x00106A94
		public void UpdateMainFormVisibility()
		{
			FormMain formMain = MyProject.Forms.FormMain;
			bool flag = Common.RTxType == Common.RTxTypes.typeRT3;
			if (flag)
			{
				formMain.Or_ToolStripLabel.Visible = false;
				formMain.USB_ToolStripButton.Visible = false;
				formMain.USB_ToolStripMenuItem.Visible = false;
				formMain.RT4_ToolStripMenuItem.Visible = false;
				formMain.ModeToolStripMenuItem.Visible = false;
			}
			else
			{
				formMain.RT4_ToolStripMenuItem.Visible = true;
				flag = MySettingsProperty.Settings.RT4CDRMode;
				if (flag)
				{
					formMain.ISO_ToolStripButton.Visible = true;
					formMain.ISO_ToolStripMenuItem.Visible = true;
					formMain.Burn_ToolStripButton.Visible = true;
					formMain.Burn_ToolStripMenuItem.Visible = true;
					flag = MySettingsProperty.Settings.RT4USBMode;
					if (flag)
					{
						formMain.Or_ToolStripLabel.Visible = true;
					}
					else
					{
						formMain.Or_ToolStripLabel.Visible = false;
					}
				}
				else
				{
					formMain.ISO_ToolStripButton.Visible = false;
					formMain.ISO_ToolStripMenuItem.Visible = false;
					formMain.Or_ToolStripLabel.Visible = false;
					formMain.Burn_ToolStripButton.Visible = false;
					formMain.Burn_ToolStripMenuItem.Visible = false;
				}
				flag = MySettingsProperty.Settings.RT4USBMode;
				if (flag)
				{
					formMain.USB_ToolStripButton.Visible = true;
					formMain.USB_ToolStripMenuItem.Visible = true;
					formMain.RT4MapUSBToolStripMenuItem.Enabled = true;
					formMain.RT4ConfigurationUSBKeyToolStripMenuItem.Enabled = true;
					flag = (Common.RTxVersion == Common.RTxVersions.version710 | Common.RTxVersion == Common.RTxVersions.version711);
					if (flag)
					{
						formMain.AgendatdatRT4ToolStripMenuItem.Enabled = true;
					}
					else
					{
						formMain.AgendatdatRT4ToolStripMenuItem.Enabled = false;
					}
					formMain.UsercomdatRT4ToolStripMenuItem.Enabled = true;
				}
				else
				{
					formMain.USB_ToolStripButton.Visible = false;
					formMain.USB_ToolStripMenuItem.Visible = false;
					formMain.RT4MapUSBToolStripMenuItem.Enabled = false;
					formMain.RT4ConfigurationUSBKeyToolStripMenuItem.Enabled = false;
					formMain.AgendatdatRT4ToolStripMenuItem.Enabled = false;
					formMain.UsercomdatRT4ToolStripMenuItem.Enabled = false;
				}
				formMain.ModeToolStripMenuItem.Visible = (Common.RTxVersion == Common.RTxVersions.version81);
				formMain.LoadMap_ToolStripButton.Visible = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
				formMain.LoadMap_ToolStripMenuItem.Visible = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
				formMain.ReloadMapWithAllPOIToolStripMenuItem.Visible = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
				formMain.ToolStripSeparator3.Visible = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00107CFC File Offset: 0x00106CFC
		public void UpdateMainFormGUI()
		{
			FormMain formMain = MyProject.Forms.FormMain;
			formMain.MenuStrip.Enabled = true;
			formMain.ToolStrip.Enabled = true;
			switch (formMain.itemNbSelectedInPOIList)
			{
			case 0:
				formMain.ImportedFilesPropertiesGroupBox.Enabled = false;
				formMain.ImportedFilesPropertiesGroupBox.Text = Resources.strImportedFilesGroupBoxTitle;
				formMain.DeleteToolStripMenuItem.Enabled = false;
				formMain.DeleteAndNeverLoadToolStripMenuItem.Enabled = false;
				formMain.AlwaysAddToolStripMenuItem.Enabled = false;
				formMain.RenameToolStripMenuItem.Enabled = false;
				formMain.MergeToolStripMenuItem.Enabled = false;
				formMain.RemoveDuplicatesToolStripMenuItem.Enabled = false;
				formMain.ExportToolStripMenuItem.Enabled = false;
				formMain.RT3OTypeComboBox.SelectedIndex = -1;
				formMain.RT3OLayerComboBox.SelectedIndex = -1;
				formMain.RT3OScaleComboBox.SelectedIndex = -1;
				formMain.RT3OMagComboBox.SelectedIndex = -1;
				formMain.RT3OTypeComboBox.Enabled = false;
				formMain.RT3OMagComboBox.Enabled = false;
				formMain.RT3OFullPatchCheckBox.Enabled = false;
				formMain.RT3ODisplayMagCheckBox.Enabled = false;
				formMain.Speed_NumericUpDown.Enabled = false;
				formMain.formMainNameTabPage.setValuesFromSelectedList();
				break;
			case 1:
				formMain.ImportedFilesPropertiesGroupBox.Enabled = true;
				formMain.ImportedFilesPropertiesGroupBox.Text = string.Format(Resources.strImportedFileGroupBoxTitle, MyProject.Forms.FormMain.selectedPOIList.name, MyProject.Forms.FormMain.selectedPOIList.ListofPOI.Count);
				formMain.DeleteToolStripMenuItem.Enabled = !formMain.selectedPOIList.isReadOnly;
				formMain.DeleteAndNeverLoadToolStripMenuItem.Enabled = formMain.selectedPOIList.fromRT3Map;
				formMain.AlwaysAddToolStripMenuItem.Enabled = (!formMain.selectedPOIList.fromRT3Map & !formMain.selectedPOIList.allwaysLoad);
				formMain.RenameToolStripMenuItem.Enabled = !formMain.selectedPOIList.fromRT3Map;
				formMain.MergeToolStripMenuItem.Enabled = false;
				formMain.RemoveDuplicatesToolStripMenuItem.Enabled = !formMain.selectedPOIList.fromRT3Map;
				formMain.ExportToolStripMenuItem.Enabled = true;
				formMain.RT3OTypeComboBox.SelectedIndex = -1;
				formMain.RT3OTypeComboBox.SelectedValue = formMain.selectedPOIList.type;
				formMain.RT3OTypeComboBox.Enabled = (!formMain.selectedPOIList.fromRT3 | formMain.selectedPOIList.type != 4444);
				formMain.RT3OMagComboBox.Enabled = (!formMain.selectedPOIList.fromRT3 & formMain.selectedPOIList.type == 4444);
				formMain.RT3OFullPatchCheckBox.Enabled = (!formMain.selectedPOIList.fromRT3 & formMain.selectedPOIList.type == 4444 & formMain.selectedPOIList.magnitude >= 4);
				formMain.RT3OFullPatchCheckBox.Checked = (formMain.selectedPOIList.fullPatch & formMain.selectedPOIList.magnitude >= 4);
				formMain.RT3ODisplayMagCheckBox.Enabled = (formMain.selectedPOIList.type == 4444);
				formMain.RT3ODisplayMagCheckBox.Checked = formMain.selectedPOIList.displayMagnitude;
				formMain.Speed_NumericUpDown.Value = new decimal(formMain.selectedPOIList.speed);
				formMain.Speed_NumericUpDown.Enabled = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert & !formMain.selectedPOIList.fromArchive);
				formMain.formMainNameTabPage.setValuesFromSelectedList();
				break;
			default:
				formMain.ImportedFilesPropertiesGroupBox.Enabled = false;
				formMain.ImportedFilesPropertiesGroupBox.Text = Resources.strImportedFilesGroupBoxTitle;
				formMain.DeleteToolStripMenuItem.Enabled = !this.isReadOnlyInList(MyProject.Forms.FormMain.ImportedFilesListBox.SelectedIndices);
				formMain.DeleteAndNeverLoadToolStripMenuItem.Enabled = this.allFromRT3MapInList(MyProject.Forms.FormMain.ImportedFilesListBox.SelectedIndices);
				formMain.AlwaysAddToolStripMenuItem.Enabled = this.allwaysLoadInList(MyProject.Forms.FormMain.ImportedFilesListBox.SelectedIndices);
				formMain.RenameToolStripMenuItem.Enabled = false;
				formMain.MergeToolStripMenuItem.Enabled = !this.fromRT3InList(MyProject.Forms.FormMain.ImportedFilesListBox.SelectedIndices);
				formMain.RemoveDuplicatesToolStripMenuItem.Enabled = this.IsOneAddedInList(MyProject.Forms.FormMain.ImportedFilesListBox.SelectedIndices);
				formMain.ExportToolStripMenuItem.Enabled = false;
				formMain.RT3OTypeComboBox.SelectedIndex = -1;
				formMain.RT3OLayerComboBox.SelectedIndex = -1;
				formMain.RT3OScaleComboBox.SelectedIndex = -1;
				formMain.RT3OMagComboBox.SelectedIndex = -1;
				formMain.RT3OTypeComboBox.Enabled = false;
				formMain.RT3OMagComboBox.Enabled = false;
				formMain.RT3OFullPatchCheckBox.Enabled = false;
				formMain.RT3ODisplayMagCheckBox.Enabled = false;
				formMain.formMainNameTabPage.setValuesFromSelectedList();
				break;
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00108234 File Offset: 0x00107234
		private bool fromRT3InList(ListBox.SelectedIndexCollection coll)
		{
			try
			{
				foreach (object value in coll)
				{
					int num = Conversions.ToInteger(value);
					bool flag = num < MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList.Count && MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList[num].fromRT3;
					if (flag)
					{
						return true;
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
			return false;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x001082F0 File Offset: 0x001072F0
		private bool allFromRT3MapInList(ListBox.SelectedIndexCollection coll)
		{
			try
			{
				foreach (object value in coll)
				{
					int num = Conversions.ToInteger(value);
					bool flag = num < MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList.Count && !MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList[num].fromRT3Map;
					if (flag)
					{
						return false;
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
			return true;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x001083AC File Offset: 0x001073AC
		private bool isOneFromArchive(ListBox.SelectedIndexCollection coll)
		{
			try
			{
				foreach (object value in coll)
				{
					int num = Conversions.ToInteger(value);
					bool flag = num < MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList.Count && MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList[num].fromArchive;
					if (flag)
					{
						return true;
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
			return false;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00108468 File Offset: 0x00107468
		private bool allwaysLoadInList(ListBox.SelectedIndexCollection coll)
		{
			try
			{
				foreach (object value in coll)
				{
					int num = Conversions.ToInteger(value);
					bool flag = num < MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList.Count && (MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList[num].fromRT3Map || MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList[num].allwaysLoad);
					if (flag)
					{
						return false;
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
			return true;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00108550 File Offset: 0x00107550
		private bool isReadOnlyInList(ListBox.SelectedIndexCollection coll)
		{
			bool result;
			try
			{
				try
				{
					foreach (object value in coll)
					{
						int num = Conversions.ToInteger(value);
						bool flag = num < MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList.Count && MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList[num].isReadOnly;
						if (flag)
						{
							return true;
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
				result = false;
			}
			catch (Exception ex)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00108638 File Offset: 0x00107638
		private bool IsOneAddedInList(ListBox.SelectedIndexCollection coll)
		{
			bool result;
			try
			{
				try
				{
					foreach (object value in coll)
					{
						int num = Conversions.ToInteger(value);
						bool flag = num < MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList.Count && !MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList[num].fromRT3Map;
						if (flag)
						{
							return true;
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
				result = false;
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00108720 File Offset: 0x00107720
		private void startingState()
		{
			FormMain formMain = MyProject.Forms.FormMain;
			formMain.ConfigureF_ToolStripMenuItem.Enabled = false;
			formMain.Configure_ToolStripButton.Enabled = false;
			formMain.LoadMap_ToolStripMenuItem.Enabled = false;
			formMain.LoadMap_ToolStripButton.Enabled = false;
			formMain.Import_ToolStripMenuItem.Enabled = false;
			formMain.Import_ToolStripButton.Enabled = false;
			formMain.Patch_ToolStripMenuItem.Enabled = false;
			formMain.Patch_ToolStripButton.Enabled = false;
			formMain.ISO_ToolStripMenuItem.Enabled = false;
			formMain.ISO_ToolStripButton.Enabled = false;
			formMain.USB_ToolStripMenuItem.Enabled = false;
			formMain.USB_ToolStripButton.Enabled = false;
			formMain.Burn_ToolStripMenuItem.Enabled = false;
			formMain.Burn_ToolStripButton.Enabled = false;
			formMain.ImportedFilesPropertiesGroupBox.Enabled = false;
			formMain.ToolStripStatusLabelSatus.Text = Resources.strStatusStarting;
			this.setMode(Common.RTxMapEditorMapMode);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0010881C File Offset: 0x0010781C
		private void notLoadedState()
		{
			FormMain formMain = MyProject.Forms.FormMain;
			formMain.ConfigureF_ToolStripMenuItem.Enabled = true;
			formMain.Configure_ToolStripButton.Enabled = true;
			formMain.LoadMap_ToolStripMenuItem.Enabled = MySettingsProperty.Settings.configCompleteOnce;
			formMain.LoadMap_ToolStripButton.Enabled = MySettingsProperty.Settings.configCompleteOnce;
			formMain.ReloadMapWithAllPOIToolStripMenuItem.Enabled = MySettingsProperty.Settings.configComplete;
			formMain.Import_ToolStripMenuItem.Enabled = false;
			formMain.Import_ToolStripButton.Enabled = false;
			formMain.Patch_ToolStripMenuItem.Enabled = false;
			formMain.Patch_ToolStripButton.Enabled = false;
			formMain.ISO_ToolStripMenuItem.Enabled = false;
			formMain.ISO_ToolStripButton.Enabled = false;
			formMain.USB_ToolStripMenuItem.Enabled = false;
			formMain.USB_ToolStripButton.Enabled = false;
			formMain.Burn_ToolStripMenuItem.Enabled = false;
			formMain.Burn_ToolStripButton.Enabled = false;
			formMain.ImportedFilesPropertiesGroupBox.Enabled = false;
			this.setMode(Common.RTxMapEditorMapMode);
			bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map;
			if (flag)
			{
				bool flag2 = !MySettingsProperty.Settings.configCompleteOnce;
				if (flag2)
				{
					formMain.ToolStripStatusLabelSatus.Text = Resources.strStatusNotConfigured;
				}
				else
				{
					flag2 = (MyProject.Forms.FormMain.userSettings.lastLoadedMaps.getEntryNb() == 0);
					if (flag2)
					{
						formMain.ToolStripStatusLabelSatus.Text = Resources.strStatusNoMapLoaded;
					}
					else
					{
						formMain.ToolStripStatusLabelSatus.Text = Resources.strStatusNoMapLoaded;
					}
				}
			}
			else
			{
				formMain.ToolStripStatusLabelSatus.Text = "Error";
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x001089BC File Offset: 0x001079BC
		private void loadedState(int nb)
		{
			FormMain formMain = MyProject.Forms.FormMain;
			formMain.ConfigureF_ToolStripMenuItem.Enabled = true;
			formMain.Configure_ToolStripButton.Enabled = true;
			formMain.LoadMap_ToolStripMenuItem.Enabled = true;
			formMain.LoadMap_ToolStripButton.Enabled = true;
			formMain.ReloadMapWithAllPOIToolStripMenuItem.Enabled = true;
			formMain.Import_ToolStripMenuItem.Enabled = true;
			formMain.Import_ToolStripButton.Enabled = true;
			formMain.Patch_ToolStripMenuItem.Enabled = (MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList.Count > 0);
			formMain.Patch_ToolStripButton.Enabled = (MyProject.Forms.FormMain.mapMngt.importedPOIList.ListOfPOIList.Count > 0);
			formMain.ISO_ToolStripMenuItem.Enabled = false;
			formMain.ISO_ToolStripButton.Enabled = false;
			formMain.USB_ToolStripMenuItem.Enabled = false;
			formMain.USB_ToolStripButton.Enabled = false;
			formMain.Burn_ToolStripMenuItem.Enabled = false;
			formMain.Burn_ToolStripButton.Enabled = false;
			formMain.ImportedFilesPropertiesGroupBox.Enabled = true;
			this.setMode(Common.RTxMapEditorMapMode);
			formMain.ToolStripStatusLabelSatus.Text = string.Format(Resources.strStatusImported, nb);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00108B10 File Offset: 0x00107B10
		private void patchedState(int nb, Common.RTxMapType mapType)
		{
			FormMain formMain = MyProject.Forms.FormMain;
			formMain.LoadMap_ToolStripMenuItem.Enabled = true;
			formMain.LoadMap_ToolStripButton.Enabled = true;
			formMain.ReloadMapWithAllPOIToolStripMenuItem.Enabled = true;
			formMain.Import_ToolStripMenuItem.Enabled = true;
			formMain.Import_ToolStripButton.Enabled = true;
			formMain.Patch_ToolStripMenuItem.Enabled = true;
			formMain.Patch_ToolStripButton.Enabled = true;
			formMain.ISO_ToolStripMenuItem.Enabled = true;
			formMain.ISO_ToolStripButton.Enabled = true;
			formMain.USB_ToolStripMenuItem.Enabled = (mapType == Common.RTxMapType.RT4 | Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert);
			formMain.USB_ToolStripButton.Enabled = (mapType == Common.RTxMapType.RT4 | Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert);
			formMain.Burn_ToolStripMenuItem.Enabled = false;
			formMain.Burn_ToolStripButton.Enabled = false;
			formMain.ImportedFilesPropertiesGroupBox.Enabled = true;
			formMain.ToolStripStatusLabelSatus.Text = string.Format(Resources.strStatusPatched, nb);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00108C18 File Offset: 0x00107C18
		private void USBedState(int nb, Common.RTxMapType mapType)
		{
			FormMain formMain = MyProject.Forms.FormMain;
			formMain.LoadMap_ToolStripMenuItem.Enabled = true;
			formMain.LoadMap_ToolStripButton.Enabled = true;
			formMain.ReloadMapWithAllPOIToolStripMenuItem.Enabled = true;
			formMain.Import_ToolStripMenuItem.Enabled = true;
			formMain.Import_ToolStripButton.Enabled = true;
			formMain.Patch_ToolStripMenuItem.Enabled = true;
			formMain.Patch_ToolStripButton.Enabled = true;
			formMain.ISO_ToolStripMenuItem.Enabled = true;
			formMain.ISO_ToolStripButton.Enabled = true;
			formMain.USB_ToolStripMenuItem.Enabled = (mapType == Common.RTxMapType.RT4);
			formMain.USB_ToolStripButton.Enabled = (mapType == Common.RTxMapType.RT4);
			formMain.Burn_ToolStripMenuItem.Enabled = false;
			formMain.Burn_ToolStripButton.Enabled = false;
			formMain.ImportedFilesPropertiesGroupBox.Enabled = true;
			formMain.ToolStripStatusLabelSatus.Text = string.Format(Resources.strStatusUSBOK, nb);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00108D0C File Offset: 0x00107D0C
		private void ISOedState(int nb)
		{
			FormMain formMain = MyProject.Forms.FormMain;
			formMain.LoadMap_ToolStripMenuItem.Enabled = true;
			formMain.LoadMap_ToolStripButton.Enabled = true;
			formMain.ReloadMapWithAllPOIToolStripMenuItem.Enabled = true;
			formMain.Import_ToolStripMenuItem.Enabled = true;
			formMain.Import_ToolStripButton.Enabled = true;
			formMain.Patch_ToolStripMenuItem.Enabled = true;
			formMain.Patch_ToolStripButton.Enabled = true;
			formMain.ISO_ToolStripMenuItem.Enabled = true;
			formMain.ISO_ToolStripButton.Enabled = true;
			formMain.USB_ToolStripMenuItem.Enabled = true;
			formMain.USB_ToolStripButton.Enabled = true;
			formMain.Burn_ToolStripMenuItem.Enabled = true;
			formMain.Burn_ToolStripButton.Enabled = true;
			formMain.ImportedFilesPropertiesGroupBox.Enabled = true;
			formMain.ToolStripStatusLabelSatus.Text = string.Format(Resources.strStatusISOOK, nb);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00108DFC File Offset: 0x00107DFC
		private void burnedState(int nb)
		{
			FormMain formMain = MyProject.Forms.FormMain;
			formMain.LoadMap_ToolStripMenuItem.Enabled = true;
			formMain.LoadMap_ToolStripButton.Enabled = true;
			formMain.ReloadMapWithAllPOIToolStripMenuItem.Enabled = true;
			formMain.Import_ToolStripMenuItem.Enabled = true;
			formMain.Import_ToolStripButton.Enabled = true;
			formMain.Patch_ToolStripMenuItem.Enabled = true;
			formMain.Patch_ToolStripButton.Enabled = true;
			formMain.ISO_ToolStripMenuItem.Enabled = true;
			formMain.ISO_ToolStripButton.Enabled = true;
			formMain.USB_ToolStripMenuItem.Enabled = true;
			formMain.USB_ToolStripButton.Enabled = true;
			formMain.Burn_ToolStripMenuItem.Enabled = true;
			formMain.Burn_ToolStripButton.Enabled = true;
			formMain.ImportedFilesPropertiesGroupBox.Enabled = true;
			formMain.ToolStripStatusLabelSatus.Text = string.Format(Resources.strStatusBurned, nb);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00108EEC File Offset: 0x00107EEC
		public void changeState(WizardState.states newState)
		{
			bool flag = newState == WizardState.states.NOCHANGE;
			if (flag)
			{
				newState = this.state;
			}
			flag = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map && MyProject.Forms.FormMain.mapMngt.importedPOIList.totalPOINumber == 0);
			if (flag)
			{
				newState = WizardState.states.NOT_LOADED;
			}
			switch (newState)
			{
			case WizardState.states.NOT_LOADED:
				this.notLoadedState();
				break;
			case WizardState.states.LOADED:
				this.loadedState(MyProject.Forms.FormMain.mapMngt.importedPOIList.totalPOINumber);
				break;
			case WizardState.states.PATCHED:
				this.patchedState(MyProject.Forms.FormMain.mapMngt.importedPOIList.totalPOINumber, MyProject.Forms.FormMain.mapMngt.mapType);
				break;
			case WizardState.states.USBOK:
				this.USBedState(MyProject.Forms.FormMain.mapMngt.importedPOIList.totalPOINumber, MyProject.Forms.FormMain.mapMngt.mapType);
				break;
			case WizardState.states.ISOOK:
				this.ISOedState(MyProject.Forms.FormMain.mapMngt.importedPOIList.totalPOINumber);
				break;
			case WizardState.states.BURNED:
				this.burnedState(MyProject.Forms.FormMain.mapMngt.importedPOIList.totalPOINumber);
				break;
			default:
				Interaction.MsgBox(Resources.strErrWizardState, MsgBoxStyle.Critical, null);
				break;
			}
			this.UpdateMainFormGUI();
			this.state = newState;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0010906C File Offset: 0x0010806C
		public void OperationInProgress(string status)
		{
			FormMain formMain = MyProject.Forms.FormMain;
			formMain.MenuStrip.Enabled = false;
			formMain.ToolStrip.Enabled = false;
			this.setMode(Common.RTxMapEditorMapMode);
			formMain.ToolStripStatusLabelSatus.Text = status;
		}

		// Token: 0x04000417 RID: 1047
		private WizardState.states state;

		// Token: 0x04000418 RID: 1048
		private string strMode;

		// Token: 0x04000419 RID: 1049
		private string strStatusMode;

		// Token: 0x02000043 RID: 67
		public enum states
		{
			// Token: 0x0400041B RID: 1051
			STARTING,
			// Token: 0x0400041C RID: 1052
			NOT_LOADED,
			// Token: 0x0400041D RID: 1053
			LOADED,
			// Token: 0x0400041E RID: 1054
			PATCHED,
			// Token: 0x0400041F RID: 1055
			USBOK,
			// Token: 0x04000420 RID: 1056
			ISOOK,
			// Token: 0x04000421 RID: 1057
			BURNED,
			// Token: 0x04000422 RID: 1058
			NOCHANGE
		}
	}
}
