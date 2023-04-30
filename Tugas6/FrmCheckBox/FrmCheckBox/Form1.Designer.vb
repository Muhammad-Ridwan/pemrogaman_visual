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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Chb4jam = New System.Windows.Forms.CheckBox()
        Me.Chb3jam = New System.Windows.Forms.CheckBox()
        Me.Chb2jam = New System.Windows.Forms.CheckBox()
        Me.Chb1jam = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChbBukan = New System.Windows.Forms.CheckBox()
        Me.ChbMember = New System.Windows.Forms.CheckBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RID Futsal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Chb4jam)
        Me.GroupBox1.Controls.Add(Me.Chb3jam)
        Me.GroupBox1.Controls.Add(Me.Chb2jam)
        Me.GroupBox1.Controls.Add(Me.Chb1jam)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 158)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bermain"
        '
        'Chb4jam
        '
        Me.Chb4jam.AutoSize = True
        Me.Chb4jam.Location = New System.Drawing.Point(6, 118)
        Me.Chb4jam.Name = "Chb4jam"
        Me.Chb4jam.Size = New System.Drawing.Size(73, 21)
        Me.Chb4jam.TabIndex = 4
        Me.Chb4jam.Text = "4 Jam"
        Me.Chb4jam.UseVisualStyleBackColor = True
        '
        'Chb3jam
        '
        Me.Chb3jam.AutoSize = True
        Me.Chb3jam.Location = New System.Drawing.Point(6, 91)
        Me.Chb3jam.Name = "Chb3jam"
        Me.Chb3jam.Size = New System.Drawing.Size(73, 21)
        Me.Chb3jam.TabIndex = 4
        Me.Chb3jam.Text = "3 Jam"
        Me.Chb3jam.UseVisualStyleBackColor = True
        '
        'Chb2jam
        '
        Me.Chb2jam.AutoSize = True
        Me.Chb2jam.Location = New System.Drawing.Point(6, 64)
        Me.Chb2jam.Name = "Chb2jam"
        Me.Chb2jam.Size = New System.Drawing.Size(73, 21)
        Me.Chb2jam.TabIndex = 4
        Me.Chb2jam.Text = "2 Jam"
        Me.Chb2jam.UseVisualStyleBackColor = True
        '
        'Chb1jam
        '
        Me.Chb1jam.AutoSize = True
        Me.Chb1jam.Location = New System.Drawing.Point(6, 37)
        Me.Chb1jam.Name = "Chb1jam"
        Me.Chb1jam.Size = New System.Drawing.Size(73, 21)
        Me.Chb1jam.TabIndex = 3
        Me.Chb1jam.Text = "1 Jam"
        Me.Chb1jam.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChbBukan)
        Me.GroupBox2.Controls.Add(Me.ChbMember)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(205, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 112)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Member"
        '
        'ChbBukan
        '
        Me.ChbBukan.AutoSize = True
        Me.ChbBukan.Location = New System.Drawing.Point(6, 64)
        Me.ChbBukan.Name = "ChbBukan"
        Me.ChbBukan.Size = New System.Drawing.Size(75, 21)
        Me.ChbBukan.TabIndex = 6
        Me.ChbBukan.Text = "Bukan"
        Me.ChbBukan.UseVisualStyleBackColor = True
        '
        'ChbMember
        '
        Me.ChbMember.AutoSize = True
        Me.ChbMember.Location = New System.Drawing.Point(6, 37)
        Me.ChbMember.Name = "ChbMember"
        Me.ChbMember.Size = New System.Drawing.Size(87, 21)
        Me.ChbMember.TabIndex = 5
        Me.ChbMember.Text = "Member"
        Me.ChbMember.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(205, 219)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(87, 27)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(252, 263)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(146, 22)
        Me.txtTotal.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(430, 391)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "CheckBox"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Chb4jam As CheckBox
    Friend WithEvents Chb3jam As CheckBox
    Friend WithEvents Chb2jam As CheckBox
    Friend WithEvents Chb1jam As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChbBukan As CheckBox
    Friend WithEvents ChbMember As CheckBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotal As TextBox
End Class
