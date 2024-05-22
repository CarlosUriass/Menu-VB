Public Class Triangulo
    Dim base, altura, area As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        base = base_txtb.Text
        altura = altura_txtb.Text

        area = (base * altura) / 2


        lbl_area.Text = area

        base_txtb.Clear()
        altura_txtb.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class