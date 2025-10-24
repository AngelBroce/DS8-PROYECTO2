Imports System.Windows.Forms

Public Class FormAnularCheque
    Inherits Form

    Public Property FechaAnulacion As DateTime?
    Private ReadOnly chequeId As Integer

    Public Sub New(id As Integer)
        Me.chequeId = id
        ' Minimal form: no controles, sólo inicialización ligera
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Anular cheque"
        Me.Width = 300
        Me.Height = 150
    End Sub

    ' Simular diálogo simple: devolver OK y fijar fecha de anulación a hoy.
    Public Shadows Function ShowDialog() As DialogResult
        Me.FechaAnulacion = DateTime.Today
        Return DialogResult.OK
    End Function

End Class
