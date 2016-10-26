Imports System.Data.Odbc
Public Class Cetak_Kwitansi

    Dim objnota As New ClsNota
    Dim objResep As New ClsResep
    Dim objDetilResep As New ClsDetil_Resep
    Dim objDetilNota As New ClsDetil_Nota
    Dim objobat As New ClsObat
    Dim objpendaftaran As New ClsPendaftaran
    Dim objkartu_status As New ClsKartu_Status
    Dim objkwitansi As New ClsKwitansi
    Dim objDetilTindakan As New ClsDetil_Tindakan
    Dim objtindakan As New ClsTindakan
    Dim A As String
    Dim B As String
    Dim Z As Integer

    Public Sub tampildata2(ByVal xData As String)

        Dim Q As String
        Dim xMyCmd As OdbcCommand
        Dim xMyRead As OdbcDataReader


        Q = "SELECT ifnull(sum(b.jml_obat_nota * b.harga),0) as penjumlahan FROM resep c right outer join pendaftaran d on  c.no_daftar = d.no_daftar left outer join nota a on a.no_resep = c.no_resep left outer join detil_nota b on b.no_nota = a.no_nota where d.no_daftar= '" & xData & "' group by a.no_nota"
        xMyCmd = New OdbcCommand(Q, MyCn)

        xMyRead = xMyCmd.ExecuteReader
        If xMyRead.HasRows Then
            While xMyRead.Read
                Z = xMyRead.Item("penjumlahan")
            End While
        End If
    End Sub

    Private Sub tampildata3(ByVal xData As String)

        Dim xList As List(Of ClsDetil_Tindakan)
        xList = objDetilTindakan.tampildata(xData)
        ListViewTindakan.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListViewTindakan.Items.Add(xList.Item(baris).pkd_tindakan)

            Dim objtindakan As New ClsTindakan
            objtindakan.pkd_tindakan = xList.Item(baris).pkd_tindakan
            If objtindakan.cari = True Then
                ListViewTindakan.Items(baris).SubItems.Add(objtindakan.pnm_tindakan)
            End If

            ListViewTindakan.Items(baris).SubItems.Add(xList.Item(baris).pbiaya_tindakan)
            ListViewTindakan.Items(baris).SubItems.Add(xList.Item(baris).pbanyaknya_tindakan)
            ListViewTindakan.Items(baris).SubItems.Add((xList.Item(baris).pbanyaknya_tindakan) * (xList.Item(baris).pbiaya_tindakan))


        Next
    End Sub

    Sub grandtotal()
        Dim total As Double
        For i As Integer = 0 To ListViewTindakan.Items.Count - 1
            total = total + ListViewTindakan.Items(i).SubItems(4).Text
        Next
        txtTotal.Text = total
    End Sub

    Sub Clear()
        txtNoPendaftaran.Clear()
        txtNmPasien.Clear()
        dtpTgl_Pendaftaran.Value = Now
        txtNmPasien.Clear()
        txtBiayaJasaDokter.Clear()
        txtBiayaObat.Clear()
        txtBiayaPendaftaran.Clear()
        txtTotal.Clear()
        txtTerbilang.Clear()
        txtJmlBiayaSeluruh.Clear()
        txtBayar.Clear()
        txtKembali.Text = "0"
        btnCari.Focus()
        ListViewTindakan.Items.Clear()
    End Sub

    Sub Kunci()
        txtNoKwitansi.Enabled = False
        dtpTgl_Kwitansi.Enabled = False
        dtpTgl_Pendaftaran.Enabled = False
        txtNoPendaftaran.Enabled = False
        txtNmPasien.Enabled = False
        txtBiayaJasaDokter.Enabled = False
        txtBiayaPendaftaran.Enabled = False
        txtBayar.Enabled = False
        txtBiayaObat.Enabled = False
        ListViewTindakan.Enabled = False
        txtJmlBiayaSeluruh.Enabled = False
        txtTerbilang.Enabled = False
        txtKembali.Enabled = False
        txtTotal.Enabled = False

        btnCetak.Enabled = False
        btnBatal.Enabled = False
    End Sub

    Private Sub Cetak_Kwitansi_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btnCari.Focus()
    End Sub

    Private Sub Cetak_Kwitansi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        Kunci()
        txtNoKwitansi.Text = objkwitansi.autonumber
        txtBiayaJasaDokter.Text = "0"
        txtBiayaPendaftaran.Text = "0"
        txtBiayaObat.Text = "0"
        txtTotal.Text = "0"
        txtJmlBiayaSeluruh.Text = "0"
        txtKembali.Text = "0"
        btnCari.Focus()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim oPop As New PopUp_Pendaftaran
        oPop.ShowDialog()
        If oPop.rno_pendaftaran <> "" Then
            txtNoPendaftaran.Text = oPop.rno_pendaftaran
            dtpTgl_Pendaftaran.Value = oPop.rtgl_pendaftaran
            txtNmPasien.Text = oPop.rnm_pasien
        End If


        btnCetak.Enabled = True
        btnBatal.Enabled = True
        ListViewTindakan.Enabled = True
        txtBayar.Enabled = True
        btnCari.Focus()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtBayar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtBayar.Text) < Val(txtJmlBiayaSeluruh.Text) Then
                MsgBox("Jumlah Biaya Bayar Tidak Boleh Kurang Dari Biaya Keseluruhan", MsgBoxStyle.Information, "Peringatan")
            Else
                txtKembali.Text = Val(txtBayar.Text) - Val(txtJmlBiayaSeluruh.Text)
                MsgBox("" & txtKembali.Text & vbCrLf & " (" & Terbilang(txtKembali.Text) & ")", MsgBoxStyle.Information, "Kembalian Anda")
            End If
        End If
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        If txtNoPendaftaran.Text = "" Then
            MsgBox("Data Belum Lengkap...!", MsgBoxStyle.Information, "INFORMASI")
        Else
            Dim nilaikembali1 As Integer
            objkwitansi.pno_kwitansi = txtNoKwitansi.Text
            objkwitansi.ptgl_kwitansi = Format(dtpTgl_Kwitansi.Value, "dd-MM-yyyy")
            objkwitansi.pno_daftar = txtNoPendaftaran.Text
            nilaikembali1 = objkwitansi.simpan()

            If nilaikembali1 = 1 Then
                MsgBox("Data Berhasil Disimpan...!", MsgBoxStyle.Information, "INFORMASI")
                IdCetakan = "6"
                TampilCetakan.ShowDialog()
            Else
                MessageBox.Show("Data Gagal Disimpan...!")
            End If

            Kunci()
            Clear()
            txtNoKwitansi.Text = objkwitansi.autonumber()
            btnCetak.Enabled = False
            btnBatal.Enabled = False
            btnCari.Focus()
        End If
    End Sub

    Private Sub txtNoPendaftaran_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoPendaftaran.TextChanged

        objResep.pno_daftar = txtNoPendaftaran.Text
        If objResep.cari2 = True Then
            A = objResep.pno_resep

        End If

        objpendaftaran.pno_daftar = txtNoPendaftaran.Text
        If objpendaftaran.cari = True Then
            txtBiayaJasaDokter.Text = objpendaftaran.pbiaya_dokter
            txtBiayaPendaftaran.Text = objpendaftaran.pbiaya_daftar
        End If

        objnota.pno_resep = A
        If objnota.cari2 = True Then
            B = objnota.pno_nota

        End If

        If txtNoPendaftaran.Text <> "" Then
            tampildata2(txtNoPendaftaran.Text)
            txtBiayaObat.Text = Z
            tampildata3(txtNoPendaftaran.Text)
            grandtotal()
            txtJmlBiayaSeluruh.Text = Val(txtBiayaJasaDokter.Text) + Val(txtBiayaPendaftaran.Text) + Val(txtBiayaObat.Text) + Val(txtTotal.Text)
            txtTerbilang.Text = Terbilang(txtJmlBiayaSeluruh.Text) & "Rupiah"
        End If

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Clear()
    End Sub
End Class