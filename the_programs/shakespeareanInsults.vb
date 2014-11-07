'Chino Montano 11/7/14 | 701 ShakespeareanInsults Excercise

Public Class fmrShakespeareanInsults

    Private Sub showInsult(ByVal intInsult As Integer)

        Select Case intInsult
            Case 1
                lblInsult.Text = "I think he be transformed into a beast; for I can nowhere find him like a man"
            Case 2
                lblInsult.Text = "Lets meet as little as we can"
            Case 3
                lblInsult.Text = "I desire that we be better strangers"
            Case 4
                lblInsult.Text = "Boys, apes, braggarts, jacks, milksops!"
            Case 5
                lblInsult.Text = "This is the silliest stuff that I ever heard"
        End Select

    End Sub

    Private Sub btnShowInsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowInsult.Click
        Dim intTheInsultNum As Integer
        Dim gen As New Random()
        intTheInsultNum = gen.Next(1, 6) 'generate a number from 1 to 5
        showInsult(intTheInsultNum)
    End Sub
End Class