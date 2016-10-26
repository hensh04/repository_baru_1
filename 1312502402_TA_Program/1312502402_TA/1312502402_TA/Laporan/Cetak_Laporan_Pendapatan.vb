Public Class Cetak_Laporan_Pendapatan

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Dispose()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        If DateValue(dtpTanggal1.Value) > DateValue(dtpTanggal2.Value) Then
            MsgBox("Tanggal Awal Tidak Boleh Melebihi Tanggal Akhir", MsgBoxStyle.Exclamation, "WARNING")
            dtpTanggal1.Focus()
        Else
            IdCetakan = "9"
            TampilCetakan.ShowDialog()
        End If
    End Sub

    '    Private Sub dtpTanggal2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTanggal2.KeyPress
    '    If Asc(e.KeyChar) = 13 Then
    '        Dim tgl1 As Date = dtpTanggal1.Value.Date
    '        Dim tgl2 As Date = dtpTanggal2.Value.Date

    '        IdCetakan = "9"
    '        TampilCetakan.ShowDialog()
    '    End If
    'End Sub
End Class