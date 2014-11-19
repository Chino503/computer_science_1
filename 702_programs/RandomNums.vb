'Chino Montano
'11/18/14   
'702 DrawCards Excercise 9


Public Class frmRandomNums

    Private Sub genRandNum(ByRef intRandNumArr() As Integer)
        Dim gen As New Random
        Dim randNum As Integer
        For intI As Integer = 0 To 9
            randNum = gen.Next(1, 101) 'Generates a number between 1 and 100
            intRandNumArr(intI) += randNum
        Next
    End Sub

    Private Sub showNums(ByVal intRandNumArr() As Integer)
        For Each intI As Integer In intRandNumArr
            lstNums.Items.Add(intI)
        Next
    End Sub

    Private Sub getNums(ByVal intRandNumArr() As Integer, ByRef intLow As Integer, ByRef intHigh As Integer)
        Array.Sort(intRandNumArr)
        intLow = intRandNumArr(0)
        Array.Reverse(intRandNumArr)
        intHigh = intRandNumArr(0)
    End Sub

    Private Sub btnGenerator_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGenerator.Click
        Dim intRandNumArr(9) As Integer
        lstNums.Items.Clear()
        genRandNum(intRandNumArr)
        showNums(intRandNumArr)
    End Sub

    Private Sub btnHigh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHigh.Click
        Dim intRandNumArr(9) As Integer
        Dim intLow, intHigh As Integer
        getNums(intRandNumArr, intLow, intHigh)
        lblShowNum.Text = "High number is: " & intHigh

    End Sub
End Class