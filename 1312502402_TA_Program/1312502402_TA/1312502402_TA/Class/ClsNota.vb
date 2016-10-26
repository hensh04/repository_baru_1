Imports System.Data.Odbc
Public Class ClsNota
    Private fno_nota As String
    Private ftgl_nota As Date
    Private fno_resep As String

    Public Property pno_nota As String
        Get
            Return fno_nota
        End Get
        Set(ByVal value As String)
            fno_nota = value
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

    Public Property ptgl_nota As Date
        Get
            Return ftgl_nota
        End Get
        Set(ByVal value As Date)
            ftgl_nota = value
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
        query = "SELECT * FROM nota ORDER BY no_nota DESC"
        xMyCmd = New OdbcCommand(query, mycn)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows = True Then
            xMyRead.Read()
            strTemp = Mid(xMyRead.Item("no_nota"), 4, 8)
            NA = Val(strTemp) + 1
            NA = "NOA" & Mid("00000", 1, 5 - NA.Length) & NA
        Else
            NA = "NOA00001"
        End If
        xMyRead.Dispose()
        Return NA
    End Function

    Public Function cari() As Boolean
        Dim query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        query = "SELECT * FROM nota WHERE no_nota=?"
        xMyCmd = New OdbcCommand(query, MyCn)
        xMyCmd.CommandType = CommandType.Text
        xMyCmd.Parameters.AddWithValue("no_nota", fno_nota)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows Then
            fno_nota = xMyRead.Item("no_resep").ToString
            ftgl_nota = xMyRead.Item("tgl_nota").ToString
            fno_resep = xMyRead.Item("no_resep").ToString
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

        query = "SELECT * FROM nota WHERE no_resep=?"
        xMyCmd = New OdbcCommand(query, MyCn)
        xMyCmd.CommandType = CommandType.Text
        xMyCmd.Parameters.AddWithValue("no_resep", fno_resep)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows Then
            fno_nota = xMyRead.Item("no_nota").ToString
            ftgl_nota = xMyRead.Item("tgl_nota").ToString
            fno_resep = xMyRead.Item("no_resep").ToString
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

        xSimpan = "INSERT INTO nota"
        xSimpan &= "(no_nota,tgl_nota,no_resep)"
        xSimpan &= "values(?,?,?)"
        myCmd = New OdbcCommand(xSimpan, MyCn)

        myCmd.Parameters.AddWithValue("no_nota", fno_nota)
        myCmd.Parameters.AddWithValue("tgl_nota", ftgl_nota)
        myCmd.Parameters.AddWithValue("no_resep", fno_resep)

        myCmd.Prepare()
        X = myCmd.ExecuteNonQuery

        myCmd.Dispose()
        Return X
    End Function

    Public Function tampildata(ByVal xData As String) As List(Of ClsNota)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpbaca As New List(Of ClsNota)

        Q = "SELECT * FROM nota WHERE no_nota like '%" & xData & "%'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsNota
                objTemp.fno_nota = xMyRead.Item("no_nota")
                objTemp.ftgl_nota = xMyRead.Item("tgl_nota")
                objTemp.fno_resep = xMyRead.Item("no_resep")

                tmpbaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpbaca
    End Function

    Public Function tampildata2(ByVal xData As String) As List(Of ClsNota)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpbaca As New List(Of ClsNota)

        Q = "SELECT sum(jml_obat_nota * harga) as penjumlahan FROM detil_nota WHERE no_nota like '%" & xData & "%' group by no_nota"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsNota
                objTemp.fno_nota = xMyRead.Item("no_nota")
                objTemp.ftgl_nota = xMyRead.Item("tgl_nota")
                objTemp.fno_resep = xMyRead.Item("no_resep")

                tmpbaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpbaca
    End Function

End Class
