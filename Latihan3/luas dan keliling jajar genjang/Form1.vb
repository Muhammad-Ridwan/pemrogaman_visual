Public Class Form1
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim alas, tinggi, nilai_a, nilai_b, luas, keliling As Integer

        alas = Val(txtAlas.Text)
        tinggi = Val(txtTinggi.Text)
        nilai_a = Val(txtNilaia.Text)
        nilai_b = Val(txtNilaib.Text)

        luas = alas * tinggi
        keliling = 1 / 2 * (nilai_a + nilai_b)

        TxtLuas.Text = Str(luas)
        TxtKeliling.Text = Str(keliling)

    End Sub
End Class
