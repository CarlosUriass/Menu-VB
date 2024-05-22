<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HorasExtras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtb_horas = New TextBox()
        txtb_precio = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Horas_trabajadas = New DataGridViewTextBoxColumn()
        Horas_normales = New DataGridViewTextBoxColumn()
        Horas_extra_dobles = New DataGridViewTextBoxColumn()
        Horas_extras_triples = New DataGridViewTextBoxColumn()
        Sueldo_bruto = New DataGridViewTextBoxColumn()
        impuestos = New DataGridViewTextBoxColumn()
        Sueldo_neto = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(212, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 15)
        Label1.TabIndex = 0
        Label1.Text = "HORAS TRABAJADAS:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(212, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 15)
        Label2.TabIndex = 1
        Label2.Text = "PRECIO POR HORA:"
        ' 
        ' txtb_horas
        ' 
        txtb_horas.Location = New Point(357, 55)
        txtb_horas.Name = "txtb_horas"
        txtb_horas.Size = New Size(156, 23)
        txtb_horas.TabIndex = 2
        ' 
        ' txtb_precio
        ' 
        txtb_precio.Location = New Point(357, 94)
        txtb_precio.Name = "txtb_precio"
        txtb_precio.Size = New Size(156, 23)
        txtb_precio.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(329, 143)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 33)
        Button1.TabIndex = 4
        Button1.Text = "CALCULAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Horas_trabajadas, Horas_normales, Horas_extra_dobles, Horas_extras_triples, Sueldo_bruto, impuestos, Sueldo_neto})
        DataGridView1.Location = New Point(36, 230)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(740, 150)
        DataGridView1.TabIndex = 5
        ' 
        ' Horas_trabajadas
        ' 
        Horas_trabajadas.HeaderText = "Horas Trabajadas"
        Horas_trabajadas.Name = "Horas_trabajadas"
        Horas_trabajadas.ReadOnly = True
        ' 
        ' Horas_normales
        ' 
        Horas_normales.HeaderText = "Horas Normales"
        Horas_normales.Name = "Horas_normales"
        Horas_normales.ReadOnly = True
        ' 
        ' Horas_extra_dobles
        ' 
        Horas_extra_dobles.HeaderText = "Horas Extras (dobles)"
        Horas_extra_dobles.Name = "Horas_extra_dobles"
        Horas_extra_dobles.ReadOnly = True
        ' 
        ' Horas_extras_triples
        ' 
        Horas_extras_triples.HeaderText = "Horas Extras Triples"
        Horas_extras_triples.Name = "Horas_extras_triples"
        Horas_extras_triples.ReadOnly = True
        ' 
        ' Sueldo_bruto
        ' 
        Sueldo_bruto.HeaderText = "Sueldo Bruto"
        Sueldo_bruto.Name = "Sueldo_bruto"
        Sueldo_bruto.ReadOnly = True
        ' 
        ' impuestos
        ' 
        impuestos.HeaderText = "Impuestos"
        impuestos.Name = "impuestos"
        impuestos.ReadOnly = True
        ' 
        ' Sueldo_neto
        ' 
        Sueldo_neto.HeaderText = "Sueldo Neto"
        Sueldo_neto.Name = "Sueldo_neto"
        Sueldo_neto.ReadOnly = True
        ' 
        ' HorasExtras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(txtb_precio)
        Controls.Add(txtb_horas)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "HorasExtras"
        Text = "HorasExtras"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtb_horas As TextBox
    Friend WithEvents txtb_precio As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Horas_trabajadas As DataGridViewTextBoxColumn
    Friend WithEvents Horas_normales As DataGridViewTextBoxColumn
    Friend WithEvents Horas_extra_dobles As DataGridViewTextBoxColumn
    Friend WithEvents Horas_extras_triples As DataGridViewTextBoxColumn
    Friend WithEvents Sueldo_bruto As DataGridViewTextBoxColumn
    Friend WithEvents impuestos As DataGridViewTextBoxColumn
    Friend WithEvents Sueldo_neto As DataGridViewTextBoxColumn
End Class
