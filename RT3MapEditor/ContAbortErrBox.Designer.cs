namespace RT3MapEditor
{
	// Token: 0x0200001F RID: 31
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ContAbortErrBox : global::System.Windows.Forms.Form
	{
		// Token: 0x060002AD RID: 685 RVA: 0x001446C4 File Offset: 0x001436C4
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00144714 File Offset: 0x00143714
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.ContAbortErrBox));
			this.TableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.IgnoreAllButton = new global::System.Windows.Forms.Button();
			this.IgnoreButton = new global::System.Windows.Forms.Button();
			this.AbortButton = new global::System.Windows.Forms.Button();
			this.errText = new global::System.Windows.Forms.Label();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.TableLayoutPanel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.TableLayoutPanel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.IgnoreAllButton, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.IgnoreButton, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.AbortButton, 3, 0);
			global::System.Windows.Forms.Control tableLayoutPanel = this.TableLayoutPanel2;
			global::System.Drawing.Point location = new global::System.Drawing.Point(216, 165);
			tableLayoutPanel.Location = location;
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			global::System.Windows.Forms.Control tableLayoutPanel2 = this.TableLayoutPanel2;
			global::System.Drawing.Size size = new global::System.Drawing.Size(244, 29);
			tableLayoutPanel2.Size = size;
			this.TableLayoutPanel2.TabIndex = 1;
			this.IgnoreAllButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			global::System.Windows.Forms.Control ignoreAllButton = this.IgnoreAllButton;
			location = new global::System.Drawing.Point(84, 3);
			ignoreAllButton.Location = location;
			this.IgnoreAllButton.Name = "IgnoreAllButton";
			global::System.Windows.Forms.Control ignoreAllButton2 = this.IgnoreAllButton;
			size = new global::System.Drawing.Size(75, 23);
			ignoreAllButton2.Size = size;
			this.IgnoreAllButton.TabIndex = 1;
			this.IgnoreAllButton.Tag = "";
			this.IgnoreAllButton.Text = "Ignore all";
			this.IgnoreButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			global::System.Windows.Forms.Control ignoreButton = this.IgnoreButton;
			location = new global::System.Drawing.Point(3, 3);
			ignoreButton.Location = location;
			this.IgnoreButton.Name = "IgnoreButton";
			global::System.Windows.Forms.Control ignoreButton2 = this.IgnoreButton;
			size = new global::System.Drawing.Size(75, 23);
			ignoreButton2.Size = size;
			this.IgnoreButton.TabIndex = 0;
			this.IgnoreButton.Tag = "";
			this.IgnoreButton.Text = "Ignore";
			this.AbortButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			global::System.Windows.Forms.Control abortButton = this.AbortButton;
			location = new global::System.Drawing.Point(165, 3);
			abortButton.Location = location;
			this.AbortButton.Name = "AbortButton";
			global::System.Windows.Forms.Control abortButton2 = this.AbortButton;
			size = new global::System.Drawing.Size(75, 23);
			abortButton2.Size = size;
			this.AbortButton.TabIndex = 2;
			this.AbortButton.Tag = "";
			this.AbortButton.Text = "Abort";
			this.errText.AutoSize = true;
			this.errText.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			global::System.Windows.Forms.Control errText = this.errText;
			location = new global::System.Drawing.Point(70, 12);
			errText.Location = location;
			global::System.Windows.Forms.Control errText2 = this.errText;
			size = new global::System.Drawing.Size(500, 0);
			errText2.MaximumSize = size;
			this.errText.Name = "errText";
			global::System.Windows.Forms.Control errText3 = this.errText;
			size = new global::System.Drawing.Size(0, 13);
			errText3.Size = size;
			this.errText.TabIndex = 6;
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			location = new global::System.Drawing.Point(12, 12);
			pictureBox.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			size = new global::System.Drawing.Size(32, 32);
			pictureBox2.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 5;
			this.PictureBox1.TabStop = false;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(472, 206);
			this.ClientSize = size;
			this.Controls.Add(this.errText);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.TableLayoutPanel2);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ContAbortErrBox";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Error";
			this.TableLayoutPanel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040001A8 RID: 424
		private global::System.ComponentModel.IContainer components;
	}
}
