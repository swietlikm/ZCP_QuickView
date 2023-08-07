<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZCP_QV
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZCP_QV))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.OdświeżToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CzasCykluToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NarzędziaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaNarzędziToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WszystkieNarzędziaNaProdukcjiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GalileoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TB_wyspa = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TB_nr_masz = New System.Windows.Forms.TextBox()
        Me.TB_masz = New System.Windows.Forms.TextBox()
        Me.Menu_rozwijane = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WyszukajRysunekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NarzędziaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TB_status = New System.Windows.Forms.TextBox()
        Me.TB_lotto = New System.Windows.Forms.TextBox()
        Me.TB_cykl = New System.Windows.Forms.TextBox()
        Me.TB_kod = New System.Windows.Forms.TextBox()
        Me.TB_opis = New System.Windows.Forms.TextBox()
        Me.TB_ilosc_lotto = New System.Windows.Forms.TextBox()
        Me.TB_ilosc_wyp = New System.Windows.Forms.TextBox()
        Me.TB_pr_lotto = New System.Windows.Forms.TextBox()
        Me.TB_ilosc_nok = New System.Windows.Forms.TextBox()
        Me.TB_pr_nok = New System.Windows.Forms.TextBox()
        Me.TB_klient = New System.Windows.Forms.TextBox()
        Me.TB_mp = New System.Windows.Forms.TextBox()
        Me.TB_opis_mp = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BTx = New System.Windows.Forms.Button()
        Me.Process1 = New System.Diagnostics.Process()
        Me.ZaładujPusteMaszynyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.Menu_rozwijane.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status, Me.Status2, Me.Status3, Me.Status4})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 658)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1793, 26)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(49, 20)
        Me.Status.Text = "Status"
        '
        'Status2
        '
        Me.Status2.Name = "Status2"
        Me.Status2.Size = New System.Drawing.Size(49, 20)
        Me.Status2.Text = "Status"
        '
        'Status3
        '
        Me.Status3.Name = "Status3"
        Me.Status3.Size = New System.Drawing.Size(233, 20)
        Me.Status3.Text = "   Automatyczne odświeżanie co : "
        '
        'Status4
        '
        Me.Status4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Status4.ForeColor = System.Drawing.Color.Red
        Me.Status4.LinkColor = System.Drawing.Color.Red
        Me.Status4.Name = "Status4"
        Me.Status4.Size = New System.Drawing.Size(126, 20)
        Me.Status4.Text = "Widok filtrowany"
        Me.Status4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.Status4.Visible = False
        '
        'MainMenu
        '
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OdświeżToolStripMenuItem, Me.CzasCykluToolStripMenuItem, Me.NarzędziaToolStripMenuItem1, Me.ZaładujPusteMaszynyToolStripMenuItem, Me.ToolStripMenuItem1, Me.GalileoToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MainMenu.Size = New System.Drawing.Size(1793, 30)
        Me.MainMenu.TabIndex = 1
        Me.MainMenu.Text = "MenuStrip1"
        '
        'OdświeżToolStripMenuItem
        '
        Me.OdświeżToolStripMenuItem.Image = Global.ZCP_QV2.My.Resources.Resources.refresh
        Me.OdświeżToolStripMenuItem.Name = "OdświeżToolStripMenuItem"
        Me.OdświeżToolStripMenuItem.Size = New System.Drawing.Size(99, 26)
        Me.OdświeżToolStripMenuItem.Text = "Odśwież"
        '
        'CzasCykluToolStripMenuItem
        '
        Me.CzasCykluToolStripMenuItem.Image = Global.ZCP_QV2.My.Resources.Resources.stopwatch__1_
        Me.CzasCykluToolStripMenuItem.Name = "CzasCykluToolStripMenuItem"
        Me.CzasCykluToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.CzasCykluToolStripMenuItem.Text = "Czas cyklu"
        '
        'NarzędziaToolStripMenuItem1
        '
        Me.NarzędziaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaNarzędziToolStripMenuItem, Me.WszystkieNarzędziaNaProdukcjiToolStripMenuItem})
        Me.NarzędziaToolStripMenuItem1.Image = Global.ZCP_QV2.My.Resources.Resources.drill_bit
        Me.NarzędziaToolStripMenuItem1.Name = "NarzędziaToolStripMenuItem1"
        Me.NarzędziaToolStripMenuItem1.Size = New System.Drawing.Size(110, 26)
        Me.NarzędziaToolStripMenuItem1.Text = "Narzędzia"
        '
        'ListaNarzędziToolStripMenuItem
        '
        Me.ListaNarzędziToolStripMenuItem.Name = "ListaNarzędziToolStripMenuItem"
        Me.ListaNarzędziToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.ListaNarzędziToolStripMenuItem.Text = "Lista narzędzi"
        '
        'WszystkieNarzędziaNaProdukcjiToolStripMenuItem
        '
        Me.WszystkieNarzędziaNaProdukcjiToolStripMenuItem.Name = "WszystkieNarzędziaNaProdukcjiToolStripMenuItem"
        Me.WszystkieNarzędziaNaProdukcjiToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.WszystkieNarzędziaNaProdukcjiToolStripMenuItem.Text = "Narzędzia na produkcji"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.ZCP_QV2.My.Resources.Resources.information
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(34, 26)
        Me.ToolStripMenuItem1.Text = " "
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'GalileoToolStripMenuItem
        '
        Me.GalileoToolStripMenuItem.Image = Global.ZCP_QV2.My.Resources.Resources.LOGOG_1
        Me.GalileoToolStripMenuItem.Name = "GalileoToolStripMenuItem"
        Me.GalileoToolStripMenuItem.Size = New System.Drawing.Size(90, 26)
        Me.GalileoToolStripMenuItem.Text = "Galileo"
        Me.GalileoToolStripMenuItem.Visible = False
        '
        'TB_wyspa
        '
        Me.TB_wyspa.Location = New System.Drawing.Point(16, 37)
        Me.TB_wyspa.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_wyspa.Name = "TB_wyspa"
        Me.TB_wyspa.Size = New System.Drawing.Size(63, 22)
        Me.TB_wyspa.TabIndex = 3
        '
        'Timer
        '
        Me.Timer.Interval = 120000
        '
        'TB_nr_masz
        '
        Me.TB_nr_masz.Location = New System.Drawing.Point(88, 37)
        Me.TB_nr_masz.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_nr_masz.Name = "TB_nr_masz"
        Me.TB_nr_masz.Size = New System.Drawing.Size(44, 22)
        Me.TB_nr_masz.TabIndex = 4
        '
        'TB_masz
        '
        Me.TB_masz.Location = New System.Drawing.Point(141, 37)
        Me.TB_masz.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_masz.Name = "TB_masz"
        Me.TB_masz.Size = New System.Drawing.Size(124, 22)
        Me.TB_masz.TabIndex = 5
        '
        'Menu_rozwijane
        '
        Me.Menu_rozwijane.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Menu_rozwijane.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WyszukajRysunekToolStripMenuItem, Me.ToolStripSeparator1, Me.NarzędziaToolStripMenuItem})
        Me.Menu_rozwijane.Name = "Menu_rozwijane"
        Me.Menu_rozwijane.Size = New System.Drawing.Size(193, 58)
        '
        'WyszukajRysunekToolStripMenuItem
        '
        Me.WyszukajRysunekToolStripMenuItem.Name = "WyszukajRysunekToolStripMenuItem"
        Me.WyszukajRysunekToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.WyszukajRysunekToolStripMenuItem.Text = "Wyszukaj rysunek"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(189, 6)
        '
        'NarzędziaToolStripMenuItem
        '
        Me.NarzędziaToolStripMenuItem.Name = "NarzędziaToolStripMenuItem"
        Me.NarzędziaToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.NarzędziaToolStripMenuItem.Text = "Lista  narzędzi"
        '
        'TB_status
        '
        Me.TB_status.Location = New System.Drawing.Point(275, 37)
        Me.TB_status.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_status.Name = "TB_status"
        Me.TB_status.Size = New System.Drawing.Size(37, 22)
        Me.TB_status.TabIndex = 6
        '
        'TB_lotto
        '
        Me.TB_lotto.Location = New System.Drawing.Point(321, 37)
        Me.TB_lotto.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_lotto.Name = "TB_lotto"
        Me.TB_lotto.Size = New System.Drawing.Size(71, 22)
        Me.TB_lotto.TabIndex = 7
        '
        'TB_cykl
        '
        Me.TB_cykl.Location = New System.Drawing.Point(401, 37)
        Me.TB_cykl.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_cykl.Name = "TB_cykl"
        Me.TB_cykl.Size = New System.Drawing.Size(33, 22)
        Me.TB_cykl.TabIndex = 8
        '
        'TB_kod
        '
        Me.TB_kod.Location = New System.Drawing.Point(444, 37)
        Me.TB_kod.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_kod.Name = "TB_kod"
        Me.TB_kod.Size = New System.Drawing.Size(97, 22)
        Me.TB_kod.TabIndex = 9
        '
        'TB_opis
        '
        Me.TB_opis.Location = New System.Drawing.Point(551, 37)
        Me.TB_opis.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_opis.Name = "TB_opis"
        Me.TB_opis.Size = New System.Drawing.Size(231, 22)
        Me.TB_opis.TabIndex = 10
        '
        'TB_ilosc_lotto
        '
        Me.TB_ilosc_lotto.Location = New System.Drawing.Point(791, 37)
        Me.TB_ilosc_lotto.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_ilosc_lotto.Name = "TB_ilosc_lotto"
        Me.TB_ilosc_lotto.Size = New System.Drawing.Size(71, 22)
        Me.TB_ilosc_lotto.TabIndex = 11
        Me.TB_ilosc_lotto.Visible = False
        '
        'TB_ilosc_wyp
        '
        Me.TB_ilosc_wyp.Location = New System.Drawing.Point(871, 37)
        Me.TB_ilosc_wyp.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_ilosc_wyp.Name = "TB_ilosc_wyp"
        Me.TB_ilosc_wyp.Size = New System.Drawing.Size(71, 22)
        Me.TB_ilosc_wyp.TabIndex = 12
        Me.TB_ilosc_wyp.Visible = False
        '
        'TB_pr_lotto
        '
        Me.TB_pr_lotto.Location = New System.Drawing.Point(951, 37)
        Me.TB_pr_lotto.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_pr_lotto.Name = "TB_pr_lotto"
        Me.TB_pr_lotto.Size = New System.Drawing.Size(44, 22)
        Me.TB_pr_lotto.TabIndex = 13
        Me.TB_pr_lotto.Visible = False
        '
        'TB_ilosc_nok
        '
        Me.TB_ilosc_nok.Location = New System.Drawing.Point(1004, 37)
        Me.TB_ilosc_nok.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_ilosc_nok.Name = "TB_ilosc_nok"
        Me.TB_ilosc_nok.Size = New System.Drawing.Size(57, 22)
        Me.TB_ilosc_nok.TabIndex = 14
        Me.TB_ilosc_nok.Visible = False
        '
        'TB_pr_nok
        '
        Me.TB_pr_nok.Location = New System.Drawing.Point(1071, 37)
        Me.TB_pr_nok.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_pr_nok.Name = "TB_pr_nok"
        Me.TB_pr_nok.Size = New System.Drawing.Size(37, 22)
        Me.TB_pr_nok.TabIndex = 15
        Me.TB_pr_nok.Visible = False
        '
        'TB_klient
        '
        Me.TB_klient.Location = New System.Drawing.Point(1117, 37)
        Me.TB_klient.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_klient.Name = "TB_klient"
        Me.TB_klient.Size = New System.Drawing.Size(191, 22)
        Me.TB_klient.TabIndex = 16
        '
        'TB_mp
        '
        Me.TB_mp.Location = New System.Drawing.Point(1317, 37)
        Me.TB_mp.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_mp.Name = "TB_mp"
        Me.TB_mp.Size = New System.Drawing.Size(57, 22)
        Me.TB_mp.TabIndex = 17
        '
        'TB_opis_mp
        '
        Me.TB_opis_mp.Location = New System.Drawing.Point(1384, 37)
        Me.TB_opis_mp.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_opis_mp.Name = "TB_opis_mp"
        Me.TB_opis_mp.Size = New System.Drawing.Size(347, 22)
        Me.TB_opis_mp.TabIndex = 18
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Location = New System.Drawing.Point(16, 66)
        Me.DGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.ShowEditingIcon = False
        Me.DGV.Size = New System.Drawing.Size(1744, 588)
        Me.DGV.TabIndex = 19
        '
        'BTx
        '
        Me.BTx.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BTx.Location = New System.Drawing.Point(1738, 37)
        Me.BTx.Name = "BTx"
        Me.BTx.Size = New System.Drawing.Size(24, 23)
        Me.BTx.TabIndex = 20
        Me.BTx.Text = "X"
        Me.BTx.UseVisualStyleBackColor = True
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'ZaładujPusteMaszynyToolStripMenuItem
        '
        Me.ZaładujPusteMaszynyToolStripMenuItem.Image = Global.ZCP_QV2.My.Resources.Resources.industry
        Me.ZaładujPusteMaszynyToolStripMenuItem.Name = "ZaładujPusteMaszynyToolStripMenuItem"
        Me.ZaładujPusteMaszynyToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.ZaładujPusteMaszynyToolStripMenuItem.Text = "Wczytaj puste maszyny"
        '
        'ZCP_QV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1793, 684)
        Me.Controls.Add(Me.BTx)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TB_opis_mp)
        Me.Controls.Add(Me.TB_mp)
        Me.Controls.Add(Me.TB_klient)
        Me.Controls.Add(Me.TB_pr_nok)
        Me.Controls.Add(Me.TB_ilosc_nok)
        Me.Controls.Add(Me.TB_pr_lotto)
        Me.Controls.Add(Me.TB_ilosc_wyp)
        Me.Controls.Add(Me.TB_ilosc_lotto)
        Me.Controls.Add(Me.TB_opis)
        Me.Controls.Add(Me.TB_kod)
        Me.Controls.Add(Me.TB_cykl)
        Me.Controls.Add(Me.TB_lotto)
        Me.Controls.Add(Me.TB_status)
        Me.Controls.Add(Me.TB_masz)
        Me.Controls.Add(Me.TB_nr_masz)
        Me.Controls.Add(Me.TB_wyspa)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1533, 477)
        Me.Name = "ZCP_QV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZCP QuickView 2"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.Menu_rozwijane.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents Status As ToolStripStatusLabel
    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents OdświeżToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TB_wyspa As TextBox
    Friend WithEvents Timer As Timer
    Friend WithEvents Status2 As ToolStripStatusLabel
    Friend WithEvents TB_nr_masz As TextBox
    Friend WithEvents TB_masz As TextBox
    Friend WithEvents Status3 As ToolStripStatusLabel
    Friend WithEvents Menu_rozwijane As ContextMenuStrip
    Friend WithEvents WyszukajRysunekToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GalileoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TB_status As TextBox
    Friend WithEvents TB_lotto As TextBox
    Friend WithEvents TB_cykl As TextBox
    Friend WithEvents TB_kod As TextBox
    Friend WithEvents TB_opis As TextBox
    Friend WithEvents TB_ilosc_lotto As TextBox
    Friend WithEvents TB_ilosc_wyp As TextBox
    Friend WithEvents TB_pr_lotto As TextBox
    Friend WithEvents TB_ilosc_nok As TextBox
    Friend WithEvents TB_pr_nok As TextBox
    Friend WithEvents TB_klient As TextBox
    Friend WithEvents TB_mp As TextBox
    Friend WithEvents TB_opis_mp As TextBox
    Friend WithEvents Status4 As ToolStripStatusLabel
    Friend WithEvents DGV As DataGridView
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NarzędziaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NarzędziaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WszystkieNarzędziaNaProdukcjiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CzasCykluToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaNarzędziToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTx As Button
    Friend WithEvents Process1 As Process
    Friend WithEvents ZaładujPusteMaszynyToolStripMenuItem As ToolStripMenuItem
    'Friend DGV As FasterDataGridView
End Class
