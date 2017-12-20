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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("C")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Görsel")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mat2")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vize", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDG")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Görsel Programlama")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Veri Yapıları", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2017", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode7})
        Me.BtnYeniSinav = New System.Windows.Forms.Button()
        Me.BtnMevcudat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMailGonder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GbAnaSayfa = New System.Windows.Forms.GroupBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.GbMevcudatDuzenle = New System.Windows.Forms.GroupBox()
        Me.BtnMevcudatGeri = New System.Windows.Forms.Button()
        Me.BtnAsistanDuzenleme = New System.Windows.Forms.Button()
        Me.BtnDerslikDuzenleme = New System.Windows.Forms.Button()
        Me.BtnDersDuzenleme = New System.Windows.Forms.Button()
        Me.GbYeniSinavOlustur = New System.Windows.Forms.GroupBox()
        Me.lblOgrenciHata = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lbkalanogrenci = New System.Windows.Forms.Label()
        Me.btnListeEkle = New System.Windows.Forms.Button()
        Me.LbOgrenciYerlestirilecekSayi = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.flAsistanlar = New System.Windows.Forms.FlowLayoutPanel()
        Me.flSinifListele = New System.Windows.Forms.FlowLayoutPanel()
        Me.LbAsistanSecilecekSayi = New System.Windows.Forms.Label()
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
        Me.GbAnaSayfa.SuspendLayout()
        Me.GbMevcudatDuzenle.SuspendLayout()
        Me.GbYeniSinavOlustur.SuspendLayout()
        Me.GbOgrenciDosya.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnYeniSinav
        '
        Me.BtnYeniSinav.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnYeniSinav.Location = New System.Drawing.Point(18, 273)
        Me.BtnYeniSinav.Name = "BtnYeniSinav"
        Me.BtnYeniSinav.Size = New System.Drawing.Size(250, 85)
        Me.BtnYeniSinav.TabIndex = 0
        Me.BtnYeniSinav.Text = "Yeni Sınav" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Oluştur"
        Me.BtnYeniSinav.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnYeniSinav.UseVisualStyleBackColor = True
        '
        'BtnMevcudat
        '
        Me.BtnMevcudat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnMevcudat.Location = New System.Drawing.Point(18, 407)
        Me.BtnMevcudat.Name = "BtnMevcudat"
        Me.BtnMevcudat.Size = New System.Drawing.Size(250, 85)
        Me.BtnMevcudat.TabIndex = 1
        Me.BtnMevcudat.Text = "Ders-Derslik-Asistan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Düzenle"
        Me.BtnMevcudat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMevcudat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(850, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Oluşturulmuş Sınavlar:"
        '
        'BtnMailGonder
        '
        Me.BtnMailGonder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnMailGonder.Location = New System.Drawing.Point(782, 557)
        Me.BtnMailGonder.Name = "BtnMailGonder"
        Me.BtnMailGonder.Size = New System.Drawing.Size(250, 85)
        Me.BtnMailGonder.TabIndex = 4
        Me.BtnMailGonder.Text = "Mail Gönder"
        Me.BtnMailGonder.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(479, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ana Ekran"
        '
        'GbAnaSayfa
        '
        Me.GbAnaSayfa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbAnaSayfa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GbAnaSayfa.Controls.Add(Me.TreeView1)
        Me.GbAnaSayfa.Controls.Add(Me.BtnYeniSinav)
        Me.GbAnaSayfa.Controls.Add(Me.Label2)
        Me.GbAnaSayfa.Controls.Add(Me.BtnMevcudat)
        Me.GbAnaSayfa.Controls.Add(Me.BtnMailGonder)
        Me.GbAnaSayfa.Controls.Add(Me.Label1)
        Me.GbAnaSayfa.Location = New System.Drawing.Point(75, 12)
        Me.GbAnaSayfa.Name = "GbAnaSayfa"
        Me.GbAnaSayfa.Size = New System.Drawing.Size(1119, 727)
        Me.GbAnaSayfa.TabIndex = 6
        Me.GbAnaSayfa.TabStop = False
        Me.GbAnaSayfa.Text = "Ana Sayfa"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView1.Location = New System.Drawing.Point(782, 234)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node2"
        TreeNode1.Text = "C"
        TreeNode2.Name = "Node3"
        TreeNode2.Text = "Görsel"
        TreeNode3.Name = "Node5"
        TreeNode3.Text = "Mat2"
        TreeNode4.Name = "Node1"
        TreeNode4.Text = "Vize"
        TreeNode5.Name = "Node7"
        TreeNode5.Text = "PDG"
        TreeNode6.Name = "Node9"
        TreeNode6.Text = "Görsel Programlama"
        TreeNode7.Name = "Node6"
        TreeNode7.Text = "Veri Yapıları"
        TreeNode8.Name = "Node0"
        TreeNode8.Text = "2017"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8})
        Me.TreeView1.Size = New System.Drawing.Size(240, 292)
        Me.TreeView1.TabIndex = 6
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
        Me.GbMevcudatDuzenle.Location = New System.Drawing.Point(1184, 161)
        Me.GbMevcudatDuzenle.Name = "GbMevcudatDuzenle"
        Me.GbMevcudatDuzenle.Size = New System.Drawing.Size(1043, 550)
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
        Me.BtnMevcudatGeri.Location = New System.Drawing.Point(54, 392)
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
        Me.BtnAsistanDuzenleme.Location = New System.Drawing.Point(739, 112)
        Me.BtnAsistanDuzenleme.Name = "BtnAsistanDuzenleme"
        Me.BtnAsistanDuzenleme.Size = New System.Drawing.Size(250, 85)
        Me.BtnAsistanDuzenleme.TabIndex = 2
        Me.BtnAsistanDuzenleme.Text = "Asistan"
        Me.BtnAsistanDuzenleme.UseVisualStyleBackColor = True
        '
        'BtnDerslikDuzenleme
        '
        Me.BtnDerslikDuzenleme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDerslikDuzenleme.AutoSize = True
        Me.BtnDerslikDuzenleme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDerslikDuzenleme.Location = New System.Drawing.Point(398, 112)
        Me.BtnDerslikDuzenleme.Name = "BtnDerslikDuzenleme"
        Me.BtnDerslikDuzenleme.Size = New System.Drawing.Size(250, 85)
        Me.BtnDerslikDuzenleme.TabIndex = 0
        Me.BtnDerslikDuzenleme.Text = "Derslik "
        Me.BtnDerslikDuzenleme.UseVisualStyleBackColor = True
        '
        'BtnDersDuzenleme
        '
        Me.BtnDersDuzenleme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDersDuzenleme.AutoSize = True
        Me.BtnDersDuzenleme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDersDuzenleme.Location = New System.Drawing.Point(54, 112)
        Me.BtnDersDuzenleme.Name = "BtnDersDuzenleme"
        Me.BtnDersDuzenleme.Size = New System.Drawing.Size(250, 85)
        Me.BtnDersDuzenleme.TabIndex = 1
        Me.BtnDersDuzenleme.Text = "Ders "
        Me.BtnDersDuzenleme.UseVisualStyleBackColor = True
        '
        'GbYeniSinavOlustur
        '
        Me.GbYeniSinavOlustur.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GbYeniSinavOlustur.Controls.Add(Me.lblOgrenciHata)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label10)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Lbkalanogrenci)
        Me.GbYeniSinavOlustur.Controls.Add(Me.btnListeEkle)
        Me.GbYeniSinavOlustur.Controls.Add(Me.LbOgrenciYerlestirilecekSayi)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label5)
        Me.GbYeniSinavOlustur.Controls.Add(Me.flAsistanlar)
        Me.GbYeniSinavOlustur.Controls.Add(Me.flSinifListele)
        Me.GbYeniSinavOlustur.Controls.Add(Me.LbAsistanSecilecekSayi)
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
        Me.GbYeniSinavOlustur.Location = New System.Drawing.Point(12, 35)
        Me.GbYeniSinavOlustur.Name = "GbYeniSinavOlustur"
        Me.GbYeniSinavOlustur.Size = New System.Drawing.Size(1119, 681)
        Me.GbYeniSinavOlustur.TabIndex = 7
        Me.GbYeniSinavOlustur.TabStop = False
        Me.GbYeniSinavOlustur.Text = "Yeni Sınav Oluştur"
        Me.GbYeniSinavOlustur.Visible = False
        '
        'lblOgrenciHata
        '
        Me.lblOgrenciHata.AutoSize = True
        Me.lblOgrenciHata.Location = New System.Drawing.Point(754, 298)
        Me.lblOgrenciHata.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOgrenciHata.Name = "lblOgrenciHata"
        Me.lblOgrenciHata.Size = New System.Drawing.Size(0, 13)
        Me.lblOgrenciHata.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(754, 80)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Yerleştirilmeyen Öğrenci Sayısı:"
        '
        'Lbkalanogrenci
        '
        Me.Lbkalanogrenci.AutoSize = True
        Me.Lbkalanogrenci.Location = New System.Drawing.Point(914, 80)
        Me.Lbkalanogrenci.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbkalanogrenci.Name = "Lbkalanogrenci"
        Me.Lbkalanogrenci.Size = New System.Drawing.Size(0, 13)
        Me.Lbkalanogrenci.TabIndex = 20
        '
        'btnListeEkle
        '
        Me.btnListeEkle.Location = New System.Drawing.Point(146, 454)
        Me.btnListeEkle.Name = "btnListeEkle"
        Me.btnListeEkle.Size = New System.Drawing.Size(206, 23)
        Me.btnListeEkle.TabIndex = 19
        Me.btnListeEkle.Text = "Liste Ekle"
        Me.btnListeEkle.UseVisualStyleBackColor = True
        '
        'LbOgrenciYerlestirilecekSayi
        '
        Me.LbOgrenciYerlestirilecekSayi.AutoSize = True
        Me.LbOgrenciYerlestirilecekSayi.Location = New System.Drawing.Point(903, 112)
        Me.LbOgrenciYerlestirilecekSayi.Name = "LbOgrenciYerlestirilecekSayi"
        Me.LbOgrenciYerlestirilecekSayi.Size = New System.Drawing.Size(0, 13)
        Me.LbOgrenciYerlestirilecekSayi.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(752, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Yerleştirilecek Kalan Öğrenci:"
        '
        'flAsistanlar
        '
        Me.flAsistanlar.AutoScroll = True
        Me.flAsistanlar.Location = New System.Drawing.Point(755, 341)
        Me.flAsistanlar.Name = "flAsistanlar"
        Me.flAsistanlar.Size = New System.Drawing.Size(225, 149)
        Me.flAsistanlar.TabIndex = 17
        '
        'flSinifListele
        '
        Me.flSinifListele.AutoScroll = True
        Me.flSinifListele.Location = New System.Drawing.Point(755, 128)
        Me.flSinifListele.Name = "flSinifListele"
        Me.flSinifListele.Size = New System.Drawing.Size(225, 149)
        Me.flSinifListele.TabIndex = 16
        '
        'LbAsistanSecilecekSayi
        '
        Me.LbAsistanSecilecekSayi.AutoSize = True
        Me.LbAsistanSecilecekSayi.Location = New System.Drawing.Point(913, 325)
        Me.LbAsistanSecilecekSayi.Name = "LbAsistanSecilecekSayi"
        Me.LbAsistanSecilecekSayi.Size = New System.Drawing.Size(0, 13)
        Me.LbAsistanSecilecekSayi.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(752, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Seçilmesi Gereken Asistan Sayısı: "
        '
        'BtnSinavIptal
        '
        Me.BtnSinavIptal.Location = New System.Drawing.Point(325, 606)
        Me.BtnSinavIptal.Name = "BtnSinavIptal"
        Me.BtnSinavIptal.Size = New System.Drawing.Size(109, 47)
        Me.BtnSinavIptal.TabIndex = 15
        Me.BtnSinavIptal.Text = "İptal"
        Me.BtnSinavIptal.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(512, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Yeni Sınav Oluşturma"
        '
        'GbOgrenciDosya
        '
        Me.GbOgrenciDosya.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GbOgrenciDosya.Controls.Add(Me.LbOgrenciSayiGoster)
        Me.GbOgrenciDosya.Controls.Add(Me.LbOgrenciSayiBilgi)
        Me.GbOgrenciDosya.Location = New System.Drawing.Point(146, 483)
        Me.GbOgrenciDosya.Name = "GbOgrenciDosya"
        Me.GbOgrenciDosya.Size = New System.Drawing.Size(218, 96)
        Me.GbOgrenciDosya.TabIndex = 11
        Me.GbOgrenciDosya.TabStop = False
        '
        'LbOgrenciSayiGoster
        '
        Me.LbOgrenciSayiGoster.AutoSize = True
        Me.LbOgrenciSayiGoster.Location = New System.Drawing.Point(128, 16)
        Me.LbOgrenciSayiGoster.Name = "LbOgrenciSayiGoster"
        Me.LbOgrenciSayiGoster.Size = New System.Drawing.Size(0, 13)
        Me.LbOgrenciSayiGoster.TabIndex = 1
        '
        'LbOgrenciSayiBilgi
        '
        Me.LbOgrenciSayiBilgi.AutoSize = True
        Me.LbOgrenciSayiBilgi.Location = New System.Drawing.Point(6, 16)
        Me.LbOgrenciSayiBilgi.Name = "LbOgrenciSayiBilgi"
        Me.LbOgrenciSayiBilgi.Size = New System.Drawing.Size(115, 13)
        Me.LbOgrenciSayiBilgi.TabIndex = 0
        Me.LbOgrenciSayiBilgi.Text = "Toplam Öğrenci Sayısı:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker1.Location = New System.Drawing.Point(146, 376)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10
        Me.DateTimePicker1.Value = New Date(2017, 12, 22, 0, 0, 0, 0)
        '
        'cbDonemSec
        '
        Me.cbDonemSec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbDonemSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDonemSec.FormattingEnabled = True
        Me.cbDonemSec.Items.AddRange(New Object() {"Vize", "Final", "Bütünleme"})
        Me.cbDonemSec.Location = New System.Drawing.Point(400, 277)
        Me.cbDonemSec.Name = "cbDonemSec"
        Me.cbDonemSec.Size = New System.Drawing.Size(187, 21)
        Me.cbDonemSec.TabIndex = 9
        '
        'CbTurSecim
        '
        Me.CbTurSecim.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbTurSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTurSecim.FormattingEnabled = True
        Me.CbTurSecim.Items.AddRange(New Object() {"Vize", "Final", "Bütünleme"})
        Me.CbTurSecim.Location = New System.Drawing.Point(146, 277)
        Me.CbTurSecim.Name = "CbTurSecim"
        Me.CbTurSecim.Size = New System.Drawing.Size(187, 21)
        Me.CbTurSecim.TabIndex = 9
        '
        'CbDersSecim
        '
        Me.CbDersSecim.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbDersSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDersSecim.FormattingEnabled = True
        Me.CbDersSecim.Location = New System.Drawing.Point(146, 166)
        Me.CbDersSecim.Name = "CbDersSecim"
        Me.CbDersSecim.Size = New System.Drawing.Size(187, 21)
        Me.CbDersSecim.TabIndex = 8
        '
        'BtnSinavOlustur
        '
        Me.BtnSinavOlustur.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSinavOlustur.Location = New System.Drawing.Point(515, 574)
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
        Me.Label4.Location = New System.Drawing.Point(143, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "4-) Öğrenci Listesini Text Dosyasını Yükleyiniz"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(143, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3-) Tarihi Seçiniz"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(143, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "2-)  Sınavın Türünü Seçiniz"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(143, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(190, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "1-)  Oluşturmak İstediğiniz dersi seçiniz."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AnaEkranForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 727)
        Me.Controls.Add(Me.GbYeniSinavOlustur)
        Me.Controls.Add(Me.GbAnaSayfa)
        Me.Controls.Add(Me.GbMevcudatDuzenle)
        Me.Name = "AnaEkranForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnaEkranForm"
        Me.GbAnaSayfa.ResumeLayout(False)
        Me.GbAnaSayfa.PerformLayout()
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
    Friend WithEvents BtnMailGonder As Button
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
    Friend WithEvents TreeView1 As TreeView
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
End Class
