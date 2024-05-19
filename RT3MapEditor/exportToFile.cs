using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualBasic;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000058 RID: 88
	public class exportToFile
	{
		// Token: 0x06000C5A RID: 3162 RVA: 0x001132FC File Offset: 0x001122FC
		public exportToFile(POILists POIList)
		{
			this._POIList = POIList;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00113310 File Offset: 0x00112310
		public void export(Common.RTxMapType mapType, bool withGUI, exportToFile.exportFormat exportFormat)
		{
			switch (exportFormat)
			{
			case exportToFile.exportFormat.exportAsc:
			{
				POIDatas.cultForExport = Common.cultENUS;
				StreamWriter streamWriter = this.openStream2Write(".asc");
				bool flag = streamWriter != null;
				if (flag)
				{
					this.exportToAsc(streamWriter);
				}
				break;
			}
			case exportToFile.exportFormat.exportRT3:
			{
				POIDatas.cultForExport = Common.cultENUS;
				ZipOutputStream zipOutputStream = this.openZipStream2Write(".rt3", withGUI);
				bool flag = zipOutputStream != null;
				if (flag)
				{
					this.exportToTxt(zipOutputStream, mapType, withGUI);
				}
				break;
			}
			case exportToFile.exportFormat.exportCsv:
			{
				switch (MySettingsProperty.Settings.exportDecSepCsvInt)
				{
				case 42:
					POIDatas.cultForExport = Thread.CurrentThread.CurrentCulture;
					goto IL_CC;
				case 44:
					POIDatas.cultForExport = new CultureInfo("fr-FR");
					goto IL_CC;
				case 46:
					POIDatas.cultForExport = Common.cultENUS;
					goto IL_CC;
				}
				POIDatas.cultForExport = Thread.CurrentThread.CurrentUICulture;
				IL_CC:
				StreamWriter streamWriter = this.openStream2Write(".csv");
				bool flag = streamWriter != null;
				if (flag)
				{
					this.exportToCsv(streamWriter);
				}
				break;
			}
			case exportToFile.exportFormat.exportKml:
			{
				POIDatas.cultForExport = Common.cultENUS;
				StreamWriter streamWriter = this.openStream2Write(".kml");
				bool flag = streamWriter != null;
				if (flag)
				{
					this.exportToKml(streamWriter);
				}
				break;
			}
			case exportToFile.exportFormat.exportRTxME:
			{
				POIDatas.cultForExport = Common.cultENUS;
				ZipOutputStream zipOutputStream = this.openZipStream2Write(".rtxme", withGUI);
				bool flag = zipOutputStream != null;
				if (flag)
				{
					this.exportToTxt(zipOutputStream, mapType, withGUI);
				}
				break;
			}
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x001134A4 File Offset: 0x001124A4
		private ZipOutputStream openZipStream2Write(string extension)
		{
			return this.openZipStream2Write(extension, true);
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x001134C0 File Offset: 0x001124C0
		private ZipOutputStream openZipStream2Write(string extension, bool withGUI)
		{
			ZipOutputStream zipOutputStream = null;
			string text = null;
			try
			{
				bool flag;
				if (withGUI)
				{
					flag = (MyProject.Forms.FormMain.choseFile2ExportDialog.showDialog(this._POIList.nameForExport + extension) == DialogResult.OK);
					if (flag)
					{
						text = MyProject.Forms.FormMain.choseFile2ExportDialog.getFileName();
					}
				}
				else
				{
					text = Path.Combine(MySettingsProperty.Settings.WorkingDir, this._POIList.nameForExport + extension);
					flag = MyProject.Computer.FileSystem.FileExists(text);
					if (flag)
					{
						MyProject.Computer.FileSystem.DeleteFile(text);
					}
				}
				flag = (text != null);
				if (flag)
				{
					zipOutputStream = new ZipOutputStream(File.Create(text));
					zipOutputStream.Password = "ZZZCOM.IND.lst";
					zipOutputStream.PutNextEntry(new ZipEntry("data")
					{
						IsCrypted = true,
						CompressionMethod = CompressionMethod.Deflated
					});
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, null);
				zipOutputStream = null;
			}
			return zipOutputStream;
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x001135E8 File Offset: 0x001125E8
		private StreamWriter openStream2Write(string extension)
		{
			StreamWriter result = null;
			try
			{
				bool flag = MyProject.Forms.FormMain.choseFile2ExportDialog.showDialog(this._POIList.nameForExport + extension) == DialogResult.OK;
				if (flag)
				{
					result = new StreamWriter(MyProject.Forms.FormMain.choseFile2ExportDialog.getFileName(), false, Common.RT3Encoding);
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, null);
				result = null;
			}
			return result;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0011367C File Offset: 0x0011267C
		public void exportToAsc(StreamWriter stream2Write)
		{
			int num = 0;
			Cursor value = null;
			value = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			Application.DoEvents();
			checked
			{
				try
				{
					stream2Write.WriteLine(string.Format(Resources.strExportHeader, "asc", DateTime.Today.ToShortDateString()));
					bool flag = this._POIList.fromRT3;
					if (flag)
					{
						stream2Write.WriteLine(Resources.strExportForbidden);
					}
					stream2Write.WriteLine("");
					try
					{
						foreach (POIDatas poidatas in this._POIList.ListofPOI)
						{
							StringBuilder stringBuilder = new StringBuilder(200);
							stringBuilder.Append(poidatas.lonForExport);
							stringBuilder.Append(", ");
							stringBuilder.Append(poidatas.latForExport);
							stringBuilder.Append(", ");
							stringBuilder.Append("\"");
							stringBuilder.Append(poidatas.nameForExport);
							string addressForExport = poidatas.addressForExport;
							flag = (MySettingsProperty.Settings.exportAddressAsc && addressForExport != null);
							if (flag)
							{
								stringBuilder.Append(MySettingsProperty.Settings.exportAscIntSeparator);
								stringBuilder.Append(addressForExport);
							}
							string cityNameForExport = poidatas.cityNameForExport;
							flag = (MySettingsProperty.Settings.exportCityAsc && poidatas.type != 4444 && cityNameForExport != null);
							if (flag)
							{
								stringBuilder.Append(MySettingsProperty.Settings.exportAscIntSeparator);
								stringBuilder.Append(cityNameForExport);
							}
							string countryForExport = poidatas.countryForExport;
							flag = (MySettingsProperty.Settings.exportCountryAsc && poidatas.type != 4444 && countryForExport != null);
							if (flag)
							{
								stringBuilder.Append(MySettingsProperty.Settings.exportAscIntSeparator);
								stringBuilder.Append(countryForExport);
							}
							string telForExport = poidatas.telForExport;
							flag = (MySettingsProperty.Settings.exportTelAsc && this._POIList.fromRT3 && telForExport != null);
							if (flag)
							{
								stringBuilder.Append(MySettingsProperty.Settings.exportAscIntSeparator);
								stringBuilder.Append(telForExport);
							}
							string brandNameForExport = poidatas.brandNameForExport;
							flag = (MySettingsProperty.Settings.exportBrandAsc && this._POIList.fromRT3 && brandNameForExport != null);
							if (flag)
							{
								stringBuilder.Append(MySettingsProperty.Settings.exportAscIntSeparator);
								stringBuilder.Append(brandNameForExport);
							}
							string commentForExport = poidatas.commentForExport;
							flag = (MySettingsProperty.Settings.exportCommentAsc && this._POIList.fromRT3 && commentForExport != null);
							if (flag)
							{
								stringBuilder.Append(MySettingsProperty.Settings.exportAscIntSeparator);
								stringBuilder.Append(commentForExport);
							}
							stringBuilder.Append("\"");
							stream2Write.WriteLine(stringBuilder.ToString());
							num++;
							flag = (num % 1000 == 0);
							if (flag)
							{
								Application.DoEvents();
							}
						}
					}
					finally
					{
						List<POIDatas>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				catch (Exception ex)
				{
					MyProject.Application.Log.WriteEntry(Resources.strErrExport);
					MyProject.Application.Log.WriteEntry(ex.StackTrace);
					Interaction.MsgBox(Resources.strErrExport, MsgBoxStyle.Critical, null);
				}
				finally
				{
					Cursor.Current = value;
					Application.DoEvents();
					stream2Write.Close();
				}
				Interaction.MsgBox(Resources.strFileExported, MsgBoxStyle.Information, null);
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00113A4C File Offset: 0x00112A4C
		public void exportToCsv(StreamWriter stream2Write)
		{
			int num = 0;
			Cursor value = null;
			value = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			checked
			{
				try
				{
					StringBuilder stringBuilder = new StringBuilder(400);
					bool flag = MySettingsProperty.Settings.exportLonCsv;
					if (flag)
					{
						stringBuilder.Append(MySettingsProperty.Settings.exportFieldLonCsv);
						stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
					}
					flag = MySettingsProperty.Settings.exportLatCsv;
					if (flag)
					{
						stringBuilder.Append(MySettingsProperty.Settings.exportFieldLatCsv);
						stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
					}
					flag = MySettingsProperty.Settings.exportNameCsv;
					if (flag)
					{
						stringBuilder.Append(MySettingsProperty.Settings.exportFieldNameCsv);
						stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
					}
					flag = MySettingsProperty.Settings.exportAddressCsv;
					if (flag)
					{
						stringBuilder.Append(MySettingsProperty.Settings.exportFieldAddressCsv);
						stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
					}
					flag = MySettingsProperty.Settings.exportCityCsv;
					if (flag)
					{
						stringBuilder.Append(MySettingsProperty.Settings.exportFieldCityCsv);
						stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
					}
					flag = MySettingsProperty.Settings.exportCountryCsv;
					if (flag)
					{
						stringBuilder.Append(MySettingsProperty.Settings.exportFieldCountryCsv);
						stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
					}
					flag = MySettingsProperty.Settings.exportTelCsv;
					if (flag)
					{
						stringBuilder.Append(MySettingsProperty.Settings.exportFieldTelCsv);
						stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
					}
					flag = MySettingsProperty.Settings.exportCommentCsv;
					if (flag)
					{
						stringBuilder.Append(MySettingsProperty.Settings.exportFieldCommentCsv);
						stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
					}
					flag = MySettingsProperty.Settings.exportBrandCsv;
					if (flag)
					{
						stringBuilder.Append(MySettingsProperty.Settings.exportFieldBrandCsv);
						stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
					}
					stream2Write.WriteLine(stringBuilder.ToString());
					try
					{
						foreach (POIDatas poidatas in this._POIList.ListofPOI)
						{
							stringBuilder = new StringBuilder(400);
							flag = MySettingsProperty.Settings.exportLonCsv;
							if (flag)
							{
								stringBuilder.Append(poidatas.lonForExport);
								stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
							}
							flag = MySettingsProperty.Settings.exportLatCsv;
							if (flag)
							{
								stringBuilder.Append(poidatas.latForExport);
								stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
							}
							flag = MySettingsProperty.Settings.exportNameCsv;
							if (flag)
							{
								stringBuilder.Append("\"");
								stringBuilder.Append(poidatas.nameForExport);
								stringBuilder.Append("\"");
								stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
							}
							flag = MySettingsProperty.Settings.exportAddressCsv;
							if (flag)
							{
								stringBuilder.Append("\"");
								stringBuilder.Append(poidatas.addressForExport);
								stringBuilder.Append("\"");
								stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
							}
							flag = MySettingsProperty.Settings.exportCityCsv;
							if (flag)
							{
								stringBuilder.Append("\"");
								stringBuilder.Append(poidatas.cityNameForExport);
								stringBuilder.Append("\"");
								stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
							}
							flag = MySettingsProperty.Settings.exportCountryCsv;
							if (flag)
							{
								stringBuilder.Append("\"");
								stringBuilder.Append(poidatas.countryForExport);
								stringBuilder.Append("\"");
								stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
							}
							flag = MySettingsProperty.Settings.exportTelCsv;
							if (flag)
							{
								stringBuilder.Append("\"");
								stringBuilder.Append(poidatas.telForExport);
								stringBuilder.Append("\"");
								stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
							}
							flag = MySettingsProperty.Settings.exportCommentCsv;
							if (flag)
							{
								stringBuilder.Append("\"");
								stringBuilder.Append(poidatas.commentForExport);
								stringBuilder.Append("\"");
								stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
							}
							flag = MySettingsProperty.Settings.exportBrandCsv;
							if (flag)
							{
								stringBuilder.Append("\"");
								stringBuilder.Append(poidatas.brandNameForExport);
								stringBuilder.Append("\"");
								stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportCsvSepInt));
							}
							stream2Write.WriteLine(stringBuilder.ToString());
							num++;
							flag = (num % 1000 == 0);
							if (flag)
							{
								Application.DoEvents();
							}
						}
					}
					finally
					{
						List<POIDatas>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				catch (Exception ex)
				{
					MyProject.Application.Log.WriteEntry(Resources.strErrExport);
					MyProject.Application.Log.WriteEntry(ex.StackTrace);
					Interaction.MsgBox(Resources.strErrExport, MsgBoxStyle.Critical, null);
				}
				finally
				{
					Cursor.Current = value;
					stream2Write.Close();
				}
				Interaction.MsgBox(Resources.strFileExported, MsgBoxStyle.Information, null);
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0011402C File Offset: 0x0011302C
		public void exportToTxt(ZipOutputStream zipStream2Write, Common.RTxMapType mapType, bool withGUI)
		{
			Encoding unicode = Encoding.Unicode;
			int num = 0;
			Cursor value = null;
			value = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			checked
			{
				try
				{
					StringBuilder stringBuilder = new StringBuilder(400);
					stringBuilder.Append(MySettingsProperty.Settings.exportFieldERT3Txt);
					stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
					stringBuilder.Append(MySettingsProperty.Settings.exportFieldNRT3Txt);
					stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
					stringBuilder.Append(MySettingsProperty.Settings.exportFieldNameTxt);
					stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
					stringBuilder.Append(MySettingsProperty.Settings.exportFieldAddressTxt);
					stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
					stringBuilder.Append(MySettingsProperty.Settings.exportFieldCityTxt);
					stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
					stringBuilder.Append(MySettingsProperty.Settings.exportFieldTelTxt);
					stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
					stringBuilder.Append(MySettingsProperty.Settings.exportFieldCommentTxt);
					stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
					stringBuilder.Append(MySettingsProperty.Settings.exportFieldBrandTxt);
					stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
					stringBuilder.Append(MySettingsProperty.Settings.exportFieldTypeTxt);
					stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
					stringBuilder.Append(MySettingsProperty.Settings.exportFieldMagnitudeTxt);
					stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
					stringBuilder.Append(MySettingsProperty.Settings.exportFieldCtTxt);
					stringBuilder.AppendLine();
					byte[] bytes = unicode.GetBytes(stringBuilder.ToString());
					byte[] array = Encoding.Convert(unicode, Common.RT3Encoding, bytes);
					zipStream2Write.Write(array, 0, array.Length);
					try
					{
						foreach (POIDatas poidatas in this._POIList.ListofPOI)
						{
							stringBuilder = new StringBuilder(400);
							bool flag = mapType == Common.RTxMapType.RT3;
							if (flag)
							{
								stringBuilder.Append(poidatas._ERTX);
							}
							else
							{
								stringBuilder.Append(projection.ERT4ToERT3((int)poidatas._ERTX));
							}
							stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
							flag = (mapType == Common.RTxMapType.RT3);
							if (flag)
							{
								stringBuilder.Append(poidatas._NRTX);
							}
							else
							{
								stringBuilder.Append(projection.NRT4ToNRT3((int)poidatas._NRTX));
							}
							stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
							stringBuilder.Append("\"");
							stringBuilder.Append(poidatas.nameForExport);
							stringBuilder.Append("\"");
							stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
							stringBuilder.Append("\"");
							stringBuilder.Append(poidatas.addressForExport);
							stringBuilder.Append("\"");
							stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
							stringBuilder.Append("\"");
							stringBuilder.Append(poidatas.cityNameForExport);
							stringBuilder.Append("\"");
							stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
							stringBuilder.Append("\"");
							stringBuilder.Append(poidatas.telForExport);
							stringBuilder.Append("\"");
							stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
							stringBuilder.Append("\"");
							stringBuilder.Append(poidatas.commentForExport);
							stringBuilder.Append("\"");
							stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
							stringBuilder.Append("\"");
							stringBuilder.Append(poidatas.brandNameForExport);
							stringBuilder.Append("\"");
							stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
							stringBuilder.Append("\"");
							stringBuilder.Append(poidatas.type);
							stringBuilder.Append("\"");
							stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
							stringBuilder.Append("\"");
							stringBuilder.Append(poidatas.magnitude);
							stringBuilder.Append("\"");
							stringBuilder.Append(Strings.ChrW(MySettingsProperty.Settings.exportTxtSepInt));
							stringBuilder.Append("\"");
							stringBuilder.Append(poidatas.countryRT3);
							stringBuilder.Append("\"");
							stringBuilder.AppendLine();
							bytes = unicode.GetBytes(stringBuilder.ToString());
							array = Encoding.Convert(unicode, Common.RT3Encoding, bytes);
							zipStream2Write.Write(array, 0, array.Length);
							num++;
							flag = (num % 1000 == 0);
							if (flag)
							{
								Application.DoEvents();
							}
						}
					}
					finally
					{
						List<POIDatas>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				catch (Exception ex)
				{
					MyProject.Application.Log.WriteEntry(Resources.strErrExport);
					MyProject.Application.Log.WriteEntry(ex.StackTrace);
					Interaction.MsgBox(Resources.strErrExport, MsgBoxStyle.Critical, null);
					return;
				}
				finally
				{
					Cursor.Current = value;
					zipStream2Write.Close();
				}
				if (withGUI)
				{
					Interaction.MsgBox(Resources.strFileExported, MsgBoxStyle.Information, null);
				}
			}
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00114620 File Offset: 0x00113620
		public void exportToKml(StreamWriter stream2Write)
		{
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00114624 File Offset: 0x00113624
		public static void exportOneSampleToAsc(string fileName, string lonForExport, string latForExport, string nameForExport)
		{
			StreamWriter streamWriter = null;
			try
			{
				streamWriter = new StreamWriter(fileName, false, Common.RT3Encoding);
				streamWriter.WriteLine(string.Format(Resources.strExportHeader, "asc", DateTime.Today.ToShortDateString()));
				streamWriter.WriteLine("");
				StringBuilder stringBuilder = new StringBuilder(200);
				stringBuilder.Append(lonForExport);
				stringBuilder.Append(", ");
				stringBuilder.Append(latForExport);
				stringBuilder.Append(", ");
				stringBuilder.Append("\"");
				stringBuilder.Append(nameForExport);
				stringBuilder.Append("\"");
				streamWriter.WriteLine(stringBuilder.ToString());
			}
			catch (Exception ex)
			{
				MyProject.Application.Log.WriteEntry(Resources.strErrExport);
				MyProject.Application.Log.WriteEntry(ex.StackTrace);
				Interaction.MsgBox(Resources.strErrExport, MsgBoxStyle.Critical, null);
			}
			finally
			{
				streamWriter.Close();
			}
		}

		// Token: 0x04000488 RID: 1160
		private POILists _POIList;

		// Token: 0x02000059 RID: 89
		public enum exportFormat
		{
			// Token: 0x0400048A RID: 1162
			exportAsc = 1,
			// Token: 0x0400048B RID: 1163
			exportRT3,
			// Token: 0x0400048C RID: 1164
			exportCsv,
			// Token: 0x0400048D RID: 1165
			exportKml,
			// Token: 0x0400048E RID: 1166
			exportRTxME
		}
	}
}
