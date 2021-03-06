﻿Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class INPUT_BIAYA

    Sub namasup()
        txtsup.DisplayMember = "Text"
        txtsup.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_PARTNER", konek)
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
            txtnokas.Text = "BY" + y + m + "000" + vall.ToString
        Else
            txtid.Text = 1
            txtnokas.Text = "BY" + y + m + "0001"
        End If
        konek.Close()
    End Sub

    Private Sub INPUT_BIAYA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        namasup()
        namabank()
        txtsup.SelectedValue = 5
        txttgl.Focus()
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

        DataGridView1.Rows.Add(txtketbiaya.Text, CDbl(txtjum.Text) * -1)

        txtjum.Text = "0"
        txtketbiaya.Clear()
        txtketbiaya.Focus()
    

        Dim tot As Double
        For i As Integer = 0 To DataGridView1.RowCount - 1
            tot += CDbl(DataGridView1.Rows(i).Cells("DGV_JUMLAH").Value.ToString)
        Next

        txtgrandtotal.Text = FormatNumber(tot, 0)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As Integer
        row = DataGridView1.CurrentRow.Index
        Dim pesan As Integer
        pesan = MsgBox("Hapus Biaya ??", vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then Exit Sub
        DataGridView1.Rows.RemoveAt(row)
        If DataGridView1.Rows.Count < 1 Then
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DataGridView1.RowCount < 1 Then
            MsgBox("Pilih No Faktur Terlebih dahulu !!!!  ", vbExclamation)
            txtketbiaya.Focus()
            Exit Sub
        End If

        nomor()
        Dim simpan, simpan2 As String

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
             + "'" & DataGridView1.Rows(i).Cells("DGV_KETBIAYA").Value.ToString & "'," _
             + "'" & HOME.usernya.Text & "'," _
             + "cast('NOW' as timestamp)," _
             + "'" & CDbl(DataGridView1.Rows(i).Cells("DGV_JUMLAH").Value) & "') ; "
            callprogress2(simpan2)
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
            txtbank.Focus()
        End If
    End Sub

    Private Sub txtbank_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbank.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtketbiaya.Focus()
        End If
    End Sub

    Private Sub txtketbiaya_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtketbiaya.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtketbiaya.Text = "" Then
                txtket.Focus()
            Else
                txtjum.Focus()
            End If
        End If
    End Sub

    Private Sub txtjum_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtjum.KeyDown
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