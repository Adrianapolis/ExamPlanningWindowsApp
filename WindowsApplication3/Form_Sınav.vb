Imports System.IO
Imports System.Net
Imports System.Net.Mail
Public Class Form_Sınav

    Dim ogrenciSayisi As Integer
    Dim yerlestirilenOgrenciSayisi As Integer = 0
    Dim secilenSinifsayi As Integer = 0
    Dim listeOlusturucu As String
    Dim seciliSiniflar As New List(Of String)
    Dim Ogrenciler As New List(Of String)
    Shared random As New Random()
    Dim listeler As New List(Of SinifListeleri)

    Private Sub OgrenciListesiniOku()
        Dim sayac As Integer = -1   'öğrenci okumak için
        Dim oku As String 'satır satır okumak için kullanılan değişken
        Dim fs As FileStream 'dosyayı okumak için kullanılır
        Dim dosyaacici As New OpenFileDialog() 'windowsta dosya açmak için
        dosyaacici.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" 'yalnızca text dosyalarını açmak için
        If dosyaacici.ShowDialog = DialogResult.OK Then
            fs = New FileStream(dosyaacici.FileName, FileMode.Open)
            Dim sr As StreamReader = New StreamReader(fs, System.Text.Encoding.Default) 'fsten üretilmiş okumak için kullanılır

            Do
                oku = sr.ReadLine
                sayac = sayac + 1
                Ogrenciler.Add(oku)

                Try
                    RichTextBox1.AppendText(oku + vbNewLine) 'ilk okurken boş geldiği için try içine alındı
                Catch ex As Exception
                End Try

            Loop Until oku Is Nothing
            ogrenciSayisi = sayac
            fs.Close()
            'lblOgrenciSayisi.Text = ogrenciSayisi
            lblOgrenciSayisi.Text = "Öğrenci Sayısı : " + ogrenciSayisi.ToString
            lblError.Text = "Lütfen yukarıdan sınıf seçiniz."
            lblAcilanDosya.Text = "Açılan Dosya - " + dosyaacici.FileName
        End If
        'flSinifListele.l

    End Sub

    Private Sub Button_OgrListeSec_Click(sender As Object, e As EventArgs) Handles btnListeYukle.Click
        OgrenciListesiniOku()
    End Sub

    Private Sub Form_Sınav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbDersAdi.DataSource = database.DersAdiGetir()
        Dim siniflar As List(Of String) = database.DerslikGetir()
        For i As Integer = 0 To siniflar.Count - 1
            Dim cb As New CheckBox
            cb.Width = 80
            cb.Text = siniflar(i).ToString() + "-" + database.DerslikKapasiteGetir(siniflar(i)).ToString()
            cb.Name = siniflar(i).ToString()
            AddHandler cb.Click, AddressOf cb_click
            flSinifListele.Controls.Add(cb)
        Next
    End Sub

    Private Sub cb_click(sender As Object, e As EventArgs)
        Dim ulasilanDerslik As CheckBox = CType(sender, CheckBox)

        Dim SecilenSiniflarinKapasitesi = database.DerslikKapasiteGetir(ulasilanDerslik.Name)
        If ogrenciSayisi <= 0 Then
            lblError.Text = "Lütfen ilk önce öğrenci listesini yükleyiniz"
            ulasilanDerslik.Checked = False
        Else

            If ulasilanDerslik.Checked And yerlestirilenOgrenciSayisi < ogrenciSayisi Then

                yerlestirilenOgrenciSayisi = yerlestirilenOgrenciSayisi + SecilenSiniflarinKapasitesi
                secilenSinifsayi = secilenSinifsayi + 1
                lblError.Text = "Yeteri kadar sınıf seçildi"
                seciliSiniflar.Add(ulasilanDerslik.Name)

            ElseIf ulasilanDerslik.Checked = False Then

                yerlestirilenOgrenciSayisi = yerlestirilenOgrenciSayisi - SecilenSiniflarinKapasitesi
                secilenSinifsayi = secilenSinifsayi - 1
                seciliSiniflar.Remove(ulasilanDerslik.Name)

            ElseIf yerlestirilenOgrenciSayisi > ogrenciSayisi Then
                lblError.Text = "Sınıf Seçmek Gerekli"
                ulasilanDerslik.Checked = False

                ' If ulasilanderslik.Checked And kapasite - kap >= 0 Then
                'kapasite -= kap
                'ElseIf ulasilanderslik.Checked = False Then
                'kapasite += kap
                ' Else

                'Label3.Text = "Kapasite aştı"
                'ulasilanderslik.Checked = False
            End If
            'lblsnfsyi.Text = "Seçilen Sınıf Sayısı : " + secilenSinifsayi                    -----------\
            'lblyrlssayi.Text = "Yerleştirilen Öğrenci Sayısı : " + yerlestirilenOgrenciSayisi------------> "lblsclnsnf" gibi labeller pek hoş değildi :)
            'lblOgrenciSayisi1.Text = ogrenciSayisi.ToString()                                -----------/

            lblYerlestirilen.Text = "Yerleştirilen Öğrenci Sayısı : " + yerlestirilenOgrenciSayisi.ToString
            lblSecilenDerslikSayi.Text = "Seçilen Sınıf Sayısı : " + secilenSinifsayi.ToString
            lblOgrenciSayisi.Text = "Öğrenci Sayısı : " + ogrenciSayisi.ToString

        End If

    End Sub

    Private Sub btnSinavOlustur_Click(sender As Object, e As EventArgs) Handles btnSinavOlustur.Click

        'gereği kadar Liste objesi yaratılıyor
        For i As Integer = 0 To seciliSiniflar.Count - 1
            Dim gecici As New SinifListeleri
            Dim ogrenciSayisi As Integer = Ogrenciler.Count - 1
            gecici.PDersAdi = seciliSiniflar(i)
            gecici.PSinifKapasite = database.DerslikKapasiteGetir(seciliSiniflar(i).ToString())
            gecici.PbosSira = database.DerslikKapasiteGetir(seciliSiniflar(i).ToString())
            listeler.Add(gecici)
        Next
        'yaratılan liste objelerine öğrenciler atanıyor
        For i As Integer = 0 To ogrenciSayisi
            For j As Integer = 0 To seciliSiniflar.Count - 1
                If listeler(j).PbosSira > 0 Then
                    Dim OgrenciIndex As Integer = random.Next(Ogrenciler.Count)
                    If Ogrenciler.Count > 0 Then
                        If listeler(j).PbosSira > 0 Then
                            listeler(j).POgrenciler.Add(Ogrenciler(OgrenciIndex))
                            listeler(j).PbosSira -= 1
                            Ogrenciler.RemoveAt(OgrenciIndex)
                        End If
                    End If
                End If
            Next
        Next


    End Sub
End Class