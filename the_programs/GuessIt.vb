Public Class frmGuessIt

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim intGuess As Integer
        Dim gen As New Random()
        Static intRandomNum As Integer = gen.Next(1, 51) 'number between 1 - 50
        Static intTries As Integer
        intTries += 1

        Try
            intGuess = Convert.ToInt32(txtGuess.Text)

            If intGuess < intRandomNum Then
                lblAnswer.Text = "Too low"
            ElseIf intGuess > intRandomNum Then
                lblAnswer.Text = "Too High"
            Else
                lblAnswer.Text = "Congrats!!")
                MessageBox.Show("Congrats!! You guessed it," & vbCrLf & " it took you " & intTries & " tries to guess it.")
            End If

            If intGuess > 50 Then
                MessageBox.Show("Please try guessing numbers between 1 and 50")
            ElseIf intGuess < 1 Then
                MessageBox.Show("Please try guessing numbers between 1 and 50")
            End If

        Catch ex As Exception
            MessageBox.Show("Please enter integer values for your guess")
        End Try

    End Sub
End Class