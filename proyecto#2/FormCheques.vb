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
        Public Property FechaAnulacion As DateTime?
    End Class

    Private cheques As New List(Of Cheque)()
    Private nextId As Integer = 1

    Private Sub FormCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar controles y cargar datos de ejemplo
        LoadProveedores()
        LoadObjetos()
        InitializeDataGrid()
    End Sub

    Private Sub LoadProveedores()
        ' Datos de ejemplo - en producción cargar desde la tabla proveedores
        cmbProveedor.Items.Clear()
        cmbProveedor.Items.Add("Proveedor Ejemplo S.A.")
        cmbProveedor.Items.Add("CARILO, S.A.")
        cmbProveedor.Items.Add("AGENCIA SKY")
        cmbProveedor.SelectedIndex = 0
    End Sub

    Private Sub LoadObjetos()
        cmbObjeto.Items.Clear()
        cmbObjeto.Items.Add("OG-001 - Gastos administrativos")
        cmbObjeto.Items.Add("OG-002 - Gastos operativos")
        cmbObjeto.Items.Add("OG-003 - Honorarios profesionales")
        cmbObjeto.SelectedIndex = 0
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
        dgv.Columns.Add("Anulado", "Anulado")
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AllowUserToAddRows = False
    End Sub

    Private Sub RefreshGrid()
        Dim dgv As DataGridView = Me.Controls.OfType(Of DataGridView)().FirstOrDefault()
        If dgv Is Nothing Then Return
        dgv.Rows.Clear()
        For Each c In cheques
            Dim anulado = If(c.FechaAnulacion.HasValue, c.FechaAnulacion.Value.ToString("yyyy-MM-dd"), "")
            dgv.Rows.Add(c.ChequeId, c.Numero, c.Fecha.ToString("yyyy-MM-dd"), c.Proveedor, c.Monto.ToString("N2"), c.Objeto, anulado)
        Next
    End Sub

    ' Conversor muy simple de número a texto (soporta hasta millones, sin decimales detallados)
    Private Function NumeroALetras(value As Decimal) As String
        Dim entero = Math.Truncate(value)
        Dim decimales = (value - entero)
        Dim texto As String = entero.ToString() & " bolivianos" ' adaptalo según moneda
        If decimales > 0 Then
            texto &= String.Format(" con {0:00}/100", CInt(Math.Round(decimales * 100)))
        End If
        Return texto
    End Function

    ' Handlers del MenuStrip
    Private Sub mnuCheques_Click(sender As Object, e As EventArgs) Handles mnuCheques.Click
        ' Estamos en Cheques — no hacer nada
    End Sub

    Private Sub mnuDepositos_Click(sender As Object, e As EventArgs) Handles mnuDepositos.Click
        Using f As New FormDepositos()
            f.ShowDialog()
        End Using
    End Sub

    Private Sub mnuConciliacion_Click(sender As Object, e As EventArgs) Handles mnuConciliacion.Click
        Using f As New FormConciliacion()
            f.ShowDialog()
        End Using
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Application.Exit()
    End Sub

    ' Botones del formulario
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ' Limpiar campos
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then DirectCast(ctrl, TextBox).Text = String.Empty
        Next
        dtpFecha.Value = DateTime.Today
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim numero = Me.Controls.OfType(Of TextBox)().FirstOrDefault(Function(t) t.Location = New Point(20, 65)).Text
        Catch ex As Exception
            ' El control fue localizado por variable en designer; usaremos búsqueda por Name alternativa si hace falta
        End Try
        ' Para simplicidad, recuperamos controles por tipos y posiciones (puedes vincularlos a variables con Friend WithEvents para mayor robustez)
        Dim txtNumero = Me.Controls.OfType(Of TextBox)().OrderBy(Function(t) t.Location.Y).FirstOrDefault()
        Dim txtMonto = Me.Controls.OfType(Of TextBox)().OrderByDescending(Function(t) t.Location.Y).FirstOrDefault()
        Dim txtMontoLetras = Me.Controls.OfType(Of TextBox)().Where(Function(t) t.ReadOnly).FirstOrDefault()
        Dim txtDetalle = Me.Controls.OfType(Of TextBox)().Where(Function(t) t.Multiline).FirstOrDefault()
        Dim cmbProv = Me.Controls.OfType(Of ComboBox)().FirstOrDefault()
        Dim cmbObj = Me.Controls.OfType(Of ComboBox)().LastOrDefault()
        Dim dtp = Me.Controls.OfType(Of DateTimePicker)().FirstOrDefault()

        If txtNumero Is Nothing OrElse txtMonto Is Nothing OrElse cmbProv Is Nothing Then
            MessageBox.Show("Faltan controles en el formulario.")
            Return
        End If

        Dim montoVal As Decimal = 0
        Decimal.TryParse(txtMonto.Text, montoVal)

        Dim nuevo As New Cheque() With {
            .ChequeId = nextId,
            .Numero = txtNumero.Text,
            .Fecha = If(dtp IsNot Nothing, dtp.Value, DateTime.Today),
            .Proveedor = If(cmbProv.SelectedItem IsNot Nothing, cmbProv.SelectedItem.ToString(), ""),
            .Monto = montoVal,
            .MontoLetras = If(txtMontoLetras IsNot Nothing, txtMontoLetras.Text, NumeroALetras(montoVal)),
            .Detalle = If(txtDetalle IsNot Nothing, txtDetalle.Text, ""),
            .Objeto = If(cmbObj IsNot Nothing AndAlso cmbObj.SelectedItem IsNot Nothing, cmbObj.SelectedItem.ToString(), "")
        }
        cheques.Add(nuevo)
        nextId += 1
        RefreshGrid()
        MessageBox.Show("Cheque registrado.")
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim dgv As DataGridView = Me.Controls.OfType(Of DataGridView)().FirstOrDefault()
        If dgv Is Nothing OrElse dgv.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un cheque para anular.")
            Return
        End If
        Dim id = CInt(dgv.SelectedRows(0).Cells(0).Value)
        Using f As New FormAnularCheque(id)
            If f.ShowDialog() = DialogResult.OK Then
                Dim fechaAnul = f.FechaAnulacion
                Dim c = cheques.FirstOrDefault(Function(x) x.ChequeId = id)
                If c IsNot Nothing Then
                    c.FechaAnulacion = fechaAnul
                    RefreshGrid()
                End If
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

    ' Actualizar monto en letras al cambiar monto
    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        Dim txtMonto = DirectCast(sender, TextBox)
        Dim montoVal As Decimal = 0
        If Decimal.TryParse(txtMonto.Text, montoVal) Then
            Dim txtLetras = Me.Controls.OfType(Of TextBox)().Where(Function(t) t.ReadOnly).FirstOrDefault()
            If txtLetras IsNot Nothing Then txtLetras.Text = NumeroALetras(montoVal)
        End If
    End Sub
    
End Class
