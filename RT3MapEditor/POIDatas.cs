using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x02000063 RID: 99
	public class POIDatas
	{
		// Token: 0x06000CA1 RID: 3233 RVA: 0x0011A7B0 File Offset: 0x001197B0
		public POIDatas()
		{
			this.errorCode = POIDatas.errorCodes.ok;
			this._UId = this._getNextUid();
			this.listOfCanonical = new List<POIDatas.POIAlias>();
			this.listOfAlternates = new List<POIDatas.POIAlias>();
			this.isGeoCoordSearchable = false;
			this.isPlaneCoordSearchable = false;
			this._lat = 10000.0;
			this._lon = 10000.0;
			this.toSkip = false;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0011A824 File Offset: 0x00119824
		public POIDatas(ushort type, byte scale, byte layer, byte magnitude, bool fullPatch, bool displayMagnitude)
		{
			this.errorCode = POIDatas.errorCodes.ok;
			this._UId = this._getNextUid();
			this.listOfCanonical = new List<POIDatas.POIAlias>();
			this.listOfAlternates = new List<POIDatas.POIAlias>();
			this.type = type;
			this.scale = scale;
			this.layer = layer;
			this.magnitude = magnitude;
			this.fullPatch = fullPatch;
			this.displayMagnitude = displayMagnitude;
			this.isGeoCoordSearchable = false;
			this.isPlaneCoordSearchable = false;
			this.speed = 0U;
			this.angle = 468.21;
			this._lat = 10000.0;
			this._lon = 10000.0;
			this.toSkip = false;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0011A8DC File Offset: 0x001198DC
		public POIDatas.errorCodes initByString(string[] currentRow, importFromFiles.index idx)
		{
			bool flag = idx.ERT3 != -1 && idx.NRT3 != -1;
			checked
			{
				POIDatas.errorCodes result;
				if (flag)
				{
					int num;
					bool flag2 = !int.TryParse(currentRow[idx.ERT3], NumberStyles.Integer, POIDatas.cultForParse, out num);
					if (flag2)
					{
						result = POIDatas.errorCodes.incorrectLatFormat;
					}
					else
					{
						flag2 = (POIDatas.mapType == Common.RTxMapType.RT3);
						if (flag2)
						{
							this._ERTX = (uint)num;
						}
						else
						{
							this._ERTX = (uint)projection.ERT3ToERT4(num);
						}
						int num2;
						flag2 = !int.TryParse(currentRow[idx.NRT3], NumberStyles.Integer, POIDatas.cultForParse, out num2);
						if (flag2)
						{
							result = POIDatas.errorCodes.incorrectLonFormat;
						}
						else
						{
							flag2 = (POIDatas.mapType == Common.RTxMapType.RT3);
							if (flag2)
							{
								this._NRTX = (uint)num2;
							}
							else
							{
								this._NRTX = (uint)projection.NRT3ToNRT4(num2);
							}
							result = this.initByEN(currentRow, idx);
						}
					}
				}
				else
				{
					bool flag2 = idx.lat != -1 && idx.lon != -1;
					if (flag2)
					{
						flag = !double.TryParse(currentRow[idx.lat].Replace(",", "."), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, POIDatas.cultForParse, out this._lat);
						if (flag)
						{
							result = POIDatas.errorCodes.incorrectLatFormat;
						}
						else
						{
							flag2 = !double.TryParse(currentRow[idx.lon].Replace(",", "."), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, POIDatas.cultForParse, out this._lon);
							if (flag2)
							{
								result = POIDatas.errorCodes.incorrectLonFormat;
							}
							else
							{
								result = this.initByLatLon(currentRow, idx);
							}
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0011AA64 File Offset: 0x00119A64
		public POIDatas.errorCodes initByLatLon(string[] currentRow, importFromFiles.index idx)
		{
			bool flag = this._lat < 27.0 || this._lat > 72.0;
			checked
			{
				POIDatas.errorCodes result;
				if (flag)
				{
					this.errorCode = POIDatas.errorCodes.LatOutOfRange;
					result = this.errorCode;
				}
				else
				{
					flag = (this._lon < -19.0 || this._lon > 27.0);
					if (flag)
					{
						this.errorCode = POIDatas.errorCodes.LonOutOfRange;
						result = this.errorCode;
					}
					else
					{
						XY xy = POIDatas.projection.proj(this._lon, this._lat);
						flag = (xy.X < 0.0 || xy.X > POIDatas.maxXYX);
						if (flag)
						{
							this.errorCode = POIDatas.errorCodes.LonOutOfRange;
							result = this.errorCode;
						}
						else
						{
							this._ERTX = (uint)Math.Round(Math.Round(xy.X));
							flag = (xy.Y < 0.0 || xy.Y > POIDatas.maxXYY);
							if (flag)
							{
								this.errorCode = POIDatas.errorCodes.LatOutOfRange;
								result = this.errorCode;
							}
							else
							{
								this._NRTX = (uint)Math.Round(Math.Round(xy.Y));
								result = this.initByEN(currentRow, idx);
							}
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0011ABC4 File Offset: 0x00119BC4
		public POIDatas.errorCodes initByEN(string[] currentRow, importFromFiles.index idx)
		{
			bool flag = this._ERTX > POIDatas.maxXYX;
			checked
			{
				POIDatas.errorCodes result;
				if (flag)
				{
					this.errorCode = POIDatas.errorCodes.LonOutOfRange;
					result = this.errorCode;
				}
				else
				{
					flag = (this._NRTX >= POIDatas.maxXYY);
					if (flag)
					{
						this.errorCode = POIDatas.errorCodes.LatOutOfRange;
						result = this.errorCode;
					}
					else
					{
						this.LS = (ushort)(unchecked((ulong)this._ERTX / 256000UL % (ulong)POIDatas.LSColumnNb) + unchecked((ulong)POIDatas.LSColumnNb) * (unchecked((ulong)this._NRTX) / 256000UL));
						this.MS = (byte)(unchecked((ulong)this._ERTX) % 256000UL / 16000UL + 16UL * (unchecked((ulong)this._NRTX) % 256000UL / 16000UL));
						this.SS = (byte)(unchecked((ulong)this._ERTX) % 16000UL / 1000UL + 16UL * (unchecked((ulong)this._NRTX) % 16000UL / 1000UL));
						this.X = (ushort)(unchecked((ulong)this._ERTX) % 1000UL);
						this.Y = (ushort)(unchecked((ulong)this._NRTX) % 1000UL);
						flag = (POIDatas._RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map && MyProject.Forms.FormMain.mapMngt.FRANC_EX_DPS.getFRANCDPA_POIIdx((uint)((int)this.MS + ((int)this.LS << 8)), this.SS) == uint.MaxValue);
						if (flag)
						{
							this.errorCode = POIDatas.errorCodes.LSMSempty;
							result = this.errorCode;
						}
						else
						{
							flag = (idx.type != -1 && currentRow.Length > idx.type);
							bool flag2;
							if (flag)
							{
								ushort num;
								flag2 = (ushort.TryParse(currentRow[idx.type], out num) && MyProject.Forms.FormMain.mapMngt.POITypeInfo.isTypeDefined(num));
								if (!flag2)
								{
									this.errorCode = POIDatas.errorCodes.badType;
									return this.errorCode;
								}
								this.type = num;
								this.layer = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getLayerOfType(num);
								this.scale = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getScaleOfType(num);
								this.fromRT3 = true;
							}
							else
							{
								this.fromRT3 = false;
							}
							flag2 = (idx.magnitude != -1 && currentRow.Length > idx.magnitude);
							if (flag2)
							{
								byte b;
								flag = byte.TryParse(currentRow[idx.magnitude], out b);
								if (!flag)
								{
									this.errorCode = POIDatas.errorCodes.badMagnitude;
									return this.errorCode;
								}
								this.magnitude = b;
							}
							flag2 = (idx.ct != -1 && currentRow.Length > idx.ct);
							if (flag2)
							{
								byte b2;
								flag = byte.TryParse(currentRow[idx.ct], out b2);
								if (!flag)
								{
									this.errorCode = POIDatas.errorCodes.badCt;
									return this.errorCode;
								}
								this.countryRT3 = b2;
							}
							POIDatas.POIAlias poialias = new POIDatas.POIAlias();
							poialias.typeFlagged = this.type;
							flag2 = (idx.name != -1 && currentRow.Length > idx.name);
							if (flag2)
							{
								this.origName = currentRow[idx.name].ToUpper().Substring(0, Math.Min(currentRow[idx.name].Length, 35));
								poialias.name = this.origName.PadRight(36, '\0');
								poialias.idxName = 1;
							}
							else
							{
								this.origName = "{..**..}";
								poialias.name = "{..**..}";
							}
							this.listOfCanonical.Add(poialias);
							flag2 = (idx.address != -1 && currentRow.Length > idx.address);
							if (flag2)
							{
								this.addressRT3 = new StringBuilder(currentRow[idx.address].ToUpper(), currentRow[idx.address].Length).Append('\0').ToString();
							}
							else
							{
								this.addressRT3 = new string('\0', 1);
							}
							flag2 = (idx.comment != -1 && currentRow.Length > idx.comment);
							if (flag2)
							{
								this.commentRT3 = currentRow[idx.comment];
							}
							else
							{
								this.commentRT3 = "";
							}
							this.telRT3 = ulong.MaxValue;
							flag2 = (idx.tel != -1 && currentRow.Length > idx.tel);
							if (flag2)
							{
								StringBuilder stringBuilder = new StringBuilder(20);
								int num2 = 0;
								int num3 = currentRow[idx.tel].Length - 1;
								int num4 = num2;
								for (;;)
								{
									int num5 = num4;
									int num6 = num3;
									if (num5 > num6)
									{
										break;
									}
									flag2 = (char.IsDigit(currentRow[idx.tel][num4]) || (num4 == 0 && Operators.CompareString(Conversions.ToString(currentRow[idx.tel][num4]), "+", false) == 0));
									if (flag2)
									{
										stringBuilder.Append(currentRow[idx.tel][num4]);
									}
									num4++;
								}
								flag2 = (stringBuilder.Length > 0 && Operators.CompareString(Conversions.ToString(stringBuilder[0]), "+", false) == 0);
								if (flag2)
								{
									string prefix = MyProject.Forms.FormMain.mapMngt.PrefInt.getPrefix(stringBuilder.ToString());
									flag2 = (prefix == null);
									if (flag2)
									{
										stringBuilder.Remove(0, 1);
									}
									else
									{
										stringBuilder.Remove(0, prefix.Length + 1);
									}
								}
								else
								{
									flag2 = (stringBuilder.Length == 10 && Operators.CompareString(Conversions.ToString(stringBuilder[0]), "0", false) == 0);
									if (flag2)
									{
										stringBuilder.Remove(0, 1);
									}
								}
								int num7 = stringBuilder.Length - 1;
								for (;;)
								{
									int num8 = num7;
									int num6 = 0;
									if (num8 < num6)
									{
										break;
									}
									int num9 = 4 * num7;
									ulong num10 = 15UL << num9;
									ulong num11 = (ulong)(stringBuilder[num7] - '0') << num9;
									this.telRT3 = ((this.telRT3 & ~num10) | num11);
									num7 += -1;
								}
							}
							this.isPlaneCoordSearchable = true;
							flag2 = (idx.city != -1 && currentRow.Length > idx.city);
							if (flag2)
							{
								this.scittaPtr = MyProject.Forms.FormMain.mapMngt.SCITTANAME_DAT.cityExists(currentRow[idx.city]);
							}
							else
							{
								flag2 = (POIDatas._RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
								if (flag2)
								{
									this.scittaPtr = MyProject.Forms.FormMain.mapMngt.SCITTANAME_DAT.nullNamePtr();
								}
								else
								{
									this.scittaPtr = 0U;
								}
							}
							this.isGeoCoordSearchable = false;
							this.compound = (uint)(0 | (int)this.X << 10 | (int)this.Y << 20);
							result = POIDatas.errorCodes.ok;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0011B28C File Offset: 0x0011A28C
		public void setType(ushort type)
		{
			this.type = type;
			this.scale = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getScaleOfType(type);
			this.layer = MyProject.Forms.FormMain.mapMngt.POITypeInfo.getLayerOfType(type);
			bool flag = this.listOfCanonical != null;
			checked
			{
				if (flag)
				{
					int num = 0;
					int num2 = this.listOfCanonical.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						this.listOfCanonical[num3].typeFlagged = type;
						num3++;
					}
				}
				flag = (this.listOfAlternates != null);
				if (flag)
				{
					int num6 = 0;
					int num7 = this.listOfAlternates.Count - 1;
					int num8 = num6;
					for (;;)
					{
						int num9 = num8;
						int num5 = num7;
						if (num9 > num5)
						{
							break;
						}
						this.listOfAlternates[num8].typeFlagged = type;
						num8++;
					}
				}
			}
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0011B36C File Offset: 0x0011A36C
		public void setScale(byte scale)
		{
			this.scale = scale;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x0011B378 File Offset: 0x0011A378
		public void setLayer(byte layer)
		{
			this.layer = layer;
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0011B384 File Offset: 0x0011A384
		public void setMagnitude(byte magnitude)
		{
			this.magnitude = magnitude;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0011B390 File Offset: 0x0011A390
		public void setFullPatch(bool fullPatch)
		{
			this.fullPatch = fullPatch;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0011B39C File Offset: 0x0011A39C
		public void setDisplayMagnitude(bool displayMagnitude)
		{
			this.displayMagnitude = displayMagnitude;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x0011B3A8 File Offset: 0x0011A3A8
		public void setSpeed(uint speed)
		{
			this.speed = speed;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0011B3B4 File Offset: 0x0011A3B4
		public void initByRT3values(FRANCXXXDSC.FrancDSCDatItems record, commonFiles commonFiles)
		{
			POIDatas.POIAlias poialias = new POIDatas.POIAlias();
			this.fromRT3 = true;
			this.fullPatch = false;
			this.displayMagnitude = false;
			this.isGeoCoordSearchable = true;
			this.magnitude = 0;
			this.type = (record.type & 32767);
			poialias.typeFlagged = record.type;
			this.countryRT3 = record.country;
			poialias.country = record.country;
			this.area = record.area;
			poialias.area = record.area;
			this.dpt = record.department;
			poialias.dpt = record.department;
			this.cityRT3 = record.city;
			poialias.city = record.city;
			this.district = record.district;
			poialias.district = record.district;
			FRANCPOI_DAT.FrancPOIDatRecords recordByRT3Ptr = commonFiles.francPOIDat.getRecordByRT3Ptr(record.FrancPOIPtr);
			FRANC_NOMSERV_DAT.FrancNomservDatRecords recordByRT3Idx = commonFiles.francNomservDat.getRecordByRT3Idx(record.FrancNomServIdx);
			GUIDA_CHAMPERARD_POI.GuidaChamperardRecords recordByRT3Ptr2 = commonFiles.GuidaChamperadPoi.getRecordByRT3Ptr(record.FrancPOIPtr);
			bool flag = recordByRT3Ptr != null;
			checked
			{
				if (flag)
				{
					FRANCPOI_DAT.FrancPOIDatRecords francPOIDatRecords = recordByRT3Ptr;
					this.addressRT3 = francPOIDatRecords.address;
					this.SS = francPOIDatRecords.SS;
					this.MS = francPOIDatRecords.MS;
					this.LS = francPOIDatRecords.LS;
					this.scittaPtr = francPOIDatRecords.ScittaNamePtr;
					this.scale = francPOIDatRecords.scale;
					this.layer = francPOIDatRecords.layer;
					this.compound = francPOIDatRecords.compound;
					this.X = francPOIDatRecords.X;
					this.Y = francPOIDatRecords.Y;
					this.francatFlag = francPOIDatRecords.francatFlag;
					this.brandIdx = francPOIDatRecords.brandIdx;
					this.telRT3 = francPOIDatRecords.tel;
					this._ERTX = 256000U * ((uint)this.LS % POIDatas.LSColumnNb) + 16000U * (uint)(this.MS % 16) + 1000U * (uint)(this.SS % 16) + (uint)this.X;
					this._NRTX = 256000U * ((uint)this.LS / POIDatas.LSColumnNb) + 16000U * (uint)(this.MS / 16) + 1000U * (uint)(this.SS / 16) + (uint)this.Y;
					flag = (recordByRT3Idx != null);
					bool flag2;
					if (flag)
					{
						FRANC_NOMSERV_DAT.FrancNomservDatRecords francNomservDatRecords = recordByRT3Idx;
						poialias.idxName = francNomservDatRecords.index;
						poialias.name = francNomservDatRecords.name;
						flag = (francNomservDatRecords.index != 1);
						if (flag)
						{
							flag2 = !MySettingsProperty.Settings.ignoreRTxAltName;
							if (flag2)
							{
								this.listOfAlternates.Add(poialias);
							}
							else
							{
								this.toSkip = true;
							}
						}
						else
						{
							this.listOfCanonical.Add(poialias);
							this.origName = francNomservDatRecords.name;
						}
						francNomservDatRecords.used = true;
					}
					else
					{
						this.origName = "{..**..}";
						poialias.name = "{..**..}";
						poialias.idxName = 1;
						this.listOfCanonical.Add(poialias);
						MyProject.Application.Log.WriteEntry(string.Format("RT3 map error: invalid index to FRANC_NOMSERV.DAT found in FRANC{0:G}.DSC (type={1:X} LS={2:X} MS={3:X} SS={4:X} address={5:G}). Name replaced by {6:G}", new object[]
						{
							POIDatas.categoryName,
							this.type,
							this.LS,
							this.MS,
							this.SS,
							this.addressRT3,
							"{..**..}"
						}));
					}
					flag2 = (recordByRT3Ptr2 != null);
					if (flag2)
					{
						this.commentRT3 = recordByRT3Ptr2.comment;
					}
					else
					{
						this.commentRT3 = null;
					}
				}
				else
				{
					this.toSkip = true;
					MyProject.Application.Log.WriteEntry(string.Format("RT3 map error: invalid pointer to FRANCPOI.DAT in FRANC{0:G}.DSC (type={1:X} country={2:X} area={3:X} dpt={4:X} city={5:X} district={6:X}). Record skipped.", new object[]
					{
						POIDatas.categoryName,
						this.type,
						this.countryRT3,
						this.area,
						this.dpt,
						this.cityRT3,
						this.district
					}));
				}
			}
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0011B818 File Offset: 0x0011A818
		public void addAlias(FRANCXXXDSC.FrancDSCDatItems record, commonFiles commonFiles)
		{
			POIDatas.POIAlias poialias = new POIDatas.POIAlias();
			FRANC_NOMSERV_DAT.FrancNomservDatRecords recordByRT3Idx = commonFiles.francNomservDat.getRecordByRT3Idx(record.FrancNomServIdx);
			poialias.typeFlagged = record.type;
			poialias.country = record.country;
			poialias.area = record.area;
			poialias.dpt = record.department;
			poialias.city = record.city;
			poialias.district = record.district;
			bool flag = recordByRT3Idx != null;
			if (flag)
			{
				FRANC_NOMSERV_DAT.FrancNomservDatRecords francNomservDatRecords = recordByRT3Idx;
				poialias.idxName = francNomservDatRecords.index;
				poialias.name = francNomservDatRecords.name;
				flag = (francNomservDatRecords.index != 1);
				if (flag)
				{
					bool flag2 = !MySettingsProperty.Settings.ignoreRTxAltName;
					if (flag2)
					{
						this.listOfAlternates.Add(poialias);
					}
				}
				else
				{
					bool flag2 = this.listOfCanonical.Count > 1 & this.type == poialias.typeFlagged;
					if (flag2)
					{
						MyProject.Application.Log.WriteEntry(string.Format("RT3 map error: duplicate canonical name in add alias of FRANC{0:G}.DSC, skipped (type={1:X} country={2:X} area={3:X} dpt={4:X} city={5:X} district={6:X} 1rstname={7:G} 2ndname={8:G}).", new object[]
						{
							POIDatas.categoryName,
							this.type,
							this.countryRT3,
							this.area,
							this.dpt,
							this.cityRT3,
							this.district,
							this.origName,
							francNomservDatRecords.name
						}));
					}
					else
					{
						this.listOfCanonical.Add(poialias);
						this.origName = francNomservDatRecords.name;
					}
				}
				francNomservDatRecords.used = true;
			}
			else
			{
				MyProject.Application.Log.WriteEntry(string.Format("RT3 map error: Invalid index to FRANC_NOMSERV.DAT found in FRANC{0:G}.DSC for an alias, skipped (type={1:X} LS={2:X} MS={3:X} SS={4:X} address={5:G}).", new object[]
				{
					POIDatas.categoryName,
					this.type,
					this.LS,
					this.MS,
					this.SS,
					this.addressRT3
				}));
			}
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0011BA60 File Offset: 0x0011AA60
		public void initByRT3values(FRANCSCCDST.FrancSCCDSTDatItems record)
		{
			POIDatas.POIAlias poialias = new POIDatas.POIAlias();
			this.fromRT3 = true;
			this.fullPatch = false;
			this.displayMagnitude = false;
			this.isPlaneCoordSearchable = true;
			this.SS = record.SS;
			this.MS = record.MS;
			this.LS = record.LS;
			this.X = record.X;
			this.Y = record.Y;
			checked
			{
				this._ERTX = 256000U * ((uint)this.LS % POIDatas.LSColumnNb) + 16000U * (uint)(this.MS % 16) + 1000U * (uint)(this.SS % 16) + (uint)this.X;
				this._NRTX = 256000U * ((uint)this.LS / POIDatas.LSColumnNb) + 16000U * (uint)(this.MS / 16) + 1000U * (uint)(this.SS / 16) + (uint)this.Y;
				this.magnitude = record.magnitude;
				this.type = 4444;
				poialias.typeFlagged = 4444;
				this.franpoiPtr = 0U;
				this.layer = 244;
				this.scale = 1;
				poialias.idxName = 1;
				poialias.name = record.name;
				this.origName = record.name;
				this.listOfCanonical.Add(poialias);
				this.telRT3 = ulong.MaxValue;
			}
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0011BBC0 File Offset: 0x0011ABC0
		public void initByRT3values(FRANCXXXDST.FrancDSTDatItems record, commonFiles commonFiles)
		{
			POIDatas.POIAlias poialias = new POIDatas.POIAlias();
			this.fromRT3 = true;
			this.fullPatch = false;
			this.displayMagnitude = false;
			this.isPlaneCoordSearchable = true;
			this.SS = record.SS;
			this.MS = record.MS;
			this.LS = record.LS;
			this.X = record.X;
			this.Y = record.Y;
			FRANCPOI_DAT.FrancPOIDatRecords recordByRT3Ptr = commonFiles.francPOIDat.getRecordByRT3Ptr(record.FrancPOIPtr);
			GUIDA_CHAMPERARD_POI.GuidaChamperardRecords recordByRT3Ptr2 = commonFiles.GuidaChamperadPoi.getRecordByRT3Ptr(record.FrancPOIPtr);
			this.type = record.type;
			poialias.idxName = 1;
			poialias.name = record.name;
			poialias.typeFlagged = record.type;
			this.listOfCanonical.Add(poialias);
			this.origName = record.name;
			bool flag = recordByRT3Ptr != null;
			checked
			{
				if (flag)
				{
					FRANCPOI_DAT.FrancPOIDatRecords francPOIDatRecords = recordByRT3Ptr;
					this.addressRT3 = francPOIDatRecords.address;
					this.SS = francPOIDatRecords.SS;
					this.MS = francPOIDatRecords.MS;
					this.LS = francPOIDatRecords.LS;
					this.scittaPtr = francPOIDatRecords.ScittaNamePtr;
					this.scale = francPOIDatRecords.scale;
					this.layer = francPOIDatRecords.layer;
					this.compound = francPOIDatRecords.compound;
					this.X = francPOIDatRecords.X;
					this.Y = francPOIDatRecords.Y;
					this.francatFlag = francPOIDatRecords.francatFlag;
					this.brandIdx = francPOIDatRecords.brandIdx;
					this.telRT3 = francPOIDatRecords.tel;
					this._ERTX = 256000U * ((uint)this.LS % POIDatas.LSColumnNb) + 16000U * (uint)(this.MS % 16) + 1000U * (uint)(this.SS % 16) + (uint)this.X;
					this._NRTX = 256000U * ((uint)this.LS / POIDatas.LSColumnNb) + 16000U * (uint)(this.MS / 16) + 1000U * (uint)(this.SS / 16) + (uint)this.Y;
					flag = (recordByRT3Ptr2 != null);
					if (flag)
					{
						this.commentRT3 = recordByRT3Ptr2.comment;
					}
					else
					{
						this.commentRT3 = null;
					}
				}
				else
				{
					MyProject.Application.Log.WriteEntry(string.Format("RT3 map error: invalid pointer to FRANCPOI.DAT in FRANC{0:G}.DST, skipped (type: {1:X}, SS {2:X}, MS {3:X}, LS {4:X}, X {5:X}, Y {6:X})", new object[]
					{
						POIDatas.categoryName,
						this.type,
						this.SS,
						this.MS,
						this.LS,
						this.X,
						this.Y
					}));
					this.toSkip = true;
				}
			}
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0011BE9C File Offset: 0x0011AE9C
		public void initByRT3values(FRANCPOI_DAT.FrancPOIDatRecords FrancPOIDatRecord, commonFiles commonFiles)
		{
			POIDatas.POIAlias poialias = new POIDatas.POIAlias();
			bool flag = FrancPOIDatRecord == null;
			checked
			{
				if (flag)
				{
					MyProject.Application.Log.WriteEntry(string.Format("RT3 map error: invalid pointer to FRANCPOI.DAT in FRANCDSP.POI. Record skipped.", new object[0]));
					this.toSkip = true;
				}
				else
				{
					this.magnitude = 0;
					this.countryRT3 = byte.MaxValue;
					poialias.country = byte.MaxValue;
					this.area = byte.MaxValue;
					poialias.area = byte.MaxValue;
					this.dpt = byte.MaxValue;
					poialias.dpt = byte.MaxValue;
					this.cityRT3 = ushort.MaxValue;
					poialias.city = ushort.MaxValue;
					this.district = ushort.MaxValue;
					poialias.district = ushort.MaxValue;
					this.type = FrancPOIDatRecord.type;
					poialias.typeFlagged = FrancPOIDatRecord.type;
					this.addressRT3 = FrancPOIDatRecord.address;
					this.SS = FrancPOIDatRecord.SS;
					this.MS = FrancPOIDatRecord.MS;
					this.LS = FrancPOIDatRecord.LS;
					this.scittaPtr = FrancPOIDatRecord.ScittaNamePtr;
					this.scale = FrancPOIDatRecord.scale;
					this.layer = FrancPOIDatRecord.layer;
					this.compound = FrancPOIDatRecord.compound;
					this.X = FrancPOIDatRecord.X;
					this.Y = FrancPOIDatRecord.Y;
					this.francatFlag = FrancPOIDatRecord.francatFlag;
					this.brandIdx = FrancPOIDatRecord.brandIdx;
					this.telRT3 = FrancPOIDatRecord.tel;
					FRANC_NOMSERV_DAT.FrancNomservDatRecords recordByRT3Idx = commonFiles.francNomservDat.getRecordByRT3Idx(FrancPOIDatRecord.FrancNomServIdx);
					this._ERTX = 256000U * ((uint)this.LS % POIDatas.LSColumnNb) + 16000U * (uint)(this.MS % 16) + 1000U * (uint)(this.SS % 16) + (uint)this.X;
					this._NRTX = 256000U * ((uint)this.LS / POIDatas.LSColumnNb) + 16000U * (uint)(this.MS / 16) + 1000U * (uint)(this.SS / 16) + (uint)this.Y;
					flag = (recordByRT3Idx != null);
					if (flag)
					{
						FRANC_NOMSERV_DAT.FrancNomservDatRecords francNomservDatRecords = recordByRT3Idx;
						bool flag2 = francNomservDatRecords.index != 1;
						if (flag2)
						{
							MyProject.Application.Log.WriteEntry(string.Format("RT3 map error: alternate name detected in FRANCDSP.POI, skipped (type={0:X} LS={1:X} MS={2:X} SS={3:X} X={4:X} Y={5:X} name={6:G}).", new object[]
							{
								this.type,
								this.LS,
								this.MS,
								this.SS,
								this.X,
								this.Y,
								francNomservDatRecords.name
							}));
							this.toSkip = true;
						}
						else
						{
							poialias.idxName = francNomservDatRecords.index;
							poialias.name = francNomservDatRecords.name;
							this.listOfCanonical.Add(poialias);
							this.origName = francNomservDatRecords.name;
						}
						francNomservDatRecords.used = true;
						this.isPlaneCoordSearchable = true;
					}
					else
					{
						this.origName = "{..**..}";
						poialias.name = "{..**..}";
						poialias.idxName = 1;
						this.listOfCanonical.Add(poialias);
						MyProject.Application.Log.WriteEntry(string.Format("RT3 map error: invalid index to FRANC_NOMSERV.DAT in FRANCDSP.POI (type: {0:X}, LS {1:X}, MS {2:X}, SS {3:X}, address {4:G}) , replaced by {5:G} ", new object[]
						{
							this.type,
							this.LS,
							this.MS,
							this.SS,
							this.addressRT3,
							"{..**..}"
						}));
					}
				}
			}
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0011C254 File Offset: 0x0011B254
		public POIDatas.errorCodes tradForRT3(StreamWriter sw, int type, int scale, int layer)
		{
			POIDatas.errorCodes result;
			try
			{
				sw.WriteLine("; " + this.origName);
				sw.WriteLine(string.Concat(new string[]
				{
					"0x",
					type.ToString("X4"),
					"  0x",
					scale.ToString("X2"),
					layer.ToString("X2"),
					" ",
					this.LS.ToString("d"),
					" ",
					this.MS.ToString("d"),
					" ",
					this.SS.ToString("d"),
					" ",
					this.Y.ToString("d"),
					" ",
					this.X.ToString("d")
				}));
				result = POIDatas.errorCodes.ok;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, null);
				result = POIDatas.errorCodes.exportError;
			}
			return result;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0011C3AC File Offset: 0x0011B3AC
		public static bool initShared(Common.RTxMapType newMapType, uint _LSColumnNb, uint _LSLineNb, uint _LSNb, Common.RTxMapEditorMapModes RTxMapEditorMapMode)
		{
			bool result = true;
			POIDatas.cultForParse = Common.cultENUS;
			POIDatas.cultForExport = Common.cultENUS;
			POIDatas.mapType = newMapType;
			POIDatas.LSColumnNb = _LSColumnNb;
			POIDatas.LSLineNb = _LSLineNb;
			POIDatas.LSNb = _LSNb;
			checked
			{
				POIDatas.maxXYX = POIDatas.LSColumnNb * 256000U - 1U;
				POIDatas.maxXYY = POIDatas.LSLineNb * 256000U - 1U;
				POIDatas._RTxMapEditorMapMode = RTxMapEditorMapMode;
				POIDatas.projection = new projection();
				bool flag = !POIDatas.projection.init(POIDatas.mapType);
				if (flag)
				{
					bool flag2 = true;
					if (flag2)
					{
						result = false;
					}
				}
				return result;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0011C444 File Offset: 0x0011B444
		public string latForExport
		{
			get
			{
				bool flag = this._lat == 10000.0;
				if (flag)
				{
					LP lp = POIDatas.projection.proj_inv(this._ERTX, this._NRTX);
					this._lat = Math.Round(180.0 * lp.phi / 3.141592653589793, 6);
					this._lon = Math.Round(180.0 * lp.lam / 3.141592653589793, 6);
				}
				return this._lat.ToString(POIDatas.cultForExport);
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0011C4E8 File Offset: 0x0011B4E8
		public string lonForExport
		{
			get
			{
				bool flag = this._lon == 10000.0;
				if (flag)
				{
					LP lp = POIDatas.projection.proj_inv(this._ERTX, this._NRTX);
					this._lat = Math.Round(180.0 * lp.phi / 3.141592653589793, 6);
					this._lon = Math.Round(180.0 * lp.lam / 3.141592653589793, 6);
				}
				return this._lon.ToString(POIDatas.cultForExport);
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0011C58C File Offset: 0x0011B58C
		public string telForExport
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder(20);
				int num = 0;
				checked
				{
					bool flag;
					int num5;
					int num6;
					do
					{
						int num2 = 4 * num;
						ulong num3 = 15UL << num2;
						int num4 = (int)((this.telRT3 & num3) >> num2);
						flag = (decimal.Compare(new decimal(num4), 15m) != 0);
						if (flag)
						{
							stringBuilder.Append(Strings.ChrW(48 + num4));
						}
						num++;
						num5 = num;
						num6 = 15;
					}
					while (num5 <= num6);
					flag = (stringBuilder.Length > 0);
					string result;
					if (flag)
					{
						string prefix = MyProject.Forms.FormMain.mapMngt.PrefInt.getPrefix(this.countryRT3);
						flag = (prefix != null);
						if (flag)
						{
							stringBuilder.Insert(0, prefix);
							stringBuilder.Insert(0, "+");
						}
						result = stringBuilder.ToString();
					}
					else
					{
						result = null;
					}
					return result;
				}
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0011C670 File Offset: 0x0011B670
		public string addressForExport
		{
			get
			{
				bool flag = this.addressRT3 != null && Operators.CompareString(this.addressRT3.TrimEnd(new char[]
				{
					'\0'
				}), "", false) != 0;
				string result;
				if (flag)
				{
					result = this.addressRT3.Replace("\"", "'").TrimEnd(new char[]
					{
						'\0'
					});
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0011C6E8 File Offset: 0x0011B6E8
		public string cityNameForExport
		{
			get
			{
				bool flag = this.type != 4444 && MyProject.Forms.FormMain.mapMngt.SCITTANAME_DAT.getCityName(this.scittaPtr) != null;
				string result;
				if (flag)
				{
					result = MyProject.Forms.FormMain.mapMngt.SCITTANAME_DAT.getCityName(this.scittaPtr).Replace("\"", "'").TrimEnd(new char[]
					{
						'\0'
					});
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x0011C778 File Offset: 0x0011B778
		public string countryForExport
		{
			get
			{
				return MyProject.Forms.FormMain.mapMngt.PrefInt.getCountry(this.countryRT3);
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0011C7AC File Offset: 0x0011B7AC
		public string commentForExport
		{
			get
			{
				bool flag = this.commentRT3 != null;
				string result;
				if (flag)
				{
					result = this.commentRT3.Replace("\v", " ").Replace("\"", "'").TrimEnd(new char[]
					{
						'\0'
					});
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x0011C80C File Offset: 0x0011B80C
		public string nameForExport
		{
			get
			{
				return this.listOfCanonical[0].name.Replace("\"", "'").TrimEnd(new char[]
				{
					'\0'
				});
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0011C850 File Offset: 0x0011B850
		public uint UId
		{
			get
			{
				return this._UId;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x0011C868 File Offset: 0x0011B868
		public string brandNameForExport
		{
			get
			{
				string text = MyProject.Forms.FormMain.mapMngt.FRANCAT_POI.getBrandName(this.brandIdx);
				bool flag = text != null;
				if (flag)
				{
					text = MyProject.Forms.FormMain.mapMngt.FRANCAT_POI.getBrandName(this.brandIdx).Replace("\"", "'");
				}
				return text;
			}
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0011C8D4 File Offset: 0x0011B8D4
		private uint _getNextUid()
		{
			uint result = POIDatas.nextUId;
			checked
			{
				POIDatas.nextUId += 1U;
				return result;
			}
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0011C8F8 File Offset: 0x0011B8F8
		public static void clearUId()
		{
			POIDatas.nextUId = 0U;
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0011C904 File Offset: 0x0011B904
		public void buildNeighborCells(int dist)
		{
			this.neighborCells = new List<uint>();
			this.neighborCells.Add((uint)((int)this.LS << 16 | (int)this.MS << 8 | (int)this.SS));
			bool flag = (int)this.X < dist;
			checked
			{
				if (flag)
				{
					this.addCellIdW();
					flag = ((int)this.Y >= 1000 - dist);
					if (flag)
					{
						this.adCellIdNW();
						this.addCellIdN();
					}
					else
					{
						flag = ((int)this.Y < dist);
						if (flag)
						{
							this.addCcellIdSW();
							this.addCellIdS();
						}
					}
				}
				else
				{
					flag = ((int)this.X >= 1000 - dist);
					if (flag)
					{
						this.addCellIdE();
						flag = ((int)this.Y >= 1000 - dist);
						if (flag)
						{
							this.addCellIdNE();
							this.addCellIdN();
						}
						else
						{
							flag = ((int)this.Y < dist);
							if (flag)
							{
								this.addCellIdSE();
								this.addCellIdS();
							}
						}
					}
					else
					{
						flag = ((int)this.Y >= 1000 - dist);
						if (flag)
						{
							this.addCellIdN();
						}
						else
						{
							flag = ((int)this.Y < dist);
							if (flag)
							{
								this.addCellIdS();
							}
						}
					}
				}
			}
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0011CA38 File Offset: 0x0011BA38
		public bool isDup(SortedDictionary<uint, List<POIDatas>> sdPOIByCell)
		{
			List<POIDatas> list = null;
			try
			{
				foreach (uint key in this.neighborCells)
				{
					bool flag = sdPOIByCell.TryGetValue(key, out list);
					if (flag)
					{
						try
						{
							foreach (POIDatas poidatas in list)
							{
								bool flag2 = checked((int)Math.Round(Math.Sqrt((double)(((int)this._NRTX - (int)poidatas._NRTX) * ((int)this._NRTX - (int)poidatas._NRTX) + ((int)this._ERTX - (int)poidatas._ERTX) * ((int)this._ERTX - (int)poidatas._ERTX))))) <= POIDatas.maxDist;
								if (flag2)
								{
									return true;
								}
							}
						}
						finally
						{
							List<POIDatas>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
			}
			finally
			{
				List<uint>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return false;
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0011CB50 File Offset: 0x0011BB50
		public uint cellId()
		{
			return (uint)((int)this.LS << 16 | (int)this.MS << 8 | (int)this.SS);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0011CB7C File Offset: 0x0011BB7C
		private void addCellIdN()
		{
			checked
			{
				uint num = this._NRTX + 1000U;
				bool flag = num > POIDatas.maxXYX;
				if (!flag)
				{
					uint ertx = this._ERTX;
					ushort num2 = (ushort)(unchecked((ulong)ertx / 256000UL % (ulong)POIDatas.LSColumnNb) + unchecked((ulong)POIDatas.LSColumnNb) * (unchecked((ulong)num) / 256000UL));
					byte b = (byte)(unchecked((ulong)ertx) % 256000UL / 16000UL + 16UL * (unchecked((ulong)num) % 256000UL / 16000UL));
					byte b2 = (byte)(unchecked((ulong)ertx) % 16000UL / 1000UL + 16UL * (unchecked((ulong)num) % 16000UL / 1000UL));
					this.neighborCells.Add((uint)((int)num2 << 16 | (int)b << 8 | (int)b2));
				}
			}
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0011CC40 File Offset: 0x0011BC40
		private void addCellIdS()
		{
			uint num = checked(this._NRTX - 1000U);
			bool flag = (ulong)num < 0UL;
			checked
			{
				if (!flag)
				{
					uint ertx = this._ERTX;
					ushort num2 = (ushort)(unchecked((ulong)ertx / 256000UL % (ulong)POIDatas.LSColumnNb) + unchecked((ulong)POIDatas.LSColumnNb) * (unchecked((ulong)num) / 256000UL));
					byte b = (byte)(unchecked((ulong)ertx) % 256000UL / 16000UL + 16UL * (unchecked((ulong)num) % 256000UL / 16000UL));
					byte b2 = (byte)(unchecked((ulong)ertx) % 16000UL / 1000UL + 16UL * (unchecked((ulong)num) % 16000UL / 1000UL));
					this.neighborCells.Add((uint)((int)num2 << 16 | (int)b << 8 | (int)b2));
				}
			}
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0011CD00 File Offset: 0x0011BD00
		private void addCellIdE()
		{
			checked
			{
				uint num = this._ERTX + 1000U;
				bool flag = num > POIDatas.maxXYX;
				if (!flag)
				{
					uint nrtx = this._NRTX;
					ushort num2 = (ushort)(unchecked((ulong)num / 256000UL % (ulong)POIDatas.LSColumnNb) + unchecked((ulong)POIDatas.LSColumnNb) * (unchecked((ulong)nrtx) / 256000UL));
					byte b = (byte)(unchecked((ulong)num) % 256000UL / 16000UL + 16UL * (unchecked((ulong)nrtx) % 256000UL / 16000UL));
					byte b2 = (byte)(unchecked((ulong)num) % 16000UL / 1000UL + 16UL * (unchecked((ulong)nrtx) % 16000UL / 1000UL));
					this.neighborCells.Add((uint)((int)num2 << 16 | (int)b << 8 | (int)b2));
				}
			}
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0011CDC4 File Offset: 0x0011BDC4
		private void addCellIdW()
		{
			uint num = checked(this._ERTX - 1000U);
			bool flag = (ulong)num < 0UL;
			checked
			{
				if (!flag)
				{
					uint nrtx = this._NRTX;
					ushort num2 = (ushort)(unchecked((ulong)num / 256000UL % (ulong)POIDatas.LSColumnNb) + unchecked((ulong)POIDatas.LSColumnNb) * (unchecked((ulong)nrtx) / 256000UL));
					byte b = (byte)(unchecked((ulong)num) % 256000UL / 16000UL + 16UL * (unchecked((ulong)nrtx) % 256000UL / 16000UL));
					byte b2 = (byte)(unchecked((ulong)num) % 16000UL / 1000UL + 16UL * (unchecked((ulong)nrtx) % 16000UL / 1000UL));
					this.neighborCells.Add((uint)((int)num2 << 16 | (int)b << 8 | (int)b2));
				}
			}
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0011CE84 File Offset: 0x0011BE84
		private void addCellIdNE()
		{
			checked
			{
				uint num = this._NRTX + 1000U;
				bool flag = num > POIDatas.maxXYY;
				if (!flag)
				{
					uint num2 = this._ERTX + 1000U;
					flag = (num2 > POIDatas.maxXYX);
					if (!flag)
					{
						ushort num3 = (ushort)(unchecked((ulong)num2 / 256000UL % (ulong)POIDatas.LSColumnNb) + unchecked((ulong)POIDatas.LSColumnNb) * (unchecked((ulong)num) / 256000UL));
						byte b = (byte)(unchecked((ulong)num2) % 256000UL / 16000UL + 16UL * (unchecked((ulong)num) % 256000UL / 16000UL));
						byte b2 = (byte)(unchecked((ulong)num2) % 16000UL / 1000UL + 16UL * (unchecked((ulong)num) % 16000UL / 1000UL));
						this.neighborCells.Add((uint)((int)num3 << 16 | (int)b << 8 | (int)b2));
					}
				}
			}
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0011CF60 File Offset: 0x0011BF60
		private void adCellIdNW()
		{
			checked
			{
				uint num = this._NRTX + 1000U;
				bool flag = num > POIDatas.maxXYY;
				if (!flag)
				{
					uint num2 = this._ERTX - 1000U;
					flag = (unchecked((ulong)num2) < 0UL);
					if (!flag)
					{
						ushort num3 = (ushort)(unchecked((ulong)num2 / 256000UL % (ulong)POIDatas.LSColumnNb) + unchecked((ulong)POIDatas.LSColumnNb) * (unchecked((ulong)num) / 256000UL));
						byte b = (byte)(unchecked((ulong)num2) % 256000UL / 16000UL + 16UL * (unchecked((ulong)num) % 256000UL / 16000UL));
						byte b2 = (byte)(unchecked((ulong)num2) % 16000UL / 1000UL + 16UL * (unchecked((ulong)num) % 16000UL / 1000UL));
						this.neighborCells.Add((uint)((int)num3 << 16 | (int)b << 8 | (int)b2));
					}
				}
			}
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0011D03C File Offset: 0x0011C03C
		private void addCcellIdSW()
		{
			uint num = checked(this._NRTX - 1000U);
			bool flag = (ulong)num < 0UL;
			checked
			{
				if (!flag)
				{
					uint num2 = this._ERTX - 1000U;
					flag = (unchecked((ulong)num2) < 0UL);
					if (!flag)
					{
						ushort num3 = (ushort)(unchecked((ulong)num2 / 256000UL % (ulong)POIDatas.LSColumnNb) + unchecked((ulong)POIDatas.LSColumnNb) * (unchecked((ulong)num) / 256000UL));
						byte b = (byte)(unchecked((ulong)num2) % 256000UL / 16000UL + 16UL * (unchecked((ulong)num) % 256000UL / 16000UL));
						byte b2 = (byte)(unchecked((ulong)num2) % 16000UL / 1000UL + 16UL * (unchecked((ulong)num) % 16000UL / 1000UL));
						this.neighborCells.Add((uint)((int)num3 << 16 | (int)b << 8 | (int)b2));
					}
				}
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0011D114 File Offset: 0x0011C114
		private void addCellIdSE()
		{
			uint num = checked(this._NRTX - 1000U);
			bool flag = (ulong)num < 0UL;
			checked
			{
				if (!flag)
				{
					uint num2 = this._ERTX + 1000U;
					flag = (num2 > POIDatas.maxXYX);
					if (!flag)
					{
						ushort num3 = (ushort)(unchecked((ulong)num2 / 256000UL % (ulong)POIDatas.LSColumnNb) + unchecked((ulong)POIDatas.LSColumnNb) * (unchecked((ulong)num) / 256000UL));
						byte b = (byte)(unchecked((ulong)num2) % 256000UL / 16000UL + 16UL * (unchecked((ulong)num) % 256000UL / 16000UL));
						byte b2 = (byte)(unchecked((ulong)num2) % 16000UL / 1000UL + 16UL * (unchecked((ulong)num) % 16000UL / 1000UL));
						this.neighborCells.Add((uint)((int)num3 << 16 | (int)b << 8 | (int)b2));
					}
				}
			}
		}

		// Token: 0x040004BE RID: 1214
		private static CultureInfo cultForParse;

		// Token: 0x040004BF RID: 1215
		public static CultureInfo cultForExport = null;

		// Token: 0x040004C0 RID: 1216
		private static projection projection;

		// Token: 0x040004C1 RID: 1217
		private static uint nextUId = 0U;

		// Token: 0x040004C2 RID: 1218
		public static string categoryName;

		// Token: 0x040004C3 RID: 1219
		private static Common.RTxMapType mapType = Common.RTxMapType.Unknown;

		// Token: 0x040004C4 RID: 1220
		private static Common.RTxMapEditorMapModes _RTxMapEditorMapMode = Common.RTxMapEditorMapModes.map;

		// Token: 0x040004C5 RID: 1221
		private double _lat;

		// Token: 0x040004C6 RID: 1222
		private double _lon;

		// Token: 0x040004C7 RID: 1223
		public uint _ERTX;

		// Token: 0x040004C8 RID: 1224
		public uint _NRTX;

		// Token: 0x040004C9 RID: 1225
		public string origName;

		// Token: 0x040004CA RID: 1226
		public string addressRT3;

		// Token: 0x040004CB RID: 1227
		public ulong telRT3;

		// Token: 0x040004CC RID: 1228
		public ushort type;

		// Token: 0x040004CD RID: 1229
		public ushort LS;

		// Token: 0x040004CE RID: 1230
		public byte MS;

		// Token: 0x040004CF RID: 1231
		public byte SS;

		// Token: 0x040004D0 RID: 1232
		public ushort X;

		// Token: 0x040004D1 RID: 1233
		public ushort Y;

		// Token: 0x040004D2 RID: 1234
		public uint scittaPtr;

		// Token: 0x040004D3 RID: 1235
		public byte countryRT3;

		// Token: 0x040004D4 RID: 1236
		public byte area;

		// Token: 0x040004D5 RID: 1237
		public byte dpt;

		// Token: 0x040004D6 RID: 1238
		public ushort cityRT3;

		// Token: 0x040004D7 RID: 1239
		public ushort district;

		// Token: 0x040004D8 RID: 1240
		public byte scale;

		// Token: 0x040004D9 RID: 1241
		public byte layer;

		// Token: 0x040004DA RID: 1242
		public byte francatFlag;

		// Token: 0x040004DB RID: 1243
		public ushort brandIdx;

		// Token: 0x040004DC RID: 1244
		public byte magnitude;

		// Token: 0x040004DD RID: 1245
		public uint compound;

		// Token: 0x040004DE RID: 1246
		public string commentRT3;

		// Token: 0x040004DF RID: 1247
		public uint speed;

		// Token: 0x040004E0 RID: 1248
		public double angle;

		// Token: 0x040004E1 RID: 1249
		public uint franpoiPtr;

		// Token: 0x040004E2 RID: 1250
		public List<POIDatas.POIAlias> listOfCanonical;

		// Token: 0x040004E3 RID: 1251
		public List<POIDatas.POIAlias> listOfAlternates;

		// Token: 0x040004E4 RID: 1252
		public bool isPlaneCoordSearchable;

		// Token: 0x040004E5 RID: 1253
		public bool isGeoCoordSearchable;

		// Token: 0x040004E6 RID: 1254
		public bool fullPatch;

		// Token: 0x040004E7 RID: 1255
		public bool displayMagnitude;

		// Token: 0x040004E8 RID: 1256
		public bool fromRT3;

		// Token: 0x040004E9 RID: 1257
		public bool toSkip;

		// Token: 0x040004EA RID: 1258
		private uint _UId;

		// Token: 0x040004EB RID: 1259
		private const int lonMin = -19;

		// Token: 0x040004EC RID: 1260
		private const int lonMax = 27;

		// Token: 0x040004ED RID: 1261
		private const int latmin = 27;

		// Token: 0x040004EE RID: 1262
		private const int latMax = 72;

		// Token: 0x040004EF RID: 1263
		private static uint LSColumnNb;

		// Token: 0x040004F0 RID: 1264
		private static uint LSLineNb;

		// Token: 0x040004F1 RID: 1265
		private static uint LSNb;

		// Token: 0x040004F2 RID: 1266
		private static uint maxXYX;

		// Token: 0x040004F3 RID: 1267
		private static uint maxXYY;

		// Token: 0x040004F4 RID: 1268
		private const double noLat = 10000.0;

		// Token: 0x040004F5 RID: 1269
		private const double noLon = 10000.0;

		// Token: 0x040004F6 RID: 1270
		private List<uint> neighborCells;

		// Token: 0x040004F7 RID: 1271
		public static int maxDist;

		// Token: 0x040004F8 RID: 1272
		private POIDatas.errorCodes errorCode;

		// Token: 0x02000064 RID: 100
		public enum errorCodes
		{
			// Token: 0x040004FA RID: 1274
			ok,
			// Token: 0x040004FB RID: 1275
			LatOutOfRange = 101,
			// Token: 0x040004FC RID: 1276
			LonOutOfRange,
			// Token: 0x040004FD RID: 1277
			incorrectName,
			// Token: 0x040004FE RID: 1278
			incorrectLatFormat,
			// Token: 0x040004FF RID: 1279
			incorrectLonFormat,
			// Token: 0x04000500 RID: 1280
			exportError,
			// Token: 0x04000501 RID: 1281
			projLibraryError,
			// Token: 0x04000502 RID: 1282
			LSMSempty,
			// Token: 0x04000503 RID: 1283
			ERT3OutOfRange,
			// Token: 0x04000504 RID: 1284
			NRT3OutOfRange,
			// Token: 0x04000505 RID: 1285
			badType,
			// Token: 0x04000506 RID: 1286
			badMagnitude,
			// Token: 0x04000507 RID: 1287
			badTel,
			// Token: 0x04000508 RID: 1288
			badCt
		}

		// Token: 0x02000065 RID: 101
		public class POIAlias
		{
			// Token: 0x06000CCB RID: 3275 RVA: 0x0011D1F0 File Offset: 0x0011C1F0
			[DebuggerNonUserCode]
			public POIAlias()
			{
			}

			// Token: 0x04000509 RID: 1289
			public byte idxName;

			// Token: 0x0400050A RID: 1290
			public string name;

			// Token: 0x0400050B RID: 1291
			public ushort typeFlagged;

			// Token: 0x0400050C RID: 1292
			public byte country;

			// Token: 0x0400050D RID: 1293
			public byte area;

			// Token: 0x0400050E RID: 1294
			public byte dpt;

			// Token: 0x0400050F RID: 1295
			public ushort city;

			// Token: 0x04000510 RID: 1296
			public ushort district;

			// Token: 0x04000511 RID: 1297
			public buildSortedMapDicts.alphabeticValue alphabeticalEntry;
		}
	}
}
