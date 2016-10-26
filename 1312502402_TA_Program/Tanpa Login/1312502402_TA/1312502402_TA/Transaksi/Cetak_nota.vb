Imports System.Data.Odbc
Public Class Cetak_nota

    Dim objnota As New ClsNota
    Dim objResep As New ClsResep
    Dim objDetilResep As New ClsDetil_Resep
    Dim objDetilNota As New ClsDetil_Nota
    Dim objobat As New ClsObat
    Dim stok As Integer
    Dim satuan As String
    Dim jns_obat As String

    Sub Clear()
        txtNoResep.Clear()
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
        txtTotal.Clear()
        btnCariResep.Focus()
        ListViewNota.Items.Clear()
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
        txtNoNota.Enabled = False
        txtNoResep.Enabled = False
        dtpTgl_Nota.Enabled = False
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
        txtTotal.Enabled = False
        txtJmlObat.Enabled = False
        btnCetak.Enabled = False
        btnBatal.Enabled = False
        btnUpdate.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Private Sub Cetak_nota_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btnCariResep.Focus()
    End Sub

    Private Sub Cetak_nota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        Kunci()
        txtNoNota.Text = objnota.autonumber
        txtJmlObat.Text = "0"
        txtJmlObat.Enabled = False
        txtAturanPakai.Enabled = False
        btnCariObat.Enabled = False
        btnUpdate.Enabled = False
        btnCariResep.Focus()
    End Sub

    Private Sub btnCariResep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariResep.Click
        Dim oPop As New Popup_Resep
        oPop.ShowDialog()
        'Dim objpasien As New ClsPasien
        'Dim objobat As New ClsObat
        If oPop.rno_resep <> "" Then
            txtNoResep.Text = oPop.rno_resep
            txtNoPendaftaran.Text = oPop.rno_pendaftaran
            dtpTgl_Pendaftaran.Value = oPop.rtgl_pendaftaran
            txtNoPasien.Text = oPop.rno_pasien
            txtNmPasien.Text = oPop.rnm_pasien
            txtJnsKelamin.Text = oPop.rjenis_kelamin
            txtUsia.Text = oPop.rusia
            txtNmDokter.Text = oPop.rnm_dokter

            tampildata(txtNoResep.Text)

            Dim objresep As New ClsResep
            objresep.pno_daftar = txtNoPendaftaran.Text
            If objresep.cari = True Then
                tampildata(objresep.pno_resep)
            End If

        End If
        btnCetak.Enabled = True
        btnBatal.Enabled = True
        btnCariObat.Enabled = True
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
        btnUpdate.Enabled = True
        btnCetak.Enabled = True
        btnBatal.Enabled = True
        txtJmlObat.Focus()
    End Sub

    Private Sub tampildata(ByVal xData As String)
        Dim objdetil_resep As New ClsDetil_Resep

        Dim xList As List(Of ClsDetil_Resep)
        xList = objdetil_resep.tampildata(xData)
        ListViewNota.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListViewNota.Items.Add(xList.Item(baris).pkd_obat)

            Dim objobat As New ClsObat
            objobat.pkd_obat = xList.Item(baris).pkd_obat
            If objobat.cari = True Then
                ListViewNota.Items(baris).SubItems.Add(objobat.pnm_obat)
                ListViewNota.Items(baris).SubItems.Add(objobat.pharga_obat)
            End If

            ListViewNota.Items(baris).SubItems.Add(xList.Item(baris).pjml_obat)
            ListViewNota.Items(baris).SubItems.Add(xList.Item(baris).paturan_pakai)

            Dim subtotal As Integer
            subtotal = CInt(xList.Item(baris).pjml_obat) * CInt(objobat.pharga_obat)
            ListViewNota.Items(baris).SubItems.Add(subtotal)

            txtTotal.Text = Format(CDbl(asubtotal()), " ###,###,###")

        Next
    End Sub

    Function asubtotal() As Double
        Dim xsubtotal As Double = 0
        For i As Integer = 0 To ListViewNota.Items.Count - 1
            xsubtotal = xsubtotal + CDbl(ListViewNota.Items(i).SubItems(5).Text)
        Next
        Return xsubtotal

    End Function

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub ListViewNota_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewNota.DoubleClick
        Dim Q As String
        Dim xmycmd As OdbcCommand
        Dim xmyread As OdbcDataReader
        Dim tmpBaca As New List(Of ClsObat)

        Q = "select * from obat where kd_obat like '%" & ListViewNota.SelectedItems.Item(0).Text & "%'"
        xmycmd = New OdbcCommand(Q, MyCn)

        xmyread = xmycmd.ExecuteReader
        If xmyread.HasRows Then
            While xmyread.Read
                stok = xmyread.Item("stock")
                jns_obat = xmyread.Item("jns_obat")
                satuan = xmyread.Item("satuan")

            End While
        End If

        With ListViewNota.SelectedItems.Item(0)
            txtKdObat.Text = .Text
            txtNmObat.Text = .SubItems(1).Text
            txtHrgObat.Text = .SubItems(2).Text
            txtJmlObat.Text = .SubItems(3).Text
            txtStock.Text = stok
            txtSatuan.Text = satuan
            txtJnsObat.Text = jns_obat
            txtAturanPakai.Text = .SubItems(4).Text
            ListViewNota.SelectedItems(0).Remove()
        End With
        txtJmlObat.Enabled = True
        btnUpdate.Enabled = True
        txtTotal.Text = Format(CDbl(asubtotal()), " ###,###,###")

    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim n As Integer
        For n = 0 To ListViewNota.Items.Count - 1
            If ListViewNota.Items(n).Text = txtKdObat.Text Then
                MsgBox("Data barang masuk ada pada list")
                Exit Sub
            End If
        Next
        If txtJmlObat.Text = "" Or txtAturanPakai.Text = "" Then
            MsgBox("Tolong Isi Jumlah Pesan")
        Else
            ListViewNota.Items.Add(txtKdObat.Text)
            ListViewNota.Items(n).SubItems.Add(txtNmObat.Text)
            ListViewNota.Items(n).SubItems.Add(txtHrgObat.Text)
            ListViewNota.Items(n).SubItems.Add(txtJmlObat.Text)
            ListViewNota.Items(n).SubItems.Add(txtAturanPakai.Text)
            ListViewNota.Items(n).SubItems.Add(Val(txtJmlObat.Text) * Val(txtHrgObat.Text))

            btnUpdate.Enabled = True
            btnCariObat.Enabled = False
            txtTotal.Enabled = False
            txtTotal.Text = Format(CDbl(asubtotal()), " ###,###,###")
            btnCariObat.Focus()
            BersihObat()
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim hapus As String
        hapus = MessageBox.Show("Apakah Anda Ingin Menghapus Obat Ini ?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If hapus = Windows.Forms.DialogResult.OK Then
            With ListViewNota.SelectedItems.Item(0)
                ListViewNota.SelectedItems(0).Remove()
            End With
        End If
    End Sub

    Private Sub ListViewNota_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewNota.SelectedIndexChanged
        If ListViewNota.FocusedItem.Selected = True Then
            btnHapus.Enabled = True
        Else
            btnHapus.Enabled = False
        End If
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        If txtNoResep.Text = "" Or ListViewNota.Items.Count = 0 Then
            MsgBox("Data Belum Lengkap...!", MsgBoxStyle.Information, "INFORMASI")
        Else
            Dim nilaikembali1, nilaikembali2 As Integer
            objnota.pno_nota = txtNoNota.Text
            objnota.ptgl_nota = Format(dtpTgl_Nota.Value, "dd-MM-yyyy")
            objnota.pno_resep = txtNoResep.Text
            nilaikembali1 = objnota.simpan()
            For x As Integer = 0 To ListViewNota.Items.Count - 1
                objDetilNota.pno_nota = txtNoNota.Text
                objDetilNota.pkd_obat = ListViewNota.Items(x).SubItems(0).Text
                objDetilNota.pjml_obat_nota = CDbl(ListViewNota.Items(x).SubItems(3).Text)
                objDetilNota.pharga = ListViewNota.Items(x).SubItems(2).Text
                objDetilNota.paturan_pakai_nota = ListViewNota.Items(x).SubItems(4).Text
                nilaikembali2 = objDetilNota.simpan()

            Next
            If nilaikembali1 = 1 And nilaikembali2 = 1 Then
                MsgBox("Data Berhasil Disimpan...!", MsgBoxStyle.Information, "INFORMASI")
                IdCetakan = "4"
                TampilCetakan.ShowDialog()
            Else
                MessageBox.Show("Data Gagal Disimpan...!")
            End If

            Kunci()
            Clear()
            BersihObat()
            txtNoNota.Text = objnota.autonumber()
            btnCetak.Enabled = False
            btnBatal.Enabled = False
            btnCariResep.Focus()
            ListViewNota.Items.Clear()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Kunci()
        Clear()
        BersihObat()
        btnCetak.Enabled = False
        btnCariResep.Focus()
        ListViewNota.Items.Clear()
    End Sub
End Class