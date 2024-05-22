<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jornaleros
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
        txtb_curp = New TextBox()
        txtb_nombre = New TextBox()
        txtb_primerap = New TextBox()
        txtb_segundoap = New TextBox()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        rb_otro = New RadioButton()
        rb_viudo = New RadioButton()
        rb_divorciado = New RadioButton()
        rb_casado = New RadioButton()
        rb_soltero = New RadioButton()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(232, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 0
        Label1.Text = "CURP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(232, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 1
        Label2.Text = "NOMBRE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(232, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 15)
        Label3.TabIndex = 2
        Label3.Text = "PRIMER APELLIDO:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(232, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 15)
        Label4.TabIndex = 3
        Label4.Text = "SEGUNDO APELLIDO"
        ' 
        ' txtb_curp
        ' 
        txtb_curp.Location = New Point(360, 21)
        txtb_curp.Name = "txtb_curp"
        txtb_curp.Size = New Size(138, 23)
        txtb_curp.TabIndex = 4
        ' 
        ' txtb_nombre
        ' 
        txtb_nombre.Location = New Point(360, 50)
        txtb_nombre.Name = "txtb_nombre"
        txtb_nombre.Size = New Size(138, 23)
        txtb_nombre.TabIndex = 5
        ' 
        ' txtb_primerap
        ' 
        txtb_primerap.Location = New Point(360, 85)
        txtb_primerap.Name = "txtb_primerap"
        txtb_primerap.Size = New Size(138, 23)
        txtb_primerap.TabIndex = 6
        ' 
        ' txtb_segundoap
        ' 
        txtb_segundoap.Location = New Point(360, 116)
        txtb_segundoap.Name = "txtb_segundoap"
        txtb_segundoap.Size = New Size(138, 23)
        txtb_segundoap.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(360, 234)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "CAPTURAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rb_otro)
        GroupBox1.Controls.Add(rb_viudo)
        GroupBox1.Controls.Add(rb_divorciado)
        GroupBox1.Controls.Add(rb_casado)
        GroupBox1.Controls.Add(rb_soltero)
        GroupBox1.Location = New Point(121, 145)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(540, 83)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "ESTADO CIVIL"
        ' 
        ' rb_otro
        ' 
        rb_otro.AutoSize = True
        rb_otro.Location = New Point(432, 32)
        rb_otro.Name = "rb_otro"
        rb_otro.Size = New Size(55, 19)
        rb_otro.TabIndex = 4
        rb_otro.TabStop = True
        rb_otro.Text = "OTRO"
        rb_otro.UseVisualStyleBackColor = True
        ' 
        ' rb_viudo
        ' 
        rb_viudo.AutoSize = True
        rb_viudo.Location = New Point(329, 32)
        rb_viudo.Name = "rb_viudo"
        rb_viudo.Size = New Size(60, 19)
        rb_viudo.TabIndex = 3
        rb_viudo.TabStop = True
        rb_viudo.Text = "VIUDO"
        rb_viudo.UseVisualStyleBackColor = True
        ' 
        ' rb_divorciado
        ' 
        rb_divorciado.AutoSize = True
        rb_divorciado.Location = New Point(226, 32)
        rb_divorciado.Name = "rb_divorciado"
        rb_divorciado.Size = New Size(95, 19)
        rb_divorciado.TabIndex = 2
        rb_divorciado.TabStop = True
        rb_divorciado.Text = "DIVORCIADO"
        rb_divorciado.UseVisualStyleBackColor = True
        ' 
        ' rb_casado
        ' 
        rb_casado.AutoSize = True
        rb_casado.Location = New Point(123, 32)
        rb_casado.Name = "rb_casado"
        rb_casado.Size = New Size(72, 19)
        rb_casado.TabIndex = 1
        rb_casado.TabStop = True
        rb_casado.Text = "CASADO"
        rb_casado.UseVisualStyleBackColor = True
        ' 
        ' rb_soltero
        ' 
        rb_soltero.AutoSize = True
        rb_soltero.Location = New Point(8, 32)
        rb_soltero.Name = "rb_soltero"
        rb_soltero.Size = New Size(73, 19)
        rb_soltero.TabIndex = 0
        rb_soltero.TabStop = True
        rb_soltero.Text = "SOLTERO"
        rb_soltero.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(80, 288)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(639, 150)
        DataGridView1.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(84, 260)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 23)
        Button2.TabIndex = 11
        Button2.Text = "MOSTRAR DATOS"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(208, 260)
        Button3.Name = "Button3"
        Button3.Size = New Size(86, 23)
        Button3.TabIndex = 12
        Button3.Text = "% SEXO"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(300, 260)
        Button4.Name = "Button4"
        Button4.Size = New Size(87, 23)
        Button4.TabIndex = 13
        Button4.Text = "EDAD"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(393, 260)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 14
        Button5.Text = "ESTADO"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(474, 260)
        Button6.Name = "Button6"
        Button6.Size = New Size(92, 23)
        Button6.TabIndex = 15
        Button6.Text = "ESTADO CIVIL"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Jornaleros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Controls.Add(txtb_segundoap)
        Controls.Add(txtb_primerap)
        Controls.Add(txtb_nombre)
        Controls.Add(txtb_curp)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Jornaleros"
        Text = "Jornaleros"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtb_curp As TextBox
    Friend WithEvents txtb_nombre As TextBox
    Friend WithEvents txtb_primerap As TextBox
    Friend WithEvents txtb_segundoap As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_otro As RadioButton
    Friend WithEvents rb_viudo As RadioButton
    Friend WithEvents rb_divorciado As RadioButton
    Friend WithEvents rb_casado As RadioButton
    Friend WithEvents rb_soltero As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
