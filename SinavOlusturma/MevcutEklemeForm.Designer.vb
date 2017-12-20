<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MevcutEklemeForm
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
        Me.LblEkleyiniz = New System.Windows.Forms.Label()
        Me.LblAdiGiriniz = New System.Windows.Forms.Label()
        Me.LblKoduGiriniz = New System.Windows.Forms.Label()
        Me.TbAdiGiriniz = New System.Windows.Forms.TextBox()
        Me.TbKoduGiriniz = New System.Windows.Forms.TextBox()
        Me.BtnEkle = New System.Windows.Forms.Button()
        Me.BtnDevam = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnGeri = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Sil = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnİptal = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblEkleyiniz
        '
        Me.LblEkleyiniz.AutoSize = True
        Me.LblEkleyiniz.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEkleyiniz.Location = New System.Drawing.Point(440, 43)
        Me.LblEkleyiniz.Name = "LblEkleyiniz"
        Me.LblEkleyiniz.Size = New System.Drawing.Size(150, 14)
        Me.LblEkleyiniz.TabIndex = 0
        Me.LblEkleyiniz.Text = "Mevcut Dersleri Ekleyiniz"
        '
        'LblAdiGiriniz
        '
        Me.LblAdiGiriniz.AutoSize = True
        Me.LblAdiGiriniz.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdiGiriniz.Location = New System.Drawing.Point(211, 195)
        Me.LblAdiGiriniz.Name = "LblAdiGiriniz"
        Me.LblAdiGiriniz.Size = New System.Drawing.Size(100, 14)
        Me.LblAdiGiriniz.TabIndex = 1
        Me.LblAdiGiriniz.Text = "Ders Adi Giriniz:"
        '
        'LblKoduGiriniz
        '
        Me.LblKoduGiriniz.AutoSize = True
        Me.LblKoduGiriniz.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKoduGiriniz.Location = New System.Drawing.Point(211, 253)
        Me.LblKoduGiriniz.Name = "LblKoduGiriniz"
        Me.LblKoduGiriniz.Size = New System.Drawing.Size(68, 14)
        Me.LblKoduGiriniz.TabIndex = 2
        Me.LblKoduGiriniz.Text = "Ders Kodu:"
        '
        'TbAdiGiriniz
        '
        Me.TbAdiGiriniz.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbAdiGiriniz.Location = New System.Drawing.Point(215, 213)
        Me.TbAdiGiriniz.Name = "TbAdiGiriniz"
        Me.TbAdiGiriniz.Size = New System.Drawing.Size(189, 20)
        Me.TbAdiGiriniz.TabIndex = 3
        '
        'TbKoduGiriniz
        '
        Me.TbKoduGiriniz.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbKoduGiriniz.Location = New System.Drawing.Point(215, 270)
        Me.TbKoduGiriniz.Name = "TbKoduGiriniz"
        Me.TbKoduGiriniz.Size = New System.Drawing.Size(189, 20)
        Me.TbKoduGiriniz.TabIndex = 4
        '
        'BtnEkle
        '
        Me.BtnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEkle.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEkle.Location = New System.Drawing.Point(229, 309)
        Me.BtnEkle.Name = "BtnEkle"
        Me.BtnEkle.Size = New System.Drawing.Size(161, 38)
        Me.BtnEkle.TabIndex = 5
        Me.BtnEkle.Text = "Ekle"
        Me.BtnEkle.UseVisualStyleBackColor = True
        '
        'BtnDevam
        '
        Me.BtnDevam.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDevam.Location = New System.Drawing.Point(443, 520)
        Me.BtnDevam.Name = "BtnDevam"
        Me.BtnDevam.Size = New System.Drawing.Size(195, 69)
        Me.BtnDevam.TabIndex = 6
        Me.BtnDevam.Text = "Devam"
        Me.BtnDevam.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(723, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(303, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Daha fazla detay için imleci verinin üzerine getiriniz."
        '
        'BtnGeri
        '
        Me.BtnGeri.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGeri.Location = New System.Drawing.Point(124, 564)
        Me.BtnGeri.Name = "BtnGeri"
        Me.BtnGeri.Size = New System.Drawing.Size(87, 25)
        Me.BtnGeri.TabIndex = 9
        Me.BtnGeri.Text = "Geri"
        Me.BtnGeri.UseVisualStyleBackColor = True
        Me.BtnGeri.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sil})
        Me.DataGridView2.Location = New System.Drawing.Point(566, 72)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(563, 348)
        Me.DataGridView2.TabIndex = 10
        '
        'Sil
        '
        Me.Sil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Sil.FillWeight = 10.0!
        Me.Sil.HeaderText = "Sil"
        Me.Sil.Name = "Sil"
        Me.Sil.ReadOnly = True
        Me.Sil.Text = "X"
        Me.Sil.UseColumnTextForButtonValue = True
        '
        'btnKaydet
        '
        Me.btnKaydet.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKaydet.Location = New System.Drawing.Point(317, 353)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(87, 25)
        Me.btnKaydet.TabIndex = 11
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = True
        Me.btnKaydet.Visible = False
        '
        'btnİptal
        '
        Me.btnİptal.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnİptal.Location = New System.Drawing.Point(215, 353)
        Me.btnİptal.Name = "btnİptal"
        Me.btnİptal.Size = New System.Drawing.Size(87, 25)
        Me.btnİptal.TabIndex = 12
        Me.btnİptal.Text = "İptal"
        Me.btnİptal.UseVisualStyleBackColor = True
        Me.btnİptal.Visible = False
        '
        'MevcutEklemeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 616)
        Me.Controls.Add(Me.btnİptal)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.BtnGeri)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnDevam)
        Me.Controls.Add(Me.BtnEkle)
        Me.Controls.Add(Me.TbKoduGiriniz)
        Me.Controls.Add(Me.TbAdiGiriniz)
        Me.Controls.Add(Me.LblKoduGiriniz)
        Me.Controls.Add(Me.LblAdiGiriniz)
        Me.Controls.Add(Me.LblEkleyiniz)
        Me.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MevcutEklemeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MevcutEklemeForm"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnGeri As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnKaydet As Button
    Friend WithEvents btnİptal As Button
    Friend WithEvents Sil As DataGridViewButtonColumn
End Class
