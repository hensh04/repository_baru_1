Imports System.Data.Odbc
Public Class Entry_Pemeriksaan

    Dim objperiksa As New ClsKartu_Status
    Dim objpendaftaran As New ClsPendaftaran
    Dim objpasien As New ClsPasien
    Dim objdokter As New ClsTindakan
    Dim objdetil_tindkan As New ClsDetil_Tindakan

    Sub ClearForm()
        txtNoPendaftaran.Clear()
        txtNmPasien.Clear()
        dtpTgl_Pendaftaran.Value = Now
        txtNoPasien.Clear()
        txtJnsKelamin.Clear()
        txtUsia.Clear()
        txtTinggiBadan.Clear()
        txtTensi.Clear()
        txtBeratBadan.Clear()
        txtKeluhan.Clear()
        txtDiagnosa.Clear()
    End Sub

    Sub BersihTindakan()
        txtKdTindakan.Clear()
        txtNmTindakan.Clear()
        txtBiayaTindakan.Text = "0"
        txtBanyaknnyaTindakan.Text = "0"
    End Sub

    Sub kunci()
        txtNoPendaftaran.Enabled = False
        dtpTgl_Pendaftaran.Enabled = False
        dtpTgl_Periksa.Enabled = False
        txtNoPasien.Enabled = False
        txtNmPasien.Enabled = False
        txtJnsKelamin.Enabled = False
        txtUsia.Enabled = False
        txtNmDokter.Enabled = False
        txtKdTindakan.Enabled = False
        txtNmTindakan.Enabled = False
        txtBiayaTindakan.Enabled = False
        txtTotal.Enabled = False
    End Sub

    Function subtotal() As Double
        Dim xsubtotal As Double = 0
        For i As Integer = 0 To ListViewTindakan_Periksa.Items.Count - 1
            xsubtotal = xsubtotal + CDbl(ListViewTindakan_Periksa.Items(i).SubItems(4).Text)
        Next
        Return xsubtotal
    End Function

    Private Sub Entry_Pemeriksaan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kunci()
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnCariPendaftaran.Focus()
    End Sub

    Private Sub btnCariPendaftaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariPendaftaran.Click
        Dim oPop As New PopUp_Pendaftaran
        oPop.ShowDialog()
        If oPop.rno_pendaftaran <> "" Then
            txtNoPendaftaran.Text = oPop.rno_pendaftaran
            dtpTgl_Pendaftaran.Value = oPop.rtgl_pendaftaran
            txtNoPasien.Text = oPop.rno_pasien
            txtNmPasien.Text = oPop.rnm_pasien
            txtJnsKelamin.Text = oPop.rjenis_kelamin
            txtUsia.Text = oPop.rusia
            txtNmDokter.Text = oPop.rnm_dokter
        End If
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        txtTinggiBadan.Focus()
    End Sub

    Private Sub btnCariTindakan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariTindakan.Click
        Dim oPop As New PopUp_Tindakan
        oPop.ShowDialog()
        If oPop.rkd_tindakan <> "" Then
            txtKdTindakan.Text = oPop.rkd_tindakan
            txtNmTindakan.Text = oPop.rnm_tindakan
            txtBiayaTindakan.Text = oPop.rharga_tindakan
        End If
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        txtBanyaknnyaTindakan.Focus()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim n As Integer
        For n = 0 To ListViewTindakan_Periksa.Items.Count - 1
            If ListViewTindakan_Periksa.Items(n).Text = txtKdTindakan.Text Then
                MsgBox("Data Sudah Masuk ke List...!")
                Exit Sub
            End If
        Next
        If txtKdTindakan.Text = "" Then
            MsgBox("Data Tidak Masuk ke List...!")
            btnCariTindakan.Focus()
            Exit Sub
            If txtBanyaknnyaTindakan.Text = "" Or txtBanyaknnyaTindakan.Text = "0" Then

                MsgBox("Masukkan Banyaknnya Tindakan...!")
            End If
            txtBanyaknnyaTindakan.Focus()
            Exit Sub
        Else
            ListViewTindakan_Periksa.Items.Add(txtKdTindakan.Text)
            ListViewTindakan_Periksa.Items(n).SubItems.Add(txtNmTindakan.Text)
            ListViewTindakan_Periksa.Items(n).SubItems.Add(txtBiayaTindakan.Text)
            ListViewTindakan_Periksa.Items(n).SubItems.Add(txtBanyaknnyaTindakan.Text)
            ListViewTindakan_Periksa.Items(n).SubItems.Add(txtBiayaTindakan.Text * txtBanyaknnyaTindakan.Text)

            txtBanyaknnyaTindakan.Enabled = False
            txtTotal.Text = Format(CDbl(subtotal()), " ###,##0")
        End If

        BersihTindakan()
        txtBanyaknnyaTindakan.Enabled = True
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtNoPendaftaran.Text = "" Or txtNoPasien.Text = "" Then
            MsgBox("Data Belum Lengkap...!", MsgBoxStyle.Information, "INFORMASI")
        Else
            Dim nilaikembali1, nilaikembali2 As Integer
            objperiksa.pno_daftar = txtNoPendaftaran.Text
            objperiksa.pno_pasien = txtNoPasien.Text
            objperiksa.ptgl_kartu_status = Format(dtpTgl_Periksa.Value, "dd-MM-yyyy")
            objperiksa.pkeluhan = txtKeluhan.Text
            objperiksa.pdiagnosa = txtDiagnosa.Text
            objperiksa.pberat_badan = txtBeratBadan.Text
            objperiksa.ptinggi_badan = txtTinggiBadan.Text
            objperiksa.ptensi = txtTensi.Text
            nilaikembali1 = objperiksa.simpan()
            For x As Integer = 0 To ListViewTindakan_Periksa.Items.Count - 1
                objdetil_tindkan.pno_daftar = txtNoPendaftaran.Text
                objdetil_tindkan.pkd_tindakan = ListViewTindakan_Periksa.Items(x).SubItems(0).Text
                objdetil_tindkan.pbiaya_tindakan = CDbl(ListViewTindakan_Periksa.Items(x).SubItems(2).Text)
                objdetil_tindkan.pbanyaknya_tindakan = CDbl(ListViewTindakan_Periksa.Items(x).SubItems(3).Text)
                nilaikembali2 = objdetil_tindkan.simpan()

            Next
            If nilaikembali1 = 1 Or nilaikembali2 = 1 Then
                MsgBox("Data Berhasil Disimpan...!", MsgBoxStyle.Information, "INFORMASI")
            Else
                MessageBox.Show("Data Gagal Disimpan...!")
            End If

            kunci()
            ClearForm()
            BersihTindakan()
            btnSimpan.Enabled = True
            btnBatal.Enabled = True
            btnCariPendaftaran.Focus()
            ListViewTindakan_Periksa.Items.Clear()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        ClearForm()
        BersihTindakan()
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnCariPendaftaran.Focus()
        ListViewTindakan_Periksa.Items.Clear()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub ListViewTindakan_Periksa_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewTindakan_Periksa.DoubleClick
        With ListViewTindakan_Periksa.SelectedItems.Item(0)
            txtKdTindakan.Text = .Text
            txtNmTindakan.Text = .SubItems(1).Text
            txtBiayaTindakan.Text = .SubItems(2).Text
            txtBanyaknnyaTindakan.Text = .SubItems(3).Text
        End With
        If ListViewTindakan_Periksa.SelectedItems.Count <> 0 Then
            Dim pesan = MessageBox.Show("Apakah Anda Ingin Menghapus Tindakan Ini?", "Konfirmasi", MessageBoxButtons.YesNo)
            If pesan = Windows.Forms.DialogResult.Yes Then
                ListViewTindakan_Periksa.SelectedItems(0).Remove()
                BersihTindakan()
            Else
                BersihTindakan()
            End If
        End If
        txtTotal.Text = Format(CDbl(subtotal()), " ###,##0")
    End Sub

    Private Sub ListViewTindakan_Periksa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewTindakan_Periksa.SelectedIndexChanged

    End Sub
End Class