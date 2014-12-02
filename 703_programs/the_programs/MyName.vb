'Chino Montano
'12/02/14
'703 MyName Excercise 2

Public Class frmMyName

    Private Sub btnName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName.Click
        Dim strFName, strLName, strFullName As String
        Dim strNewFName, strNewLName As String
        Do
            strFName = InputBox("Please enter your first name", "First Name")
            strLName = InputBox("Please enter your last name", "Last Name")

            If strFName.Equals(strLName) Then
                MessageBox.Show("You cannot have the same first name and last name, please try again")
                strFName = Nothing
                strLName = Nothing
                Exit Do
            End If

        Loop While strFName = Nothing Or strLName = Nothing

        strNewFName = strFName.Trim() + " "
        strNewLName = strLName.Trim()
        strFullName = String.Concat(strNewFName, strNewLName)
        lblAnswer.Text = "Hello " & strFullName
    End Sub
End Class