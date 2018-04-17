Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class MUTASI

    Sub nama()
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

        DataGridView1.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT a.ID,a.ONGKIR, a.TGL, a.NOFAK, b.NAMA, a.QTY, b.SATUAN, a.HPP, a.TOTHPP+(a.ONGKIR*a.QTY)AS TOTHPP, a.CREATE_UID, a.STAMP " _
                                    + " FROM TB_MUTASI a " _
                                    + "  inner join TB_BARANG b on b.ID = a.IDBARANG " _
                                    + "  WHERE a.TGL between '" & CDate(tgl1.Text) & "' and '" & CDate(tgl2.Text) & "' and b.nama like '" & aa & "' " _
                                    + "  order by stamp", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        DataGridView1.DataSource = (dS)
        DataGridView1.Enabled = True
        dA.Dispose()
        konek.Close()

        Dim total, jumlah As Double
        For i As Integer = 0 To DataGridView1.RowCount - 1
            total += CDbl(DataGridView1.Rows(i).Cells("DGV_QTY").Value)
            jumlah += CDbl(DataGridView1.Rows(i).Cells("DGV_TOTHPP").Value)
        Next
        totqty.Text = FormatNumber(total, 0)
        tothpp.Text = FormatNumber(jumlah, 0)
        txthpp.Text = FormatNumber(jumlah / total, 2)
    End Sub

    Private Sub MUTASI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nama()
        loaddata()
        tgl1.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        loaddata()
    End Sub

    Private Sub tgl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tgl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            tgl2.Focus()
        End If
    End Sub

    Private Sub tgl2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tgl2.KeyDown
        If e.KeyCode = Keys.Enter Then
            carinama.Focus()
        End If
    End Sub

    Private Sub carinama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carinama.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button4.Focus()
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If CDbl(DataGridView1.Rows(i).Cells("DGV_QTY").Value) <= 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub
End Class