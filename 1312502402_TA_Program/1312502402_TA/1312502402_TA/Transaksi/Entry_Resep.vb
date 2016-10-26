Imports System.Data.Odbc
Public Class Entry_Resep

    Dim objResep As New ClsResep
    Dim objDetilResep As New ClsDetil_Resep
    Dim objobat As New ClsObat
    Dim cek_stock As Integer
    Dim usia As Date

    Public Sub tampildata4(ByVal xdata As String)

        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader


        Q = "SELECT tgl_lahir FROM pasien where no_pasien='" & xdata & "'"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                usia = xMyRead.Item("tgl_lahir")
            End While
        End If
    End Sub

    Sub Clear()
        txtNoPendaftaran.Clear()
        txtNmPasien.Clear()
        dtpTgl_Pendaftaran.Value = Now
        txtNoPasien.Clear()
        txtJnsKelamin.Clear()
        txtUsia.Clear()
        txtNmDokter.Clear()
        txtKdObat.Clear()
        txtNmObat.Clear()
        txtJnsObat.Clear()
        txtHrgObat.Clear()
        txtSatuan.Clear()
        txtStock.Clear()
        txtJmlObat.Text = "0"
        txtAturanPakai.Clear()
        btnCariPendaftaran.Focus()
        ListViewResep.Items.Clear()
    End Sub

    Sub BersihObat()
        txtKdObat.Clear()
        txtNmObat.Clear()
        txtJnsObat.Clear()
        txtHrgObat.Clear()
        txtSatuan.Clear()
        txtStock.Clear()
        txtJmlObat.Text = "0"
        txtAturanPakai.Clear()
    End Sub

    Sub Kunci()
        txtNoResep.Enabled = False
        dtpTgl_Resep.Enabled = False
        txtNoPendaftaran.Enabled = False
        txtNmPasien.Enabled = False
        dtpTgl_Pendaftaran.Enabled = False
        txtNoPasien.Enabled = False
        txtJnsKelamin.Enabled = False
        txtUsia.Enabled = False
        txtNmDokter.Enabled = False
        txtKdObat.Enabled = False
        txtNmObat.Enabled = False
        txtJnsObat.Enabled = False
        txtHrgObat.Enabled = False
        txtSatuan.Enabled = False
        txtStock.Enabled = False
        txtAturanPakai.Enabled = False
        txtJmlObat.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnTambahObat.Enabled = False
    End Sub

    Private Sub Entry_Resep_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btnCariPendaftaran.Focus()
    End Sub

    Private Sub Entry_Resep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        Kunci()
        txtNoResep.Text = objResep.autonumber
        txtJmlObat.Text = ""
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
            txtNmDokter.Text = oPop.rnm_dokter
        End If
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        tampildata4(txtNoPasien.Text)
        txtUsia.Text = DateDiff(DateInterval.Year, usia, Now)
        btnCariObat.Focus()
    End Sub

    Private Sub btnCariObat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariObat.Click
        Dim oPop As New PopUp_Obat
        oPop.ShowDialog()
        If oPop.rkd_obat <> "" Then
            txtKdObat.Text = oPop.rkd_obat
            txtNmObat.Text = oPop.rnm_obat
            txtJnsObat.Text = oPop.rjns_obat
            txtHrgObat.Text = oPop.rharga_obat
            txtSatuan.Text = oPop.rsatuan
            txtStock.Text = oPop.rstock
        End If
        txtJmlObat.Enabled = True
        txtAturanPakai.Enabled = True
        btnTambahObat.Enabled = True
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        txtJmlObat.Focus()
    End Sub

    Private Sub btnTambahObat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambahObat.Click
        Dim n As Integer
        For n = 0 To ListViewResep.Items.Count - 1
            If ListViewResep.Items(n).Text = txtKdObat.Text Then
                MsgBox("Data Sudah Masuk ke List...!")
                Exit Sub
            End If
        Next
        If Val(txtStock.Text) < Val(txtJmlObat.Text) Then
            MsgBox("Stock Obat Tidak Mencukupi", MsgBoxStyle.Information, "Peringatan")
            Exit Sub
        End If
        If txtKdObat.Text = "" Then
            MsgBox("Data Tidak Masuk ke List...!")
            btnCariObat.Focus()
            Exit Sub
        ElseIf txtJmlObat.Text = "" Or txtJmlObat.Text = "0" Or txtAturanPakai.Text = "" Or txtAturanPakai.Text = "0" Then
            MsgBox("Masukkan Jumlah Obat dan Aturan Pakai...!")
            txtJmlObat.Focus()
            Exit Sub
        Else
            ListViewResep.Items.Add(txtKdObat.Text)
            ListViewResep.Items(n).SubItems.Add(txtNmObat.Text)
            ListViewResep.Items(n).SubItems.Add(txtJmlObat.Text)
            ListViewResep.Items(n).SubItems.Add(txtAturanPakai.Text)

            txtJmlObat.Enabled = False
            txtAturanPakai.Enabled = False
        End If

        BersihObat()
        txtJmlObat.Enabled = True
        txtAturanPakai.Enabled = True
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtNoPendaftaran.Text = "" Or txtNoPasien.Text = "" Or ListViewResep.Items.Count = 0 Then
            MsgBox("Data Belum Lengkap...!", MsgBoxStyle.Information, "INFORMASI")
        Else
            Dim nilaikembali1, nilaikembali2 As Integer
            objResep.pno_resep = txtNoResep.Text
            objResep.ptgl_resep = Format(dtpTgl_Resep.Value, "dd-MM-yyyy")
            objResep.pno_daftar = txtNoPendaftaran.Text
            nilaikembali1 = objResep.simpan()
            For x As Integer = 0 To ListViewResep.Items.Count - 1
                objDetilResep.pno_resep = txtNoResep.Text
                objDetilResep.pkd_obat = ListViewResep.Items(x).SubItems(0).Text
                objDetilResep.pjml_obat = CDbl(ListViewResep.Items(x).SubItems(2).Text)
                objDetilResep.paturan_pakai = ListViewResep.Items(x).SubItems(3).Text
                nilaikembali2 = objDetilResep.simpan()

            Next
            If nilaikembali1 = 1 And nilaikembali2 = 1 Then
                MsgBox("Data Berhasil Disimpan...!", MsgBoxStyle.Information, "INFORMASI")
            Else
                MessageBox.Show("Data Gagal Disimpan...!")
            End If

            Kunci()
            Clear()
            BersihObat()
            txtNoResep.Text = objResep.autonumber()
            btnSimpan.Enabled = True
            btnBatal.Enabled = True
            btnCariPendaftaran.Focus()
            ListViewResep.Items.Clear()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Clear()
        BersihObat()
        btnSimpan.Enabled = True
        btnCariPendaftaran.Focus()
        ListViewResep.Items.Clear()
        txtJmlObat.Enabled = False
        txtAturanPakai.Enabled = False
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub ListViewResep_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewResep.MouseDoubleClick
        With ListViewResep.SelectedItems.Item(0)
            txtKdObat.Text = .Text
            txtNmObat.Text = .SubItems(1).Text
            txtJmlObat.Text = .SubItems(2).Text
            txtAturanPakai.Text = .SubItems(3).Text
        End With
        If ListViewResep.SelectedItems.Count <> 0 Then
            Dim pesan = MessageBox.Show("Apakah Anda Ingin Menghapus Obat Ini?", "Konfirmasi", MessageBoxButtons.YesNo)
            If pesan = Windows.Forms.DialogResult.Yes Then
                ListViewResep.SelectedItems(0).Remove()
                BersihObat()
            Else
                BersihObat()
            End If
        End If
    End Sub
End Class