'Chino Montano
'11/17/14
'702 TestData excercise 3

Public Class frmTestData
    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim strTestNameArr() As String = {"Test 1", "Test 2", "Test 3"}
        Dim intTestGradeArr() As Integer = {87, 91, 83}
        For intI As Integer = 0 To 2
            lblAnswer.Text += strTestNameArr(intI) & " has a grade of " & intTestGradeArr(intI) & vbCrLf
        Next
    End Sub
End Class