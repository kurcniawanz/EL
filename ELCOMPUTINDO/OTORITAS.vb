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

            If String.IsNullOrEmpty(rddd.Item("O_PARTNER").ToString) Then
                c_partner.Checked = False
            ElseIf rddd.Item("O_PARTNER") = "Y" Then
                c_partner.Checked = True
            Else
                c_partner.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_CATEGORY").ToString) Then
                c_category.Checked = False
            ElseIf rddd.Item("O_CATEGORY") = "Y" Then
                c_category.Checked = True
            Else
                c_category.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_BARANG").ToString) Then
                c_barang.Checked = False
            ElseIf rddd.Item("O_BARANG") = "Y" Then
                c_barang.Checked = True
            Else
                c_barang.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_STOCK").ToString) Then
                c_stock.Checked = False
            ElseIf rddd.Item("O_STOCK") = "Y" Then
                c_stock.Checked = True
            Else
                c_stock.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_MUTASI").ToString) Then
                c_mutasi.Checked = False
            ElseIf rddd.Item("O_MUTASI") = "Y" Then
                c_mutasi.Checked = True
            Else
                c_mutasi.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_BELI").ToString) Then
                c_beli.Checked = False
            ElseIf rddd.Item("O_BELI") = "Y" Then
                c_beli.Checked = True
            Else
                c_beli.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_KOREKSI").ToString) Then
                c_koreksi.Checked = False
            ElseIf rddd.Item("O_KOREKSI") = "Y" Then
                c_koreksi.Checked = True
            Else
                c_koreksi.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_REBELI").ToString) Then
                c_rebeli.Checked = False
            ElseIf rddd.Item("O_REBELI") = "Y" Then
                c_rebeli.Checked = True
            Else
                c_rebeli.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_HISTORI_BELI").ToString) Then
                c_historibeli.Checked = False
            ElseIf rddd.Item("O_HISTORI_BELI") = "Y" Then
                c_historibeli.Checked = True
            Else
                c_historibeli.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_JUAL").ToString) Then
                c_jual.Checked = False
            ElseIf rddd.Item("O_JUAL") = "Y" Then
                c_jual.Checked = True
            Else
                c_jual.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_HISTORI_JUAL").ToString) Then
                c_historijual.Checked = False
            ElseIf rddd.Item("O_HISTORI_JUAL") = "Y" Then
                c_historijual.Checked = True
            Else
                c_historijual.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_REJUAL").ToString) Then
                c_rejual.Checked = False
            ElseIf rddd.Item("O_REJUAL") = "Y" Then
                c_rejual.Checked = True
            Else
                c_rejual.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_HUTANG").ToString) Then
                c_hutang.Checked = False
            ElseIf rddd.Item("O_HUTANG") = "Y" Then
                c_hutang.Checked = True
            Else
                c_hutang.Checked = False
            End If

            If String.IsNullOrEmpty(rddd.Item("O_PIUTANG").ToString) Then
                c_piutang.Checked = False
            ElseIf rddd.Item("O_PIUTANG") = "Y" Then
                c_piutang.Checked = True
            Else
                c_piutang.Checked = False
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

        Dim tmp_partner As String = "N"
        If c_partner.Checked = True Then
            tmp_partner = "Y"
        End If

        Dim tmp_category As String = "N"
        If c_category.Checked = True Then
            tmp_category = "Y"
        End If

        Dim tmp_barang As String = "N"
        If c_barang.Checked = True Then
            tmp_barang = "Y"
        End If

        Dim tmp_stock As String = "N"
        If c_stock.Checked = True Then
            tmp_stock = "Y"
        End If

        Dim tmp_mutasi As String = "N"
        If c_mutasi.Checked = True Then
            tmp_mutasi = "Y"
        End If

        Dim tmp_beli As String = "N"
        If c_beli.Checked = True Then
            tmp_beli = "Y"
        End If

        Dim tmp_koreksi As String = "N"
        If c_koreksi.Checked = True Then
            tmp_koreksi = "Y"
        End If

        Dim tmp_rebeli As String = "N"
        If c_rebeli.Checked = True Then
            tmp_rebeli = "Y"
        End If

        Dim tmp_historibeli As String = "N"
        If c_historibeli.Checked = True Then
            tmp_historibeli = "Y"
        End If

        Dim tmp_jual As String = "N"
        If c_jual.Checked = True Then
            tmp_jual = "Y"
        End If

        Dim tmp_rejual As String = "N"
        If c_rejual.Checked = True Then
            tmp_rejual = "Y"
        End If

        Dim tmp_historijual As String = "N"
        If c_historijual.Checked = True Then
            tmp_historijual = "Y"
        End If

        Dim tmp_hutang As String = "N"
        If c_hutang.Checked = True Then
            tmp_hutang = "Y"
        End If

        Dim tmp_piutang As String = "N"
        If c_piutang.Checked = True Then
            tmp_piutang = "Y"
        End If

        Dim edit As String
        edit = "UPDATE TB_OTORITAS SET " _
            + " O_ACCOUNT = '" & tmp_account & "', " _
            + " O_USER = '" & tmp_user & "', " _
            + " O_PARTNER = '" & tmp_partner & "', " _
            + " O_BARANG = '" & tmp_barang & "', " _
            + " O_STOCK = '" & tmp_stock & "', " _
            + " O_CATEGORY = '" & tmp_category & "' ," _
            + " O_MUTASI = '" & tmp_mutasi & "', " _
            + " O_BELI = '" & tmp_beli & "', " _
            + " O_KOREKSI = '" & tmp_koreksi & "', " _
            + " O_REBELI = '" & tmp_rebeli & "'," _
            + " O_HISTORI_BELI = '" & tmp_historibeli & "'," _
            + " O_JUAL = '" & tmp_jual & "'," _
            + " O_HISTORI_JUAL = '" & tmp_historijual & "'," _
            + " O_REJUAL = '" & tmp_rejual & ",'" _
            + " O_HUTANG = '" & tmp_hutang & "'," _
            + " O_PIUTANG = '" & tmp_piutang & "'" _
            + " WHERE NAMA = '" & txtnamauser.Text & "' "
        callprogress(edit)
        Me.Close()
    End Sub
End Class