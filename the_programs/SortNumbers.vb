Public Class frmSortNumbers

    Private Sub sortNum(ByRef intNum1 As Integer, ByRef intNum2 As Integer)
        Dim intTemp As Integer
        If intNum1 > intNum2 Then
            intTemp = intNum1
            intNum1 = intNum2
            intNum2 = intTemp

        End If
        lblSort.Text = "The low number is " & intTemp & " and the high number is " & intNum2
    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        Dim strNum1 As String
        Dim intNum1 As Integer
        Dim strNum2 As String
        Dim intNum2 As Integer
        For intI As Integer = 1 To 2

            If intI = 1 Then
                strNum1 = InputBox("Please enter your 1st number", "Number Sorting")
                strNum2 = InputBox("Please enter your 2nd number", "Number Sorting")
                If Int16.TryParse(strNum1, intNum1) = False Or Int16.TryParse(strNum2, intNum2) = False Then
                    MessageBox.Show("Please enter numberic values")
                    Exit Sub
                Else
                    intNum1 = Int16.TryParse(strNum1, intNum1)
                    intNum2 = Int16.TryParse(strNum2, intNum2)
                    sortNum(intNum1, intNum2)
                End If
            End If

        Next

    End Sub
End Class