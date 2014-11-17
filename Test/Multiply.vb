'Chino Montano
'11/14/14
'Multiply excercise for the Test

Public Class frmMultiply

    'this sub gets three parameter the first two is to get the number it needs to multiply to and the last one,
    'the byref one, to return the answer of the multiplication
    Private Sub Multiply(ByVal intNum1 As Integer, ByVal intNum2 As Integer, ByRef intAnswer As Integer)

        intAnswer = intNum1 * intNum2

    End Sub

    Private Sub btnMultiply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intAnswer As Integer
        lblAnswer.Text = Nothing
        Try
            intNum1 = Convert.ToInt32(txtNum1.Text)
            intNum2 = Convert.ToInt32(txtNum2.Text)
            If intNum1 = Nothing Then
                MessageBox.Show("Please enter a number on the first box")
            ElseIf intNum2 = Nothing Then
                MessageBox.Show("Please enter a number on the second box")
            Else
                Multiply(intNum1, intNum2, intAnswer)
                lblAnswer.Text = intNum1 & " * " & intNum2 & " = " & intAnswer
            End If

        Catch ex As Exception
            MessageBox.Show("Make sure you have entered whole numbers and make sure you have entered it in both of the text boxes")
        End Try
    End Sub

    Private Sub txtNum1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNum1.GotFocus
        txtNum1.Text = Nothing
    End Sub

    Private Sub txtNum2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNum2.GotFocus
        txtNum2.Text = Nothing
    End Sub
End Class