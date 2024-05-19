using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x02000034 RID: 52
	public class ConfigDialogImportTabPage
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x000FF05C File Offset: 0x000FE05C
		public ConfigDialogImportTabPage(ConfigDialog configDialog, Common.RTxTypes RTxMapEditorMode)
		{
			this.sepList = new ArrayList();
			this.myConfigDialog = configDialog;
			this._RTxMapEditorMode = RTxMapEditorMode;
			ConfigDialog configDialog2 = this.myConfigDialog;
			this.sepList.Add(new comboCharItems("tab", '\t'));
			this.sepList.Add(new comboCharItems(";", ';'));
			this.sepList.Add(new comboCharItems(",", ','));
			configDialog2.importTxtSepComboBox.DataSource = new BindingSource(this.sepList, null);
			configDialog2.importTxtSepComboBox.DisplayMember = "display";
			configDialog2.importTxtSepComboBox.ValueMember = "value";
			typeComboBoxInit.init(configDialog2.importDefaultTypeComboBox);
			magComboBoxInit.init(configDialog2.importDefaultMagComboBox);
			configDialog2.importDefaultTypeComboBox.SelectedIndexChanged += this.STImportDefaultTypeComboBox_SelectedIndexChanged;
			bool flag;
			if (this._RTxMapEditorMode != Common.RTxTypes.typeRT4 && this._RTxMapEditorMode != Common.RTxTypes.typeRT5LR)
			{
				if (this._RTxMapEditorMode != Common.RTxTypes.typeRT5HR)
				{
					flag = false;
					goto IL_FC;
				}
			}
			flag = true;
			IL_FC:
			bool flag2 = flag;
			if (flag2)
			{
				configDialog2.changeRT3PerfArtsCheckBox.Enabled = false;
				configDialog2.changeRT3PerfArtsCheckBox.Checked = false;
				configDialog2.IgnoreRT3AltNameCheckBox.Enabled = false;
				configDialog2.IgnoreRT3AltNameCheckBox.Checked = false;
			}
			else
			{
				configDialog2.changeRT3PerfArtsCheckBox.Enabled = true;
				configDialog2.IgnoreRT3AltNameCheckBox.Enabled = true;
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000FF1C0 File Offset: 0x000FE1C0
		public void showDialog()
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.ascImportQuoteCheckBox.Checked = MySettingsProperty.Settings.importAscQuoted;
			configDialog.txtImportQuoteCheckBox.Checked = MySettingsProperty.Settings.importTxtQuoted;
			configDialog.importTxtSepComboBox.SelectedValue = Strings.ChrW(MySettingsProperty.Settings.importCsvSepInt);
			configDialog.importDefaultTypeComboBox.SelectedValue = MySettingsProperty.Settings.importDefaultType;
			configDialog.importDefaultMagComboBox.SelectedValue = MySettingsProperty.Settings.importDefaultMag;
			configDialog.importDefaultMagComboBox.Enabled = (Conversions.ToUShort(configDialog.importDefaultTypeComboBox.SelectedValue) == 4444);
			configDialog.importIncFormatCheckBox.Checked = MySettingsProperty.Settings.importErrIncFormat;
			configDialog.importIncCoordCheckBox.Checked = MySettingsProperty.Settings.importErrIncCoord;
			configDialog.ImportEmptyAreaCheckBox.Checked = MySettingsProperty.Settings.importErrEmptyArea;
			configDialog.importLogErrCheckBox.Checked = MySettingsProperty.Settings.importLogError;
			configDialog.ignoreRT3BorgateCheckBox.Checked = MySettingsProperty.Settings.ignoreRTxBorgate;
			configDialog.changeRT3EmbassyCheckBox.Checked = MySettingsProperty.Settings.changeRTxEmbassy;
			configDialog.changeRT3IndustCheckBox.Checked = MySettingsProperty.Settings.changeRTxIndustArea;
			configDialog.changeRT3BorderCheckBox.Checked = MySettingsProperty.Settings.changeRTxBorderCrossing;
			bool flag = this._RTxMapEditorMode == Common.RTxTypes.typeRT3;
			if (flag)
			{
				configDialog.changeRT3PerfArtsCheckBox.Checked = MySettingsProperty.Settings.changeRTxPerfArts;
				configDialog.IgnoreRT3AltNameCheckBox.Checked = MySettingsProperty.Settings.ignoreRTxAltName;
			}
			configDialog.changeRT3CivicCheckBox.Checked = MySettingsProperty.Settings.changeRTxCivicCenter;
			configDialog.changeRT3MedicServCheckBox.Checked = MySettingsProperty.Settings.changeRTxMedicServ;
			configDialog.changeRT3MotorbCheckBox.Checked = MySettingsProperty.Settings.changeRTxMotorb;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000FF3AC File Offset: 0x000FE3AC
		public void OK_Button_Click()
		{
			ConfigDialog configDialog = this.myConfigDialog;
			MySettingsProperty.Settings.importAscQuoted = configDialog.ascImportQuoteCheckBox.Checked;
			MySettingsProperty.Settings.importTxtQuoted = configDialog.txtImportQuoteCheckBox.Checked;
			MySettingsProperty.Settings.importCsvSepInt = (int)Conversions.ToChar(configDialog.importTxtSepComboBox.SelectedValue);
			MySettingsProperty.Settings.importDefaultType = Conversions.ToUShort(configDialog.importDefaultTypeComboBox.SelectedValue);
			MySettingsProperty.Settings.importDefaultMag = Conversions.ToByte(configDialog.importDefaultMagComboBox.SelectedValue);
			MySettingsProperty.Settings.importErrIncFormat = configDialog.importIncFormatCheckBox.Checked;
			MySettingsProperty.Settings.importErrIncCoord = configDialog.importIncCoordCheckBox.Checked;
			MySettingsProperty.Settings.importErrEmptyArea = configDialog.ImportEmptyAreaCheckBox.Checked;
			MySettingsProperty.Settings.importLogError = configDialog.importLogErrCheckBox.Checked;
			bool flag;
			if (MySettingsProperty.Settings.ignoreRTxAltName == configDialog.IgnoreRT3AltNameCheckBox.Checked && MySettingsProperty.Settings.ignoreRTxBorgate == configDialog.ignoreRT3BorgateCheckBox.Checked)
			{
				if (MySettingsProperty.Settings.changeRTxEmbassy == configDialog.changeRT3EmbassyCheckBox.Checked)
				{
					if (MySettingsProperty.Settings.changeRTxIndustArea == configDialog.changeRT3IndustCheckBox.Checked)
					{
						if (MySettingsProperty.Settings.changeRTxBorderCrossing == configDialog.changeRT3BorderCheckBox.Checked)
						{
							if (MySettingsProperty.Settings.changeRTxPerfArts == configDialog.changeRT3PerfArtsCheckBox.Checked)
							{
								if (MySettingsProperty.Settings.changeRTxCivicCenter == configDialog.changeRT3CivicCheckBox.Checked)
								{
									if (MySettingsProperty.Settings.changeRTxMedicServ == configDialog.changeRT3MedicServCheckBox.Checked)
									{
										if (MySettingsProperty.Settings.changeRTxMotorb == configDialog.changeRT3MotorbCheckBox.Checked)
										{
											flag = false;
											goto IL_1BE;
										}
									}
								}
							}
						}
					}
				}
			}
			flag = true;
			IL_1BE:
			bool flag2 = flag;
			if (flag2)
			{
				configDialog.reloadMap = true;
			}
			MySettingsProperty.Settings.ignoreRTxBorgate = configDialog.ignoreRT3BorgateCheckBox.Checked;
			MySettingsProperty.Settings.changeRTxEmbassy = configDialog.changeRT3EmbassyCheckBox.Checked;
			MySettingsProperty.Settings.changeRTxIndustArea = configDialog.changeRT3IndustCheckBox.Checked;
			MySettingsProperty.Settings.changeRTxBorderCrossing = configDialog.changeRT3BorderCheckBox.Checked;
			flag2 = (this._RTxMapEditorMode == Common.RTxTypes.typeRT3);
			if (flag2)
			{
				MySettingsProperty.Settings.ignoreRTxAltName = configDialog.IgnoreRT3AltNameCheckBox.Checked;
				MySettingsProperty.Settings.changeRTxPerfArts = configDialog.changeRT3PerfArtsCheckBox.Checked;
			}
			MySettingsProperty.Settings.changeRTxCivicCenter = configDialog.changeRT3CivicCheckBox.Checked;
			MySettingsProperty.Settings.changeRTxMedicServ = configDialog.changeRT3MedicServCheckBox.Checked;
			MySettingsProperty.Settings.changeRTxMotorb = configDialog.changeRT3MotorbCheckBox.Checked;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000FF65C File Offset: 0x000FE65C
		private void STImportDefaultTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.importDefaultPictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.importDefaultTypeComboBox.SelectedValue));
			configDialog.importDefaultMagComboBox.Enabled = (Conversions.ToUShort(configDialog.importDefaultTypeComboBox.SelectedValue) == 4444);
		}

		// Token: 0x0400033D RID: 829
		private ConfigDialog myConfigDialog;

		// Token: 0x0400033E RID: 830
		private ArrayList sepList;

		// Token: 0x0400033F RID: 831
		private Common.RTxTypes _RTxMapEditorMode;
	}
}
