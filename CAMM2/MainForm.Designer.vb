<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ГабаритыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПечатьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВидToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.showPU = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PrintButt = New System.Windows.Forms.ToolStripButton()
        Me.GabBatt = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.XScaleP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.YScaleP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.InfoTS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SpeedP = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PortP = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MoveAfterP = New System.Windows.Forms.NumericUpDown()
        Me.AutoCutP = New System.Windows.Forms.CheckBox()
        Me.SlideP = New System.Windows.Forms.RadioButton()
        Me.ToBeginP = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RotRight = New System.Windows.Forms.PictureBox()
        Me.RotLeft = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ProporcionalButton = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.XSizeP = New System.Windows.Forms.NumericUpDown()
        Me.YSizeP = New System.Windows.Forms.NumericUpDown()
        Me.RotateP = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ZoomBar = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SpeedP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MoveAfterP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RotRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RotLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProporcionalButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XSizeP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YSizeP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ZoomBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.ВидToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(560, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОткрытьToolStripMenuItem, Me.ГабаритыToolStripMenuItem, Me.ПечатьToolStripMenuItem, Me.ToolStripSeparator1, Me.ВыходToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'ОткрытьToolStripMenuItem
        '
        Me.ОткрытьToolStripMenuItem.Name = "ОткрытьToolStripMenuItem"
        Me.ОткрытьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ОткрытьToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ОткрытьToolStripMenuItem.Text = "Открыть"
        '
        'ГабаритыToolStripMenuItem
        '
        Me.ГабаритыToolStripMenuItem.Name = "ГабаритыToolStripMenuItem"
        Me.ГабаритыToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ГабаритыToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ГабаритыToolStripMenuItem.Text = "Габариты"
        '
        'ПечатьToolStripMenuItem
        '
        Me.ПечатьToolStripMenuItem.Name = "ПечатьToolStripMenuItem"
        Me.ПечатьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ПечатьToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ПечатьToolStripMenuItem.Text = "Печать"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'ВидToolStripMenuItem
        '
        Me.ВидToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.showPU})
        Me.ВидToolStripMenuItem.Name = "ВидToolStripMenuItem"
        Me.ВидToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.ВидToolStripMenuItem.Text = "Вид"
        '
        'showPU
        '
        Me.showPU.CheckOnClick = True
        Me.showPU.Name = "showPU"
        Me.showPU.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.showPU.Size = New System.Drawing.Size(176, 22)
        Me.showPU.Text = "Показывать PU"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.PrintButt, Me.GabBatt})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(560, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Открыть"
        '
        'PrintButt
        '
        Me.PrintButt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintButt.Enabled = False
        Me.PrintButt.Image = CType(resources.GetObject("PrintButt.Image"), System.Drawing.Image)
        Me.PrintButt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintButt.Margin = New System.Windows.Forms.Padding(20, 1, 0, 2)
        Me.PrintButt.Name = "PrintButt"
        Me.PrintButt.Size = New System.Drawing.Size(23, 22)
        Me.PrintButt.Text = "ToolStripButton3"
        Me.PrintButt.ToolTipText = "Печать"
        '
        'GabBatt
        '
        Me.GabBatt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GabBatt.Enabled = False
        Me.GabBatt.Image = CType(resources.GetObject("GabBatt.Image"), System.Drawing.Image)
        Me.GabBatt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GabBatt.Margin = New System.Windows.Forms.Padding(20, 1, 0, 2)
        Me.GabBatt.Name = "GabBatt"
        Me.GabBatt.Size = New System.Drawing.Size(23, 22)
        Me.GabBatt.Text = "ToolStripButton4"
        Me.GabBatt.ToolTipText = "Габариты"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Progress, Me.XScaleP, Me.YScaleP, Me.InfoTS})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 352)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(560, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Progress
        '
        Me.Progress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Progress.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Progress.Name = "Progress"
        Me.Progress.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always
        Me.Progress.Size = New System.Drawing.Size(300, 16)
        Me.Progress.Step = 2
        Me.Progress.Visible = False
        '
        'XScaleP
        '
        Me.XScaleP.Name = "XScaleP"
        Me.XScaleP.Size = New System.Drawing.Size(53, 17)
        Me.XScaleP.Text = "XScale: 1"
        '
        'YScaleP
        '
        Me.YScaleP.Name = "YScaleP"
        Me.YScaleP.Size = New System.Drawing.Size(53, 17)
        Me.YScaleP.Text = "YScale: 1"
        '
        'InfoTS
        '
        Me.InfoTS.Name = "InfoTS"
        Me.InfoTS.Size = New System.Drawing.Size(0, 17)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(529, 303)
        Me.SplitContainer1.SplitterDistance = 351
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 301)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SpeedP)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.PortP)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(10, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(154, 83)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Настройка вывода:"
        '
        'SpeedP
        '
        Me.SpeedP.Location = New System.Drawing.Point(73, 51)
        Me.SpeedP.Name = "SpeedP"
        Me.SpeedP.Size = New System.Drawing.Size(70, 20)
        Me.SpeedP.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Скорость:"
        '
        'PortP
        '
        Me.PortP.FormattingEnabled = True
        Me.PortP.Items.AddRange(New Object() {"LPT1", "LPT2", "LPT3", "LPT4"})
        Me.PortP.Location = New System.Drawing.Point(50, 19)
        Me.PortP.Name = "PortP"
        Me.PortP.Size = New System.Drawing.Size(93, 21)
        Me.PortP.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Порт:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.MoveAfterP)
        Me.GroupBox2.Controls.Add(Me.AutoCutP)
        Me.GroupBox2.Controls.Add(Me.SlideP)
        Me.GroupBox2.Controls.Add(Me.ToBeginP)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(10, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 87)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "После резки:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "мм"
        '
        'MoveAfterP
        '
        Me.MoveAfterP.Location = New System.Drawing.Point(75, 39)
        Me.MoveAfterP.Name = "MoveAfterP"
        Me.MoveAfterP.Size = New System.Drawing.Size(50, 20)
        Me.MoveAfterP.TabIndex = 3
        '
        'AutoCutP
        '
        Me.AutoCutP.AutoSize = True
        Me.AutoCutP.Location = New System.Drawing.Point(15, 64)
        Me.AutoCutP.Name = "AutoCutP"
        Me.AutoCutP.Size = New System.Drawing.Size(64, 17)
        Me.AutoCutP.TabIndex = 2
        Me.AutoCutP.Text = "AutoCut"
        Me.AutoCutP.UseVisualStyleBackColor = True
        '
        'SlideP
        '
        Me.SlideP.AutoSize = True
        Me.SlideP.Checked = True
        Me.SlideP.Location = New System.Drawing.Point(15, 41)
        Me.SlideP.Name = "SlideP"
        Me.SlideP.Size = New System.Drawing.Size(62, 17)
        Me.SlideP.TabIndex = 1
        Me.SlideP.TabStop = True
        Me.SlideP.Text = "Прогон"
        Me.SlideP.UseVisualStyleBackColor = True
        '
        'ToBeginP
        '
        Me.ToBeginP.AutoSize = True
        Me.ToBeginP.Location = New System.Drawing.Point(15, 18)
        Me.ToBeginP.Name = "ToBeginP"
        Me.ToBeginP.Size = New System.Drawing.Size(86, 17)
        Me.ToBeginP.TabIndex = 0
        Me.ToBeginP.Text = "Начало (0;0)"
        Me.ToBeginP.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RotRight)
        Me.GroupBox1.Controls.Add(Me.RotLeft)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.ProporcionalButton)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.XSizeP)
        Me.GroupBox1.Controls.Add(Me.YSizeP)
        Me.GroupBox1.Controls.Add(Me.RotateP)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Габариты:"
        '
        'RotRight
        '
        Me.RotRight.Enabled = False
        Me.RotRight.Image = Global.CAMM2.My.Resources.Resources.shape_rotate_clockwise
        Me.RotRight.Location = New System.Drawing.Point(134, 83)
        Me.RotRight.Name = "RotRight"
        Me.RotRight.Size = New System.Drawing.Size(16, 16)
        Me.RotRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.RotRight.TabIndex = 20
        Me.RotRight.TabStop = False
        '
        'RotLeft
        '
        Me.RotLeft.Enabled = False
        Me.RotLeft.Image = Global.CAMM2.My.Resources.Resources.shape_rotate_anticlockwise
        Me.RotLeft.Location = New System.Drawing.Point(57, 83)
        Me.RotLeft.Name = "RotLeft"
        Me.RotLeft.Size = New System.Drawing.Size(16, 16)
        Me.RotLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.RotLeft.TabIndex = 19
        Me.RotLeft.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.CAMM2.My.Resources.Resources.page_refresh
        Me.PictureBox2.Location = New System.Drawing.Point(131, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "Сделать начальными"
        '
        'ProporcionalButton
        '
        Me.ProporcionalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ProporcionalButton.Image = Global.CAMM2.My.Resources.Resources.lock
        Me.ProporcionalButton.Location = New System.Drawing.Point(111, 35)
        Me.ProporcionalButton.Name = "ProporcionalButton"
        Me.ProporcionalButton.Size = New System.Drawing.Size(16, 16)
        Me.ProporcionalButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ProporcionalButton.TabIndex = 17
        Me.ProporcionalButton.TabStop = False
        Me.ProporcionalButton.Tag = "Lock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "°"
        '
        'XSizeP
        '
        Me.XSizeP.Enabled = False
        Me.XSizeP.Location = New System.Drawing.Point(32, 16)
        Me.XSizeP.DecimalPlaces = 2
        Me.XSizeP.Increment = 0.1
        Me.XSizeP.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.XSizeP.Name = "XSizeP"
        Me.XSizeP.Size = New System.Drawing.Size(69, 20)
        Me.XSizeP.TabIndex = 11
        '
        'YSizeP
        '
        Me.YSizeP.Enabled = False
        Me.YSizeP.Location = New System.Drawing.Point(32, 49)
        Me.YSizeP.DecimalPlaces = 2
        Me.YSizeP.Increment = 0.1
        Me.YSizeP.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.YSizeP.Name = "YSizeP"
        Me.YSizeP.Size = New System.Drawing.Size(69, 20)
        Me.YSizeP.TabIndex = 12
        '
        'RotateP
        '
        Me.RotateP.Enabled = False
        Me.RotateP.FormattingEnabled = True
        Me.RotateP.Items.AddRange(New Object() {"0", "90", "180", "270"})
        Me.RotateP.Location = New System.Drawing.Point(75, 81)
        Me.RotateP.Name = "RotateP"
        Me.RotateP.Size = New System.Drawing.Size(50, 21)
        Me.RotateP.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Поворот:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Y"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2, Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(148, 92)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 98
        Me.LineShape1.X2 = 115
        Me.LineShape1.Y1 = 9
        Me.LineShape1.Y2 = 9
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 98
        Me.LineShape2.X2 = 115
        Me.LineShape2.Y1 = 43
        Me.LineShape2.Y2 = 43
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 115
        Me.LineShape3.X2 = 115
        Me.LineShape3.Y1 = 9
        Me.LineShape3.Y2 = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 35)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "мм"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ZoomBar, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(30, 303)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.CAMM2.My.Resources.Resources.zoomout
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(3, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 24)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ZoomBar
        '
        Me.ZoomBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZoomBar.LargeChange = 3
        Me.ZoomBar.Location = New System.Drawing.Point(3, 33)
        Me.ZoomBar.Minimum = 1
        Me.ZoomBar.Name = "ZoomBar"
        Me.ZoomBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.ZoomBar.Size = New System.Drawing.Size(24, 207)
        Me.ZoomBar.TabIndex = 10
        Me.ZoomBar.Value = 1
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.CAMM2.My.Resources.Resources.zoomin
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.CAMM2.My.Resources.Resources.zoom
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(3, 276)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer2.Panel1.Enabled = False
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(560, 303)
        Me.SplitContainer2.SplitterDistance = 30
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 5
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 374)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAMM2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SpeedP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MoveAfterP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RotRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RotLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProporcionalButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XSizeP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YSizeP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ZoomBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОткрытьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПечатьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ВыходToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintButt As System.Windows.Forms.ToolStripButton
    Friend WithEvents GabBatt As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ГабаритыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВидToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents showPU As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents XSizeP As System.Windows.Forms.NumericUpDown
    Friend WithEvents YSizeP As System.Windows.Forms.NumericUpDown
    Friend WithEvents RotateP As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents AutoCutP As System.Windows.Forms.CheckBox
    Friend WithEvents SlideP As System.Windows.Forms.RadioButton
    Friend WithEvents ToBeginP As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MoveAfterP As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SpeedP As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PortP As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ProporcionalButton As System.Windows.Forms.PictureBox
    Friend WithEvents XScaleP As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents YScaleP As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents RotLeft As System.Windows.Forms.PictureBox
    Friend WithEvents RotRight As System.Windows.Forms.PictureBox
    Friend WithEvents Progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents InfoTS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ZoomBar As System.Windows.Forms.TrackBar
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
