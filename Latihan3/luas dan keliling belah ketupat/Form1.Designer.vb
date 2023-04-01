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
        Me.txtSisi = New System.Windows.Forms.TextBox()
        Me.txtDiagonal1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiagonal2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKeliling = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sisi"
        '
        'txtSisi
        '
        Me.txtSisi.Location = New System.Drawing.Point(139, 32)
        Me.txtSisi.Name = "txtSisi"
        Me.txtSisi.Size = New System.Drawing.Size(100, 22)
        Me.txtSisi.TabIndex = 1
        '
        'txtDiagonal1
        '
        Me.txtDiagonal1.Location = New System.Drawing.Point(139, 73)
        Me.txtDiagonal1.Name = "txtDiagonal1"
        Me.txtDiagonal1.Size = New System.Drawing.Size(100, 22)
        Me.txtDiagonal1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Diagonal 1"
        '
        'txtDiagonal2
        '
        Me.txtDiagonal2.Location = New System.Drawing.Point(139, 112)
        Me.txtDiagonal2.Name = "txtDiagonal2"
        Me.txtDiagonal2.Size = New System.Drawing.Size(100, 22)
        Me.txtDiagonal2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Diagonal 2"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(139, 156)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(100, 34)
        Me.btnHitung.TabIndex = 6
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtLuas
        '
        Me.txtLuas.Location = New System.Drawing.Point(139, 207)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(100, 22)
        Me.txtLuas.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Luas"
        '
        'txtKeliling
        '
        Me.txtKeliling.Location = New System.Drawing.Point(139, 245)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(100, 22)
        Me.txtKeliling.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Keliling"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(470, 402)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtDiagonal2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDiagonal1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSisi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSisi As TextBox
    Friend WithEvents txtDiagonal1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiagonal2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Label5 As Label
End Class
