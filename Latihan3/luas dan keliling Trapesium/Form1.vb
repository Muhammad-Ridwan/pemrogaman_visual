Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim tinggi, alas_a, alas_b, alas_c, alas_d, luas, keliling As Integer

        tinggi = Val(txtTinggi.Text)
        alas_a = Val(txtAlasa.Text)
        alas_b = Val(txtAlasb.Text)
        alas_c = Val(txtAlasc.Text)
        alas_d = Val(txtAlasd.Text)

        luas = 1 / 2 * (alas_a + alas_b) * tinggi
        keliling = alas_a + alas_b + alas_c + alas_d

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub
End Class
