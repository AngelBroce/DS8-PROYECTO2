<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDepositos
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents ButtonVolver As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuCheques As ToolStripMenuItem
    Friend WithEvents mnuDepositos As ToolStripMenuItem
    Friend WithEvents mnuConciliacion As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuSalir As ToolStripMenuItem

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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonVolver = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuCheques = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDepositos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConciliacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspendLayout()
        '
        ' MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCheques, Me.mnuDepositos, Me.mnuConciliacion, Me.ToolStripSeparator1, Me.mnuSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(300, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "menuStrip1"
        '
        ' mnuCheques
        '
        Me.mnuCheques.Name = "mnuCheques"
        Me.mnuCheques.Size = New System.Drawing.Size(66, 20)
        Me.mnuCheques.Text = "Cheques"
        '
        ' mnuDepositos
        '
        Me.mnuDepositos.Name = "mnuDepositos"
        Me.mnuDepositos.Size = New System.Drawing.Size(73, 20)
        Me.mnuDepositos.Text = "Depósitos"
        '
        ' mnuConciliacion
        '
        Me.mnuConciliacion.Name = "mnuConciliacion"
        Me.mnuConciliacion.Size = New System.Drawing.Size(90, 20)
        Me.mnuConciliacion.Text = "Conciliación"
        '
        ' ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        ' mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(41, 20)
        Me.mnuSalir.Text = "Salir"
        '
        ' ButtonVolver
        '
        Me.ButtonVolver.Location = New System.Drawing.Point(75, 110)
        Me.ButtonVolver.Name = "ButtonVolver"
        Me.ButtonVolver.Size = New System.Drawing.Size(150, 40)
        Me.ButtonVolver.TabIndex = 0
        Me.ButtonVolver.Text = "Volver al menú"
        Me.ButtonVolver.UseVisualStyleBackColor = True
        '
        ' FormDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 200)
        Me.Controls.Add(Me.ButtonVolver)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormDepositos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depósitos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
