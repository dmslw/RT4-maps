using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000020 RID: 32
	public class DriveList
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x000FD408 File Offset: 0x000FC408
		public DriveList(ListView driveListView, long sizeNeeded, DriveList.driveChanged del)
		{
			this.allDrives = null;
			this.driveStatusList = null;
			this.driveNameList = null;
			this.driveSizeList = null;
			this.selectedItem = -1;
			this.sizeNeeded = 0L;
			this.driveListView = driveListView;
			this.sizeNeeded = sizeNeeded;
			this.del = del;
			ImageList imageList = DriveList.largeImageList;
			Size imageSize = new Size(32, 32);
			imageList.ImageSize = imageSize;
			DriveList.largeImageList.Images.Add("removOK32", Resources.removOK32);
			DriveList.largeImageList.Images.Add("removKO32", Resources.removKO32);
			driveListView.LargeImageList = DriveList.largeImageList;
			driveListView.SelectedIndexChanged += this.DriveListView_SelectedIndexChanged;
			driveListView.HideSelection = false;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000FD4D4 File Offset: 0x000FC4D4
		public void buildDriveList()
		{
			int num = 0;
			this.driveListView.Clear();
			this.allDrives = DriveInfo.GetDrives();
			this.driveStatusList = new List<bool>();
			this.driveNameList = new List<string>();
			this.driveSizeList = new List<int>();
			checked
			{
				bool flag2;
				foreach (DriveInfo driveInfo in this.allDrives)
				{
					string text = driveInfo.Name;
					bool flag = text.EndsWith("\\");
					if (flag)
					{
						text = text.Substring(0, text.Length - 1);
					}
					flag = (driveInfo.DriveType == DriveType.Removable);
					if (flag)
					{
						bool isReady = driveInfo.IsReady;
						string text3;
						string text4;
						int item;
						if (isReady)
						{
							flag2 = (driveInfo.VolumeLabel == null || Operators.CompareString(driveInfo.VolumeLabel, "", false) == 0);
							string text2;
							if (flag2)
							{
								text2 = Resources.RemovDskLabel;
							}
							else
							{
								text2 = driveInfo.VolumeLabel;
							}
							flag2 = (Operators.CompareString(driveInfo.DriveFormat, "FAT", false) == 0 || Operators.CompareString(driveInfo.DriveFormat, "FAT32", false) == 0);
							if (flag2)
							{
								text3 = string.Format("{0:G} ({1:G}) {2:G} {3:G}", new object[]
								{
									text2,
									text,
									(int)Math.Round((double)driveInfo.TotalSize / 1048576.0),
									Resources.strMB
								});
								flag2 = (driveInfo.TotalSize > this.sizeNeeded);
								if (flag2)
								{
									text4 = "removOK32";
									flag2 = (this.selectedItem == -1);
									if (flag2)
									{
										this.selectedItem = num;
									}
								}
								else
								{
									text4 = "removKO32";
								}
							}
							else
							{
								text3 = string.Format("{0:G} ({1:G})", Resources.RemovDskLabel, text);
								text4 = "removKO32";
							}
							item = (int)Math.Round((double)driveInfo.TotalSize / 1048576.0);
						}
						else
						{
							text3 = string.Format("{0:G} ({1:G})", Resources.RemovDskLabel, text);
							text4 = "removKO32";
							item = 0;
						}
						this.driveListView.Items.Add(text3, text4);
						flag2 = (Operators.CompareString(text4, "removKO32", false) == 0);
						if (flag2)
						{
							this.driveStatusList.Add(false);
						}
						else
						{
							this.driveStatusList.Add(true);
						}
						this.driveNameList.Add(text);
						this.driveSizeList.Add(item);
						num++;
					}
				}
				flag2 = (num == 0);
				if (flag2)
				{
					this.driveStatusList.Add(false);
					this.driveListView.Items.Add(Resources.noRemovDsk, "removKO32");
				}
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000FD784 File Offset: 0x000FC784
		public void defaultSelect()
		{
			bool flag = this.driveListView.CanFocus;
			if (flag)
			{
				this.driveListView.Focus();
			}
			flag = (this.selectedItem != -1);
			if (flag)
			{
				this.driveListView.Items[this.selectedItem].Selected = true;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000FD7E0 File Offset: 0x000FC7E0
		private void DriveListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.driveListView.SelectedIndices.Count == 0;
			if (flag)
			{
				this.selectedItem = -1;
			}
			else
			{
				flag = this.driveStatusList[this.driveListView.SelectedIndices[0]];
				if (flag)
				{
					this.selectedItem = this.driveListView.SelectedIndices[0];
				}
				else
				{
					this.selectedItem = -1;
				}
			}
			flag = (this.del != null);
			if (flag)
			{
				this.del();
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000FD870 File Offset: 0x000FC870
		public string getDriveToUse()
		{
			bool flag = this.selectedItem != -1;
			string result;
			if (flag)
			{
				result = this.driveNameList[this.selectedItem];
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000FD8B0 File Offset: 0x000FC8B0
		public int getDriveSize()
		{
			bool flag = this.selectedItem != -1;
			int result;
			if (flag)
			{
				result = this.driveSizeList[this.selectedItem];
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000FD8EC File Offset: 0x000FC8EC
		public int getSelectedItem()
		{
			return this.selectedItem;
		}

		// Token: 0x040001B0 RID: 432
		private static ImageList largeImageList = new ImageList();

		// Token: 0x040001B1 RID: 433
		private const string icoRemovableOK = "removOK32";

		// Token: 0x040001B2 RID: 434
		private const string icoRemovableKO = "removKO32";

		// Token: 0x040001B3 RID: 435
		private ListView driveListView;

		// Token: 0x040001B4 RID: 436
		private DriveInfo[] allDrives;

		// Token: 0x040001B5 RID: 437
		private List<bool> driveStatusList;

		// Token: 0x040001B6 RID: 438
		private List<string> driveNameList;

		// Token: 0x040001B7 RID: 439
		private List<int> driveSizeList;

		// Token: 0x040001B8 RID: 440
		private int selectedItem;

		// Token: 0x040001B9 RID: 441
		private string driveSelected;

		// Token: 0x040001BA RID: 442
		private long sizeNeeded;

		// Token: 0x040001BB RID: 443
		private DriveList.driveChanged del;

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060002CC RID: 716
		public delegate void driveChanged();
	}
}
