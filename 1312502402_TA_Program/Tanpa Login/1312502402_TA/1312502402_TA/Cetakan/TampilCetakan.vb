Imports CrystalDecisions.CrystalReports.Engine

Public Class TampilCetakan

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim objreportdoc As New ReportDocument
        If IdCetakan = "1" Then
            objreportdoc = New CSKSehat
            objreportdoc.SetParameterValue("NomorSuratKeteranganSehat", Cetak_Surat_Keterangan_Sehat.txtNoSuratSehat.Text)
            objreportdoc.RecordSelectionFormula = "{surat_sehat1.no_surat_sehat} = '" & Cetak_Surat_Keterangan_Sehat.txtNoSuratSehat.Text & "'"
        End If
        If IdCetakan = "2" Then
            objreportdoc = New CSKSakit
            objreportdoc.SetParameterValue("NomorSuratKeteranganSakit", Cetak_Surat_Keterangan_Sakit.txtNoSuratSakit.Text)
            objreportdoc.RecordSelectionFormula = "{surat_sakit1.no_surat_sakit} = '" & Cetak_Surat_Keterangan_Sakit.txtNoSuratSakit.Text & "'"
        End If
        If IdCetakan = "3" Then
            objreportdoc = New CSKRujukan
            objreportdoc.SetParameterValue("NomorSuratRujukan", Cetak_Surat_Rujukan.txtNoSuratRujukan.Text)
            objreportdoc.RecordSelectionFormula = "{surat_rujukan1.no_surat_rujukan} = '" & Cetak_Surat_Rujukan.txtNoSuratRujukan.Text & "'"
        End If
        If IdCetakan = "4" Then
            objreportdoc = New CNota
            objreportdoc.SetParameterValue("NomorNota", Cetak_nota.txtNoNota.Text)
            objreportdoc.RecordSelectionFormula = "{nota1.no_nota} = '" & Cetak_nota.txtNoNota.Text & "'"
        End If
        If IdCetakan = "5" Then
            objreportdoc = New CLRujukan
            objreportdoc.SetParameterValue("Tgl1", Format(Cetak_Laporan_Rujukan_Pasien.dtpTanggal1.Value, "dd-MM-yyyy"))
            objreportdoc.SetParameterValue("Tgl2", Format(Cetak_Laporan_Rujukan_Pasien.dtpTanggal2.Value, "dd-MM-yyyy"))
            'objRepDoc.SetParameterValue("staff", Mid(FrmLapPendapatan.ToolStripStatusLabel3.Text, 7, 30))
            objreportdoc.RecordSelectionFormula = "{surat_rujukan1.tgl_surat_rujukan} >= #" & Format(Cetak_Laporan_Rujukan_Pasien.dtpTanggal1.Value, "MM-dd-yyyy") & "# And {surat_rujukan1.tgl_surat_rujukan} <= #" & Format(Cetak_Laporan_Rujukan_Pasien.dtpTanggal2.Value, "MM-dd-yyyy") & "#"
        End If
        If IdCetakan = "6" Then
            objreportdoc = New CRKwintansi
            objreportdoc.SetParameterValue("NomorKwitansi", Cetak_Kwitansi.txtNoKwitansi.Text)
            objreportdoc.RecordSelectionFormula = "{cetakankwitansi21.no_kwitansi} = '" & Cetak_Kwitansi.txtNoKwitansi.Text & "'"
            'objreportdoc.SetParameterValue("Terbilang", Cetak_Kwitansi.txtTerbilang.Text)
        End If
        If IdCetakan = "7" Then
            objreportdoc = New CLResep
            objreportdoc.SetParameterValue("Tgl1", Format(Cetak_Laporan_Resep.dtpTanggal1.Value, "dd-MM-yyyy"))
            objreportdoc.SetParameterValue("Tgl2", Format(Cetak_Laporan_Resep.dtpTanggal2.Value, "dd-MM-yyyy"))
            'objRepDoc.SetParameterValue("staff", Mid(FrmLapPendapatan.ToolStripStatusLabel3.Text, 7, 30))
            objreportdoc.RecordSelectionFormula = "{nota1.tgl_nota} >= #" & Format(Cetak_Laporan_Resep.dtpTanggal1.Value, "MM-dd-yyyy") & "# And {nota1.tgl_nota} <= #" & Format(Cetak_Laporan_Resep.dtpTanggal2.Value, "MM-dd-yyyy") & "#"
        End If
        If IdCetakan = "8" Then
            objreportdoc = New CLPemeriksaanPasien
            objreportdoc.SetParameterValue("Tgl1", Format(Cetak_Laporan_Pemeriksaan_Pasien.dtpTanggal1.Value, "dd-MM-yyyy"))
            objreportdoc.SetParameterValue("Tgl2", Format(Cetak_Laporan_Pemeriksaan_Pasien.dtpTanggal2.Value, "dd-MM-yyyy"))
            'objRepDoc.SetParameterValue("staff", Mid(FrmLapPendapatan.ToolStripStatusLabel3.Text, 7, 30))
            objreportdoc.RecordSelectionFormula = "{kartu_status1.tgl_kartu_status} >= #" & Format(Cetak_Laporan_Pemeriksaan_Pasien.dtpTanggal1.Value, "MM-dd-yyyy") & "# And {kartu_status1.tgl_kartu_status} <= #" & Format(Cetak_Laporan_Pemeriksaan_Pasien.dtpTanggal2.Value, "MM-dd-yyyy") & "#"
        End If
        If IdCetakan = "9" Then
            objreportdoc = New CLPendapatan
            objreportdoc.SetParameterValue("Tgl1", Format(Cetak_Laporan_Pendapatan.dtpTanggal1.Value, "dd-MM-yyyy"))
            objreportdoc.SetParameterValue("Tgl2", Format(Cetak_Laporan_Pendapatan.dtpTanggal2.Value, "dd-MM-yyyy"))
            'objRepDoc.SetParameterValue("staff", Mid(FrmLapPendapatan.ToolStripStatusLabel3.Text, 7, 30))
            objreportdoc.RecordSelectionFormula = "{laporanpendatan1.TanggalKwt} >= #" & Format(Cetak_Laporan_Pendapatan.dtpTanggal1.Value, "MM-dd-yyyy") & "# And {laporanpendatan1.TanggalKwt} <= #" & Format(Cetak_Laporan_Pendapatan.dtpTanggal2.Value, "MM-dd-yyyy") & "#"
        End If
        If IdCetakan = "10" Then
            objreportdoc = New CPasien
            objreportdoc.SetParameterValue("NomorPasien", Entry_Data_Pasien.txtNoPasien.Text)
            objreportdoc.RecordSelectionFormula = "{pasien1.no_pasien} = '" & Entry_Data_Pasien.txtNoPasien.Text & "'"
        End If
        If IdCetakan = "11" Then
            objreportdoc = New CLRekapObatYangSeringDipesan
            objreportdoc.SetParameterValue("Tgl1", Format(Cetak_Laporan_Rekapitulasi_Pemakaian_Obat.dtpTanggal1.Value, "dd-MM-yyyy"))
            objreportdoc.SetParameterValue("Tgl2", Format(Cetak_Laporan_Rekapitulasi_Pemakaian_Obat.dtpTanggal2.Value, "dd-MM-yyyy"))
            'objRepDoc.SetParameterValue("staff", Mid(FrmLapPendapatan.ToolStripStatusLabel3.Text, 7, 30))
            objreportdoc.RecordSelectionFormula = "{laporanrekap1.TanggalNota} >= #" & Format(Cetak_Laporan_Rekapitulasi_Pemakaian_Obat.dtpTanggal1.Value, "MM-dd-yyyy") & "# And {laporanrekap1.TanggalNota} <= #" & Format(Cetak_Laporan_Rekapitulasi_Pemakaian_Obat.dtpTanggal2.Value, "MM-dd-yyyy") & "#"
        End If
        CrystalReportViewer1.ReportSource = objreportdoc
    End Sub

    Private Sub TampilCetakan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class