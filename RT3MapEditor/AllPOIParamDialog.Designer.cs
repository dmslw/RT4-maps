namespace RT3MapEditor
{
	// Token: 0x0200001C RID: 28
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class AllPOIParamDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000277 RID: 631 RVA: 0x001433BC File Offset: 0x001423BC
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

		// Token: 0x06000278 RID: 632 RVA: 0x0014340C File Offset: 0x0014240C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.AllPOIParamDialog));
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new global::System.Windows.Forms.Button();
			this.Cancel_Button = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.LatMaskedTextBox = new global::System.Windows.Forms.MaskedTextBox();
			this.LonMaskedTextBox = new global::System.Windows.Forms.MaskedTextBox();
			this.EWspaMaskedTextBox = new global::System.Windows.Forms.MaskedTextBox();
			this.NSspaMaskedTextBox = new global::System.Windows.Forms.MaskedTextBox();
			this.POIplNumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.TableLayoutPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POIplNumericUpDown).BeginInit();
			this.SuspendLayout();
			this.TableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			global::System.Windows.Forms.Control tableLayoutPanel = this.TableLayoutPanel1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(127, 185);
			tableLayoutPanel.Location = location;
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			global::System.Windows.Forms.Control tableLayoutPanel2 = this.TableLayoutPanel1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(146, 29);
			tableLayoutPanel2.Size = size;
			this.TableLayoutPanel1.TabIndex = 0;
			this.OK_Button.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			global::System.Windows.Forms.Control ok_Button = this.OK_Button;
			location = new global::System.Drawing.Point(3, 3);
			ok_Button.Location = location;
			this.OK_Button.Name = "OK_Button";
			global::System.Windows.Forms.Control ok_Button2 = this.OK_Button;
			size = new global::System.Drawing.Size(67, 23);
			ok_Button2.Size = size;
			this.OK_Button.TabIndex = 0;
			this.OK_Button.Text = "OK";
			this.Cancel_Button.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.Cancel_Button.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			global::System.Windows.Forms.Control cancel_Button = this.Cancel_Button;
			location = new global::System.Drawing.Point(76, 3);
			cancel_Button.Location = location;
			this.Cancel_Button.Name = "Cancel_Button";
			global::System.Windows.Forms.Control cancel_Button2 = this.Cancel_Button;
			size = new global::System.Drawing.Size(67, 23);
			cancel_Button2.Size = size;
			this.Cancel_Button.TabIndex = 1;
			this.Cancel_Button.Text = "Cancel";
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(13, 24);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(126, 13);
			label2.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Latitude (decimal degree)";
			this.Label2.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.Label2;
			location = new global::System.Drawing.Point(13, 51);
			label3.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(135, 13);
			label4.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Longitude (decimal degree)";
			this.Label3.AutoSize = true;
			global::System.Windows.Forms.Control label5 = this.Label3;
			location = new global::System.Drawing.Point(13, 78);
			label5.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label6 = this.Label3;
			size = new global::System.Drawing.Size(85, 13);
			label6.Size = size;
			this.Label3.TabIndex = 3;
			this.Label3.Text = "E-W spacing (m)";
			this.Label4.AutoSize = true;
			global::System.Windows.Forms.Control label7 = this.Label4;
			location = new global::System.Drawing.Point(13, 105);
			label7.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label8 = this.Label4;
			size = new global::System.Drawing.Size(82, 13);
			label8.Size = size;
			this.Label4.TabIndex = 4;
			this.Label4.Text = "N-S spacing (m)";
			this.Label5.AutoSize = true;
			global::System.Windows.Forms.Control label9 = this.Label5;
			location = new global::System.Drawing.Point(13, 132);
			label9.Location = location;
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control label10 = this.Label5;
			size = new global::System.Drawing.Size(62, 13);
			label10.Size = size;
			this.Label5.TabIndex = 5;
			this.Label5.Text = "POI per line";
			global::System.Windows.Forms.Control latMaskedTextBox = this.LatMaskedTextBox;
			location = new global::System.Drawing.Point(173, 20);
			latMaskedTextBox.Location = location;
			this.LatMaskedTextBox.Name = "LatMaskedTextBox";
			global::System.Windows.Forms.Control latMaskedTextBox2 = this.LatMaskedTextBox;
			size = new global::System.Drawing.Size(100, 20);
			latMaskedTextBox2.Size = size;
			this.LatMaskedTextBox.TabIndex = 6;
			global::System.Windows.Forms.Control lonMaskedTextBox = this.LonMaskedTextBox;
			location = new global::System.Drawing.Point(173, 47);
			lonMaskedTextBox.Location = location;
			this.LonMaskedTextBox.Name = "LonMaskedTextBox";
			global::System.Windows.Forms.Control lonMaskedTextBox2 = this.LonMaskedTextBox;
			size = new global::System.Drawing.Size(100, 20);
			lonMaskedTextBox2.Size = size;
			this.LonMaskedTextBox.TabIndex = 7;
			global::System.Windows.Forms.Control ewspaMaskedTextBox = this.EWspaMaskedTextBox;
			location = new global::System.Drawing.Point(173, 74);
			ewspaMaskedTextBox.Location = location;
			this.EWspaMaskedTextBox.Name = "EWspaMaskedTextBox";
			global::System.Windows.Forms.Control ewspaMaskedTextBox2 = this.EWspaMaskedTextBox;
			size = new global::System.Drawing.Size(100, 20);
			ewspaMaskedTextBox2.Size = size;
			this.EWspaMaskedTextBox.TabIndex = 8;
			global::System.Windows.Forms.Control nsspaMaskedTextBox = this.NSspaMaskedTextBox;
			location = new global::System.Drawing.Point(173, 101);
			nsspaMaskedTextBox.Location = location;
			this.NSspaMaskedTextBox.Name = "NSspaMaskedTextBox";
			global::System.Windows.Forms.Control nsspaMaskedTextBox2 = this.NSspaMaskedTextBox;
			size = new global::System.Drawing.Size(100, 20);
			nsspaMaskedTextBox2.Size = size;
			this.NSspaMaskedTextBox.TabIndex = 9;
			global::System.Windows.Forms.Control poiplNumericUpDown = this.POIplNumericUpDown;
			location = new global::System.Drawing.Point(231, 128);
			poiplNumericUpDown.Location = location;
			global::System.Windows.Forms.NumericUpDown poiplNumericUpDown2 = this.POIplNumericUpDown;
			decimal num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			poiplNumericUpDown2.Minimum = num;
			this.POIplNumericUpDown.Name = "POIplNumericUpDown";
			global::System.Windows.Forms.Control poiplNumericUpDown3 = this.POIplNumericUpDown;
			size = new global::System.Drawing.Size(42, 20);
			poiplNumericUpDown3.Size = size;
			this.POIplNumericUpDown.TabIndex = 10;
			global::System.Windows.Forms.NumericUpDown poiplNumericUpDown4 = this.POIplNumericUpDown;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			poiplNumericUpDown4.Value = num;
			this.AcceptButton = this.OK_Button;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_Button;
			size = new global::System.Drawing.Size(291, 226);
			this.ClientSize = size;
			this.Controls.Add(this.POIplNumericUpDown);
			this.Controls.Add(this.NSspaMaskedTextBox);
			this.Controls.Add(this.EWspaMaskedTextBox);
			this.Controls.Add(this.LonMaskedTextBox);
			this.Controls.Add(this.LatMaskedTextBox);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TableLayoutPanel1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AllPOIParamDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Enter parameters of POI to create";
			this.TableLayoutPanel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.POIplNumericUpDown).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000189 RID: 393
		private global::System.ComponentModel.IContainer components;
	}
}
