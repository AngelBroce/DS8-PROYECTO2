Imports MySql.Data.MySqlClient

Public Class FormLogin
    Dim connectionString As String = "Server=localhost;Database=proyectoSoft2;Uid=root;Pwd=;"
    Dim mostrandoContrasena As Boolean = False

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar formulario
        Me.Text = "Banca Digital - Sistema de Gestión de Cheques"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        ' Enfocar en el campo de usuario
        txtUsuario.Focus()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ValidarLogin()
    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        ' Permitir entrar con la tecla Enter
        If e.KeyCode = Keys.Return Then
            ValidarLogin()
            e.Handled = True
        End If
    End Sub

    Private Sub btnMostrarContrasena_Click(sender As Object, e As EventArgs) Handles btnMostrarContrasena.Click
        ' Alternar visibilidad de la contraseña
        mostrandoContrasena = Not mostrandoContrasena

        If mostrandoContrasena Then
            ' Mostrar contraseña
            txtContrasena.PasswordChar = Chr(0)
            btnMostrarContrasena.Text = "🙈"
        Else
            ' Ocultar contraseña
            txtContrasena.PasswordChar = "*"c
            btnMostrarContrasena.Text = "👁"
        End If
    End Sub

    Private Sub ValidarLogin()
        Dim usuario As String = txtUsuario.Text.Trim()
        Dim contrasena As String = txtContrasena.Text.Trim()

        ' Validaciones básicas
        If String.IsNullOrEmpty(usuario) Then
            MessageBox.Show("Por favor ingresa el nombre de usuario.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsuario.Focus()
            Return
        End If

        If String.IsNullOrEmpty(contrasena) Then
            MessageBox.Show("Por favor ingresa la contraseña.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContrasena.Focus()
            Return
        End If

        ' Intentar conectar a la BD y validar
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT usuario_id, nombre_completo FROM usuarios WHERE usuario = @usuario AND contrasena = @contrasena AND activo = 1"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@usuario", usuario)
                    command.Parameters.AddWithValue("@contrasena", contrasena)

                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim usuarioId As Integer = CInt(reader("usuario_id"))
                        Dim nombreCompleto As String = reader("nombre_completo").ToString()

                        ' Login exitoso
                        MessageBox.Show($"¡Bienvenido, {nombreCompleto}!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Guardar el ID de usuario en una variable global o variable de aplicación (opcional)
                        ' Por ahora, simplemente abrimos el formulario principal

                        ' Abrir FormCheques
                        Dim mainForm As New FormCheques()
                        mainForm.Show()

                        ' Ocultar el formulario de login
                        Me.Hide()
                    Else
                        ' Credenciales inválidas
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Login Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtContrasena.Clear()
                        txtUsuario.Focus()
                    End If
                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Si cierran el formulario de login sin haber ingresado, cerrar la aplicación
        If Me.Visible Then
            Application.Exit()
        End If
    End Sub

    Private Sub PanelBandera_Paint(sender As Object, e As PaintEventArgs) Handles PanelBandera.Paint

    End Sub
End Class
