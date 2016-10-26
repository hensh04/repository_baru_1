Public Class Cetak_Laporan_Pemeriksaan_Pasien

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Dispose()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        If DateValue(dtpTanggal1.Value) > DateValue(dtpTanggal2.Value) Then
            MsgBox("Tanggal Awal Tidak Boleh Melebihi Tanggal Akhir", MsgBoxStyle.Exclamation, "WARNING")
            dtpTanggal1.Focus()
        Else
            'Dim tgl1 As Date = dtpTanggal1.Value.Date
            'Dim tgl2 As Date = dtpTanggal2.Value.Date
            IdCetakan = "8"
            TampilCetakan.ShowDialog()
        End If
    End Sub
End Class