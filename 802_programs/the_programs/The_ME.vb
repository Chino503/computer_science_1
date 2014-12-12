'Chino Montano 
'12/09/14
'802 Me excercise

Public Class frmMe

    Private Sub drawMe(ByVal strDrawOrClear As String)
        Dim surface As Graphics = lblGraphics.CreateGraphics

        'pens
        Dim thePen As New Pen(Color.Black, 3)

        'brushes
        Dim salmonBrush As New SolidBrush(Color.DarkSalmon)
        Dim mouthBrush As New SolidBrush(Color.White)
        Dim blackBrush As New SolidBrush(Color.Black)

        Dim nosePoints() As Point = {New Point(120, 75), New Point(110, 100), New Point(130, 105)} 'the nose line points

        If strDrawOrClear = "draw" Then
            surface.FillEllipse(salmonBrush, 70, 20, 120, 140) 'The head
            surface.FillRectangle(blackBrush, 55, 0, 150, 10) 'hat
            surface.FillRectangle(blackBrush, 80, 0, 100, 50) 'hat

            'the eyes
            surface.FillEllipse(blackBrush, 100, 60, 15, 15)
            surface.FillEllipse(blackBrush, 130, 60, 15, 15)

            surface.DrawLines(thePen, nosePoints) 'the nose

            surface.FillPie(mouthBrush, 100, 90, 40, 50, 0, 180) 'The Mouth
        ElseIf strDrawOrClear = "clear" Then
            surface.Clear(Me.BackColor)
        End If
    End Sub

    Private Sub ShowMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
        drawMe("draw")
    End Sub

    Private Sub HideMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHide.Click
        drawMe("clear")
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()
    End Sub


End Class