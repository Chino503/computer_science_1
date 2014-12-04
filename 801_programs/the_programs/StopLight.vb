'Chino Montano 
'12/04/14
'801 StopLight Excercise 2

Public Class frmStopLight

    Private Sub btnRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRed.Click
        picbxStopLigh.Image = My.Resources.stopLightRed
    End Sub

    Private Sub btnYellow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnYellow.Click
        picbxStopLigh.Image = My.Resources.stopLightYellow
    End Sub

    Private Sub btnGreen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGreen.Click
        picbxStopLigh.Image = My.Resources.stopLightGreen
    End Sub
End Class