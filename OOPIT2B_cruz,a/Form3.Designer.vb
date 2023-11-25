<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.studentinfo = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.student1 = New OOPIT2B_cruz_a.student()
        Me.SuspendLayout()
        '
        'studentinfo
        '
        Me.studentinfo.ActiveViewIndex = -1
        Me.studentinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studentinfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.studentinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.studentinfo.Location = New System.Drawing.Point(0, 0)
        Me.studentinfo.Name = "studentinfo"
        Me.studentinfo.Size = New System.Drawing.Size(800, 450)
        Me.studentinfo.TabIndex = 0
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.studentinfo)
        Me.Name = "Form3"
        Me.Text = "studentinfo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents studentinfo As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents student1 As student
End Class
