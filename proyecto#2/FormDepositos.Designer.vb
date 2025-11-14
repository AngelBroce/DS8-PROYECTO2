<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDepositos
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuCheques As ToolStripMenuItem
    Friend WithEvents mnuDepositos As ToolStripMenuItem
    Friend WithEvents mnuConciliacion As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuCerrarSesion As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
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
        mnuCerrarSesion = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        mnuSalir = New ToolStripMenuItem()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        DataGridView1 = New DataGridView()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(18, 18)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuCheques, mnuDepositos, mnuConciliacion, ToolStripSeparator1, mnuCerrarSesion, ToolStripSeparator2, mnuSalir})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(880, 27)
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
        ' mnuCerrarSesion
        ' 
        mnuCerrarSesion.Name = "mnuCerrarSesion"
        mnuCerrarSesion.Size = New Size(104, 23)
        mnuCerrarSesion.Text = "Cerrar sesión"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 23)
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Name = "mnuSalir"
        mnuSalir.Size = New Size(48, 23)
        mnuSalir.Text = "Salir"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(20, 50)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(104, 23)
        RadioButton1.TabIndex = 2
        RadioButton1.TabStop = True
        RadioButton1.Text = "Transferencia"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(150, 50)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(132, 23)
        RadioButton2.TabIndex = 3
        RadioButton2.TabStop = True
        RadioButton2.Text = "Depósito Directo"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeight = 26
        DataGridView1.Location = New Point(20, 200)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(840, 280)
        DataGridView1.TabIndex = 4
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(310, 50)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 26)
        DateTimePicker1.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(20, 130)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 26)
        TextBox1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 19)
        Label1.TabIndex = 7
        Label1.Text = "Monto:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.ForeColor = Color.White
        Button1.Location = New Point(200, 120)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 42)
        Button1.TabIndex = 8
        Button1.Text = "Registrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FormDepositos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 500)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(DataGridView1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 10F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormDepositos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Módulo de Depósitos"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
