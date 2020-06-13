Public Class loder
    Dim a As Integer = 1
    Private Sub animation_Tick(sender As Object, e As EventArgs) Handles animation.Tick
        If circle.Value = 100 Then
            a = -1
        ElseIf circle.Value = 0 Then
            a = +1
        End If
        circle.Value += a
    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        circle.Value = 0
        animation.Interval = 1
        animation.Start()
    End Sub
End Class
