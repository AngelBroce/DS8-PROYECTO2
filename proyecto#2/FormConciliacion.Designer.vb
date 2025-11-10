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
        GroupBox1 = New GroupBox()
        btnRegistrar = New Button()
        Label18 = New Label()
        Label17 = New Label()
        lblsaldoconciliadoigualabanco = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        txtsaldoconciliadoigualabanco = New TextBox()
        txtrestacheques = New TextBox()
        txtchequesencirculacion = New TextBox()
        txtdepositosentransito = New TextBox()
        lblsaldoenbancoal = New Label()
        lblsaldoconciliadosegunlibros = New Label()
        txtsaldoconciliadosegun = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        txtsaldoenbanco = New TextBox()
        txtresta1 = New TextBox()
        txtchequesgirados = New TextBox()
        txtsubtotal = New TextBox()
        txtsuma = New TextBox()
        txtxhequesanulados = New TextBox()
        txtdepositos = New TextBox()
        txtsaldosegun = New TextBox()
        lblsaldosegunlibro = New Label()
        lblcorrespondientealmes = New Label()
        Label3 = New Label()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        btnImprimir = New Button()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(18, 18)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuCheques, mnuDepositos, mnuConciliacion, ToolStripSeparator1, mnuSalir})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(878, 27)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "menuStrip1"
        ' 
        ' mnuCheques
        ' 
        mnuCheques.Name = "mnuCheques"
        mnuCheques.Size = New Size(65, 23)
        mnuCheques.Text = "Cheques"
        ' 
        ' mnuDepositos
        ' 
        mnuDepositos.Name = "mnuDepositos"
        mnuDepositos.Size = New Size(71, 23)
        mnuDepositos.Text = "Depósitos"
        ' 
        ' mnuConciliacion
        ' 
        mnuConciliacion.Name = "mnuConciliacion"
        mnuConciliacion.Size = New Size(85, 23)
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
        mnuSalir.Size = New Size(41, 23)
        mnuSalir.Text = "Salir"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnRegistrar)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(lblsaldoconciliadoigualabanco)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(txtsaldoconciliadoigualabanco)
        GroupBox1.Controls.Add(txtrestacheques)
        GroupBox1.Controls.Add(txtchequesencirculacion)
        GroupBox1.Controls.Add(txtdepositosentransito)
        GroupBox1.Controls.Add(lblsaldoenbancoal)
        GroupBox1.Controls.Add(lblsaldoconciliadosegunlibros)
        GroupBox1.Controls.Add(txtsaldoconciliadosegun)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtsaldoenbanco)
        GroupBox1.Controls.Add(txtresta1)
        GroupBox1.Controls.Add(txtchequesgirados)
        GroupBox1.Controls.Add(txtsubtotal)
        GroupBox1.Controls.Add(txtsuma)
        GroupBox1.Controls.Add(txtxhequesanulados)
        GroupBox1.Controls.Add(txtdepositos)
        GroupBox1.Controls.Add(txtsaldosegun)
        GroupBox1.Controls.Add(lblsaldosegunlibro)
        GroupBox1.Controls.Add(lblcorrespondientealmes)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(31, 119)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(746, 559)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.BackColor = Color.SteelBlue
        btnRegistrar.ForeColor = Color.White
        btnRegistrar.Location = New Point(569, 449)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(100, 35)
        btnRegistrar.TabIndex = 30
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(38, 385)
        Label18.Name = "Label18"
        Label18.Size = New Size(54, 19)
        Label18.TabIndex = 29
        Label18.Text = "Menos:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(40, 192)
        Label17.Name = "Label17"
        Label17.Size = New Size(71, 19)
        Label17.TabIndex = 28
        Label17.Text = "SUBTOTAL"
        ' 
        ' lblsaldoconciliadoigualabanco
        ' 
        lblsaldoconciliadoigualabanco.AutoSize = True
        lblsaldoconciliadoigualabanco.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblsaldoconciliadoigualabanco.Location = New Point(40, 455)
        lblsaldoconciliadoigualabanco.Name = "lblsaldoconciliadoigualabanco"
        lblsaldoconciliadoigualabanco.Size = New Size(230, 15)
        lblsaldoconciliadoigualabanco.TabIndex = 27
        lblsaldoconciliadoigualabanco.Text = "SALDO CONCILIADO IGUAL A BANCO  31"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(88, 385)
        Label13.Name = "Label13"
        Label13.Size = New Size(151, 19)
        Label13.TabIndex = 26
        Label13.Text = "Cheques en Circulación"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(88, 356)
        Label14.Name = "Label14"
        Label14.Size = New Size(141, 19)
        Label14.TabIndex = 25
        Label14.Text = "Depósitos en Transito"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(54, 356)
        Label15.Name = "Label15"
        Label15.Size = New Size(38, 19)
        Label15.TabIndex = 24
        Label15.Text = "Más:"
        ' 
        ' txtsaldoconciliadoigualabanco
        ' 
        txtsaldoconciliadoigualabanco.Location = New Point(424, 455)
        txtsaldoconciliadoigualabanco.Name = "txtsaldoconciliadoigualabanco"
        txtsaldoconciliadoigualabanco.ReadOnly = True
        txtsaldoconciliadoigualabanco.Size = New Size(106, 25)
        txtsaldoconciliadoigualabanco.TabIndex = 23
        ' 
        ' txtrestacheques
        ' 
        txtrestacheques.Location = New Point(424, 411)
        txtrestacheques.Name = "txtrestacheques"
        txtrestacheques.ReadOnly = True
        txtrestacheques.Size = New Size(106, 25)
        txtrestacheques.TabIndex = 22
        ' 
        ' txtchequesencirculacion
        ' 
        txtchequesencirculacion.Location = New Point(317, 382)
        txtchequesencirculacion.Name = "txtchequesencirculacion"
        txtchequesencirculacion.ReadOnly = True
        txtchequesencirculacion.Size = New Size(106, 25)
        txtchequesencirculacion.TabIndex = 21
        ' 
        ' txtdepositosentransito
        ' 
        txtdepositosentransito.Location = New Point(317, 353)
        txtdepositosentransito.Name = "txtdepositosentransito"
        txtdepositosentransito.ReadOnly = True
        txtdepositosentransito.Size = New Size(106, 25)
        txtdepositosentransito.TabIndex = 20
        ' 
        ' lblsaldoenbancoal
        ' 
        lblsaldoenbancoal.AutoSize = True
        lblsaldoenbancoal.Location = New Point(40, 327)
        lblsaldoenbancoal.Name = "lblsaldoenbancoal"
        lblsaldoenbancoal.Size = New Size(165, 19)
        lblsaldoenbancoal.TabIndex = 19
        lblsaldoenbancoal.Text = "SALDO EN BANCO AL 31"
        ' 
        ' lblsaldoconciliadosegunlibros
        ' 
        lblsaldoconciliadosegunlibros.AutoSize = True
        lblsaldoconciliadosegunlibros.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblsaldoconciliadosegunlibros.Location = New Point(40, 279)
        lblsaldoconciliadosegunlibros.Name = "lblsaldoconciliadosegunlibros"
        lblsaldoconciliadosegunlibros.Size = New Size(237, 15)
        lblsaldoconciliadosegunlibros.TabIndex = 18
        lblsaldoconciliadosegunlibros.Text = "SALDO CONCILIADO SEGÚN LIBROS AL 31"
        ' 
        ' txtsaldoconciliadosegun
        ' 
        txtsaldoconciliadosegun.Location = New Point(424, 279)
        txtsaldoconciliadosegun.Name = "txtsaldoconciliadosegun"
        txtsaldoconciliadosegun.ReadOnly = True
        txtsaldoconciliadosegun.Size = New Size(106, 25)
        txtsaldoconciliadosegun.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(88, 224)
        Label10.Name = "Label10"
        Label10.Size = New Size(113, 19)
        Label10.TabIndex = 16
        Label10.Text = "Cheques Girados"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(40, 224)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 19)
        Label9.TabIndex = 15
        Label9.Text = "Menos:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(88, 137)
        Label8.Name = "Label8"
        Label8.Size = New Size(123, 19)
        Label8.TabIndex = 14
        Label8.Text = "Cheques Anulados"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(88, 108)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 19)
        Label7.TabIndex = 13
        Label7.Text = "Depósitos"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(50, 108)
        Label6.Name = "Label6"
        Label6.Size = New Size(38, 19)
        Label6.TabIndex = 12
        Label6.Text = "Más:"
        ' 
        ' txtsaldoenbanco
        ' 
        txtsaldoenbanco.Location = New Point(424, 324)
        txtsaldoenbanco.Name = "txtsaldoenbanco"
        txtsaldoenbanco.Size = New Size(106, 25)
        txtsaldoenbanco.TabIndex = 11
        ' 
        ' txtresta1
        ' 
        txtresta1.Location = New Point(424, 250)
        txtresta1.Name = "txtresta1"
        txtresta1.ReadOnly = True
        txtresta1.Size = New Size(106, 25)
        txtresta1.TabIndex = 10
        ' 
        ' txtchequesgirados
        ' 
        txtchequesgirados.Location = New Point(317, 221)
        txtchequesgirados.Name = "txtchequesgirados"
        txtchequesgirados.ReadOnly = True
        txtchequesgirados.Size = New Size(106, 25)
        txtchequesgirados.TabIndex = 9
        ' 
        ' txtsubtotal
        ' 
        txtsubtotal.Location = New Point(424, 192)
        txtsubtotal.Name = "txtsubtotal"
        txtsubtotal.ReadOnly = True
        txtsubtotal.Size = New Size(106, 25)
        txtsubtotal.TabIndex = 8
        ' 
        ' txtsuma
        ' 
        txtsuma.Location = New Point(424, 163)
        txtsuma.Name = "txtsuma"
        txtsuma.ReadOnly = True
        txtsuma.Size = New Size(106, 25)
        txtsuma.TabIndex = 7
        ' 
        ' txtxhequesanulados
        ' 
        txtxhequesanulados.Location = New Point(317, 134)
        txtxhequesanulados.Name = "txtxhequesanulados"
        txtxhequesanulados.ReadOnly = True
        txtxhequesanulados.Size = New Size(106, 25)
        txtxhequesanulados.TabIndex = 6
        ' 
        ' txtdepositos
        ' 
        txtdepositos.Location = New Point(317, 105)
        txtdepositos.Name = "txtdepositos"
        txtdepositos.ReadOnly = True
        txtdepositos.Size = New Size(106, 25)
        txtdepositos.TabIndex = 5
        ' 
        ' txtsaldosegun
        ' 
        txtsaldosegun.Location = New Point(424, 76)
        txtsaldosegun.Name = "txtsaldosegun"
        txtsaldosegun.ReadOnly = True
        txtsaldosegun.Size = New Size(106, 25)
        txtsaldosegun.TabIndex = 4
        ' 
        ' lblsaldosegunlibro
        ' 
        lblsaldosegunlibro.AutoSize = True
        lblsaldosegunlibro.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblsaldosegunlibro.Location = New Point(40, 76)
        lblsaldosegunlibro.Name = "lblsaldosegunlibro"
        lblsaldosegunlibro.Size = New Size(155, 15)
        lblsaldosegunlibro.TabIndex = 3
        lblsaldosegunlibro.Text = "SALDO SEGÚN LIBRO AL 31"
        ' 
        ' lblcorrespondientealmes
        ' 
        lblcorrespondientealmes.AutoSize = True
        lblcorrespondientealmes.Location = New Point(182, 49)
        lblcorrespondientealmes.Name = "lblcorrespondientealmes"
        lblcorrespondientealmes.Size = New Size(177, 19)
        lblcorrespondientealmes.TabIndex = 2
        lblcorrespondientealmes.Text = "Correspondiente al mes de "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(216, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 19)
        Label3.TabIndex = 1
        Label3.Text = "CONCILIACIÓN BANCARIA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(251, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 19)
        Label2.TabIndex = 0
        Label2.Text = "EMPRESA XYZ"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(31, 57)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(233, 25)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 19)
        Label1.TabIndex = 4
        Label1.Text = "Seleccione el mes y año que desea:"
        ' 
        ' btnImprimir
        ' 
        btnImprimir.BackColor = Color.LightYellow
        btnImprimir.Location = New Point(311, 57)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Size = New Size(100, 30)
        btnImprimir.TabIndex = 5
        btnImprimir.Text = "Imprimir"
        btnImprimir.UseVisualStyleBackColor = False
        ' 
        ' FormConciliacion
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(878, 690)
        Controls.Add(btnImprimir)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 10F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormConciliacion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Módulo de Conciliación"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtsaldoenbanco As TextBox
    Friend WithEvents txtresta1 As TextBox
    Friend WithEvents txtchequesgirados As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents txtsuma As TextBox
    Friend WithEvents txtxhequesanulados As TextBox
    Friend WithEvents txtdepositos As TextBox
    Friend WithEvents txtsaldosegun As TextBox
    Friend WithEvents lblsaldosegunlibro As Label
    Friend WithEvents lblcorrespondientealmes As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblsaldoconciliadosegunlibros As Label
    Friend WithEvents txtsaldoconciliadosegun As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblsaldoconciliadoigualabanco As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtsaldoconciliadoigualabanco As TextBox
    Friend WithEvents txtrestacheques As TextBox
    Friend WithEvents txtchequesencirculacion As TextBox
    Friend WithEvents txtdepositosentransito As TextBox
    Friend WithEvents lblsaldoenbancoal As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnRegistrar As Button
End Class
