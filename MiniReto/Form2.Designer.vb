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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
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
        lbTitulo.Font = New Font("Segoe UI", 12F)
        lbTitulo.Location = New Point(62, 122)
        lbTitulo.Margin = New Padding(4, 0, 4, 0)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.Size = New Size(66, 28)
        lbTitulo.TabIndex = 0
        lbTitulo.Text = "Titulo:"
        ' 
        ' lbPlataforma
        ' 
        lbPlataforma.AutoSize = True
        lbPlataforma.Font = New Font("Segoe UI", 12F)
        lbPlataforma.Location = New Point(62, 210)
        lbPlataforma.Margin = New Padding(4, 0, 4, 0)
        lbPlataforma.Name = "lbPlataforma"
        lbPlataforma.Size = New Size(111, 28)
        lbPlataforma.TabIndex = 1
        lbPlataforma.Text = "Plataforma:"
        ' 
        ' lbEstudio
        ' 
        lbEstudio.AutoSize = True
        lbEstudio.Font = New Font("Segoe UI", 12F)
        lbEstudio.Location = New Point(62, 309)
        lbEstudio.Margin = New Padding(4, 0, 4, 0)
        lbEstudio.Name = "lbEstudio"
        lbEstudio.Size = New Size(201, 28)
        lbEstudio.TabIndex = 2
        lbEstudio.Text = "Estudio de desarrollo:"
        ' 
        ' lbAñoEstreno
        ' 
        lbAñoEstreno.AutoSize = True
        lbAñoEstreno.Font = New Font("Segoe UI", 12F)
        lbAñoEstreno.Location = New Point(695, 319)
        lbAñoEstreno.Margin = New Padding(4, 0, 4, 0)
        lbAñoEstreno.Name = "lbAñoEstreno"
        lbAñoEstreno.Size = New Size(149, 28)
        lbAñoEstreno.TabIndex = 3
        lbAñoEstreno.Text = "Año de estreno:"
        ' 
        ' lbSpeedrun
        ' 
        lbSpeedrun.AutoSize = True
        lbSpeedrun.Font = New Font("Segoe UI", 12F)
        lbSpeedrun.Location = New Point(695, 142)
        lbSpeedrun.Margin = New Padding(4, 0, 4, 0)
        lbSpeedrun.Name = "lbSpeedrun"
        lbSpeedrun.Size = New Size(195, 28)
        lbSpeedrun.TabIndex = 4
        lbSpeedrun.Text = "Tiempo de speedrun:"
        ' 
        ' lbNombreSpeedrun
        ' 
        lbNombreSpeedrun.AutoSize = True
        lbNombreSpeedrun.Font = New Font("Segoe UI", 12F)
        lbNombreSpeedrun.Location = New Point(695, 230)
        lbNombreSpeedrun.Margin = New Padding(4, 0, 4, 0)
        lbNombreSpeedrun.Name = "lbNombreSpeedrun"
        lbNombreSpeedrun.Size = New Size(128, 28)
        lbNombreSpeedrun.TabIndex = 5
        lbNombreSpeedrun.Text = "Speedrunner:"
        ' 
        ' btAñadir
        ' 
        btAñadir.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btAñadir.Location = New Point(375, 412)
        btAñadir.Margin = New Padding(4, 3, 4, 3)
        btAñadir.Name = "btAñadir"
        btAñadir.Size = New Size(180, 60)
        btAñadir.TabIndex = 6
        btAñadir.Text = "AÑADIR"
        btAñadir.UseVisualStyleBackColor = True
        ' 
        ' btVolver
        ' 
        btVolver.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btVolver.Location = New Point(683, 412)
        btVolver.Margin = New Padding(4, 3, 4, 3)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(187, 60)
        btVolver.TabIndex = 7
        btVolver.Text = "VOLVER"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' tbTitulo
        ' 
        tbTitulo.Font = New Font("Segoe UI", 12F)
        tbTitulo.Location = New Point(299, 118)
        tbTitulo.Margin = New Padding(4, 3, 4, 3)
        tbTitulo.Name = "tbTitulo"
        tbTitulo.Size = New Size(170, 34)
        tbTitulo.TabIndex = 8
        ' 
        ' tbPlataforma
        ' 
        tbPlataforma.Font = New Font("Segoe UI", 12F)
        tbPlataforma.Location = New Point(299, 210)
        tbPlataforma.Margin = New Padding(4, 3, 4, 3)
        tbPlataforma.Name = "tbPlataforma"
        tbPlataforma.Size = New Size(170, 34)
        tbPlataforma.TabIndex = 9
        ' 
        ' tbestudio
        ' 
        tbestudio.Font = New Font("Segoe UI", 12F)
        tbestudio.Location = New Point(299, 305)
        tbestudio.Margin = New Padding(4, 3, 4, 3)
        tbestudio.Name = "tbestudio"
        tbestudio.Size = New Size(170, 34)
        tbestudio.TabIndex = 10
        ' 
        ' tbSpeedrun
        ' 
        tbSpeedrun.Font = New Font("Segoe UI", 12F)
        tbSpeedrun.Location = New Point(960, 142)
        tbSpeedrun.Margin = New Padding(4, 3, 4, 3)
        tbSpeedrun.Name = "tbSpeedrun"
        tbSpeedrun.Size = New Size(170, 34)
        tbSpeedrun.TabIndex = 11
        ' 
        ' tbSpeedrunner
        ' 
        tbSpeedrunner.Font = New Font("Segoe UI", 12F)
        tbSpeedrunner.Location = New Point(960, 226)
        tbSpeedrunner.Margin = New Padding(4, 3, 4, 3)
        tbSpeedrunner.Name = "tbSpeedrunner"
        tbSpeedrunner.Size = New Size(170, 34)
        tbSpeedrunner.TabIndex = 12
        ' 
        ' tbAño
        ' 
        tbAño.Font = New Font("Segoe UI", 12F)
        tbAño.Location = New Point(960, 320)
        tbAño.Margin = New Padding(4, 3, 4, 3)
        tbAño.Name = "tbAño"
        tbAño.Size = New Size(170, 34)
        tbAño.TabIndex = 13
        ' 
        ' lbTituloPrincipal
        ' 
        lbTituloPrincipal.AutoSize = True
        lbTituloPrincipal.Font = New Font("Reem Kufi", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTituloPrincipal.Location = New Point(458, 25)
        lbTituloPrincipal.Margin = New Padding(4, 0, 4, 0)
        lbTituloPrincipal.Name = "lbTituloPrincipal"
        lbTituloPrincipal.Size = New Size(354, 54)
        lbTituloPrincipal.TabIndex = 14
        lbTituloPrincipal.Text = "AÑADIR VIDEOJUEGO"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(11F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1241, 520)
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
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form2"
        Text = "AÑADIR VIDEOJUEGO"
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
