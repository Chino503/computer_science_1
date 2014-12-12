'Chino Montano 
'12/04/14
'801 Shapes Excercise 1

Public Class frmShapes

    Private Sub mnuCircle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCircle.Click
        BackgroundImage = My.Resources.blueCircle1
    End Sub

    Private Sub mnuStar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStar.Click
        BackgroundImage = My.Resources.purpleStar
    End Sub

    Private Sub mnuSquare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSquare.Click
        BackgroundImage = My.Resources.redSq
    End Sub

    Private Sub mnuTriangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTriangle.Click
        BackgroundImage = My.Resources.greenTriangle
    End Sub

    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()
    End Sub
End Class
