Imports System.Security.Cryptography

Public Class Caseta


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim carro_normal, carro_residente, moto_normal, moto_residente, camion_2_normal, camion_2_residente, camion_3_normal, camion_3_residente As Double

        carro_normal = 100
        carro_residente = 15

        moto_normal = 60
        moto_residente = 10

        camion_2_normal = 150
        camion_2_residente = 20

        camion_3_normal = 200
        camion_3_residente = 300

        If rb_auto.Checked = True Then
            If rb_residente.Checked = True Then
                Label2.Text = carro_residente.ToString()
                DataGridView1.Rows(1).Cells(1).Value += 1
                DataGridView1.Rows(1).Cells(3).Value += carro_residente

                If rb_efectivo.Checked = True Then
                    DataGridView1.Rows(1).Cells(4).Value += carro_residente
                Else
                    DataGridView1.Rows(1).Cells(5).Value += carro_residente
                End If

            Else
                Label2.Text = carro_normal.ToString()
                DataGridView1.Rows(1).Cells(1).Value += 1
                DataGridView1.Rows(1).Cells(2).Value += carro_normal

                If rb_efectivo.Checked = True Then
                    DataGridView1.Rows(1).Cells(4).Value += carro_normal
                Else
                    DataGridView1.Rows(1).Cells(5).Value += carro_normal

                End If

            End If
        ElseIf rb_moto.Checked = True Then
            If rb_residente.Checked = True Then
                Label2.Text = moto_residente.ToString()
                DataGridView1.Rows(0).Cells(1).Value += 1
                DataGridView1.Rows(0).Cells(3).Value += moto_residente

                If rb_efectivo.Checked = True Then
                    DataGridView1.Rows(0).Cells(4).Value += moto_residente
                Else
                    DataGridView1.Rows(0).Cells(5).Value += moto_residente

                End If
            Else
                Label2.Text = moto_normal.ToString()
                DataGridView1.Rows(0).Cells(1).Value += 1
                DataGridView1.Rows(0).Cells(2).Value += moto_normal

                If rb_efectivo.Checked = True Then
                    DataGridView1.Rows(0).Cells(4).Value += moto_normal
                Else
                    DataGridView1.Rows(0).Cells(5).Value += moto_normal

                End If

            End If
        ElseIf rb_camion3.Checked = True Then
            If rb_residente.Checked = True Then
                Label2.Text = camion_2_residente.ToString()
                DataGridView1.Rows(2).Cells(1).Value += 1
                DataGridView1.Rows(2).Cells(3).Value += camion_2_residente

                If rb_efectivo.Checked = True Then
                    DataGridView1.Rows(2).Cells(4).Value += camion_2_residente
                Else
                    DataGridView1.Rows(2).Cells(5).Value += camion_2_residente

                End If

            Else
                Label2.Text = camion_2_normal.ToString()
                DataGridView1.Rows(2).Cells(1).Value += 1
                DataGridView1.Rows(2).Cells(2).Value += camion_2_normal

                If rb_efectivo.Checked = True Then
                    DataGridView1.Rows(0).Cells(4).Value += camion_2_normal
                Else
                    DataGridView1.Rows(0).Cells(5).Value += camion_2_normal

                End If


            End If
        ElseIf rb_camion5.Checked = True Then
            If rb_residente.Checked = True Then
                Label2.Text = camion_3_residente.ToString()
                DataGridView1.Rows(3).Cells(1).Value += 1
                DataGridView1.Rows(3).Cells(3).Value += camion_3_residente

                If rb_efectivo.Checked = True Then
                    DataGridView1.Rows(3).Cells(4).Value += camion_3_residente
                Else
                    DataGridView1.Rows(3).Cells(5).Value += camion_3_residente

                End If

            Else
                Label2.Text = camion_3_normal.ToString()
                DataGridView1.Rows(3).Cells(1).Value += 1
                DataGridView1.Rows(3).Cells(2).Value += camion_3_normal


                If rb_efectivo.Checked = True Then
                    DataGridView1.Rows(3).Cells(4).Value += camion_3_normal
                Else
                    DataGridView1.Rows(3).Cells(5).Value += camion_3_normal

                End If

            End If
        End If

        limpiar()
    End Sub

    Public Function limpiar()
        rb_auto.Checked = False
        rb_camion3.Checked = False
        rb_moto.Checked = False
        rb_camion5.Checked = False
        rb_residente.Checked = False
        rb_normal.Checked = False
    End Function

    Private Sub Caseta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.Rows.Add("Motocicleta", 0, 0, 0)
        Me.DataGridView1.Rows.Add("Automovil o pick-up", 0, 0, 0)
        Me.DataGridView1.Rows.Add("Camion 2 o 3 ejes", 0, 0, 0)
        Me.DataGridView1.Rows.Add("Trailer de 3 a 5 ejes", 0, 0, 0)
    End Sub
End Class