Imports System.Data.Odbc
Public Class Cetak_Surat_Rujukan

    Dim objsuratrujukan As New ClsSurat_Rujukan
    Dim objpendaftaran As New ClsPendaftaran
    Dim objperiksa As New ClsKartu_Status
    Dim objpasien As New ClsPasien

    Sub Clear()
        txtNoPendaftaran.Clear()
        txtNmPasien.Clear()
        txtUsia.Clear()
        txtJnsKelamin.Clear()
        txtKeluhan.Clear()
        txtLokasi.Clear()
        txtDilakukan.Clear()
        txtDiagnosa.Clear()
        txtNmDokter.Clear()
    End Sub

    Sub KunciObjek()
        txtNoSuratRujukan.Enabled = False
        dtpTgl_Surat_Rujukan.Enabled = False
        txtNoPendaftaran.Enabled = False
        txtNmPasien.Enabled = False
        txtUsia.Enabled = False
        txtKeluhan.Enabled = False
        txtDiagnosa.Enabled = False
        txtLokasi.Enabled = False
        txtDilakukan.Enabled = False
        txtJnsKelamin.Enabled = False
        txtNmDokter.Enabled = False
    End Sub

    Private Sub Cetak_Surat_Rujukan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        KunciObjek()
        Clear()
        txtNoSuratRujukan.Text = objsuratrujukan.autonumber
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
        End If

        objperiksa.pno_daftar = opop.rno_pendaftaran
        objperiksa.cari()
        If objperiksa.cari = True Then
            txtKeluhan.Text = objperiksa.pkeluhan
            txtDiagnosa.Text = objperiksa.pdiagnosa
        End If

        KunciObjek()
        txtLokasi.Enabled = True
        txtDilakukan.Enabled = True
        btnCetak.Enabled = True
        btnBatal.Enabled = True
        txtLokasi.Focus()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        KunciObjek()
        Clear()
        txtNoSuratRujukan.Text = objsuratrujukan.autonumber
        btnCetak.Enabled = False
        btnBatal.Enabled = False
        btnCariPendaftaran.Focus()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        objsuratrujukan.pno_surat_rujukan = txtNoSuratRujukan.Text
        objsuratrujukan.ptgl_surat_rujukan = dtpTgl_Surat_Rujukan.Text
        objsuratrujukan.ptempat_rujukan = txtLokasi.Text
        objsuratrujukan.pkeperluan = txtDilakukan.Text
        objsuratrujukan.pno_daftar = txtNoPendaftaran.Text

        If objsuratrujukan.simpan = 1 Then
            MessageBox.Show("Data Berhasil Disimpan..!")
            IdCetakan = "3"
            TampilCetakan.ShowDialog()
        Else
            MessageBox.Show("Data Gagal Disimpan..!")
        End If

        KunciObjek()
        Clear()
        txtNoSuratRujukan.Text = objsuratrujukan.autonumber
        btnCariPendaftaran.Focus()
    End Sub
End Class