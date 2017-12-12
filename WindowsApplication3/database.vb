Public Class database
    Shared vt As New GorselDBEntities
    Public Shared Sub AsistanEkle(ByVal asistan As Asistan)
        vt.Asistan.Add(asistan)
        vt.SaveChanges()
    End Sub
    Public Shared Function AsistanListesiAl()
        Return vt.Asistan.Select(Function(x) x.AsistanAdi).ToList()
    End Function
    Public Shared Sub DersEkle(ByVal ders As Dersler)
        vt.Dersler.Add(ders)
        vt.SaveChanges()
    End Sub
    Public Shared Sub DerslikEkle(ByVal derslik As Derslik)
        vt.Derslik.Add(derslik)
        vt.SaveChanges()
    End Sub
    Public Shared Function DersAdiGetir()
        Return vt.Dersler.Select(Function(x) x.DersAdi).ToArray()
    End Function
    Public Shared Function DerslikKapasiteGetir(ByVal ArananDerslik As String)
        Return vt.Derslik.Where(Function(x) x.DerslikAdi = ArananDerslik).Select(Function(y) y.Kapasite).FirstOrDefault()
    End Function
    Public Shared Function DerslikGetir()
        Return vt.Derslik.Select(Function(x) x.DerslikAdi).ToList()
    End Function
End Class
