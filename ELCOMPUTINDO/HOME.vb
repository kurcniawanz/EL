Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class HOME

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Sub oto()
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_OTORITAS WHERE NAMA = '" & usernya.Text & "'", konek)
        rddd = cmd.ExecuteReader

        If rddd.Read Then
            If String.IsNullOrEmpty(rddd.Item("O_USER").ToString) Then
                DataUserToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_USER") = "Y" Then
                DataUserToolStripMenuItem.Visible = True
            Else
                DataUserToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_ACCOUNT").ToString) Then
                ToolStripMenuItem1.Visible = False
            ElseIf rddd.Item("O_ACCOUNT") = "Y" Then
                ToolStripMenuItem1.Visible = True
            Else
                ToolStripMenuItem1.Visible = False
            End If
        Else
            MsgBox("User Tidak di Temukan !!!!  ", vbExclamation)
        End If
        konek.Close()
    End Sub


    Private Sub HOME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oto()

        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As DASHBOARD
        frm = New DASHBOARD
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As DASHBOARD
        frm = New DASHBOARD
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataUserToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As USER
        frm = New USER
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        PASSWORD.Show()
        PASSWORD.txtnamauser.Text = usernya.Text
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As ACCOUNT
        frm = New ACCOUNT
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub
End Class