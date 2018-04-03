﻿Imports System.Data.SqlClient
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

        Dim edit As String
        edit = "UPDATE TB_OTORITAS SET " _
            + " O_ACCOUNT = '" & tmp_account & "', " _
            + " O_USER = '" & tmp_user & "', " _
            + " O_PARTNER = '" & tmp_partner & "', " _
            + " O_BARANG = '" & tmp_barang & "', " _
            + " O_STOCK = '" & tmp_stock & "', " _
            + " O_CATEGORY = '" & tmp_category & "' " _
            + " WHERE NAMA = '" & txtnamauser.Text & "' "
        callprogress(edit)
        Me.Close()
    End Sub
End Class