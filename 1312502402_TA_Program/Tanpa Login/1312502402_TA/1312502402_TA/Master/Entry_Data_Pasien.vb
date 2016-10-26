Imports System.Data.Odbc
Public Class Entry_Data_Pasien

    Dim objPasien As New ClsPasien

    Private Sub bersih()
        txtNmPasien.Text = ""
        txtTmptLahir.Text = ""
        dtpTglLahir.Text = Now
        txtUsia.Text = "0"
        txtAlamat.Text = ""
        txtTelepon.Text = ""
        cmbAgama.Text = "--Pilih--"
        txtPekerjaan.Text = ""
        cmbGolongan_darah.Text = "--"
        txtKK.Text = ""
        btnSimpan.Enabled = True
        btnCari.Enabled = True
        rbPria.Checked = False
        rbWanita.Checked = False
    End Sub

    Private Sub Entry_Data_Pasien_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtNmPasien.Focus()
    End Sub

    Private Sub Entry_Data_Pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        txtNoPasien.Text = objPasien.autonumber()
        cmbAgama.Text = "--Pilih--"
        cmbGolongan_darah.Text = "--"
        txtUsia.Text = "0"
        txtUsia.Enabled = False
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            If txtNoPasien.Text = "" Or txtNmPasien.Text = "" Or txtTmptLahir.Text = "" Or txtUsia.Text = "" Or txtAlamat.Text = "" Or txtTelepon.Text = "" Or cmbAgama.Text = "--Pilih--" Or cmbGolongan_darah.Text = "--" Or txtPekerjaan.Text = "" Or txtKK.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objPasien.pno_pasien = txtNoPasien.Text
                objPasien.pnm_pasien = txtNmPasien.Text
                objPasien.ptmpt_lahir = txtTmptLahir.Text
                objPasien.ptgl_lahir = dtpTglLahir.Text
                If rbPria.Checked = True Then
                    objPasien.pjns_kelamin = rbPria.Text
                Else
                    objPasien.pjns_kelamin = rbWanita.Text
                End If
                objPasien.pusia = txtUsia.Text
                objPasien.palamat = txtAlamat.Text
                objPasien.ptelepon = txtTelepon.Text
                objPasien.pagama = cmbAgama.Text
                objPasien.pgolongan_darah = cmbGolongan_darah.Text
                objPasien.ppekerjaan = txtPekerjaan.Text
                objPasien.pkk = txtKK.Text
                If objPasien.simpan = 1 Then
                    MessageBox.Show("Data Berhasil Disimpan", "Berhasil")
                    bersih()
                    txtNoPasien.Text = objPasien.autonumber()
                Else
                    MessageBox.Show("Data Gagal Disimpan", "Gagal")
                End If

                bersih()
                txtNoPasien.Text = objPasien.autonumber()
                txtNoPasien.Enabled = True
                btnCari.Enabled = True
                txtNoPasien.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        Try
            If txtNoPasien.Text = "" Or txtNmPasien.Text = "" Or txtTmptLahir.Text = "" Or txtUsia.Text = "" Or txtAlamat.Text = "" Or txtTelepon.Text = "" Or cmbAgama.Text = "--Pilih--" Or cmbGolongan_darah.Text = "--" Or txtPekerjaan.Text = "" Or txtKK.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objPasien.pno_pasien = txtNoPasien.Text
                objPasien.pnm_pasien = txtNmPasien.Text
                objPasien.ptmpt_lahir = txtTmptLahir.Text
                objPasien.ptgl_lahir = dtpTglLahir.Text
                If rbPria.Checked = True Then
                    objPasien.pjns_kelamin = rbPria.Text
                Else
                    objPasien.pjns_kelamin = rbWanita.Text
                End If
                objPasien.pusia = txtUsia.Text
                objPasien.palamat = txtAlamat.Text
                objPasien.ptelepon = txtTelepon.Text
                objPasien.pagama = cmbAgama.Text
                objPasien.pgolongan_darah = cmbGolongan_darah.Text
                objPasien.ppekerjaan = txtPekerjaan.Text
                objPasien.pkk = txtKK.Text
                If objPasien.ubah = 1 Then
                    MessageBox.Show("Data Berhasil Diubah", "Berhasil")
                    bersih()
                    txtNoPasien.Text = objPasien.autonumber()
                Else
                    MessageBox.Show("Data Gagal Diubah", "Gagal")
                End If

                bersih()
                txtNoPasien.Text = objPasien.autonumber()
                txtNoPasien.Enabled = True
                btnCari.Enabled = True
                txtNoPasien.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim oPop As New popup_pasien
        oPop.ShowDialog()
        If oPop.rno_pasien <> "" Then
            txtNoPasien.Text = oPop.rno_pasien
            txtNmPasien.Text = oPop.rnm_pasien
            txtTmptLahir.Text = oPop.rtmpt_lahir
            dtpTglLahir.Value = oPop.rtgl_lahir
            If oPop.rjns_kelamin = "Pria" Then
                rbPria.Checked = True
            Else
                rbWanita.Checked = True
            End If
            txtUsia.Text = oPop.rusia
            txtAlamat.Text = oPop.ralamat
            txtTelepon.Text = oPop.rtelepon
            cmbAgama.Text = oPop.ragama
            cmbGolongan_darah.Text = oPop.rgolongan_darah
            txtPekerjaan.Text = oPop.rpekerjaan
            txtKK.Text = oPop.rkk

            txtNoPasien.Enabled = False
            btnSimpan.Enabled = False
            txtNmPasien.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        bersih()
        txtNoPasien.Text = objPasien.autonumber()
        txtNoPasien.Enabled = True
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtNoPasien_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoPasien.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNoPasien.Enabled = False
            objPasien.pno_pasien = txtNoPasien.Text
            If objPasien.cari = True Then
                txtNoPasien.Text = objPasien.pno_pasien
                txtNmPasien.Text = objPasien.pnm_pasien
                txtTmptLahir.Text = objPasien.ptmpt_lahir
                dtpTglLahir.Value = objPasien.ptgl_lahir
                If rbPria.Text = objPasien.pjns_kelamin Then
                    rbPria.Checked = True
                Else
                    rbWanita.Checked = True
                End If
                txtUsia.Text = objPasien.pusia
                txtAlamat.Text = objPasien.palamat
                txtTelepon.Text = objPasien.ptelepon
                cmbAgama.Text = objPasien.pagama
                cmbGolongan_darah.Text = objPasien.pgolongan_darah
                txtPekerjaan.Text = objPasien.ppekerjaan
                txtKK.Text = objPasien.pkk
                btnSimpan.Enabled = False
            Else
                btnUbah.Enabled = False
                btnHapus.Enabled = False
            End If
            btnCari.Enabled = False
            txtNmPasien.Focus()
        End If
    End Sub

    Private Sub txtTelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelepon.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harus Masukan Angka!")
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Try
            objPasien.pno_pasien = txtNoPasien.Text
            If objPasien.hapus = 1 Then
                MessageBox.Show("Data Berhasil Dihapus", "Berhasil")
                bersih()
                txtNoPasien.Text = objPasien.autonumber()
            Else
                MessageBox.Show("Data Gagal Dihapus", "Gagal")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        rbPria.Checked = False
        rbWanita.Checked = False
    End Sub

    Private Sub dtpTglLahir_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTglLahir.ValueChanged
        Dim tahun As Integer = dtpNow.Value.Year - dtpTglLahir.Value.Year

        txtUsia.Text = tahun

    End Sub

    Private Sub dtpNow_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpNow.ValueChanged
        Dim tahun As Integer = dtpNow.Value.Year - dtpTglLahir.Value.Year

        txtUsia.Text = tahun
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        IdCetakan = "10"
        TampilCetakan.ShowDialog()
    End Sub
End Class

