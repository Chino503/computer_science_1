'Chino Montano
'12/08/14
'802 Kicks Exercise 1

Public Class frmKicks
    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick
        Const intImgs As Integer = 3
        Static intImgNum As Integer = 0
        Select Case intImgNum
            Case 0
                picIMG.Image = My.Resources.stand
            Case 1
                picIMG.Image = My.Resources.leftFootUp
            Case 2
                picIMG.Image = My.Resources.rtFootUp
        End Select
        intImgNum = (intImgNum + 1) Mod intImgs
    End Sub
End Class
