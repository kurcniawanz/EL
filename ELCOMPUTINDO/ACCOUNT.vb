Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class ACCOUNT

    Sub nomor()
        Dim temp As String = ""
        Dim vall As String = ""
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_ACCOUNT  ORDER BY ID DESC", konek)
        rddd = cmd.ExecuteReader

        If rddd.Read Then
            temp = rddd.Item("ID")
            vall = Val(temp) + 1
            txtid.Text = vall
        Else
            txtid.Text = 0
        End If
        konek.Close()
    End Sub

    Sub loaddata()
        DataGridView1.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT * FROM TB_ACCOUNT", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        DataGridView1.DataSource = (dS)
        DataGridView1.Enabled = True
        dA.Dispose()
        konek.Close()
    End Sub

    Private Sub ACCOUNT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        txtnama.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtnama.Text = "" Then
            MsgBox("Isi Nama Account !!!!  ", vbExclamation)
            txtnama.Focus()
            Exit Sub
        End If

        If txtnorek.Text = "" Then
            MsgBox("Isi No rekening !!!!  ", vbExclamation)
            txtnorek.Focus()
            Exit Sub
        End If

        If txtket.Text = "" Then
            MsgBox("Isi Keterangan !!!!  ", vbExclamation)
            txtket.Focus()
            Exit Sub
        End If
        nomor()
        Dim simpan As String
        simpan = "INSERT INTO TB_ACCOUNT(ID,NAMA,NOREK,CREATE_USERID,STAMP,KET)" _
           + "VALUES ('" & txtid.Text & "'," _
           + "'" & txtnama.Text & "'," _
           + "'" & txtnorek.Text & "'," _
           + "'" & HOME.usernya.Text & "'," _
           + "cast('NOW' as timestamp)," _
           + "'" & txtket.Text & "') ; "
        callprogress(simpan)
        loaddata()
        txtid.Clear()
        txtnorek.Clear()
        txtnama.Clear()
        txtket.Clear()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtid.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_ID").Value.ToString
        txtnama.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_NAMA").Value.ToString
        txtnorek.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_NOREK").Value.ToString
        txtket.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_KET").Value.ToString
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim edit As String
        edit = "UPDATE TB_ACCOUNT SET STAMP = cast('NOW' as timestamp), NAMA = '" & txtnama.Text & "',NOREK = '" & txtnorek.Text & "',KET = '" & txtket.Text & "',CREATE_USERID = '" & HOME.usernya.Text & "' WHERE ID = '" & txtid.Text & "' "
        callprogress(edit)
        loaddata()
        txtid.Clear()
        txtnorek.Clear()
        txtnama.Clear()
        txtket.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Hapus As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin akan menghapus Data ??", vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then Exit Sub
        Hapus = "DELETE FROM TB_ACCOUNT WHERE ID ='" & txtid.Text & "'"
        callprogress(Hapus)
        loaddata()
        txtid.Clear()
        txtnorek.Clear()
        txtnama.Clear()
        txtket.Clear()
    End Sub

    Private Sub txtnama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnama.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnorek.Focus()
        End If
    End Sub

    Private Sub txtnorek_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnorek.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtket.Focus()
        End If
    End Sub

    Private Sub txtket_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtket.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.Focus()
        End If
    End Sub
End Class