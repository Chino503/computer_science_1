'Chino Montano 11/5/14 | 701 Signature Excercise

Public Class frmSignature

    Function Signature(ByVal strName As String) As String
        Dim strToReturn As String
        strToReturn = "Created By " & strName
        Return strToReturn
    End Function

    Private Sub btnDisplay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim strFName As String
        strFName = txtInput.Text
        lblAnswer.Text = Nothing
        If strFName = Nothing Then
            MessageBox.Show("Please enter your name")
        Else
            lblAnswer.Text = Signature(strFName)
        End If

    End Sub
End Class