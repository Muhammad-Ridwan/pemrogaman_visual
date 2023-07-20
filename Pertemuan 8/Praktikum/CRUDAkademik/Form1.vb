Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        oMahasiswa.getAllData(DataGridView1)
    End Sub
End Class
