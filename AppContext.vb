Imports System.Net.Http
Imports System.Net
Imports System.IO

Public Class AppContext
    Inherits ApplicationContext




    Private mLastCallClosed As New CallInfo  'This is the info on the last call, so we have so we know if a call is new.

    Private WithEvents Tray As NotifyIcon
    Private WithEvents MainMenu As ContextMenuStrip
    Private WithEvents mnuSettings As ToolStripMenuItem
    Private WithEvents mnuDebug As ToolStripMenuItem
    Private WithEvents mnuSep1 As ToolStripSeparator
    Private WithEvents mnuExit As ToolStripMenuItem
    Private WithEvents Timr As System.Windows.Forms.Timer

    'Private IconOn As Icon = My.Resources.phone_yellow
    'Private IconOff As Icon = My.Resources.phone_grey



    Public Sub New()

        'If My.Settings.DebugLog Then
        '    If IO.File.Exists(LogFile) Then
        '        IO.File.Delete(LogFile)
        '    End If
        '    IO.File.WriteAllText(LogFile, "")
        'End If


        If My.Settings.DebugLog Then
            LogMsg(vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf)
            LogMsg("SHOWCALL HAS STARTED.")

        End If


        'Initialize the menu 
        mnuSettings = New ToolStripMenuItem("Settings")
        mnuDebug = New ToolStripMenuItem("Debug")
        mnuSep1 = New ToolStripSeparator()
        mnuExit = New ToolStripMenuItem("Exit")
        MainMenu = New ContextMenuStrip
        MainMenu.Items.AddRange(New ToolStripItem() {mnuSettings, mnuDebug, mnuSep1, mnuExit})

        'mnuExit = New ToolStripMenuItem("Exit")
        'MainMenu = New ContextMenuStrip
        'MainMenu.Items.AddRange(New ToolStripItem() {mnuExit})

        'Initialize the tray
        Tray = New NotifyIcon
        Tray.Icon = My.Resources.phone_grey
        Tray.ContextMenuStrip = MainMenu
        Tray.Text = "ShowCall"

        'Display
        Tray.Visible = True


        Timr = New System.Windows.Forms.Timer
        SetTimrInterval()


        Timr.Enabled = True
        'CheckForCall()
    End Sub



    Private Sub AppContext_ThreadExit(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles Me.ThreadExit
        Tray.Visible = False
    End Sub

    Private Sub mnuSettings_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSettings.Click
        Try
            Using f As New frmSettings
                LogMsg("Open Settings")
                f.ShowDialog()

                SetTimrInterval()

                If f.DialogResult = DialogResult.OK Then
                    LogMsg("Close Settings")
                    mLastCallClosed = New CallInfo
                    Timr_Tick(Nothing, Nothing)
                End If
            End Using
        Catch ex As Exception
            LogMsg(ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub mnuDebug_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDebug.Click
        Try
            LogMsg("Open Debug")
            Using f As New frmDebug
                f.ShowDialog()
            End Using
            LogMsg("Close Debug")
        Catch ex As Exception
            LogMsg(ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SetTimrInterval()
        Dim interval As Integer = 1000 'ms
        Integer.TryParse(My.Settings.PageDownloadInterval, interval)
        If interval = 0 Then interval = 1000
        My.Settings.PageDownloadInterval = interval
        Timr.Interval = interval
    End Sub


    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Try
            LogMsg("mnuExit_Click")
            ExitApplication()
        Catch ex As Exception
            LogMsg(ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub


    'Show Call Attendant Web Page
    Private Sub ShowCallAttendantWebPage()


        Process.Start(My.Settings.CallAttendantURL)

    End Sub



    Private Sub Tray_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tray.DoubleClick

    End Sub



    Public Sub ExitApplication()
        Application.Exit()
        End
    End Sub




    Private mTickRunning As Boolean = False
    Private Async Sub Timr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timr.Tick
        Try

            LogMsg("Tick")
            If mTickRunning Then Return
            mTickRunning = True

            Await DoPhoneCheck()
        Finally
            mTickRunning = False
        End Try

    End Sub

    Private Async Function DoPhoneCheck() As Task
        Try
            LogMsg("Check Lst=" & Format(mLastCallClosed.CallTime, "HH:mm:ss"))
            Dim src As String = Await GetWebPage()

            Dim callList As List(Of List(Of String)) = GetCallList2(src)
            Dim CI As CallInfo = GetLastCall(callList)
            If CI.CallTime <> mLastCallClosed.CallTime Then
                NewCall(CI)
            End If

            If src.Contains("title=""Message available") Then
                gHasMessage = True
            Else
                gHasMessage = False
            End If




            If gHasMessage Then
                Tray.Icon = My.Resources.phone_yellowMessage
            Else
                Tray.Icon = My.Resources.phone_yellow
            End If
            Tray.Text = "ShowCall"
        Catch ex As Exception
            LogMsg("Exception: " & ex.ToString)

            If gHasMessage Then
                Tray.Icon = My.Resources.phone_greyMessage
            Else
                Tray.Icon = My.Resources.phone_grey
            End If
            Tray.Text = ex.Message
            gLastException = ex
            gLastExceptionDT = Now
        Finally
            mTickRunning = False
        End Try
    End Function

    Private Sub NewCall(CI As CallInfo)
        LogMsg("DoPhoneCheck NewCall: " & Format(CI.CallTime, "HH:mm:ss"))
        mLastCallClosed = CI

        If frmMessage Is Nothing OrElse frmMessage.IsDisposed Then
            frmMessage = New frmNotification
        End If



        frmMessage.TopMost = True
        frmMessage.Show()
        frmMessage.SetDisplay(CI)
        frmMessage.SetTimer(My.Settings.NotificationDisplayTime)
        frmMessage.BringToFront()
        frmMessage.TopMost = True
    End Sub

    Private Async Function GetWebPage() As Task(Of String)

        Dim content = New MemoryStream()

        Dim webReq = CType(WebRequest.Create(My.Settings.CallAttendantURL), HttpWebRequest)

        Using response As WebResponse = Await webReq.GetResponseAsync()

            ' Get the data stream that is associated with the specified URL.
            Using responseStream As Stream = response.GetResponseStream()
                ' Read the bytes in responseStream and copy them to content.
                Await responseStream.CopyToAsync(content)

            End Using
        End Using

        Return System.Text.Encoding.ASCII.GetString(content.ToArray())
    End Function


    Public WithEvents frmMessage As New frmNotification



    Private Sub Tray_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Tray.MouseUp
        If e.Button = MouseButtons.Left Then
            ShowCallAttendantWebPage()
        End If
    End Sub




End Class