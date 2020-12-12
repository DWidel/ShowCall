<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNotification
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(3, 48)
        Me.lblDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(126, 46)
        Me.lblDisplay.TabIndex = 0
        Me.lblDisplay.Text = "Caller Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Phone Number"
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.Location = New System.Drawing.Point(3, 18)
        Me.lblAction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(60, 23)
        Me.lblAction.TabIndex = 2
        Me.lblAction.Text = "Action"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = Global.ShowCall.My.Resources.Resources.cancel
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(230, 3)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 38)
        Me.btnClose.TabIndex = 1
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(276, 173)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblDisplay)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmNotification"
        Me.Text = "Incoming Call"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblAction As Label
End Class
