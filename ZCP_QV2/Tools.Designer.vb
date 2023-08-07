<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tools
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tools))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_procenty = New System.Windows.Forms.TextBox()
        Me.TB_faza = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_cykl = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_bolla = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_maszyna = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_lotto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_opis = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_kod = New System.Windows.Forms.TextBox()
        Me.DGV_tools = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TB_ile_narz = New System.Windows.Forms.Label()
        Me.TB_l_narz = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TB_koszt = New System.Windows.Forms.TextBox()
        Me.Pozycja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Korektor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opis_pracy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kod_narzedzia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wytrzymalosc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.l_krawedzi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cena = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stan_mag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_tools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TB_procenty)
        Me.GroupBox1.Controls.Add(Me.TB_faza)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TB_cykl)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TB_bolla)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TB_maszyna)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TB_lotto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TB_opis)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TB_kod)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(519, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacje"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(373, 72)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Stan Lotto:"
        '
        'TB_procenty
        '
        Me.TB_procenty.BackColor = System.Drawing.SystemColors.Window
        Me.TB_procenty.Location = New System.Drawing.Point(435, 70)
        Me.TB_procenty.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_procenty.Name = "TB_procenty"
        Me.TB_procenty.ReadOnly = True
        Me.TB_procenty.Size = New System.Drawing.Size(76, 20)
        Me.TB_procenty.TabIndex = 37
        Me.TB_procenty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_faza
        '
        Me.TB_faza.BackColor = System.Drawing.SystemColors.Window
        Me.TB_faza.Location = New System.Drawing.Point(250, 70)
        Me.TB_faza.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_faza.Name = "TB_faza"
        Me.TB_faza.ReadOnly = True
        Me.TB_faza.Size = New System.Drawing.Size(76, 20)
        Me.TB_faza.TabIndex = 6
        Me.TB_faza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(213, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Faza:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 72)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Cykl:"
        '
        'TB_cykl
        '
        Me.TB_cykl.BackColor = System.Drawing.SystemColors.Window
        Me.TB_cykl.Location = New System.Drawing.Point(78, 69)
        Me.TB_cykl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_cykl.Name = "TB_cykl"
        Me.TB_cykl.ReadOnly = True
        Me.TB_cykl.Size = New System.Drawing.Size(76, 20)
        Me.TB_cykl.TabIndex = 5
        Me.TB_cykl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(403, 24)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Kwit:"
        '
        'TB_bolla
        '
        Me.TB_bolla.BackColor = System.Drawing.SystemColors.Window
        Me.TB_bolla.Location = New System.Drawing.Point(435, 22)
        Me.TB_bolla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_bolla.Name = "TB_bolla"
        Me.TB_bolla.ReadOnly = True
        Me.TB_bolla.Size = New System.Drawing.Size(76, 20)
        Me.TB_bolla.TabIndex = 2
        Me.TB_bolla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Maszyna:"
        '
        'TB_maszyna
        '
        Me.TB_maszyna.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TB_maszyna.ForeColor = System.Drawing.Color.Black
        Me.TB_maszyna.Location = New System.Drawing.Point(78, 21)
        Me.TB_maszyna.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_maszyna.Name = "TB_maszyna"
        Me.TB_maszyna.ReadOnly = True
        Me.TB_maszyna.Size = New System.Drawing.Size(76, 20)
        Me.TB_maszyna.TabIndex = 0
        Me.TB_maszyna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(212, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lotto:"
        '
        'TB_lotto
        '
        Me.TB_lotto.BackColor = System.Drawing.SystemColors.Window
        Me.TB_lotto.Location = New System.Drawing.Point(250, 22)
        Me.TB_lotto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_lotto.Name = "TB_lotto"
        Me.TB_lotto.ReadOnly = True
        Me.TB_lotto.Size = New System.Drawing.Size(103, 20)
        Me.TB_lotto.TabIndex = 1
        Me.TB_lotto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Opis:"
        '
        'TB_opis
        '
        Me.TB_opis.BackColor = System.Drawing.SystemColors.Window
        Me.TB_opis.Location = New System.Drawing.Point(250, 46)
        Me.TB_opis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_opis.Name = "TB_opis"
        Me.TB_opis.ReadOnly = True
        Me.TB_opis.Size = New System.Drawing.Size(261, 20)
        Me.TB_opis.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kod:"
        '
        'TB_kod
        '
        Me.TB_kod.BackColor = System.Drawing.SystemColors.Window
        Me.TB_kod.Location = New System.Drawing.Point(78, 45)
        Me.TB_kod.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_kod.Name = "TB_kod"
        Me.TB_kod.ReadOnly = True
        Me.TB_kod.Size = New System.Drawing.Size(76, 20)
        Me.TB_kod.TabIndex = 3
        Me.TB_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGV_tools
        '
        Me.DGV_tools.AllowUserToAddRows = False
        Me.DGV_tools.AllowUserToDeleteRows = False
        Me.DGV_tools.AllowUserToResizeColumns = False
        Me.DGV_tools.AllowUserToResizeRows = False
        Me.DGV_tools.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_tools.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_tools.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_tools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_tools.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pozycja, Me.Korektor, Me.opis_pracy, Me.Producent, Me.kod_narzedzia, Me.barcode, Me.wytrzymalosc, Me.l_krawedzi, Me.Cena, Me.stan_mag})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_tools.DefaultCellStyle = DataGridViewCellStyle12
        Me.DGV_tools.Location = New System.Drawing.Point(10, 115)
        Me.DGV_tools.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_tools.MultiSelect = False
        Me.DGV_tools.Name = "DGV_tools"
        Me.DGV_tools.ReadOnly = True
        Me.DGV_tools.RowHeadersVisible = False
        Me.DGV_tools.RowHeadersWidth = 51
        Me.DGV_tools.RowTemplate.Height = 24
        Me.DGV_tools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_tools.Size = New System.Drawing.Size(1028, 407)
        Me.DGV_tools.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TB_ile_narz)
        Me.GroupBox2.Controls.Add(Me.TB_l_narz)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TB_koszt)
        Me.GroupBox2.Location = New System.Drawing.Point(533, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(197, 100)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Narzędzia"
        '
        'TB_ile_narz
        '
        Me.TB_ile_narz.AutoSize = True
        Me.TB_ile_narz.Location = New System.Drawing.Point(37, 23)
        Me.TB_ile_narz.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TB_ile_narz.Name = "TB_ile_narz"
        Me.TB_ile_narz.Size = New System.Drawing.Size(61, 13)
        Me.TB_ile_narz.TabIndex = 34
        Me.TB_ile_narz.Text = "L. narzędzi:"
        '
        'TB_l_narz
        '
        Me.TB_l_narz.BackColor = System.Drawing.SystemColors.Window
        Me.TB_l_narz.Location = New System.Drawing.Point(103, 22)
        Me.TB_l_narz.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_l_narz.Name = "TB_l_narz"
        Me.TB_l_narz.ReadOnly = True
        Me.TB_l_narz.Size = New System.Drawing.Size(76, 20)
        Me.TB_l_narz.TabIndex = 8
        Me.TB_l_narz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 48)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Koszt na detal:"
        '
        'TB_koszt
        '
        Me.TB_koszt.BackColor = System.Drawing.SystemColors.Window
        Me.TB_koszt.Location = New System.Drawing.Point(103, 46)
        Me.TB_koszt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_koszt.Name = "TB_koszt"
        Me.TB_koszt.ReadOnly = True
        Me.TB_koszt.Size = New System.Drawing.Size(76, 20)
        Me.TB_koszt.TabIndex = 7
        Me.TB_koszt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pozycja
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Pozycja.DefaultCellStyle = DataGridViewCellStyle2
        Me.Pozycja.HeaderText = "Pozycja"
        Me.Pozycja.MinimumWidth = 6
        Me.Pozycja.Name = "Pozycja"
        Me.Pozycja.ReadOnly = True
        Me.Pozycja.Width = 50
        '
        'Korektor
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Korektor.DefaultCellStyle = DataGridViewCellStyle3
        Me.Korektor.HeaderText = "Korektor"
        Me.Korektor.MinimumWidth = 6
        Me.Korektor.Name = "Korektor"
        Me.Korektor.ReadOnly = True
        Me.Korektor.Width = 50
        '
        'opis_pracy
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.opis_pracy.DefaultCellStyle = DataGridViewCellStyle4
        Me.opis_pracy.HeaderText = "Opis"
        Me.opis_pracy.MinimumWidth = 6
        Me.opis_pracy.Name = "opis_pracy"
        Me.opis_pracy.ReadOnly = True
        Me.opis_pracy.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.opis_pracy.Width = 125
        '
        'Producent
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Producent.DefaultCellStyle = DataGridViewCellStyle5
        Me.Producent.HeaderText = "Producent"
        Me.Producent.MinimumWidth = 6
        Me.Producent.Name = "Producent"
        Me.Producent.ReadOnly = True
        '
        'kod_narzedzia
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kod_narzedzia.DefaultCellStyle = DataGridViewCellStyle6
        Me.kod_narzedzia.HeaderText = "Kod narzędzia"
        Me.kod_narzedzia.MinimumWidth = 6
        Me.kod_narzedzia.Name = "kod_narzedzia"
        Me.kod_narzedzia.ReadOnly = True
        Me.kod_narzedzia.Width = 230
        '
        'barcode
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.barcode.DefaultCellStyle = DataGridViewCellStyle7
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.MinimumWidth = 6
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = True
        Me.barcode.Width = 200
        '
        'wytrzymalosc
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.wytrzymalosc.DefaultCellStyle = DataGridViewCellStyle8
        Me.wytrzymalosc.HeaderText = "Wytrzymałość"
        Me.wytrzymalosc.MinimumWidth = 6
        Me.wytrzymalosc.Name = "wytrzymalosc"
        Me.wytrzymalosc.ReadOnly = True
        Me.wytrzymalosc.Width = 80
        '
        'l_krawedzi
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.l_krawedzi.DefaultCellStyle = DataGridViewCellStyle9
        Me.l_krawedzi.HeaderText = "Ilość krawędzi"
        Me.l_krawedzi.MinimumWidth = 6
        Me.l_krawedzi.Name = "l_krawedzi"
        Me.l_krawedzi.ReadOnly = True
        Me.l_krawedzi.Width = 50
        '
        'Cena
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cena.DefaultCellStyle = DataGridViewCellStyle10
        Me.Cena.HeaderText = "Cena €"
        Me.Cena.MinimumWidth = 6
        Me.Cena.Name = "Cena"
        Me.Cena.ReadOnly = True
        Me.Cena.Width = 65
        '
        'stan_mag
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.stan_mag.DefaultCellStyle = DataGridViewCellStyle11
        Me.stan_mag.HeaderText = "Stan Mag"
        Me.stan_mag.MinimumWidth = 6
        Me.stan_mag.Name = "stan_mag"
        Me.stan_mag.ReadOnly = True
        Me.stan_mag.Width = 50
        '
        'Tools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 530)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGV_tools)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tools"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_tools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_kod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_opis As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_lotto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_bolla As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_maszyna As TextBox
    Friend WithEvents TB_faza As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_cykl As TextBox
    Friend WithEvents DGV_tools As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TB_ile_narz As Label
    Friend WithEvents TB_l_narz As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TB_koszt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_procenty As TextBox
    Friend WithEvents Pozycja As DataGridViewTextBoxColumn
    Friend WithEvents Korektor As DataGridViewTextBoxColumn
    Friend WithEvents opis_pracy As DataGridViewTextBoxColumn
    Friend WithEvents Producent As DataGridViewTextBoxColumn
    Friend WithEvents kod_narzedzia As DataGridViewTextBoxColumn
    Friend WithEvents barcode As DataGridViewTextBoxColumn
    Friend WithEvents wytrzymalosc As DataGridViewTextBoxColumn
    Friend WithEvents l_krawedzi As DataGridViewTextBoxColumn
    Friend WithEvents Cena As DataGridViewTextBoxColumn
    Friend WithEvents stan_mag As DataGridViewTextBoxColumn
End Class
