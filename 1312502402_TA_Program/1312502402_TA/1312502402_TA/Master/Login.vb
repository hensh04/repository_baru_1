Imports System.Data.Odbc

Public Class Login
    Sub login()
        Dim myCmd As OdbcCommand
        Dim sql As String
        Dim xMyRead As OdbcDataReader
        sql = "SELECT * FROM petugas WHERE kd_petugas ='" + TextBox1.Text + "' and password ='" & TextBox2.Text & "'"

        myCmd = New OdbcCommand(sql, MyCn)
        xMyRead = myCmd.ExecuteReader()

        'kondisi dimana data tidak ditemukan
        If xMyRead.HasRows = 0 Then
            MsgBox("Username atau Password ada yang salah !", MsgBoxStyle.Exclamation, "Error Login")
            'kondisi dimana level =1(ADMIN) maka akan login sebagai ADMIN

        Else
            MsgBox("Login Berhasil, Selamat Datang Petugas " & xMyRead.Item("nm_petugas") & " ! ", MsgBoxStyle.Information, "Login Berhasil")
            MenuUtama.Show()
            Me.Hide()
            MenuUtama.namapetugas = xMyRead.Item("nm_petugas")
            MenuUtama.idpetugas = xMyRead.Item("kd_petugas")
        End If
    End Sub
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Masukan Username dan Password anda", MsgBoxStyle.Information, "Peringatan")
        ElseIf TextBox1.Text = "" Then
            MsgBox("Masukan Username anda", MsgBoxStyle.Information, "Peringatan")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Masukan Password anda", MsgBoxStyle.Information, "Peringatan")
        Else
            login()
        End If
    End Sub

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        bukaConn()
    End Sub
End Class