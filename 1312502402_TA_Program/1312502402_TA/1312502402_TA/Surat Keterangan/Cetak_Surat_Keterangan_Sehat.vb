Imports System.Data.Odbc
Public Class Cetak_Surat_Keterangan_Sehat

    Dim objsuratsehat As New ClsSurat_Sehat
    Dim objpendaftaran As New ClsPendaftaran
    Dim objperiksa As New ClsKartu_Status
    Dim objpasien As New ClsPasien
    Dim objdokter As New ClsDokter

    Sub Clear()
        txtNoPendaftaran.Clear()
        txtNmPasien.Clear()
        txtUsia.Clear()
        txtPekerjaan.Clear()
        txtAlamat.Clear()
        txtJnsKelamin.Clear()
        txtNmDokter.Clear()
        txtGolonganDarah.Clear()
        txtBeratBadan.Clear()
        txtTinggiBadan.Clear()
        txtTensi.Clear()
        txtDiagnosa.Clear()
        txtKeperluan.Clear()
    End Sub

    Sub KunciObjek()
        txtNoSuratSehat.Enabled = False
        dtpTgl_Surat_Sehat.Enabled = False
        txtNoPendaftaran.Enabled = False
        txtNmPasien.Enabled = False
        txtUsia.Enabled = False
        txtPekerjaan.Enabled = False
        txtGolonganDarah.Enabled = False
        txtAlamat.Enabled = False
        txtNmDokter.Enabled = False
        txtBeratBadan.Enabled = False
        txtTinggiBadan.Enabled = False
        txtTensi.Enabled = False
        txtDiagnosa.Enabled = False
        txtJnsKelamin.Enabled = False
    End Sub

    Private Sub Cetak_Surat_Keterangan_Sehat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        KunciObjek()
        Clear()
        txtNoSuratSehat.Text = objsuratsehat.autonumber
        btnCetak.Enabled = False
        btnBatal.Enabled = False
        btnCariPendaftaran.Focus()
    End Sub

    Private Sub btnCariPendaftaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariPendaftaran.Click
        Dim opop As New PopUp_Pemeriksaan
        opop.ShowDialog()
        If opop.rno_pendaftaran <> "" Then
            txtNoPendaftaran.Text = opop.rno_pendaftaran
            txtNmPasien.Text = opop.rnm_pasien
            txtJnsKelamin.Text = opop.rjenis_kelamin
            txtUsia.Text = opop.rusia
            txtNmDokter.Text = opop.rnm_dokter

            objpasien.pno_pasien = opop.rno_pasien
            objpasien.cari()
            txtPekerjaan.Text = objpasien.ppekerjaan
            txtAlamat.Text = objpasien.palamat
            txtGolonganDarah.Text = objpasien.pgolongan_darah
        End If

        objperiksa.pno_daftar = opop.rno_pendaftaran
        objperiksa.cari()
        If objperiksa.cari = True Then
            txtBeratBadan.Text = objperiksa.pberat_badan
            txtTensi.Text = objperiksa.ptensi
            txtTinggiBadan.Text = objperiksa.ptinggi_badan
            txtDiagnosa.Text = objperiksa.pdiagnosa
        End If

        KunciObjek()
        btnCetak.Enabled = True
        btnBatal.Enabled = True
        txtKeperluan.Focus()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        KunciObjek()
        Clear()
        txtNoSuratSehat.Text = objsuratsehat.autonumber
        btnCetak.Enabled = False
        btnBatal.Enabled = False
        btnCariPendaftaran.Focus()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        objsuratsehat.pno_surat_sehat = txtNoSuratSehat.Text
        objsuratsehat.ptgl_surat_sehat = dtpTgl_Surat_Sehat.Text
        objsuratsehat.pkeperluan = txtKeperluan.Text
        objsuratsehat.pno_daftar = txtNoPendaftaran.Text

        If objsuratsehat.simpan = 1 Then
            MessageBox.Show("Data Berhasil Disimpan..!")
            IdCetakan = "1"
            TampilCetakan.ShowDialog()
        Else
            MessageBox.Show("Data Gagal Disimpan..!")
        End If

        KunciObjek()
        Clear()
        txtNoSuratSehat.Text = objsuratsehat.autonumber
        btnCariPendaftaran.Focus()
    End Sub
End Class