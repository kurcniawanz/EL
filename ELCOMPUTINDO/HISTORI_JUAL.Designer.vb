<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HISTORI_JUAL
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.totqty = New System.Windows.Forms.Label()
        Me.DGV_POT2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_POT1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_JUMLAH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_HARGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_CREATE_USERID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tothpp = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGV_IDBARANG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_STAMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_NAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_NOFAK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_TGL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.carifaktur = New System.Windows.Forms.TextBox()
        Me.dgv_det = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tgl2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tgl1 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.caribarang = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'totqty
        '
        Me.totqty.AutoSize = True
        Me.totqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totqty.Location = New System.Drawing.Point(64, 21)
        Me.totqty.Name = "totqty"
        Me.totqty.Size = New System.Drawing.Size(14, 13)
        Me.totqty.TabIndex = 4
        Me.totqty.Text = "0"
        '
        'DGV_POT2
        '
        Me.DGV_POT2.DataPropertyName = "POT2"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DGV_POT2.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_POT2.HeaderText = "Disc(Rp.)"
        Me.DGV_POT2.Name = "DGV_POT2"
        Me.DGV_POT2.ReadOnly = True
        '
        'DGV_POT1
        '
        Me.DGV_POT1.DataPropertyName = "POT1"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DGV_POT1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DGV_POT1.HeaderText = "Disc(%)"
        Me.DGV_POT1.Name = "DGV_POT1"
        Me.DGV_POT1.ReadOnly = True
        Me.DGV_POT1.Width = 50
        '
        'DGV_JUMLAH
        '
        Me.DGV_JUMLAH.DataPropertyName = "JUMLAH"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DGV_JUMLAH.DefaultCellStyle = DataGridViewCellStyle11
        Me.DGV_JUMLAH.HeaderText = "Jumlah"
        Me.DGV_JUMLAH.Name = "DGV_JUMLAH"
        Me.DGV_JUMLAH.ReadOnly = True
        '
        'DGV_HARGA
        '
        Me.DGV_HARGA.DataPropertyName = "HARGA"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DGV_HARGA.DefaultCellStyle = DataGridViewCellStyle12
        Me.DGV_HARGA.HeaderText = "Harga"
        Me.DGV_HARGA.Name = "DGV_HARGA"
        Me.DGV_HARGA.ReadOnly = True
        '
        'DGV_QTY
        '
        Me.DGV_QTY.DataPropertyName = "QTY"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N0"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DGV_QTY.DefaultCellStyle = DataGridViewCellStyle13
        Me.DGV_QTY.HeaderText = "Qty"
        Me.DGV_QTY.Name = "DGV_QTY"
        Me.DGV_QTY.ReadOnly = True
        Me.DGV_QTY.Width = 50
        '
        'DGV_TOTAL
        '
        Me.DGV_TOTAL.DataPropertyName = "TOTAL"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DGV_TOTAL.DefaultCellStyle = DataGridViewCellStyle14
        Me.DGV_TOTAL.HeaderText = "Total"
        Me.DGV_TOTAL.Name = "DGV_TOTAL"
        Me.DGV_TOTAL.ReadOnly = True
        '
        'DVG_CREATE_USERID
        '
        Me.DVG_CREATE_USERID.DataPropertyName = "CREATE_USERID"
        Me.DVG_CREATE_USERID.HeaderText = "CREATE_USERID"
        Me.DVG_CREATE_USERID.Name = "DVG_CREATE_USERID"
        Me.DVG_CREATE_USERID.ReadOnly = True
        Me.DVG_CREATE_USERID.Width = 150
        '
        'tothpp
        '
        Me.tothpp.AutoSize = True
        Me.tothpp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tothpp.Location = New System.Drawing.Point(286, 21)
        Me.tothpp.Name = "tothpp"
        Me.tothpp.Size = New System.Drawing.Size(14, 13)
        Me.tothpp.TabIndex = 6
        Me.tothpp.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(233, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total  Rp."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.tothpp)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.totqty)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(875, 735)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 53)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total Qty"
        '
        'DGV_IDBARANG
        '
        Me.DGV_IDBARANG.DataPropertyName = "IDBARANG"
        Me.DGV_IDBARANG.HeaderText = "idbarang"
        Me.DGV_IDBARANG.Name = "DGV_IDBARANG"
        Me.DGV_IDBARANG.ReadOnly = True
        Me.DGV_IDBARANG.Visible = False
        '
        'DGV_STAMP
        '
        Me.DGV_STAMP.DataPropertyName = "STAMP"
        Me.DGV_STAMP.HeaderText = "STAMP"
        Me.DGV_STAMP.Name = "DGV_STAMP"
        Me.DGV_STAMP.ReadOnly = True
        Me.DGV_STAMP.Width = 150
        '
        'DGV_NAMA
        '
        Me.DGV_NAMA.DataPropertyName = "NAMA"
        Me.DGV_NAMA.HeaderText = "Nama Barang"
        Me.DGV_NAMA.Name = "DGV_NAMA"
        Me.DGV_NAMA.ReadOnly = True
        Me.DGV_NAMA.Width = 200
        '
        'DGV_NOFAK
        '
        Me.DGV_NOFAK.DataPropertyName = "NOFAK"
        Me.DGV_NOFAK.HeaderText = "Nomor Faktur"
        Me.DGV_NOFAK.Name = "DGV_NOFAK"
        Me.DGV_NOFAK.ReadOnly = True
        '
        'DGV_TGL
        '
        Me.DGV_TGL.DataPropertyName = "TGL"
        Me.DGV_TGL.HeaderText = "Tanggal"
        Me.DGV_TGL.Name = "DGV_TGL"
        Me.DGV_TGL.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 29)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "History Penjualan"
        '
        'carifaktur
        '
        Me.carifaktur.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.carifaktur.Location = New System.Drawing.Point(656, 18)
        Me.carifaktur.Name = "carifaktur"
        Me.carifaktur.Size = New System.Drawing.Size(150, 20)
        Me.carifaktur.TabIndex = 39
        '
        'dgv_det
        '
        Me.dgv_det.AllowUserToAddRows = False
        Me.dgv_det.AllowUserToDeleteRows = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_det.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgv_det.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_det.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgv_det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_det.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_TGL, Me.DGV_NOFAK, Me.DGV_NAMA, Me.DGV_QTY, Me.DGV_HARGA, Me.DGV_JUMLAH, Me.DGV_POT1, Me.DGV_POT2, Me.DGV_TOTAL, Me.DVG_CREATE_USERID, Me.DGV_STAMP, Me.DGV_IDBARANG})
        Me.dgv_det.Location = New System.Drawing.Point(17, 100)
        Me.dgv_det.Name = "dgv_det"
        Me.dgv_det.ReadOnly = True
        Me.dgv_det.RowHeadersVisible = False
        Me.dgv_det.Size = New System.Drawing.Size(1352, 629)
        Me.dgv_det.TabIndex = 47
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.carifaktur)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tgl2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tgl1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.caribarang)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(476, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(893, 53)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(579, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Nomor Faktur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "s/d"
        '
        'tgl2
        '
        Me.tgl2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tgl2.Location = New System.Drawing.Point(195, 19)
        Me.tgl2.Name = "tgl2"
        Me.tgl2.Size = New System.Drawing.Size(104, 20)
        Me.tgl2.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Tanggal"
        '
        'tgl1
        '
        Me.tgl1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tgl1.Location = New System.Drawing.Point(56, 19)
        Me.tgl1.Name = "tgl1"
        Me.tgl1.Size = New System.Drawing.Size(104, 20)
        Me.tgl1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(812, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Cari"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'caribarang
        '
        Me.caribarang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.caribarang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.caribarang.FormattingEnabled = True
        Me.caribarang.Location = New System.Drawing.Point(383, 18)
        Me.caribarang.Name = "caribarang"
        Me.caribarang.Size = New System.Drawing.Size(190, 21)
        Me.caribarang.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(305, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Nama Barang"
        '
        'HISTORI_JUAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1381, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_det)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HISTORI_JUAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HISTORI_JUAL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents totqty As System.Windows.Forms.Label
    Friend WithEvents DGV_POT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_POT1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_JUMLAH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_HARGA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DVG_CREATE_USERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tothpp As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DGV_IDBARANG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_STAMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_NAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_NOFAK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_TGL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents carifaktur As System.Windows.Forms.TextBox
    Friend WithEvents dgv_det As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tgl2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tgl1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents caribarang As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
