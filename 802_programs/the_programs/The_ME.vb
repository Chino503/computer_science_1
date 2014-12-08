Public Class frmMe

    Private Sub drawMe()
        Dim surface As Graphics = lblGraphics.CreateGraphics
        Dim thePen As New Pen(Color.Black, 3)
        surface.DrawLine(thePen, 0, 0, 150, 50)
    End Sub

    Private Sub ShowMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMeToolStripMenuItem.Click
        drawMe()
    End Sub
End Class