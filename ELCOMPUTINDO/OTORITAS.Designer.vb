<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OTORITAS
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
        Me.txtnamauser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.c_category = New System.Windows.Forms.CheckBox()
        Me.c_partner = New System.Windows.Forms.CheckBox()
        Me.c_account = New System.Windows.Forms.CheckBox()
        Me.c_user = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.c_stock = New System.Windows.Forms.CheckBox()
        Me.c_barang = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Setting Otoritas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnamauser)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 47)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtnamauser
        '
        Me.txtnamauser.AutoSize = True
        Me.txtnamauser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamauser.Location = New System.Drawing.Point(118, 16)
        Me.txtnamauser.Name = "txtnamauser"
        Me.txtnamauser.Size = New System.Drawing.Size(11, 13)
        Me.txtnamauser.TabIndex = 3
        Me.txtnamauser.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama User"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.c_stock)
        Me.GroupBox2.Controls.Add(Me.c_barang)
        Me.GroupBox2.Controls.Add(Me.c_category)
        Me.GroupBox2.Controls.Add(Me.c_partner)
        Me.GroupBox2.Controls.Add(Me.c_account)
        Me.GroupBox2.Controls.Add(Me.c_user)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 310)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'c_category
        '
        Me.c_category.AutoSize = True
        Me.c_category.Location = New System.Drawing.Point(9, 88)
        Me.c_category.Name = "c_category"
        Me.c_category.Size = New System.Drawing.Size(110, 17)
        Me.c_category.TabIndex = 8
        Me.c_category.Text = "Kelompok Barang"
        Me.c_category.UseVisualStyleBackColor = True
        '
        'c_partner
        '
        Me.c_partner.AutoSize = True
        Me.c_partner.Location = New System.Drawing.Point(9, 65)
        Me.c_partner.Name = "c_partner"
        Me.c_partner.Size = New System.Drawing.Size(59, 17)
        Me.c_partner.TabIndex = 7
        Me.c_partner.Text = "partner"
        Me.c_partner.UseVisualStyleBackColor = True
        '
        'c_account
        '
        Me.c_account.AutoSize = True
        Me.c_account.Location = New System.Drawing.Point(9, 42)
        Me.c_account.Name = "c_account"
        Me.c_account.Size = New System.Drawing.Size(65, 17)
        Me.c_account.TabIndex = 6
        Me.c_account.Text = "account"
        Me.c_account.UseVisualStyleBackColor = True
        '
        'c_user
        '
        Me.c_user.AutoSize = True
        Me.c_user.Location = New System.Drawing.Point(9, 19)
        Me.c_user.Name = "c_user"
        Me.c_user.Size = New System.Drawing.Size(46, 17)
        Me.c_user.TabIndex = 5
        Me.c_user.Text = "user"
        Me.c_user.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(913, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(832, 553)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'c_stock
        '
        Me.c_stock.AutoSize = True
        Me.c_stock.Location = New System.Drawing.Point(9, 134)
        Me.c_stock.Name = "c_stock"
        Me.c_stock.Size = New System.Drawing.Size(91, 17)
        Me.c_stock.TabIndex = 10
        Me.c_stock.Text = "Stock Barang"
        Me.c_stock.UseVisualStyleBackColor = True
        '
        'c_barang
        '
        Me.c_barang.AutoSize = True
        Me.c_barang.Location = New System.Drawing.Point(9, 111)
        Me.c_barang.Name = "c_barang"
        Me.c_barang.Size = New System.Drawing.Size(87, 17)
        Me.c_barang.TabIndex = 9
        Me.c_barang.Text = "Input Barang"
        Me.c_barang.UseVisualStyleBackColor = True
        '
        'OTORITAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 588)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OTORITAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OTORITAS"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnamauser As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents c_user As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents c_account As System.Windows.Forms.CheckBox
    Friend WithEvents c_partner As System.Windows.Forms.CheckBox
    Friend WithEvents c_category As System.Windows.Forms.CheckBox
    Friend WithEvents c_stock As System.Windows.Forms.CheckBox
    Friend WithEvents c_barang As System.Windows.Forms.CheckBox
End Class
