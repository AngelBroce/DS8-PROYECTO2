Public Class FormDepositos
    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs)
        Close
    End Sub

    Private Sub mnuCheques_Click(sender As Object, e As EventArgs) Handles mnuCheques.Click
        Using f As New FormCheques()
            f.ShowDialog()
        End Using
    End Sub

    Private Sub mnuDepositos_Click(sender As Object, e As EventArgs) Handles mnuDepositos.Click
        ' Estamos en Depósitos — no hacer nada
    End Sub

    Private Sub mnuConciliacion_Click(sender As Object, e As EventArgs) Handles mnuConciliacion.Click
        Using f As New FormConciliacion()
            f.ShowDialog()
        End Using
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Application.Exit()
    End Sub

    Private Sub FormDepositos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
