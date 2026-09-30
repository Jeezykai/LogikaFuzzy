Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Try
            Dim t1 As Double = Val(txtTugas1.Text)
            Dim t2 As Double = Val(txtTugas2.Text)
            Dim t3 As Double = Val(txtTugas3.Text)
            Dim t4 As Double = Val(txtTugas4.Text)
            Dim t5 As Double = Val(txtTugas5.Text)
            Dim uts As Double = Val(txtUTS.Text)
            Dim uas As Double = Val(txtUAS.Text)

            Dim totalTugas As Double = t1 + t2 + t3 + t4 + t5
            Dim rataTugas As Double = totalTugas / 5.0
            Dim kontribusiTugas As Double = rataTugas * 0.5
            Dim kontribusiUTS As Double = uts * 0.2
            Dim kontribusiUAS As Double = uas * 0.3
            Dim nilaiAkhir As Double = kontribusiTugas + kontribusiUTS + kontribusiUAS
            Dim kategori As String = Grade(nilaiAkhir)

            lblRataTugas.Text = $"Rata-Rata Tugas: {kontribusiTugas:F2}"
            lblNilaiAkhir.Text = $"Nilai Akhir: {nilaiAkhir:F2}"
            lblGrade.Text = $"Grade / Klasifikasi: {kategori}"

        Catch ex As Exception
            MessageBox.Show("Mohon masukkan input angka yang valid!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Function Grade(nilai As Double) As String
        If nilai >= 80.0 Then
            Return "A = Tinggi"
        ElseIf nilai >= 65.0 Then
            Return "B = Sedang"
        Else
            Return "C = Cukup"
        End If
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class