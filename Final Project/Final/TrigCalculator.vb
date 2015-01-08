Public Class frmTrigCalculator

    Function getAngle(ByVal dblAngle As Double) As Double
        Return 90 - dblAngle
    End Function

    Private Sub getSides(ByRef dblOpposite As Double, ByRef dblAdjacent As Double, ByRef dblHypotenuse As Double)

        If dblOpposite = 0 Then
            dblOpposite = Math.Sqrt(Math.Pow(dblHypotenuse, 2) - Math.Pow(dblAdjacent, 2))
        ElseIf dblAdjacent = 0 Then
            dblAdjacent = Math.Sqrt(Math.Pow(dblHypotenuse, 2) - Math.Pow(dblOpposite, 2))
        ElseIf dblHypotenuse = 0 Then
            dblHypotenuse = Math.Sqrt(Math.Pow(dblOpposite, 2) + Math.Pow(dblAdjacent, 2))
        ElseIf (Math.Sqrt(Math.Pow(dblOpposite, 2) + Math.Pow(dblAdjacent, 2)) <> dblHypotenuse) Then
            dblOpposite = 0
            dblAdjacent = 0
            dblHypotenuse = 0
            MessageBox.Show("You've entered all three sides, but they don't make a right triangle!")
        End If
    End Sub


    Function theAngles(ByVal dblOpposite As Double, ByVal dblAdjacent As Double, ByVal dblHypotenuse As Double, ByRef dblAngleA As Double) As Double
        Dim USE_SIN As Double = Math.Asin(Math.Sin(dblOpposite / dblHypotenuse)) * 180 / Math.PI
        Dim USE_TAN As Double
        MessageBox.Show(USE_SIN)
        If dblOpposite > 0 And dblAdjacent > 0 Then

        End If

        Return dblAngleA
    End Function


    Private Sub getAngles(ByRef dblAngleA As Double, ByRef dblAngleB As Double, ByRef dblOpposite As Double, ByRef dblAdjacent As Double, ByRef dblHypotenuse As Double)

        Const TO_DEG As Double = Math.PI / 180 'converts values to degrees
        Dim getOpp As Double = (dblAdjacent * Math.Tan(dblAngleA * TO_DEG))
        Dim getHyp As Double = (dblOpposite / Math.Sin(dblAngleA * TO_DEG))
        Dim getAdj As Double = (dblHypotenuse * Math.Cos(dblAngleA * TO_DEG))

        theAngles(dblOpposite, dblAdjacent, dblHypotenuse, dblAngleA)

        If dblAngleA >= 90 Then
            MessageBox.Show("You cannot have a degree greater than 90 degrees")
            dblAngleA = 0
        End If

        If dblAngleA > 0 And dblAdjacent > 0 Then
            dblOpposite = getOpp
            dblAngleB = getAngle(dblAngleA)
            getSides(dblOpposite, dblAdjacent, dblHypotenuse)
        ElseIf dblAngleA > 0 And dblOpposite > 0 Then
            dblHypotenuse = getHyp
            dblAngleB = getAngle(dblAngleA)
            getSides(dblOpposite, dblAdjacent, dblHypotenuse)
        ElseIf dblAngleA > 0 And dblHypotenuse > 0 Then
            dblAdjacent = getAdj
            dblAngleB = getAngle(dblAngleA)
            getSides(dblOpposite, dblAdjacent, dblHypotenuse)
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
                If dblNum > 0 And dblNum <= 100 Then
                    intAngles += 1
                End If
            Next

            If intSides = 1 And intAngles = 1 Then
                isValid = True
            ElseIf intSides >= 2 Then
                isValid = True
                If dblAdjacent < dblHypotenuse And dblOpposite < dblHypotenuse Then
                    getSides(dblOpposite, dblAdjacent, dblHypotenuse)
                End If
            End If

            If dblOpposite < 0 Or dblAdjacent < 0 Or dblHypotenuse < 0 Or dblAngleA < 0 Or dblAngleB < 0 Then
                MessageBox.Show("You must enter number greater than 0")
            Else
                If isValid Then
                    getAngles(dblAngleA, dblAngleB, dblOpposite, dblAdjacent, dblHypotenuse)
                    getSides(dblOpposite, dblAdjacent, dblHypotenuse)
                    txtSideA.Text = dblOpposite
                    txtSideB.Text = dblAdjacent
                    txtSideC.Text = dblHypotenuse
                    txtAngleA.Text = dblAngleA
                    txtAngleB.Text = dblAngleB
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