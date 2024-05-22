Public Class HorasExtras
    Dim horas As Integer
    Dim precio As Double
    Dim sueldo As Double
    Dim extras As Integer
    Dim normales, dobles, triples As Double
    Dim horas_doble As Byte
    Dim horas_triple As Byte
    Dim bruto
    Dim impuesto As Double
    Dim neto As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        horas = txtb_horas.Text
        precio = txtb_precio.Text

        'Revisa si solo cumplio las 48 horas o menos
        If horas <= 48 Then
            normales = horas * precio
        End If

        If horas > 48 Then 'Revisa si trabajó mas de 48 horas 
            extras = calcular_horas_extras(horas) 'Calcula las horas extras restando 48 a las horas trabajadas
            normales = 48 * precio 'Calcula las 48 horas normales

            If extras <= 9 Then 'Revisa que las horas extras sean menores o iguales a 9
                dobles = extras * (precio * 2) 'Calcula el total (doble x hora extra)
            ElseIf extras > 9 Then
                horas_triple = extras - 9 'Resta las 9 de las que se pagan doble

                dobles = 9 * (precio * 2) 'Nueve horas al doble
                triples = horas_triple * (precio * 3) 'Al triple las horas trabajadas menos la base menos las 9

            End If
        End If

        bruto = normales + dobles + triples


        impuesto = calcular_impuestos(bruto) 'Calcula impuestos

        neto = bruto - impuesto 'Resta el impuesto

        Me.DataGridView1.Rows.Add(horas, normales, dobles, triples, bruto, impuesto, neto) 'Agrega al datagrid


        txtb_horas.Clear() 'Limpia los textbox
        txtb_precio.Clear()

        horas = 0 'Resetea las variables
        precio = 0
        normales = 0
        dobles = 0
        triples = 0
        extras = 0


    End Sub

    Public Function calcular_horas_extras(horas) As Integer
        Dim horas_extras As Byte

        horas_extras = horas - 48

        Return horas_extras
    End Function

    Public Function calcular_impuestos(bruto)
        Dim impuestos As Double

        impuestos = Math.Round(bruto * 0.076, 2)

        Return impuestos
    End Function


End Class