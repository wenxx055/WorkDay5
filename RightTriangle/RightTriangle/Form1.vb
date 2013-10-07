Option Strict On
Public Class Form1

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Dim side1 As Double = CDbl(txtSideOne.Text)
        Dim side2 As Double = CDbl(txtSideTwo.Text)
        txtHyp.Text = CStr(HypotenuseCal(side1, side2))

    End Sub

    Function HypotenuseCal(ByVal side1 As Double, side2 As Double) As Double

        Dim hypotenuse As Double
        hypotenuse = Math.Sqrt(side1 ^ 2 + side2 ^ 2)
        Return hypotenuse

    End Function
End Class