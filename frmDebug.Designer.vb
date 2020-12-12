<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebug
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblException = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblException
        '
        Me.lblException.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblException.Location = New System.Drawing.Point(12, 28)
        Me.lblException.Name = "lblException"
        Me.lblException.Size = New System.Drawing.Size(776, 174)
        Me.lblException.TabIndex = 15
        Me.lblException.Text = "No Exceptions Thrown"
        '
        'frmDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblException)
        Me.Name = "frmDebug"
        Me.Text = "Debug Info"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblException As Label
End Class
