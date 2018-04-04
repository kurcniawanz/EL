<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CARI_BARANG
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.carimin = New System.Windows.Forms.CheckBox()
        Me.carikel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.carinama = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_NAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_KELOMPOKNAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_HPP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_TOTHPP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_MINIMAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_SATUAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_HARGAJUAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_KET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_CREATE_USERID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_STAMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_KELOMPOK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.carimin)
        Me.GroupBox2.Controls.Add(Me.carikel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.carinama)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(191, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(695, 53)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'carimin
        '
        Me.carimin.AutoSize = True
        Me.carimin.Location = New System.Drawing.Point(499, 20)
        Me.carimin.Name = "carimin"
        Me.carimin.Size = New System.Drawing.Size(92, 17)
        Me.carimin.TabIndex = 29
        Me.carimin.Text = "Stock Minimal"
        Me.carimin.UseVisualStyleBackColor = True
        '
        'carikel
        '
        Me.carikel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.carikel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.carikel.FormattingEnabled = True
        Me.carikel.Location = New System.Drawing.Point(303, 18)
        Me.carikel.Name = "carikel"
        Me.carikel.Size = New System.Drawing.Size(190, 21)
        Me.carikel.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Kelompok"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(597, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Cari"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'carinama
        '
        Me.carinama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.carinama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.carinama.FormattingEnabled = True
        Me.carinama.Location = New System.Drawing.Point(47, 18)
        Me.carinama.Name = "carinama"
        Me.carinama.Size = New System.Drawing.Size(190, 21)
        Me.carinama.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Nama"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_ID, Me.DGV_NAMA, Me.DGV_KELOMPOKNAMA, Me.DGV_QTY, Me.DGV_HPP, Me.DGV_TOTHPP, Me.DGV_MINIMAL, Me.DGV_SATUAN, Me.DGV_HARGAJUAL, Me.DGV_KET, Me.DGV_CREATE_USERID, Me.DGV_STAMP, Me.DGV_KELOMPOK})
        Me.DataGridView1.Location = New System.Drawing.Point(17, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(869, 310)
        Me.DataGridView1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 29)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Cari Barang"
        '
        'DGV_ID
        '
        Me.DGV_ID.DataPropertyName = "ID"
        Me.DGV_ID.HeaderText = "ID"
        Me.DGV_ID.Name = "DGV_ID"
        Me.DGV_ID.ReadOnly = True
        Me.DGV_ID.Width = 40
        '
        'DGV_NAMA
        '
        Me.DGV_NAMA.DataPropertyName = "NAMA"
        Me.DGV_NAMA.HeaderText = "Nama Barang"
        Me.DGV_NAMA.Name = "DGV_NAMA"
        Me.DGV_NAMA.ReadOnly = True
        Me.DGV_NAMA.Width = 200
        '
        'DGV_KELOMPOKNAMA
        '
        Me.DGV_KELOMPOKNAMA.DataPropertyName = "KELOMPOKNAMA"
        Me.DGV_KELOMPOKNAMA.HeaderText = "Kelompok Barang"
        Me.DGV_KELOMPOKNAMA.Name = "DGV_KELOMPOKNAMA"
        Me.DGV_KELOMPOKNAMA.ReadOnly = True
        '
        'DGV_QTY
        '
        Me.DGV_QTY.DataPropertyName = "QTY"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DGV_QTY.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_QTY.HeaderText = "QTY"
        Me.DGV_QTY.Name = "DGV_QTY"
        Me.DGV_QTY.ReadOnly = True
        '
        'DGV_HPP
        '
        Me.DGV_HPP.DataPropertyName = "HPP"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DGV_HPP.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_HPP.HeaderText = "Hpp (Rp.)"
        Me.DGV_HPP.Name = "DGV_HPP"
        Me.DGV_HPP.ReadOnly = True
        Me.DGV_HPP.Visible = False
        '
        'DGV_TOTHPP
        '
        Me.DGV_TOTHPP.DataPropertyName = "TOTHPP"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DGV_TOTHPP.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_TOTHPP.HeaderText = "Total Hpp (Rp.)"
        Me.DGV_TOTHPP.Name = "DGV_TOTHPP"
        Me.DGV_TOTHPP.ReadOnly = True
        '
        'DGV_MINIMAL
        '
        Me.DGV_MINIMAL.DataPropertyName = "MINIMAL"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DGV_MINIMAL.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_MINIMAL.HeaderText = "Stock Minimal"
        Me.DGV_MINIMAL.Name = "DGV_MINIMAL"
        Me.DGV_MINIMAL.ReadOnly = True
        '
        'DGV_SATUAN
        '
        Me.DGV_SATUAN.DataPropertyName = "SATUAN"
        Me.DGV_SATUAN.HeaderText = "Satuan"
        Me.DGV_SATUAN.Name = "DGV_SATUAN"
        Me.DGV_SATUAN.ReadOnly = True
        '
        'DGV_HARGAJUAL
        '
        Me.DGV_HARGAJUAL.DataPropertyName = "HARGAJUAL"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DGV_HARGAJUAL.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_HARGAJUAL.HeaderText = "Harga Jual Minimal(Rp.)"
        Me.DGV_HARGAJUAL.Name = "DGV_HARGAJUAL"
        Me.DGV_HARGAJUAL.ReadOnly = True
        '
        'DGV_KET
        '
        Me.DGV_KET.DataPropertyName = "KET"
        Me.DGV_KET.HeaderText = "Keterangan"
        Me.DGV_KET.Name = "DGV_KET"
        Me.DGV_KET.ReadOnly = True
        Me.DGV_KET.Visible = False
        Me.DGV_KET.Width = 250
        '
        'DGV_CREATE_USERID
        '
        Me.DGV_CREATE_USERID.DataPropertyName = "CREATE_USERID"
        Me.DGV_CREATE_USERID.HeaderText = "CREATE_USERID"
        Me.DGV_CREATE_USERID.Name = "DGV_CREATE_USERID"
        Me.DGV_CREATE_USERID.ReadOnly = True
        Me.DGV_CREATE_USERID.Visible = False
        Me.DGV_CREATE_USERID.Width = 150
        '
        'DGV_STAMP
        '
        Me.DGV_STAMP.DataPropertyName = "STAMP"
        Me.DGV_STAMP.HeaderText = "STAMP"
        Me.DGV_STAMP.Name = "DGV_STAMP"
        Me.DGV_STAMP.ReadOnly = True
        Me.DGV_STAMP.Visible = False
        Me.DGV_STAMP.Width = 150
        '
        'DGV_KELOMPOK
        '
        Me.DGV_KELOMPOK.DataPropertyName = "KELOMPOK"
        Me.DGV_KELOMPOK.HeaderText = "Column1"
        Me.DGV_KELOMPOK.Name = "DGV_KELOMPOK"
        Me.DGV_KELOMPOK.ReadOnly = True
        Me.DGV_KELOMPOK.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "*Click 2x untuk Pilih Barang"
        '
        'CARI_BARANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 419)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CARI_BARANG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARI_BARANG"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents carimin As System.Windows.Forms.CheckBox
    Friend WithEvents carikel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents carinama As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_NAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_KELOMPOKNAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_HPP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_TOTHPP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_MINIMAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_SATUAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_HARGAJUAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_KET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_CREATE_USERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_STAMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_KELOMPOK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
