'Chino Montano
'11/18/14   
'702 gpaArray Excercise 7

Public Class frmGPAArray

    Private Sub addGPA(ByRef dblGPAArr() As Double)
        For intI As Double = 0 To dblGPAArr.Length - 1
            Try
                dblGPAArr(intI) = Convert.ToDouble(InputBox("Please enter GPA #" & intI + 1))
                If dblGPAArr(intI) < 0 Then
                    MessageBox.Show("You cannot have a negative GPA, please try again")
                    dblGPAArr(intI) = Nothing
                    Exit For
                ElseIf dblGPAArr(intI) > 6.0 Then
                    MessageBox.Show("You cannot have a GPA greater than 6.0, try again")
                    dblGPAArr(intI) = Nothing
                    Exit For
                End If
            Catch ex As Exception
                Exit For
                MessageBox.Show("Please enter numeric values")
            End Try
        Next
    End Sub

    Private Sub displayGPA(ByVal dblGPAArr() As Double)
        Array.Sort(dblGPAArr)
        For Each intI As Double In dblGPAArr
            Dim intCounter As Integer
            intCounter += 1
            lstGPAs.Items.Add("GPA #" & intCounter & " is " & intI.ToString("##.00"))
        Next
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dblGPAArr(4) As Double
        lstGPAs.Items.Clear()
        addGPA(dblGPAArr)
        displayGPA(dblGPAArr)
    End Sub
End Class