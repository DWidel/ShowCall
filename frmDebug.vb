Public Class frmDebug
    Private Sub frmDebug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.phone_grey

        If gLastException IsNot Nothing Then
            lblException.Text = "Last connection exception occurred at: " & Format(gLastExceptionDT, "yyyy-MM-dd HH:mm:ss") & vbCrLf
            lblException.Text &= gLastException.ToString
        End If

    End Sub
End Class