<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HISTORI_BELI
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
        Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tgl2 = New System.Windows.Forms.DateTimePicker()
        Me.dgv_det = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tgl1 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.caribarang = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.carifaktur = New System.Windows.Forms.TextBox()
        Me.DGV_TGL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_NOFAK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_NAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_HARGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_JUMLAH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_POT1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_POT2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_CREATE_USERID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_STAMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_IDBARANG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 29)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "History Pembelian"
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
        DataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_det.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle49
        Me.dgv_det.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle50.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_det.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle50
        Me.dgv_det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_det.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_TGL, Me.DGV_NOFAK, Me.DGV_NAMA, Me.DataGridViewTextBoxColumn1, Me.DGV_HARGA, Me.DGV_JUMLAH, Me.DGV_POT1, Me.DGV_POT2, Me.DGV_TOTAL, Me.DVG_CREATE_USERID, Me.DGV_STAMP, Me.DGV_IDBARANG})
        Me.dgv_det.Location = New System.Drawing.Point(17, 100)
        Me.dgv_det.Name = "dgv_det"
        Me.dgv_det.ReadOnly = True
        Me.dgv_det.RowHeadersVisible = False
        Me.dgv_det.Size = New System.Drawing.Size(1234, 688)
        Me.dgv_det.TabIndex = 43
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
        Me.GroupBox2.Controls.Add(Me.carifaktur)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tgl2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tgl1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.caribarang)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(358, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(893, 53)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(579, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Nomor Faktur"
        '
        'carifaktur
        '
        Me.carifaktur.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.carifaktur.Location = New System.Drawing.Point(656, 18)
        Me.carifaktur.Name = "carifaktur"
        Me.carifaktur.Size = New System.Drawing.Size(150, 20)
        Me.carifaktur.TabIndex = 39
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
        Me.DGV_NAMA.Width = 200
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "QTY"
        DataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle51.Format = "N0"
        DataGridViewCellStyle51.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle51
        Me.DataGridViewTextBoxColumn1.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DGV_HARGA
        '
        Me.DGV_HARGA.DataPropertyName = "HARGA"
        DataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle52.Format = "N2"
        DataGridViewCellStyle52.NullValue = Nothing
        Me.DGV_HARGA.DefaultCellStyle = DataGridViewCellStyle52
        Me.DGV_HARGA.HeaderText = "Harga"
        Me.DGV_HARGA.Name = "DGV_HARGA"
        Me.DGV_HARGA.ReadOnly = True
        '
        'DGV_JUMLAH
        '
        Me.DGV_JUMLAH.DataPropertyName = "JUMLAH"
        DataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle53.Format = "N2"
        DataGridViewCellStyle53.NullValue = Nothing
        Me.DGV_JUMLAH.DefaultCellStyle = DataGridViewCellStyle53
        Me.DGV_JUMLAH.HeaderText = "Jumlah"
        Me.DGV_JUMLAH.Name = "DGV_JUMLAH"
        Me.DGV_JUMLAH.ReadOnly = True
        '
        'DGV_POT1
        '
        Me.DGV_POT1.DataPropertyName = "POT1"
        DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle54.Format = "N0"
        DataGridViewCellStyle54.NullValue = Nothing
        Me.DGV_POT1.DefaultCellStyle = DataGridViewCellStyle54
        Me.DGV_POT1.HeaderText = "Disc(%)"
        Me.DGV_POT1.Name = "DGV_POT1"
        Me.DGV_POT1.ReadOnly = True
        Me.DGV_POT1.Width = 50
        '
        'DGV_POT2
        '
        Me.DGV_POT2.DataPropertyName = "POT2"
        DataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle55.Format = "N2"
        DataGridViewCellStyle55.NullValue = Nothing
        Me.DGV_POT2.DefaultCellStyle = DataGridViewCellStyle55
        Me.DGV_POT2.HeaderText = "Disc(Rp.)"
        Me.DGV_POT2.Name = "DGV_POT2"
        Me.DGV_POT2.ReadOnly = True
        '
        'DGV_TOTAL
        '
        Me.DGV_TOTAL.DataPropertyName = "TOTAL"
        DataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle56.Format = "N2"
        DataGridViewCellStyle56.NullValue = Nothing
        Me.DGV_TOTAL.DefaultCellStyle = DataGridViewCellStyle56
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
        Me.DGV_IDBARANG.HeaderText = "idbarang"
        Me.DGV_IDBARANG.Name = "DGV_IDBARANG"
        Me.DGV_IDBARANG.ReadOnly = True
        Me.DGV_IDBARANG.Visible = False
        '
        'HISTORI_BELI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_det)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HISTORI_BELI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HISTORI_BELI"
        CType(Me.dgv_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tgl2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv_det As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tgl1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents caribarang As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents carifaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGV_TGL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_NOFAK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_NAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_HARGA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_JUMLAH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_POT1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_POT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DVG_CREATE_USERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_STAMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_IDBARANG As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
