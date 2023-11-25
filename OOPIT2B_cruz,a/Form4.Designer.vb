<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.idviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'idviewer
        '
        Me.idviewer.ActiveViewIndex = -1
        Me.idviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.idviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.idviewer.Location = New System.Drawing.Point(0, 0)
        Me.idviewer.Name = "idviewer"
        Me.idviewer.Size = New System.Drawing.Size(800, 450)
        Me.idviewer.TabIndex = 0
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.idviewer)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents idviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
