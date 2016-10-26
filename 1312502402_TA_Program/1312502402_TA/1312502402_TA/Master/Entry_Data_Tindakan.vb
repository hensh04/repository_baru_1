Imports System.Data.Odbc
Public Class Entry_Data_Tindakan

    Dim objtindakan As New ClsTindakan

    Private Sub bersih()
        txtNmTindakan.Text = ""
        txtHargaTindakan.Text = ""
        btnSimpan.Enabled = True
        btnCari.Enabled = True
    End Sub

    Private Sub Entry_Data_Tindakan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtNmTindakan.Focus()
    End Sub

    Private Sub Entry_Data_Tindakan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        txtKdTindakan.Text = objtindakan.autonumber()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            If txtKdTindakan.Text = "" Or txtNmTindakan.Text = "" Or txtHargaTindakan.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objtindakan.pkd_tindakan = txtKdTindakan.Text
                objtindakan.pnm_tindakan = txtNmTindakan.Text
                objtindakan.pharga_tindakan = txtHargaTindakan.Text
                If objtindakan.simpan = 1 Then
                    MessageBox.Show("Data Berhasil Disimpan", "Berhasil")
                    bersih()
                    txtKdTindakan.Text = objtindakan.autonumber()
                Else
                    MessageBox.Show("Data Gagal Disimpan", "Gagal")
                End If

                bersih()
                txtKdTindakan.Text = objtindakan.autonumber()
                txtKdTindakan.Enabled = True
                btnCari.Enabled = True
                txtKdTindakan.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        Try
            If txtKdTindakan.Text = "" Or txtNmTindakan.Text = "" Or txtHargaTindakan.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objtindakan.pkd_tindakan = txtKdTindakan.Text
                objtindakan.pnm_tindakan = txtNmTindakan.Text
                objtindakan.pharga_tindakan = txtHargaTindakan.Text
                If objtindakan.ubah = 1 Then
                    MessageBox.Show("Data Berhasil DiUbah", "Berhasil")
                    bersih()
                    txtKdTindakan.Text = objtindakan.autonumber()
                Else
                    MessageBox.Show("Data Gagal DiUbah", "Gagal")
                End If

                bersih()
                txtKdTindakan.Text = objtindakan.autonumber()
                txtKdTindakan.Enabled = True
                btnCari.Enabled = True
                txtKdTindakan.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Try
            objtindakan.pkd_tindakan = txtKdTindakan.Text
            If objtindakan.hapus = 1 Then
                MessageBox.Show("Data Berhasil Dihapus", "Berhasil")
                bersih()
                txtKdTindakan.Text = objtindakan.autonumber()
            Else
                MessageBox.Show("Data Gagal Dihapus", "Gagal")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        bersih()
        txtKdTindakan.Text = objtindakan.autonumber()
        txtKdTindakan.Enabled = True
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtKdTindakan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKdTindakan.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtKdTindakan.Enabled = False
            objtindakan.pkd_tindakan = txtKdTindakan.Text
            If objtindakan.cari = True Then
                txtKdTindakan.Text = objtindakan.pkd_tindakan
                txtNmTindakan.Text = objtindakan.pnm_tindakan
                txtHargaTindakan.Text = objtindakan.pharga_tindakan
                btnSimpan.Enabled = False
            Else
                btnUbah.Enabled = True
                btnHapus.Enabled = False
            End If
            btnCari.Enabled = False
            txtNmTindakan.Focus()
        End If
    End Sub

    Private Sub txtHargaTindakan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHargaTindakan.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harus Masukan Angka!")
        End If
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim oPop As New PopUp_Tindakan
        oPop.ShowDialog()
        If oPop.rkd_tindakan <> "" Then
            txtKdTindakan.Text = oPop.rkd_tindakan
            txtNmTindakan.Text = oPop.rnm_tindakan
            txtHargaTindakan.Text = oPop.rharga_tindakan

            txtKdTindakan.Enabled = False
            btnSimpan.Enabled = False
            btnUbah.Enabled = True
            txtNmTindakan.Focus()
        End If
    End Sub
End Class