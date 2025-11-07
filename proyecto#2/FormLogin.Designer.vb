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
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.PanelDerecho = New System.Windows.Forms.Panel()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.PanelContrasena = New System.Windows.Forms.Panel()
        Me.btnMostrarContrasena = New System.Windows.Forms.Button()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.LabelContrasena = New System.Windows.Forms.Label()
        Me.PanelUsuario = New System.Windows.Forms.Panel()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.LabelSubtitulo = New System.Windows.Forms.Label()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.PanelIzquierdo = New System.Windows.Forms.Panel()
        Me.PanelBandera = New System.Windows.Forms.Panel()
        Me.LabelBancoInfo = New System.Windows.Forms.Label()
        Me.PanelPrincipal.SuspendLayout()
        Me.PanelDerecho.SuspendLayout()
        Me.PanelFormulario.SuspendLayout()
        Me.PanelContrasena.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelIzquierdo.SuspendLayout()
        Me.PanelBandera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.White
        Me.PanelPrincipal.Controls.Add(Me.PanelDerecho)
        Me.PanelPrincipal.Controls.Add(Me.PanelIzquierdo)
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(900, 600)
        Me.PanelPrincipal.TabIndex = 0
        '
        'PanelDerecho
        '
        Me.PanelDerecho.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelDerecho.Controls.Add(Me.PanelFormulario)
        Me.PanelDerecho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDerecho.Location = New System.Drawing.Point(450, 0)
        Me.PanelDerecho.Name = "PanelDerecho"
        Me.PanelDerecho.Size = New System.Drawing.Size(450, 600)
        Me.PanelDerecho.TabIndex = 1
        '
        'PanelFormulario
        '
        Me.PanelFormulario.Controls.Add(Me.LabelVersion)
        Me.PanelFormulario.Controls.Add(Me.btnIngresar)
        Me.PanelFormulario.Controls.Add(Me.PanelContrasena)
        Me.PanelFormulario.Controls.Add(Me.LabelContrasena)
        Me.PanelFormulario.Controls.Add(Me.PanelUsuario)
        Me.PanelFormulario.Controls.Add(Me.LabelUsuario)
        Me.PanelFormulario.Controls.Add(Me.LabelSubtitulo)
        Me.PanelFormulario.Controls.Add(Me.LabelTitulo)
        Me.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormulario.Location = New System.Drawing.Point(0, 0)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(450, 600)
        Me.PanelFormulario.TabIndex = 0
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.LabelVersion.Location = New System.Drawing.Point(150, 560)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(150, 13)
        Me.LabelVersion.TabIndex = 7
        Me.LabelVersion.Text = "Banca Digital v1.0.0"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Location = New System.Drawing.Point(35, 340)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(380, 50)
        Me.btnIngresar.TabIndex = 6
        Me.btnIngresar.Text = "ACCEDER A MI CUENTA"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'PanelContrasena
        '
        Me.PanelContrasena.BackColor = System.Drawing.Color.White
        Me.PanelContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContrasena.Controls.Add(Me.btnMostrarContrasena)
        Me.PanelContrasena.Controls.Add(Me.txtContrasena)
        Me.PanelContrasena.Location = New System.Drawing.Point(35, 270)
        Me.PanelContrasena.Name = "PanelContrasena"
        Me.PanelContrasena.Size = New System.Drawing.Size(380, 45)
        Me.PanelContrasena.TabIndex = 5
        '
        'btnMostrarContrasena
        '
        Me.btnMostrarContrasena.BackColor = System.Drawing.Color.White
        Me.btnMostrarContrasena.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMostrarContrasena.FlatAppearance.BorderSize = 0
        Me.btnMostrarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarContrasena.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMostrarContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnMostrarContrasena.Location = New System.Drawing.Point(345, 10)
        Me.btnMostrarContrasena.Name = "btnMostrarContrasena"
        Me.btnMostrarContrasena.Size = New System.Drawing.Size(25, 25)
        Me.btnMostrarContrasena.TabIndex = 5
        Me.btnMostrarContrasena.Text = "👁"
        Me.btnMostrarContrasena.UseVisualStyleBackColor = False
        '
        'txtContrasena
        '
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContrasena.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtContrasena.Location = New System.Drawing.Point(12, 12)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(327, 20)
        Me.txtContrasena.TabIndex = 4
        '
        'LabelContrasena
        '
        Me.LabelContrasena.AutoSize = True
        Me.LabelContrasena.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LabelContrasena.Location = New System.Drawing.Point(35, 248)
        Me.LabelContrasena.Name = "LabelContrasena"
        Me.LabelContrasena.Size = New System.Drawing.Size(80, 15)
        Me.LabelContrasena.TabIndex = 4
        Me.LabelContrasena.Text = "Contraseña"
        '
        'PanelUsuario
        '
        Me.PanelUsuario.BackColor = System.Drawing.Color.White
        Me.PanelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelUsuario.Controls.Add(Me.txtUsuario)
        Me.PanelUsuario.Location = New System.Drawing.Point(35, 195)
        Me.PanelUsuario.Name = "PanelUsuario"
        Me.PanelUsuario.Size = New System.Drawing.Size(380, 45)
        Me.PanelUsuario.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(12, 12)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(356, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LabelUsuario.Location = New System.Drawing.Point(35, 173)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(50, 15)
        Me.LabelUsuario.TabIndex = 2
        Me.LabelUsuario.Text = "Usuario"
        '
        'LabelSubtitulo
        '
        Me.LabelSubtitulo.AutoSize = True
        Me.LabelSubtitulo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelSubtitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.LabelSubtitulo.Location = New System.Drawing.Point(35, 95)
        Me.LabelSubtitulo.Name = "LabelSubtitulo"
        Me.LabelSubtitulo.Size = New System.Drawing.Size(290, 19)
        Me.LabelSubtitulo.TabIndex = 1
        Me.LabelSubtitulo.Text = "Ingresa con tu usuario y contraseña"
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LabelTitulo.Location = New System.Drawing.Point(35, 40)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(310, 37)
        Me.LabelTitulo.TabIndex = 0
        Me.LabelTitulo.Text = "Banca Digital Premium"
        '
        'PanelIzquierdo
        '
        Me.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelIzquierdo.Controls.Add(Me.PanelBandera)
        Me.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIzquierdo.Location = New System.Drawing.Point(0, 0)
        Me.PanelIzquierdo.Name = "PanelIzquierdo"
        Me.PanelIzquierdo.Size = New System.Drawing.Size(450, 600)
        Me.PanelIzquierdo.TabIndex = 2
        '
        'PanelBandera
        '
        Me.PanelBandera.Controls.Add(Me.LabelBancoInfo)
        Me.PanelBandera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBandera.Location = New System.Drawing.Point(0, 0)
        Me.PanelBandera.Name = "PanelBandera"
        Me.PanelBandera.Size = New System.Drawing.Size(450, 600)
        Me.PanelBandera.TabIndex = 0
        '
        'LabelBancoInfo
        '
        Me.LabelBancoInfo.AutoSize = False
        Me.LabelBancoInfo.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelBancoInfo.ForeColor = System.Drawing.Color.White
        Me.LabelBancoInfo.Location = New System.Drawing.Point(30, 180)
        Me.LabelBancoInfo.Name = "LabelBancoInfo"
        Me.LabelBancoInfo.Size = New System.Drawing.Size(390, 240)
        Me.LabelBancoInfo.TabIndex = 0
        Me.LabelBancoInfo.Text = "GESTIÓN INTEGRAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DE CHEQUES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BANCARIOS"
        Me.LabelBancoInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Banca Digital - Sistema de Gestión de Cheques"
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelDerecho.ResumeLayout(False)
        Me.PanelFormulario.ResumeLayout(False)
        Me.PanelFormulario.PerformLayout()
        Me.PanelContrasena.ResumeLayout(False)
        Me.PanelContrasena.PerformLayout()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelIzquierdo.ResumeLayout(False)
        Me.PanelBandera.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents LabelVersion As Label
    Friend WithEvents PanelBandera As Panel
    Friend WithEvents LabelBancoInfo As Label
    Friend WithEvents PanelUsuario As Panel
    Friend WithEvents PanelContrasena As Panel
    Friend WithEvents btnMostrarContrasena As Button
End Class

