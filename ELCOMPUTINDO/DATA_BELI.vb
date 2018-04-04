Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class DATA_BELI


    Sub nama()
        carisup.Items.Clear()
        carisup.DisplayMember = "Text"
        carisup.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add("ALL", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_PARTNER WHERE STATUS LIKE '%S'", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NAMA"), rddd("ID"))
        End While
        konek.Close()
        carisup.DataSource = data
        carisup.SelectedValue = 0
    End Sub

    Sub loaddata()
        Dim aa As String = "%"
        If Not carisup.SelectedValue = 0 Then
            aa = carisup.Text
        End If

        dgv_dat.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT a.ID, a.NOFAK, a.TGL, a.JT, b.NAMA as SUPLIERNAMA, " _
                                        + "a.GRANDTOTAL-a.POT as TOTAL, " _
                                        + " a.POT, a.GRANDTOTAL, a.KET, a.CREATE_USERID, a.STAMP " _
                                        + "FROM TB_BELI a " _
                                        + "inner join TB_PARTNER b on b.ID = a.SUPLIER " _
                                        + "WHERE a.TGL between '" & CDate(tgl1.Text) & "' and '" & CDate(tgl2.Text) & "' and b.NAMA like '" & aa & "'", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        dgv_dat.DataSource = (dS)
        dgv_dat.Enabled = True
        dA.Dispose()
        konek.Close()

        Dim total As Double
        For i As Integer = 0 To dgv_dat.RowCount - 1
            total += CDbl(dgv_dat.Rows(i).Cells("DGV1_GRANDTOTAL").Value)
        Next

        txtgrantotal.Text = FormatNumber(total, 0)
    End Sub

    Private Sub DATA_BELI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nama()
        carisup.SelectedValue = 0
        loaddata()
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dgv_det.DataSource = (dS)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        loaddata()
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dgv_det.DataSource = (dS)
    End Sub

    Private Sub dgv_dat_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_dat.CellClick
        dgv_det.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT b.NAMA as NAMABARANG, a.QTY, a.HARGA,a.QTY*a.HARGA as JUMLAH, a.POT1, a.POT2, a.TOTAL " _
                                    + "FROM TB_BELI_DET a " _
                                    + "inner join TB_BARANG b on b.id = a.IDBARANG " _
                                    + "where a.NOFAK = '" & dgv_dat.Rows(e.RowIndex).Cells("DGV1_NOFAK").Value.ToString & "'", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        dgv_det.DataSource = (dS)
        dgv_det.Enabled = True
        dA.Dispose()
        konek.Close()
    End Sub
End Class