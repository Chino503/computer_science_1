Public Class frmTrigCalculator

    Function getAngle(ByVal dblAngle As Double) As Double
        Return 90 - dblAngle
    End Function

    Function Opposite(ByVal dblAdjacent As Double, ByVal dblHypotenuse As Double) As Double
        Return Math.Sqrt(Math.Pow(dblHypotenuse, 2) - Math.Pow(dblAdjacent, 2))
    End Function

    Function Adjacent(ByVal dblOpposite As Double, ByVal dblHypotenuse As Double) As Double
        Return Math.Sqrt(Math.Pow(dblHypotenuse, 2) - Math.Pow(dblOpposite, 2))
    End Function

    Function Hypotenuse(ByVal dblOpposite As Double, ByVal dblAdjacent As Double) As Double
        Return Math.Sqrt(Math.Pow(dblOpposite, 2) + Math.Pow(dblAdjacent, 2))
    End Function

    Private Sub getAll(ByRef dblOpposite As Double, ByRef dblAdjacent As Double, ByRef dblHypotenuse As Double, ByRef dblAngleA As Double, ByRef dblAngleB As Double)

        Dim TO_DEG As Double = Math.PI / 180
        Dim TO_RAD As Double = 180 / Math.PI

        If dblAngleA > 0 Then
            If dblOpposite > 0 Then
                dblAdjacent = dblOpposite / Math.Tan(dblAngleA * TO_DEG)
                dblHypotenuse = Hypotenuse(dblOpposite, dblAdjacent)
                dblAngleB = getAngle(dblAngleA)
            ElseIf dblAdjacent > 0 Then
                dblHypotenuse = dblAdjacent / Math.Cos(dblAngleA * TO_DEG)
                dblOpposite = Opposite(dblAdjacent, dblHypotenuse)
                dblAngleB = getAngle(dblAngleA)
            ElseIf dblHypotenuse > 0 Then
                dblOpposite = dblHypotenuse * Math.Sin(dblAngleA * TO_DEG)
                dblAdjacent = Adjacent(dblOpposite, dblHypotenuse)
                dblAngleB = getAngle(dblAngleA)
            End If
        Else

            If dblAdjacent > 0 And dblHypotenuse > 0 Then
                dblOpposite = Opposite(dblAdjacent, dblHypotenuse)
                dblAngleA = Math.Asin(Math.Sin(dblOpposite / dblHypotenuse)) * TO_RAD
                dblAngleB = getAngle(dblAngleA)
            ElseIf dblOpposite > 0 And dblHypotenuse Then
                dblAdjacent = Adjacent(dblOpposite, dblHypotenuse)
                dblAngleA = Math.Asin(Math.Sin(dblOpposite / dblHypotenuse)) * TO_RAD
                dblAngleB = getAngle(dblAngleA)
            ElseIf dblOpposite > 0 And dblAdjacent > 0 Then
                dblHypotenuse = Hypotenuse(dblOpposite, dblAdjacent)
                dblAngleA = Math.Asin(Math.Sin(dblOpposite / dblHypotenuse)) * TO_RAD
                dblAngleB = getAngle(dblAngleA)
            End If
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
                ElseIf sidesArr(0) > 0 And sidesArr(1) > 0 Then
                    isValid = True
                End If
            Next

            For Each dblNum In anglesArr
                If dblNum > 0 And dblNum <= 100 Then
                    intAngles += 1
                End If
            Next


            If intSides = 1 And intAngles = 1 Then
                isValid = True
            ElseIf intSides >= 2 Then
                isValid = True
            Else
                isValid = False
            End If

            If dblOpposite < 0 Or dblAdjacent < 0 Or dblHypotenuse < 0 Or dblAngleA < 0 Or dblAngleB < 0 Then
                MessageBox.Show("You must enter number greater than 0")
            Else
                If isValid Then
                    getAll(dblOpposite, dblAdjacent, dblHypotenuse, dblAngleA, dblAngleB)
                    txtSideA.Text = dblOpposite
                    txtAngleA.Text = dblAngleA
                    txtAngleB.Text = dblAngleB
                    txtSideB.Text = dblAdjacent
                    txtSideC.Text = dblHypotenuse
                Else
                    MessageBox.Show("You must only enter 1 side and 1 angle or 2 sides.")
                    btnReset.PerformClick()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("You must enter numeric values only, try again")
            btnReset.PerformClick()
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