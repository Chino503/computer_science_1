'Chino Montano 11/12/14 | 701 sortNumber Excercise

Public Class frmSortNumbers

    Private Sub sortNum(ByRef intNum1 As Integer, ByRef intNum2 As Integer)
        Dim intTemp As Integer
        If intNum1 > intNum2 Then
            intTemp = intNum1
            intNum1 = intNum2
            intNum2 = intTemp
        End If

    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        Dim strNum1 As String
        Dim intNum1 As Integer
        Dim strNum2 As String
        Dim intNum2 As Integer



        strNum1 = InputBox("Please enter your 1st number", "Number Sorting")
        strNum2 = InputBox("Please enter your 2nd number", "Number Sorting")
        If Int16.TryParse(strNum1, intNum1) = False Or Int16.TryParse(strNum2, intNum2) = False Then
            lblSort.Text = Nothing
            MessageBox.Show("Please enter numberic values")
            Exit Sub
        Else
            ' intNum1 = Int16.TryParse(strNum1, intNum1)
            ' intNum2 = Int16.TryParse(strNum2, intNum2)
            sortNum(intNum1, intNum2)
            lblSort.Text = "The low number is " & intNum1 & " and the high number is " & intNum2
        End If

    End Sub
End Class