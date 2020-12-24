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
        Me.components = New System.ComponentModel.Container()
        Me.lblException = New System.Windows.Forms.Label()
        Me.btnClearLog = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOpenLog = New System.Windows.Forms.Button()
        Me.lblLogFile = New System.Windows.Forms.Label()
        Me.btnOpenFolder = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
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
        'btnClearLog
        '
        Me.btnClearLog.Location = New System.Drawing.Point(35, 66)
        Me.btnClearLog.Name = "btnClearLog"
        Me.btnClearLog.Size = New System.Drawing.Size(75, 23)
        Me.btnClearLog.TabIndex = 16
        Me.btnClearLog.Text = "Clear Log"
        Me.btnClearLog.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnOpenFolder)
        Me.GroupBox1.Controls.Add(Me.lblLogFile)
        Me.GroupBox1.Controls.Add(Me.btnOpenLog)
        Me.GroupBox1.Controls.Add(Me.btnClearLog)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 322)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 116)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Debug Log"
        '
        'btnOpenLog
        '
        Me.btnOpenLog.Location = New System.Drawing.Point(131, 66)
        Me.btnOpenLog.Name = "btnOpenLog"
        Me.btnOpenLog.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenLog.TabIndex = 17
        Me.btnOpenLog.Text = "Open Log"
        Me.btnOpenLog.UseVisualStyleBackColor = True
        '
        'lblLogFile
        '
        Me.lblLogFile.AutoSize = True
        Me.lblLogFile.Location = New System.Drawing.Point(16, 16)
        Me.lblLogFile.Name = "lblLogFile"
        Me.lblLogFile.Size = New System.Drawing.Size(41, 13)
        Me.lblLogFile.TabIndex = 18
        Me.lblLogFile.Text = "LogFile"
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Location = New System.Drawing.Point(231, 66)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenFolder.TabIndex = 19
        Me.btnOpenFolder.Text = "Open Folder"
        Me.btnOpenFolder.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblException)
        Me.Name = "frmDebug"
        Me.Text = "Debug Info"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblException As Label
    Friend WithEvents btnClearLog As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnOpenLog As Button
    Friend WithEvents lblLogFile As Label
    Friend WithEvents btnOpenFolder As Button
    Friend WithEvents Timer1 As Timer
End Class
