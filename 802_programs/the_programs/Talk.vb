'Chino Montano
'12/08/14
'802 Kicks Exercise 2

Public Class frmTalk

    Private Sub tmrTalk_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrTalk.Tick
        Const intImgs As Integer = 3
        Static intImgNum As Integer = 0
        lblMessage.Text += "Study "
        Select Case intImgNum
            Case 0
                picFaces.Image = My.Resources.Face1
            Case 1
                picFaces.Image = My.Resources.Face2
            Case 2
                picFaces.Image = My.Resources.Face3
        End Select
        intImgNum = (intImgNum + 1) Mod intImgs
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        lblMessage.Text = Nothing
        tmrTalk.Interval = 100
        tmrTalk.Start()
    End Sub

    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop.Click
        tmrTalk.Stop()
    End Sub
End Class