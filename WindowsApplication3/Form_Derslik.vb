Public Class Form_Derslik
    Private Sub Button_DerslikOlustur_Click(sender As Object, e As EventArgs) Handles btnDerslikOlustur.Click
        Dim derslik As New Derslik
        If tbDerslikAdi.Text = "" Or tbDerslikKapasite.Text = "" Then
            MessageBox.Show("Alanlar boş geçilemez.")
            tbDerslikAdi.Clear()
            tbDerslikKapasite.Clear()
        Else
            derslik.DerslikAdi = tbDerslikAdi.Text
            derslik.Kapasite = Convert.ToInt32(tbDerslikKapasite.Text)
            database.DerslikEkle(derslik)
            MessageBox.Show("Başarıyla Eklendi.")
            tbDerslikAdi.Clear()
            tbDerslikKapasite.Clear()
        End If
    End Sub
End Class

