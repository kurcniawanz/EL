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

            If String.IsNullOrEmpty(rddd.Item("O_REJUAL").ToString) Then
                ReturPenjualanToolStripMenuItem.Visible = False
                LaporanReturPenjualanToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_REJUAL") = "Y" Then
                ReturPenjualanToolStripMenuItem.Visible = True
                LaporanReturPenjualanToolStripMenuItem.Visible = True
            Else
                ReturPenjualanToolStripMenuItem.Visible = False
                LaporanReturPenjualanToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_HISTORI_JUAL").ToString) Then
                HistoryPenjualanToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_HISTORI_JUAL") = "Y" Then
                HistoryPenjualanToolStripMenuItem.Visible = True
            Else
                HistoryPenjualanToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_HUTANG").ToString) Then
                HutangToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_HUTANG") = "Y" Then
                HutangToolStripMenuItem.Visible = True
            Else
                HutangToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_PIUTANG").ToString) Then
                PiutangToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_PIUTANG") = "Y" Then
                PiutangToolStripMenuItem.Visible = True
            Else
                PiutangToolStripMenuItem.Visible = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_KAS").ToString) Then
                DataKasToolStripMenuItem.Visible = False
                ToolStripMenuItem3.Visible = False
                BiayaToolStripMenuItem.Visible = False
                PendapatanLainlainToolStripMenuItem.Visible = False
            ElseIf rddd.Item("O_KAS") = "Y" Then
                DataKasToolStripMenuItem.Visible = True
                ToolStripMenuItem3.Visible = True
                BiayaToolStripMenuItem.Visible = True
                PendapatanLainlainToolStripMenuItem.Visible = True
            Else
                DataKasToolStripMenuItem.Visible = False
                ToolStripMenuItem3.Visible = False
                BiayaToolStripMenuItem.Visible = False
                PendapatanLainlainToolStripMenuItem.Visible = False
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

    Private Sub ReturPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturPenjualanToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As INPUT_REJUAL
        frm = New INPUT_REJUAL
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Button3.Visible = True
        frm.Button2.Visible = False
        frm.Button1.Visible = False
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub LaporanReturPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanReturPenjualanToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As DATA_REJUAL
        frm = New DATA_REJUAL
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub HistoryPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryPenjualanToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As HISTORI_JUAL
        frm = New HISTORI_JUAL
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub DataHutangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataHutangToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As DATA_HUTANG
        frm = New DATA_HUTANG
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub ListHutangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListHutangToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As LIST_HUTANG
        frm = New LIST_HUTANG
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub DataPiutangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPiutangToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As DATA_PIUTANG
        frm = New DATA_PIUTANG
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub ListPiutangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListPiutangToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As LIST_PIUTANG
        frm = New LIST_PIUTANG
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub BayarHutangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BayarHutangToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As BAYAR_HUTANG
        frm = New BAYAR_HUTANG
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub TerimaPiutangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerimaPiutangToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As BAYAR_PIUTANG
        frm = New BAYAR_PIUTANG
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub DataKasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKasToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As DATA_KAS
        frm = New DATA_KAS
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub BiayaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiayaToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As INPUT_BIAYA
        frm = New INPUT_BIAYA
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub PendapatanLainlainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendapatanLainlainToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As INPUT_PENDAPATAN
        frm = New INPUT_PENDAPATAN
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

  
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As MUTASI_KAS
        frm = New MUTASI_KAS
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As DISCOUNT
        frm = New DISCOUNT
        frm.Text = "HOME"
        frm.MdiParent = Me
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url As String = "https://www.google.com/gmail/"
        Process.Start(url)
    End Sub
End Class