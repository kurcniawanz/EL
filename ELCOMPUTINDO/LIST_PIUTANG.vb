Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class LIST_PIUTANG

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
        Dim cmd = New FbCommand("SELECT * FROM TB_PARTNER WHERE STATUS LIKE 'C%'", konek)
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
        Dim dA As New FbDataAdapter(" SELECT y.NAMA, sum(z.JUAL)AS JUAL,sum(z.REJUAL)AS REJUAL,sum(z.BAYAR)AS BAYAR, " _
                                    + " sum(z.JUAL) - sum(z.REJUAL)AS GRANDTOTAL, " _
                                    + " sum(z.JUAL) - sum(z.REJUAL) - sum(z.BAYAR)AS SISA FROM( " _
                                    + " SELECT a.CUSTOMER,a.GRANDTOTAL AS JUAL, 0 AS REJUAL, a.BAYAR " _
                                    + " FROM TB_JUAL a " _
                                    + " union " _
                                    + " SELECT a.CUSTOMER,0 AS JUAL, a.GRANDTOTAL AS REJUAL, -(a.BAYAR) " _
                                    + " FROM TB_REJUAL a)z  " _
                                    + " INNER JOIN TB_PARTNER y on y.ID = z.CUSTOMER WHERE y.NAMA LIKE '" & aa & "' GROUP BY y.NAMA ", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        dgv_dat.DataSource = (dS)
        dgv_dat.Enabled = True
        dA.Dispose()
        konek.Close()

        Dim tottt, totbayar, totsissa As Double
        For i As Integer = 0 To dgv_dat.RowCount - 1
            tottt += CDbl(dgv_dat.Rows(i).Cells("DGV1_GRANDTOTAL").Value)
            totbayar += CDbl(dgv_dat.Rows(i).Cells("DGV1_BAYAR").Value)
            totsissa += CDbl(dgv_dat.Rows(i).Cells("DGV1_SISA").Value)
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