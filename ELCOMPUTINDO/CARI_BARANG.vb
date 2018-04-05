Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class CARI_BARANG

    Sub nama()
        carikel.Text = ""
        carikel.Items.Clear()
        carikel.DisplayMember = "Text"
        carikel.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add("ALL", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_CATEGORY", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NAMA"), rddd("ID"))
        End While
        konek.Close()
        carikel.DataSource = data
        carikel.SelectedValue = 0

        carinama.Text = ""
        carinama.Items.Clear()
        carinama.Items.Add("ALL")
        koneksi_db()
        Dim read As FbDataReader
        Dim com = New FbCommand("SELECT * FROM TB_BARANG", konek)
        read = com.ExecuteReader
        While read.Read()
            carinama.Items.Add(read("NAMA"))
        End While
        konek.Close()
        carinama.Text = "ALL"
    End Sub

    Sub loaddata()
        Dim aa As String = "%"
        If Not carinama.Text = "ALL" Then
            aa = carinama.Text
        End If

        Dim bb As String = "%"
        If Not carikel.Text = "ALL" Then
            bb = carikel.SelectedValue
        End If

        DataGridView1.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT a.ID,a.NAMA,a.KELOMPOK,a.SATUAN,a.HARGAJUAL,a.MINIMAL,a.KET,a.CREATE_USERID,a.STAMP," _
                                    + "b.NAMA as KELOMPOKNAMA FROM TB_BARANG a " _
                                    + " INNER JOIN TB_CATEGORY b ON b.ID = a.KELOMPOK WHERE a.NAMA LIKE '" & aa & "' AND a.KELOMPOK LIKE '" & bb & "'", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        DataGridView1.DataSource = (dS)
        DataGridView1.Enabled = True
        dA.Dispose()
        konek.Close()
    End Sub

    Private Sub CARI_BARANG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nama()
        loaddata()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        loaddata()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim row As Integer
        row = DataGridView1.CurrentRow.Index.ToString
        Dim frm As INPUT_BELI
        frm = CType(HOME.MdiChildren(0), Form)
        frm.txtbarang.SelectedValue = DataGridView1.Item("DGV_ID", row).Value.ToString
        frm.txtqty.Focus()
        Me.Close()

    End Sub
End Class