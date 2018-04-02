Imports FirebirdSql.Data.FirebirdClient
Imports System.IO
Module CONNECTION
    Public konek As New FbConnection()
    Dim readText As String

    Sub texting()
        Dim path As String = "C:\DB\EL.conf"
        readText = File.ReadAllText(path)
    End Sub

    Sub koneksi_db()
        Dim IP_add As String = readText
        Dim constKoneksiString As String = "User ID=SYSDBA;Password=masterkey;Database=" + IP_add + ":C:\DB\EL.FDB;Datasource=" + IP_add + ";Charset=NONE;"
        Try
            If konek.State <> 0 Then konek.Close()
            konek.ConnectionString = constKoneksiString
            konek.Open()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical +
                  MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly,
                  "Koneksi Error")
        End Try
    End Sub

    Sub callprogress(ByVal sQl As String)
        Dim SQLCmd As New FbCommand()
        koneksi_db()
        Try
            SQLCmd.Connection = konek
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.CommandText = sQl
            SQLCmd.ExecuteNonQuery()
            SQLCmd.Dispose()
            konek.Close()
            MsgBox("Sukses", vbInformation)
        Catch ex As Exception
            MsgBox("Gagal !!! " & ex.Message, vbIgnore)
        End Try
    End Sub

    Sub callprogress2(ByVal sQl As String)
        Dim SQLCmd As New FbCommand()
        koneksi_db()
        Try
            SQLCmd.Connection = konek
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.CommandText = sQl
            SQLCmd.ExecuteNonQuery()
            SQLCmd.Dispose()
            konek.Close()
            'MsgBox("Sukses", vbInformation)
        Catch ex As Exception
            MsgBox("Gagal !!! " & ex.Message, vbIgnore)
        End Try
    End Sub

End Module
