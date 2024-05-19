using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My.Resources;

namespace RT3MapEditor
{
	// Token: 0x02000013 RID: 19
	[DesignerGenerated]
	public partial class BootScreenFramingDialog : Form
	{
		// Token: 0x06000216 RID: 534 RVA: 0x0014142C File Offset: 0x0014042C
		public BootScreenFramingDialog()
		{
			base.Shown += this.DialogShown;
			ArrayList _ENCList = BootScreenFramingDialog.__ENCList;
			lock (_ENCList)
			{
				BootScreenFramingDialog.__ENCList.Add(new WeakReference(this));
			}
			this.DECAL_HORIZ = 5;
			this.DECAL_VERT = 5;
			this.zoomFactor = 1.0;
			this.oldZoomFactor = 1.0;
			this.InitializeComponent();
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000219 RID: 537 RVA: 0x001419B8 File Offset: 0x001409B8
		// (set) Token: 0x0600021A RID: 538 RVA: 0x001419D0 File Offset: 0x001409D0
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TableLayoutPanel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TableLayoutPanel1 = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600021B RID: 539 RVA: 0x001419DC File Offset: 0x001409DC
		// (set) Token: 0x0600021C RID: 540 RVA: 0x001419F4 File Offset: 0x001409F4
		internal virtual Button OK_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OK_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._OK_Button != null;
				if (flag)
				{
					this._OK_Button.Click -= this.OK_Button_Click;
				}
				this._OK_Button = value;
				flag = (this._OK_Button != null);
				if (flag)
				{
					this._OK_Button.Click += this.OK_Button_Click;
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00141A60 File Offset: 0x00140A60
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00141A78 File Offset: 0x00140A78
		internal virtual Button Cancel_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Cancel_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Cancel_Button != null;
				if (flag)
				{
					this._Cancel_Button.Click -= this.Cancel_Button_Click;
				}
				this._Cancel_Button = value;
				flag = (this._Cancel_Button != null);
				if (flag)
				{
					this._Cancel_Button.Click += this.Cancel_Button_Click;
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00141AE4 File Offset: 0x00140AE4
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00141AFC File Offset: 0x00140AFC
		internal virtual PictureBox PictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._PictureBox != null;
				if (flag)
				{
					this._PictureBox.MouseMove -= this.PictureBox_MouseMove;
					this._PictureBox.MouseLeave -= this.PictureBox_MouseLeave;
					this._PictureBox.MouseEnter -= this.PictureBox_MouseEnter;
					this._PictureBox.MouseUp -= this.PictureBox_MouseUp;
					this._PictureBox.MouseDown -= this.PictureBox_MouseDown;
				}
				this._PictureBox = value;
				flag = (this._PictureBox != null);
				if (flag)
				{
					this._PictureBox.MouseMove += this.PictureBox_MouseMove;
					this._PictureBox.MouseLeave += this.PictureBox_MouseLeave;
					this._PictureBox.MouseEnter += this.PictureBox_MouseEnter;
					this._PictureBox.MouseUp += this.PictureBox_MouseUp;
					this._PictureBox.MouseDown += this.PictureBox_MouseDown;
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00141C30 File Offset: 0x00140C30
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00141C48 File Offset: 0x00140C48
		internal virtual Button Stretch_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Stretch_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Stretch_Button != null;
				if (flag)
				{
					this._Stretch_Button.Click -= this.Stretch_Button_Click;
				}
				this._Stretch_Button = value;
				flag = (this._Stretch_Button != null);
				if (flag)
				{
					this._Stretch_Button.Click += this.Stretch_Button_Click;
				}
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00141CB4 File Offset: 0x00140CB4
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00141CCC File Offset: 0x00140CCC
		internal virtual Button Center_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Center_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Center_Button != null;
				if (flag)
				{
					this._Center_Button.Click -= this.Center_Button_Click;
				}
				this._Center_Button = value;
				flag = (this._Center_Button != null);
				if (flag)
				{
					this._Center_Button.Click += this.Center_Button_Click;
				}
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00141D38 File Offset: 0x00140D38
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00141D50 File Offset: 0x00140D50
		internal virtual Button Crop_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Crop_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Crop_Button != null;
				if (flag)
				{
					this._Crop_Button.Click -= this.Crop_Button_Click;
				}
				this._Crop_Button = value;
				flag = (this._Crop_Button != null);
				if (flag)
				{
					this._Crop_Button.Click += this.Crop_Button_Click;
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00141DBC File Offset: 0x00140DBC
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00141DD4 File Offset: 0x00140DD4
		internal virtual Label Label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00141DE0 File Offset: 0x00140DE0
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00141DF8 File Offset: 0x00140DF8
		internal virtual Button bkgColor_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._bkgColor_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._bkgColor_Button != null;
				if (flag)
				{
					this._bkgColor_Button.Click -= this.bkgColor_Click;
				}
				this._bkgColor_Button = value;
				flag = (this._bkgColor_Button != null);
				if (flag)
				{
					this._bkgColor_Button.Click += this.bkgColor_Click;
				}
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00141E64 File Offset: 0x00140E64
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00141E7C File Offset: 0x00140E7C
		internal virtual TrackBar Zoom_TrackBar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Zoom_TrackBar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._Zoom_TrackBar != null;
				if (flag)
				{
					this._Zoom_TrackBar.ValueChanged -= this.Zoom_TrackBar_Scroll;
				}
				this._Zoom_TrackBar = value;
				flag = (this._Zoom_TrackBar != null);
				if (flag)
				{
					this._Zoom_TrackBar.ValueChanged += this.Zoom_TrackBar_Scroll;
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00141EE8 File Offset: 0x00140EE8
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00141F00 File Offset: 0x00140F00
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00141F0C File Offset: 0x00140F0C
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00141F24 File Offset: 0x00140F24
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00141F30 File Offset: 0x00140F30
		public DialogResult ShowDialog(ref Bitmap bootScreen)
		{
			this.initBootScreen = bootScreen;
			this.finalBootScreen = null;
			this.stretchedBitmap = null;
			this.centeredBitmap = null;
			this.bkgColor = Color.Black;
			this.croppedBitmap = null;
			this.bitmapToCrop = null;
			this.beginFramingPoint = default(Point);
			this.imageRatio = (double)this.initBootScreen.Width / (double)this.initBootScreen.Height;
			this.hPCRatio = (double)this.initBootScreen.Width / (double)RTxScreen.RTx_SCREEN_WIDTH;
			this.vPCRatio = (double)this.initBootScreen.Height / (double)RTxScreen.RTx_SCREEN_HEIGHT;
			this.maxZoomFactor = Math.Min(this.hPCRatio, this.vPCRatio);
			bool flag = this.maxZoomFactor < 1.0;
			if (flag)
			{
				this.maxZoomFactor = 1.0;
			}
			this.zoomFactor = 1.0;
			this.oldZoomFactor = 1.0;
			this.Zoom_TrackBar.Minimum = 100;
			this.Zoom_TrackBar.Maximum = checked((int)Math.Round(unchecked(this.maxZoomFactor * 100.0)));
			this.Zoom_TrackBar.Value = 100;
			this.horizDecal = 0.0;
			this.vertDecal = 0.0;
			this.mode = BootScreenFramingDialog.modes.framed;
			this.framingInProgress = false;
			DialogResult dialogResult = base.ShowDialog();
			flag = (dialogResult == DialogResult.OK);
			if (flag)
			{
				bootScreen = this.finalBootScreen;
			}
			flag = (this.gCropped != null);
			if (flag)
			{
				this.gCropped.Dispose();
			}
			flag = (this.gCentered != null);
			if (flag)
			{
				this.gCentered.Dispose();
			}
			return dialogResult;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x001420E8 File Offset: 0x001410E8
		private void DialogShown(object sender, EventArgs e)
		{
			this.firstCrop();
		}

		// Token: 0x06000233 RID: 563 RVA: 0x001420F4 File Offset: 0x001410F4
		private void Stretch_Button_Click(object sender, EventArgs e)
		{
			bool flag = this.stretchedBitmap == null;
			if (flag)
			{
				this.stretchedBitmap = new Bitmap(RTxScreen.RTx_SCREEN_WIDTH, RTxScreen.RTx_SCREEN_HEIGHT);
				Graphics graphics = Graphics.FromImage(this.stretchedBitmap);
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.DrawImage(this.initBootScreen, 0, 0, RTxScreen.RTx_SCREEN_WIDTH, RTxScreen.RTx_SCREEN_HEIGHT);
				graphics.Dispose();
			}
			this.PictureBox.Image = this.stretchedBitmap;
			this.finalBootScreen = this.stretchedBitmap;
			this.bkgColor_Button.Enabled = false;
			this.Zoom_TrackBar.Enabled = false;
			this.mode = BootScreenFramingDialog.modes.stretched;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0014219C File Offset: 0x0014119C
		private void Center_Button_Click(object sender, EventArgs e)
		{
			bool flag = this.centeredBitmap == null;
			checked
			{
				if (flag)
				{
					bool flag2 = this.imageRatio > RTxScreen.RTx_SCREEN_RATIO;
					int num;
					int num2;
					int num3;
					int num4;
					if (flag2)
					{
						num = RTxScreen.RTx_SCREEN_WIDTH;
						num2 = Math.Min((int)Math.Round(Conversion.Fix((double)this.initBootScreen.Height / this.hPCRatio / RTxScreen.RTx_PIXEL_RATIO)), RTxScreen.RTx_SCREEN_HEIGHT);
						num3 = 0;
						num4 = (int)Math.Round((double)(RTxScreen.RTx_SCREEN_HEIGHT - num2) / 2.0);
						this.bkgRectangle1 = new Rectangle(0, 0, RTxScreen.RTx_SCREEN_WIDTH, num4);
						this.bkgRectangle2 = new Rectangle(0, num4 + num2, RTxScreen.RTx_SCREEN_WIDTH, num4);
					}
					else
					{
						num = Math.Min((int)Math.Round(Conversion.Fix(unchecked((double)this.initBootScreen.Width / this.vPCRatio * RTxScreen.RTx_PIXEL_RATIO))), RTxScreen.RTx_SCREEN_WIDTH);
						num2 = RTxScreen.RTx_SCREEN_HEIGHT;
						num3 = (int)Math.Round((double)(RTxScreen.RTx_SCREEN_WIDTH - num) / 2.0);
						num4 = 0;
						this.bkgRectangle1 = new Rectangle(0, 0, num3, RTxScreen.RTx_SCREEN_HEIGHT);
						this.bkgRectangle2 = new Rectangle(num3 + num, 0, num3, RTxScreen.RTx_SCREEN_HEIGHT);
					}
					this.centeredBitmap = new Bitmap(RTxScreen.RTx_SCREEN_WIDTH, RTxScreen.RTx_SCREEN_HEIGHT);
					this.gCentered = Graphics.FromImage(this.centeredBitmap);
					this.gCentered.InterpolationMode = InterpolationMode.HighQualityBicubic;
					this.gCentered.DrawImage(this.initBootScreen, num3, num4, num, num2);
					this.bkgBrush = new SolidBrush(this.bkgColor);
					this.gCentered.FillRectangle(this.bkgBrush, this.bkgRectangle1);
					this.gCentered.FillRectangle(this.bkgBrush, this.bkgRectangle2);
				}
				this.PictureBox.Image = this.centeredBitmap;
				this.finalBootScreen = this.centeredBitmap;
				this.bkgColor_Button.Enabled = true;
				this.Zoom_TrackBar.Enabled = false;
				this.mode = BootScreenFramingDialog.modes.centered;
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00142394 File Offset: 0x00141394
		private void bkgColor_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			bool flag = colorDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.bkgColor = colorDialog.Color;
				this.bkgBrush.Color = this.bkgColor;
				this.gCentered.FillRectangle(this.bkgBrush, this.bkgRectangle1);
				this.gCentered.FillRectangle(this.bkgBrush, this.bkgRectangle2);
				this.Refresh();
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0014240C File Offset: 0x0014140C
		private void Crop_Button_Click(object sender, EventArgs e)
		{
			this.horizDecal = 0.0;
			this.vertDecal = 0.0;
			this.zoomFactor = 1.0;
			this.oldZoomFactor = 1.0;
			this.Zoom_TrackBar.Value = 100;
			this.firstCrop();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0014246C File Offset: 0x0014146C
		private void firstCrop()
		{
			bool flag = this.imageRatio > RTxScreen.RTx_SCREEN_RATIO;
			checked
			{
				if (flag)
				{
					this.bm2CropWidth = (int)Math.Round(Conversion.Fix(unchecked((double)this.initBootScreen.Width / this.vPCRatio * RTxScreen.RTx_PIXEL_RATIO * this.zoomFactor)));
					this.bm2CropHeight = (int)Math.Round(Conversion.Fix(unchecked((double)RTxScreen.RTx_SCREEN_HEIGHT * this.zoomFactor)));
					this.srcRect = new Rectangle((int)Math.Round((double)(this.bm2CropWidth - RTxScreen.RTx_SCREEN_WIDTH) / 2.0), (int)Math.Round((double)(this.bm2CropHeight - RTxScreen.RTx_SCREEN_HEIGHT) / 2.0), RTxScreen.RTx_SCREEN_WIDTH, RTxScreen.RTx_SCREEN_HEIGHT);
					this.MaxHorizDecal = (double)((int)Math.Round(Conversion.Fix((double)(this.bm2CropWidth - RTxScreen.RTx_SCREEN_WIDTH) / 2.0)));
					this.MaxVertDecal = (double)((int)Math.Round(Conversion.Fix((double)(this.bm2CropHeight - RTxScreen.RTx_SCREEN_HEIGHT) / 2.0)));
				}
				else
				{
					this.bm2CropWidth = (int)Math.Round(Conversion.Fix(unchecked((double)RTxScreen.RTx_SCREEN_WIDTH * this.zoomFactor)));
					this.bm2CropHeight = (int)Math.Round(Conversion.Fix(unchecked((double)this.initBootScreen.Height / this.hPCRatio / RTxScreen.RTx_PIXEL_RATIO * this.zoomFactor)));
					this.srcRect = new Rectangle((int)Math.Round((double)(this.bm2CropWidth - RTxScreen.RTx_SCREEN_WIDTH) / 2.0), (int)Math.Round((double)(this.bm2CropHeight - RTxScreen.RTx_SCREEN_HEIGHT) / 2.0), RTxScreen.RTx_SCREEN_WIDTH, RTxScreen.RTx_SCREEN_HEIGHT);
					this.MaxVertDecal = (double)((int)Math.Round(Conversion.Fix((double)(this.bm2CropHeight - RTxScreen.RTx_SCREEN_HEIGHT) / 2.0)));
					this.MaxHorizDecal = (double)((int)Math.Round(Conversion.Fix((double)(this.bm2CropWidth - RTxScreen.RTx_SCREEN_WIDTH) / 2.0)));
				}
				flag = (this.zoomFactor != this.oldZoomFactor);
			}
			if (flag)
			{
				try
				{
					this.horizDecal = (double)(checked((int)Math.Round(unchecked(this.horizDecal * ((double)this.bm2CropWidth / (double)this.oldBm2CropWidth)))));
				}
				catch (Exception ex)
				{
					this.horizDecal = 0.0;
				}
				flag = (this.horizDecal > 0.0 && this.horizDecal > this.MaxHorizDecal);
				if (flag)
				{
					this.horizDecal = this.MaxHorizDecal;
				}
				else
				{
					flag = (this.horizDecal < 0.0 && this.horizDecal < -this.MaxHorizDecal);
					if (flag)
					{
						this.horizDecal = -this.MaxHorizDecal;
					}
				}
				try
				{
					this.vertDecal = (double)(checked((int)Math.Round(unchecked(this.vertDecal * ((double)this.bm2CropHeight / (double)this.oldBm2CropHeight)))));
				}
				catch (Exception ex2)
				{
					this.vertDecal = 0.0;
				}
				flag = (this.vertDecal > 0.0 && this.vertDecal > this.MaxVertDecal);
				if (flag)
				{
					this.vertDecal = this.MaxVertDecal;
				}
				else
				{
					flag = (this.vertDecal < 0.0 && this.vertDecal < -this.MaxVertDecal);
					if (flag)
					{
						this.vertDecal = -this.MaxVertDecal;
					}
				}
			}
			this.bitmapToCrop = new Bitmap(this.bm2CropWidth, this.bm2CropHeight);
			this.gToCrop = Graphics.FromImage(this.bitmapToCrop);
			this.gToCrop.InterpolationMode = InterpolationMode.HighQualityBicubic;
			this.gToCrop.DrawImage(this.initBootScreen, 0, 0, this.bm2CropWidth, this.bm2CropHeight);
			this.gToCrop.Dispose();
			this.croppedBitmap = new Bitmap(RTxScreen.RTx_SCREEN_WIDTH, RTxScreen.RTx_SCREEN_HEIGHT);
			flag = (this.gCropped != null);
			if (flag)
			{
				this.gCropped.Dispose();
			}
			this.gCropped = Graphics.FromImage(this.croppedBitmap);
			this.gCropped.InterpolationMode = InterpolationMode.HighQualityBicubic;
			this.cropAndShift();
			this.PictureBox.Image = this.croppedBitmap;
			this.finalBootScreen = this.croppedBitmap;
			this.bkgColor_Button.Enabled = false;
			this.Zoom_TrackBar.Enabled = true;
			this.mode = BootScreenFramingDialog.modes.framed;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00142904 File Offset: 0x00141904
		private void cropAndShift()
		{
			Pen pen = new Pen(Color.White);
			Rectangle rectangle = checked(new Rectangle(this.srcRect.X + (int)Math.Round(this.horizDecal), this.srcRect.Y + (int)Math.Round(this.vertDecal), this.srcRect.Width, this.srcRect.Height));
			this.gCropped.DrawImage(this.bitmapToCrop, RTxScreen.RTxScreenRectangle, rectangle, GraphicsUnit.Pixel);
			this.PictureBox.Image = this.croppedBitmap;
			this.finalBootScreen = this.croppedBitmap;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x001429A4 File Offset: 0x001419A4
		private void PictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this.mode == BootScreenFramingDialog.modes.framed;
			checked
			{
				if (flag)
				{
					this.beginFramingPoint = e.Location;
					this.BeginXDecal = (int)Math.Round(this.horizDecal);
					this.BeginYDecal = (int)Math.Round(this.vertDecal);
					this.framingInProgress = true;
				}
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x001429F8 File Offset: 0x001419F8
		private void PictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.mode == BootScreenFramingDialog.modes.framed;
			if (flag)
			{
				this.framingInProgress = false;
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00142A1C File Offset: 0x00141A1C
		private void PictureBox_MouseEnter(object sender, EventArgs e)
		{
			this.oldCursor = this.Cursor;
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00142A38 File Offset: 0x00141A38
		private void PictureBox_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = this.oldCursor;
			this.framingInProgress = false;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00142A50 File Offset: 0x00141A50
		private void PictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.framingInProgress;
			if (flag)
			{
				this.horizDecal = (double)(checked(this.BeginXDecal + this.beginFramingPoint.X - e.X));
				flag = (this.horizDecal > 0.0 && this.horizDecal > this.MaxHorizDecal);
				if (flag)
				{
					this.horizDecal = this.MaxHorizDecal;
				}
				else
				{
					flag = (this.horizDecal < 0.0 && this.horizDecal < -this.MaxHorizDecal);
					if (flag)
					{
						this.horizDecal = -this.MaxHorizDecal;
					}
				}
				this.vertDecal = (double)(checked(this.BeginYDecal + this.beginFramingPoint.Y - e.Y));
				flag = (this.vertDecal > 0.0 && this.vertDecal > this.MaxVertDecal);
				if (flag)
				{
					this.vertDecal = this.MaxVertDecal;
				}
				else
				{
					flag = (this.vertDecal < 0.0 && this.vertDecal < -this.MaxVertDecal);
					if (flag)
					{
						this.vertDecal = -this.MaxVertDecal;
					}
				}
				this.cropAndShift();
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00142B8C File Offset: 0x00141B8C
		private void Zoom_TrackBar_Scroll(object sender, EventArgs e)
		{
			this.oldZoomFactor = this.zoomFactor;
			this.oldBm2CropWidth = this.bm2CropWidth;
			this.oldBm2CropHeight = this.bm2CropHeight;
			this.zoomFactor = Math.Min((double)((float)this.Zoom_TrackBar.Value / 100f), this.maxZoomFactor);
			this.firstCrop();
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00142BEC File Offset: 0x00141BEC
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00142C00 File Offset: 0x00141C00
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x04000136 RID: 310
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x04000138 RID: 312
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x04000139 RID: 313
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x0400013A RID: 314
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x0400013B RID: 315
		[AccessedThroughProperty("PictureBox")]
		private PictureBox _PictureBox;

		// Token: 0x0400013C RID: 316
		[AccessedThroughProperty("Stretch_Button")]
		private Button _Stretch_Button;

		// Token: 0x0400013D RID: 317
		[AccessedThroughProperty("Center_Button")]
		private Button _Center_Button;

		// Token: 0x0400013E RID: 318
		[AccessedThroughProperty("Crop_Button")]
		private Button _Crop_Button;

		// Token: 0x0400013F RID: 319
		[AccessedThroughProperty("Label")]
		private Label _Label;

		// Token: 0x04000140 RID: 320
		[AccessedThroughProperty("bkgColor_Button")]
		private Button _bkgColor_Button;

		// Token: 0x04000141 RID: 321
		[AccessedThroughProperty("Zoom_TrackBar")]
		private TrackBar _Zoom_TrackBar;

		// Token: 0x04000142 RID: 322
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000143 RID: 323
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000144 RID: 324
		private BootScreenFramingDialog.modes mode;

		// Token: 0x04000145 RID: 325
		private bool framingInProgress;

		// Token: 0x04000146 RID: 326
		private Point beginFramingPoint;

		// Token: 0x04000147 RID: 327
		private int BeginXDecal;

		// Token: 0x04000148 RID: 328
		private int BeginYDecal;

		// Token: 0x04000149 RID: 329
		private int DECAL_HORIZ;

		// Token: 0x0400014A RID: 330
		private int DECAL_VERT;

		// Token: 0x0400014B RID: 331
		private Bitmap initBootScreen;

		// Token: 0x0400014C RID: 332
		private Bitmap finalBootScreen;

		// Token: 0x0400014D RID: 333
		private Bitmap stretchedBitmap;

		// Token: 0x0400014E RID: 334
		private double hPCRatio;

		// Token: 0x0400014F RID: 335
		private double vPCRatio;

		// Token: 0x04000150 RID: 336
		private double imageRatio;

		// Token: 0x04000151 RID: 337
		private Bitmap centeredBitmap;

		// Token: 0x04000152 RID: 338
		private Color bkgColor;

		// Token: 0x04000153 RID: 339
		private Rectangle bkgRectangle1;

		// Token: 0x04000154 RID: 340
		private Rectangle bkgRectangle2;

		// Token: 0x04000155 RID: 341
		private SolidBrush bkgBrush;

		// Token: 0x04000156 RID: 342
		private Graphics gCentered;

		// Token: 0x04000157 RID: 343
		private bool movePict;

		// Token: 0x04000158 RID: 344
		private Bitmap croppedBitmap;

		// Token: 0x04000159 RID: 345
		private Bitmap bitmapToCrop;

		// Token: 0x0400015A RID: 346
		private Graphics gToCrop;

		// Token: 0x0400015B RID: 347
		private Graphics gCropped;

		// Token: 0x0400015C RID: 348
		private Rectangle srcRect;

		// Token: 0x0400015D RID: 349
		private double horizDecal;

		// Token: 0x0400015E RID: 350
		private double vertDecal;

		// Token: 0x0400015F RID: 351
		private double MaxHorizDecal;

		// Token: 0x04000160 RID: 352
		private double MaxVertDecal;

		// Token: 0x04000161 RID: 353
		private double zoomFactor;

		// Token: 0x04000162 RID: 354
		private double oldZoomFactor;

		// Token: 0x04000163 RID: 355
		private double maxZoomFactor;

		// Token: 0x04000164 RID: 356
		private int bm2CropWidth;

		// Token: 0x04000165 RID: 357
		private int bm2CropHeight;

		// Token: 0x04000166 RID: 358
		private int oldBm2CropWidth;

		// Token: 0x04000167 RID: 359
		private int oldBm2CropHeight;

		// Token: 0x04000168 RID: 360
		private Cursor oldCursor;

		// Token: 0x02000014 RID: 20
		private enum modes
		{
			// Token: 0x0400016A RID: 362
			stretched,
			// Token: 0x0400016B RID: 363
			centered,
			// Token: 0x0400016C RID: 364
			framed
		}
	}
}
