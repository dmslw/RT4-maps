using System;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000035 RID: 53
	public class ConfigDialogNameTabPage
	{
		// Token: 0x060005A7 RID: 1447 RVA: 0x000FF6E4 File Offset: 0x000FE6E4
		public ConfigDialogNameTabPage(ConfigDialog configDialog)
		{
			this.myDisplayAttributes = new POIName.displayAttributes();
			this.myConfigDialog = configDialog;
			configDialog.gpspasUserDefNameTextBox.TextChanged += this.gpspasUserDefNameTextBox_TextChanged;
			configDialog.isGpsPasStartDisplayedCheckBox.CheckedChanged += this.isGpsPasStartDisplayedCheckBox_CheckedChanged;
			configDialog.isGpsPasTypeDisplayedCheckBox.CheckedChanged += this.isGpsPasTypeDisplayedCheckBox_CheckedChanged;
			configDialog.isGpsPasNumDisplayedCheckBox.CheckedChanged += this.isGpsPasNumDisplayedCheckBox_CheckedChanged;
			configDialog.isGpsPasRFRPostDisplayedCheckBox.CheckedChanged += this.isGpsPasRFRPostDisplayedCheckBox_CheckedChanged;
			configDialog.isGpsPasSep1DisplayedCheckBox.CheckedChanged += this.isGpsPasSep1DisplayedCheckBox_CheckedChanged;
			configDialog.isGpsPasSpeedDisplayedCheckBox.CheckedChanged += this.isGpsPasSpeedDisplayedCheckBox_CheckedChanged;
			configDialog.isGpsPasSpeedUnitDisplayedCheckBox.CheckedChanged += this.isGpsPasSpeedUnitDisplayedCheckBox_CheckedChanged;
			configDialog.isGpsPasSep2DisplayedCheckBox.CheckedChanged += this.isGpsPasSep2DisplayedCheckBox_CheckedChanged;
			configDialog.isGpsPasDirDisplayedCheckBox.CheckedChanged += this.isGpsPasDirDisplayedCheckBox_CheckedChanged;
			configDialog.isGpsPasMiscDisplayedCheckBox.CheckedChanged += this.isGpsPasMiscDisplayedCheckBox_CheckedChanged;
			configDialog.isGpsPasEndDisplayedCheckBox.CheckedChanged += this.isGpsPasEndDisplayedCheckBox_CheckedChanged;
			configDialog.gpspasPANTextBox.TextChanged += this.gpspasPANTextBox_TextChanged;
			configDialog.gpspasPLTextBox.TextChanged += this.gpspasPLTextBox_TextChanged;
			configDialog.gpspasRFTextBox.TextChanged += this.gpspasRFTextBox_TextChanged;
			configDialog.gpspasRMTextBox.TextChanged += this.gpspasRMTextBox_TextChanged;
			configDialog.gpspasRFRTextBox.TextChanged += this.gpspasRFRTextBox_TextChanged;
			configDialog.gpspasRDTextBox.TextChanged += this.gpspasRDTextBox_TextChanged;
			configDialog.gpspasTextTypeButton.Click += this.gpspasTextTypeButton_Click;
			configDialog.gpspasGraphTypeButton.Click += this.gpspasGraphTypeButton_Click;
			configDialog.gpspasSpeedUnitTextBox.TextChanged += this.gpspasSpeedTextBox_TextChanged;
			configDialog.gpspasFrontTextBox.TextChanged += this.gpspasFrontTextBox_TextChanged;
			configDialog.gpspasRearTextBox.TextChanged += this.gpspasRearTextBox_TextChanged;
			configDialog.gpspasUnkTextBox.TextChanged += this.gpspasUnkTextBox_TextChanged;
			configDialog.gpspasStartTextBox.TextChanged += this.gpspasStartTextBox_TextChanged;
			configDialog.gpspasEndTextBox.TextChanged += this.gpspasEndTextBox_TextChanged;
			configDialog.gpspasSep1TextBox.TextChanged += this.gpspasSep1TextBox_TextChanged;
			configDialog.gpspasSep2TextBox.TextChanged += this.gpspasSep2TextBox_TextChanged;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000FF9C8 File Offset: 0x000FE9C8
		public void showDialog()
		{
			ConfigDialog configDialog = this.myConfigDialog;
			this.myDisplayAttributes.nameDisplayMode = POIName.nameDisplayModes.gpsPassion;
			configDialog.gpspasUserDefNameTextBox.Text = MySettingsProperty.Settings.gpspasUserDefName;
			this.myDisplayAttributes.userDefinedName = MySettingsProperty.Settings.gpspasUserDefName;
			configDialog.isGpsPasStartDisplayedCheckBox.Checked = MySettingsProperty.Settings.isGpsPasStartDisplayed;
			this.myDisplayAttributes.isGpsPasStartDisplayed = MySettingsProperty.Settings.isGpsPasStartDisplayed;
			configDialog.isGpsPasTypeDisplayedCheckBox.Checked = MySettingsProperty.Settings.isGpsPasTypeDisplayed;
			this.myDisplayAttributes.isGpsPasTypeDisplayed = MySettingsProperty.Settings.isGpsPasTypeDisplayed;
			configDialog.isGpsPasNumDisplayedCheckBox.Checked = MySettingsProperty.Settings.isGpsPasNumDisplayed;
			this.myDisplayAttributes.isGpsPasNumDisplayed = MySettingsProperty.Settings.isGpsPasNumDisplayed;
			configDialog.isGpsPasRFRPostDisplayedCheckBox.Checked = MySettingsProperty.Settings.isGpsPasRFRPostDisplayed;
			this.myDisplayAttributes.isGpsPasRFRPostDisplayed = MySettingsProperty.Settings.isGpsPasRFRPostDisplayed;
			configDialog.isGpsPasSep1DisplayedCheckBox.Checked = MySettingsProperty.Settings.isGpsPasSep1Displayed;
			this.myDisplayAttributes.isGpsPasSep1Displayed = MySettingsProperty.Settings.isGpsPasSep1Displayed;
			configDialog.isGpsPasSpeedDisplayedCheckBox.Checked = MySettingsProperty.Settings.isGpsPasSpeedDisplayed;
			this.myDisplayAttributes.isGpsPasSpeedDisplayed = MySettingsProperty.Settings.isGpsPasSpeedDisplayed;
			configDialog.isGpsPasSpeedUnitDisplayedCheckBox.Checked = MySettingsProperty.Settings.isGpsPasSpeedUnitDisplayed;
			this.myDisplayAttributes.isGpsPasSpeedUnitDisplayed = MySettingsProperty.Settings.isGpsPasSpeedUnitDisplayed;
			configDialog.isGpsPasSep2DisplayedCheckBox.Checked = MySettingsProperty.Settings.isGpsPasSep2Displayed;
			this.myDisplayAttributes.isGpsPasSep2Displayed = MySettingsProperty.Settings.isGpsPasSep2Displayed;
			configDialog.isGpsPasDirDisplayedCheckBox.Checked = MySettingsProperty.Settings.isGpsPasDirDisplayed;
			this.myDisplayAttributes.isGpsPasDirDisplayed = MySettingsProperty.Settings.isGpsPasDirDisplayed;
			configDialog.isGpsPasMiscDisplayedCheckBox.Checked = MySettingsProperty.Settings.isGpsPasMiscDisplayed;
			this.myDisplayAttributes.isGpsPasMiscDisplayed = MySettingsProperty.Settings.isGpsPasMiscDisplayed;
			configDialog.isGpsPasEndDisplayedCheckBox.Checked = MySettingsProperty.Settings.isGpsPasEndDisplayed;
			this.myDisplayAttributes.isGpsPasEndDisplayed = MySettingsProperty.Settings.isGpsPasEndDisplayed;
			configDialog.gpspasPANTextBox.Text = MySettingsProperty.Settings.strGpsPasPAN;
			configDialog.gpspasPLTextBox.Text = MySettingsProperty.Settings.strGpsPasPL;
			configDialog.gpspasRFTextBox.Text = MySettingsProperty.Settings.strGpsPasRF;
			configDialog.gpspasRMTextBox.Text = MySettingsProperty.Settings.strGpsPasRM;
			configDialog.gpspasRFRTextBox.Text = MySettingsProperty.Settings.strGpsPasRFR;
			configDialog.gpspasRDTextBox.Text = MySettingsProperty.Settings.strGpsPasRD;
			configDialog.gpspasSpeedUnitTextBox.Text = MySettingsProperty.Settings.strGpsPasKMH;
			configDialog.gpspasFrontTextBox.Text = MySettingsProperty.Settings.strGpsPasF;
			configDialog.gpspasRearTextBox.Text = MySettingsProperty.Settings.strGpsPasR;
			configDialog.gpspasUnkTextBox.Text = MySettingsProperty.Settings.strGpsPasNC;
			configDialog.gpspasStartTextBox.Text = MySettingsProperty.Settings.strGpsPasStart;
			configDialog.gpspasEndTextBox.Text = MySettingsProperty.Settings.strGpsPasEnd;
			configDialog.gpspasSep1TextBox.Text = MySettingsProperty.Settings.strGpsPasSep1;
			configDialog.gpspasSep2TextBox.Text = MySettingsProperty.Settings.strGpsPasSep2;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x000FFD24 File Offset: 0x000FED24
		public void OK_Button_Click()
		{
			ConfigDialog configDialog = this.myConfigDialog;
			MySettingsProperty.Settings.gpspasUserDefName = configDialog.gpspasUserDefNameTextBox.Text;
			MySettingsProperty.Settings.isGpsPasStartDisplayed = configDialog.isGpsPasStartDisplayedCheckBox.Checked;
			MySettingsProperty.Settings.isGpsPasTypeDisplayed = configDialog.isGpsPasTypeDisplayedCheckBox.Checked;
			MySettingsProperty.Settings.isGpsPasNumDisplayed = configDialog.isGpsPasNumDisplayedCheckBox.Checked;
			MySettingsProperty.Settings.isGpsPasRFRPostDisplayed = configDialog.isGpsPasRFRPostDisplayedCheckBox.Checked;
			MySettingsProperty.Settings.isGpsPasSep1Displayed = configDialog.isGpsPasSep1DisplayedCheckBox.Checked;
			MySettingsProperty.Settings.isGpsPasSpeedDisplayed = configDialog.isGpsPasSpeedDisplayedCheckBox.Checked;
			MySettingsProperty.Settings.isGpsPasSpeedUnitDisplayed = configDialog.isGpsPasSpeedUnitDisplayedCheckBox.Checked;
			MySettingsProperty.Settings.isGpsPasSep2Displayed = configDialog.isGpsPasSep2DisplayedCheckBox.Checked;
			MySettingsProperty.Settings.isGpsPasDirDisplayed = configDialog.isGpsPasDirDisplayedCheckBox.Checked;
			MySettingsProperty.Settings.isGpsPasMiscDisplayed = configDialog.isGpsPasMiscDisplayedCheckBox.Checked;
			MySettingsProperty.Settings.isGpsPasEndDisplayed = configDialog.isGpsPasEndDisplayedCheckBox.Checked;
			MySettingsProperty.Settings.strGpsPasPAN = configDialog.gpspasPANTextBox.Text;
			MySettingsProperty.Settings.strGpsPasPL = configDialog.gpspasPLTextBox.Text;
			MySettingsProperty.Settings.strGpsPasRF = configDialog.gpspasRFTextBox.Text;
			MySettingsProperty.Settings.strGpsPasRM = configDialog.gpspasRMTextBox.Text;
			MySettingsProperty.Settings.strGpsPasRFR = configDialog.gpspasRFRTextBox.Text;
			MySettingsProperty.Settings.strGpsPasRD = configDialog.gpspasRDTextBox.Text;
			MySettingsProperty.Settings.strGpsPasKMH = configDialog.gpspasSpeedUnitTextBox.Text;
			MySettingsProperty.Settings.strGpsPasF = configDialog.gpspasFrontTextBox.Text;
			MySettingsProperty.Settings.strGpsPasR = configDialog.gpspasRearTextBox.Text;
			MySettingsProperty.Settings.strGpsPasNC = configDialog.gpspasUnkTextBox.Text;
			MySettingsProperty.Settings.strGpsPasStart = configDialog.gpspasStartTextBox.Text;
			MySettingsProperty.Settings.strGpsPasEnd = configDialog.gpspasEndTextBox.Text;
			MySettingsProperty.Settings.strGpsPasSep1 = configDialog.gpspasSep1TextBox.Text;
			MySettingsProperty.Settings.strGpsPasSep2 = configDialog.gpspasSep2TextBox.Text;
			MyProject.Forms.FormMain.userSettings.writeRTxModeDepSettings();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000FFF90 File Offset: 0x000FEF90
		private void gpspasUserDefNameTextBox_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000FFF94 File Offset: 0x000FEF94
		private void isGpsPasStartDisplayedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.myDisplayAttributes.isGpsPasStartDisplayed = this.myConfigDialog.isGpsPasStartDisplayedCheckBox.Checked;
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000FFFCC File Offset: 0x000FEFCC
		private void isGpsPasTypeDisplayedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.myDisplayAttributes.isGpsPasTypeDisplayed = this.myConfigDialog.isGpsPasTypeDisplayedCheckBox.Checked;
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00100004 File Offset: 0x000FF004
		private void isGpsPasNumDisplayedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.myDisplayAttributes.isGpsPasNumDisplayed = this.myConfigDialog.isGpsPasNumDisplayedCheckBox.Checked;
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0010003C File Offset: 0x000FF03C
		private void isGpsPasRFRPostDisplayedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.myDisplayAttributes.isGpsPasRFRPostDisplayed = this.myConfigDialog.isGpsPasRFRPostDisplayedCheckBox.Checked;
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00100074 File Offset: 0x000FF074
		private void isGpsPasSep1DisplayedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.myDisplayAttributes.isGpsPasSep1Displayed = this.myConfigDialog.isGpsPasSep1DisplayedCheckBox.Checked;
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x001000AC File Offset: 0x000FF0AC
		private void isGpsPasSpeedDisplayedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.myDisplayAttributes.isGpsPasSpeedDisplayed = this.myConfigDialog.isGpsPasSpeedDisplayedCheckBox.Checked;
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x001000E4 File Offset: 0x000FF0E4
		private void isGpsPasSpeedUnitDisplayedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.myDisplayAttributes.isGpsPasSpeedUnitDisplayed = this.myConfigDialog.isGpsPasSpeedUnitDisplayedCheckBox.Checked;
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0010011C File Offset: 0x000FF11C
		private void isGpsPasSep2DisplayedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.myDisplayAttributes.isGpsPasSep2Displayed = this.myConfigDialog.isGpsPasSep2DisplayedCheckBox.Checked;
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00100154 File Offset: 0x000FF154
		private void isGpsPasDirDisplayedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.myDisplayAttributes.isGpsPasDirDisplayed = this.myConfigDialog.isGpsPasDirDisplayedCheckBox.Checked;
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0010018C File Offset: 0x000FF18C
		private void isGpsPasMiscDisplayedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.myDisplayAttributes.isGpsPasMiscDisplayed = this.myConfigDialog.isGpsPasMiscDisplayedCheckBox.Checked;
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x001001C4 File Offset: 0x000FF1C4
		private void isGpsPasEndDisplayedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.myDisplayAttributes.isGpsPasEndDisplayed = this.myConfigDialog.isGpsPasEndDisplayedCheckBox.Checked;
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x001001FC File Offset: 0x000FF1FC
		private void gpspasPANTextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00100218 File Offset: 0x000FF218
		private void gpspasPLTextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00100234 File Offset: 0x000FF234
		private void gpspasRFTextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00100250 File Offset: 0x000FF250
		private void gpspasRMTextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0010026C File Offset: 0x000FF26C
		private void gpspasRFRTextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00100288 File Offset: 0x000FF288
		private void gpspasRDTextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x001002A4 File Offset: 0x000FF2A4
		private void gpspasTextTypeButton_Click(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map;
			if (flag)
			{
				configDialog.gpspasPANTextBox.Text = Resources.strGpsPasPANMap;
				configDialog.gpspasPLTextBox.Text = Resources.strGpsPasPLMap;
				configDialog.gpspasRFTextBox.Text = Resources.strGpsPasRFMap;
				configDialog.gpspasRMTextBox.Text = Resources.strGpsPasRMMap;
				configDialog.gpspasRFRTextBox.Text = Resources.strGpsPasRFRMap;
				configDialog.gpspasRDTextBox.Text = Resources.strGpsPasRDMap;
			}
			else
			{
				configDialog.gpspasPANTextBox.Text = Resources.strGpsPasPANAlert;
				configDialog.gpspasPLTextBox.Text = Resources.strGpsPasPLAlert;
				configDialog.gpspasRFTextBox.Text = Resources.strGpsPasRFAlert;
				configDialog.gpspasRMTextBox.Text = Resources.strGpsPasRMAlert;
				configDialog.gpspasRFRTextBox.Text = Resources.strGpsPasRFRAlert;
				configDialog.gpspasRDTextBox.Text = Resources.strGpsPasRDAlert;
			}
			configDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x001003AC File Offset: 0x000FF3AC
		private void gpspasGraphTypeButton_Click(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.gpspasPANTextBox.Text = "/=\\°";
			configDialog.gpspasPLTextBox.Text = "O=OO]°";
			configDialog.gpspasRFTextBox.Text = "[=]°";
			configDialog.gpspasRMTextBox.Text = "o=0]°";
			configDialog.gpspasRFRTextBox.Text = "¶°";
			configDialog.gpspasRDTextBox.Text = "<->°";
			configDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0010043C File Offset: 0x000FF43C
		private void gpspasSpeedTextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00100458 File Offset: 0x000FF458
		private void gpspasFrontTextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00100474 File Offset: 0x000FF474
		private void gpspasRearTextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00100490 File Offset: 0x000FF490
		private void gpspasUnkTextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x001004AC File Offset: 0x000FF4AC
		private void gpspasStartTextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x001004C8 File Offset: 0x000FF4C8
		private void gpspasEndTextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x001004E4 File Offset: 0x000FF4E4
		private void gpspasSep1TextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00100500 File Offset: 0x000FF500
		private void gpspasSep2TextBox_TextChanged(object sender, EventArgs e)
		{
			this.myConfigDialog.nameExampleValueLabel.Text = this.setExampleLabel();
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0010051C File Offset: 0x000FF51C
		private string translateGpspassionName(string origName)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Match match = ConfigDialogNameTabPage.regexGpsPassion.Match(origName);
			GroupCollection groups = match.Groups;
			string text = groups[1].ToString();
			string value = groups[2].ToString();
			string value2 = groups[3].ToString();
			string text2 = groups[4].ToString();
			string text3 = groups[5].ToString();
			string text4 = groups[6].ToString();
			string text5 = groups[7].ToString();
			ConfigDialog configDialog = this.myConfigDialog;
			bool flag = this.myDisplayAttributes.isGpsPasStartDisplayed;
			if (flag)
			{
				stringBuilder.Append(configDialog.gpspasStartTextBox.Text);
			}
			flag = this.myDisplayAttributes.isGpsPasTypeDisplayed;
			bool flag2;
			if (flag)
			{
				string left = text;
				flag2 = (Operators.CompareString(left, "PAN", false) == 0);
				if (flag2)
				{
					stringBuilder.Append(configDialog.gpspasPANTextBox.Text);
				}
				else
				{
					flag2 = (Operators.CompareString(left, "PL", false) == 0);
					if (flag2)
					{
						stringBuilder.Append(configDialog.gpspasPLTextBox.Text);
					}
					else
					{
						flag2 = (Operators.CompareString(left, "RD", false) == 0);
						if (flag2)
						{
							stringBuilder.Append(configDialog.gpspasRDTextBox.Text);
						}
						else
						{
							flag2 = (Operators.CompareString(left, "RF", false) == 0);
							if (flag2)
							{
								stringBuilder.Append(configDialog.gpspasRFTextBox.Text);
							}
							else
							{
								flag2 = (Operators.CompareString(left, "RFR", false) == 0);
								if (flag2)
								{
									stringBuilder.Append(configDialog.gpspasRFRTextBox.Text);
								}
								else
								{
									flag2 = (Operators.CompareString(left, "RM", false) == 0);
									if (flag2)
									{
										stringBuilder.Append(configDialog.gpspasRMTextBox.Text);
									}
								}
							}
						}
					}
				}
			}
			flag2 = this.myDisplayAttributes.isGpsPasNumDisplayed;
			if (flag2)
			{
				stringBuilder.Append(value);
			}
			flag2 = this.myDisplayAttributes.isGpsPasRFRPostDisplayed;
			if (flag2)
			{
				stringBuilder.Append(value2);
			}
			flag2 = (this.myDisplayAttributes.isGpsPasSep1Displayed && this.myDisplayAttributes.isGpsPasSpeedDisplayed && Operators.CompareString(text2, "", false) != 0);
			if (flag2)
			{
				stringBuilder.Append(configDialog.gpspasSep1TextBox.Text);
			}
			flag2 = this.myDisplayAttributes.isGpsPasSpeedDisplayed;
			if (flag2)
			{
				stringBuilder.Append(text2);
			}
			flag2 = (this.myDisplayAttributes.isGpsPasSpeedUnitDisplayed && this.myDisplayAttributes.isGpsPasSpeedDisplayed && Operators.CompareString(text2, "", false) != 0);
			if (flag2)
			{
				stringBuilder.Append(configDialog.gpspasSpeedUnitTextBox.Text);
			}
			flag2 = (this.myDisplayAttributes.isGpsPasSep2Displayed && this.myDisplayAttributes.isGpsPasDirDisplayed && Operators.CompareString(text4, "", false) != 0);
			if (flag2)
			{
				stringBuilder.Append(configDialog.gpspasSep2TextBox.Text);
			}
			flag2 = this.myDisplayAttributes.isGpsPasDirDisplayed;
			if (flag2)
			{
				string left2 = text4;
				flag = (Operators.CompareString(left2, "F", false) == 0);
				if (flag)
				{
					stringBuilder.Append(configDialog.gpspasFrontTextBox.Text);
				}
				else
				{
					flag2 = (Operators.CompareString(left2, "R", false) == 0);
					if (flag2)
					{
						stringBuilder.Append(configDialog.gpspasRearTextBox.Text);
					}
					else
					{
						flag2 = (Operators.CompareString(left2, "NC", false) == 0);
						if (flag2)
						{
							stringBuilder.Append(configDialog.gpspasUnkTextBox.Text);
						}
					}
				}
			}
			flag2 = (this.myDisplayAttributes.isGpsPasMiscDisplayed && Operators.CompareString(text5, "", false) != 0);
			if (flag2)
			{
				stringBuilder.Append(" ");
				stringBuilder.Append(text5);
			}
			flag2 = this.myDisplayAttributes.isGpsPasEndDisplayed;
			if (flag2)
			{
				stringBuilder.Append(configDialog.gpspasEndTextBox.Text);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00100974 File Offset: 0x000FF974
		public string setExampleLabel()
		{
			POIName.displayAttributes displayAttributes = this.myDisplayAttributes;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.translateGpspassionName("RFR088V Quai De Gesvres"));
			stringBuilder.Append(", ");
			stringBuilder.Append(this.translateGpspassionName("RF0602-090km/h-F"));
			stringBuilder.Append(", ");
			stringBuilder.Append(this.translateGpspassionName("RD012"));
			stringBuilder.Append(", ");
			stringBuilder.Append(this.translateGpspassionName("RM12050-050km/h"));
			stringBuilder.Append(", ");
			stringBuilder.Append(this.translateGpspassionName("PAN0298-070km/h-R"));
			stringBuilder.Append(", ");
			stringBuilder.Append(this.translateGpspassionName("PL0170-110km/h-F"));
			return stringBuilder.ToString();
		}

		// Token: 0x04000340 RID: 832
		private static Regex regexGpsPassion = new Regex("\\b(?<type>PAN|PL|RD|RF|RFR|RM)(?<num>\\d{3,5})(?<unk1>V)?-?(?<speed>\\d{3})?(?<km>km/h)?-?(?<dir>F|R)?(?<add>.*)?\\b", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace | RegexOptions.CultureInvariant);

		// Token: 0x04000341 RID: 833
		private ConfigDialog myConfigDialog;

		// Token: 0x04000342 RID: 834
		private POIName.displayAttributes myDisplayAttributes;
	}
}
