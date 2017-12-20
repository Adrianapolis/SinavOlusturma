Imports System.IO
Imports System.Text
Public Class AnaEkranForm
    Dim ogrenciSayisi As Integer
    Dim yerlestirilenOgrenciSayisi As Integer = 0
    Dim secilenSinifsayi As Integer = 0
    Dim secilenAsistanSayi As Integer = 0
    Dim listeOlusturucu As String
    Dim seciliSiniflar As New List(Of String)
    Dim seciliAsistanlar As New List(Of String)
    Dim Ogrenciler As New List(Of String)
    Shared random As New Random()
    Dim listeler As New List(Of SinifListeleri)
    Private Function ogrenciListesiOlustur(ByVal SiniftakiOgrenciler As List(Of String))

        Dim liste As New StringBuilder
        For i As Integer = 0 To SiniftakiOgrenciler.Count - 1
            liste.Append(SiniftakiOgrenciler(i) & ";")
        Next
        Return liste
    End Function

    Private Sub OgrenciListesiniOku()
        Dim dosyaacici As New OpenFileDialog() 'windowsta dosya açmak için
        dosyaacici.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" 'yalnızca text dosyalarını açmak için
        If dosyaacici.ShowDialog = DialogResult.OK Then
            Ogrenciler = File.ReadAllLines(dosyaacici.FileName, Encoding.Default).ToList()
            ogrenciSayisi = Ogrenciler.Count
            'lblOgrenciSayisi.Text = ogrenciSayisi
            'lblOgrenciSayisi.Text = "Öğrenci Sayısı : " + ogrenciSayisi.ToString
            'lblError.Text = "Lütfen yukarıdan sınıf seçiniz."
            'lblAcilanDosya.Text = "Açılan Dosya - " + dosyaacici.FileName
        End If
        'flSinifListele.l
        LbOgrenciYerlestirilecekSayi.Text = ogrenciSayisi
        LbOgrenciSayiGoster.Text = ogrenciSayisi

    End Sub
    Private Sub cbAsistan_click(sender As Object, e As EventArgs)
        Dim ulasilanAsistan As CheckBox = CType(sender, CheckBox)
        If secilenSinifsayi < 1 Then
            'lblerror.text = "Lütfen İlk Önce Sinif Seçiniz"
            ulasilanAsistan.Checked = False
        Else
            If ulasilanAsistan.Checked And secilenAsistanSayi < secilenSinifsayi Then
                seciliAsistanlar.Add(ulasilanAsistan.Text)
                secilenAsistanSayi = secilenAsistanSayi + 1
            ElseIf ulasilanAsistan.Checked = False Then
                seciliAsistanlar.Remove(ulasilanAsistan.Text)
                secilenAsistanSayi = secilenAsistanSayi - 1
            ElseIf secilenAsistanSayi >= secilenSinifsayi Then
                ulasilanAsistan.Checked = False
            End If
        End If
    End Sub

    Private Sub cbSinif_click(sender As Object, e As EventArgs)
        Dim ulasilanDerslik As CheckBox = CType(sender, CheckBox)

        Dim SecilenSiniflarinKapasitesi = database.DerslikKapasiteGetir(ulasilanDerslik.Name)
        If ogrenciSayisi <= 0 Then
            'lblError.Text = "Lütfen ilk önce öğrenci listesini yükleyiniz"
            ulasilanDerslik.Checked = False
        Else

            If ulasilanDerslik.Checked And yerlestirilenOgrenciSayisi < ogrenciSayisi Then

                yerlestirilenOgrenciSayisi = yerlestirilenOgrenciSayisi + SecilenSiniflarinKapasitesi
                secilenSinifsayi = secilenSinifsayi + 1
                'lblError.Text = "Yeteri kadar sınıf seçildi"
                seciliSiniflar.Add(ulasilanDerslik.Name)

            ElseIf ulasilanDerslik.Checked = False Then

                yerlestirilenOgrenciSayisi = yerlestirilenOgrenciSayisi - SecilenSiniflarinKapasitesi
                secilenSinifsayi = secilenSinifsayi - 1
                seciliSiniflar.Remove(ulasilanDerslik.Name)

            ElseIf yerlestirilenOgrenciSayisi > ogrenciSayisi Then
                'lblError.Text = "Sınıf Seçmek Gerekli"
                ulasilanDerslik.Checked = False
            End If


        End If
        If (yerlestirilenOgrenciSayisi < 0) Then
            LbOgrenciYerlestirilecekSayi.Text = 0
        Else
            LbOgrenciYerlestirilecekSayi.Text = yerlestirilenOgrenciSayisi
        End If

        Dim liste As New StringBuilder
        For i As Integer = 0 To Ogrenciler.Count - 1
            liste.Append(Ogrenciler(i) & ";")
        Next
        Dim listeStr = liste.ToString()
        Dim x(1) As Char
        x(0) = ";"
        Dim y As List(Of String) = listeStr.Split(x).ToList()
    End Sub


    Private Sub BtnYeniSinav_Click(sender As Object, e As EventArgs) Handles BtnYeniSinav.Click
        GbAnaSayfa.Visible = False
        GbMevcudatDuzenle.Visible = False
        GbYeniSinavOlustur.Visible = True
        GbYeniSinavOlustur.Top = (Me.ClientSize.Height / 2) - (GbYeniSinavOlustur.Height / 2)
        GbYeniSinavOlustur.Left = (Me.ClientSize.Width / 2) - (GbYeniSinavOlustur.Width / 2)
    End Sub

    Private Sub BtnSinavOlustur_Click(sender As Object, e As EventArgs) Handles BtnSinavOlustur.Click
        GbAnaSayfa.Visible = True
        GbYeniSinavOlustur.Visible = False

        'gereği kadar Liste objesi yaratılıyor
        For i As Integer = 0 To seciliSiniflar.Count - 1
            Dim gecici As New SinifListeleri
            Dim ogrenciSayisi As Integer = Ogrenciler.Count - 1
            gecici.PSinifAdi = seciliSiniflar(i)
            gecici.PDersAdi = CbDersSecim.SelectedItem.ToString()
            gecici.PSinifKapasite = database.DerslikKapasiteGetir(seciliSiniflar(i).ToString())
            gecici.PbosSira = database.DerslikKapasiteGetir(seciliSiniflar(i).ToString())
            gecici.PSinavTur = CbTurSecim.SelectedItem.ToString()
            gecici.PTarih = DateTimePicker1.Value
            gecici.PDonem = cbDonemSec.SelectedItem.ToString()
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
                            If listeler(j).POgrenciler.Contains(Nothing) Then
                                Dim a As Integer = 10
                            End If
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

        'Dim liste As New StringBuilder
        'For i As Integer = 0 To Ogrenciler.Count - 1
        '    liste.Append(Ogrenciler(i) & ";")
        'Next
        'Dim listeStr = liste.ToString()
        'Dim x(1) As Char
        'x(0) = ";"
        'Dim y As List(Of String) = listeStr.Split(x).ToList()


        Dim OlusturulanSinav As New Sinav
        OlusturulanSinav.DersKodu = database.DersKoduGetir(listeler(0).PDersAdi)
        OlusturulanSinav.DonemID = database.DonemIDGetir(listeler(0).PDonem)

        'LİSTE 0 IN SINAV İLE İLGİLİ OLAN KISIMLARINI AT
        'EKLENEN SINAVIN IDSİNİ ELDE ET



        For i As Integer = 0 To seciliSiniflar.Count - 1
            Dim dbEklenecekListe As New Liste
            'dbEklenecekListe.SinavID
            'dbEklenecekListe.OgrString = ogrenciListesiOlustur(listeler(i).POgrenciler)
            'dbEklenecekListe.Sinav.Dersler.DersAdi = listeler(i).PDersAdi
            'dbEklenecekListe.Sinav.SinavTuru = listeler(i).PSinavTur
            'dbEklenecekListe.Sinav.Yillar.Yil = listeler(i).PTarih.ToString()
            'dbEklenecekListe.Asistan.AsistanAdi = listeler(i).PAsistanAdi
            'dbEklenecekListe.Derslik.DerslikAdi = listeler(i).PDersAdi
            'database.ogrenciListesiEkle(dbEklenecekListe)
        Next

        MessageBox.Show("İşleminiz başarı ile gerçekleştirildi")
    End Sub

    Private Sub MevcudatDuzenle_Click(sender As Object, e As EventArgs) Handles BtnMevcudat.Click
        GbAnaSayfa.Visible = False
        GbMevcudatDuzenle.Visible = True
        GbYeniSinavOlustur.Visible = False
        GbMevcudatDuzenle.Top = (Me.ClientSize.Height / 2) - (GbMevcudatDuzenle.Height / 2)
        GbMevcudatDuzenle.Left = (Me.ClientSize.Width / 2) - (GbMevcudatDuzenle.Width / 2)
    End Sub

    Private Sub BtnMevcudatGeri_Click(sender As Object, e As EventArgs) Handles BtnMevcudatGeri.Click
        GbAnaSayfa.Visible = True
        GbMevcudatDuzenle.Visible = False
    End Sub

    Private Sub AnaEkranForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = DateTime.Now
        Me.WindowState = FormWindowState.Maximized
        GbAnaSayfa.Top = (Me.ClientSize.Height / 2) - (GbAnaSayfa.Height / 2)
        GbAnaSayfa.Left = (Me.ClientSize.Width / 2) - (GbAnaSayfa.Width / 2)
        CbDersSecim.DataSource = database.DersAdiGetir()
        cbDonemSec.DataSource = database.DonemGetir()
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

    Private Sub BtnDerslikDuzenleme_Click(sender As Object, e As EventArgs) Handles BtnDerslikDuzenleme.Click
        System.IO.File.WriteAllText("status", "")
        Dim wr As New StreamWriter("status")
        wr.WriteLine(1)
        wr.WriteLine(1)
        wr.Close()

        Dim MevcutEklemeForm As MevcutEklemeForm
        MevcutEklemeForm = New MevcutEklemeForm
        MevcutEklemeForm.Show()

    End Sub

    Private Sub BtnDersDuzenleme_Click(sender As Object, e As EventArgs) Handles BtnDersDuzenleme.Click
        System.IO.File.WriteAllText("status", "")
        Dim wr As New StreamWriter("status")
        wr.WriteLine(1)
        wr.WriteLine(0)
        wr.Close()

        Dim MevcutEklemeForm As MevcutEklemeForm
        MevcutEklemeForm = New MevcutEklemeForm
        MevcutEklemeForm.Show()
    End Sub

    Private Sub BtnAsistanDuzenleme_Click(sender As Object, e As EventArgs) Handles BtnAsistanDuzenleme.Click
        System.IO.File.WriteAllText("status", "")
        Dim wr As New StreamWriter("status")
        wr.WriteLine(1)
        wr.WriteLine(2)
        wr.Close()

        Dim MevcutEklemeForm As MevcutEklemeForm
        MevcutEklemeForm = New MevcutEklemeForm
        MevcutEklemeForm.Show()
    End Sub

    Private Sub BtnSinavIptal_Click(sender As Object, e As EventArgs) Handles BtnSinavIptal.Click
        Dim result As Integer = MessageBox.Show("İptal etmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            GbAnaSayfa.Visible = True
            GbYeniSinavOlustur.Visible = False
        End If
    End Sub

    Private Sub btnListeEkle_Click(sender As Object, e As EventArgs) Handles btnListeEkle.Click
        OgrenciListesiniOku()
    End Sub

    Private Sub GbYeniSinavOlustur_Enter(sender As Object, e As EventArgs) Handles GbYeniSinavOlustur.Enter

    End Sub



    'Dim result As Integer = MessageBox.Show("İptal etmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo)
    'If result = DialogResult.No Then
    ''MessageBox.Show("No pressed")
    'ElseIf result = DialogResult.Yes Then
    '        GbAnaSayfa.Visible = True
    '        GbYeniSinavOlustur.Visible = False
    '    End If

End Class