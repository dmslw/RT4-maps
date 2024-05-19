using System;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x0200003F RID: 63
	public class formMainNameTabPage
	{
		// Token: 0x060006F7 RID: 1783 RVA: 0x00106ED0 File Offset: 0x00105ED0
		public void load()
		{
			FormMain formMain = MyProject.Forms.FormMain;
			formMain.namedPlaceTabPage.Enter += this.namedPlaceTabPage_Enter;
			formMain.nameAsIsRadioButton.CheckedChanged += this.nameAsIsRadioButton_CheckedChanged;
			formMain.nameUserDefinedRadioButton.CheckedChanged += this.nameUserDefinedRadioButton_CheckedChanged;
			formMain.nameGpsPassionRadioButton.CheckedChanged += this.nameGpsPassionRadioButton_CheckedChanged;
			formMain.UserDefNameTextBox.TextChanged += this.userDefNameTextBox_Textchanged;
			formMain.isGpsPasStartDisplayedCheckBox.CheckedChanged += this.isGpsPasStartDisplayedCheckBox_checkedChanged;
			formMain.isGpsPasTypeDisplayedCheckBox.CheckedChanged += this.isGpsPasTypeDisplayedCheckBox_checkedChanged;
			formMain.isGpsPasNumDisplayedCheckBox.CheckedChanged += this.isGpsPasNumDisplayedCheckBox_checkedChanged;
			formMain.isGpsPasRFRPostDisplayedCheckBox.CheckedChanged += this.isGpsPasRFRPostDisplayedCheckBox_checkedChanged;
			formMain.isGpsPasSep1DisplayedCheckBox.CheckedChanged += this.isGpsPasSep1DisplayedCheckBox_checkedChanged;
			formMain.isGpsPasSpeedDisplayedCheckBox.CheckedChanged += this.isGpsPasSpeedDisplayedCheckBox_checkedChanged;
			formMain.isGpsPasSpeedUnitDisplayedCheckBox.CheckedChanged += this.isGpsPasSpeedUnitDisplayedCheckBox_checkedChanged;
			formMain.isGpsPasSep2DisplayedCheckBox.CheckedChanged += this.isGpsPasSep2DisplayedCheckBox_checkedChanged;
			formMain.isGpsPasDirDisplayedCheckBox.CheckedChanged += this.isGpsPasDirDisplayedCheckBox_checkedChanged;
			formMain.isGpsPasMiscDisplayedCheckBox.CheckedChanged += this.isGpsPasMiscDisplayedCheckBox_checkedChanged;
			formMain.isGpsPasEndDisplayedCheckBox.CheckedChanged += this.isGpsPasEndDisplayedCheckBox_checkedChanged;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0010707C File Offset: 0x0010607C
		private void namedPlaceTabPage_Enter(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.wizardState.UpdateMainFormGUI();
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00107098 File Offset: 0x00106098
		private void nameAsIsRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.UserDefNameTextBox.Enabled = false;
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.nameDisplayMode = POIName.nameDisplayModes.asIs;
			this.setExampleLabel();
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x001070D8 File Offset: 0x001060D8
		private void nameUserDefinedRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.UserDefNameTextBox.Enabled = true;
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.nameDisplayMode = POIName.nameDisplayModes.userDef;
			this.setExampleLabel();
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00107118 File Offset: 0x00106118
		private void nameGpsPassionRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.UserDefNameTextBox.Enabled = false;
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.nameDisplayMode = POIName.nameDisplayModes.gpsPassion;
			this.setExampleLabel();
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00107158 File Offset: 0x00106158
		private void userDefNameTextBox_Textchanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.userDefinedName = MyProject.Forms.FormMain.UserDefNameTextBox.Text;
			this.setExampleLabel();
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00107198 File Offset: 0x00106198
		private void isGpsPasStartDisplayedCheckBox_checkedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasStartDisplayed = MyProject.Forms.FormMain.isGpsPasStartDisplayedCheckBox.Checked;
			this.setExampleLabel();
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x001071D8 File Offset: 0x001061D8
		private void isGpsPasTypeDisplayedCheckBox_checkedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasTypeDisplayed = MyProject.Forms.FormMain.isGpsPasTypeDisplayedCheckBox.Checked;
			this.setExampleLabel();
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00107218 File Offset: 0x00106218
		private void isGpsPasNumDisplayedCheckBox_checkedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasNumDisplayed = MyProject.Forms.FormMain.isGpsPasNumDisplayedCheckBox.Checked;
			this.setExampleLabel();
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00107258 File Offset: 0x00106258
		private void isGpsPasRFRPostDisplayedCheckBox_checkedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasRFRPostDisplayed = MyProject.Forms.FormMain.isGpsPasRFRPostDisplayedCheckBox.Checked;
			this.setExampleLabel();
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00107298 File Offset: 0x00106298
		private void isGpsPasSep1DisplayedCheckBox_checkedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasSep1Displayed = MyProject.Forms.FormMain.isGpsPasSep1DisplayedCheckBox.Checked;
			this.setExampleLabel();
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x001072D8 File Offset: 0x001062D8
		private void isGpsPasSpeedDisplayedCheckBox_checkedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasSpeedDisplayed = MyProject.Forms.FormMain.isGpsPasSpeedDisplayedCheckBox.Checked;
			this.setExampleLabel();
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00107318 File Offset: 0x00106318
		private void isGpsPasSpeedUnitDisplayedCheckBox_checkedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasSpeedUnitDisplayed = MyProject.Forms.FormMain.isGpsPasSpeedUnitDisplayedCheckBox.Checked;
			this.setExampleLabel();
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00107358 File Offset: 0x00106358
		private void isGpsPasSep2DisplayedCheckBox_checkedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasSep2Displayed = MyProject.Forms.FormMain.isGpsPasSep2DisplayedCheckBox.Checked;
			this.setExampleLabel();
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00107398 File Offset: 0x00106398
		private void isGpsPasDirDisplayedCheckBox_checkedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasDirDisplayed = MyProject.Forms.FormMain.isGpsPasDirDisplayedCheckBox.Checked;
			this.setExampleLabel();
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x001073D8 File Offset: 0x001063D8
		private void isGpsPasMiscDisplayedCheckBox_checkedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasMiscDisplayed = MyProject.Forms.FormMain.isGpsPasMiscDisplayedCheckBox.Checked;
			this.setExampleLabel();
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00107418 File Offset: 0x00106418
		private void isGpsPasEndDisplayedCheckBox_checkedChanged(object sender, EventArgs e)
		{
			MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasEndDisplayed = MyProject.Forms.FormMain.isGpsPasEndDisplayedCheckBox.Checked;
			this.setExampleLabel();
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00107458 File Offset: 0x00106458
		public void setValuesFromSelectedList()
		{
			FormMain formMain = MyProject.Forms.FormMain;
			bool flag = formMain.selectedPOIList != null;
			if (flag)
			{
				formMain.namedPlaceTabPage.Enabled = ((!formMain.selectedPOIList.fromRT3 & formMain.selectedPOIList.type == 4444) | Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert);
				flag = (formMain.selectedPOIList.type == 4444);
				if (flag)
				{
					switch (formMain.selectedPOIList.getPOINameType())
					{
					case POIName.nameTypes.notChecked:
						formMain.nameAsIsRadioButton.Enabled = false;
						formMain.nameUserDefinedRadioButton.Enabled = false;
						formMain.nameGpsPassionRadioButton.Enabled = false;
						formMain.UserDefNameTextBox.Enabled = false;
						formMain.namegpspasFormatPanel.Enabled = false;
						break;
					case POIName.nameTypes.unknown:
						formMain.nameAsIsRadioButton.Enabled = true;
						formMain.nameUserDefinedRadioButton.Enabled = true;
						formMain.nameGpsPassionRadioButton.Enabled = false;
						formMain.UserDefNameTextBox.Enabled = true;
						formMain.namegpspasFormatPanel.Enabled = false;
						break;
					case POIName.nameTypes.gpspassion:
						formMain.nameAsIsRadioButton.Enabled = true;
						formMain.nameUserDefinedRadioButton.Enabled = true;
						formMain.nameGpsPassionRadioButton.Enabled = true;
						formMain.UserDefNameTextBox.Enabled = false;
						formMain.namegpspasFormatPanel.Enabled = true;
						break;
					case POIName.nameTypes.RT3:
						formMain.nameAsIsRadioButton.Enabled = false;
						formMain.nameUserDefinedRadioButton.Enabled = false;
						formMain.nameGpsPassionRadioButton.Enabled = false;
						formMain.UserDefNameTextBox.Enabled = false;
						formMain.namegpspasFormatPanel.Enabled = false;
						break;
					}
					this.setDisplayMode();
				}
				else
				{
					formMain.namedPlaceTabPage.Enabled = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert);
					this.setDisplayMode();
				}
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0010763C File Offset: 0x0010663C
		private void setDisplayMode()
		{
			FormMain formMain = MyProject.Forms.FormMain;
			switch (formMain.selectedPOIList.POIName.myDisplayAttributes.nameDisplayMode)
			{
			case POIName.nameDisplayModes.asIs:
				formMain.nameAsIsRadioButton.Checked = true;
				formMain.UserDefNameTextBox.Text = "";
				break;
			case POIName.nameDisplayModes.userDef:
				formMain.nameUserDefinedRadioButton.Checked = true;
				formMain.UserDefNameTextBox.Text = formMain.selectedPOIList.POIName.myDisplayAttributes.userDefinedName;
				break;
			case POIName.nameDisplayModes.gpsPassion:
				formMain.UserDefNameTextBox.Text = "";
				formMain.nameGpsPassionRadioButton.Checked = true;
				formMain.isGpsPasStartDisplayedCheckBox.Checked = formMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasStartDisplayed;
				formMain.isGpsPasTypeDisplayedCheckBox.Checked = formMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasTypeDisplayed;
				formMain.isGpsPasNumDisplayedCheckBox.Checked = formMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasNumDisplayed;
				formMain.isGpsPasRFRPostDisplayedCheckBox.Checked = formMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasRFRPostDisplayed;
				formMain.isGpsPasSep1DisplayedCheckBox.Checked = formMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasSep1Displayed;
				formMain.isGpsPasSpeedDisplayedCheckBox.Checked = formMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasSpeedDisplayed;
				formMain.isGpsPasSpeedUnitDisplayedCheckBox.Checked = formMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasSpeedUnitDisplayed;
				formMain.isGpsPasSep2DisplayedCheckBox.Checked = formMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasSep2Displayed;
				formMain.isGpsPasDirDisplayedCheckBox.Checked = formMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasDirDisplayed;
				formMain.isGpsPasMiscDisplayedCheckBox.Checked = formMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasMiscDisplayed;
				formMain.isGpsPasEndDisplayedCheckBox.Checked = formMain.selectedPOIList.POIName.myDisplayAttributes.isGpsPasEndDisplayed;
				break;
			}
			this.setExampleLabel();
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00107870 File Offset: 0x00106870
		private void setExampleLabel()
		{
			MyProject.Forms.FormMain.nameExampleValueLabel.Text = POIName.setExampleLabel(MyProject.Forms.FormMain.selectedPOIList.POIName.myDisplayAttributes);
		}
	}
}
