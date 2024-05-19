using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000036 RID: 54
	public class configDialogSTArchTabPage
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x00100A44 File Offset: 0x000FFA44
		public configDialogSTArchTabPage(ConfigDialog configDialog)
		{
			this.supportedModes = STArchives.ArchImportMode.none;
			this.supportedModesList = new ArrayList();
			this.myConfigDialog = configDialog;
			ConfigDialog configDialog2 = this.myConfigDialog;
			this.buildSupportedModesList(this.supportedModesList, STArchives.ArchImportMode.Allmodes);
			configDialog2.STImportModeComboBox.DataSource = new BindingSource(this.supportedModesList, null);
			configDialog2.STImportModeComboBox.DisplayMember = "display";
			configDialog2.STImportModeComboBox.ValueMember = "value";
			bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map;
			if (flag)
			{
				typeComboBoxInit.initWoNP(configDialog2.STImportAllTypeComboBox);
				typeComboBoxInit.initWoNP(configDialog2.STImportFixedTypeComboBox);
				typeComboBoxInit.initWoNP(configDialog2.STImportMobileTypeComboBox);
				typeComboBoxInit.initNPOnly(configDialog2.STImportAllNPTypeComboBox);
				typeComboBoxInit.initNPOnly(configDialog2.STImportFixedNPTypeComboBox);
				typeComboBoxInit.initNPOnly(configDialog2.STImportMobileNPTypeComboBox);
				typeComboBoxInit.init(configDialog2.STImportF120_130GTypeComboBox);
				typeComboBoxInit.init(configDialog2.STImportF100_119TypeComboBox);
				typeComboBoxInit.init(configDialog2.STImportF80_99TypeComboBox);
				typeComboBoxInit.init(configDialog2.STImport60_79TypeComboBox);
				typeComboBoxInit.init(configDialog2.STImportF0_59TypeComboBox);
				typeComboBoxInit.init(configDialog2.STImportM120_130TypeComboBox);
				typeComboBoxInit.init(configDialog2.STImportM100_119TypeComboBox);
				typeComboBoxInit.init(configDialog2.STImportM80_99TypeComboBox);
				typeComboBoxInit.init(configDialog2.STImportM60_79TypeComboBox);
				typeComboBoxInit.init(configDialog2.STImportM0_59TypeComboBox);
				typeComboBoxInit.init(configDialog2.STImportRFRTypeComboBox);
			}
			else
			{
				typeComboBoxInit.initAlert(configDialog2.STImportAllTypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportFixedTypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportMobileTypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportAllNPTypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportFixedNPTypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportMobileNPTypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportF120_130GTypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportF100_119TypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportF80_99TypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImport60_79TypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportF0_59TypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportM120_130TypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportM100_119TypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportM80_99TypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportM60_79TypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportM0_59TypeComboBox);
				typeComboBoxInit.initAlert(configDialog2.STImportRFRTypeComboBox);
			}
			magComboBoxInit.init(configDialog2.STImportAllMagComboBox);
			magComboBoxInit.init(configDialog2.STImportFixedMagComboBox);
			magComboBoxInit.init(configDialog2.STImportMobileMagComboBox);
			magComboBoxInit.init(configDialog2.STImportF120_130GMagComboBox);
			magComboBoxInit.init(configDialog2.STImportF100_119MagComboBox);
			magComboBoxInit.init(configDialog2.STImportF80_99MagComboBox);
			magComboBoxInit.init(configDialog2.STImportF60_79MagComboBox);
			magComboBoxInit.init(configDialog2.STImporF0_59MagComboBox);
			magComboBoxInit.init(configDialog2.STImportM120_130MagComboBox);
			magComboBoxInit.init(configDialog2.STImportM100_119MagComboBox);
			magComboBoxInit.init(configDialog2.STImportM80_99MagComboBox);
			magComboBoxInit.init(configDialog2.STImportM60_79MagComboBox);
			magComboBoxInit.init(configDialog2.STImportM0_59MagComboBox);
			magComboBoxInit.init(configDialog2.STImportRFRMagComboBox);
			configDialog2.STImportModeComboBox.SelectedIndexChanged += this.STImportModeComboBox_SelectedIndexChanged;
			configDialog2.STImportF120_130GCheckBox.CheckedChanged += this.STImportCheckBox_CheckedChanged;
			configDialog2.STImportF100_119CheckBox.CheckedChanged += this.STImportCheckBox_CheckedChanged;
			configDialog2.STImportF80_99CheckBox.CheckedChanged += this.STImportCheckBox_CheckedChanged;
			configDialog2.STImportF60_79CheckBox.CheckedChanged += this.STImportCheckBox_CheckedChanged;
			configDialog2.STImportF0_59CheckBox.CheckedChanged += this.STImportCheckBox_CheckedChanged;
			configDialog2.STImportM120_130CheckBox.CheckedChanged += this.STImportCheckBox_CheckedChanged;
			configDialog2.STImportM100_119CheckBox.CheckedChanged += this.STImportCheckBox_CheckedChanged;
			configDialog2.STImportM80_99CheckBox.CheckedChanged += this.STImportCheckBox_CheckedChanged;
			configDialog2.STImportM60_79CheckBox.CheckedChanged += this.STImportCheckBox_CheckedChanged;
			configDialog2.STImportM0_59CheckBox.CheckedChanged += this.STImportCheckBox_CheckedChanged;
			configDialog2.STImportRFRCheckBox.CheckedChanged += this.STImportCheckBox_CheckedChanged;
			configDialog2.STImportAllTypeComboBox.SelectedIndexChanged += this.STImportAllTypeComboBox_SelectedIndexChanged;
			configDialog2.STImportAllNPTypeComboBox.SelectedIndexChanged += this.STImportAllNPTypeComboBox_SelectedIndexChanged;
			configDialog2.STImportFixedTypeComboBox.SelectedIndexChanged += this.STImportFixedTypeComboBox_SelectedIndexChanged;
			configDialog2.STImportFixedNPTypeComboBox.SelectedIndexChanged += this.STImportFixedNPTypeComboBox_SelectedIndexChanged;
			configDialog2.STImportMobileTypeComboBox.SelectedIndexChanged += this.STImportMobileTypeComboBox_SelectedIndexChanged;
			configDialog2.STImportMobileNPTypeComboBox.SelectedIndexChanged += this.STImportMobileNPTypeComboBox_SelectedIndexChanged;
			configDialog2.STImportF120_130GTypeComboBox.SelectedIndexChanged += this.STImportF130GTypeComboBox_SelectedIndexChanged;
			configDialog2.STImportF100_119TypeComboBox.SelectedIndexChanged += this.STImportF110TypeComboBox_SelectedIndexChanged;
			configDialog2.STImportF80_99TypeComboBox.SelectedIndexChanged += this.STImportF90TypeComboBox_SelectedIndexChanged;
			configDialog2.STImport60_79TypeComboBox.SelectedIndexChanged += this.STImportF89_61TypeComboBox_SelectedIndexChanged;
			configDialog2.STImportF0_59TypeComboBox.SelectedIndexChanged += this.STImportF60_30TypeComboBox_SelectedIndexChanged;
			configDialog2.STImportM120_130TypeComboBox.SelectedIndexChanged += this.STImportM130TypeComboBox_SelectedIndexChanged;
			configDialog2.STImportM100_119TypeComboBox.SelectedIndexChanged += this.STImportM110TypeComboBox_SelectedIndexChanged;
			configDialog2.STImportM80_99TypeComboBox.SelectedIndexChanged += this.STImportM90TypeComboBox_SelectedIndexChanged;
			configDialog2.STImportM60_79TypeComboBox.SelectedIndexChanged += this.STImportM89_61TypeComboBox_SelectedIndexChanged;
			configDialog2.STImportM0_59TypeComboBox.SelectedIndexChanged += this.STImportM60_30TypeComboBox_SelectedIndexChanged;
			configDialog2.STImportRFRTypeComboBox.SelectedIndexChanged += this.STImportRFRTypeComboBox_SelectedIndexChanged;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00100FF4 File Offset: 0x000FFFF4
		public void showDialog(STArchives.ArchImportMode supportedModes, bool fixedOnly, bool RFR)
		{
			this.fixedOnly = fixedOnly;
			ConfigDialog configDialog = this.myConfigDialog;
			bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map;
			if (flag)
			{
				typeComboBoxInit.initWoNP(configDialog.STImportAllTypeComboBox);
				typeComboBoxInit.initWoNP(configDialog.STImportFixedTypeComboBox);
				typeComboBoxInit.initWoNP(configDialog.STImportMobileTypeComboBox);
				typeComboBoxInit.initNPOnly(configDialog.STImportAllNPTypeComboBox);
				typeComboBoxInit.initNPOnly(configDialog.STImportFixedNPTypeComboBox);
				typeComboBoxInit.initNPOnly(configDialog.STImportMobileNPTypeComboBox);
				typeComboBoxInit.init(configDialog.STImportF120_130GTypeComboBox);
				typeComboBoxInit.init(configDialog.STImportF100_119TypeComboBox);
				typeComboBoxInit.init(configDialog.STImportF80_99TypeComboBox);
				typeComboBoxInit.init(configDialog.STImport60_79TypeComboBox);
				typeComboBoxInit.init(configDialog.STImportF0_59TypeComboBox);
				typeComboBoxInit.init(configDialog.STImportM120_130TypeComboBox);
				typeComboBoxInit.init(configDialog.STImportM100_119TypeComboBox);
				typeComboBoxInit.init(configDialog.STImportM80_99TypeComboBox);
				typeComboBoxInit.init(configDialog.STImportM60_79TypeComboBox);
				typeComboBoxInit.init(configDialog.STImportM0_59TypeComboBox);
				typeComboBoxInit.init(configDialog.STImportRFRTypeComboBox);
			}
			else
			{
				typeComboBoxInit.initAlert(configDialog.STImportAllTypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportFixedTypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportMobileTypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportAllNPTypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportFixedNPTypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportMobileNPTypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportF120_130GTypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportF100_119TypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportF80_99TypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImport60_79TypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportF0_59TypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportM120_130TypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportM100_119TypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportM80_99TypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportM60_79TypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportM0_59TypeComboBox);
				typeComboBoxInit.initAlert(configDialog.STImportRFRTypeComboBox);
			}
			this.buildSupportedModesList(this.supportedModesList, supportedModes);
			STArchives.ArchImportMode stimportMode = (STArchives.ArchImportMode)MySettingsProperty.Settings.STImportMode;
			flag = ((ulong)(stimportMode & supportedModes) == 0UL);
			if (flag)
			{
				this.myConfigDialog.STImportModeComboBox.SelectedIndex = 0;
			}
			else
			{
				this.myConfigDialog.STImportModeComboBox.SelectedValue = (STArchives.ArchImportMode)MySettingsProperty.Settings.STImportMode;
			}
			ConfigDialog configDialog2 = this.myConfigDialog;
			configDialog2.STImportAllCheckBox.Checked = MySettingsProperty.Settings.STimportAll;
			configDialog2.STImportAllTypeComboBox.SelectedValue = MySettingsProperty.Settings.STimportAllType;
			configDialog2.STImportAllNPTypeComboBox.SelectedValue = 4444;
			configDialog2.STImportAllNPTypeComboBox.Enabled = false;
			this.STImportAllTypeIsNP = MySettingsProperty.Settings.STImportAllTypeIsNP;
			configDialog2.STImportAllMagComboBox.SelectedValue = MySettingsProperty.Settings.STimportAllMag;
			configDialog2.STImportFixedCheckBox.Checked = MySettingsProperty.Settings.STimportFixed;
			configDialog2.STImportFixedTypeComboBox.SelectedValue = MySettingsProperty.Settings.STimportFixedType;
			configDialog2.STImportFixedNPTypeComboBox.SelectedValue = 4444;
			configDialog2.STImportFixedNPTypeComboBox.Enabled = false;
			this.STImportFixedTypeIsNP = MySettingsProperty.Settings.STImportFixedTypeIsNP;
			configDialog2.STImportFixedMagComboBox.SelectedValue = MySettingsProperty.Settings.STImportFixedMag;
			configDialog2.STImportMobileCheckBox.Checked = MySettingsProperty.Settings.STimportMobile;
			configDialog2.STImportMobileTypeComboBox.SelectedValue = MySettingsProperty.Settings.STimportMobileType;
			configDialog2.STImportMobileNPTypeComboBox.SelectedValue = 4444;
			configDialog2.STImportMobileNPTypeComboBox.Enabled = false;
			this.STImportMobileTypeIsNP = MySettingsProperty.Settings.STImportMobileTypeIsNP;
			configDialog2.STImportMobileMagComboBox.SelectedValue = MySettingsProperty.Settings.STimportMobileMag;
			configDialog2.STImportF120_130GCheckBox.Checked = MySettingsProperty.Settings.STImportF120_130G;
			configDialog2.STImportF120_130GTypeComboBox.SelectedValue = MySettingsProperty.Settings.STImportF120_130GType;
			configDialog2.STImportF120_130GMagComboBox.SelectedValue = MySettingsProperty.Settings.STImportF120_130GMag;
			configDialog2.STImportF100_119CheckBox.Checked = MySettingsProperty.Settings.STImportF100_119;
			configDialog2.STImportF100_119TypeComboBox.SelectedValue = MySettingsProperty.Settings.STImportF100_119Type;
			configDialog2.STImportF100_119MagComboBox.SelectedValue = MySettingsProperty.Settings.STImportF100_119Mag;
			configDialog2.STImportF80_99CheckBox.Checked = MySettingsProperty.Settings.STImportF80_99;
			configDialog2.STImportF80_99TypeComboBox.SelectedValue = MySettingsProperty.Settings.STImportF80_99Type;
			configDialog2.STImportF80_99MagComboBox.SelectedValue = MySettingsProperty.Settings.STImportF80_99Mag;
			configDialog2.STImportF60_79CheckBox.Checked = MySettingsProperty.Settings.STImportF60_79;
			configDialog2.STImport60_79TypeComboBox.SelectedValue = MySettingsProperty.Settings.STImportF60_79Type;
			configDialog2.STImportF60_79MagComboBox.SelectedValue = MySettingsProperty.Settings.STImportF60_79Mag;
			configDialog2.STImportF0_59CheckBox.Checked = MySettingsProperty.Settings.STImportF0_59;
			configDialog2.STImportF0_59TypeComboBox.SelectedValue = MySettingsProperty.Settings.STImportF0_59Type;
			configDialog2.STImporF0_59MagComboBox.SelectedValue = MySettingsProperty.Settings.STImportF0_59Mag;
			configDialog2.STImportM120_130CheckBox.Enabled = !fixedOnly;
			configDialog2.STImportM120_130CheckBox.Checked = (MySettingsProperty.Settings.STImportM120_130 & !fixedOnly);
			configDialog2.STImportM120_130TypeComboBox.SelectedValue = MySettingsProperty.Settings.STImportM120_130Type;
			configDialog2.STImportM120_130MagComboBox.SelectedValue = MySettingsProperty.Settings.STImportM120_130Mag;
			configDialog2.STImportM100_119CheckBox.Enabled = !fixedOnly;
			configDialog2.STImportM100_119CheckBox.Checked = (MySettingsProperty.Settings.STImportM100_119 & !fixedOnly);
			configDialog2.STImportM100_119TypeComboBox.SelectedValue = MySettingsProperty.Settings.STImportM100_119Type;
			configDialog2.STImportM100_119MagComboBox.SelectedValue = MySettingsProperty.Settings.STImportM100_119Mag;
			configDialog2.STImportM80_99CheckBox.Enabled = !fixedOnly;
			configDialog2.STImportM80_99CheckBox.Checked = (MySettingsProperty.Settings.STImportM80_99 & !fixedOnly);
			configDialog2.STImportM80_99TypeComboBox.SelectedValue = MySettingsProperty.Settings.STImportM80_99Type;
			configDialog2.STImportM80_99MagComboBox.SelectedValue = MySettingsProperty.Settings.STImportM80_99Mag;
			configDialog2.STImportM60_79CheckBox.Enabled = !fixedOnly;
			configDialog2.STImportM60_79CheckBox.Checked = (MySettingsProperty.Settings.STImportM60_79 & !fixedOnly);
			configDialog2.STImportM60_79TypeComboBox.SelectedValue = MySettingsProperty.Settings.STImportM60_79Type;
			configDialog2.STImportM60_79MagComboBox.SelectedValue = MySettingsProperty.Settings.STImportM60_79Mag;
			configDialog2.STImportM0_59CheckBox.Enabled = !fixedOnly;
			configDialog2.STImportM0_59CheckBox.Checked = (MySettingsProperty.Settings.STImportM0_59 & !fixedOnly);
			configDialog2.STImportM0_59TypeComboBox.SelectedValue = MySettingsProperty.Settings.STImportM0_59Type;
			configDialog2.STImportM0_59MagComboBox.SelectedValue = MySettingsProperty.Settings.STImportM0_59Mag;
			configDialog2.STImportRFRCheckBox.Enabled = RFR;
			configDialog2.STImportRFRCheckBox.Checked = MySettingsProperty.Settings.STImportRFR;
			configDialog2.STImportRFRTypeComboBox.SelectedValue = MySettingsProperty.Settings.STImportRFRType;
			configDialog2.STImportRFRMagComboBox.SelectedValue = MySettingsProperty.Settings.STImportRFRMag;
			this.updateGUI();
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00101764 File Offset: 0x00100764
		public void updateGUI()
		{
			ConfigDialog configDialog = this.myConfigDialog;
			STArchives.ArchImportMode archImportMode = (STArchives.ArchImportMode)Conversions.ToUInteger(configDialog.STImportModeComboBox.SelectedValue);
			STArchives.ArchImportMode archImportMode2 = archImportMode;
			bool flag = archImportMode2 == STArchives.ArchImportMode.ALLIcon;
			if (flag)
			{
				this.allUpdateGUI(true, false);
				this.fixedUpdateGUI(false, false);
				this.mobileUpdateGUI(false, false);
				this.cumstomUpdateGUI(false, false);
			}
			else
			{
				flag = (archImportMode2 == STArchives.ArchImportMode.AllText);
				if (flag)
				{
					this.allUpdateGUI(true, true);
					this.fixedUpdateGUI(false, false);
					this.mobileUpdateGUI(false, false);
					this.cumstomUpdateGUI(false, false);
				}
				else
				{
					flag = (archImportMode2 == STArchives.ArchImportMode.AllRFIcon);
					if (flag)
					{
						this.allUpdateGUI(false, false);
						this.fixedUpdateGUI(true, false);
						this.mobileUpdateGUI(false, false);
						this.cumstomUpdateGUI(false, false);
					}
					else
					{
						flag = (archImportMode2 == STArchives.ArchImportMode.AllRFText);
						if (flag)
						{
							this.allUpdateGUI(false, false);
							this.fixedUpdateGUI(true, true);
							this.mobileUpdateGUI(false, false);
							this.cumstomUpdateGUI(false, false);
						}
						else
						{
							flag = (archImportMode2 == STArchives.ArchImportMode.AllRMIcon);
							if (flag)
							{
								this.allUpdateGUI(false, false);
								this.fixedUpdateGUI(false, false);
								this.mobileUpdateGUI(true, false);
								this.cumstomUpdateGUI(false, false);
							}
							else
							{
								flag = (archImportMode2 == STArchives.ArchImportMode.AllRMText);
								if (flag)
								{
									this.allUpdateGUI(false, false);
									this.fixedUpdateGUI(false, false);
									this.mobileUpdateGUI(true, true);
									this.cumstomUpdateGUI(false, false);
								}
								else
								{
									flag = (archImportMode2 == STArchives.ArchImportMode.AllRFIconRMText);
									if (flag)
									{
										this.allUpdateGUI(false, false);
										this.fixedUpdateGUI(true, false);
										this.mobileUpdateGUI(true, true);
										this.cumstomUpdateGUI(false, false);
									}
									else
									{
										flag = (archImportMode2 == STArchives.ArchImportMode.AllRFTextRMIcon);
										if (flag)
										{
											this.allUpdateGUI(false, false);
											this.fixedUpdateGUI(true, true);
											this.mobileUpdateGUI(true, false);
											this.cumstomUpdateGUI(false, false);
										}
										else
										{
											flag = (archImportMode2 == STArchives.ArchImportMode.AllRFIconRMIcon);
											if (flag)
											{
												this.allUpdateGUI(false, false);
												this.fixedUpdateGUI(true, false);
												this.mobileUpdateGUI(true, false);
												this.cumstomUpdateGUI(false, false);
											}
											else
											{
												flag = (archImportMode2 == STArchives.ArchImportMode.AllRFTextRMText);
												if (flag)
												{
													this.allUpdateGUI(false, false);
													this.fixedUpdateGUI(true, true);
													this.mobileUpdateGUI(true, true);
													this.cumstomUpdateGUI(false, false);
												}
												else
												{
													flag = (archImportMode2 == STArchives.ArchImportMode.Custom);
													if (flag)
													{
														this.allUpdateGUI(false, false);
														this.fixedUpdateGUI(false, false);
														this.mobileUpdateGUI(false, false);
														this.cumstomUpdateGUI(true, true);
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x001019C0 File Offset: 0x001009C0
		private void allUpdateGUI(bool visible, bool text)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportAllLabel.Visible = visible;
			configDialog.STImportAllCheckBox.Visible = visible;
			configDialog.STImportAllCheckBox.Checked = true;
			configDialog.STImportAllCheckBox.Enabled = false;
			configDialog.STImportAllPictureBox.Visible = visible;
			this.STImportAllTypeIsNP = text;
			if (text)
			{
				configDialog.STImportAllTypeComboBox.Visible = false;
				configDialog.STImportAllNPTypeComboBox.Visible = visible;
				this.STImportAllNPTypeComboBox_SelectedIndexChanged(null, null);
			}
			else
			{
				configDialog.STImportAllTypeComboBox.Visible = visible;
				this.STImportAllTypeComboBox_SelectedIndexChanged(null, null);
				configDialog.STImportAllNPTypeComboBox.Visible = false;
			}
			configDialog.STImportAllMagComboBox.Visible = text;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00101A7C File Offset: 0x00100A7C
		private void fixedUpdateGUI(bool visible, bool text)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportFixedLabel.Visible = visible;
			configDialog.STImportFixedCheckBox.Visible = visible;
			configDialog.STImportFixedCheckBox.Checked = true;
			configDialog.STImportFixedCheckBox.Enabled = false;
			configDialog.STImportFixedPictureBox.Visible = visible;
			this.STImportFixedTypeIsNP = text;
			if (text)
			{
				configDialog.STImportFixedTypeComboBox.Visible = false;
				configDialog.STImportFixedNPTypeComboBox.Visible = visible;
				this.STImportFixedNPTypeComboBox_SelectedIndexChanged(null, null);
			}
			else
			{
				configDialog.STImportFixedTypeComboBox.Visible = visible;
				this.STImportFixedTypeComboBox_SelectedIndexChanged(null, null);
				configDialog.STImportFixedNPTypeComboBox.Visible = false;
			}
			configDialog.STImportFixedMagComboBox.Visible = text;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00101B38 File Offset: 0x00100B38
		private void mobileUpdateGUI(bool visible, bool text)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportMobileLabel.Visible = visible;
			configDialog.STImportMobileCheckBox.Visible = visible;
			configDialog.STImportMobileCheckBox.Checked = true;
			configDialog.STImportMobileCheckBox.Enabled = false;
			configDialog.STImportMobilePictureBox.Visible = visible;
			this.STImportMobileTypeIsNP = text;
			if (text)
			{
				configDialog.STImportMobileTypeComboBox.Visible = false;
				configDialog.STImportMobileNPTypeComboBox.Visible = visible;
				this.STImportMobileNPTypeComboBox_SelectedIndexChanged(null, null);
			}
			else
			{
				configDialog.STImportMobileTypeComboBox.Visible = visible;
				this.STImportMobileTypeComboBox_SelectedIndexChanged(null, null);
				configDialog.STImportMobileNPTypeComboBox.Visible = false;
			}
			configDialog.STImportMobileMagComboBox.Visible = text;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00101BF4 File Offset: 0x00100BF4
		private void cumstomUpdateGUI(bool visible, bool text)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportF120_130GLabel.Visible = visible;
			configDialog.STImportF120_130GCheckBox.Visible = visible;
			configDialog.STImportF120_130GPictureBox.Visible = (visible & configDialog.STImportF120_130GCheckBox.Checked);
			configDialog.STImportF120_130GTypeComboBox.Visible = (visible & configDialog.STImportF120_130GCheckBox.Checked);
			configDialog.STImportF120_130GMagComboBox.Visible = (text & configDialog.STImportF120_130GCheckBox.Checked & Conversions.ToUShort(configDialog.STImportF120_130GTypeComboBox.SelectedValue) == 4444);
			configDialog.STImport100_119Label.Visible = visible;
			configDialog.STImportF100_119CheckBox.Visible = visible;
			configDialog.STImportF100_119PictureBox.Visible = (visible & configDialog.STImportF100_119CheckBox.Checked);
			configDialog.STImportF100_119TypeComboBox.Visible = (visible & configDialog.STImportF100_119CheckBox.Checked);
			configDialog.STImportF100_119MagComboBox.Visible = (text & configDialog.STImportF100_119CheckBox.Checked & Conversions.ToUShort(configDialog.STImportF100_119TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportF80_99Label.Visible = visible;
			configDialog.STImportF80_99CheckBox.Visible = visible;
			configDialog.STImportF80_99PictureBox.Visible = (visible & configDialog.STImportF80_99CheckBox.Checked);
			configDialog.STImportF80_99TypeComboBox.Visible = (visible & configDialog.STImportF80_99CheckBox.Checked);
			configDialog.STImportF80_99MagComboBox.Visible = (text & configDialog.STImportF80_99CheckBox.Checked & Conversions.ToUShort(configDialog.STImportF80_99TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportF60_79Label.Visible = visible;
			configDialog.STImportF60_79CheckBox.Visible = visible;
			configDialog.STImportF60_79PictureBox.Visible = (visible & configDialog.STImportF60_79CheckBox.Checked);
			configDialog.STImport60_79TypeComboBox.Visible = (visible & configDialog.STImportF60_79CheckBox.Checked);
			configDialog.STImportF60_79MagComboBox.Visible = (text & configDialog.STImportF60_79CheckBox.Checked & Conversions.ToUShort(configDialog.STImport60_79TypeComboBox.SelectedValue) == 4444);
			configDialog.STImporF0_59Label.Visible = visible;
			configDialog.STImportF0_59CheckBox.Visible = visible;
			configDialog.STImportF0_59PictureBox.Visible = (visible & configDialog.STImportF0_59CheckBox.Checked);
			configDialog.STImportF0_59TypeComboBox.Visible = (visible & configDialog.STImportF0_59CheckBox.Checked);
			configDialog.STImporF0_59MagComboBox.Visible = (text & configDialog.STImportF0_59CheckBox.Checked & Conversions.ToUShort(configDialog.STImportF0_59TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportM120_130Label.Visible = visible;
			configDialog.STImportM120_130CheckBox.Visible = visible;
			configDialog.STImportM120_130PictureBox.Visible = (visible & configDialog.STImportM120_130CheckBox.Checked);
			configDialog.STImportM120_130TypeComboBox.Visible = (visible & configDialog.STImportM120_130CheckBox.Checked);
			configDialog.STImportM120_130MagComboBox.Visible = (text & configDialog.STImportM120_130CheckBox.Checked & Conversions.ToUShort(configDialog.STImportM120_130TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportM100_119Label.Visible = visible;
			configDialog.STImportM100_119CheckBox.Visible = visible;
			configDialog.STImportM100_119PictureBox.Visible = (visible & configDialog.STImportM100_119CheckBox.Checked);
			configDialog.STImportM100_119TypeComboBox.Visible = (visible & configDialog.STImportM100_119CheckBox.Checked);
			configDialog.STImportM100_119MagComboBox.Visible = (text & configDialog.STImportM100_119CheckBox.Checked & Conversions.ToUShort(configDialog.STImportM100_119TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportM80_99Label.Visible = visible;
			configDialog.STImportM80_99CheckBox.Visible = visible;
			configDialog.STImportM80_99PictureBox.Visible = (visible & configDialog.STImportM80_99CheckBox.Checked);
			configDialog.STImportM80_99TypeComboBox.Visible = (visible & configDialog.STImportM80_99CheckBox.Checked);
			configDialog.STImportM80_99MagComboBox.Visible = (text & configDialog.STImportM80_99CheckBox.Checked & Conversions.ToUShort(configDialog.STImportM80_99TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportM60_79Label.Visible = visible;
			configDialog.STImportM60_79CheckBox.Visible = visible;
			configDialog.STImportM60_79PictureBox.Visible = (visible & configDialog.STImportM60_79CheckBox.Checked);
			configDialog.STImportM60_79TypeComboBox.Visible = (visible & configDialog.STImportM60_79CheckBox.Checked);
			configDialog.STImportM60_79MagComboBox.Visible = (text & configDialog.STImportM60_79CheckBox.Checked & Conversions.ToUShort(configDialog.STImportM60_79TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportM0_59Label.Visible = visible;
			configDialog.STImportM0_59CheckBox.Visible = visible;
			configDialog.STImportM0_59PictureBox.Visible = (visible & configDialog.STImportM0_59CheckBox.Checked);
			configDialog.STImportM0_59TypeComboBox.Visible = (visible & configDialog.STImportM0_59CheckBox.Checked);
			configDialog.STImportM0_59MagComboBox.Visible = (text & configDialog.STImportM0_59CheckBox.Checked & Conversions.ToUShort(configDialog.STImportM0_59TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportRFRLabel.Visible = visible;
			configDialog.STImportRFRCheckBox.Visible = visible;
			configDialog.STImportRFRPictureBox.Visible = (visible & configDialog.STImportRFRCheckBox.Checked);
			configDialog.STImportRFRTypeComboBox.Visible = (visible & configDialog.STImportRFRCheckBox.Checked);
			configDialog.STImportRFRMagComboBox.Visible = (text & configDialog.STImportRFRCheckBox.Checked & Conversions.ToUShort(configDialog.STImportRFRTypeComboBox.SelectedValue) == 4444);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0010216C File Offset: 0x0010116C
		public void OK_Button_Click()
		{
			ConfigDialog configDialog = this.myConfigDialog;
			MySettingsProperty.Settings.STImportMode = Conversions.ToUInteger(this.myConfigDialog.STImportModeComboBox.SelectedValue);
			MySettingsProperty.Settings.STimportAll = configDialog.STImportAllCheckBox.Checked;
			MySettingsProperty.Settings.STimportAllType = Conversions.ToUShort(configDialog.STImportAllTypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportAllTypeIsNP = this.STImportAllTypeIsNP;
			MySettingsProperty.Settings.STimportAllMag = Conversions.ToByte(configDialog.STImportAllMagComboBox.SelectedValue);
			MySettingsProperty.Settings.STimportFixed = configDialog.STImportFixedCheckBox.Checked;
			MySettingsProperty.Settings.STimportFixedType = Conversions.ToUShort(configDialog.STImportFixedTypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportFixedTypeIsNP = this.STImportFixedTypeIsNP;
			MySettingsProperty.Settings.STImportFixedMag = Conversions.ToByte(configDialog.STImportFixedMagComboBox.SelectedValue);
			MySettingsProperty.Settings.STimportMobile = configDialog.STImportMobileCheckBox.Checked;
			MySettingsProperty.Settings.STimportMobileType = Conversions.ToUShort(configDialog.STImportMobileTypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportMobileTypeIsNP = this.STImportMobileTypeIsNP;
			MySettingsProperty.Settings.STimportMobileMag = Conversions.ToByte(configDialog.STImportMobileMagComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportF120_130G = configDialog.STImportF120_130GCheckBox.Checked;
			MySettingsProperty.Settings.STImportF120_130GType = Conversions.ToUShort(configDialog.STImportF120_130GTypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportF120_130GMag = Conversions.ToByte(configDialog.STImportF120_130GMagComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportF100_119 = configDialog.STImportF100_119CheckBox.Checked;
			MySettingsProperty.Settings.STImportF100_119Type = Conversions.ToUShort(configDialog.STImportF100_119TypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportF100_119Mag = Conversions.ToByte(configDialog.STImportF100_119MagComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportF80_99 = configDialog.STImportF80_99CheckBox.Checked;
			MySettingsProperty.Settings.STImportF80_99Type = Conversions.ToUShort(configDialog.STImportF80_99TypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportF80_99Mag = Conversions.ToByte(configDialog.STImportF80_99MagComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportF60_79 = configDialog.STImportF60_79CheckBox.Checked;
			MySettingsProperty.Settings.STImportF60_79Type = Conversions.ToUShort(configDialog.STImport60_79TypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportF60_79Mag = Conversions.ToByte(configDialog.STImportF60_79MagComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportF0_59 = configDialog.STImportF0_59CheckBox.Checked;
			MySettingsProperty.Settings.STImportF0_59Type = Conversions.ToUShort(configDialog.STImportF0_59TypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportF0_59Mag = Conversions.ToByte(configDialog.STImporF0_59MagComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportM120_130 = configDialog.STImportM120_130CheckBox.Checked;
			MySettingsProperty.Settings.STImportM120_130Type = Conversions.ToUShort(configDialog.STImportM120_130TypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportM120_130Mag = Conversions.ToByte(configDialog.STImportM120_130MagComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportM100_119 = configDialog.STImportM100_119CheckBox.Checked;
			MySettingsProperty.Settings.STImportM100_119Type = Conversions.ToUShort(configDialog.STImportM100_119TypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportM100_119Mag = Conversions.ToByte(configDialog.STImportM100_119MagComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportM80_99 = configDialog.STImportM80_99CheckBox.Checked;
			MySettingsProperty.Settings.STImportM80_99Type = Conversions.ToUShort(configDialog.STImportM80_99TypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportM80_99Mag = Conversions.ToByte(configDialog.STImportM80_99MagComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportM60_79 = configDialog.STImportM60_79CheckBox.Checked;
			MySettingsProperty.Settings.STImportM60_79Type = Conversions.ToUShort(configDialog.STImportM60_79TypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportM60_79Mag = Conversions.ToByte(configDialog.STImportM60_79MagComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportM0_59 = configDialog.STImportM0_59CheckBox.Checked;
			MySettingsProperty.Settings.STImportM0_59Type = Conversions.ToUShort(configDialog.STImportM0_59TypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportM0_59Mag = Conversions.ToByte(configDialog.STImportM0_59MagComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportRFR = configDialog.STImportRFRCheckBox.Checked;
			MySettingsProperty.Settings.STImportRFRType = Conversions.ToUShort(configDialog.STImportRFRTypeComboBox.SelectedValue);
			MySettingsProperty.Settings.STImportRFRMag = Conversions.ToByte(configDialog.STImportRFRMagComboBox.SelectedValue);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00102600 File Offset: 0x00101600
		private void buildSupportedModesList(ArrayList supportedModesList, STArchives.ArchImportMode supportedModes)
		{
			bool flag = this.supportedModes != supportedModes;
			if (flag)
			{
				supportedModesList.Clear();
				flag = ((supportedModes & STArchives.ArchImportMode.ALLIcon) == STArchives.ArchImportMode.ALLIcon);
				if (flag)
				{
					supportedModesList.Add(new comboSTImportModeItems(Resources.strImportSTAllIcon, STArchives.ArchImportMode.ALLIcon));
				}
				flag = ((supportedModes & STArchives.ArchImportMode.AllText) == STArchives.ArchImportMode.AllText);
				if (flag)
				{
					supportedModesList.Add(new comboSTImportModeItems(Resources.strImportSTAllText, STArchives.ArchImportMode.AllText));
				}
				flag = ((supportedModes & STArchives.ArchImportMode.AllRFIconRMIcon) == STArchives.ArchImportMode.AllRFIconRMIcon);
				if (flag)
				{
					supportedModesList.Add(new comboSTImportModeItems(Resources.strImportSTRFIconRMIcon, STArchives.ArchImportMode.AllRFIconRMIcon));
				}
				flag = ((supportedModes & STArchives.ArchImportMode.AllRFIconRMText) == STArchives.ArchImportMode.AllRFIconRMText);
				if (flag)
				{
					supportedModesList.Add(new comboSTImportModeItems(Resources.strImportSTRFIconRMText, STArchives.ArchImportMode.AllRFIconRMText));
				}
				flag = ((supportedModes & STArchives.ArchImportMode.AllRFTextRMIcon) == STArchives.ArchImportMode.AllRFTextRMIcon);
				if (flag)
				{
					supportedModesList.Add(new comboSTImportModeItems(Resources.strImportSTRFTextRMIcon, STArchives.ArchImportMode.AllRFTextRMIcon));
				}
				flag = ((supportedModes & STArchives.ArchImportMode.AllRFTextRMText) == STArchives.ArchImportMode.AllRFTextRMText);
				if (flag)
				{
					supportedModesList.Add(new comboSTImportModeItems(Resources.strImportSTRFtextRMText, STArchives.ArchImportMode.AllRFTextRMText));
				}
				flag = ((supportedModes & STArchives.ArchImportMode.AllRFIcon) == STArchives.ArchImportMode.AllRFIcon);
				if (flag)
				{
					supportedModesList.Add(new comboSTImportModeItems(Resources.strImportSTRFIcon, STArchives.ArchImportMode.AllRFIcon));
				}
				flag = ((supportedModes & STArchives.ArchImportMode.AllRFText) == STArchives.ArchImportMode.AllRFText);
				if (flag)
				{
					supportedModesList.Add(new comboSTImportModeItems(Resources.strImportSTRFText, STArchives.ArchImportMode.AllRFText));
				}
				flag = ((supportedModes & STArchives.ArchImportMode.AllRMIcon) == STArchives.ArchImportMode.AllRMIcon);
				if (flag)
				{
					supportedModesList.Add(new comboSTImportModeItems(Resources.strImportSTRMIcon, STArchives.ArchImportMode.AllRMIcon));
				}
				flag = ((supportedModes & STArchives.ArchImportMode.AllRMText) == STArchives.ArchImportMode.AllRMText);
				if (flag)
				{
					supportedModesList.Add(new comboSTImportModeItems(Resources.strImportSTRMText, STArchives.ArchImportMode.AllRMText));
				}
				flag = ((supportedModes & STArchives.ArchImportMode.Custom) == STArchives.ArchImportMode.Custom);
				if (flag)
				{
					supportedModesList.Add(new comboSTImportModeItems(Resources.strImportSTCustom, STArchives.ArchImportMode.Custom));
				}
				this.supportedModes = supportedModes;
				this.myConfigDialog.STImportModeComboBox.DataSource = new BindingSource(supportedModesList, null);
				this.myConfigDialog.STImportModeComboBox.DisplayMember = "display";
				this.myConfigDialog.STImportModeComboBox.ValueMember = "value";
				this.myConfigDialog.STImportModeComboBox.Refresh();
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00102800 File Offset: 0x00101800
		private void STImportModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.updateGUI();
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0010280C File Offset: 0x0010180C
		private void STImportCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.updateGUI();
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00102818 File Offset: 0x00101818
		private void STImportAllTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			bool flag = configDialog.STImportAllTypeComboBox.SelectedValue != null;
			if (flag)
			{
				configDialog.STImportAllPictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportAllTypeComboBox.SelectedValue));
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0010287C File Offset: 0x0010187C
		private void STImportAllNPTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportAllPictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportAllNPTypeComboBox.SelectedValue));
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x001028CC File Offset: 0x001018CC
		private void STImportFixedTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportFixedPictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportFixedTypeComboBox.SelectedValue));
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0010291C File Offset: 0x0010191C
		private void STImportFixedNPTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportFixedPictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportFixedNPTypeComboBox.SelectedValue));
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0010296C File Offset: 0x0010196C
		private void STImportMobileTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportMobilePictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportMobileTypeComboBox.SelectedValue));
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x001029BC File Offset: 0x001019BC
		private void STImportMobileNPTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportMobilePictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportMobileNPTypeComboBox.SelectedValue));
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00102A0C File Offset: 0x00101A0C
		private void STImportF130GTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportF120_130GMagComboBox.Visible = (Conversions.ToUShort(configDialog.STImportF120_130GTypeComboBox.SelectedValue) == 4444);
			configDialog.STImportF120_130GPictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportF120_130GTypeComboBox.SelectedValue));
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00102A7C File Offset: 0x00101A7C
		private void STImportF110TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportF100_119MagComboBox.Visible = (Conversions.ToUShort(configDialog.STImportF100_119TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportF100_119PictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportF100_119TypeComboBox.SelectedValue));
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00102AEC File Offset: 0x00101AEC
		private void STImportF90TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportF80_99MagComboBox.Visible = (Conversions.ToUShort(configDialog.STImportF80_99TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportF80_99PictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportF80_99TypeComboBox.SelectedValue));
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00102B5C File Offset: 0x00101B5C
		private void STImportF89_61TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportF60_79MagComboBox.Visible = (Conversions.ToUShort(configDialog.STImport60_79TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportF60_79PictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImport60_79TypeComboBox.SelectedValue));
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00102BCC File Offset: 0x00101BCC
		private void STImportF60_30TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImporF0_59MagComboBox.Visible = (Conversions.ToUShort(configDialog.STImportF0_59TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportF0_59PictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportF0_59TypeComboBox.SelectedValue));
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00102C3C File Offset: 0x00101C3C
		private void STImportM130TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportM120_130MagComboBox.Visible = (Conversions.ToUShort(configDialog.STImportM120_130TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportM120_130PictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportM120_130TypeComboBox.SelectedValue));
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00102CAC File Offset: 0x00101CAC
		private void STImportM110TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportM100_119MagComboBox.Visible = (Conversions.ToUShort(configDialog.STImportM100_119TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportM100_119PictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportM100_119TypeComboBox.SelectedValue));
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00102D1C File Offset: 0x00101D1C
		private void STImportM90TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportM80_99MagComboBox.Visible = (Conversions.ToUShort(configDialog.STImportM80_99TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportM80_99PictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportM80_99TypeComboBox.SelectedValue));
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00102D8C File Offset: 0x00101D8C
		private void STImportM89_61TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportM60_79MagComboBox.Visible = (Conversions.ToUShort(configDialog.STImportM60_79TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportM60_79PictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportM60_79TypeComboBox.SelectedValue));
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00102DFC File Offset: 0x00101DFC
		private void STImportM60_30TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportM0_59MagComboBox.Visible = (Conversions.ToUShort(configDialog.STImportM0_59TypeComboBox.SelectedValue) == 4444);
			configDialog.STImportM0_59PictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportM0_59TypeComboBox.SelectedValue));
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00102E6C File Offset: 0x00101E6C
		private void STImportRFRTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConfigDialog configDialog = this.myConfigDialog;
			configDialog.STImportRFRMagComboBox.Visible = (Conversions.ToUShort(configDialog.STImportRFRTypeComboBox.SelectedValue) == 4444);
			configDialog.STImportRFRPictureBox.Image = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getImageOfType(Conversions.ToUShort(configDialog.STImportRFRTypeComboBox.SelectedValue));
		}

		// Token: 0x04000343 RID: 835
		private ConfigDialog myConfigDialog;

		// Token: 0x04000344 RID: 836
		private STArchives.ArchImportMode supportedModes;

		// Token: 0x04000345 RID: 837
		private ArrayList supportedModesList;

		// Token: 0x04000346 RID: 838
		private bool STImportAllTypeIsNP;

		// Token: 0x04000347 RID: 839
		private bool STImportFixedTypeIsNP;

		// Token: 0x04000348 RID: 840
		private bool STImportMobileTypeIsNP;

		// Token: 0x04000349 RID: 841
		private bool fixedOnly;
	}
}
