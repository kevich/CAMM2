Public Class MainForm

    Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal iniSection As String, ByVal iniKey As String, ByVal iniDefault As String, ByVal iniValue As String, ByVal iniBuffer As Integer, ByVal iniFilename As String) As Integer

    Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal iniSection As String, ByVal iniKey As String, ByVal iniValue As String, ByVal iniFilename As String) As Integer


    Dim BMP As Bitmap
    Dim G As Graphics
    Dim HPGLFile As String

    Public Port As String
    Public Speed As String
    Public MoveAfter As String
    Public SaveProportions As Integer
    Public AfterPlot As Integer
    Public AutoCut As Integer

    Public Rotating As Boolean = False

    Public XScale As Double = 1
    Public YScale As Double = 1
    Public Drawing As Boolean = False





    Private Sub Exit_Me(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВыходToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OnLoading(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GetParameters()

        SetParameters()

        SpeedP.Minimum = 10

        'BMP = New Bitmap(PictureBox1.Size.Width, PictureBox1.Size.Height)
        PictureBox1.Width = CInt(SplitContainer1.Panel1.Width * Zoom)
        PictureBox1.Height = CInt(SplitContainer1.Panel1.Height * Zoom)
        BMP = New Bitmap(CInt(SplitContainer1.Panel1.Width * Zoom), CInt(SplitContainer1.Panel1.Height * Zoom))
        G = Graphics.FromImage(BMP)
    End Sub

    Private Sub OpenHPGL(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОткрытьToolStripMenuItem.Click, ToolStripButton1.Click
        Dim Deplace As Boolean = False
        Dim Zoom As Boolean = False
        Dim ActiveZoom As Boolean = False

        OpenFileDialog1.Title = "Открыть HPGL файл"
        OpenFileDialog1.Filter = "Файл HPGL (*.plt)|*.plt|Файл HPGL (*.hgl)|*.hgl"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.ShowDialog()

        HPGLFile = OpenFileDialog1.FileName

        If Len(HPGLFile) = 0 Then
            Exit Sub
        End If

        Me.Text = "CAMM2: " & HPGLFile

        HPGL.XMax = -1 / 0
        HPGL.XMin = 1 / 0
        HPGL.YMax = -1 / 0
        HPGL.YMin = 1 / 0



        HPGL.Draw_HPGL(HPGLFile, False, Me.PictureBox1, False)

        'If (HPGL.XMax - HPGL.XMin) < 0 Then
        '    'If (HPGL.XMin) < 0 Then
        '    HPGL.DisplaceX = Math.Abs(HPGL.XMin)
        'End If

        'If (HPGL.YMax - HPGL.YMin) < 0 Then
        '    'If (HPGL.YMin) < 0 Then
        '    HPGL.DisplaceY = Math.Abs(HPGL.YMin)
        'End If

        Drawing = True
        XSizeP.Value = Math.Abs(XMax - XMin) / 40
        YSizeP.Value = Math.Abs(YMax - YMin) / 40
        Drawing = False
        XScale = 1
        YScale = 1
        XSizeP.Enabled = True
        YSizeP.Enabled = True
        'RotateP.Enabled = True
        PictureBox2.Enabled = True
        'RotLeft.Enabled = True
        'RotRight.Enabled = True
        RotateP.Text = "0"
        SplitContainer2.Panel1.Enabled = True

        HPGL.XMax = HPGL.XMax + DisplaceX
        HPGL.XMin = HPGL.XMin + DisplaceX
        HPGL.YMax = HPGL.YMax + DisplaceY
        HPGL.YMin = HPGL.YMin + DisplaceY

        HPGL.Draw_HPGL(HPGLFile, True, Me.PictureBox1, showPU.Checked)


        PrintButt.Enabled = True
        GabBatt.Enabled = True

        Debug.Print("Done")
    End Sub



    Private Sub Form1_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        'BMP = New Bitmap(PictureBox1.Size.Height, PictureBox1.Size.Width)
        PictureBox1.Width = CInt(SplitContainer1.Panel1.Width * Zoom)
        PictureBox1.Height = CInt(SplitContainer1.Panel1.Height * Zoom)
        BMP = New Bitmap(CInt(SplitContainer1.Panel1.Width * Zoom), CInt(SplitContainer1.Panel1.Height * Zoom))
        G = Graphics.FromImage(BMP)
        HPGL.Draw_HPGL(HPGLFile, True, Me.PictureBox1, showPU.Checked)
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButt.Click, ПечатьToolStripMenuItem.Click
        HPGL.CAMM_Draw(HPGLFile)
    End Sub

    Private Sub showPU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showPU.Click
        HPGL.Draw_HPGL(HPGLFile, True, Me.PictureBox1, showPU.Checked)
    End Sub


    Private Sub Square_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GabBatt.Click, ГабаритыToolStripMenuItem.Click
        HPGL.CAMMSquare()

    End Sub

    Private Sub ProporcionalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProporcionalButton.Click
        If SaveProportions = "1" Then
            ProporcionalButton.Image = CAMM2.My.Resources.Resources.unlocked
            SaveProportions = "0"
        Else
            ProporcionalButton.Image = CAMM2.My.Resources.Resources.lock
            SaveProportions = "1"
        End If
        WritePrivateProfileString("Parameters", "SaveProportions", SaveProportions, Application.StartupPath + "/camm2.ini")
    End Sub

    Private Sub SetParameters()
        If SaveProportions = "1" Then
            ProporcionalButton.Image = CAMM2.My.Resources.Resources.lock
        Else
            ProporcionalButton.Image = CAMM2.My.Resources.Resources.unlocked
        End If
        PortP.Text = Port
        SpeedP.Value = Speed
        MoveAfterP.Value = MoveAfter
        Select Case AfterPlot
            Case "1"
                ToBeginP.Checked = True
            Case "2"
                SlideP.Checked = True
        End Select
        If AutoCut = "1" Then
            AutoCutP.Checked = True
        Else
            AutoCutP.Checked = False
        End If

    End Sub

    Private Sub GetParameters()
        Dim iniBuffer As String = Space(255)


        Dim iniLength As Integer = GetPrivateProfileString("Parameters", "Port", "LPT2", iniBuffer, 255, Application.StartupPath + "/camm2.ini")
        Port = Trim(iniBuffer)

        iniBuffer = Space(255)
        iniLength = GetPrivateProfileString("Parameters", "Speed", "50", iniBuffer, 255, Application.StartupPath + "/camm2.ini")
        Speed = Trim(iniBuffer)

        iniBuffer = Space(255)
        iniLength = GetPrivateProfileString("Parameters", "MoveAfter", "0", iniBuffer, 255, Application.StartupPath + "/camm2.ini")
        MoveAfter = Trim(iniBuffer)

        iniBuffer = Space(255)
        iniLength = GetPrivateProfileString("Parameters", "SaveProportions", "1", iniBuffer, 255, Application.StartupPath + "/camm2.ini")
        SaveProportions = Trim(iniBuffer)

        iniBuffer = Space(255)
        iniLength = GetPrivateProfileString("Parameters", "AfterPlot", "2", iniBuffer, 255, Application.StartupPath + "/camm2.ini")
        AfterPlot = Trim(iniBuffer)

        iniBuffer = Space(255)
        iniLength = GetPrivateProfileString("Parameters", "AutoCut", "0", iniBuffer, 255, Application.StartupPath + "/camm2.ini")
        AutoCut = Trim(iniBuffer)
    End Sub

    Private Sub ToBeginP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToBeginP.CheckedChanged
        If ToBeginP.Checked = True Then
            AfterPlot = "1"
        Else
            AfterPlot = "2"
        End If
        WritePrivateProfileString("Parameters", "AfterPlot", AfterPlot, Application.StartupPath + "/camm2.ini")
    End Sub

    Private Sub AutoCutP_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoCutP.CheckStateChanged
        If AutoCutP.Checked = True Then
            AutoCut = "1"
        Else
            AutoCut = "0"
        End If
        WritePrivateProfileString("Parameters", "AutoCut", AutoCut, Application.StartupPath + "/camm2.ini")
    End Sub

    Private Sub PortP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PortP.TextChanged
        Port = PortP.Text
        WritePrivateProfileString("Parameters", "Port", Port, Application.StartupPath + "/camm2.ini")
    End Sub

    Private Sub XSizeP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XSizeP.ValueChanged
        If Not Drawing Then
            If Not Rotating Then
                XScale = XSizeP.Value / ((XMax - XMin) / 40)
                If SaveProportions = "1" Then
                    YScale = XScale
                    YSizeP.Value = ((YMax - YMin) / 40) * YScale
                End If
                XScaleP.Text = "XScale: " & XScale.ToString("0.00")
                YScaleP.Text = "YScale: " & YScale.ToString("0.00")
                HPGL.Draw_HPGL(HPGLFile, True, Me.PictureBox1, showPU.Checked)
            End If
        End If
        

       
    End Sub

    Private Sub YSizeP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YSizeP.ValueChanged
        If Not Drawing Then
            If Not Rotating Then
                YScale = YSizeP.Value / ((YMax - YMin) / 40)
                If SaveProportions = "1" Then
                    XScale = YScale
                    XSizeP.Value = ((XMax - XMin) / 40) * XScale
                End If
                XScaleP.Text = "XScale: " & XScale.ToString("0.00")
                YScaleP.Text = "YScale: " & YScale.ToString("0.00")
                HPGL.Draw_HPGL(HPGLFile, True, Me.PictureBox1, showPU.Checked)
            End If
        End If
      

    End Sub

    Private Sub Reset_Scale(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        XScale = 1
        YScale = 1
        If (RotateP.Text = "90" Or RotateP.Text = "270") Then
            XSizeP.Value = ((YMax - YMin) / 40) * YScale
            YSizeP.Value = ((XMax - XMin) / 40) * XScale
        Else
            XSizeP.Value = ((XMax - XMin) / 40) * XScale
            YSizeP.Value = ((YMax - YMin) / 40) * YScale
        End If
        XScaleP.Text = "XScale: " & XScale.ToString("0.00")
        YScaleP.Text = "YScale: " & YScale.ToString("0.00")
    End Sub

    Private Sub MoveAfterP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveAfterP.ValueChanged
        MoveAfter = MoveAfterP.Value
        WritePrivateProfileString("Parameters", "MoveAfter", MoveAfter, Application.StartupPath + "/camm2.ini")
    End Sub

    Private Sub SpeedP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeedP.ValueChanged
            Speed = SpeedP.Value
            WritePrivateProfileString("Parameters", "Speed", Speed, Application.StartupPath + "/camm2.ini")
    End Sub

    Private Sub RotateP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotateP.SelectedIndexChanged
        XScale = 1
        YScale = 1
        Rotating = True
        If (RotateP.Text = "90" Or RotateP.Text = "270") Then
            XSizeP.Value = (Math.Abs(YMax - YMin) / 40) * YScale
            YSizeP.Value = (Math.Abs(XMax - XMin) / 40) * XScale
        Else
            XSizeP.Value = (Math.Abs(XMax - XMin) / 40) * XScale
            YSizeP.Value = (Math.Abs(YMax - YMin) / 40) * YScale
        End If
        Rotating = False
        XScaleP.Text = "XScale: " & XScale.ToString("0.00")
        YScaleP.Text = "YScale: " & YScale.ToString("0.00")
        HPGL.Draw_HPGL(HPGLFile, True, Me.PictureBox1, showPU.Checked)
    End Sub

    Private Sub Rotate_Right(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotRight.Click
        If RotateP.Text = "270" Then
            RotateP.Text = "0"
        Else
            RotateP.Text = Val(RotateP.Text) + 90
        End If
    End Sub

    Private Sub Rotate_Left(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotLeft.Click
        If RotateP.Text = "0" Then
            RotateP.Text = "270"
        Else
            RotateP.Text = Val(RotateP.Text) - 90
        End If
    End Sub

    Private Sub ZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Zoom < 10 Then
            Zoom = Zoom + 1
            ZoomBar.Value = Zoom
        End If
        
    End Sub

    Private Sub ZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Zoom > 1 Then
            Zoom = Zoom - 1
            ZoomBar.Value = Zoom
        Else
            Zoom = 1
            ZoomBar.Value = Zoom

        End If
    End Sub

    Private Sub Zoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Zoom = 1
        ZoomBar.Value = Zoom
    End Sub

    Private Sub ZoomBar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomBar.ValueChanged
        Zoom = ZoomBar.Value
        If Zoom <> 1 Then
            PictureBox1.Dock = DockStyle.None
        Else
            PictureBox1.Dock = DockStyle.Fill
        End If
        HPGL.Draw_HPGL(HPGLFile, True, Me.PictureBox1, showPU.Checked)
    End Sub
End Class
