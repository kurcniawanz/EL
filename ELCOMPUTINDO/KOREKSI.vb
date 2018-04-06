Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class KOREKSI

    Sub nomor()
        Dim y, m As String
        y = Now.Year
        m = Now.Month
        Dim temp As String = ""
        Dim vall As String = ""
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_MUTASI  ORDER BY ID DESC", konek)
        rddd = cmd.ExecuteReader

        If rddd.Read Then
            temp = rddd.Item("ID")
            vall = Val(temp) + 1
            txtid.Text = vall
            txtnofak.Text = "KR" + y + m + "000" + vall.ToString
        Else
            txtid.Text = 1
            txtnofak.Text = "KR" + y + m + "0001"
        End If
        konek.Close()
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

    Sub loaddata()
        DataGridView1.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT a.ID, a.TGL,a.NOFAK,a.IDBARANG,a.QTY,a.HPP,a.TOTHPP,a.CREATE_UID,a.KET,a.STAMP, b.NAMA, b.SATUAN FROM TB_MUTASI a inner join TB_BARANG b ON b.id = a.IDBARANG  WHERE a.NOFAK LIKE 'KR%'", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        DataGridView1.DataSource = (dS)
        DataGridView1.Enabled = True
        dA.Dispose()
        konek.Close()
    End Sub

    Private Sub KOREKSI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        namabarang()
        loaddata()
        txttgl.Focus()
    End Sub

    Sub hitung()
        txtharga.Text = FormatNumber(txtharga.Text, 0)
        txttotal.Text = FormatNumber(CDbl(txtqty.Text) * CDbl(txtharga.Text), 0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtbarang.SelectedValue = 0 Then
            MsgBox("Pilih barang !!!!  ", vbExclamation)
            txtbarang.Focus()
            Exit Sub
        End If

        If txtbarang.SelectedValue = Nothing Then
            MsgBox("Pilih barang !!!!  ", vbExclamation)
            txtbarang.Focus()
            Exit Sub
        End If
        nomor()
        Dim simpan As String
        simpan = "INSERT INTO TB_MUTASI(ID, TGL, NOFAK, IDBARANG, QTY, HPP, CREATE_UID, STAMP, KET, TOTHPP)" _
           + "VALUES ('" & txtid.Text & "'," _
           + "'" & CDate(txttgl.Text) & "'," _
           + "'" & txtnofak.Text & "'," _
           + "'" & txtbarang.SelectedValue & "'," _
           + "'" & CDbl(txtqty.Text) & "'," _
           + "'" & CDbl(txtharga.Text) & "'," _
           + "'" & HOME.usernya.Text & "'," _
           + "cast('NOW' as timestamp)," _
           + "'" & txtket.Text & "'," _
           + "'" & CDbl(txttotal.Text) & "') ; "
        callprogress(simpan)
        loaddata()
        txtid.Clear()
        txtnofak.Clear()
        txtket.Clear()
        txtbarang.SelectedValue = 0
        txtqty.Text = "0"
        txtharga.Text = "0"
        txttotal.Text = "0"
        txttgl.Value = Now
        txttgl.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       
        Dim edit As String
        edit = "UPDATE TB_MUTASI SET STAMP = cast('NOW' as timestamp), TGL = '" & CDate(txttgl.Text) & "', IDBARANG = '" & txtbarang.SelectedValue & "',QTY = '" & CDbl(txtqty.Text) & "', " _
            + " HPP = '" & CDbl(txtharga.Text) & "', TOTHPP = '" & CDbl(txttotal.Text) & "', KET = '" & txtket.Text & "', CREATE_UID = '" & HOME.usernya.Text & "' WHERE ID = '" & txtid.Text & "' "
        callprogress(edit)
        loaddata()
        txtid.Clear()
        txtnofak.Clear()
        txtket.Clear()
        txtbarang.SelectedValue = 0
        txtqty.Text = "0"
        txtharga.Text = "0"
        txttotal.Text = "0"
        txttgl.Value = Now
        txttgl.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Hapus As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin akan menghapus Data ??", vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then Exit Sub
        Hapus = "DELETE FROM TB_MUTASI WHERE ID ='" & txtid.Text & "'"
        callprogress(Hapus)
        loaddata()
        txtid.Clear()
        txtnofak.Clear()
        txtket.Clear()
        txtbarang.SelectedValue = 0
        txtqty.Text = "0"
        txtharga.Text = "0"
        txttotal.Text = "0"
        txttgl.Value = Now
        txttgl.Focus()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtid.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_ID").Value.ToString
        txtnofak.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_NOFAK").Value.ToString
        txttgl.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_TGL").Value.ToString
        txtbarang.SelectedValue = DataGridView1.Rows(e.RowIndex).Cells("DGV_IDBARANG").Value
        txtqty.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_QTY").Value.ToString
        txtharga.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_HPP").Value.ToString
        txttotal.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_TOTHPP").Value.ToString
        txtket.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_KET").Value.ToString
        txttgl.Focus()
    End Sub

    Private Sub txttgl_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttgl.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbarang.Focus()
        End If
    End Sub

    Private Sub txtbarang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtqty.Focus()
        End If
    End Sub

    Private Sub txtqty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtqty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtharga.Focus()
        End If
    End Sub

    Private Sub txtharga_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtharga.KeyDown
        If e.KeyCode = Keys.Enter Then
            txttotal.Focus()
        End If
    End Sub

    Private Sub txttotal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtket.Focus()
        End If
    End Sub

    Private Sub txtket_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtket.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.Focus()
        End If
    End Sub

    Private Sub txtqty_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.Leave
        hitung()
    End Sub

    Private Sub txtharga_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtharga.Leave
        hitung()
    End Sub
End Class