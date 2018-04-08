<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIST_HUTANG
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.totsis = New System.Windows.Forms.Label()
        Me.totbay = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tott = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_dat = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.carisup = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV1_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_NAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_BELI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_REBELI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_GRANDTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_BAYAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_SISA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV1_SUPLIER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_dat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'totsis
        '
        Me.totsis.AutoSize = True
        Me.totsis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totsis.Location = New System.Drawing.Point(567, 21)
        Me.totsis.Name = "totsis"
        Me.totsis.Size = New System.Drawing.Size(14, 13)
        Me.totsis.TabIndex = 10
        Me.totsis.Text = "0"
        '
        'totbay
        '
        Me.totbay.AutoSize = True
        Me.totbay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totbay.Location = New System.Drawing.Point(338, 20)
        Me.totbay.Name = "totbay"
        Me.totbay.Size = New System.Drawing.Size(14, 13)
        Me.totbay.TabIndex = 8
        Me.totbay.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(488, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Total Sisa  Rp."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total Bayar  Rp."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.totsis)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.totbay)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tott)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(494, 654)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 53)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'tott
        '
        Me.tott.AutoSize = True
        Me.tott.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tott.Location = New System.Drawing.Point(94, 21)
        Me.tott.Name = "tott"
        Me.tott.Size = New System.Drawing.Size(14, 13)
        Me.tott.TabIndex = 6
        Me.tott.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "GrandTotal  Rp."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 29)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "List Hutang"
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
        Me.dgv_dat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV1_ID, Me.DGV1_NAMA, Me.DGV_SALDO, Me.DGV_BELI, Me.DGV_REBELI, Me.DGV1_GRANDTOTAL, Me.DGV1_BAYAR, Me.DGV1_SISA, Me.DGV1_SUPLIER})
        Me.dgv_dat.Location = New System.Drawing.Point(17, 97)
        Me.dgv_dat.Name = "dgv_dat"
        Me.dgv_dat.ReadOnly = True
        Me.dgv_dat.RowHeadersVisible = False
        Me.dgv_dat.Size = New System.Drawing.Size(1186, 551)
        Me.dgv_dat.TabIndex = 47
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(249, 17)
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
        Me.carisup.Location = New System.Drawing.Point(54, 18)
        Me.carisup.Name = "carisup"
        Me.carisup.Size = New System.Drawing.Size(190, 21)
        Me.carisup.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Suplier"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.carisup)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(865, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 53)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
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
        'DGV1_NAMA
        '
        Me.DGV1_NAMA.DataPropertyName = "NAMA"
        Me.DGV1_NAMA.HeaderText = "Nama Suplier"
        Me.DGV1_NAMA.Name = "DGV1_NAMA"
        Me.DGV1_NAMA.ReadOnly = True
        Me.DGV1_NAMA.Width = 150
        '
        'DGV_SALDO
        '
        Me.DGV_SALDO.DataPropertyName = "SALDO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DGV_SALDO.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_SALDO.HeaderText = "Saldo Hutang"
        Me.DGV_SALDO.Name = "DGV_SALDO"
        Me.DGV_SALDO.ReadOnly = True
        '
        'DGV_BELI
        '
        Me.DGV_BELI.DataPropertyName = "BELI"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DGV_BELI.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_BELI.HeaderText = "Total Pembelian"
        Me.DGV_BELI.Name = "DGV_BELI"
        Me.DGV_BELI.ReadOnly = True
        '
        'DGV_REBELI
        '
        Me.DGV_REBELI.DataPropertyName = "REBELI"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DGV_REBELI.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_REBELI.HeaderText = "Total Retur Pembelian"
        Me.DGV_REBELI.Name = "DGV_REBELI"
        Me.DGV_REBELI.ReadOnly = True
        '
        'DGV1_GRANDTOTAL
        '
        Me.DGV1_GRANDTOTAL.DataPropertyName = "GRANDTOTAL"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DGV1_GRANDTOTAL.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV1_GRANDTOTAL.HeaderText = "Grand Total"
        Me.DGV1_GRANDTOTAL.Name = "DGV1_GRANDTOTAL"
        Me.DGV1_GRANDTOTAL.ReadOnly = True
        '
        'DGV1_BAYAR
        '
        Me.DGV1_BAYAR.DataPropertyName = "BAYAR"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DGV1_BAYAR.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV1_BAYAR.HeaderText = "Bayar"
        Me.DGV1_BAYAR.Name = "DGV1_BAYAR"
        Me.DGV1_BAYAR.ReadOnly = True
        '
        'DGV1_SISA
        '
        Me.DGV1_SISA.DataPropertyName = "SISA"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DGV1_SISA.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGV1_SISA.HeaderText = "Sisa"
        Me.DGV1_SISA.Name = "DGV1_SISA"
        Me.DGV1_SISA.ReadOnly = True
        '
        'DGV1_SUPLIER
        '
        Me.DGV1_SUPLIER.DataPropertyName = "SUPLIER"
        Me.DGV1_SUPLIER.HeaderText = "Column1"
        Me.DGV1_SUPLIER.Name = "DGV1_SUPLIER"
        Me.DGV1_SUPLIER.ReadOnly = True
        Me.DGV1_SUPLIER.Visible = False
        '
        'LIST_HUTANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_dat)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LIST_HUTANG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LIST_HUTANG"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_dat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents totsis As System.Windows.Forms.Label
    Friend WithEvents totbay As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tott As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_dat As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents carisup As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV1_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_NAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_BELI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_REBELI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_GRANDTOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_BAYAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_SISA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV1_SUPLIER As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
