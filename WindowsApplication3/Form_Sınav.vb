Imports System.IO
Imports System.Net
Imports System.Net.Mail
Public Class Form_Sınav

    Dim ogrenciSayisi As Integer
    Dim yerlestirilenOgrenciSayisi As Integer = 0
    Dim secilenSinifsayi As Integer = 0
    Dim listeOlusturucu As String
    Dim seciliSiniflar As New List(Of String)
    Dim seciliAsistanlar As New List(Of String)
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

                'Try
                '    RichTextBox1.AppendText(oku + vbNewLine) 'ilk okurken boş geldiği için try içine alındı
                'Catch ex As Exception
                'End Try

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
        Dim asistanlar As List(Of String) = database.AsistanListesiAl()
        For i As Integer = 0 To siniflar.Count - 1
            Dim cbSinif As New CheckBox
            'cbSinif.Width = 80
            cbSinif.Text = siniflar(i).ToString() + "-" + database.DerslikKapasiteGetir(siniflar(i)).ToString()
            cbSinif.Name = siniflar(i).ToString()
            AddHandler cbSinif.Click, AddressOf cbSinif_click
            flSinifListele.Controls.Add(cbSinif)
        Next
        For i As Integer = 0 To asistanlar.Count - 1
            Dim cbAsistan As New CheckBox
            'cbAsistan.Width = 80
            cbAsistan.Text = asistanlar(i).ToString()
            cbAsistan.Name = siniflar(i).ToString()
            AddHandler cbAsistan.Click, AddressOf cbAsistan_click
            flAsistanlar.Controls.Add(cbAsistan)
        Next
    End Sub

    Private Sub cbAsistan_click(sender As Object, e As EventArgs)
        Dim ulasilanAsistan As CheckBox = CType(sender, CheckBox)
        If ulasilanAsistan.Checked Then
            seciliAsistanlar.Add(ulasilanAsistan.Text)
        ElseIf ulasilanAsistan.Checked = False Then
            seciliAsistanlar.Remove(ulasilanAsistan.Text)
        End If
    End Sub

    Private Sub cbSinif_click(sender As Object, e As EventArgs)
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
            gecici.PSinifAdi = seciliSiniflar(i)
            gecici.PDersAdi = cbDersAdi.SelectedItem.ToString()
            gecici.PSinifKapasite = database.DerslikKapasiteGetir(seciliSiniflar(i).ToString())
            gecici.PbosSira = database.DerslikKapasiteGetir(seciliSiniflar(i).ToString())
            gecici.PSinavTur = cbSinavTuru.SelectedItem.ToString()
            gecici.PTarih = System.DateTime.Today
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
        For i As Integer = 0 To seciliSiniflar.Count - 1
            Dim asistanIndex As Integer = random.Next(seciliAsistanlar.Count)
            listeler(i).PAsistanAdi = seciliAsistanlar(asistanIndex)
            seciliAsistanlar.RemoveAt(asistanIndex)
        Next


    End Sub
End Class