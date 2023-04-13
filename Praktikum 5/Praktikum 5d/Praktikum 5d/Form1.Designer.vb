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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodePlat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(170, 67)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(80, 28)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Muhammad Ridwan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(12, 133)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(238, 22)
        Me.txtKeterangan.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Keterangan"
        '
        'txtKodePlat
        '
        Me.txtKodePlat.Location = New System.Drawing.Point(12, 73)
        Me.txtKodePlat.Name = "txtKodePlat"
        Me.txtKodePlat.Size = New System.Drawing.Size(140, 22)
        Me.txtKodePlat.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kode Plat Kendaraan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(339, 255)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodePlat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Plat Kendaraan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKodePlat As TextBox
    Friend WithEvents Label1 As Label
End Class
