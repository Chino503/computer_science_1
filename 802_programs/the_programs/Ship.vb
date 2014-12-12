'Chino Montano
'12/12/14
'802 Ship Excercise 4

Public Class frmShip

    Private Sub DoSomething(ByVal strDrawOrClear As String)
        Dim surface As Graphics = lblShip.CreateGraphics

        Dim brownPen As New Pen(Color.Brown, 5)

        Dim redBrush As New SolidBrush(Color.Red)
        Dim blueBrush As New SolidBrush(Color.Blue)
        Dim whiteBrush As New SolidBrush(Color.White)

        Dim theShip() As Point = {New Point(200, 230), New Point(240, 300), New Point(360, 300), New Point(400, 230)}
        Dim theLeft() As Point = {New Point(297, 227), New Point(203, 227), New Point(297, 80), New Point(288, 170)}
        Dim theRight() As Point = {New Point(303, 227), New Point(403, 227), New Point(303, 80), New Point(312, 170)}
        Dim theWaves() As Point = {New Point(-100, 400), New Point(-50, 270), New Point(0, 290), New Point(50, 270), New Point(100, 290), New Point(150, 270), New Point(200, 290), New Point(250, 270), New Point(300, 290), New Point(350, 270), New Point(400, 290), New Point(450, 270), New Point(500, 290), New Point(550, 270), New Point(600, 290), New Point(650, 270), New Point(700, 400)}

        If strDrawOrClear = "draw" Then
            surface.FillPolygon(redBrush, theShip)
            surface.DrawLine(brownPen, 300, 230, 300, 80)
            surface.FillPolygon(whiteBrush, theLeft)
            surface.FillPolygon(whiteBrush, theRight)
            surface.FillClosedCurve(blueBrush, theWaves)
        ElseIf strDrawOrClear = "clear" Then
            surface.Clear(Me.BackColor)
        End If

    End Sub

    Private Sub mnuShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuShow.Click
        DoSomething("draw")
    End Sub

    Private Sub mnuHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHide.Click
        DoSomething("clear")
    End Sub

    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()
    End Sub
End Class