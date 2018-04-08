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
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add(" ", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("      SELECT z.SUPLIER,z.ID,z.NOFAK FROM (  " _
                                        + " SELECT a.SUPLIER,a.ID, a.NOFAK ,a.GRANDTOTAL-a.BAYAR as SISA " _
                                        + " FROM TB_BELI a " _
                                        + "         UNION " _
                                        + " SELECT a.SUPLIER,a.ID, a.NOFAK,a.GRANDTOTAL-a.BAYAR as SISA " _
                                        + " FROM TB_REBELI a )z " _
                                        + " WHERE z.SISA <> 0 AND z.SUPLIER = " & txtsup.SelectedValue & " ", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NOFAK"), rddd("ID"))
        End While
        konek.Close()
        txtnofak.DataSource = data
    End Sub

    Private Sub BAYAR_HUTANG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        namabank()
        namasup()
    End Sub

    Private Sub txtnofak_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnofak.SelectedIndexChanged
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("      SELECT z.SISA FROM (  " _
                                        + " SELECT a.ID, a.NOFAK,a.GRANDTOTAL-a.BAYAR as SISA " _
                                        + " FROM TB_BELI a " _
                                        + " UNION " _
                                        + " SELECT a.ID, a.NOFAK,-a.GRANDTOTAL+a.BAYAR as SISA " _
                                        + " FROM TB_REBELI a )z " _
                                        + " WHERE z.SISA <> 0 and z.NOFAK = '" & txtnofak.Text & "'", konek)
        rddd = cmd.ExecuteReader
        If rddd.Read() Then
            txtjum.Text = rddd("SISA").ToString
            txtbay.Text = rddd("SISA").ToString
        End If
        konek.Close()

    End Sub

    Private Sub txtsup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsup.SelectedIndexChanged
        namafak()
    End Sub
End Class