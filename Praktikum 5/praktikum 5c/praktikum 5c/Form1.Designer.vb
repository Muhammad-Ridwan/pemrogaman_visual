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
        Me.txtKodeMakanan = New System.Windows.Forms.TextBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Makanan"
        '
        'txtKodeMakanan
        '
        Me.txtKodeMakanan.Location = New System.Drawing.Point(15, 68)
        Me.txtKodeMakanan.Name = "txtKodeMakanan"
        Me.txtKodeMakanan.Size = New System.Drawing.Size(122, 22)
        Me.txtKodeMakanan.TabIndex = 1
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(15, 128)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(238, 22)
        Me.txtKeterangan.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Keterangan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Muhammad Ridwan"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(153, 65)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(80, 28)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(352, 219)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodeMakanan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kode Makanan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtKodeMakanan As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSubmit As Button
End Class
