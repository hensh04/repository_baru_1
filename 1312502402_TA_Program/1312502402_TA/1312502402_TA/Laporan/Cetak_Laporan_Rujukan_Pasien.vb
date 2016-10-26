Public Class Cetak_Laporan_Rujukan_Pasien

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        If DateValue(dtpTanggal1.Value) > DateValue(dtpTanggal2.Value) Then
            MsgBox("Tanggal Awal Tidak Boleh Melebihi Tanggal Akhir", MsgBoxStyle.Exclamation, "WARNING")
            dtpTanggal1.Focus()
        Else
            IdCetakan = "5"
            TampilCetakan.ShowDialog()
        End If
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Dispose()
    End Sub

    Private Sub Cetak_Laporan_Rujukan_Pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class