Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class LOGIN

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        texting()
        UsernameTextBox.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As String = ""
        koneksi_db()

        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT NAMA,USERID,PASS FROM TB_USER WHERE USERID = '" & UsernameTextBox.Text & "' AND PASS = '" & PasswordTextBox.Text & "'", konek)
        rddd = cmd.ExecuteReader

        If rddd.Read() Then
            a = rddd.Item("NAMA")
            HOME.ToolStripStatusLabel1.Text = "USER : "
            HOME.usernya.Text = a
            HOME.Show()
            Me.Hide()
        Else
            MsgBox("Password / Username salah")
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
        End If
        konek.Close()
    End Sub

    Private Sub UsernameTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PasswordTextBox.Focus()
        End If
    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()
        End If
    End Sub
End Class
