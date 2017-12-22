Imports System.IO
Imports System.Net.Mail
Imports System.Text

Public Class listeMailYolla
    Public Function listeDocOlustur(ByVal data As String)
        Dim veri As String = "1151402562-Süleyman Yasin Akdeniz12;1151506396-Anıl Yılmaz5;115162503-Muhammed Fatih Candan7;1151506396-Anıl Yılmaz1;1151402562-Süleyman Yasin Akdeniz6;115162503-Muhammed Fatih Candan16;115162503-Muhammed Fatih Candan;115162503-Muhammed Fatih Candan5;1151508496-Uğur Kıymetli8;1151402562-Süleyman Yasin Akdeniz11;115150849-Uğur Kıymetli5;1151602805-Mehmet Erdin10;1151402562-Süleyman Yasin Akdeniz16;1151508496-Uğur Kıymetli16;1151506396-Anıl Yılmaz7;1151402562-Süleyman Yasin Akdeniz15;1151508496-Uğur Kıymetli10;115162503-Muhammed Fatih Candan4;1151402562-Süleyman Yasin Akdeniz8;1151506396-Anıl Yılmaz;"
        Dim header As String = "<!DOCTYPE html><html lang=""en""> <head> <title></title> <meta charset=""UTF-8""> <meta name=""viewport"" content=""width=device-width, initial-scale=1""> </head> <body> <style type=""text/css""> .tg{border-collapse:collapse;border-spacing:0;}.tg td{font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}.tg th{font-family:Arial, sans-serif;font-size:14px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}.tg .tg-f64w{font-weight:bold;font-size:16px;font-family:""Times New Roman"", Times, serif !important;;background-color:#cfcfcf;text-align:center;vertical-align:top}.tg .tg-ydu8{font-size:16px;font-family:""Times New Roman"", Times, serif !important;;text-align:center}.tg .tg-plqh{font-size:16px;font-family:""Times New Roman"", Times, serif !important;;text-align:center;vertical-align:top}</style> <span style=""text-align: center;text-decoration: underline;""> <h4>DERS ADI</h4> <h5><span id=""sinavTuru"" style=""color:red"">ARASINAV</span> SINIF LİSTESİ <span id=""sinavSinif"">(L301)</span></h5> </span> <span style=""font-weight: bold;""><span style=""text-decoration: underline;"">Gözetmen:</span> <span id=""gozetmenAdi"">Emir Öztürk </span></span> <span style=""display:inline-block; width: 300;""></span> <span style=""font-weight: bold; margin-left:23em""><span style=""text-decoration: underline;"">İmza:</span></span> </br></br> <span style=""font-weight: bold;""><span style=""text-decoration: underline;"">Tarih:</span> <span id=""listeTarih"">23.03.2016</span></span> </br></br> <table class=""tg"" style=""undefined;table-layout: fixed; width: 500px""> <colgroup> <col style=""width: 80px""> <col style=""width: 129px""> <col style=""width: 358px""> <col style=""width: 165px""> </colgroup> <tr> <th class=""tg-f64w"">SIRA</th> <th class=""tg-f64w"">NUMARA </th> <th class=""tg-f64w"">AD - SOYAD</th> <th class=""tg-f64w"">İMZA</th> </tr>"
        Dim footer As String = "</table></body></html>"
        Dim kisi As String = "<tr style=""width:100px""><th class=""tg-yw4l"">@Sıra</th><th class=""tg-yw4l"">@Numara</th><th class=""tg-yw4l"">@AdSoyad</th><th class=""tg-yw4l""></th></tr>"
        Dim olusturulan As String = header
        Dim kisiler As String() = veri.Split(";")
        Dim i As Integer

        For i = 0 To kisiler.Length - 2 Step 1
            olusturulan += kisi.Replace("@Sıra", (i + 1).ToString()).Replace("@Numara", kisiler(i).Split("-")(0)).Replace("@AdSoyad", kisiler(i).Split("-")(1))
        Next
        olusturulan += footer
        File.WriteAllText("cikti.doc", olusturulan, Encoding.UTF8)

        Return olusturulan 'oluşturulan html'i döndürür
    End Function 'liste doc olustur

    Public Sub mailYolla(ByVal htmlİcerik As String)
        Dim Mail As New MailMessage

        'Sınavın idsini al
        'Sınavın idsini kullanarak kaç tane listesi olduğunu bul
        'listeler kadar for kur
        'listelerin verilerini kullan
        Mail.Subject = "Dersin Adı"
        Mail.To.Add("asistanların mailleri")
        Mail.From = New MailAddress("asistanmail")
        Mail.Body = "html" 'HTML olarak geliyor. Doc'a dönüştürülüp yollanması lazım // File.WriteAllText("cikti.doc", olusturulan, Encoding.UTF8)

        'Mail Ayarları
        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("ogrencidagitimsistemi@gmail.com", "trakyauniversitesi")
        SMTP.Port = "587"
        SMTP.Send(Mail)

    End Sub



End Class