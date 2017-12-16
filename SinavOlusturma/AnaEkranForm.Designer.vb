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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LbAsistanSecilecekSayi = New System.Windows.Forms.Label()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.GbDerslikSec = New System.Windows.Forms.GroupBox()
        Me.LbOgrenciYerlestirilecekSayi = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GbOgrenciDosya = New System.Windows.Forms.GroupBox()
        Me.LbOgrenciSayiGoster = New System.Windows.Forms.Label()
        Me.LbOgrenciSayiBilgi = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CbTurSecim = New System.Windows.Forms.ComboBox()
        Me.CbDersSecim = New System.Windows.Forms.ComboBox()
        Me.BtnSinavOlustur = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnSinavIptal = New System.Windows.Forms.Button()
        Me.GbAnaSayfa.SuspendLayout()
        Me.GbMevcudatDuzenle.SuspendLayout()
        Me.GbYeniSinavOlustur.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GbDerslikSec.SuspendLayout()
        Me.GbOgrenciDosya.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnYeniSinav
        '
        Me.BtnYeniSinav.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnYeniSinav.Location = New System.Drawing.Point(18, 250)
        Me.BtnYeniSinav.Name = "BtnYeniSinav"
        Me.BtnYeniSinav.Size = New System.Drawing.Size(271, 73)
        Me.BtnYeniSinav.TabIndex = 0
        Me.BtnYeniSinav.Text = "Yeni Sınav Oluştur"
        Me.BtnYeniSinav.UseVisualStyleBackColor = True
        '
        'BtnMevcudat
        '
        Me.BtnMevcudat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnMevcudat.Location = New System.Drawing.Point(18, 384)
        Me.BtnMevcudat.Name = "BtnMevcudat"
        Me.BtnMevcudat.Size = New System.Drawing.Size(271, 73)
        Me.BtnMevcudat.TabIndex = 1
        Me.BtnMevcudat.Text = "Mevcut Sınıf-Ders-Asistan Düzenle"
        Me.BtnMevcudat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(850, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Oluşturulmuş Sınavlar:"
        '
        'BtnMailGonder
        '
        Me.BtnMailGonder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnMailGonder.Location = New System.Drawing.Point(782, 534)
        Me.BtnMailGonder.Name = "BtnMailGonder"
        Me.BtnMailGonder.Size = New System.Drawing.Size(240, 46)
        Me.BtnMailGonder.TabIndex = 4
        Me.BtnMailGonder.Text = "Mail Gönder"
        Me.BtnMailGonder.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(479, 107)
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
        Me.GbAnaSayfa.Size = New System.Drawing.Size(1119, 681)
        Me.GbAnaSayfa.TabIndex = 6
        Me.GbAnaSayfa.TabStop = False
        Me.GbAnaSayfa.Text = "Ana Sayfa"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView1.Location = New System.Drawing.Point(782, 211)
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
        Me.GbMevcudatDuzenle.Size = New System.Drawing.Size(1043, 504)
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
        Me.BtnMevcudatGeri.Location = New System.Drawing.Point(54, 369)
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
        Me.BtnAsistanDuzenleme.Location = New System.Drawing.Point(739, 89)
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
        Me.BtnDerslikDuzenleme.Location = New System.Drawing.Point(398, 89)
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
        Me.BtnDersDuzenleme.Location = New System.Drawing.Point(54, 89)
        Me.BtnDersDuzenleme.Name = "BtnDersDuzenleme"
        Me.BtnDersDuzenleme.Size = New System.Drawing.Size(250, 85)
        Me.BtnDersDuzenleme.TabIndex = 1
        Me.BtnDersDuzenleme.Text = "Ders "
        Me.BtnDersDuzenleme.UseVisualStyleBackColor = True
        '
        'GbYeniSinavOlustur
        '
        Me.GbYeniSinavOlustur.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GbYeniSinavOlustur.Controls.Add(Me.BtnSinavIptal)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label6)
        Me.GbYeniSinavOlustur.Controls.Add(Me.GroupBox2)
        Me.GbYeniSinavOlustur.Controls.Add(Me.GbDerslikSec)
        Me.GbYeniSinavOlustur.Controls.Add(Me.GbOgrenciDosya)
        Me.GbYeniSinavOlustur.Controls.Add(Me.DateTimePicker1)
        Me.GbYeniSinavOlustur.Controls.Add(Me.CbTurSecim)
        Me.GbYeniSinavOlustur.Controls.Add(Me.CbDersSecim)
        Me.GbYeniSinavOlustur.Controls.Add(Me.BtnSinavOlustur)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label4)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label3)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label8)
        Me.GbYeniSinavOlustur.Controls.Add(Me.Label9)
        Me.GbYeniSinavOlustur.Location = New System.Drawing.Point(12, 12)
        Me.GbYeniSinavOlustur.Name = "GbYeniSinavOlustur"
        Me.GbYeniSinavOlustur.Size = New System.Drawing.Size(1119, 681)
        Me.GbYeniSinavOlustur.TabIndex = 7
        Me.GbYeniSinavOlustur.TabStop = False
        Me.GbYeniSinavOlustur.Text = "Yeni Sınav Oluştur"
        Me.GbYeniSinavOlustur.Visible = False
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.LbAsistanSecilecekSayi)
        Me.GroupBox2.Controls.Add(Me.CheckBox7)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CheckBox8)
        Me.GroupBox2.Controls.Add(Me.CheckBox9)
        Me.GroupBox2.Controls.Add(Me.CheckBox10)
        Me.GroupBox2.Controls.Add(Me.CheckBox11)
        Me.GroupBox2.Controls.Add(Me.CheckBox12)
        Me.GroupBox2.Location = New System.Drawing.Point(756, 345)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 132)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "6-)  Asistan Seçiniz"
        '
        'LbAsistanSecilecekSayi
        '
        Me.LbAsistanSecilecekSayi.AutoSize = True
        Me.LbAsistanSecilecekSayi.Location = New System.Drawing.Point(173, 31)
        Me.LbAsistanSecilecekSayi.Name = "LbAsistanSecilecekSayi"
        Me.LbAsistanSecilecekSayi.Size = New System.Drawing.Size(13, 13)
        Me.LbAsistanSecilecekSayi.TabIndex = 9
        Me.LbAsistanSecilecekSayi.Text = "5"
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(153, 102)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox7.TabIndex = 11
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Seçilecek Asistan Sayısı: "
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(153, 79)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox8.TabIndex = 10
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(153, 55)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox9.TabIndex = 9
        Me.CheckBox9.Text = "CheckBox9"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(25, 102)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox10.TabIndex = 8
        Me.CheckBox10.Text = "CheckBox10"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(25, 79)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox11.TabIndex = 7
        Me.CheckBox11.Text = "CheckBox11"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(25, 55)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox12.TabIndex = 6
        Me.CheckBox12.Text = "CheckBox12"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'GbDerslikSec
        '
        Me.GbDerslikSec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GbDerslikSec.Controls.Add(Me.LbOgrenciYerlestirilecekSayi)
        Me.GbDerslikSec.Controls.Add(Me.Label5)
        Me.GbDerslikSec.Controls.Add(Me.CheckBox4)
        Me.GbDerslikSec.Controls.Add(Me.CheckBox5)
        Me.GbDerslikSec.Controls.Add(Me.CheckBox6)
        Me.GbDerslikSec.Controls.Add(Me.CheckBox3)
        Me.GbDerslikSec.Controls.Add(Me.CheckBox2)
        Me.GbDerslikSec.Controls.Add(Me.CheckBox1)
        Me.GbDerslikSec.Location = New System.Drawing.Point(756, 128)
        Me.GbDerslikSec.Name = "GbDerslikSec"
        Me.GbDerslikSec.Size = New System.Drawing.Size(266, 141)
        Me.GbDerslikSec.TabIndex = 12
        Me.GbDerslikSec.TabStop = False
        Me.GbDerslikSec.Text = "5-) Derslik Seçiniz"
        '
        'LbOgrenciYerlestirilecekSayi
        '
        Me.LbOgrenciYerlestirilecekSayi.AutoSize = True
        Me.LbOgrenciYerlestirilecekSayi.Location = New System.Drawing.Point(173, 27)
        Me.LbOgrenciYerlestirilecekSayi.Name = "LbOgrenciYerlestirilecekSayi"
        Me.LbOgrenciYerlestirilecekSayi.Size = New System.Drawing.Size(19, 13)
        Me.LbOgrenciYerlestirilecekSayi.TabIndex = 7
        Me.LbOgrenciYerlestirilecekSayi.Text = "50"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Yerleştirilecek Kalan Öğrenci:"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(153, 103)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox4.TabIndex = 5
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(153, 80)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(153, 56)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox6.TabIndex = 3
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(25, 103)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(25, 80)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(25, 56)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GbOgrenciDosya
        '
        Me.GbOgrenciDosya.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GbOgrenciDosya.Controls.Add(Me.LbOgrenciSayiGoster)
        Me.GbOgrenciDosya.Controls.Add(Me.LbOgrenciSayiBilgi)
        Me.GbOgrenciDosya.Location = New System.Drawing.Point(146, 448)
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
        Me.LbOgrenciSayiGoster.Size = New System.Drawing.Size(25, 13)
        Me.LbOgrenciSayiGoster.TabIndex = 1
        Me.LbOgrenciSayiGoster.Text = "250"
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
        '
        'CbTurSecim
        '
        Me.CbTurSecim.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbTurSecim.FormattingEnabled = True
        Me.CbTurSecim.Location = New System.Drawing.Point(146, 277)
        Me.CbTurSecim.Name = "CbTurSecim"
        Me.CbTurSecim.Size = New System.Drawing.Size(187, 21)
        Me.CbTurSecim.TabIndex = 9
        '
        'CbDersSecim
        '
        Me.CbDersSecim.Anchor = System.Windows.Forms.AnchorStyles.None
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
        'BtnSinavIptal
        '
        Me.BtnSinavIptal.Location = New System.Drawing.Point(325, 606)
        Me.BtnSinavIptal.Name = "BtnSinavIptal"
        Me.BtnSinavIptal.Size = New System.Drawing.Size(109, 47)
        Me.BtnSinavIptal.TabIndex = 15
        Me.BtnSinavIptal.Text = "İptal"
        Me.BtnSinavIptal.UseVisualStyleBackColor = True
        '
        'AnaEkranForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 681)
        Me.Controls.Add(Me.GbMevcudatDuzenle)
        Me.Controls.Add(Me.GbYeniSinavOlustur)
        Me.Controls.Add(Me.GbAnaSayfa)
        Me.Name = "AnaEkranForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnaEkranForm"
        Me.GbAnaSayfa.ResumeLayout(False)
        Me.GbAnaSayfa.PerformLayout()
        Me.GbMevcudatDuzenle.ResumeLayout(False)
        Me.GbMevcudatDuzenle.PerformLayout()
        Me.GbYeniSinavOlustur.ResumeLayout(False)
        Me.GbYeniSinavOlustur.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GbDerslikSec.ResumeLayout(False)
        Me.GbDerslikSec.PerformLayout()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LbAsistanSecilecekSayi As Label
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents GbDerslikSec As GroupBox
    Friend WithEvents LbOgrenciYerlestirilecekSayi As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GbOgrenciDosya As GroupBox
    Friend WithEvents LbOgrenciSayiGoster As Label
    Friend WithEvents LbOgrenciSayiBilgi As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
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
End Class
