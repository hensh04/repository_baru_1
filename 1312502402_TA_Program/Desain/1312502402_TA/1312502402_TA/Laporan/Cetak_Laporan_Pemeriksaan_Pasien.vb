Public Class Cetak_Laporan_Pemeriksaan_Pasien

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        IdCetakan = "8"
        TampilCetakan.ShowDialog()
    End Sub
End Class