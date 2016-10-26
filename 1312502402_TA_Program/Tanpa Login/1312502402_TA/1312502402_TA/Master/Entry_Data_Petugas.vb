Imports System.Data.Odbc
Public Class Entry_Data_Petugas

    Dim objPetugas As New ClsPetugas

    Private Sub bersih()
        txtNmPetugas.Text = ""
        dtpTglLahir.Text = Now
        txtAlamat.Text = ""
        rbPria.Checked = False
        rbWanita.Checked = False
        txtTelepon.Text = ""
        btnSimpan.Enabled = True
        btnCari.Enabled = True
    End Sub

    Private Sub Entry_Data_Petugas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtNmPetugas.Focus()
    End Sub

    Private Sub Entry_Data_Petugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        txtKdPetugas.Text = objPetugas.autonumber()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
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
                objPetugas.palamat = txtAlamat.Text
                objPetugas.ptelepon = txtTelepon.Text
                If objPetugas.simpan = 1 Then
                    MessageBox.Show("Data Berhasil Disimpan", "Berhasil")
                    bersih()
                    txtKdPetugas.Text = objPetugas.autonumber()
                Else
                    MessageBox.Show("Data Gagal Disimpan", "Gagal")
                End If

                bersih()
                txtKdPetugas.Text = objPetugas.autonumber()
                txtKdPetugas.Enabled = True
                btnCari.Enabled = True
                txtKdPetugas.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bntUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
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
                objPetugas.palamat = txtAlamat.Text
                objPetugas.ptelepon = txtTelepon.Text
                If objPetugas.ubah = 1 Then
                    MessageBox.Show("Data Berhasil Diubah", "Berhasil")
                    bersih()
                    txtKdPetugas.Text = objPetugas.autonumber()
                Else
                    MessageBox.Show("Data Gagal Diubah", "Gagal")
                End If

                bersih()
                txtKdPetugas.Text = objPetugas.autonumber()
                txtKdPetugas.Enabled = True
                btnCari.Enabled = True
                txtKdPetugas.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Try
            objPetugas.pkd_petugas = txtKdPetugas.Text
            If objPetugas.hapus = 1 Then
                MessageBox.Show("Data Berhasil Dihapus", "Berhasil")
                bersih()
                txtKdPetugas.Text = objPetugas.autonumber()
            Else
                MessageBox.Show("Data Gagal Dihapus", "Gagal")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        bersih()
        txtKdPetugas.Text = objPetugas.autonumber()
        txtKdPetugas.Enabled = True
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtKdPetugas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKdPetugas.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtKdPetugas.Enabled = False
            objPetugas.pkd_petugas = txtKdPetugas.Text
            If objPetugas.cari = True Then
                txtKdPetugas.Text = objPetugas.pkd_petugas
                txtNmPetugas.Text = objPetugas.pnm_petugas
                dtpTglLahir.Value = objPetugas.ptgl_lahir
                If rbPria.Text = objPetugas.pjns_kelamin Then
                    rbPria.Checked = True
                Else
                    rbWanita.Checked = True
                End If
                txtAlamat.Text = objPetugas.palamat
                txtTelepon.Text = objPetugas.ptelepon
                btnSimpan.Enabled = False
            Else
                btnUbah.Enabled = False
                btnHapus.Enabled = False
            End If
            btnCari.Enabled = False
            txtNmPetugas.Focus()
        End If
    End Sub

    Private Sub txtTelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelepon.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harus Masukan Angka!")
        End If
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim oPop As New PopUp_Petugas
        oPop.ShowDialog()
        If oPop.rkd_petugas <> "" Then
            txtKdPetugas.Text = oPop.rkd_petugas
            txtNmPetugas.Text = oPop.rnm_petugas
            dtpTglLahir.Value = oPop.rtgl_lahir
            If oPop.rjns_kelamin = "Pria" Then
                rbPria.Checked = True
            Else
                rbWanita.Checked = True
            End If
            txtAlamat.Text = oPop.ralamat
            txtTelepon.Text = oPop.rtelepon

            txtKdPetugas.Enabled = False
            btnSimpan.Enabled = False
            txtNmPetugas.Focus()
        End If
    End Sub
End Class