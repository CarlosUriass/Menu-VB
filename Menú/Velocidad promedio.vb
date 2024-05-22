Public Class Velocidad_promedio
    Dim distancia, tiempo As Double
    Dim promedio As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        distancia = txtb_distancia.Text
        tiempo = txtb_tiempo.Text

        promedio = Math.Round(distancia / tiempo, 2)

        lbl_kmh.Text = promedio & " KM/H"


        txtb_tiempo.Clear()
        txtb_distancia.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class