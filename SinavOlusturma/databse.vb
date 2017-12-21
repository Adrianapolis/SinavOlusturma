Imports System.Text
Imports System.Data.Entity.Validation

Public Class database
    Shared vt As New gorseldbEntities
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
    Public Shared Function AsistanIDGetir(ByVal arananAsistanAdi As String)
        Return vt.Asistan.Where(Function(x) x.AsistanAdi = arananAsistanAdi).Select(Function(x) x.AsistanID).FirstOrDefault
    End Function
    Public Shared Function AsistanMailGetir(ByVal arananAsistanAdi As String)
        Return vt.Asistan.Where(Function(x) x.AsistanAdi = arananAsistanAdi).Select(Function(x) x.Mail).FirstOrDefault
    End Function

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
                Select New With {x.DersAdi, x.DersKodu}).OrderBy(Function(x) x.DersKodu).ToList()
    End Function
    Public Shared Sub DersSil(ByVal Ders As String)
        Dim silinecek As Dersler = vt.Dersler.Where(Function(x) x.DersKodu = Ders).FirstOrDefault()
        vt.Dersler.Remove(silinecek)
        vt.SaveChanges()
    End Sub
    Public Shared Function DersKoduGetir(ByVal ArananDersAdi As String)
        Return vt.Dersler.Where(Function(x) x.DersAdi = ArananDersAdi).Select(Function(x) x.DersKodu).FirstOrDefault()
    End Function


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
    Public Shared Function derslikIDGetir(ByVal arananDerslikAdi As String)
        Return vt.Derslik.Where(Function(x) x.DerslikAdi = arananDerslikAdi).Select(Function(x) x.DerslikID).FirstOrDefault
    End Function


    'donem
    Public Shared Function DonemGetir()
        Return vt.Donem.Select(Function(x) x.DonemAdi).ToList()
    End Function
    Public Shared Function DonemIDGetir(ByVal arananDonemAdi As String)
        Return vt.Donem.Where(Function(x) x.DonemAdi = arananDonemAdi).Select(Function(x) x.DonemID).FirstOrDefault()
    End Function
    'tarih
    Public Shared Sub TarihEkle(ByVal eklenecekTarih As Tarihler)
        vt.Tarihler.Add(eklenecekTarih)
        vt.SaveChanges()
    End Sub
    Public Shared Function TarihIDGetir(ByVal ArananTarih As Date)
        Dim tarih As New Tarihler
        tarih.TarihID = vt.Tarihler.Where(Function(x) x.Tarih = ArananTarih).Select(Function(x) x.TarihID).FirstOrDefault

        If tarih.TarihID = Nothing Then
            Dim yeniTarih As New Tarihler
            yeniTarih.Tarih = ArananTarih
            vt.Tarihler.Add(yeniTarih)
            vt.SaveChanges()
            tarih.TarihID = vt.Tarihler.Where(Function(x) x.Tarih = ArananTarih).Select(Function(x) x.TarihID).FirstOrDefault
        End If
        Return tarih.TarihID
    End Function

    'sınav
    Public Shared Sub SinavEkle(ByVal EklenecekSinav As Sinav)
        vt.Sinav.Add(EklenecekSinav)
        vt.SaveChanges()
    End Sub
    Public Shared Function SinavIDGetir(ByVal gelenDersKodu As String, ByVal gelentarih As Integer)
        Return vt.Sinav.Where(Function(x) x.DersKodu = gelenDersKodu And x.TarihID = gelentarih).Select(Function(x) x.SinavID).FirstOrDefault()
    End Function
    'liste
    Public Shared Sub ListeEkle(ByVal EklenecekListe As Liste)
        vt.Liste.Add(EklenecekListe)
        vt.SaveChanges()
    End Sub


End Class
