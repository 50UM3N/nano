Public Class Form2
    Enum opa
        start
        close
        wait
    End Enum
    Public action As opa = opa.start
    Public Sub setOpen()
        Me.Opacity = 0
        Timer1.Interval = 1
        Timer1.Start()
        Me.Show()
    End Sub
    Public Sub info(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer)
        Dim f As Guna.UI.WinForms.GunaControlBox = New Guna.UI.WinForms.GunaControlBox
        f.Size = New Point(20, 20)
        f.IconColor = ColorTranslator.FromHtml("#7F89C2")
        f.IconSize = 10
        f.OnHoverBackColor = Color.Transparent
        f.Location = New Point(392, 6)
        f.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        GunaLinePanel1.Controls.Add(f)
        Me.StartPosition = FormStartPosition.Manual
        Debug.Print(x & " " & h)
        If h = 346 Then
            y = y + 81
        Else
            y = y + 190
        End If
        x = x + 76
        Debug.Print(x & " " & y)
        Me.Location = New Point(x, y)
        Me.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case action
            Case opa.start
                If Me.Opacity = 1 Then
                    action = opa.wait
                Else
                    Me.Opacity += 0.1
                End If
            Case opa.wait
                Timer1.Interval = 2000
                action = opa.close
            Case opa.close
                Timer1.Interval = 1
                If Me.Opacity = 0 Then
                    Close()
                Else
                    Me.Opacity -= 0.1
                End If
        End Select
    End Sub
End Class