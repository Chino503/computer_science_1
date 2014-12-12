'Chino Montano
'12/02/14
'703 WhichFirst Excersise 4

Public Class frmWhichFirst

    Private Sub btnWhich_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhich.Click
        Dim strInput1, strInput2 As String
        strInput1 = txtInput1.Text
        strInput2 = txtInput2.Text
        If strInput1 = Nothing Or strInput2 = Nothing Then
            MessageBox.Show("Please enter a word")
        Else
            If String.Compare(strInput1, strInput2) = 0 Then
                lblAnswer.Text = strInput1 & " is equals to " & strInput2
            ElseIf String.Compare(strInput1, strInput2) < 0 Then
                lblAnswer.Text = strInput1 & " comes before " & strInput2
            ElseIf String.Compare(strInput1, strInput2) > 0 Then
                lblAnswer.Text = strInput2 & " comes before " & strInput1
            End If
        End If
    End Sub
End Class