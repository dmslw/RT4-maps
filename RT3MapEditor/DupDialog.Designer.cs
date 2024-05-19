namespace RT3MapEditor
{
	// Token: 0x0200003C RID: 60
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class DupDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x060006CC RID: 1740 RVA: 0x0015ABA8 File Offset: 0x00159BA8
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

		// Token: 0x060006CD RID: 1741 RVA: 0x0015ABF8 File Offset: 0x00159BF8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RT3MapEditor.DupDialog));
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.Find_Button = new global::System.Windows.Forms.Button();
			this.Remove_Button = new global::System.Windows.Forms.Button();
			this.Close_Button = new global::System.Windows.Forms.Button();
			this.ListNbLabel = new global::System.Windows.Forms.Label();
			this.choiceLists_ListBox = new global::System.Windows.Forms.ListBox();
			this.Dist_NumericUpDown = new global::System.Windows.Forms.NumericUpDown();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Brand_ComboBox = new global::System.Windows.Forms.ComboBox();
			this.ToolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.curList_Label = new global::System.Windows.Forms.Label();
			this.NbDup_Label = new global::System.Windows.Forms.Label();
			this.TableLayoutPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Dist_NumericUpDown).BeginInit();
			this.SuspendLayout();
			componentResourceManager.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
			this.TableLayoutPanel1.Controls.Add(this.Find_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Remove_Button, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Close_Button, 2, 0);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			componentResourceManager.ApplyResources(this.Find_Button, "Find_Button");
			this.Find_Button.Name = "Find_Button";
			this.ToolTip1.SetToolTip(this.Find_Button, componentResourceManager.GetString("Find_Button.ToolTip"));
			this.Find_Button.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.Remove_Button, "Remove_Button");
			this.Remove_Button.Name = "Remove_Button";
			this.ToolTip1.SetToolTip(this.Remove_Button, componentResourceManager.GetString("Remove_Button.ToolTip"));
			this.Remove_Button.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.Close_Button, "Close_Button");
			this.Close_Button.Name = "Close_Button";
			this.ToolTip1.SetToolTip(this.Close_Button, componentResourceManager.GetString("Close_Button.ToolTip"));
			componentResourceManager.ApplyResources(this.ListNbLabel, "ListNbLabel");
			this.ListNbLabel.Name = "ListNbLabel";
			this.choiceLists_ListBox.FormattingEnabled = true;
			componentResourceManager.ApplyResources(this.choiceLists_ListBox, "choiceLists_ListBox");
			this.choiceLists_ListBox.Name = "choiceLists_ListBox";
			this.choiceLists_ListBox.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiExtended;
			componentResourceManager.ApplyResources(this.Dist_NumericUpDown, "Dist_NumericUpDown");
			global::System.Windows.Forms.NumericUpDown dist_NumericUpDown = this.Dist_NumericUpDown;
			decimal num = new decimal(new int[]
			{
				499,
				0,
				0,
				0
			});
			dist_NumericUpDown.Maximum = num;
			this.Dist_NumericUpDown.Name = "Dist_NumericUpDown";
			global::System.Windows.Forms.NumericUpDown dist_NumericUpDown2 = this.Dist_NumericUpDown;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			dist_NumericUpDown2.Value = num;
			componentResourceManager.ApplyResources(this.Label3, "Label3");
			this.Label3.Name = "Label3";
			componentResourceManager.ApplyResources(this.Label4, "Label4");
			this.Label4.Name = "Label4";
			componentResourceManager.ApplyResources(this.Label5, "Label5");
			this.Label5.Name = "Label5";
			this.Brand_ComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Brand_ComboBox.FormattingEnabled = true;
			componentResourceManager.ApplyResources(this.Brand_ComboBox, "Brand_ComboBox");
			this.Brand_ComboBox.Name = "Brand_ComboBox";
			this.Brand_ComboBox.Sorted = true;
			componentResourceManager.ApplyResources(this.curList_Label, "curList_Label");
			this.curList_Label.Name = "curList_Label";
			componentResourceManager.ApplyResources(this.NbDup_Label, "NbDup_Label");
			this.NbDup_Label.Name = "NbDup_Label";
			this.AcceptButton = this.Close_Button;
			componentResourceManager.ApplyResources(this, "$this");
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.NbDup_Label);
			this.Controls.Add(this.curList_Label);
			this.Controls.Add(this.Brand_ComboBox);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Dist_NumericUpDown);
			this.Controls.Add(this.choiceLists_ListBox);
			this.Controls.Add(this.ListNbLabel);
			this.Controls.Add(this.TableLayoutPanel1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DupDialog";
			this.ShowInTaskbar = false;
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.Dist_NumericUpDown).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040003D6 RID: 982
		private global::System.ComponentModel.IContainer components;
	}
}
