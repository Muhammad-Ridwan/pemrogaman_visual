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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlas = New System.Windows.Forms.TextBox()
        Me.txtTinggi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNilaia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNilaib = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.TxtLuas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtKeliling = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alas"
        '
        'txtAlas
        '
        Me.txtAlas.Location = New System.Drawing.Point(103, 35)
        Me.txtAlas.Name = "txtAlas"
        Me.txtAlas.Size = New System.Drawing.Size(100, 22)
        Me.txtAlas.TabIndex = 1
        '
        'txtTinggi
        '
        Me.txtTinggi.Location = New System.Drawing.Point(103, 72)
        Me.txtTinggi.Name = "txtTinggi"
        Me.txtTinggi.Size = New System.Drawing.Size(100, 22)
        Me.txtTinggi.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tinggi"
        '
        'txtNilaia
        '
        Me.txtNilaia.Location = New System.Drawing.Point(103, 110)
        Me.txtNilaia.Name = "txtNilaia"
        Me.txtNilaia.Size = New System.Drawing.Size(100, 22)
        Me.txtNilaia.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nilai a"
        '
        'txtNilaib
        '
        Me.txtNilaib.Location = New System.Drawing.Point(103, 151)
        Me.txtNilaib.Name = "txtNilaib"
        Me.txtNilaib.Size = New System.Drawing.Size(100, 22)
        Me.txtNilaib.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nilai b"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(100, 191)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(100, 34)
        Me.btnHitung.TabIndex = 8
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'TxtLuas
        '
        Me.TxtLuas.Location = New System.Drawing.Point(103, 239)
        Me.TxtLuas.Name = "TxtLuas"
        Me.TxtLuas.Size = New System.Drawing.Size(100, 22)
        Me.TxtLuas.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Luas"
        '
        'TxtKeliling
        '
        Me.TxtKeliling.Location = New System.Drawing.Point(103, 278)
        Me.TxtKeliling.Name = "TxtKeliling"
        Me.TxtKeliling.Size = New System.Drawing.Size(100, 22)
        Me.TxtKeliling.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Keliling"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(409, 355)
        Me.Controls.Add(Me.TxtKeliling)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtLuas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtNilaib)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNilaia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTinggi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAlas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAlas As TextBox
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNilaia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNilaib As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents TxtLuas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtKeliling As TextBox
    Friend WithEvents Label6 As Label
End Class
