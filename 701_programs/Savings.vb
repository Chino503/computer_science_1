'Chino Montano 11/12/14 | 701 Savings excercise

Public Class frmSavings
    Function calcDeposit(ByVal dblSavings As Double, ByVal intMonths As Integer) As Integer
        Dim dblTotal As Double
        dblTotal = dblSavings * intMonths
        Return dblTotal
    End Function

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim dblSavings As Double
        Dim intMonths As Integer

        Dim dblTotal As Double

        Try
            dblSavings = Convert.ToDouble(txtAmount.Text)
            intMonths = Convert.ToInt32(txtMonths.Text)

            If dblSavings < 1 And intMonths < 1 Then
                lblAnswer.Text = Nothing
                MessageBox.Show("Make sure you have something for your savings and atleast 1 month that you have save deposited")
            ElseIf dblSavings < 1 Then
                MessageBox.Show("You need to have least some savings to calculate your savings")
            ElseIf intMonths < 1 Then
                MessageBox.Show("You need to have a least 1 month that you have deposited money")
            Else
                dblTotal = calcDeposit(dblSavings, intMonths)

                lblAnswer.Text = "You deposited a total amount of " & dblTotal.ToString("$##.00")
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter numeric values")
        End Try
    End Sub
End Class