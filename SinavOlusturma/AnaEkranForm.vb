﻿Imports System.IO
Public Class AnaEkranForm
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
            'lblOgrenciSayisi.Text = "Öğrenci Sayısı : " + ogrenciSayisi.ToString
            'lblError.Text = "Lütfen yukarıdan sınıf seçiniz."
            'lblAcilanDosya.Text = "Açılan Dosya - " + dosyaacici.FileName
        End If
        'flSinifListele.l
        LbOgrenciSayiGoster.Text = ogrenciSayisi

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
            End If
            'lblsnfsyi.Text = "Seçilen Sınıf Sayısı : " + secilenSinifsayi                    -----------\
            'lblyrlssayi.Text = "Yerleştirilen Öğrenci Sayısı : " + yerlestirilenOgrenciSayisi------------> "lblsclnsnf" gibi labeller pek hoş değildi :)
            'lblOgrenciSayisi1.Text = ogrenciSayisi.ToString()                                -----------/


        End If

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
        Me.WindowState = FormWindowState.Maximized
        GbAnaSayfa.Top = (Me.ClientSize.Height / 2) - (GbAnaSayfa.Height / 2)
        GbAnaSayfa.Left = (Me.ClientSize.Width / 2) - (GbAnaSayfa.Width / 2)
        CbDersSecim.DataSource = database.DersAdiGetir()
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
        System.IO.File.WriteAllText("C:\Users\Fatih\Desktop\VB\SinavOlusturma\SinavOlusturma\bin\Debug\status", "")
        Dim wr As New StreamWriter("C:\Users\Fatih\Desktop\VB\SinavOlusturma\SinavOlusturma\bin\Debug\status")
        wr.WriteLine(1)
        wr.WriteLine(1)
        wr.Close()

        Dim MevcutEklemeForm As MevcutEklemeForm
        MevcutEklemeForm = New MevcutEklemeForm
        MevcutEklemeForm.Show()

    End Sub

    Private Sub BtnDersDuzenleme_Click(sender As Object, e As EventArgs) Handles BtnDersDuzenleme.Click
        System.IO.File.WriteAllText("C:\Users\Fatih\Desktop\VB\SinavOlusturma\SinavOlusturma\bin\Debug\status", "")
        Dim wr As New StreamWriter("C:\Users\Fatih\Desktop\VB\SinavOlusturma\SinavOlusturma\bin\Debug\status")
        wr.WriteLine(1)
        wr.WriteLine(0)
        wr.Close()

        Dim MevcutEklemeForm As MevcutEklemeForm
        MevcutEklemeForm = New MevcutEklemeForm
        MevcutEklemeForm.Show()
    End Sub

    Private Sub BtnAsistanDuzenleme_Click(sender As Object, e As EventArgs) Handles BtnAsistanDuzenleme.Click
        System.IO.File.WriteAllText("C:\Users\Fatih\Desktop\VB\SinavOlusturma\SinavOlusturma\bin\Debug\status", "")
        Dim wr As New StreamWriter("C:\Users\Fatih\Desktop\VB\SinavOlusturma\SinavOlusturma\bin\Debug\status")
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



    'Dim result As Integer = MessageBox.Show("İptal etmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo)
    'If result = DialogResult.No Then
    ''MessageBox.Show("No pressed")
    'ElseIf result = DialogResult.Yes Then
    '        GbAnaSayfa.Visible = True
    '        GbYeniSinavOlustur.Visible = False
    '    End If

End Class