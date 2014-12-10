Public Class frmShip

    Private Sub DoSomething(ByVal strDrawOrClear As String)
        Dim surface As Graphics = lblShip.CreateGraphics

        Dim blackPen As New Pen(Color.Red)

        Dim redBrush As New SolidBrush(Color.Red)
        Dim blueBrush As New SolidBrush(Color.Blue)

        Dim theShip() As Point = {New Point(200, 230), New Point(240, 300), New Point(360, 300), New Point(400, 230)}
        Dim theLeft() As Point = {New Point(300, 230), New Point(230, 160), New Point(260, 160), New Point(300, 80)}
        Dim theWaves() As Point = {New Point(-100, 400), New Point(-50, 270), New Point(0, 290), New Point(50, 270), New Point(100, 290), New Point(150, 270), New Point(200, 290), New Point(250, 270), New Point(300, 290), New Point(350, 270), New Point(400, 290), New Point(450, 270), New Point(500, 290), New Point(550, 270), New Point(600, 290), New Point(650, 270), New Point(700, 400)}

        If strDrawOrClear = "draw" Then
            surface.FillPolygon(redBrush, theShip)
            surface.DrawLine(blackPen, 300, 230, 300, 80)
            surface.FillClosedCurve(blueBrush, theLeft)
            surface.FillClosedCurve(blueBrush, theWaves)
        End If

    End Sub

    Private Sub mnuShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuShow.Click
        DoSomething("draw")
    End Sub
End Class