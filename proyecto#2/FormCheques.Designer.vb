<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheques
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
        lblNumero = New Label()
        lblFecha = New Label()
        lblProveedor = New Label()
        lblMonto = New Label()
        lblMontoLetras = New Label()
        lblDetalle = New Label()
        lblObjeto = New Label()
        txtNumero = New TextBox()
        dtpFecha = New DateTimePicker()
        cmbProveedor = New ComboBox()
        cmbObjeto = New ComboBox()
        txtMonto = New TextBox()
        txtMontoLetras = New TextBox()
        txtDetalle = New TextBox()
        btnGuardar = New Button()
        btnAnular = New Button()
        btnChequesGirados = New Button()
        btnAgregarProveedor = New Button()
        dgvCheques = New DataGridView()
        MenuStrip1.SuspendLayout()
        CType(dgvCheques, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(18, 18)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuCheques, mnuDepositos, mnuConciliacion, ToolStripSeparator1, mnuSalir})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1175, 27)
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
        ' lblNumero
        ' 
        lblNumero.AutoSize = True
        lblNumero.Location = New Point(20, 40)
        lblNumero.Name = "lblNumero"
        lblNumero.Size = New Size(143, 21)
        lblNumero.TabIndex = 0
        lblNumero.Text = "Número de cheque"
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Location = New Point(240, 40)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(129, 21)
        lblFecha.TabIndex = 2
        lblFecha.Text = "Fecha del cheque"
        ' 
        ' lblProveedor
        ' 
        lblProveedor.AutoSize = True
        lblProveedor.Location = New Point(20, 100)
        lblProveedor.Name = "lblProveedor"
        lblProveedor.Size = New Size(177, 21)
        lblProveedor.TabIndex = 4
        lblProveedor.Text = "Beneficiario / Proveedor"
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Location = New Point(20, 220)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(56, 21)
        lblMonto.TabIndex = 9
        lblMonto.Text = "Monto"
        ' 
        ' lblMontoLetras
        ' 
        lblMontoLetras.AutoSize = True
        lblMontoLetras.Location = New Point(190, 220)
        lblMontoLetras.Name = "lblMontoLetras"
        lblMontoLetras.Size = New Size(119, 21)
        lblMontoLetras.TabIndex = 11
        lblMontoLetras.Text = "Monto en letras"
        ' 
        ' lblDetalle
        ' 
        lblDetalle.AutoSize = True
        lblDetalle.Location = New Point(20, 285)
        lblDetalle.Name = "lblDetalle"
        lblDetalle.Size = New Size(58, 21)
        lblDetalle.TabIndex = 13
        lblDetalle.Text = "Detalle"
        ' 
        ' lblObjeto
        ' 
        lblObjeto.AutoSize = True
        lblObjeto.Location = New Point(20, 160)
        lblObjeto.Name = "lblObjeto"
        lblObjeto.Size = New Size(120, 21)
        lblObjeto.TabIndex = 7
        lblObjeto.Text = "Objeto de gasto"
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(20, 65)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(200, 28)
        txtNumero.TabIndex = 1
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Format = DateTimePickerFormat.Short
        dtpFecha.Location = New Point(240, 65)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(200, 28)
        dtpFecha.TabIndex = 3
        ' 
        ' cmbProveedor
        ' 
        cmbProveedor.Location = New Point(20, 125)
        cmbProveedor.Name = "cmbProveedor"
        cmbProveedor.Size = New Size(300, 28)
        cmbProveedor.TabIndex = 5
        ' 
        ' cmbObjeto
        ' 
        cmbObjeto.Location = New Point(20, 185)
        cmbObjeto.Name = "cmbObjeto"
        cmbObjeto.Size = New Size(478, 28)
        cmbObjeto.TabIndex = 8
        ' 
        ' txtMonto
        ' 
        txtMonto.Location = New Point(20, 245)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(150, 28)
        txtMonto.TabIndex = 10
        ' 
        ' txtMontoLetras
        ' 
        txtMontoLetras.Location = New Point(176, 245)
        txtMontoLetras.Name = "txtMontoLetras"
        txtMontoLetras.ReadOnly = True
        txtMontoLetras.Size = New Size(430, 28)
        txtMontoLetras.TabIndex = 12
        ' 
        ' txtDetalle
        ' 
        txtDetalle.Location = New Point(20, 310)
        txtDetalle.Multiline = True
        txtDetalle.Name = "txtDetalle"
        txtDetalle.Size = New Size(600, 60)
        txtDetalle.TabIndex = 14
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.SteelBlue
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(642, 310)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(131, 52)
        btnGuardar.TabIndex = 16
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnAnular
        ' 
        btnAnular.BackColor = Color.IndianRed
        btnAnular.ForeColor = Color.White
        btnAnular.Location = New Point(152, 647)
        btnAnular.Name = "btnAnular"
        btnAnular.Size = New Size(92, 31)
        btnAnular.TabIndex = 17
        btnAnular.Text = "Anular"
        btnAnular.UseVisualStyleBackColor = False
        ' 
        ' btnChequesGirados
        ' 
        btnChequesGirados.BackColor = Color.LightYellow
        btnChequesGirados.Location = New Point(20, 647)
        btnChequesGirados.Name = "btnChequesGirados"
        btnChequesGirados.Size = New Size(104, 31)
        btnChequesGirados.TabIndex = 18
        btnChequesGirados.Text = "Girar"
        btnChequesGirados.UseVisualStyleBackColor = False
        ' 
        ' btnAgregarProveedor
        ' 
        btnAgregarProveedor.BackColor = Color.LightSteelBlue
        btnAgregarProveedor.Location = New Point(340, 125)
        btnAgregarProveedor.Name = "btnAgregarProveedor"
        btnAgregarProveedor.Size = New Size(158, 28)
        btnAgregarProveedor.TabIndex = 6
        btnAgregarProveedor.Text = "Agregar proveedor"
        btnAgregarProveedor.UseVisualStyleBackColor = False
        ' 
        ' dgvCheques
        ' 
        dgvCheques.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCheques.ColumnHeadersHeight = 26
        dgvCheques.Location = New Point(20, 390)
        dgvCheques.Name = "dgvCheques"
        dgvCheques.ReadOnly = True
        dgvCheques.RowHeadersWidth = 47
        dgvCheques.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCheques.Size = New Size(1131, 230)
        dgvCheques.TabIndex = 18
        ' 
        ' FormCheques
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1175, 750)
        Controls.Add(lblNumero)
        Controls.Add(txtNumero)
        Controls.Add(lblFecha)
        Controls.Add(dtpFecha)
        Controls.Add(lblProveedor)
        Controls.Add(cmbProveedor)
        Controls.Add(btnAgregarProveedor)
        Controls.Add(lblObjeto)
        Controls.Add(cmbObjeto)
        Controls.Add(lblMonto)
        Controls.Add(txtMonto)
        Controls.Add(lblMontoLetras)
        Controls.Add(txtMontoLetras)
        Controls.Add(lblDetalle)
        Controls.Add(txtDetalle)
        Controls.Add(btnGuardar)
        Controls.Add(btnAnular)
        Controls.Add(btnChequesGirados)
        Controls.Add(dgvCheques)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 10F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormCheques"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Módulo de Cheques"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(dgvCheques, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblNumero As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblMontoLetras As Label
    Friend WithEvents lblDetalle As Label
    Friend WithEvents lblObjeto As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents cmbObjeto As ComboBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtMontoLetras As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnAnular As Button
    Friend WithEvents btnChequesGirados As Button
    Friend WithEvents btnAgregarProveedor As Button
    Friend WithEvents dgvCheques As DataGridView
End Class
