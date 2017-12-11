Public Class Form_Asistan
    Private Sub Button_AsistanEkle_Click(sender As Object, e As EventArgs) Handles btnAsistanEkle.Click
        Dim a As New Asistan()
        a.AsistanAdi = tbAsistanAdi.Text
        a.Mail = tbAsistanMail.Text
        database.AsistanEkle(a)
    End Sub
End Class