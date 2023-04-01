Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, diagonal_1, diagonal_2, luas, keliling As Integer

        sisi = Val(txtSisi.Text)
        diagonal_1 = Val(txtDiagonal1.Text)
        diagonal_2 = Val(txtDiagonal2.Text)

        luas = 1 / 2 * diagonal_1 * diagonal_2
        keliling = 4 * sisi

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub
End Class
