<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cbocourse = New System.Windows.Forms.ComboBox()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbocourse
        '
        Me.cbocourse.FormattingEnabled = True
        Me.cbocourse.Location = New System.Drawing.Point(47, 32)
        Me.cbocourse.Name = "cbocourse"
        Me.cbocourse.Size = New System.Drawing.Size(121, 21)
        Me.cbocourse.TabIndex = 0
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(212, 30)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(75, 23)
        Me.btndisplay.TabIndex = 1
        Me.btndisplay.Text = "Display"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'btnhome
        '
        Me.btnhome.Location = New System.Drawing.Point(212, 266)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(75, 23)
        Me.btnhome.TabIndex = 2
        Me.btnhome.Text = "Back"
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'dgvdata
        '
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Location = New System.Drawing.Point(47, 85)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.Size = New System.Drawing.Size(240, 150)
        Me.dgvdata.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 332)
        Me.Controls.Add(Me.dgvdata)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.cbocourse)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbocourse As ComboBox
    Friend WithEvents btndisplay As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents dgvdata As DataGridView
End Class
