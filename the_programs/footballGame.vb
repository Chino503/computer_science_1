'Chino Montano 11/12/14 | 701 footballGame excercise

Public Class fmrFootballGame
    Function calcTotal(ByVal intQ1 As Integer, ByVal intQ2 As Integer, ByVal intQ3 As Integer, ByVal intQ4 As Integer) As Integer
        Dim intTotal As Integer
        intTotal = intQ1 + intQ2 + intQ3 + intQ4
        Return intTotal
    End Function

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim intQ1 As Integer
        Dim intQ2 As Integer
        Dim intQ3 As Integer
        Dim intQ4 As Integer

        Dim intTotal As Integer

        Try

            intQ1 = Convert.ToInt16(txtQ1.Text)
            intQ2 = Convert.ToInt16(txtQ2.Text)
            intQ3 = Convert.ToInt16(txtQ3.Text)
            intQ4 = Convert.ToInt16(txtQ4.Text)

            If intQ1 < 0 Or intQ2 < 0 Or intQ3 < 0 Or intQ4 < 0 Then
                lblAnswer.Text = Nothing
                MessageBox.Show("You cannot get negative points")
            Else
                intTotal = calcTotal(intQ1, intQ2, intQ3, intQ4)
                lblAnswer.Text = "The total point is " & intTotal
            End If
        Catch ex As Exception
            lblAnswer.Text = Nothing
            MessageBox.Show("Please make sure you have entered numberic values for all 4 quarters")
        End Try

    End Sub
End Class