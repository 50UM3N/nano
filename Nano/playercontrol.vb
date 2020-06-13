Public Class playercontrol
    Public ind As Integer
    Public Sub nam(ByVal title As String, ByVal duration As String, ByVal index As Integer)
        Dim t As String
        Dim sstring As String()
        sstring = Split(title, ".")
        t = duration.Substring(3, 5)
        GunaButton1.Text = sstring(0)
        Label1.Text = t
        ind = index
    End Sub
    Function clk() Handles GunaButton1.Click
        GunaButton1.ForeColor = ColorTranslator.FromHtml("#F7A931")
        GunaButton1.OnHoverForeColor = ColorTranslator.FromHtml("#F7A931")
        GunaButton1.Image = My.Resources.m
        Form1.clk(ind)
        Return ind
    End Function
    Function valget() As Integer
        Return ind
    End Function
    Public Sub col(ByVal c As String)
        GunaButton1.ForeColor = ColorTranslator.FromHtml(c)
        GunaButton1.OnHoverForeColor = ColorTranslator.FromHtml(c)
        If c = "#F7A931" Then
            GunaButton1.Image = My.Resources.m
        Else
            GunaButton1.Image = My.Resources.wm
        End If
    End Sub
End Class
