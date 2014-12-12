'Chino Montano
'11/17/14
'702 favoriteFood Excercise 2

Public Class favoriteFood
    Dim strFoodArr(4) As String
    Private Sub enterFoods(ByRef strFoodArr() As String)
        'adding string values to the array
        For intI As Integer = 0 To strFoodArr.Length - 1
            strFoodArr(intI) = InputBox("Enter one of your favorite foods", "Favorite Food")
            If strFoodArr(intI) = Nothing Then
                MessageBox.Show("Please try again and make sure you enter a favorite food for every input box")
                strFoodArr(intI) = Nothing
                Exit For
            End If
        Next
    End Sub

    Private Sub showFoods(ByVal strFoodArr() As String)
        Array.Sort(strFoodArr)
        lstFavFood.Items.Clear()
        For intI As Integer = 0 To strFoodArr.Length - 1
            If strFoodArr(0) = Nothing Then
                MessageBox.Show("Make sure you have entered your favorite food before trying to display it.")
                Exit For
            Else
                lstFavFood.Items.Add(strFoodArr(intI))
            End If
        Next
    End Sub

    Private Sub btnGet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGet.Click
        enterFoods(strFoodArr)
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        showFoods(strFoodArr)
    End Sub
End Class
