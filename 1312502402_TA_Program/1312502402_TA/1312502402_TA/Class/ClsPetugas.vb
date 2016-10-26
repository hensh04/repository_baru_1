Imports System.Data.Odbc
Public Class ClsPetugas
    Private fkd_petugas As String
    Private fnm_petugas As String
    Private fpass As String
    Private ftgl_lahir As Date
    Private fjns_kelamin As String
    Private falamat As String
    Private ftelepon As String

    Public Property palamat As String
        Get
            Return falamat
        End Get
        Set(ByVal value As String)
            falamat = value
        End Set
    End Property

    Public Property pjns_kelamin As String
        Get
            Return fjns_kelamin
        End Get
        Set(ByVal value As String)
            fjns_kelamin = value
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
    Public Property ppass As String
        Get
            Return fpass
        End Get
        Set(ByVal value As String)
            fpass = value
        End Set
    End Property

    Public Property pnm_petugas As String
        Get
            Return fnm_petugas
        End Get
        Set(ByVal value As String)
            fnm_petugas = value
        End Set
    End Property

    Public Property ptelepon As String
        Get
            Return ftelepon
        End Get
        Set(ByVal value As String)
            ftelepon = value
        End Set
    End Property

    Public Property ptgl_lahir As Date
        Get
            Return ftgl_lahir
        End Get
        Set(ByVal value As Date)
            ftgl_lahir = value
        End Set
    End Property

    Public Function cari() As Boolean
        Dim Query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        Query = "SELECT * FROM petugas WHERE kd_petugas=?"
        xMyCmd = New OdbcCommand(Query, MyCn)
        xMyCmd.Parameters.AddWithValue("kd_petugas", fkd_petugas)
        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            fnm_petugas = xMyRead.Item("nm_petugas").ToString
            ftgl_lahir = xMyRead.Item("tgl_lahir").ToString
            fpass = xMyRead.Item("password").ToString
            fjns_kelamin = xMyRead.Item("jns_kelamin").ToString
            falamat = xMyRead.Item("alamat").ToString
            ftelepon = xMyRead.Item("telepon").ToString
            xMyRead.Close()
            Return True
        Else
            xMyRead.Close()
            Return False
        End If
    End Function


    Public Function hapus() As Integer
        Dim xUbah As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        xUbah = "DELETE FROM petugas WHERE kd_petugas=?"
        xMyCmd = New OdbcCommand(xUbah, MyCn)
        xMyCmd.Parameters.AddWithValue("kd_petugas", fkd_petugas)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function


    Public Function simpan() As Integer
        Dim xSimpan As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        xSimpan = "INSERT INTO petugas "
        xSimpan &= "(kd_petugas,nm_petugas,tgl_lahir,jns_kelamin,alamat,telepon,password) "
        xSimpan &= " values(?,?,?,?,?,?,?)"
        xMyCmd = New OdbcCommand(xSimpan, MyCn)

        xMyCmd.Parameters.AddWithValue("kd_petugas", fkd_petugas)
        xMyCmd.Parameters.AddWithValue("nm_petugas", fnm_petugas)
        xMyCmd.Parameters.AddWithValue("tgl_lahir", ftgl_lahir)
        xMyCmd.Parameters.AddWithValue("jns_kelamin", fjns_kelamin)
        xMyCmd.Parameters.AddWithValue("alamat", falamat)
        xMyCmd.Parameters.AddWithValue("telepon", ftelepon)
        xMyCmd.Parameters.AddWithValue("password", fpass)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function


    Public Function tampildata(Optional ByVal xnama_petugas As String = "") As List(Of ClsPetugas)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpBaca As New List(Of ClsPetugas)

        Q = "SELECT kd_petugas,nm_petugas,tgl_lahir,jns_kelamin,alamat,telepon,password"
        Q &= " FROM petugas WHERE nm_petugas LIKE '%" & xnama_petugas & "%'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsPetugas
                objTemp.fkd_petugas = xMyRead.Item("kd_petugas")
                objTemp.fnm_petugas = xMyRead.Item("nm_petugas")
                objTemp.ftgl_lahir = xMyRead.Item("tgl_lahir")
                objTemp.fjns_kelamin = xMyRead.Item("jns_kelamin")
                objTemp.falamat = xMyRead.Item("alamat")
                objTemp.ftelepon = xMyRead.Item("telepon")
                objTemp.fpass = xMyRead.Item("password")
                tmpBaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpBaca
    End Function


    Public Function ubah() As Integer
        Dim XUbah As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        XUbah = "UPDATE petugas SET nm_petugas=? ,tgl_lahir=?, password=? ,jns_kelamin=? ,alamat=? ,telepon=?"
        XUbah &= " WHERE kd_petugas=?"
        xMyCmd = New OdbcCommand(XUbah, MyCn)

        xMyCmd.Parameters.AddWithValue("nm_petugas", fnm_petugas)
        xMyCmd.Parameters.AddWithValue("tgl_lahir", ftgl_lahir)
        xMyCmd.Parameters.AddWithValue("password", fpass)
        xMyCmd.Parameters.AddWithValue("jns_kelamin", fjns_kelamin)
        xMyCmd.Parameters.AddWithValue("alamat", falamat)
        xMyCmd.Parameters.AddWithValue("telepon", ftelepon)
        xMyCmd.Parameters.AddWithValue("kd_petugas", fkd_petugas)

        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()

        xMyCmd.Dispose()
        Return X
    End Function

End Class
