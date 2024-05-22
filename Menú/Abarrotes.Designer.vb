<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Abarrotes
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
        Label1 = New Label()
        txtb_nota = New TextBox()
        Label2 = New Label()
        txb_vendedor = New TextBox()
        GroupBox1 = New GroupBox()
        rb_credito = New RadioButton()
        rb_efectivo = New RadioButton()
        txtb_importe = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Empleado = New DataGridViewTextBoxColumn()
        credito = New DataGridViewTextBoxColumn()
        contado = New DataGridViewTextBoxColumn()
        comision = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(64, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 0
        Label1.Text = "NOTA DE VENTA"
        ' 
        ' txtb_nota
        ' 
        txtb_nota.Location = New Point(211, 33)
        txtb_nota.Name = "txtb_nota"
        txtb_nota.Size = New Size(100, 23)
        txtb_nota.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(64, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 15)
        Label2.TabIndex = 2
        Label2.Text = "CLAVE VENDEDOR"
        ' 
        ' txb_vendedor
        ' 
        txb_vendedor.Location = New Point(211, 75)
        txb_vendedor.Name = "txb_vendedor"
        txb_vendedor.Size = New Size(100, 23)
        txb_vendedor.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rb_credito)
        GroupBox1.Controls.Add(rb_efectivo)
        GroupBox1.Location = New Point(61, 111)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(316, 75)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "TIPO DE PAGO"
        ' 
        ' rb_credito
        ' 
        rb_credito.AutoSize = True
        rb_credito.Location = New Point(179, 24)
        rb_credito.Name = "rb_credito"
        rb_credito.Size = New Size(71, 19)
        rb_credito.TabIndex = 3
        rb_credito.TabStop = True
        rb_credito.Text = "CREDITO"
        rb_credito.UseVisualStyleBackColor = True
        ' 
        ' rb_efectivo
        ' 
        rb_efectivo.AutoSize = True
        rb_efectivo.Location = New Point(49, 24)
        rb_efectivo.Name = "rb_efectivo"
        rb_efectivo.Size = New Size(76, 19)
        rb_efectivo.TabIndex = 2
        rb_efectivo.TabStop = True
        rb_efectivo.Text = "EFECTIVO"
        rb_efectivo.UseVisualStyleBackColor = True
        ' 
        ' txtb_importe
        ' 
        txtb_importe.Location = New Point(211, 201)
        txtb_importe.Name = "txtb_importe"
        txtb_importe.Size = New Size(100, 23)
        txtb_importe.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(64, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 15)
        Label3.TabIndex = 5
        Label3.Text = "IMPORTE DE LA VENTA:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(165, 242)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 29)
        Button1.TabIndex = 6
        Button1.Text = "CAPTURAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Empleado, credito, contado, comision})
        DataGridView1.Location = New Point(44, 288)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(470, 150)
        DataGridView1.TabIndex = 7
        ' 
        ' Empleado
        ' 
        Empleado.HeaderText = "# DE EMPLEADO"
        Empleado.Name = "Empleado"
        Empleado.ReadOnly = True
        ' 
        ' credito
        ' 
        credito.HeaderText = "VENTAS A CREDITO"
        credito.Name = "credito"
        credito.ReadOnly = True
        ' 
        ' contado
        ' 
        contado.HeaderText = "VENTAS A CONTADO"
        contado.Name = "contado"
        contado.ReadOnly = True
        ' 
        ' comision
        ' 
        comision.HeaderText = "COMISION A PAGAR"
        comision.Name = "comision"
        comision.ReadOnly = True
        ' 
        ' Abarrotes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(txtb_importe)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        Controls.Add(txb_vendedor)
        Controls.Add(Label2)
        Controls.Add(txtb_nota)
        Controls.Add(Label1)
        Name = "Abarrotes"
        Text = "Abarrotes"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtb_nota As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txb_vendedor As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_credito As RadioButton
    Friend WithEvents rb_efectivo As RadioButton
    Friend WithEvents txtb_importe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents credito As DataGridViewTextBoxColumn
    Friend WithEvents contado As DataGridViewTextBoxColumn
    Friend WithEvents comision As DataGridViewTextBoxColumn
End Class
