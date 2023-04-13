Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtUsia.Text) <= 1) Then
            txtKeterangan.Text = "Anda Masuk Kelompok Umur Bayi"

        ElseIf (txtUsia.Text <= 5) Then
            txtKeterangan.Text = "Anda Masuk kelompok Umur Balita"

        ElseIf (txtUsia.Text <= 13) Then
            txtKeterangan.Text = "Anda Masuk kelompok Umur Anak-Anak"

        ElseIf (txtUsia.Text > 15) Then
            txtKeterangan.Text = "Anda Masuk Kelompok Umur Dewasa"

        Else
            txtKeterangan.Text = "Maaf Umur yang anda masukan Salah"
        End If
    End Sub
End Class
