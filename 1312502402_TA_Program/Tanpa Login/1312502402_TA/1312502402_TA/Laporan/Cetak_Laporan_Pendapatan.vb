Public Class Cetak_Laporan_Pendapatan

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        IdCetakan = "9"
        TampilCetakan.ShowDialog()
    End Sub
End Class