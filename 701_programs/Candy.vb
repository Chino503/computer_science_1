'Chino Montano 11/7/14 | 701 Candy Excercise

Public Class frmCandy

    Function CalculateTheTotal(ByVal intOz As Integer, ByVal dblPrize As Double) As Double
        Dim dblTotal As Double
        dblTotal = intOz * dblPrize
        Return dblTotal
    End Function

    Private Sub Calculate(ByVal strCandy As String, ByVal intOz As Integer, ByVal dblPrize As Double)
        Dim dblCost As Double
        dblCost = CalculateTheTotal(intOz, dblPrize)
        lblAnswer.Text = intOz & " ounces of " & strCandy & " at a cost of " & dblPrize.ToString("$##.00") & " per ounce. Costs " & dblCost.ToString("$##.00")
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim strCandy As String = txtCandy.Text
        Dim intOz As Integer
        Dim dblPrize As Double

        If strCandy = Nothing Then
            MessageBox.Show("Please enter the type of candy you would like...")
        ElseIf txtOz.Text = Nothing Then
            MessageBox.Show("Please enter how many oz you would like to buy...")
        ElseIf txtPrize.Text = Nothing Then
            MessageBox.Show("Please enter the prize per oz...")
        Else
            Try
                intOz = Convert.ToInt16(txtOz.Text)
                dblPrize = txtPrize.Text

                Calculate(strCandy, intOz, dblPrize)

            Catch ex As Exception
                MessageBox.Show("Please enter numeric values!")
            End Try
        End If

    End Sub
End Class
