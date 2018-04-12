<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DATA_KAS
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_dat = New System.Windows.Forms.DataGridView()
        Me.DGV1_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_TGL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_NOKAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_PARTNER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_NAMAPARTNER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_ACCOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_ACCOUNTNAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_DEBIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_KREDIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_KET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_CREATE_USERID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_STAMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.carinokas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.caribank = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tgl1 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.carisup = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsaldo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtkredit = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdebit = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_det = New System.Windows.Forms.DataGridView()
        Me.DGV_NOFAK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_BAYAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_dat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_dat
        '
        Me.dgv_dat.AllowUserToAddRows = False
        Me.dgv_dat.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_dat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_dat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_dat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV1_ID, Me.DGV1_TGL, Me.DGV1_NOKAS, Me.DGV1_PARTNER, Me.DGV1_NAMAPARTNER, Me.DGV1_ACCOUNT, Me.DGV1_ACCOUNTNAMA, Me.DGV1_DEBIT, Me.DGV1_KREDIT, Me.DGV1_KET, Me.DGV1_CREATE_USERID, Me.DGV1_STAMP})
        Me.dgv_dat.Location = New System.Drawing.Point(12, 102)
        Me.dgv_dat.Name = "dgv_dat"
        Me.dgv_dat.ReadOnly = True
        Me.dgv_dat.RowHeadersVisible = False
        Me.dgv_dat.Size = New System.Drawing.Size(1382, 404)
        Me.dgv_dat.TabIndex = 51
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
        'DGV1_TGL
        '
        Me.DGV1_TGL.DataPropertyName = "TGL"
        Me.DGV1_TGL.HeaderText = "Tanggal"
        Me.DGV1_TGL.Name = "DGV1_TGL"
        Me.DGV1_TGL.ReadOnly = True
        '
        'DGV1_NOKAS
        '
        Me.DGV1_NOKAS.DataPropertyName = "NOKAS"
        Me.DGV1_NOKAS.HeaderText = "Nomor Kas"
        Me.DGV1_NOKAS.Name = "DGV1_NOKAS"
        Me.DGV1_NOKAS.ReadOnly = True
        '
        'DGV1_PARTNER
        '
        Me.DGV1_PARTNER.DataPropertyName = "PARTNER"
        Me.DGV1_PARTNER.HeaderText = "Nama Partner"
        Me.DGV1_PARTNER.Name = "DGV1_PARTNER"
        Me.DGV1_PARTNER.ReadOnly = True
        Me.DGV1_PARTNER.Visible = False
        Me.DGV1_PARTNER.Width = 150
        '
        'DGV1_NAMAPARTNER
        '
        Me.DGV1_NAMAPARTNER.DataPropertyName = "NAMAPARTNER"
        Me.DGV1_NAMAPARTNER.HeaderText = "Nama Partner"
        Me.DGV1_NAMAPARTNER.Name = "DGV1_NAMAPARTNER"
        Me.DGV1_NAMAPARTNER.ReadOnly = True
        Me.DGV1_NAMAPARTNER.Width = 150
        '
        'DGV1_ACCOUNT
        '
        Me.DGV1_ACCOUNT.DataPropertyName = "ACCOUNT"
        Me.DGV1_ACCOUNT.HeaderText = "Account"
        Me.DGV1_ACCOUNT.Name = "DGV1_ACCOUNT"
        Me.DGV1_ACCOUNT.ReadOnly = True
        Me.DGV1_ACCOUNT.Visible = False
        '
        'DGV1_ACCOUNTNAMA
        '
        Me.DGV1_ACCOUNTNAMA.DataPropertyName = "ACCOUNTNAMA"
        Me.DGV1_ACCOUNTNAMA.HeaderText = "Account"
        Me.DGV1_ACCOUNTNAMA.Name = "DGV1_ACCOUNTNAMA"
        Me.DGV1_ACCOUNTNAMA.ReadOnly = True
        '
        'DGV1_DEBIT
        '
        Me.DGV1_DEBIT.DataPropertyName = "DEBIT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DGV1_DEBIT.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV1_DEBIT.HeaderText = "Debit (Rp.)"
        Me.DGV1_DEBIT.Name = "DGV1_DEBIT"
        Me.DGV1_DEBIT.ReadOnly = True
        '
        'DGV1_KREDIT
        '
        Me.DGV1_KREDIT.DataPropertyName = "KREDIT"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DGV1_KREDIT.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV1_KREDIT.HeaderText = "Kredit (Rp.)"
        Me.DGV1_KREDIT.Name = "DGV1_KREDIT"
        Me.DGV1_KREDIT.ReadOnly = True
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.carinokas)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.caribank)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tgl2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tgl1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.carisup)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(396, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(998, 53)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'carinokas
        '
        Me.carinokas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.carinokas.Location = New System.Drawing.Point(740, 19)
        Me.carinokas.MaxLength = 19
        Me.carinokas.Name = "carinokas"
        Me.carinokas.Size = New System.Drawing.Size(162, 20)
        Me.carinokas.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(692, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "No Kas"
        '
        'caribank
        '
        Me.caribank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.caribank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.caribank.FormattingEnabled = True
        Me.caribank.Location = New System.Drawing.Point(574, 18)
        Me.caribank.Name = "caribank"
        Me.caribank.Size = New System.Drawing.Size(112, 21)
        Me.caribank.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(522, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Account"
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
        Me.Button4.Location = New System.Drawing.Point(908, 18)
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
        Me.carisup.Location = New System.Drawing.Point(349, 18)
        Me.carisup.Name = "carisup"
        Me.carisup.Size = New System.Drawing.Size(161, 21)
        Me.carisup.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(305, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Partner"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtsaldo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtkredit)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtdebit)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(601, 509)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(793, 53)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'txtsaldo
        '
        Me.txtsaldo.AutoSize = True
        Me.txtsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsaldo.Location = New System.Drawing.Point(598, 21)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.Size = New System.Drawing.Size(14, 13)
        Me.txtsaldo.TabIndex = 10
        Me.txtsaldo.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(515, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total Saldo Rp."
        '
        'txtkredit
        '
        Me.txtkredit.AutoSize = True
        Me.txtkredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkredit.Location = New System.Drawing.Point(362, 21)
        Me.txtkredit.Name = "txtkredit"
        Me.txtkredit.Size = New System.Drawing.Size(14, 13)
        Me.txtkredit.TabIndex = 8
        Me.txtkredit.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(279, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total Kredit Rp."
        '
        'txtdebit
        '
        Me.txtdebit.AutoSize = True
        Me.txtdebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdebit.Location = New System.Drawing.Point(96, 21)
        Me.txtdebit.Name = "txtdebit"
        Me.txtdebit.Size = New System.Drawing.Size(14, 13)
        Me.txtdebit.TabIndex = 6
        Me.txtdebit.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Debit Rp."
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 509)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "*Click 2x untuk Edit/hapus"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 29)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Data Kas"
        '
        'dgv_det
        '
        Me.dgv_det.AllowUserToAddRows = False
        Me.dgv_det.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_det.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_det.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_det.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_det.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_NOFAK, Me.DGV_BAYAR})
        Me.dgv_det.Location = New System.Drawing.Point(12, 568)
        Me.dgv_det.Name = "dgv_det"
        Me.dgv_det.ReadOnly = True
        Me.dgv_det.RowHeadersVisible = False
        Me.dgv_det.Size = New System.Drawing.Size(1382, 249)
        Me.dgv_det.TabIndex = 55
        '
        'DGV_NOFAK
        '
        Me.DGV_NOFAK.DataPropertyName = "NOFAK"
        Me.DGV_NOFAK.HeaderText = "Nomor Faktur"
        Me.DGV_NOFAK.Name = "DGV_NOFAK"
        Me.DGV_NOFAK.ReadOnly = True
        Me.DGV_NOFAK.Width = 150
        '
        'DGV_BAYAR
        '
        Me.DGV_BAYAR.DataPropertyName = "BAYAR"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DGV_BAYAR.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_BAYAR.HeaderText = "Bayar (Rp.)"
        Me.DGV_BAYAR.Name = "DGV_BAYAR"
        Me.DGV_BAYAR.ReadOnly = True
        '
        'DATA_KAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1406, 837)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_dat)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_det)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DATA_KAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DATA_KAS"
        CType(Me.dgv_dat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_dat As System.Windows.Forms.DataGridView
    Friend WithEvents tgl2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents carinokas As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents caribank As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tgl1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents carisup As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsaldo As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtkredit As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdebit As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_det As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_NOFAK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_BAYAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_TGL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_NOKAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_PARTNER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_NAMAPARTNER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_ACCOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_ACCOUNTNAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_DEBIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_KREDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_KET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_CREATE_USERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_STAMP As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
