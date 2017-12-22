Imports System.IO
Imports System.Text
Imports System.Drawing.Text
Imports System.Net
Imports System.Net.Mail

Public Class AnaEkranForm
    Dim ogrenciSayisi As Integer
    Dim yerlestirilenOgrenciSayisi As Integer = 0
    Dim kalanogrencisayisi As Integer = 0
    Dim secilenSinifsayi As Integer = 0
    Dim secilenAsistanSayi As Integer = 0
    Dim secilmesiGerekenAsistanSayi As Integer = 0
    Dim listeOlusturucu As String
    Dim seciliSiniflar As New List(Of String)
    Dim seciliAsistanlar As New List(Of String)
    Dim Ogrenciler As New List(Of String)
    Shared random As New Random()
    Dim listeler As New List(Of SinifListeleri)

    Private Sub AsistanVeSinifGüncelle()
        Dim siniflar As List(Of String) = database.DerslikGetir()
        Dim asistanlar As List(Of String) = database.AsistanListesiAl()
        flAsistanlar.Controls.Clear()
        flSinifListele.Controls.Clear()
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
            AddHandler cbAsistan.Click, AddressOf cbAsistan_click
            flAsistanlar.Controls.Add(cbAsistan)
        Next
    End Sub

    Private Sub resimYukle()
        BackColor = Color.FromArgb(249, 249, 249)
        dgAnaSayfa.BackgroundColor = Color.FromArgb(249, 249, 249)
        'mevcudat gb
        BtnDersDuzenleme.BackgroundImage = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "ders.png")
        BtnDersDuzenleme.BackgroundImageLayout = ImageLayout.Stretch
        BtnAsistanDuzenleme.BackgroundImage = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "asistan.png")
        BtnAsistanDuzenleme.BackgroundImageLayout = ImageLayout.Stretch
        BtnDerslikDuzenleme.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "derslik.png")
        BtnDerslikDuzenleme.BackgroundImageLayout = ImageLayout.Stretch
        BtnMevcudatGeri.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "solOk.png")
        BtnMevcudatGeri.BackgroundImageLayout = ImageLayout.Stretch

        'anasayfa gb
        BtnYeniSinav.BackgroundImage = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "ekle.png")
        BtnYeniSinav.BackgroundImageLayout = ImageLayout.Stretch
        BtnMevcudat.BackgroundImage = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "düzenle.png")
        BtnMevcudat.BackgroundImageLayout = ImageLayout.Stretch
        'BtnMailGonder.BackgroundImage = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "mail.png")
        'BtnMailGonder.BackgroundImageLayout = ImageLayout.Stretch

        'yenisinav oluştur gb
        BtnSinavOlustur.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "ekle.png")
        BtnSinavOlustur.BackgroundImageLayout = ImageLayout.Stretch
        BtnSinavIptal.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "çarpı.png")
        BtnSinavIptal.BackgroundImageLayout = ImageLayout.Stretch

    End Sub


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
        End If
        'flSinifListele.l
        LbAcilanDosya.Text = " Açılan liste dosyası : " + System.IO.Path.GetFileName(dosyaacici.FileName)
        LbOgrenciYerlestirilecekSayi.Text = ogrenciSayisi
        LbOgrenciSayiGoster.Text = ogrenciSayisi
        dosyaacici.Reset()
        Dim secim = 1
    End Sub

    Private Sub cbAsistan_click(sender As Object, e As EventArgs)
        Dim ulasilanAsistan As CheckBox = CType(sender, CheckBox)
        If secilenSinifsayi < 1 Then
            'lblerror.text = "Lütfen İlk Önce Sinif Seçiniz"
            ulasilanAsistan.Checked = False
        Else
            If ulasilanAsistan.Checked And secilenAsistanSayi < secilenSinifsayi Then
                seciliAsistanlar.Add(ulasilanAsistan.Text)
                secilenAsistanSayi += 1
                secilmesiGerekenAsistanSayi -= 1
                LbAsistanSecilecekSayi.Text = secilmesiGerekenAsistanSayi
            ElseIf ulasilanAsistan.Checked = False Then
                seciliAsistanlar.Remove(ulasilanAsistan.Text)
                secilenAsistanSayi -= 1
                secilmesiGerekenAsistanSayi += 1
                LbAsistanSecilecekSayi.Text = secilmesiGerekenAsistanSayi
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

                lblOgrenciHata.Text = ""
                yerlestirilenOgrenciSayisi = yerlestirilenOgrenciSayisi + SecilenSiniflarinKapasitesi
                If ogrenciSayisi - yerlestirilenOgrenciSayisi <= 0 Then
                    Lbkalanogrenci.Text = "0-Bütün Öğrenciler Yerleştirildi."
                Else
                    Lbkalanogrenci.Text = ogrenciSayisi - yerlestirilenOgrenciSayisi
                End If

                secilenSinifsayi = secilenSinifsayi + 1
                'lblError.Text = "Yeteri kadar sınıf seçildi"
                seciliSiniflar.Add(ulasilanDerslik.Name)
                secilmesiGerekenAsistanSayi += 1
                LbAsistanSecilecekSayi.Text = secilmesiGerekenAsistanSayi

            ElseIf ulasilanDerslik.Checked = False Then

                lblOgrenciHata.Text = ""
                yerlestirilenOgrenciSayisi = yerlestirilenOgrenciSayisi - SecilenSiniflarinKapasitesi
                Lbkalanogrenci.Text = ogrenciSayisi - yerlestirilenOgrenciSayisi
                secilenSinifsayi = secilenSinifsayi - 1
                seciliSiniflar.Remove(ulasilanDerslik.Name)
                secilmesiGerekenAsistanSayi -= 1
                LbAsistanSecilecekSayi.Text = secilmesiGerekenAsistanSayi

            ElseIf yerlestirilenOgrenciSayisi > ogrenciSayisi Then
                'lblError.Text = "Sınıf Seçmek Gerekli"
                ulasilanDerslik.Checked = False
                lblOgrenciHata.Text = "Yeteri Kadar Sınıf Seçildi"
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
        CbDersSecim.DataSource = database.DersAdiGetir
        AsistanVeSinifGüncelle()
    End Sub

    Private Sub BtnSinavOlustur_Click(sender As Object, e As EventArgs) Handles BtnSinavOlustur.Click
        GbAnaSayfa.Visible = True
        GbYeniSinavOlustur.Visible = False
        Try

            'gereği kadar Liste objesi yaratılıyor
            For i As Integer = 0 To seciliSiniflar.Count - 1
                Dim gecici As New SinifListeleri
                Dim ogrenciSayisi As Integer = Ogrenciler.Count - 1
                gecici.PSinifAdi = seciliSiniflar(i)
                gecici.PDersAdi = CbDersSecim.SelectedItem.ToString()
                gecici.PSinifKapasite = database.DerslikKapasiteGetir(seciliSiniflar(i).ToString())
                gecici.PbosSira = database.DerslikKapasiteGetir(seciliSiniflar(i).ToString())
                gecici.PSinavTur = CbTurSecim.SelectedItem.ToString()
                gecici.PTarih = DateTimePicker1.Value.Date
                gecici.PDonem = cbDonemSec.SelectedItem.ToString()
                listeler.Add(gecici)

            Next

            'Dim eklenecek As New Tarihler
            'eklenecek.Tarih = listeler(0).PTarih
            'database.TarihEkle(eklenecek)
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
                Try
                    listeler(i).PAsistanAdi = seciliAsistanlar(asistanIndex)
                    seciliAsistanlar.RemoveAt(asistanIndex)
                Catch
                    MessageBox.Show("Asistan Seçimi Hatalı")
                End Try

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
            OlusturulanSinav.SinavTuru = listeler(0).PSinavTur
            OlusturulanSinav.TarihID = database.TarihIDGetir(listeler(0).PTarih)
            database.SinavEkle(OlusturulanSinav)

            Dim SinavID = database.SinavIDGetir(OlusturulanSinav.DersKodu, OlusturulanSinav.TarihID)


            For i As Integer = 0 To seciliSiniflar.Count - 1
                Dim dbEklenecekListe As New Liste
                dbEklenecekListe.SinavID = SinavID
                dbEklenecekListe.DerslikID = database.derslikIDGetir(listeler(i).PSinifAdi)
                dbEklenecekListe.AsistanID = database.AsistanIDGetir(listeler(i).PAsistanAdi)
                dbEklenecekListe.OgrString = ogrenciListesiOlustur(listeler(i).POgrenciler).ToString()
                database.ListeEkle(dbEklenecekListe)
            Next
            If secilmesiGerekenAsistanSayi > 0 Then
                MessageBox.Show("Asistan seçiminde hata oldu.")
            Else
                MessageBox.Show("İşleminiz başarı ile gerçekleşti.")
            End If
            dgAnaSayfa.DataSource = database.SinavGrid()
            yerlestirilenOgrenciSayisi = 0
            secilenSinifsayi = 0
            secilenAsistanSayi = 0
            seciliSiniflar.RemoveAll(AddressOf seciliSiniflar.Contains)
            listeler.RemoveAll(AddressOf listeler.Contains)
            LbOgrenciSayiGoster.Text = ""
            Lbkalanogrenci.Text = ""
            LbOgrenciYerlestirilecekSayi.Text = ""
            LbAsistanSecilecekSayi.Text = ""

        Catch ex As Exception
            MessageBox.Show("Eksik veri seçimi.")
            LbAcilanDosya.Text = ""

        End Try

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
        LbAcilanDosya.Text = ""
    End Sub

    Private Sub btnListeEkle_Click(sender As Object, e As EventArgs) Handles btnListeEkle.Click
        OgrenciListesiniOku()
    End Sub



    Private Sub AnaEkranForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        resimYukle()
        DateTimePicker1.MinDate = DateTime.Now
        Me.WindowState = FormWindowState.Maximized
        GbAnaSayfa.Top = (Me.ClientSize.Height / 2) - (GbAnaSayfa.Height / 2)
        GbAnaSayfa.Left = (Me.ClientSize.Width / 2) - (GbAnaSayfa.Width / 2)
        CbDersSecim.DataSource = database.DersAdiGetir()
        cbDonemSec.DataSource = database.DonemGetir()
        dgAnaSayfa.DataSource = database.SinavGrid()
    End Sub

    Private Sub fonk(ByVal veri As String, ByVal dersAdi As String, ByVal sinavTur As String, ByVal derslik As String, ByVal asistan As String, ByVal tarih As String, ByVal AsistanMail As String)
        'Dim veri As String = "1151402562-Süleyman Yasin Akdeniz12;1151506396-Anıl Yılmaz5;115162503-Muhammed Fatih Candan7;1151506396-Anıl Yılmaz1;1151402562-Süleyman Yasin Akdeniz6;115162503-Muhammed Fatih Candan16;115162503-Muhammed Fatih Candan;115162503-Muhammed Fatih Candan5;1151508496-Uğur Kıymetli8;1151402562-Süleyman Yasin Akdeniz11;115150849-Uğur Kıymetli5;1151602805-Mehmet Erdin10;1151402562-Süleyman Yasin Akdeniz16;1151508496-Uğur Kıymetli16;1151506396-Anıl Yılmaz7;1151402562-Süleyman Yasin Akdeniz15;1151508496-Uğur Kıymetli10;115162503-Muhammed Fatih Candan4;1151402562-Süleyman Yasin Akdeniz8;1151506396-Anıl Yılmaz;"
        Dim header As String = "<!DOCTYPE html><html lang=""en""> <head> <title></title> <meta charset=""UTF-8""> <meta name=""viewport"" content=""width=device-width, initial-scale=1""> </head> <body> <style type=""text/css""> .tg{border-collapse:collapse;border-spacing:0;}.tg td{font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}.tg th{font-family:Arial, sans-serif;font-size:14px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}.tg .tg-f64w{font-weight:bold;font-size:16px;font-family:""Times New Roman"", Times, serif !important;;background-color:#cfcfcf;text-align:center;vertical-align:top}.tg .tg-ydu8{font-size:16px;font-family:""Times New Roman"", Times, serif !important;;text-align:center}.tg .tg-plqh{font-size:16px;font-family:""Times New Roman"", Times, serif !important;;text-align:center;vertical-align:top}</style> <span style=""text-align: center;text-decoration: underline;""> <h4>@DersAdi</h4> <h5><span id=""sinavTuru"" style=""color:red"">@SinavTur</span> SINIF LİSTESİ <span id=""sinavSinif"">(@Derslik)</span></h5> </span> <span style=""font-weight: bold;""><span style=""text-decoration: underline;"">Gözetmen:</span> <span id=""gozetmenAdi"">@Asistan</span></span> <span style=""display:inline-block; width: 300;""></span> <span style=""font-weight: bold; margin-left:23em""></span> </br></br> <span style=""font-weight: bold;""><span style=""text-decoration: underline;"">Tarih:</span> <span id=""listeTarih"">@Tarih</span></span> </br></br> <table class=""tg"" style=""undefined;table-layout: fixed; width: 500px""> <colgroup> <col style=""width: 80px""> <col style=""width: 129px""> <col style=""width: 358px""> <col style=""width: 165px""> </colgroup> <tr> <th class=""tg-f64w"">SIRA</th> <th class=""tg-f64w"">NUMARA </th> <th class=""tg-f64w"">AD - SOYAD</th> <th class=""tg-f64w"">İMZA</th> </tr>"
        Dim footer As String = "</table></body></html>"
        Dim kisi As String = "<tr style=""width:100px""><th class=""tg-yw4l"">@Sıra</th><th class=""tg-yw4l"">@Numara</th><th class=""tg-yw4l"">@AdSoyad</th><th class=""tg-yw4l""></th></tr>"


        header = header.Replace("@DersAdi", dersAdi).Replace("@SinavTur", sinavTur).Replace("@Derslik", derslik).Replace("@Asistan", asistan).Replace("@Tarih", tarih)
        Dim olusturulan As String = header
        Dim kisiler As String() = veri.Split(";")
        Dim DosyaAdi As String = derslik + "-" + dersAdi + "-" + tarih
        Dim i As Integer

        For i = 0 To kisiler.Length - 2 Step 1
            olusturulan += kisi.Replace("@Sıra", (i + 1).ToString()).Replace("@Numara", kisiler(i).Split("-")(0)).Replace("@AdSoyad", kisiler(i).Split("-")(1))
        Next
        olusturulan += footer
        Try
            File.WriteAllText("Sinavlar\" + DosyaAdi + ".doc", olusturulan, Encoding.UTF8)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Dim Mail As New MailMessage
        Dim attachment As System.Net.Mail.Attachment


        Mail.Subject = derslik + "-" + dersAdi + "-" + sinavTur + "-" + asistan
        Mail.To.Add(AsistanMail)
        Mail.From = New MailAddress(AsistanMail)
        Mail.Body = "Sınav Bilgileri Ektedir"
        attachment = New System.Net.Mail.Attachment("Sinavlar\" + DosyaAdi + ".doc")
        Mail.Attachments.Add(attachment)


        'Mail Ayarları
        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("ogrencidagitimsistemi@gmail.com", "trakyauniversitesi")
        SMTP.Port = "587"
        SMTP.Send(Mail)


    End Sub

    Private Sub dgAnaSayfa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAnaSayfa.CellContentClick
        Dim islemYapilacakIndex As Integer = e.RowIndex
        If e.ColumnIndex = 0 Then
            Dim derskodu As String = dgAnaSayfa.Rows(islemYapilacakIndex).Cells(3).Value.ToString()
            Dim sinavTuru As String = dgAnaSayfa.Rows(islemYapilacakIndex).Cells(4).Value.ToString()
            Dim dersAdi As String = dgAnaSayfa.Rows(islemYapilacakIndex).Cells(2).Value.ToString()
            Dim tarih As Date = dgAnaSayfa.Rows(islemYapilacakIndex).Cells(5).Value

            Dim sinavID As Integer = database.SinavIDGetir(derskodu, database.TarihIDGetir(tarih))
            Dim listeler As List(Of Liste) = database.listeleriDondur(sinavID)
            Dim listeSayisi As Integer = listeler.Count

            For i As Integer = 0 To listeler.Count - 1
                Dim derslikAdi As String = database.DerslikAdiGetir(listeler(i).DerslikID)
                Dim asistanAdi As String = database.AsitanAdiGetir(listeler(i).AsistanID)
                Dim Mail As String = database.AsistanMailGetir(listeler(i).AsistanID)
                fonk(listeler(i).OgrString, dersAdi, sinavTuru, derslikAdi, asistanAdi, tarih, Mail)
            Next
            MessageBox.Show("Mailler Asistanlara Gönderildi")
            'Mail Gönderme işlemleri
        ElseIf e.ColumnIndex = 1 Then
            Dim silinecekDersKodu As String = dgAnaSayfa.Rows(islemYapilacakIndex).Cells(3).Value.ToString()
            Dim silinecekTarih As Date = dgAnaSayfa.Rows(islemYapilacakIndex).Cells(5).Value
            database.sinavSil(silinecekDersKodu, silinecekTarih)
            dgAnaSayfa.DataSource = database.SinavGrid()
        End If
    End Sub

    Private Sub AnaEkranForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        MessageBox.Show("VB.NET's Fathers Are Watching You!!", "Watch Out!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Application.Exit()
    End Sub
End Class