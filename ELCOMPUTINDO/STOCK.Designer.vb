<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STOCK
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
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.carimin = New System.Windows.Forms.CheckBox()
        Me.carikel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.carinama = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_ID, Me.DGV_NAMA, Me.DGV_KELOMPOKNAMA, Me.DGV_QTY, Me.DGV_HPP, Me.DGV_TOTHPP, Me.DGV_MINIMAL, Me.DGV_SATUAN, Me.DGV_HARGAJUAL, Me.DGV_KET, Me.DGV_CREATE_USERID, Me.DGV_STAMP, Me.DGV_KELOMPOK})
        Me.DataGridView1.Location = New System.Drawing.Point(17, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1121, 551)
        Me.DataGridView1.TabIndex = 24
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
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "N0"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.DGV_QTY.DefaultCellStyle = DataGridViewCellStyle24
        Me.DGV_QTY.HeaderText = "QTY"
        Me.DGV_QTY.Name = "DGV_QTY"
        Me.DGV_QTY.ReadOnly = True
        '
        'DGV_HPP
        '
        Me.DGV_HPP.DataPropertyName = "HPP"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.Format = "N2"
        DataGridViewCellStyle25.NullValue = Nothing
        Me.DGV_HPP.DefaultCellStyle = DataGridViewCellStyle25
        Me.DGV_HPP.HeaderText = "Hpp (Rp.)"
        Me.DGV_HPP.Name = "DGV_HPP"
        Me.DGV_HPP.ReadOnly = True
        '
        'DGV_TOTHPP
        '
        Me.DGV_TOTHPP.DataPropertyName = "TOTHPP"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle26.Format = "N2"
        DataGridViewCellStyle26.NullValue = Nothing
        Me.DGV_TOTHPP.DefaultCellStyle = DataGridViewCellStyle26
        Me.DGV_TOTHPP.HeaderText = "Total Hpp (Rp.)"
        Me.DGV_TOTHPP.Name = "DGV_TOTHPP"
        Me.DGV_TOTHPP.ReadOnly = True
        '
        'DGV_MINIMAL
        '
        Me.DGV_MINIMAL.DataPropertyName = "MINIMAL"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "N0"
        DataGridViewCellStyle27.NullValue = Nothing
        Me.DGV_MINIMAL.DefaultCellStyle = DataGridViewCellStyle27
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
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Format = "N2"
        DataGridViewCellStyle28.NullValue = Nothing
        Me.DGV_HARGAJUAL.DefaultCellStyle = DataGridViewCellStyle28
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
        Me.DGV_KET.Width = 250
        '
        'DGV_CREATE_USERID
        '
        Me.DGV_CREATE_USERID.DataPropertyName = "CREATE_USERID"
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
        'DGV_KELOMPOK
        '
        Me.DGV_KELOMPOK.DataPropertyName = "KELOMPOK"
        Me.DGV_KELOMPOK.HeaderText = "Column1"
        Me.DGV_KELOMPOK.Name = "DGV_KELOMPOK"
        Me.DGV_KELOMPOK.ReadOnly = True
        Me.DGV_KELOMPOK.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 29)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Stock Barang"
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
        Me.GroupBox2.Location = New System.Drawing.Point(443, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(695, 53)
        Me.GroupBox2.TabIndex = 0
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
        Me.carinama.TabIndex = 0
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
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 654)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "*Click 2x untuk Edit/hapus"
        '
        'STOCK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 676)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "STOCK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "STOCK"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents carinama As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents carikel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents carimin As System.Windows.Forms.CheckBox
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
