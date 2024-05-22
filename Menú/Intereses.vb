Imports System.DirectoryServices.ActiveDirectory

Public Class Intereses
    Dim tasa, monto As Double
    Dim meses As Integer
    Dim intereses As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        monto = txtb_monto.Text
        tasa = txtb_tasa.Text
        meses = txtb_tiempo.Text

        DataGridView1.Rows.Clear()

        generar_celdas(meses)



        For i As Integer = 0 To meses - 1
            DataGridView1.Rows(i).Cells(1).Value = monto

            intereses = Math.Round(monto * (tasa / 100), 2)
            DataGridView1.Rows(i).Cells(2).Value = intereses

            monto = Math.Round(intereses + monto, 2)
            DataGridView1.Rows(i).Cells(3).Value = monto
        Next

    End Sub


    Public Function generar_celdas(meses)
        For i As Integer = 1 To meses
            Me.DataGridView1.Rows.Add(i, 0, 0, 0)
        Next
    End Function

End Class