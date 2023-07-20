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
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtProdi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSKS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeMK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(413, 116)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 28)
        Me.btnHapus.TabIndex = 45
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(413, 44)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 28)
        Me.btnSimpan.TabIndex = 44
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(413, 80)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 43
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtProdi
        '
        Me.txtProdi.Location = New System.Drawing.Point(120, 144)
        Me.txtProdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProdi.Name = "txtProdi"
        Me.txtProdi.Size = New System.Drawing.Size(132, 22)
        Me.txtProdi.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Prodi"
        '
        'txtSKS
        '
        Me.txtSKS.Location = New System.Drawing.Point(120, 112)
        Me.txtSKS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSKS.Name = "txtSKS"
        Me.txtSKS.Size = New System.Drawing.Size(132, 22)
        Me.txtSKS.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "SKS"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(120, 80)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(132, 22)
        Me.txtNama.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Nama MK"
        '
        'txtKodeMK
        '
        Me.txtKodeMK.Location = New System.Drawing.Point(120, 48)
        Me.txtKodeMK.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKodeMK.Name = "txtKodeMK"
        Me.txtKodeMK.Size = New System.Drawing.Size(132, 22)
        Me.txtKodeMK.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "KodeMK"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 185)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(508, 187)
        Me.DataGridView1.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 376)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 18)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Muhammad Ridwan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(228, 376)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "200511135"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(374, 376)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "20 TIF D"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(577, 426)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtProdi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSKS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodeMK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSKS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKodeMK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
