Imports System.Data.Odbc
Public Class ClsPasien
    Private fno_pasien As String
    Private fnm_pasien As String
    Private ftmpt_lahir As String
    Private ftgl_lahir As Date
    Private fjns_kelamin As String
    Private fusia As Integer
    Private falamat As String
    Private ftelepon As String
    Private fagama As String
    Private fpekerjaan As String
    Private fgolongan_darah As String
    Private fkk As String

    Public Property pagama As String
        Get
            Return fagama
        End Get
        Set(ByVal value As String)
            fagama = value
        End Set
    End Property

    Public Property palamat As String
        Get
            Return falamat
        End Get
        Set(ByVal value As String)
            falamat = value
        End Set
    End Property

    Public Property pgolongan_darah As String
        Get
            Return fgolongan_darah
        End Get
        Set(ByVal value As String)
            fgolongan_darah = value
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

    Public Property pkk As String
        Get
            Return fkk
        End Get
        Set(ByVal value As String)
            fkk = value
        End Set
    End Property

    Public Property pnm_pasien As String
        Get
            Return fnm_pasien
        End Get
        Set(ByVal value As String)
            fnm_pasien = value
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

    Public Property ppekerjaan As String
        Get
            Return fpekerjaan
        End Get
        Set(ByVal value As String)
            fpekerjaan = value
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

    Public Property ptmpt_lahir As String
        Get
            Return ftmpt_lahir
        End Get
        Set(ByVal value As String)
            ftmpt_lahir = value
        End Set
    End Property

    Public Property pusia As Integer
        Get
            Return fusia
        End Get
        Set(ByVal value As Integer)
            fusia = value
        End Set
    End Property

    Public Function autonumber() As String
        Dim xAuto As String
        Dim xmyCmd As OdbcCommand
        Dim xmyRead As OdbcDataReader
        Dim NA As String
        Dim strValue As String = ""
        xAuto = "select * from pasien order by no_pasien desc"
        xmyCmd = New OdbcCommand(xAuto, MyCn)
        xmyRead = xmyCmd.ExecuteReader
        If xmyRead.HasRows Then
            xmyRead.Read()
            NA = Mid(xmyRead.Item("no_pasien"), 2, 5)
            strValue = Val(NA) + 1
            NA = "P" & Mid("00000", 1, 5 - strValue.Length) & strValue
        Else
            NA = "P00001"
        End If
        xmyRead.Dispose()
        Return NA
    End Function

    Public Function simpan() As Integer
        Dim xSimpan As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        xSimpan = "INSERT INTO pasien "
        xSimpan &= "(no_pasien,nm_pasien,tmpt_lahir,tgl_lahir,jns_kelamin,usia,alamat,telepon,agama,golongan_darah,pekerjaan,kk) "
        xSimpan &= " values(?,?,?,?,?,?,?,?,?,?,?,?)"
        xMyCmd = New OdbcCommand(xSimpan, MyCn)

        xMyCmd.Parameters.AddWithValue("no_pasien", fno_pasien)
        xMyCmd.Parameters.AddWithValue("nm_pasien", fnm_pasien)
        xMyCmd.Parameters.AddWithValue("tmpt_lahir", ftmpt_lahir)
        xMyCmd.Parameters.AddWithValue("tgl_lahir", ftgl_lahir)
        xMyCmd.Parameters.AddWithValue("jns_kelamin", fjns_kelamin)
        xMyCmd.Parameters.AddWithValue("usia", fusia)
        xMyCmd.Parameters.AddWithValue("alamat", falamat)
        xMyCmd.Parameters.AddWithValue("telepon", ftelepon)
        xMyCmd.Parameters.AddWithValue("agama", fagama)
        xMyCmd.Parameters.AddWithValue("golongan_darah", fgolongan_darah)
        xMyCmd.Parameters.AddWithValue("pekerjaan", fpekerjaan)
        xMyCmd.Parameters.AddWithValue("kk", fkk)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function

    Public Function ubah() As Integer
        Dim XUbah As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        XUbah = "UPDATE pasien SET nm_pasien=? ,tmpt_lahir=? ,tgl_lahir=? ,jns_kelamin=? ,usia=? ,alamat=? ,telepon=? ,agama=? ,golongan_darah=? ,pekerjaan=? ,kk=?"
        XUbah &= " WHERE no_pasien=?"
        xMyCmd = New OdbcCommand(XUbah, MyCn)

        xMyCmd.Parameters.AddWithValue("nm_pasien", fnm_pasien)
        xMyCmd.Parameters.AddWithValue("tmpt_lahir", ftmpt_lahir)
        xMyCmd.Parameters.AddWithValue("tgl_lahir", ftgl_lahir)
        xMyCmd.Parameters.AddWithValue("jns_kelamin", fjns_kelamin)
        xMyCmd.Parameters.AddWithValue("usia", fusia)
        xMyCmd.Parameters.AddWithValue("alamat", falamat)
        xMyCmd.Parameters.AddWithValue("telepon", ftelepon)
        xMyCmd.Parameters.AddWithValue("agama", fagama)
        xMyCmd.Parameters.AddWithValue("golongan_darah", fgolongan_darah)
        xMyCmd.Parameters.AddWithValue("pekerjaan", fpekerjaan)
        xMyCmd.Parameters.AddWithValue("kk", fkk)
        xMyCmd.Parameters.AddWithValue("no_pasien", fno_pasien)

        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()

        xMyCmd.Dispose()
        Return X
    End Function

    Public Function tampildata(Optional ByVal xnama_pasien As String = "") As List(Of ClsPasien)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpBaca As New List(Of ClsPasien)

        Q = "SELECT no_pasien,nm_pasien,tmpt_lahir,tgl_lahir,jns_kelamin,usia,alamat,telepon,agama,golongan_darah,pekerjaan,kk"
        Q &= " FROM pasien WHERE nm_pasien LIKE '%" & xnama_pasien & "%'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsPasien
                objTemp.fno_pasien = xMyRead.Item("no_pasien")
                objTemp.fnm_pasien = xMyRead.Item("nm_pasien")
                objTemp.ftmpt_lahir = xMyRead.Item("tmpt_lahir")
                objTemp.ftgl_lahir = xMyRead.Item("tgl_lahir")
                objTemp.fjns_kelamin = xMyRead.Item("jns_kelamin")
                objTemp.fusia = xMyRead.Item("usia")
                objTemp.falamat = xMyRead.Item("alamat")
                objTemp.ftelepon = xMyRead.Item("telepon")
                objTemp.fagama = xMyRead.Item("agama")
                objTemp.fgolongan_darah = xMyRead.Item("golongan_darah")
                objTemp.fpekerjaan = xMyRead.Item("pekerjaan")
                objTemp.fkk = xMyRead.Item("kk")
                tmpBaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpBaca
    End Function

    Public Function hapus() As Integer
        Dim xUbah As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        xUbah = "DELETE FROM pasien WHERE no_pasien=?"
        xMyCmd = New OdbcCommand(xUbah, MyCn)
        xMyCmd.Parameters.AddWithValue("no_pasien", fno_pasien)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function

    Public Function cari() As Boolean
        Dim Query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        Query = "SELECT * FROM pasien WHERE no_pasien=?"
        xMyCmd = New OdbcCommand(Query, MyCn)
        xMyCmd.Parameters.AddWithValue("no_pasien", fno_pasien)
        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            fnm_pasien = xMyRead.Item("nm_pasien").ToString
            ftmpt_lahir = xMyRead.Item("tmpt_lahir").ToString
            ftgl_lahir = xMyRead.Item("tgl_lahir").ToString
            fjns_kelamin = xMyRead.Item("jns_kelamin").ToString
            fusia = xMyRead.Item("usia").ToString
            falamat = xMyRead.Item("alamat").ToString
            ftelepon = xMyRead.Item("telepon").ToString
            fagama = xMyRead.Item("agama").ToString
            fpekerjaan = xMyRead.Item("pekerjaan").ToString
            fgolongan_darah = xMyRead.Item("golongan_darah").ToString
            fkk = xMyRead.Item("kk").ToString
            xMyRead.Close()
            Return True
        Else
            xMyRead.Close()
            Return False
        End If
    End Function

End Class
