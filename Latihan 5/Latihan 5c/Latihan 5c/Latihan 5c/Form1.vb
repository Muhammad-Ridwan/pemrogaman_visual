Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeJabatan.Text
            Case "MGR" : txtKeterangan.Text = "Manager"

            Case "SKR" : txtKeterangan.Text = "Sekretaris"

            Case "BDH" : txtKeterangan.Text = "Bendahara"

            Case Else : txtKeterangan.Text = "Staff"
        End Select
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
