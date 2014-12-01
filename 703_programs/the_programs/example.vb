Public Class frmExample

    Private Sub btnAbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbs.Click
        Dim dblNum As Double
        Dim input As String
        Try
            input = txtNumInput.Text
            dblNum = Convert.ToDouble(input)
            lblAnswer.Text = "The absolute value is " & Math.Abs(dblNum)
        Catch ex As Exception
            MessageBox.Show("Please enter numeric values")
        End Try
    End Sub

    Private Sub btnSqr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSqr.Click
        Dim dblNum As Double
        Dim input As String
        Try
            input = txtNumInput.Text
            dblNum = Convert.ToDouble(input)
            lblAnswer.Text = "The square root is " & Math.Sqrt(dblNum)
        Catch ex As Exception
            MessageBox.Show("Please enter numeric values")
        End Try
    End Sub

    Private Sub btnSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSign.Click
        Dim dblNum As Double
        Dim input As String

        Try
            input = txtNumInput.Text
            dblNum = Convert.ToDouble(input)
            If (Math.Sign(dblNum) > 0) Then
                lblAnswer.Text = dblNum & " is a positive number"
            ElseIf (Math.Sign(dblNum) < 0) Then
                lblAnswer.Text = dblNum & " is a negative number."
            Else
                lblAnswer.Text = dblNum & " is a zero."
            End If
        Catch Ex As Exception
            MessageBox.Show("Enter numeric values")
        End Try

    End Sub

    Private Sub btnRnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRnd.Click
        Dim dblNum As Double
        Dim input As String
        Dim intPlaces As Integer

        Try
            input = txtNumInput.Text
            dblNum = Convert.ToDouble(input)
            intPlaces = InputBox("Enter the number of places", "Places to round")
            lblAnswer.Text = "The absolute value is " & Math.Round(dblNum, intPlaces)
        Catch ex As Exception
            MessageBox.Show("enter numeric values")
        End Try
    End Sub
End Class
