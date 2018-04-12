Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class LIST_HUTANG

    Sub namabarang()
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

    End Sub

    Sub loaddata()
        Dim aa As String = "%"
        If Not carisup.SelectedValue = 0 Then
            aa = carisup.Text
        End If
     
        dgv_dat.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter(" SELECT y.NAMA, sum(z.BELI)AS BELI,sum(z.REBELI)AS REBELI,sum(z.BAYAR)AS BAYAR, " _
                                    + " sum(z.BELI) - sum(z.REBELI)AS GRANDTOTAL, " _
                                    + " sum(z.BELI) - sum(z.REBELI) - sum(z.BAYAR)AS SISA FROM TB_PARTNER y LEFT JOIN ( " _
                                    + " SELECT a.SUPLIER,a.GRANDTOTAL AS BELI, 0 AS REBELI, a.BAYAR " _
                                    + " FROM TB_BELI a " _
                                    + " union " _
                                    + " SELECT a.SUPLIER,0 AS BELI, a.GRANDTOTAL AS REBELI, -(a.BAYAR) " _
                                    + " FROM TB_REBELI a)z on y.ID = z.SUPLIER  " _
                                    + " WHERE y.NAMA LIKE '" & aa & "' AND y.STATUS LIKE '%S' GROUP BY y.NAMA ", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        dgv_dat.DataSource = (dS)
        dgv_dat.Enabled = True
        dA.Dispose()
        konek.Close()

        Dim tottt, totbayar, totsissa As Double
        For i As Integer = 0 To dgv_dat.RowCount - 1
            If Not dgv_dat.Rows(i).Cells("DGV1_GRANDTOTAL").Value.ToString = "" Then
                tottt += CDbl(dgv_dat.Rows(i).Cells("DGV1_GRANDTOTAL").Value)
            End If
            If Not dgv_dat.Rows(i).Cells("DGV1_BAYAR").Value.ToString = "" Then
                totbayar += CDbl(dgv_dat.Rows(i).Cells("DGV1_BAYAR").Value)
            End If
            If Not dgv_dat.Rows(i).Cells("DGV1_SISA").Value.ToString = "" Then
                totsissa += CDbl(dgv_dat.Rows(i).Cells("DGV1_SISA").Value)
            End If
        Next
        tott.Text = FormatNumber(tottt, 0)
        totbay.Text = FormatNumber(totbayar, 0)
        totsis.Text = FormatNumber(totsissa, 0)
    End Sub

    Private Sub LIST_HUTANG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        namabarang()
        loaddata()
        carisup.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        loaddata()
    End Sub

    Private Sub carisup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carisup.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button4.Focus()
        End If
    End Sub
End Class