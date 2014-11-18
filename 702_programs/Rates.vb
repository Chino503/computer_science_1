'Chino Montano
'11/18/14   
'702 Rates Excercise 5

Public Class frmRates
    Private Sub btnRate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRate.Click
        Dim dblRateArr() As Double = {2.3, 2.2, 2.0, 2.1, 2.4}
        Array.Sort(dblRateArr)
        Dim dblLowestRate As Double
        dblLowestRate = dblRateArr(0)
        lblAnswer.Text = "The lowest rate is " & dblLowestRate.ToString("##.00") & "%"
    End Sub
End Class