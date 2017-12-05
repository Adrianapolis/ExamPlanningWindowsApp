Public Class Form_AnaSayfa
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'POP-UP AÇMAK İÇİN'
    'Dim secim As Char

    Private Sub Button_Sinif_Click(sender As Object, e As EventArgs) Handles Button_Sinif.Click
        Label1.Hide()

        GroupBox1.Visible = True
        GroupBox1.Text = Button_Sinif.Text
        'secim = "sinif"
    End Sub

    Private Sub Button_Asistan_Click(sender As Object, e As EventArgs) Handles Button_Asistan.Click
        Label1.Hide()
        GroupBox1.Visible = True
        GroupBox1.Text = Button_Asistan.Text
        'secim = "asistan"
    End Sub

    Private Sub Button_Sinav_Click(sender As Object, e As EventArgs) Handles Button_Sinav.Click
        Label1.Hide()
        GroupBox1.Visible = True
        GroupBox1.Text = Button_Sinav.Text
        'secim = "sinav"

    End Sub

    Private Sub Button_Ders_Click(sender As Object, e As EventArgs) Handles Button_Ders.Click
        Label1.Hide()
        GroupBox1.Visible = True
        GroupBox1.Text = Button_Ders.Text
        'secim = "ders"

    End Sub

    Private Sub Button_Hoca_Click(sender As Object, e As EventArgs) Handles Button_Hoca.Click
        Label1.Hide()
        GroupBox1.Visible = True
        GroupBox1.Text = Button_Hoca.Text
        'secim = "hoca"

    End Sub

    Private Sub Button_YeniKayit_Click(sender As Object, e As EventArgs) Handles Button_YeniKayit.Click
        'POP-UP AÇMAK İÇİN'
        'Select Case secim
        '    Case "sinav"
        '        Dim MyForm As New Form_Sınav
        '        MyForm.ShowDialog()
        '    Case "sinif"
        '        Dim MyForm As New Form_Ders
        '        MyForm.ShowDialog()

        '    Case Else

        'End Select

    End Sub


End Class
