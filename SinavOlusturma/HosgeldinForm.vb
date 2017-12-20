Imports System.IO
Imports System.Drawing.Text

Public Class HosgeldinForm
    Dim durum As String = ""
    Dim durumlar(2) As String

    Public Sub resimFontYukle()
        PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Resimler\" & "giris.png")
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(AppDomain.CurrentDomain.BaseDirectory & "Fontlar\\helvetica.ttf")
        Label1.Font = New Font(pfc.Families(0), (16), FontStyle.Regular)
        Button1.Font = New Font(pfc.Families(0), (16), FontStyle.Regular)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MevcutEklemeForm As MevcutEklemeForm
        MevcutEklemeForm = New MevcutEklemeForm
        MevcutEklemeForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        System.IO.File.WriteAllText("status", "")
        Dim wr As New StreamWriter("status")
        wr.WriteLine(durumlar(0))
        wr.WriteLine(durumlar(1))
        wr.Close()
    End Sub

    Private Sub HosgeldinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        resimFontYukle() 'resim font yükle
        Dim sr As New StreamReader("status")
        Dim i As Integer = 0
        Do Until sr.Peek = -1
            durum = sr.ReadLine()
            durumlar(i) = durum
            i = i + 1
        Loop
        sr.Close()

        If (durumlar(0) = 1) Then 'Daha önce kurulum yapıldıysa
            Dim AnaEkranForm As AnaEkranForm
            AnaEkranForm = New AnaEkranForm
            AnaEkranForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (durumlar(0) = 1) Then 'Daha önce kurulum yapıldıysa
            Me.Hide()
        End If
    End Sub
End Class
