'Chino Montano 11/5/14 | 701 Reasons Excercise

Public Class frmReasons
    Private Sub showReasons()
        lblAnswer.Text = "CS teaches critical thinking " & vbCrLf & "CS touches everyone, everyday" & vbCrLf & "Computing Jobs are in high demand"
    End Sub

    Private Sub btnComputerScience_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComputerScience.Click
        showReasons()
    End Sub
End Class