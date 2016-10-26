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
        rbPria.Checked = False
        rbWanita.Checked = False
        txtUsia.Text = "0"
        txtUsia.Clear()
        txtAlamat.Clear()
        txtTelepon.Clear()
        cmbAgama.Text = "--Pilih--"
        txtPekerjaan.Clear()
        cmbGolongan_darah.Text = "--Pilih--"
        txtKK.Clear()
        txtKdDokter.Clear()
        txtNmDokter.Clear()
        txtBiayaJasa.Clear()
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
        cmbGolongan_darah.Text = "--Pilih--"
        cmbAgama.Text = "--Pilih--"
    End Sub

    Private Sub btnCariPasien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariPasien.Click
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
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtNoPasien.Text = "" Or txtKdDokter.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Information, "INFORMASI")
        Else
            Dim H1 As Integer
            objpendaftaran.pno_daftar = txtNoPendaftaran.Text
            objpendaftaran.ptgl_daftar = Format(dtpTgl_Pendaftaran.Value, "dd-MM-yyyy")
            objpendaftaran.pbiaya_dokter = txtBiayaJasa.Text
            objpendaftaran.pbiaya_daftar = txtBiayaDaftar.Text
            objpendaftaran.pkd_petugas = "Sementara"
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
End Class