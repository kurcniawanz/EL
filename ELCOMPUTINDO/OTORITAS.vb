Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class OTORITAS

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub OTORITAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_OTORITAS WHERE NAMA = '" & txtnamauser.Text & "'", konek)
        rddd = cmd.ExecuteReader

        If rddd.Read Then
            If String.IsNullOrEmpty(rddd.Item("O_USER").ToString) Then
                c_user.Checked = False
            ElseIf rddd.Item("O_USER") = "Y" Then
                c_user.Checked = True
            Else
                c_user.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_ACCOUNT").ToString) Then
                c_account.Checked = False
            ElseIf rddd.Item("O_ACCOUNT") = "Y" Then
                c_account.Checked = True
            Else
                c_account.Checked = False
            End If
        Else
            MsgBox("User Tidak di Temukan !!!!  ", vbExclamation)
        End If
        konek.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tmp_user As String = "N"
        If c_user.Checked = True Then
            tmp_user = "Y"
        End If

        Dim tmp_account As String = "N"
        If c_account.Checked = True Then
            tmp_account = "Y"
        End If

        Dim edit As String
        edit = "UPDATE TB_OTORITAS SET " _
            + " O_ACCOUNT = '" & tmp_account & "', " _
            + " O_USER = '" & tmp_user & "' " _
            + " WHERE NAMA = '" & txtnamauser.Text & "' "
        callprogress(edit)
        Me.Close()
    End Sub
End Class