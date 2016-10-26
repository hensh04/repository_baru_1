Imports System.Data.Odbc
Public Class profil

    Dim objPetugas As New ClsPetugas

    Private Sub profil_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtKdPetugas.Focus()
    End Sub

    Private Sub profil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        objPetugas.pkd_petugas = MenuUtama.idpetugas
        If objPetugas.cari = True Then
            txtKdPetugas.Text = MenuUtama.idpetugas
            txtNmPetugas.Text = objPetugas.pnm_petugas
            txtpassword.Text = objPetugas.ppass
            dtpTglLahir.Text = objPetugas.ptgl_lahir
            If objPetugas.pjns_kelamin = "Pria" Then
                rbPria.Checked = True
            Else
                rbWanita.Checked = True
            End If
            txtAlamat.Text = objPetugas.palamat
            txtTelepon.Text = objPetugas.ptelepon
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        objPetugas.pkd_petugas = MenuUtama.idpetugas
        If objPetugas.cari = True Then
            txtKdPetugas.Text = MenuUtama.idpetugas
            txtNmPetugas.Text = objPetugas.pnm_petugas
            txtpassword.Text = objPetugas.ppass
            dtpTglLahir.Text = objPetugas.ptgl_lahir
            If objPetugas.pjns_kelamin = "Pria" Then
                rbPria.Checked = True
            Else
                rbWanita.Checked = True
            End If
            txtAlamat.Text = objPetugas.palamat
            txtTelepon.Text = objPetugas.ptelepon
        End If
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Dispose()
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        Try
            If txtKdPetugas.Text = "" Or txtNmPetugas.Text = "" Or txtAlamat.Text = "" Or txtTelepon.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objPetugas.pkd_petugas = txtKdPetugas.Text
                objPetugas.pnm_petugas = txtNmPetugas.Text
                objPetugas.ptgl_lahir = dtpTglLahir.Text
                If rbPria.Checked = True Then
                    objPetugas.pjns_kelamin = rbPria.Text
                Else
                    objPetugas.pjns_kelamin = rbWanita.Text
                End If
                objPetugas.ppass = txtpassword.Text
                objPetugas.palamat = txtAlamat.Text
                objPetugas.ptelepon = txtTelepon.Text
                If objPetugas.ubah = 1 Then
                    MessageBox.Show("Data Berhasil Diubah", "Berhasil")
                Else
                    MessageBox.Show("Data Gagal Diubah", "Gagal")
                End If
                txtKdPetugas.Enabled = True
                btnUbah.Enabled = True
                txtKdPetugas.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class