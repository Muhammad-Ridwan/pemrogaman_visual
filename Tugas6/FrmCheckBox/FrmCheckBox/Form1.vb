Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Const satujam As Integer = 60000
        Const duajam As Integer = 120000
        Const tigajam As Integer = 180000
        Const empatjam As Integer = 240000

        Dim sum As Integer

        If Chb1jam.Checked = True Then
            sum = sum + satujam
        End If
        If Chb2jam.Checked = True Then
            sum = sum + duajam
        End If
        If Chb3jam.Checked = True Then
            sum = sum + tigajam
        End If
        If Chb4jam.Checked = True Then
            sum = sum + empatjam
        End If
        If ChbMember.Checked = True Then
            sum = sum - (0.1 * sum)
        End If

        txtTotal.Text = sum
    End Sub
End Class
