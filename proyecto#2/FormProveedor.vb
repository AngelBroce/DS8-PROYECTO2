Imports MySql.Data.MySqlClient

Public Class FormProveedor
    ' Cadena de conexión para MySQL/XAMPP
    Private Const ConnectionString As String = "Server=localhost;Database=proyectoSoft2;Uid=root;Pwd=;"

    Private Sub FormProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Generar código automáticamente al cargar el formulario
        txtCodigo.Text = GenerarProximoCodigo()
        txtCodigo.ReadOnly = True
        txtNombre.Focus()
    End Sub

    Private Function GenerarProximoCodigo() As String
        Try
            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()
                Dim query = "SELECT MAX(CAST(codigo AS UNSIGNED)) FROM proveedores WHERE codigo REGEXP '^[0-9]+$'"
                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    If IsDBNull(result) OrElse result Is Nothing Then
                        ' No hay códigos numéricos, empezar con 00001
                        Return "00001"
                    Else
                        ' Incrementar el máximo código encontrado y formatear con ceros
                        Dim ultimoCodigo = Convert.ToInt32(result)
                        Return (ultimoCodigo + 1).ToString("00000")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' En caso de error, empezar con 00001
            MessageBox.Show("Error al generar código: " & ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return "00001"
        End Try
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Validar campos
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("Ingrese el nombre del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return
        End If
        
        ' Insertar en la base de datos
        Try
            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()
                Dim query = "INSERT INTO proveedores (codigo, nombre, ruc, direccion) VALUES (@codigo, @nombre, @ruc, @direccion)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim())
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim())
                    cmd.Parameters.AddWithValue("@ruc", txtRUC.Text.Trim())
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim())
                    
                    Dim result = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("Proveedor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show("Error al registrar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al registrar el proveedor: " & ex.Message & vbCrLf & "Verifique que el código no esté duplicado.", "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
