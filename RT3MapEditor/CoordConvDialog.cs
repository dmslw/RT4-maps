using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using RT3MapEditor.My;

namespace RT3MapEditor
{
	// Token: 0x02000037 RID: 55
	[DesignerGenerated]
	public partial class CoordConvDialog : Form
	{
		// Token: 0x060005E5 RID: 1509 RVA: 0x001552DC File Offset: 0x001542DC
		public CoordConvDialog()
		{
			ArrayList _ENCList = CoordConvDialog.__ENCList;
			lock (_ENCList)
			{
				CoordConvDialog.__ENCList.Add(new WeakReference(this));
			}
			this.cultForOut = Common.cultENUS;
			this.mapType = Common.RTxMapType.Unknown;
			this.LSColumnNb = 0U;
			this.LSLineNb = 0U;
			this.InitializeComponent();
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00156F94 File Offset: 0x00155F94
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00156FAC File Offset: 0x00155FAC
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

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00156FB8 File Offset: 0x00155FB8
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00156FD0 File Offset: 0x00155FD0
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

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0015703C File Offset: 0x0015603C
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00157054 File Offset: 0x00156054
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

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x001570C0 File Offset: 0x001560C0
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x001570D8 File Offset: 0x001560D8
		internal virtual NumericUpDown LSI_NumericUpDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LSI_NumericUpDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LSI_NumericUpDown = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x001570E4 File Offset: 0x001560E4
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x001570FC File Offset: 0x001560FC
		internal virtual Label LabelLSI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelLSI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelLSI = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00157108 File Offset: 0x00156108
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00157120 File Offset: 0x00156120
		internal virtual Label LabelMSI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelMSI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelMSI = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0015712C File Offset: 0x0015612C
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00157144 File Offset: 0x00156144
		internal virtual NumericUpDown MSI_NumericUpDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MSI_NumericUpDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MSI_NumericUpDown = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00157150 File Offset: 0x00156150
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00157168 File Offset: 0x00156168
		internal virtual Label LabelSSI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelSSI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelSSI = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00157174 File Offset: 0x00156174
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x0015718C File Offset: 0x0015618C
		internal virtual NumericUpDown SSI_NumericUpDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SSI_NumericUpDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SSI_NumericUpDown = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00157198 File Offset: 0x00156198
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x001571B0 File Offset: 0x001561B0
		internal virtual Label LabelXI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelXI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelXI = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x001571BC File Offset: 0x001561BC
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x001571D4 File Offset: 0x001561D4
		internal virtual NumericUpDown XI_NumericUpDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._XI_NumericUpDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._XI_NumericUpDown = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x001571E0 File Offset: 0x001561E0
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x001571F8 File Offset: 0x001561F8
		internal virtual Label LabelYI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelYI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelYI = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00157204 File Offset: 0x00156204
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x0015721C File Offset: 0x0015621C
		internal virtual NumericUpDown YI_NumericUpDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._YI_NumericUpDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._YI_NumericUpDown = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00157228 File Offset: 0x00156228
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x00157240 File Offset: 0x00156240
		internal virtual Button CellCalc_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CellCalc_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._CellCalc_Button != null;
				if (flag)
				{
					this._CellCalc_Button.Click -= this.CellCalc_Button_Click;
				}
				this._CellCalc_Button = value;
				flag = (this._CellCalc_Button != null);
				if (flag)
				{
					this._CellCalc_Button.Click += this.CellCalc_Button_Click;
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x001572AC File Offset: 0x001562AC
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x001572C4 File Offset: 0x001562C4
		internal virtual Label LabelEO
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelEO;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelEO = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x001572D0 File Offset: 0x001562D0
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x001572E8 File Offset: 0x001562E8
		internal virtual TextBox EO_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EO_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EO_TextBox = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x001572F4 File Offset: 0x001562F4
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x0015730C File Offset: 0x0015630C
		internal virtual Label LabelNO
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelNO;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelNO = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00157318 File Offset: 0x00156318
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x00157330 File Offset: 0x00156330
		internal virtual TextBox NO_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NO_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NO_TextBox = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0015733C File Offset: 0x0015633C
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00157354 File Offset: 0x00156354
		internal virtual Label LabelLatO
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelLatO;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelLatO = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00157360 File Offset: 0x00156360
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00157378 File Offset: 0x00156378
		internal virtual TextBox LatO_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LatO_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LatO_TextBox = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00157384 File Offset: 0x00156384
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x0015739C File Offset: 0x0015639C
		internal virtual Label LabelLonO
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelLonO;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelLonO = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x001573A8 File Offset: 0x001563A8
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x001573C0 File Offset: 0x001563C0
		internal virtual TextBox LonO_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LonO_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LonO_TextBox = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x001573CC File Offset: 0x001563CC
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x001573E4 File Offset: 0x001563E4
		internal virtual Label LabelLatI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelLatI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelLatI = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x001573F0 File Offset: 0x001563F0
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00157408 File Offset: 0x00156408
		internal virtual TextBox LatI_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LatI_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LatI_TextBox = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00157414 File Offset: 0x00156414
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x0015742C File Offset: 0x0015642C
		internal virtual Label Label1LonI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1LonI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1LonI = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00157438 File Offset: 0x00156438
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00157450 File Offset: 0x00156450
		internal virtual TextBox LonI_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LonI_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LonI_TextBox = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0015745C File Offset: 0x0015645C
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00157474 File Offset: 0x00156474
		internal virtual Label LabelEI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelEI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelEI = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00157480 File Offset: 0x00156480
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00157498 File Offset: 0x00156498
		internal virtual TextBox EI_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EI_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EI_TextBox = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x001574A4 File Offset: 0x001564A4
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x001574BC File Offset: 0x001564BC
		internal virtual Label LabelNI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelNI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelNI = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x001574C8 File Offset: 0x001564C8
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x001574E0 File Offset: 0x001564E0
		internal virtual TextBox NI_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NI_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NI_TextBox = value;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x001574EC File Offset: 0x001564EC
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x00157504 File Offset: 0x00156504
		internal virtual Label Label14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label14 = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00157510 File Offset: 0x00156510
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x00157528 File Offset: 0x00156528
		internal virtual Button LatLonCalc_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LatLonCalc_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._LatLonCalc_Button != null;
				if (flag)
				{
					this._LatLonCalc_Button.Click -= this.LatLonCalc_Button_Click;
				}
				this._LatLonCalc_Button = value;
				flag = (this._LatLonCalc_Button != null);
				if (flag)
				{
					this._LatLonCalc_Button.Click += this.LatLonCalc_Button_Click;
				}
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00157594 File Offset: 0x00156594
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x001575AC File Offset: 0x001565AC
		internal virtual Button ENCalc_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ENCalc_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				bool flag = this._ENCalc_Button != null;
				if (flag)
				{
					this._ENCalc_Button.Click -= this.ENCalc_Button_Click;
				}
				this._ENCalc_Button = value;
				flag = (this._ENCalc_Button != null);
				if (flag)
				{
					this._ENCalc_Button.Click += this.ENCalc_Button_Click;
				}
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00157618 File Offset: 0x00156618
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00157630 File Offset: 0x00156630
		internal virtual Label Label15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label15 = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0015763C File Offset: 0x0015663C
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00157654 File Offset: 0x00156654
		internal virtual Label LabelLSO
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelLSO;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelLSO = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00157660 File Offset: 0x00156660
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00157678 File Offset: 0x00156678
		internal virtual TextBox LSO_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LSO_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LSO_TextBox = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00157684 File Offset: 0x00156684
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x0015769C File Offset: 0x0015669C
		internal virtual Label LabelMSO
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelMSO;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelMSO = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x001576A8 File Offset: 0x001566A8
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x001576C0 File Offset: 0x001566C0
		internal virtual Label LabelSSO
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelSSO;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelSSO = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x001576CC File Offset: 0x001566CC
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x001576E4 File Offset: 0x001566E4
		internal virtual TextBox MSO_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MSO_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MSO_TextBox = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x001576F0 File Offset: 0x001566F0
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00157708 File Offset: 0x00156708
		internal virtual TextBox SSO_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SSO_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SSO_TextBox = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00157714 File Offset: 0x00156714
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x0015772C File Offset: 0x0015672C
		internal virtual Label LabelXO
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelXO;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelXO = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00157738 File Offset: 0x00156738
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00157750 File Offset: 0x00156750
		internal virtual TextBox XO_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._XO_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._XO_TextBox = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0015775C File Offset: 0x0015675C
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00157774 File Offset: 0x00156774
		internal virtual Label LabelYO
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelYO;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelYO = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00157780 File Offset: 0x00156780
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00157798 File Offset: 0x00156798
		internal virtual TextBox YO_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._YO_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._YO_TextBox = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x001577A4 File Offset: 0x001567A4
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x001577BC File Offset: 0x001567BC
		internal virtual Label LabelCellO
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCellO;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCellO = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x001577C8 File Offset: 0x001567C8
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x001577E0 File Offset: 0x001567E0
		internal virtual TextBox Cell0_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Cell0_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Cell0_TextBox = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x001577EC File Offset: 0x001567EC
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00157804 File Offset: 0x00156804
		internal virtual TextBox AscO_TextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AscO_TextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._AscO_TextBox = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00157810 File Offset: 0x00156810
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00157828 File Offset: 0x00156828
		internal virtual Label LabelAsc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelAsc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelAsc = value;
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00157834 File Offset: 0x00156834
		public new DialogResult ShowDialog()
		{
			this.LSI_NumericUpDown.Maximum = new decimal(MyProject.Forms.FormMain.mapMngt.LSNb);
			this.LSColumnNb = MyProject.Forms.FormMain.mapMngt.LSColumnNb;
			this.LSLineNb = MyProject.Forms.FormMain.mapMngt.LSLineNb;
			bool flag = this.projection == null;
			if (flag)
			{
				this.projection = new projection();
				flag = !this.projection.init(this.mapType);
				if (flag)
				{
					return DialogResult.Abort;
				}
			}
			base.ShowDialog();
			DialogResult result;
			return result;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x001578DC File Offset: 0x001568DC
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x001578F0 File Offset: 0x001568F0
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00157904 File Offset: 0x00156904
		private void CellCalc_Button_Click(object sender, EventArgs e)
		{
			ushort num = Convert.ToUInt16(this.LSI_NumericUpDown.Value);
			this.LS = num;
			byte b = Convert.ToByte(this.MSI_NumericUpDown.Value);
			this.MS = b;
			byte b2 = Convert.ToByte(this.SSI_NumericUpDown.Value);
			this.SS = b2;
			ushort num2 = Convert.ToUInt16(this.XI_NumericUpDown.Value);
			this.X = num2;
			ushort num3 = Convert.ToUInt16(this.YI_NumericUpDown.Value);
			this.Y = num3;
			LP lp;
			checked
			{
				this.ERTX = 256000U * ((uint)num % this.LSColumnNb) + 16000U * (uint)(b % 16) + 1000U * (uint)(b2 % 16) + (uint)num2;
				this.NRTX = 256000U * ((uint)num / this.LSColumnNb) + 16000U * (uint)(b / 16) + 1000U * (uint)(b2 / 16) + (uint)num3;
				this.cellID = (uint)((int)this.LS << 16 | (int)this.MS << 8 | (int)this.SS);
				lp = this.projection.proj_inv(this.ERTX, this.NRTX);
			}
			this.lat = Math.Round(180.0 * lp.phi / 3.141592653589793, 6);
			this.lon = Math.Round(180.0 * lp.lam / 3.141592653589793, 6);
			this.LSO_TextBox.Text = this.LS.ToString();
			this.MSO_TextBox.Text = this.MS.ToString();
			this.SSO_TextBox.Text = this.SS.ToString();
			this.XO_TextBox.Text = this.X.ToString();
			this.YO_TextBox.Text = this.Y.ToString();
			this.Cell0_TextBox.Text = this.cellID.ToString();
			this.EO_TextBox.Text = this.ERTX.ToString();
			this.NO_TextBox.Text = this.NRTX.ToString();
			this.LatO_TextBox.Text = this.lat.ToString(this.cultForOut);
			this.LonO_TextBox.Text = this.lon.ToString(this.cultForOut);
			this.AscO_TextBox.Text = string.Concat(new string[]
			{
				this.lon.ToString(this.cultForOut),
				", ",
				this.lat.ToString(this.cultForOut),
				", \"",
				this.LS.ToString(),
				"-",
				this.MS.ToString(),
				"-",
				this.SS.ToString(),
				"-",
				this.X.ToString(),
				"-",
				this.Y.ToString(),
				"-",
				this.cellID.ToString(),
				"-",
				this.ERTX.ToString(),
				"-",
				this.NRTX.ToString(),
				"\""
			});
			this.EI_TextBox.Text = this.ERTX.ToString();
			this.NI_TextBox.Text = this.NRTX.ToString();
			this.LatI_TextBox.Text = this.lat.ToString(this.cultForOut);
			this.LonI_TextBox.Text = this.lon.ToString(this.cultForOut);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00157D04 File Offset: 0x00156D04
		private void LatLonCalc_Button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00157D08 File Offset: 0x00156D08
		private void ENCalc_Button_Click(object sender, EventArgs e)
		{
			uint num;
			bool flag = !uint.TryParse(this.EI_TextBox.Text, out num);
			if (flag)
			{
				Interaction.MsgBox("Incorrect ERTX", MsgBoxStyle.Exclamation, null);
			}
			this.ERTX = num;
			uint num2;
			flag = !uint.TryParse(this.NI_TextBox.Text, out num2);
			if (flag)
			{
				Interaction.MsgBox("Incorrect NRTX", MsgBoxStyle.Exclamation, null);
			}
			this.NRTX = num2;
			LP lp = this.projection.proj_inv(num, num2);
			this.lat = Math.Round(180.0 * lp.phi / 3.141592653589793, 6);
			this.lon = Math.Round(180.0 * lp.lam / 3.141592653589793, 6);
			checked
			{
				this.LS = (ushort)(unchecked((ulong)this.ERTX / 256000UL % (ulong)this.LSColumnNb) + unchecked((ulong)this.LSColumnNb) * (unchecked((ulong)this.NRTX) / 256000UL));
				this.MS = (byte)(unchecked((ulong)this.ERTX) % 256000UL / 16000UL + 16UL * (unchecked((ulong)this.NRTX) % 256000UL / 16000UL));
				this.SS = (byte)(unchecked((ulong)this.ERTX) % 16000UL / 1000UL + 16UL * (unchecked((ulong)this.NRTX) % 16000UL / 1000UL));
				this.X = (ushort)(unchecked((ulong)this.ERTX) % 1000UL);
				this.Y = (ushort)(unchecked((ulong)this.NRTX) % 1000UL);
				this.cellID = (uint)((int)this.LS << 16 | (int)this.MS << 8 | (int)this.SS);
				this.LSO_TextBox.Text = this.LS.ToString();
				this.MSO_TextBox.Text = this.MS.ToString();
				this.SSO_TextBox.Text = this.SS.ToString();
				this.XO_TextBox.Text = this.X.ToString();
				this.YO_TextBox.Text = this.Y.ToString();
				this.Cell0_TextBox.Text = this.cellID.ToString();
				this.EO_TextBox.Text = this.ERTX.ToString();
				this.NO_TextBox.Text = this.NRTX.ToString();
				this.LatO_TextBox.Text = this.lat.ToString(this.cultForOut);
				this.LonO_TextBox.Text = this.lon.ToString(this.cultForOut);
				this.AscO_TextBox.Text = string.Concat(new string[]
				{
					this.lon.ToString(this.cultForOut),
					", ",
					this.lat.ToString(this.cultForOut),
					", \"",
					this.LS.ToString(),
					"-",
					this.MS.ToString(),
					"-",
					this.SS.ToString(),
					"-",
					this.X.ToString(),
					"-",
					this.Y.ToString(),
					"-",
					this.cellID.ToString(),
					"-",
					this.ERTX.ToString(),
					"-",
					this.NRTX.ToString(),
					"\""
				});
				this.LSI_NumericUpDown.Value = new decimal((int)this.LS);
				this.MSI_NumericUpDown.Value = new decimal((int)this.MS);
				this.SSI_NumericUpDown.Value = new decimal((int)this.SS);
				this.XI_NumericUpDown.Value = new decimal((int)this.X);
				this.YI_NumericUpDown.Value = new decimal((int)this.Y);
				this.LatI_TextBox.Text = this.lat.ToString(this.cultForOut);
				this.LonI_TextBox.Text = this.lon.ToString(this.cultForOut);
			}
		}

		// Token: 0x0400034A RID: 842
		private static ArrayList __ENCList = new ArrayList();

		// Token: 0x0400034C RID: 844
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x0400034D RID: 845
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x0400034E RID: 846
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x0400034F RID: 847
		[AccessedThroughProperty("LSI_NumericUpDown")]
		private NumericUpDown _LSI_NumericUpDown;

		// Token: 0x04000350 RID: 848
		[AccessedThroughProperty("LabelLSI")]
		private Label _LabelLSI;

		// Token: 0x04000351 RID: 849
		[AccessedThroughProperty("LabelMSI")]
		private Label _LabelMSI;

		// Token: 0x04000352 RID: 850
		[AccessedThroughProperty("MSI_NumericUpDown")]
		private NumericUpDown _MSI_NumericUpDown;

		// Token: 0x04000353 RID: 851
		[AccessedThroughProperty("LabelSSI")]
		private Label _LabelSSI;

		// Token: 0x04000354 RID: 852
		[AccessedThroughProperty("SSI_NumericUpDown")]
		private NumericUpDown _SSI_NumericUpDown;

		// Token: 0x04000355 RID: 853
		[AccessedThroughProperty("LabelXI")]
		private Label _LabelXI;

		// Token: 0x04000356 RID: 854
		[AccessedThroughProperty("XI_NumericUpDown")]
		private NumericUpDown _XI_NumericUpDown;

		// Token: 0x04000357 RID: 855
		[AccessedThroughProperty("LabelYI")]
		private Label _LabelYI;

		// Token: 0x04000358 RID: 856
		[AccessedThroughProperty("YI_NumericUpDown")]
		private NumericUpDown _YI_NumericUpDown;

		// Token: 0x04000359 RID: 857
		[AccessedThroughProperty("CellCalc_Button")]
		private Button _CellCalc_Button;

		// Token: 0x0400035A RID: 858
		[AccessedThroughProperty("LabelEO")]
		private Label _LabelEO;

		// Token: 0x0400035B RID: 859
		[AccessedThroughProperty("EO_TextBox")]
		private TextBox _EO_TextBox;

		// Token: 0x0400035C RID: 860
		[AccessedThroughProperty("LabelNO")]
		private Label _LabelNO;

		// Token: 0x0400035D RID: 861
		[AccessedThroughProperty("NO_TextBox")]
		private TextBox _NO_TextBox;

		// Token: 0x0400035E RID: 862
		[AccessedThroughProperty("LabelLatO")]
		private Label _LabelLatO;

		// Token: 0x0400035F RID: 863
		[AccessedThroughProperty("LatO_TextBox")]
		private TextBox _LatO_TextBox;

		// Token: 0x04000360 RID: 864
		[AccessedThroughProperty("LabelLonO")]
		private Label _LabelLonO;

		// Token: 0x04000361 RID: 865
		[AccessedThroughProperty("LonO_TextBox")]
		private TextBox _LonO_TextBox;

		// Token: 0x04000362 RID: 866
		[AccessedThroughProperty("LabelLatI")]
		private Label _LabelLatI;

		// Token: 0x04000363 RID: 867
		[AccessedThroughProperty("LatI_TextBox")]
		private TextBox _LatI_TextBox;

		// Token: 0x04000364 RID: 868
		[AccessedThroughProperty("Label1LonI")]
		private Label _Label1LonI;

		// Token: 0x04000365 RID: 869
		[AccessedThroughProperty("LonI_TextBox")]
		private TextBox _LonI_TextBox;

		// Token: 0x04000366 RID: 870
		[AccessedThroughProperty("LabelEI")]
		private Label _LabelEI;

		// Token: 0x04000367 RID: 871
		[AccessedThroughProperty("EI_TextBox")]
		private TextBox _EI_TextBox;

		// Token: 0x04000368 RID: 872
		[AccessedThroughProperty("LabelNI")]
		private Label _LabelNI;

		// Token: 0x04000369 RID: 873
		[AccessedThroughProperty("NI_TextBox")]
		private TextBox _NI_TextBox;

		// Token: 0x0400036A RID: 874
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x0400036B RID: 875
		[AccessedThroughProperty("LatLonCalc_Button")]
		private Button _LatLonCalc_Button;

		// Token: 0x0400036C RID: 876
		[AccessedThroughProperty("ENCalc_Button")]
		private Button _ENCalc_Button;

		// Token: 0x0400036D RID: 877
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x0400036E RID: 878
		[AccessedThroughProperty("LabelLSO")]
		private Label _LabelLSO;

		// Token: 0x0400036F RID: 879
		[AccessedThroughProperty("LSO_TextBox")]
		private TextBox _LSO_TextBox;

		// Token: 0x04000370 RID: 880
		[AccessedThroughProperty("LabelMSO")]
		private Label _LabelMSO;

		// Token: 0x04000371 RID: 881
		[AccessedThroughProperty("LabelSSO")]
		private Label _LabelSSO;

		// Token: 0x04000372 RID: 882
		[AccessedThroughProperty("MSO_TextBox")]
		private TextBox _MSO_TextBox;

		// Token: 0x04000373 RID: 883
		[AccessedThroughProperty("SSO_TextBox")]
		private TextBox _SSO_TextBox;

		// Token: 0x04000374 RID: 884
		[AccessedThroughProperty("LabelXO")]
		private Label _LabelXO;

		// Token: 0x04000375 RID: 885
		[AccessedThroughProperty("XO_TextBox")]
		private TextBox _XO_TextBox;

		// Token: 0x04000376 RID: 886
		[AccessedThroughProperty("LabelYO")]
		private Label _LabelYO;

		// Token: 0x04000377 RID: 887
		[AccessedThroughProperty("YO_TextBox")]
		private TextBox _YO_TextBox;

		// Token: 0x04000378 RID: 888
		[AccessedThroughProperty("LabelCellO")]
		private Label _LabelCellO;

		// Token: 0x04000379 RID: 889
		[AccessedThroughProperty("Cell0_TextBox")]
		private TextBox _Cell0_TextBox;

		// Token: 0x0400037A RID: 890
		[AccessedThroughProperty("AscO_TextBox")]
		private TextBox _AscO_TextBox;

		// Token: 0x0400037B RID: 891
		[AccessedThroughProperty("LabelAsc")]
		private Label _LabelAsc;

		// Token: 0x0400037C RID: 892
		private CultureInfo cultForOut;

		// Token: 0x0400037D RID: 893
		private projection projection;

		// Token: 0x0400037E RID: 894
		private POIDatas.errorCodes errorCode;

		// Token: 0x0400037F RID: 895
		private Common.RTxMapType mapType;

		// Token: 0x04000380 RID: 896
		private uint LSColumnNb;

		// Token: 0x04000381 RID: 897
		private uint LSLineNb;

		// Token: 0x04000382 RID: 898
		private ushort LS;

		// Token: 0x04000383 RID: 899
		private byte MS;

		// Token: 0x04000384 RID: 900
		private byte SS;

		// Token: 0x04000385 RID: 901
		private uint cellID;

		// Token: 0x04000386 RID: 902
		private ushort X;

		// Token: 0x04000387 RID: 903
		private ushort Y;

		// Token: 0x04000388 RID: 904
		private uint ERTX;

		// Token: 0x04000389 RID: 905
		private uint NRTX;

		// Token: 0x0400038A RID: 906
		private double lat;

		// Token: 0x0400038B RID: 907
		private double lon;
	}
}
