Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class DATA_PIUTANG
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
        Dim bb As String
        If carifaktur.Text = "" Then
            bb = "%"
        Else
            bb = carifaktur.Text + "%"
        End If
        Dim cc As String
        If carilunas.Text = "ALL" Then
            cc = "%"
        ElseIf carilunas.Text = "YES" Then
            cc = "Y"
        ElseIf carilunas.Text = "NO" Then
            cc = "N"
        End If
        dgv_dat.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT z.* FROM ( " _
                                        + " SELECT a.ID, a.LUNAS,a.NOFAK, a.TGL, b.NAMA, a.JT ,a.GRANDTOTAL, " _
                                        + " CASE WHEN c.BAYAR IS NULL THEN 0 ELSE (-c.BAYAR) END AS BAYAR, " _
                                        + " a.GRANDTOTAL-(CASE WHEN c.BAYAR IS NULL THEN 0 ELSE c.BAYAR END) as SISA, " _
                                        + " a.CREATE_USERID, a.STAMP " _
                                        + " FROM TB_JUAL a " _
                                        + " INNER JOIN TB_PARTNER b ON b.ID = a.CUSTOMER LEFT JOIN (SELECT x.NOFAK,sum(x.BAYAR)AS BAYAR FROM TB_KAS_DET x GROUP BY x.NOFAK) c ON c.NOFAK = a.NOFAK" _
                                        + " UNION " _
                                        + " SELECT a.ID, a.LUNAS,a.NOFAK, a.TGL, b.NAMA, a.JT, -a.GRANDTOTAL,  " _
                                        + " CASE WHEN c.BAYAR IS NULL THEN 0 ELSE (c.BAYAR*-1) END AS BAYAR, " _
                                        + " -a.GRANDTOTAL-(CASE WHEN c.BAYAR IS NULL THEN 0 ELSE c.BAYAR END) as SISA , a.CREATE_USERID, a.STAMP " _
                                        + " FROM TB_REJUAL a " _
                                        + " INNER JOIN TB_PARTNER b ON b.ID = a.CUSTOMER LEFT JOIN (SELECT x.NOFAK,sum(x.BAYAR)AS BAYAR FROM TB_KAS_DET x GROUP BY x.NOFAK) c ON c.NOFAK = a.NOFAK)z " _
                                        + " WHERE z.TGL BETWEEN '" & CDate(tgl1.Text) & "' AND '" & CDate(tgl2.Text) & "' AND z.NAMA LIKE '" & aa & "' AND z.NOFAK LIKE '" & bb & "' AND z.LUNAS LIKE '" & cc & "' ", konek)
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

    Private Sub DATA_PIUTANG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        namabarang()
        loaddata()
        carilunas.Text = "ALL"
        tgl1.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        loaddata()
    End Sub

    Private Sub carisup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carisup.KeyDown
        If e.KeyCode = Keys.Enter Then
            carifaktur.Focus()
        End If
    End Sub

    Private Sub carifaktur_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carifaktur.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button4.Focus()
        End If

    End Sub

    Private Sub dgv_dat_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv_dat.CellFormatting
        For i As Integer = 0 To dgv_dat.RowCount - 1
            If CDate(dgv_dat.Rows(i).Cells("DGV1_JT").Value.ToString) <= Now.Date Then
                dgv_dat.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub

    Private Sub tgl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tgl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            tgl2.Focus()
        End If
    End Sub

    Private Sub tgl2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tgl2.KeyDown
        If e.KeyCode = Keys.Enter Then
            carisup.Focus()
        End If
    End Sub
End Class