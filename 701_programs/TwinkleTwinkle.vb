'Chino Montano 11/5/14 | 701 TwinkleTwinkle Excercise

Public Class TwinkleTwinkle

    Private Sub displayPoem()
        lblShowSong.Text = "Twinkle Twinkle Little Star" & vbCrLf & "How I Wonder What You Are" & vbCrLf & "Up Above The World So Bright" & vbCrLf & "Like a Diamond In The Night"
    End Sub

    Private Sub btnShowPoem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowPoem.Click
        displayPoem()
    End Sub
End Class