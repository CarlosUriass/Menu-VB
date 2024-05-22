Public Class Calculadora
    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbl_numeros.Text += "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbl_numeros.Text += "2"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lbl_numeros.Text += "3"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        lbl_numeros.Text += "4"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lbl_numeros.Text += "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        lbl_numeros.Text += "6"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        lbl_numeros.Text += "8"

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        lbl_numeros.Text += "9"

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        lbl_numeros.Text += "."

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        lbl_numeros.Text += "0"

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        lbl_numeros.Text += "00"

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        lbl_numeros.Text += "7"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lbl_numeros.Text = ""
    End Sub

    Private Sub btn_suma_Click(sender As Object, e As EventArgs) Handles btn_suma.Click
        lbl_numeros.Text += "+"
    End Sub

    Private Sub btn_igual_Click(sender As Object, e As EventArgs) Handles btn_igual.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim operador As String = ""
        Dim texto As String = lbl_numeros.Text


        For i As Integer = 0 To Len(texto) - 1


            If texto(i) = "+" Or texto(i) = "-" Or texto(i) = "*" Or texto(i) = "/" Or texto(i) = "^" Then

                operador = texto(i)
                num1 = Val(Mid(texto, 1, i + 1))
                num2 = Val(Mid(texto, i + 2))
            End If
        Next

        lbl_numeros.Text = "" ' Limpiamos el contenido de lbl_numeros.Text


        Dim suma As Double
        Dim resta As Double
        Dim multiplicacion As Double
        Dim division As Double
        Dim potencia As Double

        If operador = "+" Then
            suma = num1 + num2
            lbl_numeros.Text = suma

        ElseIf operador = "-" Then
            resta = num1 - num2
            lbl_numeros.Text = resta

        ElseIf operador = "*" Then
            multiplicacion = num1 * num2

            lbl_numeros.Text = multiplicacion
        ElseIf operador = "/" Then

            If num2 = 0 Then
                MsgBox("La division entre 0 no está definida")
                Return
            Else
                division = num1 / num2
                lbl_numeros.Text = division
            End If

        ElseIf operador = "^" Then
            potencia = num1 ^ num2
            lbl_numeros.Text = potencia
        End If



    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        lbl_numeros.Text += "-"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        lbl_numeros.Text += "*"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        lbl_numeros.Text += "/"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        lbl_numeros.Text += "^"
    End Sub
End Class