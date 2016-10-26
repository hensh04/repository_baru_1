Imports System.Data.Odbc
Public Class Cetak_Surat_Keterangan_Sakit

    Dim objsuratsakit As New ClsSurat_Sakit
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
        txtNoSuratSakit.Enabled = False
        dtpTgl_Surat_Sakit.Enabled = False
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

    Private Sub Cetak_Surat_Keterangan_Sakit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        KunciObjek()
        Clear()
        txtNoSuratSakit.Text = objsuratsakit.autonumber
        btnCetak.Enabled = False
        btnBatal.Enabled = False
        btnCariPendaftaran.Focus()
    End Sub

    Private Sub btnCariPendaftaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariPendaftaran.Click
        Dim opop As New PopUp_Pendaftaran
        opop.ShowDialog()
        If opop.rno_pendaftaran <> "" Then
            txtNoPendaftaran.Text = opop.rno_pendaftaran
            txtNmPasien.Text = opop.rnm_pasien
            txtUsia.Text = opop.rusia
            txtJnsKelamin.Text = opop.rjenis_kelamin

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
        txtNoSuratSakit.Text = objsuratsakit.autonumber
        btnCetak.Enabled = False
        btnBatal.Enabled = False
        btnCariPendaftaran.Focus()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        objsuratsakit.pno_surat_sakit = txtNoSuratSakit.Text
        objsuratsakit.ptgl_surat_sakit = dtpTgl_Surat_Sakit.Text
        objsuratsakit.pkeperluan = txtKeperluan.Text
        objsuratsakit.pno_daftar = txtNoPendaftaran.Text

        If objsuratsakit.simpan = 1 Then
            MessageBox.Show("Data Berhasil Disimpan..!")
            IdCetakan = "2"
            TampilCetakan.ShowDialog()
        Else
            MessageBox.Show("Data Gagal Disimpan..!")
        End If

        KunciObjek()
        Clear()
        txtNoSuratSakit.Text = objsuratsakit.autonumber
        btnCariPendaftaran.Focus()
    End Sub
End Class