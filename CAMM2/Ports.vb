Option Strict On

' Определить класс CommException, являющийся наследником класса ApplicationException, 
' а затем при получении сообщения об ошибке создать объект типа CommException.
Class CommException
    Inherits ApplicationException
    Sub New(ByVal Reason As String)
        MyBase.New(Reason)
    End Sub
End Class

Module Ports
    'Объявление структур.
    Public Structure DCB
        Public DCBlength As Int32
        Public BaudRate As Int32
        Public fBitFields As Int32 'См. комментарии в файле Win32API.Txt
        Public wReserved As Int16
        Public XonLim As Int16
        Public XoffLim As Int16
        Public ByteSize As Byte
        Public Parity As Byte
        Public StopBits As Byte
        Public XonChar As Byte
        Public XoffChar As Byte
        Public ErrorChar As Byte
        Public EofChar As Byte
        Public EvtChar As Byte
        Public wReserved1 As Int16 'Зарезервировано; не использовать
    End Structure

    Public Structure COMMTIMEOUTS
        Public ReadIntervalTimeout As Int32
        Public ReadTotalTimeoutMultiplier As Int32
        Public ReadTotalTimeoutConstant As Int32
        Public WriteTotalTimeoutMultiplier As Int32
        Public WriteTotalTimeoutConstant As Int32
    End Structure

    'Объявление констант.
    Public Const GENERIC_READ As Int32 = &H80000000
    Public Const GENERIC_WRITE As Int32 = &H40000000
    Public Const OPEN_EXISTING As Int32 = 3
    Public Const FILE_ATTRIBUTE_NORMAL As Int32 = &H80
    Public Const NOPARITY As Int32 = 0
    Public Const ONESTOPBIT As Int32 = 0

    'Объявление ссылок на внешние функции.
    Public Declare Auto Function CreateFile Lib "kernel32" _
       (ByVal lpFileName As String, ByVal dwDesiredAccess As Int32, _
          ByVal dwShareMode As Int32, ByVal lpSecurityAttributes As IntPtr, _
             ByVal dwCreationDisposition As Int32, ByVal dwFlagsAndAttributes As Int32, _
                ByVal hTemplateFile As IntPtr) As IntPtr

    Public Declare Auto Function GetCommState Lib "kernel32" (ByVal nCid As IntPtr, _
       ByRef lpDCB As DCB) As Boolean

    Public Declare Auto Function SetCommState Lib "kernel32" (ByVal nCid As IntPtr, _
       ByRef lpDCB As DCB) As Boolean

    Public Declare Auto Function GetCommTimeouts Lib "kernel32" (ByVal hFile As IntPtr, _
       ByRef lpCommTimeouts As COMMTIMEOUTS) As Boolean

    Public Declare Auto Function SetCommTimeouts Lib "kernel32" (ByVal hFile As IntPtr, _
       ByRef lpCommTimeouts As COMMTIMEOUTS) As Boolean

    Public Declare Auto Function WriteFile Lib "kernel32" (ByVal hFile As IntPtr, _
       ByVal lpBuffer As Byte(), ByVal nNumberOfBytesToWrite As Int32, _
          ByRef lpNumberOfBytesWritten As Int32, ByVal lpOverlapped As IntPtr) As Boolean

    Public Declare Auto Function CloseHandle Lib "kernel32" (ByVal hObject As IntPtr) As Boolean

    Public Sub CammRun(ByVal Data As String)
        ' Объявление локальных переменных, которые будут использованы в программе.
        Dim hParallelPort As IntPtr
        Dim Success As Boolean
        'Dim MyDCB As DCB
        'Dim MyCommTimeouts As COMMTIMEOUTS
        Dim BytesWritten As Int32
        Dim Buffer() As Byte

        ' Объявление переменных, используемых при кодировании.
        Dim oEncoder As New System.Text.ASCIIEncoding
        Dim oEnc As System.Text.Encoding = System.Text.Encoding.GetEncoding(1251)

        ' Преобразование строки в Byte().
        Buffer = oEnc.GetBytes(Data)

        Try
            ' Параллельный порт.
            Debug.Print("Получение доступа к параллельному порту " & MainForm.Port)
            ' Получение дескриптора параллельного порта LPT1.
            hParallelPort = CreateFile(MainForm.Port, GENERIC_READ Or GENERIC_WRITE, 0, IntPtr.Zero, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, IntPtr.Zero)
            ' Проверка допустимости полученного дескриптора.
            If hParallelPort.ToInt32 = -1 Then
                Throw New CommException("Не удается получить дескриптор порта " & MainForm.Port)
            End If
            ' Получение текущих параметров элемента управления.
            'Success = GetCommState(hParallelPort, MyDCB)
            'If Success = False Then
            '    Throw New CommException("Не удается получить текущие параметры элемента управления")
            'End If
            '' Измените соответствующим образом свойства полученной структуры DCB.
            '' ПРЕДУПРЕЖДЕНИЕ. При изменении свойств учитывайте поддерживаемые значения.
            'MyDCB.BaudRate = 9600
            'MyDCB.ByteSize = 8
            'MyDCB.Parity = NOPARITY
            'MyDCB.StopBits = ONESTOPBIT
            '' Перенастройка порта LPT1 согласно свойствам измененной структуры DCB.
            'Success = SetCommState(hParallelPort, MyDCB)
            'If Success = False Then
            '    Throw New CommException("Не удается выполнить перенастройку порта " + MainForm.Port)
            'End If
            '' Получение текущих параметров времени ожидания.
            'Success = GetCommTimeouts(hParallelPort, MyCommTimeouts)
            'If Success = False Then
            '    Throw New CommException("Не удается получить текущие параметры времени ожидания")
            'End If
            '' Измените соответствующим образом свойства полученной структуры COMMTIMEOUTS. 
            '' ПРЕДУПРЕЖДЕНИЕ. При изменении свойств учитывайте поддерживаемые значения.
            'MyCommTimeouts.ReadIntervalTimeout = 0
            'MyCommTimeouts.ReadTotalTimeoutConstant = 0
            'MyCommTimeouts.ReadTotalTimeoutMultiplier = 0
            'MyCommTimeouts.WriteTotalTimeoutConstant = 0
            'MyCommTimeouts.WriteTotalTimeoutMultiplier = 0
            '' Перенастройка параметров времени ожидания согласно свойствам измененной структуры COMMTIMEOUTS.
            'Success = SetCommTimeouts(hParallelPort, MyCommTimeouts)
            'If Success = False Then
            '    Throw New CommException("Не удается выполнить перенастройку параметров времени ожидания")
            'End If
            ' Запись данных в порт LPT1.
            ' Примечание. Данные из параллельного порта нельзя прочитать с помощью функции ReadFile.
            'Debug.Print("Запись следующих данных в порт " + MainForm.Port + ": тест")
            MainForm.Progress.Maximum = Buffer.Length
            MainForm.Progress.Visible = True
            'Success = WriteFile(hParallelPort, Buffer, Buffer.Length, BytesWritten, IntPtr.Zero)
            Success = WriteFile(hParallelPort, Buffer, Buffer.Length, MainForm.Progress.Value, IntPtr.Zero)
            If Success = False Then
                Throw New CommException("Не удается записать данные в порт " + MainForm.Port)
            Else
                MainForm.Progress.Value = Buffer.Length
            End If
        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            ' Освобождение дескриптора порта LPT1.
            Success = CloseHandle(hParallelPort)
            If Success = False Then
                Debug.Print("Не удается освободить дескриптор порта " + MainForm.Port)
            End If
        End Try
    End Sub
End Module
