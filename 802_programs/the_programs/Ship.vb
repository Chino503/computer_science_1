Public Class frmShip

    Private Sub DoSomething(ByVal strDrawOrClear As String)
        Dim surface As Graphics = lblShip.CreateGraphics

        Dim blackPen As New Pen(Color.Red)

        Dim redBrush As New SolidBrush(Color.Red)

        Dim theShip() As Point = {New Point(100, 120), New Point(130, 250), New Point(260, 250), New Point(600, 200)}

        If strDrawOrClear = "draw" Then
            surface.FillPolygon(redBrush, theShip)
        End If

    End Sub

    Private Sub mnuShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuShow.Click
        DoSomething("draw")
    End Sub
End Class