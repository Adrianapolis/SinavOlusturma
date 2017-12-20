Imports System.Text
Imports System.Data.Entity.Validation

Public Class database
    Shared vt As New GorselDBEntities1
    'Asistan
    Public Shared Sub AsistanEkle(ByVal asistan As Asistan)
        vt.Asistans.Add(asistan)
        vt.SaveChanges()
    End Sub
    Public Shared Function AsistanListesiAl()
        Return vt.Asistans.Select(Function(x) x.AsistanAdi).ToList()
    End Function
    Public Shared Function AsistanGrid()
        Return (From x In vt.Asistans
                Select New With {x.AsistanAdi, x.Mail}).OrderBy(Function(x) x.AsistanAdi).ToList()
    End Function
    Public Shared Sub AsistanSil(ByVal Asistan As String)
        Dim silinecek As Asistan = vt.Asistans.Where(Function(x) x.AsistanAdi = Asistan).FirstOrDefault()
        vt.Asistans.Remove(silinecek)
        vt.SaveChanges()
    End Sub
    Public Shared Function AsistanIDGetir(ByVal arananAsistanAdi As String)
        Return vt.Asistans.Where(Function(x) x.AsistanAdi = arananAsistanAdi).Select(Function(x) x.AsistanID).FirstOrDefault
    End Function


    'Ders
    Public Shared Sub DersEkle(ByVal ders As Dersler)
        vt.Derslers.Add(ders)
        vt.SaveChanges()
    End Sub
    Public Shared Function DersAdiGetir()
        Return vt.Derslers.Select(Function(x) x.DersAdi).ToArray()
    End Function
    Public Shared Function DersGrid()
        Return (From x In vt.Derslers
                Select New With {x.DersAdi, x.DersKodu}).OrderBy(Function(x) x.DersKodu).ToList()
    End Function
    Public Shared Sub DersSil(ByVal Ders As String)
        Dim silinecek As Dersler = vt.Derslers.Where(Function(x) x.DersKodu = Ders).FirstOrDefault()
        vt.Derslers.Remove(silinecek)
        vt.SaveChanges()
    End Sub
    Public Shared Function DersKoduGetir(ByVal ArananDersAdi As String)
        Return vt.Derslers.Where(Function(x) x.DersAdi = ArananDersAdi).Select(Function(x) x.DersKodu).FirstOrDefault()
    End Function

    'Derslik
    Public Shared Sub DerslikEkle(ByVal derslik As Derslik)
        vt.Dersliks.Add(derslik)
        vt.SaveChanges()
    End Sub
    Public Shared Function DerslikKapasiteGetir(ByVal ArananDerslik As String)
        Return vt.Dersliks.Where(Function(x) x.DerslikAdi = ArananDerslik).Select(Function(y) y.Kapasite).FirstOrDefault()
    End Function
    Public Shared Function DerslikGetir()
        Return vt.Dersliks.Select(Function(x) x.DerslikAdi).ToList()
    End Function
    Public Shared Function DerslikGrid()
        Return (From x In vt.Dersliks
                Select New With {x.DerslikAdi, x.Kapasite}).OrderBy(Function(x) x.DerslikAdi).ToList()
    End Function
    Public Shared Sub DerslikSil(ByVal Derslik As String)
        Dim silinecek As Derslik = vt.Dersliks.Where(Function(x) x.DerslikAdi = Derslik).FirstOrDefault()
        vt.Dersliks.Remove(silinecek)
        vt.SaveChanges()
    End Sub
    Public Shared Function derslikIDGetir(ByVal arananDerslikAdi As String)
        Return vt.Dersliks.Where(Function(x) x.DerslikAdi = arananDerslikAdi).Select(Function(x) x.DerslikID).FirstOrDefault
    End Function


    'donem
    Public Shared Function DonemGetir()
        Return vt.Donems.Select(Function(x) x.DonemAdi).ToList()
    End Function
    Public Shared Function DonemIDGetir(ByVal arananDonemAdi As String)
        Return vt.Donems.Where(Function(x) x.DonemAdi = arananDonemAdi).Select(Function(x) x.DonemID).FirstOrDefault()
    End Function
    'tarih
    Public Shared Sub TarihEkle(ByVal eklenecekTarih As Tarihler)
        vt.Tarihlers.Add(eklenecekTarih)
        vt.SaveChanges()
    End Sub
    Public Shared Function TarihIDGetir(ByVal ArananTarih As Date)
        Dim tarih As New Tarihler
        tarih.TarihID = vt.Tarihlers.Where(Function(x) x.Tarih = ArananTarih).Select(Function(x) x.TarihID).FirstOrDefault

        If tarih.TarihID = Nothing Then
            Dim yeniTarih As New Tarihler
            yeniTarih.Tarih = ArananTarih
            vt.Tarihlers.Add(yeniTarih)
            vt.SaveChanges()
            tarih.TarihID = vt.Tarihlers.Where(Function(x) x.Tarih = ArananTarih).Select(Function(x) x.TarihID).FirstOrDefault
        End If
        Return tarih.TarihID
    End Function

    'sınav
    Public Shared Sub SinavEkle(ByVal EklenecekSinav As Sinav)
        vt.Sinavs.Add(EklenecekSinav)
        vt.SaveChanges()
    End Sub
    Public Shared Function SinavIDGetir(ByVal gelenDersKodu As String, ByVal gelentarih As Integer)
        Return vt.Sinavs.Where(Function(x) x.DersKodu = gelenDersKodu And x.TarihID = gelentarih).Select(Function(x) x.SinavID).FirstOrDefault()
    End Function
    'liste
    Public Shared Sub ListeEkle(ByVal EklenecekListe As Liste)
        vt.Listes.Add(EklenecekListe)
        'vt.SaveChanges()

        Try
            vt.SaveChanges()

        Catch ex As DbEntityValidationException

            Dim msg As New StringBuilder
            msg.AppendLine(ex.Message)

            For Each vr As DbEntityValidationResult In ex.EntityValidationErrors
                For Each ve As DbValidationError In vr.ValidationErrors
                    msg.AppendLine(String.Format("{0}: {1}", ve.PropertyName, ve.ErrorMessage))
                Next
            Next

            Throw New DbEntityValidationException(msg.ToString, ex.EntityValidationErrors, ex)

        End Try


    End Sub


End Class
