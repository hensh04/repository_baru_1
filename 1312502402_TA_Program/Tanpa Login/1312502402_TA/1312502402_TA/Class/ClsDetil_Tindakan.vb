Imports System.Data.Odbc
Public Class ClsDetil_Tindakan
    Private fno_daftar As String
    Private fkd_tindakan As String
    Private fbanyaknya_tindakan As Integer
    Private fbiaya_tindakan As Integer

    Public Property pbanyaknya_tindakan As Integer
        Get
            Return fbanyaknya_tindakan
        End Get
        Set(ByVal value As Integer)
            fbanyaknya_tindakan = value
        End Set
    End Property

    Public Property pbiaya_tindakan As Integer
        Get
            Return fbiaya_tindakan
        End Get
        Set(ByVal value As Integer)
            fbiaya_tindakan = value
        End Set
    End Property

    Public Property pkd_tindakan As String
        Get
            Return fkd_tindakan
        End Get
        Set(ByVal value As String)
            fkd_tindakan = value
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

    Public Function cari() As Boolean
        Dim query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        query = "SELECT * FROM detil_tindakan WHERE no_daftar=?"
        xMyCmd = New OdbcCommand(query, MyCn)
        xMyCmd.CommandType = CommandType.Text
        xMyCmd.Parameters.AddWithValue("no_daftar", fno_daftar)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows Then
            fno_daftar = xMyRead.Item("no_daftar").ToString
            fkd_tindakan = xMyRead.Item("kd_tindakan").ToString
            fbanyaknya_tindakan = xMyRead.Item("banyaknya_tindakan").ToString
            fbiaya_tindakan = xMyRead.Item("biaya_tindakan").ToString
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

        xSimpan = "INSERT INTO detil_tindakan"
        xSimpan &= "(no_daftar,kd_tindakan,banyaknya_tindakan,biaya_tindakan)"
        xSimpan &= "values(?,?,?,?)"
        myCmd = New OdbcCommand(xSimpan, MyCn)

        myCmd.Parameters.AddWithValue("no_daftar", fno_daftar)
        myCmd.Parameters.AddWithValue("kd_tindakan", fkd_tindakan)
        myCmd.Parameters.AddWithValue("banyaknya_tindakan", fbanyaknya_tindakan)
        myCmd.Parameters.AddWithValue("biaya_tindakan", fbiaya_tindakan)

        X = myCmd.ExecuteNonQuery

        myCmd.Dispose()
        Return X
    End Function

    Public Function tampildata(ByVal xData As String) As List(Of ClsDetil_Tindakan)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpbaca As New List(Of ClsDetil_Tindakan)

        Q = "SELECT * FROM detil_tindakan WHERE no_daftar like '%" & xData & "%'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsDetil_Tindakan
                objTemp.fno_daftar = xMyRead.Item("no_daftar")
                objTemp.fkd_tindakan = xMyRead.Item("kd_tindakan")
                objTemp.fbanyaknya_tindakan = xMyRead.Item("banyaknya_tindakan")
                objTemp.fbiaya_tindakan = xMyRead.Item("biaya_tindakan")
                tmpbaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpbaca
    End Function

End Class
