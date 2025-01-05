Imports System.ComponentModel
Imports System.Threading.Tasks

Module HPGL

    Dim X As String, Y As String
    Dim XPos As Double, YPos As Double
    Dim LastX As Double, LastY As Double
    Dim Relatif As Boolean
    Public XMin As Double = 1 / 0
    Public YMin As Double = 1 / 0
    Public XMax As Double, YMax As Double = -1 / 0
    Public DisplaceX As Double = 0
    Public DisplaceY As Double = 0
    Public Zoom As Double = 1

    Dim LastCmd As String
    Dim LastPosition As New Point(0, 0)
    Dim SilverPen As New Pen(Color.Silver)
    Dim BlackPen As New Pen(Color.Black)
    Dim YMaxDraw As Double

    Dim BMP As Bitmap
    Dim G As Graphics

    Public Async Function Draw_HPGL(ByVal File As String, ByVal PenOnOff As Boolean, ByVal HPGL_Draw As PictureBox, ByVal PenUp As Boolean) As Threading.Tasks.Task
        'Dim PenColor As Integer
        Dim Command As String
        Dim Parameters As String
        ' Если нет фала EXIT
        If File = "" Then
            Exit Function
        End If
        'HPGL_Draw.Image.Dispose()        'Очищаем место рисования
        HPGL_Draw.Image = Nothing
        ' Последняя команда в инициализации PU
        LastCmd = "PU"
        'Открыть файл
        Dim oRead As System.IO.StreamReader
        Dim LineIn As String
        oRead = IO.File.OpenText(File)

        'BMP = New Bitmap(HPGL_Draw.Size.Width, HPGL_Draw.Size.Height)
        MainForm.PictureBox1.Width = CInt(MainForm.SplitContainer1.Panel1.Width * Zoom)
        MainForm.PictureBox1.Height = CInt(MainForm.SplitContainer1.Panel1.Height * Zoom)
        BMP = New Bitmap(CInt(MainForm.SplitContainer1.Panel1.Width * Zoom), CInt(MainForm.SplitContainer1.Panel1.Height * Zoom))
        G = Graphics.FromImage(BMP)

        YMaxDraw = Val(HPGL_Draw.Size.Height)
        LastPosition = New Point(10, YMaxDraw - 10)

        Dim Size As Integer = oRead.BaseStream.Length

        MainForm.Progress.Maximum = Size

        MainForm.Progress.Value = 0
        MainForm.Progress.Visible = True


        While oRead.Peek <> -1
            LineIn = Await oRead.ReadLineAsync()
            'Pos += LineIn.Length
            MainForm.Progress.Value = oRead.BaseStream.Position
            Command = Left(LineIn, 2)
            Parameters = LineIn.Remove(0, 2)
            Select Case Command
                Case "PU"
                    LastCmd = Command
                    GetXYnDraw(Command, Parameters, PenOnOff, PenUp, HPGL_Draw)
                Case "PD"
                    LastCmd = Command
                    GetXYnDraw(Command, Parameters, PenOnOff, PenUp, HPGL_Draw)
            End Select
        End While
        oRead.Close()
        MainForm.Progress.Value = Size
        MainForm.Progress.Visible = False

        HPGL_Draw.Image = BMP

    End Function

    Public Sub GetXYnDraw(ByVal Command As String, ByVal Parameters As String, ByVal PenOnOff As Boolean, ByVal PenUp As Boolean, ByVal HPGL_Draw As PictureBox)
        Dim StrArray() As String = Parameters.Replace(";", "").Split(" ")
        Dim Scale As Double = 1
        Dim ScaleX As Double, ScaleY As Double
        'X = StrArray(0) + DisplaceX
        'Y = StrArray(1) + DisplaceY
        X = StrArray(0)
        Y = StrArray(1)
        Dim PropX As Double = 1
        Dim PropY As Double = 1
        If MainForm.XScale < MainForm.YScale Then
            PropY = MainForm.YScale - MainForm.XScale + 1
        ElseIf MainForm.XScale > MainForm.YScale Then
            PropX = MainForm.XScale - MainForm.YScale + 1
        End If
            
        If Not PenOnOff Then
            If Val(X) < XMin Then XMin = Val(X)
            If Val(Y) < YMin Then YMin = Val(Y)
            If Val(X) > XMax Then XMax = Val(X)
            If Val(Y) > YMax Then YMax = Val(Y)
        Else
            If (MainForm.RotateP.Text = "90" Or MainForm.RotateP.Text = "270") Then
                ScaleX = (HPGL_Draw.Size.Height - 20) / (Math.Abs(XMax - XMin) + 10) * PropY
                ScaleY = (HPGL_Draw.Size.Width - 20) / (Math.Abs(YMax - YMin) + 10) * PropX
            Else
                ScaleX = (HPGL_Draw.Size.Width - 20) / (Math.Abs(XMax - XMin) + 10) * PropY
                ScaleY = (HPGL_Draw.Size.Height - 20) / (Math.Abs(YMax - YMin) + 10) * PropX
            End If
            If ScaleX <= ScaleY Then
                Scale = ScaleX
            Else
                Scale = ScaleY
            End If
            XPos = Val(X) * Scale / PropY
            YPos = Val(Y) * Scale / PropX
            Dim CurPoint As New Point
            Select Case MainForm.RotateP.Text
                Case "0"
                    CurPoint = New Point(XPos - (XMin * Scale / PropY) + 10, YMaxDraw - (YPos - (YMin * Scale / PropX) + 10))
                Case "90"
                    XPos = (XMax - XMin) * Scale / PropY - (XPos - XMin * Scale / PropY)
                    CurPoint = New Point((YPos - (YMin * Scale / PropX) + 10), YMaxDraw - (XPos + 10))
                Case "180"
                    XPos = (XMax - XMin) * Scale / PropY - (XPos - XMin * Scale / PropY)
                    YPos = (YMax - YMin) * Scale / PropX - (YPos - YMin * Scale / PropX)
                    CurPoint = New Point((XPos + 10), YMaxDraw - (YPos + 10))
                Case "270"
                    YPos = (YMax - YMin) * Scale / PropX - (YPos - YMin * Scale / PropX)
                    CurPoint = New Point(YPos + 10, YMaxDraw - (XPos - (XMin * Scale / PropY) + 10))
            End Select

            If PenUp Then
                If Command = "PU" Then G.DrawLine(SilverPen, LastPosition, CurPoint)
            End If
            If Command = "PD" Then G.DrawLine(BlackPen, LastPosition, CurPoint)
            LastPosition = CurPoint
            'If LastCmd = "PD" Then HPGL_Draw.Line -(XPos, YMax - YPos + YMin), QBColor(PenColor)
        End If



    End Sub

    Public Sub CAMMSquare()
        Dim Fil As String = ""

        'Fil = Fil & "IN"
        Fil = Fil & "VS" & MainForm.Speed
        Fil = Fil & "PA"
        Fil = Fil & "PU0,0"
        Fil = Fil & "PR"
        Fil = Fil & "PU0," & Int((YMax - YMin + DisplaceY) * MainForm.YScale)
        Fil = Fil & "," & Int((XMax - XMin + DisplaceX) * MainForm.XScale) & ",0"
        Fil = Fil & ",0," & -Int((YMax - YMin + DisplaceY) * MainForm.YScale)
        Fil = Fil & "," & -Int((XMax - XMin + DisplaceX) * MainForm.XScale) & ",0"
        Fil = Fil & "PAPU0,0"
        Ports.CammRun(Fil)
    End Sub

    Public Sub CAMM_Draw(ByVal File As String)
        Dim Fil As String = ""

        'Fil = Fil & "IN"
        Fil = Fil & "VS" & MainForm.Speed
        Fil = Fil & "PA"
        Fil = Fil & "PU0,0"
        Fil = Fil & "PR"
        Dim Command As String
        Dim Parameters As String
        ' Если нет фала EXIT
        If File = "" Then
            Exit Sub
        End If
        ' Последняя команда в инициализации PU
        LastCmd = ""
        LastX = 0
        LastY = 0
        'Открыть файл
        Dim oRead As System.IO.StreamReader
        Dim LineIn As String
        oRead = IO.File.OpenText(File)

        Dim Size As Integer = oRead.BaseStream.Length

        MainForm.Progress.Maximum = Size

        MainForm.Progress.Value = 0
        MainForm.Progress.Visible = True

        LastPosition = New Point(0, 0)

        While oRead.Peek <> -1
            LineIn = oRead.ReadLine()
            MainForm.Progress.Value = oRead.BaseStream.Position
            Command = Left(LineIn, 2)
            Parameters = LineIn.Remove(0, 2)
            Select Case Command
                Case "PU"
                    Fil = Fil & CAMM_Command(Command, Parameters)
                    LastCmd = Command
                Case "PD"
                    Fil = Fil & CAMM_Command(Command, Parameters)
                    LastCmd = Command
            End Select
        End While
        MainForm.Progress.Value = Size
        MainForm.Progress.Visible = False
        oRead.Close()

        Select Case MainForm.AfterPlot
            Case "1"
                Fil = Fil & "PAPU0,0"
            Case "2"
                Fil = Fil & "PAPU" & (Int((XMax - XMin) * MainForm.XScale) + MainForm.MoveAfter * 40) & ",0"
        End Select
        Fil = Fil & "SP0"

        Ports.CammRun(Fil)
    End Sub

    Function CAMM_Command(ByVal Command As String, ByVal Parameters As String) As String
        Dim RetString As String
        Dim StrArray() As String = Parameters.Replace(";", "").Split(" ")
        'X = StrArray(0) + DisplaceX
        'Y = StrArray(1) + DisplaceY
        X = StrArray(0)
        Y = StrArray(1)


        XPos = Int((Val(X) - XMin) * MainForm.XScale)
        YPos = Int((Val(Y) - YMin) * MainForm.YScale)


        If LastCmd = Command Then
            RetString = ","
        Else
            RetString = Command
        End If

        Select Case MainForm.RotateP.Text
            Case "0"
                RetString = RetString & (XPos - LastX) & "," & (YPos - LastY)
            Case "90"
                RetString = RetString & (YPos - LastY) & "," & (XPos - LastX)
            Case "180"
                RetString = RetString & (XPos - LastX) & "," & (YPos - LastY)
            Case "270"
                RetString = RetString & (YPos - LastY) & "," & (XPos - LastX)
        End Select

        LastX = XPos
        LastY = YPos

        Return RetString

    End Function



End Module
