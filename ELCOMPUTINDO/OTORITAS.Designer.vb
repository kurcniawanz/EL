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
        Me.c_koreksi = New System.Windows.Forms.CheckBox()
        Me.c_mutasi = New System.Windows.Forms.CheckBox()
        Me.c_stock = New System.Windows.Forms.CheckBox()
        Me.c_barang = New System.Windows.Forms.CheckBox()
        Me.c_category = New System.Windows.Forms.CheckBox()
        Me.c_jual = New System.Windows.Forms.CheckBox()
        Me.c_historibeli = New System.Windows.Forms.CheckBox()
        Me.c_rebeli = New System.Windows.Forms.CheckBox()
        Me.c_beli = New System.Windows.Forms.CheckBox()
        Me.c_partner = New System.Windows.Forms.CheckBox()
        Me.c_account = New System.Windows.Forms.CheckBox()
        Me.c_user = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.c_historijual = New System.Windows.Forms.CheckBox()
        Me.c_rejual = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.c_hutang = New System.Windows.Forms.CheckBox()
        Me.c_piutang = New System.Windows.Forms.CheckBox()
        Me.c_kas = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
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
        Me.GroupBox1.Size = New System.Drawing.Size(419, 47)
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
        Me.GroupBox2.Controls.Add(Me.c_koreksi)
        Me.GroupBox2.Controls.Add(Me.c_mutasi)
        Me.GroupBox2.Controls.Add(Me.c_stock)
        Me.GroupBox2.Controls.Add(Me.c_barang)
        Me.GroupBox2.Controls.Add(Me.c_category)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 147)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Barang"
        '
        'c_koreksi
        '
        Me.c_koreksi.AutoSize = True
        Me.c_koreksi.Location = New System.Drawing.Point(14, 88)
        Me.c_koreksi.Name = "c_koreksi"
        Me.c_koreksi.Size = New System.Drawing.Size(92, 17)
        Me.c_koreksi.TabIndex = 13
        Me.c_koreksi.Text = "Koreksi Stock"
        Me.c_koreksi.UseVisualStyleBackColor = True
        '
        'c_mutasi
        '
        Me.c_mutasi.AutoSize = True
        Me.c_mutasi.Location = New System.Drawing.Point(14, 111)
        Me.c_mutasi.Name = "c_mutasi"
        Me.c_mutasi.Size = New System.Drawing.Size(94, 17)
        Me.c_mutasi.TabIndex = 11
        Me.c_mutasi.Text = "Mutasi Barang"
        Me.c_mutasi.UseVisualStyleBackColor = True
        '
        'c_stock
        '
        Me.c_stock.AutoSize = True
        Me.c_stock.Location = New System.Drawing.Point(14, 65)
        Me.c_stock.Name = "c_stock"
        Me.c_stock.Size = New System.Drawing.Size(91, 17)
        Me.c_stock.TabIndex = 10
        Me.c_stock.Text = "Stock Barang"
        Me.c_stock.UseVisualStyleBackColor = True
        '
        'c_barang
        '
        Me.c_barang.AutoSize = True
        Me.c_barang.Location = New System.Drawing.Point(14, 42)
        Me.c_barang.Name = "c_barang"
        Me.c_barang.Size = New System.Drawing.Size(87, 17)
        Me.c_barang.TabIndex = 9
        Me.c_barang.Text = "Input Barang"
        Me.c_barang.UseVisualStyleBackColor = True
        '
        'c_category
        '
        Me.c_category.AutoSize = True
        Me.c_category.Location = New System.Drawing.Point(14, 19)
        Me.c_category.Name = "c_category"
        Me.c_category.Size = New System.Drawing.Size(110, 17)
        Me.c_category.TabIndex = 8
        Me.c_category.Text = "Kelompok Barang"
        Me.c_category.UseVisualStyleBackColor = True
        '
        'c_jual
        '
        Me.c_jual.AutoSize = True
        Me.c_jual.Location = New System.Drawing.Point(17, 19)
        Me.c_jual.Name = "c_jual"
        Me.c_jual.Size = New System.Drawing.Size(73, 17)
        Me.c_jual.TabIndex = 16
        Me.c_jual.Text = "Penjualan"
        Me.c_jual.UseVisualStyleBackColor = True
        '
        'c_historibeli
        '
        Me.c_historibeli.AutoSize = True
        Me.c_historibeli.Location = New System.Drawing.Point(17, 65)
        Me.c_historibeli.Name = "c_historibeli"
        Me.c_historibeli.Size = New System.Drawing.Size(110, 17)
        Me.c_historibeli.TabIndex = 15
        Me.c_historibeli.Text = "History Pembelian"
        Me.c_historibeli.UseVisualStyleBackColor = True
        '
        'c_rebeli
        '
        Me.c_rebeli.AutoSize = True
        Me.c_rebeli.Location = New System.Drawing.Point(17, 42)
        Me.c_rebeli.Name = "c_rebeli"
        Me.c_rebeli.Size = New System.Drawing.Size(104, 17)
        Me.c_rebeli.TabIndex = 14
        Me.c_rebeli.Text = "Retur Pembelian"
        Me.c_rebeli.UseVisualStyleBackColor = True
        '
        'c_beli
        '
        Me.c_beli.AutoSize = True
        Me.c_beli.Location = New System.Drawing.Point(17, 19)
        Me.c_beli.Name = "c_beli"
        Me.c_beli.Size = New System.Drawing.Size(75, 17)
        Me.c_beli.TabIndex = 12
        Me.c_beli.Text = "Pembelian"
        Me.c_beli.UseVisualStyleBackColor = True
        '
        'c_partner
        '
        Me.c_partner.AutoSize = True
        Me.c_partner.Location = New System.Drawing.Point(14, 42)
        Me.c_partner.Name = "c_partner"
        Me.c_partner.Size = New System.Drawing.Size(59, 17)
        Me.c_partner.TabIndex = 7
        Me.c_partner.Text = "partner"
        Me.c_partner.UseVisualStyleBackColor = True
        '
        'c_account
        '
        Me.c_account.AutoSize = True
        Me.c_account.Location = New System.Drawing.Point(14, 65)
        Me.c_account.Name = "c_account"
        Me.c_account.Size = New System.Drawing.Size(65, 17)
        Me.c_account.TabIndex = 6
        Me.c_account.Text = "account"
        Me.c_account.UseVisualStyleBackColor = True
        '
        'c_user
        '
        Me.c_user.AutoSize = True
        Me.c_user.Location = New System.Drawing.Point(14, 19)
        Me.c_user.Name = "c_user"
        Me.c_user.Size = New System.Drawing.Size(46, 17)
        Me.c_user.TabIndex = 5
        Me.c_user.Text = "user"
        Me.c_user.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(361, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(280, 553)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.c_beli)
        Me.GroupBox3.Controls.Add(Me.c_historibeli)
        Me.GroupBox3.Controls.Add(Me.c_rebeli)
        Me.GroupBox3.Location = New System.Drawing.Point(236, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 105)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pembelian"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.c_historijual)
        Me.GroupBox4.Controls.Add(Me.c_rejual)
        Me.GroupBox4.Controls.Add(Me.c_jual)
        Me.GroupBox4.Location = New System.Drawing.Point(236, 205)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 105)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Penjualan"
        '
        'c_historijual
        '
        Me.c_historijual.AutoSize = True
        Me.c_historijual.Location = New System.Drawing.Point(17, 65)
        Me.c_historijual.Name = "c_historijual"
        Me.c_historijual.Size = New System.Drawing.Size(110, 17)
        Me.c_historijual.TabIndex = 16
        Me.c_historijual.Text = "History Pembelian"
        Me.c_historijual.UseVisualStyleBackColor = True
        '
        'c_rejual
        '
        Me.c_rejual.AutoSize = True
        Me.c_rejual.Location = New System.Drawing.Point(17, 42)
        Me.c_rejual.Name = "c_rejual"
        Me.c_rejual.Size = New System.Drawing.Size(106, 17)
        Me.c_rejual.TabIndex = 17
        Me.c_rejual.Text = "Rejual Penjualan"
        Me.c_rejual.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.c_user)
        Me.GroupBox5.Controls.Add(Me.c_partner)
        Me.GroupBox5.Controls.Add(Me.c_account)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 247)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 98)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data Bantu"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.c_hutang)
        Me.GroupBox6.Controls.Add(Me.c_piutang)
        Me.GroupBox6.Controls.Add(Me.c_kas)
        Me.GroupBox6.Location = New System.Drawing.Point(236, 316)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 98)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Akunting"
        '
        'c_hutang
        '
        Me.c_hutang.AutoSize = True
        Me.c_hutang.Location = New System.Drawing.Point(14, 19)
        Me.c_hutang.Name = "c_hutang"
        Me.c_hutang.Size = New System.Drawing.Size(61, 17)
        Me.c_hutang.TabIndex = 5
        Me.c_hutang.Text = "Hutang"
        Me.c_hutang.UseVisualStyleBackColor = True
        '
        'c_piutang
        '
        Me.c_piutang.AutoSize = True
        Me.c_piutang.Location = New System.Drawing.Point(14, 42)
        Me.c_piutang.Name = "c_piutang"
        Me.c_piutang.Size = New System.Drawing.Size(62, 17)
        Me.c_piutang.TabIndex = 7
        Me.c_piutang.Text = "Piutang"
        Me.c_piutang.UseVisualStyleBackColor = True
        '
        'c_kas
        '
        Me.c_kas.AutoSize = True
        Me.c_kas.Location = New System.Drawing.Point(14, 65)
        Me.c_kas.Name = "c_kas"
        Me.c_kas.Size = New System.Drawing.Size(70, 17)
        Me.c_kas.TabIndex = 6
        Me.c_kas.Text = "Data Kas"
        Me.c_kas.UseVisualStyleBackColor = True
        '
        'OTORITAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 588)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
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
    Friend WithEvents c_beli As System.Windows.Forms.CheckBox
    Friend WithEvents c_mutasi As System.Windows.Forms.CheckBox
    Friend WithEvents c_koreksi As System.Windows.Forms.CheckBox
    Friend WithEvents c_rebeli As System.Windows.Forms.CheckBox
    Friend WithEvents c_historibeli As System.Windows.Forms.CheckBox
    Friend WithEvents c_jual As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents c_historijual As System.Windows.Forms.CheckBox
    Friend WithEvents c_rejual As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents c_hutang As System.Windows.Forms.CheckBox
    Friend WithEvents c_piutang As System.Windows.Forms.CheckBox
    Friend WithEvents c_kas As System.Windows.Forms.CheckBox
End Class
