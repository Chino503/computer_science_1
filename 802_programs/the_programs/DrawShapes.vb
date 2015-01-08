'Chino Montano
'12/12/14
'802 DrawShapes excercise 5

Public Class frmDrawShapes

    Private Sub btnDrawShapes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDrawShapes.Click
        Dim surface As Graphics = lblTheShapes.CreateGraphics

        Dim greenishPen As New Pen(Color.CadetBlue, 3)
        Dim pinkPen As New Pen(Color.Fuchsia, 10)
        Dim redPen As New Pen(Color.Red, 4)
        Dim bluePen As New Pen(Color.DodgerBlue, 8)

        bluePen.DashStyle = Drawing2D.DashStyle.DashDotDot

        surface.DrawLine(greenishPen, 30, 150, 470, 150)
        surface.DrawRectangle(bluePen, 80, 105, 180, 100)
        surface.DrawEllipse(pinkPen, 270, 230, 40, 40)
        surface.DrawArc(redPen, 30, 0, 470, 470, 0, 180)
    End Sub
End Class