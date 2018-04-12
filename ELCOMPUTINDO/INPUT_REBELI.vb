Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class INPUT_REBELI

    Sub nomor()
        Dim y, m As String
        y = Now.Year
        m = Now.Month
        Dim temp As String = ""
        Dim vall As String = ""
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_REBELI  ORDER BY ID DESC", konek)
        rddd = cmd.ExecuteReader

        If rddd.Read Then
            temp = rddd.Item("ID")
            vall = Val(temp) + 1
            txtid.Text = vall
            txtnofak.Text = "RB" + y + m + "000" + vall.ToString
        Else
            txtid.Text = 1
            txtnofak.Text = "RB" + y + m + "0001"
        End If
        konek.Close()
    End Sub

    Sub namasup()
        txtsup.DisplayMember = "Text"
        txtsup.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add(" ", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_PARTNER WHERE STATUS LIKE '%S'", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NAMA"), rddd("ID"))
        End While
        konek.Close()
        txtsup.DataSource = data

    End Sub

    Sub hitung()
        Dim pot1 As Double
        txtjumlah.Text = FormatNumber(CDbl(txtqty.Text) * CDbl(txtharga.Text), 0)
        pot1 = CDbl(txtjumlah.Text) - ((CDbl(txtjumlah.Text) * CDbl(txtpot1.Text)) / 100)
        txttotal.Text = FormatNumber(pot1 - (CDbl(txtpot2.Text) * (txtqty.Text)), 0)

        Dim total, jumlah As Double
        For i As Integer = 0 To DataGridView1.RowCount - 1
            total += CDbl(DataGridView1.Rows(i).Cells("DGV_TOTAL").Value)
            jumlah += CDbl(DataGridView1.Rows(i).Cells("DGV_JUMLAH").Value)
        Next
        txttotalbawah.Text = FormatNumber(jumlah, 0)
        txtpotbawah.Text = FormatNumber(jumlah - total, 0)
        txtgrandtotal.Text = FormatNumber(total, 0)

    End Sub

    Sub namabarang()
        txtbarang.Items.Clear()
        txtbarang.DisplayMember = "Text"
        txtbarang.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add(" ", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_BARANG", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NAMA"), rddd("ID"))
        End While
        konek.Close()
        txtbarang.DataSource = data

    End Sub

    Sub edit_det()
        DataGridView1.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT a.QTY*a.HARGA as JUMLAH, a.*,b.NAMA as NAMABARANG FROM TB_REBELI_DET a INNER JOIN TB_BARANG b on b.ID = a.IDBARANG WHERE a.NOFAK = '" & txtnofak.Text & "'", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        DataGridView1.DataSource = (dS)
        DataGridView1.Enabled = True
        dA.Dispose()
        konek.Close()
    End Sub

    Private Sub INPUT_REBELI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Label1.Text = "Edit Retur Pembelian" Then
            namasup()
            namabarang()
            txttgl.Focus()
        Else
            namasup()
            namabarang()
            txtsup.SelectedValue = idsup.Text
            txttgl.Focus()
            edit_det()
            hitung()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        For i As Integer = 0 To DataGridView1.RowCount - 1
            If txtbarang.SelectedValue = CDbl(DataGridView1.Rows(i).Cells("DGV_IDBARANG").Value) Then
                MsgBox("Barang Sudah ada !!!!  ", vbExclamation)
                txtbarang.Focus()
                Exit Sub
            End If
        Next

        If CDbl(txtqty.Text) < 1 Then
            MsgBox("Qty harus lebih besar dari 0 !!!!  ", vbExclamation)
            txtqty.Focus()
            Exit Sub
        End If

        If CDbl(txtharga.Text) < 1 Then
            MsgBox("Harga harus lebih besar dari 0 !!!!  ", vbExclamation)
            txtharga.Focus()
            Exit Sub
        End If


        If Label1.Text = "Edit Retur Pembelian" Then

            Dim cek As String = "F"
            Dim stocknya As String = ""
            Dim barangnya As String = ""
            For i As Integer = 0 To DataGridView1.RowCount - 1
                Dim tempqty As Integer = 0
                koneksi_db()
                Dim readqty As FbDataReader
                Dim cmdqty = New FbCommand("SELECT SUM(QTY) as QTY FROM TB_MUTASI WHERE IDBARANG = '" & CDbl(txtbarang.SelectedValue) & "' GROUP BY IDBARANG", konek)
                readqty = cmdqty.ExecuteReader

                If readqty.Read Then
                    tempqty = readqty.Item("QTY")
                End If
                konek.Close()

                If tempqty - CDbl(txtqty.Text) < 0 Then
                    cek = "T"
                    barangnya = txtbarang.Text
                    stocknya = tempqty.ToString
                    Exit For
                Else
                    cek = "F"
                    barangnya = ""
                    stocknya = ""
                End If
            Next

            If cek = "T" Then
                MsgBox("Untuk Barang " & barangnya & " Stock Kurang !!!, Stock sisa " & stocknya, vbExclamation)
                txtbarang.Focus()
                Exit Sub
            Else
                Dim temp As String = ""
                Dim vall As String = ""
                koneksi_db()
                Dim rddd As FbDataReader
                Dim cmd = New FbCommand("SELECT * FROM TB_REBELI_DET  ORDER BY ID DESC", konek)
                rddd = cmd.ExecuteReader

                If rddd.Read Then
                    temp = rddd.Item("ID")
                    vall = Val(temp) + 1
                Else
                    vall = "1"
                End If
                konek.Close()
                Dim simpan2 As String
                simpan2 = "INSERT INTO TB_REBELI_DET(ID, IDBARANG, QTY, HARGA, POT1, POT2, TOTAL, CREATE_USERID, STAMP, NOFAK)" _
                 + "VALUES ('" & vall & "'," _
                 + "'" & CDbl(txtbarang.SelectedValue) & "'," _
                 + "'" & CDbl(txtqty.Text) & "'," _
                 + "'" & CDbl(txtharga.Text) & "'," _
                 + "'" & CDbl(txtpot1.Text) & "'," _
                 + "'" & CDbl(txtpot2.Text) & "'," _
                 + "'" & CDbl(txttotal.Text) & "'," _
                 + "'" & HOME.usernya.Text & "'," _
                 + "cast('NOW' as timestamp)," _
                 + "'" & txtnofak.Text & "') ; "
                callprogress2(simpan2)
                edit_det()
                hitung()

                Dim temp2 As String = ""
                Dim vall2 As String = ""
                koneksi_db()
                Dim rddd2 As FbDataReader
                Dim cmd2 = New FbCommand("SELECT * FROM TB_MUTASI  ORDER BY ID DESC", konek)
                rddd2 = cmd2.ExecuteReader

                If rddd2.Read Then
                    temp2 = rddd2.Item("ID")
                    vall2 = Val(temp2) + 1
                Else
                    vall2 = "1"
                End If
                konek.Close()

                simpan2 = "INSERT INTO TB_MUTASI (ID, TGL, IDBARANG, QTY, HPP, TOTHPP, CREATE_UID, STAMP,NOFAK)" _
               + "VALUES ('" & vall2 & "'," _
               + "'" & CDate(txttgl.Text) & "'," _
               + "'" & CDbl(txtbarang.SelectedValue) & "'," _
               + "'" & CDbl(txtqty.Text) * -1 & "'," _
               + "'" & (CDbl(txttotal.Text) / CDbl(txtqty.Text)) & "'," _
               + "'" & CDbl(txttotal.Text) * -1 & "'," _
               + "'" & HOME.usernya.Text & "'," _
               + "cast('NOW' as timestamp)," _
               + "'" & txtnofak.Text & "') ; "
                callprogress2(simpan2)
            End If

        Else
            DataGridView1.Rows.Add(txtbarang.Text, txtqty.Text, txtharga.Text, txtjumlah.Text, txtpot1.Text, txtpot2.Text, txttotal.Text, txtbarang.SelectedValue)
        End If

        txtbarang.SelectedValue = 0
        txtqty.Text = "0"
        txtharga.Text = "0"
        txtjumlah.Text = "0"
        txtpot1.Text = "0"
        txtpot2.Text = "0"
        txttotal.Text = "0"
        hitung()
        txtbarang.Focus()

    End Sub

    Private Sub txtbarang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbarang.SelectedIndexChanged
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT SATUAN FROM TB_BARANG WHERE ID = '" & txtbarang.SelectedValue & "'", konek)
        rddd = cmd.ExecuteReader
        If rddd.Read() Then
            txtsat.Text = rddd("SATUAN")
        End If
        konek.Close()

    End Sub

    Private Sub txttgl_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttgl.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsup.Focus()
        End If
    End Sub

    Private Sub txtsup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsup.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtjt.Focus()
        End If
    End Sub

    Private Sub txtjt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtjt.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbarang.Focus()
        End If
    End Sub

    Private Sub txtbarang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtbarang.SelectedValue = 0 Then
                txtket.Focus()
            Else
                txtqty.Focus()
            End If
        End If
    End Sub

    Private Sub txtqty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtqty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtharga.Focus()
        End If
    End Sub

    Private Sub txtpot1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpot1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpot2.Focus()
        End If
    End Sub

    Private Sub txtharga_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtharga.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpot1.Focus()
        End If
    End Sub

    Private Sub txtpot2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpot2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button5.Focus()
        End If
    End Sub

    Private Sub txtqty_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.Leave
        hitung()
    End Sub

    Private Sub txtharga_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtharga.Leave
        txtharga.Text = FormatNumber(txtharga.Text, 0)
        hitung()
    End Sub

    Private Sub txtpot2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpot2.Leave
        txtpot2.Text = FormatNumber(txtpot2.Text, 0)
        hitung()
    End Sub

    Private Sub txtpot1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpot1.Leave
        hitung()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As Integer
        row = DataGridView1.CurrentRow.Index
        Dim pesan As Integer
        pesan = MsgBox("Hapus Barang ??", vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then Exit Sub
        If Label1.Text = "Edit Retur Pembelian" Then
            Dim temp2 As String = ""
            Dim vall2 As String = ""
            koneksi_db()
            Dim rddd2 As FbDataReader
            Dim cmd2 = New FbCommand("SELECT * FROM TB_MUTASI  ORDER BY ID DESC", konek)
            rddd2 = cmd2.ExecuteReader

            If rddd2.Read Then
                temp2 = rddd2.Item("ID")
                vall2 = Val(temp2) + 1
            Else
                vall2 = "1"
            End If
            konek.Close()
            Dim simpan3 As String
            simpan3 = "INSERT INTO TB_MUTASI (ID, NOFAK, IDBARANG, QTY, HPP, TOTHPP, CREATE_UID, STAMP,TGL)" _
           + "VALUES ('" & vall2 & "'," _
           + "'" & txtnofak.Text & "'," _
           + "'" & CDbl(DataGridView1.Rows(row).Cells("DGV_IDBARANG").Value) & "'," _
           + "'" & CDbl(DataGridView1.Rows(row).Cells("DGV_QTY").Value) & "'," _
           + "'" & CDbl(DataGridView1.Rows(row).Cells("DGV_TOTAL").Value) / CDbl(DataGridView1.Rows(row).Cells("DGV_QTY").Value) & "'," _
           + "'" & CDbl(DataGridView1.Rows(row).Cells("DGV_TOTAL").Value) & "'," _
           + "'" & HOME.usernya.Text & "'," _
           + "cast('NOW' as timestamp)," _
           + "'" & CDate(txttgl.Text) & "') ; "
            callprogress2(simpan3)

            Dim hapus2 As String
            hapus2 = "DELETE FROM TB_REBELI_DET WHERE NOFAK ='" & txtnofak.Text & "' AND IDBARANG = '" & CDbl(DataGridView1.Rows(row).Cells("DGV_IDBARANG").Value) & "'"
            callprogress2(hapus2)
            edit_det()
            hitung()
        Else
            DataGridView1.Rows.RemoveAt(row)
        End If
        hitung()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtsup.SelectedValue = 0 Then
            MsgBox("Pilih Suplier !!!!  ", vbExclamation)
            txtbarang.Focus()
            Exit Sub
        End If

        If txtsup.SelectedValue = Nothing Then
            MsgBox("Pilih Suplier !!!!  ", vbExclamation)
            txtbarang.Focus()
            Exit Sub
        End If

        If DataGridView1.RowCount < 1 Then
            MsgBox("Pilih Barang Terlebih dahulu !!!!  ", vbExclamation)
            txtbarang.Focus()
            Exit Sub
        End If

        Dim cek As String = "F"
        Dim stocknya As String = ""
        Dim barangnya As String = ""
        For i As Integer = 0 To DataGridView1.RowCount - 1
            Dim tempqty As Integer = 0
            koneksi_db()
            Dim readqty As FbDataReader
            Dim cmdqty = New FbCommand("SELECT SUM(QTY) as QTY FROM TB_MUTASI WHERE IDBARANG = '" & CDbl(DataGridView1.Rows(i).Cells("DGV_IDBARANG").Value) & "' GROUP BY IDBARANG", konek)
            readqty = cmdqty.ExecuteReader

            If readqty.Read Then
                tempqty = readqty.Item("QTY")
            End If
            konek.Close()

            If tempqty - CDbl(DataGridView1.Rows(i).Cells("DGV_QTY").Value) < 0 Then
                cek = "T"
                barangnya = DataGridView1.Rows(i).Cells("DGV_NAMABARANG").Value.ToString
                stocknya = tempqty.ToString
                Exit For
            Else
                cek = "F"
                barangnya = ""
                stocknya = ""
            End If
        Next

        If cek = "T" Then
            MsgBox("Untuk Barang " & barangnya & " Stock Kurang !!!, Stock sisa " & stocknya, vbExclamation)
            txtbarang.Focus()
            Exit Sub
        Else
            nomor()
            Dim simpan, simpan2, simpan3 As String

            simpan = "INSERT INTO TB_REBELI(ID,LUNAS, NOFAK, TGL, SUPLIER, JT, POT, GRANDTOTAL, BAYAR, CREATE_USERID, STAMP, KET)" _
               + "VALUES ('" & txtid.Text & "'," _
                + "'N'," _
               + "'" & txtnofak.Text & "'," _
               + "'" & CDate(txttgl.Text) & "'," _
               + "'" & txtsup.SelectedValue & "'," _
               + "'" & CDate(txtjt.Text) & "'," _
               + "'" & CDbl(txtpotbawah.Text) & "'," _
               + "'" & CDbl(txtgrandtotal.Text) & "'," _
               + "'" & CDbl(0) & "'," _
               + "'" & HOME.usernya.Text & "'," _
               + "cast('NOW' as timestamp)," _
               + "'" & txtket.Text & "') ; "
            callprogress(simpan)

            For i As Integer = 0 To DataGridView1.RowCount - 1
                Dim temp As String = ""
                Dim vall As String = ""
                koneksi_db()
                Dim rddd As FbDataReader
                Dim cmd = New FbCommand("SELECT * FROM TB_REBELI_DET  ORDER BY ID DESC", konek)
                rddd = cmd.ExecuteReader

                If rddd.Read Then
                    temp = rddd.Item("ID")
                    vall = Val(temp) + 1
                Else
                    vall = "1"
                End If
                konek.Close()

                simpan2 = "INSERT INTO TB_REBELI_DET(ID, IDBARANG, QTY, HARGA, POT1, POT2, TOTAL, CREATE_USERID, STAMP, NOFAK)" _
                 + "VALUES ('" & vall & "'," _
                 + "'" & CDbl(DataGridView1.Rows(i).Cells("DGV_IDBARANG").Value) & "'," _
                 + "'" & CDbl(DataGridView1.Rows(i).Cells("DGV_QTY").Value) & "'," _
                 + "'" & CDbl(DataGridView1.Rows(i).Cells("DGV_HARGA").Value) & "'," _
                 + "'" & CDbl(DataGridView1.Rows(i).Cells("DGV_POT1").Value) & "'," _
                 + "'" & CDbl(DataGridView1.Rows(i).Cells("DGV_POT2").Value) & "'," _
                 + "'" & CDbl(DataGridView1.Rows(i).Cells("DGV_TOTAL").Value) & "'," _
                 + "'" & HOME.usernya.Text & "'," _
                 + "cast('NOW' as timestamp)," _
                 + "'" & txtnofak.Text & "') ; "
                callprogress2(simpan2)

                Dim temp2 As String = ""
                Dim vall2 As String = ""
                koneksi_db()
                Dim rddd2 As FbDataReader
                Dim cmd2 = New FbCommand("SELECT * FROM TB_MUTASI  ORDER BY ID DESC", konek)
                rddd2 = cmd2.ExecuteReader

                If rddd2.Read Then
                    temp2 = rddd2.Item("ID")
                    vall2 = Val(temp2) + 1
                Else
                    vall2 = "1"
                End If
                konek.Close()

                simpan3 = "INSERT INTO TB_MUTASI (ID, NOFAK, IDBARANG, QTY, HPP, TOTHPP, CREATE_UID, STAMP,TGL)" _
               + "VALUES ('" & vall2 & "'," _
               + "'" & txtnofak.Text & "'," _
               + "'" & CDbl(DataGridView1.Rows(i).Cells("DGV_IDBARANG").Value) & "'," _
               + "'" & CDbl(DataGridView1.Rows(i).Cells("DGV_QTY").Value) * -1 & "'," _
               + "'" & (CDbl(DataGridView1.Rows(i).Cells("DGV_TOTAL").Value) / CDbl(DataGridView1.Rows(i).Cells("DGV_QTY").Value)) & "'," _
               + "'" & CDbl(DataGridView1.Rows(i).Cells("DGV_TOTAL").Value) * -1 & "'," _
               + "'" & HOME.usernya.Text & "'," _
               + "cast('NOW' as timestamp)," _
               + "'" & CDate(txttgl.Text) & "') ; "
                callprogress2(simpan3)
            Next


            txttgl.Value = Now
            txtjt.Value = Now
            txtsup.SelectedValue = 0
            txtket.Clear()
            txttotalbawah.Text = "0"
            txtpotbawah.Text = "0"
            txtgrandtotal.Text = "0"

            DataGridView1.Rows.Clear()
            txtnofak.Clear()
            txttgl.Focus()
        End If
       

    End Sub

    Private Sub txtket_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtket.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.Focus()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CARI_BARANG.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtsup.SelectedValue = 0 Then
            MsgBox("Pilih Suplier !!!!  ", vbExclamation)
            txtbarang.Focus()
            Exit Sub
        End If

        If txtsup.SelectedValue = Nothing Then
            MsgBox("Pilih Suplier !!!!  ", vbExclamation)
            txtbarang.Focus()
            Exit Sub
        End If

        If DataGridView1.RowCount < 1 Then
            MsgBox("Pilih Barang Terlebih dahulu !!!!  ", vbExclamation)
            txtbarang.Focus()
            Exit Sub
        End If
        hitung()
        Dim simpan As String

        simpan = "UPDATE TB_REBELI SET " _
           + "NOFAK = '" & txtnofak.Text & "'," _
           + "TGL = '" & CDate(txttgl.Text) & "'," _
           + "SUPLIER = '" & txtsup.SelectedValue & "'," _
           + "JT = '" & CDate(txtjt.Text) & "'," _
           + "POT = '" & CDbl(txtpotbawah.Text) & "'," _
           + "GRANDTOTAL = '" & CDbl(txtgrandtotal.Text) & "'," _
           + "BAYAR = '" & CDbl(0) & "'," _
           + "CREATE_USERID = '" & HOME.usernya.Text & "'," _
           + "STAMP = cast('NOW' as timestamp)," _
           + "KET = '" & txtket.Text & "' WHERE ID = '" & txtid.Text & "'; "
        callprogress(simpan)

        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As DATA_REBELI
        frm = New DATA_REBELI
        frm.Text = "HOME"
        frm.MdiParent = HOME
        frm.Show()
        frm.Dock = DockStyle.Fill

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Hapus, Hapus2 As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin akan menghapus Data ??", vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then Exit Sub

        Dim data As New DataTable
        data.Columns.Add("IDBARANG", GetType(String))
        data.Columns.Add("QTY", GetType(String))
        data.Columns.Add("TOTAL", GetType(String))

        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_REBELI_DET WHERE NOFAK = '" & txtnofak.Text & "'", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("IDBARANG"), rddd("QTY"), rddd("TOTAL"))
        End While
        konek.Close()

        For i As Integer = 0 To data.Rows.Count - 1
            Dim temp2 As String = ""
            Dim vall2 As String = ""
            koneksi_db()
            Dim rddd2 As FbDataReader
            Dim cmd2 = New FbCommand("SELECT * FROM TB_MUTASI  ORDER BY ID DESC", konek)
            rddd2 = cmd2.ExecuteReader

            If rddd2.Read Then
                temp2 = rddd2.Item("ID")
                vall2 = Val(temp2) + 1
            Else
                vall2 = "1"
            End If
            konek.Close()
            Dim simpan3 As String
            simpan3 = "INSERT INTO TB_MUTASI (ID, NOFAK, IDBARANG, QTY, HPP, TOTHPP, CREATE_UID, STAMP,TGL)" _
           + "VALUES ('" & vall2 & "'," _
           + "'" & txtnofak.Text & "'," _
           + "'" & CDbl(data.Rows(i).Item("IDBARANG").ToString) & "'," _
           + "'" & CDbl(data.Rows(i).Item("QTY").ToString) & "'," _
           + "'" & CDbl(data.Rows(i).Item("TOTAL").ToString) / CDbl(data.Rows(i).Item("QTY").ToString) & "'," _
           + "'" & CDbl(data.Rows(i).Item("TOTAL").ToString) & "'," _
           + "'" & HOME.usernya.Text & "'," _
           + "cast('NOW' as timestamp)," _
           + "'" & CDate(txttgl.Text) & "') ; "
            callprogress2(simpan3)
        Next

        Hapus2 = "DELETE FROM TB_REBELI_DET WHERE NOFAK ='" & txtnofak.Text & "'"
        Hapus = "DELETE FROM TB_REBELI WHERE ID ='" & txtid.Text & "'"
        callprogress2(Hapus2)
        callprogress(Hapus)
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As DATA_REBELI
        frm = New DATA_REBELI
        frm.Text = "HOME"
        frm.MdiParent = HOME
        frm.Show()
        frm.Dock = DockStyle.Fill

    End Sub
End Class