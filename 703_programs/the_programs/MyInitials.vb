'Chino Montano
'12/02/14   
'703 MyInitials Excercise

Public Class frmMyInitials

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub btnShowInitials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowInitials.Click
        Dim strTheString As String = txtNameInput.Text
        Dim charFirst, charSecond As String
        Dim intIndex As Integer


        If txtNameInput.Text = Nothing Then
            MessageBox.Show("Please enter your first and last name")
        Else
            intIndex = strTheString.IndexOf(" ")
            intIndex += 1
            If strTheString.Chars(intIndex) = Nothing Then
                MessageBox.Show("Please enter your last name")
            Else
                charFirst = strTheString.Chars(0)
                charSecond = strTheString.Chars(intIndex)
                lblAnswer.Text = charFirst.ToUpper & " " & charSecond.ToUpper
            End If
        End If

    End Sub
End Class