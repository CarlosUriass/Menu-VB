<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JAPAF
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
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtb_anterior = New TextBox()
        txtb_actual = New TextBox()
        Button1 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        lbl_drenaje = New Label()
        lbl_sanamiento = New Label()
        lbl_total = New Label()
        txtb_precio = New TextBox()
        labelprecio = New Label()
        lbl_agua = New Label()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(42, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 20)
        Label1.TabIndex = 1
        Label1.Text = "NOMBRE DEL USUARIO:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(258, 36)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(187, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(42, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(208, 20)
        Label2.TabIndex = 3
        Label2.Text = "M**3 (LECTURA ANTERIOR)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(42, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 20)
        Label3.TabIndex = 4
        Label3.Text = "M**3 (LECTURA ACTUAL)"
        ' 
        ' txtb_anterior
        ' 
        txtb_anterior.Location = New Point(258, 76)
        txtb_anterior.Name = "txtb_anterior"
        txtb_anterior.Size = New Size(187, 23)
        txtb_anterior.TabIndex = 5
        ' 
        ' txtb_actual
        ' 
        txtb_actual.Location = New Point(258, 114)
        txtb_actual.Name = "txtb_actual"
        txtb_actual.Size = New Size(187, 23)
        txtb_actual.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(258, 161)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 38)
        Button1.TabIndex = 7
        Button1.Text = "CALCULAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(59, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 20)
        Label4.TabIndex = 8
        Label4.Text = "CUOTA DRENAJE:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(59, 300)
        Label5.Name = "Label5"
        Label5.Size = New Size(166, 20)
        Label5.TabIndex = 9
        Label5.Text = "CUOTA SANAMIENTO:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(203, 376)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 20)
        Label7.TabIndex = 11
        Label7.Text = "TOTAL A PAGAR:"
        ' 
        ' lbl_drenaje
        ' 
        lbl_drenaje.AutoSize = True
        lbl_drenaje.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_drenaje.Location = New Point(258, 269)
        lbl_drenaje.Name = "lbl_drenaje"
        lbl_drenaje.Size = New Size(0, 20)
        lbl_drenaje.TabIndex = 12
        ' 
        ' lbl_sanamiento
        ' 
        lbl_sanamiento.AutoSize = True
        lbl_sanamiento.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_sanamiento.Location = New Point(258, 300)
        lbl_sanamiento.Name = "lbl_sanamiento"
        lbl_sanamiento.Size = New Size(0, 20)
        lbl_sanamiento.TabIndex = 13
        ' 
        ' lbl_total
        ' 
        lbl_total.AutoSize = True
        lbl_total.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_total.Location = New Point(359, 376)
        lbl_total.Name = "lbl_total"
        lbl_total.Size = New Size(0, 20)
        lbl_total.TabIndex = 15
        ' 
        ' txtb_precio
        ' 
        txtb_precio.Location = New Point(601, 415)
        txtb_precio.Name = "txtb_precio"
        txtb_precio.Size = New Size(187, 23)
        txtb_precio.TabIndex = 17
        ' 
        ' labelprecio
        ' 
        labelprecio.AutoSize = True
        labelprecio.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelprecio.Location = New Point(459, 421)
        labelprecio.Name = "labelprecio"
        labelprecio.Size = New Size(136, 20)
        labelprecio.TabIndex = 16
        labelprecio.Text = "PRECIO POR M**3"
        ' 
        ' lbl_agua
        ' 
        lbl_agua.AutoSize = True
        lbl_agua.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_agua.Location = New Point(258, 236)
        lbl_agua.Name = "lbl_agua"
        lbl_agua.Size = New Size(0, 20)
        lbl_agua.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(59, 236)
        Label9.Name = "Label9"
        Label9.Size = New Size(127, 20)
        Label9.TabIndex = 18
        Label9.Text = "IMPORTE AGUA:"
        ' 
        ' JAPAF
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbl_agua)
        Controls.Add(Label9)
        Controls.Add(txtb_precio)
        Controls.Add(labelprecio)
        Controls.Add(lbl_total)
        Controls.Add(lbl_sanamiento)
        Controls.Add(lbl_drenaje)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(txtb_actual)
        Controls.Add(txtb_anterior)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "JAPAF"
        Text = "JAPAF"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtb_anterior As TextBox
    Friend WithEvents txtb_actual As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_drenaje As Label
    Friend WithEvents lbl_sanamiento As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents txtb_precio As TextBox
    Friend WithEvents labelprecio As Label
    Friend WithEvents lbl_agua As Label
    Friend WithEvents Label9 As Label
End Class
