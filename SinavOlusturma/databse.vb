
Public Class database
    Shared vt As New GorselDBEntities1
    'Asistan
    Public Shared Sub AsistanEkle(ByVal asistan As Asistan)
        vt.Asistan.Add(asistan)
        vt.SaveChanges()
    End Sub
    Public Shared Function AsistanListesiAl()
        Return vt.Asistan.Select(Function(x) x.AsistanAdi).ToList()
    End Function
    Public Shared Function AsistanGrid()
        Return (From x In vt.Asistan
                Select New With {x.AsistanAdi, x.Mail}).OrderBy(Function(x) x.AsistanAdi).ToList()
    End Function
    Public Shared Sub AsistanSil(ByVal Asistan As String)
        Dim silinecek As Asistan = vt.Asistan.Where(Function(x) x.AsistanAdi = Asistan).FirstOrDefault()
        vt.Asistan.Remove(silinecek)
        vt.SaveChanges()
    End Sub
    'Ders
    Public Shared Sub DersEkle(ByVal ders As Dersler)
        vt.Dersler.Add(ders)
        vt.SaveChanges()
    End Sub
    Public Shared Function DersAdiGetir()
        Return vt.Dersler.Select(Function(x) x.DersAdi).ToArray()
    End Function
    Public Shared Function DersGrid()
        Return (From x In vt.Dersler
                Select New With {x.DersKodu, x.DersAdi}).OrderBy(Function(x) x.DersKodu).ToList()
    End Function
    Public Shared Sub DersSil(ByVal Ders As String)
        Dim silinecek As Dersler = vt.Dersler.Where(Function(x) x.DersKodu = Ders).FirstOrDefault()
        vt.Dersler.Remove(silinecek)
        vt.SaveChanges()
    End Sub

    'Derslik
    Public Shared Sub DerslikEkle(ByVal derslik As Derslik)
        vt.Derslik.Add(derslik)
        vt.SaveChanges()
    End Sub
    Public Shared Function DerslikKapasiteGetir(ByVal ArananDerslik As String)
        Return vt.Derslik.Where(Function(x) x.DerslikAdi = ArananDerslik).Select(Function(y) y.Kapasite).FirstOrDefault()
    End Function
    Public Shared Function DerslikGetir()
        Return vt.Derslik.Select(Function(x) x.DerslikAdi).ToList()
    End Function
    Public Shared Function DerslikGrid()
        Return (From x In vt.Derslik
                Select New With {x.DerslikAdi, x.Kapasite}).OrderBy(Function(x) x.DerslikAdi).ToList()
    End Function
    Public Shared Sub DerslikSil(ByVal Derslik As String)
        Dim silinecek As Derslik = vt.Derslik.Where(Function(x) x.DerslikAdi = Derslik).FirstOrDefault()
        vt.Derslik.Remove(silinecek)
        vt.SaveChanges()
    End Sub
    'ogrenci
    Public Shared Sub ogrenciListesiEkle(ByVal SinavListesi As Liste)
        vt.Liste.Add(SinavListesi)
        vt.SaveChanges()

    End Sub

    'donem
    Public Shared Function DonemGetir()
        Return vt.Donem.Select(Function(x) x.DonemAdi).ToList()
    End Function


End Class
