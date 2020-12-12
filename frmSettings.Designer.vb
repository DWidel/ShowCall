<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.txtCallAttendantURL = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboMessageLocation = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTimerInterval = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboDisplayTime = New System.Windows.Forms.ComboBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.cboFontSize = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCallAttendantURL
        '
        Me.txtCallAttendantURL.Location = New System.Drawing.Point(168, 12)
        Me.txtCallAttendantURL.Name = "txtCallAttendantURL"
        Me.txtCallAttendantURL.Size = New System.Drawing.Size(387, 20)
        Me.txtCallAttendantURL.TabIndex = 7
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(57, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(98, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Call Attendant URL"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(500, 372)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboMessageLocation
        '
        Me.cboMessageLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMessageLocation.FormattingEnabled = True
        Me.cboMessageLocation.Items.AddRange(New Object() {"Lower Right", "Lower Left", "Upper Left", "Upper Right", "Center"})
        Me.cboMessageLocation.Location = New System.Drawing.Point(168, 90)
        Me.cboMessageLocation.Name = "cboMessageLocation"
        Me.cboMessageLocation.Size = New System.Drawing.Size(189, 21)
        Me.cboMessageLocation.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Notification Screen Location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Page Download Interval (ms)"
        '
        'cboTimerInterval
        '
        Me.cboTimerInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTimerInterval.FormattingEnabled = True
        Me.cboTimerInterval.Location = New System.Drawing.Point(168, 38)
        Me.cboTimerInterval.Name = "cboTimerInterval"
        Me.cboTimerInterval.Size = New System.Drawing.Size(98, 21)
        Me.cboTimerInterval.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Notification Display Time (secs)"
        '
        'cboDisplayTime
        '
        Me.cboDisplayTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDisplayTime.FormattingEnabled = True
        Me.cboDisplayTime.Location = New System.Drawing.Point(168, 117)
        Me.cboDisplayTime.Name = "cboDisplayTime"
        Me.cboDisplayTime.Size = New System.Drawing.Size(98, 21)
        Me.cboDisplayTime.TabIndex = 12
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(3, 395)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(48, 13)
        Me.lblVersion.TabIndex = 15
        Me.lblVersion.Text = "vers. 0.3"
        '
        'cboFontSize
        '
        Me.cboFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFontSize.FormattingEnabled = True
        Me.cboFontSize.Location = New System.Drawing.Point(168, 144)
        Me.cboFontSize.Name = "cboFontSize"
        Me.cboFontSize.Size = New System.Drawing.Size(98, 21)
        Me.cboFontSize.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Notification Font Size"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 407)
        Me.Controls.Add(Me.cboFontSize)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.cboDisplayTime)
        Me.Controls.Add(Me.cboTimerInterval)
        Me.Controls.Add(Me.cboMessageLocation)
        Me.Controls.Add(Me.txtCallAttendantURL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtCallAttendantURL As TextBox
    Private WithEvents label1 As Label
    Private WithEvents btnSave As Button
    Private WithEvents cboMessageLocation As ComboBox
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents cboTimerInterval As ComboBox
    Private WithEvents Label4 As Label
    Private WithEvents cboDisplayTime As ComboBox
    Private WithEvents lblVersion As Label
    Private WithEvents cboFontSize As ComboBox
    Private WithEvents Label6 As Label
End Class
