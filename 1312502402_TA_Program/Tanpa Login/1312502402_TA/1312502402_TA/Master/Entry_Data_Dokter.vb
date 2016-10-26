Imports System.Data.Odbc
Public Class Entry_Data_Dokter

    Dim objDokter As New ClsDokter

    Private Sub bersih()
        txtNmDokter.Text = ""
        dtpTglLahir.Text = Now
        rbPria.Checked = True
        txtAlamat.Text = ""
        txtTelepon.Text = ""
        txtBiayaJasa.Text = ""
        btnSimpan.Enabled = True
        btnCari.Enabled = True
    End Sub

    Private Sub Entry_Data_Dokter_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtNmDokter.Focus()
    End Sub

    Private Sub Entry_Data_Dokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        txtKdDokter.Text = objDokter.autonumber()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            If txtKdDokter.Text = "" Or txtNmDokter.Text = "" Or txtAlamat.Text = "" Or txtTelepon.Text = "" Or txtBiayaJasa.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objDokter.pkd_dokter = txtKdDokter.Text
                objDokter.pnm_dokter = txtNmDokter.Text
                objDokter.ptgl_lahir = dtpTglLahir.Text
                If rbPria.Checked = True Then
                    objDokter.pjns_kelamin = rbPria.Text
                Else
                    objDokter.pjns_kelamin = rbWanita.Text
                End If
                objDokter.palamat = txtAlamat.Text
                objDokter.ptelepon = txtTelepon.Text
                objDokter.pbiaya_jasa = txtBiayaJasa.Text
                If objDokter.simpan = 1 Then
                    MessageBox.Show("Data Berhasil Disimpan", "Berhasil")
                    bersih()
                    txtKdDokter.Text = objDokter.autonumber()
                Else
                    MessageBox.Show("Data Gagal Disimpan", "Gagal")
                End If

                bersih()
                txtKdDokter.Text = objDokter.autonumber()
                txtKdDokter.Enabled = True
                btnCari.Enabled = True
                rbPria.Checked = False
                rbWanita.Checked = False
                txtKdDokter.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        Try
            If txtKdDokter.Text = "" Or txtNmDokter.Text = "" Or txtAlamat.Text = "" Or txtTelepon.Text = "" Or txtBiayaJasa.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objDokter.pkd_dokter = txtKdDokter.Text
                objDokter.pnm_dokter = txtNmDokter.Text
                objDokter.ptgl_lahir = dtpTglLahir.Text
                If rbPria.Checked = True Then
                    objDokter.pjns_kelamin = rbPria.Text
                Else
                    objDokter.pjns_kelamin = rbWanita.Text
                End If
                objDokter.palamat = txtAlamat.Text
                objDokter.ptelepon = txtTelepon.Text
                objDokter.pbiaya_jasa = txtBiayaJasa.Text
                If objDokter.ubah = 1 Then
                    MessageBox.Show("Data Berhasil Diubah", "Berhasil")
                    bersih()
                    txtKdDokter.Text = objDokter.autonumber()
                Else
                    MessageBox.Show("Data Gagal Diubah", "Gagal")
                End If

                bersih()
                txtKdDokter.Text = objDokter.autonumber()
                txtKdDokter.Enabled = True
                btnCari.Enabled = True
                txtKdDokter.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Try
            objDokter.pkd_dokter = txtKdDokter.Text
            If objDokter.hapus = 1 Then
                MessageBox.Show("Data Berhasil Dihapus", "Berhasil")
                bersih()
                txtKdDokter.Text = objDokter.autonumber()
            Else
                MessageBox.Show("Data Gagal Dihapus", "Gagal")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        rbPria.Checked = False
        rbWanita.Checked = False
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        bersih()
        txtKdDokter.Text = objDokter.autonumber()
        txtKdDokter.Enabled = True
        rbPria.Checked = False
        rbWanita.Checked = False
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtKdDokter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKdDokter.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtKdDokter.Enabled = False
            objDokter.pkd_dokter = txtKdDokter.Text
            If objDokter.cari = True Then
                txtKdDokter.Text = objDokter.pkd_dokter
                txtNmDokter.Text = objDokter.pnm_dokter
                dtpTglLahir.Value = objDokter.ptgl_lahir
                If rbPria.Text = objDokter.pjns_kelamin Then
                    rbPria.Checked = True
                Else
                    rbWanita.Checked = True
                End If
                txtAlamat.Text = objDokter.palamat
                txtTelepon.Text = objDokter.ptelepon
                txtBiayaJasa.Text = objDokter.pbiaya_jasa
                btnSimpan.Enabled = False
            Else
                btnUbah.Enabled = False
                btnHapus.Enabled = False
            End If
            btnCari.Enabled = False
            txtNmDokter.Focus()
        End If
    End Sub


    Private Sub txtTelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelepon.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harus Masukan Angka!")
        End If
    End Sub


    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim oPop As New Popup_Dokter
        oPop.ShowDialog()
        If oPop.rkd_dokter <> "" Then
            txtKdDokter.Text = oPop.rkd_dokter
            txtNmDokter.Text = oPop.rnm_dokter
            dtpTglLahir.Value = oPop.rtgl_lahir
            If oPop.rjns_kelamin = "Pria" Then
                rbPria.Checked = True
            Else
                rbWanita.Checked = True
            End If
            txtAlamat.Text = oPop.ralamat
            txtTelepon.Text = oPop.rtelepon
            txtBiayaJasa.Text = oPop.rbiaya_jasa

            txtKdDokter.Enabled = False
            btnSimpan.Enabled = False
            txtNmDokter.Focus()
        End If
    End Sub

    Private Sub txtBiayaJasa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBiayaJasa.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harus Masukan Angka!")
        End If
    End Sub
End Class