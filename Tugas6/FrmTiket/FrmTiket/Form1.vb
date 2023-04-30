Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If radDewasa.Checked = True Then
            txtHarga.Text = "20000"
        ElseIf radAnak.Checked = True Then
            txtHarga.Text = "10000"
        Else
            MessageBox.Show("Klik Pilihan Tiket")
        End If
    End Sub
End Class
