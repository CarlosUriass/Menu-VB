<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Velocidad_promedio
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
        txtb_distancia = New TextBox()
        txtb_tiempo = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        lbl_kmh = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(72, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 21)
        Label1.TabIndex = 0
        Label1.Text = "DISTANCIA RECORRIDA (KM): "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(72, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(229, 21)
        Label2.TabIndex = 1
        Label2.Text = "TIEMPO TRANSCURRIDO (H):"
        ' 
        ' txtb_distancia
        ' 
        txtb_distancia.Location = New Point(325, 81)
        txtb_distancia.Name = "txtb_distancia"
        txtb_distancia.Size = New Size(203, 23)
        txtb_distancia.TabIndex = 2
        ' 
        ' txtb_tiempo
        ' 
        txtb_tiempo.Location = New Point(325, 160)
        txtb_tiempo.Name = "txtb_tiempo"
        txtb_tiempo.Size = New Size(203, 23)
        txtb_tiempo.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(301, 236)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 46)
        Button1.TabIndex = 4
        Button1.Text = "CALCULAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(89, 318)
        Label3.Name = "Label3"
        Label3.Size = New Size(242, 21)
        Label3.TabIndex = 5
        Label3.Text = "LA VELOCIDAD PROMEDIO ES: "
        ' 
        ' lbl_kmh
        ' 
        lbl_kmh.AutoSize = True
        lbl_kmh.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_kmh.Location = New Point(337, 318)
        lbl_kmh.Name = "lbl_kmh"
        lbl_kmh.Size = New Size(0, 21)
        lbl_kmh.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(612, 388)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 7
        Button2.Text = "SALIR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Velocidad_promedio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(lbl_kmh)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(txtb_tiempo)
        Controls.Add(txtb_distancia)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Velocidad_promedio"
        Text = "Velocidad promedio"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtb_distancia As TextBox
    Friend WithEvents txtb_tiempo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_kmh As Label
    Friend WithEvents Button2 As Button
End Class
