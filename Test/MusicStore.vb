'Chino Montano
'11/14/14
'MusicStore excercise for the Test
Public Class frmMusicStore
    'This functions takes three parameters:
    'each parameter gets the number of cds the user wants
    Function TotCost(ByVal intNew As Integer, ByVal intUsed As Integer, ByVal intOne As Integer) As Double
        Const dblNewCD As Double = 14.99 'cost of a new cd
        Const dblUsedCD As Double = 8.99 'cost of a used cd
        Const dblOneSongCD As Double = 2.99 'cost of one song cd

        Dim dblNewTot As Double = dblNewCD * intNew 'the cost of new cd times how many cds the user wants
        Dim dblUsedTot As Double = dblUsedCD * intUsed 'the cost of used cd times how many cds the user wants
        Dim dblOneTot As Double = dblOneSongCD * intOne 'the cost of one song cd times how many cds the user wants

        Dim dblTotal 'stores the total

        dblTotal = dblNewTot + dblUsedTot + dblOneTot 'adds everything up to give the total

        Return dblTotal
    End Function

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim intNew As Integer
        Dim intUsed As Integer
        Dim intOne As Integer
        Dim dblTotal As Double

        lblAnswer.Text = Nothing

        Try
            intNew = Convert.ToInt32(txtNewCD.Text)
            intUsed = Convert.ToInt32(txtUsedCD.Text)
            intOne = Convert.ToInt32(txtSong1CD.Text)

            If intNew < 0 Or intUsed < 0 Or intOne < 0 Then
                MessageBox.Show("You cannot buy negative number of CDs")
            ElseIf intNew = 0 And intUsed = 0 And intOne = 0 Then
                MessageBox.Show("Come on now! Buy atleast one")
            Else
                dblTotal = TotCost(intNew, intUsed, intOne)
                lblAnswer.Text = "You would like to purchase: " & vbCrLf & intNew & " new cd/s" & vbCrLf & intUsed & " used cd/s" & vbCrLf & intOne & " single song cd/s" & vbCrLf & "Total cost before tax: " & dblTotal.ToString("$##.00")
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter integer numbers only and make sure you have atleast put 0 if you don't want to purchase a CD")
        End Try

    End Sub

    Private Sub txtNewCD_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewCD.GotFocus
        txtNewCD.Text = Nothing
    End Sub

    Private Sub txtUsedCD_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsedCD.GotFocus
        txtUsedCD.Text = Nothing
    End Sub

    Private Sub txtSong1CD_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSong1CD.GotFocus
        txtSong1CD.Text = Nothing
    End Sub
End Class
