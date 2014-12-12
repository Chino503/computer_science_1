'Chino Montano 11/17/14 | 702 FriendsArray Excercise 1

Public Class frmFriendsArray

    Private Sub btnGetFriends_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetFriends.Click
        Dim FriendArr(4) As String 'This stores 5 friend or 5 string values
        For intI As Integer = 0 To FriendArr.Length - 1
            FriendArr(intI) = InputBox("Enter a friend's name", "BFF")
        Next
        Array.Sort(FriendArr)
        For intI As Integer = 0 To FriendArr.Length - 1
            lblBffs.Text += FriendArr(intI) & vbCrLf
        Next
    End Sub
End Class
