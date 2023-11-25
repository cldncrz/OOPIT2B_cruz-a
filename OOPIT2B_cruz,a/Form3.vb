Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentinfo.ReportSource = student1
        studentinfo.Refresh()
    End Sub
End Class