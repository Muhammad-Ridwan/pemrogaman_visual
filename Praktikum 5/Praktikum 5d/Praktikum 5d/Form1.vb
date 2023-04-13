Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodePlat.Text
            Case "E" : txtKeterangan.Text = "Cirebon"

            Case "D" : txtKeterangan.Text = "Bandung"

            Case "F" : txtKeterangan.Text = "Bogor"

            Case "B" : txtKeterangan.Text = "Jakarta"

            Case Else : txtKeterangan.Text = "Data Belum di Masukan"
        End Select
    End Sub
End Class