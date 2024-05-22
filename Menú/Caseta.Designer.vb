<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caseta
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
        GroupBox1 = New GroupBox()
        rb_camion5 = New RadioButton()
        rb_camion3 = New RadioButton()
        rb_auto = New RadioButton()
        rb_moto = New RadioButton()
        Button1 = New Button()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        rb_IAVE = New RadioButton()
        rb_efectivo = New RadioButton()
        GroupBox3 = New GroupBox()
        rb_residente = New RadioButton()
        rb_normal = New RadioButton()
        DataGridView1 = New DataGridView()
        Vehiculo = New DataGridViewTextBoxColumn()
        Unidades = New DataGridViewTextBoxColumn()
        Importe_normal = New DataGridViewTextBoxColumn()
        Importe_residente = New DataGridViewTextBoxColumn()
        Efectivo = New DataGridViewTextBoxColumn()
        IAVE = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rb_camion5)
        GroupBox1.Controls.Add(rb_camion3)
        GroupBox1.Controls.Add(rb_auto)
        GroupBox1.Controls.Add(rb_moto)
        GroupBox1.Location = New Point(78, 22)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(595, 100)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "TIPO DE VEHICULO"
        ' 
        ' rb_camion5
        ' 
        rb_camion5.AutoSize = True
        rb_camion5.Location = New Point(446, 42)
        rb_camion5.Name = "rb_camion5"
        rb_camion5.Size = New Size(115, 19)
        rb_camion5.TabIndex = 3
        rb_camion5.TabStop = True
        rb_camion5.Text = "CAMION >3 EJES"
        rb_camion5.UseVisualStyleBackColor = True
        ' 
        ' rb_camion3
        ' 
        rb_camion3.AutoSize = True
        rb_camion3.Location = New Point(310, 42)
        rb_camion3.Name = "rb_camion3"
        rb_camion3.Size = New Size(115, 19)
        rb_camion3.TabIndex = 2
        rb_camion3.TabStop = True
        rb_camion3.Text = "CAMION <3 EJES"
        rb_camion3.UseVisualStyleBackColor = True
        ' 
        ' rb_auto
        ' 
        rb_auto.AutoSize = True
        rb_auto.Location = New Point(170, 42)
        rb_auto.Name = "rb_auto"
        rb_auto.Size = New Size(91, 19)
        rb_auto.TabIndex = 1
        rb_auto.TabStop = True
        rb_auto.Text = "AUTOMOVIL"
        rb_auto.UseVisualStyleBackColor = True
        ' 
        ' rb_moto
        ' 
        rb_moto.AutoSize = True
        rb_moto.Location = New Point(42, 42)
        rb_moto.Name = "rb_moto"
        rb_moto.Size = New Size(102, 19)
        rb_moto.TabIndex = 0
        rb_moto.TabStop = True
        rb_moto.Text = "MOTOCICLETA"
        rb_moto.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(340, 367)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "PAGAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(78, 402)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 15)
        Label1.TabIndex = 2
        Label1.Text = "TOTAL A PAGAR:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rb_IAVE)
        GroupBox2.Controls.Add(rb_efectivo)
        GroupBox2.Location = New Point(78, 128)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(595, 100)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "FORMA DE PAGO"
        ' 
        ' rb_IAVE
        ' 
        rb_IAVE.AutoSize = True
        rb_IAVE.Location = New Point(310, 42)
        rb_IAVE.Name = "rb_IAVE"
        rb_IAVE.Size = New Size(48, 19)
        rb_IAVE.TabIndex = 2
        rb_IAVE.TabStop = True
        rb_IAVE.Text = "IAVE"
        rb_IAVE.UseVisualStyleBackColor = True
        ' 
        ' rb_efectivo
        ' 
        rb_efectivo.AutoSize = True
        rb_efectivo.Location = New Point(170, 42)
        rb_efectivo.Name = "rb_efectivo"
        rb_efectivo.Size = New Size(76, 19)
        rb_efectivo.TabIndex = 1
        rb_efectivo.TabStop = True
        rb_efectivo.Text = "EFECTIVO"
        rb_efectivo.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(rb_residente)
        GroupBox3.Controls.Add(rb_normal)
        GroupBox3.Location = New Point(78, 234)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(595, 100)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "USUARIO"
        ' 
        ' rb_residente
        ' 
        rb_residente.AutoSize = True
        rb_residente.Location = New Point(310, 42)
        rb_residente.Name = "rb_residente"
        rb_residente.Size = New Size(82, 19)
        rb_residente.TabIndex = 2
        rb_residente.TabStop = True
        rb_residente.Text = "RESIDENTE"
        rb_residente.UseVisualStyleBackColor = True
        ' 
        ' rb_normal
        ' 
        rb_normal.AutoSize = True
        rb_normal.Location = New Point(170, 42)
        rb_normal.Name = "rb_normal"
        rb_normal.Size = New Size(75, 19)
        rb_normal.TabIndex = 1
        rb_normal.TabStop = True
        rb_normal.Text = "NORMAL"
        rb_normal.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Vehiculo, Unidades, Importe_normal, Importe_residente, Efectivo, IAVE})
        DataGridView1.Location = New Point(78, 432)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(656, 150)
        DataGridView1.TabIndex = 5
        ' 
        ' Vehiculo
        ' 
        Vehiculo.HeaderText = "Tipo de vehiculo"
        Vehiculo.Name = "Vehiculo"
        Vehiculo.ReadOnly = True
        ' 
        ' Unidades
        ' 
        Unidades.HeaderText = "Unidades"
        Unidades.Name = "Unidades"
        Unidades.ReadOnly = True
        ' 
        ' Importe_normal
        ' 
        Importe_normal.HeaderText = "Importe pago normal"
        Importe_normal.Name = "Importe_normal"
        Importe_normal.ReadOnly = True
        ' 
        ' Importe_residente
        ' 
        Importe_residente.HeaderText = "pago residente"
        Importe_residente.Name = "Importe_residente"
        Importe_residente.ReadOnly = True
        ' 
        ' Efectivo
        ' 
        Efectivo.HeaderText = "Efectivo"
        Efectivo.Name = "Efectivo"
        Efectivo.ReadOnly = True
        ' 
        ' IAVE
        ' 
        IAVE.HeaderText = "iave"
        IAVE.Name = "IAVE"
        IAVE.ReadOnly = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(181, 402)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 6
        ' 
        ' Caseta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(902, 606)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Name = "Caseta"
        Text = "Caseta"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_camion5 As RadioButton
    Friend WithEvents rb_camion3 As RadioButton
    Friend WithEvents rb_auto As RadioButton
    Friend WithEvents rb_moto As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_IAVE As RadioButton
    Friend WithEvents rb_efectivo As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rb_residente As RadioButton
    Friend WithEvents rb_normal As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Vehiculo As DataGridViewTextBoxColumn
    Friend WithEvents Unidades As DataGridViewTextBoxColumn
    Friend WithEvents Importe_normal As DataGridViewTextBoxColumn
    Friend WithEvents Importe_residente As DataGridViewTextBoxColumn
    Friend WithEvents Efectivo As DataGridViewTextBoxColumn
    Friend WithEvents IAVE As DataGridViewTextBoxColumn
End Class
