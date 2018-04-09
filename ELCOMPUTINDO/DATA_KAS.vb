Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class DATA_KAS

    Sub namasup()
        carisup.DisplayMember = "Text"
        carisup.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add("ALL", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_PARTNER ", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NAMA"), rddd("ID"))
        End While
        konek.Close()
        carisup.DataSource = data
    End Sub

    Sub namabank()
        caribank.DisplayMember = "Text"
        caribank.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add("ALL", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_ACCOUNT", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NAMA"), rddd("ID"))
        End While
        konek.Close()
        caribank.DataSource = data
    End Sub

    Sub loaddata()
        Dim aa As String = "%"
        If Not carisup.SelectedValue = 0 Then
            aa = carisup.Text
        End If

        Dim bb As String = "%"
        If Not caribank.SelectedValue = 0 Then
            bb = caribank.Text
        End If

        Dim cc As String = "%"
        If Not carinokas.Text = "" Then
            cc = carinokas.Text + "%"
        End If

        dgv_dat.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("   SELECT a.ID, a.NOKAS, a.KREDIT, a.DEBIT, b.NAMA AS NAMAPARTNER ,a.ACCOUNT, c.NAMA AS ACCOUNTNAMA ,a.PARTNER, a.TGL, a.CREATE_USERID, a.STAMP, a.KET " _
                                    + " FROM TB_KAS a " _
                                    + " INNER JOIN TB_PARTNER b ON b.ID = a.PARTNER " _
                                    + " INNER JOIN TB_ACCOUNT c ON c.ID = a.ACCOUNT " _
                                    + " WHERE a.TGL between '" & CDate(tgl1.Text) & "' AND '" & CDate(tgl2.Text) & "' AND b.NAMA LIKE '" & aa & "' AND c.NAMA LIKE '" & bb & "' AND a.NOKAS LIKE '" & cc & "'", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        dgv_dat.DataSource = (dS)
        dgv_dat.Enabled = True
        dA.Dispose()
        konek.Close()

        Dim deb, kre As Double
        For i As Integer = 0 To dgv_dat.RowCount - 1
            deb += CDbl(dgv_dat.Rows(i).Cells("DGV1_DEBIT").Value)
            kre += CDbl(dgv_dat.Rows(i).Cells("DGV1_KREDIT").Value)
        Next

        txtdebit.Text = FormatNumber(deb, 0)
        txtkredit.Text = FormatNumber(kre, 0)
        txtsaldo.Text = FormatNumber(deb - kre, 0)
    End Sub

    Private Sub DATA_KAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        namasup()
        namabank()
        carisup.Text = "ALL"
        caribank.Text = "ALL"
        loaddata()
        tgl1.Focus()
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dgv_det.DataSource = (dS)
        tgl1.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        loaddata()
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dgv_det.DataSource = (dS)
        tgl1.Focus()
    End Sub

    Private Sub dgv_dat_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_dat.CellClick
        dgv_det.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT a.ID, a.NOKAS, a.NOFAK, a.BAYAR, a.CREATE_USERID, a.STAMP " _
                                    + " FROM TB_KAS_DET a " _
                                    + "where a.NOKAS = '" & dgv_dat.Rows(e.RowIndex).Cells("DGV1_NOKAS").Value.ToString & "'", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        dgv_det.DataSource = (dS)
        dgv_det.Enabled = True
        dA.Dispose()
        konek.Close()
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

    Private Sub carisup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carisup.KeyDown
        If e.KeyCode = Keys.Enter Then
            caribank.Focus()
        End If
    End Sub

    Private Sub caribank_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles caribank.KeyDown
        If e.KeyCode = Keys.Enter Then
            carinokas.Focus()
        End If
    End Sub

    Private Sub carinokas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carinokas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button4.Focus()
        End If
    End Sub
End Class