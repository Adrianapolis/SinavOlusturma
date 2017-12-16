Imports System.IO
Public Class AnaEkranForm
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