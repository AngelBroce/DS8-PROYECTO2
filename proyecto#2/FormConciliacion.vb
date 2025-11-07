Public Class FormConciliacion
    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs)
        Close
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
        DateTimePicker1.CustomFormat = "MM-yyyy"
    End Sub
End Class
'' Eliminada definición parcial duplicada; los handlers están en la clase principal arriba.
