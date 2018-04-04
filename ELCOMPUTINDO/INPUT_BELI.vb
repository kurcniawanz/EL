Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class INPUT_BELI

    Sub nomor()
        Dim y, m As String
        y = Now.Year
        m = Now.Month
        Dim temp As String = ""
        Dim vall As String = ""
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_BELI  ORDER BY ID DESC", konek)
        rddd = cmd.ExecuteReader

        If rddd.Read Then
            temp = rddd.Item("ID")
            vall = Val(temp) + 1
            txtid.Text = vall
            txtnofak.Text = "BL" + y + m + "000" + vall.ToString
        Else
            txtid.Text = 1
            txtnofak.Text = "BL" + y + m + "0001"
        End If
        konek.Close()
    End Sub

    Sub namasup()
        txtsup.Items.Clear()
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
        txtsup.SelectedValue = 0
    End Sub

    Sub hitung()
        Dim pot1 As Double
        txtjumlah.Text = FormatNumber(CDbl(txtqty.Text) * CDbl(txtharga.Text), 0)
        pot1 = CDbl(txtjumlah.Text) - ((CDbl(txtjumlah.Text) * CDbl(txtpot1.Text)) / 100)
        txttotal.Text = FormatNumber(pot1 - CDbl(txtpot2.Text), 0)

        Dim total, jumlah As Double
        For i As Integer = 0 To DataGridView1.RowCount - 1
            total += CDbl(DataGridView1.Rows(i).Cells("DGV_TOTAL").Value)
            jumlah += CDbl(DataGridView1.Rows(i).Cells("DGV_JUMLAH").Value)
        Next
        txttotalbawah.Text = FormatNumber(jumlah, 0)
        txtpotbawah.Text = FormatNumber(jumlah - total, 0)
        txtgrandtotal.Text = FormatNumber(total, 0)
        txtsisa.Text = FormatNumber(total - CDbl(txtbayar.Text), 0)
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
        txtbarang.SelectedValue = 0
    End Sub

    Private Sub INPUT_BELI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        namasup()
        namabarang()
        txttgl.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If txtbarang.SelectedValue = CDbl(DataGridView1.Rows(i).Cells("DGV_IDBARANG").Value) Then
                MsgBox("Barang Sudah ada !!!!  ", vbExclamation)
                txtbarang.Focus()
                Exit Sub
            End If
        Next


        DataGridView1.Rows.Add(txtbarang.Text, txtqty.Text, txtharga.Text, txtjumlah.Text, txtpot1.Text, txtpot2.Text, txttotal.Text, txtbarang.SelectedValue)
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

    Private Sub txtbayar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbayar.Leave
        txtbayar.Text = FormatNumber(txtbayar.Text, 0)
        txtsisa.Text = FormatNumber(CDbl(txtgrandtotal.Text) - CDbl(txtbayar.Text), 0)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As Integer
        row = DataGridView1.CurrentRow.Index
        Dim pesan As Integer
        pesan = MsgBox("Hapus Barang ??", vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then Exit Sub
        DataGridView1.Rows.RemoveAt(row)
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

        nomor()
        Dim simpan, simpan2 As String

        simpan = "INSERT INTO TB_BELI(ID, NOFAK, TGL, SUPLIER, JT, POT, GRANDTOTAL, BAYAR, CREATE_USERID, STAMP, KET)" _
           + "VALUES ('" & txtid.Text & "'," _
           + "'" & txtnofak.Text & "'," _
           + "'" & CDate(txttgl.Text) & "'," _
           + "'" & txtsup.SelectedValue & "'," _
           + "'" & CDate(txtjt.Text) & "'," _
           + "'" & CDbl(txtpotbawah.Text) & "'," _
           + "'" & CDbl(txtgrandtotal.Text) & "'," _
           + "'" & CDbl(txtbayar.Text) & "'," _
           + "'" & HOME.usernya.Text & "'," _
           + "cast('NOW' as timestamp)," _
           + "'" & txtket.Text & "') ; "
        callprogress(simpan)

        For i As Integer = 0 To DataGridView1.RowCount - 1
            Dim temp As String = ""
            Dim vall As String = ""
            koneksi_db()
            Dim rddd As FbDataReader
            Dim cmd = New FbCommand("SELECT * FROM TB_BELI_DET  ORDER BY ID DESC", konek)
            rddd = cmd.ExecuteReader

            If rddd.Read Then
                temp = rddd.Item("ID")
                vall = Val(temp) + 1
            Else
                vall = "1"
            End If
            konek.Close()

            simpan2 = "INSERT INTO TB_BELI_DET(ID, IDBARANG, QTY, HARGA, POT1, POT2, TOTAL, CREATE_USERID, STAMP, NOFAK)" _
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
        Next


        txttgl.Value = Now
        txtjt.Value = Now
        txtsup.SelectedValue = 0
        txtket.Clear()
        txttotalbawah.Text = "0"
        txtpotbawah.Text = "0"
        txtgrandtotal.Text = "0"
        txtbayar.Text = "0"
        txtsisa.Text = "0"
        DataGridView1.Rows.Clear()
        txtnofak.Clear()
        txttgl.Focus()

    End Sub

    Private Sub txtket_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtket.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbayar.Focus()
        End If
    End Sub

    Private Sub txtbayar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.Focus()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CARI_BARANG.Show()
    End Sub
End Class