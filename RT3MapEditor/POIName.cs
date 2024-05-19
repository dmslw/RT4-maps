using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000068 RID: 104
	public class POIName
	{
		// Token: 0x06000CFB RID: 3323 RVA: 0x0011E4E4 File Offset: 0x0011D4E4
		public POIName(POIName.nameTypes nameType)
		{
			this.myDisplayAttributes = new POIName.displayAttributes();
			this.nameType = nameType;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0011E504 File Offset: 0x0011D504
		public POIName.nameTypes getNameType(POILists listOfPOI)
		{
			int num = 0;
			int num2 = 0;
			bool flag = this.nameType == POIName.nameTypes.notChecked;
			POIName.nameTypes result;
			if (flag)
			{
				int num3 = 0;
				bool flag2;
				checked
				{
					int num4 = listOfPOI.ListofPOI.Count - 1;
					int num5 = num3;
					for (;;)
					{
						int num6 = num5;
						int num7 = num4;
						if (num6 > num7)
						{
							break;
						}
						flag2 = POIName.regexGpsPassion.IsMatch(listOfPOI.ListofPOI[num5].origName);
						if (flag2)
						{
							num2++;
						}
						else
						{
							num++;
						}
						num5++;
					}
				}
				flag2 = ((double)num2 >= 0.9 * (double)listOfPOI.ListofPOI.Count);
				if (flag2)
				{
					this.nameType = POIName.nameTypes.gpspassion;
					this.myDisplayAttributes.nameDisplayMode = POIName.nameDisplayModes.gpsPassion;
					result = POIName.nameTypes.gpspassion;
				}
				else
				{
					this.nameType = POIName.nameTypes.unknown;
					result = POIName.nameTypes.unknown;
				}
			}
			else
			{
				result = this.nameType;
			}
			return result;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0011E5D0 File Offset: 0x0011D5D0
		public string translateName(string origName)
		{
			return POIName.translateName(origName, this.myDisplayAttributes);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0011E5F0 File Offset: 0x0011D5F0
		private static string translateName(string origName, POIName.displayAttributes myDisplayAttributes)
		{
			string result = null;
			switch (myDisplayAttributes.nameDisplayMode)
			{
			case POIName.nameDisplayModes.asIs:
				result = origName;
				break;
			case POIName.nameDisplayModes.userDef:
				result = myDisplayAttributes.userDefinedName;
				break;
			case POIName.nameDisplayModes.gpsPassion:
			{
				bool flag = POIName.regexGpsPassion.IsMatch(origName);
				if (flag)
				{
					result = POIName.translateGpspassionName(origName, myDisplayAttributes);
				}
				else
				{
					result = origName;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0011E64C File Offset: 0x0011D64C
		private static string translateGpspassionName(string origName, POIName.displayAttributes myDisplayAttributes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Match match = POIName.regexGpsPassion.Match(origName);
			GroupCollection groups = match.Groups;
			string text = groups[1].ToString();
			string value = groups[2].ToString();
			string value2 = groups[3].ToString();
			string text2 = groups[4].ToString();
			string text3 = groups[5].ToString();
			string text4 = groups[6].ToString();
			string text5 = groups[7].ToString();
			bool flag = myDisplayAttributes.isGpsPasStartDisplayed;
			if (flag)
			{
				stringBuilder.Append(MySettingsProperty.Settings.strGpsPasStart);
			}
			flag = myDisplayAttributes.isGpsPasTypeDisplayed;
			bool flag2;
			if (flag)
			{
				string left = text;
				flag2 = (Operators.CompareString(left, "PAN", false) == 0);
				if (flag2)
				{
					stringBuilder.Append(MySettingsProperty.Settings.strGpsPasPAN);
				}
				else
				{
					flag2 = (Operators.CompareString(left, "PL", false) == 0);
					if (flag2)
					{
						stringBuilder.Append(MySettingsProperty.Settings.strGpsPasPL);
					}
					else
					{
						flag2 = (Operators.CompareString(left, "RD", false) == 0);
						if (flag2)
						{
							stringBuilder.Append(MySettingsProperty.Settings.strGpsPasRD);
						}
						else
						{
							flag2 = (Operators.CompareString(left, "RF", false) == 0);
							if (flag2)
							{
								stringBuilder.Append(MySettingsProperty.Settings.strGpsPasRF);
							}
							else
							{
								flag2 = (Operators.CompareString(left, "RFR", false) == 0);
								if (flag2)
								{
									stringBuilder.Append(MySettingsProperty.Settings.strGpsPasRFR);
								}
								else
								{
									flag2 = (Operators.CompareString(left, "RM", false) == 0);
									if (flag2)
									{
										stringBuilder.Append(MySettingsProperty.Settings.strGpsPasRM);
									}
									else
									{
										stringBuilder.Append(text);
									}
								}
							}
						}
					}
				}
			}
			flag2 = myDisplayAttributes.isGpsPasNumDisplayed;
			if (flag2)
			{
				stringBuilder.Append(value);
			}
			flag2 = myDisplayAttributes.isGpsPasRFRPostDisplayed;
			if (flag2)
			{
				stringBuilder.Append(value2);
			}
			flag2 = (myDisplayAttributes.isGpsPasSep1Displayed && myDisplayAttributes.isGpsPasSpeedDisplayed && Operators.CompareString(text2, "", false) != 0);
			if (flag2)
			{
				stringBuilder.Append(MySettingsProperty.Settings.strGpsPasSep1);
			}
			flag2 = myDisplayAttributes.isGpsPasSpeedDisplayed;
			if (flag2)
			{
				stringBuilder.Append(text2);
			}
			flag2 = (myDisplayAttributes.isGpsPasSpeedUnitDisplayed && myDisplayAttributes.isGpsPasSpeedDisplayed && Operators.CompareString(text2, "", false) != 0);
			if (flag2)
			{
				stringBuilder.Append(MySettingsProperty.Settings.strGpsPasKMH);
			}
			flag2 = (myDisplayAttributes.isGpsPasSep2Displayed && myDisplayAttributes.isGpsPasDirDisplayed && Operators.CompareString(text4, "", false) != 0);
			if (flag2)
			{
				stringBuilder.Append(MySettingsProperty.Settings.strGpsPasSep2);
			}
			flag2 = myDisplayAttributes.isGpsPasDirDisplayed;
			if (flag2)
			{
				string left2 = text4;
				flag = (Operators.CompareString(left2, "F", false) == 0);
				if (flag)
				{
					stringBuilder.Append(MySettingsProperty.Settings.strGpsPasF);
				}
				else
				{
					flag2 = (Operators.CompareString(left2, "R", false) == 0);
					if (flag2)
					{
						stringBuilder.Append(MySettingsProperty.Settings.strGpsPasR);
					}
					else
					{
						flag2 = (Operators.CompareString(left2, "NC", false) == 0);
						if (flag2)
						{
							stringBuilder.Append(MySettingsProperty.Settings.strGpsPasNC);
						}
						else
						{
							stringBuilder.Append(text4);
						}
					}
				}
			}
			flag2 = (myDisplayAttributes.isGpsPasMiscDisplayed && Operators.CompareString(text5, "", false) != 0);
			if (flag2)
			{
				stringBuilder.Append(" ");
				stringBuilder.Append(text5);
			}
			flag2 = myDisplayAttributes.isGpsPasEndDisplayed;
			if (flag2)
			{
				stringBuilder.Append(MySettingsProperty.Settings.strGpsPasEnd);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0011EA50 File Offset: 0x0011DA50
		public static uint getSpeed(string origName)
		{
			uint num = 999U;
			Match match = POIName.regexGpsPassion.Match(origName);
			string s = match.Groups[4].ToString();
			bool flag = !uint.TryParse(s, NumberStyles.Integer, Common.cultENUS, out num);
			checked
			{
				if (flag)
				{
					num = 999U;
				}
				else
				{
					num *= 1U;
				}
				return num;
			}
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0011EAB4 File Offset: 0x0011DAB4
		public static string setExampleLabel(POIName.displayAttributes myDisplayAttributes)
		{
			string result = null;
			switch (myDisplayAttributes.nameDisplayMode)
			{
			case POIName.nameDisplayModes.asIs:
				result = Resources.strNameExampleAsIs;
				break;
			case POIName.nameDisplayModes.userDef:
				result = myDisplayAttributes.userDefinedName;
				break;
			case POIName.nameDisplayModes.gpsPassion:
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(POIName.translateName("RFR056V", myDisplayAttributes));
				stringBuilder.Append(", ");
				stringBuilder.Append(POIName.translateName("RF0602-090km/h-F", myDisplayAttributes));
				stringBuilder.Append(", ");
				stringBuilder.Append(POIName.translateName("RD012", myDisplayAttributes));
				stringBuilder.Append(", ");
				stringBuilder.Append(POIName.translateName("RM12050-050km/h", myDisplayAttributes));
				result = stringBuilder.ToString();
				break;
			}
			}
			return result;
		}

		// Token: 0x04000530 RID: 1328
		private static Regex regexGpsPassion = new Regex("\\b(?<type>PAN|PL|RD|RF|RFR|RM)(?<num>\\d{1,6})(?<unk1>V)?-?(?<speed>\\d{3})?(?<km>km/h)?-?(?<dir>F|R)?(?<add>.*)?\\b", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace | RegexOptions.CultureInvariant);

		// Token: 0x04000531 RID: 1329
		public POIName.displayAttributes myDisplayAttributes;

		// Token: 0x04000532 RID: 1330
		public POIName.nameTypes nameType;

		// Token: 0x02000069 RID: 105
		public class displayAttributes
		{
			// Token: 0x06000D02 RID: 3330 RVA: 0x0011EB7C File Offset: 0x0011DB7C
			public displayAttributes()
			{
				this.nameDisplayMode = POIName.nameDisplayModes.asIs;
				this.userDefinedName = MySettingsProperty.Settings.gpspasUserDefName;
				this.isGpsPasStartDisplayed = MySettingsProperty.Settings.isGpsPasStartDisplayed;
				this.isGpsPasTypeDisplayed = MySettingsProperty.Settings.isGpsPasTypeDisplayed;
				this.isGpsPasNumDisplayed = MySettingsProperty.Settings.isGpsPasNumDisplayed;
				this.isGpsPasRFRPostDisplayed = MySettingsProperty.Settings.isGpsPasRFRPostDisplayed;
				this.isGpsPasSep1Displayed = MySettingsProperty.Settings.isGpsPasSep1Displayed;
				this.isGpsPasSpeedDisplayed = MySettingsProperty.Settings.isGpsPasSpeedDisplayed;
				this.isGpsPasSpeedUnitDisplayed = MySettingsProperty.Settings.isGpsPasSpeedUnitDisplayed;
				this.isGpsPasSep2Displayed = MySettingsProperty.Settings.isGpsPasSep2Displayed;
				this.isGpsPasDirDisplayed = MySettingsProperty.Settings.isGpsPasDirDisplayed;
				this.isGpsPasMiscDisplayed = MySettingsProperty.Settings.isGpsPasMiscDisplayed;
				this.isGpsPasEndDisplayed = MySettingsProperty.Settings.isGpsPasEndDisplayed;
			}

			// Token: 0x04000533 RID: 1331
			public POIName.nameDisplayModes nameDisplayMode;

			// Token: 0x04000534 RID: 1332
			public string userDefinedName;

			// Token: 0x04000535 RID: 1333
			public bool isGpsPasStartDisplayed;

			// Token: 0x04000536 RID: 1334
			public bool isGpsPasTypeDisplayed;

			// Token: 0x04000537 RID: 1335
			public bool isGpsPasNumDisplayed;

			// Token: 0x04000538 RID: 1336
			public bool isGpsPasRFRPostDisplayed;

			// Token: 0x04000539 RID: 1337
			public bool isGpsPasSep1Displayed;

			// Token: 0x0400053A RID: 1338
			public bool isGpsPasSpeedDisplayed;

			// Token: 0x0400053B RID: 1339
			public bool isGpsPasSpeedUnitDisplayed;

			// Token: 0x0400053C RID: 1340
			public bool isGpsPasSep2Displayed;

			// Token: 0x0400053D RID: 1341
			public bool isGpsPasDirDisplayed;

			// Token: 0x0400053E RID: 1342
			public bool isGpsPasMiscDisplayed;

			// Token: 0x0400053F RID: 1343
			public bool isGpsPasEndDisplayed;
		}

		// Token: 0x0200006A RID: 106
		public enum nameTypes
		{
			// Token: 0x04000541 RID: 1345
			notChecked,
			// Token: 0x04000542 RID: 1346
			unknown,
			// Token: 0x04000543 RID: 1347
			gpspassion,
			// Token: 0x04000544 RID: 1348
			RT3
		}

		// Token: 0x0200006B RID: 107
		public enum nameDisplayModes
		{
			// Token: 0x04000546 RID: 1350
			asIs,
			// Token: 0x04000547 RID: 1351
			userDef,
			// Token: 0x04000548 RID: 1352
			gpsPassion
		}
	}
}
