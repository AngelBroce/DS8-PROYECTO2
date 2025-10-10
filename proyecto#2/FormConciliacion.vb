Public Class FormConciliacion
    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        Me.Close()
    End Sub
    Private Sub mnuCheques_Click(sender As Object, e As EventArgs) Handles mnuCheques.Click
        Using f As New FormCheques()
            f.ShowDialog()
        End Using
    End Sub

    Private Sub mnuDepositos_Click(sender As Object, e As EventArgs) Handles mnuDepositos.Click
        Using f As New FormDepositos()
            f.ShowDialog()
        End Using
    End Sub

    Private Sub mnuConciliacion_Click(sender As Object, e As EventArgs) Handles mnuConciliacion.Click
        ' Estamos en Conciliación — no hacer nada
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Application.Exit()
    End Sub
End Class
'' Eliminada definición parcial duplicada; los handlers están en la clase principal arriba.
