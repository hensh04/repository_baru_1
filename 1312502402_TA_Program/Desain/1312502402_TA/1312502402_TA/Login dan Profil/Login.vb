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

        ElseIf xMyRead.Item("kd_petugas") = "admin" Then
            MsgBox("Login Berhasil, Selamat Datang Admin" & xMyRead.Item("nm_petugas") & " ! ", MsgBoxStyle.Information, "Login Berhasil")
            MenuUtama.Show()
            Me.Hide()
            MenuUtama.namapetugas = xMyRead.Item("nm_petugas")
            MenuUtama.idpetugas = xMyRead.Item("kd_petugas")
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class