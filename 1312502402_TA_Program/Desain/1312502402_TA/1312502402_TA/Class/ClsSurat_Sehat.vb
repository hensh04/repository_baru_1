Imports System.Data.Odbc
Public Class ClsSurat_Sehat

    Private fkeperluan As String
    Private fno_daftar As String
    Private fno_surat_sehat As String
    Private ftgl_surat_sehat As Date

    Public Property pkeperluan As String
        Get
            Return fkeperluan
        End Get
        Set(ByVal value As String)
            fkeperluan = value
        End Set
    End Property

    Public Property pno_daftar As String
        Get
            Return fno_daftar
        End Get
        Set(ByVal value As String)
            fno_daftar = value
        End Set
    End Property

    Public Property pno_surat_sehat As String
        Get
            Return fno_surat_sehat
        End Get
        Set(ByVal value As String)
            fno_surat_sehat = value
        End Set
    End Property

    Public Property ptgl_surat_sehat As Date
        Get
            Return ftgl_surat_sehat
        End Get
        Set(ByVal value As Date)
            ftgl_surat_sehat = value
        End Set
    End Property

    Public Function autonumber() As String
        Dim query As String
        Dim mycn As New OdbcConnection(strconn)
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand
        Dim NA As String
        Dim strTemp As String

        mycn.Open()
        query = "SELECT * FROM surat_sehat ORDER BY no_surat_sehat DESC"
        xMyCmd = New OdbcCommand(query, mycn)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows = True Then
            xMyRead.Read()
            strTemp = Mid(xMyRead.Item("no_surat_sehat"), 4, 8)
            NA = Val(strTemp) + 1
            NA = "NSS" & Mid("00000", 1, 5 - NA.Length) & NA
        Else
            NA = "NSS00001"
        End If

        xMyRead.Dispose()
        Return NA
    End Function

    Public Function cari() As Boolean
        Dim query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        query = "SELECT * FROM surat_sehat WHERE no_surat_sehat=?"
        xMyCmd = New OdbcCommand(query, MyCn)
        xMyCmd.CommandType = CommandType.Text
        xMyCmd.Parameters.AddWithValue("no_surat_sehat", fno_surat_sehat)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows Then
            fno_surat_sehat = xMyRead.Item("no_surat_sehat").ToString
            ftgl_surat_sehat = xMyRead.Item("tgl_surat_sehat").ToString
            fkeperluan = xMyRead.Item("keperluan").ToString
            fno_daftar = xMyRead.Item("no_daftar").ToString
            xMyRead.Close()
            Return True
        Else
            xMyRead.Close()
            Return False
        End If
    End Function


    Public Function simpan() As Integer
        Dim xSimpan As String
        Dim X As Integer
        Dim myCmd As OdbcCommand

        xSimpan = "INSERT INTO surat_sehat"
        xSimpan &= "(no_surat_sehat,tgl_surat_sehat,keperluan,no_daftar)"
        xSimpan &= "values(?,?,?,?)"
        myCmd = New OdbcCommand(xSimpan, MyCn)

        myCmd.Parameters.AddWithValue("no_surat_sehat", fno_surat_sehat)
        myCmd.Parameters.AddWithValue("tgl_surat_sehat", ftgl_surat_sehat)
        myCmd.Parameters.AddWithValue("keperluan", fkeperluan)
        myCmd.Parameters.AddWithValue("no_daftar", fno_daftar)

        myCmd.Prepare()
        X = myCmd.ExecuteNonQuery

        myCmd.Dispose()
        Return X
    End Function

    Public Function tampildata(ByVal xData As String) As List(Of ClsSurat_Sehat)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpbaca As New List(Of ClsSurat_Sehat)

        Q = "SELECT * FROM surat_sehat WHERE no_surat_sehat like '%" & xData & "%'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsSurat_Sehat
                objTemp.fno_surat_sehat = xMyRead.Item("no_surat_sehat")
                objTemp.ftgl_surat_sehat = xMyRead.Item("tgl_surat_sehat")
                objTemp.fkeperluan = xMyRead.Item("keperluan")
                objTemp.fno_daftar = xMyRead.Item("no_daftar")

                tmpbaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpbaca
    End Function

End Class
