<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lbTitulo = New Label()
        lbPlataforma = New Label()
        lbEstudio = New Label()
        lbAñoEstreno = New Label()
        lbSpeedrun = New Label()
        lbNombreSpeedrun = New Label()
        btAñadir = New Button()
        btVolver = New Button()
        tbTitulo = New TextBox()
        tbPlataforma = New TextBox()
        tbestudio = New TextBox()
        tbSpeedrun = New TextBox()
        tbSpeedrunner = New TextBox()
        tbAño = New TextBox()
        SuspendLayout()
        ' 
        ' lbTitulo
        ' 
        lbTitulo.AutoSize = True
        lbTitulo.Location = New Point(84, 79)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.Size = New Size(50, 20)
        lbTitulo.TabIndex = 0
        lbTitulo.Text = "Titulo:"
        ' 
        ' lbPlataforma
        ' 
        lbPlataforma.AutoSize = True
        lbPlataforma.Location = New Point(84, 159)
        lbPlataforma.Name = "lbPlataforma"
        lbPlataforma.Size = New Size(85, 20)
        lbPlataforma.TabIndex = 1
        lbPlataforma.Text = "Plataforma:"
        ' 
        ' lbEstudio
        ' 
        lbEstudio.AutoSize = True
        lbEstudio.Location = New Point(84, 249)
        lbEstudio.Name = "lbEstudio"
        lbEstudio.Size = New Size(153, 20)
        lbEstudio.TabIndex = 2
        lbEstudio.Text = "Estudio de desarrollo:"
        ' 
        ' lbAñoEstreno
        ' 
        lbAñoEstreno.AutoSize = True
        lbAñoEstreno.Location = New Point(558, 240)
        lbAñoEstreno.Name = "lbAñoEstreno"
        lbAñoEstreno.Size = New Size(113, 20)
        lbAñoEstreno.TabIndex = 3
        lbAñoEstreno.Text = "Año de estreno:"
        ' 
        ' lbSpeedrun
        ' 
        lbSpeedrun.AutoSize = True
        lbSpeedrun.Location = New Point(558, 79)
        lbSpeedrun.Name = "lbSpeedrun"
        lbSpeedrun.Size = New Size(149, 20)
        lbSpeedrun.TabIndex = 4
        lbSpeedrun.Text = "Tiempo de speedrun:"
        ' 
        ' lbNombreSpeedrun
        ' 
        lbNombreSpeedrun.AutoSize = True
        lbNombreSpeedrun.Location = New Point(558, 159)
        lbNombreSpeedrun.Name = "lbNombreSpeedrun"
        lbNombreSpeedrun.Size = New Size(96, 20)
        lbNombreSpeedrun.TabIndex = 5
        lbNombreSpeedrun.Text = "Speedrunner:"
        ' 
        ' btAñadir
        ' 
        btAñadir.Location = New Point(430, 377)
        btAñadir.Name = "btAñadir"
        btAñadir.Size = New Size(131, 55)
        btAñadir.TabIndex = 6
        btAñadir.Text = "AÑADIR"
        btAñadir.UseVisualStyleBackColor = True
        ' 
        ' btVolver
        ' 
        btVolver.Location = New Point(654, 377)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(136, 55)
        btVolver.TabIndex = 7
        btVolver.Text = "VOLVER"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' tbTitulo
        ' 
        tbTitulo.Location = New Point(256, 76)
        tbTitulo.Name = "tbTitulo"
        tbTitulo.Size = New Size(125, 27)
        tbTitulo.TabIndex = 8
        ' 
        ' tbPlataforma
        ' 
        tbPlataforma.Location = New Point(256, 159)
        tbPlataforma.Name = "tbPlataforma"
        tbPlataforma.Size = New Size(125, 27)
        tbPlataforma.TabIndex = 9
        ' 
        ' tbestudio
        ' 
        tbestudio.Location = New Point(256, 246)
        tbestudio.Name = "tbestudio"
        tbestudio.Size = New Size(125, 27)
        tbestudio.TabIndex = 10
        ' 
        ' tbSpeedrun
        ' 
        tbSpeedrun.Location = New Point(751, 79)
        tbSpeedrun.Name = "tbSpeedrun"
        tbSpeedrun.Size = New Size(125, 27)
        tbSpeedrun.TabIndex = 11
        ' 
        ' tbSpeedrunner
        ' 
        tbSpeedrunner.Location = New Point(751, 156)
        tbSpeedrunner.Name = "tbSpeedrunner"
        tbSpeedrunner.Size = New Size(125, 27)
        tbSpeedrunner.TabIndex = 12
        ' 
        ' tbAño
        ' 
        tbAño.Location = New Point(751, 242)
        tbAño.Name = "tbAño"
        tbAño.Size = New Size(125, 27)
        tbAño.TabIndex = 13
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1009, 473)
        Controls.Add(tbAño)
        Controls.Add(tbSpeedrunner)
        Controls.Add(tbSpeedrun)
        Controls.Add(tbestudio)
        Controls.Add(tbPlataforma)
        Controls.Add(tbTitulo)
        Controls.Add(btVolver)
        Controls.Add(btAñadir)
        Controls.Add(lbNombreSpeedrun)
        Controls.Add(lbSpeedrun)
        Controls.Add(lbAñoEstreno)
        Controls.Add(lbEstudio)
        Controls.Add(lbPlataforma)
        Controls.Add(lbTitulo)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbTitulo As Label
    Friend WithEvents lbPlataforma As Label
    Friend WithEvents lbEstudio As Label
    Friend WithEvents lbAñoEstreno As Label
    Friend WithEvents lbSpeedrun As Label
    Friend WithEvents lbNombreSpeedrun As Label
    Friend WithEvents btAñadir As Button
    Friend WithEvents btVolver As Button
    Friend WithEvents tbTitulo As TextBox
    Friend WithEvents tbPlataforma As TextBox
    Friend WithEvents tbestudio As TextBox
    Friend WithEvents tbSpeedrun As TextBox
    Friend WithEvents tbSpeedrunner As TextBox
    Friend WithEvents tbAño As TextBox
End Class
