Public Module modPublic

    Public Enum ScreenLocation
        LowerRight
        LowerLeft
        UpperLeft
        UpperRight
        Center
    End Enum

    Public gHasMessage As Boolean = False
    Public gLastException As Exception
    Public gLastExceptionDT As DateTime = Date.MinValue

    Public Const LogFile As String = ".\log.txt"

    Public Sub LogMsg(msg As String)
#If debuglog Then
        Dim sout As String = Format(Now, "HH:mm:ss.fff yyyy-MM-dd") & ": " & msg
        If IO.File.Exists(LogFile) Then
            Using sw As New IO.StreamWriter(LogFile, True)
                sw.WriteLine(sout)
                sw.Flush()
            End Using

        End If
#End If
    End Sub

End Module
