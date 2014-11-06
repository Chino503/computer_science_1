'Chino Montano 11/03/14 | 6.03 costcalculator excercise.

Public Class frmCostCalculator

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim strCostPerItem As String
        strCostPerItem = txtItemPrice.Text
        Dim strQuantity As String
        strQuantity = txtQuantity.Text

        Dim dblCost As Double
        Dim intQuantity As Integer
        Dim dblTotal As Double

        If Double.TryParse(strCostPerItem, dblCost) And Int32.TryParse(strQuantity, intQuantity) Then
            dblTotal = dblCost * intQuantity
            lblAnswer.Text = dblTotal.ToString("$##.00")
        Else
            MessageBox.Show("Make sure you have put both the cost and the amount you want in order to do the calculation.")
        End If

    End Sub

    Private Sub mnuRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRed.Click
        BackColor = Color.Red
    End Sub

    Private Sub mnuGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGreen.Click
        BackColor = Color.Green
    End Sub

    Private Sub mnuBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBlue.Click
        BackColor = Color.Blue
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub
End Class