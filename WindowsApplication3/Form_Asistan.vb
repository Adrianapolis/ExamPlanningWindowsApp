Public Class Form_Asistan
    Private Sub Button_AsistanEkle_Click(sender As Object, e As EventArgs) Handles btnAsistanEkle.Click
        Dim a As New Asistan()
        If tbAsistanAdi.Text = "" Or tbAsistanMail.Text = "" Then
            MessageBox.Show("Alanlar boş geçilemez.")
            tbAsistanAdi.Clear()
            tbAsistanMail.Clear()
        Else
            a.AsistanAdi = tbAsistanAdi.Text
            a.Mail = tbAsistanMail.Text
            database.AsistanEkle(a)
            MessageBox.Show("Başarıyla Eklendi.")
            tbAsistanAdi.Clear()
            tbAsistanMail.Clear()
        End If
    End Sub
End Class