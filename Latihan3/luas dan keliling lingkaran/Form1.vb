Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari_jari, luas, keliling As Integer

        jari_jari = Val(txtJari_jari.Text)

        luas = 3.14 * jari_jari * jari_jari
        keliling = 2 * 3.14 * jari_jari

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
