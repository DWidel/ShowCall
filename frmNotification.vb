Public Class frmNotification

    Public mCI As CallInfo
    Public Event Acked(CI As CallInfo)
    Public mDisplayedTime As DateTime
    Public mOpenSeconds As Integer = 7

    Private Sub frmNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.phone_yellow

        ResizeMessage()

        Timer1.Interval = 100
        Timer1.Enabled = True

    End Sub

    Public Sub ResizeMessage()

        Me.Font = New Font("calibri", My.Settings.NotificationFontSize)
        Me.Width = My.Settings.NotificationFontSize * 16

        lblDisplay.Font = Me.Font
        lblAction.Font = Me.Font
        Me.Height = Me.Width * 0.6
    End Sub

    Public Sub SetPosition()

        ResizeMessage()

        Dim startPosX As Integer
        Dim startPosY As Integer

        Dim ScreenW As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim ScreenH As Integer = Screen.PrimaryScreen.WorkingArea.Height

        Select Case My.Settings.NotificationLocation
            Case ScreenLocation.LowerRight
                startPosX = ScreenW - Me.Width
                startPosY = ScreenH - Me.Height
            Case ScreenLocation.LowerLeft
                startPosX = 0
                startPosY = ScreenH - Me.Height
            Case ScreenLocation.UpperLeft
                startPosX = 0
                startPosY = 0
            Case ScreenLocation.UpperRight
                startPosX = ScreenW - Me.Width
                startPosY = 0
            Case ScreenLocation.Center
                startPosX = ScreenW \ 2 - Me.Width \ 2
                startPosY = ScreenH \ 2 - Me.Height \ 2
        End Select
        Me.StartPosition = FormStartPosition.Manual
        Me.SetDesktopLocation(startPosX, startPosY)
        Me.TopMost = True
        Me.BringToFront()
    End Sub

    Public Sub SetTimer(SecondsLeft As Integer)
        mOpenSeconds = SecondsLeft

    End Sub
    Public Sub SetDisplay(CI As CallInfo)
        SetPosition()

        mCI = CI
        mDisplayedTime = Now
        LogMsg("Show notification: " & mCI.Caller)
        Me.lblDisplay.Text = CI.Caller & vbCrLf & CI.Number & vbCrLf & Format(CI.CallTime, "h:mm tt")

        Me.lblAction.Text = CI.Action

        Select Case CI.Action
            Case "Permitted" : lblAction.ForeColor = System.Drawing.Color.GreenYellow
            Case "Blocked" : lblAction.ForeColor = System.Drawing.Color.Red
            Case "Screened" : lblAction.ForeColor = System.Drawing.Color.Red
            Case Else
                lblAction.ForeColor = Me.ForeColor
        End Select

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Now - mDisplayedTime).TotalSeconds >= mOpenSeconds Then
            Me.Close()
        End If
    End Sub

    Private Sub frmNotification_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' RaiseEvent Acked(mCI)
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        LogMsg("Close notification: " & mCI.Caller)
        Me.Close()
    End Sub
End Class
