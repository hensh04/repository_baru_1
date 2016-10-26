Imports System.Data.Odbc
Public Class ClsObat
    Private fkd_obat As String
    Private fnm_obat As String
    Private fjns_obat As String
    Private fharga_obat As Double
    Private fsatuan As String
    Private fstock As Integer

    Public Property pharga_obat As Double
        Get
            Return fharga_obat
        End Get
        Set(ByVal value As Double)
            fharga_obat = value
        End Set
    End Property

    Public Property pjns_obat As String
        Get
            Return fjns_obat
        End Get
        Set(ByVal value As String)
            fjns_obat = value
        End Set
    End Property

    Public Property pkd_obat As String
        Get
            Return fkd_obat
        End Get
        Set(ByVal value As String)
            fkd_obat = value
        End Set
    End Property

    Public Property pnm_obat As String
        Get
            Return fnm_obat
        End Get
        Set(ByVal value As String)
            fnm_obat = value
        End Set
    End Property

    Public Property psatuan As String
        Get
            Return fsatuan
        End Get
        Set(ByVal value As String)
            fsatuan = value
        End Set
    End Property

    Public Property pstock As Integer
        Get
            Return fstock
        End Get
        Set(ByVal value As Integer)
            fstock = value
        End Set
    End Property


    Public Function autonumber() As String
        Dim xAuto As String
        Dim xmyCmd As OdbcCommand
        Dim xmyRead As OdbcDataReader
        Dim NA As String
        Dim strValue As String = ""
        xAuto = "select * from obat order by kd_obat desc"
        xmyCmd = New OdbcCommand(xAuto, MyCn)
        xmyRead = xmyCmd.ExecuteReader
        If xmyRead.HasRows Then
            xmyRead.Read()
            NA = Mid(xmyRead.Item("kd_obat"), 2, 3)
            strValue = Val(NA) + 1
            NA = "O" & Mid("000", 1, 3 - strValue.Length) & strValue
        Else
            NA = "O001"
        End If
        xmyRead.Dispose()
        Return NA
    End Function


    Public Function cari() As Boolean
        Dim Query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        Query = "SELECT * FROM obat WHERE kd_obat=?"
        xMyCmd = New OdbcCommand(Query, MyCn)
        xMyCmd.Parameters.AddWithValue("kd_obat", fkd_obat)
        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            fnm_obat = xMyRead.Item("nm_obat").ToString
            fjns_obat = xMyRead.Item("jns_obat").ToString
            fharga_obat = xMyRead.Item("harga_obat").ToString
            fsatuan = xMyRead.Item("satuan").ToString
            fstock = xMyRead.Item("stock").ToString
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

        xUbah = "DELETE FROM obat WHERE kd_obat=?"
        xMyCmd = New OdbcCommand(xUbah, MyCn)
        xMyCmd.Parameters.AddWithValue("kd_obat", fkd_obat)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function


    Public Function simpan() As Integer
        Dim xSimpan As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        xSimpan = "INSERT INTO obat "
        xSimpan &= "(kd_obat,nm_obat,jns_obat,harga_obat,satuan,stock) "
        xSimpan &= " values(?,?,?,?,?,?)"
        xMyCmd = New OdbcCommand(xSimpan, MyCn)

        xMyCmd.Parameters.AddWithValue("kd_obat", fkd_obat)
        xMyCmd.Parameters.AddWithValue("nm_obat", fnm_obat)
        xMyCmd.Parameters.AddWithValue("jns_obat", fjns_obat)
        xMyCmd.Parameters.AddWithValue("harga_obat", fharga_obat)
        xMyCmd.Parameters.AddWithValue("satuan", fsatuan)
        xMyCmd.Parameters.AddWithValue("stock", fstock)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function


    Public Function tampildata(Optional ByVal xnama_obat As String = "") As List(Of ClsObat)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpBaca As New List(Of ClsObat)

        Q = "SELECT kd_obat,nm_obat,jns_obat,harga_obat,satuan,stock"
        Q &= " FROM obat WHERE nm_obat LIKE '%" & xnama_obat & "%'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsObat
                objTemp.fkd_obat = xMyRead.Item("kd_obat")
                objTemp.fnm_obat = xMyRead.Item("nm_obat")
                objTemp.fjns_obat = xMyRead.Item("jns_obat")
                objTemp.fharga_obat = xMyRead.Item("harga_obat")
                objTemp.fsatuan = xMyRead.Item("satuan")
                objTemp.fstock = xMyRead.Item("stock")
                tmpBaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpBaca
    End Function


    Public Function ubah() As Integer
        Dim XUbah As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        XUbah = "UPDATE obat SET nm_obat=? ,jns_obat=? ,harga_obat=? ,satuan=? ,stock=?"
        XUbah &= " WHERE kd_obat=?"
        xMyCmd = New OdbcCommand(XUbah, MyCn)

        xMyCmd.Parameters.AddWithValue("nm_obat", fnm_obat)
        xMyCmd.Parameters.AddWithValue("jns_obat", fjns_obat)
        xMyCmd.Parameters.AddWithValue("harga_obat", fharga_obat)
        xMyCmd.Parameters.AddWithValue("satuan", fsatuan)
        xMyCmd.Parameters.AddWithValue("stock", fstock)
        xMyCmd.Parameters.AddWithValue("kd_obat", fkd_obat)

        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()

        xMyCmd.Dispose()
        Return X
    End Function

End Class
