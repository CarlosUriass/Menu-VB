<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maiz
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
        Label3 = New Label()
        txtb_kg = New TextBox()
        txtb_humedad = New TextBox()
        txtb_precio = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        KG = New DataGridViewTextBoxColumn()
        TONELADAS = New DataGridViewTextBoxColumn()
        HUMEDAD = New DataGridViewTextBoxColumn()
        KGDESCONTADOS = New DataGridViewTextBoxColumn()
        SUBTOTAL = New DataGridViewTextBoxColumn()
        IMPUESTOS = New DataGridViewTextBoxColumn()
        TOTAL = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(178, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 0
        Label1.Text = "KG RECIBIDOS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(178, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 15)
        Label2.TabIndex = 1
        Label2.Text = "% DE HUMEDAD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(178, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 15)
        Label3.TabIndex = 2
        Label3.Text = "PRECIO X TONELADA"
        ' 
        ' txtb_kg
        ' 
        txtb_kg.Location = New Point(303, 72)
        txtb_kg.Name = "txtb_kg"
        txtb_kg.Size = New Size(146, 23)
        txtb_kg.TabIndex = 3
        ' 
        ' txtb_humedad
        ' 
        txtb_humedad.Location = New Point(303, 113)
        txtb_humedad.Name = "txtb_humedad"
        txtb_humedad.Size = New Size(146, 23)
        txtb_humedad.TabIndex = 4
        ' 
        ' txtb_precio
        ' 
        txtb_precio.Location = New Point(303, 157)
        txtb_precio.Name = "txtb_precio"
        txtb_precio.Size = New Size(146, 23)
        txtb_precio.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(303, 202)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 29)
        Button1.TabIndex = 6
        Button1.Text = "CALCULAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {KG, TONELADAS, HUMEDAD, KGDESCONTADOS, SUBTOTAL, IMPUESTOS, TOTAL})
        DataGridView1.Location = New Point(40, 263)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(748, 150)
        DataGridView1.TabIndex = 7
        ' 
        ' KG
        ' 
        KG.HeaderText = "KG"
        KG.Name = "KG"
        KG.ReadOnly = True
        ' 
        ' TONELADAS
        ' 
        TONELADAS.HeaderText = "TONELADAS"
        TONELADAS.Name = "TONELADAS"
        TONELADAS.ReadOnly = True
        ' 
        ' HUMEDAD
        ' 
        HUMEDAD.HeaderText = "% HUMEDAD"
        HUMEDAD.Name = "HUMEDAD"
        HUMEDAD.ReadOnly = True
        ' 
        ' KGDESCONTADOS
        ' 
        KGDESCONTADOS.HeaderText = "KG DESCONTADOS"
        KGDESCONTADOS.Name = "KGDESCONTADOS"
        KGDESCONTADOS.ReadOnly = True
        ' 
        ' SUBTOTAL
        ' 
        SUBTOTAL.HeaderText = "SUBTOTAL"
        SUBTOTAL.Name = "SUBTOTAL"
        SUBTOTAL.ReadOnly = True
        ' 
        ' IMPUESTOS
        ' 
        IMPUESTOS.HeaderText = "IMPUESTOS"
        IMPUESTOS.Name = "IMPUESTOS"
        IMPUESTOS.ReadOnly = True
        ' 
        ' TOTAL
        ' 
        TOTAL.HeaderText = "TOTAL"
        TOTAL.Name = "TOTAL"
        TOTAL.ReadOnly = True
        ' 
        ' Maiz
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(txtb_precio)
        Controls.Add(txtb_humedad)
        Controls.Add(txtb_kg)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Maiz"
        Text = "Maiz"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtb_kg As TextBox
    Friend WithEvents txtb_humedad As TextBox
    Friend WithEvents txtb_precio As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KG As DataGridViewTextBoxColumn
    Friend WithEvents TONELADAS As DataGridViewTextBoxColumn
    Friend WithEvents HUMEDAD As DataGridViewTextBoxColumn
    Friend WithEvents KGDESCONTADOS As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents IMPUESTOS As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
End Class
