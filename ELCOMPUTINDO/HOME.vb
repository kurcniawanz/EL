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

            If String.IsNullOrEmpty(rddd.Item("O_PARTNER").ToString) Then
                PartnerToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_PARTNER") = "Y" Then
                PartnerToolStripMenuItem.Visible = True
            Else
                PartnerToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_CATEGORY").ToString) Then
                KelompokBarangToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_CATEGORY") = "Y" Then
                KelompokBarangToolStripMenuItem.Visible = True
            Else
                KelompokBarangToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_BARANG").ToString) Then
                InputBarangToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_BARANG") = "Y" Then
                InputBarangToolStripMenuItem.Visible = True
            Else
                InputBarangToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_STOCK").ToString) Then
                StockBarangToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_STOCK") = "Y" Then
                StockBarangToolStripMenuItem.Visible = True
            Else
                StockBarangToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_MUTASI").ToString) Then
                ToolStripMenuItem2.Visible = False
            ElseIf rddd.Item("O_MUTASI") = "Y" Then
                ToolStripMenuItem2.Visible = True
            Else
                ToolStripMenuItem2.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_BELI").ToString) Then
                InputPembelianToolStripMenuItem.Visible = False
                LaporanPembelianToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_BELI") = "Y" Then
                InputPembelianToolStripMenuItem.Visible = True
                LaporanPembelianToolStripMenuItem.Visible = True
            Else
                InputPembelianToolStripMenuItem.Visible = False
                LaporanPembelianToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_KOREKSI").ToString) Then
                KoreksiToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_KOREKSI") = "Y" Then
                KoreksiToolStripMenuItem.Visible = True
            Else
                KoreksiToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_REBELI").ToString) Then
                ReturPembelianToolStripMenuItem.Visible = False
                LaporanReturPembelianToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_REBELI") = "Y" Then
                ReturPembelianToolStripMenuItem.Visible = True
                LaporanReturPembelianToolStripMenuItem.Visible = True
            Else
                ReturPembelianToolStripMenuItem.Visible = False
                LaporanReturPembelianToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_HISTORI_BELI").ToString) Then
                HistoryPembelianToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_HISTORI_BELI") = "Y" Then
                HistoryPembelianToolStripMenuItem.Visible = True
            Else
                HistoryPembelianToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_JUAL").ToString) Then
                InputPenjualanToolStripMenuItem.Visible = False
                LaporanPenjualanToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_JUAL") = "Y" Then
                InputPenjualanToolStripMenuItem.Visible = True
                LaporanPenjualanToolStripMenuItem.Visible = True
            Else
                InputPenjualanToolStripMenuItem.Visible = False
                LaporanPenjualanToolStripMenuItem.Visible = False
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

    Private Sub PartnerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartnerToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As PARTNER
        frm = New PARTNER
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub KelompokBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KelompokBarangToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As CATEEGORY
        frm = New CATEEGORY
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub InputBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputBarangToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As BARANG
        frm = New BARANG
        frm.Text = "HOME"
        frm.Button3.Visible = True
        frm.Button2.Visible = False
        frm.Button1.Visible = False
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub StockBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockBarangToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As STOCK
        frm = New STOCK
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub InputPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputPembelianToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As INPUT_BELI
        frm = New INPUT_BELI
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Button3.Visible = True
        frm.Button2.Visible = False
        frm.Button1.Visible = False
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub LaporanPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPembelianToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As DATA_BELI
        frm = New DATA_BELI
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As MUTASI
        frm = New MUTASI
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub KoreksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KoreksiToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As KOREKSI
        frm = New KOREKSI
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub ReturPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturPembelianToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As INPUT_REBELI
        frm = New INPUT_REBELI
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Button3.Visible = True
        frm.Button2.Visible = False
        frm.Button1.Visible = False
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub LaporanReturPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanReturPembelianToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As DATA_REBELI
        frm = New DATA_REBELI
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub HistoryPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryPembelianToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As HISTORI_BELI
        frm = New HISTORI_BELI
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub InputPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputPenjualanToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As INPUT_JUAL
        frm = New INPUT_JUAL
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Button3.Visible = True
        frm.Button2.Visible = False
        frm.Button1.Visible = False
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As DATA_JUAL
        frm = New DATA_JUAL
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub
End Class