Public Class frmSortNumbers

    Private Sub sortNum(ByRef intNum1 As Integer, ByRef intNum2 As Integer)
        Dim intTemp As Integer
        If intNum1 > intNum2 Then
            intTemp = intNum1
            intNum1 = intNum2
            intNum2 = intTemp
            lblSort.Text = "The low number is " & intTemp & " and the high number is " & intNum2
        End If



    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        For intI As Integer = 1 To 2

            If intI = 1 Then

            End If

        Next

    End Sub
End Class