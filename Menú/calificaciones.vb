Public Class calificaciones
    Dim nombre As String
    Dim parcial1, parcial2, parcial3 As Double
    Dim promedio As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre = txtb_nombre.Text

        parcial1 = txtb_parcial1.Text
        parcial2 = txtb_parcial2.Text
        parcial3 = txtb_parcial3.Text

        promedio = Math.Round(((parcial1 + parcial2 + parcial3) / 3), 2)

        lbl_result.Text = "El promedio del alumno: " & nombre & " es: " & promedio

        txtb_nombre.Clear()
        txtb_parcial1.Clear()
        txtb_parcial2.Clear()
        txtb_parcial3.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class