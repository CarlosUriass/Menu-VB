Public Class Abarrotes
    Dim vendedor As Integer
    Dim importe As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtb_nota.Text < 0 Then
            MsgBox("No se permiten notas menores a 0")
            txtb_nota.Text = ""
            Return
        End If

        If txb_vendedor.Text > 30 Then
            MsgBox("La clave del vendedor debe ser menor a 30")
            txb_vendedor.Text = ""
            Return
        End If

        If txtb_importe.Text < 0 Then
            MsgBox("El importe no se puede ser menor de 0")
        End If

        vendedor = txb_vendedor.Text
        importe = txtb_importe.Text

        If rb_credito.Checked = True Then
            DataGridView1.Rows(vendedor - 1).Cells(1).Value = importe
            DataGridView1.Rows(vendedor - 1).Cells(3).Value = importe * 0.015
        End If

        If rb_efectivo.Checked = True Then
            DataGridView1.Rows(vendedor - 1).Cells(1).Value = importe
            DataGridView1.Rows(vendedor - 1).Cells(2).Value = importe * 0.02
        End If

    End Sub

    Sub generartabla()
        For i As Integer = 1 To 30 
            Me.DataGridView1.Rows.Add(i, 0, 0, 0)
        Next
    End Sub

    Private Sub Abarrotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generartabla()
    End Sub
End Class