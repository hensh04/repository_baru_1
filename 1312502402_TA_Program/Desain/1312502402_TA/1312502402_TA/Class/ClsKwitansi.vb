Imports System.Data.Odbc
Public Class ClsKwitansi
    Private fno_kwitansi As String
    Private ftgl_kwitansi As Date
    Private fjlm_bayar As Integer
    Private fno_daftar As String

    Public Property pno_daftar As String
        Get
            Return fno_daftar
        End Get
        Set(ByVal value As String)
            fno_daftar = value
        End Set
    End Property

    Public Property pno_kwitansi As String
        Get
            Return fno_kwitansi
        End Get
        Set(ByVal value As String)
            fno_kwitansi = value
        End Set
    End Property

    Public Property ptgl_kwitansi As Date
        Get
            Return ftgl_kwitansi
        End Get
        Set(ByVal value As Date)
            ftgl_kwitansi = value
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
        query = "SELECT * FROM kwitansi ORDER BY no_kwitansi DESC"
        xMyCmd = New OdbcCommand(query, mycn)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows = True Then
            xMyRead.Read()
            strTemp = Mid(xMyRead.Item("no_kwitansi"), 4, 8)
            NA = Val(strTemp) + 1
            NA = "KWT" & Mid("00000", 1, 5 - NA.Length) & NA
        Else
            NA = "KWT00001"
        End If

        xMyRead.Dispose()
        Return NA
    End Function

    Public Function cari() As Boolean
        Dim query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        query = "SELECT * FROM kwitansi WHERE no_kwitansi=?"
        xMyCmd = New OdbcCommand(query, MyCn)
        xMyCmd.CommandType = CommandType.Text
        xMyCmd.Parameters.AddWithValue("no_kwitansi", fno_kwitansi)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows Then
            fno_kwitansi = xMyRead.Item("no_kwit").ToString
            ftgl_kwitansi = xMyRead.Item("tgl_kwit").ToString
            fno_daftar = xMyRead.Item("no_nota").ToString
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

        xSimpan = "INSERT INTO kwitansi"
        xSimpan &= "(no_kwitansi,tgl_kwitansi,no_daftar)"
        xSimpan &= "values(?,?,?)"
        myCmd = New OdbcCommand(xSimpan, MyCn)

        myCmd.Parameters.AddWithValue("no_kwitansi", fno_kwitansi)
        myCmd.Parameters.AddWithValue("tgl_kwitansi", ftgl_kwitansi)
        myCmd.Parameters.AddWithValue("no_daftar", fno_daftar)

        myCmd.Prepare()
        X = myCmd.ExecuteNonQuery

        myCmd.Dispose()
        Return X
    End Function

    Public Function tampildata(ByVal xData As String) As List(Of ClsKwitansi)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpbaca As New List(Of ClsKwitansi)

        Q = "SELECT * FROM kwitansi WHERE no_kwitansi like '%" & xData & "%'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsKwitansi
                objTemp.fno_kwitansi = xMyRead.Item("no_kwitansi")
                objTemp.ftgl_kwitansi = xMyRead.Item("tgl_kwitansi")
                objTemp.fno_daftar = xMyRead.Item("no_daftar")

                tmpbaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpbaca
    End Function

End Class
