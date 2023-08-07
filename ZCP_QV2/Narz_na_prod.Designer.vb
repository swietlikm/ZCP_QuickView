<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Narz_na_prod
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Narz_na_prod))
        Me.DGV_tools_prod = New System.Windows.Forms.DataGridView()
        Me.F_wyspa = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Status1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.F_nr_maszyny = New System.Windows.Forms.TextBox()
        Me.F_maszyna = New System.Windows.Forms.TextBox()
        Me.F_lotto = New System.Windows.Forms.TextBox()
        Me.F_kod_zp = New System.Windows.Forms.TextBox()
        Me.F_pozycja = New System.Windows.Forms.TextBox()
        Me.F_producent = New System.Windows.Forms.TextBox()
        Me.F_typ = New System.Windows.Forms.TextBox()
        Me.F_kod_narzedzia = New System.Windows.Forms.TextBox()
        Me.F_barcode = New System.Windows.Forms.TextBox()
        Me.F_wytrzym = New System.Windows.Forms.TextBox()
        Me.F_kraw = New System.Windows.Forms.TextBox()
        Me.F_mag = New System.Windows.Forms.TextBox()
        CType(Me.DGV_tools_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_tools_prod
        '
        Me.DGV_tools_prod.AllowUserToAddRows = False
        Me.DGV_tools_prod.AllowUserToDeleteRows = False
        Me.DGV_tools_prod.AllowUserToResizeColumns = False
        Me.DGV_tools_prod.AllowUserToResizeRows = False
        Me.DGV_tools_prod.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_tools_prod.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_tools_prod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_tools_prod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_tools_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_tools_prod.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_tools_prod.Location = New System.Drawing.Point(12, 33)
        Me.DGV_tools_prod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_tools_prod.MultiSelect = False
        Me.DGV_tools_prod.Name = "DGV_tools_prod"
        Me.DGV_tools_prod.ReadOnly = True
        Me.DGV_tools_prod.RowHeadersVisible = False
        Me.DGV_tools_prod.RowHeadersWidth = 51
        Me.DGV_tools_prod.RowTemplate.Height = 24
        Me.DGV_tools_prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_tools_prod.Size = New System.Drawing.Size(1169, 393)
        Me.DGV_tools_prod.TabIndex = 9
        '
        'F_wyspa
        '
        Me.F_wyspa.Location = New System.Drawing.Point(12, 8)
        Me.F_wyspa.Name = "F_wyspa"
        Me.F_wyspa.Size = New System.Drawing.Size(49, 20)
        Me.F_wyspa.TabIndex = 10
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1193, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Status1
        '
        Me.Status1.Name = "Status1"
        Me.Status1.Size = New System.Drawing.Size(39, 17)
        Me.Status1.Text = "Status"
        '
        'F_nr_maszyny
        '
        Me.F_nr_maszyny.Location = New System.Drawing.Point(67, 8)
        Me.F_nr_maszyny.Name = "F_nr_maszyny"
        Me.F_nr_maszyny.Size = New System.Drawing.Size(34, 20)
        Me.F_nr_maszyny.TabIndex = 12
        '
        'F_maszyna
        '
        Me.F_maszyna.Location = New System.Drawing.Point(107, 8)
        Me.F_maszyna.Name = "F_maszyna"
        Me.F_maszyna.Size = New System.Drawing.Size(94, 20)
        Me.F_maszyna.TabIndex = 13
        '
        'F_lotto
        '
        Me.F_lotto.Location = New System.Drawing.Point(207, 8)
        Me.F_lotto.Name = "F_lotto"
        Me.F_lotto.Size = New System.Drawing.Size(64, 20)
        Me.F_lotto.TabIndex = 14
        '
        'F_kod_zp
        '
        Me.F_kod_zp.Location = New System.Drawing.Point(277, 8)
        Me.F_kod_zp.Name = "F_kod_zp"
        Me.F_kod_zp.Size = New System.Drawing.Size(74, 20)
        Me.F_kod_zp.TabIndex = 15
        '
        'F_pozycja
        '
        Me.F_pozycja.Location = New System.Drawing.Point(357, 8)
        Me.F_pozycja.Name = "F_pozycja"
        Me.F_pozycja.Size = New System.Drawing.Size(44, 20)
        Me.F_pozycja.TabIndex = 16
        '
        'F_producent
        '
        Me.F_producent.Location = New System.Drawing.Point(407, 8)
        Me.F_producent.Name = "F_producent"
        Me.F_producent.Size = New System.Drawing.Size(94, 20)
        Me.F_producent.TabIndex = 17
        '
        'F_typ
        '
        Me.F_typ.Location = New System.Drawing.Point(507, 8)
        Me.F_typ.Name = "F_typ"
        Me.F_typ.Size = New System.Drawing.Size(84, 20)
        Me.F_typ.TabIndex = 18
        '
        'F_kod_narzedzia
        '
        Me.F_kod_narzedzia.Location = New System.Drawing.Point(597, 8)
        Me.F_kod_narzedzia.Name = "F_kod_narzedzia"
        Me.F_kod_narzedzia.Size = New System.Drawing.Size(214, 20)
        Me.F_kod_narzedzia.TabIndex = 19
        '
        'F_barcode
        '
        Me.F_barcode.Location = New System.Drawing.Point(817, 8)
        Me.F_barcode.Name = "F_barcode"
        Me.F_barcode.Size = New System.Drawing.Size(184, 20)
        Me.F_barcode.TabIndex = 20
        '
        'F_wytrzym
        '
        Me.F_wytrzym.Location = New System.Drawing.Point(1007, 8)
        Me.F_wytrzym.Name = "F_wytrzym"
        Me.F_wytrzym.Size = New System.Drawing.Size(69, 20)
        Me.F_wytrzym.TabIndex = 21
        Me.F_wytrzym.Visible = False
        '
        'F_kraw
        '
        Me.F_kraw.Location = New System.Drawing.Point(1082, 8)
        Me.F_kraw.Name = "F_kraw"
        Me.F_kraw.Size = New System.Drawing.Size(34, 20)
        Me.F_kraw.TabIndex = 22
        Me.F_kraw.Visible = False
        '
        'F_mag
        '
        Me.F_mag.Location = New System.Drawing.Point(1122, 8)
        Me.F_mag.Name = "F_mag"
        Me.F_mag.Size = New System.Drawing.Size(34, 20)
        Me.F_mag.TabIndex = 23
        Me.F_mag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Narz_na_prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 450)
        Me.Controls.Add(Me.F_mag)
        Me.Controls.Add(Me.F_kraw)
        Me.Controls.Add(Me.F_wytrzym)
        Me.Controls.Add(Me.F_barcode)
        Me.Controls.Add(Me.F_kod_narzedzia)
        Me.Controls.Add(Me.F_typ)
        Me.Controls.Add(Me.F_producent)
        Me.Controls.Add(Me.F_pozycja)
        Me.Controls.Add(Me.F_kod_zp)
        Me.Controls.Add(Me.F_lotto)
        Me.Controls.Add(Me.F_maszyna)
        Me.Controls.Add(Me.F_nr_maszyny)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.F_wyspa)
        Me.Controls.Add(Me.DGV_tools_prod)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Narz_na_prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Wszystkie narzędzia na produkcji"
        CType(Me.DGV_tools_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_tools_prod As DataGridView
    Friend WithEvents F_wyspa As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Status1 As ToolStripStatusLabel
    Friend WithEvents F_nr_maszyny As TextBox
    Friend WithEvents F_maszyna As TextBox
    Friend WithEvents F_lotto As TextBox
    Friend WithEvents F_kod_zp As TextBox
    Friend WithEvents F_pozycja As TextBox
    Friend WithEvents F_producent As TextBox
    Friend WithEvents F_typ As TextBox
    Friend WithEvents F_kod_narzedzia As TextBox
    Friend WithEvents F_barcode As TextBox
    Friend WithEvents F_wytrzym As TextBox
    Friend WithEvents F_kraw As TextBox
    Friend WithEvents F_mag As TextBox
End Class
