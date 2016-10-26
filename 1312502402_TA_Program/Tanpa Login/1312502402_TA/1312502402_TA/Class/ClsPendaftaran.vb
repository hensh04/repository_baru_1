Imports System.Data.Odbc
Public Class ClsPendaftaran
    Private fno_daftar As String
    Private ftgl_daftar As Date
    Private fbiaya_daftar As Integer
    Private fbiaya_dokter As Integer
    Private fkd_petugas As String
    Private fkd_dokter As String
    Private fno_pasien As String

    Public Property pno_daftar As String
        Get
            Return fno_daftar
        End Get
        Set(ByVal value As String)
            fno_daftar = value
        End Set
    End Property

    Public Property ptgl_daftar As Date
        Get
            Return ftgl_daftar
        End Get
        Set(ByVal value As Date)
            ftgl_daftar = value
        End Set
    End Property

    Public Property pbiaya_daftar As Integer
        Get
            Return fbiaya_daftar
        End Get
        Set(ByVal value As Integer)
            fbiaya_daftar = value
        End Set
    End Property

    Public Property pbiaya_dokter As Integer
        Get
            Return fbiaya_dokter
        End Get
        Set(ByVal value As Integer)
            fbiaya_dokter = value
        End Set
    End Property

    Public Property pkd_petugas As String
        Get
            Return fkd_petugas
        End Get
        Set(ByVal value As String)
            fkd_petugas = value
        End Set
    End Property

    Public Property pkd_dokter As String
        Get
            Return fkd_dokter
        End Get
        Set(ByVal value As String)
            fkd_dokter = value
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

    Public Function autonumber() As String
        Dim xAuto As String
        Dim xmyCmd As OdbcCommand
        Dim xmyRead As OdbcDataReader
        Dim NA As String
        Dim strValue As String = ""
        xAuto = "select * from pendaftaran order by no_daftar desc"
        xmyCmd = New OdbcCommand(xAuto, MyCn)
        xmyRead = xmyCmd.ExecuteReader
        If xmyRead.HasRows Then
            xmyRead.Read()
            NA = Mid(xmyRead.Item("no_daftar"), 4, 5)
            strValue = Val(NA) + 1
            NA = "DAF" & Mid("00000", 1, 5 - strValue.Length) & strValue
        Else
            NA = "DAF00001"
        End If
        xmyRead.Dispose()
        Return NA
    End Function

    Public Function cari() As Boolean
        Dim query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        query = "SELECT * FROM pendaftaran WHERE no_daftar=?"
        xMyCmd = New OdbcCommand(query, MyCn)
        xMyCmd.CommandType = CommandType.Text
        xMyCmd.Parameters.AddWithValue("no_daftar", fno_daftar)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows Then
            fno_daftar = xMyRead.Item("no_daftar").ToString
            ftgl_daftar = xMyRead.Item("tgl_daftar").ToString
            fbiaya_daftar = xMyRead.Item("biaya_daftar").ToString
            fbiaya_dokter = xMyRead.Item("biaya_dokter").ToString
            fkd_petugas = xMyRead.Item("kd_petugas").ToString
            fkd_dokter = xMyRead.Item("kd_dokter").ToString
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

        xSimpan = "INSERT INTO pendaftaran"
        xSimpan &= "(no_daftar,tgl_daftar,biaya_daftar,biaya_dokter,kd_petugas,kd_dokter,no_pasien)"
        xSimpan &= "values(?,?,?,?,?,?,?)"
        myCmd = New OdbcCommand(xSimpan, MyCn)

        myCmd.Parameters.AddWithValue("no_daftar", fno_daftar)
        myCmd.Parameters.AddWithValue("tgl_daftar", ftgl_daftar)
        myCmd.Parameters.AddWithValue("biaya_daftar", fbiaya_daftar)
        myCmd.Parameters.AddWithValue("biaya_dokter", fbiaya_dokter)
        myCmd.Parameters.AddWithValue("kd_petugas", fkd_petugas)
        myCmd.Parameters.AddWithValue("kd_dokter", fkd_dokter)
        myCmd.Parameters.AddWithValue("no_pasien", fno_pasien)

        myCmd.Prepare()
        X = myCmd.ExecuteNonQuery

        myCmd.Dispose()
        Return X
    End Function

    Public Function tampildata(ByVal xData As String) As List(Of ClsPendaftaran)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpbaca As New List(Of ClsPendaftaran)

        Q = "SELECT * FROM pendaftaran WHERE no_daftar like '%" & xData & "%' order by no_daftar desc"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsPendaftaran
                objTemp.fno_daftar = xMyRead.Item("no_daftar")
                objTemp.ftgl_daftar = xMyRead.Item("tgl_daftar")
                objTemp.pbiaya_daftar = xMyRead.Item("biaya_daftar")
                objTemp.fbiaya_dokter = xMyRead.Item("biaya_dokter")
                objTemp.fkd_petugas = xMyRead.Item("kd_petugas")
                objTemp.fkd_dokter = xMyRead.Item("kd_dokter")
                objTemp.fno_pasien = xMyRead.Item("no_pasien")

                tmpbaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpbaca
    End Function

    Public Sub tampildata2(ByVal xData As String, ByVal NmListView As ListView)
        Dim i, x As Integer
        x = 0
        NmListView.Items.Clear()

        Dim Q As String
        Dim xmycmd As OdbcCommand
        Dim xmyread As OdbcDataReader
        Dim tmpBaca As New List(Of ClsPendaftaran)

        Q = "SELECT pendaftaran.no_daftar, pendaftaran.tgl_daftar, pasien.no_pasien, pasien.nm_pasien, dokter.kd_dokter, dokter.nm_dokter FROM pendaftaran, pasien, dokter WHERE pendaftaran.no_pasien =pasien.no_pasien and pendaftaran.kd_dokter = dokter.kd_dokter and pendaftaran.no_daftar not in (select no_daftar from kwitansi) and pasien.nm_pasien like '%" & xData & "%' order by pendaftaran.no_daftar  desc"
        xmycmd = New OdbcCommand(Q, MyCn)

        xmyread = xmycmd.ExecuteReader
        Try
            While xmyread.Read
                i = i + 1
                With NmListView
                    NmListView.Items.Add(xmyread.Item("no_daftar").ToString)
                    NmListView.Items(x).SubItems.Add(Format(xmyread.Item("tgl_daftar"), "MM/dd/yyyy")).ToString()
                    NmListView.Items(x).SubItems.Add(xmyread.Item("no_pasien").ToString)
                    NmListView.Items(x).SubItems.Add(xmyread.Item("nm_pasien").ToString)
                    NmListView.Items(x).SubItems.Add(xmyread.Item("kd_dokter").ToString)
                    NmListView.Items(x).SubItems.Add(xmyread.Item("nm_dokter").ToString)
                End With
                x = x + 1
            End While
        Finally
        End Try
    End Sub

    Public Sub tampildata3(ByVal xData As String, ByVal NmListView As ListView)
        Dim i, x As Integer
        x = 0
        NmListView.Items.Clear()

        Dim Q As String
        Dim xmycmd As OdbcCommand
        Dim xmyread As OdbcDataReader
        Dim tmpBaca As New List(Of ClsPendaftaran)

        Q = "SELECT pendaftaran.no_daftar, pendaftaran.tgl_daftar, pasien.no_pasien, pasien.nm_pasien, dokter.kd_dokter, dokter.nm_dokter FROM pendaftaran, pasien, dokter WHERE pendaftaran.no_pasien =pasien.no_pasien and pendaftaran.kd_dokter = dokter.kd_dokter  and  pasien.nm_pasien like '%" & xData & "%' order by pendaftaran.no_daftar desc"
        xmycmd = New OdbcCommand(Q, MyCn)

        xmyread = xmycmd.ExecuteReader
        Try
            While xmyread.Read
                i = i + 1
                With NmListView
                    NmListView.Items.Add(xmyread.Item("no_daftar").ToString)
                    NmListView.Items(x).SubItems.Add(Format(xmyread.Item("tgl_daftar"), "MM/dd/yyyy")).ToString()
                    NmListView.Items(x).SubItems.Add(xmyread.Item("no_pasien").ToString)
                    NmListView.Items(x).SubItems.Add(xmyread.Item("nm_pasien").ToString)
                    NmListView.Items(x).SubItems.Add(xmyread.Item("kd_dokter").ToString)
                    NmListView.Items(x).SubItems.Add(xmyread.Item("nm_dokter").ToString)
                End With
                x = x + 1
            End While
        Finally
        End Try
    End Sub

End Class
