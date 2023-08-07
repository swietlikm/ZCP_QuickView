<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loading
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
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(12, 13)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(290, 23)
        Me.PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PB.TabIndex = 0
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 52)
        Me.Controls.Add(Me.PB)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Loading"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PB As ProgressBar
End Class
