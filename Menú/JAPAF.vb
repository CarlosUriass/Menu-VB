Public Class JAPAF
    Dim anterior, actual As Double
    Dim importe As Double
    Dim consumo As Double
    Dim precio As Double
    Dim drenaje As Double
    Dim sanamiento As Double
    Dim bomberos As Double
    Dim importe_iva As Double
    Dim total_a_pagar As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        precio = txtb_precio.Text

        anterior = txtb_anterior.Text
        actual = txtb_actual.Text

        consumo = actual - anterior

        importe = consumo * precio

        lbl_agua.Text = importe

        drenaje = importe * 0.2

        lbl_drenaje.Text = drenaje

        sanamiento = importe * 0.1

        lbl_sanamiento.Text = sanamiento

        bomberos = 2.0

        importe_iva = (drenaje + sanamiento) * 0.16

        total_a_pagar = Math.Round(importe + drenaje + sanamiento + bomberos + importe_iva, 2)

        lbl_total.Text = total_a_pagar




    End Sub
End Class