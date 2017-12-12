Public Class SinifListeleri
    Dim SinifAdi As String
    Dim SinifKapasite As Integer
    Dim DersAdi As String
    Dim AsistanAdi As String
    Dim Tarih As Date
    Dim SinavTur As String
    Dim Ogrenciler As List(Of String)

    Public Property PSinifAdi() As String
        Get
            Return SinifAdi
        End Get
        Set(ByVal value As String)
            SinifAdi = value
        End Set
    End Property
    Public Property PSinifKapasite() As Integer
        Get
            Return SinifKapasite
        End Get
        Set(ByVal value As Integer)
            SinifKapasite = value
        End Set
    End Property
    Public Property PDersAdi() As String
        Get
            Return DersAdi
        End Get
        Set(ByVal value As String)
            DersAdi = value
        End Set
    End Property
    Public Property PAsistanAdi() As String
        Get
            Return AsistanAdi
        End Get
        Set(ByVal value As String)
            AsistanAdi = value
        End Set
    End Property
    Public Property PTarih() As Date
        Get
            Return Tarih
        End Get
        Set(ByVal value As Date)
            Tarih = value
        End Set
    End Property
    Public Property PSinavTur() As String
        Get
            Return SinavTur
        End Get
        Set(ByVal value As String)
            SinavTur = value
        End Set
    End Property
    Public Property POgrenciler() As List(Of String)
        Get
            Return Ogrenciler
        End Get
        Set(ByVal value As List(Of String))
            Ogrenciler = value
        End Set
    End Property

End Class
