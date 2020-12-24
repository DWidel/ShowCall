Public Class frmDebug

    Dim Logfilename As String = ""
    Private Sub frmDebug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.phone_grey

        If gLastException IsNot Nothing Then
            lblException.Text = "Last connection exception occurred at: " & Format(gLastExceptionDT, "yyyy-MM-dd HH:mm:ss") & vbCrLf
            lblException.Text &= gLastException.ToString
        End If
        Timer1.Interval = 5 * 1000
        Timer1.Enabled = True

        RefreshLogSize()
    End Sub

    Private Sub RefreshLogSize()
        If IO.File.Exists(LogFile) Then
            Dim fi As New IO.FileInfo(LogFile)
            lblLogFile.Text = fi.FullName & "    (" & Format(fi.Length / 1024 / 1024, "0.00") & " MB)"
            Logfilename = fi.FullName
        End If
    End Sub

    Private Sub btnClearLog_Click(sender As Object, e As EventArgs) Handles btnClearLog.Click
        Try

            If IO.File.Exists(LogFile) Then
                Using sw As New IO.StreamWriter(LogFile, False)
                    sw.WriteLine("")
                    sw.Flush()
                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        RefreshLogSize()
    End Sub

    Private Sub btnOpenLog_Click(sender As Object, e As EventArgs) Handles btnOpenLog.Click
        Try


            If IO.File.Exists(LogFile) Then


                System.Diagnostics.Process.Start("notepad.exe", Logfilename)
            Else
                MsgBox("File not found.")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click


        If IO.File.Exists(LogFile) Then
            Dim fi As New IO.FileInfo(LogFile)
            Process.Start(fi.DirectoryName)
        Else
            MsgBox("File not found.")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RefreshLogSize()
    End Sub
End Class