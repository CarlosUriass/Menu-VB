<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Triangulo
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
        Label2 = New Label()
        Label1 = New Label()
        base_txtb = New TextBox()
        altura_txtb = New TextBox()
        Label3 = New Label()
        lbl_area = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(110, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 21)
        Label2.TabIndex = 1
        Label2.Text = "INGRESE LA ALTURA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(110, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 21)
        Label1.TabIndex = 2
        Label1.Text = "INGRESE LA BASE"
        ' 
        ' base_txtb
        ' 
        base_txtb.Location = New Point(278, 130)
        base_txtb.Name = "base_txtb"
        base_txtb.Size = New Size(174, 23)
        base_txtb.TabIndex = 3
        ' 
        ' altura_txtb
        ' 
        altura_txtb.Location = New Point(279, 209)
        altura_txtb.Name = "altura_txtb"
        altura_txtb.Size = New Size(174, 23)
        altura_txtb.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(110, 333)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 21)
        Label3.TabIndex = 5
        Label3.Text = "AREA DEL TRIANGULO:"
        ' 
        ' lbl_area
        ' 
        lbl_area.AutoSize = True
        lbl_area.Location = New Point(315, 339)
        lbl_area.Name = "lbl_area"
        lbl_area.Size = New Size(27, 15)
        lbl_area.TabIndex = 6
        lbl_area.Text = "____"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(278, 266)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 42)
        Button1.TabIndex = 7
        Button1.Text = "CALCULAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(644, 409)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 8
        Button2.Text = "Salir"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Triangulo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lbl_area)
        Controls.Add(Label3)
        Controls.Add(altura_txtb)
        Controls.Add(base_txtb)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "Triangulo"
        Text = "Triangulo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents base_txtb As TextBox
    Friend WithEvents altura_txtb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_area As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
