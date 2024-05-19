using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x02000033 RID: 51
	public class ConfigDialogExportTabPage
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x000FDA18 File Offset: 0x000FCA18
		public ConfigDialogExportTabPage(ConfigDialog configDialog)
		{
			this.sepListCsv = new ArrayList();
			this.decSepListCsv = new ArrayList();
			this.myConfigDialog = configDialog;
			ConfigDialog configDialog2 = this.myConfigDialog;
			this.sepListCsv.Add(new comboCharItems("tab", '\t'));
			this.sepListCsv.Add(new comboCharItems(";", ';'));
			this.sepListCsv.Add(new comboCharItems(",", ','));
			configDialog2.exportCsvSepComboBox.DataSource = new BindingSource(this.sepListCsv, null);
			configDialog2.exportCsvSepComboBox.DisplayMember = "display";
			configDialog2.exportCsvSepComboBox.ValueMember = "value";
			this.decSepListCsv.Add(new comboCharItems("Auto", '*'));
			this.decSepListCsv.Add(new comboCharItems(".", ';'));
			this.decSepListCsv.Add(new comboCharItems(",", ','));
			configDialog2.exportCsvDecSepComboBox.DataSource = new BindingSource(this.decSepListCsv, null);
			configDialog2.exportCsvDecSepComboBox.DisplayMember = "display";
			configDialog2.exportCsvDecSepComboBox.ValueMember = "value";
			configDialog2.exportAscRadioButton.CheckedChanged += this.exportAscRadioButton_CheckedChanged;
			configDialog2.exportCsvRadioButton.CheckedChanged += this.exportCsvRadioButton_CheckedChanged;
			configDialog2.exportTxtRadioButton.CheckedChanged += this.exportTxtRadioButton_CheckedChanged;
			configDialog2.exportKmlRadioButton.CheckedChanged += this.exportKmlRadioButton_CheckedChanged;
			configDialog2.exportLatCheckBox.CheckedChanged += this.exportLatCheckBox_CheckedChanged;
			configDialog2.exportLonCheckBox.CheckedChanged += this.exportLonCheckBox_CheckedChanged;
			configDialog2.exportNameCheckBox.CheckedChanged += this.exportNameCheckBox_CheckedChanged;
			configDialog2.exportAddressCheckBox.CheckedChanged += this.exportAddressCheckBox_CheckedChanged;
			configDialog2.exportCityCheckBox.CheckedChanged += this.exportCityCheckBox_CheckedChanged;
			configDialog2.exportCountryCheckBox.CheckedChanged += this.exportCountryCheckBox_CheckedChanged;
			configDialog2.exportTelCheckBox.CheckedChanged += this.exportTelCheckBox_CheckedChanged;
			configDialog2.exportCommentCheckBox.CheckedChanged += this.exportCommentCheckBox_CheckedChanged;
			configDialog2.exportBrandCheckBox.CheckedChanged += this.exportBrandCheckBox_CheckedChanged;
			configDialog2.exportFieldLatTextBox.TextChanged += this.exportFieldLatTextBox_TextChanged;
			configDialog2.exportFieldLonTextBox.TextChanged += this.exportFieldLonTextBox_TextChanged;
			configDialog2.exportFieldNameTextBox.TextChanged += this.exportFieldNameTextBox_TextChanged;
			configDialog2.exportFieldAddressTextBox.TextChanged += this.exportFieldAddressTextBox_TextChanged;
			configDialog2.exportFieldCityTextBox.TextChanged += this.exportFieldCityTextBox_TextChanged;
			configDialog2.exportFieldCountryTextBox.TextChanged += this.exportFieldCountryTextBox_TextChanged;
			configDialog2.exportFieldTelTextBox.TextChanged += this.exportFieldTelTextBox_TextChanged;
			configDialog2.exportFieldCommentTextBox.TextChanged += this.exportFieldCommentTextBox_TextChanged;
			configDialog2.exportFieldBrandTextBox.TextChanged += this.exportFieldBrandTextBox_TextChanged;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000FDD80 File Offset: 0x000FCD80
		public void showDialog()
		{
			ConfigDialog configDialog = this.myConfigDialog;
			this.exportFormat = checked((exportToFile.exportFormat)MySettingsProperty.Settings.exportFormat);
			switch (this.exportFormat)
			{
			case exportToFile.exportFormat.exportAsc:
				configDialog.exportAscRadioButton.Checked = true;
				break;
			case exportToFile.exportFormat.exportRT3:
				configDialog.exportTxtRadioButton.Checked = true;
				break;
			case exportToFile.exportFormat.exportCsv:
				configDialog.exportCsvRadioButton.Checked = true;
				break;
			case exportToFile.exportFormat.exportKml:
				configDialog.exportKmlRadioButton.Checked = true;
				break;
			}
			this.exportAddressAsc = MySettingsProperty.Settings.exportAddressAsc;
			this.exportCityAsc = MySettingsProperty.Settings.exportCityAsc;
			this.exportCountryAsc = MySettingsProperty.Settings.exportCountryAsc;
			this.exportTelAsc = MySettingsProperty.Settings.exportTelAsc;
			this.exportCommentAsc = MySettingsProperty.Settings.exportCommentAsc;
			this.exportBrandAsc = MySettingsProperty.Settings.exportBrandAsc;
			this.exportLatCsv = MySettingsProperty.Settings.exportLatCsv;
			this.exportLonCsv = MySettingsProperty.Settings.exportLonCsv;
			this.exportNameCsv = MySettingsProperty.Settings.exportNameCsv;
			this.exportAddressCsv = MySettingsProperty.Settings.exportAddressCsv;
			this.exportCityCsv = MySettingsProperty.Settings.exportCityCsv;
			this.exportCountryCsv = MySettingsProperty.Settings.exportCountryCsv;
			this.exportTelCsv = MySettingsProperty.Settings.exportTelCsv;
			this.exportCommentCsv = MySettingsProperty.Settings.exportCommentCsv;
			this.exportBrandCsv = MySettingsProperty.Settings.exportBrandCsv;
			this.exportFieldLatCsv = MySettingsProperty.Settings.exportFieldLatCsv;
			this.exportFieldLonCsv = MySettingsProperty.Settings.exportFieldLonCsv;
			this.exportFieldNameCsv = MySettingsProperty.Settings.exportFieldNameCsv;
			this.exportFieldAddressCsv = MySettingsProperty.Settings.exportFieldAddressCsv;
			this.exportFieldCityCsv = MySettingsProperty.Settings.exportFieldCityCsv;
			this.exportFieldCountryCsv = MySettingsProperty.Settings.exportFieldCountryCsv;
			this.exportFieldTelCsv = MySettingsProperty.Settings.exportFieldTelCsv;
			this.exportFieldCommentCsv = MySettingsProperty.Settings.exportFieldCommentCsv;
			this.exportFieldBrandCsv = MySettingsProperty.Settings.exportFieldBrandCsv;
			configDialog.ascExportIntSepTextBox.Text = MySettingsProperty.Settings.exportAscIntSeparator;
			configDialog.exportCsvSepComboBox.SelectedValue = Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt);
			configDialog.exportCsvDecSepComboBox.SelectedValue = Strings.ChrW(MySettingsProperty.Settings.exportDecSepCsvInt);
			this.updateGUI();
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000FDFE8 File Offset: 0x000FCFE8
		public void updateGUI()
		{
			ConfigDialog configDialog = this.myConfigDialog;
			switch (this.exportFormat)
			{
			case exportToFile.exportFormat.exportAsc:
				this.fieldExportEnable(exportToFile.exportFormat.exportAsc);
				configDialog.ascExpOptGroupBox.Enabled = true;
				configDialog.csvExpOptGroupBox.Enabled = false;
				configDialog.kmlExpOptGroupBox.Enabled = false;
				configDialog.exportRT3CheckBox.Visible = false;
				this.fieldNameVisible(false);
				this.fieldNameEnabled(false);
				configDialog.exportLatCheckBox.Checked = true;
				configDialog.exportLonCheckBox.Checked = true;
				configDialog.exportNameCheckBox.Checked = true;
				configDialog.exportAddressCheckBox.Checked = this.exportAddressAsc;
				configDialog.exportCityCheckBox.Checked = this.exportCityAsc;
				configDialog.exportCountryCheckBox.Checked = this.exportCountryAsc;
				configDialog.exportTelCheckBox.Checked = this.exportTelAsc;
				configDialog.exportCommentCheckBox.Checked = this.exportCommentAsc;
				configDialog.exportBrandCheckBox.Checked = this.exportBrandAsc;
				configDialog.exportRT3CheckBox.Checked = false;
				break;
			case exportToFile.exportFormat.exportRT3:
				this.fieldExportEnable(exportToFile.exportFormat.exportRT3);
				configDialog.ascExpOptGroupBox.Enabled = false;
				configDialog.csvExpOptGroupBox.Enabled = false;
				configDialog.kmlExpOptGroupBox.Enabled = false;
				configDialog.exportLatCheckBox.Checked = false;
				configDialog.exportLonCheckBox.Checked = false;
				configDialog.exportNameCheckBox.Checked = true;
				configDialog.exportAddressCheckBox.Checked = true;
				configDialog.exportCityCheckBox.Checked = true;
				configDialog.exportCountryCheckBox.Checked = true;
				configDialog.exportTelCheckBox.Checked = true;
				configDialog.exportCommentCheckBox.Checked = true;
				configDialog.exportBrandCheckBox.Checked = true;
				configDialog.exportRT3CheckBox.Checked = true;
				configDialog.exportRT3CheckBox.Visible = true;
				this.fieldNameVisible(true);
				this.fieldNameEnabled(false);
				configDialog.exportFieldLatTextBox.Text = MySettingsProperty.Settings.exportFieldLatTxt;
				configDialog.exportFieldLonTextBox.Text = MySettingsProperty.Settings.exportFieldLonTxt;
				configDialog.exportFieldNameTextBox.Text = MySettingsProperty.Settings.exportFieldNameTxt;
				configDialog.exportFieldAddressTextBox.Text = MySettingsProperty.Settings.exportFieldAddressTxt;
				configDialog.exportFieldCityTextBox.Text = MySettingsProperty.Settings.exportFieldCityTxt;
				configDialog.exportFieldCountryTextBox.Text = MySettingsProperty.Settings.exportFieldCountryTxt;
				configDialog.exportFieldTelTextBox.Text = MySettingsProperty.Settings.exportFieldTelTxt;
				configDialog.exportFieldCommentTextBox.Text = MySettingsProperty.Settings.exportFieldCommentTxt;
				configDialog.exportFieldBrandTextBox.Text = MySettingsProperty.Settings.exportFieldBrandTxt;
				break;
			case exportToFile.exportFormat.exportCsv:
				this.fieldExportEnable(exportToFile.exportFormat.exportCsv);
				configDialog.ascExpOptGroupBox.Enabled = false;
				configDialog.csvExpOptGroupBox.Enabled = true;
				configDialog.kmlExpOptGroupBox.Enabled = false;
				configDialog.exportLatCheckBox.Checked = this.exportLatCsv;
				configDialog.exportLonCheckBox.Checked = this.exportLonCsv;
				configDialog.exportNameCheckBox.Checked = this.exportNameCsv;
				configDialog.exportAddressCheckBox.Checked = this.exportAddressCsv;
				configDialog.exportCityCheckBox.Checked = this.exportCityCsv;
				configDialog.exportCountryCheckBox.Checked = this.exportCountryCsv;
				configDialog.exportTelCheckBox.Checked = this.exportTelCsv;
				configDialog.exportCommentCheckBox.Checked = this.exportCommentCsv;
				configDialog.exportBrandCheckBox.Checked = this.exportBrandCsv;
				configDialog.exportRT3CheckBox.Checked = false;
				configDialog.exportRT3CheckBox.Visible = false;
				this.fieldNameVisible(true);
				this.fieldNameEnabled(true);
				configDialog.exportFieldLatTextBox.Text = this.exportFieldLatCsv;
				configDialog.exportFieldLonTextBox.Text = this.exportFieldLonCsv;
				configDialog.exportFieldNameTextBox.Text = this.exportFieldNameCsv;
				configDialog.exportFieldAddressTextBox.Text = this.exportFieldAddressCsv;
				configDialog.exportFieldCityTextBox.Text = this.exportFieldCityCsv;
				configDialog.exportFieldCountryTextBox.Text = this.exportFieldCountryCsv;
				configDialog.exportFieldTelTextBox.Text = this.exportFieldTelCsv;
				configDialog.exportFieldCommentTextBox.Text = this.exportFieldCommentCsv;
				configDialog.exportFieldBrandTextBox.Text = this.exportFieldBrandCsv;
				break;
			case exportToFile.exportFormat.exportKml:
				this.fieldExportEnable(exportToFile.exportFormat.exportKml);
				configDialog.ascExpOptGroupBox.Enabled = false;
				configDialog.csvExpOptGroupBox.Enabled = false;
				configDialog.kmlExpOptGroupBox.Enabled = true;
				configDialog.exportRT3CheckBox.Visible = false;
				this.fieldNameVisible(false);
				this.fieldNameEnabled(false);
				break;
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000FE4A0 File Offset: 0x000FD4A0
		private void fieldExportEnable(exportToFile.exportFormat mode)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			switch (mode)
			{
			case exportToFile.exportFormat.exportAsc:
				this.fieldExportEnable(true);
				configDialog.exportLatCheckBox.Enabled = false;
				configDialog.exportLonCheckBox.Enabled = false;
				configDialog.exportNameCheckBox.Enabled = false;
				break;
			case exportToFile.exportFormat.exportRT3:
				this.fieldExportEnable(false);
				break;
			case exportToFile.exportFormat.exportCsv:
				this.fieldExportEnable(true);
				break;
			case exportToFile.exportFormat.exportKml:
				this.fieldExportEnable(true);
				configDialog.exportLatCheckBox.Enabled = false;
				configDialog.exportLonCheckBox.Enabled = false;
				configDialog.exportNameCheckBox.Enabled = false;
				break;
			}
			configDialog.exportRT3CheckBox.Enabled = false;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000FE55C File Offset: 0x000FD55C
		private void fieldExportEnable(bool enabled)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.exportLatCheckBox.Enabled = enabled;
			configDialog.exportLonCheckBox.Enabled = enabled;
			configDialog.exportNameCheckBox.Enabled = enabled;
			configDialog.exportAddressCheckBox.Enabled = enabled;
			configDialog.exportCityCheckBox.Enabled = enabled;
			configDialog.exportCountryCheckBox.Enabled = enabled;
			configDialog.exportTelCheckBox.Enabled = enabled;
			configDialog.exportCommentCheckBox.Enabled = enabled;
			configDialog.exportBrandCheckBox.Enabled = enabled;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000FE5EC File Offset: 0x000FD5EC
		private void fieldNameVisible(bool visible)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.exportFieldLatTextBox.Visible = visible;
			configDialog.exportFieldLonTextBox.Visible = visible;
			configDialog.exportFieldNameTextBox.Visible = visible;
			configDialog.exportFieldAddressTextBox.Visible = visible;
			configDialog.exportFieldCityTextBox.Visible = visible;
			configDialog.exportFieldCountryTextBox.Visible = visible;
			configDialog.exportFieldTelTextBox.Visible = visible;
			configDialog.exportFieldCommentTextBox.Visible = visible;
			configDialog.exportFieldBrandTextBox.Visible = visible;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000FE67C File Offset: 0x000FD67C
		private void fieldNameEnabled(bool enabled)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.exportFieldLatTextBox.Enabled = enabled;
			configDialog.exportFieldLonTextBox.Enabled = enabled;
			configDialog.exportFieldNameTextBox.Enabled = enabled;
			configDialog.exportFieldAddressTextBox.Enabled = enabled;
			configDialog.exportFieldCityTextBox.Enabled = enabled;
			configDialog.exportFieldCountryTextBox.Enabled = enabled;
			configDialog.exportFieldTelTextBox.Enabled = enabled;
			configDialog.exportFieldCommentTextBox.Enabled = enabled;
			configDialog.exportFieldBrandTextBox.Enabled = enabled;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000FE70C File Offset: 0x000FD70C
		private void saveExportedFields(exportToFile.exportFormat newExportFormat)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			switch (this.exportFormat)
			{
			case exportToFile.exportFormat.exportAsc:
				this.exportAddressAsc = configDialog.exportAddressCheckBox.Checked;
				this.exportCityAsc = configDialog.exportCityCheckBox.Checked;
				this.exportCountryAsc = configDialog.exportCountryCheckBox.Checked;
				this.exportTelAsc = configDialog.exportTelCheckBox.Checked;
				this.exportCommentAsc = configDialog.exportCommentCheckBox.Checked;
				this.exportBrandAsc = configDialog.exportBrandCheckBox.Checked;
				break;
			case exportToFile.exportFormat.exportCsv:
				this.exportLatCsv = configDialog.exportLatCheckBox.Checked;
				this.exportLonCsv = configDialog.exportLonCheckBox.Checked;
				this.exportNameCsv = configDialog.exportNameCheckBox.Checked;
				this.exportAddressCsv = configDialog.exportAddressCheckBox.Checked;
				this.exportCityCsv = configDialog.exportCityCheckBox.Checked;
				this.exportCountryCsv = configDialog.exportCountryCheckBox.Checked;
				this.exportTelCsv = configDialog.exportTelCheckBox.Checked;
				this.exportCommentCsv = configDialog.exportCommentCheckBox.Checked;
				this.exportBrandCsv = configDialog.exportBrandCheckBox.Checked;
				this.exportFieldLatCsv = configDialog.exportFieldLatTextBox.Text;
				this.exportFieldLonCsv = configDialog.exportFieldLonTextBox.Text;
				this.exportFieldNameCsv = configDialog.exportFieldNameTextBox.Text;
				this.exportFieldAddressCsv = configDialog.exportFieldAddressTextBox.Text;
				this.exportFieldCityCsv = configDialog.exportFieldCityTextBox.Text;
				this.exportFieldCountryCsv = configDialog.exportFieldCountryTextBox.Text;
				this.exportFieldTelCsv = configDialog.exportFieldTelTextBox.Text;
				this.exportFieldCommentCsv = configDialog.exportFieldCommentTextBox.Text;
				this.exportFieldBrandCsv = configDialog.exportFieldBrandTextBox.Text;
				break;
			}
			this.exportFormat = newExportFormat;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000FE8EC File Offset: 0x000FD8EC
		public void OK_Button_Click()
		{
			MySettingsProperty.Settings.exportFormat = checked((uint)this.exportFormat);
			MySettingsProperty.Settings.exportAddressAsc = this.exportAddressAsc;
			MySettingsProperty.Settings.exportCityAsc = this.exportCityAsc;
			MySettingsProperty.Settings.exportCountryAsc = this.exportCountryAsc;
			MySettingsProperty.Settings.exportTelAsc = this.exportTelAsc;
			MySettingsProperty.Settings.exportCommentAsc = this.exportCommentAsc;
			MySettingsProperty.Settings.exportBrandAsc = this.exportBrandAsc;
			MySettingsProperty.Settings.exportLatCsv = this.exportLatCsv;
			MySettingsProperty.Settings.exportLonCsv = this.exportLonCsv;
			MySettingsProperty.Settings.exportNameCsv = this.exportNameCsv;
			MySettingsProperty.Settings.exportAddressCsv = this.exportAddressCsv;
			MySettingsProperty.Settings.exportCityCsv = this.exportCityCsv;
			MySettingsProperty.Settings.exportCountryCsv = this.exportCountryCsv;
			MySettingsProperty.Settings.exportTelCsv = this.exportTelCsv;
			MySettingsProperty.Settings.exportCommentCsv = this.exportCommentCsv;
			MySettingsProperty.Settings.exportBrandCsv = this.exportBrandCsv;
			MySettingsProperty.Settings.exportFieldLatCsv = this.exportFieldLatCsv;
			MySettingsProperty.Settings.exportFieldLonCsv = this.exportFieldLonCsv;
			MySettingsProperty.Settings.exportFieldNameCsv = this.exportFieldNameCsv;
			MySettingsProperty.Settings.exportFieldAddressCsv = this.exportFieldAddressCsv;
			MySettingsProperty.Settings.exportFieldCityCsv = this.exportFieldCityCsv;
			MySettingsProperty.Settings.exportFieldCountryCsv = this.exportFieldCountryCsv;
			MySettingsProperty.Settings.exportFieldTelCsv = this.exportFieldTelCsv;
			MySettingsProperty.Settings.exportFieldCommentCsv = this.exportFieldCommentCsv;
			MySettingsProperty.Settings.exportFieldBrandCsv = this.exportFieldBrandCsv;
			ConfigDialog configDialog = this.myConfigDialog;
			MySettingsProperty.Settings.exportAscIntSeparator = configDialog.ascExportIntSepTextBox.Text;
			MySettingsProperty.Settings.exportCsvSepInt = (int)Conversions.ToChar(configDialog.exportCsvSepComboBox.SelectedValue);
			MySettingsProperty.Settings.exportDecSepCsvInt = (int)Conversions.ToChar(configDialog.exportCsvDecSepComboBox.SelectedValue);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x000FEAFC File Offset: 0x000FDAFC
		private void exportAscRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.saveExportedFields(exportToFile.exportFormat.exportAsc);
			this.updateGUI();
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x000FEB10 File Offset: 0x000FDB10
		private void exportTxtRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.saveExportedFields(exportToFile.exportFormat.exportRT3);
			this.updateGUI();
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000FEB24 File Offset: 0x000FDB24
		private void exportCsvRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.saveExportedFields(exportToFile.exportFormat.exportCsv);
			this.updateGUI();
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000FEB38 File Offset: 0x000FDB38
		private void exportKmlRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.saveExportedFields(exportToFile.exportFormat.exportKml);
			this.updateGUI();
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000FEB4C File Offset: 0x000FDB4C
		private void exportLatCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			exportToFile.exportFormat exportFormat = this.exportFormat;
			bool flag = exportFormat == exportToFile.exportFormat.exportCsv;
			if (flag)
			{
				this.exportLatCsv = configDialog.exportLatCheckBox.Checked;
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x000FEB88 File Offset: 0x000FDB88
		private void exportLonCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			exportToFile.exportFormat exportFormat = this.exportFormat;
			bool flag = exportFormat == exportToFile.exportFormat.exportCsv;
			if (flag)
			{
				this.exportLonCsv = configDialog.exportLonCheckBox.Checked;
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000FEBC4 File Offset: 0x000FDBC4
		private void exportNameCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			exportToFile.exportFormat exportFormat = this.exportFormat;
			bool flag = exportFormat == exportToFile.exportFormat.exportCsv;
			if (flag)
			{
				this.exportNameCsv = configDialog.exportNameCheckBox.Checked;
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000FEC00 File Offset: 0x000FDC00
		private void exportAddressCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			switch (this.exportFormat)
			{
			case exportToFile.exportFormat.exportAsc:
				this.exportAddressAsc = configDialog.exportAddressCheckBox.Checked;
				break;
			case exportToFile.exportFormat.exportCsv:
				this.exportAddressCsv = configDialog.exportAddressCheckBox.Checked;
				break;
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000FEC60 File Offset: 0x000FDC60
		private void exportCityCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			switch (this.exportFormat)
			{
			case exportToFile.exportFormat.exportAsc:
				this.exportCityAsc = configDialog.exportCityCheckBox.Checked;
				break;
			case exportToFile.exportFormat.exportCsv:
				this.exportCityCsv = configDialog.exportCityCheckBox.Checked;
				break;
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000FECC0 File Offset: 0x000FDCC0
		private void exportCountryCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			switch (this.exportFormat)
			{
			case exportToFile.exportFormat.exportAsc:
				this.exportCountryAsc = configDialog.exportCountryCheckBox.Checked;
				break;
			case exportToFile.exportFormat.exportCsv:
				this.exportCountryCsv = configDialog.exportCountryCheckBox.Checked;
				break;
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000FED20 File Offset: 0x000FDD20
		private void exportTelCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			switch (this.exportFormat)
			{
			case exportToFile.exportFormat.exportAsc:
				this.exportTelAsc = configDialog.exportTelCheckBox.Checked;
				break;
			case exportToFile.exportFormat.exportCsv:
				this.exportTelCsv = configDialog.exportTelCheckBox.Checked;
				break;
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000FED80 File Offset: 0x000FDD80
		private void exportCommentCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			switch (this.exportFormat)
			{
			case exportToFile.exportFormat.exportAsc:
				this.exportCommentAsc = configDialog.exportCommentCheckBox.Checked;
				break;
			case exportToFile.exportFormat.exportCsv:
				this.exportCommentCsv = configDialog.exportCommentCheckBox.Checked;
				break;
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000FEDE0 File Offset: 0x000FDDE0
		private void exportBrandCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			switch (this.exportFormat)
			{
			case exportToFile.exportFormat.exportAsc:
				this.exportBrandAsc = configDialog.exportBrandCheckBox.Checked;
				break;
			case exportToFile.exportFormat.exportCsv:
				this.exportBrandCsv = configDialog.exportBrandCheckBox.Checked;
				break;
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000FEE40 File Offset: 0x000FDE40
		private void exportFieldLatTextBox_TextChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			exportToFile.exportFormat exportFormat = this.exportFormat;
			bool flag = exportFormat == exportToFile.exportFormat.exportCsv;
			if (flag)
			{
				this.exportFieldLatCsv = configDialog.exportFieldLatTextBox.Text;
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000FEE7C File Offset: 0x000FDE7C
		private void exportFieldLonTextBox_TextChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			exportToFile.exportFormat exportFormat = this.exportFormat;
			bool flag = exportFormat == exportToFile.exportFormat.exportCsv;
			if (flag)
			{
				this.exportFieldLonCsv = configDialog.exportFieldLonTextBox.Text;
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000FEEB8 File Offset: 0x000FDEB8
		private void exportFieldNameTextBox_TextChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			exportToFile.exportFormat exportFormat = this.exportFormat;
			bool flag = exportFormat == exportToFile.exportFormat.exportCsv;
			if (flag)
			{
				this.exportFieldNameCsv = configDialog.exportFieldNameTextBox.Text;
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000FEEF4 File Offset: 0x000FDEF4
		private void exportFieldAddressTextBox_TextChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			exportToFile.exportFormat exportFormat = this.exportFormat;
			bool flag = exportFormat == exportToFile.exportFormat.exportCsv;
			if (flag)
			{
				this.exportFieldAddressCsv = configDialog.exportFieldAddressTextBox.Text;
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000FEF30 File Offset: 0x000FDF30
		private void exportFieldCityTextBox_TextChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			exportToFile.exportFormat exportFormat = this.exportFormat;
			bool flag = exportFormat == exportToFile.exportFormat.exportCsv;
			if (flag)
			{
				this.exportFieldCityCsv = configDialog.exportFieldCityTextBox.Text;
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000FEF6C File Offset: 0x000FDF6C
		private void exportFieldCountryTextBox_TextChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			exportToFile.exportFormat exportFormat = this.exportFormat;
			bool flag = exportFormat == exportToFile.exportFormat.exportCsv;
			if (flag)
			{
				this.exportFieldCountryCsv = configDialog.exportFieldCountryTextBox.Text;
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000FEFA8 File Offset: 0x000FDFA8
		private void exportFieldTelTextBox_TextChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			exportToFile.exportFormat exportFormat = this.exportFormat;
			bool flag = exportFormat == exportToFile.exportFormat.exportCsv;
			if (flag)
			{
				this.exportFieldTelCsv = configDialog.exportFieldTelTextBox.Text;
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000FEFE4 File Offset: 0x000FDFE4
		private void exportFieldCommentTextBox_TextChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			exportToFile.exportFormat exportFormat = this.exportFormat;
			bool flag = exportFormat == exportToFile.exportFormat.exportCsv;
			if (flag)
			{
				this.exportFieldCommentCsv = configDialog.exportFieldCommentTextBox.Text;
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000FF020 File Offset: 0x000FE020
		private void exportFieldBrandTextBox_TextChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			exportToFile.exportFormat exportFormat = this.exportFormat;
			bool flag = exportFormat == exportToFile.exportFormat.exportCsv;
			if (flag)
			{
				this.exportFieldBrandCsv = configDialog.exportFieldBrandTextBox.Text;
			}
		}

		// Token: 0x04000321 RID: 801
		private ConfigDialog myConfigDialog;

		// Token: 0x04000322 RID: 802
		private ArrayList sepListCsv;

		// Token: 0x04000323 RID: 803
		private ArrayList decSepListCsv;

		// Token: 0x04000324 RID: 804
		private exportToFile.exportFormat exportFormat;

		// Token: 0x04000325 RID: 805
		private bool exportAddressAsc;

		// Token: 0x04000326 RID: 806
		private bool exportCityAsc;

		// Token: 0x04000327 RID: 807
		private bool exportCountryAsc;

		// Token: 0x04000328 RID: 808
		private bool exportTelAsc;

		// Token: 0x04000329 RID: 809
		private bool exportCommentAsc;

		// Token: 0x0400032A RID: 810
		private bool exportBrandAsc;

		// Token: 0x0400032B RID: 811
		private bool exportLatCsv;

		// Token: 0x0400032C RID: 812
		private bool exportLonCsv;

		// Token: 0x0400032D RID: 813
		private bool exportNameCsv;

		// Token: 0x0400032E RID: 814
		private bool exportAddressCsv;

		// Token: 0x0400032F RID: 815
		private bool exportCityCsv;

		// Token: 0x04000330 RID: 816
		private bool exportCountryCsv;

		// Token: 0x04000331 RID: 817
		private bool exportTelCsv;

		// Token: 0x04000332 RID: 818
		private bool exportCommentCsv;

		// Token: 0x04000333 RID: 819
		private bool exportBrandCsv;

		// Token: 0x04000334 RID: 820
		private string exportFieldLatCsv;

		// Token: 0x04000335 RID: 821
		private string exportFieldLonCsv;

		// Token: 0x04000336 RID: 822
		private string exportFieldNameCsv;

		// Token: 0x04000337 RID: 823
		private string exportFieldAddressCsv;

		// Token: 0x04000338 RID: 824
		private string exportFieldCityCsv;

		// Token: 0x04000339 RID: 825
		private string exportFieldCountryCsv;

		// Token: 0x0400033A RID: 826
		private string exportFieldTelCsv;

		// Token: 0x0400033B RID: 827
		private string exportFieldCommentCsv;

		// Token: 0x0400033C RID: 828
		private string exportFieldBrandCsv;
	}
}
