<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MevcutEklemeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MevcutEklemeForm))
        Me.LblEkleyiniz = New System.Windows.Forms.Label()
        Me.LblAdiGiriniz = New System.Windows.Forms.Label()
        Me.LblKoduGiriniz = New System.Windows.Forms.Label()
        Me.TbAdiGiriniz = New System.Windows.Forms.TextBox()
        Me.TbKoduGiriniz = New System.Windows.Forms.TextBox()
        Me.BtnEkle = New System.Windows.Forms.Button()
        Me.BtnDevam = New System.Windows.Forms.Button()
        Me.BtnGeri = New System.Windows.Forms.Button()
        Me.dgMevcutEkleme = New System.Windows.Forms.DataGridView()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnİptal = New System.Windows.Forms.Button()
        Me.Sil = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgMevcutEkleme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblEkleyiniz
        '
        Me.LblEkleyiniz.AutoSize = True
        Me.LblEkleyiniz.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblEkleyiniz.Location = New System.Drawing.Point(377, 40)
        Me.LblEkleyiniz.Name = "LblEkleyiniz"
        Me.LblEkleyiniz.Size = New System.Drawing.Size(247, 29)
        Me.LblEkleyiniz.TabIndex = 0
        Me.LblEkleyiniz.Text = "Mevcut Dersleri Ekleyiniz"
        '
        'LblAdiGiriniz
        '
        Me.LblAdiGiriniz.AutoSize = True
        Me.LblAdiGiriniz.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LblAdiGiriniz.Location = New System.Drawing.Point(181, 181)
        Me.LblAdiGiriniz.Name = "LblAdiGiriniz"
        Me.LblAdiGiriniz.Size = New System.Drawing.Size(115, 20)
        Me.LblAdiGiriniz.TabIndex = 1
        Me.LblAdiGiriniz.Text = "Ders Adı Giriniz :"
        '
        'LblKoduGiriniz
        '
        Me.LblKoduGiriniz.AutoSize = True
        Me.LblKoduGiriniz.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LblKoduGiriniz.Location = New System.Drawing.Point(180, 241)
        Me.LblKoduGiriniz.Name = "LblKoduGiriniz"
        Me.LblKoduGiriniz.Size = New System.Drawing.Size(78, 20)
        Me.LblKoduGiriniz.TabIndex = 2
        Me.LblKoduGiriniz.Text = "Ders Kodu:"
        '
        'TbAdiGiriniz
        '
        Me.TbAdiGiriniz.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TbAdiGiriniz.Location = New System.Drawing.Point(184, 204)
        Me.TbAdiGiriniz.Name = "TbAdiGiriniz"
        Me.TbAdiGiriniz.Size = New System.Drawing.Size(163, 26)
        Me.TbAdiGiriniz.TabIndex = 3
        '
        'TbKoduGiriniz
        '
        Me.TbKoduGiriniz.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TbKoduGiriniz.Location = New System.Drawing.Point(184, 264)
        Me.TbKoduGiriniz.Name = "TbKoduGiriniz"
        Me.TbKoduGiriniz.Size = New System.Drawing.Size(163, 26)
        Me.TbKoduGiriniz.TabIndex = 4
        '
        'BtnEkle
        '
        Me.BtnEkle.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEkle.Location = New System.Drawing.Point(184, 307)
        Me.BtnEkle.Name = "BtnEkle"
        Me.BtnEkle.Size = New System.Drawing.Size(163, 34)
        Me.BtnEkle.TabIndex = 5
        Me.BtnEkle.Text = "Ekle"
        Me.BtnEkle.UseVisualStyleBackColor = True
        '
        'BtnDevam
        '
        Me.BtnDevam.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDevam.Location = New System.Drawing.Point(380, 483)
        Me.BtnDevam.Name = "BtnDevam"
        Me.BtnDevam.Size = New System.Drawing.Size(167, 64)
        Me.BtnDevam.TabIndex = 6
        Me.BtnDevam.Text = "Devam"
        Me.BtnDevam.UseVisualStyleBackColor = True
        '
        'BtnGeri
        '
        Me.BtnGeri.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGeri.Location = New System.Drawing.Point(106, 508)
        Me.BtnGeri.Name = "BtnGeri"
        Me.BtnGeri.Size = New System.Drawing.Size(98, 39)
        Me.BtnGeri.TabIndex = 9
        Me.BtnGeri.Text = "Geri"
        Me.BtnGeri.UseVisualStyleBackColor = True
        Me.BtnGeri.Visible = False
        '
        'dgMevcutEkleme
        '
        Me.dgMevcutEkleme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMevcutEkleme.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMevcutEkleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMevcutEkleme.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sil})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMevcutEkleme.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgMevcutEkleme.Location = New System.Drawing.Point(483, 99)
        Me.dgMevcutEkleme.MultiSelect = False
        Me.dgMevcutEkleme.Name = "dgMevcutEkleme"
        Me.dgMevcutEkleme.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMevcutEkleme.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgMevcutEkleme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMevcutEkleme.Size = New System.Drawing.Size(483, 323)
        Me.dgMevcutEkleme.TabIndex = 10
        '
        'btnKaydet
        '
        Me.btnKaydet.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnKaydet.Location = New System.Drawing.Point(269, 347)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(78, 34)
        Me.btnKaydet.TabIndex = 11
        Me.btnKaydet.Text = "  Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = True
        Me.btnKaydet.Visible = False
        '
        'btnİptal
        '
        Me.btnİptal.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnİptal.Location = New System.Drawing.Point(185, 347)
        Me.btnİptal.Name = "btnİptal"
        Me.btnİptal.Size = New System.Drawing.Size(78, 34)
        Me.btnİptal.TabIndex = 12
        Me.btnİptal.Text = "  İptal"
        Me.btnİptal.UseVisualStyleBackColor = True
        Me.btnİptal.Visible = False
        '
        'Sil
        '
        Me.Sil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Sil.FillWeight = 30.0!
        Me.Sil.HeaderText = "Sil"
        Me.Sil.Name = "Sil"
        Me.Sil.ReadOnly = True
        Me.Sil.Text = "X"
        Me.Sil.UseColumnTextForButtonValue = True
        '
        'MevcutEklemeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 572)
        Me.Controls.Add(Me.btnİptal)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.dgMevcutEkleme)
        Me.Controls.Add(Me.BtnGeri)
        Me.Controls.Add(Me.BtnDevam)
        Me.Controls.Add(Me.BtnEkle)
        Me.Controls.Add(Me.TbKoduGiriniz)
        Me.Controls.Add(Me.TbAdiGiriniz)
        Me.Controls.Add(Me.LblKoduGiriniz)
        Me.Controls.Add(Me.LblAdiGiriniz)
        Me.Controls.Add(Me.LblEkleyiniz)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MevcutEklemeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sınav Oluşturma Programı - Ekleme / Düzenle"
        CType(Me.dgMevcutEkleme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblEkleyiniz As Label
    Friend WithEvents LblAdiGiriniz As Label
    Friend WithEvents LblKoduGiriniz As Label
    Friend WithEvents TbAdiGiriniz As TextBox
    Friend WithEvents TbKoduGiriniz As TextBox
    Friend WithEvents BtnEkle As Button
    Friend WithEvents BtnDevam As Button
    Friend WithEvents BtnGeri As Button
    Friend WithEvents dgMevcutEkleme As DataGridView
    Friend WithEvents btnKaydet As Button
    Friend WithEvents btnİptal As Button
    Friend WithEvents Sil As DataGridViewButtonColumn
End Class
