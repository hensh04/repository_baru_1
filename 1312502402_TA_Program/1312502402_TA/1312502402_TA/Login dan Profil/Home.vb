Imports System.Data.Odbc
Public Class Home
    Public z As Integer
    Public a As Integer
    Public a1 As String
    Public b As Integer
    Public b1 As String
    Public c As Integer
    Public c1 As String
    Public d As Integer
    Public d1 As String
    Public ez As Integer
    Public e1 As String
    Public Sub tampildata2()

        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader


        Q = "SELECT ifnull(count(b.no_daftar),0) as penjumlahan FROM pendaftaran b where b.tgl_daftar = date_format(now(), '%y-%m-%d')"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                z = xMyRead.Item("penjumlahan")
            End While
        End If
    End Sub

    Public Sub tampildata1()

        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader


        Q = "SELECT nm_obat, stock FROM obat order by stock asc limit 0,1"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                a1 = xMyRead.Item("nm_obat")
                a = xMyRead.Item("stock")
            End While
        End If
    End Sub

    Public Sub tampildata3()

        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader


        Q = "SELECT nm_obat, stock FROM obat order by stock asc limit 1,1"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                b1 = xMyRead.Item("nm_obat")
                b = xMyRead.Item("stock")
            End While
        End If
    End Sub

    Public Sub tampildata4()

        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader


        Q = "SELECT nm_obat, stock FROM obat order by stock asc limit 2,1"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                c1 = xMyRead.Item("nm_obat")
                c = xMyRead.Item("stock")
            End While
        End If
    End Sub

    Public Sub tampildata5()

        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader


        Q = "SELECT nm_obat, stock FROM obat order by stock asc limit 3,1"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                d1 = xMyRead.Item("nm_obat")
                d = xMyRead.Item("stock")
            End While
        End If
    End Sub

    Public Sub tampildata6()

        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader


        Q = "SELECT nm_obat, stock FROM obat order by stock asc limit 4,1"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                e1 = xMyRead.Item("nm_obat")
                ez = xMyRead.Item("stock")
            End While
        End If
    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        tampildata2()
        tampildata1()
        tampildata3()
        tampildata4()
        tampildata5()
        tampildata6()
        Label7.Text = z
        Label1.Text = a1
        Label9.Text = b1
        Label10.Text = c1
        Label11.Text = d1
        Label12.Text = e1

        Label14.Text = a
        Label15.Text = b
        Label16.Text = c
        Label17.Text = d
        Label18.Text = ez
    End Sub

    Private Sub MetroTileItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTileItem33.Click
        Entry_Pendaftaran.ShowDialog()
    End Sub
End Class