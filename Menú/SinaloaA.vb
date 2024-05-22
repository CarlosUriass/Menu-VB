Imports Menú.validaciones.Validaciones
Imports System.IO

Public Class SinaloaA
    Dim importe As String
    Dim municipio As String
    Dim num_municipio As String
    Dim rubro As String
    Dim n_rubro As String
    Dim mes As String
    Dim n_mes As String
    Dim cadena As String
    Dim ARCHIVO As System.IO.StreamWriter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        importe = importe_txt.Text

        If soloNumeros(importe) = True Then 'Validar que solo sean numeros
            Return
        End If

        municipio = municipio_cbx.SelectedItem

        num_municipio = numero_municipio(municipio)

        rubro = rubro_cbx.SelectedItem

        n_rubro = numero_rubro(rubro) 'NUMERO DE RUBRO

        importe = importe.PadLeft(9, "0") 'Agrega los ceros que hagan falta a la izquierda

        mes = cbx_mes.SelectedItem

        n_mes = mes_num(mes)

        ListBox1.Items.Add("Municipio: " & LCase(municipio) & " Rubro:" & " " & LCase(rubro) & " Importe:" & " " & importe & " Mes: " & LCase(mes))

        cadena = num_municipio & n_rubro & importe & n_mes

        ARCHIVO.WriteLine(cadena)
        ARCHIVO.Flush()

        limpiar()



    End Sub


    Public Function numero_municipio(municipio) As String
        Dim numero_municipio_str As String
        numero_municipio_str = ""


        Select Case municipio
            Case "Ahome"
                numero_municipio_str = "01"
            Case "Angostura"
                numero_municipio_str = "02"
            Case "Badiraguato"
                numero_municipio_str = "03"
            Case "Choix"
                numero_municipio_str = "04"
            Case "Cosalá"
                numero_municipio_str = "05"
            Case "Concordia"
                numero_municipio_str = "06"
            Case "Culiacán"
                numero_municipio_str = "07"
            Case "El Fuerte"
                numero_municipio_str = "08"
            Case "Elota"
                numero_municipio_str = "09"
            Case "Escuinapa"
                numero_municipio_str = "10"
            Case "Guasave"
                numero_municipio_str = "11"
            Case "Mazatlán"
                numero_municipio_str = "12"
            Case "Mocorito"
                numero_municipio_str = "13"
            Case "Navolato"
                numero_municipio_str = "14"
            Case "Rosario"
                numero_municipio_str = "15"
            Case "Salvador Alvarado"
                numero_municipio_str = "16"
            Case "San Ignacio"
                numero_municipio_str = "17"
            Case "Sinaloa"
                numero_municipio_str = "18"

        End Select

        Return numero_municipio_str

    End Function


    Public Function numero_rubro(rubro) As String

        Dim n_rubro As String = ""

        Select Case rubro
            Case "SALUD"
                n_rubro = "01"
            Case "EDUCACION"
                n_rubro = "02"
            Case "SEGURIDAD"
                n_rubro = "03"
            Case "CULTURA"
                n_rubro = "04"
            Case "TURISMO"
                n_rubro = "05"
            Case "ECONOMIA"
                n_rubro = "06"

        End Select

        Return n_rubro

    End Function

    Public Function mes_num(mes) As String
        Dim num_mes As String

        num_mes = ""

        Select Case mes
            Case "ENERO"
                num_mes = "01"
            Case "FEBRERO"
                num_mes = "02"
            Case "MARZO"
                num_mes = "03"
            Case "ABRIL"
                num_mes = "04"
            Case "MAYO"
                num_mes = "05"
            Case "JUNIO"
                num_mes = "06"
            Case "JULIO"
                num_mes = "07"
            Case "AGOSTO"
                num_mes = "08"
            Case "SEPTIEMBRE"
                num_mes = "09"
            Case "OCTUBRE"
                num_mes = "10"
            Case "NOVIEMBRE"
                num_mes = "11"
            Case "DICIEMBRE"
                num_mes = "12"
        End Select

        Return num_mes
    End Function

    Public Function limpiar()
        municipio_cbx.SelectedIndex = -1
        rubro_cbx.SelectedIndex = -1
        importe_txt.Clear()
        cbx_mes.SelectedIndex = -1

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ARCHIVO = My.Computer.FileSystem.OpenTextFileWriter("F:\Menú\Menú\TXT\sinaloaA.txt", True)
    End Sub
End Class
