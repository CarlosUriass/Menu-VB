<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intereses
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        txtb_monto = New TextBox()
        Label2 = New Label()
        txtb_tasa = New TextBox()
        Label3 = New Label()
        txtb_tiempo = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        mes = New DataGridViewTextBoxColumn()
        SALDO = New DataGridViewTextBoxColumn()
        interes_generado = New DataGridViewTextBoxColumn()
        Total = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._5114
        PictureBox1.Location = New Point(15, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(137, 56)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(216, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 15)
        Label1.TabIndex = 1
        Label1.Text = "MONTO A INVERTIR:"
        ' 
        ' txtb_monto
        ' 
        txtb_monto.Location = New Point(350, 88)
        txtb_monto.Name = "txtb_monto"
        txtb_monto.Size = New Size(173, 23)
        txtb_monto.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(216, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 15)
        Label2.TabIndex = 3
        Label2.Text = "TASA DE INTERES ( %)"
        ' 
        ' txtb_tasa
        ' 
        txtb_tasa.Location = New Point(350, 127)
        txtb_tasa.Name = "txtb_tasa"
        txtb_tasa.Size = New Size(173, 23)
        txtb_tasa.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(216, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 15)
        Label3.TabIndex = 5
        Label3.Text = "TIEMPO (MESES):"
        ' 
        ' txtb_tiempo
        ' 
        txtb_tiempo.Location = New Point(350, 165)
        txtb_tiempo.Name = "txtb_tiempo"
        txtb_tiempo.Size = New Size(173, 23)
        txtb_tiempo.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(318, 194)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 51)
        Button1.TabIndex = 7
        Button1.Text = "CALCULAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {mes, SALDO, interes_generado, Total})
        DataGridView1.Location = New Point(144, 273)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(561, 150)
        DataGridView1.TabIndex = 8
        ' 
        ' mes
        ' 
        mes.HeaderText = "MES"
        mes.Name = "mes"
        mes.ReadOnly = True
        ' 
        ' SALDO
        ' 
        SALDO.HeaderText = "SALDO"
        SALDO.Name = "SALDO"
        SALDO.ReadOnly = True
        ' 
        ' interes_generado
        ' 
        interes_generado.HeaderText = "INTERES GENERADO"
        interes_generado.Name = "interes_generado"
        interes_generado.ReadOnly = True
        ' 
        ' Total
        ' 
        Total.HeaderText = "TOTAL"
        Total.Name = "Total"
        Total.ReadOnly = True
        ' 
        ' Intereses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(txtb_tiempo)
        Controls.Add(Label3)
        Controls.Add(txtb_tasa)
        Controls.Add(Label2)
        Controls.Add(txtb_monto)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Intereses"
        Text = "Intereses"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtb_monto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtb_tasa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtb_tiempo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents mes As DataGridViewTextBoxColumn
    Friend WithEvents SALDO As DataGridViewTextBoxColumn
    Friend WithEvents interes_generado As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
