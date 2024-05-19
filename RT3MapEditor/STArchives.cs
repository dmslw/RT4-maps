using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x020000D4 RID: 212
	public class STArchives
	{
		// Token: 0x06000E60 RID: 3680 RVA: 0x00130A6C File Offset: 0x0012FA6C
		public STArchives(string fileName)
		{
			this.completeListOfName = new STArchives.entryDef[0];
			this.fixedListOfName = new STArchives.entryDef[0];
			this.mobileListOfName = new STArchives.entryDef[0];
			this.F120_130GListOfName = new STArchives.entryDef[0];
			this.F100_119ListOfName = new STArchives.entryDef[0];
			this.F80_99ListOfName = new STArchives.entryDef[0];
			this.F60_79ListOfName = new STArchives.entryDef[0];
			this.F0_59ListOfName = new STArchives.entryDef[0];
			this.M120_130ListOfName = new STArchives.entryDef[0];
			this.M100_119ListOfName = new STArchives.entryDef[0];
			this.M80_99ListOfName = new STArchives.entryDef[0];
			this.M60_79ListOfName = new STArchives.entryDef[0];
			this.M0_59ListOfName = new STArchives.entryDef[0];
			this.RFRListOfName = new STArchives.entryDef[0];
			this.completeGpspassStdRF = new STArchives.entryDef[]
			{
				new STArchives.entryDef("radarsF.asc", STArchives.entryType.RF)
			};
			this.fixedGpspassStdRF = new STArchives.entryDef[]
			{
				new STArchives.entryDef("radarsF.asc", STArchives.entryType.RF)
			};
			this.completeGpspassStdRM = new STArchives.entryDef[]
			{
				new STArchives.entryDef("radarsFR.asc", STArchives.entryType.RFR),
				new STArchives.entryDef("radarsM.asc", STArchives.entryType.RM)
			};
			this.fixedGpspassStdRM = new STArchives.entryDef[]
			{
				new STArchives.entryDef("radarsFR.asc", STArchives.entryType.RFR)
			};
			this.mobileGpspassStdRM = new STArchives.entryDef[]
			{
				new STArchives.entryDef("radarsM.asc", STArchives.entryType.RM)
			};
			this.completeGpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("radarsFR.asc", STArchives.entryType.RFR),
				new STArchives.entryDef("RD.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-030.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-050.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-070.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-080.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-090.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-110.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-130.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RM-030.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-040.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-045.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-050.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-060.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-070.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-080.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-090.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-110.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-130.asc", STArchives.entryType.RM)
			};
			this.fixedGpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("radarsFR.asc", STArchives.entryType.RFR),
				new STArchives.entryDef("RD.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-030.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-050.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-070.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-080.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-090.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-110.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-130.asc", STArchives.entryType.RF)
			};
			this.mobileGpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("RM-030.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-040.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-045.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-050.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-060.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-070.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-080.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-090.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-110.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-130.asc", STArchives.entryType.RM)
			};
			this.F120_130GGpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("RF-130.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RD.asc", STArchives.entryType.RF)
			};
			this.F100_119GpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("RF-110.asc", STArchives.entryType.RF)
			};
			this.F80_99GpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("RF-080.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-090.asc", STArchives.entryType.RF)
			};
			this.F60_79GpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("RF-070.asc", STArchives.entryType.RF)
			};
			this.F0_59GpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("RF-030.asc", STArchives.entryType.RF),
				new STArchives.entryDef("RF-050.asc", STArchives.entryType.RF)
			};
			this.M120_130GpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("RM-130.asc", STArchives.entryType.RM)
			};
			this.M100_119GpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("RM-110.asc", STArchives.entryType.RM)
			};
			this.M80_99GpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("RM-080.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-090.asc", STArchives.entryType.RM)
			};
			this.M60_79GpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("RM-060.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-070.asc", STArchives.entryType.RM)
			};
			this.M0_59GpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("RM-030.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-040.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-045.asc", STArchives.entryType.RM),
				new STArchives.entryDef("RM-050.asc", STArchives.entryType.RM)
			};
			this.RFRGpspassPlus = new STArchives.entryDef[]
			{
				new STArchives.entryDef("radarsFR.asc", STArchives.entryType.RFR)
			};
			this.completeAlGpsStd = new STArchives.entryDef[]
			{
				new STArchives.entryDef("Mes POIs/Mio/RF.asc", STArchives.entryType.RF),
				new STArchives.entryDef("Mes POIs/Mio/RFR.asc", STArchives.entryType.RFR),
				new STArchives.entryDef("Mes POIs/Mio/RM.asc", STArchives.entryType.RM)
			};
			this.fixedAlGpsStd = new STArchives.entryDef[]
			{
				new STArchives.entryDef("Mes POIs/Mio/RF.asc", STArchives.entryType.RF),
				new STArchives.entryDef("Mes POIs/Mio/RFR.asc", STArchives.entryType.RFR)
			};
			this.mobileAlGpsStd = new STArchives.entryDef[]
			{
				new STArchives.entryDef("Mes POIs/Mio/RM.asc", STArchives.entryType.RM)
			};
			this.completeAlGpsPlus = new STArchives.entryDef[1];
			this.completeAlGpsPlusList = new List<STArchives.entryDef>();
			this.FixedAlGpsPlus = new STArchives.entryDef[1];
			this.FixedAlGpsPlusList = new List<STArchives.entryDef>();
			this.mobileAlGpsPlus = new STArchives.entryDef[1];
			this.mobileAlGpsPlusList = new List<STArchives.entryDef>();
			this.F120_130AlGpsPlus = new STArchives.entryDef[1];
			this.F120_130AlGpsPlusList = new List<STArchives.entryDef>();
			this.F100_119AlGpsPlus = new STArchives.entryDef[1];
			this.F100_119AlGpsPlusList = new List<STArchives.entryDef>();
			this.F80_99AlGpsPlus = new STArchives.entryDef[1];
			this.F80_99AlGpsPlusList = new List<STArchives.entryDef>();
			this.F60_79AlGpsPlus = new STArchives.entryDef[1];
			this.F60_79AlGpsPlusList = new List<STArchives.entryDef>();
			this.F0_59AlGpsPlus = new STArchives.entryDef[1];
			this.F0_59AlGpsPlusList = new List<STArchives.entryDef>();
			this.M120_130AlGpsPlus = new STArchives.entryDef[1];
			this.M120_130AlGpsPlusList = new List<STArchives.entryDef>();
			this.M100_119AlGpsPlus = new STArchives.entryDef[1];
			this.M100_119AlGpsPlusList = new List<STArchives.entryDef>();
			this.M80_99AlGpsPlus = new STArchives.entryDef[1];
			this.M80_99AlGpsPlusList = new List<STArchives.entryDef>();
			this.M60_79AlGpsPlus = new STArchives.entryDef[1];
			this.M60_79AlGpsPlusList = new List<STArchives.entryDef>();
			this.M0_59AlGpsPlus = new STArchives.entryDef[1];
			this.M0_59AlGpsPlusList = new List<STArchives.entryDef>();
			this.RFRAlGpsPlus = new STArchives.entryDef[1];
			this.RFRAlGpsPlusList = new List<STArchives.entryDef>();
			this.completeWR = new STArchives.entryDef[1];
			this.completeWRList = new List<STArchives.entryDef>();
			this.FixedWR = new STArchives.entryDef[1];
			this.FixedWRList = new List<STArchives.entryDef>();
			this.mobileWR = new STArchives.entryDef[1];
			this.mobileWRList = new List<STArchives.entryDef>();
			this.F120_130WR = new STArchives.entryDef[1];
			this.F120_130WRList = new List<STArchives.entryDef>();
			this.F100_119WR = new STArchives.entryDef[1];
			this.F100_119WRList = new List<STArchives.entryDef>();
			this.F80_99WR = new STArchives.entryDef[1];
			this.F80_99WRList = new List<STArchives.entryDef>();
			this.F60_79WR = new STArchives.entryDef[1];
			this.F60_79WRList = new List<STArchives.entryDef>();
			this.F0_59WR = new STArchives.entryDef[1];
			this.F0_59WRList = new List<STArchives.entryDef>();
			this.M120_130WR = new STArchives.entryDef[1];
			this.M120_130WRList = new List<STArchives.entryDef>();
			this.M100_119WR = new STArchives.entryDef[1];
			this.M100_119WRList = new List<STArchives.entryDef>();
			this.M80_99WR = new STArchives.entryDef[1];
			this.M80_99WRList = new List<STArchives.entryDef>();
			this.M60_79WR = new STArchives.entryDef[1];
			this.M60_79WRList = new List<STArchives.entryDef>();
			this.M0_59WR = new STArchives.entryDef[1];
			this.M0_59WRList = new List<STArchives.entryDef>();
			this.RFRWR = new STArchives.entryDef[1];
			this.RFRWRList = new List<STArchives.entryDef>();
			this._fileName = fileName;
			try
			{
				this._zipFile = new ZipFile(this._fileName);
				this._archiveType = this.guessSTTtype();
				this._supportedModes = this.setSupportedModes(this._archiveType);
				this._supportedModesAlert = this.setSupportedModesAlert(this._archiveType);
			}
			catch (Exception ex)
			{
				this._archiveType = STArchives.STArchiveType.ArcUnknown;
				this._supportedModes = STArchives.ArchImportMode.none;
			}
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x001313DC File Offset: 0x001303DC
		private STArchives.STArchiveType guessSTTtype()
		{
			bool flag = this.checkAllEntries(this.completeGpspassStdRF);
			STArchives.STArchiveType result;
			if (flag)
			{
				result = STArchives.STArchiveType.ArcGpsPassStdRF;
				this.archiveName = "gps passion standard";
			}
			else
			{
				flag = this.checkAllEntries(this.completeGpspassStdRM);
				if (flag)
				{
					result = STArchives.STArchiveType.ArcGpsPassStdRM;
					this.archiveName = "gps passion standard";
				}
				else
				{
					flag = this.checkAllEntries(this.completeAlGpsStd);
					if (flag)
					{
						result = STArchives.STArchiveType.ArcAlgpsStd;
						this.archiveName = "alerte gps standard";
					}
					else
					{
						flag = this.checkAllEntries(this.completeGpspassPlus);
						if (flag)
						{
							result = STArchives.STArchiveType.ArcGpsPassPlus;
							this.archiveName = "gps passion plus";
						}
						else
						{
							flag = this.checkGpsPlusEntries(this.completeAlGpsPlus);
							if (flag)
							{
								result = STArchives.STArchiveType.ArcAlgpsPlus;
								this.archiveName = "alerte gps plus";
							}
							else
							{
								flag = this.checkWREntries(this.completeWR);
								if (flag)
								{
									result = STArchives.STArchiveType.ArcWarningRadar;
									this.archiveName = "warningRadar";
								}
								else
								{
									result = STArchives.STArchiveType.ArcUnknown;
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x001314AC File Offset: 0x001304AC
		private bool checkAllEntries(STArchives.entryDef[] nameList)
		{
			foreach (STArchives.entryDef entryDef in nameList)
			{
				bool flag = this._zipFile.GetEntry(entryDef.name) == null;
				if (flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x001314FC File Offset: 0x001304FC
		private bool checkGpsPlusEntries(STArchives.entryDef[] nameList)
		{
			try
			{
				foreach (object obj in this._zipFile)
				{
					ZipEntry zipEntry = (ZipEntry)obj;
					string name = zipEntry.Name;
					string text = Path.GetFileName(name);
					bool flag = !name.StartsWith("Mes POIs\\") | !name.Contains("Mio") | !(Path.GetFileName(name).StartsWith("RF-") | Path.GetFileName(name).StartsWith("RFR-") | Path.GetFileName(name).StartsWith("RM-") | Path.GetFileName(name).StartsWith("ZD-"));
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
			try
			{
				foreach (object obj2 in this._zipFile)
				{
					ZipEntry zipEntry = (ZipEntry)obj2;
					string name = zipEntry.Name;
					string text = Path.GetFileName(name);
					bool flag = text.EndsWith(".asc");
					if (flag)
					{
						text = Path.GetFileNameWithoutExtension(text);
						string[] array = text.Split(new char[]
						{
							'-'
						});
						flag = (array.Length <= 1);
						if (flag)
						{
							return false;
						}
						flag = (Operators.CompareString(array[0], "ZD", false) == 0);
						if (!flag)
						{
							flag = (Operators.CompareString(array[0], "RFR", false) == 0);
							if (flag)
							{
								STArchives.entryDef item = new STArchives.entryDef(name, STArchives.entryType.RFR);
								this.completeAlGpsPlusList.Add(item);
								this.FixedAlGpsPlusList.Add(item);
								this.RFRAlGpsPlusList.Add(item);
							}
							else
							{
								flag = (Operators.CompareString(array[0], "RF", false) == 0);
								STArchives.entryDef item;
								STArchives.entryType entryType;
								int num;
								if (flag)
								{
									item = new STArchives.entryDef(name, STArchives.entryType.RF);
									entryType = STArchives.entryType.RF;
									num = 1;
								}
								else
								{
									flag = (Operators.CompareString(array[0], "RM", false) == 0);
									if (!flag)
									{
										return false;
									}
									item = new STArchives.entryDef(name, STArchives.entryType.RM);
									entryType = STArchives.entryType.RM;
									num = 1;
								}
								int num2;
								flag = !int.TryParse(array[num], out num2);
								if (flag)
								{
									return false;
								}
								this.completeAlGpsPlusList.Add(item);
								switch (entryType)
								{
								case STArchives.entryType.RF:
									this.FixedAlGpsPlusList.Add(item);
									flag = (num2 <= 59);
									if (flag)
									{
										this.F0_59AlGpsPlusList.Add(item);
									}
									else
									{
										flag = (num2 <= 79);
										if (flag)
										{
											this.F60_79AlGpsPlusList.Add(item);
										}
										else
										{
											flag = (num2 <= 99);
											if (flag)
											{
												this.F80_99AlGpsPlusList.Add(item);
											}
											else
											{
												flag = (num2 <= 119);
												if (flag)
												{
													this.F100_119AlGpsPlusList.Add(item);
												}
												else
												{
													this.F120_130AlGpsPlusList.Add(item);
												}
											}
										}
									}
									break;
								case STArchives.entryType.RM:
									this.mobileAlGpsPlusList.Add(item);
									flag = (num2 <= 59);
									if (flag)
									{
										this.M0_59AlGpsPlusList.Add(item);
									}
									else
									{
										flag = (num2 <= 79);
										if (flag)
										{
											this.M60_79AlGpsPlusList.Add(item);
										}
										else
										{
											flag = (num2 <= 99);
											if (flag)
											{
												this.M80_99AlGpsPlusList.Add(item);
											}
											else
											{
												flag = (num2 <= 119);
												if (flag)
												{
													this.M100_119AlGpsPlusList.Add(item);
												}
												else
												{
													this.M120_130AlGpsPlusList.Add(item);
												}
											}
										}
									}
									break;
								}
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				bool flag = enumerator2 is IDisposable;
				if (flag)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			Array.Resize<STArchives.entryDef>(ref this.completeAlGpsPlus, this.completeAlGpsPlusList.Count);
			this.completeAlGpsPlusList.CopyTo(this.completeAlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.FixedAlGpsPlus, this.FixedAlGpsPlusList.Count);
			this.FixedAlGpsPlusList.CopyTo(this.FixedAlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.mobileAlGpsPlus, this.mobileAlGpsPlusList.Count);
			this.mobileAlGpsPlusList.CopyTo(this.mobileAlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.F120_130AlGpsPlus, this.F120_130AlGpsPlusList.Count);
			this.F120_130AlGpsPlusList.CopyTo(this.F120_130AlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.F100_119AlGpsPlus, this.F100_119AlGpsPlusList.Count);
			this.F100_119AlGpsPlusList.CopyTo(this.F100_119AlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.F80_99AlGpsPlus, this.F80_99AlGpsPlusList.Count);
			this.F80_99AlGpsPlusList.CopyTo(this.F80_99AlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.F60_79AlGpsPlus, this.F60_79AlGpsPlusList.Count);
			this.F60_79AlGpsPlusList.CopyTo(this.F60_79AlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.F0_59AlGpsPlus, this.F0_59AlGpsPlusList.Count);
			this.F0_59AlGpsPlusList.CopyTo(this.F0_59AlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.M120_130AlGpsPlus, this.M120_130AlGpsPlusList.Count);
			this.M120_130AlGpsPlusList.CopyTo(this.M120_130AlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.M100_119AlGpsPlus, this.M100_119AlGpsPlusList.Count);
			this.M100_119AlGpsPlusList.CopyTo(this.M100_119AlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.M80_99AlGpsPlus, this.M80_99AlGpsPlusList.Count);
			this.M80_99AlGpsPlusList.CopyTo(this.M80_99AlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.M60_79AlGpsPlus, this.M60_79AlGpsPlusList.Count);
			this.M60_79AlGpsPlusList.CopyTo(this.M60_79AlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.M0_59AlGpsPlus, this.M0_59AlGpsPlusList.Count);
			this.M0_59AlGpsPlusList.CopyTo(this.M0_59AlGpsPlus);
			Array.Resize<STArchives.entryDef>(ref this.RFRAlGpsPlus, this.RFRAlGpsPlusList.Count);
			this.RFRAlGpsPlusList.CopyTo(this.RFRAlGpsPlus);
			return true;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00131B54 File Offset: 0x00130B54
		private bool checkWREntries(STArchives.entryDef[] nameList)
		{
			bool flag = !Path.GetFileName(this._zipFile.Name).StartsWith("WR_RF_7_");
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				try
				{
					foreach (object obj in this._zipFile)
					{
						ZipEntry zipEntry = (ZipEntry)obj;
						string name = zipEntry.Name;
						string text = Path.GetFileName(name);
						flag = !Path.GetFileName(name).StartsWith("WR_RF_");
						if (flag)
						{
							return false;
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
				try
				{
					foreach (object obj2 in this._zipFile)
					{
						ZipEntry zipEntry = (ZipEntry)obj2;
						string name = zipEntry.Name;
						string text = Path.GetFileName(name);
						flag = text.EndsWith(".asc");
						if (flag)
						{
							text = Path.GetFileNameWithoutExtension(text);
							string[] array = text.Split(new char[]
							{
								'_'
							});
							flag = (array.Length != 3);
							if (flag)
							{
								return false;
							}
							flag = (Operators.CompareString(array[1], "RF", false) == 0);
							if (!flag)
							{
								return false;
							}
							STArchives.entryDef item = new STArchives.entryDef(name, STArchives.entryType.RF);
							STArchives.entryType entryType = STArchives.entryType.RF;
							int num;
							flag = !int.TryParse(array[2], out num);
							if (flag)
							{
								return false;
							}
							this.completeWRList.Add(item);
							switch (entryType)
							{
							case STArchives.entryType.RF:
								this.FixedWRList.Add(item);
								flag = (num <= 59);
								if (flag)
								{
									this.F0_59WRList.Add(item);
								}
								else
								{
									flag = (num <= 79);
									if (flag)
									{
										this.F60_79WRList.Add(item);
									}
									else
									{
										flag = (num <= 99);
										if (flag)
										{
											this.F80_99WRList.Add(item);
										}
										else
										{
											flag = (num <= 119);
											if (flag)
											{
												this.F100_119WRList.Add(item);
											}
											else
											{
												this.F120_130WRList.Add(item);
											}
										}
									}
								}
								break;
							case STArchives.entryType.RM:
								this.mobileWRList.Add(item);
								flag = (num <= 59);
								if (flag)
								{
									this.M0_59WRList.Add(item);
								}
								else
								{
									flag = (num <= 79);
									if (flag)
									{
										this.M60_79WRList.Add(item);
									}
									else
									{
										flag = (num <= 99);
										if (flag)
										{
											this.M80_99WRList.Add(item);
										}
										else
										{
											flag = (num <= 119);
											if (flag)
											{
												this.M100_119WRList.Add(item);
											}
											else
											{
												this.M120_130WRList.Add(item);
											}
										}
									}
								}
								break;
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator2;
					flag = (enumerator2 is IDisposable);
					if (flag)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				Array.Resize<STArchives.entryDef>(ref this.completeWR, this.completeWRList.Count);
				this.completeWRList.CopyTo(this.completeWR);
				Array.Resize<STArchives.entryDef>(ref this.FixedWR, this.FixedWRList.Count);
				this.FixedWRList.CopyTo(this.FixedWR);
				Array.Resize<STArchives.entryDef>(ref this.mobileWR, this.mobileWRList.Count);
				this.mobileWRList.CopyTo(this.mobileWR);
				Array.Resize<STArchives.entryDef>(ref this.F120_130WR, this.F120_130WRList.Count);
				this.F120_130WRList.CopyTo(this.F120_130WR);
				Array.Resize<STArchives.entryDef>(ref this.F100_119WR, this.F100_119WRList.Count);
				this.F100_119WRList.CopyTo(this.F100_119WR);
				Array.Resize<STArchives.entryDef>(ref this.F80_99WR, this.F80_99WRList.Count);
				this.F80_99WRList.CopyTo(this.F80_99WR);
				Array.Resize<STArchives.entryDef>(ref this.F60_79WR, this.F60_79WRList.Count);
				this.F60_79WRList.CopyTo(this.F60_79WR);
				Array.Resize<STArchives.entryDef>(ref this.F0_59WR, this.F0_59WRList.Count);
				this.F0_59WRList.CopyTo(this.F0_59WR);
				Array.Resize<STArchives.entryDef>(ref this.M120_130WR, this.M120_130WRList.Count);
				this.M120_130WRList.CopyTo(this.M120_130WR);
				Array.Resize<STArchives.entryDef>(ref this.M100_119WR, this.M100_119WRList.Count);
				this.M100_119WRList.CopyTo(this.M100_119WR);
				Array.Resize<STArchives.entryDef>(ref this.M80_99WR, this.M80_99WRList.Count);
				this.M80_99WRList.CopyTo(this.M80_99WR);
				Array.Resize<STArchives.entryDef>(ref this.M60_79WR, this.M60_79WRList.Count);
				this.M60_79WRList.CopyTo(this.M60_79WR);
				Array.Resize<STArchives.entryDef>(ref this.M0_59WR, this.M0_59WRList.Count);
				this.M0_59WRList.CopyTo(this.M0_59WR);
				Array.Resize<STArchives.entryDef>(ref this.RFRWR, this.RFRWRList.Count);
				this.RFRWRList.CopyTo(this.RFRWR);
				result = true;
			}
			return result;
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x001320E0 File Offset: 0x001310E0
		private STArchives.ArchImportMode setSupportedModes(STArchives.STArchiveType archiveType)
		{
			STArchives.ArchImportMode result = STArchives.ArchImportMode.none;
			switch (archiveType)
			{
			case STArchives.STArchiveType.ArcAlgpsStd:
				result = (STArchives.ArchImportMode)1023U;
				break;
			case STArchives.STArchiveType.ArcAlgpsPlus:
				result = (STArchives.ArchImportMode)2047U;
				break;
			case STArchives.STArchiveType.ArcGpsPassStdRM:
				result = (STArchives.ArchImportMode)1023U;
				break;
			case STArchives.STArchiveType.ArcGpsPassStdRF:
				result = (STArchives.ArchImportMode)12U;
				break;
			case STArchives.STArchiveType.ArcGpsPassPlus:
				result = (STArchives.ArchImportMode)2047U;
				break;
			case STArchives.STArchiveType.ArcScdbInfo:
				result = (STArchives.ArchImportMode)1036U;
				break;
			case STArchives.STArchiveType.ArcWarningRadar:
				result = (STArchives.ArchImportMode)1036U;
				break;
			case STArchives.STArchiveType.ArcUnknown:
				result = STArchives.ArchImportMode.none;
				break;
			}
			return result;
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0013215C File Offset: 0x0013115C
		private STArchives.ArchImportMode setSupportedModesAlert(STArchives.STArchiveType archiveType)
		{
			STArchives.ArchImportMode result = STArchives.ArchImportMode.none;
			switch (archiveType)
			{
			case STArchives.STArchiveType.ArcAlgpsStd:
				result = (STArchives.ArchImportMode)277U;
				break;
			case STArchives.STArchiveType.ArcAlgpsPlus:
				result = (STArchives.ArchImportMode)277U;
				break;
			case STArchives.STArchiveType.ArcGpsPassStdRM:
				result = (STArchives.ArchImportMode)277U;
				break;
			case STArchives.STArchiveType.ArcGpsPassStdRF:
				result = STArchives.ArchImportMode.AllRFIcon;
				break;
			case STArchives.STArchiveType.ArcGpsPassPlus:
				result = (STArchives.ArchImportMode)277U;
				break;
			case STArchives.STArchiveType.ArcScdbInfo:
				result = STArchives.ArchImportMode.AllRFIcon;
				break;
			case STArchives.STArchiveType.ArcWarningRadar:
				result = STArchives.ArchImportMode.AllRFIcon;
				break;
			case STArchives.STArchiveType.ArcUnknown:
				result = STArchives.ArchImportMode.none;
				break;
			}
			return result;
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x001321D0 File Offset: 0x001311D0
		public List<STLists> getLists2Import(STArchives.ArchImportMode importMode)
		{
			this.setNameLists();
			List<STLists> list = new List<STLists>();
			bool flag = importMode == STArchives.ArchImportMode.ALLIcon || importMode == STArchives.ArchImportMode.AllText;
			if (flag)
			{
				bool flag2 = MySettingsProperty.Settings.STImportAllTypeIsNP;
				ushort poitype;
				if (flag2)
				{
					poitype = 4444;
				}
				else
				{
					poitype = MySettingsProperty.Settings.STimportAllType;
				}
				list.Add(this.buildSTList(this.completeListOfName, Resources.strArchTypeAll + this.archiveName, poitype, MySettingsProperty.Settings.STimportAllMag));
			}
			else
			{
				bool flag2 = importMode == STArchives.ArchImportMode.AllRFIcon || importMode == STArchives.ArchImportMode.AllRFText;
				if (flag2)
				{
					flag = MySettingsProperty.Settings.STImportFixedTypeIsNP;
					ushort poitype2;
					if (flag)
					{
						poitype2 = 4444;
					}
					else
					{
						poitype2 = MySettingsProperty.Settings.STimportFixedType;
					}
					list.Add(this.buildSTList(this.fixedListOfName, Resources.strArchTypeFixed + this.archiveName, poitype2, MySettingsProperty.Settings.STImportFixedMag));
				}
				else
				{
					flag2 = (importMode == STArchives.ArchImportMode.AllRMIcon || importMode == STArchives.ArchImportMode.AllRMText);
					if (flag2)
					{
						flag = MySettingsProperty.Settings.STImportMobileTypeIsNP;
						ushort poitype3;
						if (flag)
						{
							poitype3 = 4444;
						}
						else
						{
							poitype3 = MySettingsProperty.Settings.STimportMobileType;
						}
						list.Add(this.buildSTList(this.mobileListOfName, Resources.strArchTypeMobile + this.archiveName, poitype3, MySettingsProperty.Settings.STimportMobileMag));
					}
					else
					{
						bool flag3;
						if (importMode != STArchives.ArchImportMode.AllRFIconRMText && importMode != STArchives.ArchImportMode.AllRFTextRMIcon)
						{
							if (importMode != STArchives.ArchImportMode.AllRFIconRMIcon)
							{
								if (importMode != STArchives.ArchImportMode.AllRFTextRMText)
								{
									flag3 = false;
									goto IL_185;
								}
							}
						}
						flag3 = true;
						IL_185:
						flag2 = flag3;
						if (flag2)
						{
							flag = MySettingsProperty.Settings.STImportFixedTypeIsNP;
							ushort poitype2;
							if (flag)
							{
								poitype2 = 4444;
							}
							else
							{
								poitype2 = MySettingsProperty.Settings.STimportFixedType;
							}
							list.Add(this.buildSTList(this.fixedListOfName, Resources.strArchTypeFixed + this.archiveName, poitype2, MySettingsProperty.Settings.STImportFixedMag));
							flag2 = MySettingsProperty.Settings.STImportMobileTypeIsNP;
							ushort poitype3;
							if (flag2)
							{
								poitype3 = 4444;
							}
							else
							{
								poitype3 = MySettingsProperty.Settings.STimportMobileType;
							}
							list.Add(this.buildSTList(this.mobileListOfName, Resources.strArchTypeMobile + this.archiveName, poitype3, MySettingsProperty.Settings.STimportMobileMag));
						}
						else
						{
							flag2 = (importMode == STArchives.ArchImportMode.Custom);
							if (flag2)
							{
								flag = MySettingsProperty.Settings.STImportF120_130G;
								if (flag)
								{
									list.Add(this.buildSTList(this.F120_130GListOfName, Resources.strArchTypeF120_130G + this.archiveName, MySettingsProperty.Settings.STImportF120_130GType, MySettingsProperty.Settings.STImportF120_130GMag));
								}
								flag2 = MySettingsProperty.Settings.STImportF100_119;
								if (flag2)
								{
									list.Add(this.buildSTList(this.F100_119ListOfName, Resources.strArchTypeF100_119 + this.archiveName, MySettingsProperty.Settings.STImportF100_119Type, MySettingsProperty.Settings.STImportF100_119Mag));
								}
								flag2 = MySettingsProperty.Settings.STImportF80_99;
								if (flag2)
								{
									list.Add(this.buildSTList(this.F80_99ListOfName, Resources.strArchTypeF80_99 + this.archiveName, MySettingsProperty.Settings.STImportF80_99Type, MySettingsProperty.Settings.STImportF80_99Mag));
								}
								flag2 = MySettingsProperty.Settings.STImportF60_79;
								if (flag2)
								{
									list.Add(this.buildSTList(this.F60_79ListOfName, Resources.strArchTypeF60_79 + this.archiveName, MySettingsProperty.Settings.STImportF60_79Type, MySettingsProperty.Settings.STImportF60_79Mag));
								}
								flag2 = MySettingsProperty.Settings.STImportF0_59;
								if (flag2)
								{
									list.Add(this.buildSTList(this.F0_59ListOfName, Resources.strArchTypeF0_59 + this.archiveName, MySettingsProperty.Settings.STImportF0_59Type, MySettingsProperty.Settings.STImportF0_59Mag));
								}
								flag2 = MySettingsProperty.Settings.STImportM120_130;
								if (flag2)
								{
									list.Add(this.buildSTList(this.M120_130ListOfName, Resources.strArchTypeM120_130 + this.archiveName, MySettingsProperty.Settings.STImportM120_130Type, MySettingsProperty.Settings.STImportM120_130Mag));
								}
								flag2 = MySettingsProperty.Settings.STImportM100_119;
								if (flag2)
								{
									list.Add(this.buildSTList(this.M100_119ListOfName, Resources.strArchTypeM100_119 + this.archiveName, MySettingsProperty.Settings.STImportM100_119Type, MySettingsProperty.Settings.STImportM100_119Mag));
								}
								flag2 = MySettingsProperty.Settings.STImportM80_99;
								if (flag2)
								{
									list.Add(this.buildSTList(this.M80_99ListOfName, Resources.strArchTypeM80_99 + this.archiveName, MySettingsProperty.Settings.STImportM80_99Type, MySettingsProperty.Settings.STImportM80_99Mag));
								}
								flag2 = MySettingsProperty.Settings.STImportM60_79;
								if (flag2)
								{
									list.Add(this.buildSTList(this.M60_79ListOfName, Resources.strArchTypeM60_79 + this.archiveName, MySettingsProperty.Settings.STImportM60_79Type, MySettingsProperty.Settings.STImportM60_79Mag));
								}
								flag2 = MySettingsProperty.Settings.STImportM0_59;
								if (flag2)
								{
									list.Add(this.buildSTList(this.M0_59ListOfName, Resources.strArchTypeM0_59 + this.archiveName, MySettingsProperty.Settings.STImportM0_59Type, MySettingsProperty.Settings.STImportM0_59Mag));
								}
								flag2 = MySettingsProperty.Settings.STImportRFR;
								if (flag2)
								{
									list.Add(this.buildSTList(this.RFRListOfName, Resources.strArchTypeRFR + this.archiveName, MySettingsProperty.Settings.STImportRFRType, MySettingsProperty.Settings.STImportRFRMag));
								}
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00132744 File Offset: 0x00131744
		private void setNameLists()
		{
			switch (this._archiveType)
			{
			case STArchives.STArchiveType.ArcAlgpsStd:
				this.completeListOfName = this.completeAlGpsStd;
				this.fixedListOfName = this.fixedAlGpsStd;
				this.mobileListOfName = this.mobileAlGpsStd;
				break;
			case STArchives.STArchiveType.ArcAlgpsPlus:
				this.completeListOfName = this.completeAlGpsPlus;
				this.fixedListOfName = this.FixedAlGpsPlus;
				this.mobileListOfName = this.mobileAlGpsPlus;
				this.F120_130GListOfName = this.F120_130AlGpsPlus;
				this.F100_119ListOfName = this.F100_119AlGpsPlus;
				this.F80_99ListOfName = this.F80_99AlGpsPlus;
				this.F60_79ListOfName = this.F60_79AlGpsPlus;
				this.F0_59ListOfName = this.F0_59AlGpsPlus;
				this.M120_130ListOfName = this.M120_130AlGpsPlus;
				this.M100_119ListOfName = this.M100_119AlGpsPlus;
				this.M80_99ListOfName = this.M80_99AlGpsPlus;
				this.M60_79ListOfName = this.M60_79AlGpsPlus;
				this.M0_59ListOfName = this.M0_59AlGpsPlus;
				this.RFRListOfName = this.RFRAlGpsPlus;
				break;
			case STArchives.STArchiveType.ArcGpsPassStdRM:
				this.completeListOfName = this.completeGpspassStdRM;
				this.fixedListOfName = this.fixedGpspassStdRM;
				this.mobileListOfName = this.mobileGpspassStdRM;
				break;
			case STArchives.STArchiveType.ArcGpsPassStdRF:
				this.completeListOfName = this.completeGpspassStdRF;
				this.fixedListOfName = this.fixedGpspassStdRF;
				break;
			case STArchives.STArchiveType.ArcGpsPassPlus:
				this.completeListOfName = this.completeGpspassPlus;
				this.fixedListOfName = this.fixedGpspassPlus;
				this.mobileListOfName = this.mobileGpspassPlus;
				this.F120_130GListOfName = this.F120_130GGpspassPlus;
				this.F100_119ListOfName = this.F100_119GpspassPlus;
				this.F80_99ListOfName = this.F80_99GpspassPlus;
				this.F60_79ListOfName = this.F60_79GpspassPlus;
				this.F0_59ListOfName = this.F0_59GpspassPlus;
				this.M120_130ListOfName = this.M120_130GpspassPlus;
				this.M100_119ListOfName = this.M100_119GpspassPlus;
				this.M80_99ListOfName = this.M80_99GpspassPlus;
				this.M60_79ListOfName = this.M60_79GpspassPlus;
				this.M0_59ListOfName = this.M0_59GpspassPlus;
				this.RFRListOfName = this.RFRGpspassPlus;
				break;
			case STArchives.STArchiveType.ArcWarningRadar:
				this.completeListOfName = this.completeWR;
				this.fixedListOfName = this.FixedWR;
				this.mobileListOfName = this.mobileWR;
				this.F120_130GListOfName = this.F120_130WR;
				this.F100_119ListOfName = this.F100_119WR;
				this.F80_99ListOfName = this.F80_99WR;
				this.F60_79ListOfName = this.F60_79WR;
				this.F0_59ListOfName = this.F0_59WR;
				this.M120_130ListOfName = this.M120_130WR;
				this.M100_119ListOfName = this.M100_119WR;
				this.M80_99ListOfName = this.M80_99WR;
				this.M60_79ListOfName = this.M60_79WR;
				this.M0_59ListOfName = this.M0_59WR;
				this.RFRListOfName = this.RFRWR;
				break;
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x001329FC File Offset: 0x001319FC
		private STLists buildSTList(STArchives.entryDef[] nameList, string displayName, ushort POItype, byte magnitude)
		{
			STLists stlists = new STLists(displayName, POItype, magnitude);
			foreach (STArchives.entryDef entryDef in nameList)
			{
				STLists.STListsEntry item = new STLists.STListsEntry(this._zipFile.GetEntry(entryDef.name), entryDef.type);
				stlists.listOfST.Add(item);
			}
			return stlists;
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00132A60 File Offset: 0x00131A60
		public void close()
		{
			bool flag = this._zipFile != null;
			if (flag)
			{
				this._zipFile.Close();
				this._zipFile = null;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00132A94 File Offset: 0x00131A94
		public STArchives.STArchiveType archiveType
		{
			get
			{
				return this._archiveType;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00132AAC File Offset: 0x00131AAC
		public STArchives.ArchImportMode supportedModes
		{
			get
			{
				bool flag = Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map;
				STArchives.ArchImportMode result;
				if (flag)
				{
					result = this._supportedModes;
				}
				else
				{
					result = this._supportedModesAlert;
				}
				return result;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00132AE0 File Offset: 0x00131AE0
		public ZipFile zipFile
		{
			get
			{
				return this._zipFile;
			}
		}

		// Token: 0x04000958 RID: 2392
		private string _fileName;

		// Token: 0x04000959 RID: 2393
		private STArchives.STArchiveType _archiveType;

		// Token: 0x0400095A RID: 2394
		private STArchives.ArchImportMode _supportedModes;

		// Token: 0x0400095B RID: 2395
		private STArchives.ArchImportMode _supportedModesAlert;

		// Token: 0x0400095C RID: 2396
		private string archiveName;

		// Token: 0x0400095D RID: 2397
		private string listType;

		// Token: 0x0400095E RID: 2398
		private ZipFile _zipFile;

		// Token: 0x0400095F RID: 2399
		private STArchives.entryDef[] completeListOfName;

		// Token: 0x04000960 RID: 2400
		private STArchives.entryDef[] fixedListOfName;

		// Token: 0x04000961 RID: 2401
		private STArchives.entryDef[] mobileListOfName;

		// Token: 0x04000962 RID: 2402
		private STArchives.entryDef[] F120_130GListOfName;

		// Token: 0x04000963 RID: 2403
		private STArchives.entryDef[] F100_119ListOfName;

		// Token: 0x04000964 RID: 2404
		private STArchives.entryDef[] F80_99ListOfName;

		// Token: 0x04000965 RID: 2405
		private STArchives.entryDef[] F60_79ListOfName;

		// Token: 0x04000966 RID: 2406
		private STArchives.entryDef[] F0_59ListOfName;

		// Token: 0x04000967 RID: 2407
		private STArchives.entryDef[] M120_130ListOfName;

		// Token: 0x04000968 RID: 2408
		private STArchives.entryDef[] M100_119ListOfName;

		// Token: 0x04000969 RID: 2409
		private STArchives.entryDef[] M80_99ListOfName;

		// Token: 0x0400096A RID: 2410
		private STArchives.entryDef[] M60_79ListOfName;

		// Token: 0x0400096B RID: 2411
		private STArchives.entryDef[] M0_59ListOfName;

		// Token: 0x0400096C RID: 2412
		private STArchives.entryDef[] RFRListOfName;

		// Token: 0x0400096D RID: 2413
		private STArchives.entryDef[] completeGpspassStdRF;

		// Token: 0x0400096E RID: 2414
		private STArchives.entryDef[] fixedGpspassStdRF;

		// Token: 0x0400096F RID: 2415
		private STArchives.entryDef[] completeGpspassStdRM;

		// Token: 0x04000970 RID: 2416
		private STArchives.entryDef[] fixedGpspassStdRM;

		// Token: 0x04000971 RID: 2417
		private STArchives.entryDef[] mobileGpspassStdRM;

		// Token: 0x04000972 RID: 2418
		private STArchives.entryDef[] completeGpspassPlus;

		// Token: 0x04000973 RID: 2419
		private STArchives.entryDef[] fixedGpspassPlus;

		// Token: 0x04000974 RID: 2420
		private STArchives.entryDef[] mobileGpspassPlus;

		// Token: 0x04000975 RID: 2421
		private STArchives.entryDef[] F120_130GGpspassPlus;

		// Token: 0x04000976 RID: 2422
		private STArchives.entryDef[] F100_119GpspassPlus;

		// Token: 0x04000977 RID: 2423
		private STArchives.entryDef[] F80_99GpspassPlus;

		// Token: 0x04000978 RID: 2424
		private STArchives.entryDef[] F60_79GpspassPlus;

		// Token: 0x04000979 RID: 2425
		private STArchives.entryDef[] F0_59GpspassPlus;

		// Token: 0x0400097A RID: 2426
		private STArchives.entryDef[] M120_130GpspassPlus;

		// Token: 0x0400097B RID: 2427
		private STArchives.entryDef[] M100_119GpspassPlus;

		// Token: 0x0400097C RID: 2428
		private STArchives.entryDef[] M80_99GpspassPlus;

		// Token: 0x0400097D RID: 2429
		private STArchives.entryDef[] M60_79GpspassPlus;

		// Token: 0x0400097E RID: 2430
		private STArchives.entryDef[] M0_59GpspassPlus;

		// Token: 0x0400097F RID: 2431
		private STArchives.entryDef[] RFRGpspassPlus;

		// Token: 0x04000980 RID: 2432
		private STArchives.entryDef[] completeAlGpsStd;

		// Token: 0x04000981 RID: 2433
		private STArchives.entryDef[] fixedAlGpsStd;

		// Token: 0x04000982 RID: 2434
		private STArchives.entryDef[] mobileAlGpsStd;

		// Token: 0x04000983 RID: 2435
		private STArchives.entryDef[] completeAlGpsPlus;

		// Token: 0x04000984 RID: 2436
		private List<STArchives.entryDef> completeAlGpsPlusList;

		// Token: 0x04000985 RID: 2437
		private STArchives.entryDef[] FixedAlGpsPlus;

		// Token: 0x04000986 RID: 2438
		private List<STArchives.entryDef> FixedAlGpsPlusList;

		// Token: 0x04000987 RID: 2439
		private STArchives.entryDef[] mobileAlGpsPlus;

		// Token: 0x04000988 RID: 2440
		private List<STArchives.entryDef> mobileAlGpsPlusList;

		// Token: 0x04000989 RID: 2441
		private STArchives.entryDef[] F120_130AlGpsPlus;

		// Token: 0x0400098A RID: 2442
		private List<STArchives.entryDef> F120_130AlGpsPlusList;

		// Token: 0x0400098B RID: 2443
		private STArchives.entryDef[] F100_119AlGpsPlus;

		// Token: 0x0400098C RID: 2444
		private List<STArchives.entryDef> F100_119AlGpsPlusList;

		// Token: 0x0400098D RID: 2445
		private STArchives.entryDef[] F80_99AlGpsPlus;

		// Token: 0x0400098E RID: 2446
		private List<STArchives.entryDef> F80_99AlGpsPlusList;

		// Token: 0x0400098F RID: 2447
		private STArchives.entryDef[] F60_79AlGpsPlus;

		// Token: 0x04000990 RID: 2448
		private List<STArchives.entryDef> F60_79AlGpsPlusList;

		// Token: 0x04000991 RID: 2449
		private STArchives.entryDef[] F0_59AlGpsPlus;

		// Token: 0x04000992 RID: 2450
		private List<STArchives.entryDef> F0_59AlGpsPlusList;

		// Token: 0x04000993 RID: 2451
		private STArchives.entryDef[] M120_130AlGpsPlus;

		// Token: 0x04000994 RID: 2452
		private List<STArchives.entryDef> M120_130AlGpsPlusList;

		// Token: 0x04000995 RID: 2453
		private STArchives.entryDef[] M100_119AlGpsPlus;

		// Token: 0x04000996 RID: 2454
		private List<STArchives.entryDef> M100_119AlGpsPlusList;

		// Token: 0x04000997 RID: 2455
		private STArchives.entryDef[] M80_99AlGpsPlus;

		// Token: 0x04000998 RID: 2456
		private List<STArchives.entryDef> M80_99AlGpsPlusList;

		// Token: 0x04000999 RID: 2457
		private STArchives.entryDef[] M60_79AlGpsPlus;

		// Token: 0x0400099A RID: 2458
		private List<STArchives.entryDef> M60_79AlGpsPlusList;

		// Token: 0x0400099B RID: 2459
		private STArchives.entryDef[] M0_59AlGpsPlus;

		// Token: 0x0400099C RID: 2460
		private List<STArchives.entryDef> M0_59AlGpsPlusList;

		// Token: 0x0400099D RID: 2461
		private STArchives.entryDef[] RFRAlGpsPlus;

		// Token: 0x0400099E RID: 2462
		private List<STArchives.entryDef> RFRAlGpsPlusList;

		// Token: 0x0400099F RID: 2463
		private STArchives.entryDef[] completeWR;

		// Token: 0x040009A0 RID: 2464
		private List<STArchives.entryDef> completeWRList;

		// Token: 0x040009A1 RID: 2465
		private STArchives.entryDef[] FixedWR;

		// Token: 0x040009A2 RID: 2466
		private List<STArchives.entryDef> FixedWRList;

		// Token: 0x040009A3 RID: 2467
		private STArchives.entryDef[] mobileWR;

		// Token: 0x040009A4 RID: 2468
		private List<STArchives.entryDef> mobileWRList;

		// Token: 0x040009A5 RID: 2469
		private STArchives.entryDef[] F120_130WR;

		// Token: 0x040009A6 RID: 2470
		private List<STArchives.entryDef> F120_130WRList;

		// Token: 0x040009A7 RID: 2471
		private STArchives.entryDef[] F100_119WR;

		// Token: 0x040009A8 RID: 2472
		private List<STArchives.entryDef> F100_119WRList;

		// Token: 0x040009A9 RID: 2473
		private STArchives.entryDef[] F80_99WR;

		// Token: 0x040009AA RID: 2474
		private List<STArchives.entryDef> F80_99WRList;

		// Token: 0x040009AB RID: 2475
		private STArchives.entryDef[] F60_79WR;

		// Token: 0x040009AC RID: 2476
		private List<STArchives.entryDef> F60_79WRList;

		// Token: 0x040009AD RID: 2477
		private STArchives.entryDef[] F0_59WR;

		// Token: 0x040009AE RID: 2478
		private List<STArchives.entryDef> F0_59WRList;

		// Token: 0x040009AF RID: 2479
		private STArchives.entryDef[] M120_130WR;

		// Token: 0x040009B0 RID: 2480
		private List<STArchives.entryDef> M120_130WRList;

		// Token: 0x040009B1 RID: 2481
		private STArchives.entryDef[] M100_119WR;

		// Token: 0x040009B2 RID: 2482
		private List<STArchives.entryDef> M100_119WRList;

		// Token: 0x040009B3 RID: 2483
		private STArchives.entryDef[] M80_99WR;

		// Token: 0x040009B4 RID: 2484
		private List<STArchives.entryDef> M80_99WRList;

		// Token: 0x040009B5 RID: 2485
		private STArchives.entryDef[] M60_79WR;

		// Token: 0x040009B6 RID: 2486
		private List<STArchives.entryDef> M60_79WRList;

		// Token: 0x040009B7 RID: 2487
		private STArchives.entryDef[] M0_59WR;

		// Token: 0x040009B8 RID: 2488
		private List<STArchives.entryDef> M0_59WRList;

		// Token: 0x040009B9 RID: 2489
		private STArchives.entryDef[] RFRWR;

		// Token: 0x040009BA RID: 2490
		private List<STArchives.entryDef> RFRWRList;

		// Token: 0x020000D5 RID: 213
		public enum STArchiveType
		{
			// Token: 0x040009BC RID: 2492
			ArcAlgpsStd,
			// Token: 0x040009BD RID: 2493
			ArcAlgpsPlus,
			// Token: 0x040009BE RID: 2494
			ArcGpsPassStdRM,
			// Token: 0x040009BF RID: 2495
			ArcGpsPassStdRF,
			// Token: 0x040009C0 RID: 2496
			ArcGpsPassPlus,
			// Token: 0x040009C1 RID: 2497
			ArcScdbInfo,
			// Token: 0x040009C2 RID: 2498
			ArcWarningRadar,
			// Token: 0x040009C3 RID: 2499
			ArcUnknown
		}

		// Token: 0x020000D6 RID: 214
		public enum ArchImportMode : uint
		{
			// Token: 0x040009C5 RID: 2501
			none,
			// Token: 0x040009C6 RID: 2502
			ALLIcon,
			// Token: 0x040009C7 RID: 2503
			AllText,
			// Token: 0x040009C8 RID: 2504
			AllRFIcon = 4U,
			// Token: 0x040009C9 RID: 2505
			AllRFText = 8U,
			// Token: 0x040009CA RID: 2506
			AllRMIcon = 16U,
			// Token: 0x040009CB RID: 2507
			AllRMText = 32U,
			// Token: 0x040009CC RID: 2508
			AllRFIconRMText = 64U,
			// Token: 0x040009CD RID: 2509
			AllRFTextRMIcon = 128U,
			// Token: 0x040009CE RID: 2510
			AllRFIconRMIcon = 256U,
			// Token: 0x040009CF RID: 2511
			AllRFTextRMText = 512U,
			// Token: 0x040009D0 RID: 2512
			Custom = 1024U,
			// Token: 0x040009D1 RID: 2513
			Allmodes = 65535U
		}

		// Token: 0x020000D7 RID: 215
		public enum entryType
		{
			// Token: 0x040009D3 RID: 2515
			ZD,
			// Token: 0x040009D4 RID: 2516
			RF,
			// Token: 0x040009D5 RID: 2517
			RFR,
			// Token: 0x040009D6 RID: 2518
			RM,
			// Token: 0x040009D7 RID: 2519
			Unknown
		}

		// Token: 0x020000D8 RID: 216
		private class entryDef
		{
			// Token: 0x06000E6E RID: 3694 RVA: 0x00132AF8 File Offset: 0x00131AF8
			public entryDef(string name, STArchives.entryType type)
			{
				this.name = name;
				this.type = type;
			}

			// Token: 0x040009D8 RID: 2520
			public string name;

			// Token: 0x040009D9 RID: 2521
			public STArchives.entryType type;
		}
	}
}
