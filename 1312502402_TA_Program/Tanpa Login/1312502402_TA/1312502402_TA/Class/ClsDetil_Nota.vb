Imports System.Data.Odbc
Public Class ClsDetil_Nota
    Private fno_nota As String
    Private fkd_obat As String
    Private fjml_obat_nota As Integer
    Private fharga As Integer


    Private faturan_pakai_nota As String

    Public Property pjml_obat_nota As Integer
        Get
            Return fjml_obat_nota
        End Get
        Set(ByVal value As Integer)
            fjml_obat_nota = value
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

    Public Property pno_nota As String
        Get
            Return fno_nota
        End Get
        Set(ByVal value As String)
            fno_nota = value
        End Set
    End Property

    Public Property pharga As Integer
        Get
            Return fharga
        End Get
        Set(ByVal value As Integer)
            fharga = value
        End Set
    End Property


    Public Property paturan_pakai_nota As String
        Get
            Return faturan_pakai_nota
        End Get
        Set(ByVal value As String)
            faturan_pakai_nota = value
        End Set
    End Property


    Public Function cari() As Boolean
        Dim query As String
        Dim xMyRead As OdbcDataReader
        Dim xMyCmd As OdbcCommand

        query = "SELECT * FROM detil_nota WHERE no_nota=?"
        xMyCmd = New OdbcCommand(query, MyCn)
        xMyCmd.CommandType = CommandType.Text
        xMyCmd.Parameters.AddWithValue("no_nota", fno_nota)
        xMyRead = xMyCmd.ExecuteReader

        If xMyRead.HasRows Then
            fno_nota = xMyRead.Item("no_nota").ToString
            fkd_obat = xMyRead.Item("kd_obat").ToString
            fjml_obat_nota = xMyRead.Item("jml_obat_nota").ToString
            fharga = xMyRead.Item("harga").ToString
            faturan_pakai_nota = xMyRead.Item("aturan_pakai_nota").ToString
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

        xSimpan = "INSERT INTO detil_nota"
        xSimpan &= "(no_nota,kd_obat,jml_obat_nota,harga,aturan_pakai_nota)"
        xSimpan &= "values(?,?,?,?,?)"
        myCmd = New OdbcCommand(xSimpan, MyCn)

        myCmd.Parameters.AddWithValue("no_nota", fno_nota)
        myCmd.Parameters.AddWithValue("kd_obat", fkd_obat)
        myCmd.Parameters.AddWithValue("jml_obat_nota", fjml_obat_nota)
        myCmd.Parameters.AddWithValue("harga", fharga)
        myCmd.Parameters.AddWithValue("aturan_pakai_nota", faturan_pakai_nota)

        X = myCmd.ExecuteNonQuery

        myCmd.Dispose()
        Return X
    End Function


    Public Function tampildata(ByVal xData As String) As List(Of ClsDetil_Nota)
        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader
        Dim tmpbaca As New List(Of ClsDetil_Nota)

        Q = "SELECT * FROM detil_nota WHERE no_nota like '%" & xData & "%'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Dim objTemp As New ClsDetil_Nota
                objTemp.fno_nota = xMyRead.Item("no_nota")
                objTemp.fkd_obat = xMyRead.Item("kd_obat")
                objTemp.fjml_obat_nota = xMyRead.Item("jml_obat_nota")
                objTemp.fharga = xMyRead.Item("harga")
                objTemp.faturan_pakai_nota = xMyRead.Item("aturan_pakai_nota")
                tmpbaca.Add(objTemp)
            End While
        End If
        xMyRead.Close() : Return tmpbaca
    End Function
    
End Class
