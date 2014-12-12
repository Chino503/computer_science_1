'Chino Montano
'11/18/14   
'702 DrawCards Excercise 8

Public Class frmDrawCards

    Private Sub drawCards(ByRef intCardCount() As Integer, ByVal intTimes As Integer)
        Dim gen As New Random
        Dim intCardDraws As Integer
        For intI As Integer = 0 To intTimes - 1
            intCardDraws = gen.Next(2, 11) 'random number between 2 and 10
            intCardCount(intCardDraws - 2) += 1
        Next
    End Sub

    Private Sub showCards(ByVal intCardCount() As Integer)
        For intI As Integer = 0 To intCardCount.Length - 1
            Dim intCardNum As Integer
            intCardNum += 1
            lblAnswer.Text += "Card #" & intCardNum + 1 & " was drawn " & intCardCount(intI) & " times" & vbCrLf
        Next
    End Sub

    Private Sub btnDraw_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDraw.Click
        Dim intCardCount(8) As Integer
        Dim intTimes As Integer
        lblAnswer.Text = Nothing
        Try
            intTimes = Convert.ToInt32(txtDraws.Text)
            If intTimes < 0 Then
                MessageBox.Show("You cannot draw negative times, please try again")
            ElseIf intTimes = 0 Then
                MessageBox.Show("You cannot draw 0 times, please try again")
            Else
                drawCards(intCardCount, intTimes)
                showCards(intCardCount)
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter numberic whole numbers")
        End Try

    End Sub
End Class