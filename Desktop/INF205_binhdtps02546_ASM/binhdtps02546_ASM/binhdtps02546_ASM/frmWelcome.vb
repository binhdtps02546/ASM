Public Class frmWelcome
    Private Sub tmLoadTime_Tick(sender As Object, e As EventArgs) Handles loadTimer.Tick, prBar.Click
        prBar.Increment(3)
        If prBar.Value = prBar.Maximum Then
            Me.Close()
        End If
    End Sub
End Class
