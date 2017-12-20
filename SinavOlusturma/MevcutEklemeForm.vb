Imports System.IO
Public Class MevcutEklemeForm
    Dim durum As String = ""
    Dim durumlar(2) As String



    Private Sub BtnDevam_Click(sender As Object, e As EventArgs) Handles BtnDevam.Click
        If (durumlar(0) = 0) Then 'Program kuruluyorsa
            If (durumlar(1) < 2) Then
                durumlar(1) += 1

                If (durumlar(1) = 0) Then
                    DataGridView2.DataSource = database.DersGrid()
                    LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                    LblAdiGiriniz.Text = "Ders Adı Giriniz:"
                    LblKoduGiriniz.Text = "Ders Kodu Giriniz:"
                    BtnGeri.Visible = False
                    BtnDevam.Text = "Devam"


                ElseIf (durumlar(1) = 1) Then
                    DataGridView2.DataSource = database.DerslikGrid()
                    LblEkleyiniz.Text = "Mevcut Derslikleri Giriniz"
                    LblAdiGiriniz.Text = "Derslik Adı Giriniz:"
                    LblKoduGiriniz.Text = "Kapasite Giriniz:"
                    BtnGeri.Visible = True
                    BtnDevam.Text = "Devam"

                ElseIf (durumlar(1) = 2) Then
                    DataGridView2.DataSource = database.AsistanGrid()
                    LblEkleyiniz.Text = "Mevcut Asistanları Giriniz"
                    LblAdiGiriniz.Text = "Asistan Adı Giriniz:"
                    LblKoduGiriniz.Text = "Asistan Mail Giriniz:"
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
                    DataGridView2.DataSource = database.DersGrid()
                    LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                    LblAdiGiriniz.Text = "Ders Adı Giriniz:"
                    LblKoduGiriniz.Text = "Ders Kodu Giriniz:"
                    BtnGeri.Visible = False
                    BtnDevam.Text = "Devam"


                ElseIf (durumlar(1) = 1) Then
                    DataGridView2.DataSource = database.DerslikGrid
                    LblEkleyiniz.Text = "Mevcut Derslikleri Giriniz"
                    LblAdiGiriniz.Text = "Derslik Adı Giriniz:"
                    LblKoduGiriniz.Text = "Kapasite Giriniz:"
                    BtnGeri.Visible = True
                    BtnDevam.Text = "Devam"


                ElseIf (durumlar(1) = 2) Then
                    DataGridView2.DataSource = database.AsistanGrid()
                    LblEkleyiniz.Text = "Mevcut Asistanları Giriniz"
                    LblAdiGiriniz.Text = "Asistan Adı Giriniz:"
                    LblKoduGiriniz.Text = "Asistan Mail Giriniz:"
                    BtnGeri.Visible = True
                    BtnDevam.Text = "Bitir"

                End If
            Else 'İlk sayfadaysa  /BU KOD SİLİNEBİLİR
                DataGridView2.DataSource = database.DersGrid()
                LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                LblAdiGiriniz.Text = "Ders Adı Giriniz:"
                LblKoduGiriniz.Text = "Ders Kodu Giriniz:"
                BtnGeri.Visible = False
                BtnDevam.Text = "Devam"
            End If
        Else
            'Anasayfadan geliyorsa bitir 
            BtnGeri.Text = "Ana Sayfaya Dön"
        End If
    End Sub

    Private Sub MevcutEklemeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                DataGridView2.DataSource = database.DersGrid()
                LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                LblAdiGiriniz.Text = "Ders Adı Giriniz:"
                LblKoduGiriniz.Text = "Ders Kodu Giriniz:"
                BtnGeri.Visible = False
                BtnDevam.Text = "Devam"


            ElseIf (durumlar(1) = 1) Then
                DataGridView2.DataSource = database.DerslikGrid()
                LblEkleyiniz.Text = "Mevcut Derslikleri Giriniz"
                LblAdiGiriniz.Text = "Derslik Adı Giriniz:"
                LblKoduGiriniz.Text = "Kapasite Giriniz:"
                BtnGeri.Visible = True
                BtnDevam.Text = "Devam"


            ElseIf (durumlar(1) = 2) Then
                DataGridView2.DataSource = database.AsistanGrid()
                LblEkleyiniz.Text = "Mevcut Asistanları Giriniz"
                LblAdiGiriniz.Text = "Asistan Adı Giriniz:"
                LblKoduGiriniz.Text = "Asistan Mail Giriniz:"
                BtnGeri.Visible = True
                BtnDevam.Text = "Bitir"


            End If
        Else
            'Durumlar(0)=1 olduğundan kurulum daha önceden yapılmış
            If (durumlar(1) = 0) Then
                DataGridView2.DataSource = database.DersGrid()
                LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                LblAdiGiriniz.Text = "Ders Adı Giriniz:"
                LblKoduGiriniz.Text = "Ders Kodu Giriniz:"
                BtnGeri.Visible = False
                BtnDevam.Text = "Tamam"


            ElseIf (durumlar(1) = 1) Then
                DataGridView2.DataSource = database.DerslikGrid()
                LblEkleyiniz.Text = "Mevcut Derslikleri Giriniz"
                LblAdiGiriniz.Text = "Derslik Adı Giriniz:"
                LblKoduGiriniz.Text = "Kapasite Giriniz:"
                BtnGeri.Visible = False
                BtnDevam.Text = "Tamam"


            ElseIf (durumlar(1) = 2) Then
                DataGridView2.DataSource = database.AsistanGrid()
                LblEkleyiniz.Text = "Mevcut Asistanları Giriniz"
                LblAdiGiriniz.Text = "Asistan Adı Giriniz:"
                LblKoduGiriniz.Text = "Asistan Mail Giriniz:"
                BtnGeri.Visible = False
                BtnDevam.Text = "Tamam"



            End If
        End If


    End Sub '//FORM LOAD

    Private Sub BtnEkle_Click(sender As Object, e As EventArgs) Handles BtnEkle.Click
        'Me.DataGridView1.Rows.Add("X", TbAdiGiriniz.Text)
        If durumlar(1) = 0 Then 'ders
            Dim eklenecekDers As New Dersler
            eklenecekDers.DersAdi = TbAdiGiriniz.Text
            eklenecekDers.DersKodu = TbKoduGiriniz.Text
            database.DersEkle(eklenecekDers)
            DataGridView2.DataSource = database.DersGrid
        ElseIf durumlar(1) = 1 Then 'derslik
            Dim eklenecekDerslik As New Derslik
            eklenecekDerslik.DerslikAdi = TbAdiGiriniz.Text
            eklenecekDerslik.Kapasite = TbKoduGiriniz.Text
            database.DerslikEkle(eklenecekDerslik)
            DataGridView2.DataSource = database.DerslikGrid
        ElseIf durumlar(1) = 2 Then 'asistan
            Dim eklenecekAsistan As New Asistan
            eklenecekAsistan.AsistanAdi = TbAdiGiriniz.Text
            eklenecekAsistan.Mail = TbKoduGiriniz.Text
            database.AsistanEkle(eklenecekAsistan)
            DataGridView2.DataSource = database.AsistanGrid
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim SilinecekIndex As Integer = e.RowIndex
        If durumlar(1) = 0 Then 'ders
            Dim silinecekDersKodu As String = DataGridView2.Rows(SilinecekIndex).Cells(1).Value.ToString()
            database.DersSil(silinecekDersKodu)
            DataGridView2.DataSource = database.DersGrid
        ElseIf durumlar(1) = 1 Then 'derslik
            Dim silinecekDerslikAdi As String = DataGridView2.Rows(SilinecekIndex).Cells(1).Value.ToString()
            database.DerslikSil(silinecekDerslikAdi)
            DataGridView2.DataSource = database.DerslikGrid
        ElseIf durumlar(1) = 2 Then 'asistan
            Dim silinecekAsistanAdi As String = DataGridView2.Rows(SilinecekIndex).Cells(1).Value.ToString()
            database.AsistanSil(silinecekAsistanAdi)
            DataGridView2.DataSource = database.AsistanGrid
        End If
    End Sub

End Class