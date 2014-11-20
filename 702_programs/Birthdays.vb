'Chino Montano
'11/18/14   
'702 Birthdays Excercise 6

Public Class frmBirthdays
    Private Sub getBirthdays(ByRef strBirthdatesArr() As String)
        For intI As Integer = 0 To strBirthdatesArr.Length - 1
            strBirthdatesArr(intI) = InputBox("Please enter a name and a birthdate (ex: John mm/dd/yy)")
            If strBirthdatesArr(intI) = Nothing Then
                MessageBox.Show("Make sure you enter a birthday and a name, please try again")
                strBirthdatesArr(intI) = Nothing
                Exit For
            End If
        Next
    End Sub

    Private Sub addBirthday(ByVal strBirthdatesArr() As String)
        For intI As Integer = 0 To strBirthdatesArr.Length - 1
            If strBirthdatesArr(intI) = Nothing Then
                Exit For
            Else
                lstDisplay.Items.Add(strBirthdatesArr(intI))
            End If

        Next
    End Sub

    Private Sub btnGetBirthdates_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGetBirthdates.Click
        Dim strBirthdatesArr(3) As String
        getBirthdays(strBirthdatesArr)
        addBirthday(strBirthdatesArr)
    End Sub
End Class