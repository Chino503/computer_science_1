'Chino Montano 11/5/14 | 701 TimesTen Excercise

Public Class frmTimesTen
    Private Sub MultiplyByTen(ByVal intNum As Integer, ByRef intAnswer As Integer)
        intAnswer = intNum * 10
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim intNumberEntered As Integer
        Dim intAnswer As Integer
        Try
            intNumberEntered = Convert.ToInt16(txtInput.Text)
            MultiplyByTen(intNumberEntered, intAnswer)
            lblAnswer.Text = intNumberEntered & " x 10 = " & intAnswer
        Catch ex As Exception
            MessageBox.Show("Enter whole numbers")
        End Try
    End Sub

End Class