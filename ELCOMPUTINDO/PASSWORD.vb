Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class PASSWORD

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As String = ""
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_USER  WHERE NAMA = '" & txtnamauser.Text & "'", konek)
        rddd = cmd.ExecuteReader

        If rddd.Read Then
            a = rddd.Item("PASS")
            txtid.Text = rddd.Item("ID")

            If Not a = txtpass1.Text Then
                MsgBox("Password Salah !!!!  ", vbExclamation)
                txtpass1.Clear()
                txtpass2.Clear()
                Exit Sub
            Else
                Dim edit As String
                edit = "UPDATE TB_USER SET STAMP = cast('NOW' as timestamp),PASS = '" & txtpass2.Text & "',CREATE_USERID = '" & HOME.usernya.Text & "' WHERE ID = '" & txtid.Text & "' "
                callprogress(edit)
                Application.Exit()
            End If
        Else
            MsgBox("User Tidak di Temukan !!!!  ", vbExclamation)
        End If
        konek.Close()

       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PASSWORD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class