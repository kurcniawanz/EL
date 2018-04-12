Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class BAYAR_HUTANG

    Sub namasup()
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
    End Sub

    Sub namabank()
        txtbank.DisplayMember = "Text"
        txtbank.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add(" ", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_ACCOUNT", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NAMA"), rddd("ID"))
        End While
        konek.Close()
        txtbank.DataSource = data
    End Sub

    Sub namafak()
        txtnofak.DisplayMember = "Text"
        txtnofak.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(String))
        data.Rows.Add(" ", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("       SELECT z.SUPLIER,z.NOFAK, z.GRANDTOTAL,z.LUNAS, " _
                                        + " case when z.BAYAR is null then 0 else z.BAYAR end  AS BAYAR , " _
                                        + " z.GRANDTOTAL-(case when z.BAYAR is null then 0 else z.BAYAR end) AS SISA FROM (  " _
                                        + " SELECT a.SUPLIER,a.NOFAK,a.GRANDTOTAL,a.LUNAS, " _
                                        + " (SELECT sum(b.BAYAR) FROM TB_KAS_DET b WHERE b.NOFAK = a.NOFAK GROUP BY b.NOFAK ) AS BAYAR  " _
                                        + " FROM TB_BELI a " _
                                        + " UNION " _
                                        + " SELECT a.SUPLIER,a.NOFAK,-a.GRANDTOTAL, a.LUNAS, " _
                                        + " (SELECT sum(b.BAYAR) FROM TB_KAS_DET b WHERE b.NOFAK = a.NOFAK GROUP BY b.NOFAK ) AS BAYAR  " _
                                        + " FROM TB_REBELI a " _
                                        + " )z " _
                                        + " WHERE z.SUPLIER = " & txtsup.SelectedValue & " AND z.LUNAS = 'N' ", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NOFAK"), rddd("NOFAK"))
        End While
        konek.Close()
        txtnofak.DataSource = data
    End Sub

    Sub nomor()
        Dim y, m As String
        y = Now.Year
        m = Now.Month
        Dim temp As String = ""
        Dim vall As String = ""
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_KAS  ORDER BY ID DESC", konek)
        rddd = cmd.ExecuteReader

        If rddd.Read Then
            temp = rddd.Item("ID")
            vall = Val(temp) + 1
            txtid.Text = vall
            txtnokas.Text = "HT" + y + m + "000" + vall.ToString
        Else
            txtid.Text = 1
            txtnokas.Text = "HT" + y + m + "0001"
        End If
        konek.Close()
    End Sub

    Private Sub BAYAR_HUTANG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        namabank()
        namasup()
        txttgl.Focus()
    End Sub

    Private Sub txtnofak_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnofak.SelectedIndexChanged
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("       SELECT z.NOFAK, z.GRANDTOTAL, " _
                                        + " case when z.BAYAR is null then 0 else z.BAYAR end  AS BAYAR , " _
                                        + " z.GRANDTOTAL-(case when z.BAYAR is null then 0 else z.BAYAR end) AS SISA FROM (  " _
                                        + " SELECT a.NOFAK,-a.GRANDTOTAL AS GRANDTOTAL, " _
                                        + " (SELECT sum(b.BAYAR) FROM TB_KAS_DET b WHERE b.NOFAK = a.NOFAK GROUP BY b.NOFAK ) AS BAYAR  " _
                                        + " FROM TB_BELI a " _
                                        + " UNION " _
                                        + " SELECT a.NOFAK,a.GRANDTOTAL AS GRANDTOTAL,  " _
                                        + " (SELECT sum(b.BAYAR) FROM TB_KAS_DET b WHERE b.NOFAK = a.NOFAK GROUP BY b.NOFAK ) AS BAYAR  " _
                                        + " FROM TB_REBELI a " _
                                        + " )z " _
                                        + " WHERE z.NOFAK = '" & txtnofak.Text & "'", konek)
        rddd = cmd.ExecuteReader
        If rddd.Read() Then
            txtjum.Text = FormatNumber(rddd("SISA").ToString, 0)
            txtbay.Text = FormatNumber(rddd("SISA").ToString, 0)
        End If
        konek.Close()

    End Sub

    Private Sub txtsup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsup.SelectedIndexChanged
        namafak()
        txtbay.Text = "0"
        txtjum.Text = "0"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txtbank.SelectedValue = 0 Then
            MsgBox("Pilih Account  !!!!  ", vbExclamation)
            txtbank.Focus()
            Exit Sub
        End If
        If txtbank.SelectedValue = Nothing Then
            MsgBox("Pilih Account  !!!!  ", vbExclamation)
            txtbank.Focus()
            Exit Sub
        End If
        GroupBox1.Enabled = False
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If txtnofak.SelectedValue = DataGridView1.Rows(i).Cells("DGV_IDFAKTUR").Value.ToString Then
                MsgBox("No Faktur Sudah ada !!!!  ", vbExclamation)
                txtnofak.Focus()
                Exit Sub
            End If
        Next
        DataGridView1.Rows.Add(txtnofak.SelectedValue, txtnofak.Text, txtjum.Text, txtbay.Text, CDbl(txtjum.Text) - CDbl(txtbay.Text))

        txtjum.Text = "0"
        txtbay.Text = "0"
        txtnofak.SelectedValue = 0
        txtnofak.Focus()

        Dim tot As Double
        For i As Integer = 0 To DataGridView1.RowCount - 1
            tot += CDbl(DataGridView1.Rows(i).Cells("DGV_BAYAR").Value.ToString)
        Next

        txtgrandtotal.Text = FormatNumber(tot, 0)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As Integer
        row = DataGridView1.CurrentRow.Index
        Dim pesan As Integer
        pesan = MsgBox("Hapus No Faktur ??", vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then Exit Sub
        DataGridView1.Rows.RemoveAt(row)
        If DataGridView1.Rows.Count < 1 Then
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtsup.SelectedValue = 0 Then
            MsgBox("Pilih Suplier !!!!  ", vbExclamation)
            txtsup.Focus()
            Exit Sub
        End If

        If txtsup.SelectedValue = Nothing Then
            MsgBox("Pilih Suplier !!!!  ", vbExclamation)
            txtsup.Focus()
            Exit Sub
        End If

        If txtbank.SelectedValue = 0 Then
            MsgBox("Pilih Account !!!!  ", vbExclamation)
            txtsup.Focus()
            Exit Sub
        End If

        If txtbank.SelectedValue = Nothing Then
            MsgBox("Pilih Account !!!!  ", vbExclamation)
            txtsup.Focus()
            Exit Sub
        End If


        If DataGridView1.RowCount < 1 Then
            MsgBox("Pilih No Faktur Terlebih dahulu !!!!  ", vbExclamation)
            txtnofak.Focus()
            Exit Sub
        End If

        nomor()
        Dim simpan, simpan2, setlunas As String

        simpan = "INSERT INTO TB_KAS(ID, NOKAS, KREDIT, DEBIT, ACCOUNT, PARTNER,KET,CREATE_USERID,STAMP, TGL)" _
           + "VALUES ('" & txtid.Text & "'," _
           + "'" & txtnokas.Text & "'," _
           + "'" & CDbl(txtgrandtotal.Text) & "'," _
           + "'" & 0 & "'," _
           + "'" & txtbank.SelectedValue & "'," _
           + "'" & txtsup.SelectedValue & "'," _
           + "'" & txtket.Text & "'," _
           + "'" & HOME.usernya.Text & "'," _
           + "cast('NOW' as timestamp)," _
           + "'" & CDate(txttgl.Text) & "') ; "
        callprogress(simpan)

        For i As Integer = 0 To DataGridView1.RowCount - 1
            Dim temp As String = ""
            Dim vall As String = ""
            koneksi_db()
            Dim rddd As FbDataReader
            Dim cmd = New FbCommand("SELECT * FROM TB_KAS_DET  ORDER BY ID DESC", konek)
            rddd = cmd.ExecuteReader

            If rddd.Read Then
                temp = rddd.Item("ID")
                vall = Val(temp) + 1
            Else
                vall = "1"
            End If
            konek.Close()

            simpan2 = "INSERT INTO TB_KAS_DET(ID, NOKAS, NOFAK,CREATE_USERID,STAMP, BAYAR)" _
             + "VALUES ('" & vall & "'," _
             + "'" & txtnokas.Text & "'," _
             + "'" & DataGridView1.Rows(i).Cells("DGV_NOFAK").Value.ToString & "'," _
             + "'" & HOME.usernya.Text & "'," _
             + "cast('NOW' as timestamp)," _
             + "'" & CDbl(DataGridView1.Rows(i).Cells("DGV_BAYAR").Value) & "') ; "
            callprogress2(simpan2)

            Dim sisa As Double
            koneksi_db()
            Dim readceklunas As FbDataReader
            Dim cmdlunas = New FbCommand("SELECT a.NOFAK,a.GRANDTOTAL-b.BAYAR AS SISA FROM( " _
                        + " SELECT -a.GRANDTOTAL AS GRANDTOTAL, a.NOFAK " _
                        + " FROM TB_BELI a WHERE a.NOFAK = '" & DataGridView1.Rows(i).Cells("DGV_NOFAK").Value.ToString & "' " _
                        + " UNION " _
                        + " SELECT a.GRANDTOTAL, a.NOFAK " _
                        + " FROM TB_REBELI a WHERE a.NOFAK = '" & DataGridView1.Rows(i).Cells("DGV_NOFAK").Value.ToString & "' " _
                        + " )a LEFT JOIN  " _
                        + " (SELECT b.NOFAK, SUM(b.BAYAR) AS BAYAR FROM TB_KAS_DET b WHERE b.NOFAK = '" & DataGridView1.Rows(i).Cells("DGV_NOFAK").Value.ToString & "' GROUP BY b.NOFAK)b " _
                        + " ON b.NOFAK = a.NOFAK", konek)
            readceklunas = cmdlunas.ExecuteReader
            If readceklunas.Read Then
                sisa = CDbl(readceklunas.Item("SISA"))
            End If
            konek.Close()

            If sisa = 0 Then
                If DataGridView1.Rows(i).Cells("DGV_NOFAK").Value.ToString.Substring(0, 1) = "B" Then
                    setlunas = "UPDATE TB_BELI z SET z.LUNAS = 'Y' WHERE z.NOFAK = '" & DataGridView1.Rows(i).Cells("DGV_NOFAK").Value.ToString & "'"
                    callprogress2(setlunas)
                    setlunas = ""
                Else
                    setlunas = "UPDATE TB_REBELI z SET z.LUNAS = 'Y' WHERE z.NOFAK = '" & DataGridView1.Rows(i).Cells("DGV_NOFAK").Value.ToString & "'"
                    callprogress2(setlunas)
                    setlunas = ""
                End If
            End If
        Next

        txttgl.Value = Now
        txtsup.SelectedValue = 0
        txtbank.SelectedValue = 0
        txtnokas.Clear()
        txtket.Clear()
        txtgrandtotal.Text = "0"
        GroupBox1.Enabled = True
        DataGridView1.Rows.Clear()
        txttgl.Focus()
    End Sub

    Private Sub txttgl_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttgl.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsup.Focus()
        End If
    End Sub

    Private Sub txtsup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsup.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbank.Focus()
        End If
    End Sub

    Private Sub txtbank_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbank.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnofak.Focus()
        End If
    End Sub

    Private Sub txtnofak_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnofak.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not txtnofak.Text = " " Then
                txtbay.Focus()
            Else
                txtket.Focus()
            End If
        End If
    End Sub

    Private Sub txtbay_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbay.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button5.Focus()
        End If
    End Sub

    Private Sub txtket_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtket.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.Focus()
        End If
    End Sub
End Class