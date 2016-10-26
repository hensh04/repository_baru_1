Imports System.Data.Odbc
Public Class ClsKartu_Status
    Private fno_daftar As String
    Private ftgl_kartu_status As Date
    Private fkeluhan As String
    Private fdiagnosa As String
    Private fberat_badan As String
    Private ftinggi_badan As String
    Private ftensi As String
    Private fno_pasien As String

    Public Property pberat_badan As String
        Get
            Return fberat_badan
        End Get
        Set(ByVal value As String)
            fberat_badan = value
        End Set
    End Property

    Public Property pdiagnosa As String
        Get
            Return fdiagnosa
        End Get
        Set(ByVal value As String)
            fdiagnosa = value
        End Set
    End Property

    Public Property pkeluhan As String
        Get
            Return fkeluhan
        End Get
        Set(ByVal value As String)
            fkeluhan = value
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

    Public Property pno_pasien As String
        Get
            Return fno_pasien
        End Get
        Set(ByVal value As String)
            fno_pasien = value
        End Set
    End Property

    Public Property ptensi As String
        Get
            Return ftensi
        End Get
        Set(ByVal value As String)
            ftensi = value
        End Set
    End Property

    Public Property ptgl_kartu_status As Date
        Get
            Return ftgl_kartu_status
        End Get
        Set(ByVal value As Date)
            ftgl_kartu_status = value
        End Set
    End Property

    Public Property ptinggi_badan As String
        Get
            Return ftinggi_badan
        End Get
        Set(ByVal value As String)
            ftinggi_badan = value
        End Set
    End Property

    Public Function cari() As Boolean
        Dim query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        query = "SELECT * FROM kartu_status WHERE no_daftar=?"
        xMyCmd = New OdbcCommand(query, MyCn)
        xMyCmd.CommandType = CommandType.Text
        xMyCmd.Parameters.AddWithValue("no_daftar", fno_daftar)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows Then
            fno_daftar = xMyRead.Item("no_daftar").ToString
            ftgl_kartu_status = xMyRead.Item("tgl_kartu_status").ToString
            fkeluhan = xMyRead.Item("keluhan").ToString
            fdiagnosa = xMyRead.Item("diagnosa").ToString
            fberat_badan = xMyRead.Item("berat_badan").ToString
            ftinggi_badan = xMyRead.Item("tinggi_badan").ToString
            ftensi = xMyRead.Item("tensi").ToString
            fno_pasien = xMyRead.Item("no_pasien").ToString
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

        xSimpan = "INSERT INTO kartu_status"
        xSimpan &= "(no_daftar,tgl_kartu_status,keluhan,diagnosa,berat_badan,tinggi_badan,tensi,no_pasien)"
        xSimpan &= "values(?,?,?,?,?,?,?,?)"
        myCmd = New OdbcCommand(xSimpan, MyCn)

        myCmd.Parameters.AddWithValue("no_daftar", fno_daftar)
        myCmd.Parameters.AddWithValue("tgl_kartu_status", ftgl_kartu_status)
        myCmd.Parameters.AddWithValue("keluhan", fkeluhan)
        myCmd.Parameters.AddWithValue("diagnosa", fdiagnosa)
        myCmd.Parameters.AddWithValue("berat_badan", fberat_badan)
        myCmd.Parameters.AddWithValue("tinggi_badan", ftinggi_badan)
        myCmd.Parameters.AddWithValue("tensi", ftensi)
        myCmd.Parameters.AddWithValue("no_pasien", fno_pasien)
        myCmd.Prepare()
        X = myCmd.ExecuteNonQuery

        myCmd.Dispose()
        Return X
    End Function

    Public Function tampildata(ByVal xData As String) As List(Of ClsKartu_Status)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpbaca As New List(Of ClsKartu_Status)

        Q = "SELECT * FROM kartu_status WHERE no_daftar like '%" & xData & "%'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsKartu_Status
                objTemp.Fno_daftar = xMyRead.Item("no_daftar")
                objTemp.ftgl_kartu_status = xMyRead.Item("tgl_kartustatus")
                objTemp.fkeluhan = xMyRead.Item("tinggi_bdn")
                objTemp.fdiagnosa = xMyRead.Item("berat_bdn")
                objTemp.fberat_badan = xMyRead.Item("tekanan_drh")
                objTemp.ftinggi_badan = xMyRead.Item("anamnesa")
                objTemp.ftensi = xMyRead.Item("diagnosa")
                objTemp.fno_pasien = xMyRead.Item("no_pasien")

                tmpbaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpbaca
    End Function

End Class
