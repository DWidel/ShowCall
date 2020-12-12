Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.phone_yellow
        txtCallAttendantURL.Text = My.Settings.CallAttendantURL

        Dim Loc As ScreenLocation = ScreenLocation.LowerLeft
        If Integer.TryParse(My.Settings.NotificationLocation, Loc) Then

        End If

        cboMessageLocation.SelectedIndex = Loc

        cboTimerInterval.Items.Clear()

        For i As Integer = 500 To 1500 Step 250
            cboTimerInterval.Items.Add(i.ToString)
        Next

        Dim interval As Integer = 1000
        Integer.TryParse(My.Settings.PageDownloadInterval, interval)

        If cboTimerInterval.Items.Contains(interval.ToString) Then
            cboTimerInterval.SelectedItem = interval.ToString
        Else
            cboTimerInterval.SelectedItem = "1000"
        End If

        'display time
        For i As Integer = 1 To 9
            cboDisplayTime.Items.Add(i.ToString)
        Next
        For i As Integer = 10 To 25 Step 5
            cboDisplayTime.Items.Add(i.ToString)
        Next
        For i As Integer = 30 To 90 Step 15
            cboDisplayTime.Items.Add(i.ToString)
        Next
        Dim DisTime As Integer = 7
        Integer.TryParse(My.Settings.NotificationDisplayTime, DisTime)

        If cboDisplayTime.Items.Contains(DisTime.ToString) Then
            cboDisplayTime.SelectedItem = DisTime.ToString
        Else
            cboDisplayTime.SelectedIndex = 5
        End If





        Dim fontsizes() As Integer = {6, 7, 8, 9, 10, 11, 12, 14, 16, 20, 24, 28, 32, 36, 40, 48, 56, 64, 76, 84, 96}

        cboFontSize.DataSource = fontsizes

        Dim FontSize As Integer = 16
        Integer.TryParse(My.Settings.NotificationFontSize, FontSize)
        cboFontSize.SelectedItem = FontSize


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            My.Settings.CallAttendantURL = txtCallAttendantURL.Text
            My.Settings.NotificationLocation = cboMessageLocation.SelectedIndex
            My.Settings.PageDownloadInterval = cboTimerInterval.SelectedItem
            My.Settings.NotificationDisplayTime = cboDisplayTime.SelectedItem

            My.Settings.NotificationFontSize = cboFontSize.SelectedItem

            My.Settings.Save()

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


End Class