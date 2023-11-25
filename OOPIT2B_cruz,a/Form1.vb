Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase()
        txtfirst.Enabled = False
        txtlast.Enabled = False
        txtstudcourse.Enabled = False
        btnupdate.Enabled = False
        btnupdate.Enabled = False
        btnprnt.Enabled = False
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        SaveRecord()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        SearchData()
    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim ans As DialogResult = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            UpdateRecord(txtuserid.Text, txtfirst.Text, txtlast.Text, txtCourse.Text)
            MsgBox("Update Successfull!")
        Else
            MsgBox("Update cancelled!")
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim ans As DialogResult = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            DeleteRecord(txtuserid.Text)
            MsgBox("Deletion Successfull!")
        Else
            MsgBox("Deletion cancelled!")
        End If
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Form3.Show()
    End Sub

    Private Sub btnprnt_Click(sender As Object, e As EventArgs) Handles btnprnt.Click
        Form4.Show()
    End Sub
End Class
