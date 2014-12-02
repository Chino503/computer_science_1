'Chino Montano
'12/1/14
'703 MathFun excercise 1

Public Class frmMathFun

    Dim dblNum As Double

    Private Sub mnuAbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbs.Click
        Try
            dblNum = Convert.ToDouble(txtInput.Text)
            lblAnswer.Text = "The absolute value is " & Math.Abs(dblNum)
        Catch ex As Exception
            MessageBox.Show("Please enter numeric numbers")
        End Try

    End Sub

    Private Sub mnuSqt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSqt.Click
        Try
            dblNum = Convert.ToDouble(txtInput.Text)
            If dblNum < 1 Then
                MessageBox.Show("Please ente a positive number")
            Else
                lblAnswer.Text = "The square root is " & Math.Sqrt(dblNum)
            End If

        Catch ex As Exception
            MessageBox.Show("Please enter numeric values")
        End Try

    End Sub

    Private Sub mnuSign_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSign.Click
        Try
            dblNum = Convert.ToDouble(txtInput.Text)
            If Math.Sign(dblNum) > 0 Then
                lblAnswer.Text = dblNum & " is a positive number"
            ElseIf Math.Sign(dblNum) < 0 Then
                lblAnswer.Text = dblNum & " is a negative number"
            Else
                lblAnswer.Text = dblNum & " is a zero"
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter numeric values")
        End Try
    End Sub

    Private Sub mnuRound_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRound.Click
        Dim intPlaces As Integer
        Try
            dblNum = Convert.ToDouble(txtInput.Text)
            intPlaces = InputBox("Enter the number of places you would like to round", "Places to round")
            lblAnswer.Text = dblNum & " rounded to " & intPlaces & " is " & Math.Round(dblNum, intPlaces)
        Catch ex As Exception
            MessageBox.Show("Please enter numeric values")
        End Try
    End Sub
End Class