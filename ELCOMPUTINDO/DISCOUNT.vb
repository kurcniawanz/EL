Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class DISCOUNT

    Sub nomor()
        Dim temp As String = ""
        Dim vall As String = ""
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_DISCOUNT  ORDER BY ID DESC", konek)
        rddd = cmd.ExecuteReader

        If rddd.Read Then
            temp = rddd.Item("ID")
            vall = Val(temp) + 1
            txtid.Text = vall
        Else
            txtid.Text = 1
        End If
        konek.Close()
    End Sub

    Sub nama()
        txtkelompok.DisplayMember = "Text"
        txtkelompok.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add(" ", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_CATEGORY", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NAMA"), rddd("ID"))
        End While
        konek.Close()
        txtkelompok.DataSource = data
        txtkelompok.SelectedValue = 0
    End Sub

    Sub loaddata()
        DataGridView2.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT a.*,b.NAMA FROM TB_DISCOUNT a INNER JOIN TB_CATEGORY b ON b.ID = a.KELBARANG", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        DataGridView2.DataSource = (dS)
        DataGridView2.Enabled = True
        dA.Dispose()
        konek.Close()
    End Sub

    Private Sub DISCOUNT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        nama()
        loaddata()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtkelompok.Text = "" Then
            MsgBox("Pilih Kelompok barang !!!!  ", vbExclamation)
            txtkelompok.Focus()
            Exit Sub
        End If

        If txtqty1.Text = "" Then
            MsgBox("Isi Qty1 !!!!  ", vbExclamation)
            txtqty1.Focus()
        End If

        If txtqty2.Text = "" Then
            MsgBox("Isi Qty2 !!!!  ", vbExclamation)
            txtqty2.Focus()
            Exit Sub
        End If

        If txtdis.Text = "" Then
            MsgBox("Isi Discount !!!!  ", vbExclamation)
            txtdis.Focus()
            Exit Sub
        End If

        nomor()
        Dim simpan As String
        simpan = "INSERT INTO TB_DISCOUNT(ID,KELBARANG,QTY1,QTY2,CREATE_USERID,STAMP,DISCOUNT)" _
           + "VALUES ('" & txtid.Text & "'," _
           + "'" & txtkelompok.SelectedValue & "'," _
           + "'" & CDbl(txtqty1.Text) & "'," _
           + "'" & CDbl(txtqty2.Text) & "'," _
           + "'" & HOME.usernya.Text & "'," _
           + "cast('NOW' as timestamp)," _
           + "'" & CDbl(txtdis.Text) & "') ; "
        callprogress(simpan)
        loaddata()
        txtid.Clear()
        txtqty1.Text = "0"
        txtqty2.Text = "0"
        txtdis.Text = "0"
        txtkelompok.SelectedValue = 0
        txtkelompok.Focus()

    End Sub

    Private Sub DataGridView2_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        txtid.Text = DataGridView2.Rows(e.RowIndex).Cells("DGV_ID").Value.ToString
        txtkelompok.SelectedValue = DataGridView2.Rows(e.RowIndex).Cells("DGV_KELBARANG").Value.ToString
        txtqty1.Text = DataGridView2.Rows(e.RowIndex).Cells("DGV_QTY1").Value.ToString
        txtqty2.Text = DataGridView2.Rows(e.RowIndex).Cells("DGV_QTY2").Value.ToString
        txtdis.Text = FormatNumber(DataGridView2.Rows(e.RowIndex).Cells("DGV_DISCOUNT").Value.ToString, 0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtkelompok.Text = "" Then
            MsgBox("Pilih Kelompok barang !!!!  ", vbExclamation)
            txtkelompok.Focus()
            Exit Sub
        End If

        If txtqty1.Text = "" Then
            MsgBox("Isi Qty1 !!!!  ", vbExclamation)
            txtqty1.Focus()
        End If

        If txtqty2.Text = "" Then
            MsgBox("Isi Qty2 !!!!  ", vbExclamation)
            txtqty2.Focus()
            Exit Sub
        End If

        If txtdis.Text = "" Then
            MsgBox("Isi Discount !!!!  ", vbExclamation)
            txtdis.Focus()
            Exit Sub
        End If

        Dim edit As String
        edit = "UPDATE TB_DISCOUNT SET KELBARANG = '" & txtkelompok.SelectedValue & "', STAMP = cast('NOW' as timestamp),QTY1 = '" & CDbl(txtqty1.Text) & "', QTY2 = '" & CDbl(txtqty2.Text) & "',DISCOUNT = '" & CDbl(txtdis.Text) & "', CREATE_USERID = '" & HOME.usernya.Text & "' WHERE ID = '" & txtid.Text & "' "
        callprogress(edit)
        loaddata()
        txtid.Clear()
        txtqty1.Text = "0"
        txtqty2.Text = "0"
        txtdis.Text = "0"
        txtkelompok.SelectedValue = 0
        txtkelompok.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Hapus As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin akan menghapus Data ??", vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then Exit Sub
        Hapus = "DELETE FROM TB_DISCOUNT WHERE ID ='" & txtid.Text & "'"
        callprogress(Hapus)
        loaddata()
        txtid.Clear()
        txtqty1.Text = "0"
        txtqty2.Text = "0"
        txtdis.Text = "0"
        txtkelompok.SelectedValue = 0
        txtkelompok.Focus()
    End Sub

    Private Sub txtdis_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdis.Leave
        txtdis.Text = FormatNumber(txtdis.Text, 0)
    End Sub
End Class