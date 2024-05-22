Imports System.IO
Imports Menú.numeros_txt
Public Class SINALOAB
    Dim Sline As String
    Dim array(18, 5, 12) As String
    Dim ARCHIVO As New StreamReader("F:\Menú\Menú\TXT\sinaloaA.txt") 'Agregar ruta donde se cargará el archivo

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Definir la matriz de 0.
        For i As Integer = 0 To 18
            For j As Integer = 0 To 5
                For m As Integer = 0 To 12
                    array(i, j, m) = "0"
                Next
            Next
        Next

        Dim municipio As String
        Dim rubro As String
        Dim importe As String
        Dim mes As String

        Do
            Sline = ARCHIVO.ReadLine()
            If Not Sline Is Nothing Then
                municipio = Microsoft.VisualBasic.Left(Sline, 2)
                rubro = Sline.Substring(2, 2)
                importe = Sline.Substring(4, 9)
                mes = Sline.Substring(13, 2)


                'Agregar los datos a la matriz
                For i As Integer = 0 To 20
                    array(municipio - 1, rubro - 1, mes - 1) = importe
                Next


            End If
        Loop Until Sline Is Nothing

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total_rubro As Integer = 0
        Dim total As Integer

        ListBox2.Items.Clear()

        For i As Integer = 0 To 18
            For j As Integer = 0 To 5
                total_rubro = 0
                For k As Integer = 0 To 12
                    total_rubro += Val(array(i, j, k))
                    total += Val(array(i, j, k))
                Next

                If total_rubro > 0 Then

                    ListBox2.Items.Add("Municipio: " & nombre_municipio(i + 1) & " Rubro: " & numero_rubro(j + 1) & " total: " & total_rubro & " " & numeros_txt.NumeroATexto(total_rubro))
                End If
            Next
        Next

        ListBox2.Items.Add("Suma total: " & total & " " & numeros_txt.NumeroATexto(total))

    End Sub

    Public Function nombre_municipio(ByVal numero As Integer) As String
        Dim nombre_municipio_str As String = ""

        Select Case numero
            Case 1
                nombre_municipio_str = "Ahome"
            Case 2
                nombre_municipio_str = "Angostura"
            Case 3
                nombre_municipio_str = "Badiraguato"
            Case 4
                nombre_municipio_str = "Choix"
            Case 5
                nombre_municipio_str = "Cosalá"
            Case 6
                nombre_municipio_str = "Concordia"
            Case 7
                nombre_municipio_str = "Culiacán"
            Case 8
                nombre_municipio_str = "El Fuerte"
            Case 9
                nombre_municipio_str = "Elota"
            Case 10
                nombre_municipio_str = "Escuinapa"
            Case 11
                nombre_municipio_str = "Guasave"
            Case 12
                nombre_municipio_str = "Mazatlán"
            Case 13
                nombre_municipio_str = "Mocorito"
            Case 14
                nombre_municipio_str = "Navolato"
            Case 15
                nombre_municipio_str = "Rosario"
            Case 16
                nombre_municipio_str = "Salvador Alvarado"
            Case 17
                nombre_municipio_str = "San Ignacio"
            Case 18
                nombre_municipio_str = "Sinaloa"
        End Select

        Return nombre_municipio_str
    End Function


    Public Function numero_rubro(ByVal rubro As Integer) As String
        Dim n_rubro As String = ""

        Select Case rubro
            Case 1
                n_rubro = "Salud"
            Case 2
                n_rubro = "Educacion"
            Case 3
                n_rubro = "Seguridad"
            Case 4
                n_rubro = "Cultura"
            Case 5
                n_rubro = "Turismo"
            Case 6
                n_rubro = "Economia"
        End Select

        Return n_rubro
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ListBox2.Items.Clear()
        Dim total_municipio = 0
        Dim total = 0
        For i = 0 To 18
            total_municipio = 0
            For j = 0 To 5
                For k = 0 To 12
                    total_municipio += Val(array(i, j, k))
                    total += Val(array(i, j, k))
                Next
            Next
            If total_municipio > 0 Then
                ListBox2.Items.Add("Municipio: " & nombre_municipio(i + 1) & " Total: " & total_municipio & " " & numeros_txt.NumeroATexto(total_municipio) & " " & obtener_porcentaje(total_municipio) & "%")
            End If
        Next

        ListBox2.Items.Add("Total: $" & total)
    End Sub

    Public Function obtener_porcentaje(numero) As String
        Dim porcentaje As String

        porcentaje = Math.Round((numero / 1000000 * 100), 2)


        Return porcentaje


    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox2.Items.Clear()

        Dim total_mes As String
        Dim suma As Integer

        For i = 0 To 12
            total_mes = 0
            For j = 0 To 5
                For k = 0 To 18
                    total_mes += Val(array(k, j, i))
                    suma += Val(array(k, j, i))
                Next
            Next
            If total_mes > 0 Then
                ListBox2.Items.Add("Mes: " & nombre_mes(i + 1) & " Total: $" & total_mes & numeros_txt.NumeroATexto(total_mes) & " " & obtener_porcentaje(total_mes) & "%")
            End If
        Next

        ListBox2.Items.Add("Suma total: $" & suma & " " & numeros_txt.NumeroATexto(suma))
    End Sub

    Public Function nombre_mes(ByVal numero As Integer) As String
        Dim nombre_mes_str As String = ""

        Select Case numero
            Case 1
                nombre_mes_str = "Enero"
            Case 2
                nombre_mes_str = "Febrero"
            Case 3
                nombre_mes_str = "Marzo"
            Case 4
                nombre_mes_str = "Abril"
            Case 5
                nombre_mes_str = "Mayo"
            Case 6
                nombre_mes_str = "Junio"
            Case 7
                nombre_mes_str = "Julio"
            Case 8
                nombre_mes_str = "Agosto"
            Case 9
                nombre_mes_str = "Septiembre"
            Case 10
                nombre_mes_str = "Octubre"
            Case 11
                nombre_mes_str = "Noviembre"
            Case 12
                nombre_mes_str = "Diciembre"
        End Select

        Return nombre_mes_str
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox2.Items.Clear()
        Dim suma As Integer

        For i As Integer = 0 To 18
            For j As Integer = 0 To 5
                suma = 0
                For k As Integer = 0 To 12
                    suma += Val(array(i, j, k))
                    If array(i, j, k) > 0 Then
                        ListBox2.Items.Add("Municipio: " & nombre_municipio(i + 1) & " " & "rubro: " & numero_rubro(j + 1) & " " & "mes: " & nombre_mes(k + 1) & " importe: $" & suma & " " & numeros_txt.NumeroATexto(suma))
                    End If
                Next
            Next
        Next
    End Sub
End Class
