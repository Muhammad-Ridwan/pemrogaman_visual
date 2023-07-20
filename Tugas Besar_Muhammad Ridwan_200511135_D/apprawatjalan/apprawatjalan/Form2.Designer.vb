<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtJk = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNrp = New System.Windows.Forms.TextBox()
        Me.txtTanggal = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(95, 495)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 245)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Kota"
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(131, 236)
        Me.txtKota.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(171, 22)
        Me.txtKota.TabIndex = 98
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 213)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(131, 204)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(171, 22)
        Me.txtAlamat.TabIndex = 96
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(370, 149)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 28)
        Me.btnDelete.TabIndex = 95
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(370, 113)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 94
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(370, 78)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 28)
        Me.btnSubmit.TabIndex = 93
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 181)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Nama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 79)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 17)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "NRP"
        '
        'txtJk
        '
        Me.txtJk.Location = New System.Drawing.Point(131, 140)
        Me.txtJk.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJk.Name = "txtJk"
        Me.txtJk.Size = New System.Drawing.Size(171, 22)
        Me.txtJk.TabIndex = 88
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(131, 108)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(171, 22)
        Me.txtNama.TabIndex = 87
        '
        'txtNrp
        '
        Me.txtNrp.Location = New System.Drawing.Point(131, 76)
        Me.txtNrp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNrp.Name = "txtNrp"
        Me.txtNrp.Size = New System.Drawing.Size(171, 22)
        Me.txtNrp.TabIndex = 86
        '
        'txtTanggal
        '
        Me.txtTanggal.Location = New System.Drawing.Point(131, 172)
        Me.txtTanggal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(171, 22)
        Me.txtTanggal.TabIndex = 85
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(14, 276)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(516, 215)
        Me.dgvData.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Footlight MT Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Data Pasien"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(222, 525)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "200511135"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(201, 508)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 17)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Muhammad Ridwan"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(544, 564)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtJk)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNrp)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKota As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtJk As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNrp As TextBox
    Friend WithEvents txtTanggal As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
