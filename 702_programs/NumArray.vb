'Chino Montano 
'11/17/14
'702 NumArray Excercise 4

Public Class frmNumArray
    Private Sub addToArray(ByRef intNumArr() As Integer)
        For intI As Integer = 0 To intNumArr.Length - 1
            Try
                intNumArr(intI) = InputBox("Enter a number", "Arrays")
            Catch ex As Exception
                lblAnswer.Text = Nothing
                MessageBox.Show("Please enter numeric whole numbers and try again")
                Exit For
            End Try
        Next
    End Sub

    Function getAverage(ByVal intNumArr() As Integer) As Double
        Dim dblSum, dblAvg As Double
        For Each intNum As Integer In intNumArr
            dblSum += intNum
        Next
        dblAvg = dblSum / intNumArr.Length
        Return dblAvg
    End Function

    Private Sub btnAverage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        Dim intNumArr(2) As Integer
        Dim dblAverage As Double
        addToArray(intNumArr)
        dblAverage = getAverage(intNumArr)
        lblAnswer.Text = "The average of the numbers is " & dblAverage.ToString("##.0")
    End Sub
End Class