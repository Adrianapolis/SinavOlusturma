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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnGeri = New System.Windows.Forms.Button()
        Me.SilColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IcerilColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblEkleyiniz
        '
        Me.LblEkleyiniz.AutoSize = True
        Me.LblEkleyiniz.Location = New System.Drawing.Point(377, 40)
        Me.LblEkleyiniz.Name = "LblEkleyiniz"
        Me.LblEkleyiniz.Size = New System.Drawing.Size(125, 13)
        Me.LblEkleyiniz.TabIndex = 0
        Me.LblEkleyiniz.Text = "Mevcut Dersleri Ekleyiniz"
        '
        'LblAdiGiriniz
        '
        Me.LblAdiGiriniz.AutoSize = True
        Me.LblAdiGiriniz.Location = New System.Drawing.Point(181, 181)
        Me.LblAdiGiriniz.Name = "LblAdiGiriniz"
        Me.LblAdiGiriniz.Size = New System.Drawing.Size(81, 13)
        Me.LblAdiGiriniz.TabIndex = 1
        Me.LblAdiGiriniz.Text = "Ders Adi Giriniz:"
        '
        'LblKoduGiriniz
        '
        Me.LblKoduGiriniz.AutoSize = True
        Me.LblKoduGiriniz.Location = New System.Drawing.Point(181, 235)
        Me.LblKoduGiriniz.Name = "LblKoduGiriniz"
        Me.LblKoduGiriniz.Size = New System.Drawing.Size(60, 13)
        Me.LblKoduGiriniz.TabIndex = 2
        Me.LblKoduGiriniz.Text = "Ders Kodu:"
        '
        'TbAdiGiriniz
        '
        Me.TbAdiGiriniz.Location = New System.Drawing.Point(184, 198)
        Me.TbAdiGiriniz.Name = "TbAdiGiriniz"
        Me.TbAdiGiriniz.Size = New System.Drawing.Size(163, 20)
        Me.TbAdiGiriniz.TabIndex = 3
        '
        'TbKoduGiriniz
        '
        Me.TbKoduGiriniz.Location = New System.Drawing.Point(184, 251)
        Me.TbKoduGiriniz.Name = "TbKoduGiriniz"
        Me.TbKoduGiriniz.Size = New System.Drawing.Size(163, 20)
        Me.TbKoduGiriniz.TabIndex = 4
        '
        'BtnEkle
        '
        Me.BtnEkle.Location = New System.Drawing.Point(196, 287)
        Me.BtnEkle.Name = "BtnEkle"
        Me.BtnEkle.Size = New System.Drawing.Size(138, 23)
        Me.BtnEkle.TabIndex = 5
        Me.BtnEkle.Text = "Ekle"
        Me.BtnEkle.UseVisualStyleBackColor = True
        '
        'BtnDevam
        '
        Me.BtnDevam.Location = New System.Drawing.Point(380, 483)
        Me.BtnDevam.Name = "BtnDevam"
        Me.BtnDevam.Size = New System.Drawing.Size(167, 64)
        Me.BtnDevam.TabIndex = 6
        Me.BtnDevam.Text = "Devam"
        Me.BtnDevam.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SilColumn, Me.IcerilColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(609, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(270, 260)
        Me.DataGridView1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(620, 393)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Daha fazla detay için imleci verinin üzerine getiriniz."
        '
        'BtnGeri
        '
        Me.BtnGeri.Location = New System.Drawing.Point(106, 524)
        Me.BtnGeri.Name = "BtnGeri"
        Me.BtnGeri.Size = New System.Drawing.Size(75, 23)
        Me.BtnGeri.TabIndex = 9
        Me.BtnGeri.Text = "Geri"
        Me.BtnGeri.UseVisualStyleBackColor = True
        Me.BtnGeri.Visible = False
        '
        'SilColumn
        '
        Me.SilColumn.FillWeight = 25.0!
        Me.SilColumn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SilColumn.HeaderText = "Sil"
        Me.SilColumn.Name = "SilColumn"
        Me.SilColumn.Width = 25
        '
        'IcerilColumn
        '
        Me.IcerilColumn.HeaderText = "Adı"
        Me.IcerilColumn.Name = "IcerilColumn"
        Me.IcerilColumn.ReadOnly = True
        Me.IcerilColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IcerilColumn.Width = 200
        '
        'MevcutEklemeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 572)
        Me.Controls.Add(Me.BtnGeri)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnDevam)
        Me.Controls.Add(Me.BtnEkle)
        Me.Controls.Add(Me.TbKoduGiriniz)
        Me.Controls.Add(Me.TbAdiGiriniz)
        Me.Controls.Add(Me.LblKoduGiriniz)
        Me.Controls.Add(Me.LblAdiGiriniz)
        Me.Controls.Add(Me.LblEkleyiniz)
        Me.Name = "MevcutEklemeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MevcutEklemeForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnGeri As Button
    Friend WithEvents SilColumn As DataGridViewButtonColumn
    Friend WithEvents IcerilColumn As DataGridViewTextBoxColumn
End Class
