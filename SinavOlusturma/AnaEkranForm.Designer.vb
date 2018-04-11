<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaEkranForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaEkranForm))
        Me.BtnYeniSinav = New System.Windows.Forms.Button()
        Me.BtnMevcudat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GbAnaSayfa = New System.Windows.Forms.GroupBox()
        Me.dgAnaSayfa = New System.Windows.Forms.DataGridView()
        Me.GbMevcudatDuzenle = New System.Windows.Forms.GroupBox()
        Me.BtnMevcudatGeri = New System.Windows.Forms.Button()
        Me.BtnAsistanDuzenleme = New System.Windows.Forms.Button()
        Me.BtnDerslikDuzenleme = New System.Windows.Forms.Button()
        Me.BtnDersDuzenleme = New System.Windows.Forms.Button()
        Me.GbYeniSinavOlustur = New System.Windows.Forms.GroupBox()
        Me.LbAsistanSecilecekSayi = New System.Windows.Forms.Label()
        Me.LbAcilanDosya = New System.Windows.Forms.Label()
        Me.lblOgrenciHata = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lbkalanogrenci = New System.Windows.Forms.Label()
        Me.btnListeEkle = New System.Windows.Forms.Button()
        Me.LbOgrenciYerlestirilecekSayi = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.flAsistanlar = New System.Windows.Forms.FlowLayoutPanel()
        Me.flSinifListele = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnSinavIptal = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GbOgrenciDosya = New System.Windows.Forms.GroupBox()
        Me.LbOgrenciSayiGoster = New System.Windows.Forms.Label()
        Me.LbOgrenciSayiBilgi = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbDonemSec = New System.Windows.Forms.ComboBox()
        Me.CbTurSecim = New System.Windows.Forms.ComboBox()
        Me.CbDersSecim = New System.Windows.Forms.ComboBox()
        Me.BtnSinavOlustur = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Mail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Sil = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GbAnaSayfa.SuspendLayout()
        CType(Me.dgAnaSayfa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbMevcudatDuzenle.SuspendLayout()
        Me.GbYeniSinavOlustur.SuspendLayout()
        Me.GbOgrenciDosya.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnYeniSinav
        '
        Me.BtnYeniSinav.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnYeniSinav.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold)
        Me.BtnYeniSinav.Location = New System.Drawing.Point(7, 242)
        Me.BtnYeniSinav.Name = "BtnYeniSinav"
        Me.BtnYeniSinav.Size = New System.Drawing.Size(269, 90)
        Me.BtnYeniSinav.TabIndex = 0
        Me.BtnYeniSinav.Text = "Yeni Sınav" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Oluştur"
        Me.BtnYeniSinav.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnYeniSinav.UseVisualStyleBackColor = True
        '
        'BtnMevcudat
        '
        Me.BtnMevcudat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnMevcudat.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold)
        Me.BtnMevcudat.Location = New System.Drawing.Point(7, 376)
        Me.BtnMevcudat.Name = "BtnMevcudat"
        Me.BtnMevcudat.Size = New System.Drawing.Size(269, 90)
        Me.BtnMevcudat.TabIndex = 1
        Me.BtnMevcudat.Text = "Ders-Derslik-Asistan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Düzenle"
        Me.BtnMevcudat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMevcudat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(739, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Oluşturulmuş Sınavlar :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(463, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ana Ekran"
        '
        'GbAnaSayfa
        '
        Me.GbAnaSayfa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbAnaSayfa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GbAnaSayfa.Controls.Add(Me.dgAnaSayfa)
        Me.GbAnaSayfa.Controls.Add(Me.BtnYeniSinav)
        Me.GbAnaSayfa.Controls.Add(Me.Label2)
        Me.GbAnaSayfa.Controls.Add(Me.BtnMevcudat)
        Me.GbAnaSayfa.Controls.Add(Me.Label1)
        Me.GbAnaSayfa.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GbAnaSayfa.Location = New System.Drawing.Point(75, 12)
        Me.GbAnaSayfa.Name = "GbAnaSayfa"
        Me.GbAnaSayfa.Size = New System.Drawing.Size(1096, 727)
        Me.GbAnaSayfa.TabIndex = 6
        Me.GbAnaSayfa.TabStop = False
        '
        'dgAnaSayfa
        '
        Me.dgAnaSayfa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgAnaSayfa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgAnaSayfa.BackgroundColor = System.Drawing.Color.White
        Me.dgAnaSayfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAnaSayfa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mail, Me.Sil})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAnaSayfa.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgAnaSayfa.Location = New System.Drawing.Point(546, 145)
        Me.dgAnaSayfa.MultiSelect = False
        Me.dgAnaSayfa.Name = "dgAnaSayfa"
        Me.dgAnaSayfa.ReadOnly = True
        Me.dgAnaSayfa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAnaSayfa.Size = New System.Drawing.Size(562, 479)
        Me.dgAnaSayfa.TabIndex = 11
        '
        'GbMevcudatDuzenle
        '
        Me.GbMevcudatDuzenle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbMevcudatDuzenle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GbMevcudatDuzenle.Controls.Add(Me.BtnMevcudatGeri)
        Me.GbMevcudatDuzenle.Controls.Add(Me.BtnAsistanDuzenleme)
        Me.GbMevcudatDuzenle.Controls.Add(Me.BtnDerslikDuzenleme)
        Me.GbMevcudatDuzenle.Controls.Add(Me.BtnDersDuzenleme)
        Me.GbMevcudatDuzenle.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GbMevcudatDuzenle.Location = New System.Drawing.Point(1184, 161)
        Me.GbMevcudatDuzenle.Name = "GbMevcudatDuzenle"
        Me.GbMevcudatDuzenle.Size = New System.Drawing.Size(1020, 550)
        Me.GbMevcudatDuzenle.TabIndex = 8
        Me.GbMevcudatDuzenle.TabStop = False
        Me.GbMevcudatDuzenle.Text = "Mevcut Ders -Derslik - Asistan Düzenleme"
        Me.GbMevcudatDuzenle.Visible = False
        '
        'BtnMevcudatGeri
        '
        Me.BtnMevcudatGeri.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnMevcudatGeri.AutoSize = True
        Me.BtnMevcudatGeri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMevcudatGeri.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnMevcudatGeri.Location = New System.Drawing.Point(43, 392)
        Me.BtnMevcudatGeri.Name = "BtnMevcudatGeri"
        Me.BtnMevcudatGeri.Size = New System.Drawing.Size(141, 61)
        Me.BtnMevcudatGeri.TabIndex = 3
        Me.BtnMevcudatGeri.Text = "Geri"
        Me.BtnMevcudatGeri.UseVisualStyleBackColor = True
        '
        'BtnAsistanDuzenleme
        '
        Me.BtnAsistanDuzenleme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAsistanDuzenleme.AutoSize = True
        Me.BtnAsistanDuzenleme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAsistanDuzenleme.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnAsistanDuzenleme.Location = New System.Drawing.Point(728, 112)
        Me.BtnAsistanDuzenleme.Name = "BtnAsistanDuzenleme"
        Me.BtnAsistanDuzenleme.Size = New System.Drawing.Size(320, 100)
        Me.BtnAsistanDuzenleme.TabIndex = 2
        Me.BtnAsistanDuzenleme.Text = "Asistan"
        Me.BtnAsistanDuzenleme.UseVisualStyleBackColor = True
        '
        'BtnDerslikDuzenleme
        '
        Me.BtnDerslikDuzenleme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDerslikDuzenleme.AutoSize = True
        Me.BtnDerslikDuzenleme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDerslikDuzenleme.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDerslikDuzenleme.Location = New System.Drawing.Point(387, 112)
        Me.BtnDerslikDuzenleme.Name = "BtnDerslikDuzenleme"
        Me.BtnDerslikDuzenleme.Size = New System.Drawing.Size(320, 100)
        Me.BtnDerslikDuzenleme.TabIndex = 0
        Me.BtnDerslikDuzenleme.Text = "Derslik "
        Me.BtnDerslikDuzenleme.UseVisualStyleBackColor = True
        '
        'BtnDersDuzenleme
        '
        Me.BtnDersDuzenleme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDersDuzenleme.AutoSize = True
        Me.BtnDersDuzenleme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDersDuzenleme.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDersDuzenleme.Location = New System.Drawing.Point(43, 112)
        Me.BtnDersDuzenleme.Name = "BtnDersDuzenleme"
        Me.BtnDersDuzenleme.Size = New System.Drawing.Size(320, 100)
        Me.BtnDersDuzenleme.TabIndex = 1
        Me.BtnDersDuzenleme.Text = "Ders "
        Me.BtnDersDuzenleme.UseVisualStyleBackColor = True
        '
        'GbYeniSinavOlustur
        '
        Me.GbYeniSinavOlustur.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GbYeniSinavOlustur.Controls.Add(Me.LbAsistanSecilecekSayi)
        Me.GbYeniSinavOlustur.Controls.Add(Me.LbAcilanDosya)
        Me.GbYeniSinavOlustur.Controls.Add(Me.lblOgrenciHata)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label10)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Lbkalanogrenci)
        Me.GbYeniSinavOlustur.Controls.Add(Me.btnListeEkle)
        Me.GbYeniSinavOlustur.Controls.Add(Me.LbOgrenciYerlestirilecekSayi)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label5)
        Me.GbYeniSinavOlustur.Controls.Add(Me.flAsistanlar)
        Me.GbYeniSinavOlustur.Controls.Add(Me.flSinifListele)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label7)
        Me.GbYeniSinavOlustur.Controls.Add(Me.BtnSinavIptal)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label6)
        Me.GbYeniSinavOlustur.Controls.Add(Me.GbOgrenciDosya)
        Me.GbYeniSinavOlustur.Controls.Add(Me.DateTimePicker1)
        Me.GbYeniSinavOlustur.Controls.Add(Me.cbDonemSec)
        Me.GbYeniSinavOlustur.Controls.Add(Me.CbTurSecim)
        Me.GbYeniSinavOlustur.Controls.Add(Me.CbDersSecim)
        Me.GbYeniSinavOlustur.Controls.Add(Me.BtnSinavOlustur)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label4)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label3)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label8)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label9)
        Me.GbYeniSinavOlustur.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GbYeniSinavOlustur.Location = New System.Drawing.Point(57, 24)
        Me.GbYeniSinavOlustur.Name = "GbYeniSinavOlustur"
        Me.GbYeniSinavOlustur.Size = New System.Drawing.Size(1193, 681)
        Me.GbYeniSinavOlustur.TabIndex = 7
        Me.GbYeniSinavOlustur.TabStop = False
        Me.GbYeniSinavOlustur.Text = "Yeni Sınav Oluştur"
        Me.GbYeniSinavOlustur.Visible = False
        '
        'LbAsistanSecilecekSayi
        '
        Me.LbAsistanSecilecekSayi.AutoSize = True
        Me.LbAsistanSecilecekSayi.Location = New System.Drawing.Point(986, 383)
        Me.LbAsistanSecilecekSayi.Name = "LbAsistanSecilecekSayi"
        Me.LbAsistanSecilecekSayi.Size = New System.Drawing.Size(0, 20)
        Me.LbAsistanSecilecekSayi.TabIndex = 9
        '
        'LbAcilanDosya
        '
        Me.LbAcilanDosya.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbAcilanDosya.AutoSize = True
        Me.LbAcilanDosya.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LbAcilanDosya.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LbAcilanDosya.Location = New System.Drawing.Point(189, 468)
        Me.LbAcilanDosya.Name = "LbAcilanDosya"
        Me.LbAcilanDosya.Size = New System.Drawing.Size(0, 20)
        Me.LbAcilanDosya.TabIndex = 23
        '
        'lblOgrenciHata
        '
        Me.lblOgrenciHata.AutoSize = True
        Me.lblOgrenciHata.Location = New System.Drawing.Point(757, 352)
        Me.lblOgrenciHata.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOgrenciHata.Name = "lblOgrenciHata"
        Me.lblOgrenciHata.Size = New System.Drawing.Size(0, 20)
        Me.lblOgrenciHata.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(754, 119)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(212, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Yerleştirilmeyen Öğrenci Sayısı :"
        '
        'Lbkalanogrenci
        '
        Me.Lbkalanogrenci.AutoSize = True
        Me.Lbkalanogrenci.Location = New System.Drawing.Point(966, 119)
        Me.Lbkalanogrenci.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbkalanogrenci.Name = "Lbkalanogrenci"
        Me.Lbkalanogrenci.Size = New System.Drawing.Size(0, 20)
        Me.Lbkalanogrenci.TabIndex = 20
        '
        'btnListeEkle
        '
        Me.btnListeEkle.Location = New System.Drawing.Point(184, 440)
        Me.btnListeEkle.Name = "btnListeEkle"
        Me.btnListeEkle.Size = New System.Drawing.Size(206, 28)
        Me.btnListeEkle.TabIndex = 19
        Me.btnListeEkle.Text = "Liste Ekle"
        Me.btnListeEkle.UseVisualStyleBackColor = True
        '
        'LbOgrenciYerlestirilecekSayi
        '
        Me.LbOgrenciYerlestirilecekSayi.AutoSize = True
        Me.LbOgrenciYerlestirilecekSayi.Location = New System.Drawing.Point(966, 149)
        Me.LbOgrenciYerlestirilecekSayi.Name = "LbOgrenciYerlestirilecekSayi"
        Me.LbOgrenciYerlestirilecekSayi.Size = New System.Drawing.Size(0, 20)
        Me.LbOgrenciYerlestirilecekSayi.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(757, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Seçilen dersliklerin kapasitesi :"
        '
        'flAsistanlar
        '
        Me.flAsistanlar.AutoScroll = True
        Me.flAsistanlar.Location = New System.Drawing.Point(759, 412)
        Me.flAsistanlar.Name = "flAsistanlar"
        Me.flAsistanlar.Size = New System.Drawing.Size(263, 174)
        Me.flAsistanlar.TabIndex = 17
        '
        'flSinifListele
        '
        Me.flSinifListele.AutoScroll = True
        Me.flSinifListele.Location = New System.Drawing.Point(758, 172)
        Me.flSinifListele.Name = "flSinifListele"
        Me.flSinifListele.Size = New System.Drawing.Size(263, 174)
        Me.flSinifListele.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(755, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Seçilmesi Gereken Asistan Sayısı : "
        '
        'BtnSinavIptal
        '
        Me.BtnSinavIptal.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSinavIptal.Location = New System.Drawing.Point(325, 594)
        Me.BtnSinavIptal.Name = "BtnSinavIptal"
        Me.BtnSinavIptal.Size = New System.Drawing.Size(134, 59)
        Me.BtnSinavIptal.TabIndex = 15
        Me.BtnSinavIptal.Text = "İptal"
        Me.BtnSinavIptal.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(510, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 26)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Yeni Sınav Oluşturma"
        '
        'GbOgrenciDosya
        '
        Me.GbOgrenciDosya.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GbOgrenciDosya.Controls.Add(Me.LbOgrenciSayiGoster)
        Me.GbOgrenciDosya.Controls.Add(Me.LbOgrenciSayiBilgi)
        Me.GbOgrenciDosya.Location = New System.Drawing.Point(183, 490)
        Me.GbOgrenciDosya.Name = "GbOgrenciDosya"
        Me.GbOgrenciDosya.Size = New System.Drawing.Size(207, 96)
        Me.GbOgrenciDosya.TabIndex = 11
        Me.GbOgrenciDosya.TabStop = False
        '
        'LbOgrenciSayiGoster
        '
        Me.LbOgrenciSayiGoster.AutoSize = True
        Me.LbOgrenciSayiGoster.Location = New System.Drawing.Point(167, 16)
        Me.LbOgrenciSayiGoster.Name = "LbOgrenciSayiGoster"
        Me.LbOgrenciSayiGoster.Size = New System.Drawing.Size(0, 20)
        Me.LbOgrenciSayiGoster.TabIndex = 1
        '
        'LbOgrenciSayiBilgi
        '
        Me.LbOgrenciSayiBilgi.AutoSize = True
        Me.LbOgrenciSayiBilgi.Location = New System.Drawing.Point(6, 16)
        Me.LbOgrenciSayiBilgi.Name = "LbOgrenciSayiBilgi"
        Me.LbOgrenciSayiBilgi.Size = New System.Drawing.Size(155, 20)
        Me.LbOgrenciSayiBilgi.TabIndex = 0
        Me.LbOgrenciSayiBilgi.Text = "Toplam Öğrenci Sayısı:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker1.Location = New System.Drawing.Point(183, 358)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 10
        Me.DateTimePicker1.Value = New Date(2017, 12, 22, 0, 0, 0, 0)
        '
        'cbDonemSec
        '
        Me.cbDonemSec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbDonemSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDonemSec.FormattingEnabled = True
        Me.cbDonemSec.Items.AddRange(New Object() {"Vize", "Final", "Bütünleme"})
        Me.cbDonemSec.Location = New System.Drawing.Point(286, 265)
        Me.cbDonemSec.Name = "cbDonemSec"
        Me.cbDonemSec.Size = New System.Drawing.Size(84, 28)
        Me.cbDonemSec.TabIndex = 9
        '
        'CbTurSecim
        '
        Me.CbTurSecim.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbTurSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTurSecim.FormattingEnabled = True
        Me.CbTurSecim.Items.AddRange(New Object() {"Vize", "Final", "Bütünleme"})
        Me.CbTurSecim.Location = New System.Drawing.Point(183, 265)
        Me.CbTurSecim.Name = "CbTurSecim"
        Me.CbTurSecim.Size = New System.Drawing.Size(82, 28)
        Me.CbTurSecim.TabIndex = 9
        '
        'CbDersSecim
        '
        Me.CbDersSecim.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbDersSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDersSecim.FormattingEnabled = True
        Me.CbDersSecim.Location = New System.Drawing.Point(183, 160)
        Me.CbDersSecim.Name = "CbDersSecim"
        Me.CbDersSecim.Size = New System.Drawing.Size(187, 28)
        Me.CbDersSecim.TabIndex = 8
        '
        'BtnSinavOlustur
        '
        Me.BtnSinavOlustur.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSinavOlustur.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSinavOlustur.Location = New System.Drawing.Point(527, 584)
        Me.BtnSinavOlustur.Name = "BtnSinavOlustur"
        Me.BtnSinavOlustur.Size = New System.Drawing.Size(198, 79)
        Me.BtnSinavOlustur.TabIndex = 6
        Me.BtnSinavOlustur.Text = "Oluştur"
        Me.BtnSinavOlustur.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(180, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(295, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "4-) Öğrenci Listesini Text Dosyasını Yükleyiniz"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(180, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3-) Tarihi Seçiniz"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(180, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(259, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "2-)  Sınavın Türünü ve Dönemini Seçiniz"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(180, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(258, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "1-)  Oluşturmak İstediğiniz dersi seçiniz."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Mail
        '
        Me.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Mail.FillWeight = 60.0!
        Me.Mail.HeaderText = "Gönder"
        Me.Mail.Name = "Mail"
        Me.Mail.ReadOnly = True
        Me.Mail.Text = ">"
        Me.Mail.UseColumnTextForButtonValue = True
        '
        'Sil
        '
        Me.Sil.FillWeight = 30.0!
        Me.Sil.HeaderText = "Sil"
        Me.Sil.Name = "Sil"
        Me.Sil.ReadOnly = True
        Me.Sil.Text = "X"
        Me.Sil.UseColumnTextForButtonValue = True
        '
        'AnaEkranForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 727)
        Me.Controls.Add(Me.GbAnaSayfa)
        Me.Controls.Add(Me.GbYeniSinavOlustur)
        Me.Controls.Add(Me.GbMevcudatDuzenle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AnaEkranForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sınav Oluşturma Programı - Anasayfa"
        Me.GbAnaSayfa.ResumeLayout(False)
        Me.GbAnaSayfa.PerformLayout()
        CType(Me.dgAnaSayfa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbMevcudatDuzenle.ResumeLayout(False)
        Me.GbMevcudatDuzenle.PerformLayout()
        Me.GbYeniSinavOlustur.ResumeLayout(False)
        Me.GbYeniSinavOlustur.PerformLayout()
        Me.GbOgrenciDosya.ResumeLayout(False)
        Me.GbOgrenciDosya.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnYeniSinav As Button
    Friend WithEvents BtnMevcudat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GbAnaSayfa As GroupBox
    Friend WithEvents GbYeniSinavOlustur As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LbAsistanSecilecekSayi As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LbOgrenciYerlestirilecekSayi As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GbOgrenciDosya As GroupBox
    Friend WithEvents LbOgrenciSayiGoster As Label
    Friend WithEvents LbOgrenciSayiBilgi As Label
    Friend WithEvents CbTurSecim As ComboBox
    Friend WithEvents CbDersSecim As ComboBox
    Friend WithEvents BtnSinavOlusturIptal As Button
    Friend WithEvents BtnSinavOlustur As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GbMevcudatDuzenle As GroupBox
    Friend WithEvents BtnMevcudatGeri As Button
    Friend WithEvents BtnAsistanDuzenleme As Button
    Friend WithEvents BtnDersDuzenleme As Button
    Friend WithEvents BtnDerslikDuzenleme As Button
    Friend WithEvents BtnSinavIptal As Button
    Friend WithEvents flAsistanlar As FlowLayoutPanel
    Friend WithEvents flSinifListele As FlowLayoutPanel
    Friend WithEvents btnListeEkle As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cbDonemSec As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Lbkalanogrenci As Label
    Friend WithEvents lblOgrenciHata As Label
    Friend WithEvents dgAnaSayfa As DataGridView
    Friend WithEvents LbAcilanDosya As Label
    Friend WithEvents Mail As DataGridViewButtonColumn
    Friend WithEvents Sil As DataGridViewButtonColumn
End Class
