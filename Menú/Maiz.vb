Public Class Maiz
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kg As Integer
        Dim descuento As Double
        Dim humedad As Double
        Dim precio As Double = txtb_precio.Text


        kg = txtb_kg.Text

        humedad = txtb_humedad.Text
        descuento = descuento_humedad(humedad)

        Dim kg_descontados As Double

        kg_descontados = kg * descuento

        Dim kg_a_pagar As Double
        kg_a_pagar = kg - kg_descontados

        Dim subtotal As Double
        Dim ton_a_pagar As Double

        ton_a_pagar = kg_to_ton(kg_a_pagar) * precio

        subtotal = ton_a_pagar


        Dim impuestos As Double

        impuestos = subtotal * 0.16

        Dim total As Double

        total = subtotal - impuestos

        DataGridView1.Rows.Add(kg, kg_to_ton(kg), humedad & "%", kg_descontados, subtotal, impuestos, total)

        limpiar()

    End Sub

    Public Function kg_to_ton(kg)
        Dim toneladas As Double

        toneladas = kg / 1000

        Return toneladas
    End Function

    Public Function descuento_humedad(humedad)
        Dim descuento As Double
        If humedad <= 14 Then
            descuento = 0
        ElseIf humedad > 14 And humedad <= 16 Then
            descuento = 0.03
        ElseIf humedad > 16 And humedad <= 18 Then
            descuento = 0.05
        Else
            descuento = 0.07
        End If

        Return descuento
    End Function

    Public Sub limpiar()
        txtb_humedad.Text = ""
        txtb_kg.Text = ""
        txtb_precio.Text = ""

        MsgBox("Operacion Realizada con exito!")
    End Sub

End Class