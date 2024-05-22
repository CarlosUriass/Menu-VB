<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SinaloaA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ListBox1 = New ListBox()
        importe_txt = New TextBox()
        btn1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        municipio_cbx = New ComboBox()
        rubro_cbx = New ComboBox()
        Label3 = New Label()
        mes_cbx = New Label()
        cbx_mes = New ComboBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(41, 313)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(692, 109)
        ListBox1.TabIndex = 0
        ' 
        ' importe_txt
        ' 
        importe_txt.Location = New Point(178, 142)
        importe_txt.Name = "importe_txt"
        importe_txt.Size = New Size(199, 23)
        importe_txt.TabIndex = 3
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(132, 231)
        btn1.Name = "btn1"
        btn1.Size = New Size(127, 43)
        btn1.TabIndex = 4
        btn1.Text = "CAPTURAR"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(80, 145)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 3
        Label1.Text = "IMPORTE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(80, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 4
        Label2.Text = "MUNICIPIO"
        ' 
        ' municipio_cbx
        ' 
        municipio_cbx.FormattingEnabled = True
        municipio_cbx.Items.AddRange(New Object() {"Ahome", "Angostura", "Badiraguato", "Choix", "Concordia", "Cosalá", "Culiacán", "El Fuerte", "Elota", "Escuinapa", "Guasave", "Mazatlán", "Mocorito", "Navolato", "Rosario", "Salvador Alvarado", "San Ignacio", "Sinaloa"})
        municipio_cbx.Location = New Point(178, 34)
        municipio_cbx.Name = "municipio_cbx"
        municipio_cbx.Size = New Size(199, 23)
        municipio_cbx.TabIndex = 1
        ' 
        ' rubro_cbx
        ' 
        rubro_cbx.FormattingEnabled = True
        rubro_cbx.Items.AddRange(New Object() {"SALUD", "EDUCACION", "SEGURIDAD", "CULTURA", "TURISMO", "ECONOMIA"})
        rubro_cbx.Location = New Point(178, 85)
        rubro_cbx.Name = "rubro_cbx"
        rubro_cbx.Size = New Size(199, 23)
        rubro_cbx.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(80, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 7
        Label3.Text = "RUBRO"
        ' 
        ' mes_cbx
        ' 
        mes_cbx.AutoSize = True
        mes_cbx.Location = New Point(80, 190)
        mes_cbx.Name = "mes_cbx"
        mes_cbx.Size = New Size(30, 15)
        mes_cbx.TabIndex = 8
        mes_cbx.Text = "MES"
        ' 
        ' cbx_mes
        ' 
        cbx_mes.FormattingEnabled = True
        cbx_mes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        cbx_mes.Location = New Point(178, 187)
        cbx_mes.Name = "cbx_mes"
        cbx_mes.Size = New Size(199, 23)
        cbx_mes.TabIndex = 4
        ' 

        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(821, 468)
        Controls.Add(cbx_mes)
        Controls.Add(mes_cbx)
        Controls.Add(Label3)
        Controls.Add(rubro_cbx)
        Controls.Add(municipio_cbx)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn1)
        Controls.Add(importe_txt)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents importe_txt As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents municipio_cbx As ComboBox
    Friend WithEvents rubro_cbx As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mes_cbx As Label
    Friend WithEvents cbx_mes As ComboBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
