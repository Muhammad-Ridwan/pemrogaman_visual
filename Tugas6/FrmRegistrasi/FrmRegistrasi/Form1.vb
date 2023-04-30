Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbProdi.Items.Clear()
        CmbProdi.Items.Add("Teknik Informatika (S1)")
        CmbProdi.Items.Add("Teknik Industri (S1)")
        CmbProdi.Items.Add("Teknik Peternakan (S1)")
    End Sub

    Private Sub CmbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProdi.SelectedIndexChanged
        If CmbProdi.Text = "Teknik Informatika (S1)" Then
            txtRegistrasi.Text = "2000000"
            txtSpp.Text = "2400000"
            txtJas.Text = "150000"
            txtTotal.Clear()
        ElseIf CmbProdi.Text = "Teknik Industri (S1)" Then
            txtRegistrasi.Text = "2000000"
            txtSpp.Text = "2700000"
            txtJas.Text = "150000"
            txtTotal.Clear()
        ElseIf CmbProdi.Text = "Teknik Peternakan (S1)" Then
            txtRegistrasi.Text = "2000000"
            txtSpp.Text = "2000000"
            txtJas.Text = "150000"
            txtTotal.Clear()
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        txtTotal.Text = Val(txtRegistrasi.Text) + Val(txtSpp.Text) + Val(txtJas.Text)
    End Sub
End Class
