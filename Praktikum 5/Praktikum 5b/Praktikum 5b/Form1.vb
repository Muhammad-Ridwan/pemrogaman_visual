Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtTinggiBadan.Text) >= 160) Then
            txtKeterangan.Text = "Anda Lulus Ke tahap Selanjutnya"
        Else
            txtKeterangan.Text = "Anda tidak Lulus, Silahkan Coba Lain waktu"
        End If
    End Sub
End Class
