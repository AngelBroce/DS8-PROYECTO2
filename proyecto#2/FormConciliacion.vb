Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class FormConciliacion
    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
    Private Sub mnuCheques_Click(sender As Object, e As EventArgs) Handles mnuCheques.Click
        Dim f As New FormCheques()
        f.Show()
        Me.Close()
    End Sub

    Private Sub mnuDepositos_Click(sender As Object, e As EventArgs) Handles mnuDepositos.Click
        Dim f As New FormDepositos()
        f.Show()
        Me.Close()
    End Sub

    Private Sub mnuConciliacion_Click(sender As Object, e As EventArgs) Handles mnuConciliacion.Click
        ' Estamos en Conciliación — no hacer nada
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Application.Exit()
    End Sub

    Private Sub FormConciliacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM yyyy"
        DateTimePicker1.ShowUpDown = False

        ' Intentar enlazar dinámicamente un botón llamado "btnRegistrar" si existe en el formulario
        Dim posibles = Me.Controls.Find("btnRegistrar", True)
        If posibles IsNot Nothing AndAlso posibles.Length > 0 Then
            Dim btn = TryCast(posibles(0), Button)
            If btn IsNot Nothing Then
                AddHandler btn.Click, AddressOf BtnRegistrar_Click
            End If
        End If
    End Sub

    ' Calcula y aplica los textos de las etiquetas según la fecha seleccionada
    Private Sub AplicarFechasEnEtiquetas()
        ' Tomar solo mes/año del selector
        Dim seleccion As Date = New Date(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1)

        ' Último día del mes seleccionado
        Dim finDeMes As Date = New Date(seleccion.Year, seleccion.Month, System.DateTime.DaysInMonth(seleccion.Year, seleccion.Month))

        ' Último día del mes anterior (considerando cambio de año)
        Dim mesAnterior As Date = seleccion.AddMonths(-1)
        Dim finDeMesAnterior As Date = New Date(mesAnterior.Year, mesAnterior.Month, System.DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month))

        ' Cultura española para mostrar mes en español
        Dim es As CultureInfo = New CultureInfo("es-ES")

        ' 1) Correspondiente al mes ... (según pedido: con último día, mes y año seleccionados)
        lblcorrespondientealmes.Text = "Correspondiente al mes de " & finDeMes.ToString("dd 'de' MMMM 'de' yyyy", es)

        ' 2) SALDO SEGÚN LIBRO AL ... (último día del mes ANTERIOR)
        lblsaldosegunlibro.Text = "SALDO SEGÚN LIBRO AL " & finDeMesAnterior.ToString("dd 'de' MMMM 'de' yyyy", es)

        ' 3) SALDO CONCILIADO SEGÚN LIBROS AL ... (último día del mes seleccionado)
        lblsaldoconciliadosegunlibros.Text = "SALDO CONCILIADO SEGÚN LIBROS AL " & finDeMes.ToString("dd 'de' MMMM 'de' yyyy", es)

        ' 4) SALDO EN BANCO AL ... (último día del mes seleccionado)
        lblsaldoenbancoal.Text = "SALDO EN BANCO AL " & finDeMes.ToString("dd 'de' MMMM 'de' yyyy", es)

        ' 5) SALDO CONCILIADO IGUAL A BANCO ... (último día del mes seleccionado)
        '    Mantengo el enunciado tal como está en el diseñador y agrego la fecha.
        lblsaldoconciliadoigualabanco.Text = "SALDO CONCILIADO IGUAL A BANCO " & finDeMes.ToString("dd 'de' MMMM 'de' yyyy", es)
    End Sub

    ' Connection string: AJUSTA usuario/contraseña según tu entorno de MySQL/MariaDB
    Private ReadOnly Property ConnString As String
        Get
            ' Si usas otra cuenta o contraseña, cámbiala aquí o muévela a configuración
            Return "Server=localhost;Database=proyectosoft2;Uid=root;Pwd=;"
        End Get
    End Property

    Private Function FormatMoney(value As Decimal) As String
        Return value.ToString("N2")
    End Function

    Private Function TryParseDec(texto As String) As Decimal
        Dim d As Decimal
        If Decimal.TryParse(texto, NumberStyles.Any, CultureInfo.CurrentCulture, d) Then
            Return d
        End If
        ' Intento adicional con invariante por si hay un formato distinto
        If Decimal.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, d) Then
            Return d
        End If
        Return 0D
    End Function

    Private Sub CargarDatosDesdeBD()
        Dim seleccionPrimerDia As Date = New Date(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1)
        Dim seleccionUltimoDia As Date = New Date(seleccionPrimerDia.Year, seleccionPrimerDia.Month, Date.DaysInMonth(seleccionPrimerDia.Year, seleccionPrimerDia.Month))

        Dim anterior As Date = seleccionPrimerDia.AddMonths(-1)
        Dim saldoSegunLibroAnterior As Decimal = 0D
        Dim totalDepositos As Decimal = 0D
        Dim totalChequesAnulados As Decimal = 0D
        Dim totalChequesGirados As Decimal = 0D
        Dim totalChequesEnCirculacion As Decimal = 0D

        Try
            Using cn As New MySqlConnection(ConnString)
                cn.Open()

                ' 1) SALDO SEGÚN LIBRO — mes anterior
                Using cmd As New MySqlCommand("SELECT saldo_conciliado FROM conciliacion_bancaria WHERE mes=@mes AND anio=@anio LIMIT 1", cn)
                    cmd.Parameters.AddWithValue("@mes", anterior.Month)
                    cmd.Parameters.AddWithValue("@anio", anterior.Year)
                    Dim obj = cmd.ExecuteScalar()
                    If obj IsNot Nothing AndAlso obj IsNot DBNull.Value Then
                        saldoSegunLibroAnterior = Convert.ToDecimal(obj)
                    End If
                End Using

                ' 2) DEPÓSITOS — suma del mes seleccionado
                Using cmd As New MySqlCommand("SELECT IFNULL(SUM(Monto),0) FROM depositos WHERE FechaOperacion BETWEEN @d1 AND @d2", cn)
                    cmd.Parameters.AddWithValue("@d1", seleccionPrimerDia)
                    cmd.Parameters.AddWithValue("@d2", seleccionUltimoDia)
                    totalDepositos = Convert.ToDecimal(cmd.ExecuteScalar())
                End Using

                ' 3) CHEQUES ANULADOS — suma del mes seleccionado (por fecha_anulacion)
                Using cmd As New MySqlCommand("SELECT IFNULL(SUM(monto),0) FROM cheques WHERE fecha_anulacion IS NOT NULL AND DATE(fecha_anulacion) BETWEEN @d1 AND @d2", cn)
                    cmd.Parameters.AddWithValue("@d1", seleccionPrimerDia)
                    cmd.Parameters.AddWithValue("@d2", seleccionUltimoDia)
                    totalChequesAnulados = Convert.ToDecimal(cmd.ExecuteScalar())
                End Using

                ' 4) CHEQUES GIRADOS — suma del mes seleccionado (por fecha_girado)
                Using cmd As New MySqlCommand("SELECT IFNULL(SUM(monto),0) FROM cheques WHERE fecha_girado IS NOT NULL AND DATE(fecha_girado) BETWEEN @d1 AND @d2", cn)
                    cmd.Parameters.AddWithValue("@d1", seleccionPrimerDia)
                    cmd.Parameters.AddWithValue("@d2", seleccionUltimoDia)
                    totalChequesGirados = Convert.ToDecimal(cmd.ExecuteScalar())
                End Using

                ' 5) CHEQUES EN CIRCULACIÓN — solo cheques SIN fecha de anulación Y CON fecha_girado dentro del mes.
                Using cmd As New MySqlCommand("SELECT IFNULL(SUM(monto),0) FROM cheques
                                WHERE fecha_anulacion IS NULL AND fecha_girado IS NOT NULL AND DATE(fecha_girado) BETWEEN @d1 AND @d2", cn)
                    cmd.Parameters.AddWithValue("@d1", seleccionPrimerDia)
                    cmd.Parameters.AddWithValue("@d2", seleccionUltimoDia)
                    totalChequesEnCirculacion = Convert.ToDecimal(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al consultar la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' En caso de error, continuamos con ceros para no romper el flujo
        End Try

        ' Asignaciones a los TextBox
        txtsaldosegun.Text = FormatMoney(saldoSegunLibroAnterior)
        txtdepositos.Text = FormatMoney(totalDepositos)
        ' Nota: en el diseñador el control se llama txtxhequesanulados (con x). Usamos ese nombre real.
        txtxhequesanulados.Text = FormatMoney(totalChequesAnulados)

        Dim suma As Decimal = totalDepositos + totalChequesAnulados
        txtsuma.Text = FormatMoney(suma)

        Dim subtotal As Decimal = saldoSegunLibroAnterior + suma
        txtsubtotal.Text = FormatMoney(subtotal)

        txtchequesgirados.Text = FormatMoney(totalChequesGirados)
        txtresta1.Text = FormatMoney(totalChequesGirados)

        Dim saldoConciliadoSegun As Decimal = subtotal - totalChequesGirados
        txtsaldoconciliadosegun.Text = FormatMoney(saldoConciliadoSegun)

        txtdepositosentransito.Text = FormatMoney(0D)

        txtchequesencirculacion.Text = FormatMoney(totalChequesEnCirculacion)
        txtrestacheques.Text = FormatMoney(totalChequesEnCirculacion)
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs)
        ' Recalcular y validar que Banco == Libros
        If Not RecalcularYValidarConciliacion(True) Then
            Exit Sub
        End If

        ' Preparar datos de periodo
        Dim seleccion As New Date(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1)
        Dim mes As Integer = seleccion.Month
        Dim anio As Integer = seleccion.Year
        Dim saldo As Decimal = TryParseDec(txtsaldoconciliadoigualabanco.Text)

        ' Manejar posible duplicado
        Dim permitirReemplazo As Boolean = False
        If ExisteConciliacion(mes, anio) Then
            Dim es As New CultureInfo("es-ES")
            Dim resp = MessageBox.Show(
                "Ya existe una conciliación para " & seleccion.ToString("MMMM yyyy", es) & ". ¿Desea reemplazarla?",
                "Registro duplicado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )
            permitirReemplazo = (resp = DialogResult.Yes)
            If Not permitirReemplazo Then
                MessageBox.Show("No se guardó la conciliación.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        ' Guardar (insert / upsert condicionado)
        GuardarConciliacion(mes, anio, saldo, permitirReemplazo)
    End Sub

    ' Recalcula y valida que el saldo conciliado de banco sea igual al de libros
    Private Function RecalcularYValidarConciliacion(Optional mostrarMensajes As Boolean = True) As Boolean
        Dim saldoEnBanco As Decimal = TryParseDec(txtsaldoenbanco.Text)
        Dim restaCheques As Decimal = TryParseDec(txtrestacheques.Text)
        Dim totalBancoConciliado As Decimal = saldoEnBanco - restaCheques
        txtsaldoconciliadoigualabanco.Text = FormatMoney(totalBancoConciliado)

        Dim saldoConciliadoSegun As Decimal = TryParseDec(txtsaldoconciliadosegun.Text)
        If Math.Round(totalBancoConciliado, 2) <> Math.Round(saldoConciliadoSegun, 2) Then
            If mostrarMensajes Then
                MessageBox.Show("El 'Saldo conciliado igual a banco' no coincide con el 'Saldo conciliado según libros'.", "Diferencia en conciliación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return False
        End If
        Return True
    End Function

    Private Function ExisteConciliacion(mes As Integer, anio As Integer) As Boolean
        Try
            Using cn As New MySqlConnection(ConnString)
                cn.Open()
                Using cmd As New MySqlCommand("SELECT 1 FROM conciliacion_bancaria WHERE mes=@mes AND anio=@anio LIMIT 1", cn)
                    cmd.Parameters.AddWithValue("@mes", mes)
                    cmd.Parameters.AddWithValue("@anio", anio)
                    Dim o = cmd.ExecuteScalar()
                    Return o IsNot Nothing
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Sub GuardarConciliacion(mes As Integer, anio As Integer, saldo As Decimal, permitirReemplazo As Boolean)
        Try
            Using cn As New MySqlConnection(ConnString)
                cn.Open()
                Dim sql As String =
                    "INSERT INTO conciliacion_bancaria (mes, anio, saldo_conciliado) " &
                    "VALUES (@mes, @anio, @saldo) " &
                    "ON DUPLICATE KEY UPDATE " &
                    "saldo_conciliado = CASE WHEN @reemplazo = 1 THEN VALUES(saldo_conciliado) ELSE saldo_conciliado END;"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@mes", mes)
                    cmd.Parameters.AddWithValue("@anio", anio)
                    cmd.Parameters.AddWithValue("@saldo", saldo)
                    cmd.Parameters.AddWithValue("@reemplazo", If(permitirReemplazo, 1, 0))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Conciliación guardada.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al guardar la conciliación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Click en Imprimir
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        ' Ajustar textos y cargar datos
        AplicarFechasEnEtiquetas()
        CargarDatosDesdeBD()
    End Sub
End Class
'' Eliminada definición parcial duplicada; los handlers están en la clase principal arriba.
