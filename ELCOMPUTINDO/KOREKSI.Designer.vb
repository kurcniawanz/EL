<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KOREKSI
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txttgl = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnofak = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbarang = New System.Windows.Forms.ComboBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtket = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DGV_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_TGL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_NOFAK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_NAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_SATUAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_HPP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_TOTHPP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_KET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_CREATE_USERID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_STAMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_IDBARANG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 558)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "*Click 2x untuk Edit/hapus"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 29)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Koreksi Barang"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(225, 18)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(25, 20)
        Me.txtid.TabIndex = 33
        Me.txtid.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Keterangan"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(446, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(446, 243)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(446, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Hapus"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttgl)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtnofak)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txttotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtbarang)
        Me.GroupBox1.Controls.Add(Me.txtharga)
        Me.GroupBox1.Controls.Add(Me.txtqty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtket)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 251)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txttgl
        '
        Me.txttgl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txttgl.Location = New System.Drawing.Point(136, 42)
        Me.txttgl.Name = "txttgl"
        Me.txttgl.Size = New System.Drawing.Size(149, 20)
        Me.txttgl.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Tanggal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Nomor Faktur"
        '
        'txtnofak
        '
        Me.txtnofak.Enabled = False
        Me.txtnofak.Location = New System.Drawing.Point(136, 15)
        Me.txtnofak.MaxLength = 20
        Me.txtnofak.Name = "txtnofak"
        Me.txtnofak.Size = New System.Drawing.Size(149, 20)
        Me.txtnofak.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(133, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Rp."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(133, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Rp."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(160, 146)
        Me.txttotal.MaxLength = 12
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(125, 20)
        Me.txttotal.TabIndex = 4
        Me.txttotal.Text = "0"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Qty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Harga"
        '
        'txtbarang
        '
        Me.txtbarang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtbarang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtbarang.FormattingEnabled = True
        Me.txtbarang.Location = New System.Drawing.Point(136, 68)
        Me.txtbarang.Name = "txtbarang"
        Me.txtbarang.Size = New System.Drawing.Size(266, 21)
        Me.txtbarang.TabIndex = 1
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(160, 120)
        Me.txtharga.MaxLength = 12
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(125, 20)
        Me.txtharga.TabIndex = 3
        Me.txtharga.Text = "0"
        Me.txtharga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(136, 94)
        Me.txtqty.MaxLength = 4
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(149, 20)
        Me.txtqty.TabIndex = 2
        Me.txtqty.Text = "0"
        Me.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtket
        '
        Me.txtket.Location = New System.Drawing.Point(136, 175)
        Me.txtket.MaxLength = 250
        Me.txtket.Multiline = True
        Me.txtket.Name = "txtket"
        Me.txtket.Size = New System.Drawing.Size(266, 67)
        Me.txtket.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_ID, Me.DGV_TGL, Me.DGV_NOFAK, Me.DGV_NAMA, Me.DGV_QTY, Me.DGV_SATUAN, Me.DGV_HPP, Me.DGV_TOTHPP, Me.DGV_KET, Me.DGV_CREATE_USERID, Me.DGV_STAMP, Me.DGV_IDBARANG})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 298)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(901, 257)
        Me.DataGridView1.TabIndex = 31
        '
        'DGV_ID
        '
        Me.DGV_ID.DataPropertyName = "ID"
        Me.DGV_ID.HeaderText = "ID"
        Me.DGV_ID.Name = "DGV_ID"
        Me.DGV_ID.ReadOnly = True
        Me.DGV_ID.Width = 40
        '
        'DGV_TGL
        '
        Me.DGV_TGL.DataPropertyName = "TGL"
        Me.DGV_TGL.HeaderText = "Tanggal"
        Me.DGV_TGL.Name = "DGV_TGL"
        Me.DGV_TGL.ReadOnly = True
        '
        'DGV_NOFAK
        '
        Me.DGV_NOFAK.DataPropertyName = "NOFAK"
        Me.DGV_NOFAK.HeaderText = "Nomor Faktur"
        Me.DGV_NOFAK.Name = "DGV_NOFAK"
        Me.DGV_NOFAK.ReadOnly = True
        '
        'DGV_NAMA
        '
        Me.DGV_NAMA.DataPropertyName = "NAMA"
        Me.DGV_NAMA.HeaderText = "Nama Barang"
        Me.DGV_NAMA.Name = "DGV_NAMA"
        Me.DGV_NAMA.ReadOnly = True
        Me.DGV_NAMA.Width = 150
        '
        'DGV_QTY
        '
        Me.DGV_QTY.DataPropertyName = "QTY"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DGV_QTY.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_QTY.HeaderText = "Qty"
        Me.DGV_QTY.Name = "DGV_QTY"
        Me.DGV_QTY.ReadOnly = True
        '
        'DGV_SATUAN
        '
        Me.DGV_SATUAN.DataPropertyName = "SATUAN"
        Me.DGV_SATUAN.HeaderText = "Satuan"
        Me.DGV_SATUAN.Name = "DGV_SATUAN"
        Me.DGV_SATUAN.ReadOnly = True
        '
        'DGV_HPP
        '
        Me.DGV_HPP.DataPropertyName = "HPP"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DGV_HPP.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_HPP.HeaderText = "Harga"
        Me.DGV_HPP.Name = "DGV_HPP"
        Me.DGV_HPP.ReadOnly = True
        '
        'DGV_TOTHPP
        '
        Me.DGV_TOTHPP.DataPropertyName = "TOTHPP"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DGV_TOTHPP.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_TOTHPP.HeaderText = "Total"
        Me.DGV_TOTHPP.Name = "DGV_TOTHPP"
        Me.DGV_TOTHPP.ReadOnly = True
        '
        'DGV_KET
        '
        Me.DGV_KET.DataPropertyName = "KET"
        Me.DGV_KET.HeaderText = "Keterangan"
        Me.DGV_KET.Name = "DGV_KET"
        Me.DGV_KET.ReadOnly = True
        Me.DGV_KET.Width = 250
        '
        'DGV_CREATE_USERID
        '
        Me.DGV_CREATE_USERID.DataPropertyName = "CREATE_UID"
        Me.DGV_CREATE_USERID.HeaderText = "CREATE_USERID"
        Me.DGV_CREATE_USERID.Name = "DGV_CREATE_USERID"
        Me.DGV_CREATE_USERID.ReadOnly = True
        Me.DGV_CREATE_USERID.Width = 150
        '
        'DGV_STAMP
        '
        Me.DGV_STAMP.DataPropertyName = "STAMP"
        Me.DGV_STAMP.HeaderText = "STAMP"
        Me.DGV_STAMP.Name = "DGV_STAMP"
        Me.DGV_STAMP.ReadOnly = True
        Me.DGV_STAMP.Width = 150
        '
        'DGV_IDBARANG
        '
        Me.DGV_IDBARANG.DataPropertyName = "IDBARANG"
        Me.DGV_IDBARANG.HeaderText = "Column1"
        Me.DGV_IDBARANG.Name = "DGV_IDBARANG"
        Me.DGV_IDBARANG.ReadOnly = True
        Me.DGV_IDBARANG.Visible = False
        '
        'KOREKSI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 589)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KOREKSI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "KOREKSI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbarang As System.Windows.Forms.ComboBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtket As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnofak As System.Windows.Forms.TextBox
    Friend WithEvents txttgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DGV_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_TGL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_NOFAK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_NAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_SATUAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_HPP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_TOTHPP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_KET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_CREATE_USERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_STAMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_IDBARANG As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
