<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberReport
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
        Me.rpvMemberReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rpvMemberReport
        '
        Me.rpvMemberReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.rpvMemberReport.Location = New System.Drawing.Point(0, 0)
        Me.rpvMemberReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rpvMemberReport.Name = "rpvMemberReport"
        Me.rpvMemberReport.ServerReport.BearerToken = Nothing
        Me.rpvMemberReport.Size = New System.Drawing.Size(909, 468)
        Me.rpvMemberReport.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(733, 497)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMemberReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 554)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.rpvMemberReport)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMemberReport"
        Me.Text = "Member Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpvMemberReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnClose As Button
End Class
