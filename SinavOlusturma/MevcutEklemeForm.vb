﻿Imports System.IO
Public Class MevcutEklemeForm
    Dim durum As String = ""
    Dim durumlar(2) As String



    Private Sub BtnDevam_Click(sender As Object, e As EventArgs) Handles BtnDevam.Click
        If (durumlar(0) = 0) Then 'Program kuruluyorsa
            If (durumlar(1) < 2) Then
                durumlar(1) += 1

                If (durumlar(1) = 0) Then
                    LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                    LblAdiGiriniz.Text = "Ders Adı Giriniz:"
                    LblKoduGiriniz.Text = "Ders Kodu Giriniz:"
                    BtnGeri.Visible = False
                    BtnDevam.Text = "Devam"
                    DataGridView2.Columns(0).HeaderCell.Value = "Ders Adı"
                    'veri tabınına ekleme kısmı
                    Try
                        Dim eklenecekDers As New Dersler
                        eklenecekDers.DersAdi = LblAdiGiriniz.Text
                        eklenecekDers.DersKodu = LblKoduGiriniz.Text
                        database.DersEkle(eklenecekDers)
                    Catch ex As Exception

                    End Try


                ElseIf (durumlar(1) = 1) Then
                    LblEkleyiniz.Text = "Mevcut Derslikleri Giriniz"
                    LblAdiGiriniz.Text = "Derslik Adı Giriniz:"
                    LblKoduGiriniz.Text = "Kapasite Giriniz:"
                    BtnGeri.Visible = True
                    BtnDevam.Text = "Devam"
                    DataGridView2.Columns(0).HeaderCell.Value = "Derslik Adı"
                    'veri tabanına ekleme kısmı
                    Try
                        Dim eklenecekDerslik As New Derslik
                        eklenecekDerslik.DerslikAdi = TbAdiGiriniz.Text
                        eklenecekDerslik.Kapasite = TbKoduGiriniz.Text
                        database.DerslikEkle(eklenecekDerslik)
                    Catch ex As Exception

                    End Try

                ElseIf (durumlar(1) = 2) Then
                    LblEkleyiniz.Text = "Mevcut Asistanları Giriniz"
                    LblAdiGiriniz.Text = "Asistan Adı Giriniz:"
                    LblKoduGiriniz.Text = "Asistan Mail Giriniz:"
                    BtnGeri.Visible = True
                    DataGridView2.Columns(0).HeaderCell.Value = "Asistan Adı"
                    BtnDevam.Text = "Bitir"
                    'veri tabanına ekleme kısmı
                    Try
                        Dim eklenecekAsistan As New Asistan
                        eklenecekAsistan.AsistanAdi = TbAdiGiriniz.Text
                        eklenecekAsistan.Mail = TbKoduGiriniz.Text
                        database.AsistanEkle(eklenecekAsistan)
                    Catch ex As Exception

                    End Try


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
                    LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                    LblAdiGiriniz.Text = "Ders Adı Giriniz:"
                    LblKoduGiriniz.Text = "Ders Kodu Giriniz:"
                    BtnGeri.Visible = False
                    BtnDevam.Text = "Devam"
                    DataGridView2.Columns(1).HeaderCell.Value = "Ders Adı"
                    'veri tabınına ekleme kısmı
                    Try
                        Dim eklenecekDers As New Dersler
                        eklenecekDers.DersAdi = LblAdiGiriniz.Text
                        eklenecekDers.DersKodu = LblKoduGiriniz.Text
                        database.DersEkle(eklenecekDers)
                    Catch ex As Exception

                    End Try


                ElseIf (durumlar(1) = 1) Then
                    LblEkleyiniz.Text = "Mevcut Derslikleri Giriniz"
                    LblAdiGiriniz.Text = "Derslik Adı Giriniz:"
                    LblKoduGiriniz.Text = "Kapasite Giriniz:"
                    BtnGeri.Visible = True
                    BtnDevam.Text = "Devam"
                    DataGridView2.Columns(1).HeaderCell.Value = "Derslik Adı"
                    'veri tabanına ekleme kısmı
                    Try
                        Dim eklenecekDerslik As New Derslik
                        eklenecekDerslik.DerslikAdi = TbAdiGiriniz.Text
                        eklenecekDerslik.Kapasite = TbKoduGiriniz.Text
                        database.DerslikEkle(eklenecekDerslik)
                    Catch ex As Exception

                    End Try


                ElseIf (durumlar(1) = 2) Then
                    LblEkleyiniz.Text = "Mevcut Asistanları Giriniz"
                    LblAdiGiriniz.Text = "Asistan Adı Giriniz:"
                    LblKoduGiriniz.Text = "Asistan Mail Giriniz:"
                    BtnGeri.Visible = True
                    DataGridView2.Columns(1).HeaderCell.Value = "Asistan Adı"
                    BtnDevam.Text = "Bitir"
                    'veri tabanına ekleme kısmı
                    Try
                        Dim eklenecekAsistan As New Asistan
                        eklenecekAsistan.AsistanAdi = TbAdiGiriniz.Text
                        eklenecekAsistan.Mail = TbKoduGiriniz.Text
                        database.AsistanEkle(eklenecekAsistan)
                    Catch ex As Exception

                    End Try

                End If
            Else 'İlk sayfadaysa  /BU KOD SİLİNEBİLİR
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
        DataGridView2.DataSource = database.AsistanGrid
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
                LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                LblAdiGiriniz.Text = "Ders Adı Giriniz:"
                LblKoduGiriniz.Text = "Ders Kodu Giriniz:"
                BtnGeri.Visible = False
                BtnDevam.Text = "Devam"
                DataGridView2.Columns(1).HeaderCell.Value = "Ders Adı"
                'veri tabınına ekleme kısmı
                Try
                    Dim eklenecekDers As New Dersler
                    eklenecekDers.DersAdi = LblAdiGiriniz.Text
                    eklenecekDers.DersKodu = LblKoduGiriniz.Text
                    database.DersEkle(eklenecekDers)
                Catch ex As Exception

                End Try


            ElseIf (durumlar(1) = 1) Then
                LblEkleyiniz.Text = "Mevcut Derslikleri Giriniz"
                LblAdiGiriniz.Text = "Derslik Adı Giriniz:"
                LblKoduGiriniz.Text = "Kapasite Giriniz:"
                BtnGeri.Visible = True
                BtnDevam.Text = "Devam"
                DataGridView2.Columns(1).HeaderCell.Value = "Derslik Adı"
                'veri tabanına ekleme kısmı
                Try
                    Dim eklenecekDerslik As New Derslik
                    eklenecekDerslik.DerslikAdi = TbAdiGiriniz.Text
                    eklenecekDerslik.Kapasite = TbKoduGiriniz.Text
                    database.DerslikEkle(eklenecekDerslik)
                Catch ex As Exception

                End Try


            ElseIf (durumlar(1) = 2) Then
                LblEkleyiniz.Text = "Mevcut Asistanları Giriniz"
                LblAdiGiriniz.Text = "Asistan Adı Giriniz:"
                LblKoduGiriniz.Text = "Asistan Mail Giriniz:"
                BtnGeri.Visible = True
                DataGridView2.Columns(1).HeaderCell.Value = "Asistan Adı"
                BtnDevam.Text = "Bitir"
                'veri tabanına ekleme kısmı
                Try
                    Dim eklenecekAsistan As New Asistan
                    eklenecekAsistan.AsistanAdi = TbAdiGiriniz.Text
                    eklenecekAsistan.Mail = TbKoduGiriniz.Text
                    database.AsistanEkle(eklenecekAsistan)
                Catch ex As Exception

                End Try


            End If
        Else
            'Durumlar(0)=1 olduğundan kurulum daha önceden yapılmış
            If (durumlar(1) = 0) Then
                LblEkleyiniz.Text = "Mevcut Dersleri Giriniz"
                LblAdiGiriniz.Text = "Ders Adı Giriniz:"
                LblKoduGiriniz.Text = "Ders Kodu Giriniz:"
                BtnGeri.Visible = False
                BtnDevam.Text = "Tamam"
                'DataGridView2.Columns(1).HeaderCell.Value = "Ders Adı"
                'veri tabınına ekleme kısmı
                Try
                    Dim eklenecekDers As New Dersler
                    eklenecekDers.DersAdi = LblAdiGiriniz.Text
                    eklenecekDers.DersKodu = LblKoduGiriniz.Text
                    database.DersEkle(eklenecekDers)
                Catch ex As Exception

                End Try


            ElseIf (durumlar(1) = 1) Then
                LblEkleyiniz.Text = "Mevcut Derslikleri Giriniz"
                LblAdiGiriniz.Text = "Derslik Adı Giriniz:"
                LblKoduGiriniz.Text = "Kapasite Giriniz:"
                BtnGeri.Visible = False
                BtnDevam.Text = "Tamam"
                DataGridView2.Columns(1).HeaderCell.Value = "Derslik Adı"
                'veri tabanına ekleme kısmı
                Try
                    Dim eklenecekDerslik As New Derslik
                    eklenecekDerslik.DerslikAdi = TbAdiGiriniz.Text
                    eklenecekDerslik.Kapasite = TbKoduGiriniz.Text
                    database.DerslikEkle(eklenecekDerslik)
                Catch ex As Exception

                End Try


            ElseIf (durumlar(1) = 2) Then
                LblEkleyiniz.Text = "Mevcut Asistanları Giriniz"
                LblAdiGiriniz.Text = "Asistan Adı Giriniz:"
                LblKoduGiriniz.Text = "Asistan Mail Giriniz:"
                BtnGeri.Visible = False
                BtnDevam.Text = "Tamam"
                DataGridView2.Columns(1).HeaderCell.Value = "Asistan Adı"
                'veri tabanına ekleme kısmı
                Try
                    Dim eklenecekAsistan As New Asistan
                    eklenecekAsistan.AsistanAdi = TbAdiGiriniz.Text
                    eklenecekAsistan.Mail = TbKoduGiriniz.Text
                    database.AsistanEkle(eklenecekAsistan)
                    DataGridView2.Refresh()
                Catch ex As Exception

                End Try


            End If
        End If


    End Sub '//FORM LOAD

    Private Sub BtnEkle_Click(sender As Object, e As EventArgs) Handles BtnEkle.Click
        'Me.DataGridView1.Rows.Add("X", TbAdiGiriniz.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        Dim x As Integer = e.RowIndex
    End Sub
End Class