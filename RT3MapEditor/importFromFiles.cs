using System;
using System.Collections.Generic;
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
	// Token: 0x0200005C RID: 92
	public class importFromFiles
	{
		// Token: 0x06000C82 RID: 3202 RVA: 0x00117638 File Offset: 0x00116638
		public importFromFiles(POILists POIList)
		{
			this.tmpListOfPOI = null;
			this._POIList = POIList;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00117654 File Offset: 0x00116654
		public bool importFromFiles(string[] fileNames, Common.RTxMapEditorMapModes RTxMapEditorMapMode)
		{
			Cursor value = null;
			value = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			this._POIList.name = "";
			this._POIList._state = POILists.state.added;
			this.multipleImport = (fileNames.Length > 1);
			bool flag;
			bool flag2;
			bool flag3;
			foreach (string text in fileNames)
			{
				MyProject.Forms.NonFatalErrorBox.resetIgnoreErrors();
				this._errorAction = NonFatalErrorBox.DialResult.Close;
				flag = (Operators.CompareString(Path.GetExtension(text), ".rt3", false) == 0);
				flag2 = (Operators.CompareString(Path.GetExtension(text), ".rtxme", false) == 0);
				try
				{
					flag3 = (flag || flag2);
					ZipFile zipFile;
					Stream stream;
					if (flag3)
					{
						zipFile = new ZipFile(text);
						zipFile.Password = "ZZZCOM.IND.lst";
						stream = zipFile.GetInputStream(zipFile.GetEntry("data"));
					}
					else
					{
						zipFile = null;
						stream = new FileStream(text, FileMode.Open, FileAccess.Read);
					}
					this.AssignType(text, this.multipleImport, flag || flag2, RTxMapEditorMapMode);
					this.initFromAscCsvStream(text, stream, STArchives.STArchiveType.ArcUnknown, STArchives.entryType.Unknown);
					flag3 = (zipFile != null);
					if (flag3)
					{
						zipFile.Close();
					}
					else
					{
						stream.Close();
					}
				}
				catch (Exception ex)
				{
					this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(string.Format(Resources.strErrUnable2Open, text), "", false, false, true, this.multipleImport);
				}
				Cursor.Current = value;
				flag3 = (this._errorAction == NonFatalErrorBox.DialResult.Abort);
				if (flag3)
				{
					this.tmpListOfPOI = null;
				}
				else
				{
					flag3 = (this._errorAction == NonFatalErrorBox.DialResult.AbortAll);
					if (flag3)
					{
						this.tmpListOfPOI = null;
						this._POIList.ListofPOI = null;
						return false;
					}
					this._POIList.ListofPOI.AddRange(this.tmpListOfPOI);
					flag3 = (Operators.CompareString(this._POIList.name, "", false) != 0);
					POILists poilist;
					if (flag3)
					{
						poilist = this._POIList;
						poilist.name += ", ";
					}
					poilist = this._POIList;
					poilist.name += Path.GetFileNameWithoutExtension(text);
					this.tmpListOfPOI = null;
				}
			}
			flag3 = (this._POIList.POINumber > 0);
			if (flag3)
			{
				this._POIList._fromRT3 = flag;
				flag3 = (flag2 || flag);
				if (flag3)
				{
					this._POIList.type = this._POIList.ListofPOI[0].type;
				}
				this._POIList.getPOINameType();
				return true;
			}
			return false;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0011791C File Offset: 0x0011691C
		public bool importFromArchive(STLists STList, STArchives archive)
		{
			Cursor value = null;
			value = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			this._POIList.name = STList.displayName;
			this._POIList._state = POILists.state.added;
			bool flag;
			try
			{
				foreach (STLists.STListsEntry stlistsEntry in STList.listOfST)
				{
					MyProject.Forms.NonFatalErrorBox.resetIgnoreErrors();
					this._POIList.setType(STList.POIType);
					this._POIList.setMagnitude(STList.magnitude);
					this.initFromAscCsvStream(stlistsEntry.zipEntry.Name, archive.zipFile.GetInputStream(stlistsEntry.zipEntry), archive.archiveType, stlistsEntry.entryType);
					flag = (this._errorAction == NonFatalErrorBox.DialResult.Abort);
					if (flag)
					{
						this.tmpListOfPOI = null;
					}
					else
					{
						flag = (this._errorAction == NonFatalErrorBox.DialResult.AbortAll);
						if (flag)
						{
							this.tmpListOfPOI = null;
							this._POIList.ListofPOI = null;
							return false;
						}
						this._POIList.ListofPOI.AddRange(this.tmpListOfPOI);
						this.tmpListOfPOI = null;
					}
				}
			}
			finally
			{
				List<STLists.STListsEntry>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			Cursor.Current = value;
			flag = (this._POIList.POINumber > 0);
			bool result;
			if (flag)
			{
				this._POIList.getPOINameType();
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00117AA8 File Offset: 0x00116AA8
		public static importFromFiles.index initIndex(importFromFiles.supportedTypes fileType)
		{
			importFromFiles.index result;
			switch (fileType)
			{
			case RT3MapEditor.importFromFiles.supportedTypes.asc:
				result.lat = 1;
				result.lon = 0;
				result.name = 2;
				result.address = -1;
				result.city = -1;
				result.tel = -1;
				result.brand = -1;
				result.comment = -1;
				result.ERT3 = -1;
				result.NRT3 = -1;
				result.type = -1;
				result.ct = -1;
				result.magnitude = -1;
				result.minColumn = 3;
				break;
			case RT3MapEditor.importFromFiles.supportedTypes.txtRT3:
			case RT3MapEditor.importFromFiles.supportedTypes.csv:
				result.lat = -1;
				result.lon = -1;
				result.name = -1;
				result.address = -1;
				result.city = -1;
				result.tel = -1;
				result.brand = -1;
				result.comment = -1;
				result.ERT3 = -1;
				result.NRT3 = -1;
				result.type = -1;
				result.ct = -1;
				result.magnitude = -1;
				result.minColumn = -1;
				break;
			}
			return result;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00117BB8 File Offset: 0x00116BB8
		private bool validHeader(string[] currentRow, ref importFromFiles.index idx, importFromFiles.supportedTypes inputType)
		{
			bool result = false;
			int num = currentRow.Length;
			int num2 = 0;
			checked
			{
				int num3 = num - 1;
				int num4 = num2;
				bool flag;
				for (;;)
				{
					int num5 = num4;
					int num6 = num3;
					if (num5 > num6)
					{
						break;
					}
					string text = currentRow[num4].ToLower();
					flag = (text.Equals("nom") || text.Equals("name"));
					if (flag)
					{
						idx.name = num4;
					}
					else
					{
						flag = (text.StartsWith("latitude") && inputType != RT3MapEditor.importFromFiles.supportedTypes.txtRT3);
						if (flag)
						{
							idx.lat = num4;
						}
						else
						{
							flag = (text.StartsWith("longitude") && inputType != RT3MapEditor.importFromFiles.supportedTypes.txtRT3);
							if (flag)
							{
								idx.lon = num4;
							}
							else
							{
								flag = (text.Equals("address 1") || text.Equals("adresse 1"));
								if (flag)
								{
									idx.address = num4;
								}
								else
								{
									flag = (text.Equals("city") || text.Equals("ville"));
									if (flag)
									{
										idx.city = num4;
									}
									else
									{
										flag = (text.StartsWith("tel") || text.StartsWith("phone"));
										if (flag)
										{
											idx.tel = num4;
										}
										else
										{
											flag = (text.Equals("brand") || text.Equals("marque"));
											if (flag)
											{
												idx.brand = num4;
											}
											else
											{
												flag = (text.Equals("other data") || text.Equals("informations"));
												if (flag)
												{
													idx.comment = num4;
												}
												else
												{
													flag = (text.Equals("ert3") && inputType == RT3MapEditor.importFromFiles.supportedTypes.txtRT3);
													if (flag)
													{
														idx.ERT3 = num4;
													}
													else
													{
														flag = (text.Equals("nrt3") && inputType == RT3MapEditor.importFromFiles.supportedTypes.txtRT3);
														if (flag)
														{
															idx.NRT3 = num4;
														}
														else
														{
															flag = (text.Equals("type") && inputType == RT3MapEditor.importFromFiles.supportedTypes.txtRT3);
															if (flag)
															{
																idx.type = num4;
															}
															else
															{
																flag = (text.Equals("magnitude") && inputType == RT3MapEditor.importFromFiles.supportedTypes.txtRT3);
																if (flag)
																{
																	idx.magnitude = num4;
																}
																else
																{
																	flag = (text.Equals("ct") && inputType == RT3MapEditor.importFromFiles.supportedTypes.txtRT3);
																	if (flag)
																	{
																		idx.ct = num4;
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
					}
					num4++;
				}
				flag = (inputType == RT3MapEditor.importFromFiles.supportedTypes.txtRT3);
				if (flag)
				{
					bool flag2 = idx.name != -1 && idx.address != -1 && idx.city != -1 && idx.tel != -1 && idx.brand != -1 && idx.comment != -1 && idx.ERT3 != -1 && idx.NRT3 != -1 && idx.type != -1 && idx.magnitude != -1 && idx.ct != -1;
					if (flag2)
					{
						idx.minColumn = 11;
						result = true;
					}
				}
				else
				{
					bool flag2 = idx.name != -1 && idx.lat != -1 && idx.lon != -1;
					if (flag2)
					{
						idx.minColumn = 3;
						result = true;
					}
				}
				return result;
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00117ECC File Offset: 0x00116ECC
		private void formatPOIName(ref string[] currentRow, importFromFiles.index idx, STArchives.STArchiveType archiveType, STArchives.entryType entryType)
		{
			bool flag = idx.name != -1;
			if (flag)
			{
				switch (archiveType)
				{
				case STArchives.STArchiveType.ArcAlgpsPlus:
					currentRow[idx.name] = this.formatAlGpsPlusName(currentRow[idx.name], archiveType, entryType);
					break;
				case STArchives.STArchiveType.ArcWarningRadar:
					currentRow[idx.name] = this.formatWRName(currentRow[idx.name], archiveType, entryType);
					break;
				}
			}
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00117F54 File Offset: 0x00116F54
		private string formatWRName(string name, STArchives.STArchiveType archiveType, STArchives.entryType entryType)
		{
			string[] array = name.Split(new char[]
			{
				' '
			});
			bool flag = array.Length != 4;
			string result;
			if (flag)
			{
				result = name;
			}
			else
			{
				string arg = array[1].Substring(1);
				string text = array[2].Substring(1);
				switch (entryType)
				{
				case STArchives.entryType.ZD:
					result = string.Format("RD{0:G}", arg);
					break;
				case STArchives.entryType.RF:
					result = string.Format("RF{0:G}-{1:G}km/h-NC", arg, text.PadLeft(3, '0'));
					break;
				case STArchives.entryType.RFR:
					result = string.Format("PAN{0:G}", arg);
					break;
				case STArchives.entryType.RM:
					result = string.Format("RM{0:G}-{1:G}km/h-NC", arg, text.PadLeft(3, '0'));
					break;
				default:
					result = name;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00118024 File Offset: 0x00117024
		private string formatAlGpsPlusName(string name, STArchives.STArchiveType archiveType, STArchives.entryType entryType)
		{
			string[] array = name.Split(new char[]
			{
				' '
			});
			bool flag = array.Length < 5;
			string result;
			if (flag)
			{
				result = name;
			}
			else
			{
				string arg = array[1];
				string text = array[3].Substring(0, checked(array[3].Length - 4));
				switch (entryType)
				{
				case STArchives.entryType.ZD:
					result = string.Format("RD{0:G}", arg);
					break;
				case STArchives.entryType.RF:
					result = string.Format("RF{0:G}-{1:G}km/h-NC", arg, text.PadLeft(3, '0'));
					break;
				case STArchives.entryType.RFR:
					result = string.Format("PAN{0:G}", arg);
					break;
				case STArchives.entryType.RM:
					result = string.Format("RM{0:G}-{1:G}km/h-NC", arg, text.PadLeft(3, '0'));
					break;
				default:
					result = name;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x001180F8 File Offset: 0x001170F8
		private bool textFieldParse(string fileName, TextFieldParser tfp, importFromFiles.supportedTypes inputType, importFromFiles.index idx, STArchives.STArchiveType archiveType, STArchives.entryType entryType)
		{
			int num = 1;
			bool flag = true;
			string[] array = null;
			this.tmpListOfPOI = new List<POIDatas>();
			checked
			{
				while (!tfp.EndOfData)
				{
					bool flag3;
					try
					{
						string text = tfp.PeekChars(1);
						bool flag2 = Operators.CompareString(text, "", false) != 0 && Operators.CompareString(text, ";", false) != 0 && Strings.Asc(text) != 0 && Strings.Asc(text) != 5;
						if (flag2)
						{
							array = tfp.ReadFields();
							flag2 = (flag && (inputType == RT3MapEditor.importFromFiles.supportedTypes.txtRT3 || inputType == RT3MapEditor.importFromFiles.supportedTypes.csv));
							if (flag2)
							{
								flag3 = !this.validHeader(array, ref idx, inputType);
								if (flag3)
								{
									this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(string.Format(Resources.strErrInvalidHeader, tfp.LineNumber - 1L, fileName), array, false, false, true, this.multipleImport);
									return false;
								}
							}
							else
							{
								flag3 = (array.Length < idx.minColumn);
								if (flag3)
								{
									flag2 = MySettingsProperty.Settings.importErrIncFormat;
									if (flag2)
									{
										this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(string.Format(Resources.strErrInvalidLine, tfp.LineNumber - 1L, fileName), array, true, true, true, this.multipleImport);
										switch (this._errorAction)
										{
										case NonFatalErrorBox.DialResult.Abort:
										case NonFatalErrorBox.DialResult.AbortAll:
											return false;
										}
									}
								}
								else
								{
									POIDatas poidatas = new POIDatas(this._POIList.type, this._POIList.scale, this._POIList.layer, this._POIList.magnitude, this._POIList.fullPatch, this._POIList.displayMagnitude);
									this.formatPOIName(ref array, idx, archiveType, entryType);
									POIDatas.errorCodes errorCodes = poidatas.initByString(array, idx);
									flag3 = (errorCodes == POIDatas.errorCodes.ok);
									if (flag3)
									{
										this.tmpListOfPOI.Add(poidatas);
									}
									else
									{
										switch (this._POIList.displayImportErr(errorCodes, fileName, array, idx, (int)tfp.LineNumber - 1, this.multipleImport))
										{
										case NonFatalErrorBox.DialResult.Abort:
										case NonFatalErrorBox.DialResult.AbortAll:
											return false;
										}
									}
								}
							}
							flag = false;
						}
						else
						{
							tfp.ReadLine();
						}
					}
					catch (MalformedLineException ex)
					{
						flag3 = MySettingsProperty.Settings.importErrIncFormat;
						if (flag3)
						{
							this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(string.Format(Resources.strErrInvalidLine, tfp.LineNumber - 1L, fileName), tfp.ErrorLine, true, true, true, this.multipleImport);
							switch (this._errorAction)
							{
							case NonFatalErrorBox.DialResult.Abort:
							case NonFatalErrorBox.DialResult.AbortAll:
								return false;
							}
						}
					}
					num++;
					flag3 = (num % 1000 == 0);
					if (flag3)
					{
						Application.DoEvents();
					}
				}
				tfp.Close();
				return true;
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00118414 File Offset: 0x00117414
		private bool initFromAscCsvStream(string fileName, Stream inputStream, STArchives.STArchiveType archiveType, STArchives.entryType entryType)
		{
			TextFieldParser textFieldParser = null;
			bool flag = Operators.CompareString(fileName, "", false) == 0;
			if (flag)
			{
				this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(string.Format(Resources.strErrInvalidFileName, fileName), "", false, false, true, this.multipleImport);
				switch (this._errorAction)
				{
				case NonFatalErrorBox.DialResult.Abort:
				case NonFatalErrorBox.DialResult.AbortAll:
					return false;
				}
			}
			string extension = Path.GetExtension(fileName);
			string left = extension.ToLower();
			flag = (Operators.CompareString(left, ".csv", false) == 0);
			bool result;
			if (flag)
			{
				try
				{
					textFieldParser = new TextFieldParser(inputStream, Common.RT3Encoding, true);
				}
				catch (Exception ex)
				{
					this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(string.Format(Resources.strErrUnable2Open, fileName), "", false, false, true, this.multipleImport);
					switch (this._errorAction)
					{
					case NonFatalErrorBox.DialResult.Abort:
					case NonFatalErrorBox.DialResult.AbortAll:
						return false;
					}
				}
				textFieldParser.HasFieldsEnclosedInQuotes = MySettingsProperty.Settings.importTxtQuoted;
				textFieldParser.TextFieldType = FieldType.Delimited;
				textFieldParser.SetDelimiters(new string[]
				{
					Conversions.ToString(Strings.ChrW(MySettingsProperty.Settings.importCsvSepInt))
				});
				importFromFiles.index idx = RT3MapEditor.importFromFiles.initIndex(RT3MapEditor.importFromFiles.supportedTypes.csv);
				result = this.textFieldParse(fileName, textFieldParser, RT3MapEditor.importFromFiles.supportedTypes.csv, idx, STArchives.STArchiveType.ArcUnknown, entryType);
			}
			else
			{
				flag = (Operators.CompareString(left, ".rt3", false) == 0 || Operators.CompareString(left, ".rtxme", false) == 0);
				if (flag)
				{
					try
					{
						textFieldParser = new TextFieldParser(inputStream, Common.RT3Encoding, true);
					}
					catch (Exception ex2)
					{
						this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(string.Format(Resources.strErrUnable2Open, fileName), "", false, false, true, this.multipleImport);
						switch (this._errorAction)
						{
						case NonFatalErrorBox.DialResult.Abort:
						case NonFatalErrorBox.DialResult.AbortAll:
							return false;
						}
					}
					textFieldParser.HasFieldsEnclosedInQuotes = true;
					textFieldParser.TextFieldType = FieldType.Delimited;
					textFieldParser.SetDelimiters(new string[]
					{
						"\t"
					});
					importFromFiles.index idx = RT3MapEditor.importFromFiles.initIndex(RT3MapEditor.importFromFiles.supportedTypes.txtRT3);
					result = this.textFieldParse(fileName, textFieldParser, RT3MapEditor.importFromFiles.supportedTypes.txtRT3, idx, STArchives.STArchiveType.ArcUnknown, STArchives.entryType.Unknown);
				}
				else
				{
					flag = (Operators.CompareString(left, ".asc", false) == 0);
					if (flag)
					{
						try
						{
							textFieldParser = new TextFieldParser(inputStream, Common.RT3Encoding, true);
						}
						catch (Exception ex3)
						{
							this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(string.Format(Resources.strErrUnable2Open, fileName), "", false, false, true, this.multipleImport);
							switch (this._errorAction)
							{
							case NonFatalErrorBox.DialResult.Abort:
							case NonFatalErrorBox.DialResult.AbortAll:
								return false;
							}
						}
						textFieldParser.HasFieldsEnclosedInQuotes = MySettingsProperty.Settings.importAscQuoted;
						textFieldParser.TextFieldType = FieldType.Delimited;
						textFieldParser.SetDelimiters(new string[]
						{
							","
						});
						importFromFiles.index idx = RT3MapEditor.importFromFiles.initIndex(RT3MapEditor.importFromFiles.supportedTypes.asc);
						result = this.textFieldParse(fileName, textFieldParser, RT3MapEditor.importFromFiles.supportedTypes.asc, idx, archiveType, entryType);
					}
					else
					{
						this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(string.Format(Resources.strErrTypeNotSupported, extension), false, false, true, this.multipleImport);
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x001187C0 File Offset: 0x001177C0
		private void AssignType(string fileName, bool multipleImport, bool typeInFile, Common.RTxMapEditorMapModes RTxMapEditorMapMode)
		{
			POILists poilist = this._POIList;
			poilist._displayMagnitude = false;
			poilist._fullPatch = false;
			if (typeInFile)
			{
				bool flag = RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert;
				if (flag)
				{
					poilist.setType(1002);
					poilist.setMagnitude(3);
				}
			}
			else if (multipleImport)
			{
				poilist.setType(MySettingsProperty.Settings.STimportAllType);
				poilist.setMagnitude(MySettingsProperty.Settings.STimportAllMag);
			}
			else
			{
				bool flag = RTxMapEditorMapMode == Common.RTxMapEditorMapModes.alert;
				if (flag)
				{
					poilist.setType(1002);
					poilist.setMagnitude(3);
				}
				else
				{
					flag = (fileName.EndsWith("RF-130.asc") || fileName.EndsWith("RD.asc"));
					if (flag)
					{
						poilist.setType(MySettingsProperty.Settings.STImportF120_130GType);
						poilist.setMagnitude(MySettingsProperty.Settings.STImportF120_130GMag);
					}
					else
					{
						flag = fileName.EndsWith("RF-110.asc");
						if (flag)
						{
							poilist.setType(MySettingsProperty.Settings.STImportF100_119Type);
							poilist.setMagnitude(MySettingsProperty.Settings.STImportF100_119Mag);
						}
						else
						{
							flag = fileName.EndsWith("RF-090.asc");
							if (flag)
							{
								poilist.setType(MySettingsProperty.Settings.STImportF80_99Type);
								poilist.setMagnitude(MySettingsProperty.Settings.STImportF80_99Mag);
							}
							else
							{
								flag = (fileName.EndsWith("RF-080.asc") || fileName.EndsWith("RF-070.asc"));
								if (flag)
								{
									poilist.setType(MySettingsProperty.Settings.STImportF60_79Type);
									poilist.setMagnitude(MySettingsProperty.Settings.STImportF60_79Mag);
								}
								else
								{
									flag = (fileName.EndsWith("RF-050.asc") || fileName.EndsWith("RF-030.asc"));
									if (flag)
									{
										this._POIList.setType(MySettingsProperty.Settings.STImportF0_59Type);
										this._POIList.setMagnitude(MySettingsProperty.Settings.STImportF0_59Mag);
									}
									else
									{
										flag = fileName.EndsWith("RM-130.asc");
										if (flag)
										{
											poilist.setType(MySettingsProperty.Settings.STImportM120_130Type);
											poilist.setMagnitude(MySettingsProperty.Settings.STImportM120_130Mag);
										}
										else
										{
											flag = fileName.EndsWith("RM-110.asc");
											if (flag)
											{
												poilist.setType(MySettingsProperty.Settings.STImportM100_119Type);
												poilist.setMagnitude(MySettingsProperty.Settings.STImportM100_119Mag);
											}
											else
											{
												flag = fileName.EndsWith("RM-090.asc");
												if (flag)
												{
													poilist.setType(MySettingsProperty.Settings.STImportM80_99Type);
													poilist.setMagnitude(MySettingsProperty.Settings.STImportM80_99Mag);
												}
												else
												{
													flag = (fileName.EndsWith("RM-080.asc") || fileName.EndsWith("RM-070.asc"));
													if (flag)
													{
														poilist.setType(MySettingsProperty.Settings.STImportM60_79Type);
														poilist.setMagnitude(MySettingsProperty.Settings.STImportM60_79Mag);
													}
													else
													{
														bool flag2;
														if (!fileName.EndsWith("RM-060.asc") && !fileName.EndsWith("RM-050.asc"))
														{
															if (!fileName.EndsWith("RM-045.asc"))
															{
																if (!fileName.EndsWith("RM-040.asc"))
																{
																	if (!fileName.EndsWith("RM-030.asc"))
																	{
																		flag2 = false;
																		goto IL_316;
																	}
																}
															}
														}
														flag2 = true;
														IL_316:
														flag = flag2;
														if (flag)
														{
															poilist.setType(MySettingsProperty.Settings.STImportM0_59Type);
															poilist.setMagnitude(MySettingsProperty.Settings.STImportM0_59Mag);
														}
														else
														{
															flag = fileName.EndsWith("RadarsFR.asc");
															if (flag)
															{
																poilist.setType(MySettingsProperty.Settings.STImportRFRType);
																poilist.setMagnitude(MySettingsProperty.Settings.STImportRFRMag);
															}
															else
															{
																flag = fileName.EndsWith("radarsF.txt");
																if (flag)
																{
																	poilist.setType(MySettingsProperty.Settings.STimportFixedType);
																	poilist.setMagnitude(MySettingsProperty.Settings.STImportFixedMag);
																}
																else
																{
																	flag = fileName.EndsWith("radarsM.txt");
																	if (flag)
																	{
																		poilist.setType(MySettingsProperty.Settings.STimportMobileType);
																		poilist.setMagnitude(MySettingsProperty.Settings.STimportMobileMag);
																	}
																	else
																	{
																		flag = (fileName.EndsWith("RF.asc") || fileName.EndsWith("RFR.asc"));
																		if (flag)
																		{
																			poilist.setType(MySettingsProperty.Settings.STimportFixedType);
																			poilist.setMagnitude(MySettingsProperty.Settings.STImportFixedMag);
																		}
																		else
																		{
																			flag = fileName.EndsWith("RM.txt");
																			if (flag)
																			{
																				poilist.setType(MySettingsProperty.Settings.STimportMobileType);
																				poilist.setMagnitude(MySettingsProperty.Settings.STimportMobileMag);
																			}
																			else
																			{
																				poilist.setType(MySettingsProperty.Settings.importDefaultType);
																				poilist.setMagnitude(MySettingsProperty.Settings.importDefaultMag);
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
							}
						}
					}
				}
			}
		}

		// Token: 0x04000498 RID: 1176
		private POILists _POIList;

		// Token: 0x04000499 RID: 1177
		private NonFatalErrorBox.DialResult _errorAction;

		// Token: 0x0400049A RID: 1178
		private bool multipleImport;

		// Token: 0x0400049B RID: 1179
		private List<POIDatas> tmpListOfPOI;

		// Token: 0x0200005D RID: 93
		public struct index
		{
			// Token: 0x0400049C RID: 1180
			public int name;

			// Token: 0x0400049D RID: 1181
			public int lat;

			// Token: 0x0400049E RID: 1182
			public int lon;

			// Token: 0x0400049F RID: 1183
			public int address;

			// Token: 0x040004A0 RID: 1184
			public int city;

			// Token: 0x040004A1 RID: 1185
			public int tel;

			// Token: 0x040004A2 RID: 1186
			public int brand;

			// Token: 0x040004A3 RID: 1187
			public int comment;

			// Token: 0x040004A4 RID: 1188
			public int ERT3;

			// Token: 0x040004A5 RID: 1189
			public int NRT3;

			// Token: 0x040004A6 RID: 1190
			public int type;

			// Token: 0x040004A7 RID: 1191
			public int magnitude;

			// Token: 0x040004A8 RID: 1192
			public int ct;

			// Token: 0x040004A9 RID: 1193
			public int minColumn;
		}

		// Token: 0x0200005E RID: 94
		public enum supportedTypes
		{
			// Token: 0x040004AB RID: 1195
			asc,
			// Token: 0x040004AC RID: 1196
			txtRT3,
			// Token: 0x040004AD RID: 1197
			csv,
			// Token: 0x040004AE RID: 1198
			unSupported
		}
	}
}
