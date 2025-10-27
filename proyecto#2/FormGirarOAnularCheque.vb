Imports System.Windows.Forms

Public Class FormGirarOAnularCheque
    Inherits Form

    Private lblTitulo As Label
    Private lblFecha As Label
    Private dtpFecha As DateTimePicker
    Private btnGirar As Button
    Private btnAnular As Button
    Private btnCancelar As Button
    Private components As System.ComponentModel.IContainer
    
    Public Property Accion As String ' "Girar" o "Anular"
    Public Property FechaSeleccionada As DateTime
    Public Property FechaCreacion As DateTime
    
    Private components_ As System.ComponentModel.IContainer = Nothing

    Public Sub New(fechaCreacion As DateTime)
        InitializeComponent()
        Me.FechaCreacion = fechaCreacion
        dtpFecha.Value = DateTime.Today
        dtpFecha.MinDate = fechaCreacion
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Girar o Anular Cheque"
        Me.Width = 550
        Me.Height = 350
    End Sub

    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        
        ' Título
        lblTitulo = New Label()
        lblTitulo.Text = "¿Desea girar o anular el cheque?"
        lblTitulo.Location = New Point(20, 20)
        lblTitulo.Size = New Size(500, 30)
        lblTitulo.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.Controls.Add(lblTitulo)
        
        ' Etiqueta Fecha
        lblFecha = New Label()
        lblFecha.Text = "Fecha:"
        lblFecha.Location = New Point(20, 70)
        lblFecha.Size = New Size(100, 25)
        lblFecha.Font = New Font("Segoe UI", 10)
        Me.Controls.Add(lblFecha)
        
        ' DateTimePicker
        dtpFecha = New DateTimePicker()
        dtpFecha.Location = New Point(130, 70)
        dtpFecha.Size = New Size(350, 28)
        dtpFecha.Format = DateTimePickerFormat.Short
        Me.Controls.Add(dtpFecha)
        
        ' Botón Girar (IZQUIERDA)
        btnGirar = New Button()
        btnGirar.Text = "Girar"
        btnGirar.Location = New Point(50, 140)
        btnGirar.Size = New Size(150, 50)
        btnGirar.BackColor = Color.LightBlue
        btnGirar.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.Controls.Add(btnGirar)
        AddHandler btnGirar.Click, AddressOf btnGirar_Click
        
        ' Botón Anular (DERECHA)
        btnAnular = New Button()
        btnAnular.Text = "Anular"
        btnAnular.Location = New Point(320, 140)
        btnAnular.Size = New Size(150, 50)
        btnAnular.BackColor = Color.IndianRed
        btnAnular.ForeColor = Color.White
        btnAnular.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.Controls.Add(btnAnular)
        AddHandler btnAnular.Click, AddressOf btnAnular_Click
        
        ' Botón Cancelar (ABAJO, CENTRADO)
        btnCancelar = New Button()
        btnCancelar.Text = "Cancelar"
        btnCancelar.Location = New Point(185, 230)
        btnCancelar.Size = New Size(150, 40)
        btnCancelar.Font = New Font("Segoe UI", 10)
        Me.Controls.Add(btnCancelar)
        AddHandler btnCancelar.Click, AddressOf btnCancelar_Click
        
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub btnGirar_Click(sender As Object, e As EventArgs)
        ' Validar que la fecha no sea anterior a la fecha de creación
        If dtpFecha.Value < FechaCreacion Then
            MessageBox.Show("La fecha no puede ser anterior a la fecha de creación del cheque.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Me.Accion = "Girar"
        Me.FechaSeleccionada = dtpFecha.Value
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs)
        ' Validar que la fecha no sea anterior a la fecha de creación
        If dtpFecha.Value < FechaCreacion Then
            MessageBox.Show("La fecha no puede ser anterior a la fecha de creación del cheque.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Me.Accion = "Anular"
        Me.FechaSeleccionada = dtpFecha.Value
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
