<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calificaciones
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
        Label4 = New Label()
        Button1 = New Button()
        lbl_result = New Label()
        txtb_parcial1 = New TextBox()
        txtb_parcial2 = New TextBox()
        txtb_parcial3 = New TextBox()
        txtb_nombre = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(57, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre del alumo:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(57, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 1
        Label2.Text = "PARCIAL 1:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(57, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 20)
        Label3.TabIndex = 2
        Label3.Text = "PARCIAL 2:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(57, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 20)
        Label4.TabIndex = 3
        Label4.Text = "PARCIAL 3:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(309, 216)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 45)
        Button1.TabIndex = 4
        Button1.Text = "CALCULAR PROMEDIO"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lbl_result
        ' 
        lbl_result.AutoSize = True
        lbl_result.Location = New Point(74, 293)
        lbl_result.Name = "lbl_result"
        lbl_result.Size = New Size(0, 15)
        lbl_result.TabIndex = 5
        ' 
        ' txtb_parcial1
        ' 
        txtb_parcial1.Location = New Point(158, 85)
        txtb_parcial1.Name = "txtb_parcial1"
        txtb_parcial1.Size = New Size(110, 23)
        txtb_parcial1.TabIndex = 6
        ' 
        ' txtb_parcial2
        ' 
        txtb_parcial2.Location = New Point(158, 125)
        txtb_parcial2.Name = "txtb_parcial2"
        txtb_parcial2.Size = New Size(110, 23)
        txtb_parcial2.TabIndex = 7
        ' 
        ' txtb_parcial3
        ' 
        txtb_parcial3.Location = New Point(158, 175)
        txtb_parcial3.Name = "txtb_parcial3"
        txtb_parcial3.Size = New Size(110, 23)
        txtb_parcial3.TabIndex = 8
        ' 
        ' txtb_nombre
        ' 
        txtb_nombre.Location = New Point(207, 34)
        txtb_nombre.Name = "txtb_nombre"
        txtb_nombre.Size = New Size(213, 23)
        txtb_nombre.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(700, 403)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 10
        Button2.Text = "SALIR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' calificaciones
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(txtb_nombre)
        Controls.Add(txtb_parcial3)
        Controls.Add(txtb_parcial2)
        Controls.Add(txtb_parcial1)
        Controls.Add(lbl_result)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "calificaciones"
        Text = "calificaciones"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_result As Label
    Friend WithEvents txtb_parcial1 As TextBox
    Friend WithEvents txtb_parcial2 As TextBox
    Friend WithEvents txtb_parcial3 As TextBox
    Friend WithEvents txtb_nombre As TextBox
    Friend WithEvents Button2 As Button
End Class
