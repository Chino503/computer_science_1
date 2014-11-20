'Chino Montano
'11/18/14   
'702 DrawCards Excercise 9

Public Class frmRandomNums

    Dim intRandNumArr(9), intLow, intHigh As Integer

    'randomizes numbers between 1 and 100 and stores it in an array
    Private Sub genRandNum(ByRef intRandNumArr() As Integer)
        Dim gen As New Random
        Dim randNum As Integer
        For intI As Integer = 0 To 9
            randNum = gen.Next(1, 101) 'Generates a number between 1 and 100
            intRandNumArr(intI) = randNum
        Next
    End Sub

    'display random numbers in array
    Private Sub showNums(ByVal intRandNumArr() As Integer)
        For Each intI As Integer In intRandNumArr
            lstNums.Items.Add(intI)
        Next
    End Sub

    'gets high or low nums from array
    Private Sub getNums(ByVal intRandNumArr() As Integer, ByRef intLow As Integer, ByRef intHigh As Integer)
        Array.Sort(intRandNumArr)
        intLow = intRandNumArr(0)
        Array.Reverse(intRandNumArr)
        intHigh = intRandNumArr(0)
    End Sub

    'Generator button
    Private Sub btnGenerator_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGenerator.Click
        lstNums.Items.Clear()
        genRandNum(intRandNumArr)
        showNums(intRandNumArr)
    End Sub

    'Show Low button
    Private Sub btnLow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLow.Click
        getNums(intRandNumArr, intLow, intHigh)
        If intLow = Nothing Then
            MessageBox.Show("Make sure you generate random numbers first")
        Else
            lblShowNum.Text = "Low number is " & intLow
        End If

    End Sub

    'Show High button
    Private Sub btnHigh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHigh.Click
        getNums(intRandNumArr, intLow, intHigh)
        If intLow = Nothing Then
            MessageBox.Show("Make sure you generate random numbers first")
        Else
            lblShowNum.Text = "High Number is " & intHigh
        End If

    End Sub

End Class