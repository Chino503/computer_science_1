Public Class frmMe

    Private Sub drawMe()
        Dim surface As Graphics = lblGraphics.CreateGraphics
        Dim thePen As New Pen(Color.Black, 3)
        Dim salmonBrush As New SolidBrush(Color.DarkSalmon)
        Dim mouthBrush As New SolidBrush(Color.White)
        Dim theEyesBrush As New SolidBrush(Color.Black)
        Dim nosePoints() As Point = {New Point(120, 75), New Point(110, 100), New Point(130, 105)} 'the nose line points

        surface.FillEllipse(salmonBrush, 70, 20, 120, 140) 'The head
        surface.FillPie(mouthBrush, 100, 90, 40, 50, 0, 180) 'The Mouth

        'the eyes
        surface.FillEllipse(theEyesBrush, 100, 60, 15, 15)
        surface.FillEllipse(theEyesBrush, 130, 60, 15, 15)

        'the nose
        surface.DrawLines(thePen, nosePoints)

    End Sub

    Private Sub ShowMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMeToolStripMenuItem.Click
        drawMe()
    End Sub

    Private Sub HideMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideMeToolStripMenuItem.Click

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub


End Class