Imports System.Data.Odbc
Public Class ClsTindakan
    Private fkd_tindakan As String
    Private fnm_tindakan As String
    Private fharga_tindakan As Double

    Public Property pkd_tindakan As String
        Get
            Return fkd_tindakan
        End Get
        Set(ByVal value As String)
            fkd_tindakan = value
        End Set
    End Property

    Public Property pnm_tindakan As String
        Get
            Return fnm_tindakan
        End Get
        Set(ByVal value As String)
            fnm_tindakan = value
        End Set
    End Property

    Public Property pharga_tindakan As Double
        Get
            Return fharga_tindakan
        End Get
        Set(ByVal value As Double)
            fharga_tindakan = value
        End Set
    End Property


    Public Function autonumber() As String
        Dim xAuto As String
        Dim xmyCmd As OdbcCommand
        Dim xmyRead As OdbcDataReader
        Dim NA As String
        Dim strValue As String = ""
        xAuto = "select * from tindakan order by kd_tindakan desc"
        xmyCmd = New OdbcCommand(xAuto, MyCn)
        xmyRead = xmyCmd.ExecuteReader
        If xmyRead.HasRows Then
            xmyRead.Read()
            NA = Mid(xmyRead.Item("kd_tindakan"), 3, 2)
            strValue = Val(NA) + 1
            NA = "TD" & Mid("00", 1, 2 - strValue.Length) & strValue
        Else
            NA = "TD01"
        End If
        xmyRead.Dispose()
        Return NA
    End Function


    Public Function cari() As Boolean
        Dim Query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        Query = "SELECT * FROM tindakan WHERE kd_tindakan=?"
        xMyCmd = New OdbcCommand(Query, MyCn)
        xMyCmd.Parameters.AddWithValue("kd_tindakan", fkd_tindakan)
        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            fnm_tindakan = xMyRead.Item("nm_tindakan").ToString
            fharga_tindakan = xMyRead.Item("harga_tindakan").ToString
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

        xUbah = "DELETE FROM tindakan WHERE kd_tindakan=?"
        xMyCmd = New OdbcCommand(xUbah, MyCn)
        xMyCmd.Parameters.AddWithValue("kd_tindakan", fkd_tindakan)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function


    Public Function simpan() As Integer
        Dim xSimpan As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        xSimpan = "INSERT INTO tindakan "
        xSimpan &= "(kd_tindakan,nm_tindakan,harga_tindakan) "
        xSimpan &= " values(?,?,?)"
        xMyCmd = New OdbcCommand(xSimpan, MyCn)

        xMyCmd.Parameters.AddWithValue("kd_tindakan", fkd_tindakan)
        xMyCmd.Parameters.AddWithValue("nm_tindakan", fnm_tindakan)
        xMyCmd.Parameters.AddWithValue("harga_tindakan", fharga_tindakan)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function


    Public Function tampildata(Optional ByVal xnama_tindakan As String = "") As List(Of ClsTindakan)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpBaca As New List(Of ClsTindakan)

        Q = "SELECT kd_tindakan,nm_tindakan,harga_tindakan"
        Q &= " FROM tindakan WHERE nm_tindakan LIKE '%" & xnama_tindakan & "%'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsTindakan
                objTemp.fkd_tindakan = xMyRead.Item("kd_tindakan")
                objTemp.fnm_tindakan = xMyRead.Item("nm_tindakan")
                objTemp.fharga_tindakan = xMyRead.Item("harga_tindakan")
                tmpBaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpBaca
    End Function


    Public Function ubah() As Integer
        Dim XUbah As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        XUbah = "UPDATE tindakan SET nm_tindakan=? ,harga_tindakan=?"
        XUbah &= " WHERE kd_tindakan=?"
        xMyCmd = New OdbcCommand(XUbah, MyCn)

        xMyCmd.Parameters.AddWithValue("nm_tindakan", fnm_tindakan)
        xMyCmd.Parameters.AddWithValue("harga_tindakan", fharga_tindakan)
        xMyCmd.Parameters.AddWithValue("kd_tindakan", fkd_tindakan)

        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()

        xMyCmd.Dispose()
        Return X
    End Function

End Class
