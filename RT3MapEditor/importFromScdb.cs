using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000060 RID: 96
	public class importFromScdb
	{
		// Token: 0x06000C93 RID: 3219 RVA: 0x001196E0 File Offset: 0x001186E0
		public importFromScdb(POILists POIList)
		{
			this.FList = null;
			this.F120_130List = null;
			this.F100_119List = null;
			this.F80_99List = null;
			this.F60_79List = null;
			this.F0_59List = null;
			this.RFRList = null;
			this.idx = importFromFiles.initIndex(importFromFiles.supportedTypes.asc);
			this._POIList = POIList;
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0011973C File Offset: 0x0011873C
		public List<POILists> importFromScdb(string fileName)
		{
			Cursor value = null;
			ZipFile zipFile = null;
			XmlDocument xmlDocument = new XmlDocument();
			value = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			this._POIList.name = "";
			this._POIList._state = POILists.state.added;
			MyProject.Forms.NonFatalErrorBox.resetIgnoreErrors();
			this._errorAction = NonFatalErrorBox.DialResult.Close;
			List<POILists> result = null;
			try
			{
				zipFile = new ZipFile(fileName);
				Stream inputStream = zipFile.GetInputStream(zipFile.GetEntry("google_earth_scdb.kml"));
				xmlDocument.Load(inputStream);
				this.setLists2Import(fileName);
				result = this.initFromScdbStream(xmlDocument, fileName);
				zipFile.Close();
			}
			catch (XmlException ex)
			{
				zipFile.Close();
				this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(string.Format(Resources.strErrUnable2LoadScdb, fileName), "", false, false, true, false);
				result = null;
			}
			catch (ArgumentNullException ex2)
			{
				zipFile.Close();
				this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(string.Format(Resources.strErrUnable2Open, fileName), "", false, false, true, false);
				result = null;
			}
			catch (Exception ex3)
			{
				this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(string.Format(Resources.strErrUnable2Open, fileName), "", false, false, true, false);
				result = null;
			}
			Cursor.Current = value;
			return result;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x001198D4 File Offset: 0x001188D4
		private void setLists2Import(string fileName)
		{
			uint stimportMode = MySettingsProperty.Settings.STImportMode;
			bool flag = stimportMode == 4U || stimportMode == 8U;
			if (flag)
			{
				this.FList = new POILists(false, true);
				this.FList.name = Resources.strArchTypeFixed + Path.GetFileName(fileName);
				this.FList._state = POILists.state.added;
				flag = MySettingsProperty.Settings.STImportFixedTypeIsNP;
				if (flag)
				{
					this.FList.setType(4444);
				}
				else
				{
					this.FList.setType(MySettingsProperty.Settings.STimportFixedType);
				}
				this.FList.setType(MySettingsProperty.Settings.STimportFixedType);
				this.FList.setMagnitude(MySettingsProperty.Settings.STImportFixedMag);
			}
			else
			{
				flag = (stimportMode == 1024U);
				if (flag)
				{
					this.F120_130List = new POILists(false, true);
					this.F120_130List.name = Resources.strArchTypeF120_130G + Path.GetFileName(fileName);
					this.F120_130List._state = POILists.state.added;
					this.F120_130List.setType(MySettingsProperty.Settings.STImportF120_130GType);
					this.F120_130List.setMagnitude(MySettingsProperty.Settings.STImportF120_130GMag);
					this.F100_119List = new POILists(false, true);
					this.F100_119List.name = Resources.strArchTypeF100_119 + Path.GetFileName(fileName);
					this.F100_119List._state = POILists.state.added;
					this.F100_119List.setType(MySettingsProperty.Settings.STImportF100_119Type);
					this.F100_119List.setMagnitude(MySettingsProperty.Settings.STImportF100_119Mag);
					this.F80_99List = new POILists(false, true);
					this.F80_99List.name = Resources.strArchTypeF80_99 + Path.GetFileName(fileName);
					this.F80_99List._state = POILists.state.added;
					this.F80_99List.setType(MySettingsProperty.Settings.STImportF80_99Type);
					this.F80_99List.setMagnitude(MySettingsProperty.Settings.STImportF80_99Mag);
					this.F60_79List = new POILists(false, true);
					this.F60_79List.name = Resources.strArchTypeF60_79 + Path.GetFileName(fileName);
					this.F60_79List._state = POILists.state.added;
					this.F60_79List.setType(MySettingsProperty.Settings.STImportF60_79Type);
					this.F60_79List.setMagnitude(MySettingsProperty.Settings.STImportF60_79Mag);
					this.F0_59List = new POILists(false, true);
					this.F0_59List.name = Resources.strArchTypeF0_59 + Path.GetFileName(fileName);
					this.F0_59List._state = POILists.state.added;
					this.F0_59List.setType(MySettingsProperty.Settings.STImportF0_59Type);
					this.F0_59List.setMagnitude(MySettingsProperty.Settings.STImportF0_59Mag);
					this.RFRList = new POILists(false, true);
					this.RFRList.name = Resources.strArchTypeRFR + Path.GetFileName(fileName);
					this.RFRList._state = POILists.state.added;
					this.RFRList.setType(MySettingsProperty.Settings.STImportRFRType);
					this.RFRList.setMagnitude(MySettingsProperty.Settings.STImportRFRMag);
				}
			}
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00119BFC File Offset: 0x00118BFC
		private List<POILists> initFromScdbStream(XmlDocument xmlDoc, string fileName)
		{
			string radarSpeed = null;
			importFromScdb.radarType radarType = RT3MapEditor.importFromScdb.radarType.RF;
			string[] array = null;
			XmlNodeList elementsByTagName = xmlDoc.GetElementsByTagName("Placemark");
			bool flag;
			try
			{
				try
				{
					foreach (object obj in elementsByTagName)
					{
						XmlNode placemarkNode = (XmlNode)obj;
						array = this.getRadarParam(placemarkNode, ref radarSpeed, ref radarType);
						flag = (radarType != RT3MapEditor.importFromScdb.radarType.NA);
						if (flag)
						{
							POIDatas poidatas = new POIDatas(this._POIList.type, this._POIList.scale, this._POIList.layer, this._POIList.magnitude, this._POIList.fullPatch, this._POIList.displayMagnitude);
							POIDatas.errorCodes errorCodes = poidatas.initByString(array, this.idx);
							flag = (errorCodes == POIDatas.errorCodes.ok);
							if (flag)
							{
								this.getLists2Import(radarType, radarSpeed).ListofPOI.Add(poidatas);
							}
							else
							{
								switch (this._POIList.displayImportErr(errorCodes, fileName, array, this.idx, 0, false))
								{
								case NonFatalErrorBox.DialResult.Abort:
								case NonFatalErrorBox.DialResult.AbortAll:
									return null;
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag = (enumerator is IDisposable);
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				string errText = string.Format(Resources.strErrUnknown, 0, fileName);
				this._errorAction = MyProject.Forms.NonFatalErrorBox.showError(errText, array, true, true, true, false);
				return null;
			}
			List<POILists> list = new List<POILists>();
			uint stimportMode = MySettingsProperty.Settings.STImportMode;
			flag = (stimportMode == 4U || stimportMode == 8U);
			if (flag)
			{
				list.Add(this.FList);
			}
			else
			{
				flag = (stimportMode == 1024U);
				if (flag)
				{
					bool flag2 = this.F120_130List.POINumber > 0;
					if (flag2)
					{
						list.Add(this.F120_130List);
					}
					flag2 = (this.F100_119List.POINumber > 0);
					if (flag2)
					{
						list.Add(this.F100_119List);
					}
					flag2 = (this.F80_99List.POINumber > 0);
					if (flag2)
					{
						list.Add(this.F80_99List);
					}
					flag2 = (this.F60_79List.POINumber > 0);
					if (flag2)
					{
						list.Add(this.F60_79List);
					}
					flag2 = (this.F0_59List.POINumber > 0);
					if (flag2)
					{
						list.Add(this.F0_59List);
					}
					flag2 = (this.RFRList.POINumber > 0);
					if (flag2)
					{
						list.Add(this.RFRList);
					}
				}
			}
			return list;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00119EE8 File Offset: 0x00118EE8
		private string[] getRadarParam(XmlNode placemarkNode, ref string radarSpeed, ref importFromScdb.radarType radarType)
		{
			string[] array = new string[]
			{
				"",
				"",
				""
			};
			string innerText = placemarkNode["styleUrl"].InnerText;
			string innerText2 = placemarkNode["description"].InnerText;
			XmlElement xmlElement = placemarkNode["Point"];
			string innerText3 = xmlElement["coordinates"].InnerText;
			int num = innerText2.IndexOf(',');
			bool flag = num != -1;
			string arg;
			if (flag)
			{
				arg = innerText2.Substring(0, num).Trim();
			}
			else
			{
				arg = "";
			}
			radarType = this.getRadarType(innerText);
			switch (radarType)
			{
			case RT3MapEditor.importFromScdb.radarType.RF:
				radarSpeed = this.getRadarSpeed(innerText);
				flag = (radarSpeed != null);
				if (flag)
				{
					array[this.idx.name] = string.Format("RF{0:G}-{1:G}km/h-NC", arg, radarSpeed);
				}
				else
				{
					array[this.idx.name] = string.Format("RF{0:G}-NC", arg);
				}
				break;
			case RT3MapEditor.importFromScdb.radarType.RFR:
				array[this.idx.name] = string.Format("RFR{0:G}", arg);
				break;
			case RT3MapEditor.importFromScdb.radarType.NA:
				array[this.idx.name] = null;
				break;
			}
			string[] array2 = innerText3.Split(new char[]
			{
				','
			});
			array[this.idx.lon] = array2[0];
			array[this.idx.lat] = array2[1];
			return array;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0011A080 File Offset: 0x00119080
		private string getRadarSpeed(string styleURL)
		{
			int num = styleURL.LastIndexOf('0');
			bool flag = num != -1;
			checked
			{
				string result;
				if (flag)
				{
					bool flag2 = num == 7;
					if (flag2)
					{
						result = "0" + styleURL.Substring(6, num - 5);
					}
					else
					{
						result = styleURL.Substring(6, num - 5);
					}
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0011A0DC File Offset: 0x001190DC
		private importFromScdb.radarType getRadarType(string styleURL)
		{
			bool flag = Operators.CompareString(styleURL, "#SCDB_Ampel", false) == 0;
			importFromScdb.radarType result;
			if (flag)
			{
				result = RT3MapEditor.importFromScdb.radarType.RFR;
			}
			else
			{
				flag = (styleURL.IndexOf('0') != -1 || styleURL.IndexOf("variab") != -1);
				if (flag)
				{
					result = RT3MapEditor.importFromScdb.radarType.RF;
				}
				else
				{
					result = RT3MapEditor.importFromScdb.radarType.NA;
				}
			}
			return result;
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0011A134 File Offset: 0x00119134
		private POILists getLists2Import(importFromScdb.radarType radarType, string radarSpeed)
		{
			uint stimportMode = MySettingsProperty.Settings.STImportMode;
			bool flag = stimportMode == 4U || stimportMode == 8U;
			POILists result;
			if (flag)
			{
				result = this.FList;
			}
			else
			{
				flag = (stimportMode == 1024U);
				if (flag)
				{
					bool flag2 = radarType == RT3MapEditor.importFromScdb.radarType.RFR;
					if (flag2)
					{
						result = this.RFRList;
					}
					else
					{
						bool flag3;
						if (Operators.CompareString(radarSpeed, "010", false) != 0 && Operators.CompareString(radarSpeed, "020", false) != 0)
						{
							if (Operators.CompareString(radarSpeed, "030", false) != 0)
							{
								if (Operators.CompareString(radarSpeed, "040", false) != 0)
								{
									if (Operators.CompareString(radarSpeed, "050", false) != 0)
									{
										flag3 = false;
										goto IL_B4;
									}
								}
							}
						}
						flag3 = true;
						IL_B4:
						flag2 = flag3;
						if (flag2)
						{
							result = this.F0_59List;
						}
						else
						{
							flag2 = (Operators.CompareString(radarSpeed, "060", false) == 0 || Operators.CompareString(radarSpeed, "070", false) == 0);
							if (flag2)
							{
								result = this.F60_79List;
							}
							else
							{
								flag2 = (Operators.CompareString(radarSpeed, "080", false) == 0 || Operators.CompareString(radarSpeed, "090", false) == 0);
								if (flag2)
								{
									result = this.F80_99List;
								}
								else
								{
									flag2 = (Operators.CompareString(radarSpeed, "100", false) == 0 || Operators.CompareString(radarSpeed, "110", false) == 0);
									if (flag2)
									{
										result = this.F100_119List;
									}
									else
									{
										flag2 = (Operators.CompareString(radarSpeed, "120, 130", false) == 0);
										if (flag2)
										{
											result = this.F120_130List;
										}
										else
										{
											result = this.F120_130List;
										}
									}
								}
							}
						}
					}
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x040004B0 RID: 1200
		private POILists _POIList;

		// Token: 0x040004B1 RID: 1201
		private NonFatalErrorBox.DialResult _errorAction;

		// Token: 0x040004B2 RID: 1202
		private POILists FList;

		// Token: 0x040004B3 RID: 1203
		private POILists F120_130List;

		// Token: 0x040004B4 RID: 1204
		private POILists F100_119List;

		// Token: 0x040004B5 RID: 1205
		private POILists F80_99List;

		// Token: 0x040004B6 RID: 1206
		private POILists F60_79List;

		// Token: 0x040004B7 RID: 1207
		private POILists F0_59List;

		// Token: 0x040004B8 RID: 1208
		private POILists RFRList;

		// Token: 0x040004B9 RID: 1209
		private importFromFiles.index idx;

		// Token: 0x02000061 RID: 97
		private enum radarType
		{
			// Token: 0x040004BB RID: 1211
			RF,
			// Token: 0x040004BC RID: 1212
			RFR,
			// Token: 0x040004BD RID: 1213
			NA
		}
	}
}
