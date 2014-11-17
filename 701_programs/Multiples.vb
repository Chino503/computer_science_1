'Chino Montano 11/5/14 | 701 Multiples Excercise

Public Class frmMultiples

    Private Sub showMultiples(ByVal intNum As Integer)
        For intTime As Integer = 1 To 10
            lblMultiples.Text += intNum & " x " & intTime & " = " & intNum * intTime & vbCrLf
        Next
    End Sub

    Private Sub btnShowMultiples_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowMultiples.Click
        Dim intNumEntered As Integer
        lblMultiples.Text = Nothing
        Try
            intNumEntered = Convert.ToUInt16(txtNumber.Text)
            showMultiples(intNumEntered)
        Catch ex As Exception
            MessageBox.Show("Enter a numeric value")
        End Try
    End Sub
End Class