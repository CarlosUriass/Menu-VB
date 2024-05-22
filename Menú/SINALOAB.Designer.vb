<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SINALOAB
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
        ListBox2 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(43, 263)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(644, 139)
        ListBox2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(43, 228)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 29)
        Button1.TabIndex = 2
        Button1.Text = "Filtrar por rubro"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(185, 228)
        Button2.Name = "Button2"
        Button2.Size = New Size(136, 29)
        Button2.TabIndex = 3
        Button2.Text = "Filtrar por municipio"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(327, 228)
        Button3.Name = "Button3"
        Button3.Size = New Size(136, 29)
        Button3.TabIndex = 4
        Button3.Text = "Filtrar por mes"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(469, 228)
        Button4.Name = "Button4"
        Button4.Size = New Size(151, 29)
        Button4.TabIndex = 5
        Button4.Text = "municipio - rubro - mes"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox2)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
