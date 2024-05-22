Imports System.ComponentModel.Design
Imports System.IO
Public Class CINE

    Private Sub CargarImagen(imagen1, imagen2, imagen3, imagen4)
        ' Verificamos si la ruta de la imagen es válida
        If System.IO.File.Exists(imagen1) Then
            ' Cargamos la imagen desde la ruta especificada
            PictureBox2.Image = Image.FromFile(imagen1)
            PictureBox3.Image = Image.FromFile(imagen2)
            PictureBox4.Image = Image.FromFile(imagen3)
            PictureBox7.Image = Image.FromFile(imagen4)
        Else
            MessageBox.Show("La ruta de la imagen no es válida.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim imagen1, imagen2, imagen3, imagen4 As String
        ' Inicializa la semilla para generar números aleatorios
        Randomize()

        ' Genera un número aleatorio del 1 al 37
        Dim p_1 As Integer = Int((37 * Rnd()) + 1)
        Dim p_2 As Integer = Int((37 * Rnd()) + 1)
        Dim p_3 As Integer = Int((37 * Rnd()) + 1)
        Dim p_4 As Integer = Int((37 * Rnd()) + 1)


        imagen1 = "F:\Menú\Menú\Imagenes\" & "Poster" & p_1 & ".jpg"
        imagen2 = "F:\Menú\Menú\Imagenes\" & "Poster" & p_2 & ".jpg"
        imagen3 = "F:\Menú\Menú\Imagenes\" & "Poster" & p_3 & ".jpg"
        imagen4 = "F:\Menú\Menú\Imagenes\" & "Poster" & p_4 & ".jpg"

        CargarImagen(imagen1, imagen2, imagen3, imagen4)

        'Obtener fecha

        Dim fecha As DateTime = MonthCalendar1.SelectionStart
        Dim dia As DayOfWeek = fecha.DayOfWeek
        Dim nombre_dia As String

        nombre_dia = ObtenerNombreDia(dia)

        Label1.Text = "PROMOCION DEL DIA: " & promocion(nombre_dia)


    End Sub

    Public Function ObtenerNombreDia(diaSemana As DayOfWeek) As String
        Select Case diaSemana
            Case DayOfWeek.Sunday
                Return "Domingo"
            Case DayOfWeek.Monday
                Return "Lunes"
            Case DayOfWeek.Tuesday
                Return "Martes"
            Case DayOfWeek.Wednesday
                Return "Miércoles"
            Case DayOfWeek.Thursday
                Return "Jueves"
            Case DayOfWeek.Friday
                Return "Viernes"
            Case DayOfWeek.Saturday
                Return "Sábado"
            Case Else
                Return "Día no válido"
        End Select
    End Function

    Public Function promocion(dia)
        Dim mensajePromocion As String = ""

        ' Seleccionar la promoción según el día de la semana
        Select Case dia
            Case "Lunes"
                mensajePromocion = "¡Lunes de descuento! 50% de descuento en palomitas."
            Case "Martes"
                mensajePromocion = "¡Martes de bebida gratis! Por cada entrada, una bebida gratis."
            Case "Miércoles"
                mensajePromocion = "¡Miércoles de 2x1! Lleva a un amigo y su entrada es gratis."
            Case "Jueves"
                mensajePromocion = "¡Jueves de familia! Niños entran gratis acompañados de un adulto."
            Case "Viernes"
                mensajePromocion = "¡Viernes de estreno! 20% de descuento en estrenos de la semana."
            Case "Sábado"
                mensajePromocion = "¡Sábado de matiné! Descuento especial en funciones antes de las 3 PM."
            Case "Domingo"
                mensajePromocion = "¡Domingo familiar! 2x1 en entradas para familias."
        End Select

        Return mensajePromocion

    End Function
End Class