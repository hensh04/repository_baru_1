Public Class Cetak_Laporan_Resep

    Private Sub Cetak_Laporan_Resep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        IdCetakan = "7"
        TampilCetakan.ShowDialog()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class