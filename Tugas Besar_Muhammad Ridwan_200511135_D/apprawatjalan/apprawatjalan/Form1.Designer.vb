<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPasienBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuRawatJalanBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.RawatjalanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDokterBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDokterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Firebrick
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuPasienBar, Me.MenuRawatJalanBar, Me.MenuDokterBar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(845, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginBar, Me.LogoutBar, Me.ExitBar})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginBar
        '
        Me.LoginBar.Name = "LoginBar"
        Me.LoginBar.Size = New System.Drawing.Size(131, 26)
        Me.LoginBar.Text = "Login"
        '
        'LogoutBar
        '
        Me.LogoutBar.Name = "LogoutBar"
        Me.LogoutBar.Size = New System.Drawing.Size(131, 26)
        Me.LogoutBar.Text = "Logout"
        '
        'ExitBar
        '
        Me.ExitBar.Name = "ExitBar"
        Me.ExitBar.Size = New System.Drawing.Size(131, 26)
        Me.ExitBar.Text = "Exit"
        '
        'MenuPasienBar
        '
        Me.MenuPasienBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PasienToolStripMenuItem})
        Me.MenuPasienBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuPasienBar.Name = "MenuPasienBar"
        Me.MenuPasienBar.Size = New System.Drawing.Size(103, 24)
        Me.MenuPasienBar.Text = "Menu Pasien"
        '
        'PasienToolStripMenuItem
        '
        Me.PasienToolStripMenuItem.Name = "PasienToolStripMenuItem"
        Me.PasienToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.PasienToolStripMenuItem.Text = "Data Pasien"
        '
        'MenuRawatJalanBar
        '
        Me.MenuRawatJalanBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RawatjalanToolStripMenuItem})
        Me.MenuRawatJalanBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuRawatJalanBar.Name = "MenuRawatJalanBar"
        Me.MenuRawatJalanBar.Size = New System.Drawing.Size(140, 24)
        Me.MenuRawatJalanBar.Text = "Menu Rawat Jalan"
        '
        'RawatjalanToolStripMenuItem
        '
        Me.RawatjalanToolStripMenuItem.Name = "RawatjalanToolStripMenuItem"
        Me.RawatjalanToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.RawatjalanToolStripMenuItem.Text = "Data Rawat Jalan"
        '
        'MenuDokterBar
        '
        Me.MenuDokterBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataDokterToolStripMenuItem})
        Me.MenuDokterBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuDokterBar.Name = "MenuDokterBar"
        Me.MenuDokterBar.Size = New System.Drawing.Size(107, 24)
        Me.MenuDokterBar.Text = "Menu Dokter"
        '
        'DataDokterToolStripMenuItem
        '
        Me.DataDokterToolStripMenuItem.Name = "DataDokterToolStripMenuItem"
        Me.DataDokterToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.DataDokterToolStripMenuItem.Text = "Data Dokter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(251, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 58)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DASHBOARD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MistyRose
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Muhammad Ridwan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MistyRose
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(324, 490)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "200511135 / D"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImage = Global.apprawatjalan.My.Resources.Resources.rawat_inap
        Me.ClientSize = New System.Drawing.Size(845, 576)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginBar As ToolStripMenuItem
    Friend WithEvents LogoutBar As ToolStripMenuItem
    Friend WithEvents ExitBar As ToolStripMenuItem
    Friend WithEvents MenuPasienBar As ToolStripMenuItem
    Friend WithEvents MenuRawatJalanBar As ToolStripMenuItem
    Friend WithEvents RawatjalanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuDokterBar As ToolStripMenuItem
    Friend WithEvents DataDokterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
