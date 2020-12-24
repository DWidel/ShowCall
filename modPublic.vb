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
    Public Const MaxLogFileSizeMB As Integer = 5

    Public Sub LogMsg(msg As String)

        If IO.File.Exists(LogFile) Then
            Dim fi As New IO.FileInfo(LogFile)
            If fi.Length / 1024 / 1024 > MaxLogFileSizeMB Then
                ShrinkLogFile()
            End If

        End If



            If My.Settings.DebugLog Then
            Dim sout As String = Format(Now, "dd HH:mm:ss.fff") & ": " & msg
            If IO.File.Exists(LogFile) Then
                Using sw As New IO.StreamWriter(LogFile, True)
                    sw.WriteLine(sout)
                    sw.Flush()
                End Using

            End If
        End If

    End Sub

    Private Sub ShrinkLogFile()
        Dim line As String = Nothing
        Dim tempFile As String = IO.Path.GetTempFileName()
        Dim filePath As String = LogFile
        Dim line_number As Integer = 0
        Dim lines_to_delete As Integer = 15000

        Using reader As New IO.StreamReader(LogFile)

            Using writer As New IO.StreamWriter(tempFile)
                writer.WriteLine("Shrink Log")
                line = reader.ReadLine
                While line IsNot Nothing
                    line_number += 1
                    If line_number > lines_to_delete Then Exit While
                    line = reader.ReadLine
                End While

                While line IsNot Nothing
                    writer.WriteLine(line)
                    line = reader.ReadLine
                End While

            End Using
        End Using

        If IO.File.Exists(tempFile) Then
            IO.File.Delete(LogFile)
            IO.File.Move(tempFile, LogFile)
        End If
    End Sub

End Module
