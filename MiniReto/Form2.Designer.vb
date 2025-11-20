<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
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
        lbTituloPrincipal = New Label()
        SuspendLayout()
        '
        ' lbTitulo
        '
        lbTitulo.AutoSize = True
        lbTitulo.Font = New Font("Verdana", 10.8F)
        lbTitulo.Location = New Point(59, 118)
        lbTitulo.Margin = New Padding(4, 0, 4, 0)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.Size = New Size(68, 22)
        lbTitulo.TabIndex = 0
        lbTitulo.Text = "Titulo:"
        '
        ' lbPlataforma
        '
        lbPlataforma.AutoSize = True
        lbPlataforma.Font = New Font("Verdana", 10.8F)
        lbPlataforma.Location = New Point(59, 206)
        lbPlataforma.Margin = New Padding(4, 0, 4, 0)
        lbPlataforma.Name = "lbPlataforma"
        lbPlataforma.Size = New Size(117, 22)
        lbPlataforma.TabIndex = 1
        lbPlataforma.Text = "Plataforma:"
        '
        ' lbEstudio
        '
        lbEstudio.AutoSize = True
        lbEstudio.Font = New Font("Verdana", 10.8F)
        lbEstudio.Location = New Point(59, 305)
        lbEstudio.Margin = New Padding(4, 0, 4, 0)
        lbEstudio.Name = "lbEstudio"
        lbEstudio.Size = New Size(207, 22)
        lbEstudio.TabIndex = 2
        lbEstudio.Text = "Estudio de desarrollo:"
        '
        ' lbAñoEstreno
        '
        lbAñoEstreno.AutoSize = True
        lbAñoEstreno.Font = New Font("Verdana", 10.8F)
        lbAñoEstreno.Location = New Point(621, 294)
        lbAñoEstreno.Margin = New Padding(4, 0, 4, 0)
        lbAñoEstreno.Name = "lbAñoEstreno"
        lbAñoEstreno.Size = New Size(154, 22)
        lbAñoEstreno.TabIndex = 3
        lbAñoEstreno.Text = "Año de estreno:"
        '
        ' lbSpeedrun
        '
        lbSpeedrun.AutoSize = True
        lbSpeedrun.Font = New Font("Verdana", 10.8F)
        lbSpeedrun.Location = New Point(621, 117)
        lbSpeedrun.Margin = New Padding(4, 0, 4, 0)
        lbSpeedrun.Name = "lbSpeedrun"
        lbSpeedrun.Size = New Size(202, 22)
        lbSpeedrun.TabIndex = 4
        lbSpeedrun.Text = "Tiempo de speedrun:"
        '
        ' lbNombreSpeedrun
        '
        lbNombreSpeedrun.AutoSize = True
        lbNombreSpeedrun.Font = New Font("Verdana", 10.8F)
        lbNombreSpeedrun.Location = New Point(621, 205)
        lbNombreSpeedrun.Margin = New Padding(4, 0, 4, 0)
        lbNombreSpeedrun.Name = "lbNombreSpeedrun"
        lbNombreSpeedrun.Size = New Size(134, 22)
        lbNombreSpeedrun.TabIndex = 5
        lbNombreSpeedrun.Text = "Speedrunner:"
        '
        ' btAñadir
        ' 
        btAñadir.Location = New Point(243, 426)
        '
        btAñadir.Location = New Point(243, 426)
        btAñadir.Margin = New Padding(4, 3, 4, 3)
        btAñadir.Name = "btAñadir"
        btAñadir.Size = New Size(164, 81)
        btAñadir.TabIndex = 6
        btAñadir.Text = "AÑADIR"
        btAñadir.UseVisualStyleBackColor = True
        '
        ' btVolver
        ' 
        btVolver.Location = New Point(899, 415)
        btVolver.Margin = New Padding(4, 3, 4, 3)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(164, 81)
        btVolver.TabIndex = 7
        btVolver.Text = "VOLVER"
        btVolver.UseVisualStyleBackColor = True
        '
        ' tbTitulo
        ' 
        tbTitulo.Location = New Point(351, 114)
        tbTitulo.Margin = New Padding(4, 3, 4, 3)
        tbTitulo.Name = "tbTitulo"
        tbTitulo.Size = New Size(170, 29)
        tbTitulo.TabIndex = 8
        '
        ' tbPlataforma
        ' 
        tbPlataforma.Location = New Point(351, 206)
        tbPlataforma.Margin = New Padding(4, 3, 4, 3)
        tbPlataforma.Name = "tbPlataforma"
        tbPlataforma.Size = New Size(170, 29)
        tbPlataforma.TabIndex = 9
        '
        ' tbestudio
        ' 
        tbestudio.Location = New Point(351, 301)
        tbestudio.Margin = New Padding(4, 3, 4, 3)
        tbestudio.Name = "tbestudio"
        tbestudio.Size = New Size(170, 29)
        tbestudio.TabIndex = 10
        '
        ' tbSpeedrun
        ' 
        tbSpeedrun.Location = New Point(1031, 118)
        tbSpeedrun.Margin = New Padding(4, 3, 4, 3)
        tbSpeedrun.Name = "tbSpeedrun"
        tbSpeedrun.Size = New Size(170, 29)
        tbSpeedrun.TabIndex = 11
        '
        ' tbSpeedrunner
        ' 
        tbSpeedrunner.Location = New Point(1031, 202)
        tbSpeedrunner.Margin = New Padding(4, 3, 4, 3)
        tbSpeedrunner.Name = "tbSpeedrunner"
        tbSpeedrunner.Size = New Size(170, 29)
        tbSpeedrunner.TabIndex = 12
        '
        ' tbAño
        ' 
        tbAño.Location = New Point(1031, 296)
        tbAño.Margin = New Padding(4, 3, 4, 3)
        tbAño.Name = "tbAño"
        tbAño.Size = New Size(170, 29)
        tbAño.TabIndex = 13
        '
        ' lbTituloPrincipal
        '
        lbTituloPrincipal.AutoSize = True
        lbTituloPrincipal.Font = New Font("Reem Kufi", 18.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lbTituloPrincipal.Location = New Point(469, 10)
        lbTituloPrincipal.Margin = New Padding(4, 0, 4, 0)
        lbTituloPrincipal.Name = "lbTituloPrincipal"
        lbTituloPrincipal.Size = New Size(354, 54)
        lbTituloPrincipal.TabIndex = 14
        lbTituloPrincipal.Text = "AÑADIR VIDEOJUEGO"
        '
        ' Form2
        '
        AutoScaleDimensions = New SizeF(11.0F, 22.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1191, 557)
        Controls.Add(lbTituloPrincipal)
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
        Font = New Font("Verdana", 10.8F)
        Margin = New Padding(4, 3, 4, 3)
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
    Friend WithEvents lbTituloPrincipal As Label
End Class