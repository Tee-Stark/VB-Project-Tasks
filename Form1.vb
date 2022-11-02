Imports System.Math

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Dim a, b, c As Integer
        Dim d, x, x1, x2, real, imag As Double

        a = Integer.Parse(txtA.Text)
        b = Integer.Parse(txtB.Text)
        c = Integer.Parse(txtC.Text)

        d = (b * b) - (4 * a * c)

        If d > 0 Then
            x1 = (-b + Math.Sqrt(d)) / (2 * a)
            x2 = (-b - Math.Sqrt(d)) / (2 * a)

            lblX1.Text = x1
            lblX2.Text = x2
        ElseIf d = 0 Then
            x = -b / 2 * a

            lblX.Text = x
        Else
            real = -b / (2 * a)
            imag = Math.Sqrt(-d) / (2 * a)

            lblReal.Text = real
            lblImag.Text = imag
        End If

    End Sub
End Class
