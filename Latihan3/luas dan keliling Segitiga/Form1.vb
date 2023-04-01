Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim alas, tinggi, sisi_a, sisi_b, sisi_c, luas, keliling As Integer

        alas = Val(txtAlas.Text)
        tinggi = Val(txtTinggi.Text)
        sisi_a = Val(txtSisia.Text)
        sisi_b = Val(txtSisib.Text)
        sisi_c = Val(txtSisic.Text)

        luas = 1 / 2 * alas * tinggi
        keliling = sisi_a + sisi_b + sisi_c

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub
End Class
