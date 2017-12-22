Imports System.IO
Imports System.Text.RegularExpressions
Public Class MevcutEklemeForm
    Dim durum As String = ""
    Dim durumlar(2) As String

    Public Sub resimYukle()
        BackColor = Color.FromArgb(252, 252, 252)
        dgMevcutEkleme.BackgroundColor = Color.FromArgb(249, 249, 249)
        'dgMevcutEkleme.RowHeadersDefaultCellStyle = DataGridViewCellStyle { BackColor=Color [Control], ForeColor=Color [WindowText], SelectionBackColor=Color [Highlight], SelectionForeColor=Color [HighlightText], Font=[Font: Name = Arial Narrow, Size=8,25, Units=3, GdiCharSet=162, GdiVerticalFont=False], WrapMode=True, Alignment=MiddleLeft }
        If (durumlar(0) = 0) Then
            BtnDevam.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "sagOk.png")
            BtnDevam.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf durumlar(0) = 1 Or durumlar(1) = 0 Then
            BtnDevam.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "tamam.png")
            BtnDevam.BackgroundImageLayout = ImageLayout.Stretch
        End If
        BtnEkle.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "ekle(6oran).png")
        BtnEkle.BackgroundImageLayout = ImageLayout.Stretch
        btnİptal.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "çarpı.png")
        btnİptal.BackgroundImageLayout = ImageLayout.Stretch
        btnKaydet.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "tamam.png")
        btnKaydet.BackgroundImageLayout = ImageLayout.Stretch
        BtnGeri.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "solOk.png")
        BtnGeri.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub TbKoduGiriniz_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbKoduGiriniz.Validating
        Dim email As String = TbKoduGiriniz.Text
        If durumlar(1) = 2 Then 'asistan
            If emailKontrol(email) = False Then
                Dim sonuc As DialogResult = MessageBox.Show("Girdiğiniz email geçerli değil.")
                TbKoduGiriniz.Clear()
                If sonuc = DialogResult.Yes Then
                    e.Cancel = True
                End If
            End If

        End If
    End Sub


    Private Sub TbKoduGiriniz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbKoduGiriniz.KeyPress 'derslik eklenirken kapasite sadece numerik
        If durumlar(1) = 1 Then 'derslik
            If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Function emailKontrol(ByVal emailAdres As String) As Boolean  'mail'in düzgünlüğünü kontrol ediyor
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" &
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailEslestiMi As Match = Regex.Match(emailAdres, pattern)
        If emailEslestiMi.Success Then
            emailKontrol = True
        Else
            emailKontrol = False
        End If
    End Function


    Private Sub BtnDevam_Click(sender As Object, e As EventArgs) Handles BtnDevam.Click
        If (durumlar(0) = 0) Then 'Program kuruluyorsa
            If (durumlar(1) < 2) Then
                durumlar(1) += 1

                If (durumlar(1) = 0) Then
                    dgMevcutEkleme.DataSource = database.DersGrid()
                    LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                    LblAdiGiriniz.Text = "Ders Adı Giriniz :"
                    LblKoduGiriniz.Text = "Ders Kodu Giriniz :"
                    BtnGeri.Visible = False
                    BtnDevam.Text = "Devam"


                ElseIf (durumlar(1) = 1) Then
                    dgMevcutEkleme.DataSource = database.DerslikGrid()
                    LblEkleyiniz.Text = "Mevcut Derslikleri Giriniz"
                    LblAdiGiriniz.Text = "Derslik Adı Giriniz :"
                    LblKoduGiriniz.Text = "Kapasite Giriniz :"
                    BtnGeri.Visible = True
                    BtnDevam.Text = "Devam"

                ElseIf (durumlar(1) = 2) Then
                    dgMevcutEkleme.DataSource = database.AsistanGrid()
                    LblEkleyiniz.Text = "Mevcut Asistanları Giriniz"
                    LblAdiGiriniz.Text = "Asistan Adı Giriniz :"
                    LblKoduGiriniz.Text = "Asistan Mail Giriniz :"
                    BtnGeri.Visible = True
                    BtnDevam.Text = "Bitir"


                End If
            Else 'Kurulum bittiyse
                System.IO.File.WriteAllText("status", "")
                Dim wr As New StreamWriter("status")
                durumlar(0) = 1
                durumlar(1) = 0
                wr.WriteLine(durumlar(0))
                wr.WriteLine(durumlar(1))
                wr.Close()
                Dim AnaEkranForm As AnaEkranForm
                AnaEkranForm = New AnaEkranForm
                AnaEkranForm.Show()
                Me.Hide()
            End If
        Else
            'Anasayfadan geliyor
            System.IO.File.WriteAllText("status", "")
            Dim wr As New StreamWriter("status")
            durumlar(0) = 1
            durumlar(1) = 0
            wr.WriteLine(durumlar(0))
            wr.WriteLine(durumlar(1))
            wr.Close()
            Me.Hide()
        End If
    End Sub

    Private Sub BtnGeri_Click(sender As Object, e As EventArgs) Handles BtnGeri.Click
        If (durumlar(0) = 0) Then 'Program kuruluyorsa
            If (durumlar(1) > 0) Then
                durumlar(1) -= 1

                If (durumlar(1) = 0) Then
                    dgMevcutEkleme.DataSource = database.DersGrid()
                    LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                    LblAdiGiriniz.Text = "Ders Adı Giriniz :"
                    LblKoduGiriniz.Text = "Ders Kodu Giriniz :"
                    BtnGeri.Visible = False
                    BtnDevam.Text = "Devam"


                ElseIf (durumlar(1) = 1) Then
                    dgMevcutEkleme.DataSource = database.DerslikGrid
                    LblEkleyiniz.Text = "Mevcut Derslikleri Giriniz"
                    LblAdiGiriniz.Text = "Derslik Adı Giriniz :"
                    LblKoduGiriniz.Text = "Kapasite Giriniz :"
                    BtnGeri.Visible = True
                    BtnDevam.Text = "Devam"


                ElseIf (durumlar(1) = 2) Then
                    dgMevcutEkleme.DataSource = database.AsistanGrid()
                    LblEkleyiniz.Text = "Mevcut Asistanları Giriniz"
                    LblAdiGiriniz.Text = "Asistan Adı Giriniz :"
                    LblKoduGiriniz.Text = "Asistan Mail Giriniz :"
                    BtnGeri.Visible = True
                    BtnDevam.Text = "Bitir"

                End If
            Else 'İlk sayfadaysa  /BU KOD SİLİNEBİLİR
                dgMevcutEkleme.DataSource = database.DersGrid()
                LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                LblAdiGiriniz.Text = "Ders Adı Giriniz :"
                LblKoduGiriniz.Text = "Ders Kodu Giriniz :"
                BtnGeri.Visible = False
                BtnDevam.Text = "Devam"
            End If
        Else
            'Anasayfadan geliyorsa bitir 
            BtnGeri.Text = "Ana Sayfaya Dön"
        End If
    End Sub

    Private Sub MevcutEklemeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resimYukle()
        Dim sr As New StreamReader("status")
        Dim i As Integer = 0
        Do Until sr.Peek = -1
            durum = sr.ReadLine()
            durumlar(i) = durum
            i = i + 1
        Loop
        sr.Close()

        If (durumlar(0) = 0) Then
            If (durumlar(1) = 0) Then
                dgMevcutEkleme.DataSource = database.DersGrid()
                LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                LblAdiGiriniz.Text = "Ders Adı Giriniz :"
                LblKoduGiriniz.Text = "Ders Kodu Giriniz :"
                BtnGeri.Visible = False
                BtnDevam.Text = "Devam"


            ElseIf (durumlar(1) = 1) Then
                dgMevcutEkleme.DataSource = database.DerslikGrid()
                LblEkleyiniz.Text = "Mevcut Derslikleri Giriniz"
                LblAdiGiriniz.Text = "Derslik Adı Giriniz :"
                LblKoduGiriniz.Text = "Kapasite Giriniz :"
                BtnGeri.Visible = True
                BtnDevam.Text = "Devam"


            ElseIf (durumlar(1) = 2) Then
                dgMevcutEkleme.DataSource = database.AsistanGrid()
                LblEkleyiniz.Text = "Mevcut Asistanları Giriniz"
                LblAdiGiriniz.Text = "Asistan Adı Giriniz :"
                LblKoduGiriniz.Text = "Asistan Mail Giriniz :"
                BtnGeri.Visible = True
                BtnDevam.Text = "Bitir"


            End If
        Else
            'Durumlar(0)=1 olduğundan kurulum daha önceden yapılmış
            If (durumlar(1) = 0) Then
                dgMevcutEkleme.DataSource = database.DersGrid()
                LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                LblAdiGiriniz.Text = "Ders Adı Giriniz :"
                LblKoduGiriniz.Text = "Ders Kodu Giriniz :"
                BtnGeri.Visible = False
                BtnDevam.Text = "Tamam"


            ElseIf (durumlar(1) = 1) Then
                dgMevcutEkleme.DataSource = database.DerslikGrid()
                LblEkleyiniz.Text = "Mevcut Derslikleri Giriniz"
                LblAdiGiriniz.Text = "Derslik Adı Giriniz :"
                LblKoduGiriniz.Text = "Kapasite Giriniz :"
                BtnGeri.Visible = False
                BtnDevam.Text = "Tamam"


            ElseIf (durumlar(1) = 2) Then
                dgMevcutEkleme.DataSource = database.AsistanGrid()
                LblEkleyiniz.Text = "Mevcut Asistanları Giriniz"
                LblAdiGiriniz.Text = "Asistan Adı Giriniz :"
                LblKoduGiriniz.Text = "Asistan Mail Giriniz :"
                BtnGeri.Visible = False
                BtnDevam.Text = "Tamam"



            End If
        End If


    End Sub '//FORM LOAD

    Private Sub BtnEkle_Click(sender As Object, e As EventArgs) Handles BtnEkle.Click
        'Me.DataGridView1.Rows.Add("X", TbAdiGiriniz.Text)
        If TbKoduGiriniz.Text = "" Or TbAdiGiriniz.Text = "" Then
            MessageBox.Show("Alanlar boş bırakılamaz.")
            TbAdiGiriniz.Clear()
            TbKoduGiriniz.Clear()
        ElseIf durumlar(1) = 0 Then 'ders
            Dim eklenecekDers As New Dersler
            eklenecekDers.DersAdi = TbAdiGiriniz.Text
            eklenecekDers.DersKodu = TbKoduGiriniz.Text.ToUpper() 'ders kodu büyük harf olsun
            database.DersEkle(eklenecekDers)
            TbAdiGiriniz.Clear()
            TbKoduGiriniz.Clear()
            dgMevcutEkleme.DataSource = database.DersGrid
        ElseIf durumlar(1) = 1 Then 'derslik
            Dim eklenecekDerslik As New Derslik
            eklenecekDerslik.DerslikAdi = TbAdiGiriniz.Text.ToUpper() 'derslik harfi büyükharf
            eklenecekDerslik.Kapasite = TbKoduGiriniz.Text
            database.DerslikEkle(eklenecekDerslik)
            TbAdiGiriniz.Clear()
            TbKoduGiriniz.Clear()
            dgMevcutEkleme.DataSource = database.DerslikGrid
        ElseIf durumlar(1) = 2 Then 'asistan
            Dim eklenecekAsistan As New Asistan
            eklenecekAsistan.AsistanAdi = TbAdiGiriniz.Text
            eklenecekAsistan.Mail = TbKoduGiriniz.Text
            database.AsistanEkle(eklenecekAsistan)
            TbAdiGiriniz.Clear()
            TbKoduGiriniz.Clear()
            dgMevcutEkleme.DataSource = database.AsistanGrid
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMevcutEkleme.CellContentClick
        Dim SilinecekIndex As Integer = e.RowIndex
        If e.ColumnIndex = 0 Then

            If durumlar(1) = 0 Then 'ders
                Dim silinecekDersKodu As String = dgMevcutEkleme.Rows(SilinecekIndex).Cells(2).Value.ToString()
                database.DersSil(silinecekDersKodu)
                dgMevcutEkleme.DataSource = database.DersGrid
            ElseIf durumlar(1) = 1 Then 'derslik
                Dim silinecekDerslikAdi As String = dgMevcutEkleme.Rows(SilinecekIndex).Cells(1).Value.ToString()
                database.DerslikSil(silinecekDerslikAdi)
                dgMevcutEkleme.DataSource = database.DerslikGrid
            ElseIf durumlar(1) = 2 Then 'asistan
                Dim silinecekAsistanAdi As String = dgMevcutEkleme.Rows(SilinecekIndex).Cells(1).Value.ToString()
                database.AsistanSil(silinecekAsistanAdi)
                dgMevcutEkleme.DataSource = database.AsistanGrid
            End If
        End If
    End Sub
    Dim duzenlenecekIndex As Integer
    Private Sub DataGridView2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMevcutEkleme.CellContentDoubleClick

        duzenlenecekIndex = e.RowIndex
        btnKaydet.Visible = True
        btnİptal.Visible = True
        BtnEkle.Visible = False
        TbAdiGiriniz.Text = dgMevcutEkleme.Rows(duzenlenecekIndex).Cells(1).Value.ToString()
        TbKoduGiriniz.Text = dgMevcutEkleme.Rows(duzenlenecekIndex).Cells(2).Value.ToString()
        If durumlar(1) = 0 Then
            TbKoduGiriniz.ReadOnly = True
        End If

    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If TbKoduGiriniz.Text = "" Or TbAdiGiriniz.Text = "" Then
            MessageBox.Show("Alanlar boş bırakılamaz.")
            TbAdiGiriniz.Clear()
            TbKoduGiriniz.Clear()
        ElseIf durumlar(1) = 0 Then 'ders
            Dim degisecekDersKodu As String = dgMevcutEkleme.Rows(duzenlenecekIndex).Cells(2).Value.ToString()
            database.DersGuncelle(degisecekDersKodu, TbAdiGiriniz.Text)
            TbKoduGiriniz.ReadOnly = False
            dgMevcutEkleme.DataSource = database.DersGrid
        ElseIf durumlar(1) = 1 Then 'derslik
            Dim degisecekDerslikAdi As String = dgMevcutEkleme.Rows(duzenlenecekIndex).Cells(1).Value.ToString()
            database.derslikGuncelle(degisecekDerslikAdi, TbAdiGiriniz.Text, Convert.ToInt32(TbKoduGiriniz.Text))
            dgMevcutEkleme.DataSource = database.DerslikGrid
        ElseIf durumlar(1) = 2 Then 'asistan
            Dim degisecekAsistanAdi As String = dgMevcutEkleme.Rows(duzenlenecekIndex).Cells(1).Value.ToString()
            database.AsistanGuncelle(degisecekAsistanAdi, TbAdiGiriniz.Text, TbKoduGiriniz.Text)
            dgMevcutEkleme.DataSource = database.AsistanGrid
        End If
        btnKaydet.Visible = False
        btnİptal.Visible = False
        BtnEkle.Visible = True
        TbAdiGiriniz.Text = ""
        TbKoduGiriniz.Text = ""
    End Sub

    Private Sub btnİptal_Click(sender As Object, e As EventArgs) Handles btnİptal.Click
        If durumlar(1) = 0 Then
            TbKoduGiriniz.ReadOnly = False
        End If
        btnKaydet.Visible = False
        btnİptal.Visible = False
        BtnEkle.Visible = True
        TbAdiGiriniz.Text = ""
        TbKoduGiriniz.Text = ""
    End Sub
End Class