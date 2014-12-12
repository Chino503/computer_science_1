'Chino Montano
'11/25/14
'Score excercise for the 702 test

Public Class frmScores

    Private Sub getScores(ByRef dblScoresArr() As Double)
        For intI As Integer = 0 To 2
            dblScoresArr(intI) = InputBox("Enter a score/grade", "Scores")
            If (dblScoresArr(intI) < 0) Then
                MessageBox.Show("You cannot have grades less than 0")
                dblScoresArr(0) = 0 And dblScoresArr(1) = 0 And dblScoresArr(2) = 0
                Exit For
            ElseIf dblScoresArr(intI) > 100 Then
                MessageBox.Show("You cannot have grades greater than 100")
                dblScoresArr(0) = 0 And dblScoresArr(1) = 0 And dblScoresArr(2) = 0
                Exit For
            End If
        Next
    End Sub

    Private Sub displayNums(ByVal dblScoresArr() As Double)
        Dim dblAverage As Double
        Dim dblTheNums As Double
        If dblScoresArr(0) = 0 And dblScoresArr(1) = 0 And dblScoresArr(2) = 0 Then
            MessageBox.Show("Please try again")
        Else
            For Each intNum As Double In dblScoresArr
                dblTheNums += intNum
                lstScores.Items.Add(intNum)
            Next
            dblAverage = dblTheNums / 3
            lblAnswer.Text = "The average score is " & dblAverage.ToString("##.00")
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dblScoresArr(2) As Double
        lstScores.Items.Clear()
        Try
            getScores(dblScoresArr)
            displayNums(dblScoresArr)
        Catch ex As Exception
            MessageBox.Show("Please enter numeric values")
        End Try
    End Sub
End Class
