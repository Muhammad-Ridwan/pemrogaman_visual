Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeMakanan.Text
            Case "NG" : txtKeterangan.Text = "Nasi Goreng"

            Case "MG" : txtKeterangan.Text = "Mie Goreng"

            Case "NP" : txtKeterangan.Text = "Nasi Padang"

            Case Else : txtKeterangan.Text = "Tidak Dikenali"
        End Select
    End Sub
End Class