'Chino Montano
'12/05/14   
'703 Test

Public Class frmTheProgram

    Private Sub mnuStrings(ByRef strFunction As String)
        Dim strTheString As String = txtTheString.Text
        If strTheString = Nothing Then
            MessageBox.Show("Please enter a string")
        Else
            Select Case strFunction
                Case "length"
                    lblTheAnswer.Text = "The length of the string is " & strTheString.Length
                Case "trim"
                    lblTheAnswer.Text = strTheString.Trim
                Case "uppercase"
                    strTheString.Trim()
                    lblTheAnswer.Text = strTheString.ToUpper
                Case "find"
                    Dim strWord As String
                    strWord = InputBox("Please enter what you would like to find", "Search...")
                    If strWord = Nothing Then
                        lblTheAnswer.Text = "I'm sorry but you didn't entered anything to search for..."
                    ElseIf strTheString.IndexOf(strWord) = -1 Then
                        lblTheAnswer.Text = "Not Found"
                    Else
                        lblTheAnswer.Text = "The string is located at position " & strTheString.IndexOf(strWord)
                    End If
            End Select
        End If
    End Sub

    Private Sub mnuMath()
        Dim dblTheDecimal, dblSqrt As Double
        Dim strToLabel As String
        Try
            dblTheDecimal = Convert.ToDouble(txtTheDecimal.Text)
            dblSqrt = Math.Sqrt(dblTheDecimal)
            strToLabel = "The square root of " & dblTheDecimal & " is " & Math.Round(dblSqrt, 4)
            If dblTheDecimal < 0 Then
                dblTheDecimal = Math.Abs(dblTheDecimal)
                lblTheAnswer.Text = strToLabel + "i"
            Else
                lblTheAnswer.Text = strToLabel
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a decimal")
        End Try
    End Sub

    Private Sub mnuLength_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLength.Click
        mnuStrings("length")
    End Sub

    Private Sub mnuTrim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrim.Click
        mnuStrings("trim")
    End Sub

    Private Sub mnuUpperCase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUpperCase.Click
        mnuStrings("uppercase")
    End Sub

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        mnuStrings("find")
    End Sub

    Private Sub mnuSquareRoot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSquareRoot.Click
        mnuMath()
    End Sub
End Class
