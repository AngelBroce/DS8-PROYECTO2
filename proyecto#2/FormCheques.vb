Imports MySql.Data.MySqlClient

Public Class FormCheques
    ' Modelo sencillo de cheque (en memoria)
    Private Class Cheque
        Public Property ChequeId As Integer
        Public Property Numero As String
        Public Property Fecha As DateTime
        Public Property Proveedor As String
        Public Property Monto As Decimal
        Public Property MontoLetras As String
        Public Property Detalle As String
        Public Property Objeto As String
        Public Property FechaGirado As DateTime?
        Public Property FechaAnulacion As DateTime?
    End Class

    Private cheques As New List(Of Cheque)()
    Private nextId As Integer = 1
    Private nextChequeNumber As Integer = 1

    Private Sub FormCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar controles y cargar datos de ejemplo
        LoadProveedores()
        LoadObjetos()
        InitializeDataGrid()
        
        ' Cargar cheques existentes de la BD
        LoadChequesFromDatabase()
        
        ' Generar el primer número de cheque automáticamente
        txtNumero.Text = GenerarNumeroCheque()
        txtNumero.ReadOnly = True
    End Sub

    Private Sub LoadChequesFromDatabase()
        ' Limpiar la lista en memoria
        cheques.Clear()
        nextChequeNumber = 1  ' Reiniciar el contador
        
        Try
            Dim connectionString As String = "Server=localhost;Database=proyectoSoft2;Uid=root;Pwd=;"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                
                Dim query = "SELECT cheque_id, numero, fecha_emision, proveedor_codigo, monto, objeto_codigo, fecha_girado, fecha_anulacion, detalles FROM cheques ORDER BY cheque_id"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Obtener nombre del proveedor
                            Dim proveedorNombre As String = ""
                            If Not reader.IsDBNull(3) Then
                                proveedorNombre = ObtenerNombreProveedor(reader(3).ToString())
                            End If
                            
                            ' Obtener nombre del objeto
                            Dim objetoNombre As String = ""
                            If Not reader.IsDBNull(5) Then
                                objetoNombre = ObtenerNombreObjeto(reader(5).ToString())
                            End If
                            
                            Dim monto As Decimal = If(reader.IsDBNull(4), 0, CDec(reader(4)))
                            Dim montoLetras = NumeroALetrasCompleto(monto)
                            
                            Dim fechaGirado As DateTime? = Nothing
                            If Not reader.IsDBNull(6) Then
                                fechaGirado = CDate(reader(6))
                            End If
                            
                            Dim fechaAnulacion As DateTime? = Nothing
                            If Not reader.IsDBNull(7) Then
                                fechaAnulacion = CDate(reader(7))
                            End If
                            
                            ' Extraer el número como integer para actualizar nextChequeNumber
                            Dim numeroStr As String = reader(1).ToString()
                            Dim numeroInt As Integer = 0
                            If Integer.TryParse(numeroStr, numeroInt) Then
                                ' Actualizar nextChequeNumber al siguiente número disponible
                                If numeroInt >= nextChequeNumber Then
                                    nextChequeNumber = numeroInt + 1
                                End If
                            End If
                            
                            Dim c As New Cheque() With {
                                .ChequeId = CInt(reader(0)),
                                .Numero = numeroStr,
                                .Fecha = CDate(reader(2)),
                                .Proveedor = proveedorNombre,
                                .Monto = monto,
                                .MontoLetras = montoLetras,
                                .Objeto = objetoNombre,
                                .FechaGirado = fechaGirado,
                                .FechaAnulacion = fechaAnulacion,
                                .Detalle = If(reader.IsDBNull(8), "", reader(8).ToString())
                            }
                            cheques.Add(c)
                            
                            ' Actualizar nextId para que no haya conflictos
                            If c.ChequeId >= nextId Then
                                nextId = c.ChequeId + 1
                            End If
                        End While
                    End Using
                End Using
            End Using
            
            RefreshGrid()
        Catch ex As Exception
            MessageBox.Show("Error al cargar cheques de la BD: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ObtenerNombreProveedor(codigo As String) As String
        Try
            Dim connectionString As String = "Server=localhost;Database=proyectoSoft2;Uid=root;Pwd=;"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query = "SELECT nombre FROM proveedores WHERE codigo = @codigo"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@codigo", codigo)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        Return result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Silencio el error
        End Try
        Return codigo
    End Function

    Private Function ObtenerNombreObjeto(codigo As String) As String
        Try
            Dim connectionString As String = "Server=localhost;Database=proyectoSoft2;Uid=root;Pwd=;"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query = "SELECT detalle FROM objeto_gasto WHERE codigo = @codigo"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@codigo", codigo)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        Return result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Silencio el error
        End Try
        Return codigo
    End Function

    Private Sub LoadProveedores()
        ' Cargar proveedores desde la BD
        cmbProveedor.Items.Clear()
        Try
            Dim connectionString As String = "Server=localhost;Database=proyectoSoft2;Uid=root;Pwd=;"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query = "SELECT codigo, nombre FROM proveedores ORDER BY nombre"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim codigo = reader("codigo").ToString()
                            Dim nombre = reader("nombre").ToString()
                            cmbProveedor.Items.Add(codigo & " - " & nombre)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Si falla la carga, mostrar datos de ejemplo
            MessageBox.Show("Error cargando proveedores: " & ex.Message)
            cmbProveedor.Items.Add("00001 - ÓPTICA SOSA Y ARANGO, S.A.")
            cmbProveedor.Items.Add("00003 - CARILO, S.A.")
            cmbProveedor.Items.Add("00006 - AGENCIA SKY")
        End Try
        If cmbProveedor.Items.Count > 0 Then
            cmbProveedor.SelectedIndex = 0
        End If
    End Sub

    Private Sub LoadObjetos()
        ' Cargar objetos de gasto desde la BD
        cmbObjeto.Items.Clear()
        Try
            Dim connectionString As String = "Server=localhost;Database=proyectoSoft2;Uid=root;Pwd=;"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query = "SELECT codigo, detalle FROM objeto_gasto ORDER BY detalle"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim codigo = reader("codigo").ToString()
                            Dim detalle = reader("detalle").ToString()
                            cmbObjeto.Items.Add(codigo & " - " & detalle)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Si falla la carga, mostrar datos de ejemplo
            MessageBox.Show("Error cargando objetos: " & ex.Message)
            cmbObjeto.Items.Add("120 - Impresión, Encuadernación y otros")
            cmbObjeto.Items.Add("130 - Información y Publicidad")
            cmbObjeto.Items.Add("141 - Viáticos dentro del país")
        End Try
        If cmbObjeto.Items.Count > 0 Then
            cmbObjeto.SelectedIndex = 0
        End If
    End Sub

    Private Sub InitializeDataGrid()
        Dim dgv As DataGridView = Me.Controls.OfType(Of DataGridView)().FirstOrDefault()
        If dgv Is Nothing Then Return
        dgv.Columns.Clear()
        dgv.Columns.Add("Id", "Id")
        dgv.Columns.Add("Numero", "Número")
        dgv.Columns.Add("Fecha", "Fecha")
        dgv.Columns.Add("Proveedor", "Proveedor")
        dgv.Columns.Add("Monto", "Monto")
        dgv.Columns.Add("Objeto", "Objeto")
        dgv.Columns.Add("FechaGirado", "Fecha Girado")
        dgv.Columns.Add("Anulado", "Anulado")
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AllowUserToAddRows = False
    End Sub

    Private Sub RefreshGrid()
        ' Limpiar la lista en memoria
        cheques.Clear()
        
        Try
            Dim connectionString As String = "Server=localhost;Database=proyectoSoft2;Uid=root;Pwd=;"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                
                Dim query = "SELECT cheque_id, numero, fecha_emision, proveedor_codigo, monto, objeto_codigo, fecha_girado, fecha_anulacion, detalles FROM cheques ORDER BY cheque_id"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Obtener nombre del proveedor
                            Dim proveedorNombre As String = ""
                            If Not reader.IsDBNull(3) Then
                                proveedorNombre = ObtenerNombreProveedor(reader(3).ToString())
                            End If
                            
                            ' Obtener nombre del objeto
                            Dim objetoNombre As String = ""
                            If Not reader.IsDBNull(5) Then
                                objetoNombre = ObtenerNombreObjeto(reader(5).ToString())
                            End If
                            
                            Dim monto As Decimal = If(reader.IsDBNull(4), 0, CDec(reader(4)))
                            Dim montoLetras = NumeroALetrasCompleto(monto)
                            
                            Dim fechaGirado As DateTime? = Nothing
                            If Not reader.IsDBNull(6) Then
                                fechaGirado = CDate(reader(6))
                            End If
                            
                            Dim fechaAnulacion As DateTime? = Nothing
                            If Not reader.IsDBNull(7) Then
                                fechaAnulacion = CDate(reader(7))
                            End If
                            
                            ' Extraer el número como integer para actualizar nextChequeNumber
                            Dim numeroStr As String = reader(1).ToString()
                            Dim numeroInt As Integer = 0
                            If Integer.TryParse(numeroStr, numeroInt) Then
                                ' Actualizar nextChequeNumber al siguiente número disponible
                                If numeroInt >= nextChequeNumber Then
                                    nextChequeNumber = numeroInt + 1
                                End If
                            End If
                            
                            Dim c As New Cheque() With {
                                .ChequeId = CInt(reader(0)),
                                .Numero = numeroStr,
                                .Fecha = CDate(reader(2)),
                                .Proveedor = proveedorNombre,
                                .Monto = monto,
                                .MontoLetras = montoLetras,
                                .Objeto = objetoNombre,
                                .FechaGirado = fechaGirado,
                                .FechaAnulacion = fechaAnulacion,
                                .Detalle = If(reader.IsDBNull(8), "", reader(8).ToString())
                            }
                            cheques.Add(c)
                            
                            ' Actualizar nextId para que no haya conflictos
                            If c.ChequeId >= nextId Then
                                nextId = c.ChequeId + 1
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al recargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
        ' Mostrar datos en el DataGridView
        Dim dgv As DataGridView = Me.Controls.OfType(Of DataGridView)().FirstOrDefault()
        If dgv Is Nothing Then Return
        dgv.Rows.Clear()
        For Each c In cheques
            Dim fechaGirado = If(c.FechaGirado.HasValue, c.FechaGirado.Value.ToString("yyyy-MM-dd"), "")
            Dim anulado = If(c.FechaAnulacion.HasValue, c.FechaAnulacion.Value.ToString("yyyy-MM-dd"), "")
            dgv.Rows.Add(c.ChequeId, c.Numero, c.Fecha.ToString("yyyy-MM-dd"), c.Proveedor, c.Monto.ToString("N2"), c.Objeto, fechaGirado, anulado)
        Next
    End Sub

    ' Conversor completo de número a letras en dólares (hasta 99,999)
    Private Function NumeroALetrasCompleto(value As Decimal) As String
        Dim entero = Math.Truncate(value)
        Dim decimales = Math.Round((value - entero) * 100)
        
        ' Validar rango (0 a 99,999)
        If entero < 0 OrElse entero > 99999 Then
            Return "Cantidad fuera de rango"
        End If
        
        Dim unidades() As String = {"", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"}
        Dim dieces() As String = {"", "", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"}
        Dim diez_diecinueve() As String = {"diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve"}
        Dim centenas() As String = {"", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"}
        
        Dim resultado As String = ""
        
        ' Si es cero
        If entero = 0 Then
            resultado = "cero"
        Else
            ' Procesar miles
            Dim miles As Integer = CInt(entero \ 1000)
            If miles > 0 Then
                If miles = 1 Then
                    resultado &= "mil"
                Else
                    resultado &= ConvertirCentenas(miles, unidades, dieces, diez_diecinueve, centenas) & " mil"
                End If
            End If
            
            ' Procesar unidades, decenas y centenas restantes (0-999)
            Dim resto As Integer = CInt(entero Mod 1000)
            If resto > 0 Then
                If resultado <> "" Then resultado &= " "
                resultado &= ConvertirCentenas(resto, unidades, dieces, diez_diecinueve, centenas)
            End If
        End If
        
        ' Capitalizar primera letra
        If resultado.Length > 0 Then
            resultado = Char.ToUpper(resultado(0)) & resultado.Substring(1)
        End If
        
        ' Determinar singular o plural
        Dim moneda As String = If(entero = 1, "dólar", "dólares")
        
        ' Agregar centavos en dólares
        resultado &= String.Format(" {0} con {1:00}/100", moneda, CInt(decimales))
        
        Return resultado
    End Function
    
    Private Function ConvertirCentenas(numero As Integer, unidades() As String, dieces() As String, diez_diecinueve() As String, centenas() As String) As String
        Dim resultado As String = ""
        
        ' Procesar centenas (100-900)
        Dim cent As Integer = numero \ 100
        If cent > 0 Then
            resultado = centenas(cent)
        End If
        
        ' Procesar decenas y unidades (0-99)
        Dim resto As Integer = numero Mod 100
        If resto > 0 Then
            ' Si ya hay centenas, agregar conector
            If resultado <> "" Then resultado &= " "
            
            ' Unidades (1-9)
            If resto < 10 Then
                ' Si es 1, usar "un" en lugar de "uno"
                If resto = 1 Then
                    resultado &= "un"
                Else
                    resultado &= unidades(resto)
                End If
            ' Diez a diecinueve (10-19)
            ElseIf resto < 20 Then
                resultado &= diez_diecinueve(resto - 10)
            ' Veinte en adelante (20-99)
            Else
                Dim dec As Integer = resto \ 10
                Dim unid As Integer = resto Mod 10
                resultado &= dieces(dec)
                ' Si hay unidades, usar "y"
                If unid > 0 Then
                    ' Si es 1, usar "un" en lugar de "uno"
                    If unid = 1 Then
                        resultado &= " y un"
                    Else
                        resultado &= " y " & unidades(unid)
                    End If
                End If
            End If
        End If
        
        Return resultado
    End Function
    
    ' Generar número de cheque con formato 0000001
    Private Function GenerarNumeroCheque() As String
        Dim numero As String = nextChequeNumber.ToString("0000000")
        nextChequeNumber += 1
        Return numero
    End Function

    ' Handlers del MenuStrip
    Private Sub mnuCheques_Click(sender As Object, e As EventArgs) Handles mnuCheques.Click
        ' Estamos en Cheques — no hacer nada
    End Sub

    Private Sub mnuDepositos_Click(sender As Object, e As EventArgs) Handles mnuDepositos.Click
        Dim f As New FormDepositos()
        f.Show()
        Me.Close()
    End Sub

    Private Sub mnuConciliacion_Click(sender As Object, e As EventArgs) Handles mnuConciliacion.Click
        Dim f As New FormConciliacion()
        f.Show()
        Me.Close()
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Application.Exit()
    End Sub

    ' Botones del formulario
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Usar los controles Friend WithEvents directamente del Designer
        If txtNumero Is Nothing OrElse txtMonto Is Nothing OrElse cmbProveedor Is Nothing Then
            MessageBox.Show("Faltan controles en el formulario.")
            Return
        End If

        Dim montoVal As Decimal = 0
        Decimal.TryParse(txtMonto.Text, montoVal)

        ' Extraer solo el nombre del proveedor (sin el código)
        Dim proveedorNombre As String = ""
        Dim proveedorCodigo As String = ""
        If cmbProveedor.SelectedItem IsNot Nothing Then
            Dim provText As String = cmbProveedor.SelectedItem.ToString()
            If provText.Contains(" - ") Then
                Dim parts = provText.Split(New String() {" - "}, StringSplitOptions.None)
                proveedorCodigo = parts(0)
                proveedorNombre = String.Join(" - ", parts.Skip(1)).Trim()
            Else
                proveedorNombre = provText
            End If
        End If
        
        ' Extraer solo el nombre del objeto (sin el código)
        Dim objetoNombre As String = ""
        Dim objetoCodigo As String = ""
        If cmbObjeto.SelectedItem IsNot Nothing Then
            Dim objText As String = cmbObjeto.SelectedItem.ToString()
            If objText.Contains(" - ") Then
                Dim parts = objText.Split(New String() {" - "}, StringSplitOptions.None)
                objetoCodigo = parts(0)
                objetoNombre = String.Join(" - ", parts.Skip(1)).Trim()
            Else
                objetoNombre = objText
            End If
        End If

        Dim nuevo As New Cheque() With {
            .ChequeId = nextId,
            .Numero = txtNumero.Text,
            .Fecha = dtpFecha.Value,
            .Proveedor = proveedorNombre,
            .Monto = montoVal,
            .MontoLetras = txtMontoLetras.Text,
            .Detalle = txtDetalle.Text,
            .Objeto = objetoNombre
        }
        cheques.Add(nuevo)
        nextId += 1
        
        ' Guardar en la base de datos
        Try
            Dim connectionString As String = "Server=localhost;Database=proyectoSoft2;Uid=root;Pwd=;"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query = "INSERT INTO cheques (numero, fecha_emision, proveedor_codigo, monto, estado, objeto_codigo, detalles) " &
                            "VALUES (@numero, @fecha_emision, @proveedor_codigo, @monto, 0, @objeto_codigo, @detalles)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@numero", nuevo.Numero)
                    cmd.Parameters.AddWithValue("@fecha_emision", nuevo.Fecha)
                    
                    If String.IsNullOrEmpty(proveedorCodigo) Then
                        cmd.Parameters.AddWithValue("@proveedor_codigo", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@proveedor_codigo", proveedorCodigo)
                    End If
                    
                    cmd.Parameters.AddWithValue("@monto", nuevo.Monto)
                    
                    If String.IsNullOrEmpty(objetoCodigo) Then
                        cmd.Parameters.AddWithValue("@objeto_codigo", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@objeto_codigo", objetoCodigo)
                    End If
                    
                    cmd.Parameters.AddWithValue("@detalles", nuevo.Detalle)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            
            RefreshGrid()
            
            ' Limpiar inmediatamente todos los campos
            LimpiarFormulario()
            
            MessageBox.Show("Cheque guardado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al guardar en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarFormulario()
        ' Limpiar todos los TextBox
        txtNumero.Text = GenerarNumeroCheque()
        txtMonto.Text = String.Empty
        txtMontoLetras.Text = String.Empty
        txtDetalle.Text = String.Empty
        
        ' Resetear ComboBox y DateTimePicker
        dtpFecha.Value = DateTime.Today
        cmbProveedor.SelectedIndex = If(cmbProveedor.Items.Count > 0, 0, -1)
        cmbObjeto.SelectedIndex = If(cmbObjeto.Items.Count > 0, 0, -1)
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim dgv As DataGridView = Me.Controls.OfType(Of DataGridView)().FirstOrDefault()
        If dgv Is Nothing OrElse dgv.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un cheque para anular.")
            Return
        End If
        
        Dim id = CInt(dgv.SelectedRows(0).Cells(0).Value)
        Dim numeroCheque = dgv.SelectedRows(0).Cells(1).Value.ToString()
        
        ' Buscar el cheque en memoria
        Dim c = cheques.FirstOrDefault(Function(x) x.ChequeId = id)
        If c Is Nothing Then Return
        
        ' Validar que el cheque sea nuevo (no haya sido anulado previamente)
        If c.FechaAnulacion.HasValue Then
            MessageBox.Show("Este cheque ya ha sido anulado. No se puede procesar nuevamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Si el cheque ya fue girado, no se puede anular
        If c.FechaGirado.HasValue Then
            MessageBox.Show("Este cheque ya ha sido girado. No se puede anular.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Abrir formulario para anular
        Using f As New FormAnularCheque(c.Fecha)
            If f.ShowDialog() = DialogResult.OK Then
                Dim fechaSeleccionada = f.FechaSeleccionada
                
                ' Actualizar en memoria
                c.FechaAnulacion = fechaSeleccionada
                
                ' Verificar si la anulación es en el mismo mes y año que la creación
                Dim esDelMismoMes As Boolean = (c.Fecha.Year = fechaSeleccionada.Year AndAlso 
                                               c.Fecha.Month = fechaSeleccionada.Month)
                
                ' Si es del mismo mes, el monto será 0; si no, quedará igual
                Dim montoAGuardar As Decimal = If(esDelMismoMes, 0, c.Monto)
                
                ' Guardar en la base de datos
                Try
                    Dim connectionString As String = "Server=localhost;Database=proyectoSoft2;Uid=root;Pwd=;"
                    Using conn As New MySqlConnection(connectionString)
                        conn.Open()
                        
                        ' Guardar como anulado (estado = 1, fecha_anulacion, y monto = 0 si es mismo mes)
                        Dim query = "UPDATE cheques SET fecha_anulacion = @fecha_anulacion, estado = 1, monto = @monto WHERE numero = @numero"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@fecha_anulacion", fechaSeleccionada)
                            cmd.Parameters.AddWithValue("@monto", montoAGuardar)
                            cmd.Parameters.AddWithValue("@numero", numeroCheque)
                            cmd.ExecuteNonQuery()
                        End Using
                        
                        Dim mensaje As String = If(esDelMismoMes, 
                            "Cheque anulado correctamente. Monto cambiado a 0 (anulación del mismo mes).", 
                            "Cheque anulado correctamente. Monto mantenido (anulación de otro mes).")
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                    
                    RefreshGrid()
                Catch ex As Exception
                    MessageBox.Show("Error al anular el cheque: " & ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub
    Private Sub btnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
        Using f As New FormProveedor()
            If f.ShowDialog() = DialogResult.OK Then
                ' Recargar proveedores (en producción recargar de la BD)
                LoadProveedores()
            End If
        End Using
    End Sub

    Private Sub btnChequesGirados_Click(sender As Object, e As EventArgs) Handles btnChequesGirados.Click
        Dim dgv As DataGridView = Me.Controls.OfType(Of DataGridView)().FirstOrDefault()
        If dgv Is Nothing OrElse dgv.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un cheque para girar.")
            Return
        End If
        
        Dim id = CInt(dgv.SelectedRows(0).Cells(0).Value)
        Dim numeroCheque = dgv.SelectedRows(0).Cells(1).Value.ToString()
        
        ' Buscar el cheque en memoria
        Dim c = cheques.FirstOrDefault(Function(x) x.ChequeId = id)
        If c Is Nothing Then Return
        
        ' Validar que el cheque sea nuevo (no haya sido girado previamente)
        ' Si el cheque ya fue anulado, no se puede girar
        If c.FechaAnulacion.HasValue Then
            MessageBox.Show("Este cheque ya ha sido anulado. No se puede girar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validar que el cheque sea nuevo (no haya sido girado previamente)
        If c.FechaGirado.HasValue Then
            MessageBox.Show("Este cheque ya ha sido girado. No se puede procesar nuevamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Abrir formulario para girar
        Using f As New FormGirarCheque(c.Fecha)
            If f.ShowDialog() = DialogResult.OK Then
                Dim fechaSeleccionada = f.FechaSeleccionada
                
                ' Actualizar en memoria
                c.FechaGirado = fechaSeleccionada
                
                ' Guardar en la base de datos
                Try
                    Dim connectionString As String = "Server=localhost;Database=proyectoSoft2;Uid=root;Pwd=;"
                    Using conn As New MySqlConnection(connectionString)
                        conn.Open()
                        
                        ' Guardar como girado (estado = 0, fecha_girado)
                        Dim query = "UPDATE cheques SET estado = 0, fecha_girado = @fecha_girado WHERE numero = @numero"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@fecha_girado", fechaSeleccionada)
                            cmd.Parameters.AddWithValue("@numero", numeroCheque)
                            cmd.ExecuteNonQuery()
                        End Using
                        
                        MessageBox.Show("Cheque girado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                    
                    RefreshGrid()
                Catch ex As Exception
                    MessageBox.Show("Error al girar el cheque: " & ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    ' Actualizar monto en letras al cambiar monto
    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        Dim montoVal As Decimal = 0
        If Decimal.TryParse(txtMonto.Text, montoVal) Then
            txtMontoLetras.Text = NumeroALetrasCompleto(montoVal)
        End If
    End Sub
    
End Class
