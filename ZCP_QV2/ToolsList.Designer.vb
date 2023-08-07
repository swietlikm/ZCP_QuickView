<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ToolsList
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolsList))
        Me.DGV_tools = New System.Windows.Forms.DataGridView()
        Me.TB_kod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BT_wyszukaj = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_koszt_narzedzi = New System.Windows.Forms.TextBox()
        Me.TB_ilosc_narzedzi = New System.Windows.Forms.TextBox()
        Me.DGV_wybor = New System.Windows.Forms.DataGridView()
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
        CType(Me.DGV_tools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_wybor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DGV_tools.Location = New System.Drawing.Point(10, 119)
        Me.DGV_tools.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_tools.Name = "DGV_tools"
        Me.DGV_tools.ReadOnly = True
        Me.DGV_tools.RowHeadersVisible = False
        Me.DGV_tools.RowHeadersWidth = 51
        Me.DGV_tools.RowTemplate.Height = 24
        Me.DGV_tools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_tools.Size = New System.Drawing.Size(1028, 407)
        Me.DGV_tools.TabIndex = 9
        '
        'TB_kod
        '
        Me.TB_kod.BackColor = System.Drawing.SystemColors.Window
        Me.TB_kod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_kod.Location = New System.Drawing.Point(70, 49)
        Me.TB_kod.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_kod.Name = "TB_kod"
        Me.TB_kod.Size = New System.Drawing.Size(100, 20)
        Me.TB_kod.TabIndex = 0
        Me.TB_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "KodZP:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BT_wyszukaj)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TB_kod)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(274, 105)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Wyszukiwanie listy narzędzi"
        '
        'BT_wyszukaj
        '
        Me.BT_wyszukaj.Location = New System.Drawing.Point(175, 48)
        Me.BT_wyszukaj.Name = "BT_wyszukaj"
        Me.BT_wyszukaj.Size = New System.Drawing.Size(75, 23)
        Me.BT_wyszukaj.TabIndex = 13
        Me.BT_wyszukaj.Text = "Wyszukaj"
        Me.BT_wyszukaj.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TB_koszt_narzedzi)
        Me.GroupBox2.Controls.Add(Me.TB_ilosc_narzedzi)
        Me.GroupBox2.Controls.Add(Me.DGV_wybor)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 105)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dane"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Koszt na detal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Ilość narzędzi:"
        '
        'TB_koszt_narzedzi
        '
        Me.TB_koszt_narzedzi.BackColor = System.Drawing.SystemColors.Window
        Me.TB_koszt_narzedzi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_koszt_narzedzi.Location = New System.Drawing.Point(352, 59)
        Me.TB_koszt_narzedzi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_koszt_narzedzi.Name = "TB_koszt_narzedzi"
        Me.TB_koszt_narzedzi.Size = New System.Drawing.Size(66, 20)
        Me.TB_koszt_narzedzi.TabIndex = 18
        Me.TB_koszt_narzedzi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_ilosc_narzedzi
        '
        Me.TB_ilosc_narzedzi.BackColor = System.Drawing.SystemColors.Window
        Me.TB_ilosc_narzedzi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_ilosc_narzedzi.Location = New System.Drawing.Point(352, 36)
        Me.TB_ilosc_narzedzi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TB_ilosc_narzedzi.Name = "TB_ilosc_narzedzi"
        Me.TB_ilosc_narzedzi.Size = New System.Drawing.Size(66, 20)
        Me.TB_ilosc_narzedzi.TabIndex = 14
        Me.TB_ilosc_narzedzi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGV_wybor
        '
        Me.DGV_wybor.AllowUserToAddRows = False
        Me.DGV_wybor.AllowUserToDeleteRows = False
        Me.DGV_wybor.AllowUserToResizeColumns = False
        Me.DGV_wybor.AllowUserToResizeRows = False
        Me.DGV_wybor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_wybor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_wybor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DGV_wybor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.22!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_wybor.DefaultCellStyle = DataGridViewCellStyle14
        Me.DGV_wybor.Location = New System.Drawing.Point(54, 18)
        Me.DGV_wybor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_wybor.MultiSelect = False
        Me.DGV_wybor.Name = "DGV_wybor"
        Me.DGV_wybor.ReadOnly = True
        Me.DGV_wybor.RowHeadersVisible = False
        Me.DGV_wybor.RowHeadersWidth = 51
        Me.DGV_wybor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGV_wybor.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DGV_wybor.RowTemplate.Height = 18
        Me.DGV_wybor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_wybor.Size = New System.Drawing.Size(178, 78)
        Me.DGV_wybor.TabIndex = 17
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
        '
        'Producent
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Producent.DefaultCellStyle = DataGridViewCellStyle5
        Me.Producent.HeaderText = "Producent"
        Me.Producent.MinimumWidth = 6
        Me.Producent.Name = "Producent"
        Me.Producent.ReadOnly = True
        Me.Producent.Width = 125
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
        'ToolsList
        '
        Me.AcceptButton = Me.BT_wyszukaj
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 530)
        Me.Controls.Add(Me.DGV_tools)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ToolsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ToolsList"
        CType(Me.DGV_tools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV_wybor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_tools As DataGridView
    Friend WithEvents TB_kod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BT_wyszukaj As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV_wybor As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_koszt_narzedzi As TextBox
    Friend WithEvents TB_ilosc_narzedzi As TextBox
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
