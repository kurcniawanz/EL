Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class HISTORI_BELI

    Sub namabarang()
        caribarang.Items.Clear()
        caribarang.DisplayMember = "Text"
        caribarang.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add("ALL", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_BARANG", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NAMA"), rddd("ID"))
        End While
        konek.Close()
        caribarang.DataSource = data

    End Sub

    Sub loaddata()
        Dim aa As String = "%"
        If Not caribarang.SelectedValue = 0 Then
            aa = caribarang.Text
        End If
        Dim bb As String
        If carifaktur.Text = "" Then
            bb = "%"
        Else
            bb = carifaktur.Text + "%"
        End If
        dgv_det.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT z.* FROM ( " _
                                    + " SELECT a.ID,b.TGL, a.NOFAK, c.NAMA, -a.QTY AS QTY, a.HARGA, a.HARGA*-a.QTY AS JUMLAH, a.POT1, a.POT2, -a.TOTAL AS TOTAL, a.CREATE_USERID, a.STAMP " _
                                    + " FROM TB_REBELI_DET a " _
                                    + " INNER JOIN TB_REBELI b ON b.NOFAK = a.NOFAK " _
                                    + " INNER JOIN TB_BARANG c ON c.ID = a.IDBARANG " _
                                    + " union " _
                                    + " SELECT a.ID,b.TGL, a.NOFAK, c.NAMA, a.QTY AS QTY, a.HARGA, a.HARGA*a.QTY AS JUMLAH, a.POT1, a.POT2,a.TOTAL AS TOTAL, a.CREATE_USERID, a.STAMP " _
                                    + " FROM TB_BELI_DET a " _
                                    + " INNER JOIN TB_BELI b ON b.NOFAK = a.NOFAK " _
                                    + " INNER JOIN TB_BARANG c ON c.ID = a.IDBARANG )z " _
                                    + " WHERE z.TGL BETWEEN '" & CDate(tgl1.Text) & "' and '" & CDate(tgl2.Text) & "' AND z.NAMA LIKE '" & aa & "' AND z.NOFAK LIKE '" & bb & "'", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        dgv_det.DataSource = (dS)
        dgv_det.Enabled = True
        dA.Dispose()
        konek.Close()
    End Sub

    Private Sub HISTORI_BELI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        namabarang()
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
            caribarang.Focus()
        End If
    End Sub

    Private Sub caribarang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles caribarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            carifaktur.Focus()
        End If
    End Sub

    Private Sub carifaktur_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carifaktur.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button4.Focus()
        End If
    End Sub
End Class