'Chino Montano
'12/02/14
'703 WhichFirst Excersise 5

Public Class frmNewWord

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        lblAnswer.Text = Nothing 'resets the label
        Dim strWord, strNewWord As String
        Dim strReplace, strReplacement As Char

        strWord = txtWord.Text
        strReplace = txtToReplace.Text
        strReplacement = txtReplacementLetter.Text

        If strWord = Nothing Then
            MessageBox.Show("Please enter a word")
        ElseIf strReplace = Nothing Or strReplacement = Nothing Then
            MessageBox.Show("Please enter a letter")
        Else

            If strWord.Contains(strReplace) = False Then
                MessageBox.Show("That letter is not the word " & strWord)
            Else
                strNewWord = strWord.Replace(strReplace, strReplacement)
                lblAnswer.Text = strNewWord
            End If

        End If

    End Sub
End Class