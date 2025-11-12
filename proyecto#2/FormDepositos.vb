Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FormDepositos
    ' Ajuste: usar la misma conexión que en FormCheques
    Private ReadOnly connString As String =
        "Server=localhost;Database=proyectoSoft2;Uid=root;Pwd=;"

    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub mnuCheques_Click(sender As Object, e As EventArgs) Handles mnuCheques.Click
        Dim f As New FormCheques()
        f.Show()
        Me.Close()
    End Sub

    Private Sub mnuDepositos_Click(sender As Object, e As EventArgs) Handles mnuDepositos.Click
        ' Estamos en Depósitos — no hacer nada
    End Sub

    Private Sub mnuConciliacion_Click(sender As Object, e As EventArgs) Handles mnuConciliacion.Click
        Dim f As New FormConciliacion()
        f.Show()
        Me.Close()
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Application.Exit()
    End Sub

    Private Sub FormDepositos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarDepositos()
    End Sub

    ' Eliminado manejo de número de cuenta; ya no se ocultan/validan controles.

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tipo As String = If(RadioButton1.Checked, "Transferencia", "Deposito Directo")
        Dim fecha As Date = DateTimePicker1.Value.Date

        Dim monto As Decimal
        If Not Decimal.TryParse(TextBox1.Text.Trim(), monto) OrElse monto <= 0D Then
            MessageBox.Show("Ingrese un monto válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
            Return
        End If

        Dim descripcion As Object = DBNull.Value

        Try
            Using cn As New MySqlConnection(connString)
                cn.Open()
                Dim sql As String = "INSERT INTO depositos (Tipo, FechaOperacion, Monto, ) VALUES (@tipo, @fecha, @monto)"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = tipo
                    cmd.Parameters.Add("@fecha", MySqlDbType.Date).Value = fecha
                    cmd.Parameters.Add("@monto", MySqlDbType.Decimal).Value = monto
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Limpiar y recargar
            TextBox1.Clear()
            RadioButton2.Checked = True
            CargarDepositos()

            MessageBox.Show("Depósito registrado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDepositos()
        Try
            Using cn As New MySqlConnection(connString)
                Dim dt As New DataTable()
                Using da As New MySqlDataAdapter("SELECT DepositoID, Tipo, FechaOperacion, Monto, FechaRegistro FROM depositos ORDER BY DepositoID DESC", cn)
                    da.Fill(dt)
                End Using
                DataGridView1.DataSource = dt
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                DataGridView1.ReadOnly = True
                DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
