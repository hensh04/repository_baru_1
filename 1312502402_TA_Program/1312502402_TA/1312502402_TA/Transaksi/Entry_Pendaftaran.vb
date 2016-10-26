Imports System.Data.Odbc
Public Class Entry_Pendaftaran

    Dim objpendaftaran As New ClsPendaftaran
    Dim objpasien As New ClsPasien
    Dim objdokter As New ClsDokter

    Private Sub ClearForm()
        txtNoPendaftaran.Text = objpendaftaran.autonumber
        dtpTgl_Pendaftaran.Value = Now
        txtNoPasien.Clear()
        txtNmPasien.Clear()
        txtTmptLahir.Clear()
        dtpTglLahir.Value = Now
        txtjns_kelamin.Clear()
        txtUsia.Text = "0"
        txtUsia.Clear()
        txtAlamat.Clear()
        txtTelepon.Clear()
        txtagama.Clear()
        txtPekerjaan.Clear()
        txtgolongan_darah.Clear()
        txtKK.Clear()
        txtKdDokter.Clear()
        txtNmDokter.Clear()
        txtBiayaJasa.Clear()
    End Sub

    Private Sub Kunci()
        txtNoPasien.Enabled = False
        txtNmPasien.Enabled = False
        txtTmptLahir.Enabled = False
        dtpTglLahir.Enabled = False
        txtjns_kelamin.Enabled = False
        txtUsia.Enabled = False
        txtAlamat.Enabled = False
        txtTelepon.Enabled = False
        txtPekerjaan.Enabled = False
        txtKK.Enabled = False
        txtagama.Enabled = False
        txtgolongan_darah.Enabled = False
    End Sub

    Private Sub Entry_Pendaftaran_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btnCariPasien.Focus()
    End Sub

    Private Sub Entry_Pendaftaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        txtNoPendaftaran.Text = objpendaftaran.autonumber
        txtNoPendaftaran.Enabled = False
        txtBiayaDaftar.Text = "2000"
        txtBiayaDaftar.Enabled = False
        txtNmPetugas.Text = MenuUtama.namapetugas
        Kunci()
    End Sub

    Private Sub btnCariPasien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariPasien.Click
        Dim oPop As New popup_pasien
        oPop.ShowDialog()
        If oPop.rno_pasien <> "" Then
            txtNoPasien.Text = oPop.rno_pasien
            txtNmPasien.Text = oPop.rnm_pasien
            txtTmptLahir.Text = oPop.rtmpt_lahir
            dtpTglLahir.Value = oPop.rtgl_lahir
            txtjns_kelamin.Text = oPop.rjns_kelamin
            txtAlamat.Text = oPop.ralamat
            txtTelepon.Text = oPop.rtelepon
            txtagama.Text = oPop.ragama
            txtgolongan_darah.Text = oPop.rgolongan_darah
            txtPekerjaan.Text = oPop.rpekerjaan
            txtKK.Text = oPop.rkk

        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub btnCariDokter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariDokter.Click
        Dim oPop As New Popup_Dokter
        oPop.ShowDialog()
        If oPop.rkd_dokter <> "" Then
            txtKdDokter.Text = oPop.rkd_dokter
            txtNmDokter.Text = oPop.rnm_dokter
            txtBiayaJasa.Text = oPop.rbiaya_jasa
        End If
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Dispose()
        Home.tampildata2()
        Home.Label7.Text = Home.z

    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtNoPasien.Text = "" Or txtKdDokter.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Information, "INFORMASI")
        Else
            Dim H1 As Integer
            objpendaftaran.pno_daftar = txtNoPendaftaran.Text
            objpendaftaran.ptgl_daftar = dtpTgl_Pendaftaran.Text
            objpendaftaran.pbiaya_dokter = txtBiayaJasa.Text
            objpendaftaran.pbiaya_daftar = txtBiayaDaftar.Text
            objpendaftaran.pkd_petugas = MenuUtama.idpetugas
            objpendaftaran.pkd_dokter = txtKdDokter.Text
            objpendaftaran.pno_pasien = txtNoPasien.Text
            H1 = objpendaftaran.simpan()
            
            If H1 = 1 Then
                MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "INFORMASI")
            Else
                MsgBox("Data Gagal Disimpan", MsgBoxStyle.Information, "INFORMASI")
            End If
            ClearForm()
            txtNoPendaftaran.Text = objpendaftaran.autonumber
        End If
    End Sub

    Private Sub dtpTgl_Pendaftaran_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTgl_Pendaftaran.ValueChanged
        Dim tahun As Integer = dtpTgl_Pendaftaran.Value.Year - dtpTglLahir.Value.Year

        txtUsia.Text = tahun
    End Sub

    Private Sub dtpTglLahir_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTglLahir.ValueChanged
        Dim tahun As Integer = dtpTgl_Pendaftaran.Value.Year - dtpTglLahir.Value.Year

        txtUsia.Text = tahun
    End Sub
End Class