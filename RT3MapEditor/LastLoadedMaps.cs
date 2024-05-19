using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x02000045 RID: 69
	public class LastLoadedMaps
	{
		// Token: 0x0600077F RID: 1919 RVA: 0x0010943C File Offset: 0x0010843C
		public LastLoadedMaps(ToolStripMenuItem MapToolStripMenuItem, ToolStripSplitButton Load_ToolStripButton)
		{
			this.mapLoadMenuItemList = new List<ToolStripMenuItem>();
			try
			{
				foreach (object obj in MapToolStripMenuItem.DropDownItems)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					bool flag = objectValue.GetType().Equals(typeof(ToolStripMenuItem));
					if (flag)
					{
						ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)objectValue;
						flag = toolStripMenuItem.Name.StartsWith("Map");
						if (flag)
						{
							this.mapLoadMenuItemList.Add(toolStripMenuItem);
						}
						else
						{
							flag = toolStripMenuItem.Name.StartsWith("LoadMap");
							if (flag)
							{
								this.LoadMap_ToolStripMenuItem = toolStripMenuItem;
							}
						}
					}
					else
					{
						flag = objectValue.GetType().Equals(typeof(ToolStripSeparator));
						if (flag)
						{
							ToolStripSeparator toolStripSeparator = (ToolStripSeparator)objectValue;
							flag = toolStripSeparator.Name.StartsWith("Map");
							if (flag)
							{
								this.mapMenuSeparator = toolStripSeparator;
							}
						}
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
			this.mapLoadButtonItemList = new List<ToolStripMenuItem>();
			try
			{
				foreach (object obj2 in Load_ToolStripButton.DropDownItems)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj2);
					bool flag = objectValue.GetType().Equals(typeof(ToolStripMenuItem));
					if (flag)
					{
						ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)objectValue;
						flag = toolStripMenuItem.Name.StartsWith("Map");
						if (flag)
						{
							this.mapLoadButtonItemList.Add(toolStripMenuItem);
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
			this.load_ToolStripButton = Load_ToolStripButton;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0010961C File Offset: 0x0010861C
		public void loadFromSettings()
		{
			this.settingsList = MySettingsProperty.Settings.lastLoadedMaps;
			bool flag = this.settingsList == null;
			if (flag)
			{
				this.settingsList = new NVPairList();
			}
			this.updateMenu();
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0010965C File Offset: 0x0010865C
		public void saveInSettings()
		{
			MySettingsProperty.Settings.lastLoadedMaps = this.settingsList;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00109674 File Offset: 0x00108674
		public void addEntry(string path, string name)
		{
			bool flag = false;
			bool flag2;
			try
			{
				foreach (NVPair nvpair in this.settingsList)
				{
					flag2 = (Operators.CompareString(nvpair.name, path, false) == 0);
					if (flag2)
					{
						flag = true;
						break;
					}
				}
			}
			finally
			{
				List<NVPair>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			flag2 = !flag;
			if (flag2)
			{
				NVPair nvpair = new NVPair();
				nvpair.name = path;
				nvpair.value = name;
				this.settingsList.Insert(0, nvpair);
				flag2 = (this.settingsList.Count > 10);
				if (flag2)
				{
					this.settingsList.RemoveAt(10);
				}
			}
			this.updateMenu();
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00109738 File Offset: 0x00108738
		public void removeEntry(string path)
		{
			int num = 0;
			checked
			{
				bool flag;
				try
				{
					foreach (NVPair nvpair in this.settingsList)
					{
						flag = (Operators.CompareString(nvpair.name, path, false) == 0);
						if (flag)
						{
							break;
						}
						num++;
					}
				}
				finally
				{
					List<NVPair>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				flag = (num < this.settingsList.Count);
				if (flag)
				{
					this.settingsList.RemoveAt(num);
				}
				this.updateMenu();
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x001097D4 File Offset: 0x001087D4
		public string getPath(string entryName)
		{
			bool flag = false;
			NVPair nvpair = null;
			bool flag2;
			try
			{
				List<NVPair>.Enumerator enumerator = this.settingsList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					nvpair = enumerator.Current;
					flag2 = (Operators.CompareString(nvpair.value, entryName, false) == 0);
					if (flag2)
					{
						flag = true;
						break;
					}
				}
			}
			finally
			{
				List<NVPair>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			flag2 = flag;
			string result;
			if (flag2)
			{
				result = nvpair.name;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00109864 File Offset: 0x00108864
		public void updateMenu()
		{
			int num = 0;
			bool flag = MySettingsProperty.Settings.configCompleteOnce;
			if (flag)
			{
				this.LoadMap_ToolStripMenuItem.Enabled = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
				this.load_ToolStripButton.Enabled = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
			}
			else
			{
				this.load_ToolStripButton.Enabled = false;
				this.LoadMap_ToolStripMenuItem.Enabled = false;
			}
			flag = (this.settingsList.Count > 0);
			if (flag)
			{
				this.mapMenuSeparator.Visible = (Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
			}
			else
			{
				this.mapMenuSeparator.Visible = false;
			}
			checked
			{
				try
				{
					foreach (ToolStripMenuItem toolStripMenuItem in this.mapLoadMenuItemList)
					{
						flag = (this.settingsList.Count > num & Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
						if (flag)
						{
							toolStripMenuItem.Text = this.settingsList[num].value;
							toolStripMenuItem.ToolTipText = this.settingsList[num].name;
							toolStripMenuItem.Visible = true;
						}
						else
						{
							toolStripMenuItem.Visible = false;
							toolStripMenuItem.Text = "";
							toolStripMenuItem.ToolTipText = "";
						}
						num++;
					}
				}
				finally
				{
					List<ToolStripMenuItem>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				num = 0;
				try
				{
					foreach (ToolStripMenuItem toolStripMenuItem in this.mapLoadButtonItemList)
					{
						flag = (this.settingsList.Count > num & Common.RTxMapEditorMapMode == Common.RTxMapEditorMapModes.map);
						if (flag)
						{
							toolStripMenuItem.Text = this.settingsList[num].value;
							toolStripMenuItem.ToolTipText = this.settingsList[num].name;
							toolStripMenuItem.Visible = true;
						}
						else
						{
							toolStripMenuItem.Visible = false;
							toolStripMenuItem.Text = "";
							toolStripMenuItem.ToolTipText = "";
						}
						num++;
					}
				}
				finally
				{
					List<ToolStripMenuItem>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00109A98 File Offset: 0x00108A98
		public int getEntryNb()
		{
			return this.settingsList.Count;
		}

		// Token: 0x04000425 RID: 1061
		private const int MAX_ENTRY_NUMBER = 10;

		// Token: 0x04000426 RID: 1062
		private NVPairList settingsList;

		// Token: 0x04000427 RID: 1063
		private List<ToolStripMenuItem> mapLoadMenuItemList;

		// Token: 0x04000428 RID: 1064
		private ToolStripSeparator mapMenuSeparator;

		// Token: 0x04000429 RID: 1065
		private ToolStripMenuItem LoadMap_ToolStripMenuItem;

		// Token: 0x0400042A RID: 1066
		private List<ToolStripMenuItem> mapLoadButtonItemList;

		// Token: 0x0400042B RID: 1067
		private ToolStripSplitButton load_ToolStripButton;
	}
}
