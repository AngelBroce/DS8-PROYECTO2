<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it by hand.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelPrincipal = New Panel()
        PanelDerecho = New Panel()
        PanelFormulario = New Panel()
        LabelVersion = New Label()
        btnSalir = New Button()
        btnIngresar = New Button()
        PanelContrasena = New Panel()
        btnMostrarContrasena = New Button()
        txtContrasena = New TextBox()
        LabelContrasena = New Label()
        PanelUsuario = New Panel()
        txtUsuario = New TextBox()
        LabelUsuario = New Label()
        LabelSubtitulo = New Label()
        LabelTitulo = New Label()
        PanelIzquierdo = New Panel()
        PanelBandera = New Panel()
        LabelBancoInfo = New Label()
        PanelPrincipal.SuspendLayout()
        PanelDerecho.SuspendLayout()
        PanelFormulario.SuspendLayout()
        PanelContrasena.SuspendLayout()
        PanelUsuario.SuspendLayout()
        PanelIzquierdo.SuspendLayout()
        PanelBandera.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelPrincipal
        ' 
        PanelPrincipal.BackColor = Color.White
        PanelPrincipal.Controls.Add(PanelDerecho)
        PanelPrincipal.Controls.Add(PanelIzquierdo)
        PanelPrincipal.Dock = DockStyle.Fill
        PanelPrincipal.Location = New Point(0, 0)
        PanelPrincipal.Margin = New Padding(4, 4, 4, 4)
        PanelPrincipal.Name = "PanelPrincipal"
        PanelPrincipal.Size = New Size(1200, 877)
        PanelPrincipal.TabIndex = 0
        ' 
        ' PanelDerecho
        ' 
        PanelDerecho.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        PanelDerecho.Controls.Add(PanelFormulario)
        PanelDerecho.Dock = DockStyle.Fill
        PanelDerecho.Location = New Point(600, 0)
        PanelDerecho.Margin = New Padding(4, 4, 4, 4)
        PanelDerecho.Name = "PanelDerecho"
        PanelDerecho.Size = New Size(600, 877)
        PanelDerecho.TabIndex = 1
        ' 
        ' PanelFormulario
        ' 
        PanelFormulario.Controls.Add(LabelVersion)
        PanelFormulario.Controls.Add(btnSalir)
        PanelFormulario.Controls.Add(btnIngresar)
        PanelFormulario.Controls.Add(PanelContrasena)
        PanelFormulario.Controls.Add(LabelContrasena)
        PanelFormulario.Controls.Add(PanelUsuario)
        PanelFormulario.Controls.Add(LabelUsuario)
        PanelFormulario.Controls.Add(LabelSubtitulo)
        PanelFormulario.Controls.Add(LabelTitulo)
        PanelFormulario.Dock = DockStyle.Fill
        PanelFormulario.Location = New Point(0, 0)
        PanelFormulario.Margin = New Padding(4, 4, 4, 4)
        PanelFormulario.Name = "PanelFormulario"
        PanelFormulario.Size = New Size(600, 877)
        PanelFormulario.TabIndex = 0
        ' 
        ' LabelVersion
        ' 
        LabelVersion.AutoSize = True
        LabelVersion.Font = New Font("Segoe UI", 7.5F)
        LabelVersion.ForeColor = Color.FromArgb(CByte(158), CByte(158), CByte(158))
        LabelVersion.Location = New Point(200, 818)
        LabelVersion.Margin = New Padding(4, 0, 4, 0)
        LabelVersion.Name = "LabelVersion"
        LabelVersion.Size = New Size(109, 15)
        LabelVersion.TabIndex = 7
        LabelVersion.Text = "Banca Digital v1.0.0"
        LabelVersion.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnIngresar
        ' 
        btnIngresar.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(204))
        btnIngresar.Cursor = Cursors.Hand
        btnIngresar.FlatAppearance.BorderSize = 0
        btnIngresar.FlatStyle = FlatStyle.Flat
        btnIngresar.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnIngresar.ForeColor = Color.White
        btnIngresar.Location = New Point(47, 497)
        btnIngresar.Margin = New Padding(4, 4, 4, 4)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(507, 73)
        btnIngresar.TabIndex = 6
        btnIngresar.Text = "ACCEDER A MI CUENTA"
        btnIngresar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        btnSalir.Cursor = Cursors.Hand
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSalir.ForeColor = Color.White
        btnSalir.Location = New Point(47, 583)
        btnSalir.Margin = New Padding(4, 4, 4, 4)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(507, 50)
        btnSalir.TabIndex = 7
        btnSalir.Text = "❌ SALIR"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' PanelContrasena
        ' 
        PanelContrasena.BackColor = Color.White
        PanelContrasena.BorderStyle = BorderStyle.FixedSingle
        PanelContrasena.Controls.Add(btnMostrarContrasena)
        PanelContrasena.Controls.Add(txtContrasena)
        PanelContrasena.Location = New Point(47, 395)
        PanelContrasena.Margin = New Padding(4, 4, 4, 4)
        PanelContrasena.Name = "PanelContrasena"
        PanelContrasena.Size = New Size(506, 65)
        PanelContrasena.TabIndex = 5
        ' 
        ' btnMostrarContrasena
        ' 
        btnMostrarContrasena.BackColor = Color.White
        btnMostrarContrasena.Cursor = Cursors.Hand
        btnMostrarContrasena.FlatAppearance.BorderSize = 0
        btnMostrarContrasena.FlatStyle = FlatStyle.Flat
        btnMostrarContrasena.Font = New Font("Segoe UI Symbol", 12F)
        btnMostrarContrasena.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        btnMostrarContrasena.Location = New Point(460, 15)
        btnMostrarContrasena.Margin = New Padding(4, 4, 4, 4)
        btnMostrarContrasena.Name = "btnMostrarContrasena"
        btnMostrarContrasena.Size = New Size(33, 37)
        btnMostrarContrasena.TabIndex = 5
        btnMostrarContrasena.Text = "👁"
        btnMostrarContrasena.UseVisualStyleBackColor = False
        ' 
        ' txtContrasena
        ' 
        txtContrasena.BorderStyle = BorderStyle.None
        txtContrasena.Font = New Font("Segoe UI", 11F)
        txtContrasena.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        txtContrasena.Location = New Point(16, 18)
        txtContrasena.Margin = New Padding(4, 4, 4, 4)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.PasswordChar = "*"c
        txtContrasena.Size = New Size(436, 23)
        txtContrasena.TabIndex = 4
        ' 
        ' LabelContrasena
        ' 
        LabelContrasena.AutoSize = True
        LabelContrasena.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LabelContrasena.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        LabelContrasena.Location = New Point(47, 362)
        LabelContrasena.Margin = New Padding(4, 0, 4, 0)
        LabelContrasena.Name = "LabelContrasena"
        LabelContrasena.Size = New Size(84, 19)
        LabelContrasena.TabIndex = 4
        LabelContrasena.Text = "Contraseña"
        ' 
        ' PanelUsuario
        ' 
        PanelUsuario.BackColor = Color.White
        PanelUsuario.BorderStyle = BorderStyle.FixedSingle
        PanelUsuario.Controls.Add(txtUsuario)
        PanelUsuario.Location = New Point(47, 285)
        PanelUsuario.Margin = New Padding(4, 4, 4, 4)
        PanelUsuario.Name = "PanelUsuario"
        PanelUsuario.Size = New Size(506, 65)
        PanelUsuario.TabIndex = 3
        ' 
        ' txtUsuario
        ' 
        txtUsuario.BorderStyle = BorderStyle.None
        txtUsuario.Font = New Font("Segoe UI", 11F)
        txtUsuario.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        txtUsuario.Location = New Point(16, 18)
        txtUsuario.Margin = New Padding(4, 4, 4, 4)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(475, 23)
        txtUsuario.TabIndex = 2
        ' 
        ' LabelUsuario
        ' 
        LabelUsuario.AutoSize = True
        LabelUsuario.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LabelUsuario.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        LabelUsuario.Location = New Point(47, 253)
        LabelUsuario.Margin = New Padding(4, 0, 4, 0)
        LabelUsuario.Name = "LabelUsuario"
        LabelUsuario.Size = New Size(60, 19)
        LabelUsuario.TabIndex = 2
        LabelUsuario.Text = "Usuario"
        ' 
        ' LabelSubtitulo
        ' 
        LabelSubtitulo.AutoSize = True
        LabelSubtitulo.Font = New Font("Segoe UI", 10F)
        LabelSubtitulo.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        LabelSubtitulo.Location = New Point(47, 139)
        LabelSubtitulo.Margin = New Padding(4, 0, 4, 0)
        LabelSubtitulo.Name = "LabelSubtitulo"
        LabelSubtitulo.Size = New Size(256, 21)
        LabelSubtitulo.TabIndex = 1
        LabelSubtitulo.Text = "Ingresa con tu usuario y contraseña"
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.AutoSize = True
        LabelTitulo.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        LabelTitulo.ForeColor = Color.FromArgb(CByte(0), CByte(102), CByte(204))
        LabelTitulo.Location = New Point(47, 58)
        LabelTitulo.Margin = New Padding(4, 0, 4, 0)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(354, 42)
        LabelTitulo.TabIndex = 0
        LabelTitulo.Text = "Banca Digital Premium"
        ' 
        ' PanelIzquierdo
        ' 
        PanelIzquierdo.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(204))
        PanelIzquierdo.Controls.Add(PanelBandera)
        PanelIzquierdo.Dock = DockStyle.Left
        PanelIzquierdo.Location = New Point(0, 0)
        PanelIzquierdo.Margin = New Padding(4, 4, 4, 4)
        PanelIzquierdo.Name = "PanelIzquierdo"
        PanelIzquierdo.Size = New Size(600, 877)
        PanelIzquierdo.TabIndex = 2
        ' 
        ' PanelBandera
        ' 
        PanelBandera.Controls.Add(LabelBancoInfo)
        PanelBandera.Dock = DockStyle.Fill
        PanelBandera.Location = New Point(0, 0)
        PanelBandera.Margin = New Padding(4, 4, 4, 4)
        PanelBandera.Name = "PanelBandera"
        PanelBandera.Size = New Size(600, 877)
        PanelBandera.TabIndex = 0
        ' 
        ' LabelBancoInfo
        ' 
        LabelBancoInfo.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        LabelBancoInfo.ForeColor = Color.White
        LabelBancoInfo.Location = New Point(40, 263)
        LabelBancoInfo.Margin = New Padding(4, 0, 4, 0)
        LabelBancoInfo.Name = "LabelBancoInfo"
        LabelBancoInfo.Size = New Size(520, 351)
        LabelBancoInfo.TabIndex = 0
        LabelBancoInfo.Text = "GESTIÓN INTEGRAL" & vbCrLf & "DE CHEQUES" & vbCrLf & "BANCARIOS"
        LabelBancoInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1200, 877)
        Controls.Add(PanelPrincipal)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 4, 4, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Banca Digital - Sistema de Gestión de Cheques"
        PanelPrincipal.ResumeLayout(False)
        PanelDerecho.ResumeLayout(False)
        PanelFormulario.ResumeLayout(False)
        PanelFormulario.PerformLayout()
        PanelContrasena.ResumeLayout(False)
        PanelContrasena.PerformLayout()
        PanelUsuario.ResumeLayout(False)
        PanelUsuario.PerformLayout()
        PanelIzquierdo.ResumeLayout(False)
        PanelBandera.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents PanelDerecho As Panel
    Friend WithEvents PanelIzquierdo As Panel
    Friend WithEvents PanelFormulario As Panel
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents LabelSubtitulo As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents LabelContrasena As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents LabelVersion As Label
    Friend WithEvents PanelBandera As Panel
    Friend WithEvents LabelBancoInfo As Label
    Friend WithEvents PanelUsuario As Panel
    Friend WithEvents PanelContrasena As Panel
    Friend WithEvents btnMostrarContrasena As Button
End Class

