Public Class Form_Ders
    Private Sub Button_DersEkle_Click(sender As Object, e As EventArgs) Handles btnDersEkle.Click
        Dim ders As New Dersler
        If tbDersAdi.Text = "" Or tbDersKodu.Text = "" Then
            MessageBox.Show("Alanlar boş geçilemez.")
            tbDersAdi.Clear()
            tbDersKodu.Clear()
        Else
            ders.DersAdi = tbDersAdi.Text
            ders.DersKodu = tbDersKodu.Text
            database.DersEkle(ders)
            MessageBox.Show("Başarıyla Eklendi.")
            tbDersAdi.Clear()
            tbDersKodu.Clear()

        End If
    End Sub
End Class