Public Class Jornaleros

    Dim contador As Integer
    Dim array(0, 6) As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim curp As String = txtb_curp.Text
        Dim nombre As String = txtb_nombre.Text
        Dim primerap As String = txtb_primerap.Text
        Dim segundoap As String = txtb_segundoap.Text

        Dim estadocivil As String = ""
        If rb_casado.Checked Then
            estadocivil = "casado"
        ElseIf rb_divorciado.Checked Then
            estadocivil = "divorciado"
        ElseIf rb_viudo.Checked Then
            estadocivil = "viudo"
        ElseIf rb_soltero.Checked Then
            estadocivil = "soltero"
        ElseIf rb_otro.Checked Then
            estadocivil = "otro"
        End If

        Dim sexo_clave As String = curp(10)
        Dim sexo As String = sexo_str(sexo_clave)

        Dim estado_clave As String = curp(11) & curp(12)
        Dim estado As String = estado_str(estado_clave)


        ReDim array(contador, 6)


        array(contador, 0) = curp
        array(contador, 1) = nombre
        array(contador, 2) = primerap
        array(contador, 3) = segundoap
        array(contador, 4) = sexo
        array(contador, 5) = estado
        array(contador, 6) = estadocivil

        txtb_curp.Text = ""
        txtb_nombre.Text = ""
        txtb_primerap.Text = ""
        txtb_segundoap.Text = ""

        contador += 1
    End Sub

    Public Function sexo_str(clave As String) As String
        clave = UCase(clave)
        Dim sexo As String = ""
        Select Case clave
            Case "M"
                sexo = "Femenino"
            Case "H"
                sexo = "Masculino"
        End Select
        Return sexo
    End Function

    Public Function estado_str(estado As String) As String

        estado = UCase(estado)
        Dim entidad As String = ""
        Select Case estado
            Case "AS"
                entidad = "Aguascalientes"
            Case "BC"
                entidad = "Baja California"
            Case "BS"
                entidad = "Baja California Sur"
            Case "CC"
                entidad = "Campeche"
            Case "CL"
                entidad = "Coahuila"
            Case "CH"
                entidad = "Chihuahua"
            Case "DF"
                entidad = "Ciudad de Mexico"
            Case "DG"
                entidad = "Durango"
            Case "GT"
                entidad = "Guanajuato"
            Case "GR"
                entidad = "Guerrero"
            Case "HG"
                entidad = "Hidalgo"
            Case "JC"
                entidad = "Jalisco"
            Case "MC"
                entidad = "Mexico"
            Case "MN"
                entidad = "Michoacan"
            Case "MS"
                entidad = "Morelos"
            Case "NT"
                entidad = "Nayarit"
            Case "NL"
                entidad = "Nuevo Leon"
            Case "OC"
                entidad = "Oaxaca"
            Case "PL"
                entidad = "Puebla"
            Case "QT"
                entidad = "Queretaro"
            Case "QR"
                entidad = "Quintana Roo"
            Case "SP"
                entidad = "San Luis Potosi"
            Case "SL"
                entidad = "Sinaloa"
            Case "SR"
                entidad = "Sonora"
            Case "TC"
                entidad = "Tabasco"
            Case "TS"
                entidad = "Tamaulipas"
            Case "TL"
                entidad = "Tlaxcala"
            Case "VZ"
                entidad = "Veracruz"
            Case "YN"
                entidad = "Yucatan"
            Case "ZS"
                entidad = "Zacatecas"
            Case "NE"
                entidad = "Nacido en el extranjero"
        End Select
        Return entidad
    End Function

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        ' Definición de las columnas
        Dim columnaCURP As New DataGridViewTextBoxColumn()
        Dim columnaNombre As New DataGridViewTextBoxColumn()
        Dim columnaApellidoPaterno As New DataGridViewTextBoxColumn()
        Dim columnaApellidoMaterno As New DataGridViewTextBoxColumn()
        Dim columnaSexo As New DataGridViewTextBoxColumn()
        Dim columnaEstado As New DataGridViewTextBoxColumn()
        Dim columnaEstadoCivil As New DataGridViewTextBoxColumn()

        ' Asignación de propiedades a las columnas
        columnaCURP.HeaderText = "CURP"
        columnaCURP.DataPropertyName = "CURP"
        columnaCURP.Width = 150

        columnaNombre.HeaderText = "Nombre"
        columnaNombre.DataPropertyName = "Nombre"
        columnaNombre.Width = 200

        columnaApellidoPaterno.HeaderText = "Apellido paterno"
        columnaApellidoPaterno.DataPropertyName = "ApellidoPaterno"
        columnaApellidoPaterno.Width = 150

        columnaApellidoMaterno.HeaderText = "Apellido materno"
        columnaApellidoMaterno.DataPropertyName = "ApellidoMaterno"
        columnaApellidoMaterno.Width = 150

        columnaSexo.HeaderText = "Sexo"
        columnaSexo.DataPropertyName = "Sexo"
        columnaSexo.Width = 80

        columnaEstado.HeaderText = "Estado"
        columnaEstado.DataPropertyName = "Estado"
        columnaEstado.Width = 120

        columnaEstadoCivil.HeaderText = "Estado civil"
        columnaEstadoCivil.DataPropertyName = "Estado civil"
        columnaEstadoCivil.Width = 120

        ' Agregar las columnas al DataGridView
        Me.DataGridView1.Columns.Add(columnaCURP)
        Me.DataGridView1.Columns.Add(columnaNombre)
        Me.DataGridView1.Columns.Add(columnaApellidoPaterno)
        Me.DataGridView1.Columns.Add(columnaApellidoMaterno)
        Me.DataGridView1.Columns.Add(columnaSexo)
        Me.DataGridView1.Columns.Add(columnaEstado)
        Me.DataGridView1.Columns.Add(columnaEstadoCivil)

        ' Añadir filas
        For i As Integer = 0 To contador - 1
            DataGridView1.Rows.Add(array(i, 0), array(i, 1), array(i, 2), array(i, 3), array(i, 4), array(i, 5), array(i, 6))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim contador_sexo As Integer
        Dim array_sexo(1)
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        For i As Integer = 0 To contador - 1
            contador_sexo += 1
            If array(i, 4) = "M" Then
                array_sexo(0) += 1
            Else
                array_sexo(1) += 1
            End If
        Next

        Dim columna_sexo As New DataGridViewTextBoxColumn()
        Dim columna_cantidad As New DataGridViewTextBoxColumn()
        Dim porcentaje_sexo As New DataGridViewTextBoxColumn()


        columna_sexo.HeaderText = "Sexo"
        columna_sexo.DataPropertyName = "Sexo"
        columna_sexo.Width = 120

        columna_cantidad.HeaderText = "Cantidad"
        columna_cantidad.DataPropertyName = "CantidadxSexo"
        columna_cantidad.Width = 80


        porcentaje_sexo.HeaderText = "%"
        porcentaje_sexo.DataPropertyName = "%sexo"
        porcentaje_sexo.Width = 80

        Me.DataGridView1.Columns.Add(columna_sexo)
        Me.DataGridView1.Columns.Add(columna_cantidad)
        Me.DataGridView1.Columns.Add(porcentaje_sexo)


        DataGridView1.Rows.Add("Hombres", array_sexo(1), array_sexo(1) / contador_sexo * 100 & "%")
        DataGridView1.Rows.Add("Mujeres", array_sexo(0), array_sexo(0) / contador_sexo * 100 & "%")



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()


        Dim columna_mayor As New DataGridViewTextBoxColumn()
        Dim columna_menor As New DataGridViewTextBoxColumn()

        columna_mayor.HeaderText = "Mayor de edad"
        columna_mayor.DataPropertyName = "Mayor"
        columna_mayor.Width = 80

        columna_menor.HeaderText = "Menor de edad"
        columna_menor.DataPropertyName = "menor"
        columna_menor.Width = 80

        Me.DataGridView1.Columns.Add(columna_mayor)
        Me.DataGridView1.Columns.Add(columna_menor)

        Dim array_edad(1) As Integer

        For i As Integer = 0 To contador - 1
            If esmayordeedad(array(i, 1)) = True Then
                array_edad(0) += 1
            Else
                array_edad(1) += 1
            End If
        Next

        DataGridView1.Rows.Add(array_edad(1), array_edad(0))


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        Dim array_estado(32) As Integer

        Dim columna_entidad As New DataGridViewTextBoxColumn()
        Dim columna_cantidad_entidad As New DataGridViewTextBoxColumn()
        Dim columna_entidad_porcentaje As New DataGridViewTextBoxColumn()

        columna_entidad.HeaderText = "Entidad"
        columna_entidad.DataPropertyName = "Entidad"
        columna_entidad.Width = 80

        columna_cantidad_entidad.HeaderText = "Cantidad"
        columna_cantidad_entidad.DataPropertyName = "CantidadxEntidad"
        columna_cantidad_entidad.Width = 80

        columna_entidad_porcentaje.HeaderText = "%"
        columna_entidad_porcentaje.DataPropertyName = "PorcentajeXentidad"
        columna_entidad_porcentaje.Width = 80



        Me.DataGridView1.Columns.Add(columna_entidad)
        Me.DataGridView1.Columns.Add(columna_cantidad_entidad)
        Me.DataGridView1.Columns.Add(columna_entidad_porcentaje)

        Dim numero_estado As Integer

        For i As Integer = 0 To contador - 1
            numero_estado = no_estado(array(i, 5))
            array_estado(numero_estado) += 1
        Next


        For i As Integer = 0 To 32
            If array_estado(i) > 0 Then
                DataGridView1.Rows.Add(ObtenerNombreEstado(i), array_estado(i))
            End If
        Next


    End Sub

    Public Function no_estado(estado)
        Dim numeroEstado As Integer

        Select Case estado
            Case "Aguascalientes"
                numeroEstado = 0
            Case "Baja California"
                numeroEstado = 1
            Case "Baja California Sur"
                numeroEstado = 2
            Case "Campeche"
                numeroEstado = 3
            Case "Coahuila"
                numeroEstado = 4
            Case "Colima"
                numeroEstado = 5
            Case "Chiapas"
                numeroEstado = 6
            Case "Chihuahua"
                numeroEstado = 7
            Case "Ciudad de Mexico"
                numeroEstado = 8
            Case "Durango"
                numeroEstado = 9
            Case "Guanajuato"
                numeroEstado = 10
            Case "Guerrero"
                numeroEstado = 11
            Case "Hidalgo"
                numeroEstado = 12
            Case "Jalisco"
                numeroEstado = 13
            Case "Mexico"
                numeroEstado = 14
            Case "Michoacan"
                numeroEstado = 15
            Case "Morelos"
                numeroEstado = 16
            Case "Nayarit"
                numeroEstado = 17
            Case "Nuevo Leon"
                numeroEstado = 18
            Case "Oaxaca"
                numeroEstado = 19
            Case "Puebla"
                numeroEstado = 20
            Case "Queretaro"
                numeroEstado = 21
            Case "Quintana Roo"
                numeroEstado = 22
            Case "San Luis Potosi"
                numeroEstado = 23
            Case "Sinaloa"
                numeroEstado = 24
            Case "Sonora"
                numeroEstado = 25
            Case "Tabasco"
                numeroEstado = 26
            Case "Tamaulipas"
                numeroEstado = 27
            Case "Tlaxcala"
                numeroEstado = 28
            Case "Veracruz"
                numeroEstado = 29
            Case "Yucatan"
                numeroEstado = 30
            Case "Zacatecas"
                numeroEstado = 31
            Case "Nacido en el extranjero"
                numeroEstado = 32
        End Select

        Return numeroEstado


    End Function

    Function ObtenerNombreEstado(ByVal numeroEstado As Integer) As String
        Dim entidad As String

        Select Case numeroEstado
            Case 0
                entidad = "Aguascalientes"
            Case 1
                entidad = "Baja California"
            Case 2
                entidad = "Baja California Sur"
            Case 3
                entidad = "Campeche"
            Case 4
                entidad = "Coahuila"
            Case 5
                entidad = "Colima"
            Case 6
                entidad = "Chiapas"
            Case 7
                entidad = "Chihuahua"
            Case 8
                entidad = "Ciudad de Mexico"
            Case 9
                entidad = "Durango"
            Case 10
                entidad = "Guanajuato"
            Case 11
                entidad = "Guerrero"
            Case 12
                entidad = "Hidalgo"
            Case 13
                entidad = "Jalisco"
            Case 14
                entidad = "Mexico"
            Case 15
                entidad = "Michoacan"
            Case 16
                entidad = "Morelos"
            Case 17
                entidad = "Nayarit"
            Case 18
                entidad = "Nuevo Leon"
            Case 19
                entidad = "Oaxaca"
            Case 20
                entidad = "Puebla"
            Case 21
                entidad = "Queretaro"
            Case 22
                entidad = "Quintana Roo"
            Case 23
                entidad = "San Luis Potosi"
            Case 24
                entidad = "Sinaloa"
            Case 25
                entidad = "Sonora"
            Case 26
                entidad = "Tabasco"
            Case 27
                entidad = "Tamaulipas"
            Case 28
                entidad = "Tlaxcala"
            Case 29
                entidad = "Veracruz"
            Case 30
                entidad = "Yucatan"
            Case 31
                entidad = "Zacatecas"
            Case 32
                entidad = "Nacido en el extranjero"
            Case Else
                entidad = "Número de estado no válido"
        End Select

        Return entidad
    End Function

    Public Function esmayordeedad(curp)

        Dim año_nacimiento As String
        Dim mayor_edad As Boolean

        año_nacimiento = Val(Mid(curp, 3, 2))

        If año_nacimiento < 6 Then
            mayor_edad = False
        Else
            mayor_edad = True
        End If

        Return mayor_edad


    End Function

    Public Function N_estadocivl(estadocivil)

        Dim e_civil As Integer

        Select Case estadocivil
            Case "casado"
                e_civil = 0
            Case "divorciado"
                e_civil = 1
            Case "viudo"
                e_civil = 2
            Case "soltero"
                e_civil = 3
            Case "otro"
                e_civil = 4
        End Select

        Return e_civil
    End Function

    Public Function EstadoCivil(num)
        Dim estado_civil As String = ""

        Select Case num
            Case 0
                estado_civil = "Casado"
            Case 1
                estado_civil = "Divorciado"
            Case 2
                estado_civil = "Viudo"
            Case 3
                estado_civil = "Soltero"
            Case 4
                estado_civil = "Otro"
        End Select

        Return estado_civil

    End Function


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        Dim array_ecivil(4) As Integer
        Dim num As Integer

        For i As Integer = 0 To contador - 1
            num = N_estadocivl(array(i, 6))
            array_ecivil(num) += 1
        Next



        Dim columna_EstadoCivil As New DataGridViewTextBoxColumn()
        Dim columna_Porcentaje As New DataGridViewTextBoxColumn()

        columna_EstadoCivil.HeaderText = "Estado Civil"
        columna_EstadoCivil.DataPropertyName = "Estado Civil"
        columna_EstadoCivil.Width = 80

        columna_Porcentaje.HeaderText = "%"
        columna_Porcentaje.DataPropertyName = "%"
        columna_Porcentaje.Width = 80

        Me.DataGridView1.Columns.Add(columna_EstadoCivil)
        Me.DataGridView1.Columns.Add(columna_Porcentaje)

        For i As Integer = 0 To 4
            DataGridView1.Rows.Add(EstadoCivil(i), array_ecivil(i))
        Next

    End Sub
End Class