Public Class frmTrigCalculator

    Function useSine(ByVal dblOpposite As Double, ByVal dblHypotenuse As Double) As Double
        Return Math.Sin(dblOpposite / dblHypotenuse)
    End Function

    Private Sub getSides(ByRef dblOpposite As Double, ByRef dblAdjacent As Double, ByRef dblHypotenuse As Double)
        If dblOpposite = 0 Then
            txtSideA.Text = Math.Sqrt(Math.Pow(dblHypotenuse, 2) - Math.Pow(dblAdjacent, 2))
        ElseIf dblAdjacent = 0 Then
            txtSideB.Text = Math.Sqrt(Math.Pow(dblHypotenuse, 2) - Math.Pow(dblAdjacent, 2))
        ElseIf dblHypotenuse = 0 Then
            txtSideC.Text = Math.Sqrt(Math.Pow(dblOpposite, 2) + Math.Pow(dblAdjacent, 2))
        End If
    End Sub

    Private Sub getAngles(ByRef dblAngleA As Double, ByRef dblAngleB As Double)
        If dblAngleA < 0 Then

        ElseIf dblAngleB < 0 Then

        End If
    End Sub


    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Try
            Dim dblOpposite As Double = CDbl(txtSideA.Text)
            Dim dblAdjacent As Double = CDbl(txtSideB.Text)
            Dim dblHypotenuse As Double = CDbl(txtSideC.Text)
            Dim dblAngleA As Double = CDbl(txtAngleA.Text)
            Dim dblAngleB As Double = CDbl(txtAngleB.Text)

            Dim sidesArr As Array = {dblOpposite, dblAdjacent, dblHypotenuse}
            Dim anglesArr As Array = {dblAngleA, dblAngleB}

            Dim intSides As Integer = 0
            Dim intAngles As Integer = 0
            Dim isValid As Boolean = False

            For Each dblNum In sidesArr
                If dblNum > 0 Then
                    intSides += 1
                End If
            Next

            For Each dblNum In anglesArr
                If dblNum > 0 Then
                    intAngles += 1
                End If
            Next

            If intSides = 1 And intAngles = 1 Then
                isValid = True
            ElseIf intSides >= 2 Then
                isValid = True
            End If

            If dblOpposite < 0 Or dblAdjacent < 0 Or dblHypotenuse < 0 Or dblAngleA < 0 Or dblAngleB < 0 Then
                MessageBox.Show("You must enter number greater than 0")
            Else
                If isValid Then
                    getSides(dblOpposite, dblAdjacent, dblHypotenuse)
                Else
                    MessageBox.Show("You must input atleast 1 side and an angle or two sides.")
                End If
            End If


        Catch ex As Exception
            MessageBox.Show("You must enter numeric values only")
        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtSideA.Text = 0
        txtSideB.Text = 0
        txtSideC.Text = 0
        txtAngleA.Text = 0
        txtAngleB.Text = 0
    End Sub
End Class