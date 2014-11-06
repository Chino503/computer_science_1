'Chino Montano 11/03/14 | 6.03 CandyJar excercise

Public Class frmCandyJar

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim strInput As String
        Dim intInput As Integer
        strInput = txtInput.Text
        If Int32.TryParse(strInput, intInput) Then
            If intInput >= 0 And intInput <= 300 Then
                lblAnswer.Text = "You guesses it"
            Else
                lblAnswer.Text = "That's wrong"
            End If
        Else
            MessageBox.Show("Please enter a numeric whole number")
        End If
    End Sub
End Class
