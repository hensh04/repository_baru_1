Public Class MenuUtama
    Public namapetugas As String
    Public idpetugas As String
    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub EntryDataPasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataPasienToolStripMenuItem.Click
        Entry_Data_Pasien.ShowDialog()
    End Sub

    Private Sub EntryDataDokterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataDokterToolStripMenuItem.Click
        Entry_Data_Dokter.ShowDialog()
    End Sub

    Private Sub EntryDataObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataObatToolStripMenuItem.Click
        Entry_Data_Obat.ShowDialog()
    End Sub

    Private Sub EntryDataPetugasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataPetugasToolStripMenuItem.Click
        Entry_Data_Petugas.ShowDialog()
    End Sub

    Private Sub EntryDataTindakanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataTindakanToolStripMenuItem.Click
        Entry_Data_Tindakan.ShowDialog()
    End Sub

    Private Sub CetakSuratRujukanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakSuratRujukanToolStripMenuItem.Click
        Cetak_Surat_Rujukan.ShowDialog()
    End Sub

    Private Sub EntryPendaftaranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryPendaftaranToolStripMenuItem.Click
        Entry_Pendaftaran.ShowDialog()
    End Sub

    Private Sub EntryPemeriksaanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryPemeriksaanToolStripMenuItem.Click
        Entry_Pemeriksaan.ShowDialog()
    End Sub

    Private Sub EntryResepToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryResepToolStripMenuItem.Click
        Entry_Resep.ShowDialog()
    End Sub

    Private Sub CetakNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakNotaToolStripMenuItem.Click
        Cetak_nota.ShowDialog()
    End Sub

    Private Sub CetakKwitansiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakKwitansiToolStripMenuItem.Click
        Cetak_Kwitansi.ShowDialog()
    End Sub

    Private Sub CetakSuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakSuToolStripMenuItem.Click
        Cetak_Surat_Keterangan_Sakit.ShowDialog()
    End Sub

    Private Sub CetakSuratKeteranganSehatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakSuratKeteranganSehatToolStripMenuItem.Click
        Cetak_Surat_Keterangan_Sehat.ShowDialog()
    End Sub

    Private Sub LaporanRujukanPasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanRujukanPasienToolStripMenuItem.Click
        Cetak_Laporan_Rujukan_Pasien.ShowDialog()
    End Sub

    Private Sub LaporanResepToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanResepToolStripMenuItem.Click
        Cetak_Laporan_Resep.ShowDialog()
    End Sub

    Private Sub LaporanPemeriksaanPasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPemeriksaanPasienToolStripMenuItem.Click
        Cetak_Laporan_Pemeriksaan_Pasien.ShowDialog()
    End Sub

    Private Sub LaporanPendapatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPendapatanToolStripMenuItem.Click
        Cetak_Laporan_Pendapatan.ShowDialog()
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LaporanRekapitulasiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanRekapitulasiToolStripMenuItem.Click
        Cetak_Laporan_Rekapitulasi_Pemakaian_Obat.ShowDialog()
    End Sub

    Private Sub PROFILToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROFILToolStripMenuItem.Click
        profil.ShowDialog()
    End Sub
End Class
