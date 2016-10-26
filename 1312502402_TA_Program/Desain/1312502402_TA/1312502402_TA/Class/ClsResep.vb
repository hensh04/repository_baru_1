Imports System.Data.Odbc
Public Class ClsResep
    Private fno_resep As String
    Private ftgl_resep As Date
    Private fno_daftar As String

    Public Property pno_daftar As String
        Get
            Return fno_daftar
        End Get
        Set(ByVal value As String)
            fno_daftar = value
        End Set
    End Property

    Public Property pno_resep As String
        Get
            Return fno_resep
        End Get
        Set(ByVal value As String)
            fno_resep = value
        End Set
    End Property

    Public Property ptgl_resep As Date
        Get
            Return ftgl_resep
        End Get
        Set(ByVal value As Date)
            ftgl_resep = value
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
        query = "SELECT * FROM resep ORDER BY no_resep DESC"
        xMyCmd = New OdbcCommand(query, mycn)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows = True Then
            xMyRead.Read()
            strTemp = Mid(xMyRead.Item("no_resep"), 4, 8)
            NA = Val(strTemp) + 1
            NA = "RSP" & Mid("00000", 1, 5 - NA.Length) & NA
        Else
            NA = "RSP00001"
        End If

        xMyRead.Dispose()
        Return NA
    End Function

    Public Function cari() As Boolean
        Dim query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        query = "SELECT * FROM resep WHERE no_resep=?"
        xMyCmd = New OdbcCommand(query, MyCn)
        xMyCmd.CommandType = CommandType.Text
        xMyCmd.Parameters.AddWithValue("no_resep", fno_resep)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows Then
            fno_resep = xMyRead.Item("no_resep").ToString
            ftgl_resep = xMyRead.Item("tgl_resep").ToString
            fno_daftar = xMyRead.Item("no_daftar").ToString
            xMyRead.Close()
            Return True
        Else
            xMyRead.Close()
            Return False
        End If
    End Function

    Public Function cari2() As Boolean
        Dim query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        query = "SELECT * FROM resep WHERE no_daftar=?"
        xMyCmd = New OdbcCommand(query, MyCn)
        xMyCmd.CommandType = CommandType.Text
        xMyCmd.Parameters.AddWithValue("no_daftar", fno_daftar)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows Then
            fno_resep = xMyRead.Item("no_resep").ToString
            ftgl_resep = xMyRead.Item("tgl_resep").ToString
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

        xSimpan = "INSERT INTO resep"
        xSimpan &= "(no_resep,tgl_resep,no_daftar)"
        xSimpan &= "values(?,?,?)"
        myCmd = New OdbcCommand(xSimpan, MyCn)

        myCmd.Parameters.AddWithValue("no_resep", fno_resep)
        myCmd.Parameters.AddWithValue("tgl_resep", ftgl_resep)
        myCmd.Parameters.AddWithValue("no_daftar", fno_daftar)

        myCmd.Prepare()
        X = myCmd.ExecuteNonQuery

        myCmd.Dispose()
        Return X
    End Function

    Public Function tampildata(ByVal xData As String) As List(Of ClsResep)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpbaca As New List(Of ClsResep)

        Q = "SELECT * FROM resep WHERE no_resep like '%" & xData & "%'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsResep
                objTemp.fno_resep = xMyRead.Item("no_resep")
                objTemp.ftgl_resep = xMyRead.Item("tgl_resep")
                objTemp.fno_daftar = xMyRead.Item("no_daftar")

                tmpbaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpbaca
    End Function

    'Public Function cari2() As Boolean

    'End Function




End Class
