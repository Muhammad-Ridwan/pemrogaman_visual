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
        Me.radDewasa = New System.Windows.Forms.RadioButton()
        Me.radAnak = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tiket Masuk Wisata"
        '
        'radDewasa
        '
        Me.radDewasa.AutoSize = True
        Me.radDewasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDewasa.Location = New System.Drawing.Point(27, 85)
        Me.radDewasa.Name = "radDewasa"
        Me.radDewasa.Size = New System.Drawing.Size(85, 21)
        Me.radDewasa.TabIndex = 1
        Me.radDewasa.TabStop = True
        Me.radDewasa.Text = "Dewasa"
        Me.radDewasa.UseVisualStyleBackColor = True
        '
        'radAnak
        '
        Me.radAnak.AutoSize = True
        Me.radAnak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAnak.Location = New System.Drawing.Point(27, 121)
        Me.radAnak.Name = "radAnak"
        Me.radAnak.Size = New System.Drawing.Size(107, 21)
        Me.radAnak.TabIndex = 2
        Me.radAnak.TabStop = True
        Me.radAnak.Text = "Anak-Anak"
        Me.radAnak.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(27, 166)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(85, 26)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(82, 217)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(155, 22)
        Me.txtHarga.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Harga"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(382, 316)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.radAnak)
        Me.Controls.Add(Me.radDewasa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "RadioButton"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents radDewasa As RadioButton
    Friend WithEvents radAnak As RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label2 As Label
End Class
