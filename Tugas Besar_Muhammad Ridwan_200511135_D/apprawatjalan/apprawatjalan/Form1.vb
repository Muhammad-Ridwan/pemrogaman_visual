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
    End Sub


    Private Sub ExitBar_Click(sender As Object, e As EventArgs) Handles ExitBar.Click
        End
    End Sub
End Class
