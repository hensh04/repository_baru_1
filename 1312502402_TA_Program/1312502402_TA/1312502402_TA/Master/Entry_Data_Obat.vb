Imports System.Data.Odbc
Public Class Entry_Data_Obat

    Dim objobat As New ClsObat

    Private Sub bersih()
        txtNmObat.Text = ""
        cmbJnsObat.Text = "--Pilih--"
        txtHrgObat.Text = ""
        txtSatuan.Text = ""
        txtStock.Text = ""
        btnSimpan.Enabled = True
        btnCari.Enabled = True
    End Sub

    Private Sub Entry_Data_Obat_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtNmObat.Focus()
    End Sub

    Private Sub Entry_Data_Obat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vbukaConn()
        txtKdObat.Text = objobat.autonumber()
        cmbJnsObat.Text = "--Pilih--"
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            If txtKdObat.Text = "" Or txtNmObat.Text = "" Or cmbJnsObat.Text = "--Pilih--" Or txtHrgObat.Text = "" Or txtSatuan.Text = "" Or txtStock.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objobat.pkd_obat = txtKdObat.Text
                objobat.pnm_obat = txtNmObat.Text
                objobat.pjns_obat = cmbJnsObat.Text
                objobat.pharga_obat = txtHrgObat.Text
                objobat.psatuan = txtSatuan.Text
                objobat.pstock = txtStock.Text
                If objobat.simpan = 1 Then
                    MessageBox.Show("Data Berhasil Disimpan", "Berhasil")
                    bersih()
                    txtKdObat.Text = objobat.autonumber()
                Else
                    MessageBox.Show("Data Gagal Disimpan", "Gagal")
                End If

                bersih()
                txtKdObat.Text = objobat.autonumber()
                txtKdObat.Enabled = True
                btnCari.Enabled = True
                txtKdObat.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        Try
            If txtKdObat.Text = "" Or txtNmObat.Text = "" Or cmbJnsObat.Text = "--Pilih--" Or txtHrgObat.Text = "" Or txtSatuan.Text = "" Or txtStock.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objobat.pkd_obat = txtKdObat.Text
                objobat.pnm_obat = txtNmObat.Text
                objobat.pjns_obat = cmbJnsObat.Text
                objobat.pharga_obat = txtHrgObat.Text
                objobat.psatuan = txtSatuan.Text
                objobat.pstock = txtStock.Text
                If objobat.ubah = 1 Then
                    MessageBox.Show("Data Berhasil DiUbah", "Berhasil")
                    bersih()
                    txtKdObat.Text = objobat.autonumber()
                Else
                    MessageBox.Show("Data Gagal DiUbah", "Gagal")
                End If

                bersih()
                txtKdObat.Text = objobat.autonumber()
                txtKdObat.Enabled = True
                btnCari.Enabled = True
                txtKdObat.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Try
            objobat.pkd_obat = txtKdObat.Text
            If objobat.hapus = 1 Then
                MessageBox.Show("Data Berhasil Dihapus", "Berhasil")
                bersih()
                txtKdObat.Text = objobat.autonumber()
            Else
                MessageBox.Show("Data Gagal Dihapus", "Gagal")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        bersih()
        txtKdObat.Text = objobat.autonumber()
        txtKdObat.Enabled = True
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtKdObat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKdObat.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtKdObat.Enabled = False
            objobat.pkd_obat = txtKdObat.Text
            If objobat.cari = True Then
                txtKdObat.Text = objobat.pkd_obat
                txtNmObat.Text = objobat.pnm_obat
                cmbJnsObat.Text = objobat.pjns_obat
                txtHrgObat.Text = objobat.pharga_obat
                txtSatuan.Text = objobat.psatuan
                txtStock.Text = objobat.pstock
                btnSimpan.Enabled = False
            Else
                btnUbah.Enabled = False
                btnHapus.Enabled = False
            End If
            btnCari.Enabled = False
            txtNmObat.Focus()
        End If
    End Sub

    Private Sub txtHrgObat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHrgObat.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harus Masukan Angka!")
        End If
    End Sub

    Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harus Masukan Angka!")
        End If
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim oPop As New PopUp_Obat
        oPop.ShowDialog()
        If oPop.rkd_obat <> "" Then
            txtKdObat.Text = oPop.rkd_obat
            txtNmObat.Text = oPop.rnm_obat
            cmbJnsObat.Text = oPop.rjns_obat
            txtHrgObat.Text = oPop.rharga_obat
            txtSatuan.Text = oPop.rsatuan
            txtStock.Text = oPop.rstock

            txtKdObat.Enabled = False
            btnSimpan.Enabled = False
            txtNmObat.Focus()
        End If
    End Sub
End Class