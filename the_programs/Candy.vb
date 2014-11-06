Public Class frmCandy

    Function CalculateTheTotal(ByVal intOz As Integer, ByVal dblPrize As Double)
        Dim dblTotal As Double
        dblTotal = intOz * dblPrize
        Return dblTotal
    End Function

    Private Sub Calculate(ByRef strCandy As String, ByVal intOz As Integer, ByVal dblPrize As Double)
	Dim dblCost As Integer
	lblAnswer.Text = intOz & " ounces and they cost " & dblCost
    End Sub

End Class
