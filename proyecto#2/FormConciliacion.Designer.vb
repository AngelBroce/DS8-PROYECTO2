<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConciliacion
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
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
        MenuStrip1 = New MenuStrip()
        mnuCheques = New ToolStripMenuItem()
        mnuDepositos = New ToolStripMenuItem()
        mnuConciliacion = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        mnuSalir = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(18, 18)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuCheques, mnuDepositos, mnuConciliacion, ToolStripSeparator1, mnuSalir})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 27)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "menuStrip1"
        ' 
        ' mnuCheques
        ' 
        mnuCheques.Name = "mnuCheques"
        mnuCheques.Size = New Size(76, 23)
        mnuCheques.Text = "Cheques"
        ' 
        ' mnuDepositos
        ' 
        mnuDepositos.Name = "mnuDepositos"
        mnuDepositos.Size = New Size(84, 23)
        mnuDepositos.Text = "Depósitos"
        ' 
        ' mnuConciliacion
        ' 
        mnuConciliacion.Name = "mnuConciliacion"
        mnuConciliacion.Size = New Size(95, 23)
        mnuConciliacion.Text = "Conciliación"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 23)
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Name = "mnuSalir"
        mnuSalir.Size = New Size(48, 23)
        mnuSalir.Text = "Salir"
        ' 
        ' FormConciliacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 539)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormConciliacion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Conciliación"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
End Class
