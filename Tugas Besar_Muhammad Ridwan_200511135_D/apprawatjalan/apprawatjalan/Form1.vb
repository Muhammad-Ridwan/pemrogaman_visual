Public Class Form1
    Private Sub PasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasienToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub RawatjalanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RawatjalanToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub DataDokterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDokterToolStripMenuItem.Click
        Form4.ShowDialog()
    End Sub


    Private Sub MatikanSemuaMenu()
        MenuPasienBar.Visible = False
        MenuRawatJalanBar.Visible = False
        MenuDokterBar.Visible = False
        LoginBar.Visible = True
        LogoutBar.Visible = False
    End Sub

    Private Sub LoginBar_Click(sender As Object, e As EventArgs) Handles LoginBar.Click
        LoginForm.ShowDialog()

    End Sub

    Private Sub LogoutBar_Click(sender As Object, e As EventArgs) Handles LogoutBar.Click
        MatikanSemuaMenu()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Jika user login adalah pasien
        If (pasien_role = True) Then
            MenuPasienBar.Visible = True
            MenuRawatJalanBar.Visible = False
            MenuDokterBar.Visible = False
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

        'Jika user login adalah rawatjalan
        If (rawatjalan_role = True) Then
            MenuPasienBar.Visible = False
            MenuRawatJalanBar.Visible = True
            MenuDokterBar.Visible = False
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If

        'Jika user login adalah dokter
        If (dokter_role = True) Then
            MenuPasienBar.Visible = False
            MenuRawatJalanBar.Visible = False
            MenuDokterBar.Visible = True
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If
    End Sub

    Private Sub ExitBar_Click(sender As Object, e As EventArgs) Handles ExitBar.Click
        End
    End Sub
End Class
