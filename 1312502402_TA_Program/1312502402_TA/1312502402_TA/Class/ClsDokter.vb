Imports System.Data.Odbc
Public Class ClsDokter
    Private fkd_dokter As String
    Private fnm_dokter As String
    Private ftgl_lahir As Date
    Private fjns_kelamin As String
    Private falamat As String
    Private ftelepon As String
    Private fbiaya_jasa As Double

    Public Property palamat As String
        Get
            Return falamat
        End Get
        Set(ByVal value As String)
            falamat = value
        End Set
    End Property

    Public Property pbiaya_jasa As Double
        Get
            Return fbiaya_jasa
        End Get
        Set(ByVal value As Double)
            fbiaya_jasa = value
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

    Public Property pkd_dokter As String
        Get
            Return fkd_dokter
        End Get
        Set(ByVal value As String)
            fkd_dokter = value
        End Set
    End Property

    Public Property pnm_dokter As String
        Get
            Return fnm_dokter
        End Get
        Set(ByVal value As String)
            fnm_dokter = value
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


    Public Function autonumber() As String
        Dim xAuto As String
        Dim xmyCmd As OdbcCommand
        Dim xmyRead As OdbcDataReader
        Dim NA As String
        Dim strValue As String = ""
        xAuto = "select * from dokter order by kd_dokter desc"
        xmyCmd = New OdbcCommand(xAuto, MyCn)
        xmyRead = xmyCmd.ExecuteReader
        If xmyRead.HasRows Then
            xmyRead.Read()
            NA = Mid(xmyRead.Item("kd_dokter"), 3, 2)
            strValue = Val(NA) + 1
            NA = "DR" & Mid("00", 1, 2 - strValue.Length) & strValue
        Else
            NA = "DR01"
        End If
        xmyRead.Dispose()
        Return NA
    End Function


    Public Function cari() As Boolean
        Dim Query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        Query = "SELECT * FROM dokter WHERE kd_dokter=?"
        xMyCmd = New OdbcCommand(Query, mycn)
        xMyCmd.Parameters.AddWithValue("kd_dokter", fkd_dokter)
        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            fnm_dokter = xMyRead.Item("nm_dokter").ToString
            ftgl_lahir = xMyRead.Item("tgl_lahir").ToString
            fjns_kelamin = xMyRead.Item("jns_kelamin").ToString
            falamat = xMyRead.Item("alamat").ToString
            ftelepon = xMyRead.Item("telepon").ToString
            fbiaya_jasa = xMyRead.Item("biaya_jasa").ToString
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

        xUbah = "DELETE FROM dokter WHERE kd_dokter=?"
        xMyCmd = New OdbcCommand(xUbah, mycn)
        xMyCmd.Parameters.AddWithValue("kd_dokter", fkd_dokter)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function


    Public Function simpan() As Integer
        Dim xSimpan As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        xSimpan = "INSERT INTO dokter "
        xSimpan &= "(kd_dokter,nm_dokter,tgl_lahir,jns_kelamin,alamat,telepon,biaya_jasa) "
        xSimpan &= " values(?,?,?,?,?,?,?)"
        xMyCmd = New OdbcCommand(xSimpan, mycn)

        xMyCmd.Parameters.AddWithValue("kd_dokter", fkd_dokter)
        xMyCmd.Parameters.AddWithValue("nm_dokter", fnm_dokter)
        xMyCmd.Parameters.AddWithValue("tgl_lahir", ftgl_lahir)
        xMyCmd.Parameters.AddWithValue("jns_kelamin", fjns_kelamin)
        xMyCmd.Parameters.AddWithValue("alamat", falamat)
        xMyCmd.Parameters.AddWithValue("telepon", ftelepon)
        xMyCmd.Parameters.AddWithValue("biaya_jasa", fbiaya_jasa)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function


    Public Function tampildata(Optional ByVal xnama_dokter As String = "") As List(Of ClsDokter)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpBaca As New List(Of ClsDokter)

        Q = "SELECT kd_dokter,nm_dokter,tgl_lahir,jns_kelamin,alamat,telepon,biaya_jasa"
        Q &= " FROM dokter WHERE nm_dokter LIKE '%" & xnama_dokter & "%'"
        xMyCmd = New OdbcCommand(Q, mycn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsDokter
                objTemp.fkd_dokter = xMyRead.Item("kd_dokter")
                objTemp.fnm_dokter = xMyRead.Item("nm_dokter")
                objTemp.ftgl_lahir = xMyRead.Item("tgl_lahir")
                objTemp.fjns_kelamin = xMyRead.Item("jns_kelamin")
                objTemp.falamat = xMyRead.Item("alamat")
                objTemp.ftelepon = xMyRead.Item("telepon")
                objTemp.fbiaya_jasa = xMyRead.Item("biaya_jasa")
                tmpBaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpBaca
    End Function


    Public Function ubah() As Integer
        Dim XUbah As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        XUbah = "UPDATE dokter SET nm_dokter=? ,tgl_lahir=? ,jns_kelamin=? ,alamat=? ,telepon=? ,biaya_jasa=?"
        XUbah &= " WHERE kd_dokter=?"
        xMyCmd = New OdbcCommand(XUbah, mycn)

        xMyCmd.Parameters.AddWithValue("nm_dokter", fnm_dokter)
        xMyCmd.Parameters.AddWithValue("tgl_lahir", ftgl_lahir)
        xMyCmd.Parameters.AddWithValue("jns_kelamin", fjns_kelamin)
        xMyCmd.Parameters.AddWithValue("alamat", falamat)
        xMyCmd.Parameters.AddWithValue("telepon", ftelepon)
        xMyCmd.Parameters.AddWithValue("biaya_jasa", fbiaya_jasa)
        xMyCmd.Parameters.AddWithValue("kd_dokter", fkd_dokter)

        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()

        xMyCmd.Dispose()
        Return X
    End Function

End Class
