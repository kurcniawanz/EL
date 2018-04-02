Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class USER

    Sub nomor()
        Dim temp As String = ""
        Dim vall As String = ""
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_USER  ORDER BY ID DESC", konek)
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
        Dim dA As New FbDataAdapter("SELECT * FROM TB_USER WHERE ID <> 0 ", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        DataGridView1.DataSource = (dS)
        DataGridView1.Enabled = True
        dA.Dispose()
        konek.Close()
    End Sub

    Private Sub USER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        txtnama.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtnama.Text = "" Then
            MsgBox("Isi Nama User !!!!  ", vbExclamation)
            txtnama.Focus()
            Exit Sub
        End If

        If txtuser.Text = "" Then
            MsgBox("Isi UserID !!!!  ", vbExclamation)
            txtuser.Focus()
            Exit Sub
        End If

        If txtpass.Text = "" Then
            MsgBox("Isi Password !!!!  ", vbExclamation)
            txtpass.Focus()
            Exit Sub
        End If
        nomor()
        Dim simpan, simpan2 As String
        simpan2 = " INSERT INTO TB_OTORITAS (ID, NAMA) VALUES ( '" & txtid.Text & "','" & txtnama.Text & "' )"
        simpan = "INSERT INTO TB_USER(ID,NAMA,USERID,CREATE_USERID,STAMP,PASS)" _
           + "VALUES ('" & txtid.Text & "'," _
           + "'" & txtnama.Text & "'," _
           + "'" & txtuser.Text & "'," _
           + "'" & HOME.usernya.Text & "'," _
           + "cast('NOW' as timestamp)," _
           + "'" & txtpass.Text & "') ; "
        callprogress2(simpan2)
        callprogress(simpan)
        loaddata()
        txtid.Clear()
        txtuser.Clear()
        txtnama.Clear()
        txtpass.Clear()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtid.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_ID").Value.ToString
        txtnama.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_NAMA").Value.ToString
        txtuser.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_USERID").Value.ToString
        txtpass.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_PASS").Value.ToString
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim edit, edit2 As String
        edit = "UPDATE TB_USER SET STAMP = cast('NOW' as timestamp), NAMA = '" & txtnama.Text & "',USERID = '" & txtuser.Text & "',PASS = '" & txtpass.Text & "',CREATE_USERID = '" & HOME.usernya.Text & "' WHERE ID = '" & txtid.Text & "' "
        edit2 = "UPDATE TB_OTORITAS SET NAMA = '" & txtnama.Text & "' WHERE ID = '" & txtid.Text & "' "
        callprogress2(edit2)
        callprogress(edit)
        loaddata()
        txtid.Clear()
        txtuser.Clear()
        txtnama.Clear()
        txtpass.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Hapus, hapus2 As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin akan menghapus Data ??", vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then Exit Sub
        hapus2 = "DELETE FROM TB_OTORITAS WHERE ID ='" & txtid.Text & "'"
        Hapus = "DELETE FROM TB_USER WHERE ID ='" & txtid.Text & "'"
        callprogress2(hapus2)
        callprogress(Hapus)
        loaddata()
        txtid.Clear()
        txtuser.Clear()
        txtnama.Clear()
        txtpass.Clear()
    End Sub

    Private Sub txtnama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnama.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtuser.Focus()
        End If
    End Sub

    Private Sub txtuser_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpass.Focus()
        End If
    End Sub

    Private Sub txtpass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.Focus()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If txtnama.Text = "" Then
            MsgBox("Pilih User terlebih dahulu !!!!  ", vbExclamation)
            txtnama.Focus()
            Exit Sub
        End If
        OTORITAS.txtnamauser.Text = txtnama.Text
        OTORITAS.Show()
    End Sub
End Class