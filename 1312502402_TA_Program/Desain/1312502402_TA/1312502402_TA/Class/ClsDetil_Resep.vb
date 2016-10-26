Imports System.Data.Odbc
Public Class ClsDetil_Resep
    Private fno_resep As String
    Private fkd_obat As String
    Private fjml_obat As Integer
    Private faturan_pakai As String


    Public Property paturan_pakai As String
        Get
            Return faturan_pakai
        End Get
        Set(ByVal value As String)
            faturan_pakai = value
        End Set
    End Property

    Public Property pjml_obat As Integer
        Get
            Return fjml_obat
        End Get
        Set(ByVal value As Integer)
            fjml_obat = value
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

    Public Property pno_resep As String
        Get
            Return fno_resep
        End Get
        Set(ByVal value As String)
            fno_resep = value
        End Set
    End Property





    Public Function cari() As Boolean
        Dim query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        query = "SELECT * FROM detil_resep WHERE no_resep=?"
        xMyCmd = New OdbcCommand(query, MyCn)
        xMyCmd.CommandType = CommandType.Text
        xMyCmd.Parameters.AddWithValue("no_resep", fno_resep)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows Then
            fno_resep = xMyRead.Item("no_resep").ToString
            fkd_obat = xMyRead.Item("kd_obat").ToString
            fjml_obat = xMyRead.Item("jml_obat").ToString
            faturan_pakai = xMyRead.Item("aturan_pakai").ToString
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

        xSimpan = "INSERT INTO detil_resep"
        xSimpan &= "(no_resep,kd_obat,jml_obat,aturan_pakai)"
        xSimpan &= "values(?,?,?,?)"
        myCmd = New OdbcCommand(xSimpan, MyCn)

        myCmd.Parameters.AddWithValue("no_resep", fno_resep)
        myCmd.Parameters.AddWithValue("kd_obat", fkd_obat)
        myCmd.Parameters.AddWithValue("jml_obat", fjml_obat)
        myCmd.Parameters.AddWithValue("aturan_pakai", faturan_pakai)

        X = myCmd.ExecuteNonQuery

        myCmd.Dispose()
        Return X
    End Function


    Public Function tampildata(ByVal xData As String) As List(Of ClsDetil_Resep)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpbaca As New List(Of ClsDetil_Resep)

        Q = "SELECT * FROM detil_resep WHERE no_resep like '%" & xData & "%'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsDetil_Resep
                objTemp.fno_resep = xMyRead.Item("no_resep")
                objTemp.fkd_obat = xMyRead.Item("kd_obat")
                objTemp.fjml_obat = xMyRead.Item("jml_obat")
                objTemp.faturan_pakai = xMyRead.Item("aturan_pakai")
                tmpbaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpbaca
    End Function

End Class
