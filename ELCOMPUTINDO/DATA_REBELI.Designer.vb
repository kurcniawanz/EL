<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DATA_REBELI
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
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtgrantotal = New System.Windows.Forms.Label()
        Me.dgv_dat = New System.Windows.Forms.DataGridView()
        Me.DGV1_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_NOFAK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_TGL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_JT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_SUPLIERNAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_POT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_GRANDTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_KET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_CREATE_USERID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_STAMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_BAYAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_SUPLIER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tgl2 = New System.Windows.Forms.DateTimePicker()
        Me.dgv_det = New System.Windows.Forms.DataGridView()
        Me.DGV_NAMABARANG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_HARGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_JUMLAH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_POT1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_POT2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_IDBARANG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tgl1 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.carisup = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgv_dat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtgrantotal
        '
        Me.txtgrantotal.AutoSize = True
        Me.txtgrantotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrantotal.Location = New System.Drawing.Point(96, 21)
        Me.txtgrantotal.Name = "txtgrantotal"
        Me.txtgrantotal.Size = New System.Drawing.Size(14, 13)
        Me.txtgrantotal.TabIndex = 6
        Me.txtgrantotal.Text = "0"
        '
        'dgv_dat
        '
        Me.dgv_dat.AllowUserToAddRows = False
        Me.dgv_dat.AllowUserToDeleteRows = False
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_dat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle27
        Me.dgv_dat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.dgv_dat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV1_ID, Me.DGV1_NOFAK, Me.DGV1_TGL, Me.DGV1_JT, Me.DGV1_SUPLIERNAMA, Me.DGV1_TOTAL, Me.DGV1_POT, Me.DGV1_GRANDTOTAL, Me.DGV1_KET, Me.DGV1_CREATE_USERID, Me.DGV1_STAMP, Me.DGV1_BAYAR, Me.DGV1_SUPLIER})
        Me.dgv_dat.Location = New System.Drawing.Point(17, 97)
        Me.dgv_dat.Name = "dgv_dat"
        Me.dgv_dat.ReadOnly = True
        Me.dgv_dat.RowHeadersVisible = False
        Me.dgv_dat.Size = New System.Drawing.Size(1242, 326)
        Me.dgv_dat.TabIndex = 38
        '
        'DGV1_ID
        '
        Me.DGV1_ID.DataPropertyName = "ID"
        Me.DGV1_ID.HeaderText = "ID"
        Me.DGV1_ID.Name = "DGV1_ID"
        Me.DGV1_ID.ReadOnly = True
        Me.DGV1_ID.Visible = False
        Me.DGV1_ID.Width = 40
        '
        'DGV1_NOFAK
        '
        Me.DGV1_NOFAK.DataPropertyName = "NOFAK"
        Me.DGV1_NOFAK.HeaderText = "Nomor Faktur"
        Me.DGV1_NOFAK.Name = "DGV1_NOFAK"
        Me.DGV1_NOFAK.ReadOnly = True
        Me.DGV1_NOFAK.Width = 150
        '
        'DGV1_TGL
        '
        Me.DGV1_TGL.DataPropertyName = "TGL"
        Me.DGV1_TGL.HeaderText = "Tanggal"
        Me.DGV1_TGL.Name = "DGV1_TGL"
        Me.DGV1_TGL.ReadOnly = True
        '
        'DGV1_JT
        '
        Me.DGV1_JT.DataPropertyName = "JT"
        Me.DGV1_JT.HeaderText = "Jatuh Tempo"
        Me.DGV1_JT.Name = "DGV1_JT"
        Me.DGV1_JT.ReadOnly = True
        '
        'DGV1_SUPLIERNAMA
        '
        Me.DGV1_SUPLIERNAMA.DataPropertyName = "SUPLIERNAMA"
        Me.DGV1_SUPLIERNAMA.HeaderText = "Nama Suplier"
        Me.DGV1_SUPLIERNAMA.Name = "DGV1_SUPLIERNAMA"
        Me.DGV1_SUPLIERNAMA.ReadOnly = True
        Me.DGV1_SUPLIERNAMA.Width = 150
        '
        'DGV1_TOTAL
        '
        Me.DGV1_TOTAL.DataPropertyName = "TOTAL"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle29.Format = "N2"
        DataGridViewCellStyle29.NullValue = Nothing
        Me.DGV1_TOTAL.DefaultCellStyle = DataGridViewCellStyle29
        Me.DGV1_TOTAL.HeaderText = "Total(Rp.)"
        Me.DGV1_TOTAL.Name = "DGV1_TOTAL"
        Me.DGV1_TOTAL.ReadOnly = True
        '
        'DGV1_POT
        '
        Me.DGV1_POT.DataPropertyName = "POT"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle30.Format = "N0"
        DataGridViewCellStyle30.NullValue = Nothing
        Me.DGV1_POT.DefaultCellStyle = DataGridViewCellStyle30
        Me.DGV1_POT.HeaderText = "Potongan(Rp.)"
        Me.DGV1_POT.Name = "DGV1_POT"
        Me.DGV1_POT.ReadOnly = True
        '
        'DGV1_GRANDTOTAL
        '
        Me.DGV1_GRANDTOTAL.DataPropertyName = "GRANDTOTAL"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle31.Format = "N2"
        DataGridViewCellStyle31.NullValue = Nothing
        Me.DGV1_GRANDTOTAL.DefaultCellStyle = DataGridViewCellStyle31
        Me.DGV1_GRANDTOTAL.HeaderText = "Grand Total(Rp.)"
        Me.DGV1_GRANDTOTAL.Name = "DGV1_GRANDTOTAL"
        Me.DGV1_GRANDTOTAL.ReadOnly = True
        '
        'DGV1_KET
        '
        Me.DGV1_KET.DataPropertyName = "KET"
        Me.DGV1_KET.HeaderText = "Keterangan"
        Me.DGV1_KET.Name = "DGV1_KET"
        Me.DGV1_KET.ReadOnly = True
        Me.DGV1_KET.Width = 250
        '
        'DGV1_CREATE_USERID
        '
        Me.DGV1_CREATE_USERID.DataPropertyName = "CREATE_USERID"
        Me.DGV1_CREATE_USERID.HeaderText = "CREATE_USERID"
        Me.DGV1_CREATE_USERID.Name = "DGV1_CREATE_USERID"
        Me.DGV1_CREATE_USERID.ReadOnly = True
        Me.DGV1_CREATE_USERID.Width = 150
        '
        'DGV1_STAMP
        '
        Me.DGV1_STAMP.DataPropertyName = "STAMP"
        Me.DGV1_STAMP.HeaderText = "STAMP"
        Me.DGV1_STAMP.Name = "DGV1_STAMP"
        Me.DGV1_STAMP.ReadOnly = True
        Me.DGV1_STAMP.Width = 150
        '
        'DGV1_BAYAR
        '
        Me.DGV1_BAYAR.DataPropertyName = "BAYAR"
        Me.DGV1_BAYAR.HeaderText = "Column1"
        Me.DGV1_BAYAR.Name = "DGV1_BAYAR"
        Me.DGV1_BAYAR.ReadOnly = True
        Me.DGV1_BAYAR.Visible = False
        '
        'DGV1_SUPLIER
        '
        Me.DGV1_SUPLIER.DataPropertyName = "SUPLIER"
        Me.DGV1_SUPLIER.HeaderText = "Column1"
        Me.DGV1_SUPLIER.Name = "DGV1_SUPLIER"
        Me.DGV1_SUPLIER.ReadOnly = True
        Me.DGV1_SUPLIER.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 29)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Laporan Retur Pembelian"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 429)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "*Click 2x untuk Edit/hapus"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtgrantotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(971, 429)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 53)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Grand Total Rp."
        '
        'tgl2
        '
        Me.tgl2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tgl2.Location = New System.Drawing.Point(195, 19)
        Me.tgl2.Name = "tgl2"
        Me.tgl2.Size = New System.Drawing.Size(104, 20)
        Me.tgl2.TabIndex = 28
        '
        'dgv_det
        '
        Me.dgv_det.AllowUserToAddRows = False
        Me.dgv_det.AllowUserToDeleteRows = False
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_det.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle32
        Me.dgv_det.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_det.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle33
        Me.dgv_det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_det.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_NAMABARANG, Me.DataGridViewTextBoxColumn1, Me.DGV_HARGA, Me.DGV_JUMLAH, Me.DGV_POT1, Me.DGV_POT2, Me.DGV_TOTAL, Me.DGV_IDBARANG})
        Me.dgv_det.Location = New System.Drawing.Point(17, 488)
        Me.dgv_det.Name = "dgv_det"
        Me.dgv_det.ReadOnly = True
        Me.dgv_det.RowHeadersVisible = False
        Me.dgv_det.Size = New System.Drawing.Size(1242, 249)
        Me.dgv_det.TabIndex = 43
        '
        'DGV_NAMABARANG
        '
        Me.DGV_NAMABARANG.DataPropertyName = "NAMABARANG"
        Me.DGV_NAMABARANG.HeaderText = "Nama Barang"
        Me.DGV_NAMABARANG.Name = "DGV_NAMABARANG"
        Me.DGV_NAMABARANG.ReadOnly = True
        Me.DGV_NAMABARANG.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "QTY"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle34.Format = "N0"
        DataGridViewCellStyle34.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle34
        Me.DataGridViewTextBoxColumn1.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DGV_HARGA
        '
        Me.DGV_HARGA.DataPropertyName = "HARGA"
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle35.Format = "N2"
        DataGridViewCellStyle35.NullValue = Nothing
        Me.DGV_HARGA.DefaultCellStyle = DataGridViewCellStyle35
        Me.DGV_HARGA.HeaderText = "Harga"
        Me.DGV_HARGA.Name = "DGV_HARGA"
        Me.DGV_HARGA.ReadOnly = True
        '
        'DGV_JUMLAH
        '
        Me.DGV_JUMLAH.DataPropertyName = "JUMLAH"
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle36.Format = "N2"
        DataGridViewCellStyle36.NullValue = Nothing
        Me.DGV_JUMLAH.DefaultCellStyle = DataGridViewCellStyle36
        Me.DGV_JUMLAH.HeaderText = "Jumlah"
        Me.DGV_JUMLAH.Name = "DGV_JUMLAH"
        Me.DGV_JUMLAH.ReadOnly = True
        '
        'DGV_POT1
        '
        Me.DGV_POT1.DataPropertyName = "POT1"
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle37.Format = "N0"
        DataGridViewCellStyle37.NullValue = Nothing
        Me.DGV_POT1.DefaultCellStyle = DataGridViewCellStyle37
        Me.DGV_POT1.HeaderText = "Disc(%)"
        Me.DGV_POT1.Name = "DGV_POT1"
        Me.DGV_POT1.ReadOnly = True
        Me.DGV_POT1.Width = 50
        '
        'DGV_POT2
        '
        Me.DGV_POT2.DataPropertyName = "POT2"
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle38.Format = "N2"
        DataGridViewCellStyle38.NullValue = Nothing
        Me.DGV_POT2.DefaultCellStyle = DataGridViewCellStyle38
        Me.DGV_POT2.HeaderText = "Disc(Rp.)"
        Me.DGV_POT2.Name = "DGV_POT2"
        Me.DGV_POT2.ReadOnly = True
        '
        'DGV_TOTAL
        '
        Me.DGV_TOTAL.DataPropertyName = "TOTAL"
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle39.Format = "N2"
        DataGridViewCellStyle39.NullValue = Nothing
        Me.DGV_TOTAL.DefaultCellStyle = DataGridViewCellStyle39
        Me.DGV_TOTAL.HeaderText = "Total"
        Me.DGV_TOTAL.Name = "DGV_TOTAL"
        Me.DGV_TOTAL.ReadOnly = True
        '
        'DGV_IDBARANG
        '
        Me.DGV_IDBARANG.DataPropertyName = "IDBARANG"
        Me.DGV_IDBARANG.HeaderText = "idbarang"
        Me.DGV_IDBARANG.Name = "DGV_IDBARANG"
        Me.DGV_IDBARANG.ReadOnly = True
        Me.DGV_IDBARANG.Visible = False
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tgl2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tgl1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.carisup)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(626, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(633, 53)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
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
        Me.Button4.Location = New System.Drawing.Point(546, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Cari"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'carisup
        '
        Me.carisup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.carisup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.carisup.FormattingEnabled = True
        Me.carisup.Location = New System.Drawing.Point(350, 18)
        Me.carisup.Name = "carisup"
        Me.carisup.Size = New System.Drawing.Size(190, 21)
        Me.carisup.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(305, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Suplier"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(224, 429)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "*Click F1 untuk print ulang"
        '
        'DATA_REBELI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_dat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_det)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "DATA_REBELI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DATA_REBELI"
        CType(Me.dgv_dat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtgrantotal As System.Windows.Forms.Label
    Friend WithEvents dgv_dat As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tgl2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv_det As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_NAMABARANG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_HARGA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_JUMLAH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_POT1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_POT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_IDBARANG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tgl1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents carisup As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DGV1_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_NOFAK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_TGL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_JT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_SUPLIERNAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_POT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_GRANDTOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_KET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_CREATE_USERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_STAMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_BAYAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_SUPLIER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
