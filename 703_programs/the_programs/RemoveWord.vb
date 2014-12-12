'Chino Montano
'12/1/14
'703 MathFun excercise 6

Public Class frmRemoveWord

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        lblAnswer.Text = Nothing 'resets the label
        Dim strTheString, strTheWord, strNewString As String
        Dim intIndex, intStart, intFinish As Integer

        strTheString = txtString.Text
        strTheWord = txtWord.Text

        If strTheString = Nothing Then
            MessageBox.Show("Please enter a string")
        ElseIf strTheWord = Nothing Then
            MessageBox.Show("Please enter a word to remove")
        Else
            If strTheString.Contains(strTheWord) = False Then
                MessageBox.Show("The string does not contain that word, please enter a different word to remove")
            Else
                intIndex = strTheString.IndexOf(strTheWord)
                intStart = intIndex
                intFinish = strTheWord.Length
                strNewString = strTheString.Remove(intStart, intFinish)
                lblAnswer.Text = strNewString
            End If
        End If

    End Sub
End Class